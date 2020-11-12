using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounterConverter
{
    public partial class fatsCarbsConverterForm : Form
    {
        public fatsCarbsConverterForm()
        {
            InitializeComponent();
        }

        //converts grams of fat to calories
        static double fromFats(double d)
        {
            return d * 9;
        }

        //converts grams of carbs to calories
        static double fromCarbs(double d)
        {
            return d * 4;
        }

        //sums two doubles
        static double total(double d, double c)
        {
            return d + c;
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            double fats = 0;
            double carbs = 0;
            double calFats = 0;
            double calCarbs = 0;
            double totalCal;

            //checks for empty textbox
            if (String.IsNullOrEmpty(fatGramsTextBox.Text))
            {
                //if nothing is entered display 0
                displayCaloriesFromFats.Text = "0";
            } 
            else if (double.TryParse(fatGramsTextBox.Text, out fats))
            {
                //convert user input to calories from fats
                calFats = fromFats(fats);
            } 
            else
            {
                //display to user invalid input
                MessageBox.Show("Invalid input for Fats");
            }

            //checks for empty textbox
            if (String.IsNullOrEmpty(gramsCarbsTextBox.Text))
            {
                //if nothing is entered display 0
                displayCaloriesFromCarbs.Text = "0";
            }
            else if (double.TryParse(gramsCarbsTextBox.Text, out carbs))
            {
                //convert user input to calories from carbs
                calCarbs = fromCarbs(carbs);
            }
            else
            {
                //display to user invalid input
                MessageBox.Show("Invalid input for Carbs");
            }

            //total calories
            totalCal = total(calCarbs, calFats);

            //output calculations
            displayCaloriesFromFats.Text = calFats.ToString();
            displayCaloriesFromCarbs.Text = calCarbs.ToString();
            displayTotalCalories.Text = totalCal.ToString();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear user input and output
            fatGramsTextBox.Text = "";
            gramsCarbsTextBox.Text = "";
            displayCaloriesFromCarbs.Text = "";
            displayCaloriesFromCarbs.Text = "";
            displayTotalCalories.Text = "";

            //reset focus to first textbox
            fatGramsTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
