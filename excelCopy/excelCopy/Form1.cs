namespace excelCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            String? filePath = null;
             openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                textBox1.Text = filePath.Split('\\')[filePath.Split('\\').Length - 1];
            }
        }
    }
}