namespace PasswordGenerator.Forms
{
    partial class SavedPasswordsForm
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
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.searchLabel = new System.Windows.Forms.Label();
            this.workPanel = new System.Windows.Forms.Panel();
            this.designPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.receiveBtn = new FontAwesome.Sharp.IconButton();
            this.searchPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchBox);
            this.searchPanel.Controls.Add(this.searchBtn);
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(747, 36);
            this.searchPanel.TabIndex = 0;
            this.searchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderDraw);
            // 
            // searchBox
            // 
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(57, 0);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(602, 36);
            this.searchBox.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(183)))), ((int)(((byte)(108)))));
            this.searchBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBtn.IconColor = System.Drawing.Color.Black;
            this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBtn.IconSize = 23;
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.searchBtn.Location = new System.Drawing.Point(659, 0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(88, 36);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Поиск";
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.OnSearchClick);
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(183)))), ((int)(((byte)(108)))));
            this.searchLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchLabel.Location = new System.Drawing.Point(0, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(57, 36);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Логин:";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workPanel
            // 
            this.workPanel.AutoScroll = true;
            this.workPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workPanel.Location = new System.Drawing.Point(0, 41);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(747, 367);
            this.workPanel.TabIndex = 1;
            // 
            // designPanel
            // 
            this.designPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(183)))), ((int)(((byte)(108)))));
            this.designPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.designPanel.Location = new System.Drawing.Point(0, 36);
            this.designPanel.Name = "designPanel";
            this.designPanel.Size = new System.Drawing.Size(747, 5);
            this.designPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.receiveBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 36);
            this.panel1.TabIndex = 3;
            // 
            // receiveBtn
            // 
            this.receiveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(183)))), ((int)(((byte)(108)))));
            this.receiveBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.receiveBtn.FlatAppearance.BorderSize = 0;
            this.receiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiveBtn.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.receiveBtn.IconColor = System.Drawing.Color.Black;
            this.receiveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.receiveBtn.IconSize = 23;
            this.receiveBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.receiveBtn.Location = new System.Drawing.Point(633, 0);
            this.receiveBtn.Name = "receiveBtn";
            this.receiveBtn.Size = new System.Drawing.Size(114, 36);
            this.receiveBtn.TabIndex = 3;
            this.receiveBtn.Text = "Получить";
            this.receiveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.receiveBtn.UseVisualStyleBackColor = false;
            this.receiveBtn.Click += new System.EventHandler(this.receiveBtn_Click);
            // 
            // SavedPasswordsForm
            // 
            this.ClientSize = new System.Drawing.Size(747, 444);
            this.Controls.Add(this.workPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.designPanel);
            this.Controls.Add(this.searchPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SavedPasswordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "#32B76C";
            this.Text = "Сохранённые пароли";
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel searchPanel;
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.Panel designPanel;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton receiveBtn;
    }
}