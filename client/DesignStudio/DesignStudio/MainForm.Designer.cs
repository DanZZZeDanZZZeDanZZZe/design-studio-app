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
            this.Pages = new System.Windows.Forms.TabControl();
            this.fontsPage = new System.Windows.Forms.TabPage();
            this.fontsDeleteButton = new System.Windows.Forms.Button();
            this.fontsDataGrid = new System.Windows.Forms.DataGridView();
            this.logosPage = new System.Windows.Forms.TabPage();
            this.LogosDeleteButton = new System.Windows.Forms.Button();
            this.logosDataGrid = new System.Windows.Forms.DataGridView();
            this.individualsPage = new System.Windows.Forms.TabPage();
            this.individualsDeleteButton = new System.Windows.Forms.Button();
            this.individualsDataGrid = new System.Windows.Forms.DataGridView();
            this.legalEntitiesPage = new System.Windows.Forms.TabPage();
            this.legalEntitiesDeleteButton = new System.Windows.Forms.Button();
            this.legalEntitiesDataGrid = new System.Windows.Forms.DataGridView();
            this.externalOrdersPage = new System.Windows.Forms.TabPage();
            this.externalOrdersDeleteButton = new System.Windows.Forms.Button();
            this.externalOrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.internalOrdersPage = new System.Windows.Forms.TabPage();
            this.internalOrdersAddButton = new System.Windows.Forms.Button();
            this.internalOrdersDeleteButton = new System.Windows.Forms.Button();
            this.internalOrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.developmentTeamsPage = new System.Windows.Forms.TabPage();
            this.developmentTeamsAddButton = new System.Windows.Forms.Button();
            this.developmentTeamsDeleteButton = new System.Windows.Forms.Button();
            this.developmentTeamsDataGrid = new System.Windows.Forms.DataGridView();
            this.designersPage = new System.Windows.Forms.TabPage();
            this.designersDeleteButton = new System.Windows.Forms.Button();
            this.designersDataGrid = new System.Windows.Forms.DataGridView();
            this.employeesPage = new System.Windows.Forms.TabPage();
            this.employeesDeleteButton = new System.Windows.Forms.Button();
            this.employeesDataGrid = new System.Windows.Forms.DataGridView();
            this.clothesPage = new System.Windows.Forms.TabPage();
            this.clothesDeleteButton = new System.Windows.Forms.Button();
            this.clothesDataGrid = new System.Windows.Forms.DataGridView();
            this.circlesPage = new System.Windows.Forms.TabPage();
            this.circlesDeleteButton = new System.Windows.Forms.Button();
            this.circlesDataGrid = new System.Windows.Forms.DataGridView();
            this.coversPage = new System.Windows.Forms.TabPage();
            this.coversDeleteButton = new System.Windows.Forms.Button();
            this.coversDataGrid = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pages.SuspendLayout();
            this.fontsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontsDataGrid)).BeginInit();
            this.logosPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logosDataGrid)).BeginInit();
            this.individualsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.individualsDataGrid)).BeginInit();
            this.legalEntitiesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.legalEntitiesDataGrid)).BeginInit();
            this.externalOrdersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.externalOrdersDataGrid)).BeginInit();
            this.internalOrdersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internalOrdersDataGrid)).BeginInit();
            this.developmentTeamsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.developmentTeamsDataGrid)).BeginInit();
            this.designersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designersDataGrid)).BeginInit();
            this.employeesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGrid)).BeginInit();
            this.clothesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clothesDataGrid)).BeginInit();
            this.circlesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlesDataGrid)).BeginInit();
            this.coversPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coversDataGrid)).BeginInit();
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
            // Pages
            // 
            this.Pages.Controls.Add(this.fontsPage);
            this.Pages.Controls.Add(this.logosPage);
            this.Pages.Controls.Add(this.individualsPage);
            this.Pages.Controls.Add(this.legalEntitiesPage);
            this.Pages.Controls.Add(this.externalOrdersPage);
            this.Pages.Controls.Add(this.internalOrdersPage);
            this.Pages.Controls.Add(this.developmentTeamsPage);
            this.Pages.Controls.Add(this.designersPage);
            this.Pages.Controls.Add(this.employeesPage);
            this.Pages.Controls.Add(this.clothesPage);
            this.Pages.Controls.Add(this.circlesPage);
            this.Pages.Controls.Add(this.coversPage);
            this.Pages.Location = new System.Drawing.Point(12, 12);
            this.Pages.Name = "Pages";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(959, 554);
            this.Pages.TabIndex = 3;
            // 
            // fontsPage
            // 
            this.fontsPage.Controls.Add(this.fontsDeleteButton);
            this.fontsPage.Controls.Add(this.fontsDataGrid);
            this.fontsPage.Location = new System.Drawing.Point(4, 25);
            this.fontsPage.Name = "fontsPage";
            this.fontsPage.Size = new System.Drawing.Size(951, 525);
            this.fontsPage.TabIndex = 0;
            this.fontsPage.Text = "fonts";
            this.fontsPage.UseVisualStyleBackColor = true;
            // 
            // fontsDeleteButton
            // 
            this.fontsDeleteButton.Location = new System.Drawing.Point(748, 458);
            this.fontsDeleteButton.Name = "fontsDeleteButton";
            this.fontsDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.fontsDeleteButton.TabIndex = 1;
            this.fontsDeleteButton.Text = "delete";
            this.fontsDeleteButton.UseVisualStyleBackColor = true;
            // 
            // fontsDataGrid
            // 
            this.fontsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fontsDataGrid.Location = new System.Drawing.Point(14, 24);
            this.fontsDataGrid.Name = "fontsDataGrid";
            this.fontsDataGrid.ReadOnly = true;
            this.fontsDataGrid.RowHeadersWidth = 51;
            this.fontsDataGrid.RowTemplate.Height = 24;
            this.fontsDataGrid.Size = new System.Drawing.Size(920, 341);
            this.fontsDataGrid.TabIndex = 0;
            // 
            // logosPage
            // 
            this.logosPage.Controls.Add(this.LogosDeleteButton);
            this.logosPage.Controls.Add(this.logosDataGrid);
            this.logosPage.Location = new System.Drawing.Point(4, 25);
            this.logosPage.Name = "logosPage";
            this.logosPage.Padding = new System.Windows.Forms.Padding(3);
            this.logosPage.Size = new System.Drawing.Size(951, 525);
            this.logosPage.TabIndex = 1;
            this.logosPage.Text = "logos";
            this.logosPage.UseVisualStyleBackColor = true;
            // 
            // LogosDeleteButton
            // 
            this.LogosDeleteButton.Location = new System.Drawing.Point(700, 443);
            this.LogosDeleteButton.Name = "LogosDeleteButton";
            this.LogosDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.LogosDeleteButton.TabIndex = 2;
            this.LogosDeleteButton.Text = "delete";
            this.LogosDeleteButton.UseVisualStyleBackColor = true;
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
            // 
            // individualsPage
            // 
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
            // legalEntitiesPage
            // 
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
            // externalOrdersPage
            // 
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
            // externalOrdersDeleteButton
            // 
            this.externalOrdersDeleteButton.Location = new System.Drawing.Point(680, 432);
            this.externalOrdersDeleteButton.Name = "externalOrdersDeleteButton";
            this.externalOrdersDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.externalOrdersDeleteButton.TabIndex = 4;
            this.externalOrdersDeleteButton.Text = "delete";
            this.externalOrdersDeleteButton.UseVisualStyleBackColor = true;
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
            // developmentTeamsPage
            // 
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
            // clothesPage
            // 
            this.clothesPage.Controls.Add(this.clothesDeleteButton);
            this.clothesPage.Controls.Add(this.clothesDataGrid);
            this.clothesPage.Location = new System.Drawing.Point(4, 25);
            this.clothesPage.Name = "clothesPage";
            this.clothesPage.Padding = new System.Windows.Forms.Padding(3);
            this.clothesPage.Size = new System.Drawing.Size(951, 525);
            this.clothesPage.TabIndex = 9;
            this.clothesPage.Text = "clothes";
            this.clothesPage.UseVisualStyleBackColor = true;
            // 
            // clothesDeleteButton
            // 
            this.clothesDeleteButton.Location = new System.Drawing.Point(680, 415);
            this.clothesDeleteButton.Name = "clothesDeleteButton";
            this.clothesDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.clothesDeleteButton.TabIndex = 4;
            this.clothesDeleteButton.Text = "delete";
            this.clothesDeleteButton.UseVisualStyleBackColor = true;
            // 
            // clothesDataGrid
            // 
            this.clothesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clothesDataGrid.Location = new System.Drawing.Point(85, 37);
            this.clothesDataGrid.Name = "clothesDataGrid";
            this.clothesDataGrid.RowHeadersWidth = 51;
            this.clothesDataGrid.RowTemplate.Height = 24;
            this.clothesDataGrid.Size = new System.Drawing.Size(781, 303);
            this.clothesDataGrid.TabIndex = 3;
            // 
            // circlesPage
            // 
            this.circlesPage.Controls.Add(this.circlesDeleteButton);
            this.circlesPage.Controls.Add(this.circlesDataGrid);
            this.circlesPage.Location = new System.Drawing.Point(4, 25);
            this.circlesPage.Name = "circlesPage";
            this.circlesPage.Padding = new System.Windows.Forms.Padding(3);
            this.circlesPage.Size = new System.Drawing.Size(951, 525);
            this.circlesPage.TabIndex = 10;
            this.circlesPage.Text = "circles";
            this.circlesPage.UseVisualStyleBackColor = true;
            // 
            // circlesDeleteButton
            // 
            this.circlesDeleteButton.Location = new System.Drawing.Point(680, 432);
            this.circlesDeleteButton.Name = "circlesDeleteButton";
            this.circlesDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.circlesDeleteButton.TabIndex = 4;
            this.circlesDeleteButton.Text = "delete";
            this.circlesDeleteButton.UseVisualStyleBackColor = true;
            // 
            // circlesDataGrid
            // 
            this.circlesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.circlesDataGrid.Location = new System.Drawing.Point(85, 37);
            this.circlesDataGrid.Name = "circlesDataGrid";
            this.circlesDataGrid.RowHeadersWidth = 51;
            this.circlesDataGrid.RowTemplate.Height = 24;
            this.circlesDataGrid.Size = new System.Drawing.Size(781, 303);
            this.circlesDataGrid.TabIndex = 3;
            // 
            // coversPage
            // 
            this.coversPage.Controls.Add(this.coversDeleteButton);
            this.coversPage.Controls.Add(this.coversDataGrid);
            this.coversPage.Location = new System.Drawing.Point(4, 25);
            this.coversPage.Name = "coversPage";
            this.coversPage.Padding = new System.Windows.Forms.Padding(3);
            this.coversPage.Size = new System.Drawing.Size(951, 525);
            this.coversPage.TabIndex = 11;
            this.coversPage.Text = "covers";
            this.coversPage.UseVisualStyleBackColor = true;
            // 
            // coversDeleteButton
            // 
            this.coversDeleteButton.Location = new System.Drawing.Point(680, 432);
            this.coversDeleteButton.Name = "coversDeleteButton";
            this.coversDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.coversDeleteButton.TabIndex = 4;
            this.coversDeleteButton.Text = "delete";
            this.coversDeleteButton.UseVisualStyleBackColor = true;
            // 
            // coversDataGrid
            // 
            this.coversDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coversDataGrid.Location = new System.Drawing.Point(85, 37);
            this.coversDataGrid.Name = "coversDataGrid";
            this.coversDataGrid.RowHeadersWidth = 51;
            this.coversDataGrid.RowTemplate.Height = 24;
            this.coversDataGrid.Size = new System.Drawing.Size(781, 303);
            this.coversDataGrid.TabIndex = 3;
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
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pages);
            this.Name = "mainForm";
            this.Text = "Design studio";
            this.Pages.ResumeLayout(false);
            this.fontsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fontsDataGrid)).EndInit();
            this.logosPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logosDataGrid)).EndInit();
            this.individualsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.individualsDataGrid)).EndInit();
            this.legalEntitiesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.legalEntitiesDataGrid)).EndInit();
            this.externalOrdersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.externalOrdersDataGrid)).EndInit();
            this.internalOrdersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.internalOrdersDataGrid)).EndInit();
            this.developmentTeamsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.developmentTeamsDataGrid)).EndInit();
            this.designersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.designersDataGrid)).EndInit();
            this.employeesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGrid)).EndInit();
            this.clothesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clothesDataGrid)).EndInit();
            this.circlesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circlesDataGrid)).EndInit();
            this.coversPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coversDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TabControl Pages;
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
        private System.Windows.Forms.Button fontsDeleteButton;
        private System.Windows.Forms.Button LogosDeleteButton;
        private System.Windows.Forms.Button individualsDeleteButton;
        private System.Windows.Forms.DataGridView individualsDataGrid;
        private System.Windows.Forms.Button legalEntitiesDeleteButton;
        private System.Windows.Forms.DataGridView legalEntitiesDataGrid;
        private System.Windows.Forms.Button externalOrdersDeleteButton;
        private System.Windows.Forms.DataGridView externalOrdersDataGrid;
        private System.Windows.Forms.Button internalOrdersDeleteButton;
        private System.Windows.Forms.DataGridView internalOrdersDataGrid;
        private System.Windows.Forms.Button developmentTeamsDeleteButton;
        private System.Windows.Forms.DataGridView developmentTeamsDataGrid;
        private System.Windows.Forms.Button designersDeleteButton;
        private System.Windows.Forms.DataGridView designersDataGrid;
        private System.Windows.Forms.Button employeesDeleteButton;
        private System.Windows.Forms.DataGridView employeesDataGrid;
        private System.Windows.Forms.Button clothesDeleteButton;
        private System.Windows.Forms.DataGridView clothesDataGrid;
        private System.Windows.Forms.Button circlesDeleteButton;
        private System.Windows.Forms.DataGridView circlesDataGrid;
        private System.Windows.Forms.Button coversDeleteButton;
        private System.Windows.Forms.DataGridView coversDataGrid;
        private System.Windows.Forms.Button developmentTeamsAddButton;
        private System.Windows.Forms.Button internalOrdersAddButton;
    }
}

