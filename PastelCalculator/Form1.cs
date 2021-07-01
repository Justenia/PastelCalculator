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
        String operation = "";
        Double value = 0;

        public Form1_calculator()
        {
            InitializeComponent();
        }

        private void BtnNumericValues(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (TextBox_Result.Text == "0")
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

        private void Button_Operation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            value = Double.Parse(TextBox_Result.Text);
            operation = button.Text;
            TextBox_Result.Text = "";
            lbl_equation.Text = value + " " + operation;
        }

        private void Button_equals_Click(object sender, EventArgs e)
        {
            lbl_equation.Text = "";
            switch (operation)
            {
                case "+":
                    TextBox_Result.Text = Convert.ToString(value + Double.Parse(TextBox_Result.Text));
                    break;
                case "-":
                    TextBox_Result.Text = Convert.ToString(value - Double.Parse(TextBox_Result.Text));
                    break;
                case "*":
                    TextBox_Result.Text = Convert.ToString(value * Double.Parse(TextBox_Result.Text));
                    break;
                case "/":
                    TextBox_Result.Text = Convert.ToString(value / Double.Parse(TextBox_Result.Text));
                    break;
                default:
                    break;
            }
        }

        private void Button_delete_Click(object sender, EventArgs e)
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

        private void Button_clearEntry_Click(object sender, EventArgs e)
        {
            TextBox_Result.Text = "0";
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            TextBox_Result.Clear();
            lbl_equation.ResetText();
        }
    }
}