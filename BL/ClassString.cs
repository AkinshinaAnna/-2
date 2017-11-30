using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public  class ClassString
    {
        public  string Str { get; set; }

        public ClassString(string str)
        {
            this.Str = str;
        }

        public int CountWordsWithA()
        {
            int Stringk = 0;
            int Wordk = 0;
            for (int i = 0; i < Str.Length; i++)
            {
                if (Str[i] == 'А')
                    Wordk++;
                if (Str[i] == ' ')
                {
                    if (Wordk == 3)
                        Stringk++;
                    Wordk = 0;
                }

                if ((i == Str.Length - 1) && (Wordk == 3))
                    Stringk++;
            }
            return Stringk;
        }
    }
}
