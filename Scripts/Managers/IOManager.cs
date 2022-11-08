using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyScripts
{
    internal class IOManager
    {
        public static List<MyFile> GetFiles(string path)
        {
            string[] filePaths = Directory.GetFiles(path);
            List<MyFile> files = new List<MyFile>();
            foreach (string s in filePaths)
            {
                files.Add(new MyFile(s, Path.GetFileNameWithoutExtension(s), Path.GetExtension(s), File.GetLastAccessTime(s).ToString(),  !new FileInfo(s).Attributes.HasFlag(System.IO.FileAttributes.ReadOnly)));
            }

            return files;

        }

        public static bool isPathCorrect(string path)
        {
            return Directory.Exists(path);
        }

    }



}
