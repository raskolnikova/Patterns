﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
   public abstract class AbstractFactory
   {
      public abstract IShape GetShape();
   }
}
