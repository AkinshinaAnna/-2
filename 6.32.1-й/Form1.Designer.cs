namespace _6._32._1_й
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
            this.InputXtextBox = new System.Windows.Forms.TextBox();
            this.InputEtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Callculatebutton = new System.Windows.Forms.Button();
            this.AnswerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputXtextBox
            // 
            this.InputXtextBox.Location = new System.Drawing.Point(114, 23);
            this.InputXtextBox.Name = "InputXtextBox";
            this.InputXtextBox.Size = new System.Drawing.Size(100, 20);
            this.InputXtextBox.TabIndex = 0;
            // 
            // InputEtextBox
            // 
            this.InputEtextBox.Location = new System.Drawing.Point(114, 84);
            this.InputEtextBox.Name = "InputEtextBox";
            this.InputEtextBox.Size = new System.Drawing.Size(100, 20);
            this.InputEtextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите Х";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите e";
            // 
            // Callculatebutton
            // 
            this.Callculatebutton.Location = new System.Drawing.Point(95, 145);
            this.Callculatebutton.Name = "Callculatebutton";
            this.Callculatebutton.Size = new System.Drawing.Size(75, 23);
            this.Callculatebutton.TabIndex = 6;
            this.Callculatebutton.Text = "вычислить";
            this.Callculatebutton.UseVisualStyleBackColor = true;
            this.Callculatebutton.Click += new System.EventHandler(this.Callculatebutton_Click);
            // 
            // AnswerLbl
            // 
            this.AnswerLbl.AutoSize = true;
            this.AnswerLbl.Location = new System.Drawing.Point(12, 214);
            this.AnswerLbl.Name = "AnswerLbl";
            this.AnswerLbl.Size = new System.Drawing.Size(0, 13);
            this.AnswerLbl.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 293);
            this.Controls.Add(this.AnswerLbl);
            this.Controls.Add(this.Callculatebutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputEtextBox);
            this.Controls.Add(this.InputXtextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputXtextBox;
        private System.Windows.Forms.TextBox InputEtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Callculatebutton;
        private System.Windows.Forms.Label AnswerLbl;
    }
}

