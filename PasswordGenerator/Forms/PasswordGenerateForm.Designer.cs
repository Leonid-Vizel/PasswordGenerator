﻿
namespace PasswordGenerator
{
    partial class PasswordGenerateForm
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
            this.components = new System.ComponentModel.Container();
            this.lengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.numberCheckBox = new System.Windows.Forms.CheckBox();
            this.alphanumCheckBox = new System.Windows.Forms.CheckBox();
            this.ambiguousCheckBox = new System.Windows.Forms.CheckBox();
            this.similarCheckBox = new System.Windows.Forms.CheckBox();
            this.lowerCheckBox = new System.Windows.Forms.CheckBox();
            this.upperCheckBox = new System.Windows.Forms.CheckBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.openSavedBtn = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.openPasswordBtn = new FontAwesome.Sharp.IconButton();
            this.copyBtn = new FontAwesome.Sharp.IconButton();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.saveCurrentBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.copyLabelShowTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).BeginInit();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lengthUpDown
            // 
            this.lengthUpDown.Location = new System.Drawing.Point(81, 17);
            this.lengthUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.lengthUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lengthUpDown.Name = "lengthUpDown";
            this.lengthUpDown.Size = new System.Drawing.Size(180, 34);
            this.lengthUpDown.TabIndex = 0;
            this.lengthUpDown.ValueChanged += new System.EventHandler(this.lengthUpDown_ValueChanged);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(-2, 17);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(75, 28);
            this.lengthLabel.TabIndex = 1;
            this.lengthLabel.Text = "Длина:";
            // 
            // numberCheckBox
            // 
            this.numberCheckBox.AutoSize = true;
            this.numberCheckBox.Location = new System.Drawing.Point(19, 153);
            this.numberCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberCheckBox.Name = "numberCheckBox";
            this.numberCheckBox.Size = new System.Drawing.Size(181, 32);
            this.numberCheckBox.TabIndex = 14;
            this.numberCheckBox.Text = "Включить числа";
            this.numberCheckBox.UseVisualStyleBackColor = true;
            this.numberCheckBox.CheckedChanged += new System.EventHandler(this.numberCheckBox_CheckedChanged);
            // 
            // alphanumCheckBox
            // 
            this.alphanumCheckBox.AutoSize = true;
            this.alphanumCheckBox.Location = new System.Drawing.Point(19, 120);
            this.alphanumCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.alphanumCheckBox.Name = "alphanumCheckBox";
            this.alphanumCheckBox.Size = new System.Drawing.Size(437, 32);
            this.alphanumCheckBox.TabIndex = 13;
            this.alphanumCheckBox.Text = "Включить не буквенно-цифровые символы";
            this.alphanumCheckBox.UseVisualStyleBackColor = true;
            this.alphanumCheckBox.CheckedChanged += new System.EventHandler(this.alphanumCheckBox_CheckedChanged);
            // 
            // ambiguousCheckBox
            // 
            this.ambiguousCheckBox.AutoSize = true;
            this.ambiguousCheckBox.Location = new System.Drawing.Point(19, 219);
            this.ambiguousCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ambiguousCheckBox.Name = "ambiguousCheckBox";
            this.ambiguousCheckBox.Size = new System.Drawing.Size(376, 32);
            this.ambiguousCheckBox.TabIndex = 12;
            this.ambiguousCheckBox.Text = "Исключить неоднозначные символы";
            this.ambiguousCheckBox.UseVisualStyleBackColor = true;
            this.ambiguousCheckBox.CheckedChanged += new System.EventHandler(this.ambiguousCheckBox_CheckedChanged);
            // 
            // similarCheckBox
            // 
            this.similarCheckBox.AutoSize = true;
            this.similarCheckBox.Location = new System.Drawing.Point(19, 186);
            this.similarCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.similarCheckBox.Name = "similarCheckBox";
            this.similarCheckBox.Size = new System.Drawing.Size(463, 32);
            this.similarCheckBox.TabIndex = 11;
            this.similarCheckBox.Text = "Исключить подобные символы (i, l, 1, L, o, 0, O)\r\n";
            this.similarCheckBox.UseVisualStyleBackColor = true;
            this.similarCheckBox.CheckedChanged += new System.EventHandler(this.similarCheckBox_CheckedChanged);
            // 
            // lowerCheckBox
            // 
            this.lowerCheckBox.AutoSize = true;
            this.lowerCheckBox.Location = new System.Drawing.Point(19, 87);
            this.lowerCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.lowerCheckBox.Name = "lowerCheckBox";
            this.lowerCheckBox.Size = new System.Drawing.Size(278, 32);
            this.lowerCheckBox.TabIndex = 10;
            this.lowerCheckBox.Text = "Включить строчные буквы";
            this.lowerCheckBox.UseVisualStyleBackColor = true;
            this.lowerCheckBox.CheckedChanged += new System.EventHandler(this.lowerCheckBox_CheckedChanged);
            // 
            // upperCheckBox
            // 
            this.upperCheckBox.AutoSize = true;
            this.upperCheckBox.Location = new System.Drawing.Point(19, 54);
            this.upperCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.upperCheckBox.Name = "upperCheckBox";
            this.upperCheckBox.Size = new System.Drawing.Size(295, 32);
            this.upperCheckBox.TabIndex = 9;
            this.upperCheckBox.Text = "Включить прописные буквы";
            this.upperCheckBox.UseVisualStyleBackColor = true;
            this.upperCheckBox.CheckedChanged += new System.EventHandler(this.upperCheckBox_CheckedChanged);
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.Coral;
            this.generateBtn.FlatAppearance.BorderSize = 0;
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.Location = new System.Drawing.Point(19, 251);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(365, 46);
            this.generateBtn.TabIndex = 15;
            this.generateBtn.Text = "Генерировать";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.OnGenerateClick);
            // 
            // openSavedBtn
            // 
            this.openSavedBtn.BackColor = System.Drawing.Color.Coral;
            this.openSavedBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.openSavedBtn.FlatAppearance.BorderSize = 0;
            this.openSavedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSavedBtn.Location = new System.Drawing.Point(0, 0);
            this.openSavedBtn.Name = "openSavedBtn";
            this.openSavedBtn.Size = new System.Drawing.Size(218, 34);
            this.openSavedBtn.TabIndex = 19;
            this.openSavedBtn.Text = "Откыть сохранённые";
            this.openSavedBtn.UseVisualStyleBackColor = false;
            this.openSavedBtn.Click += new System.EventHandler(this.OnOpenSavedClick);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(19, 303);
            this.passwordBox.MaxLength = 1000;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(554, 34);
            this.passwordBox.TabIndex = 20;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // openPasswordBtn
            // 
            this.openPasswordBtn.FlatAppearance.BorderSize = 0;
            this.openPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPasswordBtn.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.openPasswordBtn.IconColor = System.Drawing.Color.Black;
            this.openPasswordBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.openPasswordBtn.IconSize = 30;
            this.openPasswordBtn.Location = new System.Drawing.Point(574, 308);
            this.openPasswordBtn.Name = "openPasswordBtn";
            this.openPasswordBtn.Size = new System.Drawing.Size(28, 24);
            this.openPasswordBtn.TabIndex = 21;
            this.openPasswordBtn.UseVisualStyleBackColor = true;
            this.openPasswordBtn.Click += new System.EventHandler(this.openPasswordBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.FlatAppearance.BorderSize = 0;
            this.copyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyBtn.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.copyBtn.IconColor = System.Drawing.Color.Black;
            this.copyBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.copyBtn.IconSize = 30;
            this.copyBtn.Location = new System.Drawing.Point(604, 304);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(28, 29);
            this.copyBtn.TabIndex = 22;
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // btnPanel
            // 
            this.btnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPanel.Controls.Add(this.saveCurrentBtn);
            this.btnPanel.Controls.Add(this.openSavedBtn);
            this.btnPanel.Location = new System.Drawing.Point(604, 0);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(218, 79);
            this.btnPanel.TabIndex = 23;
            // 
            // saveCurrentBtn
            // 
            this.saveCurrentBtn.BackColor = System.Drawing.Color.Coral;
            this.saveCurrentBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveCurrentBtn.FlatAppearance.BorderSize = 0;
            this.saveCurrentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCurrentBtn.Location = new System.Drawing.Point(0, 34);
            this.saveCurrentBtn.Name = "saveCurrentBtn";
            this.saveCurrentBtn.Size = new System.Drawing.Size(218, 34);
            this.saveCurrentBtn.TabIndex = 16;
            this.saveCurrentBtn.Text = "Сохранить параметры";
            this.saveCurrentBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(21, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Скопировано!";
            // 
            // copyLabelShowTimer
            // 
            this.copyLabelShowTimer.Interval = 3000;
            this.copyLabelShowTimer.Tick += new System.EventHandler(this.OnCopyTimerElapsed);
            // 
            // PasswordGenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.openPasswordBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.numberCheckBox);
            this.Controls.Add(this.alphanumCheckBox);
            this.Controls.Add(this.ambiguousCheckBox);
            this.Controls.Add(this.similarCheckBox);
            this.Controls.Add(this.lowerCheckBox);
            this.Controls.Add(this.upperCheckBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.lengthUpDown);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PasswordGenerateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "#FF7F50";
            this.Text = "Генератор безопасных паролей";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).EndInit();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown lengthUpDown;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.CheckBox numberCheckBox;
        private System.Windows.Forms.CheckBox alphanumCheckBox;
        private System.Windows.Forms.CheckBox ambiguousCheckBox;
        private System.Windows.Forms.CheckBox similarCheckBox;
        private System.Windows.Forms.CheckBox lowerCheckBox;
        private System.Windows.Forms.CheckBox upperCheckBox;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button openSavedBtn;
        private System.Windows.Forms.TextBox passwordBox;
        private FontAwesome.Sharp.IconButton openPasswordBtn;
        private FontAwesome.Sharp.IconButton copyBtn;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button saveCurrentBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer copyLabelShowTimer;
    }
}