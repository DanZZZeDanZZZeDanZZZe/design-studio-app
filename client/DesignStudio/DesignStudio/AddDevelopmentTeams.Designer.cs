namespace DesignStudio
{
    partial class AddDevelopmentTeam
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
            this.label1 = new System.Windows.Forms.Label();
            this.leadersComboBox = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбрать лидера из списка дизайнеров";
            // 
            // leadersComboBox
            // 
            this.leadersComboBox.FormattingEnabled = true;
            this.leadersComboBox.Location = new System.Drawing.Point(309, 40);
            this.leadersComboBox.Name = "leadersComboBox";
            this.leadersComboBox.Size = new System.Drawing.Size(100, 24);
            this.leadersComboBox.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(257, 228);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(152, 43);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текущая дата";
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(309, 95);
            this.dateBox.Name = "dateBox";
            this.dateBox.ReadOnly = true;
            this.dateBox.Size = new System.Drawing.Size(100, 22);
            this.dateBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Установить ID";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(309, 152);
            this.IDBox.MaxLength = 3;
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 22);
            this.IDBox.TabIndex = 6;
            // 
            // AddDevelopmentTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 283);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.leadersComboBox);
            this.Controls.Add(this.label1);
            this.Name = "AddDevelopmentTeam";
            this.Text = "Добавить команду разработки";
            this.Load += new System.EventHandler(this.AddDevelopmentTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox leadersComboBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDBox;
    }
}