using System;


namespace test
{
    class Program
    {
        /// <summary>
        /// just the main function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(Git(10,20));
        }

        int AnyFormule(int a,int b)
        {
            int res = b / a;
            return res;
        }
    }
}
