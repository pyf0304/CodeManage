using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// Bind_TrueOrFalse ��ժҪ˵����
	/// </summary>
	public class clsExportField
	{
        /// <summary>
        /// ���Ӣ����
        /// </summary>
		protected string strFieldEnglishName;
        /// <summary>
        /// �ֶ�������
        /// </summary>
		protected string strFieldChineseName;
        /// <summary>
        /// �����ֶεĹ��캯��
        /// </summary>
		public clsExportField()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
        /// <summary>
        /// ���Ӣ����
        /// </summary>
		public string FieldEnglishName
		{
			get
			{
				return strFieldEnglishName;
			}
			set
			{
				strFieldEnglishName = value;
			}
		}
        /// <summary>
        /// �ֶ�������
        /// </summary>
		public string FieldChineseName
		{
			get
			{
				return strFieldChineseName;
			}
			set
			{
				strFieldChineseName = value;
			}
		}
	}
}
