using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Constructors_Hafsa
{
    internal class Book
    {
        //feilds
        private string author;
        private string title;
        private string illustrator;

        public string Title
        {
            get { return title; }
        }
        public string Author
        {
            get { return author; }
        }
        public string Illustrator
        {
            get { return illustrator; }
        }
       

        //a constructor - a method in a class that is called when an oject of the class is created

        //default constructor - provided by c# if no constructors are defined. it initializes the object without setting any feilds
        public Book()
        {
            //initialize feilds or set default values
            title = "Default Title";
            author = "Default Author";
            illustrator = "Default illustrator";
        }

        //custom constructor with parameters to initialize feilds
        public Book(string title, string author, string illustrator)
        {
            //creating this constructor removes the default one so now we ensure that specific data has to be passed to make the instnace of this class
            this.title = title;
            this.author = author;
            this.illustrator = illustrator;
        }

        // Overloaded constructor with different parameters
        public Book(string title)
        {
            // Set the title using the provided parameter
            this.title = title;
            // Assign a default author value
            this.author = "No Author Given";
        }

        // Field initialization in constructors ensures objects have valid states
    }
}
