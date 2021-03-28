
namespace lr13
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxa = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(424, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор уравнения";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Уравнение 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Уравнение 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(102, 38);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 2;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(102, 69);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 3;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(102, 99);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 4;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(102, 130);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 20);
            this.textBoxR.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "N = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "R = ";
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(341, 272);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(226, 20);
            this.textBoxZ.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Z = ";
            // 
            // comboBoxb
            // 
            this.comboBoxb.FormattingEnabled = true;
            this.comboBoxb.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "20"});
            this.comboBoxb.Location = new System.Drawing.Point(262, 67);
            this.comboBoxb.Name = "comboBoxb";
            this.comboBoxb.Size = new System.Drawing.Size(121, 21);
            this.comboBoxb.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "a = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "b = ";
            // 
            // comboBoxa
            // 
            this.comboBoxa.FormattingEnabled = true;
            this.comboBoxa.Items.AddRange(new object[] {
            "0",
            "10",
            "15",
            "100"});
            this.comboBoxa.Location = new System.Drawing.Point(263, 36);
            this.comboBoxa.Name = "comboBoxa";
            this.comboBoxa.Size = new System.Drawing.Size(121, 21);
            this.comboBoxa.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 340);
            this.Controls.Add(this.comboBoxa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxa;
    }
}

