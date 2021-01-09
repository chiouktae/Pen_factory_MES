using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Factory
{
    class product
    {
        public string ID;
        public string NAME;
        public string VOL;
        public string PRICE;

        public product(string id, string name, string vol, string price)
        {
            this.ID = id;
            this.NAME = name;
            this.VOL = vol;
            this.PRICE = price;
        }
    }
}