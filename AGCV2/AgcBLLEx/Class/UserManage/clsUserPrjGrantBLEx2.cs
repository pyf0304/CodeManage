using System;
using System.Text;
using com.taishsoft.commdb;


namespace AGC.BusinessLogicEx
{
	/// <summary>
	/// clsUserPrjGrantEx ��ժҪ˵����
	/// </summary>
	public partial class clsUserPrjGrantBLEx
	{
		/// <summary>
		/// ���ܣ���ȡĳһ������DataTable�����еĴ���ת������Ӧ������
		/// </summary>
		/// <param name="strCondition">������</param>
		/// <returns>�����Ѿ�ת�������DataTable</returns>
		public static System.Data.DataTable GetUserPrjGrantT1(string strCondition)
		{
			StringBuilder strSQL = new StringBuilder(); 
			System.Data.DataTable objDT=null; 
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			strSQL.Append("Select UserPrjGrant.* ");
			strSQL.Append(", Projects.PrjName ProjectsPrjName ");
			strSQL.Append(" from UserPrjGrant ");
			strSQL.Append(" left JOIN Projects on UserPrjGrant.PrjId = Projects.PrjId ");
			strSQL.Append(" where " + strCondition); 
			objDT = objSQL.GetDataTable(strSQL.ToString());
			return objDT;
		}
	}
}
