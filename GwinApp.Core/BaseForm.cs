using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GApp.Win
{
    public class BaseForm : MetroSetForm, IBaseForm
    {

        public BaseForm()
        {
            this.InitializeComponent();
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
