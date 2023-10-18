namespace nameapp
{
    partial class Form1
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
            nameInput = new TextBox();
            richTextBox1 = new RichTextBox();
            getParagraph = new Button();
            checkBox1 = new CheckBox();
            printButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // nameInput
            // 
            nameInput.Location = new Point(730, 154);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(150, 31);
            nameInput.TabIndex = 0;
            nameInput.KeyPress += nameInput_KeyPress;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(105, 78);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(575, 654);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.KeyPress += richTextBox1_KeyPress;
            // 
            // getParagraph
            // 
            getParagraph.Location = new Point(730, 211);
            getParagraph.Name = "getParagraph";
            getParagraph.Size = new Size(153, 34);
            getParagraph.TabIndex = 2;
            getParagraph.Text = "Get Paragraph";
            getParagraph.UseVisualStyleBackColor = true;
            getParagraph.Click += getParagraph_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(714, 346);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(168, 29);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "קרע שטן include";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // printButton
            // 
            printButton.Location = new Point(730, 509);
            printButton.Name = "printButton";
            printButton.Size = new Size(112, 34);
            printButton.TabIndex = 4;
            printButton.Text = "Print Text";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(730, 560);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Help";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 744);
            Controls.Add(button1);
            Controls.Add(printButton);
            Controls.Add(checkBox1);
            Controls.Add(getParagraph);
            Controls.Add(richTextBox1);
            Controls.Add(nameInput);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameInput;
        private RichTextBox richTextBox1;
        private Button getParagraph;
        private CheckBox checkBox1;
        private Button printButton;
        private Button button1;
    }
}