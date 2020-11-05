using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorOnWinForm
{
    public partial class ButPanel : Form
    {
        public string act;
        public string tempVariable;
        public bool flag;
        public ButPanel()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void But1_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;

            int tempNumber;
            bool isNum = int.TryParse(numButton.Text, out tempNumber);

            if (flag)
            {
                flag = false;
                TextBox.Text = "0";
            }
            if ( (TextBox.Text == "0") && (isNum) )
            {
                TextBox.Text = numButton.Text;
            }
            else
            {
                if ( (!numButton.Text.Contains(",")) && numButton.Text == "," )
                {
                    TextBox.Text = TextBox.Text + numButton.Text;
                }
                else
                {
                    TextBox.Text = TextBox.Text + numButton.Text;
                }
            }
        }

        private void ButtonErase_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1);
            }
            else
            {
                TextBox.Text = "0";
            }
        }

        private void ButRollUp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButDivision_Click(object sender, EventArgs e)
        {
            Button buttonAct = (Button)sender;
            act = buttonAct.Text;
            tempVariable = TextBox.Text;
            flag = true;
        }
        private void ButEqually_Click(object sender, EventArgs e)
        {
            double firstVar, secondVar, res = 0;
            Double.TryParse(tempVariable, out firstVar);
            Double.TryParse(TextBox.Text, out secondVar);
            if (act == "+")
            {
                res = firstVar + secondVar;
            }
            if (act == "-")
            {
                res = firstVar - secondVar; 
            }
            if (act == "*")
            {
                res = firstVar * secondVar;
            }
            if (act == "/")
            {
                res = firstVar / secondVar;
            }
            if (act == "%")
            {
                res = (firstVar / secondVar) * 100;
            }
            TextBox.Text = res.ToString();
            flag = true;
        }

        private void ButEraseAll_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        Point lastPoint;
        private void ButEraseAll_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ButEraseAll_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ButChangeBG_Click(object sender, EventArgs e)
        {
            if(this.BackColor != Color.White)
            {
                SettingPanel.BackColor = Color.White;
                TextBox.BackColor = Color.FromArgb(245, 245, 245);
                this.BackColor = Color.White;
                ButtonErase.BackColor = Color.White;
                ButEraseAll.BackColor = Color.White;
                ButPercent.BackColor = Color.White;
                ButDivision.BackColor = Color.White;
                But1.BackColor = Color.White;
                But2.BackColor = Color.White;
                But3.BackColor = Color.White;
                But4.BackColor = Color.White;
                But5.BackColor = Color.White;
                But6.BackColor = Color.White;
                But7.BackColor = Color.White;
                But8.BackColor = Color.White;
                But9.BackColor = Color.White;
                But0.BackColor = Color.White;
                ButPoint.BackColor = Color.White;
                ButMultiplication.BackColor = Color.White;
                BubSubtraction.BackColor = Color.White;
                ButAdditions.BackColor = Color.White;
                ButEqually.BackColor = Color.White;
            }
            else
            {
                SettingPanel.BackColor = Color.FromArgb(33, 35, 39);
                TextBox.BackColor = Color.FromArgb(33, 35, 39);
                this.BackColor = Color.FromArgb(33, 35, 39);
                ButtonErase.BackColor = Color.FromArgb(33, 35, 39);
                ButEraseAll.BackColor = Color.FromArgb(33, 35, 39);
                ButPercent.BackColor = Color.FromArgb(33, 35, 39);
                ButDivision.BackColor = Color.FromArgb(33, 35, 39);
                But1.BackColor = Color.FromArgb(33, 35, 39);
                But2.BackColor = Color.FromArgb(33, 35, 39);
                But3.BackColor = Color.FromArgb(33, 35, 39);
                But4.BackColor = Color.FromArgb(33, 35, 39);
                But5.BackColor = Color.FromArgb(33, 35, 39);
                But6.BackColor = Color.FromArgb(33, 35, 39);
                But7.BackColor = Color.FromArgb(33, 35, 39);
                But8.BackColor = Color.FromArgb(33, 35, 39);
                But9.BackColor = Color.FromArgb(33, 35, 39);
                But0.BackColor = Color.FromArgb(33, 35, 39);
                ButPoint.BackColor = Color.FromArgb(33, 35, 39);
                ButMultiplication.BackColor = Color.FromArgb(33, 35, 39);
                BubSubtraction.BackColor = Color.FromArgb(33, 35, 39);
                ButAdditions.BackColor = Color.FromArgb(33, 35, 39);
                ButEqually.BackColor = Color.FromArgb(33, 35, 39);
            }
        }
    }
}
