using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{


    public class Graph
    {
        List<Vertex> allVertex;
        List<Edge> allEdges;
        byte[,] AMatrix;
        byte[,] IMatrix;
        public static Dictionary<String, int> VNums = new Dictionary<string, int>()
        {
            { "A", 0 },
            { "B", 1 },
            { "C", 2 },
            { "D", 3 },
            { "E", 4 },
            { "F", 5 },
            { "G", 6 }
        };
        public Graph(List<Vertex> v, List<Edge> e)
        {
            this.allEdges = e;
            this.allVertex = v;
            CalcAMatrix();
        }

        void CalcAMatrix()
        {
            
            AMatrix = new byte[this.allVertex.Count, this.allVertex.Count];
            for(int i = 0; i < this.allVertex.Count; i++)
            {
                for(int j = 0; j < this.allVertex.Count; j++)
                {
                    AMatrix[i, j] = 0;
                }
            }

            foreach(Edge e in allEdges)
            {
                this.AMatrix[VNums[e.vStart.getName()], VNums[e.vEnd.getName()]] = 1;
            }
        }
        
        public byte[,] getAMatrix()
        {
            return this.AMatrix;
        }

        public List<Vertex> GetContur(String V)
        {
            List<Vertex> Contur = new List<Vertex>();
            int Row = VNums[V];
            CalcContur(Row, Row, Contur);
            
            for(int i = 0; i < allVertex.Count; i++)
            {
                allVertex[i].Travers = false;
            }
            return Contur;
        }

        private void CalcContur(int StartRow, int Row, List<Vertex> Contur)
        {
            bool AllIs0 = true;
            Console.WriteLine($"Vertex : {allVertex[Row].getName()}\nStartRow = {StartRow}");
            Console.WriteLine($"Add in Contur : {allVertex[Row].getName()}");
            Contur.Add(allVertex[Row]);
            allVertex[Row].Travers = true;
            for (int i = 0; i < AMatrix.GetLength(0); i++)
            {
                if(Contur.Count != 1 && (Contur[0].getName() == Contur[Contur.Count-1].getName()))
                {
                    return;
                }
                if (AMatrix[Row, i] == 1)
                {
                    if(i == StartRow)
                    {
                        Contur.Add(allVertex[i]);
                        return;
                    }
                    if (!allVertex[i].Travers)
                    {
                        CalcContur(StartRow, i, Contur);
                    }
                    else
                    {
                        Console.WriteLine($"Travers of {allVertex[i].getName()} is true");
                    }
                    AllIs0 = false;
                }
            }

            if (Contur.Count != 0 && AllIs0)
            {
                Console.WriteLine($"Remove Vertex : {Contur[Contur.Count - 1].getName()}");
                Contur.RemoveAt(Contur.Count-1);
            }
        }
    }

    
}
