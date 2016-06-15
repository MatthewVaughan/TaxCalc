using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Project 05
// Date: 02/26/2015 2:30:27 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace proj05
{
    public partial class FrmMain : Form
    {
        //Class level reference to Sale Calculator
        private SaleCalculator sc;

        public FrmMain()
        {
            InitializeComponent();
            //Create Sale Calculator object
            sc = new SaleCalculator();
        }

        /// <summary>
        /// About Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display message box that has the name of the programmer and the class
            MessageBox.Show("Matthew Vaughan\nCS 1400 Sec 003");
        }

        /// <summary>
        /// Exit Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close out of program
            this.Close();

        }

        /// <summary>
        /// Clear Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            //Set the text boxes back to null
            txtNumItems.Text = ($"");
            txtUnitPrice.Text = ($"");
        }

        /// <summary>
        /// Button calculate handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalculate_Click(object sender, EventArgs e)
        {

            //Store some values in variables
            double unitPrice = double.Parse(txtUnitPrice.Text);
            double numItems = double.Parse(txtNumItems.Text);

            //Set some values in the class sales calc
            sc.SetNetPrice(unitPrice, numItems);
            sc.SetStateTax();
            sc.SetLocalTax();
            sc.SetTotalAmount();

            //Get values from the class and store them in variables
            double netPrice = sc.GetNetPrice();
            double stateTax = sc.GetStateTax();
            double localTax = sc.GetLocalTax();
            double totalAmount = sc.GetTotalAmount();

            
            MessageBox.Show($"Sales Ticket...\nQuanity: {numItems}\nUnit Price: {unitPrice:C} each\n----------------------------------\nNet Price: {netPrice:C}\nState Sales Tax: {stateTax:C}\nLocal Sales Tax: {localTax:C}\nPlease Pay: {totalAmount:C}");
        }
    }
}
