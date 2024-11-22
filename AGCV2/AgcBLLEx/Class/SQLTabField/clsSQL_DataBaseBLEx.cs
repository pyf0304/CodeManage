using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using AGC.Entity;
using System.Collections.Generic;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    public partial class clsSQL_DataBaseBLEx : clsSQL_DataBaseBL
    {

      

        ///��������ĺ�������

        ///���ɰ�ListView�Ĵ���
        /// <summary>
        /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��ListView�С�
        /// </summary>
        public static int BindLv_SQL_DataBase(System.Windows.Forms.ListView lvSQL_DataBase, string strWhereCond)
        {
            //��������:(��4��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3������ListView����ͷ��Ϣ
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

            System.Windows.Forms.ListViewItem lviSQL_DataBase;
            List<clsSQL_DataBaseEN> arrSQL_DataBaseObjList;
            //	2��������������ȡ�ñ�����������DataTable��
            arrSQL_DataBaseObjList = clsSQL_DataBaseBL.GetObjLst(strWhereCond);
            //	3������ListView����ͷ��Ϣ
            lvSQL_DataBase.Items.Clear();//���ԭ������Item
            lvSQL_DataBase.Columns.Clear();//���ԭ��������ͷ��Ϣ
            lvSQL_DataBase.Columns.Add("���ݿ���", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSQL_DataBase.Columns.Add("������", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSQL_DataBase.Columns.Add("�û�ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSQL_DataBase.Columns.Add("����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSQL_DataBase.Columns.Add("�û�ID4Master", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSQL_DataBase.Columns.Add("����4Master", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSQL_DataBase.Columns.Add("����ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSQL_DataBase.View = System.Windows.Forms.View.Details;
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            foreach (clsSQL_DataBaseEN objSQL_DataBase in arrSQL_DataBaseObjList)
            {
                lviSQL_DataBase = new System.Windows.Forms.ListViewItem();
                lviSQL_DataBase.Tag = objSQL_DataBase.DataBaseName;
                lviSQL_DataBase.Text = objSQL_DataBase.DataBaseName;
                lviSQL_DataBase.SubItems.Add(objSQL_DataBase.Server);
                lviSQL_DataBase.SubItems.Add(objSQL_DataBase.UserId);
                lviSQL_DataBase.SubItems.Add(objSQL_DataBase.Password);
                lviSQL_DataBase.SubItems.Add(objSQL_DataBase.UserIdForMaster);
                lviSQL_DataBase.SubItems.Add(objSQL_DataBase.PasswordForMaster);
                lviSQL_DataBase.SubItems.Add(objSQL_DataBase.PrjId);
                lvSQL_DataBase.Items.Add(lviSQL_DataBase);
            }
            //	4�����ü�¼����״̬,
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            return arrSQL_DataBaseObjList.Count;
        }
        /// <summary>
        /// ��ȡָ�����������������ݿ�
        /// </summary>
        /// <returns>�����������ݿ��DataTable</returns>
        public System.Data.DataTable getDataBases(clsSQL_DataBaseEN objSQL_DataBaseEN)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objSQL_DataBaseEN.Server, "master",
               objSQL_DataBaseEN.UserIdForMaster, objSQL_DataBaseEN.PasswordForMaster);
            objDT = objSQL.getDataBases();
            return objDT;
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б�����
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public System.Data.DataTable getTables(clsSQL_DataBaseEN objSQL_DataBaseEN)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objSQL_DataBaseEN.Server,
                objSQL_DataBaseEN.DataBaseName,
                objSQL_DataBaseEN.UserId,
                objSQL_DataBaseEN.Password);
            objDT = objSQL.getTables();
            return objDT;
        }

        /// <summary>
        /// ��ȡ��ǰ���ݿ������б�����
        /// </summary>
        /// <returns>���б�����ArrayList</returns>
        public ArrayList getTablesList(clsSQL_DataBaseEN objSQL_DataBaseEN)
        {
            ArrayList arrTablesList = new ArrayList();
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objSQL_DataBaseEN.Server,
                objSQL_DataBaseEN.DataBaseName,
                objSQL_DataBaseEN.UserId,
                objSQL_DataBaseEN.Password);
            objDT = objSQL.getTables();

            foreach (DataRow objRow in objDT.Rows)
            {
                string strTabName = objRow["name"].ToString().Trim();
                arrTablesList.Add(strTabName);
            }

            return arrTablesList;
        }


        /// <summary>
        /// ��ȡ��ǰ���ݿ������б������б�
        /// </summary>
        /// <returns>���б����Ķ���ArrayList</returns>
        public ArrayList getTablesObjList(clsSQL_DataBaseEN objSQL_DataBaseEN)
        {
            ArrayList arrTablesObjList = new ArrayList();
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objSQL_DataBaseEN.Server,
                objSQL_DataBaseEN.DataBaseName,
                objSQL_DataBaseEN.UserId,
                objSQL_DataBaseEN.Password);
            objDT = objSQL.getTables();

            foreach (DataRow objRow in objDT.Rows)
            {
                clsTablesEN objTables = new clsTablesEN();
                objTables.TabName = objRow["name"].ToString().Trim();
                objTables.DataBaseName = objSQL_DataBaseEN.DataBaseName;
                arrTablesObjList.Add(objTables);
            }
            return arrTablesObjList;
        }

      
        public static clsSpecSQLforSql getSpecSQLByPrjDataBaseId(string strPrjDataBaseId)
        {
            if (strPrjDataBaseId  ==  null || strPrjDataBaseId  ==  "")
            {
                throw new Exception("PrjDataBaseId Ϊ��,������һ���Ϸ���PrjDataBaseId(�������ݿ��)!");
            }
//            bool bolResult = clsPrjDataBaseBL.IsExistRecord("PrjDataBaseId = '" + strPrjDataBaseId + "'");
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);

            if (objPrjDataBaseEN ==  null)
            {
                throw new Exception("�Ƿ�PrjDataBaseId��PrjDataBaseId:" + strPrjDataBaseId + "' ������ ,������һ���Ϸ���PrjDataBaseId(�������ݿ��)!");
            }
           
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objPrjDataBaseEN.IpAddress,
                objPrjDataBaseEN.DataBaseName,
                objPrjDataBaseEN.DataBaseUserId,
                objPrjDataBaseEN.DataBasePwd);
            return objSQL;
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б�����
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public bool IsExistTable(clsSQL_DataBaseEN objSQL_DataBaseEN, string strTabName)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objSQL_DataBaseEN.Server,
                objSQL_DataBaseEN.DataBaseName,
                objSQL_DataBaseEN.UserId,
                objSQL_DataBaseEN.Password);
            objDT = objSQL.getTables();
            if (objDT.Rows.Count  ==  0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ�������VIEW����
        /// </summary>
        /// <returns>����View����DataTable</returns>
        public System.Data.DataTable getViews(clsSQL_DataBaseEN objSQL_DataBaseEN)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objSQL_DataBaseEN.Server,
                   objSQL_DataBaseEN.DataBaseName,
                  objSQL_DataBaseEN.UserId,
                   objSQL_DataBaseEN.Password);
            objDT = objSQL.getViews();
            return objDT;
        }
    }
}