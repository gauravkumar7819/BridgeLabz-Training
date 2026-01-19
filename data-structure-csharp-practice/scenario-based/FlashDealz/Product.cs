namespace FlashDealz
{
    class Product
    {
        private string name;
        private int discount;

        public Product(string name, int discount)
        {
            this.name = name;
            this.discount = discount;
        }

        public string GetName()
        {
            return name;
        }

        public int GetDiscount()
        {
            return discount;
        }
    }
}
