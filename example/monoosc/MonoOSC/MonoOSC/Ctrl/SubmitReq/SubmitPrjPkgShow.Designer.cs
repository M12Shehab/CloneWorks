//
// SubmitPrjPkgShow.Designer.cs
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

namespace MonoOSC.Ctrl.SubmitReq
{
partial class SubmitPrjPkgShow
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

    #region Code généré par le Concepteur de composants

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
        this.TxtLogID = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.BtnShowLog = new System.Windows.Forms.Button();
        this.CmbxPkg = new System.Windows.Forms.ComboBox();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.ChkBxDiff = new System.Windows.Forms.CheckBox();
        this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        this.groupBox1.SuspendLayout();
        this.SuspendLayout();
        //
        // TxtLogID
        //
        this.TxtLogID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        this.TxtLogID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
        this.TxtLogID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        this.TxtLogID.Location = new System.Drawing.Point(30, 14);
        this.TxtLogID.Name = "TxtLogID";
        this.TxtLogID.Size = new System.Drawing.Size(108, 23);
        this.TxtLogID.TabIndex = 9;
        //
        // label3
        //
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(6, 19);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(18, 13);
        this.label3.TabIndex = 8;
        this.label3.Text = "ID";
        //
        // BtnShowLog
        //
        this.BtnShowLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        this.BtnShowLog.Location = new System.Drawing.Point(6, 46);
        this.BtnShowLog.Name = "BtnShowLog";
        this.BtnShowLog.Size = new System.Drawing.Size(59, 23);
        this.BtnShowLog.TabIndex = 11;
        this.BtnShowLog.Text = "Show !";
        this.BtnShowLog.UseVisualStyleBackColor = true;
        this.BtnShowLog.Click += new System.EventHandler(this.BtnShowLog_Click);
        //
        // CmbxPkg
        //
        this.CmbxPkg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        this.CmbxPkg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
        this.CmbxPkg.FormattingEnabled = true;
        this.CmbxPkg.Items.AddRange(new object[]
        {
            "new",
            "deleted",
            "revoked",
            "declined",
            "accepted"
        });
        this.CmbxPkg.Location = new System.Drawing.Point(144, 16);
        this.CmbxPkg.MaxDropDownItems = 20;
        this.CmbxPkg.Name = "CmbxPkg";
        this.CmbxPkg.Size = new System.Drawing.Size(138, 21);
        this.CmbxPkg.TabIndex = 10;
        this.CmbxPkg.Text = "new";
        this.CmbxPkg.Visible = false;
        //
        // groupBox1
        //
        this.groupBox1.Controls.Add(this.ChkBxDiff);
        this.groupBox1.Controls.Add(this.TxtLogID);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.BtnShowLog);
        this.groupBox1.Controls.Add(this.CmbxPkg);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox1.Location = new System.Drawing.Point(0, 0);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(319, 93);
        this.groupBox1.TabIndex = 15;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Show";
        //
        // ChkBxDiff
        //
        this.ChkBxDiff.AutoSize = true;
        this.ChkBxDiff.Location = new System.Drawing.Point(96, 50);
        this.ChkBxDiff.Name = "ChkBxDiff";
        this.ChkBxDiff.Size = new System.Drawing.Size(42, 17);
        this.ChkBxDiff.TabIndex = 12;
        this.ChkBxDiff.Text = "Diff";
        this.ChkBxDiff.UseVisualStyleBackColor = true;
        //
        // backgroundWorker1
        //
        this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
        this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
        //
        // SubmitPrjPkgShow
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.groupBox1);
        this.Name = "SubmitPrjPkgShow";
        this.Size = new System.Drawing.Size(319, 93);
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox TxtLogID;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button BtnShowLog;
    private System.Windows.Forms.ComboBox CmbxPkg;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.CheckBox ChkBxDiff;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
}
}
