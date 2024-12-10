namespace NetCsharpWinFormsCrestNuls
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(31, 26);
            button1.Name = "button1";
            button1.Size = new Size(127, 125);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(164, 26);
            button2.Name = "button2";
            button2.Size = new Size(127, 125);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button3_Click;
            // 
            // button3
            // 
            button3.Location = new Point(297, 26);
            button3.Name = "button3";
            button3.Size = new Size(127, 125);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(31, 157);
            button4.Name = "button4";
            button4.Size = new Size(127, 125);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(164, 157);
            button5.Name = "button5";
            button5.Size = new Size(127, 125);
            button5.TabIndex = 0;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button3_Click;
            // 
            // button6
            // 
            button6.Location = new Point(297, 157);
            button6.Name = "button6";
            button6.Size = new Size(127, 125);
            button6.TabIndex = 0;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button3_Click;
            // 
            // button7
            // 
            button7.Location = new Point(31, 288);
            button7.Name = "button7";
            button7.Size = new Size(127, 125);
            button7.TabIndex = 0;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button3_Click;
            // 
            // button8
            // 
            button8.Location = new Point(164, 288);
            button8.Name = "button8";
            button8.Size = new Size(127, 125);
            button8.TabIndex = 0;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button3_Click;
            // 
            // button9
            // 
            button9.Location = new Point(297, 288);
            button9.Name = "button9";
            button9.Size = new Size(127, 125);
            button9.TabIndex = 0;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button3_Click;
            // 
            // button10
            // 
            button10.Location = new Point(501, 26);
            button10.Name = "button10";
            button10.Size = new Size(204, 57);
            button10.TabIndex = 1;
            button10.Text = "НАЧАТЬ ИГРУ";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(501, 109);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(172, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Первым ходит компьютер";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(button10);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private CheckBox checkBox1;
    }
}
