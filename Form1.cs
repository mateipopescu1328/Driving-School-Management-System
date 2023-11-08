using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_School
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            costumizeDesign();
        }

        private void costumizeDesign()
        {
            panel_elevsubmenu.Visible = false;
            panel_sedintasubmenu.Visible = false;
            panel_instructorsubmenu.Visible = false;

        }

        private void hideSubmenu()
        {
            if (panel_elevsubmenu.Visible == true)
                 panel_elevsubmenu.Visible = false;
            if (panel_sedintasubmenu.Visible == true)
                panel_sedintasubmenu.Visible = false;
            if (panel_instructorsubmenu.Visible == true)
                panel_instructorsubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu) 
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        #region Elevi

        private void button_elevi_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_elevsubmenu);
        }

        private void inregistrare_elevi_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void modificare_elevi_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void afisare_elevi_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        #endregion Elevi
        #region Sedinte

        private void button_sedinte_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_sedintasubmenu);
        }

        private void inregistrare_sedinte_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void modificare_sedinte_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void afisare_sedinte_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        #endregion Sedinte
        #region Instructori
        private void button_instructori_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_instructorsubmenu);
        }

        private void inregistrare_instructori_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void modificarere_instructori_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void afisare_instructori_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        #endregion Instructori
    }
}
