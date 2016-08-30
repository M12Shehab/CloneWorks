//
// Log.Designer.cs
//
// Author:
//       Surfzoid <surfzoid@gmail.com>
//
// Copyright (c) 2009 Surfzoid
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace MonoOSC
{
partial class Log
{
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
        this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
        this.SearchBar = new System.Windows.Forms.ToolStrip();
        this.BtnSearch = new System.Windows.Forms.ToolStripButton();
        this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
        this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
        this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
        this.StatusLblPos = new System.Windows.Forms.ToolStripStatusLabel();
        this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        this.richTextBox2 = new System.Windows.Forms.RichTextBox();
        this.richTextBox1 = new System.Windows.Forms.RichTextBox();
        this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
        this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
        this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.AutoSrcollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.autoRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.searchNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.lineNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
        this.toolStripContainer1.ContentPanel.SuspendLayout();
        this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
        this.toolStripContainer1.SuspendLayout();
        this.SearchBar.SuspendLayout();
        this.splitContainer1.Panel1.SuspendLayout();
        this.splitContainer1.Panel2.SuspendLayout();
        this.splitContainer1.SuspendLayout();
        this.contextMenuStrip1.SuspendLayout();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();
        //
        // toolStripContainer1
        //
        //
        // toolStripContainer1.BottomToolStripPanel
        //
        this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.SearchBar);
        //
        // toolStripContainer1.ContentPanel
        //
        this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
        this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(804, 378);
        this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
        this.toolStripContainer1.Name = "toolStripContainer1";
        this.toolStripContainer1.Size = new System.Drawing.Size(804, 427);
        this.toolStripContainer1.TabIndex = 2;
        this.toolStripContainer1.Text = "toolStripContainer1";
        //
        // toolStripContainer1.TopToolStripPanel
        //
        this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
        //
        // SearchBar
        //
        this.SearchBar.Dock = System.Windows.Forms.DockStyle.None;
        this.SearchBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.BtnSearch,
            this.toolStripTextBox1,
            this.toolStripLabel2,
            this.toolStripComboBox1,
            this.StatusLblPos
        });
        this.SearchBar.Location = new System.Drawing.Point(5, 0);
        this.SearchBar.Name = "SearchBar";
        this.SearchBar.Size = new System.Drawing.Size(372, 25);
        this.SearchBar.TabIndex = 1;
        //
        // BtnSearch
        //
        this.BtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
        this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
        this.BtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.BtnSearch.Name = "BtnSearch";
        this.BtnSearch.Size = new System.Drawing.Size(44, 22);
        this.BtnSearch.Text = "Search";
        this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
        //
        // toolStripTextBox1
        //
        this.toolStripTextBox1.Name = "toolStripTextBox1";
        this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
        this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox2_TextChanged);
        //
        // toolStripLabel2
        //
        this.toolStripLabel2.Name = "toolStripLabel2";
        this.toolStripLabel2.Size = new System.Drawing.Size(51, 22);
        this.toolStripLabel2.Text = "Options :";
        //
        // toolStripComboBox1
        //
        this.toolStripComboBox1.Items.AddRange(new object[]
        {
            System.Windows.Forms.RichTextBoxFinds.MatchCase,
            System.Windows.Forms.RichTextBoxFinds.NoHighlight,
            System.Windows.Forms.RichTextBoxFinds.None,
            System.Windows.Forms.RichTextBoxFinds.Reverse,
            System.Windows.Forms.RichTextBoxFinds.WholeWord
        });
        this.toolStripComboBox1.Name = "toolStripComboBox1";
        this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
        //
        // StatusLblPos
        //
        this.StatusLblPos.AutoToolTip = true;
        this.StatusLblPos.Name = "StatusLblPos";
        this.StatusLblPos.Size = new System.Drawing.Size(42, 20);
        this.StatusLblPos.Text = "Line : 0";
        this.StatusLblPos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        //
        // splitContainer1
        //
        this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
        this.splitContainer1.IsSplitterFixed = true;
        this.splitContainer1.Location = new System.Drawing.Point(0, 0);
        this.splitContainer1.Name = "splitContainer1";
        //
        // splitContainer1.Panel1
        //
        this.splitContainer1.Panel1.Controls.Add(this.richTextBox2);
        //
        // splitContainer1.Panel2
        //
        this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
        this.splitContainer1.Size = new System.Drawing.Size(804, 378);
        this.splitContainer1.SplitterDistance = 32;
        this.splitContainer1.SplitterWidth = 1;
        this.splitContainer1.TabIndex = 4;
        this.splitContainer1.TabStop = false;
        //
        // richTextBox2
        //
        this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        this.richTextBox2.Location = new System.Drawing.Point(0, 0);
        this.richTextBox2.Name = "richTextBox2";
        this.richTextBox2.ReadOnly = true;
        this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
        this.richTextBox2.Size = new System.Drawing.Size(32, 378);
        this.richTextBox2.TabIndex = 0;
        this.richTextBox2.Text = "";
        this.richTextBox2.Visible = false;
        this.richTextBox2.WordWrap = false;
        //
        // richTextBox1
        //
        this.richTextBox1.AcceptsTab = true;
        this.richTextBox1.AutoWordSelection = true;
        this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
        this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.richTextBox1.EnableAutoDragDrop = true;
        this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        this.richTextBox1.ForeColor = System.Drawing.Color.DarkBlue;
        this.richTextBox1.HideSelection = false;
        this.richTextBox1.Location = new System.Drawing.Point(0, 0);
        this.richTextBox1.Name = "richTextBox1";
        this.richTextBox1.ReadOnly = true;
        this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
        this.richTextBox1.ShowSelectionMargin = true;
        this.richTextBox1.Size = new System.Drawing.Size(771, 378);
        this.richTextBox1.TabIndex = 0;
        this.richTextBox1.Text = "Try to fetch the log file.................";
        this.richTextBox1.WordWrap = false;
        this.richTextBox1.VScroll += new System.EventHandler(this.richTextBox1_VScroll);
        this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
        this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
        this.richTextBox1.Resize += new System.EventHandler(this.richTextBox1_Resize);
        this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
        //
        // contextMenuStrip1
        //
        this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.toolStripMenuItem3,
            this.toolStripSeparator8,
            this.toolStripMenuItem7
        });
        this.contextMenuStrip1.Name = "contextMenuStrip1";
        this.contextMenuStrip1.Size = new System.Drawing.Size(167, 54);
        //
        // toolStripMenuItem3
        //
        this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
        this.toolStripMenuItem3.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.toolStripMenuItem3.Name = "toolStripMenuItem3";
        this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
        this.toolStripMenuItem3.Size = new System.Drawing.Size(166, 22);
        this.toolStripMenuItem3.Text = "Co&py";
        this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
        //
        // toolStripSeparator8
        //
        this.toolStripSeparator8.Name = "toolStripSeparator8";
        this.toolStripSeparator8.Size = new System.Drawing.Size(163, 6);
        //
        // toolStripMenuItem7
        //
        this.toolStripMenuItem7.Name = "toolStripMenuItem7";
        this.toolStripMenuItem7.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
        this.toolStripMenuItem7.Size = new System.Drawing.Size(166, 22);
        this.toolStripMenuItem7.Text = "Sel&ect all";
        this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
        //
        // menuStrip1
        //
        this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.displayToolStripMenuItem
        });
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(804, 24);
        this.menuStrip1.TabIndex = 1;
        this.menuStrip1.Text = "menuStrip1";
        //
        // optionsToolStripMenuItem
        //
        this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.alwaysOnTopToolStripMenuItem,
            this.AutoSrcollToolStripMenuItem,
            this.autoRefreshToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.searchNextToolStripMenuItem,
            this.wordWrapToolStripMenuItem
        });
        this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
        this.optionsToolStripMenuItem.Text = "Options";
        //
        // alwaysOnTopToolStripMenuItem
        //
        this.alwaysOnTopToolStripMenuItem.Checked = true;
        this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
        this.alwaysOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
        this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
        this.alwaysOnTopToolStripMenuItem.Text = "Always on top";
        this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
        //
        // AutoSrcollToolStripMenuItem
        //
        this.AutoSrcollToolStripMenuItem.Checked = true;
        this.AutoSrcollToolStripMenuItem.CheckOnClick = true;
        this.AutoSrcollToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        this.AutoSrcollToolStripMenuItem.Name = "AutoSrcollToolStripMenuItem";
        this.AutoSrcollToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
        this.AutoSrcollToolStripMenuItem.Text = "Autoscroll";
        //
        // autoRefreshToolStripMenuItem
        //
        this.autoRefreshToolStripMenuItem.Checked = true;
        this.autoRefreshToolStripMenuItem.CheckOnClick = true;
        this.autoRefreshToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        this.autoRefreshToolStripMenuItem.Name = "autoRefreshToolStripMenuItem";
        this.autoRefreshToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
        this.autoRefreshToolStripMenuItem.Text = "AutoRefresh";
        this.autoRefreshToolStripMenuItem.Click += new System.EventHandler(this.autorefreshToolStripMenuItem_Click);
        //
        // refreshToolStripMenuItem
        //
        this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
        this.refreshToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
        this.refreshToolStripMenuItem.Text = "Refresh";
        this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
        //
        // searchNextToolStripMenuItem
        //
        this.searchNextToolStripMenuItem.Name = "searchNextToolStripMenuItem";
        this.searchNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
        this.searchNextToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
        this.searchNextToolStripMenuItem.Text = "Search Next";
        this.searchNextToolStripMenuItem.Visible = false;
        this.searchNextToolStripMenuItem.Click += new System.EventHandler(this.searchNextToolStripMenuItem_Click);
        //
        // wordWrapToolStripMenuItem
        //
        this.wordWrapToolStripMenuItem.CheckOnClick = true;
        this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
        this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
        this.wordWrapToolStripMenuItem.Text = "WordWrap";
        this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
        //
        // toolStripMenuItem1
        //
        this.toolStripMenuItem1.AutoToolTip = true;
        this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        this.toolStripMenuItem1.Checked = true;
        this.toolStripMenuItem1.CheckOnClick = true;
        this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
        this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
        this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Lime;
        this.toolStripMenuItem1.Name = "toolStripMenuItem1";
        this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
        this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
        this.toolStripMenuItem1.Text = "Search";
        this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
        //
        // backgroundWorker1
        //
        this.backgroundWorker1.WorkerSupportsCancellation = true;
        this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
        this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1RunWorkerCompleted);
        //
        // displayToolStripMenuItem
        //
        this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.lineNumberToolStripMenuItem
        });
        this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
        this.displayToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
        this.displayToolStripMenuItem.Text = "Display";
        //
        // lineNumberToolStripMenuItem
        //
        this.lineNumberToolStripMenuItem.CheckOnClick = true;
        this.lineNumberToolStripMenuItem.Name = "lineNumberToolStripMenuItem";
        this.lineNumberToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.lineNumberToolStripMenuItem.Text = "Line number";
        this.lineNumberToolStripMenuItem.Click += new System.EventHandler(this.lineNumberToolStripMenuItem_Click);
        //
        // Log
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(804, 427);
        this.Controls.Add(this.toolStripContainer1);
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "Log";
        this.Text = "Log";
        this.TopMost = true;
        this.Shown += new System.EventHandler(this.Log_Shown);
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Log_FormClosed);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_FormClosing);
        this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
        this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
        this.toolStripContainer1.ContentPanel.ResumeLayout(false);
        this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
        this.toolStripContainer1.TopToolStripPanel.PerformLayout();
        this.toolStripContainer1.ResumeLayout(false);
        this.toolStripContainer1.PerformLayout();
        this.SearchBar.ResumeLayout(false);
        this.SearchBar.PerformLayout();
        this.splitContainer1.Panel1.ResumeLayout(false);
        this.splitContainer1.Panel2.ResumeLayout(false);
        this.splitContainer1.ResumeLayout(false);
        this.contextMenuStrip1.ResumeLayout(false);
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem AutoSrcollToolStripMenuItem;
    private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.ToolStripMenuItem autoRefreshToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStrip SearchBar;
    private System.Windows.Forms.ToolStripButton BtnSearch;
    private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
    private System.Windows.Forms.ToolStripMenuItem searchNextToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.RichTextBox richTextBox2;
    private System.Windows.Forms.ToolStripStatusLabel StatusLblPos;
    private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem lineNumberToolStripMenuItem;
}
}
