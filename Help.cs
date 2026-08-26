using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TawandaSystem
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LogIn form = new LogIn();
                form.ShowDialog();
                this.Close();
            }

            
        }
    }
}
