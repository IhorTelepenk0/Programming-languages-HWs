using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void readButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = string.Join("", ReadFile());
        }

        private void totalByNamesButton_Click(object sender, EventArgs e)
        {
            //Old school way
            // var result = new Dictionary<string, decimal>();
            //
            // foreach (var invoice in invoices)
            // {
            //     if (!result.ContainsKey(invoice.Name))
            //     {
            //         result[invoice.Name] = invoice.Amount;
            //     }
            //     else
            //     {
            //         result[invoice.Name] += invoice.Amount;
            //     }
            // }
            //
            // resultTextBox.Text = "";
            // foreach (var entry in result.OrderBy(x=>x.Key))
            // {
            //     resultTextBox.Text += $"{entry.Key}: {entry.Value}\r\n";
            // }

            //Modern approach:
            var result = ListOfInvoices()
                .GroupBy(x => x.Name)
                .Select(x => $"{x.Key}: {x.Sum(y => y.Amount)}");

            resultTextBox.Text = string.Join("\r\n", result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = ListOfInvoices()

                .OrderByDescending(x => x.DateTime)
                .GroupBy(z => z.Name)
                .Select(z => $"{z.Key}: {z.Sum(y => y.Amount)}");


            resultTextBox.Text = $"FROM NEWEST TO OLDEST:\r\n{string.Join("\r\n", result)}";
        }
        private IEnumerable<string> ReadFile()
        {
            var path = pathTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist. Cannot proceed");
                return null;
            }

            var lines = File.ReadAllLines(path).Skip(1);
            return lines;
        }

        private List<Invoice> ListOfInvoices()
        {
            var lines = ReadFile();

            var invoices = new List<Invoice>();
            foreach (var line in lines)
            {
                var split = line.Split('\t');
                var name = split[0];
                var date = DateTime.ParseExact(split[1], "yyyy-MM-dd", null);
                var amount = Convert.ToDecimal(split[2].Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)); // 120.21

                var invoice = new Invoice(name, date, amount);
                invoices.Add(invoice);
            }
            return invoices;
        }
    }
    public class Invoice
    {
        public string Name { get; }
        public DateTime DateTime { get; }
        public decimal Amount { get; }

        public Invoice(string name, DateTime dateTime, decimal amount)
        {
            Name = name;
            DateTime = dateTime;
            Amount = amount;
        }
    }
}
