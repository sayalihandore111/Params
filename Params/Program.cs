using System;

namespace Params
{
    class Geeks
    {

        public void result(params object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void Main(string[] args)
        {
            Geeks gfg = new Geeks();
            gfg.result("Geeks", "GFG","ProGeek Cup 2.0", "G4G", "100");
        }
    }
}
