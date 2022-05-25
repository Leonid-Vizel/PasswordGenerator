namespace PasswordGenerator.Forms
{
    partial class SendTCPForm
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
            this.ipLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.MaskedTextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.sendBtn = new FontAwesome.Sharp.IconButton();
            this.waitLabel = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(13, 9);
            this.ipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(26, 21);
            this.ipLabel.TabIndex = 1;
            this.ipLabel.Text = "IP:";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(261, 6);
            this.portTextBox.Mask = "09999";
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(56, 29);
            this.portTextBox.TabIndex = 4;
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(205, 9);
            this.portLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(49, 21);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "Порт:";
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.sendBtn.IconColor = System.Drawing.Color.Black;
            this.sendBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sendBtn.IconSize = 29;
            this.sendBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sendBtn.Location = new System.Drawing.Point(12, 41);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(305, 34);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "Отправить";
            this.sendBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // waitLabel
            // 
            this.waitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waitLabel.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.waitLabel.Location = new System.Drawing.Point(0, 0);
            this.waitLabel.Name = "waitLabel";
            this.waitLabel.Size = new System.Drawing.Size(835, 489);
            this.waitLabel.TabIndex = 6;
            this.waitLabel.Text = "Ожидайте...";
            this.waitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.waitLabel.Visible = false;
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(46, 6);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(152, 29);
            this.ipTextBox.TabIndex = 7;
            // 
            // SendTCPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 489);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.waitLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SendTCPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка отправки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.MaskedTextBox portTextBox;
        private System.Windows.Forms.Label portLabel;
        private FontAwesome.Sharp.IconButton sendBtn;
        private System.Windows.Forms.Label waitLabel;
        private System.Windows.Forms.TextBox ipTextBox;
    }
}