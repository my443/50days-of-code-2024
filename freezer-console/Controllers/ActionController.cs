using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freezer_console.Controllers
{
    public class ActionController
    {
        public ActionController(string[] args)
        {
            SplitArgs(args);
        }

        private void SplitArgs(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }


    }
}
