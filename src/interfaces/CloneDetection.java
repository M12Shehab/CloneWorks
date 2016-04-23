package interfaces;

import java.io.IOException;
import java.nio.file.Path;
import java.nio.file.Paths;

import org.apache.commons.cli.CommandLine;
import org.apache.commons.cli.CommandLineParser;
import org.apache.commons.cli.DefaultParser;
import org.apache.commons.cli.HelpFormatter;
import org.apache.commons.cli.Option;
import org.apache.commons.cli.Options;

import detection.requirements.Requirements;
import detection.requirements.SizeRequirements;

public class CloneDetection {
	
	private static Options options;
	private static HelpFormatter formatter;
	
	public static void main(String args[]) throws IOException {
		options = new Options();
		
		
		// Input Block File
		options.addOption(Option.builder("i")
								.hasArg()
								.argName("file")
				                .longOpt("input")
				                .required()
				                .desc("File containing blocks produced by thrifty-builder.")
				                .build()
		);
		
		// Output Clone File
		options.addOption(Option.builder("o")
								.hasArg()
								.argName("file")
				                .longOpt("output")
				                .required()
				                .desc("File to output clones to.")
				                .build()
		);
		
		// Minimum Similarity
		options.addOption(Option.builder("s")
								.hasArg()
				                .longOpt("min-similarity")
				                .required()
				                .argName("ratio")
				                .desc("Minimum clone similarity.")
				                .build()
		);
		
		// Partition
		options.addOption(Option.builder("p")
								.longOpt("partition-mode")
								.desc("Run using index-partitioning mode with the specified maximum partition size in code blocks." + 
		                            "\nUse when index size exhausts available memory.")
								.hasArg()
								.argName("num")
								.build()
		);
		
		// Number of Threads
		options.addOption(Option.builder("t")
								.hasArg()
								.argName("num")
				                .longOpt("num-threads")
				                .desc("Number of execution threads to use per task.  Defaults to number of cores.")
				                .build()
		);
		
		// Minimum Clone Size - Original Lines		
		options.addOption(Option.builder("mil")
				                .longOpt("min-lines")
				                .hasArg()
				                .argName("num")
				                .desc("Minimum clone size in (original) source lines.")
				                .build()
		);
		
		// Maximum Clone Size - Original Lines
		options.addOption(Option.builder("mal")
				                .longOpt("max-lines")
				                .hasArg()
				                .argName("num")
				                .desc("Maximum clone size in (original) source lines.")
				                .build()
		);
		
		// Minimum Tokens - Original Tokens
		options.addOption(Option.builder("mit")
				                .longOpt("min-tokens")
				                .hasArg()
				                .argName("num")
				                .desc("Minimum clone size in (original, pre-processing) parsed tokens.")
				                .build()
		);
		
		// Maximum Tokens - Original Tokens
		options.addOption(Option.builder("mat")
				                .longOpt("max-tokens")
				                .hasArg()
				                .argName("num")
				                .desc("Maximum clone size in (original, pre-processing) parsed tokens.")
				                .build()
		);
		
		// Pre-Sorted
		options.addOption(Option.builder("ps")
				                .longOpt("pre-sorted")
				                .desc("Indicates input blocks are pre-sorted, and GTF-sorting should be skipped."
				                  + "\nThis makes clone detection with pre-sorted blocks more efficient.  If the"
				                  + "\nblocks are not pre-sorted, or are sorted incorrectly, this can cause false"
				                  + "\nnegatives.  Skipping sorting on pre-sorted blocks can improve performance.")
				                .build()
		);
		
		Path input;
		Path output;
		boolean partition_mode = false;
		int max_partition_size = -1;
		double minsim;
		int num_threads = Runtime.getRuntime().availableProcessors();
		int min_size_lines  = 0;
		int max_size_lines  = 0;
		int min_size_tokens = 0;
		int max_size_tokens = 0;
		boolean pre_sorted = false;
		
		formatter = new HelpFormatter();
		formatter.setOptionComparator(null);	
		CommandLineParser parser = new DefaultParser();
	
		CommandLine line;
		try {
			line = parser.parse(options, args);
		} catch (Exception e) {
			panic();
			return;
		}
		
		// Input Path
		try {
			input = Paths.get(line.getOptionValue("i"));
		} catch(Exception e) {
			System.out.println("ERROR: Invalid input path.");
			System.out.println("");
			panic();
			return;
		}

		// Output Path
		try {
			output = Paths.get(line.getOptionValue("o"));
		} catch(Exception e) {
			System.out.println("ERROR: Invalid output path.");
			System.out.println("");
			panic();
			return;
		}
		
		// Minimum Similarity
		try {
			minsim = Double.parseDouble(line.getOptionValue("s"));
			if (minsim < 0 || minsim > 1)
				throw new IllegalArgumentException("");
		} catch (Exception e) {
			System.out.println("ERROR: Invalid minimum similarity.  Must be ratio in range [0.0,1.0].");
			System.out.println("");
			panic();
			return;
		}

		// Partition-Mode
		if(line.hasOption("p")) {
			partition_mode = true;
			try {
				max_partition_size = Integer.parseInt(line.getOptionValue("p"));
				if(max_partition_size < 1)
					throw new IllegalArgumentException("");
			} catch (Exception e) {
				System.out.println("ERROR: Partition size must be an integer > 0.");
				System.out.println("");
				panic();
				return;
			}
		}
		
		// Num Threads
		if(line.hasOption("t")) {
			try {
				num_threads = Integer.parseInt(line.getOptionValue("t"));
				if(num_threads < 1)
					throw new IllegalArgumentException("");
			} catch(Exception e) {
				System.out.println("ERROR: Number of threads must be an integer >= 1.");
				System.out.println("");
				panic();
				return;
			}
		}
		
		// Min-Lines (mil)
		if(line.hasOption("mil")) {
			try {
				min_size_lines = Integer.parseInt(line.getOptionValue("mil"));
				if(min_size_lines < 0)
					throw new IllegalArgumentException("");
			} catch (Exception e) {
				System.out.println("ERROR: Minimum lines must be an integer >= 0.");
				System.out.println("");
				panic();
				return;
			}
		}
		
		
		// Max-Lines (mal)
		if(line.hasOption("mal")) {
			try {
				max_size_lines = Integer.parseInt(line.getOptionValue("mal"));
				if(max_size_lines < 0)
					throw new IllegalArgumentException("");
			} catch (Exception e) {
				System.out.println("ERROR: Maximum lines must be an integer >= 0.");
				System.out.println("");
				panic();
				return;
			}
		}
		
		// Min-Tokens (mit)
		if(line.hasOption("mit")) {
			try {
				min_size_tokens = Integer.parseInt(line.getOptionValue("mit"));
				if(min_size_tokens < 0)
					throw new IllegalArgumentException("");
			} catch (Exception e) {
				System.out.println("ERROR: Minimum tokens must be an integer >= 0.");
				System.out.println("");
				panic();
				return;
			}
		}
		
		// Max-Tokens (mat)
		if(line.hasOption("mat")) {
			try {
				max_size_tokens = Integer.parseInt(line.getOptionValue("mat"));
				if(max_size_tokens < 0)
					throw new IllegalArgumentException("");
			} catch (Exception e) {
				System.out.println("ERROR: Maximum tokens must be an integer >= 0.");
				System.out.println("");
				panic();
				return;
			}
		}
		
		if(max_size_tokens < min_size_tokens) {
			System.out.println("ERROR: Maximum tokens muust be greater or equal to minimum tokens.");
			System.out.println("");
			panic();
			return;
		}
		if(max_size_lines < min_size_lines) {
			System.out.println("ERROR: Maximum lines muust be greater or equal to minimum lines.");
			System.out.println("");
			panic();
			return;
		}
		
		// Pre-Sorted
		if(line.hasOption("ps"))
			pre_sorted = true;
		
		Requirements requirements = new SizeRequirements(min_size_lines, max_size_lines, min_size_tokens, max_size_tokens);
		
		if(pre_sorted && partition_mode) {
			detection.logic.SelfPartitionedCloneDetectionPreSorted.detect(input, output, requirements, minsim, max_partition_size, num_threads);
		} else if (pre_sorted && !partition_mode) {
			detection.logic.SelfCloneDetectionPreSorted.detect(input, output, requirements, minsim, num_threads);
		} else if (!pre_sorted && partition_mode) {
			detection.logic.SelfPartitionedCloneDetection.detect(input, output, requirements, minsim, max_partition_size, num_threads);
		} else { //(!pre-sorted && !partition_mode)
			detection.logic.SelfCloneDetection.detect(input, output, requirements, minsim, num_threads);
		}
	}
	
	private static void panic() {
		formatter.printHelp(200, "thriftyd", "Clone detection with ThriftyClone.", options, "", true);
		System.exit(-1);
		return;
	}
	
}