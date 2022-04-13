using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInfoWindowApp
{
    class EBook : Book, iSale
    {
        int price;               //가격
        bool outOfStock = false; //품절 유무

        public EBook(string title, string author, int page, string ISBN, string publisher, int price) : base(title, author, page, ISBN, publisher)
        {
            this.price = price;
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public bool OutOfStock
        {
            get
            {
                return outOfStock;
            }
            set
            {
                outOfStock = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\r\n책 가격 : " + price + ", 품절유무 : " + outOfStock;
        }

        public void DiscountPrice(int discount)
        {
            price = price - discount;
        }

        public void StockOut()
        {
            outOfStock = true;
        }

        public void StorageInWareHouse()
        {
            outOfStock = false;
        }
    }
}
