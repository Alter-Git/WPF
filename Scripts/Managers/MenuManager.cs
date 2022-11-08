using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyScripts
{
    internal class MenuManager
    {
        static MenuManager Instance;

        Tab_Explorer tab_explorer = new();
        Tab_Bitmaper tab_bitmaper = new();

        private MenuManager()
        {            
        }
        public static MenuManager GetInstance()
        {
            if (Instance == null)
            {
                Instance = new();
            }
            return Instance;
        }

        public static List<MyFile>? GetDirectoryFiles(string path)
        {
            return Instance.tab_explorer.GetDirectoryFiles(path);
        }

        public static List<Tab_Bitmaper.BitImage> GetListboxItems(int count)
        {
             return Instance.tab_bitmaper.GetListboxItems(count);
        }

    }
}
