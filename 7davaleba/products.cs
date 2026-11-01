using System;
using System.Collections.Generic;
using System.Text;

namespace _7davaleba
{
    internal class Products
    {
        public int Id { get; set; }
    public string Name {  get; set; }


        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set { 
                if(value  < 0)
                {
                    throw new ArgumentException("this price is incorrect"); 
                }
                _price = value;
            }
        }

       

        public bool Nuts {  get; set; }
    public string Image {  get; set; }
    public bool Vegeterian {  get; set; }
        private int _spiciness;

        public int Spiciness
        {
            get { return _spiciness; }
            set {
                if(value <0 || value >5)
                {
                    throw new ArgumentException("the spiciness is incorrect");
                }
                _spiciness = value;
            }
        }

        public string Category { get; set; }


        public Products(int id, string name, decimal price, bool nuts, string image, bool vegeterian, int spiciness, string category )
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Nuts = nuts;
            this.Image = image;
            this.Vegeterian = vegeterian;
            this.Spiciness = spiciness;
            this.Category = category;
        }
        

        public bool IsSafeForNutAllergy()
        {
            if (Nuts)
            {
                return false;
            }
            return true;
        }


        public string GetSpicinessDescription()
        {
            if(Spiciness == 0)
            {
                return ("not spicy");
            }
            else if (Spiciness == 1 || Spiciness == 2)
            {
                return ("a bit spicy");
            }
            else if (Spiciness == 3 || Spiciness == 4)
            {
                return ("spicy");
            }
            else 
            {
                return("very spicy");
            }
        }
    }
}
