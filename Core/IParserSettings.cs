﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Parser.Core
{
    interface IParserSettings
    {
        string BaseUrl { get; set; }
        string Prefix { get; set; }
        int StartPoint { get; set; }
        int EndPoint { get; set; }

    }
}
