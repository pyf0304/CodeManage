using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// Bind_TrueOrFalse 的摘要说明。
	/// </summary>
	public class clsExportField
	{
        /// <summary>
        /// 类的英文名
        /// </summary>
		protected string strFieldEnglishName;
        /// <summary>
        /// 字段中文名
        /// </summary>
		protected string strFieldChineseName;
        /// <summary>
        /// 导出字段的构造函数
        /// </summary>
		public clsExportField()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
        /// <summary>
        /// 类的英文名
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
        /// 字段中文名
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
