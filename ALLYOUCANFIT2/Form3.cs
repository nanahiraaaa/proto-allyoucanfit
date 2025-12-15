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
    public partial class Form3 : Form
    {
        private string goal;
        private double targetCalories;
        private double targetProtein;
        private double targetCarbs;
        private Food bestFood;

        public Form3(string goal, double calories, double protein, double carbs)
        {
            InitializeComponent();
            this.goal = goal;
            this.targetCalories = calories;
            this.targetProtein = protein;
            this.targetCarbs = carbs;
        }

        // Food Structure
        public class Food
        {
            public string Name { get; set; }
            public double Calories { get; set; }
            public double Protein { get; set; }
            public double Price { get; set; }
        }

        //Load the correct menu
        private List<Food> GetMenu()
        {
            if (goal == "Lose")
            {
                return new List<Food>()
                {
                    new Food { Name = "Grilled Salmon & Roasted Asparagus", Calories = 400, Protein = 40, Price = 350 },
                    new Food { Name = "Lean Turkey Chili", Calories = 350, Protein = 30, Price = 300 },
                    new Food { Name = "Chicken & Veggie Stir-fry", Calories = 330, Protein = 40, Price = 380 },
                    new Food { Name = "Greek Yogurt Parfait", Calories = 300, Protein = 25, Price = 250 },
                    new Food { Name = "Egg White Vegetable Scramble", Calories = 220, Protein = 25, Price = 120 }
                };
            }

            if (goal == "Maintain")
            {
                return new List<Food>()
                {
                    new Food { Name = "Quinoa Bowl with Chicken & Avocado", Calories = 530, Protein = 50, Price = 250 },
                    new Food { Name = "Turkey Sandwich on Whole Wheat", Calories = 500, Protein = 40, Price = 300 },
                    new Food { Name = "Lentil Soup with Whole-Grain Bread", Calories = 450, Protein = 30, Price = 190 },
                    new Food { Name = "Salmon Salad with Sweet Potato", Calories = 550, Protein = 40, Price = 250 },
                    new Food { Name = "High-Protein Oatmeal Power Bowl", Calories = 500, Protein = 35, Price = 150 }
                };
            }

            // GAIN menu
            return new List<Food>()
            {
                new Food { Name = "Power Oatmeal with Nut Butter & Protein", Calories = 750, Protein = 45, Price = 200 },
                new Food { Name = "Loaded Chicken & Rice Bowl", Calories = 680, Protein = 50, Price = 180 },
                new Food { Name = "High-Calorie Mass Gainer Shake", Calories = 800, Protein = 50, Price = 120 },
                new Food { Name = "Beef & Sweet Potato Mash", Calories = 650, Protein = 45, Price = 350 },
                new Food { Name = "Salmon & Whole-Wheat Pasta Alfredo", Calories = 750, Protein = 50, Price = 350 }
            };
        }

        //Find best match
        private void ShowRecommendations()
        {
            List<Food> menu = GetMenu();

            Food best = null;
            double bestScore = double.MaxValue;

            foreach (var f in menu)
            {
                double score =
                    Math.Abs(f.Calories - targetCalories) +
                    Math.Abs(f.Protein - targetProtein);

                if (score < bestScore)
                {
                    bestScore = score;
                    best = f;
                }
            }

            best = best;

            richTextBox1.Clear();

            if (best != null)
            {
                richTextBox1.AppendText("=== Recommended Meal ===\n\n");

                richTextBox1.AppendText($"{best.Name}\n");
                richTextBox1.AppendText($"Calories: {best.Calories}\n");
                richTextBox1.AppendText($"Protein: {best.Protein}\n");
                richTextBox1.AppendText($"Price: ₱{best.Price}\n");
            }
        }




        private void Form3_Load(object sender, EventArgs e)
        {
            ShowRecommendations();
        }

        private void btn_proceed3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "You must be logged in to continue.\nDo you want to login first?",
            "Checkout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

        if (result == DialogResult.Yes)
            {
            // User wants to login
                Form4 login = new Form4();
                login.Show();
            }
        else{
        // User continues as guest
            paymentForm pay = new paymentForm(
            bestFood.Name,
            bestFood.Calories,
            bestFood.Protein,
            bestFood.Price
            );

        pay.Show();
            }

        }
    }
}
