namespace _02_Ver_rtf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.LoadFile("Contrato_Uso_Software.rtf");
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
    
        }
    }
}
