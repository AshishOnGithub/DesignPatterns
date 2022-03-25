using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    public sealed class Singleton
    {
        private static readonly object lockObject = new object ();  

        
        private Singleton() { }

     
        private static Singleton _instance;

        
        public static Singleton GetInstance()
        {
            lock (lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    
                }
            return _instance;
        }

       
        public void SendPrintRequest(string command)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Printing: "+ command);
        }
    }
}
