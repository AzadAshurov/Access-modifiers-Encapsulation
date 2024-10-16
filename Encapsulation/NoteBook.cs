namespace Encapsulation
{
    internal class NoteBook : Product

    {

        private string _opSystem;
        private string _processor;
        private bool _hasGraphic;

        public string OpSystem
        {
            get
            {
                return _opSystem;
            }
            set
            {
                _opSystem = value;
            }
        }
        public string Processor
        {
            get
            {
                return _processor;
            }
            set
            {
                _processor = value;
            }
        }

        public bool HasGraphic
        {
            get
            {
                return _hasGraphic;
            }
            set
            {
                _hasGraphic = value;
            }
        }


        public NoteBook(string opSystem, string processor, string brandName, string model, decimal price, decimal cost, decimal count) : base(brandName, model, price, cost, count)
        {

        }
        //overload
        public NoteBook(string opSystem, string processor, string brandName, string model, decimal price, decimal cost, decimal count, bool hasGraphic) : base(brandName, model, price, cost, count)
        {

        }

    }
}
