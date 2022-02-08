using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DisplayInvoicesDue.Controller;
using PayablesData;

namespace DisplayInvoicesDue.View
{
    public partial class InvoicesForm : Form
    {
        private InvoiceController _invoiceController;

        public InvoicesForm()
        {
            InitializeComponent();
            _invoiceController = new InvoiceController();
        }

        private void getAllInvoicesButton_Click(object sender, EventArgs e)
        {
            lvInvoices.Items.Clear();

            List<Invoice> invoiceList;
            try
            {
                invoiceList = _invoiceController.GetInvoicesDue();

                totalBalanceDueTextBox.Text = _invoiceController.GetTotalBalanceDue().ToString("c");

                if (invoiceList.Count > 0)
                {
                    Invoice invoice;
                    for (int i = 0; i < invoiceList.Count; i++)
                    {
                        invoice = invoiceList[i];
                        lvInvoices.Items.Add(invoice.InvoiceNumber);
                        lvInvoices.Items[i].SubItems.Add(invoice.InvoiceDate.ToShortDateString());
                        lvInvoices.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.PaymentTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.CreditTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.BalanceDue().ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.DueDate.ToShortDateString());
                    }
                }
                else
                {
                    MessageBox.Show("All invoices are paid in full.",
                        "No Balance Due");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        private void getVendorInvoicesButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vendorIDTextBox.Text))
            {
                MessageBox.Show("VendorID cannot be null or empty", "Heads Up!");
                return;
            }
            
            lvInvoices.Items.Clear();

            try
            {
                int vendorID = int.Parse(vendorIDTextBox.Text);

                totalBalanceDueTextBox.Text = _invoiceController.GetVendorBalanceDue(vendorID).ToString("c");
                
                List<Invoice> invoiceList = _invoiceController.GetVendorInvoicesDue(vendorID);

                if (invoiceList.Count > 0)
                {
                    Invoice invoice;
                    for (int i = 0; i < invoiceList.Count; i++)
                    {
                        invoice = invoiceList[i];
                        lvInvoices.Items.Add(invoice.InvoiceNumber);
                        lvInvoices.Items[i].SubItems.Add(invoice.InvoiceDate.ToShortDateString());
                        lvInvoices.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.PaymentTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.CreditTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.BalanceDue().ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.DueDate.ToShortDateString());
                    }
                }
                else
                {
                    MessageBox.Show("All invoices are paid in full.",
                        "No Balance Due");
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.GetType().ToString());
            }
        }
    }
}
