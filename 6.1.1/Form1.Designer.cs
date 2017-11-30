namespace _6._1._1
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.InputTextLabel = new System.Windows.Forms.Label();
            this.OutputBlock = new System.Windows.Forms.GroupBox();
            this.OutputTextLabel = new System.Windows.Forms.Label();
            this.OutputBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(15, 29);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(259, 20);
            this.InputTextBox.TabIndex = 0;
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Location = new System.Drawing.Point(15, 66);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(256, 27);
            this.ProcessBtn.TabIndex = 1;
            this.ProcessBtn.Text = "Посчитать";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // InputTextLabel
            // 
            this.InputTextLabel.AutoSize = true;
            this.InputTextLabel.Location = new System.Drawing.Point(15, 13);
            this.InputTextLabel.Name = "InputTextLabel";
            this.InputTextLabel.Size = new System.Drawing.Size(86, 13);
            this.InputTextLabel.TabIndex = 2;
            this.InputTextLabel.Text = "Введите строку";
            // 
            // OutputBlock
            // 
            this.OutputBlock.Controls.Add(this.OutputTextLabel);
            this.OutputBlock.Location = new System.Drawing.Point(17, 106);
            this.OutputBlock.Name = "OutputBlock";
            this.OutputBlock.Size = new System.Drawing.Size(254, 142);
            this.OutputBlock.TabIndex = 3;
            this.OutputBlock.TabStop = false;
            this.OutputBlock.Text = "Вывод";
            // 
            // OutputTextLabel
            // 
            this.OutputTextLabel.AutoSize = true;
            this.OutputTextLabel.Location = new System.Drawing.Point(6, 16);
            this.OutputTextLabel.Name = "OutputTextLabel";
            this.OutputTextLabel.Size = new System.Drawing.Size(0, 13);
            this.OutputTextLabel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.OutputBlock);
            this.Controls.Add(this.InputTextLabel);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.InputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.OutputBlock.ResumeLayout(false);
            this.OutputBlock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.Label InputTextLabel;
        private System.Windows.Forms.GroupBox OutputBlock;
        private System.Windows.Forms.Label OutputTextLabel;
    }
}

