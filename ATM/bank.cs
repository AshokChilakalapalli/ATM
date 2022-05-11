using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class bank
    {
        int custid;
        string custname;
        int custbalance;


        
        public int Custid
        {
            get
            {
                return custid;
            }
            set
            {
                custid = value;
            }
        }
        public string Custname
        {
            get
            {
                return custname;
            }
            set
            {
                custname = value;
            }
        }
        public int Custbalance
        {
            get
            {
                return custbalance;
            }
            set
            {
                custbalance = value;
            }
        }
    }
}
