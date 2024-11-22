using System;
using System.Data; 
using System.Text; 
using System.Collections; 
using com.taishsoft.common;
using com.taishsoft.commexception;
using com.taishsoft.commdbfororacle;
using System.Data.OracleClient;

namespace AGC.Entity
{
	public class clsUser_ViewsEN : clsGeneralTab
	{
		public const string CurrTabName_S = "User_Views";    //��ǰ�������������صı���
		public const string CurrTabKeyFldName_S = "View_Name";    //��ǰ���еĹؼ������ƣ��������صı��йؼ�����
		protected const int mintAttributeCount = 3;
		public static string[] AttributeName = new string[] {"View_Name", "Text", "Text_Length"};
		//���������Ա���

		protected string mstrView_Name;
		protected string mstrText;
		protected int mintText_Length;

		public clsUser_ViewsEN()
		{
			SetInit();
			_CurrTabName = "User_Views";
			KeyFldName = "View_Name";
		}

		public clsUser_ViewsEN(string strView_Name)
		{

			mstrView_Name=strView_Name;
			SetInit();
			_CurrTabName = "User_Views";
			KeyFldName = "View_Name";
		}

		public clsUser_ViewsEN(string strView_Name, bool bolIsGetUser_Views)
		{

			mstrView_Name=strView_Name;
			SetInit();
			if (bolIsGetUser_Views==true)
			{
				GetUser_Views();
			}
			_CurrTabName = "User_Views";
			KeyFldName = "View_Name";
		}

		public clsUser_ViewsEN(string server,string strSid,string uid,string pwd):base(server, strSid, uid,pwd)
		{
		}

		public static int AttributeCount
		{
			get
			{
				return mintAttributeCount;
			}
		}
		public object this[string strAttributeName]
		{
			get
			{
				if (strAttributeName == "View_Name")
				{
					return mstrView_Name;
				}
				else if (strAttributeName == "Text")
				{
					return mstrText;
				}
				else if (strAttributeName == "Text_Length")
				{
					return mintText_Length;
				}
				return null;
			}
			set
			{
				if (strAttributeName == "View_Name")
				{
					mstrView_Name = value.ToString();
				}
				else if (strAttributeName == "Text")
				{
					mstrText = value.ToString();
				}
				else if (strAttributeName == "Text_Length")
				{
					mintText_Length = TransNullToInt(value.ToString());
				}
			}
		}
		public object this[int intIndex]
		{
			get
			{
				if ("View_Name" == AttributeName[intIndex])
				{
					return mstrView_Name;
				}
				else if ("Text" == AttributeName[intIndex])
				{
					return mstrText;
				}
				else if ("Text_Length" == AttributeName[intIndex])
				{
					return mintText_Length;
				}
				return null;
			}
			set
			{
				if ("View_Name" == AttributeName[intIndex])
				{
					mstrView_Name = value.ToString();
				}
				else if ("Text" == AttributeName[intIndex])
				{
					mstrText = value.ToString();
				}
				else if ("Text_Length" == AttributeName[intIndex])
				{
					mintText_Length = TransNullToInt(value.ToString());
				}
			}
		}

		public string View_Name
		{
			get
			{
				return mstrView_Name;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrView_Name = value;
				}
				else
				{
					mstrView_Name = value;
				}
			}
		}
		public string Text
		{
			get
			{
				return mstrText;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrText = value;
				}
				else
				{
					mstrText = value;
				}
			}
		}
		public int Text_Length
		{
			get
			{
				return mintText_Length;
			}
			set
			{
				mintText_Length = value;
			}
		}

		//public override bool AddNewRecord()
		//{
		//	string strSQL; 
		//	OracleDataAdapter objDA; 
		//	System.Data.DataSet objDS = new System.Data.DataSet();
		//	OracleCommandBuilder objCB ; 
		//	System.Data.DataRow objRow; 
		//	clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
		//	strSQL = "Select * from User_Views where 1=2";
		//	objDA = new OracleDataAdapter(strSQL, objSQL.OracleConnect);
		//	objCB = new OracleCommandBuilder(objDA);
		//	objDA.Fill(objDS, "User_Views");
		//	objRow = objDS.Tables["User_Views"].NewRow();
		//	objRow["View_Name"] = mstrView_Name;
		//	objRow["Text"] = mstrText;
		//	objRow["Text_Length"] = mintText_Length;
		//	objDS.Tables["User_Views"].Rows.Add(objRow);
		//	try
		//	{
		//		objDA.Update(objDS, "User_Views");
		//	}
		//	catch (Exception objException )
		//	{
		//		LogError(objException);
		//		throw new Exception(EXCEPTION_MSG + objException.Message, objException);
		//	}
		//	finally
		//	{
		//		objDA = null;
		//		objDS = null;
		//		objCB = null;
		//		objRow = null;
		//	}
		//	return true;
		//}



		/// <summary>
		/// �Ѷ�����¼ͬʱ���뵽����!
		/// </summary>
		/// <param name="oDT"></param>
		/// <param name="strResult"></param>
		/// <returns></returns>
		//public  bool AddnewUser_Viewss(System.Data.DataTable oDT, ref string strResult) 
		//{
		//	string strSQL;
		//	OracleDataAdapter objDA;
		//	System.Data.DataSet objDS = new System.Data.DataSet();
		//	OracleCommandBuilder objCB; 
		//	System.Data.DataRow objRow;
		//	clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
		//	if (mintErrNo != 0 ) 
		//	{
		//		strResult = "�����Ϊ��" + mintErrNo.ToString();
		//		return false;
		//	}
		//	strSQL = "Select * from User_Views where View_Name='111'";
		//	objDA = new OracleDataAdapter(strSQL, objSQL.OracleConnect);
		//	objCB = new OracleCommandBuilder(objDA);
		//	objDA.Fill(objDS, "User_Views");
		//	//���ؼ��ֵ�Ψһ��
		//	foreach(System.Data.DataRow oRow in oDT.Rows)
		//	{
		//		string strView_Name =oRow["View_Name"].ToString().Trim();
		//		if (IsExist(strView_Name))
		//		{
		//			strResult = "�ؼ���View_NameΪ��" + strView_Name + "�ļ�¼�Ѵ��ڣ������ظ�����!" ;
		//			return false;
		//		}
		//	}
		//	//�Ѷ�����¼���뵽����
		//	foreach(System.Data.DataRow oRow in oDT.Rows)
		//	{
		//		objRow = objDS.Tables["User_Views"].NewRow();
		//		objRow["View_Name"] = oRow["View_Name"].ToString().Trim();
		//		objRow["Text"] = oRow["Text"].ToString().Trim();
		//		objRow["Text_Length"] = oRow["Text_Length"].ToString().Trim();
		//		objDS.Tables["User_Views"].Rows.Add(objRow);
		//	}
		//	try
		//	{
		//		objDA.Update(objDS, "User_Views");
		//	}
		//	catch(Exception objException) 
		//	{
		//		LogError(objException);
		//		throw new Exception(EXCEPTION_MSG + objException.Message, objException);
		//	}
		//	finally
		//	{
		//		objDA = null;
		//		objDS = null;
		//		objCB = null;
		//		objRow = null;
		//		objSQL.OracleConnect.Close();
		//		objSQL = null;
		//	}
		//	return true;
		//}

		//public override bool Update() 
		//{
		//	string strSQL ;
		//	OracleDataAdapter objDA ;
		//	System.Data.DataSet objDS = new System.Data.DataSet();
		//	OracleCommandBuilder objCB ;
		//	System.Data.DataRow objRow ;
		//	clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
		//	strSQL = "Select * from User_Views where View_Name=" + "'"+ mstrView_Name+"'";
		//	objDA = new OracleDataAdapter(strSQL, objSQL.OracleConnect);
		//	objCB = new OracleCommandBuilder(objDA);
		//	objDA.Fill(objDS, "User_Views");
		//	if (objDS.Tables["User_Views"].Rows.Count == 0 )
		//	{
		//		//MsgBox("û����Ӧ��ID�ţ�View_Name=" + "'"+ mstrView_Name+"'");
		//		return false;
		//	}
		//	objRow = objDS.Tables["User_Views"].Rows[0];
		//	objRow["Text"] = mstrText;
		//	objRow["Text_Length"] = mintText_Length;
		//	try
		//	{
		//		objDA.Update(objDS, "User_Views");
		//	}
		//	catch (Exception objException )
		//	{
		//		LogError(objException);
		//		throw new Exception(EXCEPTION_MSG + objException.Message, objException);
		//	}
		//	finally
		//	{
		//		objDA = null;
		//		objDS = null;
		//		objCB = null;
		//		objRow = null;
		//	}
		//	return true;
		//}



		/// <summary>
		/// ���ܣ��޸Ķ�����¼
		/// </summary>
		/// <param name="strCondition"></param>
		/// <returns></returns>
		//public override int UpdateMultiRec(string strCondition) 
		//{
		//	string strSQL ;
		//	OracleDataAdapter objDA ;
		//	System.Data.DataSet objDS = new System.Data.DataSet();
		//	OracleCommandBuilder objCB ;
		//	//			System.Data.DataRow objRow ;
		//	clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
		//	int intRecCount;
		//	if (strCondition == "")
		//	{
		//		return 0;   //��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
		//	}
		//	strSQL = "Select * from User_Views where " + strCondition;
		//	objDA = new OracleDataAdapter(strSQL, objSQL.OracleConnect);
		//	objCB = new OracleCommandBuilder(objDA);
		//	objDA.Fill(objDS, "User_Views");
		//	if (objDS.Tables["User_Views"].Rows.Count == 0 )
		//	{
		//		return 0;
		//	}
		//	intRecCount = objDS.Tables["User_Views"].Rows.Count;
		//	foreach(System.Data.DataRow objRow in objDS.Tables["User_Views"].Rows)
		//	{
		//		objRow["Text"] = mstrText;
		//		objRow["Text_Length"] = mintText_Length;
		//	}
		//	try
		//	{
		//		objDA.Update(objDS, "User_Views");
		//	}
		//	catch (Exception objException )
		//	{
		//		LogError(objException);
		//		throw new Exception(EXCEPTION_MSG + objException.Message, objException);
		//	}
		//	finally
		//	{
		//		objDA = null;
		//		objDS = null;
		//		objCB = null;
		//	}
		//	return intRecCount;
		//}


		public override bool DelRecord() 
		{
			string strSQL = "";
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			//ɾ��User_Views�������뵱ǰ�����йصļ�¼
			strSQL = strSQL + "Delete from User_Views where View_Name=" + "'"+ mstrView_Name+"'";
			return objSQL.ExecSql(strSQL);
		}


		//ͬʱɾ��������¼
		public static bool DelUser_Views(ArrayList lstKey)
		{
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			string strSQL;
			string strKeyList;
			if (lstKey.Count ==0) return true;
			strKeyList = "";
			for (int i=0; i<lstKey.Count; i++)
			{
				if (i==0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
				else strKeyList += ","  + "'" + lstKey[i].ToString() + "'";
			}
			strSQL = "";
			//ɾ��User_Views�������뵱ǰ�����йصļ�¼
			strSQL = strSQL + "Delete from User_Views where View_Name in (" + strKeyList + ")";
			return objSQL.ExecSql(strSQL);
		}

		public static bool DelRecord(string strView_Name) 
		{
			//ɾ��������¼
			string strSQL = "";
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			//ɾ��User_Views�������뵱ǰ�����йصļ�¼
			strSQL = strSQL + "Delete from User_Views where View_Name=" + "'"+ strView_Name+"'";
			return objSQL.ExecSql(strSQL);
		}


		/// <summary>
		/// ���ܣ�ɾ��������¼����������ɾ��
		/// </summary>
		/// <param name="strCondition">��Ҫɾ���ļ�¼����</param>
		/// <returns>����ɾ���ļ�¼0��</returns>
		public static int DelUser_Views(string strCondition)
		{
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			string strSQL;
			if (strCondition == "")
			{
				return 0;	//��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
			}
			else
			{
				strSQL =  "Delete from User_Views where " + strCondition ;
			}
			int intRecoCount =  objSQL.ExecSql2(strSQL);
			return intRecoCount;
		}


		public bool GetUser_Views()
		{
			string strSQL ;
			System.Data.DataTable objDT ; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL = "Select * from User_Views where View_Name=" + "'"+ mstrView_Name+"'";
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count == 0)
			{
				objDT = null;
				return false;
			}
			mstrView_Name=objDT.Rows[0]["View_Name"].ToString().Trim();
			mstrText=objDT.Rows[0]["Text"].ToString().Trim();
			mintText_Length=Int32.Parse(objDT.Rows[0]["Text_Length"].ToString().Trim());
			objDT = null;
			return true;
		}

		public static System.Data.DataTable GetUser_Views(string strCondition)
		{
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL = "Select * from User_Views where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			return objDT;
		}

		public ArrayList GetUser_ViewsObjList(string strCondition)
		{
			ArrayList arrObjList = new ArrayList(); 
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL = "Select * from User_Views where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count == 0)
			{
				objDT = null;
				return arrObjList;
			}
			foreach(DataRow objRow in objDT.Rows)
			{
				clsUser_ViewsEN objUser_Views = new clsUser_ViewsEN();
				objUser_Views.View_Name = objRow["View_Name"].ToString().Trim();
				objUser_Views.Text = objRow["Text"].ToString().Trim();
				objUser_Views.Text_Length = Int32.Parse(objRow["Text_Length"].ToString().Trim());
				arrObjList.Add(objUser_Views);
			}
			objDT = null;
			return arrObjList;
		}

		public clsUser_ViewsEN GetFirstUser_Views(string strCondition)
		{
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL = "Select * from User_Views where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count == 0)
			{
				objDT = null;
				return null;
			}
			DataRow objRow = objDT.Rows[0];
			clsUser_ViewsEN objUser_Views = new clsUser_ViewsEN();
			objUser_Views.View_Name = objRow["View_Name"].ToString().Trim();
			objUser_Views.Text = objRow["Text"].ToString().Trim();
			objUser_Views.Text_Length = Int32.Parse(objRow["Text_Length"].ToString().Trim());
			objDT = null;
			return objUser_Views;
		}



		/// <summary>
		/// ���ܣ���ȡĳһ��������ر���ͼ(View)
		/// </summary>
		/// <param name="strCondition">������</param>
		/// <returns>�����Ѿ�ת�������DataTable</returns>
		public static System.Data.DataTable GetUser_ViewsV(string strCondition)
		{
			StringBuilder strSQL = new StringBuilder(); 
			System.Data.DataTable objDT=null; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL.Append("Select vUser_Views.* ");
			strSQL.Append(" from vUser_Views ");
			strSQL.Append(" where " + strCondition); 
			objDT = objSQL.GetDataTable(strSQL.ToString());
			return objDT;
		}


		public override bool IsExist()
		{
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			if (objSQL.IsExistRecord("User_Views", "View_Name=" + "'"+ mstrView_Name+"'") )
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool IsExist(string strView_Name)
		{
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			if (objSQL.IsExistRecord("User_Views", "View_Name=" + "'"+ strView_Name+"'") )
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void CheckPropertyNew()
		{
			if (Object.Equals(null, mstrView_Name ) 
				|| (!Object.Equals(null, mstrView_Name ) && mstrView_Name .ToString() == "")
				)
			{
				throw new clsDbObjException("�ֶ�[��ͼ��]����Ϊ��(NULL)!");
			}
			if (Object.Equals(null, mstrText ) 
				|| (!Object.Equals(null, mstrText ) && mstrText .ToString() == "")
				)
			{
				throw new clsDbObjException("�ֶ�[�ı�����]����Ϊ��(NULL)!");
			}
			if (Object.Equals(null, mintText_Length ) 
				|| (!Object.Equals(null, mintText_Length ) && mintText_Length .ToString() == "")
				)
			{
				throw new clsDbObjException("�ֶ�[�ı�����]����Ϊ��(NULL)!");
			}
			if (!Object.Equals(null, mstrView_Name)  && getStrLen(mstrView_Name) > 30)
			{
				throw new clsDbObjException("�ֶ�[��ͼ��]�ĳ��Ȳ��ܳ���30!");
			}
		}

		public override ArrayList GetID(string strCondtion ) 
		{
			string strSQL ;
			System.Data.DataTable objDT ;
			ArrayList arrList = new ArrayList();
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			int iRow, iCol; 
			string strKeyValue; 
			strSQL = "Select View_Name from User_Views where " + strCondtion;
			try
			{
				objDT = objSQL.GetDataTable(strSQL);
			}
			catch (Exception objException )
			{
				LogError(objException);
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
			}

			if (objDT.Rows.Count == 0 )
			{
				objDT = null;
				return null;
			}
			for (iRow = 0; iRow<= objDT.Rows.Count - 1;iRow++)
			{
				strKeyValue = "";
				for (iCol = 0; iCol<= objDT.Columns.Count - 1;iCol++)
				{
					if (iCol == 0 )
					{
						strKeyValue += objDT.Rows[iRow][iCol].ToString();
					}
					else
					{
						strKeyValue += "//" + objDT.Rows[iRow][iCol].ToString();
					}
				}
				arrList.Add(strKeyValue);
			}
			objDT = null;
			return arrList;
		}

		public string GetFirstID(string strCondtion ) 
		{
			string strSQL ;
			System.Data.DataTable objDT ;
			ArrayList arrList = new ArrayList();
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			string strKeyValue; 
			strSQL = "Select View_Name from User_Views where " + strCondtion;
			try
			{
				objDT = objSQL.GetDataTable(strSQL);
			}
			catch (Exception objException )
			{
				LogError(objException);
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
			}

			if (objDT.Rows.Count == 0 )
			{
				objDT = null;
				return null;
			}
			strKeyValue = objDT.Rows[0][0].ToString();
			objDT = null;
			return strKeyValue;
		}

		public static string GetFirstID_S(string strCondtion ) 
		{
			string strSQL ;
			System.Data.DataTable objDT ;
			ArrayList arrList = new ArrayList();
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			string strKeyValue; 
			strSQL = "Select View_Name from User_Views where " + strCondtion;
			try
			{
				objDT = objSQL.GetDataTable(strSQL);
			}
			catch (Exception objException )
			{
				LogErrorS(objException, "clsUser_ViewsEN");
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
			}

			if (objDT.Rows.Count == 0 )
			{
				objDT = null;
				return null;
			}
			strKeyValue = objDT.Rows[0][0].ToString();
			objDT = null;
			return strKeyValue;
		}
	}
}