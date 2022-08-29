using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Handson
{
    internal class DBConn
    {
        private static DBConn instance = new DBConn();
        private DBConn() { }
        public static DBConn GetInstance()
        {
            return instance;
        }
        public void ShowMessage()
        {
            Console.WriteLine("Hello");
        }

    }
    public class DBConnX
    {
        public static void Main(String[] args)
        {


            DBConn object1 = DBConn.GetInstance();

            object1.ShowMessage();

        }
    }
}
