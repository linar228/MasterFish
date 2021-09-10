using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterFish
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["Form1"];
            ListBox lst = (ListBox)frm.Controls["Fish"];
            lst.Items.Add(FishName.Text);
            this.Close();
        }
    }
}
