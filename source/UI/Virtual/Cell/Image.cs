﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Cell
{
    /// <summary>
    /// EXPERIMENTAL!
    /// </summary>
    public partial class Image : qxDotNet.UI.Virtual.Cell.AbstractImage
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.cell.Image";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}