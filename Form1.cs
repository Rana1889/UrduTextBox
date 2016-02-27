using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UrduTextBox
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tbxUrdu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            tbxUrdu.RightToLeft = RightToLeft.Yes;
            UrduFun.TypeUrdu(tbxUrdu, e.KeyChar);            
        }
        

    }
}
