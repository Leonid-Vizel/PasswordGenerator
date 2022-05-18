
namespace PasswordGenerator.Forms
{
    partial class PictureGenForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.workPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.addButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addButton.Location = new System.Drawing.Point(617, 0);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(218, 34);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.addButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(835, 34);
            this.topPanel.TabIndex = 1;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderDraw);
            // 
            // workPanel
            // 
            this.workPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workPanel.Location = new System.Drawing.Point(0, 34);
            this.workPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(835, 455);
            this.workPanel.TabIndex = 2;
            // 
            // PictureGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 489);
            this.Controls.Add(this.workPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PictureGenForm";
            this.Tag = "#2196F3";
            this.Text = "Пароли-картинки";
            this.Load += new System.EventHandler(this.PictureGenForm_Load);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel workPanel;
    }
}