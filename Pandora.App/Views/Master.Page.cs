using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Pandora.App.Views
{
    public partial class Master : Form
    {
        #region Props
        private IconButton current;
        private Panel border;
        private struct Palette
        {
            public static Color defaultButtonBackgroud = Color.FromArgb(255, 255, 255);
            public static Color activeButtonBackgroud = Color.FromArgb(225, 075, 070);
            public static Color defaultButtonForeColor = Color.FromArgb(035, 045, 055);
            public static Color activeButtonForeColor = Color.FromArgb(245, 245, 245);
            public static Color borderButtonColor = Color.FromArgb(175, 050, 050);
        }
        #endregion

        public Master()
        {
            InitializeComponent();
            border = new Panel();
            border.Size = new Size(10, 70);
            panelMenu.Controls.Add(border);
        }

        #region Methods
        private void ActivateButton(object sender)
        {
            if(sender != null)
            {
                DisableButton();
                current = (IconButton)sender;
                current.BackColor = Palette.activeButtonBackgroud;
                current.ForeColor = Palette.activeButtonForeColor;
                current.IconColor = Palette.activeButtonForeColor;
                current.TextAlign = ContentAlignment.MiddleCenter;
                current.TextImageRelation = TextImageRelation.TextBeforeImage;
                current.ImageAlign = ContentAlignment.MiddleRight;

                //border
                border.BackColor = Palette.borderButtonColor;
                border.Location  = new Point(0, current.Location.Y);
                border.Visible   = true;
                border.BringToFront();
            }
        }

        private void DisableButton()
        { 
            if(current != null)
            {
                //Define original settings
                current.BackColor = Palette.defaultButtonBackgroud;
                current.ForeColor = Palette.defaultButtonForeColor;
                current.IconColor = Palette.defaultButtonForeColor;
                current.TextAlign = ContentAlignment.MiddleCenter;
                current.TextImageRelation = TextImageRelation.ImageBeforeText;
                current.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        #endregion

        #region Buttons
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void btnVehicle_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void btnEntries_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        #endregion
    }
}
