﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Menu
{
    /// <summary>
    /// Renders a special radio button inside a menu. The button behaves like a normal {@link qx.ui.form.RadioButton} and shows a radio icon when checked; normally shows no icon when not checked (depends on the theme).
    /// </summary>
    public partial class RadioButton : qxDotNet.UI.Menu.AbstractButton, qxDotNet.UI.Form.IRadioItem, qxDotNet.UI.Form.IBooleanForm, qxDotNet.UI.Form.IModel
    {

        private qxDotNet.UI.Form.RadioGroup _group = null;
        private bool? _value = false;
//        private _var _model = null;


        /// <summary>
        /// The assigned qx.ui.form.RadioGroup which handles the switching between registered buttons
        /// </summary>
        public qxDotNet.UI.Form.RadioGroup Group
        {
            get
            {
                return _group;
            }
            set
            {
               _group = value;
            }
        }

        /// <summary>
        /// The value of the widget. True, if the widget is checked.
        /// </summary>
        public bool? Value
        {
            get
            {
                return _value;
            }
            set
            {
               _value = value;
               OnChangeValue();
            }
        }


        public override string GetTypeName()
        {
            return "qx.ui.menu.RadioButton";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("group", _group, null);
            state.SetPropertyValue("value", _value, false);

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeValue()
        {
            if (ChangeValue != null)
            {
                ChangeValue.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #value}.
        /// </summary>
        public event EventHandler ChangeValue;

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