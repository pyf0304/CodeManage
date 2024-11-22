
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsResourceEN
 表名:Resource(01120320)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理(ResourceMan)
 框架-层名:实体层(CS)(EntityLayer,0001)
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
using System.Collections.Generic;

namespace ExamLib.Entity
{
 /// <summary>
 /// 表Resource的关键字(IdResource)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdResource_Resource
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdResource">表关键字</param>
public K_IdResource_Resource(string strIdResource)
{
if (IsValid(strIdResource)) Value = strIdResource;
else
{
Value = null;
}
}
private static bool IsValid(string strIdResource)
{
if (string.IsNullOrEmpty(strIdResource) == true) return false;
if (strIdResource.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdResource_Resource]类型的对象</returns>
public static implicit operator K_IdResource_Resource(string value)
{
return new K_IdResource_Resource(value);
}
}
 /// <summary>
 /// 资源(Resource)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsResourceEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Resource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdResource"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"IdResource", "ResourceID", "ResourceName", "SaveMode", "IdFtpResource", "IdFile", "IdResourceType", "UpdDate", "UpdTime", "Memo", "FuncModuleId", "CheckDate", "CheckUser", "CheckResult"};

protected string mstrIdResource;    //资源流水号
protected string mstrResourceID;    //资源ID
protected string mstrResourceName;    //资源名称
protected bool mbolSaveMode;    //文件存放方式
protected string mstrIdFtpResource;    //FTP资源流水号
protected string mstrIdFile;    //文件流水号
protected string mstrIdResourceType;    //资源类型流水号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdTime;    //UpdTime
protected string mstrMemo;    //备注
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrCheckDate;    //检查日期
protected string mstrCheckUser;    //检查用户Id
protected string mstrCheckResult;    //检查结果

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsResourceEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdResource");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdResource">关键字:资源流水号</param>
public clsResourceEN(string strIdResource)
 {
strIdResource = strIdResource.Replace("'", "''");
if (strIdResource.Length > 8)
{
throw new Exception("在表:Resource中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdResource)  ==  true)
{
throw new Exception("在表:Resource中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdResource);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdResource = strIdResource;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdResource");
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
if (strAttributeName  ==  conResource.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  conResource.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  conResource.ResourceName)
{
return mstrResourceName;
}
else if (strAttributeName  ==  conResource.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  conResource.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  conResource.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  conResource.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  conResource.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conResource.UpdTime)
{
return mstrUpdTime;
}
else if (strAttributeName  ==  conResource.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conResource.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conResource.CheckDate)
{
return mstrCheckDate;
}
else if (strAttributeName  ==  conResource.CheckUser)
{
return mstrCheckUser;
}
else if (strAttributeName  ==  conResource.CheckResult)
{
return mstrCheckResult;
}
return null;
}
set
{
if (strAttributeName  ==  conResource.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(conResource.IdResource);
}
else if (strAttributeName  ==  conResource.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(conResource.ResourceID);
}
else if (strAttributeName  ==  conResource.ResourceName)
{
mstrResourceName = value.ToString();
 AddUpdatedFld(conResource.ResourceName);
}
else if (strAttributeName  ==  conResource.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(conResource.SaveMode);
}
else if (strAttributeName  ==  conResource.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(conResource.IdFtpResource);
}
else if (strAttributeName  ==  conResource.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(conResource.IdFile);
}
else if (strAttributeName  ==  conResource.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(conResource.IdResourceType);
}
else if (strAttributeName  ==  conResource.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conResource.UpdDate);
}
else if (strAttributeName  ==  conResource.UpdTime)
{
mstrUpdTime = value.ToString();
 AddUpdatedFld(conResource.UpdTime);
}
else if (strAttributeName  ==  conResource.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conResource.Memo);
}
else if (strAttributeName  ==  conResource.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conResource.FuncModuleId);
}
else if (strAttributeName  ==  conResource.CheckDate)
{
mstrCheckDate = value.ToString();
 AddUpdatedFld(conResource.CheckDate);
}
else if (strAttributeName  ==  conResource.CheckUser)
{
mstrCheckUser = value.ToString();
 AddUpdatedFld(conResource.CheckUser);
}
else if (strAttributeName  ==  conResource.CheckResult)
{
mstrCheckResult = value.ToString();
 AddUpdatedFld(conResource.CheckResult);
}
}
}
public object this[int intIndex]
{
get
{
if (conResource.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (conResource.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (conResource.ResourceName  ==  AttributeName[intIndex])
{
return mstrResourceName;
}
else if (conResource.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (conResource.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (conResource.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (conResource.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (conResource.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conResource.UpdTime  ==  AttributeName[intIndex])
{
return mstrUpdTime;
}
else if (conResource.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conResource.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conResource.CheckDate  ==  AttributeName[intIndex])
{
return mstrCheckDate;
}
else if (conResource.CheckUser  ==  AttributeName[intIndex])
{
return mstrCheckUser;
}
else if (conResource.CheckResult  ==  AttributeName[intIndex])
{
return mstrCheckResult;
}
return null;
}
set
{
if (conResource.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(conResource.IdResource);
}
else if (conResource.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(conResource.ResourceID);
}
else if (conResource.ResourceName  ==  AttributeName[intIndex])
{
mstrResourceName = value.ToString();
 AddUpdatedFld(conResource.ResourceName);
}
else if (conResource.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(conResource.SaveMode);
}
else if (conResource.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(conResource.IdFtpResource);
}
else if (conResource.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(conResource.IdFile);
}
else if (conResource.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(conResource.IdResourceType);
}
else if (conResource.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conResource.UpdDate);
}
else if (conResource.UpdTime  ==  AttributeName[intIndex])
{
mstrUpdTime = value.ToString();
 AddUpdatedFld(conResource.UpdTime);
}
else if (conResource.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conResource.Memo);
}
else if (conResource.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conResource.FuncModuleId);
}
else if (conResource.CheckDate  ==  AttributeName[intIndex])
{
mstrCheckDate = value.ToString();
 AddUpdatedFld(conResource.CheckDate);
}
else if (conResource.CheckUser  ==  AttributeName[intIndex])
{
mstrCheckUser = value.ToString();
 AddUpdatedFld(conResource.CheckUser);
}
else if (conResource.CheckResult  ==  AttributeName[intIndex])
{
mstrCheckResult = value.ToString();
 AddUpdatedFld(conResource.CheckResult);
}
}
}

/// <summary>
/// 资源流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdResource
{
get
{
return mstrIdResource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdResource = value;
}
else
{
 mstrIdResource = value;
}
//记录修改过的字段
 AddUpdatedFld(conResource.IdResource);
}
}
/// <summary>
/// 资源ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceID
{
get
{
return mstrResourceID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceID = value;
}
else
{
 mstrResourceID = value;
}
//记录修改过的字段
 AddUpdatedFld(conResource.ResourceID);
}
}
/// <summary>
/// 资源名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceName
{
get
{
return mstrResourceName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceName = value;
}
else
{
 mstrResourceName = value;
}
//记录修改过的字段
 AddUpdatedFld(conResource.ResourceName);
}
}
/// <summary>
/// 文件存放方式(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool SaveMode
{
get
{
return mbolSaveMode;
}
set
{
 mbolSaveMode = value;
//记录修改过的字段
 AddUpdatedFld(conResource.SaveMode);
}
}
/// <summary>
/// FTP资源流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdFtpResource
{
get
{
return mstrIdFtpResource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdFtpResource = value;
}
else
{
 mstrIdFtpResource = value;
}
//记录修改过的字段
 AddUpdatedFld(conResource.IdFtpResource);
}
}
/// <summary>
/// 文件流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdFile
{
get
{
return mstrIdFile;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdFile = value;
}
else
{
 mstrIdFile = value;
}
//记录修改过的字段
 AddUpdatedFld(conResource.IdFile);
}
}
/// <summary>
/// 资源类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdResourceType
{
get
{
return mstrIdResourceType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdResourceType = value;
}
else
{
 mstrIdResourceType = value;
}
//记录修改过的字段
 AddUpdatedFld(conResource.IdResourceType);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conResource.UpdDate);
}
}
/// <summary>
/// UpdTime(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdTime
{
get
{
return mstrUpdTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdTime = value;
}
else
{
 mstrUpdTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conResource.UpdTime);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(conResource.Memo);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conResource.FuncModuleId);
}
}
/// <summary>
/// 检查日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckDate
{
get
{
return mstrCheckDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckDate = value;
}
else
{
 mstrCheckDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conResource.CheckDate);
}
}
/// <summary>
/// 检查用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckUser
{
get
{
return mstrCheckUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckUser = value;
}
else
{
 mstrCheckUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conResource.CheckUser);
}
}
/// <summary>
/// 检查结果(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckResult
{
get
{
return mstrCheckResult;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckResult = value;
}
else
{
 mstrCheckResult = value;
}
//记录修改过的字段
 AddUpdatedFld(conResource.CheckResult);
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
  return mstrIdResource;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrResourceName;
 }
 }
}
 /// <summary>
 /// 资源(Resource)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conResource
{
public const string _CurrTabName = "Resource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdResource"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdResource", "ResourceID", "ResourceName", "SaveMode", "IdFtpResource", "IdFile", "IdResourceType", "UpdDate", "UpdTime", "Memo", "FuncModuleId", "CheckDate", "CheckUser", "CheckResult"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResource = "IdResource";    //资源流水号

 /// <summary>
 /// 常量:"ResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceID = "ResourceID";    //资源ID

 /// <summary>
 /// 常量:"ResourceName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceName = "ResourceName";    //资源名称

 /// <summary>
 /// 常量:"SaveMode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveMode = "SaveMode";    //文件存放方式

 /// <summary>
 /// 常量:"IdFtpResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFtpResource = "IdFtpResource";    //FTP资源流水号

 /// <summary>
 /// 常量:"IdFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFile = "IdFile";    //文件流水号

 /// <summary>
 /// 常量:"IdResourceType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResourceType = "IdResourceType";    //资源类型流水号

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdTime = "UpdTime";    //UpdTime

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"CheckDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckDate = "CheckDate";    //检查日期

 /// <summary>
 /// 常量:"CheckUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckUser = "CheckUser";    //检查用户Id

 /// <summary>
 /// 常量:"CheckResult"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckResult = "CheckResult";    //检查结果
}

}