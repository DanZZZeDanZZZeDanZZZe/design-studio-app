namespace DesignStudio
{
    partial class mainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.actionControl = new System.Windows.Forms.TabControl();
            this.syncPage = new System.Windows.Forms.TabPage();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.viewControl = new System.Windows.Forms.TabControl();
            this.tablePage = new System.Windows.Forms.TabPage();
            this.mainDataGrid = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.actionControl.SuspendLayout();
            this.syncPage.SuspendLayout();
            this.viewControl.SuspendLayout();
            this.tablePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.settingButton);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Location = new System.Drawing.Point(664, 457);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 90);
            this.panel1.TabIndex = 2;
            // 
            // settingButton
            // 
            this.settingButton.Location = new System.Drawing.Point(284, 23);
            this.settingButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(272, 54);
            this.settingButton.TabIndex = 2;
            this.settingButton.Text = "Настройка соединения";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(4, 23);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(272, 54);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Подключить";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // actionControl
            // 
            this.actionControl.Controls.Add(this.syncPage);
            this.actionControl.Location = new System.Drawing.Point(977, 12);
            this.actionControl.Name = "actionControl";
            this.actionControl.SelectedIndex = 0;
            this.actionControl.Size = new System.Drawing.Size(271, 438);
            this.actionControl.TabIndex = 4;
            // 
            // syncPage
            // 
            this.syncPage.Controls.Add(this.saveButton);
            this.syncPage.Controls.Add(this.updateButton);
            this.syncPage.Location = new System.Drawing.Point(4, 25);
            this.syncPage.Name = "syncPage";
            this.syncPage.Padding = new System.Windows.Forms.Padding(3);
            this.syncPage.Size = new System.Drawing.Size(263, 409);
            this.syncPage.TabIndex = 1;
            this.syncPage.Text = "Synchronization";
            this.syncPage.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(23, 86);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(216, 47);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(23, 23);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(216, 47);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // viewControl
            // 
            this.viewControl.Controls.Add(this.tablePage);
            this.viewControl.Location = new System.Drawing.Point(12, 12);
            this.viewControl.Name = "viewControl";
            this.viewControl.SelectedIndex = 0;
            this.viewControl.Size = new System.Drawing.Size(959, 438);
            this.viewControl.TabIndex = 3;
            // 
            // tablePage
            // 
            this.tablePage.Controls.Add(this.mainDataGrid);
            this.tablePage.Location = new System.Drawing.Point(4, 25);
            this.tablePage.Name = "tablePage";
            this.tablePage.Size = new System.Drawing.Size(951, 409);
            this.tablePage.TabIndex = 0;
            this.tablePage.Text = "Table";
            this.tablePage.UseVisualStyleBackColor = true;
            // 
            // mainDataGrid
            // 
            this.mainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGrid.Location = new System.Drawing.Point(0, 3);
            this.mainDataGrid.Name = "mainDataGrid";
            this.mainDataGrid.RowHeadersWidth = 51;
            this.mainDataGrid.RowTemplate.Height = 24;
            this.mainDataGrid.Size = new System.Drawing.Size(948, 403);
            this.mainDataGrid.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 560);
            this.Controls.Add(this.actionControl);
            this.Controls.Add(this.viewControl);
            this.Controls.Add(this.panel1);
            this.Name = "mainForm";
            this.Text = "Design studio";
            this.panel1.ResumeLayout(false);
            this.actionControl.ResumeLayout(false);
            this.syncPage.ResumeLayout(false);
            this.viewControl.ResumeLayout(false);
            this.tablePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TabControl actionControl;
        private System.Windows.Forms.TabPage syncPage;
        private System.Windows.Forms.TabControl viewControl;
        private System.Windows.Forms.TabPage tablePage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView mainDataGrid;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button updateButton;
    }
}

