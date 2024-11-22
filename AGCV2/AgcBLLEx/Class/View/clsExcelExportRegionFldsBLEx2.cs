using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commexception;
using com.taishsoft.commdb;

using System.Collections.Generic;
using AGC.Entity;
using AGC.BusinessLogic;
using System.Linq;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace AGC.BusinessLogicEx
{
	public partial class clsExcelExportRegionFldsBLEx 
	{
        public List<clsPrjTabFldENEx> arrFieldTabExObjLst = null;			//���������ϸ���ֶμ���

		public clsPrjTabFldENEx objPrjTabFldENEx = null;

        public static void initExcelExportRegionFldSet(clsViewInfoENEx objViewInfoENEx)
        {
            //����:
            //1���жϳ�ʼ�����Ƿ�Ϸ�
            //2���ѱ��������Ϣ��ʼ����һ���������,
            //  Ȼ��浽������
            //3��
            ///
            objViewInfoENEx.TabKeyFldNum = 0;

            //��ȡ����ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache(objViewInfoENEx.ViewId,
                clsRegionTypeENEx.EXCELEXPORT_REGION, objViewInfoENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            //objViewInfoENEx.objExcelExportRegionENEx = new clsExcelExportRegionENEx(lngRegionId);
            //clsExcelExportRegionBLEx.GetExcelExportRegionEx(ref objViewInfoENEx.objExcelExportRegionENEx, objViewInfoENEx.PrjId);

            objViewInfoENEx.arrExcelExportRegionFldSet = clsExcelExportRegionFldsBLEx.GetObjExLst4InUse1(lngRegionId, objViewInfoENEx.PrjId);

            //objViewInfoENEx.objExcelExportRegionENEx.FieldNum = objViewInfoENEx.arrExcelExportRegionFldSet.Count;
            foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
            {
				try
				{
					objExcelExportRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objExcelExportRegionFldsEx.FldId, objViewInfoENEx.PrjId);
				}
				catch(Exception objException)
                {
                    Console.WriteLine(objException.ToString());
                }
            }
        }


      



        ///���ɰ�ListView�Ĵ���
        /// <summary>
        /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��ListView�С�
        /// </summary>
        public static int BindLv_ExcelExportRegionFlds(System.Windows.Forms.ListView lvExcelExportRegionFlds, string strWhereCond)
		{
			//��������:(��4��)
			//	1����Ͻ�����������
			//	2��������������ȡ�ñ�����������DataTable��
			//	3������ListView����ͷ��Ϣ
			//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
			//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

			System.Windows.Forms.ListViewItem lviExcelExportRegionFlds;
            List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjList;
			//	2��������������ȡ�ñ�����������DataTable��
			arrExcelExportRegionFldsObjList = clsExcelExportRegionFldsBL.GetObjLst(strWhereCond);
			//	3������ListView����ͷ��Ϣ
			lvExcelExportRegionFlds.Items.Clear();//���ԭ������Item
			lvExcelExportRegionFlds.Columns.Clear();//���ԭ��������ͷ��Ϣ
			lvExcelExportRegionFlds.Columns.Add("mId", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvExcelExportRegionFlds.Columns.Add("����Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvExcelExportRegionFlds.Columns.Add("���", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvExcelExportRegionFlds.Columns.Add("�б���", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvExcelExportRegionFlds.Columns.Add("���ֶ�ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvExcelExportRegionFlds.Columns.Add("�޸�����", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvExcelExportRegionFlds.Columns.Add("�û�ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvExcelExportRegionFlds.Columns.Add("˵��", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvExcelExportRegionFlds.View = System.Windows.Forms.View.Details;
			//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
			foreach (clsExcelExportRegionFldsEN objExcelExportRegionFldsEN in arrExcelExportRegionFldsObjList)
			{
				lviExcelExportRegionFlds = new System.Windows.Forms.ListViewItem();
				lviExcelExportRegionFlds.Tag = objExcelExportRegionFldsEN.mId;
				lviExcelExportRegionFlds.Text = objExcelExportRegionFldsEN.mId.ToString();
				lviExcelExportRegionFlds.SubItems.Add(objExcelExportRegionFldsEN.RegionId.ToString());
				lviExcelExportRegionFlds.SubItems.Add(objExcelExportRegionFldsEN.SeqNum.ToString());
				lviExcelExportRegionFlds.SubItems.Add(objExcelExportRegionFldsEN.ColCaption);
				lviExcelExportRegionFlds.SubItems.Add(objExcelExportRegionFldsEN.FldId.ToString());
				lviExcelExportRegionFlds.SubItems.Add(objExcelExportRegionFldsEN.UpdDate);
				lviExcelExportRegionFlds.SubItems.Add(objExcelExportRegionFldsEN.UpdUser);
				lviExcelExportRegionFlds.SubItems.Add(objExcelExportRegionFldsEN.Memo);
				lvExcelExportRegionFlds.Items.Add(lviExcelExportRegionFlds);
			}
			//	4�����ü�¼����״̬,
			//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
			return arrExcelExportRegionFldsObjList.Count;
		}
        public static ArrayList GetObjLstEx(string strCondition)
		{
			ArrayList arrObjList = new ArrayList(); 
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			strSQL = "Select * from ExcelExportRegionFlds where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count  ==  0)
			{
				objDT = null;
				return arrObjList;
			}
			foreach(DataRow objRow in objDT.Rows)
			{
				clsExcelExportRegionFldsENEx objExcelExportRegionFldsEN = new clsExcelExportRegionFldsENEx();
				objExcelExportRegionFldsEN.mId = Int32.Parse(objRow["mId"].ToString().Trim());
				objExcelExportRegionFldsEN.RegionId = objRow["RegionId"].ToString().Trim();
				objExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow["SeqNum"].ToString().Trim());
				objExcelExportRegionFldsEN.ColCaption = objRow["ColCaption"].ToString().Trim();
				objExcelExportRegionFldsEN.FldId = objRow["FldId"].ToString().Trim();
				objExcelExportRegionFldsEN.UpdDate = objRow["UpdDate"].ToString().Trim();
				objExcelExportRegionFldsEN.UpdUser = objRow["UpdUser"].ToString().Trim();
				objExcelExportRegionFldsEN.Memo = objRow["Memo"].ToString().Trim();
				arrObjList.Add(objExcelExportRegionFldsEN);
			}
			objDT = null;
			return arrObjList;
		}
		public new static void ReOrder(string lngRegionId)
		{
            IEnumerable<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjList = clsExcelExportRegionFldsBL.GetObjLst("RegionId = '" + lngRegionId + "' order by SeqNum ");
            arrExcelExportRegionFldsObjList = arrExcelExportRegionFldsObjList.OrderByDescending(x => x.InUse).ThenBy(x => x.SeqNum);

            int intIndex = 1;
			foreach(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN in arrExcelExportRegionFldsObjList)
			{
				objExcelExportRegionFldsEN.SeqNum = intIndex;
                clsExcelExportRegionFldsBL.UpdateBySql2(objExcelExportRegionFldsEN);
				intIndex ++;
			}
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
			///
			int intSeqNum;	//��ǰ��¼�����
			int intPrevSeqNum, intNextSeqNum;	//����������¼�����
			//			string strMid;
			long lngPrevMid = 0;	//��һ����ŵĹؼ���MId
			long lngNextMid = 0;	//��һ����ŵĹؼ���MId
			int intTabRecNum;       //��ǰ�����ֶεļ�¼��
            string strCurrRegionId;
			List<string > arrID;
			StringBuilder strCondition = new StringBuilder();
			//1����ȡ��ǰ��ѡ�е��ֶ�ID��

            clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = clsExcelExportRegionFldsBL.GetObjBymId(lngMid);
			intSeqNum = objExcelExportRegionFldsEN.SeqNum;
			intPrevSeqNum = intSeqNum - 1;
			intNextSeqNum = intSeqNum + 1;
			//3�������ǰ����Ƿ���ĩ�����,
			//		3.1 �����ĩ�����,���˳�,
			strCurrRegionId = objExcelExportRegionFldsEN.RegionId;		//��ȡ��ǰ��¼��{��ID}
			intTabRecNum = clsGeneralTab2.funGetRecCountByCond(clsExcelExportRegionFldsEN._CurrTabName, "RegionId = '" + strCurrRegionId + "'");	//��ȡ��ǰ{��ID}�ļ�¼��
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
					strCurrRegionId, intSeqNum -1);
				arrID = clsExcelExportRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
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
				arrID = clsExcelExportRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
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
                clsExcelExportRegionFldsBL.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, "SeqNum", intSeqNum-1, "MId = " + lngMid);
                clsExcelExportRegionFldsBL.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, "SeqNum", intPrevSeqNum + 1, "MId = " + lngPrevMid);
			}
			else if (strDirect  ==  "DOWN")
			{
                clsExcelExportRegionFldsBL.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, "SeqNum", intSeqNum + 1, "MId = " + lngMid);
                clsExcelExportRegionFldsBL.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, "SeqNum", intNextSeqNum - 1, "MId = " + lngNextMid);
			}
            else if (strDirect  ==  "FIRST")
            {
                clsExcelExportRegionFldsBL.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, "SeqNum", 0, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            else if (strDirect  ==  "LAST")
            {
                clsExcelExportRegionFldsBL.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, "SeqNum", intTabRecNum + 1, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            //7��������ʾDATAGRID
            clsExcelExportRegionFldsBL.ReFreshCache(objExcelExportRegionFldsEN.PrjId);

            return true;
		}


        public static bool AddColumn_SourceTabName(ref System.Data.DataTable objDT)
        {
            objDT.Columns.Add("SourceTabName");
            foreach (DataRow objDR in objDT.Rows)
            {
                string strPrjId = objDR[convExcelExportRegionFlds.PrjId].ToString();
                //string 1strFldID = objDR[convExcelExportRegionFlds.FldId].ToString();
                string strFldName = objDR[convExcelExportRegionFlds.FldName].ToString();
                string strTabId = objDR[convExcelExportRegionFlds.TabId].ToString();
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

		public static clsExcelExportRegionFldsENEx GetObjEx(clsExcelExportRegionFldsEN objExcelExportRegionFlds)
		{
			clsExcelExportRegionFldsENEx objExcelExportRegionFldsENEx = new clsExcelExportRegionFldsENEx();
			CopyTo(objExcelExportRegionFlds, objExcelExportRegionFldsENEx);
			return objExcelExportRegionFldsENEx;
		}

		public static List<clsExcelExportRegionFldsEN> GetObjLstByRegionIdEx(string lngRegionId)
		{
			//��ʼ���б���
			string strCondition = string.Format("{0}={1}", conExcelExportRegionFlds.RegionId, lngRegionId);
			List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLst_Sel = clsExcelExportRegionFldsBL.GetObjLst(strCondition);
			return arrExcelExportRegionFldsObjLst_Sel;

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
			var arrExcelExportRegionFlds = clsExcelExportRegionFldsBLEx.GetObjLstByRegionIdEx(strRegionId);
			var arrExcelExportRegionFldsEx = arrExcelExportRegionFlds.Select(clsExcelExportRegionFldsBLEx.GetObjEx).ToList();
			//StringBuilder sbErrMsg = new StringBuilder();
			//try
			//{

			foreach (var objInFor in arrExcelExportRegionFldsEx)
			{
				if (objInFor.InUse == false) continue;
				try
				{
					if (objInFor.DnPathId() != null )
                    {
						var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(objInFor.DnPathId(), objInFor.PrjId);
						clsDnPathBLEx.CheckDnPath(objDnPath, strOpUserId);
						if (objDnPath.ErrMsg != null && objDnPath.ErrMsg.Length > 0)
                        {
							strMsg = string.Format("�ؼ�:[{0}]�У�·������:[{1}].({2})",
		  objInFor.ColCaption, objDnPath.ErrMsg,
		clsStackTrace.GetCurrClassFunctionByLevel(2));
							throw new Exception(strMsg);
						}
						//clsPubFun4BLEx.CheckDnPath_In(objInFor);
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
			var objErrMsg = new clsErrMsgENEx(conErrType.ExcelExportRegion, intErrCount);
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

		public static clsExcelExportRegionFldsENEx GetObjExBymIdCache(long lngMid, string strPrjId)
		{
			//��ʼ���б���
			clsExcelExportRegionFldsEN objExcelExportRegionFlds = clsExcelExportRegionFldsBL.GetObjBymIdCache(lngMid, strPrjId);
			var objEx = CopyToEx(objExcelExportRegionFlds);
			return objEx;
		}
	}
}