using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lowdb
{
    public class FileSync
    {
        public string PathFile { get; set; }
        Encoding enc = Encoding.UTF8;


        public FileSync(string pathFile)
        {
            PathFile = Path.Combine(Directory.GetCurrentDirectory(), pathFile);
        }

        public FileSync(string pathFile, Encoding en)
        {
            PathFile = Path.Combine(Directory.GetCurrentDirectory(), pathFile);
            enc = en;
        }

        public string read()
        {
            string sData = "{}";

            try
            {

                if (File.Exists(PathFile))
                    sData = System.IO.File.ReadAllText(PathFile);
                else
                    System.IO.File.WriteAllText(PathFile, "{}", Encoding.UTF8);
            }
            catch
            {}

            return sData;
        }

        public bool write(string data)
        {
            bool res = false;

            try
            {
                System.IO.File.WriteAllText(PathFile, data, enc);
                res = true;
            }
            catch
            { }

            return res;
        }

    }

}
