using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class SUPER : Form
    {
        public SUPER()
        {
            InitializeComponent();
        }

        private void SUPER_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.AccessControl = false;
        }
    }
}
