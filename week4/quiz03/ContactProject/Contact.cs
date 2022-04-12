using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactProject
{
    class Contact
    {
        string name;
        int age;
        string company;
        string cellPhone;
        string tel;
        string mail;

        public Contact(string name, int age, string company, string cellPhone, string tel, string mail)
        {
            this.name = name;
            this.age = age;
            this.company = company;
            this.cellPhone = cellPhone;
            this.tel = tel;
            this.mail = mail;
        }
        public override string ToString()
        {
            return "이름 : " + name + ", 나이 : " + age + ", 직장 : " + company + "\r\n휴대폰 : " + cellPhone + ", 전화 : " + tel + ", 메일 : " + mail;
        }
    }
}
