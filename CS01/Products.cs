using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS01
{
    class Products
    {

        string id;
        string name;
        string size;
        string image;

        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }


        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }
}
