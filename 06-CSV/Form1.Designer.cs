namespace _06_CSV
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
            btnLeerCSV = new Button();
            lblContenidoCSV = new Label();
            btnLeerCSVHelper = new Button();
            SuspendLayout();
            // 
            // btnLeerCSV
            // 
            btnLeerCSV.Location = new Point(47, 31);
            btnLeerCSV.Name = "btnLeerCSV";
            btnLeerCSV.Size = new Size(180, 76);
            btnLeerCSV.TabIndex = 0;
            btnLeerCSV.Text = "Leer CSV";
            btnLeerCSV.UseVisualStyleBackColor = true;
            btnLeerCSV.Click += btnLeerCSV_Click;
            // 
            // lblContenidoCSV
            // 
            lblContenidoCSV.AutoSize = true;
            lblContenidoCSV.Location = new Point(247, 58);
            lblContenidoCSV.Name = "lblContenidoCSV";
            lblContenidoCSV.Size = new Size(59, 25);
            lblContenidoCSV.TabIndex = 1;
            lblContenidoCSV.Text = "label1";
            // 
            // btnLeerCSVHelper
            // 
            btnLeerCSVHelper.Location = new Point(47, 141);
            btnLeerCSVHelper.Name = "btnLeerCSVHelper";
            btnLeerCSVHelper.Size = new Size(180, 76);
            btnLeerCSVHelper.TabIndex = 2;
            btnLeerCSVHelper.Text = "Leer CSV Helper";
            btnLeerCSVHelper.UseVisualStyleBackColor = true;
            btnLeerCSVHelper.Click += btnLeerCSVHelper_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLeerCSVHelper);
            Controls.Add(lblContenidoCSV);
            Controls.Add(btnLeerCSV);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeerCSV;
        private Label lblContenidoCSV;
        private Button btnLeerCSVHelper;
    }
}
