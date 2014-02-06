﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form.Renderer
{
    /// <summary>
    /// Abstract renderer for {@link qx.ui.form.Form}. This abstract renderer should be the superclass of all form renderer. It takes the form, which is supplied as constructor parameter and configures itself. So if you need to set some additional information on your renderer before adding the widgets, be sure to do that before calling this.base(arguments, form).
    /// </summary>
    public abstract partial class AbstractRenderer : qxDotNet.UI.Core.Widget, qxDotNet.UI.Form.Renderer.IFormRenderer
    {


        
        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.renderer.AbstractRenderer";
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
