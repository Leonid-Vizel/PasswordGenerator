
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.addBtn = new FontAwesome.Sharp.IconButton();
            this.workPanel = new System.Windows.Forms.Panel();
            this.designPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.addBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(835, 36);
            this.topPanel.TabIndex = 1;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderDraw);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addBtn.IconColor = System.Drawing.Color.Black;
            this.addBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addBtn.IconSize = 20;
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addBtn.Location = new System.Drawing.Point(718, 0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(117, 36);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Добавить";
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.OnAddClick);
            // 
            // workPanel
            // 
            this.workPanel.AutoScroll = true;
            this.workPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workPanel.Location = new System.Drawing.Point(0, 36);
            this.workPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(835, 453);
            this.workPanel.TabIndex = 2;
            this.workPanel.Resize += new System.EventHandler(this.OnWorkPanelResized);
            // 
            // designPanel
            // 
            this.designPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.designPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.designPanel.Location = new System.Drawing.Point(0, 36);
            this.designPanel.Name = "designPanel";
            this.designPanel.Size = new System.Drawing.Size(835, 5);
            this.designPanel.TabIndex = 3;
            // 
            // PictureGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 489);
            this.Controls.Add(this.designPanel);
            this.Controls.Add(this.workPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PictureGenForm";
            this.Tag = "#2196F3";
            this.Text = "Ваши пароли-картинки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PictureGenForm_FormClosed);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel workPanel;
        private FontAwesome.Sharp.IconButton addBtn;
        private System.Windows.Forms.Panel designPanel;
    }
}