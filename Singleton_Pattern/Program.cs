using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPool obj = PrintPool.getInstance();
            obj.printMsg("doc_1");

            PrintPool obj1 = PrintPool.getInstance();
            obj1.printMsg("doc_2");
        }
    }

    public class PrintPool
    {
        private static PrintPool instance;
        /// <summary>
        ///  防止被实例化
        /// </summary>
        private PrintPool()
        {
        }

        public static PrintPool getInstance()
        {
            if(instance==null)
            {
                instance = new PrintPool();
            }

            return instance;
        }

        public void printMsg(string content)
        {
            Console.WriteLine(content);
        }

    }
}
