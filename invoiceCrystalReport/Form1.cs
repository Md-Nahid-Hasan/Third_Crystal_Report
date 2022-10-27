using invoiceCrystalReport.generateReport.invoiceReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invoiceCrystalReport
{
    public partial class Form1 : Form
    {
        private object dsP;

        public Form1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable invoice = new DataTable();

            invoice.Columns.Add("consumer_id", typeof(string));
            invoice.Columns.Add("name", typeof(string));
            invoice.Columns.Add("address", typeof(string));
            invoice.Columns.Add("email", typeof(string));
            invoice.Columns.Add("phone_no", typeof(string));
            invoice.Columns.Add("cell_no", typeof(string));

            invoice.Columns.Add("invoice_no", typeof(string));
            invoice.Columns.Add("invoice_date", typeof(string));
            invoice.Columns.Add("wh", typeof(string));
            invoice.Columns.Add("delivery_wh", typeof(string));
            invoice.Columns.Add("shipping_address", typeof(string));
            invoice.Columns.Add("mobile", typeof(string));

            invoice.Columns.Add("product_code", typeof(string));
            invoice.Columns.Add("product_name", typeof(string));
            invoice.Columns.Add("product_model", typeof(string));
            invoice.Columns.Add("unit_price", typeof(string));
            invoice.Columns.Add("invoice_quantity", typeof(string));
            invoice.Columns.Add("amount", typeof(string));

            invoice.Rows.Add("RJD-2817", "Md.Shahed Ali Shah", "The Ibne Sina Pharma Rangpur", "shahedibnesina@gmail.com", " ", "01718625298", "RJD-2022-0968", "19-Oct-2022", "[RJD]-Rangpur Jail Road Dhap", "[RJD]-Rangpur Jail Road Dhap (RJD)", "Md. Ashikuzzaman Shohan", "01718625271","391045","Samsung Washing Machine","WA90T5260BYUTL","42900","1","42900");

         

            invoiceRetail invo = new invoiceRetail();
            invo.Database.Tables["Invoice"].SetDataSource(invoice);
           

            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = invo;
        }
    }
}
