namespace DesignStudio
{
    partial class AddIndividualas
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
            this.sunameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PIDBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.patronymicBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sunameBox
            // 
            this.sunameBox.Location = new System.Drawing.Point(111, 144);
            this.sunameBox.Name = "sunameBox";
            this.sunameBox.Size = new System.Drawing.Size(100, 22);
            this.sunameBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Фамилия";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(111, 88);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Имя";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(111, 29);
            this.IDBox.MaxLength = 3;
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 22);
            this.IDBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(176, 226);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(152, 43);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(387, 144);
            this.numberBox.MaxLength = 11;
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(100, 22);
            this.numberBox.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Номер телефона";
            // 
            // PIDBox
            // 
            this.PIDBox.Location = new System.Drawing.Point(387, 88);
            this.PIDBox.MaxLength = 9;
            this.PIDBox.Name = "PIDBox";
            this.PIDBox.Size = new System.Drawing.Size(100, 22);
            this.PIDBox.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Отчество";
            // 
            // patronymicBox
            // 
            this.patronymicBox.Location = new System.Drawing.Point(387, 29);
            this.patronymicBox.Name = "patronymicBox";
            this.patronymicBox.Size = new System.Drawing.Size(100, 22);
            this.patronymicBox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Номер пасспрота";
            // 
            // AddIndividualas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 292);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PIDBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.patronymicBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sunameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAdd);
            this.Name = "AddIndividualas";
            this.Text = "Добавить физическое лицо";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sunameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PIDBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox patronymicBox;
        private System.Windows.Forms.Label label6;
    }
}