using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiltrationSpammer.Properties;

namespace FiltrationSpammer
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            authtoken.Text = core.authToken;
            accountid.Text = core.accountID;
            spammessage.Text = core.spamMessage;

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savesettings_Click(object sender, EventArgs e)
        {
            core.authToken = authtoken.Text;
            core.accountID = accountid.Text;
            core.spamMessage = spammessage.Text;
            Settings.Default.Save();
            status.ForeColor = System.Drawing.Color.Green;
            status.Text = "Saved Settings";
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }
    }
}
