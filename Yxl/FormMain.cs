using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Yxl.GitPush
{
    /// <summary>
    /// 主窗体
    /// </summary>
    public partial class FormMain : Form
    {
        #region 字段
        /// <summary>
        /// 仓库 内存表
        /// </summary>
        private DataTable dtRepo=new DataTable();

        /// <summary>
        /// 提交 内存表
        /// </summary>
        private DataTable dtCommit=new DataTable();
        #endregion

        #region 构造方法
        /// <summary>
        /// 主窗体 构造方法
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }
        #endregion


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
