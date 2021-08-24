using System;
using System.IO;
namespace day8tp.Filehandling
{
    public class FileHandel
    {
        public void WriteToFile(string name)
        {
            FileStream f = new FileStream("Tarining.txt",FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(f);
            streamWriter.WriteLine(name);
            streamWriter.Close(); // first close stram writer
            f.Close(); // then close file
        }
        public void ReadFromfile()
        {
            FileStream f = new FileStream("Tarining.txt",FileMode.Open);
            StreamReader r = new StreamReader(f);
            string s = r.ReadLine();
            f.Close();
            r.Close();
            Console.WriteLine(s);
        }
    }
}