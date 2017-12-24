namespace _9._1._1F
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
            this.inputdataGridView = new System.Windows.Forms.DataGridView();
            this.outputdataGridView = new System.Windows.Forms.DataGridView();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.rnd_button = new System.Windows.Forms.Button();
            this.changebutton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.LoadFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.inputdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputdataGridView)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputdataGridView
            // 
            this.inputdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputdataGridView.Location = new System.Drawing.Point(12, 80);
            this.inputdataGridView.Name = "inputdataGridView";
            this.inputdataGridView.Size = new System.Drawing.Size(367, 191);
            this.inputdataGridView.TabIndex = 0;
            // 
            // outputdataGridView
            // 
            this.outputdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputdataGridView.Location = new System.Drawing.Point(520, 80);
            this.outputdataGridView.Name = "outputdataGridView";
            this.outputdataGridView.Size = new System.Drawing.Size(367, 191);
            this.outputdataGridView.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1018, 24);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFileOpen,
            this.MainMenuSaveFile});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // MainMenuFileOpen
            // 
            this.MainMenuFileOpen.Name = "MainMenuFileOpen";
            this.MainMenuFileOpen.Size = new System.Drawing.Size(171, 22);
            this.MainMenuFileOpen.Text = "открыть файл";
            this.MainMenuFileOpen.Click += new System.EventHandler(this.MainMenuFileOpen_Click_1);
            // 
            // MainMenuSaveFile
            // 
            this.MainMenuSaveFile.Name = "MainMenuSaveFile";
            this.MainMenuSaveFile.Size = new System.Drawing.Size(171, 22);
            this.MainMenuSaveFile.Text = "сохранить в файл";
            this.MainMenuSaveFile.Click += new System.EventHandler(this.MainMenuSaveFile_Click);
            // 
            // rnd_button
            // 
            this.rnd_button.Location = new System.Drawing.Point(103, 327);
            this.rnd_button.Name = "rnd_button";
            this.rnd_button.Size = new System.Drawing.Size(175, 23);
            this.rnd_button.TabIndex = 3;
            this.rnd_button.Text = "рандом";
            this.rnd_button.UseVisualStyleBackColor = true;
            this.rnd_button.Click += new System.EventHandler(this.rnd_button_Click);
            // 
            // changebutton
            // 
            this.changebutton.Location = new System.Drawing.Point(643, 327);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(157, 23);
            this.changebutton.TabIndex = 4;
            this.changebutton.Text = "изменить";
            this.changebutton.UseVisualStyleBackColor = true;
            this.changebutton.Click += new System.EventHandler(this.changebutton_Click);
            // 
            // LoadFileDialog
            // 
            this.LoadFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 446);
            this.Controls.Add(this.changebutton);
            this.Controls.Add(this.rnd_button);
            this.Controls.Add(this.outputdataGridView);
            this.Controls.Add(this.inputdataGridView);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.inputdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputdataGridView)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inputdataGridView;
        private System.Windows.Forms.DataGridView outputdataGridView;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MainMenuSaveFile;
        private System.Windows.Forms.Button rnd_button;
        private System.Windows.Forms.Button changebutton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog LoadFileDialog;
    }
}

