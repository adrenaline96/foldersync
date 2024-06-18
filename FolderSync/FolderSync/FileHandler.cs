using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSync
{
    public class FileHandler
    {
        private string sourcePath;
        private string replicaPath;
        private List<File> sourceFiles;
        private List<File> replicaFiles;

        public FileHandler(string sourcePath, string replicaPath)
        {
            this.sourcePath = sourcePath;
            this.replicaPath = replicaPath;
            sourceFiles = new List<File>();
            replicaFiles = new List<File>();
        }

        public void EnumFiles()
        {
            string[] srcFilesPaths = Directory.GetFiles(sourcePath);
            string[] replicaFilesPaths = Directory.GetFiles(replicaPath);

            sourceFiles.Clear();
            replicaFiles.Clear();

            foreach (string srcFile in srcFilesPaths)
            {
                sourceFiles.Add(new File(srcFile, Util.CalculateMD5(srcFile)));
            }

            foreach (string replicaFile in replicaFilesPaths)
            {
                replicaFiles.Add(new File(replicaFile, Util.CalculateMD5(replicaFile)));
            }
        }

        public void CopyMissingFiles(ListBox lbLog)
        {
            List<string> srcMD5 = new List<string>();
            List<string> replicaMD5 = new List<string>();

            GetMD5(srcMD5,replicaMD5);

            List<string> srcNotReplica = srcMD5.Except(replicaMD5).ToList();

            foreach (string srcFile in srcNotReplica) 
            { 
                foreach(File src in sourceFiles)
                {
                    if(srcFile == src.getMd5())
                    {
                        System.IO.File.Copy(src.getPath(), replicaPath +"/"+ Path.GetFileName(src.getPath()));
                        lbLog.Items.Add("Copied "+ Path.GetFileName(src.getPath())+" to replica folder.");
                    }
                }
            }
        }
        public void RemoveDeletedFiles(ListBox lbLog)
        {
            List<string> srcMD5 = new List<string>();
            List<string> replicaMD5 = new List<string>();

            GetMD5(srcMD5, replicaMD5);

            List<string> replicaNotSrc = replicaMD5.Except(srcMD5).ToList();

            foreach(string replicaFile in replicaNotSrc)
            {
                foreach(File replica in replicaFiles)
                {
                    if(replicaFile == replica.getMd5())
                    {
                        if (System.IO.File.Exists(replica.getPath()))
                        {
                            try
                            {
                                System.IO.File.Delete(replica.getPath());
                                lbLog.Items.Add("Removed " + Path.GetFileName(replica.getPath()) + " from replica folder as it is no longer present in the source folder!");
                            }
                            catch { }
                                                      
                        }
                    }
                }
            }
        }

        public void CheckRenamedFiles(ListBox lbLog)
        {
            foreach (File srcFile in sourceFiles)
            {
                foreach (File replicaFile in replicaFiles)
                {
                    if(srcFile.getMd5() == replicaFile.getMd5())
                    {
                        if(Path.GetFileName(srcFile.getPath()) != Path.GetFileName(replicaFile.getPath())){
                            System.IO.File.Move(replicaFile.getPath(), Path.GetDirectoryName(replicaFile.getPath())+"/"+Path.GetFileName(srcFile.getPath()), true);
                            lbLog.Items.Add("Renamed " + Path.GetFileName(replicaFile.getPath()) + " in replica folder to " + Path.GetFileName(srcFile.getPath()));
                        }
                    }
                }
            }
        }
        private void GetMD5(List<string> srcMD5, List<string> replicaMD5)
        {
            foreach (File file in sourceFiles)
            {
                srcMD5.Add(file.getMd5());
            }

            foreach (File file in replicaFiles)
            {
                replicaMD5.Add(file.getMd5());
            }
        }
    }
}
