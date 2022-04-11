using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace FileReadAndFind
{
    internal class Program
    {
       string path= "C:\\Users\\Aaliya Sheikh\\MyFiles";

        public static void Main(){
            Console.WriteLine("Enter into the Directory");
            Program program = new Program();
            program.GetIntoSubDirectroies();
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();   

             
                /*var path = @"C:\MyFiles";
            
             // FileInfo fi = new FileInfo(path);
              DirectoryInfo di = new DirectoryInfo(path);
                FileInfo[] fiArr = di.GetFiles();
                Console.WriteLine("The directory {0} contains the following files:", di.Name);
                foreach (FileInfo f in fiArr)
                    Console.WriteLine("The size of {0} is {1} bytes.", f.Name, f.Length);
            
                int count = Directory.EnumerateFiles(path).Count();

               Console.WriteLine(count);*/

         }

        private void GetIntoSubDirectroies() {
            string mainDir = "C:\\Users\\Aaliya Sheikh\\MyFiles";
            string[] subDirectories=Directory.GetDirectories(mainDir);
            foreach (string subDir in subDirectories)
            {
                LoadSubDirs(subDir);
                getFilesInDir(subDir);
            }   
        }

        private void LoadSubDirs(string dir)
        {
            Console.WriteLine(dir);
            string[] subDirectories = Directory.GetDirectories(dir);
            foreach (string subDir in subDirectories)
            {
                LoadSubDirs(subDir);
                getFilesInDir (subDir);
            }

            
        }

        public void getFilesInDir(string dir) { 
             String[] filesInDir=Directory.GetFiles(dir);
            foreach (String fileName in filesInDir)
            {
                Console.WriteLine(fileName);
                getAllFilesInfo(fileName);
            }

        }

        public  void getAllFilesInfo(string fileName)
        {
            FileInfo file = new FileInfo(fileName);

            string OnlyFile = file.Name;
            Console.WriteLine("File Name:{0}" ,OnlyFile);

            string extn = file.Extension;
            Console.WriteLine("File Extension:{0}",extn);

            long size = file.Length;
            Console.WriteLine("File size in Bytes: {0}",size);
            int count = Directory.EnumerateFiles(path).Count();

            Console.WriteLine(count);

            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            List<string> list = new List<string>();
            list.Add(OnlyFile);
            list.Add(extn);
            list.Add(size.ToString());
            dictionary.Add(extn,new List<string>());
            




        }
        
            
    }   
}
