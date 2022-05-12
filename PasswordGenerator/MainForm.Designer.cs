
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.savedBtn = new FontAwesome.Sharp.IconButton();
            this.generatePanel = new FontAwesome.Sharp.IconButton();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.workPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.maximizeBtn = new FontAwesome.Sharp.IconButton();
            this.minimizeBtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.savedBtn);
            this.panel2.Controls.Add(this.generatePanel);
            this.panel2.Controls.Add(this.logoPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 621);
            this.panel2.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 189);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(189, 60);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Настройки ";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // savedBtn
            // 
            this.savedBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.savedBtn.FlatAppearance.BorderSize = 0;
            this.savedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savedBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savedBtn.ForeColor = System.Drawing.Color.White;
            this.savedBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.savedBtn.IconColor = System.Drawing.Color.White;
            this.savedBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.savedBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.savedBtn.Location = new System.Drawing.Point(0, 129);
            this.savedBtn.Name = "savedBtn";
            this.savedBtn.Size = new System.Drawing.Size(189, 60);
            this.savedBtn.TabIndex = 2;
            this.savedBtn.Text = "Сохранённые";
            this.savedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savedBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.savedBtn.UseVisualStyleBackColor = true;
            // 
            // generatePanel
            // 
            this.generatePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.generatePanel.FlatAppearance.BorderSize = 0;
            this.generatePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatePanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generatePanel.ForeColor = System.Drawing.Color.White;
            this.generatePanel.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.generatePanel.IconColor = System.Drawing.Color.White;
            this.generatePanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.generatePanel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.generatePanel.Location = new System.Drawing.Point(0, 69);
            this.generatePanel.Name = "generatePanel";
            this.generatePanel.Size = new System.Drawing.Size(189, 60);
            this.generatePanel.TabIndex = 1;
            this.generatePanel.Text = "Генератор";
            this.generatePanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generatePanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.generatePanel.UseVisualStyleBackColor = true;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.logoPanel.Controls.Add(this.label2);
            this.logoPanel.Controls.Add(this.logoBox);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(189, 69);
            this.logoPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("ConcursoItalian BTN Wide", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 69);
            this.label2.TabIndex = 4;
            this.label2.Text = "PROGA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMoveMouseDown);
            // 
            // logoBox
            // 
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "Генератор безопасных паролей";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMoveMouseDown);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
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
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
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
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
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
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.minimizeBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.maximizeBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(189, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 69);
            this.panel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 621);
            this.Controls.Add(this.workPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(702, 164);
            this.Name = "MainForm";
            this.Text = "Генератор паролей";
            this.panel2.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton savedBtn;
        private FontAwesome.Sharp.IconButton generatePanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel workPanel;
        private FontAwesome.Sharp.IconButton closeBtn;
        private FontAwesome.Sharp.IconButton maximizeBtn;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
    }
}

