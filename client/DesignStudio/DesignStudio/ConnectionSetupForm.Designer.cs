namespace DesignStudio
{
    partial class ConnectionSetupForm
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
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.dBNameLabel = new System.Windows.Forms.Label();
            this.dBNameTextBox = new System.Windows.Forms.TextBox();
            this.saveAndExitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Location = new System.Drawing.Point(138, 26);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(326, 22);
            this.serverNameTextBox.TabIndex = 11;
            this.serverNameTextBox.TextChanged += new System.EventHandler(this.serverNameTextBox_TextChanged);
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(23, 26);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(93, 17);
            this.serverNameLabel.TabIndex = 10;
            this.serverNameLabel.Text = "Имя сервера";
            // 
            // dBNameLabel
            // 
            this.dBNameLabel.AutoSize = true;
            this.dBNameLabel.Location = new System.Drawing.Point(23, 67);
            this.dBNameLabel.Name = "dBNameLabel";
            this.dBNameLabel.Size = new System.Drawing.Size(72, 17);
            this.dBNameLabel.TabIndex = 9;
            this.dBNameLabel.Text = "Имя базы";
            this.dBNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dBNameTextBox
            // 
            this.dBNameTextBox.Location = new System.Drawing.Point(138, 62);
            this.dBNameTextBox.Name = "dBNameTextBox";
            this.dBNameTextBox.Size = new System.Drawing.Size(326, 22);
            this.dBNameTextBox.TabIndex = 8;
            this.dBNameTextBox.TextChanged += new System.EventHandler(this.dBNameTextBox_TextChanged);
            // 
            // saveAndExitButton
            // 
            this.saveAndExitButton.Enabled = false;
            this.saveAndExitButton.Location = new System.Drawing.Point(238, 169);
            this.saveAndExitButton.Name = "saveAndExitButton";
            this.saveAndExitButton.Size = new System.Drawing.Size(164, 41);
            this.saveAndExitButton.TabIndex = 7;
            this.saveAndExitButton.Text = "Сохранить и выйти";
            this.saveAndExitButton.UseVisualStyleBackColor = true;
            this.saveAndExitButton.Click += new System.EventHandler(this.saveAndExitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(409, 169);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 41);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ConnectionSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 242);
            this.Controls.Add(this.serverNameTextBox);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.dBNameLabel);
            this.Controls.Add(this.dBNameTextBox);
            this.Controls.Add(this.saveAndExitButton);
            this.Controls.Add(this.exitButton);
            this.Name = "ConnectionSetupForm";
            this.Text = "Настройки подключения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.Label dBNameLabel;
        private System.Windows.Forms.TextBox dBNameTextBox;
        private System.Windows.Forms.Button saveAndExitButton;
        private System.Windows.Forms.Button exitButton;
    }
}