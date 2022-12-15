﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperImageStore.Models;

public class TimespanSegments
{
    public TimespanSegments(TimeSpan timespan)
    {
        Days = timespan.Days;
        Hours = timespan.Hours;
        Minutes = timespan.Minutes;
        Seconds = timespan.Seconds;
    }

    public int Days { get; set; }
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }



}
