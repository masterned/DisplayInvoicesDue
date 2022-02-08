namespace DisplayInvoicesDue.View
{
    partial class InvoicesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvInvoices = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.getAllInvoicesButton = new System.Windows.Forms.Button();
            this.vendorIDLabel = new System.Windows.Forms.Label();
            this.vendorIDTextBox = new System.Windows.Forms.TextBox();
            this.getVendorInvoicesButton = new System.Windows.Forms.Button();
            this.totalBalanceDueTextBox = new System.Windows.Forms.TextBox();
            this.totalBalanceDueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvInvoices
            // 
            this.lvInvoices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvInvoices.HideSelection = false;
            this.lvInvoices.Location = new System.Drawing.Point(14, 50);
            this.lvInvoices.Name = "lvInvoices";
            this.lvInvoices.Size = new System.Drawing.Size(642, 241);
            this.lvInvoices.TabIndex = 0;
            this.lvInvoices.UseCompatibleStateImageBehavior = false;
            this.lvInvoices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Invoice Number";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Invoice Date";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Invoice Total";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Payment Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Credit Total";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Balance Due";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Due Date";
            this.columnHeader7.Width = 80;
            // 
            // getAllInvoicesButton
            // 
            this.getAllInvoicesButton.AutoSize = true;
            this.getAllInvoicesButton.Location = new System.Drawing.Point(14, 12);
            this.getAllInvoicesButton.Name = "getAllInvoicesButton";
            this.getAllInvoicesButton.Size = new System.Drawing.Size(91, 23);
            this.getAllInvoicesButton.TabIndex = 1;
            this.getAllInvoicesButton.Text = "Get All Invoices";
            this.getAllInvoicesButton.UseVisualStyleBackColor = true;
            this.getAllInvoicesButton.Click += new System.EventHandler(this.getAllInvoicesButton_Click);
            // 
            // vendorIDLabel
            // 
            this.vendorIDLabel.AutoSize = true;
            this.vendorIDLabel.Location = new System.Drawing.Point(372, 15);
            this.vendorIDLabel.Name = "vendorIDLabel";
            this.vendorIDLabel.Size = new System.Drawing.Size(58, 13);
            this.vendorIDLabel.TabIndex = 2;
            this.vendorIDLabel.Text = "Vendor ID:";
            // 
            // vendorIDTextBox
            // 
            this.vendorIDTextBox.Location = new System.Drawing.Point(436, 12);
            this.vendorIDTextBox.Name = "vendorIDTextBox";
            this.vendorIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.vendorIDTextBox.TabIndex = 3;
            // 
            // getVendorInvoicesButton
            // 
            this.getVendorInvoicesButton.AutoSize = true;
            this.getVendorInvoicesButton.Location = new System.Drawing.Point(542, 12);
            this.getVendorInvoicesButton.Name = "getVendorInvoicesButton";
            this.getVendorInvoicesButton.Size = new System.Drawing.Size(114, 23);
            this.getVendorInvoicesButton.TabIndex = 4;
            this.getVendorInvoicesButton.Text = "Get Vendor Invoices";
            this.getVendorInvoicesButton.UseVisualStyleBackColor = true;
            // 
            // totalBalanceDueTextBox
            // 
            this.totalBalanceDueTextBox.Location = new System.Drawing.Point(485, 297);
            this.totalBalanceDueTextBox.Name = "totalBalanceDueTextBox";
            this.totalBalanceDueTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalBalanceDueTextBox.TabIndex = 5;
            // 
            // totalBalanceDueLabel
            // 
            this.totalBalanceDueLabel.AutoSize = true;
            this.totalBalanceDueLabel.Location = new System.Drawing.Point(383, 300);
            this.totalBalanceDueLabel.Name = "totalBalanceDueLabel";
            this.totalBalanceDueLabel.Size = new System.Drawing.Size(96, 13);
            this.totalBalanceDueLabel.TabIndex = 6;
            this.totalBalanceDueLabel.Text = "Total Balance Due";
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 328);
            this.Controls.Add(this.totalBalanceDueLabel);
            this.Controls.Add(this.totalBalanceDueTextBox);
            this.Controls.Add(this.getVendorInvoicesButton);
            this.Controls.Add(this.vendorIDTextBox);
            this.Controls.Add(this.vendorIDLabel);
            this.Controls.Add(this.getAllInvoicesButton);
            this.Controls.Add(this.lvInvoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InvoicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoices by Due Date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvInvoices;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button getAllInvoicesButton;
        private System.Windows.Forms.Label vendorIDLabel;
        private System.Windows.Forms.TextBox vendorIDTextBox;
        private System.Windows.Forms.Button getVendorInvoicesButton;
        private System.Windows.Forms.TextBox totalBalanceDueTextBox;
        private System.Windows.Forms.Label totalBalanceDueLabel;
    }
}

