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
using com.taishsoft.datetime;

namespace AGC.BusinessLogicEx
{
    public partial class clsDGRegionFldsBLEx
    {

        public List<clsPrjTabFldENEx> arrFieldTabExObjLst = null;           //���������ϸ���ֶμ���

        public static void initDGRegionFldSet(clsViewInfoENEx objViewInfoENEx, bool bolIsFstLcase)
        {
            //����:
            //1���жϳ�ʼ�����Ƿ�Ϸ�
            //2���ѱ��������Ϣ��ʼ����һ���������,
            //  Ȼ��浽������
            //3��
            //
            objViewInfoENEx.TabKeyFldNum = 0;


            //��ȡ����ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache(objViewInfoENEx.ViewId,
                clsRegionTypeENEx.DGREGION, objViewInfoENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            //objViewInfoENEx.objDGRegionENEx = new clsDGRegionENEx(lngRegionId);
            //clsDGRegionBLEx.GetDGRegionEx(ref objViewInfoENEx.objDGRegionENEx, objViewInfoENEx.PrjId);
            objViewInfoENEx.arrDGRegionFldSet = clsDGRegionFldsBLEx.GetObjExList4InUse1(lngRegionId, objViewInfoENEx.PrjId);

            //objViewInfoENEx.objDGRegionENEx.FieldNum = objViewInfoENEx.arrDGRegionFldSet.Count;

            clsDGRegionFldsENEx objDGRegionFlds_Sel = objViewInfoENEx.arrDGRegionFldSet.Find(x=>x.IsDefaultSort == true);
            if (objDGRegionFlds_Sel != null)
            {
                //clsPrjTabFldENEx ObjPrjTabFldENEx = clsPrjTabFldBLEx.InitPrjTabFld(objDGRegionFlds_Sel.TabFldId, objViewInfoENEx.PrjId);         
                objViewInfoENEx.FirstSortField =
                    clsString.FstLcaseS(
                    clsFieldTabBL.GetNameByFldIdCache(objDGRegionFlds_Sel.FldId, objDGRegionFlds_Sel.PrjId()));                 
            }

            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet.FindAll(x=>string.IsNullOrEmpty( x.FldId) == false))            
            {
                objDGRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objDGRegionFldsEx.FldId, objViewInfoENEx.PrjId);
                //if (objViewInfoENEx.objSortField_Out == null && objDGRegionFldsEx.ObjPrjTabFldENEx.PrimaryTypeId != enumPrimaryType.Identity_02)
                //{
                //    objViewInfoENEx.objSortField_Out = objDGRegionFldsEx.ObjPrjTabFldENEx;
                //}
                
                //if (objDGRegionFldsEx.ObjPrjTabFldENEx.IsSortFld == true)
                //{
                //    objViewInfoENEx.objSortField_Out = objDGRegionFldsEx.ObjPrjTabFldENEx;
                //}

                if (string.IsNullOrEmpty(objViewInfoENEx.FirstSortField) == false) continue;
                if (objDGRegionFldsEx.IsNeedSort)
                {
                    objViewInfoENEx.FirstSortField = objDGRegionFldsEx.ObjFieldTabENEx.PropertyName(bolIsFstLcase);
                }
            }
        }
        /// <summary>
        /// ��ȡ��չ�����б�ͬʱ��ȡ��ر��������
        /// </summary>
        /// <param name="strViewId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<clsDGRegionFldsENEx> GetObjExLstEx(string strViewId, string strPrjId)
        {
            //��ȡ����ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache(strViewId,
                clsRegionTypeENEx.DGREGION, strPrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return null;
            }

            List<clsDGRegionFldsENEx> arrDGRegionFldSet = clsDGRegionFldsBLEx.GetObjExList(lngRegionId, strPrjId);
            
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in arrDGRegionFldSet)
            {
                //if (objDGRegionFldsEx.TabFldId == 0) continue;
                objDGRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objDGRegionFldsEx.FldId, strPrjId);
            }
            return arrDGRegionFldSet;
        }


        /// <summary>
        /// ��ȡ��չ�����б�
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public static List<clsDGRegionFldsENEx> GetObjExLst(string strCondition)
        {
            List<clsDGRegionFldsEN> arrObjList = clsDGRegionFldsBL.GetObjLst(strCondition);
            List<clsDGRegionFldsENEx> arrObjExLst = new List<clsDGRegionFldsENEx>();

            foreach (clsDGRegionFldsEN objInFor in arrObjList)
            {
                clsDGRegionFldsENEx objDGRegionFldsENEx = new clsDGRegionFldsENEx();
                clsDGRegionFldsBL.CopyTo(objInFor, objDGRegionFldsENEx);
                arrObjExLst.Add(objDGRegionFldsENEx);
            }

            return arrObjExLst;
        }



        ///���ɰ�ListView�Ĵ���
        /// <summary>
        /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��ListView�С�
        /// </summary>
        public static int BindLv_DGRegionFlds(System.Windows.Forms.ListView lvDGRegionFlds, string strWhereCond)
        {
            //��������:(��4��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3������ListView����ͷ��Ϣ
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

            System.Windows.Forms.ListViewItem lviDGRegionFlds;
            List<clsDGRegionFldsEN> arrDGRegionFldsObjList;
            //	2��������������ȡ�ñ�����������DataTable��
            arrDGRegionFldsObjList = clsDGRegionFldsBL.GetObjLst(strWhereCond);
            //	3������ListView����ͷ��Ϣ
            lvDGRegionFlds.Items.Clear();//���ԭ������Item
            lvDGRegionFlds.Columns.Clear();//���ԭ��������ͷ��Ϣ
            lvDGRegionFlds.Columns.Add("mId", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("�Ƿ���Ҫ����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("�����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("�б���", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("�Ƿ�ת����CheckBox", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("����Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("�Ƿ���ʾ", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("�Ƿ����ֶ�", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("Dg��������Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("�ؼ����ͺ�", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("�û�ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("˵��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("�޸�ʱ��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("���ֶ�ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.View = System.Windows.Forms.View.Details;
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            foreach (clsDGRegionFldsEN objDGRegionFlds in arrDGRegionFldsObjList)
            {
                lviDGRegionFlds = new System.Windows.Forms.ListViewItem();
                lviDGRegionFlds.Tag = objDGRegionFlds.mId;
                lviDGRegionFlds.Text = objDGRegionFlds.mId.ToString();
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.IsNeedSort.ToString());
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.SeqNum.ToString());
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.HeaderText);
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.IsTransToChkBox.ToString());
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.RegionId.ToString());
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.IsVisible.ToString());
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.IsFuncFld.ToString());
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.DgFuncTypeId);
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.CtlTypeId);
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.UpdUser);
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.Memo);
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.UpdDate);
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.FldId.ToString());
                lvDGRegionFlds.Items.Add(lviDGRegionFlds);
            }
            //	4�����ü�¼����״̬,
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            return arrDGRegionFldsObjList.Count;
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

            clsDGRegionFldsEN objDGRegionFlds = clsDGRegionFldsBL.GetObjBymId(lngMid);
            intSeqNum = objDGRegionFlds.SeqNum;
            intPrevSeqNum = intSeqNum - 1;
            intNextSeqNum = intSeqNum + 1;
            //3�������ǰ����Ƿ���ĩ�����,
            //		3.1 �����ĩ�����,���˳�,
            strCurrRegionId = objDGRegionFlds.RegionId;		//��ȡ��ǰ��¼��{��ID}
            intTabRecNum = clsGeneralTab2.funGetRecCountByCond(clsDGRegionFldsEN._CurrTabName, "RegionId = '" + strCurrRegionId + "'");	//��ȡ��ǰ{��ID}�ļ�¼��
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
            //		3.2 �������,������������ƶ�,���жϵ�ǰ����Ƿ�С�ڡ���ǰ���е��ֶ���,
            //		    ���������һ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1,
            //		    ����������ƶ�,���жϵ�ǰ����Ƿ񡰴��ڡ�1,
            //		    �������ʼһ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1��

            //4����ȡ��(��)һ������ֶεĹؼ���Mid
            if (strDirect  ==  "UP")
            {
                strCondition.AppendFormat("RegionId = '{0}' and SeqNum = {1}",
                    strCurrRegionId, intSeqNum - 1);
                arrID = clsDGRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
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
                arrID = clsDGRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
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
                clsDGRegionFldsBL.SetFldValue(clsDGRegionFldsEN._CurrTabName, "SeqNum", intSeqNum - 1, "MId = " + lngMid);
                clsDGRegionFldsBL.SetFldValue(clsDGRegionFldsEN._CurrTabName, "SeqNum", intPrevSeqNum + 1, "MId = " + lngPrevMid);
            }
            else if (strDirect  ==  "DOWN")
            {
                clsDGRegionFldsBL.SetFldValue(clsDGRegionFldsEN._CurrTabName, "SeqNum", intSeqNum + 1, "MId = " + lngMid);
                clsDGRegionFldsBL.SetFldValue(clsDGRegionFldsEN._CurrTabName, "SeqNum", intNextSeqNum - 1, "MId = " + lngNextMid);
            }
            else if (strDirect  ==  "FIRST")
            {
                clsDGRegionFldsBL.SetFldValue(clsDGRegionFldsEN._CurrTabName, "SeqNum", 0, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            else if (strDirect  ==  "LAST")
            {
                clsDGRegionFldsBL.SetFldValue(clsDGRegionFldsEN._CurrTabName, "SeqNum", intTabRecNum + 1, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            //7��������ʾDATAGRID
            clsDGRegionFldsBL.ReFreshCache(objDGRegionFlds.PrjId);
            return true;
        }
        public new static void ReOrder(string lngRegionId)
        {
            IEnumerable<clsDGRegionFldsEN> arrDGRegionFldsObjList = clsDGRegionFldsBL.GetObjLst("RegionId = '" + lngRegionId + "' order by SeqNum ");
            arrDGRegionFldsObjList = arrDGRegionFldsObjList.OrderByDescending(x => x.InUse).ThenBy(x=>x.SeqNum);
            int intIndex = 1;
            foreach (clsDGRegionFldsEN objDGRegionFlds in arrDGRegionFldsObjList)
            {
                objDGRegionFlds.SeqNum = intIndex;
            clsDGRegionFldsBL.UpdateBySql2(    objDGRegionFlds);
                intIndex++;
            }
        }


        public static bool AddColumn_SourceTabName(ref System.Data.DataTable objDT)
        {
            objDT.Columns.Add("SourceTabName");
            foreach (DataRow objDR in objDT.Rows)
            {
                string strPrjId = objDR[convDGRegionFlds.PrjId].ToString();
                //string 1strFldID = objDR[convDGRegionFlds.FldId].ToString();
                string strFldName = objDR[convDGRegionFlds.FldName].ToString();
                string strTabId = objDR[convDGRegionFlds.TabId].ToString();
                if (string.IsNullOrEmpty(strTabId) == true) continue;
                try
                {


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
        public static List<clsDGRegionFldsENEx> GetObjExLstByRegionIdEx1(string lngRegionId, string strCmPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, clsDGRegionFldsEN.con_InUse);

            List<clsDGRegionFldsENEx> arrObjENExList = new List<clsDGRegionFldsENEx>();
            List<clsDGRegionFldsEN> arrObjList = GetObjLstByRegionIdCache4InUseEx1(lngRegionId, strCmPrjId);
            foreach (clsDGRegionFldsEN objDGRegionFldsEN in arrObjList)
            {
                clsDGRegionFldsENEx objDGRegionFldsENEx = new clsDGRegionFldsENEx();
                CopyTo(objDGRegionFldsEN, objDGRegionFldsENEx);
                if (string.IsNullOrEmpty( objDGRegionFldsENEx.FldId) == false)
                {
                    objDGRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objDGRegionFldsEN.FldId, objDGRegionFldsENEx.PrjId());
                }
                objDGRegionFldsENEx.objCtlType = clsCtlTypeBLEx.GetObjByCtlTypeIdCache(objDGRegionFldsENEx.CtlTypeId);
                arrObjENExList.Add(objDGRegionFldsENEx);
            }
            return arrObjENExList;
        }

        public static List<clsDGRegionFldsEN> GetObjLstByTabIdCache(string strTabId, string strPrjId)
        {
            //��ʼ���б���
            List<clsDGRegionFldsEN> arrObjLstCache = clsDGRegionFldsBL.GetObjLstCache(strPrjId);
            List<clsViewRegionEN> arrViewRegion = clsViewRegionBLEx.GetObjLstByTabIdCache(strTabId, strPrjId);
            List<string> arrRegionId = arrViewRegion.Select(x=>x.RegionId).ToList();
            List<clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel = arrObjLstCache.Where(x => arrRegionId.Contains( x.RegionId) == true && x.InUse == true)
                .OrderBy(x => x.SeqNum)
                .ToList();
            return arrDGRegionFldsObjLst_Sel;
        }
        public static List<clsDGRegionFldsEN> GetObjLstByPrjIdCache(string strPrjId)
        {
            //��ʼ���б���
            List<clsDGRegionFldsEN> arrObjLstCache = clsDGRegionFldsBL.GetObjLstCache(strPrjId);
            List<clsViewRegionEN> arrViewRegion = clsViewRegionBLEx.GetObjLstByPrjIdCache(strPrjId);
            List<string> arrRegionId = arrViewRegion.Select(x => x.RegionId).ToList();
            List<clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel = arrObjLstCache.Where(x => arrRegionId.Contains(x.RegionId) == true && x.InUse == true)
                .OrderBy(x => x.SeqNum)
                .ToList();
            return arrDGRegionFldsObjLst_Sel;
        }

        //public static bool CheckOutDataNodeIdBak(clsDGRegionFldsEN objDGRegionFldsEx, string strCmPrjId, string strOpUser)
        //{
        //    string strMsg = "";
        //  long strOutDataNodeId = objDGRegionFldsEx.OutDataNodeId;
        //    try
        //    {
        //        var objDataNode_Out = clsDataNodeBL.GetObjByDataNodeIdCache(strOutDataNodeId, strCmPrjId);

        //        if (objDataNode_Out == null)
        //        {
        //            var strDataNodeId_New = clsDataNodeBLEx.GetNewDataNodeIdByCmPrjId(strOutDataNodeId, strCmPrjId);
        //            if (string.IsNullOrEmpty(strDataNodeId_New) == true)
        //            {
        //                var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
        //                var objDataNode = clsDataNodeBL.GetObjByDataNodeId(strOutDataNodeId);
        //                if (objDataNode == null)
        //                {
        //                    strMsg = string.Format("���Out���ʱ, ������:[{0}]�����ڡ��� CmPrjId={1}({2})�����飡(In {3})",
        //                         strOutDataNodeId, strCmPrjId, objCMProject.CmPrjName,
        //                        clsStackTrace.GetCurrClassFunction());
        //                    throw new Exception(strMsg);
        //                }
                  
        //                 strMsg = string.Format("ת�������У�����:[{0}], ������:[{1}]({2}), �����ڡ��� VersionNo=1, CmPrjId={3}�����飡(In {4})",
        //                     objDGRegionFldsEx.DataPropertyName,
        //                    objDataNode.DataNodeName, objDataNode.DataNodeId, strCmPrjId, objCMProject.CmPrjName,
        //                    clsStackTrace.GetCurrClassFunction());
        //                throw new Exception(strMsg);
        //            }
        //            else
        //            {
        //                strOutDataNodeId = strDataNodeId_New;
        //                objDGRegionFldsEx.OutDataNodeId = strDataNodeId_New;
        //                objDGRegionFldsEx.UpdDate = clsDateTime.getTodayDateTimeStr(1);
        //                objDGRegionFldsEx.UpdUser = strOpUser;
        //                clsDGRegionFldsBL.UpdateBySql2(objDGRegionFldsEx);
        //            }
        //        }
        //        return true;
        //    }
        //    catch (Exception objException)
        //    {
        //        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDGRegionFldsEx.FldId, objDGRegionFldsEx.PrjId());
        //        var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
        //        strMsg = string.Format("���OutDataNodeId:[{0}]ʱ(�ֶ�:[{1}({2})], ����:[{3}])������:{4}�� CmPrjId={5}({6})�����飡(In {7})",
        //            strOutDataNodeId, objFieldTab.FldName, objDGRegionFldsEx.FldId, objDGRegionFldsEx.DataPropertyName(),
        //            objException.Message,
        //            strCmPrjId, objCMProject.CmPrjName,
        //            clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //}

        public static bool CheckOutFldId(clsDGRegionFldsENEx objDGRegionFldsEx, bool bolIsFstLcase, string strCmPrjId, string strOpUser)
        {
            string strMsg = "";
            string strOutFldId = objDGRegionFldsEx.OutFldId;
            string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            try
            {
                var objFieldTab_Out = clsFieldTabBL.GetObjByFldIdCache(strOutFldId, strPrjId);

                if (objFieldTab_Out == null)
                {

                    var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);

                    strMsg = string.Format("���Out�ֶ�ʱ, ����ֶ�:[{0}]�����ڡ��� CmPrjId={1}({2})�����飡(In {3})",
                         strOutFldId, strCmPrjId, objCMProject.CmPrjName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);


                }
                return true;
            }
            catch (Exception objException)
            {
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDGRegionFldsEx.FldId, objDGRegionFldsEx.PrjId());
                var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
                strMsg = string.Format("���OutFldId:[{0}({1})], ����:[{2}])������:{3}�� CmPrjId={4}({5})�����飡(In {6})",
                    strOutFldId, objFieldTab.FldName, objDGRegionFldsEx.DataPropertyName(),
                    objException.Message,
                    strCmPrjId, objCMProject.CmPrjName,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }


        public static clsDGRegionFldsENEx GetObjEx(clsDGRegionFldsEN objDGRegionFlds)
        {
            clsDGRegionFldsENEx objDGRegionFldsENEx = new clsDGRegionFldsENEx();
            CopyTo(objDGRegionFlds, objDGRegionFldsENEx);
            return objDGRegionFldsENEx;
        }
        public static clsErrMsgENEx CheckRegionFlds(string strRegionId, string strCmPrjId, string strOpUserId)
        {
            //string strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);

            //1����ȡ��ǰ����ID���������ID��
            //clsvViewRegionEN objvViewRegionEN = clsvViewRegionBL.GetObjByRegionId(lngRegionId);
            //string strTabName = objvViewRegionEN.TabName;
            //string strRelaTabId = objvViewRegionEN.TabId;
            string strMsg = "";
            int intErrCount = 0;
            var arrDGRegionFlds = clsDGRegionFldsBLEx.GetObjLstByRegionIdEx(strRegionId);
            var arrDGRegionFldsEx = arrDGRegionFlds.Select(clsDGRegionFldsBLEx.GetObjEx).ToList();

            //StringBuilder sbErrMsg = new StringBuilder();
            //try
            //{

            foreach (var objInFor in arrDGRegionFldsEx)
            {
                if (objInFor.InUse == false) continue;
                try
                {
                    switch (objInFor.CtlTypeId)
                    {
                        case enumCtlType.DropDownList_06:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.DropDownList_Bool_18:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.TextBox_16:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.CheckBox_02:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.Button_01:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.Label_10:
                            if (objInFor.DnPathId() != null )
                            {
                                var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(objInFor.DnPathId(), objInFor.PrjId);
                                if (objDnPath != null)
                                {
                                    clsDnPathBLEx.CheckDnPath(objDnPath, strOpUserId);
                                    if (objDnPath.ErrMsg != null && objDnPath.ErrMsg.Length > 0)
                                    {
                                        strMsg = string.Format("�ؼ�:[{0}]�У�·������:[{1}].({2})",
                      objInFor.HeaderText, objDnPath.ErrMsg,
                    clsStackTrace.GetCurrClassFunctionByLevel(2));
                                        throw new Exception(strMsg);
                                    }
                                }
                            }
                            //clsPubFun4BLEx.CheckDnPath_In(objInFor);
                            break;
                        default:
                            var objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objInFor.CtlTypeId);
                            strMsg = string.Format("�ؼ�����:[{0}]({1})û�б�����(in {2})",
                                      objCtlType.CtlTypeName, objCtlType.CtlTypeId,
                                      clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
                }
                catch (Exception ex)
                {
                    objInFor.ErrMsg = ex.Message;
                    //if (objInFor.DnPathId == "") objInFor.DnPathId = null;
                    objInFor.Update();
                    intErrCount++;
                    continue;
                }
                if (objInFor.ErrMsg != null && objInFor.ErrMsg.Length > 0)
                {
                    objInFor.ErrMsg = "";
                    //if (objInFor.DnPathId == "") objInFor.DnPathId = null;
                    objInFor.Update();
                    continue;
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    sbErrMsg.AppendLine(ex.Message);
            //}
            //2����ȡ�������ID���ֶεĶ����б�;
            var objErrMsg = new clsErrMsgENEx(conErrType.ListRegion, intErrCount);
            var objViewRegion = clsViewRegionBL.GetObjByRegionId(strRegionId);
            if (objViewRegion != null)
            {
                if (intErrCount > 0)
                {
                    objViewRegion.ErrMsg = objErrMsg.ToString();
                    objViewRegion.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objViewRegion.Update();
                }
                else
                {
                    objViewRegion.ErrMsg = "";
                    objViewRegion.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objViewRegion.Update();
                }
            }
            return objErrMsg;
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

        public static clsDGRegionFldsENEx GetObjExBymIdCache(long lngMid, string strPrjId)
        {
            //��ʼ���б���
            clsDGRegionFldsEN objDGRegionFlds = clsDGRegionFldsBL.GetObjBymIdCache(lngMid, strPrjId);
            var objDGRegionFldsEx = CopyToEx(objDGRegionFlds);
            return objDGRegionFldsEx;
        }
    }
}