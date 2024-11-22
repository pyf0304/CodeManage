using System;
using com.taishsoft.common;

namespace AGC.Entity
{
	/// <summary>
	/// clsDBServer ��ժҪ˵����
	/// </summary>
	public class clsDBServer
	{

		private string mstrServer;	//Ŀ��IP���������
		private string mstrDataBase;	//�û����ݿ���
		private string mstrUserIDForMaster;	//�û�ID For Master��
		private string mstrUserIDForDB;	//�û�ID	for DataBase
		private string mstrPassWordForMaster;		//�û�����
		private string mstrPassWordForDB;		//�û�����
		private string mstrTabName;			//��ǰ�û�ѡ��ı���
		private int mintTabIndex;			//��ǰ��ѡ�������
		private string mstrMainFunc;		//���ɴ������Ҫ����
		private string mstrCodeFunction;		//���ɴ���Ĺ��ܣ�
		private bool mbolIsUseCtl;			//�Ƿ�ʹ�ÿؼ�
		private string mstrNameSpace;		//����
		private string mstrUserId;			//ʹ�ñ�ϵͳ���û�ID
		//		AutoGenFile.clsTabInfo objTabInfo=null;

		/// <summary>
		/// ���ɴ���Ĺ��ܹ���6�࣬�ֱ����£�
		/// 0��ȫ�����룻
		/// 1������˽�б���
		/// 2: �����¼
		/// 3: �޸ļ�¼
		/// 4: ɾ����¼
		/// 5: ��ʾ���¼
		/// 
		/// </summary>
		public clsDBServer()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//

		}
		/// <summary>
		/// ���ɴ���Ĺ��ܹ���6�࣬�ֱ����£�
		/// 0��ȫ�����룻
		/// 1������˽�б���
		/// 2: �����¼
		/// 3: �޸ļ�¼
		/// 4: ɾ����¼
		/// 5: ��ʾ���¼
		/// 
		/// </summary>
		public string MainFunc
		{
			get
			{
				return mstrMainFunc;
			}
			set 
			{
				mstrMainFunc = value;
			}
		}

		public string UserId
		{
			get 
			{
				return mstrUserId;
			}
			set
			{
				mstrUserId = value;
			}
		}
		public string MyNameSpace
		{
			get
			{
				return mstrNameSpace;
			}
			set
			{
				mstrNameSpace = value;
			}
		}
		
		public string CodeFunction
		{
			get
			{
				return mstrCodeFunction;
			}
			set 
			{
				mstrCodeFunction = value;
			}
		}
		public bool IsUseCtl
		{
			get
			{
				return mbolIsUseCtl;
			}
			set
			{
				mbolIsUseCtl = value;
			}
		}
		public string Server
		{
			get
			{
				return mstrServer;
			}
			set
			{
				mstrServer = value;
			}
		}
		public string DataBase
		{
			get 
			{
				return mstrDataBase;
			}
			set 
			{
				mstrDataBase = value;
			}
		}
		public string UserIDForMaster
		{
			get
			{
				return mstrUserIDForMaster;
			}
			set
			{
				mstrUserIDForMaster= value;
			}
		}
		public string UserIDForDB
		{
			get
			{
				return mstrUserIDForDB;
			}
			set
			{
				mstrUserIDForDB= value;
			}
		}

		public string PassWordForMaster
		{
			get
			{
				return mstrPassWordForMaster;
			}
			set
			{
				mstrPassWordForMaster = value;
			}
		}
		public string PassWordForDB
		{
			get
			{
				return mstrPassWordForDB;
			}
			set
			{
				mstrPassWordForDB = value;
			}
		}

		public string TabName
		{
			get
			{
				return mstrTabName;
			}
			set 
			{
				mstrTabName = value;
				new clsString().FstUcase(ref mstrTabName);	//	ʹ�����ĵ�һ����ĸΪ��д
			}
		}
		public int TabIndex 
		{
			get 
			{
				return mintTabIndex;
			}
			set
			{
				mintTabIndex = value;
			}
		}
		public string ClsName
		{
			get
			{
				string strClsName;
				strClsName = "cls" + mstrTabName;
				return strClsName;
			}
		}

	}
}
