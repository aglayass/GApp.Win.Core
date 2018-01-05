
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GwinApp
{
    public class BaseForm :MetroFramework.Forms.MetroForm, IBaseForm
    {

        public BaseForm()
        {
            
        }

        /// <summary>
        /// Reload the form after language change
        /// </summary>
       public virtual void Reload() { }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(433, 284);
            this.Name = "BaseForm";
            this.ResumeLayout(false);

        }
    }
}
