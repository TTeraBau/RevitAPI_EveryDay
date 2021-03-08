﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Library;
using Application = Autodesk.Revit.ApplicationServices.Application;

namespace RevitAPIEveryDay
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    [Journaling(JournalingMode.UsingCommandData)]
    public class _Template : RevitCommand
    {
        public override void Action()
        {
            //do some thing
        }
    }
}
