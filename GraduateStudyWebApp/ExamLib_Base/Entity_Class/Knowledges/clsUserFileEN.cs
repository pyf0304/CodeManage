
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserFileEN
 表名:UserFile(01120085)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
 框架-层名:实体层(CS)(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace ExamLib.Entity
{
 /// <summary>
 /// 表UserFile的关键字(FileName)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FileName_UserFile
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFileName">表关键字</param>
public K_FileName_UserFile(string strFileName)
{
if (IsValid(strFileName)) Value = strFileName;
else
{
Value = null;
}
}
private static bool IsValid(string strFileName)
{
if (string.IsNullOrEmpty(strFileName) == true) return false;
if (strFileName.Length > 500) return false;
if (strFileName.IndexOf(' ') >= 0) return false;
if (strFileName.IndexOf(')') >= 0) return false;
if (strFileName.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FileName_UserFile]类型的对象</returns>
public static implicit operator K_FileName_UserFile(string value)
{
return new K_FileName_UserFile(value);
}
}
 /// <summary>
 /// 课程资源管理(UserFile)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserFileEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserFile"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FileName"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"FileName", "OrderNum", "FileSize", "Extension", "ResourceTypeName", "FileSizeUnit", "ResourcePicPath", "UploadDateTime", "FileNamePath"};

protected string mstrFileName;    //文件名称
protected int? mintOrderNum;    //序号
protected double mdblFileSize;    //文件大小
protected string mstrExtension;    //扩展名
protected string mstrResourceTypeName;    //资源类型名称
protected string mstrFileSizeUnit;    //文件大小单位
protected string mstrResourcePicPath;    //图片位置
protected string mstrUploadDateTime;    //上传时间
protected string mstrFileNamePath;    //文件路径

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsUserFileEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FileName");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strFileName">关键字:文件名称</param>
public clsUserFileEN(string strFileName)
 {
strFileName = strFileName.Replace("'", "''");
if (strFileName.Length > 500)
{
throw new Exception("在表:UserFile中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFileName)  ==  true)
{
throw new Exception("在表:UserFile中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFileName);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFileName = strFileName;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FileName");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conUserFile.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  conUserFile.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conUserFile.FileSize)
{
return mdblFileSize;
}
else if (strAttributeName  ==  conUserFile.Extension)
{
return mstrExtension;
}
else if (strAttributeName  ==  conUserFile.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  conUserFile.FileSizeUnit)
{
return mstrFileSizeUnit;
}
else if (strAttributeName  ==  conUserFile.ResourcePicPath)
{
return mstrResourcePicPath;
}
else if (strAttributeName  ==  conUserFile.UploadDateTime)
{
return mstrUploadDateTime;
}
else if (strAttributeName  ==  conUserFile.FileNamePath)
{
return mstrFileNamePath;
}
return null;
}
set
{
if (strAttributeName  ==  conUserFile.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(conUserFile.FileName);
}
else if (strAttributeName  ==  conUserFile.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserFile.OrderNum);
}
else if (strAttributeName  ==  conUserFile.FileSize)
{
mdblFileSize = TransNullToDouble(value.ToString());
 AddUpdatedFld(conUserFile.FileSize);
}
else if (strAttributeName  ==  conUserFile.Extension)
{
mstrExtension = value.ToString();
 AddUpdatedFld(conUserFile.Extension);
}
else if (strAttributeName  ==  conUserFile.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(conUserFile.ResourceTypeName);
}
else if (strAttributeName  ==  conUserFile.FileSizeUnit)
{
mstrFileSizeUnit = value.ToString();
 AddUpdatedFld(conUserFile.FileSizeUnit);
}
else if (strAttributeName  ==  conUserFile.ResourcePicPath)
{
mstrResourcePicPath = value.ToString();
 AddUpdatedFld(conUserFile.ResourcePicPath);
}
else if (strAttributeName  ==  conUserFile.UploadDateTime)
{
mstrUploadDateTime = value.ToString();
 AddUpdatedFld(conUserFile.UploadDateTime);
}
else if (strAttributeName  ==  conUserFile.FileNamePath)
{
mstrFileNamePath = value.ToString();
 AddUpdatedFld(conUserFile.FileNamePath);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserFile.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (conUserFile.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conUserFile.FileSize  ==  AttributeName[intIndex])
{
return mdblFileSize;
}
else if (conUserFile.Extension  ==  AttributeName[intIndex])
{
return mstrExtension;
}
else if (conUserFile.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (conUserFile.FileSizeUnit  ==  AttributeName[intIndex])
{
return mstrFileSizeUnit;
}
else if (conUserFile.ResourcePicPath  ==  AttributeName[intIndex])
{
return mstrResourcePicPath;
}
else if (conUserFile.UploadDateTime  ==  AttributeName[intIndex])
{
return mstrUploadDateTime;
}
else if (conUserFile.FileNamePath  ==  AttributeName[intIndex])
{
return mstrFileNamePath;
}
return null;
}
set
{
if (conUserFile.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(conUserFile.FileName);
}
else if (conUserFile.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserFile.OrderNum);
}
else if (conUserFile.FileSize  ==  AttributeName[intIndex])
{
mdblFileSize = TransNullToDouble(value.ToString());
 AddUpdatedFld(conUserFile.FileSize);
}
else if (conUserFile.Extension  ==  AttributeName[intIndex])
{
mstrExtension = value.ToString();
 AddUpdatedFld(conUserFile.Extension);
}
else if (conUserFile.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(conUserFile.ResourceTypeName);
}
else if (conUserFile.FileSizeUnit  ==  AttributeName[intIndex])
{
mstrFileSizeUnit = value.ToString();
 AddUpdatedFld(conUserFile.FileSizeUnit);
}
else if (conUserFile.ResourcePicPath  ==  AttributeName[intIndex])
{
mstrResourcePicPath = value.ToString();
 AddUpdatedFld(conUserFile.ResourcePicPath);
}
else if (conUserFile.UploadDateTime  ==  AttributeName[intIndex])
{
mstrUploadDateTime = value.ToString();
 AddUpdatedFld(conUserFile.UploadDateTime);
}
else if (conUserFile.FileNamePath  ==  AttributeName[intIndex])
{
mstrFileNamePath = value.ToString();
 AddUpdatedFld(conUserFile.FileNamePath);
}
}
}

/// <summary>
/// 文件名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileName
{
get
{
return mstrFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileName = value;
}
else
{
 mstrFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserFile.FileName);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conUserFile.OrderNum);
}
}
/// <summary>
/// 文件大小(说明:;字段类型:decimal;字段长度:22;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double FileSize
{
get
{
return mdblFileSize;
}
set
{
 mdblFileSize = value;
//记录修改过的字段
 AddUpdatedFld(conUserFile.FileSize);
}
}
/// <summary>
/// 扩展名(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Extension
{
get
{
return mstrExtension;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExtension = value;
}
else
{
 mstrExtension = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserFile.Extension);
}
}
/// <summary>
/// 资源类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceTypeName
{
get
{
return mstrResourceTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceTypeName = value;
}
else
{
 mstrResourceTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserFile.ResourceTypeName);
}
}
/// <summary>
/// 文件大小单位(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileSizeUnit
{
get
{
return mstrFileSizeUnit;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileSizeUnit = value;
}
else
{
 mstrFileSizeUnit = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserFile.FileSizeUnit);
}
}
/// <summary>
/// 图片位置(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourcePicPath
{
get
{
return mstrResourcePicPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourcePicPath = value;
}
else
{
 mstrResourcePicPath = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserFile.ResourcePicPath);
}
}
/// <summary>
/// 上传时间(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UploadDateTime
{
get
{
return mstrUploadDateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUploadDateTime = value;
}
else
{
 mstrUploadDateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserFile.UploadDateTime);
}
}
/// <summary>
/// 文件路径(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileNamePath
{
get
{
return mstrFileNamePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileNamePath = value;
}
else
{
 mstrFileNamePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserFile.FileNamePath);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrFileName;
 }
 }
}
 /// <summary>
 /// 课程资源管理(UserFile)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserFile
{
public const string _CurrTabName = "UserFile"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FileName"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FileName", "OrderNum", "FileSize", "Extension", "ResourceTypeName", "FileSizeUnit", "ResourcePicPath", "UploadDateTime", "FileNamePath"};
//以下是属性变量


 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"FileSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileSize = "FileSize";    //文件大小

 /// <summary>
 /// 常量:"Extension"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Extension = "Extension";    //扩展名

 /// <summary>
 /// 常量:"ResourceTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceTypeName = "ResourceTypeName";    //资源类型名称

 /// <summary>
 /// 常量:"FileSizeUnit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileSizeUnit = "FileSizeUnit";    //文件大小单位

 /// <summary>
 /// 常量:"ResourcePicPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourcePicPath = "ResourcePicPath";    //图片位置

 /// <summary>
 /// 常量:"UploadDateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UploadDateTime = "UploadDateTime";    //上传时间

 /// <summary>
 /// 常量:"FileNamePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileNamePath = "FileNamePath";    //文件路径
}

}