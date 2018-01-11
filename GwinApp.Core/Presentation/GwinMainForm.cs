using GwinApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GwinApp.Presentation
{
    public class GwinMainForm : GForm
    {
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage1;
        public GTab GTabControl;

        private void InitializeComponent()
        {
            this.GTabControl = new  GTab();
            this.metroSetTabPage1 = new MetroSet_UI.Child.MetroSetTabPage();
            this.GTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // GTabControl
            // 
            this.GTabControl.Controls.Add(this.metroSetTabPage1);
            this.GTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GTabControl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.GTabControl.ItemSize = new System.Drawing.Size(100, 38);
            this.GTabControl.Location = new System.Drawing.Point(12, 90);
            this.GTabControl.Name = "GTabControl";
            this.GTabControl.SelectedIndex = 0;
            this.GTabControl.Size = new System.Drawing.Size(702, 244);
            this.GTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.GTabControl.Speed = 20;
            this.GTabControl.Style = MetroSet_UI.Design.Style.Light;
            this.GTabControl.StyleManager = null;
            this.GTabControl.TabIndex = 1;
            this.GTabControl.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.GTabControl.ThemeAuthor = "Narwin";
            this.GTabControl.ThemeName = "MetroLite";
            this.GTabControl.UseAnimation = true;
            // 
            // metroSetTabPage1
            // 
            this.metroSetTabPage1.BaseColor = System.Drawing.Color.White;
            this.metroSetTabPage1.ImageIndex = 0;
            this.metroSetTabPage1.ImageKey = null;
            this.metroSetTabPage1.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage1.Name = "metroSetTabPage1";
            this.metroSetTabPage1.Size = new System.Drawing.Size(694, 198);
            this.metroSetTabPage1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabPage1.StyleManager = null;
            this.metroSetTabPage1.TabIndex = 0;
            this.metroSetTabPage1.Text = "metroSetTabPage1";
            this.metroSetTabPage1.ThemeAuthor = "Narwin";
            this.metroSetTabPage1.ThemeName = "MetroLite";
            this.metroSetTabPage1.ToolTipText = null;
            // 
            // GMainForm
            // 
            this.ClientSize = new System.Drawing.Size(726, 346);
            this.Controls.Add(this.GTabControl);
            this.Name = "GMainForm";
            this.Controls.SetChildIndex(this.GTabControl, 0);
            this.GTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
