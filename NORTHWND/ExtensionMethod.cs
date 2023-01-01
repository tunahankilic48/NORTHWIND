using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWND
{
    internal static class ExtensionMethod
    {
        public static void CleanTheControls(Form from)
        {
            foreach (Control control in from.Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control control1 in control.Controls)
                    {
                        if (control1 is TextBox)
                        {
                            ((TextBox)control1).Clear();
                        }
                        else if (control1 is DateTimePicker)
                        {
                            ((DateTimePicker)control1).Value = DateTime.Now;
                        }
                        else if (control1 is ComboBox)
                        {
                            ((ComboBox)control1).SelectedIndex = 0;
                        }
                    }
                }
            }
        }
    }
}
