﻿using System;
using System.Collections.Generic;
            //LINQ - Language Integrated Query 
            //Query Syntax
            var res = (from i in numbers
            //Method Syntax
            var res1 = numbers.Where(x => x % 2 == 0).Select(x => x);