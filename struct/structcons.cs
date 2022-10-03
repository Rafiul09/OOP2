using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace arcistruct
{
    public struct Bank
    {
        public string id, name;
        //public int noc;
        public double balance;
        public DateTime date;

        public Bank(string a,string b,double n,string d) 
        {
            this.id = a;
            this.name = b;
            this.balance = n;
            this.date = Convert.ToDateTime(d);
        
        }


    }
    class Program
    {
       

        static void Main(string[] args)
        {

            Bank b0 = new Bank("21-44631-1","Rafiul",999999999999, "12/5/2013");
            Console.WriteLine("Account name: " + b0.name);
            Console.WriteLine("Account Number: " + b0.id);
            Console.WriteLine("Account Balance: " + b0.balance);
            Console.WriteLine("Account Date: " + b0.date);



        }
    }
}
