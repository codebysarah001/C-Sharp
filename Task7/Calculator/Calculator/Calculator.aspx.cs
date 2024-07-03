using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SumButton_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(number1.Text);
            double num2 = Convert.ToDouble(number2.Text);
            double sum = num1 + num2;
            result.Text = sum.ToString();
        }

        protected void SubButton_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(number1.Text);
            double num2 = Convert.ToDouble(number2.Text);
            double sub = num1 - num2;
            result.Text = sub.ToString();
        }

        protected void MulButton_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(number1.Text);
            double num2 = Convert.ToDouble(number2.Text);
            double mul = num1 * num2;
            result.Text = mul.ToString();
        }
    }
}