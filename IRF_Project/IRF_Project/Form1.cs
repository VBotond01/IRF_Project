using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace IRF_Project
{
    public partial class Form1 : Form
    {
       
        private List<Book> _Books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
            LoadBooks();


        }




        
        private void LoadBooks()
        {
       

        _Books.Clear();
            using (StreamReader sr = new StreamReader("bestsellers with categories.csv", Encoding.Default))
            {
               sr.ReadLine(); 

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    if (line.StartsWith("\""))
                    {
                        var last = line.LastIndexOf('\"')+1;
                        var separated = line.Substring(0,last);
                        var separatedString = line.Substring(last).Split(',');

                        Book s = new Book();
                        s.Name = separated;
                        s.Author = separatedString[1];
                        s.UserRating = separatedString[2];
                        s.Reviews = separatedString[3];
                        s.USD_Price = separatedString[4];
                        s.Year = separatedString[5];
                        s.Genre = separatedString[6];

                        _Books.Add(s);

                    }
                    else
                    {
                        var separatedString = line.Split(',');
                        Book s = new Book();
                        s.Name = separatedString[0];
                        s.Author = separatedString[1];
                        s.UserRating = separatedString[2];
                        s.Reviews = separatedString[3];
                        s.USD_Price = separatedString[4];
                        s.Year = separatedString[5];
                        s.Genre = separatedString[6];

                        _Books.Add(s);


                    }

                }
               }

            var bindingSource = new BindingSource
            {
                DataSource = _Books};
            advancedDataGridView1.DataSource = bindingSource;
        }






        private void button1_Click_1(object sender, EventArgs e)
        {

            if (advancedDataGridView1.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < advancedDataGridView1.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = advancedDataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < advancedDataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < advancedDataGridView1.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = advancedDataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;


            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = advancedDataGridView1.DataSource;
            bs.Filter = "Name like '%" + textBox1.Text + "%'";
            advancedDataGridView1.DataSource = bs;

            

        }

        private void advancedDataGridView_SortStringChange(object sender, EventArgs e)
        {
            this.bookBindingSource.Sort = this.advancedDataGridView1.SortString;
            
        }

        private void advancedDataGridView_FilterStringChanged(object sender, EventArgs e)
        {
            this.bookBindingSource.Filter = this.advancedDataGridView1.FilterString;

        }
        int seconds = 0;
        private void tmrSeconds_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblSeconds.Text = "Eltöltött idő (mp):" + seconds;

        }
    }
    
}
