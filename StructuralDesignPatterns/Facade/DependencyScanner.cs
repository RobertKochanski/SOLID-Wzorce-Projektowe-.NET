﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class DependencyScanner
    {
        public IEnumerable<string> DependencyScan(string gitHubUrl)
        {
            Console.WriteLine("Dependency scan");

            return new List<string>() { "DependencyScan Error1"};
        }
    }
}
