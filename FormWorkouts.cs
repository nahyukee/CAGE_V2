using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkoutApp
{
    public partial class FormWorkouts : Form
    {
        public FormWorkouts()
        {
            InitializeComponent();
        }

        private void BtnDesignWorkout_Click(object sender, EventArgs e)
        {

           
         if(boxWorkout.Text == "2")
            {
                txtMon.Text = "FullBody" + Environment.NewLine +
                     "3x5 Flat BB Bench Press" + Environment.NewLine +
                     "3x10 Incline DB Press" + Environment.NewLine +
                     "3x10 Lateral PD" + Environment.NewLine +
                     "3x10 Seated Rows" + Environment.NewLine +
                     "3x12 Hammer Curls" + Environment.NewLine +
                     "3x12 Tricep Extensions" + Environment.NewLine +
                     "5x8 Barbell Squats";
                txtTues.Text = "Rest";
                txtWed.Text = "Rest";
                txtFri.Text = "Rest";
                txtThurs.Text = "FullBody" + Environment.NewLine +
                    "3 x 5 Decline BB BP" + Environment.NewLine +
                    "3 x 10 Incline DB Press" + Environment.NewLine +
                    "3 x 10 DB Row" + Environment.NewLine +
                    "3 x 10 Single Arm Row" + Environment.NewLine +
                    "3 x 12 Dumbbell curls" + Environment.NewLine +
                    "3 x 12 Tricep PD" + Environment.NewLine +
                    "5 x 5 Barbell Squats";
            }

            if (boxWorkout.Text == "4")
            {
                txtMon.Text = "FullBody" + Environment.NewLine +
                    "3x5 Flat BB Bench Press" + Environment.NewLine +
                    "3x10 Incline DB Press" + Environment.NewLine +
                    "3x10 Lateral PD" + Environment.NewLine +
                    "3x10 Seated Rows" + Environment.NewLine +
                    "3x12 Hammer Curls" + Environment.NewLine +
                    "3x12 Tricep Extensions" + Environment.NewLine +
                    "5x8 Barbell Squats";
                txtTues.Text = "FullBody" + Environment.NewLine +
                    "3 x 5 Decline BB BP" + Environment.NewLine +
                    "3 x 10 Incline DB Press" + Environment.NewLine +
                    "3 x 10 DB Row" + Environment.NewLine +
                    "3 x 10 Single Arm Row" + Environment.NewLine +
                    "3 x 12 Dumbbell curls" + Environment.NewLine +
                    "3 x 12 Tricep PD" + Environment.NewLine +
                    "5 x 5 Barbell Squats";
                txtWed.Text = "Rest";
                txtThurs.Text = "FullBody" + Environment.NewLine +
                    "3 x 5 Decline BB BP" + Environment.NewLine +
                    "3 x 10 Incline DB Press" + Environment.NewLine +
                    "3 x 10 DB Row" + Environment.NewLine +
                    "3 x 10 Single Arm Row" + Environment.NewLine +
                    "3 x 12 Dumbbell curls" + Environment.NewLine +
                    "3 x 12 Tricep PD" + Environment.NewLine +
                    "5 x 5 Barbell Squats";
                txtFri.Text = "FullBody" + Environment.NewLine +
                    "3 x 5 Decline BB BP" + Environment.NewLine +
                    "3 x 10 Incline DB Press" + Environment.NewLine +
                    "3 x 10 DB Row" + Environment.NewLine +
                    "3 x 10 Single Arm Row" + Environment.NewLine +
                    "3 x 12 Dumbbell curls" + Environment.NewLine +
                    "3 x 12 Tricep PD" + Environment.NewLine +
                    "5 x 5 Barbell Squats";
            }

            if (boxWorkout.Text == "5")
            {
                txtMon.Text = "FullBody" + Environment.NewLine +
                     "3x5 Flat BB Bench Press" + Environment.NewLine +
                     "3x10 Incline DB Press" + Environment.NewLine +
                     "3x10 Lateral PD" + Environment.NewLine +
                     "3x10 Seated Rows" + Environment.NewLine +
                     "3x12 Hammer Curls" + Environment.NewLine +
                     "3x12 Tricep Extensions" + Environment.NewLine +
                     "5x8 Barbell Squats";
                txtTues.Text = "FullBody" + Environment.NewLine +
                    "3 x 5 Decline BB BP" + Environment.NewLine +
                    "3 x 10 Incline DB Press" + Environment.NewLine +
                    "3 x 10 DB Row" + Environment.NewLine +
                    "3 x 10 Single Arm Row" + Environment.NewLine +
                    "3 x 12 Dumbbell curls" + Environment.NewLine +
                    "3 x 12 Tricep PD" + Environment.NewLine +
                    "5 x 5 Barbell Squats";
                txtWed.Text = "FullBody" + Environment.NewLine +
                    "3 x 5 Decline BB BP" + Environment.NewLine +
                    "3 x 10 Incline DB Press" + Environment.NewLine +
                    "3 x 10 DB Row" + Environment.NewLine +
                    "3 x 10 Single Arm Row" + Environment.NewLine +
                    "3 x 12 Dumbbell curls" + Environment.NewLine +
                    "3 x 12 Tricep PD" + Environment.NewLine +
                    "5 x 5 Barbell Squats";
                txtThurs.Text = "FullBody" + Environment.NewLine +
                    "3 x 5 Decline BB BP" + Environment.NewLine +
                    "3 x 10 Incline DB Press" + Environment.NewLine +
                    "3 x 10 DB Row" + Environment.NewLine +
                    "3 x 10 Single Arm Row" + Environment.NewLine +
                    "3 x 12 Dumbbell curls" + Environment.NewLine +
                    "3 x 12 Tricep PD" + Environment.NewLine +
                    "5 x 5 Barbell Squats";
                txtFri.Text = "FullBody" + Environment.NewLine +
                    "3 x 5 Decline BB BP" + Environment.NewLine +
                    "3 x 10 Incline DB Press" + Environment.NewLine +
                    "3 x 10 DB Row" + Environment.NewLine +
                    "3 x 10 Single Arm Row" + Environment.NewLine +
                    "3 x 12 Dumbbell curls" + Environment.NewLine +
                    "3 x 12 Tricep PD" + Environment.NewLine +
                    "5 x 5 Barbell Squats";
            }


        }



        private void boxWorkout_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxWorkout.ForeColor = Color.Black;
        }
    }
}
