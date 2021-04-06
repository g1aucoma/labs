
namespace lr15
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
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.btnChooseFont = new System.Windows.Forms.Button();
            this.btnChooseFK = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtT = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(42, 24);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(105, 23);
            this.btnChooseColor.TabIndex = 0;
            this.btnChooseColor.Text = "Choose bg color";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // btnChooseFont
            // 
            this.btnChooseFont.Location = new System.Drawing.Point(311, 24);
            this.btnChooseFont.Name = "btnChooseFont";
            this.btnChooseFont.Size = new System.Drawing.Size(105, 23);
            this.btnChooseFont.TabIndex = 2;
            this.btnChooseFont.Text = "Choose Font";
            this.btnChooseFont.UseVisualStyleBackColor = true;
            this.btnChooseFont.Click += new System.EventHandler(this.btnChooseFont_Click);
            // 
            // btnChooseFK
            // 
            this.btnChooseFK.Location = new System.Drawing.Point(537, 24);
            this.btnChooseFK.Name = "btnChooseFK";
            this.btnChooseFK.Size = new System.Drawing.Size(105, 23);
            this.btnChooseFK.TabIndex = 4;
            this.btnChooseFK.Text = "Choose Font Color";
            this.btnChooseFK.UseVisualStyleBackColor = true;
            this.btnChooseFK.Click += new System.EventHandler(this.btnChooseFK_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(253, 231);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(219, 71);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(253, 183);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(219, 20);
            this.txtTerm.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "enter the number of terms";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(253, 339);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(219, 20);
            this.txtAnswer.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Answer";
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(42, 231);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(100, 20);
            this.txtT.TabIndex = 10;
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(548, 230);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(100, 20);
            this.txtZ.TabIndex = 11;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(316, 109);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ENTER T";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ENTER X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ENTER Z";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 398);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnChooseFK);
            this.Controls.Add(this.btnChooseFont);
            this.Controls.Add(this.btnChooseColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Button btnChooseFont;
        private System.Windows.Forms.Button btnChooseFK;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

