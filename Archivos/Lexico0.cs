using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Archivos
{
    class Lexico0
    {
        private StreamReader archivo;
        private StreamWriter bitacora;

        public Lexico0()
        { 
            Console.WriteLine("Compilando prueba.txt");

            try
            {
                if (File.Exists("C:\\Archivos\\prueba.txt"))
                {
                    archivo = new StreamReader("C:\\Archivos\\prueba.txt");
                    bitacora = new StreamWriter("C:\\Archivos\\prueba.log");
                    bitacora.AutoFlush = true;

                    bitacora.WriteLine("Archivo: prueba.txt");
                    bitacora.WriteLine("Directorio: C:\\Archivos");
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        ~Lexico0()
        {
            Console.WriteLine("Finaliza compilacion de prueba.txt");
            CerrarArchivos();
            Console.ReadKey();
        }

        private void CerrarArchivos()
        {
            archivo.Close();
            bitacora.Close();
        }

        public void Display()
        {
            if (archivo != null)
            {
                while (!archivo.EndOfStream)
                {
                    Console.Write((char)archivo.Read());
                }
            }
        }
    }
}
