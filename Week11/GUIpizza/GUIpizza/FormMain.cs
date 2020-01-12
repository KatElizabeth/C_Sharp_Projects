using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUIpizza
{
    public partial class FormMain : Form
    {
        private String order;
        private double price;
        private double orderPrice;
        private double finalPrice;
        public FormMain()
        {
            InitializeComponent();
        }


        private void BtnOrder_Click_1(object sender, EventArgs e)
        {
            order = "Crust: ";


            // check crust option
            order += radThin.Checked ? "Thin Crust. " : "";
            order += radDeepDish.Checked ? "Deep Dish. " : "";
            order += radTraditional.Checked ? "Traditional. " : "";
            order += radStuffedCrust.Checked ? "Stuffed Crust. " : "";

            // check toppings

            order += "Toppings: ";

            order += chkBacon.Checked ? "Bacon, " : "";
            order += chkBlackOlives.Checked ? "Black Olives, " : "";
            order += chkCheese.Checked ? "Extra Cheese, " : "";
            order += chkGreenPeppers.Checked ? "Green Peppers, " : "";
            order += chkOnions.Checked ? "Onions, " : "";
            order += chkPepperoni.Checked ? "Pepperoni, " : "";
            order += chkPineapple.Checked ? "Pineapple, " : "";
            order += chkProsciutto.Checked ? "Prosciutto, " : "";
            order += chkSalami.Checked ? "Salami, " : "";
            order += chkSausage.Checked ? "Sausage, " : "";

            // delivery
            order += radDelivery.Checked ? "For Delivery." : "";
            order += radTakeOut.Checked ? "For Takeout." : "";
            order += radDineIn.Checked ? "For Dine-In." : "";

            // get number
            order += "Phone: " + mtbPhone.Text;

            // display order
            txtOrder.Text = order;

            finalPrice = Math.Round(FinalPrice(), 2);

            lblFinalPrice.Text = "Final Price: $" + finalPrice.ToString();

        }
      

        private void RadDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (radDelivery.Checked)
            {
                DialogResult result =
                    MessageBox.Show(
                        "We delivery to addresses within city limits.\n" +
                        "Are you in city limits?", "Delivery Area",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    radTakeOut.Checked = true;
                }
            }
        }

        private void MnuFileExit_Click(object sender, EventArgs e)
        {

            DialogResult exit =
                MessageBox.Show(
                    "Are you sure you want to exit?", "Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }


            
        }

        private void MnuCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"calc.exe");
        }

        private void MnuHelp_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
        }

        

        private void BtnUpdatePrice_Click(object sender, EventArgs e)
        {
            
            lblBasePrice.Text = "Current Price: $" + UpdatePrice();
        }

        // this method will calculate the current price based on user's selections
        private double UpdatePrice()
        {

            price = 10.75;

            // check crust option, add prices if needed
            price += radDeepDish.Checked ? 2 : 0;
            price += radStuffedCrust.Checked ? 2 : 0;

            // check toppings and add prices
            price += chkBacon.Checked ? 1 : 0;
            price += chkBlackOlives.Checked ? 1 : 0;
            price += chkCheese.Checked ? 1 : 0;
            price += chkGreenPeppers.Checked ? 1 : 0;
            price += chkOnions.Checked ? 1 : 0;
            price += chkPepperoni.Checked ? 1 : 0;
            price += chkPineapple.Checked ? 1 : 0;
            price += chkProsciutto.Checked ? 1 : 0;
            price += chkSalami.Checked ? 1 : 0;
            price += chkSausage.Checked ? 1 : 0;

            // check beverage choices
            price += chkCoke.Checked ? 2.5 : 0;
            price += chkDietCoke.Checked ? 2.5 : 0;
            price += chkSprite.Checked ? 2.5 : 0;
            price += chkRootBeer.Checked ? 2.5 : 0;

            

            return Math.Round(price, 2);

        }

        private double FinalPrice()
        {
            orderPrice = Math.Round(UpdatePrice(), 2);

            lblSubtotal.Text = "Subtotal: $" + orderPrice.ToString();

            var taxTotal = Math.Round(orderPrice * .0688, 2);

            double tipTotal = 0;

            lblTaxes.Text = "Tax Total:  $" + taxTotal.ToString();

            tipTotal += radBtnTip10.Checked ? .10*orderPrice : 0;
            tipTotal += radBtnTip15.Checked ? .15*orderPrice : 0;
            tipTotal += radBtnTip20.Checked ? .20*orderPrice : 0;

            tipTotal = Math.Round(tipTotal, 2);

            lblTip.Text = "Tip Total:  $" + tipTotal.ToString();



            orderPrice += taxTotal + tipTotal;
            

            return Math.Round(orderPrice, 2);
        }

        private void TmrBlink_Tick(object sender, EventArgs e)
        {
            pbxOpenSign.Visible = pbxOpenSign.Visible ? false : true;

        }

       
    }
}
