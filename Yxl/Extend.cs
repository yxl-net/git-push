using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Yxl
{
    /// <summary>
    /// 扩展静态类
    /// </summary>
    static class Extend
    {
        #region DataGridView
        /// <summary>
        /// 表格 加载
        /// </summary>
        /// <param name="dgv">表格 扩展对象</param>
        /// <param name="tsiCount">行数工具栏项</param>
        /// <returns>绑定的内存行</returns>
        internal static DataTable Load(this DataGridView dgv, ToolStripItem tsiCount)
        {
            dgv.AutoGenerateColumns = false;//不自动生成列
            dgv.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(dgv, true);//双缓冲
            DataTable dt = new DataTable();//创捷内存表
            foreach(DataGridViewColumn col in dgv.Columns)//遍历表格列集
            {
                dt.Columns.Add(col.DataPropertyName);//添加列字段
            }
            dt.DefaultView.ListChanged += (o, x) => tsiCount.Text = (o as DataView).Count.ToString();//内存行数变动
            dgv.DataSource = dt;//绑定
            dgv.CellMouseDoubleClick +=dgv_CellMouseDoubleClick;//鼠标双击单元格句柄
            return dt;//返回内存表
        }

        /// <summary>
        /// 鼠标双击表格单元格 句柄
        /// </summary>
        /// <param name="o">控件</param>
        /// <param name="x">事件参数</param>
        static void dgv_CellMouseDoubleClick(object o,DataGridViewCellMouseEventArgs x)
        {
            if (x.RowIndex == -1)//列头
            {
                string k = (o as DataGridView).Columns[x.ColumnIndex].DataPropertyName;//字段名
                DataView dv = ((o as DataGridView).DataSource as DataTable).DefaultView;//内存视图
                if (k != "")//有字段名
                {
                    if (dv.Sort.StartsWith(k))//已排过序
                    {
                        if (dv.Sort.EndsWith("asc"))//原来是升序
                        {
                            dv.Sort = $"{k} desc";//降序
                        }
                        else//原来是降序
                        {
                            dv.Sort = $"{k} asc";//升序
                        }
                    }
                    else//未排过序
                    {
                        dv.Sort = $"{k} asc";//升序
                    }
                }
            }
        }

        /// <summary>
        /// 表格 打开数据 
        /// </summary>
        /// <param name="dgv">表格 扩展对象</param>
        /// <param name="sFileName">文件名 默认"yxl"</param>
        internal static void Open(this DataGridView dgv,string sFileName="yxl")
        {
            if (File.Exists(dgv.AccessibleDescription=sFileName))//文件名赋值 文件存在
            {
                DataTable dt = dgv.DataSource as DataTable;//绑定内存表
                foreach(string line in File.ReadAllText(sFileName).Split('\x1E'))//打开和遍历文件内容 记录分隔
                {
                    if (line != "")//无分隔符不添加
                    {
                        dt.Rows.Add(line.Split('\x1F'));//遍历行 字段分隔
                    }
                }
            }
        }
      
        /// <summary>
        /// 表格 保存数据 
        /// </summary>
        /// <param name="dgv">表格 扩展对象</param>
        internal static void Save(this DataGridView dgv)
        {
            StringBuilder sb = new StringBuilder();//可变文本
            foreach(DataRow dr in (dgv.DataSource as DataTable).Rows)//绑定内存表行
            {
                sb.Append($"{String.Join("\x1F", dr.ItemArray)}\x1E");//添加字段连接行
            }
            File.WriteAllText(dgv.AccessibleDescription, sb.ToString().TrimEnd('\x1E'));//移除末尾记录分隔符 保存文件
        }

        /// <summary>
        /// 表格 复制当前单元格值
        /// </summary>
        /// <param name="dgv">表格 扩展对象</param>
        internal static void Copy(this DataGridView dgv)
        {
            try//有异常
            {
                if (dgv.CurrentCell != null)//有当前单元格
                {
                    Clipboard.SetText(Convert.ToString(dgv.CurrentCell.Value));//当前单元格值到剪贴板
                }
            }
            catch//不报错
            {
            }
        }

        /// <summary>
        /// 表格 当前单元格粘贴值
        /// </summary>
        /// <param name="dgv">表格 扩展对象</param>
        internal static void Paste(this DataGridView dgv)
        {
            try//有异常
            {
                if (dgv.CurrentCell != null)//有当前单元格
                {
                    dgv.CurrentCell.Value = Clipboard.GetText().Trim();//剪贴板值到当前单元格
                    dgv.Save();//表格 保存数据
                }
            }
            catch//不报错
            {
            }
        }

        /// <summary>
        /// 表格 添加行
        /// </summary>
        /// <param name="dgv">表格 扩展对象</param>
        /// <param name="aValue">值 可变数组</param>
        internal static void Add(this DataGridView dgv,params object[] aValue)
        {
            DataTable dt = dgv.DataSource as DataTable;//绑定内存表
            if (aValue.Length == 0)//未提供值
            {
                if (dgv.CurrentRow == null)//有当前行
                {
                    dt.Rows.Add();//添加空行
                }
                else//无当前行
                {
                    dt.Rows.Add((dgv.CurrentRow.DataBoundItem as DataRowView).Row.ItemArray);//添加当前行数值值
                }
            }
            else//提供值
            {
                dt.Rows.Add(aValue);//按值添加行
            }
            dgv.Save();//表格 保存数据
        }


        /// <summary>
        /// 表格 移除当前行
        /// </summary>
        /// <param name="dgv">表格 扩展对象</param>
        internal static void Remove(this DataGridView dgv)
        {
            if (MessageBox.Show("确定删除吗？", "确认框", MessageBoxButtons.OKCancel) == DialogResult.OK)//弹出确认框
            {
                dgv.Rows.Remove(dgv.CurrentRow);//数据表格 移除当前行
                dgv.Save();//表格 保存数据
                if (dgv.Rows.Count > 0)//还有行
                {
                    dgv.CurrentCell = dgv.Rows[dgv.RowCount - 1].Cells[0];//选中最后行首单元格
                }
            }
        }

        /// <summary>
        /// 表格 填充过滤菜单项
        /// </summary>
        /// <param name="dgv">表格 扩展对象</param>
        /// <param name="cms">菜单</param>
        /// <param name="iCol">列序号</param>
        internal static void Fill(this DataGridView dgv,ContextMenuStrip cms,int iCol)
        {
            string sField = dgv.Columns[iCol].DataPropertyName;//序号对应列字段
            foreach (DataRow dr in new DataView(dgv.DataSource as DataTable).ToTable(true, sField).Rows)//遍历绑定内存表唯一列值
            {
                cms.Items.Add(Convert.ToString(dr[0]), null, (o, x) => { dgv.Filter((o as ToolStripItem).AccessibleDescription);dgv.Save(); }).AccessibleDescription=$"{sField}='{dr[0]}'";//添加菜单 列值,图标,过滤并保存 按文本过滤列值
            }
        }

        /// <summary>
        /// 表格 填充设置当前单元格值菜单项
        /// </summary>
        /// <param name="dgv">表格 扩展对象</param>
        /// <param name="cms">菜单</param>
        internal static void Fill(this DataGridView dgv,ContextMenuStrip cms)
        {
            foreach (DataRow dr in new DataView(dgv.DataSource as DataTable).ToTable(true, dgv.CurrentCell.OwningColumn.DataPropertyName).Rows)//遍历绑定内存表行
            {
                cms.Items.Add(Convert.ToString(dr[0]), null, (o, x) => { dgv.CurrentCell.Value = (o as ToolStripItem).Text;dgv.Save();});//添加菜单 列值,图标,设置值并保存 按文本过滤列值
            }
        }

        /// <summary>
        /// 表格 过滤
        /// </summary>
        /// <param name="dgv">表格 扩展对象</param>
        /// <param name="sFormat">格式串 {0}为过滤文本</param>
        /// <param name="sText">过滤文本 清除首尾空格</param>
        internal static void Filter(this DataGridView dgv, string sFormat = "", string sText = "")
        {
            (dgv.DataSource as DataTable).DefaultView.RowFilter = String.Format(sFormat, sText.Trim().Replace("%", "[%]").Replace("*", "[*]").Replace("[", "[[]").Replace("'", "''"));//绑定内存表默认视图筛选表达式 过滤文本替换单引号和元字符
        }
        #endregion
    }
}
