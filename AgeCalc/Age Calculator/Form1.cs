using static System.Net.Mime.MediaTypeNames;

namespace Age_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datePicker_currentDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datePicker_birthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (datePicker_birthDate.Value < datePicker_currentDate.Value)
            {
                int Age = datePicker_currentDate.Value.Year - datePicker_birthDate.Value.Year;
                MessageBox.Show("You are currently " + Age + " years old.");
            }
            else
            {
                MessageBox.Show("You birthday must be prior to the current date!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (datePicker_birthDate.Value < datePicker_currentDate.Value)
            {
                int Age = datePicker_currentDate.Value.Year - datePicker_birthDate.Value.Year;
                int Month = datePicker_currentDate.Value.Month - datePicker_birthDate.Value.Month;
                int Days = datePicker_currentDate.Value.Day - datePicker_birthDate.Value.Day;
                MessageBox.Show("You are currently " + Age + " years " +
                    + Month  + " months "
                    + Days + " days "
                    + " old.");
            }
            else
            {
                MessageBox.Show("You birthday must be prior to the current date!");
            }
        }
    }
}
