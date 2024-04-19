namespace CompGraph.View
{
    partial class LabThirdForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.vGor31 = new CompGraph.View.VGor3();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labThird_10 = new CompGraph.View.LabThird_10();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(828, 656);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(820, 630);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stepa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(820, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grisha";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.vGor31);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(820, 630);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vova";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // vGor31
            // 
            this.vGor31.Location = new System.Drawing.Point(6, 3);
            this.vGor31.Name = "vGor31";
            this.vGor31.Size = new System.Drawing.Size(816, 584);
            this.vGor31.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labThird_10);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(820, 630);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Anton";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labThird_10
            // 
            this.labThird_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labThird_10.Location = new System.Drawing.Point(3, 3);
            this.labThird_10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labThird_10.Name = "labThird_10";
            this.labThird_10.Size = new System.Drawing.Size(822, 624);
            this.labThird_10.TabIndex = 0;
            // 
            // LabThirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 659);
            this.Controls.Add(this.tabControl1);
            this.Name = "LabThirdForm";
            this.Text = "LabThirdForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private LabThird_10 labThird_10;
        private Grisha_3Laba_Tab grisha_3Laba_Tab1;
        private Lab3Stepa lab3Stepa1;
        private VGor3 vGor31;
    }
}