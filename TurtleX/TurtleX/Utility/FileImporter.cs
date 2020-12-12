using System;
using System.Collections.Generic;

namespace TurtleX.Utility
{
    public class FileImporter
    {
        private String path;
        public List<String> exprs { get; set; }

        public FileImporter(String path)
        {
            this.path = path;
        }

        public Boolean import()
        {
            exprs = new List<string>();
            String line;
            using (System.IO.StreamReader file =
                new System.IO.StreamReader(path))
            {
                while((line = file.ReadLine()) != null)  
                {  
                    exprs.Add(line);
                }  
            }

            return true;
        }
    }
}