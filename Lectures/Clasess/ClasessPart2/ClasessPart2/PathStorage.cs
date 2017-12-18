using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClasessPart2
{
    
    public static class PathStorage
    {
        private static List<Path> paths;
        //const
        public PathStorage()
        {
            paths = new List<Path>();
        }
        public static List<Path> Paths
        {
            get { return paths; }
            set { paths = value; }
        }
        
        public static void PathStore(Path paths)
        {
            paths = new List<Path>();
            foreach (var item in pathStore)
            {
                pathStore.Add(paths);
            }
        }

        public static void SaveToFile()
        {

        }
    }
}
