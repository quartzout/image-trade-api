﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperImageStore.Models;

public class NeuroImageNotFoundException : Exception
{
    public NeuroImageNotFoundException() { }
    public NeuroImageNotFoundException(string message) : base(message) { }
}