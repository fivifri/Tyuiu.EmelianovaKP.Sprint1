using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.EmelianovaKP.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            if (value.Length == 0)
            {
                return true;
            }

            char prev = value[0];

            foreach (char ch in value)
            {
                if (ch < prev)
                {
                    return false;
                }

                prev = ch;
            }

            return true;
        }
    }
}
