namespace ALLYOUCANFIT2
{
    partial class paymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentForm));
            richTextBox1 = new RichTextBox();
            btn_Pay = new Button();
            btn_Cancel = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(66, 142);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(355, 426);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // btn_Pay
            // 
            btn_Pay.Location = new Point(66, 588);
            btn_Pay.Name = "btn_Pay";
            btn_Pay.Size = new Size(156, 58);
            btn_Pay.TabIndex = 12;
            btn_Pay.Text = "PAY";
            btn_Pay.UseVisualStyleBackColor = true;
            btn_Pay.Click += btn_Pay_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(265, 588);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(156, 58);
            btn_Cancel.TabIndex = 13;
            btn_Cancel.Text = "CANCEL";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // paymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(482, 726);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Pay);
            Controls.Add(richTextBox1);
            Name = "paymentForm";
            Text = "paymentForm";
            Load += paymentForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btn_Pay;
        private Button btn_Cancel;
    }
}