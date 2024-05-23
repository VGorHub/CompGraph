
using System.Drawing;
using System.Windows.Forms;

namespace CompGraph.View
{
    partial class Lab4_Vova
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonZdecrease = new System.Windows.Forms.Button();
            this.buttonYdecrease = new System.Windows.Forms.Button();
            this.buttonXdecrease = new System.Windows.Forms.Button();
            this.buttonZincrease = new System.Windows.Forms.Button();
            this.buttonYincrease = new System.Windows.Forms.Button();
            this.buttonXincrease = new System.Windows.Forms.Button();
            this.NumericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownX)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableLayoutPanel.Controls.Add(this.PictureBox, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.groupBox1, 0, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(744, 552);
            this.TableLayoutPanel.TabIndex = 1;
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(226, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(515, 546);
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonZdecrease);
            this.groupBox1.Controls.Add(this.buttonYdecrease);
            this.groupBox1.Controls.Add(this.buttonXdecrease);
            this.groupBox1.Controls.Add(this.buttonZincrease);
            this.groupBox1.Controls.Add(this.buttonYincrease);
            this.groupBox1.Controls.Add(this.buttonXincrease);
            this.groupBox1.Controls.Add(this.NumericUpDownZ);
            this.groupBox1.Controls.Add(this.NumericUpDownX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка оси";
            // 
            // buttonZdecrease
            // 
            this.buttonZdecrease.Location = new System.Drawing.Point(27, 193);
            this.buttonZdecrease.Name = "buttonZdecrease";
            this.buttonZdecrease.Size = new System.Drawing.Size(75, 23);
            this.buttonZdecrease.TabIndex = 4;
            this.buttonZdecrease.Text = "<----";
            this.buttonZdecrease.UseVisualStyleBackColor = true;
            this.buttonZdecrease.Click += new System.EventHandler(this.decreaseRotateZ_Click);
            // 
            // buttonYdecrease
            // 
            this.buttonYdecrease.Location = new System.Drawing.Point(27, 143);
            this.buttonYdecrease.Name = "buttonYdecrease";
            this.buttonYdecrease.Size = new System.Drawing.Size(75, 23);
            this.buttonYdecrease.TabIndex = 4;
            this.buttonYdecrease.Text = "<----";
            this.buttonYdecrease.UseVisualStyleBackColor = true;
            this.buttonYdecrease.Click += new System.EventHandler(this.decreaseRotateY_Click);
            // 
            // buttonXdecrease
            // 
            this.buttonXdecrease.Location = new System.Drawing.Point(27, 88);
            this.buttonXdecrease.Name = "buttonXdecrease";
            this.buttonXdecrease.Size = new System.Drawing.Size(75, 23);
            this.buttonXdecrease.TabIndex = 4;
            this.buttonXdecrease.Text = "<----";
            this.buttonXdecrease.UseVisualStyleBackColor = true;
            this.buttonXdecrease.Click += new System.EventHandler(this.decreaseRotateX_Click);
            // 
            // buttonZincrease
            // 
            this.buttonZincrease.Location = new System.Drawing.Point(108, 193);
            this.buttonZincrease.Name = "buttonZincrease";
            this.buttonZincrease.Size = new System.Drawing.Size(75, 23);
            this.buttonZincrease.TabIndex = 4;
            this.buttonZincrease.Text = "---->";
            this.buttonZincrease.UseVisualStyleBackColor = true;
            this.buttonZincrease.Click += new System.EventHandler(this.increaseRotateZ_Click);
            // 
            // buttonYincrease
            // 
            this.buttonYincrease.Location = new System.Drawing.Point(108, 143);
            this.buttonYincrease.Name = "buttonYincrease";
            this.buttonYincrease.Size = new System.Drawing.Size(75, 23);
            this.buttonYincrease.TabIndex = 4;
            this.buttonYincrease.Text = "---->";
            this.buttonYincrease.UseVisualStyleBackColor = true;
            this.buttonYincrease.Click += new System.EventHandler(this.increaseRotateY_Click);
            // 
            // buttonXincrease
            // 
            this.buttonXincrease.Location = new System.Drawing.Point(108, 88);
            this.buttonXincrease.Name = "buttonXincrease";
            this.buttonXincrease.Size = new System.Drawing.Size(75, 23);
            this.buttonXincrease.TabIndex = 4;
            this.buttonXincrease.Text = "---->";
            this.buttonXincrease.UseVisualStyleBackColor = true;
            this.buttonXincrease.Click += new System.EventHandler(this.increaseRotateX_Click);
            // 
            // NumericUpDownZ
            // 
            this.NumericUpDownZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownZ.Location = new System.Drawing.Point(27, 46);
            this.NumericUpDownZ.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownZ.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumericUpDownZ.Name = "NumericUpDownZ";
            this.NumericUpDownZ.Size = new System.Drawing.Size(103, 20);
            this.NumericUpDownZ.TabIndex = 3;
            // 
            // NumericUpDownX
            // 
            this.NumericUpDownX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownX.Location = new System.Drawing.Point(27, 17);
            this.NumericUpDownX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumericUpDownX.Name = "NumericUpDownX";
            this.NumericUpDownX.Size = new System.Drawing.Size(103, 20);
            this.NumericUpDownX.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Z: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X: ";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rotate X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rotate Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rotate Z";
            // 
            // Lab4_Vova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayoutPanel);
            this.Name = "Lab4_Vova";
            this.Size = new System.Drawing.Size(744, 552);
            this.Load += new System.EventHandler(this.Lab4_Load);
            this.Resize += new System.EventHandler(this.Lab4_Resize);
            this.TableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Timer Timer;
        private GroupBox groupBox1;
        private NumericUpDown NumericUpDownZ;
        private NumericUpDown NumericUpDownX;
        private Label label2;
        private Label label1;
        private PictureBox PictureBox;
        private Button buttonZdecrease;
        private Button buttonYdecrease;
        private Button buttonXdecrease;
        private Button buttonZincrease;
        private Button buttonYincrease;
        private Button buttonXincrease;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
