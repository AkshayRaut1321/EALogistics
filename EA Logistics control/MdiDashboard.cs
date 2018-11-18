using System;
using System.Drawing;
using System.Windows.Forms;
using EA_Logistics_Control.Models;
using ExtraFunctions;

namespace EA_Logistics_Control
{
    public partial class MdiDashboard : Form
    {
        #region private members
        private CUserInfo _userInfo = new CUserInfo();
        #endregion

        #region properties
        internal CUserInfo UserInfo
        {
            get
            {
                return _userInfo;
            }
        }
        #endregion

        #region custom methods
        private void ResetForm()
        {
            this.WindowState = FormWindowState.Maximized;
            statusStrip.ForeColor = Color.White;
            SetNotification("Ready", NotificationPriority.Ready);
            CRunTimeUI.enableToolStripItems(false, menuStrip.Items);
            CRunTimeUI.enableToolStripItems(false, toolStrip.Items);
            loginToolStripMenuItem.Enabled = true;
            loginToolStripMenuItem.Text = "Login";
            showLogin();
        }

        private void showLogin()
        {
            FormLogin fl = new FormLogin();
            fl.MdiParent = this;
            fl.Show();
            fl.StartPosition = FormStartPosition.CenterScreen;
        }

        internal void CheckSession()
        {
            if (UserInfo.IsActive)
            {
                this.ActiveMdiChild.Close();
                CRunTimeUI.enableToolStripItems(true, MainMenuStrip.Items);
                CRunTimeUI.enableToolStripItems(true, toolStrip.Items);
                loginToolStripMenuItem.Text = "Logout";
            }
        }

        /// <summary>
        /// Sets notification messages on status strip of a form. It takes a message and priority as parameters
        /// </summary>
        /// <param name="message"></param>
        /// <param name="notify"></param>
        public void SetNotification(string message, NotificationPriority notify)
        {
            if (notify == NotificationPriority.Success)
            {
                statusStrip.BackColor = Color.DodgerBlue;
            }
            else if (notify == NotificationPriority.Failure)
            {
                statusStrip.BackColor = Color.Red;
            }
            else if (notify == NotificationPriority.Ready)
            {
                statusStrip.BackColor = Color.Green;
            }
            else if (notify == NotificationPriority.Waiting)
            {
                statusStrip.BackColor = Color.Orange;
            }
            toolStripStatusLabel.Text = message;
        }
        #endregion

        #region event handling
        public MdiDashboard()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //  implement code to show templates of Consignment or Bill
        }

        private void OpenFile(object sender, EventArgs e)
        {
            //  implement code to show existing Consignment or Bill data templates
            //  if user selects to open a doc file execute following code.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void viewConsignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                FormViewConsignments f = new FormViewConsignments();
                f.MdiParent = this;
                f.Show();
                f.WindowState = FormWindowState.Maximized;
            }
        }

        private void viewBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                FormViewBills f = new FormViewBills();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void newConsignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                FormNewConsignment f = new FormNewConsignment();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void newBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                SetNotification("Loading form for new Bill", NotificationPriority.Waiting);
                System.Threading.Thread.Sleep(500);
                FormNewBill f = new FormNewBill();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
                SetNotification("New Bill form loaded", NotificationPriority.Ready);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FormNewConsignment)
            {
                (this.ActiveMdiChild as FormNewConsignment).Save();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                _userInfo.ResetObject();
                ResetForm();
            }
        }
        #endregion
    }
}
