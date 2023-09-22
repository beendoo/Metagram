using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeClient
{
    public partial class alarm : Form
    {
        public alarm()
        {
            InitializeComponent();
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
