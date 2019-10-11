using System.Collections.Generic;

namespace HarryPotterLogic
{
    public class BookSet
    {
        public List<string> Books { get; }

        public BookSet()
        {
            Books = new List<string>();
        }

        public decimal Total => GetBookSetTotal();

        private decimal GetBookSetTotal()
        {
            switch (Books.Count)
            {
                case 1:
                    return HarryPotterBooks.SingleBookPrice;
                case 2:
                    return (decimal)HarryPotterBooks.SingleBookPrice * Books.Count * 95 / 100;
                case 3:
                    return (decimal)HarryPotterBooks.SingleBookPrice * Books.Count * 90 / 100;
                case 4:
                    return (decimal)HarryPotterBooks.SingleBookPrice * Books.Count * 85 / 100;
                case 5:
                    return (decimal)HarryPotterBooks.SingleBookPrice * Books.Count * 80 / 100;
                case 6:
                    return (decimal)HarryPotterBooks.SingleBookPrice * Books.Count * 75 / 100;
                case 7:
                    return (decimal)HarryPotterBooks.SingleBookPrice * Books.Count * 70 / 100;
                default:
                    return 0;
            }
        }
    }
}
