﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook (string name, bool isWeight) : base(name, isWeight)
        {
            Type = Enums.GradeBookType.Standard;
        }

    }
}
