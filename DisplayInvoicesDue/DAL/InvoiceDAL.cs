﻿using PayablesData;
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
    }
}