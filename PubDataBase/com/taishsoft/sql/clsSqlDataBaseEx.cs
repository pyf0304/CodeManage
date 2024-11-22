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
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select PrjDataBaseId, PrjDataBaseName from PrjDataBase ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindCbo_PrjDataBaseId(System.Windows.Forms.ComboBox objComboBox)
        {
            //Ϊ����ԴΪ�����������������
            System.Data.DataTable objDT = GetPrjDataBaseId();
            clsSqlDataBase objPrjDataBase;
            //��ʼ��һ�������б�
            ArrayList PrjDataBaseList = new ArrayList();
            //�����0��ڵ�0���в��롰��ѡ��...����Ϊ�˷����û�����WEB��ʽ���ơ�
            objPrjDataBase = new clsSqlDataBase();
            objPrjDataBase.PrjDataBaseId = "0";
            objPrjDataBase.PrjDataBaseName = "��ѡ��...";
            PrjDataBaseList.Add(objPrjDataBase);
            //��DataTable�е���������ӵ������б���
            foreach (DataRow objRow in objDT.Rows)
            {
                objPrjDataBase = new clsSqlDataBase();
                objPrjDataBase.PrjDataBaseId = objRow["PrjDataBaseId"].ToString();
                objPrjDataBase.PrjDataBaseName = objRow["PrjDataBaseName"].ToString();
                PrjDataBaseList.Add(objPrjDataBase);
            }
            //���������������Դ���Լ�����ֵ���ʾ��
            objComboBox.DataSource = PrjDataBaseList;
            objComboBox.ValueMember = "PrjDataBaseId";
            objComboBox.DisplayMember = "PrjDataBaseName";
            objComboBox.SelectedIndex = 0;
        }

        ///��������ĺ�������
        public static void BindDdl_PrjDataBaseId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetPrjDataBaseId();
            objDDL.DataValueField = "PrjDataBaseId";
            objDDL.DataTextField = "PrjDataBaseName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        ///���ɰ�ListView�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��ListView�С�
        /// </summary>
        public static int BindLv_PrjDataBase(System.Windows.Forms.ListView lvPrjDataBase, string strWhereCond)
        {
            //	�������裺(��4��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3������ListView����ͷ��Ϣ
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

            System.Windows.Forms.ListViewItem lviPrjDataBase;
            ArrayList arrPrjDataBaseObjList;
            //	2��������������ȡ�ñ�����������DataTable��
            arrPrjDataBaseObjList = new clsSqlDataBase().GetPrjDataBaseObjList(strWhereCond);
            //	3������ListView����ͷ��Ϣ
            lvPrjDataBase.Items.Clear();//���ԭ������Item
            lvPrjDataBase.Columns.Clear();//���ԭ��������ͷ��Ϣ
            lvPrjDataBase.Columns.Add("��Ŀ���ݿ�Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("��Ŀ���ݿ���", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("���ݿ���", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("���ݿ�ӵ����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("���ݿ���û�����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("���ݿ�����ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("���ݿ���û�ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("������", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("SID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("��ռ�", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("�û�ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("�޸�����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("��ע", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.View = System.Windows.Forms.View.Details;
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
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
            //	4�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            return arrPrjDataBaseObjList.Count;
        }
        /// <summary>
        /// 
        /// </summary>
        public string ConnectString
        {
            get
            {
                //��������ַ���
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
        /// ��ȡ���Ӵ�
        /// </summary>
        /// <param name="objPrjDataBase">clsSqlDataBase����</param>
        /// <returns>���Ӵ�</returns>
        public static string GetConnectString(clsSqlDataBase objPrjDataBase)
        {
            //��������ַ���
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