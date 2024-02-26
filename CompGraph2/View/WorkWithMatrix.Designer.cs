
namespace CompGraph
{
    partial class WorkWithMatrix
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
            this.NLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DimensionMatrixTexBox = new System.Windows.Forms.TextBox();
            this.InputFirstMatrixButton = new System.Windows.Forms.Button();
            this.InputSecondMatrixButton = new System.Windows.Forms.Button();
            this.ResultMultiplicationButton = new System.Windows.Forms.Button();
            this.SaveInFileButton = new System.Windows.Forms.Button();
            this.RezultOfAdditionButton = new System.Windows.Forms.Button();
            this.RezultSubtractionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NLabel.Location = new System.Drawing.Point(66, 72);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(64, 31);
            this.NLabel.TabIndex = 0;
            this.NLabel.Text = "N = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(260, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(260, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // DimensionMatrixTexBox
            // 
            this.DimensionMatrixTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DimensionMatrixTexBox.Location = new System.Drawing.Point(123, 72);
            this.DimensionMatrixTexBox.Name = "DimensionMatrixTexBox";
            this.DimensionMatrixTexBox.Size = new System.Drawing.Size(223, 38);
            this.DimensionMatrixTexBox.TabIndex = 3;
            this.DimensionMatrixTexBox.Leave += new System.EventHandler(this.DimensionMatrixTexBox_Leave);
            // 
            // InputFirstMatrixButton
            // 
            this.InputFirstMatrixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputFirstMatrixButton.Location = new System.Drawing.Point(72, 128);
            this.InputFirstMatrixButton.Name = "InputFirstMatrixButton";
            this.InputFirstMatrixButton.Size = new System.Drawing.Size(182, 39);
            this.InputFirstMatrixButton.TabIndex = 4;
            this.InputFirstMatrixButton.Text = "Ввод Матрицы 1";
            this.InputFirstMatrixButton.UseVisualStyleBackColor = true;
            this.InputFirstMatrixButton.Click += new System.EventHandler(this.InputFirstMatrixButton_Click);
            // 
            // InputSecondMatrixButton
            // 
            this.InputSecondMatrixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputSecondMatrixButton.Location = new System.Drawing.Point(72, 177);
            this.InputSecondMatrixButton.Name = "InputSecondMatrixButton";
            this.InputSecondMatrixButton.Size = new System.Drawing.Size(182, 39);
            this.InputSecondMatrixButton.TabIndex = 5;
            this.InputSecondMatrixButton.Text = "Ввод Матрицы 2";
            this.InputSecondMatrixButton.UseVisualStyleBackColor = true;
            this.InputSecondMatrixButton.Click += new System.EventHandler(this.InputSecondMatrixButton_Click);
            // 
            // ResultMultiplicationButton
            // 
            this.ResultMultiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultMultiplicationButton.Location = new System.Drawing.Point(72, 231);
            this.ResultMultiplicationButton.Name = "ResultMultiplicationButton";
            this.ResultMultiplicationButton.Size = new System.Drawing.Size(274, 47);
            this.ResultMultiplicationButton.TabIndex = 6;
            this.ResultMultiplicationButton.Text = "Результат Умножения";
            this.ResultMultiplicationButton.UseVisualStyleBackColor = true;
            this.ResultMultiplicationButton.Click += new System.EventHandler(this.ResultMultiplicationButton_Click);
            // 
            // SaveInFileButton
            // 
            this.SaveInFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveInFileButton.Location = new System.Drawing.Point(72, 400);
            this.SaveInFileButton.Name = "SaveInFileButton";
            this.SaveInFileButton.Size = new System.Drawing.Size(274, 47);
            this.SaveInFileButton.TabIndex = 6;
            this.SaveInFileButton.Text = "Сохранить в файле “Res_Matr.txt";
            this.SaveInFileButton.UseVisualStyleBackColor = true;
            this.SaveInFileButton.Click += new System.EventHandler(this.SaveInFileButton_Click);
            // 
            // RezultOfAdditionButton
            // 
            this.RezultOfAdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RezultOfAdditionButton.Location = new System.Drawing.Point(72, 284);
            this.RezultOfAdditionButton.Name = "RezultOfAdditionButton";
            this.RezultOfAdditionButton.Size = new System.Drawing.Size(274, 47);
            this.RezultOfAdditionButton.TabIndex = 7;
            this.RezultOfAdditionButton.Text = "Результат Сложения";
            this.RezultOfAdditionButton.UseVisualStyleBackColor = true;
            this.RezultOfAdditionButton.Click += new System.EventHandler(this.RezultOfAdditionButton_Click);
            // 
            // RezultSubtractionButton
            // 
            this.RezultSubtractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RezultSubtractionButton.Location = new System.Drawing.Point(72, 337);
            this.RezultSubtractionButton.Name = "RezultSubtractionButton";
            this.RezultSubtractionButton.Size = new System.Drawing.Size(274, 47);
            this.RezultSubtractionButton.TabIndex = 8;
            this.RezultSubtractionButton.Text = "Результат Вычитания";
            this.RezultSubtractionButton.UseVisualStyleBackColor = true;
            this.RezultSubtractionButton.Click += new System.EventHandler(this.RezultSubtractionButton_Click);
            // 
            // WorkWithMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 539);
            this.Controls.Add(this.RezultSubtractionButton);
            this.Controls.Add(this.RezultOfAdditionButton);
            this.Controls.Add(this.SaveInFileButton);
            this.Controls.Add(this.ResultMultiplicationButton);
            this.Controls.Add(this.InputSecondMatrixButton);
            this.Controls.Add(this.InputFirstMatrixButton);
            this.Controls.Add(this.DimensionMatrixTexBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NLabel);
            this.Name = "WorkWithMatrix";
            this.Text = "WorkWithMatrix";
            this.Load += new System.EventHandler(this.WorkWithMatrix_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DimensionMatrixTexBox;
        private System.Windows.Forms.Button InputFirstMatrixButton;
        private System.Windows.Forms.Button InputSecondMatrixButton;
        private System.Windows.Forms.Button ResultMultiplicationButton;
        private System.Windows.Forms.Button SaveInFileButton;
        private System.Windows.Forms.Button RezultOfAdditionButton;
        private System.Windows.Forms.Button RezultSubtractionButton;
    }
}

