using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yxl.Data;

namespace Yxl.GitPush
{
    public partial class Form1 : Form
    {
        private DataTable dt=new DataTable();

        public Form1()
        {
            InitializeComponent();
            dt.AddColumns("sDir","sUrl","iCount");
            dgv.DataSource = dt;
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            /*
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (Path.IsPathRooted(fbd.SelectedPath))
                {

                }
                foreach(string s in System.IO.Directory.EnumerateDirectories(fbd.SelectedPath, "*.git"))
                {

                }
            }*/
            DateTime t = DateTime.Now;
            foreach(DriveInfo di in DriveInfo.GetDrives())
            {
                foreach(DirectoryInfo rdi in di.RootDirectory.GetDirectories())
                {
                    try 
                    {
                        foreach (DirectoryInfo ddi in rdi.GetDirectories("*.git", SearchOption.AllDirectories))
                        {

                        }
                    }
                    catch (UnauthorizedAccessException)
                    {

                    }
                }
            }
            TimeSpan ts = DateTime.Now - t;//00:05:20
        }
    }
}
