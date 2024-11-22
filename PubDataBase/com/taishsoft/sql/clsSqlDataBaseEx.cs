using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;

namespace com.taishsoft.sql
{
    public class clsPrjDataBaseEx : clsSqlDataBase
    {

        public clsPrjDataBaseEx()
            : base()
        {
        }

        public clsPrjDataBaseEx(string strPrjDataBaseId)
            : base(strPrjDataBaseId)
        {
        }

        public clsPrjDataBaseEx(string strPrjDataBaseId, bool bolIsGetPrjDataBase)
            : base(strPrjDataBaseId, bolIsGetPrjDataBase)
        {
        }


        public static System.Data.DataTable GetPrjDataBaseId()
        {
            //获取某学院所有专业信息
            string strSQL = "select PrjDataBaseId, PrjDataBaseName from PrjDataBase ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindCbo_PrjDataBaseId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetPrjDataBaseId();
            clsSqlDataBase objPrjDataBase;
            //初始化一个对象列表
            ArrayList PrjDataBaseList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”，为了方便用户，与WEB方式类似。
            objPrjDataBase = new clsSqlDataBase();
            objPrjDataBase.PrjDataBaseId = "0";
            objPrjDataBase.PrjDataBaseName = "请选择...";
            PrjDataBaseList.Add(objPrjDataBase);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objPrjDataBase = new clsSqlDataBase();
                objPrjDataBase.PrjDataBaseId = objRow["PrjDataBaseId"].ToString();
                objPrjDataBase.PrjDataBaseName = objRow["PrjDataBaseName"].ToString();
                PrjDataBaseList.Add(objPrjDataBase);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = PrjDataBaseList;
            objComboBox.ValueMember = "PrjDataBaseId";
            objComboBox.DisplayMember = "PrjDataBaseName";
            objComboBox.SelectedIndex = 0;
        }

        ///绑定下拉框的函数代码
        public static void BindDdl_PrjDataBaseId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetPrjDataBaseId();
            objDDL.DataValueField = "PrjDataBaseId";
            objDDL.DataTextField = "PrjDataBaseName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_PrjDataBase(System.Windows.Forms.ListView lvPrjDataBase, string strWhereCond)
        {
            //	操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviPrjDataBase;
            ArrayList arrPrjDataBaseObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrPrjDataBaseObjList = new clsSqlDataBase().GetPrjDataBaseObjList(strWhereCond);
            //	3、设置ListView的列头信息
            lvPrjDataBase.Items.Clear();//清除原来所有Item
            lvPrjDataBase.Columns.Clear();//清除原来所有列头信息
            lvPrjDataBase.Columns.Add("项目数据库Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("项目数据库名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("数据库名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("数据库拥有者", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("数据库的用户口令", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("数据库类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("数据库的用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("服务器", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("SID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("表空间", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsSqlDataBase objPrjDataBase in arrPrjDataBaseObjList)
            {
                lviPrjDataBase = new System.Windows.Forms.ListViewItem();
                lviPrjDataBase.Tag = objPrjDataBase.PrjDataBaseId;
                lviPrjDataBase.Text = objPrjDataBase.PrjDataBaseId.ToString();
                lviPrjDataBase.SubItems.Add(objPrjDataBase.PrjDataBaseName);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.DataBaseName);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.DatabaseOwner);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.DataBasePwd);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.DataBaseTypeId);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.DataBaseUserId);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.IpAddress);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.SID);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.TableSpace);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.UserId);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.UpdDate);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.Memo);
                lvPrjDataBase.Items.Add(lviPrjDataBase);
            }
            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrPrjDataBaseObjList.Count;
        }
        /// <summary>
        /// 
        /// </summary>
        public string ConnectString
        {
            get
            {
                //获得连接字符串
                StringBuilder sbConnectString = new StringBuilder();
                if (this.mstrDataBaseTypeId == "01" || this.mstrDataBaseTypeId == "04")
                {
                    sbConnectString.AppendFormat("server={0};", this.mstrIpAddress);
                    sbConnectString.AppendFormat("database={0};", this.mstrDataBaseName);
                    sbConnectString.AppendFormat("uid={0};", this.mstrDataBaseUserId);
                    sbConnectString.AppendFormat("pwd={0};", this.mstrDataBasePwd);
                }
                else if (this.mstrDataBaseTypeId == "02")
                {
                    sbConnectString.Append("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)");
                    sbConnectString.AppendFormat("(HOST={0})",
                        this.mstrIpAddress);
                    sbConnectString.Append("(PORT=1521)))");
                    sbConnectString.AppendFormat("(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={0})));",
                        this.mstrSID);
                    sbConnectString.AppendFormat("User Id={0};Password={1};",
                        this.mstrDataBaseUserId,
                        this.mstrDataBasePwd);
                }
                else
                {
                    return "";
                }
                return sbConnectString.ToString();

            }
        }
        /// <summary>
        /// 获取连接串
        /// </summary>
        /// <param name="objPrjDataBase">clsSqlDataBase对象</param>
        /// <returns>连接串</returns>
        public static string GetConnectString(clsSqlDataBase objPrjDataBase)
        {
            //获得连接字符串
            StringBuilder sbConnectString = new StringBuilder();
            if (objPrjDataBase.DataBaseTypeId == "01" || objPrjDataBase.DataBaseTypeId == "04")
            {
                sbConnectString.AppendFormat("server={0};", objPrjDataBase.IpAddress);
                sbConnectString.AppendFormat("database={0};", objPrjDataBase.DataBaseName);
                sbConnectString.AppendFormat("uid={0};", objPrjDataBase.DataBaseUserId);
                sbConnectString.AppendFormat("pwd={0};", objPrjDataBase.DataBasePwd);
            }
            else if (objPrjDataBase.DataBaseTypeId == "02")
            {
                sbConnectString.Append("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)");
                sbConnectString.AppendFormat("(HOST={0})",
                    objPrjDataBase.IpAddress);
                sbConnectString.Append("(PORT=1521)))");
                sbConnectString.AppendFormat("(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={0})));",
                    objPrjDataBase.SID);
                sbConnectString.AppendFormat("User Id={0};Password={1};",
                    objPrjDataBase.DataBaseUserId,
                    objPrjDataBase.DataBasePwd);
            }
            else
            {
                return "";
            }
            return sbConnectString.ToString();
        }
    }
}