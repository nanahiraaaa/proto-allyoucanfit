using System.Net.Sockets;

namespace ALLYOUCANFIT2
{
    public partial class submitBtn : Form

    {
        private string selectedMode = "";
        public submitBtn()
        {
            InitializeComponent();
        }
        //Age
        private void Age_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(Age.Text, out _))
            {
                Age.Text = "";
            }
        }
        //Weight
        private void Weight_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(Weight.Text, out _))
            {
                Weight.Text = "";
            }
        }
        //Height
        private void Height_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(Height.Text, out _))
            {
                Height.Text = "";
            }
        }

        //LOSE WEIGHT BUTTON
        private void btnLose_Click(object sender, EventArgs e)
        {
            selectedMode = "Lose";
        }
        //MAINTAIN WEIGHT BUTTON
        private void btnMaintain_Click(object sender, EventArgs e)
        {
            selectedMode = "Maintain";
        }
        //GAIN WEIGHT BUTTON
        private void btnGain_Click(object sender, EventArgs e)
        {
            selectedMode = "Gain";
        }

        //submit button
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Read inputs
            if (!int.TryParse(Age.Text, out int age) ||
                !int.TryParse(Height.Text, out int height) ||
                !double.TryParse(Weight.Text, out double weight))
            {
                MessageBox.Show("Please enter valid Age (int), Height (cm), and Weight (kg).");
                return;
            }

            if (selectedMode == "")
            {
                MessageBox.Show("Please select a goal: Lose, Maintain, Gain.");
                return;
            }

            // ----- MULTIPLIERS -----
            double goalMultiplier = 1.0;
            double proteinFactor = 1.4;

            if (selectedMode == "Lose")
            {
                goalMultiplier = 0.9;
                proteinFactor = 1.8;
            }
            else if (selectedMode == "Maintain")
            {
                goalMultiplier = 1.0;
                proteinFactor = 1.4;
            }
            else if (selectedMode == "Gain")
            {
                goalMultiplier = 1.15;
                proteinFactor = 2.0;
            }

            // ----- FORMULAS -----
            double dailyCalories = (10 * weight) + (6.25 * height) - (5 * age) + 5;
            double adjustedCalories = dailyCalories * goalMultiplier;
            double mealCalories = adjustedCalories / 3;

            double dailyProtein = weight * proteinFactor;
            double mealProtein = dailyProtein / 3;
            double proteinCalories = mealProtein * 4;

            double mealCarbs = (mealCalories - proteinCalories) / 4;

            double bmi = weight / Math.Pow(height / 100.0, 2);

            // ---- PASS TO FORM2 ----
            Form2 resultsForm = new Form2(
                bmi,
                dailyCalories,
                adjustedCalories,
                mealCalories,
                dailyProtein,
                mealProtein,
                mealCarbs,
                selectedMode

            );

            resultsForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }   
    }
}

