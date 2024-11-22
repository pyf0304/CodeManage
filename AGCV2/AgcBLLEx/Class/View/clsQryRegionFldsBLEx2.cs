using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using com.taishsoft.commexception;

using System.Collections.Generic;
using AGC.Entity;
using AGC.BusinessLogic;
using System.Linq;
using com.taishsoft.common;
using AGC.PureClass;
using AGC.PureClassEx;
using com.taishsoft.datetime;

namespace AGC.BusinessLogicEx
{
    public partial class clsQryRegionFldsBLEx
    {
        public List<clsPrjTabFldENEx> arrFieldTabExObjLst = null;           //���������ϸ���ֶμ���
        public static void initQryRegionFldSet(clsViewInfoENEx objViewInfoENEx, bool bolIsFstLcase)
        {
           
            objViewInfoENEx.TabKeyFldNum = 0;
            //��ȡ����ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache(objViewInfoENEx.ViewId,
                clsRegionTypeENEx.QUERYREGION, objViewInfoENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            //objViewInfoENEx.objQueryRegionENEx = new clsQueryRegionENEx(lngRegionId);
            //clsQueryRegionBLEx.GetQueryRegionEx(ref objViewInfoENEx.objQueryRegionENEx, objViewInfoENEx.PrjId);

            //objViewInfoENEx.objQueryRegionENEx.InitViewRegion();
            objViewInfoENEx.arrQryRegionFldSet = clsQryRegionFldsBLEx.GetObjExLstByRegionIdCache4InUse1(lngRegionId, bolIsFstLcase, objViewInfoENEx.PrjId);
            //if (objViewInfoENEx.arrQryRegionFldSet  ==  null || objViewInfoENEx.arrQryRegionFldSet.Count  ==  0)
            //{
            //    intViewFldNum = 0;
            //    return;
            //}
            //objViewInfoENEx.objQueryRegionENEx.FieldNum = objViewInfoENEx.arrQryRegionFldSet.Count;
            objViewInfoENEx.ViewFldNum = objViewInfoENEx.arrQryRegionFldSet.Count;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                //objQryRegionFldsEx.arrFieldTabExObjLstBak = objViewInfoENEx.arrFieldTabExObjLstBak;
                if (string.IsNullOrEmpty(objQryRegionFldsEx.FldId) == true) continue;
                if (objQryRegionFldsEx.ObjPrjTabFld() == null)
                {
                    objQryRegionFldsEx.IsForExtendClass = false;
                }
                else
                {
                    objQryRegionFldsEx.IsForExtendClass = objQryRegionFldsEx.ObjPrjTabFld().IsForExtendClass;
                }
                objQryRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objQryRegionFldsEx.FldId, objViewInfoENEx.PrjId);

                objQryRegionFldsEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objQryRegionFldsEx.CtlTypeId);
                if (string.IsNullOrEmpty( objQryRegionFldsEx.DsTabId ) == false)
                {
                    clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objQryRegionFldsEx.DsTabId, objViewInfoENEx.PrjId);
                    if (objPrjTabEN != null) objQryRegionFldsEx.DS_TabName = objPrjTabEN.TabName;
                }
            }
        }

        //public clsPrjTabFldENEx objPrjTabFldENEx = null;
        //public clsCtlTypeEN objCtlType = null;
        //private string mstrCtlName;


        //public string FldName_Java
        //{
        //    get
        //    {
        //        return CommProgramSet.clsComm.FstLcaseS(objViewInfoENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName.ToLower());
        //    }
        //}
        //public string CtrlId
        //{
        //    get
        //    {
        //        mstrCtlName = objViewInfoENEx.objCtlType.CtlTypeAbbr + objViewInfoENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;
        //        return mstrCtlName;
        //    }
        //    set
        //    {
        //        mstrCtlName = value;
        //    }
        //}
        //public string CtlName4Win
        //{
        //    get
        //    {
        //        mstrCtlName = objViewInfoENEx.objCtlType.CtlTypeAbbr + objViewInfoENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

        //        return mstrCtlName.Replace("ddl", "cbo");
        //    }
        //    set
        //    {
        //        mstrCtlName = value;
        //    }
        //}
        /// <summary>
        /// ת�������
        /// </summary>
        public static string CodeTab4Get(clsQryRegionFldsENEx objQryRegionFldsEx)
        {

            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(objQryRegionFldsEx.DsTabId);
            if (objPrjTabEN  ==  null || string.IsNullOrEmpty(objQryRegionFldsEx.DsTabId))
            {

                var objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objQryRegionFldsEx.FldId);
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objQryRegionFldsEx.RegionId);
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("�ڱ�[{0}]��,���ֶ�[{1}]������ת�������",
                    objvViewRegion.TabName, objvPrjTabFld.FldName);
                sbMessage.AppendFormat(", ����ID = {0},�������� = {1}, �������� = {2}",
                    objQryRegionFldsEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
                sbMessage.AppendFormat(", ��ǰ��Ϊ:{0}", objQryRegionFldsEx.GetType().ToString());
                string strOUTTabName = objvViewRegion.TabName;
                sbMessage.AppendFormat(", ��ǰ�����:{0}", strOUTTabName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            return objPrjTabEN.TabName;

        }
        //public string CodeTabNameBak
        //{
        //    get
        //    {
        //        return 1new clsFieldTabENEx(objViewInfoENEx.Ds_DataTextFieldId, true).FldName;
        //    }
        //}
        /// <summary>
        /// ת�������
        /// </summary>
        public static string DsTabName4Get(clsQryRegionFldsENEx objQryRegionFldsEx)
        {

            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(objQryRegionFldsEx.DsTabId);
            if (objPrjTabEN  ==  null || string.IsNullOrEmpty(objQryRegionFldsEx.DsTabId))
            {
                var objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objQryRegionFldsEx.FldId);
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objQryRegionFldsEx.RegionId);
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("�ڱ�[{0}]��,���ֶ�[{1}]������ת�������",
                    objvViewRegion.TabName, objvPrjTabFld.FldName);
                sbMessage.AppendFormat(", ����ID = {0},�������� = {1}, �������� = {2}",
                    objQryRegionFldsEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
                sbMessage.AppendFormat(", ��ǰ��Ϊ:{0}", objQryRegionFldsEx.GetType().ToString());
                string strOUTTabName = objvViewRegion.TabName;
                sbMessage.AppendFormat(", ��ǰ�����:{0}", strOUTTabName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            return objPrjTabEN.TabName;

        }
        public static clsPrjTabEN Ds_PrjTab4Get(clsQryRegionFldsENEx objQryRegionFldsEx)
        {

            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objQryRegionFldsEx.DsTabId, objQryRegionFldsEx.PrjId());
            if (objPrjTabEN == null || string.IsNullOrEmpty(objQryRegionFldsEx.DsTabId))
            {
                var objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objQryRegionFldsEx.FldId);
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objQryRegionFldsEx.RegionId);
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("�ڱ�[{0}]��,���ֶ�[{1}]������ת�������",
                    objvViewRegion.TabName, objvPrjTabFld.FldName);
                sbMessage.AppendFormat(", ����ID = {0},�������� = {1}, �������� = {2}",
                    objQryRegionFldsEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
                sbMessage.AppendFormat(", ��ǰ��Ϊ:{0}", objQryRegionFldsEx.GetType().ToString());
                string strOUTTabName = objvViewRegion.TabName;
                sbMessage.AppendFormat(", ��ǰ�����:{0}", strOUTTabName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            return objPrjTabEN;

        }
        public static string InitDS_TabName4Get(clsQryRegionFldsENEx objQryRegionFldsEx)
        {

            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objQryRegionFldsEx.DsTabId, objQryRegionFldsEx.PrjId());
            if (objPrjTabEN == null || string.IsNullOrEmpty(objQryRegionFldsEx.DsTabId))
            {
                var objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objQryRegionFldsEx.FldId);
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objQryRegionFldsEx.RegionId);
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("�ڱ�[{0}]��,���ֶ�[{1}]������ת�������",
                    objvViewRegion.TabName, objvPrjTabFld.FldName);
                sbMessage.AppendFormat(", ����ID = {0},�������� = {1}, �������� = {2}",
                    objQryRegionFldsEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
                sbMessage.AppendFormat(", ��ǰ��Ϊ:{0}", objQryRegionFldsEx.GetType().ToString());
                string strOUTTabName = objvViewRegion.TabName;
                sbMessage.AppendFormat(", ��ǰ��������:{0}", strOUTTabName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            //objQryRegionFldsEx.DS_TabName = objPrjTabEN.TabName;
            return objPrjTabEN.TabName;

        }

        /// <summary>
        /// ת�������--�ı��ֶ�
        /// </summary>
        public static  string Ds_DataTextField4GetBak20230309(clsQryRegionFldsENEx objQryRegionFldsEx)
        {
            //clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(objQryRegionFldsEx.Ds_DataTextFieldId, objQryRegionFldsEx.PrjId());
            //if (objFieldTabEN  ==  null || string.IsNullOrEmpty(objQryRegionFldsEx.Ds_DataTextFieldId))
            //{
            //    var objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objQryRegionFldsEx.FldId);
            //    clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objQryRegionFldsEx.RegionId);
            //    StringBuilder sbMessage = new StringBuilder();
            //    sbMessage.AppendFormat("�ڱ�[{0}]��,���ֶ�[{1}]������ת�������--�ı��ֶΡ�",
            //        objvViewRegion.TabName, objvPrjTabFld.FldName);
            //    sbMessage.AppendFormat(", ����ID = {0},�������� = {1}, �������� = {2}",
            //        objQryRegionFldsEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
            //    sbMessage.AppendFormat(", ��ǰ��Ϊ:{0}", objQryRegionFldsEx.GetType().ToString());
            //    string strOUTTabName = objvViewRegion.TabName;
            //    sbMessage.AppendFormat(", ��ǰ��������:{0}", strOUTTabName);
            //    throw new clsDbObjException(sbMessage.ToString());
            //}
            //return objFieldTabEN.FldName;
            return "";
        }
        /// <summary>
        /// ת�������--ֵ�ֶ�
        /// </summary>
        public static  string Ds_DataValueField4GetBak20230309(clsQryRegionFldsENEx objQryRegionFldsEx)
        {
            return "";
            //clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(objQryRegionFldsEx.DsDataValueFieldId, objQryRegionFldsEx.PrjId());
            //if (objFieldTabEN  ==  null || string.IsNullOrEmpty(objQryRegionFldsEx.DsDataValueFieldId))
            //{
            //    var objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objQryRegionFldsEx.FldId);
            //    clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objQryRegionFldsEx.RegionId);
            //    StringBuilder sbMessage = new StringBuilder();
            //    sbMessage.AppendFormat("�ڱ�[{0}]��,���ֶ�[{1}]������ת�������--ֵ�ֶΡ�",
            //        objvViewRegion.TabName, objvPrjTabFld.FldName);
            //    sbMessage.AppendFormat(", ����ID = {0},�������� = {1}, �������� = {2}",
            //        objQryRegionFldsEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
            //    sbMessage.AppendFormat(", ��ǰ��Ϊ:{0}", objQryRegionFldsEx.GetType().ToString());
            //    string strOUTTabName = objvViewRegion.TabName;
            //    sbMessage.AppendFormat(", ��ǰ��������:{0}", strOUTTabName);
            //    throw new clsDbObjException(sbMessage.ToString());
            //}
            //return objFieldTabEN.FldName;

        }

       
        public static ArrayList GetObjLstEx(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from QryRegionFlds where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count  ==  0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsQryRegionFldsENEx objQryRegionFldsEN = new clsQryRegionFldsENEx();
                objQryRegionFldsEN.mId = Int32.Parse(objRow["mId"].ToString().Trim());
                objQryRegionFldsEN.RegionId = objRow["RegionId"].ToString().Trim();
                objQryRegionFldsEN.FldId = objRow["FldId"].ToString().Trim();
                objQryRegionFldsEN.CtlTypeId = objRow["CtlTypeId"].ToString().Trim();
                objQryRegionFldsEN.DsTabId = objRow["DsTabId"].ToString().Trim();
                objQryRegionFldsEN.QueryOptionId = objRow["QueryOptionId"].ToString().Trim();
                objQryRegionFldsEN.DdlItemsOptionId = objRow["DdlItemsOptionId"].ToString().Trim();
                objQryRegionFldsEN.DsSqlStr = objRow["DsSqlStr"].ToString().Trim();
                //objQryRegionFldsEN.Ds_DataTextFieldId = objRow["Ds_DataTextFieldId"].ToString().Trim();
                //objQryRegionFldsEN.DsDataValueFieldId = objRow["DsDataValueFieldId"].ToString().Trim();
                objQryRegionFldsEN.ItemsString = objRow["ItemsString"].ToString().Trim();
                objQryRegionFldsEN.DsCondStr = objRow["DsCondStr"].ToString().Trim();
                objQryRegionFldsEN.SeqNum = clsGeneralTab2.TransNullToInt_S(objRow["SeqNum"].ToString().Trim());
                objQryRegionFldsEN.UpdDate = objRow["UpdDate"].ToString().Trim();
                objQryRegionFldsEN.UpdUser = objRow["UpdUser"].ToString().Trim();
                objQryRegionFldsEN.Memo = objRow["Memo"].ToString().Trim();
                arrObjList.Add(objQryRegionFldsEN);
            }
            objDT = null;
            return arrObjList;
        }




        ///���ɰ�ListView�Ĵ���
        /// <summary>
        /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��ListView�С�
        /// </summary>
        public static int BindLv_QryRegionFlds(System.Windows.Forms.ListView lvQryRegionFlds, string strWhereCond)
        {
            //��������:(��4��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3������ListView����ͷ��Ϣ
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

            System.Windows.Forms.ListViewItem lviQryRegionFlds;
            List<clsQryRegionFldsEN> arrQryRegionFldsObjList;
            //	2��������������ȡ�ñ�����������DataTable��
            arrQryRegionFldsObjList = clsQryRegionFldsBL.GetObjLst(strWhereCond);
            //	3������ListView����ͷ��Ϣ
            lvQryRegionFlds.Items.Clear();//���ԭ������Item
            lvQryRegionFlds.Columns.Clear();//���ԭ��������ͷ��Ϣ
            lvQryRegionFlds.Columns.Add("mId", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("����Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("���ֶ�ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("�ؼ����ͺ�", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("����Դ��ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("��ѯ��ʽId", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("�������б�ѡ��ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("����ԴSQL��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("����Դ�ı��ֶ�Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("����Դֵ�ֶ�Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("�б��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("����Դ������", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("�ֶ����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("�޸�ʱ��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("�û�ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("˵��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.View = System.Windows.Forms.View.Details;
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            foreach (clsQryRegionFldsEN objQryRegionFldsEN in arrQryRegionFldsObjList)
            {
                lviQryRegionFlds = new System.Windows.Forms.ListViewItem();
                lviQryRegionFlds.Tag = objQryRegionFldsEN.mId;
                lviQryRegionFlds.Text = objQryRegionFldsEN.RegionId.ToString();
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.FldId.ToString());
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.CtlTypeId);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.DsTabId);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.QueryOptionId);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.DdlItemsOptionId);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.DsSqlStr);
                //lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.Ds_DataTextFieldId);
                //lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.DsDataValueFieldId);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.ItemsString);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.DsCondStr);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.SeqNum.ToString());
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.UpdDate);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.UpdUser);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.Memo);
                lvQryRegionFlds.Items.Add(lviQryRegionFlds);
            }
            //	4�����ü�¼����״̬,
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            return arrQryRegionFldsObjList.Count;
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
            //
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

            var objQryRegionFldsEN = clsQryRegionFldsBLEx.GetObjBymId(lngMid);
            //var objQryRegionFldsENEx = CopyToEx(objQryRegionFldsEN);
            intSeqNum = objQryRegionFldsEN.SeqNum??0;
            intPrevSeqNum = intSeqNum - 1;
            intNextSeqNum = intSeqNum + 1;
            //3�������ǰ����Ƿ���ĩ�����,
            //		3.1 �����ĩ�����,���˳�,
            strCurrRegionId = objQryRegionFldsEN.RegionId;		//��ȡ��ǰ��¼��{��ID}
            intTabRecNum = clsGeneralTab2.funGetRecCountByCond(clsQryRegionFldsEN._CurrTabName, "RegionId = '" + strCurrRegionId + "'");	//��ȡ��ǰ{��ID}�ļ�¼��
            if (strDirect  ==  "UP")
            {
                if (intSeqNum <=  1)
                {
                    throw new clsDbObjException("�Ѿ��ǵ�һ����¼,����������!");
                }
            }
            else if (strDirect  ==  "DOWN")
            {
                if (intSeqNum >=  intTabRecNum)	//�����ǰ��Ŵ��ڱ��¼��
                {
                    throw new clsDbObjException("�Ѿ������һ����¼,����������!");
                }
            }
            ///		3.2 �������,������������ƶ�,���жϵ�ǰ����Ƿ�С�ڡ���ǰ���е��ֶ���,
            ///		    ���������һ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1,
            ///		    ����������ƶ�,���жϵ�ǰ����Ƿ񡰴��ڡ�1,
            ///		    �������ʼһ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1��

            //4����ȡ��(��)һ������ֶεĹؼ���Mid
            if (strDirect  ==  "UP")
            {
                strCondition.AppendFormat("RegionId = '{0}' and SeqNum = {1}",
                    strCurrRegionId, intSeqNum - 1);
                arrID = clsQryRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
                if (arrID  ==  null)
                {
                    throw new clsDbObjException("��ȡ��һ����¼�Ĺؼ��ֳ���!");

                }
                if (arrID.Count <=  0)
                {
                    throw new clsDbObjException("��ȡ��һ����¼�Ĺؼ��ֳ���!");
                }
                lngPrevMid = long.Parse((string)arrID[0]);
            }
            else if (strDirect  ==  "DOWN")
            {
                strCondition.AppendFormat("RegionId = '{0}' and SeqNum = {1}",
                    strCurrRegionId, intSeqNum + 1);
                arrID = clsQryRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
                if (arrID  ==  null)
                {
                    throw new clsDbObjException("��ȡ��һ����¼�Ĺؼ��ֳ���!");

                }
                if (arrID.Count <=  0)
                {
                    throw new clsDbObjException("��ȡ��һ����¼�Ĺؼ��ֳ���!");
                }
                lngNextMid = long.Parse((string)arrID[0]);
            }
            else if (strDirect  ==  "FIRST")
            {
            }
            else if (strDirect  ==  "LAST")
            {
            }
            else
            {
                throw new clsDbObjException("�����������!");
            }
            //5���ѵ�ǰ�ؼ���Mid����ż�(��)1
            //6������һ����ŵĹؼ���Mid��(��)1
            if (strDirect  ==  "UP")
            {
                clsQryRegionFldsBL.SetFldValue(clsQryRegionFldsEN._CurrTabName, "SeqNum", intSeqNum - 1, "MId = " + lngMid);
                clsQryRegionFldsBL.SetFldValue(clsQryRegionFldsEN._CurrTabName, "SeqNum", intPrevSeqNum + 1, "MId = " + lngPrevMid);
            }
            else if (strDirect  ==  "DOWN")
            {
                clsQryRegionFldsBL.SetFldValue(clsQryRegionFldsEN._CurrTabName, "SeqNum", intSeqNum + 1, "MId = " + lngMid);
                clsQryRegionFldsBL.SetFldValue(clsQryRegionFldsEN._CurrTabName, "SeqNum", intNextSeqNum - 1, "MId = " + lngNextMid);
            }
            else if (strDirect  ==  "FIRST")
            {
                clsQryRegionFldsBL.SetFldValue(clsQryRegionFldsEN._CurrTabName, "SeqNum", 0, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            else if (strDirect  ==  "LAST")
            {
                clsQryRegionFldsBL.SetFldValue(clsQryRegionFldsEN._CurrTabName, "SeqNum", intTabRecNum + 1, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            //7��������ʾDATAGRID
            clsQryRegionFldsBL.ReFreshCache(objQryRegionFldsEN.PrjId);
            return true;
        }
        public new static void ReOrder(string lngRegionId)
        {
            IEnumerable<clsQryRegionFldsEN> arrQryRegionFldsObjList = clsQryRegionFldsBL.GetObjLst("RegionId = '" + lngRegionId + "' order by SeqNum ");

            arrQryRegionFldsObjList = arrQryRegionFldsObjList.OrderByDescending(x => x.InUse).ThenBy(x => x.SeqNum);

            int intIndex = 1;
            foreach (clsQryRegionFldsEN objQryRegionFldsEN in arrQryRegionFldsObjList)
            {
                objQryRegionFldsEN.SeqNum = intIndex;
                clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN);
                intIndex++;
            }
        }

        public static bool AddColumn_SourceTabName(ref System.Data.DataTable objDT)
        {
            objDT.Columns.Add("SourceTabName");
            foreach (DataRow objDR in objDT.Rows)
            {
                string strPrjId = objDR[convQryRegionFlds.PrjId].ToString();
                //string 1strFldID = objDR[convQryRegionFlds.FldId].ToString();
                string strFldName = objDR[convQryRegionFlds.FldName].ToString();
                string strTabId = objDR[convQryRegionFlds.TabId].ToString();
                try
                {
                    //var strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
                    clsvSqlViewFldEN objvSqlViewFldEN = clsvSqlViewFldBLEx.GetvSqlViewFldObjByTabIdFieldAliasesExCache(strPrjId, strTabId, strFldName);
                    if (objvSqlViewFldEN  ==  null)
                    {
                        objvSqlViewFldEN = clsvSqlViewFldBLEx.GetvSqlViewFldObjByTabIdFldNameExCache(strPrjId, strTabId, strFldName);

                    }
                    if (objvSqlViewFldEN !=  null)
                    {
                        objDR["SourceTabName"] = objvSqlViewFldEN.TabName;
                    }
                }
                catch (Exception objException)
                {
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
                }
            }

            return true;
        }

        public static List<ASPControlGroupEx> GetControlGroup(string lngRegionId, clsViewInfoENEx objViewInfoENEx, string strItemName4MultiModel)
        {
                       
            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst = objViewInfoENEx.arrQryRegionFldSet.Select(obj=> clsASPControlGroupBLEx.GetControlGroup_Asp(obj, objViewInfoENEx.PrjId, strItemName4MultiModel));
            //�Ѳ�ѯ��ť�ӽ���
            //ASPControlGroupEx objASPControlGroup = clsASPControlGroupBLEx.GetbtnQuery();
            //List<ASPControlGroupEx> arrButtonObjLst = new List<ASPControlGroupEx>();
            //arrButtonObjLst.Add(objASPControlGroup);

            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
            if (objViewInfoENEx.arrFeatureRegionFlds == null)
            {
                string strMsg = string.Format("���湦����Ϊ�գ�����ӽ��湦�ܣ�����:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            IEnumerable<ASPControlGroupEx> arrButtonGroupLst = null;
           
                arrButtonGroupLst = objViewInfoENEx.arrFeatureRegionFlds
                    .Where(x => x.RegionId == lngRegionId)
                    .Select(x=>clsFeatureRegionFldsBLEx.GetButtonGroup(x, objViewInfoENEx.ApplicationTypeId));
           
            //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonObjLst);

            arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonGroupLst);
            return arrASPControlGroupObjLst.ToList();

        }

        //public static IEnumerable<VueControlGroupEx> GetControlGroup_Vue(string lngRegionId, clsViewInfoENEx objViewInfoENEx, string strItemName4MultiModel, bool bolIs4PureHtml = false)
        //{

        //    IEnumerable<VueControlGroupEx> arrASPControlGroupObjLst = objViewInfoENEx.arrQryRegionFldSet.Select(obj => clsVueControlGroupBLEx.GetControlGroup_Asp(obj, strItemName4MultiModel, bolIs4PureHtml));
        //    //�Ѳ�ѯ��ť�ӽ���
        //    //VueControlGroupEx objASPControlGroup = clsVueControlGroupBLEx.GetbtnQuery();
        //    //List<VueControlGroupEx> arrButtonObjLst = new List<VueControlGroupEx>();
        //    //arrButtonObjLst.Add(objASPControlGroup);

        //    IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
        //    if (objViewInfoENEx.arrFeatureRegionFlds == null)
        //    {
        //        string strMsg = string.Format("���湦����Ϊ�գ�����ӽ��湦�ܣ�����:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    IEnumerable<VueControlGroupEx> arrButtonGroupLst = null;
        //    arrButtonGroupLst = objViewInfoENEx.arrFeatureRegionFlds
        //            .Where(x => x.RegionId == lngRegionId)
        //            .Select(clsFeatureRegionFldsBLEx.GetButtonGroup4Vue);
            
        //    //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonObjLst);

        //    arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonGroupLst);
        //    return arrASPControlGroupObjLst;

        //}

        public static IEnumerable<ASPControlGroupEx> GetControlGroupV2(string lngRegionId,    string strCmPrjId, string strPrjId,
            string strItemName4MultiModel, bool bolIs4PureHtml = false)
        {
            clsvViewRegionEN objViewRegion = clsvViewRegionBL.GetObjByRegionIdCache(lngRegionId, strCmPrjId);

            //Func<clsQryRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4MultiModel = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, strItemName4MultiModel);
            List<clsQryRegionFldsENEx> arrQryRegionFlds = clsQryRegionFldsBLEx.GetObjExLstByRegionIdCacheEx(lngRegionId, strCmPrjId);

            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst = arrQryRegionFlds.Select(x=> clsASPControlGroupBLEx.GetControlGroup_Asp(x, strCmPrjId,  strItemName4MultiModel));
            //�Ѳ�ѯ��ť�ӽ���
            //ASPControlGroupEx objASPControlGroup = clsASPControlGroupBLEx.GetbtnQuery();
            //List<ASPControlGroupEx> arrButtonObjLst = new List<ASPControlGroupEx>();
            //arrButtonObjLst.Add(objASPControlGroup);

            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = clsFeatureRegionFldsBLEx.GetObjExLstByRegionIdEx(lngRegionId, strPrjId);//  objViewInfoENEx.arrFeatureRegionFlds;
            if (arrFeatureRegionFldsObjLst == null)
            {
                
                string strMsg = string.Format("���湦����Ϊ�գ�����ӽ��湦�ܣ���ǰ�����:{0}. (In {1})", objViewRegion.TabName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            Func<clsFeatureRegionFldsENEx, ASPControlGroupEx> GetButtonGroupV2 = obj => clsFeatureRegionFldsBLEx.GetButtonGroup(obj, objViewRegion.ApplicationTypeId ?? 0);

        IEnumerable<ASPControlGroupEx> arrButtonGroupLst = arrFeatureRegionFldsObjLst
                .Where(x => x.RegionId == lngRegionId)
                .Select(GetButtonGroupV2);

            //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonObjLst);

            arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonGroupLst);
            return arrASPControlGroupObjLst;

        }
        /// <summary>
        /// ����:�����ֶο��ã�ͬʱ���ö�����¼��
        /// </summary>
        /// <param name = "arrmIdLst">�����Ĺؼ���ֵ�б�</param>
        /// <param name = "intColSpan">������</param>
        /// <param name = "strUpdUser">�����Ĺؼ���ֵ�б�</param>
        /// <returns>�������ÿ��õļ�¼��</returns>
        public static int SetColSpan(List<long> arrmIdLst, int intColSpan, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (long strMid in arrmIdLst)
                {
                    clsQryRegionFldsEN objQryRegionFldsEN = clsQryRegionFldsBL.GetObjBymId(strMid);
                    objQryRegionFldsEN.ColSpan = intColSpan;
                    objQryRegionFldsEN.UpdUser = strUpdUser;
                    objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("�����ֶο���������,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static int SetWidth(List<long> arrmIdLst, int intWidth, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (long strMid in arrmIdLst)
                {
                    clsQryRegionFldsEN objQryRegionFldsEN = clsQryRegionFldsBL.GetObjBymId(strMid);
                    objQryRegionFldsEN.Width = intWidth;
                    objQryRegionFldsEN.UpdUser = strUpdUser;
                    objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("�����ֶο���������,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static clsQryRegionFldsENEx GetObjExBymIdCache(long lngMid, string strCmPrjId)
        {
            //��ʼ���б���
            clsQryRegionFldsEN objQryRegionFlds = clsQryRegionFldsBL.GetObjBymIdCache(lngMid, strCmPrjId);
            var objEx = CopyToEx(objQryRegionFlds);
            return objEx;
        }
    }
}