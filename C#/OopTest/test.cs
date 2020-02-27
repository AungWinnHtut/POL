using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTest
{
    public class test
    {
        public int i;
        char c;
        int d;
        public string name
        { get; set; }
        public void setc(char ch) //setter function
        {
            c = ch;
        }
        public char getcc()
        {
            return c;
        }

        public void setd(int j) //setter function
        {
            d = j;
        }
        public int getd()
        {
            return d;
        }

    }
}
