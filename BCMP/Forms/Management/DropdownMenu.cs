using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Web.UI.WebControls;

namespace BCMP.Forms.Management
{
    internal class DropdownMenu : ContextMenuStrip
    {
        private bool isMainMenu;
        private int menuItemHeight = 25;
        private Color menuItemTextColor = Color.FromArgb(35, 40, 45);
        private Color primaryColor = Color.Snow;

        private Bitmap menuItemHeaderSize;

        public DropdownMenu(IContainer container)
            : base(container)
        {

        }

        [Browsable(false)]
        public bool IsMainMenu { get => isMainMenu; set => isMainMenu = value; }
        [Browsable(false)]
        public int MenuItemHeight { get => menuItemHeight; set => menuItemHeight = value; }
        [Browsable(false)]
        public Color MenuItemTextColor { get => menuItemTextColor; set => menuItemTextColor = value; }
        [Browsable(false)]
        public Color PrimaryColor { get => primaryColor; set => primaryColor = value; }
    
        private void LoadMenuItemAppearance()
        {
            if (isMainMenu)
            {
                menuItemHeaderSize = new Bitmap(25, 45);
                menuItemTextColor = Color.FromArgb(35, 40, 45);
            } else
            {
                menuItemHeaderSize = new Bitmap(15, menuItemHeight);
            }

            foreach (ToolStripMenuItem menuItemL1 in this.Items)
            {
                menuItemL1.ForeColor = menuItemTextColor;
                menuItemL1.ImageScaling = ToolStripItemImageScaling.None;
                if(menuItemL1.Image == null )
                {
                    menuItemL1.Image = menuItemHeaderSize;
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if(this.DesignMode == false)
            {
                LoadMenuItemAppearance();
                this.Renderer = new MenuRenderer(isMainMenu, primaryColor, menuItemTextColor);
            }
        }
    }
}
