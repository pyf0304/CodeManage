using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using AGC.Entity;
using com.taishsoft.datetime;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
	/// <summary>
	/// clsSysLogSever ��ժҪ˵����
	/// </summary>
	public class clsSysLogServerBLEx
	{
		private static bool IsAddJournalWin;
		/// <summary>
		/// �������
		/// </summary>
		public static string Add="0001";

		/// <summary>
		/// ����ɾ��
		/// </summary>
		public static string Delete="0002";
		/// <summary>
		/// �����޸�
		/// </summary>
		public static string Update="0003";

		public clsSysLogServerBLEx()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
		/// <summary>
		/// �ڲ�����
		/// </summary>
		/// <param name="objSysLog"></param>
		/// <param name="strUserId">�û����</param>
		/// <param name="strUserIp">�û�IP</param>
		/// <param name="strOperationType">�û���������</param>
		/// <param name="strTableName">���ݱ������</param>
		/// <param name="strTableKey">���ݱ�Ĺؼ��ֶ�����</param>
		/// <param name="strJournal">��־����</param>
		private static void PutDataToSysLogClass(clsSysLogEN pobjSysLog,
			string strUserId,
			string strUserIp,
			string strOperationTypeId,
			string strTableName,
			string strTableKey,
			string strJournal,
			string strPrjId)
		{
			pobjSysLog.UserId = strUserId;
			//pobjSysLog.UserName = wucSysLog1.UserName;
			pobjSysLog.UserIp = strUserIp;
			pobjSysLog.OpDate = clsDateTime.getTodayStr(0);
			pobjSysLog.OpTime = DateTime.Now.ToShortTimeString();
			pobjSysLog.OpTypeId = strOperationTypeId;
			pobjSysLog.TableName = strTableName;
			pobjSysLog.TableKey = strTableKey;
			pobjSysLog.OpContent = strJournal;
			pobjSysLog.PrjId = strPrjId;
		}
		/// <summary>
		/// ִ�л�����Ϣ��־�����
		/// </summary>
		/// <param name="strUserId">�û����</param>
		/// <param name="strUserIp">�û�IP</param>
		/// <param name="strOperationTypeId">�������ͺ�</param>
		/// <param name="strTableName">���ݱ���</param>
		/// <returns></returns>
		public  static bool AddSystemBaseJournalInfo(string strUserId,string strUserIp,string strOperationTypeId,string strTableName)
		{
			clsSysLogEN objSysLog=new clsSysLogEN();
			PutDataToSysLogClass(objSysLog,strUserId, strUserIp,strOperationTypeId,strTableName,null,null,null);	
			if (clsSysLogBL .AddNewRecordBySql2(objSysLog) == false) 
			{
				IsAddJournalWin=false;
			}
			else
			{
				IsAddJournalWin=true;
			}
			return IsAddJournalWin;
		}
		
		/// <summary>
		/// ��־��Ӳ���(��ϸ��Ϣ)
		/// </summary>
		/// <param name="strUserId">�û����</param>
		/// <param name="strUserIp">�û�IP</param>
		/// <param name="strOperationType">�û��������ͺ�</param>
		/// <param name="strTableName">���ݱ������</param>
		/// <param name="strTableKey">���ݱ�Ĺؼ��ֶ�����</param>
		/// <param name="strJournal">��־����</param>
		/// <returns>���سɹ����ı�־,bool����</returns>
		public static  bool AddSysLogInfo(string strUserId,
			string strUserIp,
			string strOperationTypeId,
			string strTableName,
			string strTableKey,
			string strJournal,
			string strPrjId)
		{
			clsSysLogEN objSysLog=new clsSysLogEN();
			PutDataToSysLogClass(
				objSysLog,
				strUserId, 
				strUserIp,
				strOperationTypeId,
				strTableName,
				strTableKey,
				strJournal,
				strPrjId);
			try
			{
				if (clsSysLogBL.AddNewRecordBySql2(objSysLog) == false)
				{
					IsAddJournalWin = false;
				}
				else
				{
					IsAddJournalWin = true;
				}
			}
			catch(Exception objException)
            {
				clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
            }
			return IsAddJournalWin;
		}
	}
}
