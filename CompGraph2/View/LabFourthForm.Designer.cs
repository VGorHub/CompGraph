﻿namespace CompGraph.View
{
    partial class LabFourthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_LabFourth = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this._41 = new CompGraph.View._4();
            this.stepa41 = new CompGraph.View.stepa4();
            this.tabControl_LabFourth.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_LabFourth
            // 
            this.tabControl_LabFourth.Controls.Add(this.tabPage1);
            this.tabControl_LabFourth.Controls.Add(this.tabPage2);
            this.tabControl_LabFourth.Controls.Add(this.tabPage3);
            this.tabControl_LabFourth.Controls.Add(this.tabPage4);
            this.tabControl_LabFourth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_LabFourth.Location = new System.Drawing.Point(0, 0);
            this.tabControl_LabFourth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl_LabFourth.Name = "tabControl_LabFourth";
            this.tabControl_LabFourth.SelectedIndex = 0;
            this.tabControl_LabFourth.Size = new System.Drawing.Size(1365, 970);
            this.tabControl_LabFourth.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.stepa41);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1357, 941);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stepa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1357, 941);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grisha";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1357, 941);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vova";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this._41);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1357, 941);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Anton";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // _41
            // 
            this._41.Dock = System.Windows.Forms.DockStyle.Fill;
            this._41.Location = new System.Drawing.Point(0, 0);
            this._41.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._41.Name = "_41";
            this._41.Size = new System.Drawing.Size(1357, 941);
            this._41.TabIndex = 0;
            // 
            // stepa41
            // 
            this.stepa41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepa41.Location = new System.Drawing.Point(4, 4);
            this.stepa41.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stepa41.Name = "stepa41";
            this.stepa41.Size = new System.Drawing.Size(1349, 933);
            this.stepa41.TabIndex = 0;
            this.stepa41.Load += new System.EventHandler(this.stepa41_Load);
            // 
            // LabFourthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 970);
            this.Controls.Add(this.tabControl_LabFourth);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LabFourthForm";
            this.Text = "LabFourthForm";
            this.tabControl_LabFourth.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_LabFourth;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
		private _4 _41;
        private System.Windows.Forms.TabPage tabPage1;
        private stepa4 stepa41;
    }
}