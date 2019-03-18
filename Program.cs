using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Namespace IO ekliyoruz.

namespace DirectoryExamples
{
    class DirectoryTest
    {
       static public void Main()
        {
            string path = @"C:\Test\TestDizini";
            string target = @"C:\Test\HedefDizini"; 
            try
            {
                if(!Directory.Exists(target))
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine("Oluşturma Tarihi: " + Directory.GetCreationTime(path));
                    Console.WriteLine("Son Erişim Tarihi: " + Directory.GetLastAccessTime(path));
                    Console.WriteLine("Son Değiştirilme Tarihi: " + Directory.GetLastWriteTime(path));
                    Console.WriteLine("Bulunduğu Dizinin Adı: " + Directory.GetParent(path));
                    Console.ReadLine();
                }
                if(Directory.Exists(target))
                {
                    Directory.Delete(target, true);
                }
                Directory.Move(path, target);
                string[] directories = Directory.GetDirectories(@"C:\Test\");
                foreach(string dir in directories)
                {
                    Console.WriteLine(dir);
                }
                File.CreateText(target + @"\NewFiletxt");
                Console.WriteLine("{0} dizinindeki dosya sayısı: {1}", target, Directory.GetFiles(target));
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("İşlem Başarısız: {0}", e.ToString());
            }
            finally { }
        }
    }
}
