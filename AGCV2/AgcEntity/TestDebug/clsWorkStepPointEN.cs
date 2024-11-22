using System;
using System.Data; 
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using System.Collections.Generic;


namespace AGC.Entity
{
	public class clsWorkStepPointEN : clsGeneralTab
	{
		public const string CurrTabName_S = "WorkStepPoint";    //��ǰ�������������صı���
		public const string CurrTabKeyFldName_S = "PointID";    //��ǰ���еĹؼ������ƣ��������صı��йؼ�����
		//���������Ա���
		///�ú���������:

		protected string mstrPointID;
		protected string mstrPointName;
		protected int mintpLeft;
		protected int mintpTop;
		protected string mstrMemo;
		protected string mstrImgFile;

		public clsWorkStepPointEN()
		{
			SetInit();
			_CurrTabName = "WorkStepPoint";
			KeyFldName = "PointID";
		}

		public clsWorkStepPointEN(string strPointID)
		{

			mstrPointID=strPointID;
			SetInit();
			_CurrTabName = "WorkStepPoint";
			KeyFldName = "PointID";
		}

		public clsWorkStepPointEN(string strPointID, bool bolIsGetWorkStepPoint)
		{

			mstrPointID=strPointID;
			SetInit();
			if (bolIsGetWorkStepPoint==true)
			{
				GetWorkStepPoint();
			}
			_CurrTabName = "WorkStepPoint";
			KeyFldName = "PointID";
		}


		public string PointID
		{
			get
			{
				return mstrPointID;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrPointID = value;
				}
				else
				{
					mstrPointID = value;
				}
			}
		}
		public string PointName
		{
			get
			{
				return mstrPointName;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrPointName = value;
				}
				else
				{
					mstrPointName = value;
				}
			}
		}
		public int pLeft
		{
			get
			{
				return mintpLeft;
			}
			set
			{
				mintpLeft = value;
			}
		}
		public int pTop
		{
			get
			{
				return mintpTop;
			}
			set
			{
				mintpTop = value;
			}
		}
		public string Memo
		{
			get
			{
				return mstrMemo;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrMemo = value;
				}
				else
				{
					mstrMemo = value;
				}
			}
		}
		public string ImgFile
		{
			get
			{
				return mstrImgFile;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrImgFile = value;
				}
				else
				{
					mstrImgFile = value;
				}
			}
		}

		public override bool AddNewRecord()
		{
			string strSQL; 
			System.Data.SqlClient.SqlDataAdapter objDA ; 
			System.Data.DataSet objDS = new System.Data.DataSet();
			System.Data.SqlClient.SqlCommandBuilder objCB ; 
			System.Data.DataRow objRow; 
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			strSQL = "Select * from WorkStepPoint where 1=2";
			objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
			objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
			objDA.Fill(objDS, "WorkStepPoint");
			objRow = objDS.Tables["WorkStepPoint"].NewRow();
			objRow["PointID"] = mstrPointID;
			objRow["PointName"] = mstrPointName;
			objRow["pLeft"] = mintpLeft;
			objRow["pTop"] = mintpTop;
			if (mstrMemo != "")
			{
				objRow["Memo"] = mstrMemo;
			}
			objRow["ImgFile"] = mstrImgFile;
			objDS.Tables["WorkStepPoint"].Rows.Add(objRow);
			try
			{
				objDA.Update(objDS, "WorkStepPoint");
			}
			catch (Exception objException )
			{
				LogError(objException);
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
				objDA = null;
				objDS = null;
				objCB = null;
				objRow = null;
			}
			return true;
		}



		public bool AddnewWorkStepPointBySP() 
		{
			//ͨ���洢������
			//ֱ��ʹ��
			if ( mintErrNo != 0 ) 
			{
				//MsgBox(mstrErrMsg(mintErrNo))
				return false;
			}
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			objSQL.SPConfigXMLFile ="..\\XML\\XMLSP.xml";
			//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
			ArrayList values = new ArrayList();
			values.Add(mstrPointID);
			values.Add(mstrPointName);
			values.Add(mintpLeft);
			values.Add(mintpTop);
			values.Add(mstrMemo);
			values.Add(mstrImgFile);
			objSQL.ExecSP("AddnewWorkStepPoint",values);
			return true;
		}

		/// <summary>
		/// �Ѷ�����¼ͬʱ���뵽����!
		/// </summary>
		/// <param name="oDT"></param>
		/// <param name="strResult"></param>
		/// <returns></returns>
		public  bool AddnewWorkStepPoints(System.Data.DataTable oDT, ref string strResult) 
		{
			string strSQL;
			System.Data.SqlClient.SqlDataAdapter objDA;
			System.Data.DataSet objDS = new System.Data.DataSet();
			System.Data.SqlClient.SqlCommandBuilder objCB; 
			System.Data.DataRow objRow;
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			if (mintErrNo != 0 ) 
			{
				strResult = "�����Ϊ��" + mintErrNo.ToString();
				return false;
			}
			strSQL = "Select * from WorkStepPoint where PointID='111'";
			objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
			objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
			objDA.Fill(objDS, "WorkStepPoint");
			//���ؼ��ֵ�Ψһ��
			foreach(System.Data.DataRow oRow in oDT.Rows)
			{
				string strPointID =oRow["PointID"].ToString().Trim();
				if (IsExist(strPointID))
				{
					strResult = "�ؼ���PointIDΪ��" + strPointID + "�ļ�¼�Ѵ��ڣ������ظ�����!" ;
					return false;
				}
			}
			//�Ѷ�����¼���뵽����
			foreach(System.Data.DataRow oRow in oDT.Rows)
			{
				objRow = objDS.Tables["WorkStepPoint"].NewRow();
				objRow["PointID"] = oRow["PointID"].ToString().Trim();
				objRow["PointName"] = oRow["PointName"].ToString().Trim();
				objRow["pLeft"] = oRow["pLeft"].ToString().Trim();
				objRow["pTop"] = oRow["pTop"].ToString().Trim();
				objRow["Memo"] = oRow["Memo"].ToString().Trim();
				objRow["ImgFile"] = oRow["ImgFile"].ToString().Trim();
				objDS.Tables["WorkStepPoint"].Rows.Add(objRow);
			}
			try
			{
				objDA.Update(objDS, "WorkStepPoint");
			}
			catch(Exception objException) 
			{
				LogError(objException);
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
				objDA = null;
				objDS = null;
				objCB = null;
				objRow = null;
				objSQL.SQLConnect.Close();
				objSQL = null;
			}
			return true;
		}

		public override bool Update() 
		{
			string strSQL ;
			System.Data.SqlClient.SqlDataAdapter objDA ;
			System.Data.DataSet objDS = new System.Data.DataSet();
			System.Data.SqlClient.SqlCommandBuilder objCB ;
			System.Data.DataRow objRow ;
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			strSQL = "Select * from WorkStepPoint where PointID=" + "'"+ mstrPointID+"'";
			objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
			objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
			objDA.Fill(objDS, "WorkStepPoint");
			if (objDS.Tables["WorkStepPoint"].Rows.Count == 0 )
			{
				//MsgBox("û����Ӧ��ID�ţ�PointID=" + "'"+ mstrPointID+"'");
				return false;
			}
			objRow = objDS.Tables["WorkStepPoint"].Rows[0];
			objRow["PointName"] = mstrPointName;
			objRow["pLeft"] = mintpLeft;
			objRow["pTop"] = mintpTop;
			objRow["Memo"] = mstrMemo;
			objRow["ImgFile"] = mstrImgFile;
			try
			{
				objDA.Update(objDS, "WorkStepPoint");
			}
			catch (Exception objException )
			{
				LogError(objException);
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
				objDA = null;
				objDS = null;
				objCB = null;
				objRow = null;
			}
			return true;
		}



		/// <summary>
		/// ���ܣ��޸Ķ�����¼
		/// </summary>
		/// <param name="strCondition"></param>
		/// <returns></returns>
		public override int UpdateMultiRec(string strCondition) 
		{
			string strSQL ;
			System.Data.SqlClient.SqlDataAdapter objDA ;
			System.Data.DataSet objDS = new System.Data.DataSet();
			System.Data.SqlClient.SqlCommandBuilder objCB ;
			//			System.Data.DataRow objRow ;
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			int intRecCount;
			if (strCondition == "")
			{
				return 0;   //��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
			}
			strSQL = "Select * from WorkStepPoint where " + strCondition;
			objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
			objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
			objDA.Fill(objDS, "WorkStepPoint");
			if (objDS.Tables["WorkStepPoint"].Rows.Count == 0 )
			{
				return 0;
			}
			intRecCount = objDS.Tables["WorkStepPoint"].Rows.Count;
			foreach(System.Data.DataRow objRow in objDS.Tables["WorkStepPoint"].Rows)
			{
				objRow["PointName"] = mstrPointName;
				objRow["pLeft"] = mintpLeft;
				objRow["pTop"] = mintpTop;
				objRow["Memo"] = mstrMemo;
				objRow["ImgFile"] = mstrImgFile;
			}
			try
			{
				objDA.Update(objDS, "WorkStepPoint");
			}
			catch (Exception objException )
			{
				LogError(objException);
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
				objDA = null;
				objDS = null;
				objCB = null;
			}
			return intRecCount;
		}


		public override bool DelRecord() 
		{
			string strSQL = "";
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			//ɾ��WorkStepPoint�������뵱ǰ�����йصļ�¼
			strSQL = strSQL + "Delete from WorkStepPoint where PointID=" + "'"+ mstrPointID+"'";
			return objSQL.ExecSql(strSQL);
		}


		//ͬʱɾ��������¼
		public static bool DelWorkStepPoint(ArrayList lstKey)
		{
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
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
			//ɾ��WorkStepPoint�������뵱ǰ�����йصļ�¼
			strSQL = strSQL + "Delete from WorkStepPoint where PointID in (" + strKeyList + ")";
			return objSQL.ExecSql(strSQL);
		}

		public static bool DelRecord(string strPointID) 
		{
			//ɾ��������¼
			string strSQL = "";
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			//ɾ��WorkStepPoint�������뵱ǰ�����йصļ�¼
			strSQL = strSQL + "Delete from WorkStepPoint where PointID=" + "'"+ strPointID+"'";
			return objSQL.ExecSql(strSQL);
		}


		/// <summary>
		/// ���ܣ�ɾ��������¼����������ɾ��
		/// </summary>
		/// <param name="strCondition">��Ҫɾ���ļ�¼����</param>
		/// <returns>����ɾ���ļ�¼0��</returns>
		public static int DelWorkStepPoint(string strCondition)
		{
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			string strSQL;
			if (strCondition == "")
			{
				return 0;	//��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
			}
			else
			{
				strSQL =  "Delete from WorkStepPoint where " + strCondition ;
			}
			int intRecoCount =  objSQL.ExecSql2(strSQL);
			return intRecoCount;
		}


		public bool GetWorkStepPoint()
		{
			string strSQL ;
			System.Data.DataTable objDT ; 
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			strSQL = "Select * from WorkStepPoint where PointID=" + "'"+ mstrPointID+"'";
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count == 0)
			{
				objDT = null;
				return false;
			}
			mstrPointID=objDT.Rows[0]["PointID"].ToString().Trim();
			mstrPointName=objDT.Rows[0]["PointName"].ToString().Trim();
			mintpLeft=TransNullToInt(objDT.Rows[0]["pLeft"].ToString().Trim());
			mintpTop=TransNullToInt(objDT.Rows[0]["pTop"].ToString().Trim());
			mstrMemo=objDT.Rows[0]["Memo"].ToString().Trim();
			mstrImgFile=objDT.Rows[0]["ImgFile"].ToString().Trim();
			objDT = null;
			return true;
		}

		public static System.Data.DataTable GetWorkStepPoint(string strCondition)
		{
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			strSQL = "Select * from WorkStepPoint where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			return objDT;
		}



		/// <summary>
		/// ���ܣ���ȡĳһ��������ر���ͼ(View)
		/// </summary>
		/// <param name="strCondition">������</param>
		/// <returns>�����Ѿ�ת�������DataTable</returns>
		public static System.Data.DataTable GetWorkStepPointV(string strCondition)
		{
			StringBuilder strSQL = new StringBuilder(); 
			System.Data.DataTable objDT=null; 
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			strSQL.Append("Select vWorkStepPoint.* ");
			strSQL.Append(" from vWorkStepPoint ");
			strSQL.Append(" where " + strCondition); 
			objDT = objSQL.GetDataTable(strSQL.ToString());
			return objDT;
		}


		public override bool IsExist()
		{
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			if (objSQL.IsExistRecord("WorkStepPoint", "PointID=" + "'"+ mstrPointID+"'") )
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool IsExist(string strPointID)
		{
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			if (objSQL.IsExistRecord("WorkStepPoint", "+PointID=" + "'"+ strPointID+"'") )
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool CheckProperty(ref string strResult)
		{
			if (Object.Equals(null, mstrPointID ) 
				|| (!Object.Equals(null, mstrPointID ) && mstrPointID .ToString() == "")
				)
			{
				strResult = "�ֶ�[PointID]����Ϊ��(NULL)!";
				return false;
			}
			if (Object.Equals(null, mstrPointName ) 
				|| (!Object.Equals(null, mstrPointName ) && mstrPointName .ToString() == "")
				)
			{
				strResult = "�ֶ�[PointName]����Ϊ��(NULL)!";
				return false;
			}
			if (Object.Equals(null, mstrImgFile ) 
				|| (!Object.Equals(null, mstrImgFile ) && mstrImgFile .ToString() == "")
				)
			{
				strResult = "�ֶ�[ͼ���ļ�]����Ϊ��(NULL)!";
				return false;
			}
			if (!Object.Equals(null, mstrPointID)  && getStrLen(mstrPointID) > 8)
			{
				strResult = "�ֶ�[PointID]�ĳ��Ȳ��ܳ���8!";
				return false;
			}
			if (!Object.Equals(null, mstrPointName)  && getStrLen(mstrPointName) > 100)
			{
				strResult = "�ֶ�[PointName]�ĳ��Ȳ��ܳ���100!";
				return false;
			}
			if (!Object.Equals(null, mstrMemo)  && getStrLen(mstrMemo) > 1000)
			{
				strResult = "�ֶ�[˵��]�ĳ��Ȳ��ܳ���1000!";
				return false;
			}
			if (!Object.Equals(null, mstrImgFile)  && getStrLen(mstrImgFile) > 100)
			{
				strResult = "�ֶ�[ͼ���ļ�]�ĳ��Ȳ��ܳ���100!";
				return false;
			}
			return true;
		}

        public override List<string> GetID(string strCondtion) 
		{
			string strSQL ;
			System.Data.DataTable objDT ;
            List<string> arrList = new List<string>();
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			int iRow, iCol; 
			string strKeyValue; 
			strSQL = "Select PointID from WorkStepPoint where " + strCondtion;
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
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			string strKeyValue; 
			strSQL = "Select PointID from WorkStepPoint where " + strCondtion;
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
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			string strKeyValue; 
			strSQL = "Select PointID from WorkStepPoint where " + strCondtion;
			try
			{
				objDT = objSQL.GetDataTable(strSQL);
			}
			catch (Exception objException )
			{
				LogErrorS(objException, "clsWorkStepPoint");
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