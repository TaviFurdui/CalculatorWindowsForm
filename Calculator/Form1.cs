using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolishNotation;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Double result = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        bool isParantheses = false;
        public Calculator()
        {
            InitializeComponent();
        }
        public string path = @"C:\Users\Skullcandy\Desktop\Proiecte individuale\Proiecte Windows Form\Calculator\";
        private void numberClick(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            if (isOperationPerformed)
                labelAfisaj.Text = "";
            labelAfisaj.Text += number.Text;
            afisajCalculator.Text += number.Text;
            isOperationPerformed = false;
        }
        private void operatorClick(object sender, EventArgs e)
        {
            Button operation = (Button)sender;
            operationPerformed = operation.Text;
            afisajCalculator.Text += operation.Text;
            isOperationPerformed = true;
            switch (operationPerformed)
            {
                case "+":
                    labelAfisaj.Text = (result + Double.Parse(labelAfisaj.Text)).ToString();
                    break;
                case "-":
                    labelAfisaj.Text = (result - Double.Parse(labelAfisaj.Text)).ToString();
                    break;
                case "×":
                    labelAfisaj.Text = (result * Double.Parse(labelAfisaj.Text)).ToString();
                    break;
                case "÷":
                    labelAfisaj.Text = (result / Double.Parse(labelAfisaj.Text)).ToString();
                    break;
                case "%":
                    labelAfisaj.Text = (result / 100).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(labelAfisaj.Text);
            //labelAfisaj.Text = result.ToString();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            afisajCalculator.Text = "";
            labelAfisaj.Text = "";
            result = 0;
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            afisajCalculator.Text = labelAfisaj.Text;
            labelAfisaj.Text = "";
            result = Double.Parse(afisajCalculator.Text);
        }
        private void buttonParantheses_Click(object sender, EventArgs e)
        {
            if (!isParantheses)
            {
                isParantheses = true;
                afisajCalculator.Text += "(";
            }
            else
            {
                isParantheses = false;
                afisajCalculator.Text += ")";
            }
        }
        private void buttonDarkLight_Click(object sender, EventArgs e)
        {
            switch (buttonDarkLight.Text)
            {
                case ".":
                    buttonDarkLight.Text = ",";
                    buttonDarkLight.ForeColor = Color.DimGray;
                    afisajCalculator.BackColor = Color.White;
                    afisajCalculator.ForeColor = Color.DimGray;
                    BackColor = Color.White;
                    buttonDarkLight.BackgroundImage = Image.FromFile(path + "moon.png");
                    buttonClock.BackgroundImage = Image.FromFile(path + "clock-black.png");
                    buttonRuler.BackgroundImage = Image.FromFile(path + "ruler-black.png");
                    buttonSqrt.BackgroundImage = Image.FromFile(path + "sqrt-black.png");
                    buttonOne.BackColor = Color.FromArgb(200, 200, 200);
                    buttonOne.ForeColor = Color.DimGray;
                    buttonTwo.BackColor = Color.FromArgb(200, 200, 200);
                    buttonTwo.ForeColor = Color.DimGray;
                    buttonThree.BackColor = Color.FromArgb(200, 200, 200);
                    buttonThree.ForeColor = Color.DimGray;
                    buttonFour.BackColor = Color.FromArgb(200, 200, 200);
                    buttonFour.ForeColor = Color.DimGray;
                    buttonFive.BackColor = Color.FromArgb(200, 200, 200);
                    buttonFive.ForeColor = Color.DimGray;
                    buttonSix.BackColor = Color.FromArgb(200, 200, 200);
                    buttonSix.ForeColor = Color.DimGray;
                    buttonSeven.BackColor = Color.FromArgb(200, 200, 200);
                    buttonSeven.ForeColor = Color.DimGray;
                    buttonEight.BackColor = Color.FromArgb(200, 200, 200);
                    buttonEight.ForeColor = Color.DimGray;
                    buttonNine.BackColor = Color.FromArgb(200, 200, 200);
                    buttonNine.ForeColor = Color.DimGray;
                    buttonZero.BackColor = Color.FromArgb(200, 200, 200);
                    buttonZero.ForeColor = Color.DimGray;
                    buttonChangeSign.BackColor = Color.FromArgb(200, 200, 200);
                    buttonChangeSign.ForeColor = Color.DimGray;
                    buttonPoint.BackColor = Color.FromArgb(200, 200, 200);
                    buttonPoint.ForeColor = Color.DimGray;
                    buttonPlus.BackColor = Color.FromArgb(200, 200, 200);
                    buttonMinus.BackColor = Color.FromArgb(200, 200, 200);
                    buttonMultiply.BackColor = Color.FromArgb(200, 200, 200);
                    buttonDivision.BackColor = Color.FromArgb(200, 200, 200);
                    buttonDelete.BackColor = Color.FromArgb(200, 200, 200);
                    buttonPercent.BackColor = Color.FromArgb(200, 200, 200);
                    buttonParantheses.BackColor = Color.FromArgb(200, 200, 200);
                    break;
                case ",":
                    buttonDarkLight.Text = ".";
                    buttonDarkLight.ForeColor = Color.White;
                    afisajCalculator.BackColor = Color.FromArgb(40, 40, 43);
                    afisajCalculator.ForeColor = Color.White;
                    BackColor = Color.FromArgb(40, 40, 43);
                    buttonDarkLight.BackgroundImage = Image.FromFile(path + "bright.png");
                    buttonClock.BackgroundImage = Image.FromFile(path + "clock.png");
                    buttonRuler.BackgroundImage = Image.FromFile(path + "ruler.png");
                    buttonSqrt.BackgroundImage = Image.FromFile(path + "sqrt.png");
                    buttonOne.BackColor = Color.DimGray;
                    buttonOne.ForeColor = Color.White;
                    buttonTwo.BackColor = Color.DimGray;
                    buttonTwo.ForeColor = Color.White;
                    buttonThree.BackColor = Color.DimGray;
                    buttonThree.ForeColor = Color.White;
                    buttonFour.BackColor = Color.DimGray;
                    buttonFour.ForeColor = Color.White;
                    buttonFive.BackColor = Color.DimGray;
                    buttonFive.ForeColor = Color.White;
                    buttonSix.BackColor = Color.DimGray;
                    buttonSix.ForeColor = Color.White;
                    buttonSeven.BackColor = Color.DimGray;
                    buttonSeven.ForeColor = Color.White;
                    buttonEight.BackColor = Color.DimGray;
                    buttonEight.ForeColor = Color.White;
                    buttonNine.BackColor = Color.DimGray;
                    buttonNine.ForeColor = Color.White;
                    buttonZero.BackColor = Color.DimGray;
                    buttonZero.ForeColor = Color.White;
                    buttonChangeSign.BackColor = Color.DimGray;
                    buttonChangeSign.ForeColor = Color.White;
                    buttonPoint.BackColor = Color.DimGray;
                    buttonPoint.ForeColor = Color.White;
                    buttonPlus.BackColor = Color.DimGray;
                    buttonMinus.BackColor = Color.DimGray;
                    buttonMultiply.BackColor = Color.DimGray;
                    buttonDivision.BackColor = Color.DimGray;
                    buttonDelete.BackColor = Color.DimGray;
                    buttonPercent.BackColor = Color.DimGray;
                    buttonParantheses.BackColor = Color.DimGray;
                    break;
                default:
                    break;
            }
        }
    }
}
