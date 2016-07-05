using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkDesign
{
    public class TextArea : Element
    {
        public string text; 
        public string Name { get; set; }

        public override void Click()
        {
            throw new NotImplementedException();
        }

        public override void SetText(string text)
        {
            this.text = text;
        }
        public override string ToString()
        {
            return $"TexArea include this text : {text}";
        }
    }
}
