using System;
using System.Collections.Generic;
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
            this.goal = goal.ToLower();
            targetCalories = calories;
            targetProtein = protein;
            targetCarbs = carbs;
        }

        // ================= FOOD CLASS =================
        public class Food
        {
            public string Name { get; set; }
            public double Calories { get; set; }
            public double Protein { get; set; }
            public double Carbs { get; set; }
            public double Price { get; set; }
        }

        // ================= MENU =================
        private List<Food> GetMenu()
        {
            if (goal == "lose")
            {
                return new List<Food>
                {
                    new Food { Name="Grilled Salmon & Roasted Asparagus", Calories=400, Protein=40, Carbs=20, Price=350 },
                    new Food { Name="Lean Turkey Chili", Calories=350, Protein=30, Carbs=25, Price=300 },
                    new Food { Name="Chicken & Veggie Stir-fry", Calories=330, Protein=40, Carbs=30, Price=380 },
                    new Food { Name="Greek Yogurt Parfait", Calories=300, Protein=25, Carbs=35, Price=250 },
                    new Food { Name="Egg White Vegetable Scramble", Calories=220, Protein=25, Carbs=10, Price=120 }
                };
            }

            if (goal == "maintain")
            {
                return new List<Food>
                {
                    new Food { Name="Quinoa Bowl with Chicken & Avocado", Calories=530, Protein=50, Carbs=45, Price=250 },
                    new Food { Name="Turkey Sandwich on Whole Wheat", Calories=500, Protein=40, Carbs=50, Price=300 },
                    new Food { Name="Lentil Soup with Whole-Grain Bread", Calories=450, Protein=30, Carbs=55, Price=190 },
                    new Food { Name="Salmon Salad with Sweet Potato", Calories=550, Protein=40, Carbs=60, Price=250 },
                    new Food { Name="High-Protein Oatmeal Power Bowl", Calories=500, Protein=35, Carbs=65, Price=150 }
                };
            }

            // GAIN
            return new List<Food>
            {
                new Food { Name="Power Oatmeal with Nut Butter & Protein", Calories=750, Protein=45, Carbs=90, Price=200 },
                new Food { Name="Loaded Chicken & Rice Bowl", Calories=680, Protein=50, Carbs=85, Price=180 },
                new Food { Name="High-Calorie Mass Gainer Shake", Calories=800, Protein=50, Carbs=100, Price=120 },
                new Food { Name="Beef & Sweet Potato Mash", Calories=650, Protein=45, Carbs=70, Price=350 },
                new Food { Name="Salmon & Whole-Wheat Pasta Alfredo", Calories=750, Protein=50, Carbs=80, Price=350 }
            };
        }

        // ================= RECOMMENDATION =================
        private void ShowRecommendations()
        {
            List<Food> menu = GetMenu();
            bestFood = null;

            double bestScore = double.MaxValue;

            foreach (Food f in menu)
            {
                double score =
                    Math.Abs(f.Calories - targetCalories) +
                    Math.Abs(f.Protein - targetProtein) +
                    Math.Abs(f.Carbs - targetCarbs);

                if (score < bestScore)
                {
                    bestScore = score;
                    bestFood = f;
                }
            }

            richTextBox1.Clear();

            if (bestFood != null)
            {
                richTextBox1.AppendText("=== Recommended Meal ===\n\n");
                richTextBox1.AppendText($"{bestFood.Name}\n");
                richTextBox1.AppendText($"Calories: {bestFood.Calories}\n");
                richTextBox1.AppendText($"Protein: {bestFood.Protein}g\n");
                richTextBox1.AppendText($"Carbs: {bestFood.Carbs}g\n");
                richTextBox1.AppendText($"Price: ₱{bestFood.Price}\n");
            }
            else
            {
                richTextBox1.AppendText("No suitable meal found.");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ShowRecommendations();
        }

        // ================= CHECKOUT =================
        private void btn_proceed3_Click(object sender, EventArgs e)
        {
            if (bestFood == null)
            {
                MessageBox.Show("No food selected.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "You must be logged in to continue.\nDo you want to login first?",
                "Checkout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                loginForm login = new loginForm();
                login.Show();
                this.Hide();
            }
            else
            {
                paymentForm pay = new paymentForm(
                    bestFood.Name,
                    bestFood.Calories,
                    bestFood.Protein,
                    bestFood.Price
                );

                pay.Show();
                this.Hide();
            }
        }
    }
}
