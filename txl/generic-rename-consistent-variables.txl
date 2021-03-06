% Generic consistent renaming for potential clones
% Jim Cordy, May 2010

define xml_source_coordinate
    '< [SPOFF] 'source [SP] 'file=[stringlit] [SP] 'startline=[stringlit] [SP] 'endline=[stringlit] '> [SPON] [NL]
end define

define end_xml_source_coordinate
    [NL] '< [SPOFF] '/ 'source '> [SPON] [NL]
end define

define source_unit  
    [xml_source_coordinate]
        [potential_clone]
    [end_xml_source_coordinate]
end define

redefine program
    [repeat source_unit]
end redefine

% Main program

rule main
    skipping [source_unit]
    replace $ [source_unit]
	BeginXML [xml_source_coordinate]
	    PC [potential_clone]
	EndXML [end_xml_source_coordinate]
    by
	BeginXML 
	    PC [renameIds]
	EndXML 
end rule

% Rule to normalize using consistent renaming of identifiers
% to normal form (x1, x2, x3, ...)

function renameIds
    replace [potential_clone]
        PC [potential_clone]

    % Make a list of all of the unique identifiers 
    construct Ids [repeat declared_name]
        _ [^ PC] [removeDuplicateIds]

    % Make normalized new names of the form xN for each of them
    construct GenIds [repeat declared_name]
        Ids [genIds 0]

    % Consistently replace each instance of each one by its normalized form
    by
        PC [$ each Ids GenIds]
end function

% Utility rule - remove duplicate ids from a list

function removeDuplicateIds
    replace [repeat declared_name]
        Id [declared_name] 
	Rest [repeat declared_name]
    by
	Id
        Rest [removeIds Id]
	     [removeDuplicateIds]
end function

rule removeIds Id [declared_name]
    replace [repeat declared_name]
        Id
	More [repeat declared_name]
    by
        More
end rule

% Utility rule - make a normalized id of the form xN for each unique id in a list

function genIds NM1 [number]
    % For each id in the list
    replace [repeat declared_name]
        _ [declared_name] 
        Rest [repeat declared_name] 

    % Generate the next xN id
    construct N [number]
        NM1 [+ 1]
    construct GenId [declared_name]
        _ [+ 'x] [+ N]

    % Replace the id with the generated one
    % and recursively do the next one
    by
        GenId 
        Rest [genIds N]
end function

