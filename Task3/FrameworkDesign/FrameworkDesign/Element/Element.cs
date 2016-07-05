using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkDesign
{
    public abstract class Element : ILoggable
    {
        public abstract void Click();

        public void Log()
        {
            throw new NotImplementedException();
        }

        public abstract void SetText( string text);
    }
}
