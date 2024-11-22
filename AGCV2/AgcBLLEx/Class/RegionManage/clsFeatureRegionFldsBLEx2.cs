
///----------------------
///���ɴ���汾:2012.01.02.1
///��������:2012/10/08
///������:���Է�
///��������:AGC
///����ID:0005
///ģ��������:�������
///ģ��Ӣ����:RegionManage
///ע��:1����Ҫ���ݵײ�(PubDataBase.dll)�İ汾:2011.05.08.1
///       2����Ҫ����������(TzPubFunction.dll)�İ汾:2011.05.08.1
/// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;

using System.Collections.Generic;
using AGC.Entity;
using AGC.DAL;
using AGC.BusinessLogic;


using com.taishsoft.common;
using System.Linq;
using com.taishsoft.datetime;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// ���������ֶ��б�(FeatureRegionFlds)
    /// </summary>
    public partial class clsFeatureRegionFldsBLEx 
    {
        public clsCtlTypeEN objCtlType = null;
        public static void initFeatureRegionFldSet(clsViewInfoENEx objViewInfoENEx)
        {
            List<string> arrRegionId  = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(objViewInfoENEx.ViewId, objViewInfoENEx.PrjId);
            //			clsViewFldInfo objViewFldInfo = new clsViewFldInfo(objViewInfoENEx.ViewId);
            objViewInfoENEx.TabKeyFldNum = 0;

            //��ȡ����ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache(objViewInfoENEx.ViewId,
                clsRegionTypeENEx.FEATUREREGION, objViewInfoENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            //objViewInfoENEx.objFeatureRegionENEx = new clsFeatureRegionENEx(lngRegionId);
            //clsFeatureRegionBLEx.GetFeatureRegionEx(ref objViewInfoENEx.objFeatureRegionENEx, objViewInfoENEx.PrjId);

            objViewInfoENEx.arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjExLst1(arrRegionId, objViewInfoENEx.PrjId);

            //objViewInfoENEx.objFeatureRegionENEx.FieldNum = objViewInfoENEx.arrFeatureRegionFlds.Count;
            objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst = new List<clsvFunction4GeneCodeEN>();
            foreach (clsFeatureRegionFldsENEx objFeatureRegionFldsEx in objViewInfoENEx.arrFeatureRegionFlds)
            {
                if (string.IsNullOrEmpty(objFeatureRegionFldsEx.ReleFldId) == false)
                {
                    objFeatureRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.GetObjExByFldIDCache(objFeatureRegionFldsEx.ReleFldId, objViewInfoENEx.PrjId);
                }
                objFeatureRegionFldsEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objFeatureRegionFldsEx.CtlTypeId);
                IEnumerable<clsvFunction4GeneCodeEN> arrObjLst = clsvFunction4GeneCodeBLEx.GetObjLstByFeatureIdCache(objFeatureRegionFldsEx.FeatureId);
                foreach(clsvFunction4GeneCodeEN objInFor in arrObjLst)
                {
                    if (objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst.Find(x=>x.FuncId4GC == objInFor.FuncId4GC) == null)
                    {
                        objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst.Add(objInFor);
                    }
                }
            }
          
        }


        ///���ɰ�ListView�Ĵ���
        /// <summary>
        /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��ListView�С�
        /// </summary>
        public static int BindLv_FeatureRegionFlds(System.Windows.Forms.ListView lvFeatureRegionFlds, string strWhereCond)
        {
            //��������:(��4��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3������ListView����ͷ��Ϣ
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

            System.Windows.Forms.ListViewItem lviFeatureRegionFlds;
            List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjList;
            //	2��������������ȡ�ñ�����������DataTable��
            arrFeatureRegionFldsObjList = clsFeatureRegionFldsBL.GetObjLst(strWhereCond);
            //	3������ListView����ͷ��Ϣ
            lvFeatureRegionFlds.Items.Clear();//���ԭ������Item
            lvFeatureRegionFlds.Columns.Clear();//���ԭ��������ͷ��Ϣ
            lvFeatureRegionFlds.Columns.Add("���湦��Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("����Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("��ť����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("�ı�����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("�ؼ����ͺ�", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("�߶�", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("�ֶ����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("��ʽ��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("ͼƬ��Դ", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("�û�ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("�޸�����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("˵��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.View = System.Windows.Forms.View.Details;
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            foreach (clsFeatureRegionFldsEN objFeatureRegionFlds in arrFeatureRegionFldsObjList)
            {
                lviFeatureRegionFlds = new System.Windows.Forms.ListViewItem();
                lviFeatureRegionFlds.Tag = objFeatureRegionFlds.ViewFeatureId;
                lviFeatureRegionFlds.Text = objFeatureRegionFlds.ViewFeatureId.ToString();
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.ButtonName);
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.Text);
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.Height.ToString());
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.Width.ToString());
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.SeqNum.ToString());
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.CssClass);
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.ImageUrl);
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.UpdUser);
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.UpdDate);
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.Memo);
                lvFeatureRegionFlds.Items.Add(lviFeatureRegionFlds);
            }
            //	4�����ü�¼����״̬,
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            return arrFeatureRegionFldsObjList.Count;
        }

        ///// <summary>
        ///// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
        ///// </summary>
        ///// <param name = "lngmId">�����Ĺؼ���</param>
        ///// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>
        //public static clsFeatureRegionFldsEN GetFeatureRegionFldsObjBymId(long lngmId)
        //{
        //    if (arrFeatureRegionFldsObjLst  ==  null)
        //    {
        //        arrFeatureRegionFldsObjLst = clsFeatureRegionFldsBL.GetObjLst("1 = 1");
        //    }
        //    foreach (clsFeatureRegionFldsEN objFeatureRegionFlds in arrFeatureRegionFldsObjLst)
        //    {
        //        if (objFeatureRegionFlds.mId  ==  lngmId)
        //        {
        //            return objFeatureRegionFlds;
        //        }
        //    }
        //    return null;
        //}

        /// <summary>
        /// ��ȡ�������������м�¼�����б�,�ö����б����ʽ��ʾ
        /// </summary>
        /// <param name = "strCondition">������</param>
        /// <returns>�������������м�¼�����б�</returns>
        public List<clsFeatureRegionFldsENEx> GetObjLstEx(string strCondition)
        {
            List<clsFeatureRegionFldsENEx> arrObjList = new List<clsFeatureRegionFldsENEx>();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
            strSQL = "Select * from FeatureRegionFlds where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count  ==  0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsFeatureRegionFldsENEx objFeatureRegionFlds = new clsFeatureRegionFldsENEx();
                objFeatureRegionFlds.ViewFeatureId = objRow["ViewFeatureId"].ToString().Trim(); //mId
                objFeatureRegionFlds.RegionId = objRow["RegionId"].ToString().Trim(); //����Id
                objFeatureRegionFlds.ButtonName = objRow["ButtonName"].ToString().Trim(); //��ť����
                objFeatureRegionFlds.Text = objRow["Text"].ToString().Trim(); //�ı�����
                objFeatureRegionFlds.CtlTypeId = objRow["CtlTypeId"].ToString().Trim(); //�ؼ����ͺ�
                objFeatureRegionFlds.Height = clsGeneralTab2. TransNullToInt_S(objRow["Height"].ToString().Trim()); //�߶�
                objFeatureRegionFlds.Width = clsGeneralTab2. TransNullToInt_S(objRow["Width"].ToString().Trim()); //��
                objFeatureRegionFlds.SeqNum = clsGeneralTab2. TransNullToInt_S(objRow["SeqNum"].ToString().Trim()); //�ֶ����
                objFeatureRegionFlds.CssClass = objRow["CssClass"].ToString().Trim(); //��ʽ��
                objFeatureRegionFlds.ImageUrl = objRow["ImageUrl"].ToString().Trim(); //ͼƬ��Դ
                objFeatureRegionFlds.UpdUser = objRow["UpdUser"].ToString().Trim(); //�û�ID
                objFeatureRegionFlds.UpdDate = objRow["UpdDate"].ToString().Trim(); //�޸�����
                objFeatureRegionFlds.Memo = objRow["Memo"].ToString().Trim(); //˵��
                objFeatureRegionFlds.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
                arrObjList.Add(objFeatureRegionFlds);
            }
            objDT = null;
            return arrObjList;
        }
        /// <summary>
        /// ��չɾ����¼����ͬʱɾ�������ļ�¼����Ҫ����ԭ���Ե�������
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
        /// </summary>
        /// <param name="strViewFeatureId">��ؼ���</param>
        /// <returns></returns>
        public static bool DelRecordEx(string strViewFeatureId, string strPrjId, string strOpUserId)
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
            //ɾ��TeacherInfo�������뵱ǰ�����йصļ�¼
            SqlConnection objConnection = null;
            SqlTransaction objSqlTransaction = null;
            try
            {
                //��ȡ���Ӷ���
                objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
                //��ȡ�����Ӷ����е�����
                objSqlTransaction = objConnection.BeginTransaction();
                //
                //ɾ�����:[FeatureRegionFlds]��صı�Ĵ��룬��Ҫʱȥ��ע�ͣ���д��صĴ���
                string strCondition = string.Format("{0} = '{1}'",
                conFeatureRegionFlds.ViewFeatureId,                strViewFeatureId);
                clsViewFeatureFldsBL.DelViewFeatureFldssByCondWithTransaction_S(strCondition, strPrjId, objConnection, objSqlTransaction);

                clsFeatureRegionFldsBL.DelRecord(strViewFeatureId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsFeatureRegionFldsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("��չɾ����¼����:{0}��KeyId = {1}.({2})",
                objException.Message,
                strViewFeatureId, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                if (objSqlTransaction != null)
                {
                    objSqlTransaction.Rollback();
                }
                throw new Exception(strMsg);
            }
            finally
            {
                objConnection.Close();
            }
        }
        public static void ReOrderEx(string lngRegionId)
        {
            IEnumerable<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjList = clsFeatureRegionFldsBL.GetObjLst("RegionId = '" + lngRegionId + "' order by SeqNum ");
            arrFeatureRegionFldsObjList = arrFeatureRegionFldsObjList.OrderByDescending(x => x.InUse).ThenBy(x => x.SeqNum);
            int intIndex = 1;
            foreach (clsFeatureRegionFldsEN objFeatureRegionFldsEN in arrFeatureRegionFldsObjList)
            {
                objFeatureRegionFldsEN.SeqNum = intIndex;
                clsFeatureRegionFldsBL.UpdateBySql2(objFeatureRegionFldsEN);
                intIndex++;
            }
        }

        public static clsFeatureRegionFldsENEx GetObjEx(clsFeatureRegionFldsEN objFeatureRegionFlds)
        {
            clsFeatureRegionFldsENEx objFeatureRegionFldsENEx = new clsFeatureRegionFldsENEx();
            CopyTo(objFeatureRegionFlds, objFeatureRegionFldsENEx);
            return objFeatureRegionFldsENEx;
        }

        public static List<clsFeatureRegionFldsEN> GetObjLstByRegionIdEx(string lngRegionId)
        {
            //��ʼ���б���
            string strCondition = string.Format("{0}={1}", conFeatureRegionFlds.RegionId, lngRegionId);
            List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLst_Sel = clsFeatureRegionFldsBL.GetObjLst(strCondition);
            return arrFeatureRegionFldsObjLst_Sel;

        }
        public static clsErrMsgENEx CheckRegionFlds(string strRegionId, string strCmPrjId, string strOpUserId)
        {
            string strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);

            //1����ȡ��ǰ����ID���������ID��
            //clsvViewRegionEN objvViewRegionEN = clsvViewRegionBL.GetObjByRegionId(lngRegionId);
            //string strTabName = objvViewRegionEN.TabName;
            //string strRelaTabId = objvViewRegionEN.TabId;
            string strMsg = "";
            int intErrCount = 0;
            var arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjLstByRegionIdEx(strRegionId);
            var arrFeatureRegionFldsEx = arrFeatureRegionFlds.Select(clsFeatureRegionFldsBLEx.GetObjEx).ToList();
            //StringBuilder sbErrMsg = new StringBuilder();
            //try
            //{

            foreach (var objInFor in arrFeatureRegionFldsEx)
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

                    objInFor.Update();
                    intErrCount++;
                    continue;
                }
                if (objInFor.ErrMsg != null && objInFor.ErrMsg.Length > 0)
                {
                    objInFor.ErrMsg = "";
                    objInFor.Update();
                    continue;
                }
            }

            var objErrMsg = new clsErrMsgENEx(conErrType.FeatureRegion, intErrCount);
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
    }
}