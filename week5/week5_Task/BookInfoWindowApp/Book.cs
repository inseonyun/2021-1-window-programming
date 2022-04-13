using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInfoWindowApp
{
    class Book
    {
        string title;       // 책 제목
        string author;      // 책 저자
        int page;           // 쪽 수
        string ISBN;        // 국제표준도서번호
        string publisher;   // 출판사

        public Book(string title, string author, int page, string ISBN, string publisher)
        {
            this.title = title;
            this.author = author;
            this.page = page;
            this.ISBN = ISBN;
            this.publisher = publisher;
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                this.title = value;
            }
        }

        public override string ToString()
        {
            return "책 제목 : " + title + ", 책 저자 : " + author + ", 쪽 수 : " + page + "\r\n국제표준도서번호 : " + ISBN + ", 출판사 : " + publisher;
        }
    }
}
