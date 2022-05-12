
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openPasswordBtn = new FontAwesome.Sharp.IconButton();
            this.copyBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(81, 17);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(180, 29);
            this.numericUpDown1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Длина:";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(19, 153);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(145, 25);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.Text = "Включить числа";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(19, 120);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(341, 25);
            this.checkBox5.TabIndex = 13;
            this.checkBox5.Text = "Включить не буквенно-цифровые символы";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(19, 219);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(295, 25);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "Исключить неоднозначные символы";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(19, 186);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(365, 25);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Исключить подобные символы (i, l, 1, L, o, 0, O)\r\n";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(19, 87);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(221, 25);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Включить строчные буквы";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 54);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(232, 25);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Включить прописные буквы";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(19, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "Генерировать";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Сохранить настройки";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(604, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 34);
            this.button3.TabIndex = 17;
            this.button3.Text = "Передать настройки (TCP)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(604, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 34);
            this.button4.TabIndex = 18;
            this.button4.Text = "Сохранить онлайн";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(604, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(206, 34);
            this.button5.TabIndex = 19;
            this.button5.Text = "Откыть сохранённые";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 303);
            this.textBox1.MaxLength = 1000;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(554, 29);
            this.textBox1.TabIndex = 20;
            this.textBox1.UseSystemPasswordChar = true;
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
            // 
            // PasswordGenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 390);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.openPasswordBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PasswordGenerateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordGenerateForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton openPasswordBtn;
        private FontAwesome.Sharp.IconButton copyBtn;
    }
}