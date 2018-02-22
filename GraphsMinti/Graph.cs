using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GraphsMinti
{
    [Serializable]
    public class Graph {
        //for double comparsion
        private static double TOLERANCE = 0.00001;
        public enum IndexatorOption {
            Cost, HasWay
        }
        private int vertexCount;

        public int VertexCount => vertexCount;

        /// <summary>
        /// if pathCounts == -1 - no way
        /// else this is way cost
        /// </summary>
        private double[,] pathCosts;

        public Graph(int vertexCount) {
            this.vertexCount = vertexCount;
            pathCosts = new double[vertexCount,vertexCount];
            for (int i = 0; i < vertexCount; i++) {
                for (int j = 0; j < vertexCount; j++) {
                    pathCosts[i,j] = -1;
                }
            }
        }

        public double this[int i, int j, IndexatorOption optin = IndexatorOption.Cost] {
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
            public double distance;
            public int prevVertexIdxs;
            public List<int> otherPrevWayIdxs = null;
            public MintiNode(double distance, int prevVertexIdxs, List<int> otherPrevWays = null) {
                this.distance = distance;
                this.prevVertexIdxs = prevVertexIdxs;
                otherPrevWayIdxs = otherPrevWays;
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
            rez[startVertex] = new MintiNode(0,-1,null);
  
            //first - vertex idx, last - distance
            Dictionary<int,double> vertexInProcessI = new Dictionary<int, double>();
            vertexInProcessI.Add(startVertex,0);

            while (vertexInProcessI.Count > 0) {
                double minDist = Double.MaxValue;
                int candidat = -1;
                int prevMinNode= -1;
                List<int> otherWays = new List<int>();

                foreach (var di in vertexInProcessI) {
                    for (int j = 0; j < vertexCount; j++) {
                        if (pathCosts[di.Key, j] < 0 || rez[j] != null) continue;
                        double dist = di.Value + pathCosts[di.Key, j];
                        if (dist < minDist) {
                            minDist = dist;
                            candidat = j;
                            prevMinNode = di.Key;
                            otherWays.Clear();
                        }
                        else if (Math.Abs(dist - minDist) < TOLERANCE && candidat == j) {
                            otherWays.Add(di.Key);
                        }
                    }
                }
                if (candidat != -1) {
                    rez[candidat] = new MintiNode(minDist, prevMinNode);
                    if (otherWays.Count != 0) rez[candidat].otherPrevWayIdxs = otherWays;
                    vertexInProcessI.Add(candidat, minDist);
                }

                List<int> toUnprocess = new List<int>();
                foreach (var di in vertexInProcessI) {
                    int j = 0;
                    for (; j < vertexCount; j++) {
                        if(pathCosts[di.Key,j] < 0) continue;
                        if (rez[j] == null) break;
                    }
                    if (j == vertexCount)
                      toUnprocess.Add(di.Key);
                }
                foreach (var i in toUnprocess) {
                    vertexInProcessI.Remove(i);
                }
            }
            return rez;
        }

        /// <summary>
        /// returns dot-graph script
        /// </summary>
        /// <param name="startIdx"></param>
        /// <param name="destIdx">if negative - show all pathes</param>
        /// <param name="mintiRez"></param>
        /// <param name="showSingle">if show isolated nodes</param>
        /// <returns></returns>
        public string ToMintyDotGraph(int startIdx, int destIdx, MintiNode[] mintiRez, bool showSingle)
        {
            StringBuilder b = new StringBuilder();
            b.Append("digraph G {" + Environment.NewLine + "rankdir = LR;" + Environment.NewLine + "size = \""+(vertexCount > 10 ? vertexCount: 10).ToString() +"\"" +
                     Environment.NewLine + "node[shape = doublecircle color = blue]; \"" + (startIdx+1) + "\";" +
                     Environment.NewLine);
            if (destIdx != -1)
                b.Append("node[shape = doublecircle color = red]; \"" + (destIdx+1) + "\";" + Environment.NewLine);
            b.Append("node[shape = circle color = black];" + Environment.NewLine);
            b.Append(ToMintyDot(startIdx,destIdx,mintiRez,showSingle));
            b.Append("}");
            return b.ToString();
        }

        private string ToMintyDot(int startIdx, int destIdx, MintiNode[] mintiRez, bool showSingle)
        {
            bool showAll = (destIdx == -1);

            StringBuilder b = new StringBuilder();
            if (showAll) { //show all short ways
                for (int i = 0; i < vertexCount; i++) {
                    bool hasOutLink = false;
                    for (int j = 0; j < vertexCount; j++) {

                        if (pathCosts[i, j] >= 0) {
                            hasOutLink = true;

                            b.Append($"\"{i + 1}\" -> \"{j + 1}\" [label = \"{pathCosts[i, j]}\"");
                            if (mintiRez[j] != null) {
                                if (mintiRez[j].prevVertexIdxs == i) b.Append(" color = red fontcolor = red]");
                                else if (mintiRez[j].otherPrevWayIdxs != null &&
                                         mintiRez[j].otherPrevWayIdxs.Contains(i))
                                    b.Append(" color = magenta fontcolor = magenta]");
                                else b.Append("]");
                            }
                            else b.Append("]");
                            b.AppendLine();
                        }
                    }
                    if (!hasOutLink && showSingle) {
                        int k = 0;
                        for (; k < vertexCount; k++) {
                        //    if (pathCosts[k, i] > 0) break;
                            if (pathCosts[k, i] >= 0) break;
                        }
                        if (k == vertexCount && i != 0) {
                            b.Append($"node[shape = circle color = black] \"{i + 1}\";");
                            b.AppendLine();
                        }
                    }
                }
            }
            else
            {// show one way
                // 1 - main way
                // 2 - second way
                // 0 - no action
                short[,] mainRoadWayTable = new short[vertexCount, vertexCount];
                int tmp = destIdx;
                if (mintiRez[tmp] != null)
                {
                    List<int> secondaryWaysToProcess = new List<int>();
                    while (tmp != startIdx)
                    {
                        mainRoadWayTable[mintiRez[tmp].prevVertexIdxs, tmp] = 1;
                        if (mintiRez[tmp].otherPrevWayIdxs != null) {
                            foreach (var opwi in mintiRez[tmp].otherPrevWayIdxs) {
                                mainRoadWayTable[opwi, tmp] = 2;
                                secondaryWaysToProcess.Add(opwi);
                            }
                        }
                        tmp = mintiRez[tmp].prevVertexIdxs;
                    }
                    while (secondaryWaysToProcess.Count > 0) {
                        int curNodeIdx = secondaryWaysToProcess[0];
                        if (mintiRez[curNodeIdx].prevVertexIdxs != -1) {
                            if (mainRoadWayTable[mintiRez[curNodeIdx].prevVertexIdxs, curNodeIdx] == 0) {
                                mainRoadWayTable[mintiRez[curNodeIdx].prevVertexIdxs, curNodeIdx] = 2;
                                secondaryWaysToProcess.Add(mintiRez[curNodeIdx].prevVertexIdxs);
                            }
                            if (mintiRez[curNodeIdx].otherPrevWayIdxs != null) {
                                foreach (var opwi in mintiRez[curNodeIdx].otherPrevWayIdxs) {
                                    if (mainRoadWayTable[opwi, curNodeIdx] == 0) {
                                        mainRoadWayTable[opwi, curNodeIdx] = 2;
                                        secondaryWaysToProcess.Add(opwi);
                                    }
                                }

                            }
                        }
                        secondaryWaysToProcess.RemoveAt(0);
                    }
                }
                for (int i = 0; i < vertexCount; i++)
                {
                    bool hasOutLink = false;
                    for (int j = 0; j < vertexCount; j++) {
                        if (pathCosts[i, j] >= 0) {
                            hasOutLink = true;

                            b.Append($"\"{i + 1}\" -> \"{j + 1}\" [label = \"{pathCosts[i, j]}\"");
                            if (mainRoadWayTable[i, j] == 1) b.Append(" color = red fontcolor = red]");
                            else if (mainRoadWayTable[i, j] == 2) b.Append(" color = magenta fontcolor = magenta]");
                            else b.Append("]");
                            b.AppendLine();
                        }
                    }
                    if (!hasOutLink && showSingle)
                    {
                        int k = 0;
                        for (; k < vertexCount; k++)
                        {
                            if (pathCosts[k, i] >= 0) break;
                        }
                        if (k == vertexCount && i != 0)
                        {
                            b.Append($"node[shape = circle color = black] \"{ i+1}\";");
                            b.AppendLine();
                        }
                    }
                }

            }
            b.AppendFormat("overlap = false" + Environment.NewLine);
            if (destIdx != -1) {
                if (mintiRez[destIdx] != null)
                    b.Append("label = \"Відстань до стоку " + mintiRez[destIdx].distance + "\"");
            }
            else {
                b.Append((startIdx == destIdx || destIdx == -1 ? "label = \"Показано всі шляхи\"" : "label = \"Стік недосяжний\"") + Environment.NewLine +
                    "fontsize = 12;" + Environment.NewLine);
            }
            return b.ToString();
        }

        public void Save(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate)) { formatter.Serialize(fs, this); }
        }
        public static Graph Load(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Graph newobj;
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                newobj = (Graph)formatter.Deserialize(fs);
            }
            return newobj;
        }

    }
}
