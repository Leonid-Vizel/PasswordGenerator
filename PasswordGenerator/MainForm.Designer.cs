
namespace PasswordGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.savesBtn = new FontAwesome.Sharp.IconButton();
            this.picPasswordsBtn = new FontAwesome.Sharp.IconButton();
            this.generateBtn = new FontAwesome.Sharp.IconButton();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.workPanel = new System.Windows.Forms.Panel();
            this.topLabel = new System.Windows.Forms.Label();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.maximizeBtn = new FontAwesome.Sharp.IconButton();
            this.minimizeBtn = new FontAwesome.Sharp.IconButton();
            this.topLabelPanel = new System.Windows.Forms.Panel();
            this.buttonPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.topLabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonPanel.Controls.Add(this.savesBtn);
            this.buttonPanel.Controls.Add(this.picPasswordsBtn);
            this.buttonPanel.Controls.Add(this.generateBtn);
            this.buttonPanel.Controls.Add(this.logoPanel);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(189, 621);
            this.buttonPanel.TabIndex = 1;
            // 
            // savesBtn
            // 
            this.savesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.savesBtn.FlatAppearance.BorderSize = 0;
            this.savesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savesBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.savesBtn.ForeColor = System.Drawing.Color.White;
            this.savesBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.savesBtn.IconColor = System.Drawing.Color.White;
            this.savesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.savesBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.savesBtn.Location = new System.Drawing.Point(0, 189);
            this.savesBtn.Name = "savesBtn";
            this.savesBtn.Size = new System.Drawing.Size(189, 60);
            this.savesBtn.TabIndex = 3;
            this.savesBtn.Text = "Сохранения";
            this.savesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.savesBtn.UseVisualStyleBackColor = true;
            // 
            // picPasswordsBtn
            // 
            this.picPasswordsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.picPasswordsBtn.FlatAppearance.BorderSize = 0;
            this.picPasswordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.picPasswordsBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.picPasswordsBtn.ForeColor = System.Drawing.Color.White;
            this.picPasswordsBtn.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.picPasswordsBtn.IconColor = System.Drawing.Color.White;
            this.picPasswordsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picPasswordsBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.picPasswordsBtn.Location = new System.Drawing.Point(0, 129);
            this.picPasswordsBtn.Name = "picPasswordsBtn";
            this.picPasswordsBtn.Size = new System.Drawing.Size(189, 60);
            this.picPasswordsBtn.TabIndex = 2;
            this.picPasswordsBtn.Text = "Картинки-пароли";
            this.picPasswordsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.picPasswordsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.picPasswordsBtn.UseVisualStyleBackColor = true;
            this.picPasswordsBtn.Click += new System.EventHandler(this.OnPicPasswordsClick);
            // 
            // generateBtn
            // 
            this.generateBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.generateBtn.FlatAppearance.BorderSize = 0;
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.generateBtn.ForeColor = System.Drawing.Color.White;
            this.generateBtn.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.generateBtn.IconColor = System.Drawing.Color.White;
            this.generateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.generateBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.generateBtn.Location = new System.Drawing.Point(0, 69);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(189, 60);
            this.generateBtn.TabIndex = 1;
            this.generateBtn.Tag = "";
            this.generateBtn.Text = "Генератор";
            this.generateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.OnGenerateBtnClick);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.logoPanel.Controls.Add(this.logoLabel);
            this.logoPanel.Controls.Add(this.logoBox);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(189, 69);
            this.logoPanel.TabIndex = 0;
            // 
            // logoLabel
            // 
            this.logoLabel.BackColor = System.Drawing.Color.Transparent;
            this.logoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.White;
            this.logoLabel.Location = new System.Drawing.Point(69, 0);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(120, 69);
            this.logoLabel.TabIndex = 4;
            this.logoLabel.Text = "PROGA";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMoveMouseDown);
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Transparent;
            this.logoBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(0, 0);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(69, 69);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 3;
            this.logoBox.TabStop = false;
            this.logoBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMoveMouseDown);
            // 
            // workPanel
            // 
            this.workPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workPanel.Location = new System.Drawing.Point(189, 69);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(833, 552);
            this.workPanel.TabIndex = 3;
            this.workPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPanelMouseDown);
            this.workPanel.MouseLeave += new System.EventHandler(this.OnPanelMouseLeave);
            this.workPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPanelMouseMove);
            this.workPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPanelMouseUp);
            // 
            // topLabel
            // 
            this.topLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topLabel.BackColor = System.Drawing.Color.Transparent;
            this.topLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.topLabel.ForeColor = System.Drawing.Color.White;
            this.topLabel.Location = new System.Drawing.Point(0, 0);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(725, 69);
            this.topLabel.TabIndex = 6;
            this.topLabel.Text = "Генератор безопасных паролей";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMoveMouseDown);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 29;
            this.closeBtn.Location = new System.Drawing.Point(803, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.OnCloseClick);
            this.closeBtn.MouseEnter += new System.EventHandler(this.OnCloseMouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.OnCloseMouseLeave);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.maximizeBtn.FlatAppearance.BorderSize = 0;
            this.maximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBtn.ForeColor = System.Drawing.Color.White;
            this.maximizeBtn.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.maximizeBtn.IconColor = System.Drawing.Color.White;
            this.maximizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximizeBtn.IconSize = 29;
            this.maximizeBtn.Location = new System.Drawing.Point(767, 0);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(30, 30);
            this.maximizeBtn.TabIndex = 8;
            this.maximizeBtn.UseVisualStyleBackColor = false;
            this.maximizeBtn.Click += new System.EventHandler(this.OnMaxClick);
            this.maximizeBtn.MouseEnter += new System.EventHandler(this.OnMaxMouseEnter);
            this.maximizeBtn.MouseLeave += new System.EventHandler(this.OnMaxMouseLeave);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.minimizeBtn.IconColor = System.Drawing.Color.White;
            this.minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeBtn.IconSize = 29;
            this.minimizeBtn.Location = new System.Drawing.Point(731, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(30, 30);
            this.minimizeBtn.TabIndex = 9;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.OnMinClick);
            this.minimizeBtn.MouseEnter += new System.EventHandler(this.OnMixMouseEnter);
            this.minimizeBtn.MouseLeave += new System.EventHandler(this.OnMinMouseLeave);
            // 
            // topLabelPanel
            // 
            this.topLabelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.topLabelPanel.Controls.Add(this.minimizeBtn);
            this.topLabelPanel.Controls.Add(this.closeBtn);
            this.topLabelPanel.Controls.Add(this.maximizeBtn);
            this.topLabelPanel.Controls.Add(this.topLabel);
            this.topLabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLabelPanel.Location = new System.Drawing.Point(189, 0);
            this.topLabelPanel.Name = "topLabelPanel";
            this.topLabelPanel.Size = new System.Drawing.Size(833, 69);
            this.topLabelPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 621);
            this.Controls.Add(this.workPanel);
            this.Controls.Add(this.topLabelPanel);
            this.Controls.Add(this.buttonPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(702, 164);
            this.Name = "MainForm";
            this.Text = "Генератор паролей";
            this.buttonPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.topLabelPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel buttonPanel;
        private FontAwesome.Sharp.IconButton generateBtn;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Panel workPanel;
        private FontAwesome.Sharp.IconButton closeBtn;
        private FontAwesome.Sharp.IconButton maximizeBtn;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private System.Windows.Forms.Label logoLabel;
        private FontAwesome.Sharp.IconButton savesBtn;
        private System.Windows.Forms.Panel topLabelPanel;
        private FontAwesome.Sharp.IconButton picPasswordsBtn;
    }
}

