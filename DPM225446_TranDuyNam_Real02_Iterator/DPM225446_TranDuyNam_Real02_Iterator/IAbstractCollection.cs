﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225446_TranDuyNam_Real02_Iterator
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
