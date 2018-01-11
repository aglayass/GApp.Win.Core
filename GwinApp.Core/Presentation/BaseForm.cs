
using GwinApp.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GwinApp.Presentation
{
    public class BaseForm :GForm, IBaseForm
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(623, 324);
            this.Name = "BaseForm";
            this.ResumeLayout(false);

        }
    }
}
