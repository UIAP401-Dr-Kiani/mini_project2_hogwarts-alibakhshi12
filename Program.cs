using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hagwartz
{
    
  internal class Program
  {
    public static void Main(string[] args)
    {
        using (StreamReader file = new StreamReader("file.tsv"))
        {
            string ln;
            while ((ln =file.ReadLine())!= null)
            {
                string[] human = ln.Split('\t').ToArray<string>();
            }

            file.Close();
        }
    }
  }
}