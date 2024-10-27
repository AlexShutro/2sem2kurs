using System;
using System.Windows.Forms;


namespace lab_1
{
   
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private string Calc(double mass, double height, uint years, double targetMass, uint timeLine)
            {
                if (mass == 0 || height == 0 || years == 0)
                    return "---";

                double current = (655 + height * 1.8f + mass * 9.6f - years * 4.7f);
                double target = (655 + height * 1.8f + targetMass * 9.6f - years * 4.7f);

                if (woman.Checked == true)
                {
                    current *= 0.9f;
                }

                switch (goalComboBox.Text)
                {
                    case "Поддержание веса":
                        return ((int)current).ToString();
                    case "Снижение веса ":
                        if (timeLine == 0)
                            return "---";
                        return ((int)(current - (current - target) / timeLine)).ToString();
                    case "Увеличение веса":
                        if (timeLine == 0)
                            return "---";
                        return ((int)(current + (target - current) / timeLine)).ToString();
                }

                return "---";
            }
            private void sendButton_Click(object sender, EventArgs e)
            {

                try
                {
                    double weight = Convert.ToDouble(weightTextBox.Text);
                    double height = Convert.ToDouble(heightTextBox.Text);
                    uint age = Convert.ToUInt32(yearsOldTextBox.Text);
                    string sex = "";
                    string activity = goalComboBox.Text;
                    double weightWant = Convert.ToDouble(resultWeight.Text);
                    uint day = Convert.ToUInt32(timeTextBox.Text);

                    string result = Calc(weight, height, age, weightWant, day);

                    MessageBox.Show(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }
            }
        }
}






