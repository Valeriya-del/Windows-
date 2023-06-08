using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using System.Windows.Forms;

namespace Windowsпроб
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void StudentsButton_Click(object sender, EventArgs e)
        {
            StudentsForm form = new StudentsForm();
            form.Show();

        }
    }
}
