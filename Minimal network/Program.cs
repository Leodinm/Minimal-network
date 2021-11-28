using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* https://projecteuler.net/problem=107*/

/*Calculate Minimum Spanning Tree with kruskal*/

namespace Minimal_network
{
    class Program
    {
		
		static void Main(string[] args)
        {
            
            NetworkKruskal mynet = new NetworkKruskal();

            var kurskalGraph = mynet.Netwrok();

            int Edges = 0;

            for (int i = 0; i <= kurskalGraph.Length - 1; i++)
                for (int j = i+1; j <= kurskalGraph.Length - 1; j++)
                {
                    if (kurskalGraph[i][j] != 0)
                        Edges++;                         //calculate number of Edges
                }


             Graph graph = new Graph(kurskalGraph.Length, Edges);


            int k = 0;

            for (int i = 0; i <= kurskalGraph.Length - 1; i++)
                for (int j = i+1; j  <= kurskalGraph.Length - 1; j++)
                {
                    if (kurskalGraph[i][j] != 0)                    // if have  Edge    
                    {
                        graph.edge[k].src = i;                                 // intialized values of graph
                        graph.edge[k].dest = j;
                        graph.edge[k].weight = kurskalGraph[i][j];
                        k++;
                    }
                }

            graph.KruskalMST();

            Console.ReadLine();
        }
    }
}
