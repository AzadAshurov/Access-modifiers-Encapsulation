namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Samsung", "FE21", 100m, 50m, 10);
            product.GetInfo();
            product.Sale(5);
            Phone phone = new Phone(16, "Kingxton", "RRD4", 130m, 100m, 10m);
            phone.Call(10m);
            phone.Pay(150.5m);
            phone.Call(10m);
            NoteBook noteBook = new NoteBook("Linux", "Amd", "Nvidia", "rtx", 100.5m, 15.5m, 5m);






        }
    }
}
