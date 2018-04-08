using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10Translation
{
    public class ConfigObject
    {
        public ConfigObject()
        {

        }

        public virtual ConfigObject getConfigObject(string dir, string name)
        {
            return this;
        }

        public virtual void Save(string path) { }
    }
}
