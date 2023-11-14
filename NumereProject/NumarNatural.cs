using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumereProject
{


    public class NumarNatural
    {
        public int minCifra = 0;
        public int maxCifra = 9;
        public char semn = '+'; //sau '-'
        public List<int> cifre = new List<int>();
        public int lungimeNumar = 0;

        public bool isACifra(int x)
        {
            if (x >= minCifra && x <= maxCifra)
            {

                return true;
            }
            return false;

        }

        public NumarNatural adunare(NumarNatural a, NumarNatural b)
        {
            NumarNatural x = new NumarNatural();
            
            int lungNrA = a.whatNumberOfCifreHaveANumber(a);
            int lungNrB = b.whatNumberOfCifreHaveANumber(b);
            int transport = 0;

            if (lungNrA == lungNrB)
            {
                int c = 0;
                for (int i =0;i<lungNrA; i++)
                {
                     c = a.cifre[i] + b.cifre[i] + transport ;
                    if (c<10)
                    {
                        transport = 0;
                        x.addCifra(c);
                        
                    }
                    else 
                    {
                        transport = 1;
                        
                        x.addCifra(c%10);
                    }
                }
            }
            if (transport != 0) { x.addCifra(transport); }

            return x;
        }

        public bool addCifra(int i)
        {
            if (isACifra(i))
            {
                cifre.Add(i);
                return true;
            }
            return false;
        }

        public string printCifra(int i)
        {
            return cifre[i].ToString();
        }

        public string printNumarReverse()
        {
            string x = "";
            for (int i = 0; i < cifre.Count; i++)
            {

                x += cifre[i].ToString();

            }
            return x;
        }
        public string printNumar()
        {
            string x = "";
            for (int i = cifre.Count-1; i >= 0;  i--)
            {

                x += cifre[i].ToString();

            }
            return x;
        }
        public int whatNumberOfCifreHaveANumber(int px)
        {
            int x = 0;
            int ppx = px;
            while (ppx > 0)
            {

                ppx = ppx / 10;
                x++;
            };

            return x;

        }
        public int whatNumberOfCifreHaveANumber(NumarNatural nx)
        {
            int x = 0;
            x = nx.cifre.Count;

            return x;

        }
        public bool int2cifre(int x)
        {
            List<int> c = new List<int>();
            int lengthOfX = whatNumberOfCifreHaveANumber(x);
            int px = x;
            while (px > 0)
            {
                c.Add(px % 10);
                px = px / 10;

            };
            this.cifre = c;
            return true;
        }
        public bool string2cifre(string x)
        {
            List<int> c = new List<int>();
            int lengthOfX = x.Length;
            
            for(int i = lengthOfX-1; i>=0 ; i--)
            {
                c.Add(Int32.Parse(x.Substring(i,1)));
               

            };
            this.cifre = c;
            return true;
        }

        //section constructors
        public NumarNatural() { }
        public NumarNatural(int i) { 
            bool x = int2cifre(i); //transforma int in cifrele unui numar memorat intro lista de int 
        }

        public bool addNewNumar(int i)
        {
            bool x = int2cifre(i);
            return x;
        }
        public bool addNewNumar(string i)
        {
            bool x = string2cifre(i);
            return x;
        }
    }


}
