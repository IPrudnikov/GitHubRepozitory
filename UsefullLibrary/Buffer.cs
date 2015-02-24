using System.Collections.Generic;
using System.Linq;

    public class Buffer
    {
        protected int NumbEmpty = 0;
        protected string[] strVal = new string[0];

        public void Set(string val)
        {
            string[] strTmp = { val };

            strVal = strVal.Concat(strTmp).ToArray();
            //strVal[NumbEmpty] = val;
            NumbEmpty++;
        }

        //последний первый
        public string GetLF()
        {
            string rez = "";
            if (NumbEmpty > 0)
            {
                NumbEmpty--;
                rez = strVal[NumbEmpty];
            }

            return rez;
        }

        //первый первый
        public string GetFF()
        {
            string rez = "";
            if (NumbEmpty > 0)
            {
                NumbEmpty--;
                List<string> tmp = new List<string>(strVal);
                rez = strVal[0];
                tmp.RemoveAt(0);
                strVal = tmp.ToArray();

            }

            return rez;
        }
    }
