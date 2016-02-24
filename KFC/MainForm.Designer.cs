namespace KFC
{
    partial class MainForm
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.adminTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.userEditTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ингредиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.единицыИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.приходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приказОПриёмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminTSMI,
            this.directoryTSMI,
            this.documentTSMI,
            this.reportTSMI});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(927, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // adminTSMI
            // 
            this.adminTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userEditTSMI});
            this.adminTSMI.Enabled = false;
            this.adminTSMI.Name = "adminTSMI";
            this.adminTSMI.Size = new System.Drawing.Size(68, 20);
            this.adminTSMI.Text = "Админка";
            // 
            // userEditTSMI
            // 
            this.userEditTSMI.Name = "userEditTSMI";
            this.userEditTSMI.Size = new System.Drawing.Size(215, 22);
            this.userEditTSMI.Text = "Работа с пользователями";
            this.userEditTSMI.Click += new System.EventHandler(this.userEditTSMI_Click);
            // 
            // directoryTSMI
            // 
            this.directoryTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ингредиентыToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.поставщикиToolStripMenuItem,
            this.складToolStripMenuItem,
            this.единицыИзмеренияToolStripMenuItem});
            this.directoryTSMI.Enabled = false;
            this.directoryTSMI.Name = "directoryTSMI";
            this.directoryTSMI.Size = new System.Drawing.Size(87, 20);
            this.directoryTSMI.Text = "Справочник";
            // 
            // ингредиентыToolStripMenuItem
            // 
            this.ингредиентыToolStripMenuItem.Name = "ингредиентыToolStripMenuItem";
            this.ингредиентыToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ингредиентыToolStripMenuItem.Text = "Ингредиенты";
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.товарыToolStripMenuItem.Text = "Товары";
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.складToolStripMenuItem.Text = "Склад";
            // 
            // единицыИзмеренияToolStripMenuItem
            // 
            this.единицыИзмеренияToolStripMenuItem.Name = "единицыИзмеренияToolStripMenuItem";
            this.единицыИзмеренияToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.единицыИзмеренияToolStripMenuItem.Text = "Единицы измерения";
            // 
            // documentTSMI
            // 
            this.documentTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приходToolStripMenuItem,
            this.приказОПриёмеToolStripMenuItem,
            this.заказToolStripMenuItem,
            this.чекToolStripMenuItem});
            this.documentTSMI.Enabled = false;
            this.documentTSMI.Name = "documentTSMI";
            this.documentTSMI.Size = new System.Drawing.Size(82, 20);
            this.documentTSMI.Text = "Документы";
            // 
            // приходToolStripMenuItem
            // 
            this.приходToolStripMenuItem.Name = "приходToolStripMenuItem";
            this.приходToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.приходToolStripMenuItem.Text = "Приход";
            this.приходToolStripMenuItem.Click += new System.EventHandler(this.приходToolStripMenuItem_Click);
            // 
            // приказОПриёмеToolStripMenuItem
            // 
            this.приказОПриёмеToolStripMenuItem.Name = "приказОПриёмеToolStripMenuItem";
            this.приказОПриёмеToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.приказОПриёмеToolStripMenuItem.Text = "Приказ о приёме";
            // 
            // заказToolStripMenuItem
            // 
            this.заказToolStripMenuItem.Name = "заказToolStripMenuItem";
            this.заказToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.заказToolStripMenuItem.Text = "Заказ";
            // 
            // чекToolStripMenuItem
            // 
            this.чекToolStripMenuItem.Name = "чекToolStripMenuItem";
            this.чекToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.чекToolStripMenuItem.Text = "Чек";
            // 
            // reportTSMI
            // 
            this.reportTSMI.Enabled = false;
            this.reportTSMI.Name = "reportTSMI";
            this.reportTSMI.Size = new System.Drawing.Size(60, 20);
            this.reportTSMI.Text = "Отчеты";
            this.reportTSMI.Click += new System.EventHandler(this.reportTSMI_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 561);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Админ панель";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem adminTSMI;
        private System.Windows.Forms.ToolStripMenuItem directoryTSMI;
        private System.Windows.Forms.ToolStripMenuItem documentTSMI;
        private System.Windows.Forms.ToolStripMenuItem reportTSMI;
        private System.Windows.Forms.ToolStripMenuItem userEditTSMI;
        private System.Windows.Forms.ToolStripMenuItem ингредиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приказОПриёмеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem единицыИзмеренияToolStripMenuItem;
    }
}