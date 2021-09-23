using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Yxl.Data
{
    public static class DataTableExtend
    {
        public static void AddColumns(this DataTable dt,params string[] names)
        {
            foreach (string name in names)
            {
                switch(name.Substring(0,1).ToLower())
                {
                    case "u":
                        dt.Columns.Add(name, Type.GetType("System.UInt16"));
                        break;
                    case "i":
                        dt.Columns.Add(name, Type.GetType("System.Int32"));
                        break;
                    case "l":
                        dt.Columns.Add(name, Type.GetType("System.Int64"));
                        break;
                    case "d":
                    case "t":
                        dt.Columns.Add(name, Type.GetType("System.DateTime"));
                        break;
                    case "f":
                        dt.Columns.Add(name, Type.GetType("System.Double"));
                        break;
                    case "m":
                        dt.Columns.Add(name, Type.GetType("System.Decimal"));
                        break;
                    case "b":
                        dt.Columns.Add(name, Type.GetType("System.Boolean"));
                        break;
                    case "c":
                        dt.Columns.Add(name, Type.GetType("System.Char"));
                        break;
                    default:
                        dt.Columns.Add(name);
                        break;
                }
            }
        }

        public static void Save(this DataTable dt, string path)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((char)dt.Rows.Count);
            object v;
            foreach(DataRow dr in dt.Rows)
            {
                foreach(DataColumn dc in dt.Columns)
                {
                    v = dr[dc.Ordinal];
                    switch(dc.ColumnName.Substring(0, 1).ToLower())
                    {
                        case "u":
                        case "c":
                            sb.Append((char)Convert.ToUInt16(v));
                            break;
                        case "b":
                            sb.Append(Convert.ToBoolean(v)?"t":"f");
                            break;
                        case "i":
                            long i=Convert.ToInt32(v)+2147483648;
                            sb.Append((char)(i/65536));
                            sb.Append((char)(i%65536));
                            break;
                        case "l":
                            ulong l=(ulong)Convert.ToInt32(v)+ 9223372036854775808;
                            sb.Append((char)(l/ 281474976710656));
                            sb.Append((char)(l/4294967296));
                            sb.Append((char)(l/65536));
                            sb.Append((char)(l%65536));
                            break;
                        case "d":
                            long d = (int)(Convert.ToDateTime(v)-DateTime.MinValue).TotalDays;
                            sb.Append((char)(d/65536));
                            sb.Append((char)(d%65536));
                            break;
                        case "t":
                            ulong t=(ulong)(Convert.ToDateTime(v) - DateTime.MinValue).Ticks;
                            sb.Append((char)(t/ 281474976710656));
                            sb.Append((char)(t/4294967296));
                            sb.Append((char)(t/65536));
                            sb.Append((char)(t%65536));
                            break;
                        default:
                            string s = v.ToString();
                            sb.Append((char)s.Length);
                            sb.Append(s);
                            break;
                    }
                }
            }
            File.WriteAllText(path, sb.ToString(),Encoding.UTF8);
        }
        public static void Open(this DataTable dt, string path)
        {
            string s=File.ReadAllText(path,Encoding.UTF8);
            int i = 0;
            for(int j=s[i++];j>0;j--)
            {
                DataRow dr=dt.NewRow();
                foreach(DataColumn dc in dt.Columns)
                {
                    switch(dc.ColumnName.Substring(0, 1).ToLower())
                    {
                        case "u":
                            dr[dc.Ordinal] = (ushort)s[i++];
                            break;
                        case "c":
                            dr[dc.Ordinal] = s[i++];
                            break;
                        case "b":
                            dr[dc.Ordinal] = s[i++]=='t';
                            break;
                        case "i":
                            dr[dc.Ordinal] = s[i++] * 65536 + s[i++] - 2147483648;
                            break;
                        case "l":
                            dr[dc.Ordinal] = (ulong)(s[i++] * 281474976710656 + s[i++]* 4294967296 + s[i++] * 65536 + s[i++]) - 9223372036854775808;
                            break;
                        case "d":
                            dr[dc.Ordinal] = DateTime.MinValue.AddDays(s[i++] * 65536 + s[i++]);
                            break;
                        case "t":
                            dr[dc.Ordinal] = DateTime.MinValue.AddTicks(s[i++] * 281474976710656 + s[i++] * 4294967296 + s[i++] * 65536 + s[i++]);
                            break;
                        case "f":
                            dr[dc.Ordinal] = Convert.ToDouble(s.Substring(i+=1,(i+=s[i]+1)-i));
                            break;
                        case "m":
                            dr[dc.Ordinal] = Convert.ToDecimal(s.Substring(i+=1,(i+=s[i]+1)-i));
                            break;
                        default:
                            dr[dc.Ordinal] =s.Substring(i+=1,(i+=s[i]+1)-i);
                            break;
                    }
                }
            }
        }
    }
}
