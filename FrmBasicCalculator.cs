using CalculatorPrivateAssemblys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
            cmbOperator.Items.Add("+");
            cmbOperator.Items.Add("-");
            cmbOperator.Items.Add("*");
            cmbOperator.Items.Add("/");

            cmbOperator.SelectedIndex = 0;
            btnCompute.AccessibleDefaultActionDescription = "Calculate the result";
            cmbOperator.AccessibleDefaultActionDescription = "Choose an arithmetic operation";
            rtbTotal.AccessibleDefaultActionDescription = "Read the calculation result";
            txtFirstNumber.Select();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1, num2, result = 0;
            bool firstNumberValid = float.TryParse(txtFirstNumber.Text, out num1);
            bool secondNumberValid = float.TryParse(txtSecondNumber.Text, out num2);

            if (!firstNumberValid || !secondNumberValid)
            {
                MessageBox.Show(
                    "Please enter valid numbers in both fields.",
                    "Invalid input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                if (!firstNumberValid)
                {
                    txtFirstNumber.Focus();
                    txtFirstNumber.SelectAll();
                }
                else
                {
                    txtSecondNumber.Focus();
                    txtSecondNumber.SelectAll();
                }

                return;
            }

            try
            {
                switch (cmbOperator.Text)
                {
                    case "+":
                        result = BasicComputation.Addition(num1, num2);
                        break;

                    case "-":
                        result = BasicComputation.Subtraction(num1, num2);
                        break;

                    case "*":
                        result = BasicComputation.Multiplication(num1, num2);
                        break;

                    case "/":
                        result = BasicComputation.Division(num1, num2);
                        break;
                }

                rtbTotal.Text = result.ToString("G9");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show(
                    "Cannot divide by zero. Enter a non-zero second number.",
                    "Invalid operation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSecondNumber.Focus();
                txtSecondNumber.SelectAll();
            }
        }
    }
}
