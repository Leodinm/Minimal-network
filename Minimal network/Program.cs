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


            GraphNetwork mynet = new GraphNetwork();

             var netWork = mynet.Netwrok();

             int Edges = 0;

            for (int i = 0; i <= netWork.Length - 1; i++)
                for (int j = i+1; j <= netWork.Length - 1; j++)
                {
                    if (netWork[i][j] != 0)
                        Edges++;                         //calculate number of Edges
                }


                Graph graph = new Graph(netWork.Length, Edges);


            int k = 0;

            for (int i = 0; i <= netWork.Length - 1; i++)
                for (int j = i+1; j  <= netWork.Length - 1; j++)
                {
                    if (netWork[i][j] != 0)                    // if have  Edge    
                    {
                        graph.edge[k].src = i;                                 // intialized values of graph
                        graph.edge[k].dest = j;
                        graph.edge[k].weight = netWork[i][j];
                        k++;
                    }
                }


            graph.KruskalMST();

            Console.ReadLine();
        }
    }
}
