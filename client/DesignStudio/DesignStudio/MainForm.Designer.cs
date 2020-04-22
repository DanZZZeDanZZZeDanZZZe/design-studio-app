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
            this.settingButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.viewControl = new System.Windows.Forms.TabControl();
            this.fontsPage = new System.Windows.Forms.TabPage();
            this.fontsDataGrid = new System.Windows.Forms.DataGridView();
            this.logosPage = new System.Windows.Forms.TabPage();
            this.logosDataGrid = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.individualsPage = new System.Windows.Forms.TabPage();
            this.legalEntitiesPage = new System.Windows.Forms.TabPage();
            this.externalOrdersPage = new System.Windows.Forms.TabPage();
            this.internalOrdersPage = new System.Windows.Forms.TabPage();
            this.developmentTeamsPage = new System.Windows.Forms.TabPage();
            this.designersPage = new System.Windows.Forms.TabPage();
            this.employeesPage = new System.Windows.Forms.TabPage();
            this.clothesPage = new System.Windows.Forms.TabPage();
            this.circlesPage = new System.Windows.Forms.TabPage();
            this.coversPage = new System.Windows.Forms.TabPage();
            this.viewControl.SuspendLayout();
            this.fontsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontsDataGrid)).BeginInit();
            this.logosPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logosDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingButton
            // 
            this.settingButton.Location = new System.Drawing.Point(25, 72);
            this.settingButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(216, 47);
            this.settingButton.TabIndex = 2;
            this.settingButton.Text = "Настройка соединения";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(25, 15);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(216, 49);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Подключить";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // viewControl
            // 
            this.viewControl.Controls.Add(this.fontsPage);
            this.viewControl.Controls.Add(this.logosPage);
            this.viewControl.Controls.Add(this.individualsPage);
            this.viewControl.Controls.Add(this.legalEntitiesPage);
            this.viewControl.Controls.Add(this.externalOrdersPage);
            this.viewControl.Controls.Add(this.internalOrdersPage);
            this.viewControl.Controls.Add(this.developmentTeamsPage);
            this.viewControl.Controls.Add(this.designersPage);
            this.viewControl.Controls.Add(this.employeesPage);
            this.viewControl.Controls.Add(this.clothesPage);
            this.viewControl.Controls.Add(this.circlesPage);
            this.viewControl.Controls.Add(this.coversPage);
            this.viewControl.Location = new System.Drawing.Point(12, 12);
            this.viewControl.Name = "viewControl";
            this.viewControl.SelectedIndex = 0;
            this.viewControl.Size = new System.Drawing.Size(959, 554);
            this.viewControl.TabIndex = 3;
            // 
            // fontsPage
            // 
            this.fontsPage.Controls.Add(this.fontsDataGrid);
            this.fontsPage.Location = new System.Drawing.Point(4, 25);
            this.fontsPage.Name = "fontsPage";
            this.fontsPage.Size = new System.Drawing.Size(951, 525);
            this.fontsPage.TabIndex = 0;
            this.fontsPage.Text = "fonts";
            this.fontsPage.UseVisualStyleBackColor = true;
            // 
            // fontsDataGrid
            // 
            this.fontsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fontsDataGrid.Location = new System.Drawing.Point(28, 32);
            this.fontsDataGrid.Name = "fontsDataGrid";
            this.fontsDataGrid.ReadOnly = true;
            this.fontsDataGrid.RowHeadersWidth = 51;
            this.fontsDataGrid.RowTemplate.Height = 24;
            this.fontsDataGrid.Size = new System.Drawing.Size(920, 341);
            this.fontsDataGrid.TabIndex = 0;
            // 
            // logosPage
            // 
            this.logosPage.Controls.Add(this.logosDataGrid);
            this.logosPage.Location = new System.Drawing.Point(4, 25);
            this.logosPage.Name = "logosPage";
            this.logosPage.Padding = new System.Windows.Forms.Padding(3);
            this.logosPage.Size = new System.Drawing.Size(951, 525);
            this.logosPage.TabIndex = 1;
            this.logosPage.Text = "logos";
            this.logosPage.UseVisualStyleBackColor = true;
            // 
            // logosDataGrid
            // 
            this.logosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logosDataGrid.Location = new System.Drawing.Point(105, 48);
            this.logosDataGrid.Name = "logosDataGrid";
            this.logosDataGrid.RowHeadersWidth = 51;
            this.logosDataGrid.RowTemplate.Height = 24;
            this.logosDataGrid.Size = new System.Drawing.Size(781, 303);
            this.logosDataGrid.TabIndex = 0;
            this.logosDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.logosDataGrid_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.settingButton);
            this.panel1.Location = new System.Drawing.Point(973, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 134);
            this.panel1.TabIndex = 4;
            // 
            // individualsPage
            // 
            this.individualsPage.Location = new System.Drawing.Point(4, 25);
            this.individualsPage.Name = "individualsPage";
            this.individualsPage.Padding = new System.Windows.Forms.Padding(3);
            this.individualsPage.Size = new System.Drawing.Size(951, 525);
            this.individualsPage.TabIndex = 2;
            this.individualsPage.Text = "individuals";
            this.individualsPage.UseVisualStyleBackColor = true;
            // 
            // legalEntitiesPage
            // 
            this.legalEntitiesPage.Location = new System.Drawing.Point(4, 25);
            this.legalEntitiesPage.Name = "legalEntitiesPage";
            this.legalEntitiesPage.Padding = new System.Windows.Forms.Padding(3);
            this.legalEntitiesPage.Size = new System.Drawing.Size(951, 525);
            this.legalEntitiesPage.TabIndex = 3;
            this.legalEntitiesPage.Text = "legal entities";
            this.legalEntitiesPage.UseVisualStyleBackColor = true;
            // 
            // externalOrdersPage
            // 
            this.externalOrdersPage.Location = new System.Drawing.Point(4, 25);
            this.externalOrdersPage.Name = "externalOrdersPage";
            this.externalOrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.externalOrdersPage.Size = new System.Drawing.Size(951, 525);
            this.externalOrdersPage.TabIndex = 4;
            this.externalOrdersPage.Text = "external orders";
            this.externalOrdersPage.UseVisualStyleBackColor = true;
            // 
            // internalOrdersPage
            // 
            this.internalOrdersPage.Location = new System.Drawing.Point(4, 25);
            this.internalOrdersPage.Name = "internalOrdersPage";
            this.internalOrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.internalOrdersPage.Size = new System.Drawing.Size(951, 525);
            this.internalOrdersPage.TabIndex = 5;
            this.internalOrdersPage.Text = "internal orders";
            this.internalOrdersPage.UseVisualStyleBackColor = true;
            this.internalOrdersPage.Click += new System.EventHandler(this.internalOrdersPage_Click);
            // 
            // developmentTeamsPage
            // 
            this.developmentTeamsPage.Location = new System.Drawing.Point(4, 25);
            this.developmentTeamsPage.Name = "developmentTeamsPage";
            this.developmentTeamsPage.Padding = new System.Windows.Forms.Padding(3);
            this.developmentTeamsPage.Size = new System.Drawing.Size(951, 525);
            this.developmentTeamsPage.TabIndex = 6;
            this.developmentTeamsPage.Text = "development teams";
            this.developmentTeamsPage.UseVisualStyleBackColor = true;
            // 
            // designersPage
            // 
            this.designersPage.Location = new System.Drawing.Point(4, 25);
            this.designersPage.Name = "designersPage";
            this.designersPage.Padding = new System.Windows.Forms.Padding(3);
            this.designersPage.Size = new System.Drawing.Size(951, 525);
            this.designersPage.TabIndex = 7;
            this.designersPage.Text = "designers";
            this.designersPage.UseVisualStyleBackColor = true;
            // 
            // employeesPage
            // 
            this.employeesPage.Location = new System.Drawing.Point(4, 25);
            this.employeesPage.Name = "employeesPage";
            this.employeesPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeesPage.Size = new System.Drawing.Size(951, 525);
            this.employeesPage.TabIndex = 8;
            this.employeesPage.Text = "employees";
            this.employeesPage.UseVisualStyleBackColor = true;
            this.employeesPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // clothesPage
            // 
            this.clothesPage.Location = new System.Drawing.Point(4, 25);
            this.clothesPage.Name = "clothesPage";
            this.clothesPage.Padding = new System.Windows.Forms.Padding(3);
            this.clothesPage.Size = new System.Drawing.Size(951, 525);
            this.clothesPage.TabIndex = 9;
            this.clothesPage.Text = "clothes";
            this.clothesPage.UseVisualStyleBackColor = true;
            // 
            // circlesPage
            // 
            this.circlesPage.Location = new System.Drawing.Point(4, 25);
            this.circlesPage.Name = "circlesPage";
            this.circlesPage.Padding = new System.Windows.Forms.Padding(3);
            this.circlesPage.Size = new System.Drawing.Size(951, 525);
            this.circlesPage.TabIndex = 10;
            this.circlesPage.Text = "circles";
            this.circlesPage.UseVisualStyleBackColor = true;
            // 
            // coversPage
            // 
            this.coversPage.Location = new System.Drawing.Point(4, 25);
            this.coversPage.Name = "coversPage";
            this.coversPage.Padding = new System.Windows.Forms.Padding(3);
            this.coversPage.Size = new System.Drawing.Size(951, 525);
            this.coversPage.TabIndex = 11;
            this.coversPage.Text = "covers";
            this.coversPage.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewControl);
            this.Name = "mainForm";
            this.Text = "Design studio";
            this.viewControl.ResumeLayout(false);
            this.fontsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fontsDataGrid)).EndInit();
            this.logosPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logosDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TabControl viewControl;
        private System.Windows.Forms.TabPage fontsPage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView fontsDataGrid;
        private System.Windows.Forms.TabPage logosPage;
        private System.Windows.Forms.DataGridView logosDataGrid;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage individualsPage;
        private System.Windows.Forms.TabPage legalEntitiesPage;
        private System.Windows.Forms.TabPage externalOrdersPage;
        private System.Windows.Forms.TabPage internalOrdersPage;
        private System.Windows.Forms.TabPage developmentTeamsPage;
        private System.Windows.Forms.TabPage designersPage;
        private System.Windows.Forms.TabPage employeesPage;
        private System.Windows.Forms.TabPage clothesPage;
        private System.Windows.Forms.TabPage circlesPage;
        private System.Windows.Forms.TabPage coversPage;
    }
}

