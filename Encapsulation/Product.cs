namespace Encapsulation
{
    internal class Product
    {
        private string _brandName;
        private string _model;
        private decimal _price;
        private decimal _cost;
        private decimal _count;
        private string _id;
        private decimal _income;



        public string BrandName
        {
            get
            {
                return _brandName;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Use longer brandname");
                }
                else
                {
                    _brandName = value;
                }
            }
        }
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public decimal Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }

        public decimal Income
        {
            get
            {
                return _income;
            }
            set
            {
                _income = value;
            }
        }

        public decimal Count
        {
            get { return _count; }
            set
            {
                _count = value < 0 ? 0 : value;
            }
        }

        public Product(string brandName, string model, decimal price, decimal cost, decimal count)
        {
            _brandName = brandName;
            _count = count;
            _model = model;
            _price = price;
            _cost = cost;

            if (Count < 0)
            {
                Count = 0;
            }
            _id = BrandName.Substring(0, 2) + Model.Substring(0, 2);
            Console.WriteLine("Product Constructor works(message for developer)");
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name of the brand: {BrandName},Model: {Model},Price: {Price}, Cost: {Cost}, Count: {Count}, Id: {Id}");
        }
        public void Sale(decimal wantedCount)
        {
            if (wantedCount <= Count)
            {
                Count -= wantedCount;
                _income = Income + ((Price - Cost) * wantedCount);
                Console.WriteLine($"Item is sold, total income is: {Income} and items left: {Count}");
            }
            else
            {
                Console.WriteLine("Sorry! This product already sold");
            }
        }





    }
}
