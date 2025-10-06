using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225446_TranDuyNam_MyWorld09_Decorator
{
    public class Sugar : BeverageDecorator
    {
        public Sugar(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", thêm đường";
        }

        public override double GetCost()
        {
            return beverage.GetCost() + 2000; // thêm 2k
        }
    }
}
