namespace MainForm
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.filePage = new System.Windows.Forms.TabPage();
            this.fileGridView = new System.Windows.Forms.DataGridView();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asmPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.arg2 = new System.Windows.Forms.NumericUpDown();
            this.arg1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Calc = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nlzPage = new System.Windows.Forms.TabPage();
            this.analyzeLabel = new System.Windows.Forms.Label();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.analyzeTextBox = new System.Windows.Forms.TextBox();
            this.ormPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.filePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.asmPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arg1)).BeginInit();
            this.nlzPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.filePage);
            this.tabControl1.Controls.Add(this.asmPage);
            this.tabControl1.Controls.Add(this.nlzPage);
            this.tabControl1.Controls.Add(this.ormPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 216);
            this.tabControl1.TabIndex = 1;
            // 
            // filePage
            // 
            this.filePage.Controls.Add(this.fileGridView);
            this.filePage.Controls.Add(this.menuStrip1);
            this.filePage.Location = new System.Drawing.Point(4, 22);
            this.filePage.Name = "filePage";
            this.filePage.Padding = new System.Windows.Forms.Padding(3);
            this.filePage.Size = new System.Drawing.Size(768, 190);
            this.filePage.TabIndex = 0;
            this.filePage.Text = "Работа с файлом";
            this.filePage.UseVisualStyleBackColor = true;
            // 
            // fileGridView
            // 
            this.fileGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressColumn,
            this.portColumn,
            this.serverTypeColumn});
            this.fileGridView.Location = new System.Drawing.Point(6, 30);
            this.fileGridView.Name = "fileGridView";
            this.fileGridView.RowHeadersVisible = false;
            this.fileGridView.RowHeadersWidth = 4;
            this.fileGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.fileGridView.Size = new System.Drawing.Size(756, 154);
            this.fileGridView.TabIndex = 0;
            // 
            // addressColumn
            // 
            this.addressColumn.FillWeight = 200F;
            this.addressColumn.Frozen = true;
            this.addressColumn.HeaderText = "Адрес сервера";
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.Width = 99;
            // 
            // portColumn
            // 
            this.portColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.portColumn.HeaderText = "Порт";
            this.portColumn.Name = "portColumn";
            this.portColumn.Width = 57;
            // 
            // serverTypeColumn
            // 
            this.serverTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.serverTypeColumn.HeaderText = "Протокол";
            this.serverTypeColumn.Name = "serverTypeColumn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.правкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "fileMenuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как...";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.EditToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.AddToolStripMenuItem.Text = "Добавить запись";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить запись";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.EditToolStripMenuItem.Text = "Редактировать запись";
            // 
            // asmPage
            // 
            this.asmPage.Controls.Add(this.label4);
            this.asmPage.Controls.Add(this.arg2);
            this.asmPage.Controls.Add(this.arg1);
            this.asmPage.Controls.Add(this.label3);
            this.asmPage.Controls.Add(this.Calc);
            this.asmPage.Controls.Add(this.textBoxResult);
            this.asmPage.Controls.Add(this.label2);
            this.asmPage.Controls.Add(this.label1);
            this.asmPage.Location = new System.Drawing.Point(4, 22);
            this.asmPage.Name = "asmPage";
            this.asmPage.Padding = new System.Windows.Forms.Padding(3);
            this.asmPage.Size = new System.Drawing.Size(768, 190);
            this.asmPage.TabIndex = 1;
            this.asmPage.Text = "Низкоуровневая вставка";
            this.asmPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Исключающее или";
            // 
            // arg2
            // 
            this.arg2.Location = new System.Drawing.Point(320, 73);
            this.arg2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.arg2.Name = "arg2";
            this.arg2.Size = new System.Drawing.Size(100, 20);
            this.arg2.TabIndex = 8;
            // 
            // arg1
            // 
            this.arg1.Location = new System.Drawing.Point(320, 38);
            this.arg1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.arg1.Name = "arg1";
            this.arg1.Size = new System.Drawing.Size(100, 20);
            this.arg1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат";
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(211, 151);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(209, 23);
            this.Calc.TabIndex = 5;
            this.Calc.Text = "Посчитать";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(320, 107);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Второй аргумент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Первый аргумент";
            // 
            // nlzPage
            // 
            this.nlzPage.Controls.Add(this.analyzeLabel);
            this.nlzPage.Controls.Add(this.analyzeButton);
            this.nlzPage.Controls.Add(this.analyzeTextBox);
            this.nlzPage.Location = new System.Drawing.Point(4, 22);
            this.nlzPage.Name = "nlzPage";
            this.nlzPage.Padding = new System.Windows.Forms.Padding(3);
            this.nlzPage.Size = new System.Drawing.Size(768, 190);
            this.nlzPage.TabIndex = 2;
            this.nlzPage.Text = "Анализатор";
            this.nlzPage.UseVisualStyleBackColor = true;
            // 
            // analyzeLabel
            // 
            this.analyzeLabel.AutoSize = true;
            this.analyzeLabel.Location = new System.Drawing.Point(293, 168);
            this.analyzeLabel.Name = "analyzeLabel";
            this.analyzeLabel.Size = new System.Drawing.Size(59, 13);
            this.analyzeLabel.TabIndex = 2;
            this.analyzeLabel.Text = "Результат";
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(41, 163);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(246, 23);
            this.analyzeButton.TabIndex = 1;
            this.analyzeButton.Text = "Анализировать";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.AnalyzeButton_Click);
            // 
            // analyzeTextBox
            // 
            this.analyzeTextBox.Location = new System.Drawing.Point(0, 0);
            this.analyzeTextBox.Multiline = true;
            this.analyzeTextBox.Name = "analyzeTextBox";
            this.analyzeTextBox.Size = new System.Drawing.Size(768, 157);
            this.analyzeTextBox.TabIndex = 0;
            this.analyzeTextBox.Text = "int i=0;\r\nwhile(i<5)\r\n{\r\ni++;\r\n}";
            // 
            // ormPage
            // 
            this.ormPage.Location = new System.Drawing.Point(4, 22);
            this.ormPage.Name = "ormPage";
            this.ormPage.Padding = new System.Windows.Forms.Padding(3);
            this.ormPage.Size = new System.Drawing.Size(768, 190);
            this.ormPage.TabIndex = 3;
            this.ormPage.Text = "ОРМ";
            this.ormPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Syspro";
            this.tabControl1.ResumeLayout(false);
            this.filePage.ResumeLayout(false);
            this.filePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.asmPage.ResumeLayout(false);
            this.asmPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arg1)).EndInit();
            this.nlzPage.ResumeLayout(false);
            this.nlzPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage filePage;
        private System.Windows.Forms.DataGridView fileGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.TabPage asmPage;
        private System.Windows.Forms.TabPage nlzPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown arg2;
        private System.Windows.Forms.NumericUpDown arg1;
        private System.Windows.Forms.TabPage ormPage;
        private System.Windows.Forms.TextBox analyzeTextBox;
        private System.Windows.Forms.Label analyzeLabel;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverTypeColumn;
    }
}

