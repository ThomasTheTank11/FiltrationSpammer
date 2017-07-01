using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltrationSpammer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!spambw.IsBusy)
            {
                spambw.RunWorkerAsync();
            }
            else
            {
                spambw.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            runSpammer();
        }

        private void runSpammer()
        {
            Spammer spammer = new Spammer();
            spammer.StatusTextChanged += (sender, text) =>
            {
                status.Text = text;
            };
            spammer.Main(phonenumber.Text);
        }
    }
}
