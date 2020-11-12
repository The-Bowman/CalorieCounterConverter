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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double fromFats(double d)
        {
            return d * 9;
        }

        static double fromCarbs(double d)
        {
            return d * 4;
        }

        private void totalButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fatGramsTextBox.Text = "";
            gramsCarbsTextBox.Text = "";
            displayCaloriesFromCarbs.Text = "";
            displayCaloriesFromCarbs.Text = "";
            displayTotalCalories.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
