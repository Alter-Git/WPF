using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyScripts 
{
    internal static class MessageManager
    {
        public static void ShowError(int id)
        {
            string s="";
            switch (id)
            {
                case 0: s = "Unknown Error"; break;
                case 1: s = "Error 1"; break;
                case 2: s = "Your directory path is not valid or does not exist."; break;
            }

            MessageBox.Show(s, "Error");
        }

    }
}
