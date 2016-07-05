using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkDesign
{
    public class DataBaseRead : IReadConfig
    {
        public User Read()
        {
            User user = new User();
            return user;

        }
    }
}
