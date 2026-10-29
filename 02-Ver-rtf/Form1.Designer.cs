namespace _02_Ver_rtf
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            panel1 = new Panel();
            btnCargarPDF = new Button();
            btnCargarMD = new Button();
            markdownViewer1 = new CDS.Markdown.MarkdownViewer();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(189, 14);
            richTextBox1.Margin = new Padding(4, 5, 4, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(363, 307);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.VScroll += richTextBox1_VScroll;
            // 
            // button1
            // 
            button1.Location = new Point(13, 118);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(157, 58);
            button1.TabIndex = 1;
            button1.Text = "Cargar rtf";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(201, 340);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 398);
            panel1.TabIndex = 2;
            // 
            // btnCargarPDF
            // 
            btnCargarPDF.Location = new Point(13, 418);
            btnCargarPDF.Margin = new Padding(4, 5, 4, 5);
            btnCargarPDF.Name = "btnCargarPDF";
            btnCargarPDF.Size = new Size(157, 58);
            btnCargarPDF.TabIndex = 3;
            btnCargarPDF.Text = "Cargar rtf";
            btnCargarPDF.UseVisualStyleBackColor = true;
            btnCargarPDF.Click += btnCargarPDF_Click;
            // 
            // btnCargarMD
            // 
            btnCargarMD.Location = new Point(607, 86);
            btnCargarMD.Margin = new Padding(4, 5, 4, 5);
            btnCargarMD.Name = "btnCargarMD";
            btnCargarMD.Size = new Size(157, 58);
            btnCargarMD.TabIndex = 4;
            btnCargarMD.Text = "Cargar.md";
            btnCargarMD.UseVisualStyleBackColor = true;
            btnCargarMD.Click += btnCargarMD_Click;
            // 
            // markdownViewer1
            // 
            markdownViewer1.Location = new Point(817, 57);
            markdownViewer1.Name = "markdownViewer1";
            markdownViewer1.Size = new Size(657, 558);
            markdownViewer1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1559, 750);
            Controls.Add(markdownViewer1);
            Controls.Add(btnCargarMD);
            Controls.Add(btnCargarPDF);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Panel panel1;
        private Button btnCargarPDF;
        private Button btnCargarMD;
        private CDS.Markdown.MarkdownViewer markdownViewer1;
    }
}
