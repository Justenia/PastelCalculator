using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastelCalculator
{
    public partial class Form1_calculator : Form
    {
        PastelClass calc = new PastelClass();
        PastelClass2 inherit = new PastelClass2();

        public Form1_calculator()
        {
            InitializeComponent();
        }

        private void BtnNumericValues(object sender, EventArgs e)
        {
            AppendNumValues(sender);
        }

        private void Button_Operation(object sender, EventArgs e)
        {
            Operation(sender);
        }

        private void Button_equals_Click(object sender, EventArgs e)
        {
            calc.Value2 = TextBox_Result.Text;
            lbl_equation.Text = "";
            calc.Operators();
            TextBox_Result.Text = calc.Value2;
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            Backspace();
        }

        private void Button_clearEntry_Click(object sender, EventArgs e)
        {
            ClearEntry();
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void AppendNumValues(object sender)
        {
            calc.IsOperationPressed = false;
            Button button = (Button)sender;
            if ((TextBox_Result.Text == "0") || (calc.IsOperationPressed))
                TextBox_Result.Text = "";

            if (button.Text == ".")
            {
                if (!TextBox_Result.Text.Contains("."))
                    TextBox_Result.Text = TextBox_Result.Text + button.Text;
            }
            else
            {
                TextBox_Result.Text = TextBox_Result.Text + button.Text;
            }
        }

        private void Operation(object sender)
        {
            Button button = (Button)sender;
            calc.IsOperationPressed = true; 
            calc.Value = Double.Parse(TextBox_Result.Text);
            calc.Operation = button.Text;
            TextBox_Result.Text = "";
            lbl_equation.Text = calc.Value + " " + calc.Operation;
        }

        private void Backspace()
        {
            if (TextBox_Result.Text.Length > 0)
            {
                TextBox_Result.Text = TextBox_Result.Text.Remove(TextBox_Result.Text.Length - 1, 1);
            }

            if (TextBox_Result.Text == "")
            {
                TextBox_Result.Text = "0";
            }
        }

        private void ClearEntry()
        {
            TextBox_Result.Text = "0";
        }

        private void Clear()
        {
            TextBox_Result.Clear();
            lbl_equation.ResetText();
        }
    }
}