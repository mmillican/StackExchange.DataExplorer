﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StackExchange.DataExplorer.ViewModel {
    public class QueryVoting {
        public int TotalVotes { get; set; }
        public bool HasVoted { get; set; }
        public bool ReadOnly { get; set; }
    }
}