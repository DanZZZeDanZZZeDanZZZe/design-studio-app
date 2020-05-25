﻿namespace DesignStudio
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
            this.employeesDataGrid = new System.Windows.Forms.DataGridView();
            this.designersPage = new System.Windows.Forms.TabPage();
            this.sendToTheTeamButton = new System.Windows.Forms.Button();
            this.designersDataGrid = new System.Windows.Forms.DataGridView();
            this.developmentTeamsPage = new System.Windows.Forms.TabPage();
            this.showProductsButton = new System.Windows.Forms.Button();
            this.developmentTeamsAddButton = new System.Windows.Forms.Button();
            this.developmentTeamsDeleteButton = new System.Windows.Forms.Button();
            this.developmentTeamsDataGrid = new System.Windows.Forms.DataGridView();
            this.externalOrdersPage = new System.Windows.Forms.TabPage();
            this.openCheckButton = new System.Windows.Forms.Button();
            this.externalOrdersAddButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonExUndone = new System.Windows.Forms.RadioButton();
            this.radioButtonExDone = new System.Windows.Forms.RadioButton();
            this.externalOrdersMarkButton = new System.Windows.Forms.Button();
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
            this.internalOrdersPage = new System.Windows.Forms.TabPage();
            this.internalOrdersMarkButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonIntUndone = new System.Windows.Forms.RadioButton();
            this.radioButtonIntDone = new System.Windows.Forms.RadioButton();
            this.internalOrdersAddButton = new System.Windows.Forms.Button();
            this.internalOrdersDeleteButton = new System.Windows.Forms.Button();
            this.internalOrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.employeesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGrid)).BeginInit();
            this.designersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designersDataGrid)).BeginInit();
            this.developmentTeamsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.developmentTeamsDataGrid)).BeginInit();
            this.externalOrdersPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.externalOrdersDataGrid)).BeginInit();
            this.legalEntitiesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.legalEntitiesDataGrid)).BeginInit();
            this.individualsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.individualsDataGrid)).BeginInit();
            this.Pages.SuspendLayout();
            this.internalOrdersPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internalOrdersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // settingButton
            // 
            this.settingButton.Location = new System.Drawing.Point(25, 72);
            this.settingButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(216, 47);
            this.settingButton.TabIndex = 2;
            this.settingButton.Text = "Настройки подключения";
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
            this.connectButton.Text = "Подключение";
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
            this.employeesPage.Controls.Add(this.employeesDataGrid);
            this.employeesPage.Location = new System.Drawing.Point(4, 25);
            this.employeesPage.Name = "employeesPage";
            this.employeesPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeesPage.Size = new System.Drawing.Size(951, 525);
            this.employeesPage.TabIndex = 8;
            this.employeesPage.Text = "работники";
            this.employeesPage.UseVisualStyleBackColor = true;
            // 
            // employeesDataGrid
            // 
            this.employeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGrid.Location = new System.Drawing.Point(-4, 0);
            this.employeesDataGrid.Name = "employeesDataGrid";
            this.employeesDataGrid.ReadOnly = true;
            this.employeesDataGrid.RowHeadersWidth = 51;
            this.employeesDataGrid.RowTemplate.Height = 24;
            this.employeesDataGrid.Size = new System.Drawing.Size(951, 529);
            this.employeesDataGrid.TabIndex = 3;
            // 
            // designersPage
            // 
            this.designersPage.Controls.Add(this.sendToTheTeamButton);
            this.designersPage.Controls.Add(this.designersDataGrid);
            this.designersPage.Location = new System.Drawing.Point(4, 25);
            this.designersPage.Name = "designersPage";
            this.designersPage.Padding = new System.Windows.Forms.Padding(3);
            this.designersPage.Size = new System.Drawing.Size(951, 525);
            this.designersPage.TabIndex = 7;
            this.designersPage.Text = "дизайнеры";
            this.designersPage.UseVisualStyleBackColor = true;
            // 
            // sendToTheTeamButton
            // 
            this.sendToTheTeamButton.Location = new System.Drawing.Point(749, 450);
            this.sendToTheTeamButton.Name = "sendToTheTeamButton";
            this.sendToTheTeamButton.Size = new System.Drawing.Size(186, 55);
            this.sendToTheTeamButton.TabIndex = 5;
            this.sendToTheTeamButton.Text = "направить в команду";
            this.sendToTheTeamButton.UseVisualStyleBackColor = true;
            this.sendToTheTeamButton.Click += new System.EventHandler(this.sendToTheTeamButton_Click);
            // 
            // designersDataGrid
            // 
            this.designersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.designersDataGrid.Location = new System.Drawing.Point(0, 0);
            this.designersDataGrid.Name = "designersDataGrid";
            this.designersDataGrid.ReadOnly = true;
            this.designersDataGrid.RowHeadersWidth = 51;
            this.designersDataGrid.RowTemplate.Height = 24;
            this.designersDataGrid.Size = new System.Drawing.Size(951, 432);
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
            this.developmentTeamsPage.Text = "команды разработки";
            this.developmentTeamsPage.UseVisualStyleBackColor = true;
            // 
            // showProductsButton
            // 
            this.showProductsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.showProductsButton.Location = new System.Drawing.Point(85, 432);
            this.showProductsButton.Name = "showProductsButton";
            this.showProductsButton.Size = new System.Drawing.Size(276, 55);
            this.showProductsButton.TabIndex = 6;
            this.showProductsButton.Text = "показать продукцию";
            this.showProductsButton.UseVisualStyleBackColor = true;
            this.showProductsButton.Click += new System.EventHandler(this.showProductsButton_Click);
            // 
            // developmentTeamsAddButton
            // 
            this.developmentTeamsAddButton.Location = new System.Drawing.Point(471, 432);
            this.developmentTeamsAddButton.Name = "developmentTeamsAddButton";
            this.developmentTeamsAddButton.Size = new System.Drawing.Size(186, 55);
            this.developmentTeamsAddButton.TabIndex = 5;
            this.developmentTeamsAddButton.Text = "добавить";
            this.developmentTeamsAddButton.UseVisualStyleBackColor = true;
            this.developmentTeamsAddButton.Click += new System.EventHandler(this.developmentTeamsAddButton_Click);
            // 
            // developmentTeamsDeleteButton
            // 
            this.developmentTeamsDeleteButton.Location = new System.Drawing.Point(680, 432);
            this.developmentTeamsDeleteButton.Name = "developmentTeamsDeleteButton";
            this.developmentTeamsDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.developmentTeamsDeleteButton.TabIndex = 4;
            this.developmentTeamsDeleteButton.Text = "удалить";
            this.developmentTeamsDeleteButton.UseVisualStyleBackColor = true;
            this.developmentTeamsDeleteButton.Click += new System.EventHandler(this.developmentTeamsDeleteButton_Click);
            // 
            // developmentTeamsDataGrid
            // 
            this.developmentTeamsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.developmentTeamsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.developmentTeamsDataGrid.Name = "developmentTeamsDataGrid";
            this.developmentTeamsDataGrid.ReadOnly = true;
            this.developmentTeamsDataGrid.RowHeadersWidth = 51;
            this.developmentTeamsDataGrid.RowTemplate.Height = 24;
            this.developmentTeamsDataGrid.Size = new System.Drawing.Size(951, 401);
            this.developmentTeamsDataGrid.TabIndex = 3;
            // 
            // externalOrdersPage
            // 
            this.externalOrdersPage.Controls.Add(this.openCheckButton);
            this.externalOrdersPage.Controls.Add(this.externalOrdersAddButton);
            this.externalOrdersPage.Controls.Add(this.groupBox1);
            this.externalOrdersPage.Controls.Add(this.externalOrdersMarkButton);
            this.externalOrdersPage.Controls.Add(this.externalOrdersDeleteButton);
            this.externalOrdersPage.Controls.Add(this.externalOrdersDataGrid);
            this.externalOrdersPage.Location = new System.Drawing.Point(4, 25);
            this.externalOrdersPage.Name = "externalOrdersPage";
            this.externalOrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.externalOrdersPage.Size = new System.Drawing.Size(951, 525);
            this.externalOrdersPage.TabIndex = 4;
            this.externalOrdersPage.Text = "внешние заказы";
            this.externalOrdersPage.UseVisualStyleBackColor = true;
            // 
            // openCheckButton
            // 
            this.openCheckButton.Enabled = false;
            this.openCheckButton.Location = new System.Drawing.Point(296, 371);
            this.openCheckButton.Name = "openCheckButton";
            this.openCheckButton.Size = new System.Drawing.Size(186, 55);
            this.openCheckButton.TabIndex = 17;
            this.openCheckButton.Text = "открыть чек";
            this.openCheckButton.UseVisualStyleBackColor = true;
            this.openCheckButton.Click += new System.EventHandler(this.openCheckButton_Click);
            // 
            // externalOrdersAddButton
            // 
            this.externalOrdersAddButton.Location = new System.Drawing.Point(488, 432);
            this.externalOrdersAddButton.Name = "externalOrdersAddButton";
            this.externalOrdersAddButton.Size = new System.Drawing.Size(186, 55);
            this.externalOrdersAddButton.TabIndex = 16;
            this.externalOrdersAddButton.Text = "добавить";
            this.externalOrdersAddButton.UseVisualStyleBackColor = true;
            this.externalOrdersAddButton.Click += new System.EventHandler(this.externalOrdersAddButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonExUndone);
            this.groupBox1.Controls.Add(this.radioButtonExDone);
            this.groupBox1.Location = new System.Drawing.Point(90, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 116);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отображение заказов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 13;
            // 
            // radioButtonExUndone
            // 
            this.radioButtonExUndone.AutoSize = true;
            this.radioButtonExUndone.Checked = true;
            this.radioButtonExUndone.Location = new System.Drawing.Point(6, 34);
            this.radioButtonExUndone.Name = "radioButtonExUndone";
            this.radioButtonExUndone.Size = new System.Drawing.Size(138, 21);
            this.radioButtonExUndone.TabIndex = 16;
            this.radioButtonExUndone.TabStop = true;
            this.radioButtonExUndone.Text = "Невыполненные";
            this.radioButtonExUndone.UseVisualStyleBackColor = true;
            this.radioButtonExUndone.CheckedChanged += new System.EventHandler(this.radioButtonEx_CheckedChanged);
            // 
            // radioButtonExDone
            // 
            this.radioButtonExDone.AutoSize = true;
            this.radioButtonExDone.Location = new System.Drawing.Point(6, 78);
            this.radioButtonExDone.Name = "radioButtonExDone";
            this.radioButtonExDone.Size = new System.Drawing.Size(122, 21);
            this.radioButtonExDone.TabIndex = 15;
            this.radioButtonExDone.Text = "Выполненные";
            this.radioButtonExDone.UseVisualStyleBackColor = true;
            this.radioButtonExDone.CheckedChanged += new System.EventHandler(this.radioButtonEx_CheckedChanged);
            // 
            // externalOrdersMarkButton
            // 
            this.externalOrdersMarkButton.Location = new System.Drawing.Point(296, 432);
            this.externalOrdersMarkButton.Name = "externalOrdersMarkButton";
            this.externalOrdersMarkButton.Size = new System.Drawing.Size(186, 55);
            this.externalOrdersMarkButton.TabIndex = 5;
            this.externalOrdersMarkButton.Text = "отметить выполнение";
            this.externalOrdersMarkButton.UseVisualStyleBackColor = true;
            this.externalOrdersMarkButton.Click += new System.EventHandler(this.externalOrdersMarkButton_Click);
            // 
            // externalOrdersDeleteButton
            // 
            this.externalOrdersDeleteButton.Location = new System.Drawing.Point(680, 432);
            this.externalOrdersDeleteButton.Name = "externalOrdersDeleteButton";
            this.externalOrdersDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.externalOrdersDeleteButton.TabIndex = 4;
            this.externalOrdersDeleteButton.Text = "удалить";
            this.externalOrdersDeleteButton.UseVisualStyleBackColor = true;
            this.externalOrdersDeleteButton.Click += new System.EventHandler(this.externalOrdersDeleteButton_Click);
            // 
            // externalOrdersDataGrid
            // 
            this.externalOrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.externalOrdersDataGrid.Location = new System.Drawing.Point(-4, 0);
            this.externalOrdersDataGrid.Name = "externalOrdersDataGrid";
            this.externalOrdersDataGrid.ReadOnly = true;
            this.externalOrdersDataGrid.RowHeadersWidth = 51;
            this.externalOrdersDataGrid.RowTemplate.Height = 24;
            this.externalOrdersDataGrid.Size = new System.Drawing.Size(955, 340);
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
            this.legalEntitiesPage.Text = "юридические лица";
            this.legalEntitiesPage.UseVisualStyleBackColor = true;
            // 
            // legalEntitiesAddButton
            // 
            this.legalEntitiesAddButton.Location = new System.Drawing.Point(488, 432);
            this.legalEntitiesAddButton.Name = "legalEntitiesAddButton";
            this.legalEntitiesAddButton.Size = new System.Drawing.Size(186, 55);
            this.legalEntitiesAddButton.TabIndex = 5;
            this.legalEntitiesAddButton.Text = "добавить";
            this.legalEntitiesAddButton.UseVisualStyleBackColor = true;
            this.legalEntitiesAddButton.Click += new System.EventHandler(this.legalEntitiesAddButton_Click);
            // 
            // legalEntitiesDeleteButton
            // 
            this.legalEntitiesDeleteButton.Location = new System.Drawing.Point(680, 432);
            this.legalEntitiesDeleteButton.Name = "legalEntitiesDeleteButton";
            this.legalEntitiesDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.legalEntitiesDeleteButton.TabIndex = 4;
            this.legalEntitiesDeleteButton.Text = "удалить";
            this.legalEntitiesDeleteButton.UseVisualStyleBackColor = true;
            this.legalEntitiesDeleteButton.Click += new System.EventHandler(this.legalEntitiesDeleteButton_Click);
            // 
            // legalEntitiesDataGrid
            // 
            this.legalEntitiesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.legalEntitiesDataGrid.Location = new System.Drawing.Point(-1, 0);
            this.legalEntitiesDataGrid.Name = "legalEntitiesDataGrid";
            this.legalEntitiesDataGrid.ReadOnly = true;
            this.legalEntitiesDataGrid.RowHeadersWidth = 51;
            this.legalEntitiesDataGrid.RowTemplate.Height = 24;
            this.legalEntitiesDataGrid.Size = new System.Drawing.Size(952, 340);
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
            this.individualsPage.Text = "физические лица";
            this.individualsPage.UseVisualStyleBackColor = true;
            // 
            // addIndividuals
            // 
            this.addIndividuals.Location = new System.Drawing.Point(488, 432);
            this.addIndividuals.Name = "addIndividuals";
            this.addIndividuals.Size = new System.Drawing.Size(186, 55);
            this.addIndividuals.TabIndex = 6;
            this.addIndividuals.Text = "добавить";
            this.addIndividuals.UseVisualStyleBackColor = true;
            this.addIndividuals.Click += new System.EventHandler(this.addIndividuals_Click);
            // 
            // individualsDeleteButton
            // 
            this.individualsDeleteButton.Location = new System.Drawing.Point(680, 432);
            this.individualsDeleteButton.Name = "individualsDeleteButton";
            this.individualsDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.individualsDeleteButton.TabIndex = 4;
            this.individualsDeleteButton.Text = "удалить";
            this.individualsDeleteButton.UseVisualStyleBackColor = true;
            this.individualsDeleteButton.Click += new System.EventHandler(this.individualsDeleteButton_Click);
            // 
            // individualsDataGrid
            // 
            this.individualsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.individualsDataGrid.Location = new System.Drawing.Point(-3, 0);
            this.individualsDataGrid.Name = "individualsDataGrid";
            this.individualsDataGrid.ReadOnly = true;
            this.individualsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.individualsDataGrid.RowTemplate.Height = 24;
            this.individualsDataGrid.Size = new System.Drawing.Size(951, 390);
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
            this.Pages.Location = new System.Drawing.Point(12, 9);
            this.Pages.Name = "Pages";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(959, 554);
            this.Pages.TabIndex = 3;
            this.Pages.Visible = false;
            // 
            // internalOrdersPage
            // 
            this.internalOrdersPage.Controls.Add(this.internalOrdersMarkButton);
            this.internalOrdersPage.Controls.Add(this.groupBox2);
            this.internalOrdersPage.Controls.Add(this.internalOrdersAddButton);
            this.internalOrdersPage.Controls.Add(this.internalOrdersDeleteButton);
            this.internalOrdersPage.Controls.Add(this.internalOrdersDataGrid);
            this.internalOrdersPage.Location = new System.Drawing.Point(4, 25);
            this.internalOrdersPage.Name = "internalOrdersPage";
            this.internalOrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.internalOrdersPage.Size = new System.Drawing.Size(951, 525);
            this.internalOrdersPage.TabIndex = 5;
            this.internalOrdersPage.Text = "внутренние заказы";
            this.internalOrdersPage.UseVisualStyleBackColor = true;
            // 
            // internalOrdersMarkButton
            // 
            this.internalOrdersMarkButton.Location = new System.Drawing.Point(263, 432);
            this.internalOrdersMarkButton.Name = "internalOrdersMarkButton";
            this.internalOrdersMarkButton.Size = new System.Drawing.Size(186, 55);
            this.internalOrdersMarkButton.TabIndex = 17;
            this.internalOrdersMarkButton.Text = "отметить выполнение";
            this.internalOrdersMarkButton.UseVisualStyleBackColor = true;
            this.internalOrdersMarkButton.Click += new System.EventHandler(this.internalOrdersMarkButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.radioButtonIntUndone);
            this.groupBox2.Controls.Add(this.radioButtonIntDone);
            this.groupBox2.Location = new System.Drawing.Point(57, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 116);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отображение заказов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 13;
            // 
            // radioButtonIntUndone
            // 
            this.radioButtonIntUndone.AutoSize = true;
            this.radioButtonIntUndone.Checked = true;
            this.radioButtonIntUndone.Location = new System.Drawing.Point(6, 33);
            this.radioButtonIntUndone.Name = "radioButtonIntUndone";
            this.radioButtonIntUndone.Size = new System.Drawing.Size(138, 21);
            this.radioButtonIntUndone.TabIndex = 16;
            this.radioButtonIntUndone.TabStop = true;
            this.radioButtonIntUndone.Text = "Невыполненный";
            this.radioButtonIntUndone.UseVisualStyleBackColor = true;
            this.radioButtonIntUndone.CheckedChanged += new System.EventHandler(this.radioButtonIn_CheckedChanged);
            // 
            // radioButtonIntDone
            // 
            this.radioButtonIntDone.AutoSize = true;
            this.radioButtonIntDone.Location = new System.Drawing.Point(6, 60);
            this.radioButtonIntDone.Name = "radioButtonIntDone";
            this.radioButtonIntDone.Size = new System.Drawing.Size(122, 21);
            this.radioButtonIntDone.TabIndex = 15;
            this.radioButtonIntDone.Text = "Выполненный";
            this.radioButtonIntDone.UseVisualStyleBackColor = true;
            this.radioButtonIntDone.CheckedChanged += new System.EventHandler(this.radioButtonIn_CheckedChanged);
            // 
            // internalOrdersAddButton
            // 
            this.internalOrdersAddButton.Location = new System.Drawing.Point(472, 432);
            this.internalOrdersAddButton.Name = "internalOrdersAddButton";
            this.internalOrdersAddButton.Size = new System.Drawing.Size(186, 55);
            this.internalOrdersAddButton.TabIndex = 5;
            this.internalOrdersAddButton.Text = "добавить";
            this.internalOrdersAddButton.UseVisualStyleBackColor = true;
            this.internalOrdersAddButton.Click += new System.EventHandler(this.internalOrdersAddButton_Click);
            // 
            // internalOrdersDeleteButton
            // 
            this.internalOrdersDeleteButton.Location = new System.Drawing.Point(680, 432);
            this.internalOrdersDeleteButton.Name = "internalOrdersDeleteButton";
            this.internalOrdersDeleteButton.Size = new System.Drawing.Size(186, 55);
            this.internalOrdersDeleteButton.TabIndex = 4;
            this.internalOrdersDeleteButton.Text = "удалить";
            this.internalOrdersDeleteButton.UseVisualStyleBackColor = true;
            this.internalOrdersDeleteButton.Click += new System.EventHandler(this.internalOrdersDeleteButton_Click);
            // 
            // internalOrdersDataGrid
            // 
            this.internalOrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.internalOrdersDataGrid.Location = new System.Drawing.Point(0, 0);
            this.internalOrdersDataGrid.Name = "internalOrdersDataGrid";
            this.internalOrdersDataGrid.ReadOnly = true;
            this.internalOrdersDataGrid.RowHeadersWidth = 51;
            this.internalOrdersDataGrid.RowTemplate.Height = 24;
            this.internalOrdersDataGrid.Size = new System.Drawing.Size(948, 366);
            this.internalOrdersDataGrid.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(313, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(479, 39);
            this.label.TabIndex = 6;
            this.label.Text = "База данных не подключена";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pages);
            this.Controls.Add(this.label);
            this.Name = "mainForm";
            this.Text = "Дизайн студия";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.employeesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGrid)).EndInit();
            this.designersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.designersDataGrid)).EndInit();
            this.developmentTeamsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.developmentTeamsDataGrid)).EndInit();
            this.externalOrdersPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.externalOrdersDataGrid)).EndInit();
            this.legalEntitiesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.legalEntitiesDataGrid)).EndInit();
            this.individualsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.individualsDataGrid)).EndInit();
            this.Pages.ResumeLayout(false);
            this.internalOrdersPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internalOrdersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Button connectButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage employeesPage;
        private System.Windows.Forms.DataGridView employeesDataGrid;
        private System.Windows.Forms.TabPage designersPage;
        private System.Windows.Forms.DataGridView designersDataGrid;
        private System.Windows.Forms.TabPage developmentTeamsPage;
        private System.Windows.Forms.Button developmentTeamsAddButton;
        private System.Windows.Forms.Button developmentTeamsDeleteButton;
        private System.Windows.Forms.DataGridView developmentTeamsDataGrid;
        private System.Windows.Forms.TabPage externalOrdersPage;
        private System.Windows.Forms.Button externalOrdersMarkButton;
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
        private System.Windows.Forms.Button sendToTheTeamButton;
        private System.Windows.Forms.TabPage internalOrdersPage;
        private System.Windows.Forms.Button internalOrdersAddButton;
        private System.Windows.Forms.Button internalOrdersDeleteButton;
        private System.Windows.Forms.DataGridView internalOrdersDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonExUndone;
        private System.Windows.Forms.RadioButton radioButtonExDone;
        private System.Windows.Forms.Button externalOrdersAddButton;
        private System.Windows.Forms.Button openCheckButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonIntUndone;
        private System.Windows.Forms.RadioButton radioButtonIntDone;
        private System.Windows.Forms.Button internalOrdersMarkButton;
    }
}

