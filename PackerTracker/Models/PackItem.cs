namespace PackerTracker
{
    class PackItem
    {
        public string name { get; set; }
        public string brand { get; set; }
        public double price
        {
            get;
            set
            {
                price = noNegative(value);
            }
        }
        public double weight
        {
            get;
            set
            {
                weight = noNegative(value);
            }
        }
        public bool isPurchase
        {
            get;
            set
            {
                if (value)
                {
                    isPurchase = true;
                }
                else
                {
                    isPurchase = false;
                    isPacked = false;
                }
            }
        }
        public bool isPacked
        {
            get;
            set
            {
                if (value)
                {
                    isPacked = isPurchased;
                }
                else
                {
                    isPacked = false;
                }

            }
        }
        private double noNegative(double value)
        {
            if (value <= 0)
            {
                return 0;
            }
            return value;
        }
    }
}