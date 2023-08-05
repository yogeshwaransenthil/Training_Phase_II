using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
     class ElectricReading
    {
        private int consumernumber,pre_reading,cur_reading;
        private string consumername,consumertype;
        public ElectricReading(int consumernumber, string consumername, int cur_reading, int pre_reading, string consumertype)
        {
            this.consumernumber =consumernumber;
            this.consumername=consumername;
            this.cur_reading=cur_reading;
            this.pre_reading=pre_reading;
            this.consumertype=consumertype;

        }
        public int CalculateBill()
        {
        int Bill_amount = 0;
        int consumption = pre_reading-cur_reading;
            if (consumertype.Equals("Domestic"))
            {
                
                if(consumption <= 100)
                {
                    Bill_amount = 0;
                }
                else if(consumption>100 && consumption <=200)
                {
                    Bill_amount = (consumption-100) * 2;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    Bill_amount = (consumption - 100) * 5;
                }
                else if (consumption > 500 && consumption <= 1000)
                {
                    Bill_amount = (consumption - 100) * 10;
                }
            }
            else if (consumertype.Equals("Commercial"))
            {
                if (consumption > 100)
                {
                    Bill_amount = 10;
                }
                else if (consumption > 100 && consumption <= 200)
                {
                    Bill_amount = consumption * 12;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    Bill_amount = consumption * 15;
                }
                else if (consumption > 500)
                {
                    Bill_amount = consumption * 17;
                }
            }
            return Bill_amount;
        }

    }

}
