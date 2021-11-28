using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimal_network
{
    
    class NetworkKruskal
    {

        public int[][] Netwrok()


        {
            string workingDirectory = Environment.CurrentDirectory;
            string path = Path.Combine(Directory.GetParent(workingDirectory).Parent.FullName, @"network\", @"_network.txt");
            //whole to a single string
            string text = File.ReadAllText(path);

            /* split and input on 2d array*/

            var Network = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)

                .Select(line => line.Trim()
                    .Split(',')
                    .Select(s => int.Parse(s.Replace('-','0')))        //if - set 0 
                    .ToArray())
               .ToArray();

            return Network;
        }
    }
}
