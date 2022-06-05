using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_5
{
    public partial class Form1 : Form
    {
        public Form1(System.IO.Stream input)
        {
            InitializeComponent();
            
            openFileDialog1.ShowDialog();

        }

    }
}
