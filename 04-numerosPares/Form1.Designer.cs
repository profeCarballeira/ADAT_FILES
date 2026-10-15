namespace _04_numerosPares
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
            textBox1 = new TextBox();
            button7 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button8 = new Button();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(21, 12);
            button1.Name = "button1";
            button1.Size = new Size(201, 82);
            button1.TabIndex = 0;
            button1.Text = "Números PARES";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(21, 110);
            button2.Name = "button2";
            button2.Size = new Size(201, 82);
            button2.TabIndex = 1;
            button2.Text = "Contabilizar (append)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(21, 211);
            button3.Name = "button3";
            button3.Size = new Size(201, 82);
            button3.TabIndex = 2;
            button3.Text = "Borrar menores que 10";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(21, 316);
            button4.Name = "button4";
            button4.Size = new Size(201, 82);
            button4.TabIndex = 3;
            button4.Text = "Fusionar dos ficheros";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(21, 427);
            button5.Name = "button5";
            button5.Size = new Size(201, 82);
            button5.TabIndex = 4;
            button5.Text = "Ordenar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(277, 12);
            button6.Name = "button6";
            button6.Size = new Size(201, 82);
            button6.TabIndex = 5;
            button6.Text = "Buscar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(484, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // button7
            // 
            button7.Location = new Point(383, 122);
            button7.Name = "button7";
            button7.Size = new Size(201, 82);
            button7.TabIndex = 7;
            button7.Text = "REemplazar por:";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(277, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(611, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // button8
            // 
            button8.Location = new Point(277, 237);
            button8.Name = "button8";
            button8.Size = new Size(201, 82);
            button8.TabIndex = 10;
            button8.Text = "Split en ficheros de lineas:";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(499, 268);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 586);
            Controls.Add(textBox4);
            Controls.Add(button8);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button7);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
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
        private TextBox textBox1;
        private Button button7;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button8;
        private TextBox textBox4;
    }
}
