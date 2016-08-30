//
// Progress.Designer.cs
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

namespace MonoOBSFramework.Engine
{
partial class Progress
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
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        this.BtnOpenDestDir = new System.Windows.Forms.Button();
        this.TxtDestDir = new System.Windows.Forms.TextBox();
        this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        this.LblKoS = new System.Windows.Forms.Label();
        this.progressBar1 = new System.Windows.Forms.ProgressBar();
        this.timer1 = new System.Windows.Forms.Timer(this.components);
        this.tableLayoutPanel1.SuspendLayout();
        this.tableLayoutPanel2.SuspendLayout();
        this.tableLayoutPanel3.SuspendLayout();
        this.SuspendLayout();
        //
        // tableLayoutPanel1
        //
        this.tableLayoutPanel1.ColumnCount = 1;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 2;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 103);
        this.tableLayoutPanel1.TabIndex = 0;
        //
        // tableLayoutPanel2
        //
        this.tableLayoutPanel2.ColumnCount = 2;
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        this.tableLayoutPanel2.Controls.Add(this.BtnOpenDestDir, 1, 0);
        this.tableLayoutPanel2.Controls.Add(this.TxtDestDir, 0, 0);
        this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
        this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        this.tableLayoutPanel2.RowCount = 1;
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel2.Size = new System.Drawing.Size(322, 44);
        this.tableLayoutPanel2.TabIndex = 0;
        //
        // BtnOpenDestDir
        //
        this.BtnOpenDestDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.BtnOpenDestDir.Location = new System.Drawing.Point(285, 17);
        this.BtnOpenDestDir.Name = "BtnOpenDestDir";
        this.BtnOpenDestDir.Size = new System.Drawing.Size(34, 24);
        this.BtnOpenDestDir.TabIndex = 0;
        this.BtnOpenDestDir.Text = "...";
        this.BtnOpenDestDir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        this.BtnOpenDestDir.UseVisualStyleBackColor = true;
        this.BtnOpenDestDir.Click += new System.EventHandler(this.BtnOpenDestDir_Click);
        //
        // TxtDestDir
        //
        this.TxtDestDir.Dock = System.Windows.Forms.DockStyle.Fill;
        this.TxtDestDir.Location = new System.Drawing.Point(3, 3);
        this.TxtDestDir.Multiline = true;
        this.TxtDestDir.Name = "TxtDestDir";
        this.TxtDestDir.ReadOnly = true;
        this.TxtDestDir.Size = new System.Drawing.Size(276, 38);
        this.TxtDestDir.TabIndex = 1;
        //
        // tableLayoutPanel3
        //
        this.tableLayoutPanel3.ColumnCount = 1;
        this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel3.Controls.Add(this.LblKoS, 0, 1);
        this.tableLayoutPanel3.Controls.Add(this.progressBar1, 0, 0);
        this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 53);
        this.tableLayoutPanel3.Name = "tableLayoutPanel3";
        this.tableLayoutPanel3.RowCount = 2;
        this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
        this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
        this.tableLayoutPanel3.Size = new System.Drawing.Size(322, 47);
        this.tableLayoutPanel3.TabIndex = 1;
        //
        // LblKoS
        //
        this.LblKoS.AutoSize = true;
        this.LblKoS.Dock = System.Windows.Forms.DockStyle.Fill;
        this.LblKoS.Location = new System.Drawing.Point(3, 31);
        this.LblKoS.Name = "LblKoS";
        this.LblKoS.Size = new System.Drawing.Size(316, 19);
        this.LblKoS.TabIndex = 0;
        this.LblKoS.Text = "Ko/s";
        this.LblKoS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // progressBar1
        //
        this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.progressBar1.Location = new System.Drawing.Point(3, 3);
        this.progressBar1.Name = "progressBar1";
        this.progressBar1.Size = new System.Drawing.Size(316, 25);
        this.progressBar1.TabIndex = 1;
        //
        // timer1
        //
        this.timer1.Enabled = true;
        this.timer1.Interval = 1000;
        this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        //
        // Progress
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(328, 103);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Name = "Progress";
        this.Text = "Progress";
        this.TopMost = true;
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel2.ResumeLayout(false);
        this.tableLayoutPanel2.PerformLayout();
        this.tableLayoutPanel3.ResumeLayout(false);
        this.tableLayoutPanel3.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button BtnOpenDestDir;
    private System.Windows.Forms.TextBox TxtDestDir;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Label LblKoS;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Timer timer1;
}
}
