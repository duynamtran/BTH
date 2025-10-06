using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DPM225446_TranDuyNam_MyWorld08_Composite
{
    public class Department : CompanyComponent
    {
        private List<CompanyComponent> children = new List<CompanyComponent>();

        public Department(string name) : base(name) { }

        public override void Add(CompanyComponent c)
        {
            children.Add(c);
        }

        public override void Remove(CompanyComponent c)
        {
            children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + " Phòng ban: " + name);

            foreach (CompanyComponent c in children)
            {
                c.Display(depth + 2);
            }
        }
    }
}
