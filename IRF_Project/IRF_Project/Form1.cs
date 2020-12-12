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
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
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
            dataGridView1.DataSource = bindingSource;
        }






        private void button1_Click_1(object sender, EventArgs e)
        {




         

        }



    }
    
}
