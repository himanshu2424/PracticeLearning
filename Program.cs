using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDevops
{
    class Program
    {
        static void Main(string[] args)
        {

		string[] arr = { "aaa.txt", "bbb.TXT", "xyz.abc.pdf", "aaaa.PDF", 
                             "abc.xml", "ccc.txt", "zzz.txt" };
          var egrp=arr.Select(file=>Path.GetExtension(file).TrimStart('.').ToLower())
                     .GroupBy(x => x,(ext, extCnt) =>new
                                                     {
                                                        Extension = ext,
                                                        Count = extCnt.Count()
                                                      });
 
          foreach (var v in egrp)
              Console.WriteLine("{0} File(s) with {1} Extension ",
                                  v.Count, v.Extension);
								  
			
            Console.WriteLine("Hello Devops by Himanshu for Jenkins !!. Automated builds are now successfull. Connected MSBUILD as well. Hi Mishti...");
			Console.ReadLine();
        }
    }
}
