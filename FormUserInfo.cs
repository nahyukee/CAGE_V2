using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WorkoutApp
{
    public partial class FormUserInfo : Form
    {
        #region Rounded edges
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int left,     
            int right,      
            int top,    
            int bottom,  
            int Width, 
            int height
        );
        #endregion  

        public FormUserInfo()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 6, 66));
       
        }
        //INCLUDES ALL CALCULATIONS
        #region CALCULATION METHODS 

        #region MacroCalculator (last output)
        //fix the calculations for protein, carbs, fat
        String MacroCalculator()
        {
            double weight = Convert.ToDouble(txtWeight.Text);
            double totalcalories = Goalpicker();
            int protein = (Convert.ToInt32(totalcalories * .32 / 4));
            int carbs = (Convert.ToInt32((totalcalories * .40) / 4));
            int fat = (Convert.ToInt32((totalcalories * .25) / 9));

            if (boxGoals.Text == "Lose")
            {
                return ($"Hi {txtName.Text}," + "\r\n" +
                        "Your macros are:" + "\r\n" +
                        $"Protein: {protein}" + "\r\n" +
                        $"Carbohydrates: {carbs}" + "\r\n" +
                        $"Fat: {fat}");
            }
            if (boxGoals.Text == "Maintain")
            {
                return ($"Hi {txtName.Text}," + "\r\n" +
                        $"Your macros are:" + "\r\n" +
                        $"Protein: {protein}" + "\r\n" +
                        $"Carbohydrates: {carbs}" + "\r\n" +
                        $"Fat: {fat}");
            }
            if (boxGoals.Text == "Gain")
            {
                return ($"Hi {txtName.Text}," + "\r\n" +
                        $"Your macros are:" + "\r\n" +
                        $"Protein: {protein}" + "\r\n" +
                        $"Carbohydrates: {carbs}" + "\r\n" +
                        $"Fat: {fat}");
            }
            return Convert.ToString("");
        }
        #endregion

        #region Goalpicker
        Double Goalpicker()
        {
            double goalTDEE = Activitypicker();
            double lose = .8;
            double maintain = 1.0;
            double gain = 1.2;

            if (boxGoals.Text == "Lose")
            {
                return Convert.ToInt32(goalTDEE * lose);
            }
            else if (boxGoals.Text == "Maintain")
            {
                return Convert.ToInt32(goalTDEE * maintain);
            }
            else if (boxGoals.Text == "Gain")
            {
                return Convert.ToInt32(goalTDEE * gain);
            }
            return Convert.ToInt32("do nothing");

        }
        #endregion

        #region Activitypicker
        Double Activitypicker()
        {
            double actTEE = Genderpicker();
            double little = 1.2;
            double light = 1.375;
            double mod = 1.55;
            double vig = 1.725;
            double ext = 1.9;

            if (boxActivity.Text == "Little")
            {
                return Convert.ToDouble(actTEE * little);
            }
            if (boxActivity.Text == "Light")
            {
                return Convert.ToDouble(actTEE * light);
            }
            if (boxActivity.Text == "Moderate")
            {
                return Convert.ToDouble(actTEE * mod);
            }
            if (boxActivity.Text == "Vigorous")
            {
                return Convert.ToDouble(actTEE * vig);
            }
            if (boxActivity.Text == "Extreme")
            {
                Convert.ToDouble(actTEE * ext);
            }
            return Convert.ToDouble("do nothing");
            
        }
        #endregion 

        #region Genderpicker
        Double Genderpicker()
        {
            double height = Convert.ToDouble(txtHeight.Text);
            double weight = Convert.ToDouble(txtWeight.Text);
            double age = Convert.ToDouble(txtAge.Text);
            double sumMaleREE = Convert.ToDouble(66 + (13.7 * (weight / 2.2)) + (5 * (height * 2.54)) - (6.8 * age));
            double sumFemaleREE = Convert.ToDouble(655 + (9.6 * (weight / 2.2)) + (1.85 * (height * 2.54)) - (4.7 * age));

            if (boxGender.Text == "Male")
            {
                return Convert.ToDouble(sumMaleREE);
                
            }
            else if (boxGender.Text == "Female")
            {
                return Convert.ToDouble(sumFemaleREE);
            }
            return Convert.ToDouble("do nothing");

        }
        #endregion

        #endregion




        #region Label state change Appearance

        private void BtnCalcMacros_Click(object sender, EventArgs e)
        {
            txtMacros.Text = Convert.ToString(MacroCalculator());
            txtTotalCalories.Text = Convert.ToString(Goalpicker());
        }

        //private void BtnCalories_Click(object sender, EventArgs e)
        //{
        //    txtTotalCalories.Text = Convert.ToString(Goalpicker());
        //}


        private void txtName_ModifiedChanged(object sender, EventArgs e)
        {
            txtName.ForeColor = Color.Black;
        }

        private void txtWeight_ModifiedChanged(object sender, EventArgs e)
        {
            txtWeight.ForeColor = Color.Black;
        }

        private void txtHeight_ModifiedChanged(object sender, EventArgs e)
        {
            txtHeight.ForeColor = Color.Black;
        }

        private void txtAge_ModifiedChanged(object sender, EventArgs e)
        {
            txtAge.ForeColor = Color.Black;
        }

        private void boxActivity_SelectedValueChanged(object sender, EventArgs e)
        {
            boxActivity.ForeColor = Color.Black;
        }
        private void boxGoals_SelectedValueChanged(object sender, EventArgs e)
        {
            boxGoals.ForeColor = Color.Black;
        }

        private void boxGender_SelectedValueChanged(object sender, EventArgs e)
        {
            boxGender.ForeColor = Color.Black;
        }



        #endregion

      
    }
}
