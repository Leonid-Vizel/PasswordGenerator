namespace PasswordGenerator.Forms
{
    partial class ReceiveSSLForm
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
            this.portTextBox = new System.Windows.Forms.MaskedTextBox();
            this.waitPanel = new System.Windows.Forms.Panel();
            this.cancelWaitBtn = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.loadingBox = new System.Windows.Forms.PictureBox();
            this.ReceiveBtn = new FontAwesome.Sharp.IconButton();
            this.askPortPanel = new System.Windows.Forms.Panel();
            this.foundPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveBtn = new FontAwesome.Sharp.IconButton();
            this.cancelSaveBtn = new FontAwesome.Sharp.IconButton();
            this.waitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).BeginInit();
            this.askPortPanel.SuspendLayout();
            this.foundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Порт получения:";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(139, 3);
            this.portTextBox.Mask = "000999";
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(56, 29);
            this.portTextBox.TabIndex = 5;
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // waitPanel
            // 
            this.waitPanel.Controls.Add(this.cancelWaitBtn);
            this.waitPanel.Controls.Add(this.label2);
            this.waitPanel.Controls.Add(this.loadingBox);
            this.waitPanel.Location = new System.Drawing.Point(12, 148);
            this.waitPanel.Name = "waitPanel";
            this.waitPanel.Size = new System.Drawing.Size(323, 130);
            this.waitPanel.TabIndex = 7;
            this.waitPanel.Visible = false;
            // 
            // cancelWaitBtn
            // 
            this.cancelWaitBtn.BackColor = System.Drawing.Color.Crimson;
            this.cancelWaitBtn.FlatAppearance.BorderSize = 0;
            this.cancelWaitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelWaitBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.cancelWaitBtn.IconColor = System.Drawing.Color.Black;
            this.cancelWaitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelWaitBtn.IconSize = 30;
            this.cancelWaitBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.cancelWaitBtn.Location = new System.Drawing.Point(133, 93);
            this.cancelWaitBtn.Name = "cancelWaitBtn";
            this.cancelWaitBtn.Rotation = 45D;
            this.cancelWaitBtn.Size = new System.Drawing.Size(187, 34);
            this.cancelWaitBtn.TabIndex = 7;
            this.cancelWaitBtn.Text = "Отмена";
            this.cancelWaitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelWaitBtn.UseVisualStyleBackColor = false;
            this.cancelWaitBtn.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP: 123.123.123.123\r\nПорт: 11111";
            // 
            // loadingBox
            // 
            this.loadingBox.Image = global::PasswordGenerator.Properties.Resources.loading;
            this.loadingBox.Location = new System.Drawing.Point(3, 3);
            this.loadingBox.Name = "loadingBox";
            this.loadingBox.Size = new System.Drawing.Size(124, 124);
            this.loadingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingBox.TabIndex = 0;
            this.loadingBox.TabStop = false;
            // 
            // ReceiveBtn
            // 
            this.ReceiveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.ReceiveBtn.FlatAppearance.BorderSize = 0;
            this.ReceiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReceiveBtn.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.ReceiveBtn.IconColor = System.Drawing.Color.Black;
            this.ReceiveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReceiveBtn.IconSize = 29;
            this.ReceiveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReceiveBtn.Location = new System.Drawing.Point(7, 38);
            this.ReceiveBtn.Name = "ReceiveBtn";
            this.ReceiveBtn.Size = new System.Drawing.Size(188, 34);
            this.ReceiveBtn.TabIndex = 6;
            this.ReceiveBtn.Text = "Начать получение";
            this.ReceiveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReceiveBtn.UseVisualStyleBackColor = false;
            this.ReceiveBtn.Click += new System.EventHandler(this.ReceiveBtn_Click);
            // 
            // askPortPanel
            // 
            this.askPortPanel.Controls.Add(this.label1);
            this.askPortPanel.Controls.Add(this.portTextBox);
            this.askPortPanel.Controls.Add(this.ReceiveBtn);
            this.askPortPanel.Location = new System.Drawing.Point(12, 12);
            this.askPortPanel.Name = "askPortPanel";
            this.askPortPanel.Size = new System.Drawing.Size(323, 130);
            this.askPortPanel.TabIndex = 8;
            // 
            // foundPanel
            // 
            this.foundPanel.Controls.Add(this.cancelSaveBtn);
            this.foundPanel.Controls.Add(this.saveBtn);
            this.foundPanel.Controls.Add(this.pictureBox1);
            this.foundPanel.Controls.Add(this.label3);
            this.foundPanel.Location = new System.Drawing.Point(12, 284);
            this.foundPanel.Name = "foundPanel";
            this.foundPanel.Size = new System.Drawing.Size(354, 130);
            this.foundPanel.TabIndex = 9;
            this.foundPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(133, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "Пароль картинка-получена!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Green;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.saveBtn.IconColor = System.Drawing.Color.Black;
            this.saveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveBtn.IconSize = 30;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.saveBtn.Location = new System.Drawing.Point(133, 93);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(218, 34);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // cancelSaveBtn
            // 
            this.cancelSaveBtn.BackColor = System.Drawing.Color.Crimson;
            this.cancelSaveBtn.FlatAppearance.BorderSize = 0;
            this.cancelSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelSaveBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.cancelSaveBtn.IconColor = System.Drawing.Color.Black;
            this.cancelSaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelSaveBtn.IconSize = 30;
            this.cancelSaveBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.cancelSaveBtn.Location = new System.Drawing.Point(133, 53);
            this.cancelSaveBtn.Name = "cancelSaveBtn";
            this.cancelSaveBtn.Rotation = 45D;
            this.cancelSaveBtn.Size = new System.Drawing.Size(218, 34);
            this.cancelSaveBtn.TabIndex = 9;
            this.cancelSaveBtn.Text = "Отмена";
            this.cancelSaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelSaveBtn.UseVisualStyleBackColor = false;
            // 
            // ReceiveSSLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 489);
            this.Controls.Add(this.foundPanel);
            this.Controls.Add(this.askPortPanel);
            this.Controls.Add(this.waitPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReceiveSSLForm";
            this.Text = "Получение картинки-пароля";
            this.waitPanel.ResumeLayout(false);
            this.waitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).EndInit();
            this.askPortPanel.ResumeLayout(false);
            this.askPortPanel.PerformLayout();
            this.foundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox portTextBox;
        private FontAwesome.Sharp.IconButton ReceiveBtn;
        private System.Windows.Forms.Panel waitPanel;
        private System.Windows.Forms.PictureBox loadingBox;
        private FontAwesome.Sharp.IconButton cancelWaitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel askPortPanel;
        private System.Windows.Forms.Panel foundPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton saveBtn;
        private FontAwesome.Sharp.IconButton cancelSaveBtn;
    }
}