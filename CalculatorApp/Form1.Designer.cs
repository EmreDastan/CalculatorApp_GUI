
namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Display = new System.Windows.Forms.Label();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_sum = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_equals = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Display.Location = new System.Drawing.Point(12, 9);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(221, 52);
            this.Display.TabIndex = 0;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button_divide
            // 
            this.button_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_divide.Location = new System.Drawing.Point(177, 74);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(46, 39);
            this.button_divide.TabIndex = 1;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button_sum
            // 
            this.button_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sum.Location = new System.Drawing.Point(177, 164);
            this.button_sum.Name = "button_sum";
            this.button_sum.Size = new System.Drawing.Size(46, 39);
            this.button_sum.TabIndex = 2;
            this.button_sum.Text = "+";
            this.button_sum.UseVisualStyleBackColor = true;
            this.button_sum.Click += new System.EventHandler(this.button_sum_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_multiply.Location = new System.Drawing.Point(177, 119);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(46, 39);
            this.button_multiply.TabIndex = 3;
            this.button_multiply.Text = "X";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_minus.Location = new System.Drawing.Point(177, 209);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(46, 39);
            this.button_minus.TabIndex = 4;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_equals
            // 
            this.button_equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_equals.Location = new System.Drawing.Point(177, 254);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(46, 39);
            this.button_equals.TabIndex = 5;
            this.button_equals.Text = "=";
            this.button_equals.UseVisualStyleBackColor = true;
            this.button_equals.Click += new System.EventHandler(this.button_equals_Click);
            // 
            // button_dot
            // 
            this.button_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_dot.Location = new System.Drawing.Point(116, 254);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(46, 39);
            this.button_dot.TabIndex = 6;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            // 
            // button_0
            // 
            this.button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_0.Location = new System.Drawing.Point(12, 254);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(98, 39);
            this.button_0.TabIndex = 7;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_7
            // 
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_7.Location = new System.Drawing.Point(12, 119);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(46, 39);
            this.button_7.TabIndex = 8;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_8
            // 
            this.button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_8.Location = new System.Drawing.Point(64, 119);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(46, 39);
            this.button_8.TabIndex = 9;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_9
            // 
            this.button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_9.Location = new System.Drawing.Point(116, 119);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(46, 39);
            this.button_9.TabIndex = 10;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_4
            // 
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_4.Location = new System.Drawing.Point(12, 164);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(46, 39);
            this.button_4.TabIndex = 11;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_5
            // 
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_5.Location = new System.Drawing.Point(64, 164);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(46, 39);
            this.button_5.TabIndex = 12;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_6
            // 
            this.button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_6.Location = new System.Drawing.Point(116, 164);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(46, 39);
            this.button_6.TabIndex = 13;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_1
            // 
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_1.Location = new System.Drawing.Point(12, 209);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(46, 39);
            this.button_1.TabIndex = 14;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_2
            // 
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_2.Location = new System.Drawing.Point(64, 209);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(46, 39);
            this.button_2.TabIndex = 15;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_3
            // 
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_3.Location = new System.Drawing.Point(116, 209);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(46, 39);
            this.button_3.TabIndex = 16;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_reset.Location = new System.Drawing.Point(12, 74);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(150, 39);
            this.button_reset.TabIndex = 17;
            this.button_reset.Text = "AC";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 300);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_equals);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_sum);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_sum;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_equals;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_reset;
    }
}

