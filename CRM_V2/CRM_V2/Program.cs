using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList CustomerInfo = new System.Collections.ArrayList();

            bool cont = true;
            String again;
            String nstr;
            String pstr;
            String mstr;
            String fstr;

            while (cont == true)
            {
                Console.WriteLine("Ange namn");
                nstr = Console.ReadLine();
                Console.WriteLine("Ange telefonnummer");
                pstr = Console.ReadLine();
                Console.WriteLine("Ange mail");
                mstr = Console.ReadLine();
                Console.WriteLine("Ange favorit (Ja/Nej)");
                fstr = Console.ReadLine();

                CustomerInfo.Add(new CustomerInfo() { Name = nstr, phonenumber = pstr, mail = mstr, favorit = fstr });
                Console.WriteLine("Tack, registrerad, mer? (Ja/Nej)");
                again = Console.ReadLine();
                if (again.Equals("Nej"))
                {
                    cont = false;
                }

            }

            int favCount = 0;
            Console.WriteLine("\nDu har {0} st kontakter", CustomerInfo.Count);
            foreach (CustomerInfo tot in CustomerInfo)
            {
                Console.WriteLine("{0} {1} {2} {3}", tot.Name, tot.phonenumber, tot.mail, tot.favorit);
                if (tot.favorit.Equals("Ja"))
                {
                    favCount++;
                }
            }
            Console.WriteLine("\nDu har {0} st favoriter", favCount);
            foreach (CustomerInfo tot in CustomerInfo)
            {
                if (tot.favorit.Equals("Ja"))
                {
                    Console.WriteLine("{0} {1} {2} {3}", tot.Name, tot.phonenumber, tot.mail, tot.favorit);
                }
            }
        }
    }
}
