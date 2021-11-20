using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string a = "";
            foreach (char letter in original)
                a += letter.ToString() + letter.ToString(); 
            return a;        
        }
    }
}
