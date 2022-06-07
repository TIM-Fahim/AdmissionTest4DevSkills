using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FileUtility
    {
        public void WriteLine(string text)
        {
            string fileName = @"C:\Data.txt";
            FileInfo fi = new FileInfo(fileName);
            using (FileStream fs = fi.Create())
            {
                Byte[] txt = new UTF8Encoding(true).GetBytes("Data.");
                fs.Write(txt, 0, txt.Length);
                Byte[] author = new UTF8Encoding(true).GetBytes(text);
                fs.Write(author, 0, author.Length);
            }
            throw new NotImplementedException();
        }
    }
}
