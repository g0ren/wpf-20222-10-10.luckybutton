namespace _10._10.luckybutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ура! Вы нажали кнопку счастья, теперь у вас всё будет хорошо!", 
                "Успех", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show(String.Format("{0} {1}",
            //    button1.Height,
            //    button1.Width));
            Point p = new Point(
                random.Next(0, this.Height - 2*button1.Height), 
                random.Next(0, this.Width - 2*button1.Width)
                );
            button1.Location = p;
        }
    }
}