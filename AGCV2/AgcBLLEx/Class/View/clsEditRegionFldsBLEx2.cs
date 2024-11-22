using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using com.taishsoft.commexception;

using System.Collections.Generic;
using AGC.Entity;

using AGC.BusinessLogic;
using com.taishsoft.common;
using System.Linq;

namespace AGC.BusinessLogicEx
{
    
    public partial class clsEditRegionFldsBLEx
    {
        public List<clsPrjTabFldENEx> arrFieldTabExObjLst = null;			//���������ϸ���ֶμ���

        public clsPrjTabFldENEx objPrjTabFldENEx = null;
        public clsCtlTypeEN objCtlType = null;
        private string mstrCtlName;


        public string FldName_Java
        {
            get
            {
                return objPrjTabFldENEx.ObjFieldTabENEx.FldName.ToLower();
            }
        }
        public string CtrlId
        {
            get
            {
                mstrCtlName = objCtlType.CtlTypeAbbr + objPrjTabFldENEx.ObjFieldTabENEx.FldName;
                return mstrCtlName;
            }
            set
            {
                mstrCtlName = value;
            }
        }
        /// <summary>
        /// ���WINDOWSӦ�õĿؼ���
        /// </summary>
        public string CtlName4Win
        {
            get
            {
                mstrCtlName = objCtlType.CtlTypeAbbr + objPrjTabFldENEx.ObjFieldTabENEx.FldName;

                return mstrCtlName.Replace("ddl", "cbo");
            }
            set
            {
                mstrCtlName = value;
            }
        }
        //public string CodeTabNameBAK
        //{
        //    get
        //    {
        //        return 1new clsFieldTabENEx(objViewInfoENEx.Ds_DataTextFieldId, true).FldName;
        //    }
        //}

        /// <summary>
        /// ת�������
        /// </summary>
        public static string InitDsTabName4Get(clsEditRegionFldsENEx objEditRegionFldsENEx)
        {

            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objEditRegionFldsENEx.DsTabId, objEditRegionFldsENEx.PrjId());
            if (objPrjTabEN == null || string.IsNullOrEmpty(objEditRegionFldsENEx.DsTabId))
            {
                clsvFieldTabEN objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objEditRegionFldsENEx.FldId);
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objEditRegionFldsENEx.RegionId);
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("�ڱ�[{0}]��,���ֶ�[{1}]������ת�������",
                    objPrjTabEN.TabName, objvPrjTabFld.FldName);
                sbMessage.AppendFormat(", ����ID = {0},�������� = {1}, �������� = {2}",
                    objEditRegionFldsENEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
                sbMessage.AppendFormat(", ��ǰ��Ϊ:{0}", objEditRegionFldsENEx.GetType().ToString());
                string strINTabName = objvViewRegion.TabName;
                sbMessage.AppendFormat(", ��ǰ��������:{0}", strINTabName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            //objEditRegionFldsENEx.DS_TabName = objPrjTabEN.TabName;
            return objPrjTabEN.TabName;

        }

        public static clsPrjTabEN InitDs_PrjTab4Get(clsEditRegionFldsENEx objEditRegionFldsENEx)
        {

            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objEditRegionFldsENEx.DsTabId, objEditRegionFldsENEx.PrjId());
            if (objPrjTabEN == null || string.IsNullOrEmpty(objEditRegionFldsENEx.DsTabId))
            {
                clsvFieldTabEN objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objEditRegionFldsENEx.FldId);

                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objEditRegionFldsENEx.RegionId);
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("�ڱ�[{0}]��,���ֶ�[{1}]������ת�������",
                    objvViewRegion.TabName, objvPrjTabFld.FldName);
                sbMessage.AppendFormat(", ����ID = {0},�������� = {1}, �������� = {2}",
                    objEditRegionFldsENEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
                sbMessage.AppendFormat(", ��ǰ��Ϊ:{0}", objEditRegionFldsENEx.GetType().ToString());
                string strINTabName = objvViewRegion.TabName;
                sbMessage.AppendFormat(", ��ǰ�����:{0}", strINTabName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            //objEditRegionFldsENEx.DS_TabName = objPrjTabEN.TabName;
            return objPrjTabEN;

        }

     

        public static List<clsEditRegionFldsENEx> GetObjLstEx(string strCondition)
        {
            List<clsEditRegionFldsENEx> arrObjList = new List<clsEditRegionFldsENEx>();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from EditRegionFlds where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsEditRegionFldsENEx objEditRegionFldsEN = new clsEditRegionFldsENEx();
                objEditRegionFldsEN.mId = Int32.Parse(objRow["mId"].ToString().Trim());
                objEditRegionFldsEN.RegionId = objRow["RegionId"].ToString().Trim();
                objEditRegionFldsEN.FldId = objRow["FldId"].ToString().Trim();
                objEditRegionFldsEN.CtlTypeId = objRow["CtlTypeId"].ToString().Trim();
                objEditRegionFldsEN.DdlItemsOptionId = objRow["DdlItemsOptionId"].ToString().Trim();
                objEditRegionFldsEN.DsTabId = objRow["DsTabId"].ToString().Trim();
                //objEditRegionFldsEN.DsDataValueFieldId = objRow["DsDataValueFieldId"].ToString().Trim();
                //objEditRegionFldsEN.Ds_DataTextFieldId = objRow["Ds_DataTextFieldId"].ToString().Trim();
                objEditRegionFldsEN.DsCondStr = objRow["DsCondStr"].ToString().Trim();
                objEditRegionFldsEN.DsSqlStr = objRow["DsSqlStr"].ToString().Trim();
                objEditRegionFldsEN.ItemsString = objRow["ItemsString"].ToString().Trim();
                objEditRegionFldsEN.SeqNum = clsGeneralTab2.TransNullToInt_S(objRow["SeqNum"].ToString().Trim());
                objEditRegionFldsEN.UpdUser = objRow["UpdUser"].ToString().Trim();
                objEditRegionFldsEN.Memo = objRow["Memo"].ToString().Trim();
                objEditRegionFldsEN.UpdDate = objRow["UpdDate"].ToString().Trim();
                objEditRegionFldsEN.InOutTypeId = objRow["InOutTypeId"].ToString().Trim();
                arrObjList.Add(objEditRegionFldsEN);
            }
            objDT = null;
            return arrObjList;
        }




        ///���ɰ�ListView�Ĵ���
        /// <summary>
        /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��ListView�С�
        /// </summary>
        public static int BindLv_EditRegionFlds(System.Windows.Forms.ListView lvEditRegionFlds, string strWhereCond)
        {
            //��������:(��4��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3������ListView����ͷ��Ϣ
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

            System.Windows.Forms.ListViewItem lviEditRegionFlds;
            List<clsEditRegionFldsEN> arrEditRegionFldsObjList;
            //	2��������������ȡ�ñ�����������DataTable��
            arrEditRegionFldsObjList = clsEditRegionFldsBL.GetObjLst(strWhereCond);
            //	3������ListView����ͷ��Ϣ
            lvEditRegionFlds.Items.Clear();//���ԭ������Item
            lvEditRegionFlds.Columns.Clear();//���ԭ��������ͷ��Ϣ
            lvEditRegionFlds.Columns.Add("mId", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("����Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("�ֶ�ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("�ؼ����ͺ�", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("�������б�ѡ��ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("����Դ��ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("����Դֵ�ֶ�Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("����Դ�ı��ֶ�Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("����Դ������", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("����ԴSQL��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("�б��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("�ֶ����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("�û�ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("˵��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("�޸�����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.View = System.Windows.Forms.View.Details;
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            foreach (clsEditRegionFldsEN objEditRegionFldsEN in arrEditRegionFldsObjList)
            {
                lviEditRegionFlds = new System.Windows.Forms.ListViewItem();
                lviEditRegionFlds.Tag = objEditRegionFldsEN.mId;
                lviEditRegionFlds.Text = objEditRegionFldsEN.mId.ToString();
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.RegionId.ToString());
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.FldId.ToString());
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.CtlTypeId);
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.DdlItemsOptionId);
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.DsTabId);
                //lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.DsDataValueFieldId);
                //lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.Ds_DataTextFieldId);
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.DsCondStr);
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.DsSqlStr);
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.ItemsString);
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.SeqNum.ToString());
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.UpdUser);
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.Memo);
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.UpdDate);
                lvEditRegionFlds.Items.Add(lviEditRegionFlds);
            }
            //	4�����ü�¼����״̬,
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            return arrEditRegionFldsObjList.Count;
        }
        public static bool AdjustSequenceNumber(string strDirect, long lngMid)
        {
            //��������:
            //1����ȡ��ǰ��ѡ�еĹؼ���Mid��
            //2�����ݹؼ���Mid����ȡ�ֵ����
            //3�������ǰ����Ƿ���ĩ�����,
            //		3.1 �����ĩ�����,���˳�,
            //		3.2 �������,������������ƶ�,���жϵ�ǰ����Ƿ�С�ڡ���ǰ���е��ֶ���,
            //		    ���������һ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1,
            //		    ����������ƶ�,���жϵ�ǰ����Ƿ񡰴��ڡ�1,
            //		    �������ʼһ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1��
            //4����ȡ��(��)һ������ֶεĹؼ���Mid
            //5���ѵ�ǰ�ؼ���Mid����ż�(��)1
            //6������һ����ŵĹؼ���Mid��(��)1
            //7��������ʾDATAGRID
            
            int intSeqNum;	//��ǰ��¼�����
            int intPrevSeqNum, intNextSeqNum;	//����������¼�����
            //			string strMid;
            long lngPrevMid = 0;	//��һ����ŵĹؼ���MId
            long lngNextMid = 0;	//��һ����ŵĹؼ���MId
            int intTabRecNum;		//��ǰ�����ֶεļ�¼��
            string strCurrRegionId;
            List<string> arrID;
            StringBuilder strCondition = new StringBuilder();
            //1����ȡ��ǰ��ѡ�е��ֶ�ID��

            clsEditRegionFldsEN objEditRegionFldsEN = clsEditRegionFldsBL.GetObjBymId(lngMid);
            intSeqNum = objEditRegionFldsEN.SeqNum ?? 0;
            intPrevSeqNum = intSeqNum - 1;
            intNextSeqNum = intSeqNum + 1;
            //3�������ǰ����Ƿ���ĩ�����,
            //		3.1 �����ĩ�����,���˳�,
            strCurrRegionId = objEditRegionFldsEN.RegionId;		//��ȡ��ǰ��¼��{��ID}
            intTabRecNum = clsGeneralTab2.funGetRecCountByCond(clsEditRegionFldsEN._CurrTabName, "RegionId = '" + strCurrRegionId + "'");	//��ȡ��ǰ{��ID}�ļ�¼��
            if (strDirect == "UP")
            {
                if (intSeqNum <= 1)
                {
                    throw new clsDbObjException("�Ѿ��ǵ�һ����¼,����������!");
                }
            }
            else if (strDirect == "DOWN")
            {
                if (intSeqNum >= intTabRecNum)	//�����ǰ��Ŵ��ڱ��¼��
                {
                    throw new clsDbObjException("�Ѿ������һ����¼,����������!");
                }
            }
            ///		3.2 �������,������������ƶ�,���жϵ�ǰ����Ƿ�С�ڡ���ǰ���е��ֶ���,
            ///		    ���������һ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1,
            ///		    ����������ƶ�,���жϵ�ǰ����Ƿ񡰴��ڡ�1,
            ///		    �������ʼһ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1��

            //4����ȡ��(��)һ������ֶεĹؼ���Mid
            if (strDirect == "UP")
            {
                strCondition.AppendFormat("RegionId = '{0}' and SeqNum = {1}",
                    strCurrRegionId, intSeqNum - 1);
                arrID = clsEditRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
                if (arrID == null)
                {
                    throw new clsDbObjException("��ȡ��һ����¼�Ĺؼ��ֳ���!");

                }
                if (arrID.Count <= 0)
                {
                    throw new clsDbObjException("��ȡ��һ����¼�Ĺؼ��ֳ���!");
                }
                lngPrevMid = long.Parse((string)arrID[0]);
            }
            else if (strDirect == "DOWN")
            {
                strCondition.AppendFormat("RegionId = '{0}' and SeqNum = {1}",
                    strCurrRegionId, intSeqNum + 1);
                arrID = clsEditRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
                if (arrID == null)
                {
                    throw new clsDbObjException("��ȡ��һ����¼�Ĺؼ��ֳ���!");

                }
                if (arrID.Count <= 0)
                {
                    throw new clsDbObjException("��ȡ��һ����¼�Ĺؼ��ֳ���!");
                }
                lngNextMid = long.Parse((string)arrID[0]);
            }
            else if (strDirect == "FIRST")
            {
            }
            else if (strDirect == "LAST")
            {
            }
            else
            {
                throw new clsDbObjException("�����������!");
            }
            //5���ѵ�ǰ�ؼ���Mid����ż�(��)1
            //6������һ����ŵĹؼ���Mid��(��)1
            if (strDirect == "UP")
            {
                clsEditRegionFldsBL.SetFldValue(clsEditRegionFldsEN._CurrTabName, "SeqNum", intSeqNum - 1, "MId = " + lngMid);
                clsEditRegionFldsBL.SetFldValue(clsEditRegionFldsEN._CurrTabName, "SeqNum", intPrevSeqNum + 1, "MId = " + lngPrevMid);
            }
            else if (strDirect == "DOWN")
            {
                clsEditRegionFldsBL.SetFldValue(clsEditRegionFldsEN._CurrTabName, "SeqNum", intSeqNum + 1, "MId = " + lngMid);
                clsEditRegionFldsBL.SetFldValue(clsEditRegionFldsEN._CurrTabName, "SeqNum", intNextSeqNum - 1, "MId = " + lngNextMid);
            }
            else if (strDirect == "FIRST")
            {
                clsEditRegionFldsBL.SetFldValue(clsEditRegionFldsEN._CurrTabName, "SeqNum", 0, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            else if (strDirect == "LAST")
            {
                clsEditRegionFldsBL.SetFldValue(clsEditRegionFldsEN._CurrTabName, "SeqNum", 1000, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            //7��������ʾDATAGRID
            return true;
        }
        public new static void ReOrder(string lngRegionId)
        {
            IEnumerable<clsEditRegionFldsEN> arrEditRegionFldsObjList = clsEditRegionFldsBL.GetObjLst("RegionId = '" + lngRegionId + "' order by SeqNum ");
            arrEditRegionFldsObjList = arrEditRegionFldsObjList.OrderByDescending(x => x.InUse).ThenBy(x => x.SeqNum);
            int intIndex = 1;
            foreach (clsEditRegionFldsEN objEditRegionFldsEN in arrEditRegionFldsObjList)
            {
                objEditRegionFldsEN.SeqNum = intIndex;
                clsEditRegionFldsBL.UpdateBySql2(objEditRegionFldsEN);
                intIndex++;
            }
        }

        /// <summary>
        /// ת�������--�ı��ֶ�
        /// </summary>
        public static string InitDs_DataTextFieldBak20230309(clsEditRegionFldsENEx objEditRegionFldsENEx)
        {

            //clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(objEditRegionFldsENEx.Ds_DataTextFieldId, objEditRegionFldsENEx.PrjId());
            //if (objFieldTabEN == null || string.IsNullOrEmpty(objEditRegionFldsENEx.Ds_DataTextFieldId))
            //{
            //    var objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objEditRegionFldsENEx.FldId);
            //    clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objEditRegionFldsENEx.RegionId);
            //    StringBuilder sbMessage = new StringBuilder();
            //    sbMessage.AppendFormat("�ڱ�[{0}]��,���ֶ�[{1}]������ת�������--�ı��ֶΡ�",
            //        objvViewRegion.TabName, objvPrjTabFld.FldName);
            //    sbMessage.AppendFormat(", ����ID = {0},�������� = {1}, �������� = {2}",
            //        objEditRegionFldsENEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
            //    sbMessage.AppendFormat(", ��ǰ��Ϊ:{0}", objEditRegionFldsENEx.GetType().ToString());
            //    string strINTabName = objvViewRegion.TabName;
            //    sbMessage.AppendFormat(", ��ǰ�����:{0}", strINTabName);
            //    throw new clsDbObjException(sbMessage.ToString());
            //}
            ////objEditRegionFldsENEx.DS_DataTextField = objFieldTabEN.FldName;
            //return objFieldTabEN.FldName;
            return "";
        }
        /// <summary>
        /// ת�������--ֵ�ֶ�
        /// </summary>
        public static string InitDs_DataValueFieldBak20230309(clsEditRegionFldsENEx objEditRegionFldsENEx)
        {

            //clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(objEditRegionFldsENEx.DsDataValueFieldId, objEditRegionFldsENEx.PrjId());
            //if (objFieldTabEN == null || string.IsNullOrEmpty(objEditRegionFldsENEx.DsDataValueFieldId))
            //{
            //    clsvFieldTabEN objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objEditRegionFldsENEx.FldId);
            //    clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objEditRegionFldsENEx.RegionId);
            //    StringBuilder sbMessage = new StringBuilder();
            //    sbMessage.AppendFormat("�ڱ�[{0}]��,���ֶ�[{1}]������ת�������--ֵ�ֶΡ�",
            //        objvViewRegion.TabName, objvPrjTabFld.FldName);
            //    sbMessage.AppendFormat(", ����ID = {0},�������� = {1}, �������� = {2}",
            //        objEditRegionFldsENEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
            //    sbMessage.AppendFormat(", ��ǰ��Ϊ:{0}", objEditRegionFldsENEx.GetType().ToString());
            //    string strINTabName = objvViewRegion.TabName;
            //    sbMessage.AppendFormat(", ��ǰ�����:{0}", strINTabName);
            //    throw new clsDbObjException(sbMessage.ToString());
            //}
            //return objFieldTabEN.FldName;
            return "";
        }

        /// <summary>
        /// ת�������
        /// </summary>
        public static void InitCodeTab(clsEditRegionFldsENEx objEditRegionFldsENEx)
        {

            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objEditRegionFldsENEx.DsTabId, objEditRegionFldsENEx.PrjId());
            if (objPrjTabEN == null || string.IsNullOrEmpty(objEditRegionFldsENEx.DsTabId))
            {
                clsvFieldTabEN objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objEditRegionFldsENEx.FldId);
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objEditRegionFldsENEx.RegionId);
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("�ڱ�[{0}]��,���ֶ�[{1}]������ת�������",
                    objvViewRegion.TabName, objvPrjTabFld.FldName);
                sbMessage.AppendFormat(", ����ID = {0},�������� = {1}, �������� = {2}",
                    objEditRegionFldsENEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
                sbMessage.AppendFormat(", ��ǰ��Ϊ:{0}", objEditRegionFldsENEx.GetType().ToString());
                string strINTabName = objvViewRegion.TabName;
                sbMessage.AppendFormat(", ��ǰ�����:{0}", strINTabName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            objEditRegionFldsENEx.CodeTab = objPrjTabEN.TabName;

        }

        public static bool CheckRegionFldsUp(string strRegionId, string strCmPrjId, string strOpUserId)
        {
            var strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            var objErrMsg_New = CheckRegionFlds(strRegionId, strCmPrjId, strOpUserId);
            var arrViewId = clsViewRegionRelaBLEx.GetViewIdLstByRegionIdCache(strRegionId, strPrjId_p);
            var arrViewInfo = clsViewInfoBL.GetObjLstByViewIdLstCache(arrViewId, strPrjId_p);
            if (objErrMsg_New.ErrNum == 0)
            {
                foreach (var objInFor in arrViewInfo)
                {
                    if (objInFor.ErrMsg == null) continue;
                    if (objInFor.ErrMsg.Length == 0) continue;
                    var arrErrMsg = clsErrMsgBLEx.GetErrMsgObjLstByErrMsg(objInFor.ErrMsg);
                    if (arrErrMsg == null) continue;
                    if (arrErrMsg.Count == 0) continue;
                    var arrErrMsg_Del = arrErrMsg.Where(x => x.ErrType != objErrMsg_New.ErrType).ToList();
                    string strErrMsg_New = clsErrMsgBLEx.GetErrMsgByObjLst(arrErrMsg_Del);
                    objInFor.ErrMsg = strErrMsg_New;
                    objInFor.Update();
                }
            }
            else
            {

                foreach (var objInFor in arrViewInfo)
                {
                    var arrErrMsg = clsErrMsgBLEx.GetErrMsgObjLstByErrMsg(objInFor.ErrMsg);
                    clsErrMsgBLEx.AddObj(arrErrMsg, objErrMsg_New);
                    string strErrMsg_New = clsErrMsgBLEx.GetErrMsgByObjLst(arrErrMsg);
                    objInFor.ErrMsg = strErrMsg_New;
                    objInFor.Update();
                }
            }
            return true;
        }
    }
}