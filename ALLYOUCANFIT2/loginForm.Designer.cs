namespace ALLYOUCANFIT2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            txtEmployeeID = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_login = new Button();
            SuspendLayout();
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(171, 226);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(232, 27);
            txtEmployeeID.TabIndex = 0;
            txtEmployeeID.TextChanged += txt_empId_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(171, 323);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(232, 27);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 229);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 2;
            label1.Text = "EMPLOYEE ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 326);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "PASSWORD:";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(180, 436);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(155, 67);
            btn_login.TabIndex = 4;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(482, 726);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmployeeID);
            Name = "Form4";
            Text = "Form4";
            Load += btnLogin_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmployeeID;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btn_login;
    }
}