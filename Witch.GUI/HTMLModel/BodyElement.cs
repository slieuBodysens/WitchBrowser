﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Witch.GUI.Model;

namespace Witch.GUI.HTMLModel
{
    class BodyElement : IHTMLControl
    {
        public override string ToString()
        {
            return "BODY";
        }
    }
}