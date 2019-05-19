using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryClasses
{
    public class BridgeEngineer : Engineer {
        public string Password;

        public BridgeEngineer(string password)
        {
            Encryption encryption = new Encryption();

            Password = encryption.HashMeBaby(password);

        }
    }

    class Encryption
    {
        //samir, vdplu
        public string HashMeBaby(string p)
        {
            string newP = "";

            foreach (char c in p)
            {
                newP += (char)(c + 3);
            }

            return newP;
        }
    }

}
