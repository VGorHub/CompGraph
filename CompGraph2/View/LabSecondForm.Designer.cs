
namespace CompGraph.View
{
    partial class LabSecondForm
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
            this.labSecond1 = new CompGraph.View.LabSecond();
            this.SuspendLayout();
            // 
            // labSecond1
            // 
            this.labSecond1.Location = new System.Drawing.Point(1, 1);
            this.labSecond1.Name = "labSecond1";
            this.labSecond1.Size = new System.Drawing.Size(738, 533);
            this.labSecond1.TabIndex = 0;
            // 
            // LabSecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 535);
            this.Controls.Add(this.labSecond1);
            this.Name = "LabSecondForm";
            this.Text = "LabSecondForm";
            this.ResumeLayout(false);

        }

        #endregion

        private LabSecond labSecond1;
    }
}