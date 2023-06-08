using System;
using System.Web.UI;
using StrategyPattern.Service;


namespace StrategyPattern
{
    public partial class CheckOut : Page
    {
        private Context _context;

        protected void Page_Load(object sender, EventArgs e)
        {
            _context = new Context();

            decimal cart = Convert.ToDecimal(Request.QueryString["cart"]);
            totalCost.Text = cart.ToString();
            lblTotal.Text = cart.ToString();
        }

        protected void checkOut(object sender, EventArgs e)
        {

            string selectedValue = shipping.SelectedValue;
            var order = Decimal.Parse(lblTotal.Text);

            switch (selectedValue)
            {
                case "Free":
                    _context.SetStrategyAndOrder(new FreeShippingService(), order);
                    break;
                case "Local":
                    _context.SetStrategyAndOrder(new LocalShippingService(), order);
                    break;
                case "World":
                    _context.SetStrategyAndOrder(new WorldWideShippingService(), order);
                    break;
            }
            
            var response = _context.Execute();
            lblTotal.Text = response.ToString();
            
        }
    }
}