using System;
using System.Windows.Forms;
using static System.Array;

namespace DeliveryCharges
{
    public partial class DeliveryCharges : Form
    {
        private string[] zips = { "56201", "56202", "56303", "56404", "56505", "56606", "56707", "56808", "56909", "56101" };
        private double[] deliveryFees = { 4.45, 5.50, 2.75, 7.98, 4.55, 4.75, 4.50, 4.60, 4.59, 3.89 };

        public DeliveryCharges()
        {
            InitializeComponent();
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            var zip = txtZip.Text;

            // search array using IndexOf(). IndexOf() returns -1 value if zip isn't in array
            // Otherwise it will return index position of the zip code.
            var zipIndex = IndexOf(zips, zip);

            if (zipIndex > -1)
            {
                txtDeliveryFees.Text = String.Format("We deliver to that area. The fee is: " + "{0:C}", deliveryFees[zipIndex]);
            }
            else
            {
                txtDeliveryFees.Text = "We do not deliver to that area. Enter a zip code from the list.";
            }

            txtZip.Focus(); // send focus back to text entry window, but don't clear zip.
        }
    }
}
