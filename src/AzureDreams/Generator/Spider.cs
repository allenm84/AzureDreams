﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AzureDreams
{
  public class Spider
  {
    public bool Dead { get; set; }
    public Stack<Index> Path { get; set; }
  }
}
