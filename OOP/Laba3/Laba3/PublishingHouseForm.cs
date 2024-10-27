using System;
using System.ComponentModel;
using System.Windows.Forms;
using Laba2.BookFile;

namespace Laba2
{
    public partial class PublishingHouseForm : Form
    {
        public PublishingHouseForm()
        {
            InitializeComponent();
            CurrentPublishingHouse = null;
        }

        public PublishingHouse CurrentPublishingHouse { get; private set; }

        private void PublishingHouseForm_Closed(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            (sender as PublishingHouseForm).Hide();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxCity.Text == "" || textBoxCountry.Text == "" ||
                radioButtonOwnershipType_Private.Checked == false && radioButtonOwnershipType_State.Checked == false) return;

            try
            {
                if (textBoxName.Text.Length > 30 || textBoxCity.Text.Length > 30 || textBoxCountry.Text.Length > 30)
                    throw new Exception("Превышен размер входных данных");

                string name = textBoxName.Text;
                string city = textBoxCity.Text;
                string country = textBoxCountry.Text;
                var dateOfFoundation = dateTimePickerDateOfFoundation.Value;
                var ownerShipType = radioButtonOwnershipType_Private.Checked ? OwnershipType.Private : OwnershipType.State;

                CurrentPublishingHouse = new PublishingHouse(name, country, city, dateOfFoundation, ownerShipType);

                Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        public void Clear()
        {
            CurrentPublishingHouse = null;
        }

        private void dateTimePickerDateOfFoundation_ValueChanged(object sender, EventArgs e)
        {

            if (dateTimePickerDateOfFoundation.Value <= DateTime.Now)
            {

            }
            else
            {
                // MessageBox.Show("Вы выбрали неверную дату");
                dateTimePickerDateOfFoundation.Value = DateTime.Now;
            }
        }
    }
}