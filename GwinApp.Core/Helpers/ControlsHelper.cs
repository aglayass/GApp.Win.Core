using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GApp.Win.EntryForm;
using System.Windows.Forms;

namespace GApp.Win.Helpers
{
    public class ControlsHelper
    {

        public Control mainControl { set; get; }

        public ControlsHelper(Control mainControl)
        {
            this.mainControl = mainControl;
        }

        #region Empty Contols
        /// <summary>
        /// Is All controls in the container is empty
        /// </summary>
        /// <param name="formSaveCancelControl"></param>
        /// <returns></returns>
        //public bool IsControlsEmpty(FormSaveCancelControl formSaveCancelControl)
        //{
        //    throw new NotImplementedException();
        //}
        /// <summary>
        /// Emptu all controls in the form
        /// </summary>
        /// <param name="formSaveCancelControl"></param>
        public void EmptyAllPropertyControls()
        {
            foreach (var item in this.FindAllPropertyControls())
            {
                if (item is TextBox)
                    (item as TextBox).Clear();
                if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = -1;
                if (item is CheckBox)
                    (item as CheckBox).Checked = false;

            }
        }
        #endregion


        #region Find
        /// <summary>
        /// Find All controls in the mainControl
        /// </summary>
        /// <param name="mainControl">The main control</param>
        /// <returns>List of Controls</returns>
        public List<Control> FindAll(Control mainControl)
        {
            List<Control> controlList = new List<Control>();

            foreach (Control c in mainControl.Controls)
            {
                if (c.HasChildren)
                    controlList.AddRange(FindAll(c));
                controlList.Add(c);
            }
            return controlList;
        }
        /// <summary>
        /// Find All Control used to represent a property
        /// </summary>
        /// <returns></returns>
        public List<Control> FindAllPropertyControls()
        {
            return this.FindAll(this.mainControl)
                .Where(c => !(c is Label))
                .Where(c => !(c is Panel))
                .Where(c => !(c is GroupBox))
                .ToList();
        }
        #endregion
    }
}
