
namespace PastelCalculator
{
    partial class Form1_calculator
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
            this.Button_divide = new System.Windows.Forms.Button();
            this.Button_equals = new System.Windows.Forms.Button();
            this.Button_dot = new System.Windows.Forms.Button();
            this.Button_zero = new System.Windows.Forms.Button();
            this.Button_multiply = new System.Windows.Forms.Button();
            this.Button_three = new System.Windows.Forms.Button();
            this.Button_two = new System.Windows.Forms.Button();
            this.Button_one = new System.Windows.Forms.Button();
            this.Button_subtract = new System.Windows.Forms.Button();
            this.Button_six = new System.Windows.Forms.Button();
            this.Button_five = new System.Windows.Forms.Button();
            this.Button_four = new System.Windows.Forms.Button();
            this.Button_add = new System.Windows.Forms.Button();
            this.Button_nine = new System.Windows.Forms.Button();
            this.Button_eight = new System.Windows.Forms.Button();
            this.Button_seven = new System.Windows.Forms.Button();
            this.Button_clear = new System.Windows.Forms.Button();
            this.Button_clearEntry = new System.Windows.Forms.Button();
            this.Button_delete = new System.Windows.Forms.Button();
            this.TextBox_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_divide
            // 
            this.Button_divide.BackColor = System.Drawing.Color.PeachPuff;
            this.Button_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_divide.Location = new System.Drawing.Point(273, 293);
            this.Button_divide.Name = "Button_divide";
            this.Button_divide.Size = new System.Drawing.Size(78, 70);
            this.Button_divide.TabIndex = 62;
            this.Button_divide.Text = "/";
            this.Button_divide.UseVisualStyleBackColor = false;
            this.Button_divide.Click += new System.EventHandler(this.Button_Operation);
            // 
            // Button_equals
            // 
            this.Button_equals.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Button_equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_equals.Location = new System.Drawing.Point(188, 369);
            this.Button_equals.Name = "Button_equals";
            this.Button_equals.Size = new System.Drawing.Size(163, 70);
            this.Button_equals.TabIndex = 61;
            this.Button_equals.Text = "=";
            this.Button_equals.UseVisualStyleBackColor = false;
            this.Button_equals.Click += new System.EventHandler(this.Button_equals_Click);
            // 
            // Button_dot
            // 
            this.Button_dot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_dot.Location = new System.Drawing.Point(104, 370);
            this.Button_dot.Name = "Button_dot";
            this.Button_dot.Size = new System.Drawing.Size(78, 70);
            this.Button_dot.TabIndex = 60;
            this.Button_dot.Text = ".";
            this.Button_dot.UseVisualStyleBackColor = false;
            this.Button_dot.Click += new System.EventHandler(this.BtnNumericValues);
            // 
            // Button_zero
            // 
            this.Button_zero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_zero.Location = new System.Drawing.Point(20, 370);
            this.Button_zero.Name = "Button_zero";
            this.Button_zero.Size = new System.Drawing.Size(78, 70);
            this.Button_zero.TabIndex = 59;
            this.Button_zero.Text = "0";
            this.Button_zero.UseVisualStyleBackColor = false;
            this.Button_zero.Click += new System.EventHandler(this.BtnNumericValues);
            // 
            // Button_multiply
            // 
            this.Button_multiply.BackColor = System.Drawing.Color.PeachPuff;
            this.Button_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_multiply.Location = new System.Drawing.Point(274, 217);
            this.Button_multiply.Name = "Button_multiply";
            this.Button_multiply.Size = new System.Drawing.Size(78, 70);
            this.Button_multiply.TabIndex = 58;
            this.Button_multiply.Text = "*";
            this.Button_multiply.UseVisualStyleBackColor = false;
            this.Button_multiply.Click += new System.EventHandler(this.Button_Operation);
            // 
            // Button_three
            // 
            this.Button_three.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_three.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_three.Location = new System.Drawing.Point(188, 295);
            this.Button_three.Name = "Button_three";
            this.Button_three.Size = new System.Drawing.Size(78, 70);
            this.Button_three.TabIndex = 57;
            this.Button_three.Text = "3";
            this.Button_three.UseVisualStyleBackColor = false;
            this.Button_three.Click += new System.EventHandler(this.BtnNumericValues);
            // 
            // Button_two
            // 
            this.Button_two.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_two.Location = new System.Drawing.Point(105, 294);
            this.Button_two.Name = "Button_two";
            this.Button_two.Size = new System.Drawing.Size(78, 70);
            this.Button_two.TabIndex = 56;
            this.Button_two.Text = "2";
            this.Button_two.UseVisualStyleBackColor = false;
            this.Button_two.Click += new System.EventHandler(this.BtnNumericValues);
            // 
            // Button_one
            // 
            this.Button_one.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_one.Location = new System.Drawing.Point(21, 294);
            this.Button_one.Name = "Button_one";
            this.Button_one.Size = new System.Drawing.Size(78, 70);
            this.Button_one.TabIndex = 55;
            this.Button_one.Text = "1";
            this.Button_one.UseVisualStyleBackColor = false;
            this.Button_one.Click += new System.EventHandler(this.BtnNumericValues);
            // 
            // Button_subtract
            // 
            this.Button_subtract.BackColor = System.Drawing.Color.PeachPuff;
            this.Button_subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_subtract.Location = new System.Drawing.Point(273, 140);
            this.Button_subtract.Name = "Button_subtract";
            this.Button_subtract.Size = new System.Drawing.Size(78, 70);
            this.Button_subtract.TabIndex = 54;
            this.Button_subtract.Text = "-";
            this.Button_subtract.UseVisualStyleBackColor = false;
            this.Button_subtract.Click += new System.EventHandler(this.Button_Operation);
            // 
            // Button_six
            // 
            this.Button_six.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_six.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_six.Location = new System.Drawing.Point(188, 217);
            this.Button_six.Name = "Button_six";
            this.Button_six.Size = new System.Drawing.Size(78, 70);
            this.Button_six.TabIndex = 53;
            this.Button_six.Text = "6";
            this.Button_six.UseVisualStyleBackColor = false;
            this.Button_six.Click += new System.EventHandler(this.BtnNumericValues);
            // 
            // Button_five
            // 
            this.Button_five.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_five.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_five.Location = new System.Drawing.Point(104, 218);
            this.Button_five.Name = "Button_five";
            this.Button_five.Size = new System.Drawing.Size(78, 70);
            this.Button_five.TabIndex = 52;
            this.Button_five.Text = "5";
            this.Button_five.UseVisualStyleBackColor = false;
            this.Button_five.Click += new System.EventHandler(this.BtnNumericValues);
            // 
            // Button_four
            // 
            this.Button_four.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_four.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_four.Location = new System.Drawing.Point(20, 218);
            this.Button_four.Name = "Button_four";
            this.Button_four.Size = new System.Drawing.Size(78, 70);
            this.Button_four.TabIndex = 51;
            this.Button_four.Text = "4";
            this.Button_four.UseVisualStyleBackColor = false;
            this.Button_four.Click += new System.EventHandler(this.BtnNumericValues);
            // 
            // Button_add
            // 
            this.Button_add.BackColor = System.Drawing.Color.PeachPuff;
            this.Button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_add.Location = new System.Drawing.Point(273, 65);
            this.Button_add.Name = "Button_add";
            this.Button_add.Size = new System.Drawing.Size(78, 70);
            this.Button_add.TabIndex = 50;
            this.Button_add.Text = "+";
            this.Button_add.UseVisualStyleBackColor = false;
            this.Button_add.Click += new System.EventHandler(this.Button_Operation);
            // 
            // Button_nine
            // 
            this.Button_nine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_nine.Location = new System.Drawing.Point(188, 140);
            this.Button_nine.Name = "Button_nine";
            this.Button_nine.Size = new System.Drawing.Size(78, 70);
            this.Button_nine.TabIndex = 49;
            this.Button_nine.Text = "9";
            this.Button_nine.UseVisualStyleBackColor = false;
            this.Button_nine.Click += new System.EventHandler(this.BtnNumericValues);
            // 
            // Button_eight
            // 
            this.Button_eight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_eight.Location = new System.Drawing.Point(104, 141);
            this.Button_eight.Name = "Button_eight";
            this.Button_eight.Size = new System.Drawing.Size(78, 70);
            this.Button_eight.TabIndex = 48;
            this.Button_eight.Text = "8";
            this.Button_eight.UseVisualStyleBackColor = false;
            this.Button_eight.Click += new System.EventHandler(this.BtnNumericValues);
            // 
            // Button_seven
            // 
            this.Button_seven.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_seven.Location = new System.Drawing.Point(20, 141);
            this.Button_seven.Name = "Button_seven";
            this.Button_seven.Size = new System.Drawing.Size(78, 70);
            this.Button_seven.TabIndex = 47;
            this.Button_seven.Text = "7";
            this.Button_seven.UseVisualStyleBackColor = false;
            this.Button_seven.Click += new System.EventHandler(this.BtnNumericValues);
            // 
            // Button_clear
            // 
            this.Button_clear.BackColor = System.Drawing.Color.DarkSalmon;
            this.Button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_clear.Location = new System.Drawing.Point(188, 65);
            this.Button_clear.Name = "Button_clear";
            this.Button_clear.Size = new System.Drawing.Size(78, 70);
            this.Button_clear.TabIndex = 45;
            this.Button_clear.Text = "C";
            this.Button_clear.UseVisualStyleBackColor = false;
            this.Button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // Button_clearEntry
            // 
            this.Button_clearEntry.BackColor = System.Drawing.Color.DarkSalmon;
            this.Button_clearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_clearEntry.Location = new System.Drawing.Point(104, 66);
            this.Button_clearEntry.Name = "Button_clearEntry";
            this.Button_clearEntry.Size = new System.Drawing.Size(78, 70);
            this.Button_clearEntry.TabIndex = 44;
            this.Button_clearEntry.Text = "CE";
            this.Button_clearEntry.UseVisualStyleBackColor = false;
            this.Button_clearEntry.Click += new System.EventHandler(this.Button_clearEntry_Click);
            // 
            // Button_delete
            // 
            this.Button_delete.BackColor = System.Drawing.Color.DarkSalmon;
            this.Button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_delete.ForeColor = System.Drawing.Color.Black;
            this.Button_delete.Location = new System.Drawing.Point(20, 66);
            this.Button_delete.Name = "Button_delete";
            this.Button_delete.Size = new System.Drawing.Size(78, 70);
            this.Button_delete.TabIndex = 43;
            this.Button_delete.Text = "⌫";
            this.Button_delete.UseVisualStyleBackColor = false;
            this.Button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // TextBox_Result
            // 
            this.TextBox_Result.BackColor = System.Drawing.Color.FloralWhite;
            this.TextBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Result.Location = new System.Drawing.Point(19, 11);
            this.TextBox_Result.Name = "TextBox_Result";
            this.TextBox_Result.Size = new System.Drawing.Size(331, 49);
            this.TextBox_Result.TabIndex = 42;
            // 
            // Form1_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PastelCalculator.Properties.Resources._649129;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.Button_divide);
            this.Controls.Add(this.Button_equals);
            this.Controls.Add(this.Button_dot);
            this.Controls.Add(this.Button_zero);
            this.Controls.Add(this.Button_multiply);
            this.Controls.Add(this.Button_three);
            this.Controls.Add(this.Button_two);
            this.Controls.Add(this.Button_one);
            this.Controls.Add(this.Button_subtract);
            this.Controls.Add(this.Button_six);
            this.Controls.Add(this.Button_five);
            this.Controls.Add(this.Button_four);
            this.Controls.Add(this.Button_add);
            this.Controls.Add(this.Button_nine);
            this.Controls.Add(this.Button_eight);
            this.Controls.Add(this.Button_seven);
            this.Controls.Add(this.Button_clear);
            this.Controls.Add(this.Button_clearEntry);
            this.Controls.Add(this.Button_delete);
            this.Controls.Add(this.TextBox_Result);
            this.MaximizeBox = false;
            this.Name = "Form1_calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_divide;
        private System.Windows.Forms.Button Button_equals;
        private System.Windows.Forms.Button Button_dot;
        private System.Windows.Forms.Button Button_zero;
        private System.Windows.Forms.Button Button_multiply;
        private System.Windows.Forms.Button Button_three;
        private System.Windows.Forms.Button Button_two;
        private System.Windows.Forms.Button Button_one;
        private System.Windows.Forms.Button Button_subtract;
        private System.Windows.Forms.Button Button_six;
        private System.Windows.Forms.Button Button_five;
        private System.Windows.Forms.Button Button_four;
        private System.Windows.Forms.Button Button_add;
        private System.Windows.Forms.Button Button_nine;
        private System.Windows.Forms.Button Button_eight;
        private System.Windows.Forms.Button Button_seven;
        private System.Windows.Forms.Button Button_clear;
        private System.Windows.Forms.Button Button_clearEntry;
        private System.Windows.Forms.Button Button_delete;
        private System.Windows.Forms.TextBox TextBox_Result;
    }
}

