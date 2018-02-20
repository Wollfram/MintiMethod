using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsMinti
{
    class Graph {
        public enum IndexatorOption {
            Cost, HasWay
        }
        private int vertexCount;
        /// <summary>
        /// if pathCounts == -1 - no way
        /// else this is way cost
        /// </summary>
        private int[,] pathCosts;

        public Graph(int vertexCount) {
            this.vertexCount = vertexCount;
            pathCosts = new int[vertexCount,vertexCount];
            for (int i = 0; i < vertexCount; i++) {
                for (int j = 0; j < vertexCount; j++) {
                    pathCosts[i,j] = -1;
                }
            }
        }

        public int this[int i, int j, IndexatorOption optin = IndexatorOption.Cost] {
            set {
                pathCosts[i, j] = value;
            }
            get {
                switch (optin) {
                    case IndexatorOption.Cost: return pathCosts[i, j]; break;
                    case IndexatorOption.HasWay: return pathCosts[i, j] < 0 ? 0 : 1; break;
                    default: return pathCosts[i, j]; break; 
                }
            }
        }


        public class MintiNode
        {
            public int distance;
            public int prevVertexIdxs;
            public MintiNode(int distance, int prevVertexIdxs) {
                this.distance = distance;
                this.prevVertexIdxs = prevVertexIdxs;
            }
        }
        /// <summary>
        /// Method Minti
        /// </summary>
        /// <param name="startVertex"></param>
        /// <returns>array of structs [(min distance to  vertex from start vertex,) 
        /// and  prevNode of min path to this vertex], if rez[i] == null - vertex i is unreachable</returns>
        public MintiNode[] DoMinti(int startVertex) {
            MintiNode[] rez = new MintiNode[vertexCount];
            rez[startVertex] = new MintiNode(0,-1);
  
            //first - vertex idx, last - distance
            Dictionary<int,int> vertexInProcessI = new Dictionary<int, int>();
            vertexInProcessI.Add(startVertex,0);

            while (vertexInProcessI.Count > 0) {
                int minDist = Int32.MaxValue;
                int candidat = -1;
                int prevMinNode= -1;

                foreach (var di in vertexInProcessI) {
                    for (int j = 0; j < vertexCount; j++) {
                        if (pathCosts[di.Key,j] <= 0 || rez[j] != null) continue;
                        int dist = di.Value + pathCosts[di.Key, j];
                        if (dist < minDist) {
                            minDist = dist;
                            candidat = j;
                            prevMinNode = di.Key;
                        }
                    }
                }
                rez[candidat] = new MintiNode(minDist,prevMinNode);
                vertexInProcessI.Add(candidat,minDist);

                List<int> toRemove = new List<int>();
                foreach (var di in vertexInProcessI) {
                    int j = 0;
                    for (; j < vertexCount; j++) {
                        if(pathCosts[di.Key,j] <= 0) continue;
                        if (rez[j] == null) break;
                    }
                    if (j == vertexCount)
                      toRemove.Add(di.Key);
                }
                foreach (var i in toRemove) {
                    vertexInProcessI.Remove(i);
                }
            }
            return rez;
        }

        public string ToDotGraph(int startIdx, int destIdx, MintiNode[] mintiRez)
        {
            StringBuilder b = new StringBuilder();
            b.Append("digraph G {" + Environment.NewLine + 
                "rankdir = LR;" + Environment.NewLine + 
                "size = \"8,5\"" + Environment.NewLine + 
                "node[shape = doublecircle color = blue]; v" +startIdx + "_0;" + Environment.NewLine +
                     "node[shape = doublecircle color = red]; v" + destIdx + "_" + mintiRez[destIdx].distance + ";" + Environment.NewLine +
                "node[shape = circle color = black];" + Environment.NewLine);
            b.Append(ToDot(startIdx,destIdx,mintiRez));
            b.Append("}");
            return b.ToString();
        }

        private string ToDot(int startIdx, int DestIdx, MintiNode[] mintiRez)
        {
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < vertexCount; i++) {
                for (int j = 0; j < vertexCount; j++) {
                    if (pathCosts[i, j] > 0) {
                        b.AppendFormat(
                            "v{0}_{1} -> v{2}_{3} [label = \"{4}\"]",i, mintiRez[i].distance, j, mintiRez[j].distance, pathCosts[i, j]);
                        b.AppendLine();
                    }
                }
            }
            return b.ToString();
        }
    }
}
