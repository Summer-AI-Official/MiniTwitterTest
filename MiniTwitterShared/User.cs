﻿using System.Collections.Generic;

namespace MiniTwitterShared
{
    public class User
    {
        public string Name { get; set; }
        public List<string> PeopleThisUserFollows { get; set; }
    }
}
