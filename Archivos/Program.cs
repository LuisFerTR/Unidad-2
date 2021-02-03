using System;
using System.IO;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (Lexico0 l = new Lexico0())
                {
                    l.Encrypt();
                    
                }
                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
