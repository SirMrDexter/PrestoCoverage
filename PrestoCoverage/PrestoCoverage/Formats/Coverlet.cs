﻿using System.Collections.Generic;

//Parts of source used from https://github.com/tonerdo/coverlet/blob/master/src/coverlet.core/CoverageResult.cs

namespace Coverlet.Core
{
    public class BranchInfo
    {
        public int Line { get; set; }
        public int Offset { get; set; }
        public int EndOffset { get; set; }
        public int Path { get; set; }
        public uint Ordinal { get; set; }
        public int Hits { get; set; }
    }

    public class Lines : SortedDictionary<int, int> { }

    public class Branches : List<BranchInfo> { }

    public class Method
    {
        internal Method()
        {
            Lines = new Lines();
            Branches = new Branches();
        }
        public Lines Lines;
        public Branches Branches;
    }
    public class Methods : Dictionary<string, Method> { }
    public class Classes : Dictionary<string, Methods> { }
    public class Documents : Dictionary<string, Classes> { }
    public class Modules : Dictionary<string, Documents> { }

}
