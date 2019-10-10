using System.Collections.Generic;

namespace HarryPotterLogic
{
    public class HarryPotterService
    {
        public const decimal SingleBookPrice = 8;
        
        public List<string> UniqueBooks { get; }
        public List<string> DuplicateBooks { get; }

        public HarryPotterService()
        {            
            UniqueBooks = new List<string>();
            DuplicateBooks = new List<string>();
        }

        public void AddBookToBasket(string bookName)
        {
            if (UniqueBooks.Contains(bookName))
            {
                DuplicateBooks.Add(bookName);
            }
            else
            {
                UniqueBooks.Add(bookName);
            }
        }

        public decimal BasketTotal => GetBasketTotal();

        private decimal GetBasketTotal()
        {
            return GetUniqueBooksTotal() + (DuplicateBooks.Count * SingleBookPrice);
        }

        private decimal GetUniqueBooksTotal()
        {
            switch (UniqueBooks.Count)
            {
                case 1:
                    return SingleBookPrice;
                case 2:
                    return (decimal) SingleBookPrice * UniqueBooks.Count * 95 / 100;
                case 3:
                    return (decimal) SingleBookPrice * UniqueBooks.Count * 90 / 100;
                case 4:
                    return (decimal) SingleBookPrice * UniqueBooks.Count * 85 / 100;
                case 5:
                    return (decimal) SingleBookPrice * UniqueBooks.Count * 80 / 100;
                case 6:
                    return (decimal) SingleBookPrice * UniqueBooks.Count * 75 / 100;
                case 7:
                    return (decimal) SingleBookPrice * UniqueBooks.Count * 70 / 100;
                default:
                    return 0;
            }
        }
    }
}
