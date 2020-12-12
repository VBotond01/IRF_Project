using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project

{
   
 public class Book
    {

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string userrating;

        public string UserRating
        {
            get { return userrating; }
            set { userrating = value; }
        }

        private string reviews;

        public string Reviews
        {
            get { return reviews; }
            set { reviews = value; }
        }


        //  public string Author { get; set; }
        //  public string User_Rating { get; set; }
        //  public string Reviews { get; set; }

        private string USDprice;

        public string USD_Price
        {
            get { return USDprice; }
            set { USDprice = value; }
        }

        //public string USD_Price { get; set; }

        private string year;

        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        //   public string Year { get; set; }

        private string genre;

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        //  public string Genre { get; set; }


        public Book(string author = "default", string name = "default", string userrating = "0", string reviews = "0", string USDprice = "0", string year = "0", string genre = "default")
        {
            Author = author;
            Name = name;
            UserRating = userrating;
            Reviews = reviews;
            USD_Price = USDprice;
            Year = year;
            Genre = genre;


        }
    }  

   

   
}
