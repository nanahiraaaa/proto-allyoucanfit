namespace ALLYOUCANFIT2
{
    partial class submitBtn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label1;
            Label label2;
            Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(submitBtn));
            Age = new TextBox();
            Height = new TextBox();
            Weight = new TextBox();
            btnGain = new Button();
            btnMaintain = new Button();
            btnLose = new Button();
            btnSubmit = new Button();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 494);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 12;
            label1.Text = "LOSE WEIGHT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 494);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 13;
            label2.Text = "MAINTAIN WEIGHT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 494);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 14;
            label4.Text = "GAIN WEIGHT";
            // 
            // Age
            // 
            Age.BackColor = Color.White;
            Age.Font = new Font("Segoe UI", 14F);
            Age.Location = new Point(147, 177);
            Age.Name = "Age";
            Age.Size = new Size(220, 39);
            Age.TabIndex = 1;
            Age.TextAlign = HorizontalAlignment.Center;
            Age.TextChanged += Age_TextChanged;
            // 
            // Height
            // 
            Height.BackColor = Color.White;
            Height.Font = new Font("Segoe UI", 14F);
            Height.Location = new Point(147, 269);
            Height.Name = "Height";
            Height.Size = new Size(220, 39);
            Height.TabIndex = 2;
            Height.TextAlign = HorizontalAlignment.Center;
            Height.TextChanged += Height_TextChanged;
            // 
            // Weight
            // 
            Weight.BackColor = Color.White;
            Weight.Font = new Font("Segoe UI", 14F);
            Weight.Location = new Point(147, 224);
            Weight.Name = "Weight";
            Weight.Size = new Size(220, 39);
            Weight.TabIndex = 3;
            Weight.TextAlign = HorizontalAlignment.Center;
            Weight.TextChanged += Weight_TextChanged;
            // 
            // btnGain
            // 
            btnGain.BackgroundImage = (Image)resources.GetObject("btnGain.BackgroundImage");
            btnGain.Location = new Point(194, 391);
            btnGain.Name = "btnGain";
            btnGain.Size = new Size(100, 100);
            btnGain.TabIndex = 4;
            btnGain.UseVisualStyleBackColor = true;
            btnGain.Click += btnGain_Click;
            // 
            // btnMaintain
            // 
            btnMaintain.BackgroundImage = (Image)resources.GetObject("btnMaintain.BackgroundImage");
            btnMaintain.Location = new Point(300, 391);
            btnMaintain.Name = "btnMaintain";
            btnMaintain.Size = new Size(100, 100);
            btnMaintain.TabIndex = 5;
            btnMaintain.UseVisualStyleBackColor = true;
            btnMaintain.Click += btnMaintain_Click;
            // 
            // btnLose
            // 
            btnLose.BackgroundImage = (Image)resources.GetObject("btnLose.BackgroundImage");
            btnLose.ForeColor = Color.FromArgb(0, 0, 192);
            btnLose.Location = new Point(85, 391);
            btnLose.Name = "btnLose";
            btnLose.Size = new Size(100, 100);
            btnLose.TabIndex = 6;
            btnLose.UseVisualStyleBackColor = true;
            btnLose.Click += btnLose_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(133, 536);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(220, 61);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "PROCEED";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 53);
            label3.Name = "label3";
            label3.Size = new Size(0, 50);
            label3.TabIndex = 11;
            // 
            // submitBtn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(482, 726);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnSubmit);
            Controls.Add(btnLose);
            Controls.Add(btnMaintain);
            Controls.Add(btnGain);
            Controls.Add(Weight);
            Controls.Add(Height);
            Controls.Add(Age);
            Name = "submitBtn";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Age;
        private TextBox Height;
        private TextBox Weight;
        private Button btnGain;
        private Button btnMaintain;
        private Button btnLose;
        private Button btnSubmit;
        private Label label3;
    }
}
