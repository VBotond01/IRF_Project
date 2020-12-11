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
                sr.ReadLine(); // Remove headers
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');

                    Book s = new Book();
                    s.Name = line[0];
                    s.Author = line[1];
                    s.User_Rating = line[2];
                    s.Price = line[3];
                    s.Year = line[4];
                    s.Genre = line[5];

                    _Books.Add(s);
                    

                }
               }

            var bindingSource = new BindingSource
            {
                DataSource = _Books};
            dataGridView1.DataSource = bindingSource;
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }
        
    }
    
}
