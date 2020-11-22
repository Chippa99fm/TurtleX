using System;
using System.Collections.Generic;

namespace TurtleX.ParsersX
{
    public class Enviroment
    {
        private Dictionary<String, double> variables = new Dictionary<String, double>();
        private static Enviroment instance;

        public static Enviroment getInstance()
        {
            if (instance == null)
            {
                instance = new Enviroment();
            }

            return instance;
        }

        public Dictionary<String, double> getVariables()
        {
            return variables;
        }
    }
}