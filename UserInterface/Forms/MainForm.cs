using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.UserInterface.Forms.Contracts;
using SystemHR.UserInterface.Forms.Employees;
using SystemHR.UserInterface.Helpers;

namespace SystemHRUserInterface.Forms
{
    public partial class MainForm : Form
    {
        #region Fields

        

        private TabPage _tpEmpolyees;

        private TabPage _tpContract;

        #endregion
        #region Ctor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion
        #region Events

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            if (EmployeesForm.isNull)
            {
                _tpEmpolyees = new TabPage();
                ShowFormInTapPage(_tpEmpolyees, EmployeesForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpEmpolyees;
            }
        }

        private void btnContract_Click(object sender, EventArgs e)
        {

            if (ContractsForm.isNull)
            {
                _tpContract = new TabPage();
                ShowFormInTapPage(_tpContract, ContractsForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpContract;
            }
        }

        private void tcTabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.tcTabs.TabPages[e.Index];
                var tabRect = this.tcTabs.GetTabRect(e.Index);

                var closeImage = new Bitmap($"{ResourceHelper.ResourceFilePath}\\{ResourceHelper.closeButtonName}");

                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                     tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                tabRect, tabPage.ForeColor, TextFormatFlags.Left);
                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void tcTabs_MouseDown(object sender, MouseEventArgs e)
        {
            // Process MouseDown event only till (tabControl.TabPages.Count - 1) excluding the last TabPage
            for (var i = 0; i < this.tcTabs.TabPages.Count; i++)
            {
                var tabRect = this.tcTabs.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap($"{ResourceHelper.ResourceFilePath}\\{ResourceHelper.closeButtonName}");
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    var frm = tcTabs.TabPages[i].Controls[0] as Form;
                    frm.Close();

                    this.tcTabs.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        #endregion
        #region Private Methods

        private void ShowFormInTapPage(TabPage tpTab, Form frm)
        {
            tcTabs.Controls.Add(tpTab);

            tpTab.Text = frm.Text;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tpTab.Controls.Add(frm);
            tcTabs.SelectedTab = tpTab;
        }
        #endregion
    }
}
