using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS
{
    class CurrentUser
    {
        private static string code = "";

        public static string Code {
            get { return code; }
            set { code = value; }
        }
    }
}
