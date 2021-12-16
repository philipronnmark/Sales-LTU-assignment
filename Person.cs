/** 
 * Author1:  Philip Rönnmark 990513-4392 (phrinn-1@student.ltu.se) 
 * Course:   L0002B
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    class Person
    {

        private string name;
        private string idNumber;
        private string district;
        private int sales;
        public int Sales
        {
            get { return sales; }
        }

        public Person(string _name, string _idNumber, string _district, int _sales)
        {
            this.name = _name;
            this.idNumber = _idNumber;
            this.district = _district;
            this.sales = _sales;
        }


        public override string ToString()
        {






            return name.PadRight(15) + idNumber.PadRight(15) + district.PadRight(15) + sales;
        }
    }
}
