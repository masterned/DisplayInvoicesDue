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
            List<Invoice> invoiceList;
            try
            {
                invoiceList = _invoiceController.GetInvoicesDue();
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
    }
}
