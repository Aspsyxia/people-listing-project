using System.Collections.Generic;
using System.IO;

namespace PeopleListing
{
    public class FileOperations
    {
        public static void SaveToFile(Dictionary<string, string> dict)
        {
            using (FileStream fileStream = new FileStream(@"PersonList.txt", FileMode.Create, FileAccess.Write))
            {
                StreamWriter streamWriter = new StreamWriter(fileStream);
                foreach (var entry in dict)
                {
                    streamWriter.WriteLine("{0} {1}", entry.Key, entry.Value);
                    streamWriter.Flush();
                }
            }
        }
    }
}
