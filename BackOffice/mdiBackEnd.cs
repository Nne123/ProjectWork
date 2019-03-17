using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class mdiBackEnd : Form
    {
        //create an object based on the security class
        clsSecurity Sec = new clsSecurity();
        //create an instance of the main menu form
        frmMenu Menu = new frmMenu();

        private int childFormNumber = 0;
        private object signInToolStripMenuItem;
        private object reSetPasswordToolStripMenuItem;

        public mdiBackEnd()
        {
            InitializeComponent();
        }

        private void mdiBackEnd_Load(object sender, EventArgs e)
        {
            SetLinks(Sec.Authenticated, Sec.Admin);
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
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

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an object based on frmMainAppointment
            frmMainAppointment AppointmentList = new frmMainAppointment();
            // make the object a child of the mdi parent
            AppointmentList.MdiParent = this;
            // make the form visible
            AppointmentList.Visible = true;
        }

        private void signToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a new instance of the sign in form
            frmSignIn Auth = new frmSignIn();
            //show the form as a dialogue i.e. modally
            Auth.ShowDialog();
            //get the state of the security once close
            Sec = Auth.Sec;
            //if security state is authenticated
            if (Sec.Authenticated == true)
            {
                //close the login form
                Auth.Close();
                //ste the menu as a child of this parent
                Menu.MdiParent = this;
                //display the menu
                Menu.Visible = true;
                //set the state of the security links
                SetLinks(Sec.Authenticated, Sec.Admin);
            }
        }

        private void SetLinks(bool authenticated, object admin)
        {
            throw new NotImplementedException();
        }

        private void SetLinks(Boolean Authenticated, Boolean IsAdmin)
        {
            ////sets the enabled state of links based on the authentiaction state and if the user is admin or not
            ////set the login option to the opposite of authentiaction
            //signInToolStripMenuItem.Enabled = !Authenticated;
            ////if the user is authentiacted then enable the following
            //signOutToolStripMenuItem.Enabled = Authenticated;
            //changePasswordToolStripMenuItem.Enabled = Authenticated;
            ////if the user is authenticated and admin then enable the following
            //reSetPasswordToolStripMenuItem.Enabled = Authenticated & IsAdmin;
            //addUserToolStripMenuItem.Enabled = Authenticated & IsAdmin;
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sign out the current user
            //set the main menu to not visible
            Menu.Visible = false;
            //invoke the sign out method
            Sec.SignOut();
            //set the links
            SetLinks(Sec.Authenticated, Sec.Admin);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display the change password form
            frmChangePassword Change = new frmChangePassword();
            //set the mode using a specific user 
            Change.SetMode(Sec, Sec.UserEMail);
            //show the form as a dialogue
            Change.ShowDialog();
            //get the state of the scurity once done
            Sec = Change.Sec;
        }

        private void reSetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //resets the password
            //create a instance of the chnage passord form
            frmChangePassword Change = new frmChangePassword();
            //set the mode to change any user password (admin only)
            Change.SetMode(Sec, "");
            //show the form as a dialogue
            Change.ShowDialog();
            //get the new security state
            Sec = Change.Sec;
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display the adduser page
            frmAddUser Add = new frmAddUser();
            Add.ShowDialog();
        }
    }
}
