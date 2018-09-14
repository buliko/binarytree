using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo3_binaris_keresofa
{
    class Program
    {
        static void Main(string[] args)
        {

            BinaryTree bTree = new BinaryTree();
            bTree.Add(10);
            bTree.Add(90);
            bTree.Add(35);
            bTree.Add(-20);
            bTree.Add(70);

            Console.WriteLine("Tree containts {0}: {1}", 10, bTree.Contains(10));
            Console.WriteLine("Tree containts {0}: {1}", 20, bTree.Contains(20));
            Console.WriteLine("Tree containts {0}: {1}", 35, bTree.Contains(35));
            Console.WriteLine("Tree containts {0}: {1}", 90, bTree.Contains(90));
            Console.WriteLine("Tree containts {0}: {1}", -100, bTree.Contains(-100));
            Console.WriteLine("Tree containts {0}: {1}", -20, bTree.Contains(-20));
            Console.WriteLine("Tree containts {0}: {1}", 70, bTree.Contains(70));


            Console.ReadKey();

        }



    }
}
