﻿namespace CompGraph.View
{
    partial class VectorModule
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveInFileButton = new System.Windows.Forms.Button();
            this.ResultModuleButton = new System.Windows.Forms.Button();
            this.InputVectorButton = new System.Windows.Forms.Button();
            this.DimensionVectorTexBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SaveInFileButton);
            this.panel1.Controls.Add(this.ResultModuleButton);
            this.panel1.Controls.Add(this.InputVectorButton);
            this.panel1.Controls.Add(this.DimensionVectorTexBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 572);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(329, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "label1";
            // 
            // SaveInFileButton
            // 
            this.SaveInFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveInFileButton.Location = new System.Drawing.Point(26, 197);
            this.SaveInFileButton.Name = "SaveInFileButton";
            this.SaveInFileButton.Size = new System.Drawing.Size(298, 61);
            this.SaveInFileButton.TabIndex = 25;
            this.SaveInFileButton.Text = "Сохранить в файле “Res_Module.txt";
            this.SaveInFileButton.UseVisualStyleBackColor = true;
            // 
            // ResultModuleButton
            // 
            this.ResultModuleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultModuleButton.Location = new System.Drawing.Point(26, 129);
            this.ResultModuleButton.Name = "ResultModuleButton";
            this.ResultModuleButton.Size = new System.Drawing.Size(298, 61);
            this.ResultModuleButton.TabIndex = 26;
            this.ResultModuleButton.Text = "Результат";
            this.ResultModuleButton.UseVisualStyleBackColor = true;
            this.ResultModuleButton.Click += new System.EventHandler(this.ResultModuleButton_Click);
            // 
            // InputVectorButton
            // 
            this.InputVectorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputVectorButton.Location = new System.Drawing.Point(26, 70);
            this.InputVectorButton.Name = "InputVectorButton";
            this.InputVectorButton.Size = new System.Drawing.Size(206, 53);
            this.InputVectorButton.TabIndex = 23;
            this.InputVectorButton.Text = "Ввод Вектора";
            this.InputVectorButton.UseVisualStyleBackColor = true;
            this.InputVectorButton.Click += new System.EventHandler(this.InputVectorButton_Click);
            // 
            // DimensionVectorTexBox
            // 
            this.DimensionVectorTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DimensionVectorTexBox.Location = new System.Drawing.Point(77, 14);
            this.DimensionVectorTexBox.Name = "DimensionVectorTexBox";
            this.DimensionVectorTexBox.Size = new System.Drawing.Size(247, 38);
            this.DimensionVectorTexBox.TabIndex = 22;
            this.DimensionVectorTexBox.Leave += new System.EventHandler(this.DimensionVectorTexBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(238, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NLabel.Location = new System.Drawing.Point(20, 14);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(64, 31);
            this.NLabel.TabIndex = 19;
            this.NLabel.Text = "N = ";
            // 
            // VectorModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VectorModule";
            this.Size = new System.Drawing.Size(838, 604);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveInFileButton;
        private System.Windows.Forms.Button ResultModuleButton;
        private System.Windows.Forms.Button InputVectorButton;
        private System.Windows.Forms.TextBox DimensionVectorTexBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.Label label1;
    }
}
