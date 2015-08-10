using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolBatch
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void 官网HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开软件主页
            System.Diagnostics.Process.Start("http://soft.wanyor.com/windows/coolbatch/");
        }

        private void 帮助手册MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //查看软件手册
            System.Diagnostics.Process.Start("EXPLORER.EXE", "Manual.pdf");
        }
    }
}
