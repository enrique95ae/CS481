using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HW2_Calculator
{
    public partial class MainPage : ContentPage
    {
        //KNOWN ERRORS:
            //Calculator doesn't stack operations, that is: An operation has to be completed (equal button pressed)
            //before using it's result along with another quanity.

        double temp1, temp2, result;
        string operation;


        public MainPage()
        {
            InitializeComponent();
            displayNum_Label.Text = "";
        }

        //NUMBER BUTTONS

        private void sevenButton_Clicked(object sender, EventArgs e)
        {
            displayNum_Label.Text = displayNum_Label.Text + "7";
        }

        private void eightButton_Clicked(object sender, EventArgs e)
        {
            displayNum_Label.Text = displayNum_Label.Text + "8";
        }

        private void nineButton_Clicked(object sender, EventArgs e)
        {
            displayNum_Label.Text = displayNum_Label.Text + "9";
        }

        private void fourButton_Clicked(object sender, EventArgs e)
        {
            displayNum_Label.Text = displayNum_Label.Text + "4";
        }

        private void fiveButton_Clicked(object sender, EventArgs e)
        {
            displayNum_Label.Text = displayNum_Label.Text + "5";
        }

        private void sixButton_Clicked(object sender, EventArgs e)
        {
            displayNum_Label.Text = displayNum_Label.Text + "6";
        }

        private void oneButton_Clicked(object sender, EventArgs e)
        {
            displayNum_Label.Text = displayNum_Label.Text + "1";
        }

        private void twoButton_Clicked(object sender, EventArgs e)
        {
            displayNum_Label.Text = displayNum_Label.Text + "2";
        }

        private void threeButton_Clicked(object sender, EventArgs e)
        {
            displayNum_Label.Text = displayNum_Label.Text + "3";
        }

        private void zeroButton_Clicked(object sender, EventArgs e)
        {
            displayNum_Label.Text = displayNum_Label.Text + "0";
        }

        //OPERATION BUTTONS

        private void clearButton_Clicked(object sender, EventArgs e)
        {
            if(displayNum_Label.Text != null)
            {
                displayNum_Label.Text = "";
            }
        }

        private void addButton_Clicked(object sender, EventArgs e)
        {
            if(displayNum_Label.Text != null)
            {
                temp1 = double.Parse(displayNum_Label.Text);
                displayNum_Label.Text = "";
                operation = "add";
            }
        }

        private void subButton_Clicked(object sender, EventArgs e)
        {
            if (displayNum_Label.Text != null)
            {
                temp1 = double.Parse(displayNum_Label.Text);
                displayNum_Label.Text = "";
                operation = "sub";
            }
        }

        private void mulButton_Clicked(object sender, EventArgs e)
        {
            if (displayNum_Label.Text != null)
            {
                temp1 = double.Parse(displayNum_Label.Text);
                displayNum_Label.Text = "";
                operation = "mul";
            }
        }

        private void divButton_Clicked(object sender, EventArgs e)
        {
            if (displayNum_Label.Text != null)
            {
                temp1 = double.Parse(displayNum_Label.Text);
                displayNum_Label.Text = "";
                operation = "div";
            }
        }

        //NOTE: Should make it a switch statement.

        //ALGORITHM: 
            //checks that the field is not empty
            //if = button pressed, means that there is already a first number entered and stored into temp1 so the current one goes into temp 2.
            //uses the string "operation" to decide which operation to make with temp1 and temp2. displays them and resets tamporary variables.

        private void equalButton_Clicked(object sender, EventArgs e)
        {
            if(displayNum_Label.Text != null)
            {
                if (operation == "add")
                {
                    temp2 = double.Parse(displayNum_Label.Text);
                    result = temp1 + temp2;
                    displayNum_Label.Text = result.ToString();
                }else if(operation == "sub")
                {
                    temp2 = double.Parse(displayNum_Label.Text);
                    result = temp1 - temp2;
                    displayNum_Label.Text = result.ToString();
                }else if(operation == "mul")
                {
                    temp2 = double.Parse(displayNum_Label.Text);
                    result = temp1 * temp2;
                    displayNum_Label.Text = result.ToString();
                }else if(operation == "div")
                {
                    temp2 = double.Parse(displayNum_Label.Text);
                    result = temp1 / temp2;
                    displayNum_Label.Text = result.ToString();
                }

                //temp varaibles reset.
                temp1 = 0;
                temp2 = 0;
                result = 0;
            }
        }
    }
}
