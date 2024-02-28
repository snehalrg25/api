using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace Movieapi
{
    public class receipt
    {
        private int Receiptnumber;
        private string dateofpurchase;
        private int custnum;
        private string custfirstname;
        private string custlastname;
        private string custAddress;
        private string custphone;
        private int itemnumber;
        private string itemdesc;
        private decimal unitprice;
        private int qtypurchased;

        public receipt(int num, string dop, int cn, string cfn,string cln, string ca, string cp, int Itemn,string idesc,decimal uprice , int qty ) { 
        
        
            Receiptnumber = num;        
            dateofpurchase = dop;
            custnum = cn;
            custfirstname = cfn;
            custlastname = cln;
            custAddress = ca;
            custphone = cp;
            itemnumber = Itemn;
            itemdesc = idesc;              
            unitprice = uprice;
            qtypurchased = qty;

        
        }

        public int receiptnumber
        {
            get { return Receiptnumber; } set { if(value > 0) Receiptnumber = value; }
        }

        public string  PurchaseDate
        {
            get { return dateofpurchase; }
            set { dateofpurchase = value; }
        }

        public int custnu
        {
            get { return custnum; }
            set { if (value > 0) custnum = value; }
        }

        public string custfirst
        {
            get { return custfirstname; }
            set { custfirstname = value; }
        }


        public string custlast
        {
            get { return custlastname; }
            set { custlastname = value; }
        }

        public string custadd
        {
            get { return custAddress; }
            set { custAddress = value; }
        }

        public string custmobile
        {
            get { return custphone; }
            set { custphone = value; }
        }

        public int Itemno
        {
            get { return itemnumber; }
            set { if (value > 0  && value > 9999) itemnumber = value; }
        }

        public string Itmdesc
        {
            get { return itemdesc; }
            set { itemdesc = value; }
        }

        public decimal unit
        {
            get { return unitprice; }    
            set { if( value > 0 && value >9999)unitprice = value; }
        }

        public int Qtyp
        {
            get { return qtypurchased; }
            set { if (value > 0 && value > 9999) qtypurchased = value; }
        }

        public decimal totalcost()
        {
            return unitprice * qtypurchased;
        }

        public override string ToString()
        {
            return "customer" + custfirstname + " "+ custlastname +
                "\nPhonenum" + custphone +
                "\nTotal Purchase" + Convert.ToString(totalcost());

        }

    }
}
