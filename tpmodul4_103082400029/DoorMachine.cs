using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103082400029
{
    internal class DoorMachine
    {
        private string state = "Terkunci";

        public void Buka()
        {
            if (state == "Terkunci")
            {
                state = "Terbuka";
                Console.WriteLine("Pintu tidak terkunci");
            }
        }

        public void Kunci()
        {
            if (state == "Terbuka")
            {
                state = "Terkunci";
                Console.WriteLine("Pintu terkunci");
            }
        }

    }

}