namespace _07_JSON
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
            btnLeerJSONlocal = new Button();
            lblPersona = new Label();
            SuspendLayout();
            // 
            // btnLeerJSONlocal
            // 
            btnLeerJSONlocal.Location = new Point(35, 34);
            btnLeerJSONlocal.Name = "btnLeerJSONlocal";
            btnLeerJSONlocal.Size = new Size(210, 41);
            btnLeerJSONlocal.TabIndex = 0;
            btnLeerJSONlocal.Text = "Deserializar";
            btnLeerJSONlocal.UseVisualStyleBackColor = true;
            btnLeerJSONlocal.Click += btnLeerJSONlocal_Click;
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.Location = new Point(273, 46);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new Size(59, 25);
            lblPersona.TabIndex = 1;
            lblPersona.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPersona);
            Controls.Add(btnLeerJSONlocal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeerJSONlocal;
        private Label lblPersona;
    }
}
