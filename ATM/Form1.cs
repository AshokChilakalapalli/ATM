using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        List<bank> lstcust = new List<bank>();
        public Form1()
        {

            InitializeComponent();

            
            bank objcust1 = new bank();
            objcust1.Custid = 123;
            objcust1.Custname = "Ashok";
            objcust1.Custbalance = 5000;
            bank objcust2 = new bank();
            objcust2.Custid = 124;
            objcust2.Custname = "Siva";
            objcust2.Custbalance = 8000;
            lstcust.Add(objcust1);
            lstcust.Add(objcust2);
        }

        private void btnbalance_Click(object sender, EventArgs e)
        {
            
            int custid = int.Parse(txtcustomerid.Text);
            for (int i = 0; i < lstcust.Count; i++)
            {
                if (custid == lstcust[i].Custid)
                {
                    txtcustomername.Text = lstcust[i].Custname;
                    txtbalance.Text = Convert.ToString(lstcust[i].Custbalance);
                }

            }
        }

        private void btnwithdrop_Click(object sender, EventArgs e)
        {
           
            int custid = int.Parse(txtcustomerid.Text);
            for (int i = 0; i < lstcust.Count; i++)
            {
                if (custid == lstcust[i].Custid)
                {

                    int Drawmoney = int.Parse(txtamount.Text);
                    if (Drawmoney <= lstcust[i].Custbalance)
                    {
                        lstcust[i].Custbalance = lstcust[i].Custbalance - Drawmoney;
                        MessageBox.Show("Transaction successful");

                       MessageBox.Show(Convert.ToString(lstcust[i].Custbalance),"Updated Balance"); 
                    }

                }
            }
        }

        private void btndeposit_Click(object sender, EventArgs e)
        {
            
            int custid = int.Parse(txtcustomerid.Text);
            for (int i = 0; i < lstcust.Count; i++)
            {
                if (custid == lstcust[i].Custid)
                {

                    int money = int.Parse(txtamount.Text);

                    lstcust[i].Custbalance = lstcust[i].Custbalance + money;
                    MessageBox.Show("Transaction successful");
                    MessageBox.Show(Convert.ToString(lstcust[i].Custbalance), "Updated Balance");


                }
            }
        }
    }
}