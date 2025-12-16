using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ALLYOUCANFIT2
{
    public partial class Form3 : Form
    {
        private string goal;
        private double targetCalories;
        private double targetProtein;
        private double targetCarbs;

        private List<Food> menu;

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

            // NORMALIZED SCORE (FIXED CALCULATION)
            public double Score(double c, double p, double cb)
            {
                double calorieDiff = Math.Abs(Calories - c) / c;
                double proteinDiff = Math.Abs(Protein - p) / p;
                double carbDiff = Math.Abs(Carbs - cb) / cb;

                return calorieDiff + proteinDiff + carbDiff;
            }

            public override string ToString()
            {
                return $"{Name} | {Calories} kcal | {Protein}g P | {Carbs}g C | ₱{Price}";
            }
        }

        // ================= MENU BY GOAL =================
        private List<Food> GetMenu()
        {
            if (goal == "lose")
            {
                return new List<Food>
                {
                    new Food { Name="Grilled Salmon & Asparagus", Calories=400, Protein=40, Carbs=20, Price=350 },
                    new Food { Name="Lean Turkey Chili", Calories=350, Protein=30, Carbs=25, Price=300 },
                    new Food { Name="Chicken Veggie Stir-fry", Calories=330, Protein=40, Carbs=30, Price=380 },
                    new Food { Name="Greek Yogurt Parfait", Calories=300, Protein=25, Carbs=35, Price=250 },
                    new Food { Name="Egg White Scramble", Calories=220, Protein=25, Carbs=10, Price=120 }
                };
            }

            if (goal == "maintain")
            {
                return new List<Food>
                {
                    new Food { Name="Quinoa Chicken Bowl", Calories=530, Protein=50, Carbs=45, Price=250 },
                    new Food { Name="Turkey Sandwich", Calories=500, Protein=40, Carbs=50, Price=300 },
                    new Food { Name="Lentil Soup & Bread", Calories=450, Protein=30, Carbs=55, Price=190 },
                    new Food { Name="Salmon Salad", Calories=550, Protein=40, Carbs=60, Price=250 },
                    new Food { Name="Protein Oatmeal", Calories=500, Protein=35, Carbs=65, Price=150 }
                };
            }

            // GAIN
            return new List<Food>
            {
                new Food { Name="Power Oatmeal", Calories=750, Protein=45, Carbs=90, Price=200 },
                new Food { Name="Chicken Rice Bowl", Calories=680, Protein=50, Carbs=85, Price=180 },
                new Food { Name="Mass Gainer Shake", Calories=800, Protein=50, Carbs=100, Price=120 },
                new Food { Name="Beef Sweet Potato", Calories=650, Protein=45, Carbs=70, Price=350 },
                new Food { Name="Salmon Pasta Alfredo", Calories=750, Protein=50, Carbs=80, Price=350 }
            };
        }

        // ================= TARGET FILTER =================
        private bool IsWithinTarget(Food f)
        {
            bool caloriesOk = Math.Abs(f.Calories - targetCalories) <= targetCalories * 0.15;
            bool proteinOk = Math.Abs(f.Protein - targetProtein) <= targetProtein * 0.20;
            bool carbsOk = Math.Abs(f.Carbs - targetCarbs) <= targetCarbs * 0.20;

            return caloriesOk && proteinOk && carbsOk;
        }

        // ================= LOAD & FILTER =================
        private void LoadRecommendations()
        {
            menu = GetMenu();

            var filteredMeals = menu
                .Where(f => IsWithinTarget(f))
                .OrderBy(f => f.Score(targetCalories, targetProtein, targetCarbs))
                .ToList();

            listBox1.Items.Clear();

            if (filteredMeals.Count == 0)
            {
                MessageBox.Show(
                    "No meals closely match your nutrition needs.\nTry adjusting your inputs or goal.",
                    "No Recommendations"
                );
                return;
            }

            foreach (Food f in filteredMeals)
                listBox1.Items.Add(f);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadRecommendations();
        }

        // ================= CHECKOUT =================
        private void btn_proceed3_Click(object sender, EventArgs e)
        {
            Food selectedFood = listBox1.SelectedItem as Food;

            if (selectedFood == null)
            {
                MessageBox.Show("Please select a meal first.");
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
                Form4 login = new Form4();
                login.Show();
                this.Hide();
            }
            else
            {
                paymentForm pay = new paymentForm(
                    selectedFood.Name,
                    selectedFood.Calories,
                    selectedFood.Protein,
                    selectedFood.Price
                );

                pay.Show();
                this.Hide();
            }
        }
    }
}