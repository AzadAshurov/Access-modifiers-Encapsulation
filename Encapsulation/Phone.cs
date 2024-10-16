namespace Encapsulation
{
    internal class Phone : Product
    {
        private int _RAM;
        private string _color;
        private decimal _balance;

        public int Ram
        {
            get
            {
                return _RAM;
            }
            set
            {
                _RAM = value;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }
        public Phone(int ram, string brandName, string model, decimal price, decimal cost, decimal count, string color = "Black") : base(brandName, model, price, cost, count)
        {
            _balance = 0;
            _color = color;
            _RAM = ram;
        }
        public void Call(decimal seconds)
        {
            if (seconds * 0.1m <= _balance)
            {
                _balance -= seconds * 0.1m;
                Console.WriteLine("Call was successefull");
            }
            else
            {
                Console.WriteLine("No enought balans");
            }

        }
        public void Pay(decimal money)
        {
            _balance += money;
            Console.WriteLine($"Your balance is {Balance} now");
        }
    }
}
