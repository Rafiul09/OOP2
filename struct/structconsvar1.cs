using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace arcistruct
{
    public struct Bank
    {
        private string id, name;
        //public int noc;
        public string Id { get { return id; } set { id = value; } }
        private double balance;
        public double Balance { get { return balance; } set { balance = value; } }
        public string Name { get { return name; } set { name = value; } }
       //private DateTime date;
        //public DateTime Date { get { return date=System.Convert.ToDateTime(); } set { date = value; } }

       /* public Bank(string a,string b,double n,string d) 
        {
            this.id = a;
            this.name = b;
            this.balance = n;
            this.date = Convert.ToDateTime(d);
        
        }*/


    }
    class Program
    {
       

        static void Main(string[] args)
        {

            Bank b0 = new Bank();/*"21-44631-1","Rafiul",999999999999, "12/5/2013");*/
            b0.Name = "Rafiul";
            b0.Id = "21-44631-1";
            b0.Balance = 999999999999;
            //b0.Date = "12/5/2013";
            Console.WriteLine("Account name: " + b0.Name);
            Console.WriteLine("Account Number: " + b0.Id);
            Console.WriteLine("Account Balance: " + b0.Balance);
           // Console.WriteLine("Account Date: " + b0.Date);



        }
    }
}
