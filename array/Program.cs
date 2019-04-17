using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {

        class Neighbour
        {
            public string fullname;
            public int flatnumber;
            public int phone;

        }

        static void Main(string[] args)
        {
            ArrayListExample2();
            Console.ReadLine();

        }

        /*public static void ArrayListExample()
        {

            ArrayList myAL = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                string s = Console.ReadLine();
                myAL.Ads(s);
            }
            myAL.Sort();
            myAL.Remove
                foreach(string item in myAl)
            {
                Console.WriteLine();
            }


        }*/


        /*public static void ArrayListExample2()
        {
            List<Neighbour> parts = new List<Neighbour>();
            parts.Add(new Neighbour { fullname = "vasia", flatnumber = 1, phone = 999 });
            parts.Add(new Neighbour { fullname = "vasia2", flatnumber = 12, phone = 9992 });
            parts.Add(new Neighbour { fullname = "vasia3", flatnumber = 13, phone = 9993 });
            Console.WriteLine("imput flat number");
            int s = Convert.ToInt32(Console.ReadLine());
            foreach (var item in parts)
            {
                if (item.flatnumber == s)
                {
                    Console.WriteLine(item.phone);
                    break;
                }
            }
        }*/

        public static void ArrayListExample2()
        {
            var parts = new Dictionary<int, Neighbour>();
            parts.Add(1,new Neighbour { fullname = "vasia", flatnumber = 1, phone = 999 });
            parts.Add(3,new Neighbour { fullname = "vasia2", flatnumber = 12, phone = 9992 });
            parts.Add(7,new Neighbour { fullname = "vasia3", flatnumber = 13, phone = 9993 });
            Console.WriteLine("imput flat number");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(parts[s].phone);

        }
    }
}
