﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Enums
{
    /// <summary>
    /// Period value used to specify time frame for clips.
    /// </summary>
    public enum Period
    {
        /// <summary>Represents a single day.</summary>
        Day,
        /// <summary>Represents a single week.</summary>
        Week,
        /// <summary>Represents a single month.</summary>
        Month,
        /// <summary>Represents a all time frames.</summary>
        All
    }
}
