using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETL_Manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelSubmenuExecution.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubmenuExecution.Visible == true)
                panelSubmenuExecution.Visible=false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible=true;
            }
            else
                subMenu.Visible=false;

        }

        private void btnExecution_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuExecution);

        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            // code
            openChildForm(new FormLogs());
            hideSubMenu();
        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            // code
            openChildForm(new FormConfig());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // code
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close(); 
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;   
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
