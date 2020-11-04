using System;

namespace ClassLibrary1
{
    public class MUDA
    {
        private string a;
        private string b;

        public MUDA(string a, string b)
        {
            this.a = a;
            this.b = b;
        }
        public string sum()
        {
            return " = " + ((Int32.Parse(a)) * (Int32.Parse(a)) * (Int32.Parse(a)) + 3 * (Int32.Parse(b)) * (Int32.Parse(a)) * (Int32.Parse(a)) + 3 * (Int32.Parse(b)) * (Int32.Parse(b)) * (Int32.Parse(a)) + (Int32.Parse(b)) * (Int32.Parse(b)) * (Int32.Parse(b)));
        }
    }

}


