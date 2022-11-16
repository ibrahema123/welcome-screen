namespace HW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inp_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " + tb_name.Text);
            tb_name.Clear();
        }
    }
}