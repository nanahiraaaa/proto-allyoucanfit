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
    public partial class paymentForm : Form
    {
        private string mealName;
        private double calories;
        private double protein;
        private double price;

        // Constructor receives the selected meal details
        public paymentForm(string mealName, double calories, double protein, double price)
        {
            InitializeComponent();

            this.mealName = mealName;
            this.calories = calories;
            this.protein = protein;
            this.price = price;
        }
        public paymentForm()
        {
            InitializeComponent();
        }

        // Load values into labels when the form opens
        private void paymentForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            richTextBox1.AppendText("=== PAYMENT SUMMARY ===\n\n");
            richTextBox1.AppendText($"Meal: {mealName}\n");
            richTextBox1.AppendText($"Calories: {calories}\n");
            richTextBox1.AppendText($"Protein: {protein}\n");
            richTextBox1.AppendText($"Price: ₱{price}\n");
        }

        private void btn_proceed3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Payment Successful!\nThank you for your order.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }

        // Cancel button
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
