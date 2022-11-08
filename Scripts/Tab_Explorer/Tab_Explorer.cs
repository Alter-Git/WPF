using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyScripts
{
    internal class Tab_Explorer
    {
        List<MyFile>? listViewFiles;

        public List<MyFile>? GetDirectoryFiles(string path)
        {
            if (IOManager.isPathCorrect(path))
            {
                listViewFiles = IOManager.GetFiles(path);
                return listViewFiles;
            }
            else
            {
                MessageManager.ShowError(2);
            }

            return null;

        }

    }
}
