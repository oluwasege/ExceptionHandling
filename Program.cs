using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                StreamReader streamReader = new StreamReader(@"C:\smple.txt");
               
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
