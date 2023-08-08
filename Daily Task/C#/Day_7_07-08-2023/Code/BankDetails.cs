using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{

     internal class BankDetails
    {
        private int custid;
        private string name, status;
        private long accno;
        private double balance;

        public BankDetails(int custid, string name, string status, long accno, double balance)
        {
            this.custid = custid;
            this.name = name;
            this.status = status;
            this.accno = accno;
            this.balance = balance;
        }

        public int Custid { get => custid; set => custid = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public long Accno { get => accno; set => accno = value; }
        public double Balance { get => balance; set => balance = value; }

        public void FetchAccountDetails(int custid)
        {
            if (Custid == custid)
            {
                Console.WriteLine(Accno + Name + Status + Balance);
            }
        }
        public void FetchAccountDetails(long Accno)
        {
            if (Accno == accno)
            {
                Console.WriteLine(Custid + Name + Status + Balance);
            }
        }
        public void FetchAccountDetails(string name)
        {
            if (Name.Equals(name))
                {
                Console.WriteLine(Accno + Custid+ Status + Balance);
            }
                }
    }
}

