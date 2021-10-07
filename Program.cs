using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DbRepository dbRepository = new DbRepository();
            dbRepository.GetData();
        }
    }
}
