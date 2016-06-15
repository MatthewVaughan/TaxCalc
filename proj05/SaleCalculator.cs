using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj05
{
    class SaleCalculator
    {
        private double TotalAmount;
        private double LocalTax;
        private double NetPrice;
        private double StateTax;

        /// <summary>
        /// Set Net Price Method
        /// </summary>
        /// <param name="price"></param>
        /// <param name="numItems"></param>
        public void SetNetPrice(double price, double numItems)
        {
            //Set net price by multiplying the values input
            NetPrice = price * numItems;
        }

        /// <summary>
        /// Set State Tax Method
        /// </summary>
        public void SetStateTax()
        {
            //Declare Constant
            const double STATE_TAX = 0.0745;

            //Multiply net price with the state tax and store it
            StateTax = NetPrice * STATE_TAX;
        }

        /// <summary>
        /// Set Local Tax Method
        /// </summary>
        public void SetLocalTax()
        {
            //Declare Constant
            const double LOCAL_TAX = 0.025;

            //Multiply net price with the local tax and store it
            LocalTax = NetPrice * LOCAL_TAX;
        }

        /// <summary>
        /// Set Total Amount handler
        /// </summary>
        public void SetTotalAmount()
        {
            //Find the total amount by adding it with the taxes
            TotalAmount = NetPrice + LocalTax + StateTax;
        }

        /// <summary>
        /// Get Net Price Method
        /// </summary>
        /// <returns></returns>
        public double GetNetPrice()
        {
            //Return net price
            return NetPrice;
        }

        /// <summary>
        /// Get State Tax Method
        /// </summary>
        /// <returns></returns>
        public double GetStateTax()
        {
            //Return state tax
            return StateTax;
        }

        /// <summary>
        /// Get Local Tax Method
        /// </summary>
        /// <returns></returns>
        public double GetLocalTax()
        {
            //Return local tax
            return LocalTax;
        }

        /// <summary>
        /// Get Total Amount Method
        /// </summary>
        /// <returns></returns>
        public double GetTotalAmount()
        { 
            //Return total amount
            return TotalAmount;
        }
    }
}
