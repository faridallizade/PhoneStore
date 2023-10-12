using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore
{
    internal class Phone
    {
        private int _id;
        private string _name;
        private string _brandName;
        private double _price;
        private int _count;

        #region Properties
        public int Id {
            get
            {
                return _id;
            }
            set
            {
                if(value > 0)
                {
                    _id = value;
                    
                }
            }
        }

        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if(value.Length >= 2) {
                _name = value;
                }
            } 
        }

        public string BrandName
        {
            get
            {
                return _brandName;
            }
            set
            {
                if (value.Length >= 3)
                {
                    _brandName = value;
                }
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }

        public int Count {
            get
            {
                return _count;
            }
            set
            {
                if(value > 0)
                {
                    _count = value;
                }
            } 
        }
        #endregion

        public Phone(string BrandName, string Name, int Id, double Price, int Count)
        {
            this.BrandName = BrandName;
            this.Name = Name;
            this.Id = Id;
            this.Price = Price;
            this.Count = Count;
        }

        public void ShowInfo()
        {
            Console.WriteLine($" |Brand Name : {BrandName}\n |Name : {Name}\n |Id : #{Id}\n |Price : {Price}$\n |Count : {Count}\n --------------------");
        }
    }
}
