namespace PhoneStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone Phone1 = new Phone("Apple", "Iphone 12", 1684, 799.99, 25);
            //Phone1.ShowInfo();
            Phone Phone2 = new Phone("Apple", "Iphone 13 Pro Max", 4865, 1099.99, 35);
            //Phone2.ShowInfo();
            Phone Phone3 = new Phone("Apple", "Iphone 15 Pro", 9854, 1299.99, 4);
            //Phone3.ShowInfo();
            Phone Phone4 = new Phone("Apple", "Iphone X", 0265, 299.99, 8);
            //Phone4.ShowInfo();
            Store MyStore = new Store("AlmaStore");
            MyStore.AddPhones(Phone1);
            MyStore.AddPhones(Phone2);
            MyStore.AddPhones(Phone3);
            MyStore.AddPhones(Phone4);
            MyStore.ShowPhoneForPrice(800, 1300);
            //MyStore.RemovePhone(4865);
            //MyStore.ShowAllPhone();
        }
    }
}