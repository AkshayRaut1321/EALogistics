using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace ExtraFunctions
{
    class CRunTimeUI
    {
        #region members
        /// <summary>
        /// Any kind of message that needs Operator's attention will be assigned to msg property.
        /// </summary>
        private static string message { get; set; }

        #endregion

        #region methods

        /// <summary>
        /// Temporary method to reduce code, it sets specific color to all matching controls in collection.
        /// </summary>
        /// <param name="ContCol"></param>
        /// <param name="col"></param>
        public static void setBackColor(Control.ControlCollection ContCol, Color col)
        {
            foreach (Control cTemp2 in ContCol)
            {
                if (cTemp2 is Label)
                    cTemp2.BackColor = col;
            }
        }

        /// <summary>
        /// It is an independent method that returns a bool value if any control within specified array has empty text and sets error on all empty controls.
        /// </summary>
        /// <param name="diTemp">Dictionary&lt;Control, ErrorProvider&gt;, a collection that takes mandatory controls of any type as keys and ErrorProviders as values.</param>
        /// <returns></returns>
        public static bool showErrorOnFields(Dictionary<Control, ErrorProvider> diTemp)
        {
            bool ret = false;
            try
            {
                message = "Fill in the required fields";
                foreach (Control cTemp in diTemp.Keys)
                {
                    if (cTemp is TextBox || cTemp is RichTextBox)
                    {
                        if (cTemp.Text == "")
                        {
                            diTemp[cTemp].SetError(cTemp, message);
                            ret = true;
                        }
                        else
                            diTemp[cTemp].Clear();
                    }
                    else if (cTemp is ComboBox)
                    {
                        if ((cTemp as ComboBox).SelectedIndex == 0)
                        {
                            diTemp[cTemp].SetError(cTemp, message);
                            ret = true;
                        }
                    }
                }
                return ret;
            }
            finally
            {
                diTemp = null;
            }
        }

        /// <summary>
        /// Clears Text field of Controls and their corresponding ErrorProvider(s) if any exist.
        /// </summary>
        /// <param name="cc">Collection of controls which need to be cleared.</param>
        /// <param name="diTemp">Dictionary&lt;Control, ErrorProvider&gt;, a collection that takes mandatory controls of any type as keys and ErrorProviders as values.
        /// <para>bool hasEP must be true to iterate through error messages in this collection.</para></param>
        /// <param name="hasEP">bool value indicating whether any ErrorProvider(s) for controls exists.
        /// <para>Set it true to and pass a Dictionary object to clear error messages for compulsory controls.</para></param>
        /// <param name="nested">bool value that allows recursion to go through nested controls such as Panels</param>
        public static void clearFields(System.Windows.Forms.Control.ControlCollection cc, Dictionary<Control, ErrorProvider> diTemp = null, bool hasEP = false, bool nested = false)
        {
            if (!hasEP)
                diTemp = null;
            foreach (Control cTemp in cc)
            {
                if (cTemp is TextBox || cTemp is RichTextBox)
                {
                    cTemp.Text = "";    //  TextChanged event is fired which sets the errorprovider for this control. and again it is cleared below code.
                    if (hasEP && diTemp != null)
                    {
                        if (diTemp.ContainsKey(cTemp))
                            diTemp[cTemp].Clear();
                    }
                }
                else if (cTemp is ComboBox)
                {
                    (cTemp as ComboBox).SelectedIndex = 0;
                }
                else if (nested && cTemp.HasChildren)
                    clearFields(cTemp.Controls, diTemp, hasEP, nested);
            }
        }

        /// <summary>
        /// Prevents user from typing certain keys
        /// </summary>
        public static void restrictKeys(Dictionary<Control, string> diTemp, Control cTemp, KeyPressEventArgs e)
        {
            try
            {
                if (diTemp.ContainsKey(cTemp))
                {
                    if (diTemp[cTemp] == "Int")
                    {
                        if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                        {
                            e.Handled = true;
                        }
                    }
                    else if (diTemp[cTemp] == "Decimal")
                    {
                        if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b' || (cTemp.Text.Contains(e.KeyChar.ToString()) && (e.KeyChar == '.')))
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        if (char.IsDigit(e.KeyChar))
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
            finally
            {
                diTemp = null;
                cTemp = null;
                e = null;
            }
        }

        /// <summary>
        /// It is an independent method that returns a bool value if a control within specified array has empty text.
        /// </summary>
        /// <param name="cc">Collection of controls that needs checking for empty fields.</param>
        /// <returns></returns>
        public static bool getBoolOnEmptyFields(Control.ControlCollection cc, bool onEmpty = true, bool nested = false)
        {
            bool result = false;
            try
            {
                foreach (Control cTemp in cc)
                {
                    if (cTemp is TextBox || cTemp is RichTextBox)
                        if (onEmpty && cTemp.Text == "")
                            return true;
                        else if (!onEmpty && cTemp.Text != "")
                            return true;
                    if (nested && cTemp.HasChildren)
                        result = getBoolOnEmptyFields(cTemp.Controls, onEmpty, nested);
                }
                return result;
            }
            finally
            {
                cc = null;
            }
        }

        /// <summary>
        /// Iterates through a control collection and makes them ReadOnly
        /// </summary>
        /// <param name="controlCollection">The collection of controls in which controls will be made ReadOnly</param>
        public static void makeFieldsReadOnly(System.Windows.Forms.Control.ControlCollection controlCollection)
        {
            try
            {
                foreach (Control cTemp in controlCollection)
                {
                    if (cTemp is TextBox)
                    {
                        TextBox tbTemp = (TextBox)cTemp;
                        tbTemp.ReadOnly = true;
                    }
                }
            }
            finally
            {
                controlCollection = null;
            }
        }

        /// <summary>
        /// a static method that searches for a control in a collection based on its Unique name.
        /// </summary>
        /// <param name="ControlName">Unique Name of the control to be searched</param>
        /// <param name="controlCollection">Collection of Controls in which specific control will be searched</param>
        /// <param name="nested">a flag that indicates whether to look in to the nested Containers</param>
        /// <returns></returns>
        public static Control findControlByName(string ControlName, Control.ControlCollection controlCollection, bool nested = false)
        {
            try
            {
                foreach (Control cTemp in controlCollection)
                {
                    if (cTemp.Name == ControlName)
                        return cTemp;
                    else if (nested && cTemp.HasChildren)
                        return findControlByName(ControlName, cTemp.Controls, nested);
                }
            }
            finally
            {
                controlCollection = null;
            }
            return null;
        }

        public static void enableToolStripItems(bool state, ToolStripItemCollection toolStripItemCollection)
        {
            foreach (ToolStripItem toolStripItem in toolStripItemCollection)
            {
                toolStripItem.Enabled = state;
            }
        }
        #endregion
    }
}