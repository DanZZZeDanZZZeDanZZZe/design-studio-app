namespace DesignStudio
{
    partial class SendToTheTeam
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
            this.teamsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teamsComboBox
            // 
            this.teamsComboBox.FormattingEnabled = true;
            this.teamsComboBox.Location = new System.Drawing.Point(121, 57);
            this.teamsComboBox.Name = "teamsComboBox";
            this.teamsComboBox.Size = new System.Drawing.Size(100, 24);
            this.teamsComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Команда";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(98, 103);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(152, 43);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Направить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // SendToTheTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 158);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.teamsComboBox);
            this.Controls.Add(this.label1);
            this.Name = "SendToTheTeam";
            this.Text = "Направить в команду";
            this.Load += new System.EventHandler(this.SendToTheTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teamsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
    }
}