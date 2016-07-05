using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkDesign
{
    public class PageService
    {
        public void Save()
        {
            DataBaseRead dbuser = new DataBaseRead();
            User user = new User();
            user = dbuser.Read();
            CustomPage cs = new CustomPage();
            cs.ta.SetText(user.Name);
            cs.taa.SetText(user.Age);
            cs.Save = new Button();
            cs.Save.Click();
        }
    }
}
