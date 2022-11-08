using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MyScripts
{
    internal class MyFile
    {
        public string path { get; set; }
        public string name { get; set; }
        public string extension { get; set; }
        public string modifiedDate { get; set; }
        public bool isWritable { get; set; }
        public BitmapImage writiableStatusImage
        {
            get { return isWritable ? ResourceManager.img_circle_green : ResourceManager.img_circle_red; }
        }
        
        public MyFile(string path, string name, string extension, string modifiedDate, bool isWritable)
        { 
            this.path = path;
            this.name = name;
            this.extension = extension;
            this.modifiedDate = modifiedDate;
            this.isWritable = isWritable;
        }

    }
}
