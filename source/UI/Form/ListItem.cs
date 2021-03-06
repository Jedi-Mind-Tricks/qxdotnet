﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// A item for a list. Could be added to all List like widgets but also
    /// to the {@link qx.ui.form.SelectBox} and {@link qx.ui.form.ComboBox}.
    /// 
    /// </summary>
    public partial class ListItem : qxDotNet.UI.Basic.Atom, qxDotNet.UI.Form.IModel
    {

//TODO: private _var _model = null;



        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.ListItem";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

            if (Action != null)
            {
                state.SetEvent("action", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "action")
            {
                OnAction();
            }
        }

        /// <summary>
        /// Raises event 'Action'
        /// </summary>
        protected virtual void OnAction()
        {
            if (Action != null)
            {
                Action.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// (Fired by {@link qx.ui.form.List})
        /// 
        /// </summary>
        public event EventHandler Action;

        /// <summary>
        /// Raises event 'ChangeModel'
        /// </summary>
        protected virtual void OnChangeModel()
        {
            if (ChangeModel != null)
            {
                ChangeModel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #model}.
        /// </summary>
        public event EventHandler ChangeModel;

    }
}
