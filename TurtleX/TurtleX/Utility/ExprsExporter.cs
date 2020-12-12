using System;
using System.Collections.Generic;
using System.IO;

namespace TurtleX.Utility
{
    public class ExprsExporter
    {
        private String path;
        private List<String> exprs;

        public ExprsExporter(String path, List<String> exprs)
        {
            this.path = path;
            this.exprs = exprs;
        }

        public Boolean export()
        {
            try
            {
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(path))
                {
                    foreach (String expr in exprs)
                    {
                        file.WriteLine(expr);
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}