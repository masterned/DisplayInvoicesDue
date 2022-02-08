using PayablesData;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DisplayInvoicesDue.DAL
{
    public class InvoiceDAL
    {
        public List<Invoice> GetInvoicesDue()
        {
            List<Invoice> invoiceList = new List<Invoice>();

            string selectStatement =
                "SELECT InvoiceNumber, InvoiceDate, InvoiceTotal, " +
                "PaymentTotal, CreditTotal, DueDate " +
                "FROM Invoices " +
                "WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0 " +
                "ORDER BY DueDate";

            using (SqlConnection connection = PayablesDB.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Invoice invoice = new Invoice();
                            invoice.InvoiceNumber = reader["InvoiceNumber"].ToString();
                            invoice.InvoiceDate = (DateTime)reader["InvoiceDate"];
                            invoice.InvoiceTotal = (decimal)reader["InvoiceTotal"];
                            invoice.PaymentTotal = (decimal)reader["PaymentTotal"];
                            invoice.CreditTotal = (decimal)reader["CreditTotal"];
                            invoice.DueDate = (DateTime)reader["DueDate"];
                            invoiceList.Add(invoice);
                        }
                    }
                }
            }
            
            return invoiceList;
        }

        public List<Invoice> GetVendorInvoicesDue(int vendorID)
        {
            List<Invoice> invoiceList = new List<Invoice>();

            string selectStatement =
                "SELECT InvoiceNumber, InvoiceDate, InvoiceTotal, " +
                "PaymentTotal, CreditTotal, DueDate " +
                "FROM Invoices " +
                "WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0 " +
                "AND VendorID = " + vendorID + " " +
                "ORDER BY DueDate";

            using (SqlConnection connection = PayablesDB.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Invoice invoice = new Invoice();
                            invoice.InvoiceNumber = reader["InvoiceNumber"].ToString();
                            invoice.InvoiceDate = (DateTime)reader["InvoiceDate"];
                            invoice.InvoiceTotal = (decimal)reader["InvoiceTotal"];
                            invoice.PaymentTotal = (decimal)reader["PaymentTotal"];
                            invoice.CreditTotal = (decimal)reader["CreditTotal"];
                            invoice.DueDate = (DateTime)reader["DueDate"];
                            invoiceList.Add(invoice);
                        }
                    }
                }
            }

            return invoiceList;
        }

        public decimal GetTotalBalanceDue()
        {
            decimal totalBalanceDue = 0;

            using (SqlConnection connection = PayablesDB.GetConnection())
            {
                SqlCommand selectCommand = new SqlCommand();

                selectCommand.Connection = connection;
                selectCommand.CommandText = "SELECT SUM(InvoiceTotal - PaymentTotal - CreditTotal) " +
                    "AS TotalBalanceDue " +
                    "FROM Invoices " +
                    "WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0" +
                    ";";

                connection.Open();
                totalBalanceDue = (decimal)selectCommand.ExecuteScalar();
            }

            return totalBalanceDue;
        }

        public decimal GetVendorBalanceDue(int vendorID)
        {
            decimal totalBalanceDue = 0;

            using (SqlConnection connection = PayablesDB.GetConnection())
            {
                SqlCommand selectCommand = new SqlCommand();

                selectCommand.Connection = connection;
                selectCommand.CommandText = "SELECT SUM(InvoiceTotal - PaymentTotal - CreditTotal) " +
                    "AS TotalBalanceDue " +
                    "FROM Invoices " +
                    "WHERE VendorID = " + vendorID + " AND (InvoiceTotal - PaymentTotal - CreditTotal > 0)" +
                    ";";

                connection.Open();
                totalBalanceDue = (decimal)selectCommand.ExecuteScalar();
            }

            return totalBalanceDue;
        }
    }
}
