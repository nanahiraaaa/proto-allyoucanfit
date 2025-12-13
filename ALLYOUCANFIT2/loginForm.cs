using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ALLYOUCANFIT2
{
    public partial class Form4 : Form
    {
        private const string conStr = "server=localhost;database=employee_records;uid=root;pwd=;";
        public double EmployeeDiscountRate { get; private set; } = 0.0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txt_empId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string employeeID = this.txtEmployeeID.Text.Trim();
            string password = this.txtPassword.Text;
            int employeeLevel = 0;

            if (string.IsNullOrEmpty(employeeID) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Employee ID and Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(conStr))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT employee_status_id FROM employees WHERE employee_id = @id AND Password = @pwd";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id", employeeID);
                    command.Parameters.AddWithValue("@pwd", password);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        employeeLevel = Convert.ToInt32(result);

                        // 3. Apply Discount Logic
                        switch (employeeLevel)
                        {
                            case 3: // Manager (20% discount)
                                this.EmployeeDiscountRate = 0.20;
                                break;
                            case 2: // Regular (15% discount)
                                this.EmployeeDiscountRate = 0.15;
                                break;
                            case 1: // Irregular (10% discount)
                                this.EmployeeDiscountRate = 0.10;
                                break;
                            default:
                                this.EmployeeDiscountRate = 0.0;
                                break;
                        }

                        // 4. Successful Login: Transition UI
                        MessageBox.Show($"Login Successful. Discount: {this.EmployeeDiscountRate * 100}%", "Welcome");

                        // Example: Hide the login area and show the main menu
                        this.txtEmployeeID.Visible = false;
                        this.txtPassword.Visible = false;
                        this.btn_login.Visible = false;
                        // You will need to make your main app controls visible here.

                    }
                    else
                    {
                        MessageBox.Show("Invalid Employee ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.EmployeeDiscountRate = 0.0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.EmployeeDiscountRate = 0.0;
                }
            }
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            btn_login_Click(sender, e);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }
        public double CalculateFinalPrice(double subTotal)
        {
            double finalPrice = subTotal * (1 - this.EmployeeDiscountRate);
            return finalPrice;
        }
    }
}
