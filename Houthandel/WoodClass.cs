using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houthandel
{
    class WoodClass
    {
        private string name;
        private double price;
        private double planWage;
        private double discount;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double PlanWage
        {
            get { return planWage; }
            set { planWage = value; }
        }

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public WoodClass(string woodClassName, double woodClassPrice, double woodClassPlanWage, double woodClassDiscount)
        {
            name = woodClassName;
            price = woodClassPrice;
            planWage = woodClassPlanWage;
            discount = woodClassDiscount;
        }
    }
}
