using System;
using System.IO;
using System.Reflection;

namespace Scavanger
{
    public class AssetLocation
    {
        readonly private static String baseDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Remove(0, 6);

        public static String Enemy { get { return baseDir + "\\Assets\\Images\\Enemy\\"; } }

        public static String Pickup { get { return baseDir + "\\Assets\\Images\\Pickup\\"; } }

        public static String Player { get { return baseDir + "\\Assets\\Images\\Player\\"; } }

        public static String Tile { get { return baseDir + "\\Assets\\Images\\Tile\\"; } }

        public static String Wall { get { return baseDir + "\\Assets\\Images\\Wall\\"; } }

        public static String World { get { return baseDir + "\\Assets\\Worlds\\"; } }

        public static String[] GetFileNames(String[] paths)
        {
            for (int i = 0; i < paths.Length; i++)
            {
                paths[i] = paths[i].Remove(0, paths[i].LastIndexOf("\\") + 1);
            }
            return paths;
        }
    }
}
