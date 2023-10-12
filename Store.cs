    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace PhoneStore
{
    internal class Store
    {
        Phone[] Phones;
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 3)
                {
                    _name = value;
                }
            }
        }

        public Store(string Name)
        {
            this.Name = Name;
            Phones = new Phone[0];
        }


        public void AddPhones(Phone phone)
        {
            Phone[] newPhones = new Phone[Phones.Length + 1];
            for (int i = 0; i < Phones.Length; i++)
            {
                newPhones[i] = Phones[i];
            }
            newPhones[newPhones.Length - 1] = phone;
            Phones = newPhones;
        }
        public void ShowAllPhone()
        {

            foreach (Phone item in Phones)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void ShowPhoneForPrice(double MinPrice, double MaxPrice)
        {
            bool found = false;
            foreach (Phone item in Phones)
            {
                if (MinPrice <= item.Price && item.Price <= MaxPrice)
                {
                    Console.WriteLine(item.Name);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("There is no such phone.");
            }
        }

        public void RemovePhone(int inputId)
        {
            if (Phones.Length == 0)
            {
                Console.WriteLine("There are no phones to remove.");
                return;
            }
            Phone[] removedPhone = new Phone[Phones.Length - 1];
            int newIndex = 0;
            for (int i = 0; i < Phones.Length; i++)
            {
                if (inputId == Phones[i].Id)
                {
                    continue;
                }
                removedPhone[newIndex] = Phones[i];
                newIndex++;
            }
            Phones = removedPhone;
            foreach (Phone phone in Phones)
            {
                Console.WriteLine(phone.Name);
            }
        }
    }
}


