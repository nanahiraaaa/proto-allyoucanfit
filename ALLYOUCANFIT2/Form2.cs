using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLYOUCANFIT2
{
    public partial class Form2 : Form
    {
        double bmi, dailyCalories, adjustedCalories, mealCalories, dailyProtein, mealProtein, mealCarbs;
        string goal;
        public Form2(
              double bmi,
              double dailyCalories,
              double adjustedCalories,
              double mealCalories,
              double dailyProtein,
              double mealProtein,
              double mealCarbs,
              string goal
            )
        {
            InitializeComponent();

            this.bmi = bmi;
            this.dailyCalories = dailyCalories;
            this.adjustedCalories = adjustedCalories;
            this.mealCalories = mealCalories;
            this.dailyProtein = dailyProtein;
            this.mealProtein = mealProtein;
            this.mealCarbs = mealCarbs;
            this.goal = goal;

            DisplayResults();

        }

        private void DisplayResults()
        {
            richTextBox1.Text =
                "===== NUTRITION SUMMARY =====\n\n" +
                $"BMI: {bmi:F2}\n\n" +
                $"Daily Calories: {dailyCalories:F0} kcal\n" +
                $"Adjusted Calories: {adjustedCalories:F0} kcal\n" +
                $"Meal Calories: {mealCalories:F0} kcal\n\n" +
                $"Daily Protein: {dailyProtein:F1} g\n" +
                $"Meal Protein: {mealProtein:F1} g\n\n" +
                $"Meal Carbs: {mealCarbs:F1} g\n\n" +
                "===============================";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // PROCEEED BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(goal, mealCalories, mealProtein, mealCarbs);
            f3.Show();
        }
    }
}
