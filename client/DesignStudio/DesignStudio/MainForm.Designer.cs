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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employeesPage = new System.Windows.Forms.TabPage();
            this.employeesDeleteButton = new System.Windows.Forms.Button();
            this.employeesDataGrid = new System.Windows.Forms.DataGridView();
            this.designersPage = new System.Windows.Forms.TabPage();
            this.designersDeleteButton = new System.Windows.Forms.Button();
            this.designersDataGrid = new System.Windows.Forms.DataGridView();
            this.developmentTeamsPage = new System.Windows.Forms.TabPage();
            this.developmentTeamsAddButton = new System.Windows.Forms.Button();
            this.developmentTeamsDeleteButton = new System.Windows.Forms.Button();
            this.developmentTeamsDataGrid = new System.Windows.Forms.DataGridView();
            this.internalOrdersPage = new System.Windows.Forms.TabPage();
            this.internalOrdersAddButton = new System.Windows.Forms.Button();
            this.internalOrdersDeleteButton = new System.Windows.Forms.Button();
            this.internalOrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.externalOrdersPage = new System.Windows.Forms.TabPage();
            this.externalOrdersAddButton = new System.Windows.Forms.Button();
            this.externalOrdersDeleteButton = new System.Windows.Forms.Button();
            this.externalOrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.legalEntitiesPage = new System.Windows.Forms.TabPage();
            this.legalEntitiesAddButton = new System.Windows.Forms.Button();
            this.legalEntitiesDeleteButton = new System.Windows.Forms.Button();
            this.legalEntitiesDataGrid = new System.Windows.Forms.DataGridView();
            this.individualsPage = new System.Windows.Forms.TabPage();
            this.addIndividuals = new System.Windows.Forms.Button();
            this.individualsDeleteButton = new System.Windows.Forms.Button();
            this.individualsDataGrid = new System.Windows.Forms.DataGridView();
            this.Pages = new System.Windows.Forms.TabControl();
            this.showProductsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.employeesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGrid)).BeginInit();
            this.designersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designersDataGrid)).BeginInit();
            this.developmentTeamsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.developmentTeamsDataGrid)).BeginInit();
            this.internalOrdersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internalOrdersDataGrid)).BeginInit();
            this.externalOrdersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.externalOrdersDataGrid)).BeginInit();
            this.legalEntitiesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.legalEntitiesDataGrid)).BeginInit();
            this.individualsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.individualsDataGrid)).BeginInit();
            this.Pages.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.settingButton);
            this.panel1.Location = new System.Drawing.Point(973, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 134);
            this.panel1.TabIndex = 4;
            // 
            // employeesPage
            // 
            this.employeesPage.Controls.Add(this.employeesDeleteButton);
            this.employeesPage.Controls.Add(this.employeesDataGrid);
            this.employeesPage.Location = new System.Drawing.Point(4, 25);
            this.employeesPage.Name = "employeesPage";
            this.employeesPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeesPage.Size = new System.Drawing.Size(951, 525);
            this.employeesPage.TabIndex = 8;
            this.employeesPage.Text = "employees";
            this.employeesPage.UseVisualStyleBackColor = true;
            // 
            // employeesDeleteButton
            // 
            this.employeesDeleteButton.Location = new System.Drawing.Point(680, 432);
            this.employeesDeleteButton.Name = "employeesDeleteButton";
            this.employeesDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.employeesDeleteButton.TabIndex = 4;
            this.employeesDeleteButton.Text = "delete";
            this.employeesDeleteButton.UseVisualStyleBackColor = true;
            // 
            // employeesDataGrid
            // 
            this.employeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGrid.Location = new System.Drawing.Point(85, 37);
            this.employeesDataGrid.Name = "employeesDataGrid";
            this.employeesDataGrid.RowHeadersWidth = 51;
            this.employeesDataGrid.RowTemplate.Height = 24;
            this.employeesDataGrid.Size = new System.Drawing.Size(781, 303);
            this.employeesDataGrid.TabIndex = 3;
            // 
            // designersPage
            // 
            this.designersPage.Controls.Add(this.designersDeleteButton);
            this.designersPage.Controls.Add(this.designersDataGrid);
            this.designersPage.Location = new System.Drawing.Point(4, 25);
            this.designersPage.Name = "designersPage";
            this.designersPage.Padding = new System.Windows.Forms.Padding(3);
            this.designersPage.Size = new System.Drawing.Size(951, 525);
            this.designersPage.TabIndex = 7;
            this.designersPage.Text = "designers";
            this.designersPage.UseVisualStyleBackColor = true;
            // 
            // designersDeleteButton
            // 
            this.designersDeleteButton.Location = new System.Drawing.Point(680, 432);
            this.designersDeleteButton.Name = "designersDeleteButton";
            this.designersDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.designersDeleteButton.TabIndex = 4;
            this.designersDeleteButton.Text = "delete";
            this.designersDeleteButton.UseVisualStyleBackColor = true;
            // 
            // designersDataGrid
            // 
            this.designersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.designersDataGrid.Location = new System.Drawing.Point(85, 37);
            this.designersDataGrid.Name = "designersDataGrid";
            this.designersDataGrid.RowHeadersWidth = 51;
            this.designersDataGrid.RowTemplate.Height = 24;
            this.designersDataGrid.Size = new System.Drawing.Size(781, 303);
            this.designersDataGrid.TabIndex = 3;
            // 
            // developmentTeamsPage
            // 
            this.developmentTeamsPage.Controls.Add(this.showProductsButton);
            this.developmentTeamsPage.Controls.Add(this.developmentTeamsAddButton);
            this.developmentTeamsPage.Controls.Add(this.developmentTeamsDeleteButton);
            this.developmentTeamsPage.Controls.Add(this.developmentTeamsDataGrid);
            this.developmentTeamsPage.Location = new System.Drawing.Point(4, 25);
            this.developmentTeamsPage.Name = "developmentTeamsPage";
            this.developmentTeamsPage.Padding = new System.Windows.Forms.Padding(3);
            this.developmentTeamsPage.Size = new System.Drawing.Size(951, 525);
            this.developmentTeamsPage.TabIndex = 6;
            this.developmentTeamsPage.Text = "development teams";
            this.developmentTeamsPage.UseVisualStyleBackColor = true;
            // 
            // developmentTeamsAddButton
            // 
            this.developmentTeamsAddButton.Location = new System.Drawing.Point(471, 432);
            this.developmentTeamsAddButton.Name = "developmentTeamsAddButton";
            this.developmentTeamsAddButton.Size = new System.Drawing.Size(186, 55);
            this.developmentTeamsAddButton.TabIndex = 5;
            this.developmentTeamsAddButton.Text = "add";
            this.developmentTeamsAddButton.UseVisualStyleBackColor = true;
            this.developmentTeamsAddButton.Click += new System.EventHandler(this.developmentTeamsAddButton_Click);
            // 
            // developmentTeamsDeleteButton
            // 
            this.developmentTeamsDeleteButton.Location = new System.Drawing.Point(680, 432);
            this.developmentTeamsDeleteButton.Name = "developmentTeamsDeleteButton";
            this.developmentTeamsDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.developmentTeamsDeleteButton.TabIndex = 4;
            this.developmentTeamsDeleteButton.Text = "delete";
            this.developmentTeamsDeleteButton.UseVisualStyleBackColor = true;
            this.developmentTeamsDeleteButton.Click += new System.EventHandler(this.developmentTeamsDeleteButton_Click);
            // 
            // developmentTeamsDataGrid
            // 
            this.developmentTeamsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.developmentTeamsDataGrid.Location = new System.Drawing.Point(85, 37);
            this.developmentTeamsDataGrid.Name = "developmentTeamsDataGrid";
            this.developmentTeamsDataGrid.RowHeadersWidth = 51;
            this.developmentTeamsDataGrid.RowTemplate.Height = 24;
            this.developmentTeamsDataGrid.Size = new System.Drawing.Size(781, 303);
            this.developmentTeamsDataGrid.TabIndex = 3;
            // 
            // internalOrdersPage
            // 
            this.internalOrdersPage.Controls.Add(this.internalOrdersAddButton);
            this.internalOrdersPage.Controls.Add(this.internalOrdersDeleteButton);
            this.internalOrdersPage.Controls.Add(this.internalOrdersDataGrid);
            this.internalOrdersPage.Location = new System.Drawing.Point(4, 25);
            this.internalOrdersPage.Name = "internalOrdersPage";
            this.internalOrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.internalOrdersPage.Size = new System.Drawing.Size(951, 525);
            this.internalOrdersPage.TabIndex = 5;
            this.internalOrdersPage.Text = "internal orders";
            this.internalOrdersPage.UseVisualStyleBackColor = true;
            // 
            // internalOrdersAddButton
            // 
            this.internalOrdersAddButton.Location = new System.Drawing.Point(472, 432);
            this.internalOrdersAddButton.Name = "internalOrdersAddButton";
            this.internalOrdersAddButton.Size = new System.Drawing.Size(186, 55);
            this.internalOrdersAddButton.TabIndex = 5;
            this.internalOrdersAddButton.Text = "add";
            this.internalOrdersAddButton.UseVisualStyleBackColor = true;
            this.internalOrdersAddButton.Click += new System.EventHandler(this.internalOrdersAddButton_Click);
            // 
            // internalOrdersDeleteButton
            // 
            this.internalOrdersDeleteButton.Location = new System.Drawing.Point(680, 432);
            this.internalOrdersDeleteButton.Name = "internalOrdersDeleteButton";
            this.internalOrdersDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.internalOrdersDeleteButton.TabIndex = 4;
            this.internalOrdersDeleteButton.Text = "delete";
            this.internalOrdersDeleteButton.UseVisualStyleBackColor = true;
            this.internalOrdersDeleteButton.Click += new System.EventHandler(this.internalOrdersDeleteButton_Click);
            // 
            // internalOrdersDataGrid
            // 
            this.internalOrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.internalOrdersDataGrid.Location = new System.Drawing.Point(85, 37);
            this.internalOrdersDataGrid.Name = "internalOrdersDataGrid";
            this.internalOrdersDataGrid.RowHeadersWidth = 51;
            this.internalOrdersDataGrid.RowTemplate.Height = 24;
            this.internalOrdersDataGrid.Size = new System.Drawing.Size(781, 303);
            this.internalOrdersDataGrid.TabIndex = 3;
            // 
            // externalOrdersPage
            // 
            this.externalOrdersPage.Controls.Add(this.externalOrdersAddButton);
            this.externalOrdersPage.Controls.Add(this.externalOrdersDeleteButton);
            this.externalOrdersPage.Controls.Add(this.externalOrdersDataGrid);
            this.externalOrdersPage.Location = new System.Drawing.Point(4, 25);
            this.externalOrdersPage.Name = "externalOrdersPage";
            this.externalOrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.externalOrdersPage.Size = new System.Drawing.Size(951, 525);
            this.externalOrdersPage.TabIndex = 4;
            this.externalOrdersPage.Text = "external orders";
            this.externalOrdersPage.UseVisualStyleBackColor = true;
            // 
            // externalOrdersAddButton
            // 
            this.externalOrdersAddButton.Location = new System.Drawing.Point(465, 432);
            this.externalOrdersAddButton.Name = "externalOrdersAddButton";
            this.externalOrdersAddButton.Size = new System.Drawing.Size(186, 55);
            this.externalOrdersAddButton.TabIndex = 5;
            this.externalOrdersAddButton.Text = "add";
            this.externalOrdersAddButton.UseVisualStyleBackColor = true;
            this.externalOrdersAddButton.Click += new System.EventHandler(this.externalOrdersAddButton_Click);
            // 
            // externalOrdersDeleteButton
            // 
            this.externalOrdersDeleteButton.Location = new System.Drawing.Point(680, 432);
            this.externalOrdersDeleteButton.Name = "externalOrdersDeleteButton";
            this.externalOrdersDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.externalOrdersDeleteButton.TabIndex = 4;
            this.externalOrdersDeleteButton.Text = "delete";
            this.externalOrdersDeleteButton.UseVisualStyleBackColor = true;
            this.externalOrdersDeleteButton.Click += new System.EventHandler(this.externalOrdersDeleteButton_Click);
            // 
            // externalOrdersDataGrid
            // 
            this.externalOrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.externalOrdersDataGrid.Location = new System.Drawing.Point(85, 37);
            this.externalOrdersDataGrid.Name = "externalOrdersDataGrid";
            this.externalOrdersDataGrid.RowHeadersWidth = 51;
            this.externalOrdersDataGrid.RowTemplate.Height = 24;
            this.externalOrdersDataGrid.Size = new System.Drawing.Size(781, 303);
            this.externalOrdersDataGrid.TabIndex = 3;
            // 
            // legalEntitiesPage
            // 
            this.legalEntitiesPage.Controls.Add(this.legalEntitiesAddButton);
            this.legalEntitiesPage.Controls.Add(this.legalEntitiesDeleteButton);
            this.legalEntitiesPage.Controls.Add(this.legalEntitiesDataGrid);
            this.legalEntitiesPage.Location = new System.Drawing.Point(4, 25);
            this.legalEntitiesPage.Name = "legalEntitiesPage";
            this.legalEntitiesPage.Padding = new System.Windows.Forms.Padding(3);
            this.legalEntitiesPage.Size = new System.Drawing.Size(951, 525);
            this.legalEntitiesPage.TabIndex = 3;
            this.legalEntitiesPage.Text = "legal entities";
            this.legalEntitiesPage.UseVisualStyleBackColor = true;
            // 
            // legalEntitiesAddButton
            // 
            this.legalEntitiesAddButton.Location = new System.Drawing.Point(488, 432);
            this.legalEntitiesAddButton.Name = "legalEntitiesAddButton";
            this.legalEntitiesAddButton.Size = new System.Drawing.Size(186, 55);
            this.legalEntitiesAddButton.TabIndex = 5;
            this.legalEntitiesAddButton.Text = "add";
            this.legalEntitiesAddButton.UseVisualStyleBackColor = true;
            this.legalEntitiesAddButton.Click += new System.EventHandler(this.legalEntitiesAddButton_Click);
            // 
            // legalEntitiesDeleteButton
            // 
            this.legalEntitiesDeleteButton.Location = new System.Drawing.Point(680, 432);
            this.legalEntitiesDeleteButton.Name = "legalEntitiesDeleteButton";
            this.legalEntitiesDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.legalEntitiesDeleteButton.TabIndex = 4;
            this.legalEntitiesDeleteButton.Text = "delete";
            this.legalEntitiesDeleteButton.UseVisualStyleBackColor = true;
            this.legalEntitiesDeleteButton.Click += new System.EventHandler(this.legalEntitiesDeleteButton_Click);
            // 
            // legalEntitiesDataGrid
            // 
            this.legalEntitiesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.legalEntitiesDataGrid.Location = new System.Drawing.Point(85, 37);
            this.legalEntitiesDataGrid.Name = "legalEntitiesDataGrid";
            this.legalEntitiesDataGrid.RowHeadersWidth = 51;
            this.legalEntitiesDataGrid.RowTemplate.Height = 24;
            this.legalEntitiesDataGrid.Size = new System.Drawing.Size(781, 303);
            this.legalEntitiesDataGrid.TabIndex = 3;
            // 
            // individualsPage
            // 
            this.individualsPage.Controls.Add(this.addIndividuals);
            this.individualsPage.Controls.Add(this.individualsDeleteButton);
            this.individualsPage.Controls.Add(this.individualsDataGrid);
            this.individualsPage.Location = new System.Drawing.Point(4, 25);
            this.individualsPage.Name = "individualsPage";
            this.individualsPage.Padding = new System.Windows.Forms.Padding(3);
            this.individualsPage.Size = new System.Drawing.Size(951, 525);
            this.individualsPage.TabIndex = 2;
            this.individualsPage.Text = "individuals";
            this.individualsPage.UseVisualStyleBackColor = true;
            // 
            // addIndividuals
            // 
            this.addIndividuals.Location = new System.Drawing.Point(488, 432);
            this.addIndividuals.Name = "addIndividuals";
            this.addIndividuals.Size = new System.Drawing.Size(186, 55);
            this.addIndividuals.TabIndex = 6;
            this.addIndividuals.Text = "add";
            this.addIndividuals.UseVisualStyleBackColor = true;
            this.addIndividuals.Click += new System.EventHandler(this.addIndividuals_Click);
            // 
            // individualsDeleteButton
            // 
            this.individualsDeleteButton.Location = new System.Drawing.Point(680, 432);
            this.individualsDeleteButton.Name = "individualsDeleteButton";
            this.individualsDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.individualsDeleteButton.TabIndex = 4;
            this.individualsDeleteButton.Text = "delete";
            this.individualsDeleteButton.UseVisualStyleBackColor = true;
            this.individualsDeleteButton.Click += new System.EventHandler(this.individualsDeleteButton_Click);
            // 
            // individualsDataGrid
            // 
            this.individualsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.individualsDataGrid.Location = new System.Drawing.Point(85, 37);
            this.individualsDataGrid.Name = "individualsDataGrid";
            this.individualsDataGrid.RowHeadersWidth = 51;
            this.individualsDataGrid.RowTemplate.Height = 24;
            this.individualsDataGrid.Size = new System.Drawing.Size(781, 303);
            this.individualsDataGrid.TabIndex = 3;
            // 
            // Pages
            // 
            this.Pages.Controls.Add(this.individualsPage);
            this.Pages.Controls.Add(this.legalEntitiesPage);
            this.Pages.Controls.Add(this.externalOrdersPage);
            this.Pages.Controls.Add(this.internalOrdersPage);
            this.Pages.Controls.Add(this.developmentTeamsPage);
            this.Pages.Controls.Add(this.designersPage);
            this.Pages.Controls.Add(this.employeesPage);
            this.Pages.Location = new System.Drawing.Point(12, 12);
            this.Pages.Name = "Pages";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(959, 554);
            this.Pages.TabIndex = 3;
            // 
            // showProductsButton
            // 
            this.showProductsButton.Location = new System.Drawing.Point(85, 432);
            this.showProductsButton.Name = "showProductsButton";
            this.showProductsButton.Size = new System.Drawing.Size(276, 55);
            this.showProductsButton.TabIndex = 6;
            this.showProductsButton.Text = "show products";
            this.showProductsButton.UseVisualStyleBackColor = true;
            this.showProductsButton.Click += new System.EventHandler(this.showProductsButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pages);
            this.Name = "mainForm";
            this.Text = "Design studio";
            this.panel1.ResumeLayout(false);
            this.employeesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGrid)).EndInit();
            this.designersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.designersDataGrid)).EndInit();
            this.developmentTeamsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.developmentTeamsDataGrid)).EndInit();
            this.internalOrdersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.internalOrdersDataGrid)).EndInit();
            this.externalOrdersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.externalOrdersDataGrid)).EndInit();
            this.legalEntitiesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.legalEntitiesDataGrid)).EndInit();
            this.individualsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.individualsDataGrid)).EndInit();
            this.Pages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Button connectButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage employeesPage;
        private System.Windows.Forms.Button employeesDeleteButton;
        private System.Windows.Forms.DataGridView employeesDataGrid;
        private System.Windows.Forms.TabPage designersPage;
        private System.Windows.Forms.Button designersDeleteButton;
        private System.Windows.Forms.DataGridView designersDataGrid;
        private System.Windows.Forms.TabPage developmentTeamsPage;
        private System.Windows.Forms.Button developmentTeamsAddButton;
        private System.Windows.Forms.Button developmentTeamsDeleteButton;
        private System.Windows.Forms.DataGridView developmentTeamsDataGrid;
        private System.Windows.Forms.TabPage internalOrdersPage;
        private System.Windows.Forms.Button internalOrdersAddButton;
        private System.Windows.Forms.Button internalOrdersDeleteButton;
        private System.Windows.Forms.DataGridView internalOrdersDataGrid;
        private System.Windows.Forms.TabPage externalOrdersPage;
        private System.Windows.Forms.Button externalOrdersAddButton;
        private System.Windows.Forms.Button externalOrdersDeleteButton;
        private System.Windows.Forms.DataGridView externalOrdersDataGrid;
        private System.Windows.Forms.TabPage legalEntitiesPage;
        private System.Windows.Forms.Button legalEntitiesAddButton;
        private System.Windows.Forms.Button legalEntitiesDeleteButton;
        private System.Windows.Forms.DataGridView legalEntitiesDataGrid;
        private System.Windows.Forms.TabPage individualsPage;
        private System.Windows.Forms.Button addIndividuals;
        private System.Windows.Forms.Button individualsDeleteButton;
        private System.Windows.Forms.DataGridView individualsDataGrid;
        private System.Windows.Forms.TabControl Pages;
        private System.Windows.Forms.Button showProductsButton;
    }
}

