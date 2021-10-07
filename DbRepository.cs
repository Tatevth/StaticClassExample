using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class DbRepository
    {
        static DbRepository()
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            connection = configurationManager.GetConnection();

        }
        private static string connection;

        public void GetData()
        {
            Console.WriteLine("Using "+ connection);
        }
    }
}
