//19011768

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem19011768
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnReplaceBooks_Click(object sender, EventArgs e)
        {

            //<-----------------Code Attribution------------------
            //Code obtained from : https://stackoverflow.com/questions/3965043/how-to-open-a-new-form-from-another-form

            frmReplaceBooks frmRB = new frmReplaceBooks();
            this.Hide();
            frmRB.ShowDialog();
            this.Close();

            //<-------------End of Code Attribution------------->

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
