using System;
using System.Diagnostics;

namespace Alert
{
    class Program
    {
        /// <summary>
        /// Salam
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                string pathUrl = args[0].Replace(args[0].Split(':')[0] + ':', "");
                try
                {
                    Process.Start(@pathUrl);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
