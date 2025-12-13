namespace ALLYOUCANFIT2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            richTextBox1 = new RichTextBox();
            btn_proceed3 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(58, 149);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(367, 428);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // btn_proceed3
            // 
            btn_proceed3.Location = new Point(161, 592);
            btn_proceed3.Name = "btn_proceed3";
            btn_proceed3.Size = new Size(144, 73);
            btn_proceed3.TabIndex = 11;
            btn_proceed3.Text = "PROCEED";
            btn_proceed3.UseVisualStyleBackColor = true;
            btn_proceed3.Click += btn_proceed3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(482, 726);
            Controls.Add(btn_proceed3);
            Controls.Add(richTextBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btn_proceed3;
    }
}