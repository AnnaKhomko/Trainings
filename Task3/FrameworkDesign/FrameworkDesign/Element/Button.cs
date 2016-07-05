using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkDesign
{
    public class Button : Element
    {
        public string name;

        public override void Click()
        {
            
        }

        public override void SetText(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Button name is : {name}";
        }
    }
}
