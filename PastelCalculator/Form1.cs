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
        public Form1_calculator()
        {
            InitializeComponent();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {

        }

        private void Button_subtract_Click(object sender, EventArgs e)
        {

        }

        private void Button_multiply_Click(object sender, EventArgs e)
        {

        }

        private void Button_divide_Click(object sender, EventArgs e)
        {

        }

        private void Button_equals_Click(object sender, EventArgs e)
        {

        }

        private void Button_delete_Click(object sender, EventArgs e)
        {

        }

        private void Button_clearEntry_Click(object sender, EventArgs e)
        {
            TextBox_Result.Text = "0";
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            TextBox_Result.Clear();
        }

        private void TextBox_Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNumericValues(object sender, EventArgs e)
        {
            Button a = (Button)sender;

            if (TextBox_Result.Text == "0")
                TextBox_Result.Text = "";

            if (a.Text == ".")
            {
                if (!TextBox_Result.Text.Contains("."))
                    TextBox_Result.Text = TextBox_Result.Text + a.Text;
            }
            else
            {
                TextBox_Result.Text = TextBox_Result.Text + a.Text;
            }
        }
    }
}
