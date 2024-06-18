using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSync
{
    public class File
    {
        private string path;
        private string md5;
        public File(string path, string md5)
        {
            this.path = path;
            this.md5 = md5;
        }
        public string getPath() { return path; }
        public string getMd5() { return md5; }
    }
}
