
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvBrowseInfoStatistEN
 表名:vBrowseInfoStatist(01120470)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:实习记录(PracticeRecord)
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
 /// 表vBrowseInfoStatist的关键字(IdBrowseInfoStatist)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdBrowseInfoStatist_vBrowseInfoStatist
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdBrowseInfoStatist">表关键字</param>
public K_IdBrowseInfoStatist_vBrowseInfoStatist(long lngIdBrowseInfoStatist)
{
if (IsValid(lngIdBrowseInfoStatist)) Value = lngIdBrowseInfoStatist;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdBrowseInfoStatist)
{
if (lngIdBrowseInfoStatist == 0) return false;
if (lngIdBrowseInfoStatist == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdBrowseInfoStatist_vBrowseInfoStatist]类型的对象</returns>
public static implicit operator K_IdBrowseInfoStatist_vBrowseInfoStatist(long value)
{
return new K_IdBrowseInfoStatist_vBrowseInfoStatist(value);
}
}
 /// <summary>
 /// v浏览信息统计(vBrowseInfoStatist)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvBrowseInfoStatistEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vBrowseInfoStatist"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdBrowseInfoStatist"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"IdBrowseInfoStatist", "SystemModuleName", "IdUser", "IdSystemModule", "ClassResourceID", "BrowseInfoStatistDate", "BrowseInfoStatistTime", "BrowseTypeId", "BrowseSpendTime", "BrowseTypeName"};

protected long mlngIdBrowseInfoStatist;    //浏览信息统计流水号
protected string mstrSystemModuleName;    //系统模块名称
protected string mstrIdUser;    //id_User
protected string mstrIdSystemModule;    //系统模块流水号
protected string mstrClassResourceID;    //资源流水号
protected string mstrBrowseInfoStatistDate;    //浏览日期
protected string mstrBrowseInfoStatistTime;    //浏览时间
protected string mstrBrowseTypeId;    //BrowseTypeId
protected float? mfltBrowseSpendTime;    //浏览花费时间
protected string mstrBrowseTypeName;    //BrowseTypeName

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvBrowseInfoStatistEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdBrowseInfoStatist");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdBrowseInfoStatist">关键字:浏览信息统计流水号</param>
public clsvBrowseInfoStatistEN(long lngIdBrowseInfoStatist)
 {
 if (lngIdBrowseInfoStatist  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdBrowseInfoStatist = lngIdBrowseInfoStatist;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdBrowseInfoStatist");
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
if (strAttributeName  ==  convBrowseInfoStatist.IdBrowseInfoStatist)
{
return mlngIdBrowseInfoStatist;
}
else if (strAttributeName  ==  convBrowseInfoStatist.SystemModuleName)
{
return mstrSystemModuleName;
}
else if (strAttributeName  ==  convBrowseInfoStatist.IdUser)
{
return mstrIdUser;
}
else if (strAttributeName  ==  convBrowseInfoStatist.IdSystemModule)
{
return mstrIdSystemModule;
}
else if (strAttributeName  ==  convBrowseInfoStatist.ClassResourceID)
{
return mstrClassResourceID;
}
else if (strAttributeName  ==  convBrowseInfoStatist.BrowseInfoStatistDate)
{
return mstrBrowseInfoStatistDate;
}
else if (strAttributeName  ==  convBrowseInfoStatist.BrowseInfoStatistTime)
{
return mstrBrowseInfoStatistTime;
}
else if (strAttributeName  ==  convBrowseInfoStatist.BrowseTypeId)
{
return mstrBrowseTypeId;
}
else if (strAttributeName  ==  convBrowseInfoStatist.BrowseSpendTime)
{
return mfltBrowseSpendTime;
}
else if (strAttributeName  ==  convBrowseInfoStatist.BrowseTypeName)
{
return mstrBrowseTypeName;
}
return null;
}
set
{
if (strAttributeName  ==  convBrowseInfoStatist.IdBrowseInfoStatist)
{
mlngIdBrowseInfoStatist = TransNullToInt(value.ToString());
 AddUpdatedFld(convBrowseInfoStatist.IdBrowseInfoStatist);
}
else if (strAttributeName  ==  convBrowseInfoStatist.SystemModuleName)
{
mstrSystemModuleName = value.ToString();
 AddUpdatedFld(convBrowseInfoStatist.SystemModuleName);
}
else if (strAttributeName  ==  convBrowseInfoStatist.IdUser)
{
mstrIdUser = value.ToString();
 AddUpdatedFld(convBrowseInfoStatist.IdUser);
}
else if (strAttributeName  ==  convBrowseInfoStatist.IdSystemModule)
{
mstrIdSystemModule = value.ToString();
 AddUpdatedFld(convBrowseInfoStatist.IdSystemModule);
}
else if (strAttributeName  ==  convBrowseInfoStatist.ClassResourceID)
{
mstrClassResourceID = value.ToString();
 AddUpdatedFld(convBrowseInfoStatist.ClassResourceID);
}
else if (strAttributeName  ==  convBrowseInfoStatist.BrowseInfoStatistDate)
{
mstrBrowseInfoStatistDate = value.ToString();
 AddUpdatedFld(convBrowseInfoStatist.BrowseInfoStatistDate);
}
else if (strAttributeName  ==  convBrowseInfoStatist.BrowseInfoStatistTime)
{
mstrBrowseInfoStatistTime = value.ToString();
 AddUpdatedFld(convBrowseInfoStatist.BrowseInfoStatistTime);
}
else if (strAttributeName  ==  convBrowseInfoStatist.BrowseTypeId)
{
mstrBrowseTypeId = value.ToString();
 AddUpdatedFld(convBrowseInfoStatist.BrowseTypeId);
}
else if (strAttributeName  ==  convBrowseInfoStatist.BrowseSpendTime)
{
mfltBrowseSpendTime = TransNullToFloat(value.ToString());
 AddUpdatedFld(convBrowseInfoStatist.BrowseSpendTime);
}
else if (strAttributeName  ==  convBrowseInfoStatist.BrowseTypeName)
{
mstrBrowseTypeName = value.ToString();
 AddUpdatedFld(convBrowseInfoStatist.BrowseTypeName);
}
}
}
public object this[int intIndex]
{
get
{
if (convBrowseInfoStatist.IdBrowseInfoStatist  ==  AttributeName[intIndex])
{
return mlngIdBrowseInfoStatist;
}
else if (convBrowseInfoStatist.SystemModuleName  ==  AttributeName[intIndex])
{
return mstrSystemModuleName;
}
else if (convBrowseInfoStatist.IdUser  ==  AttributeName[intIndex])
{
return mstrIdUser;
}
else if (convBrowseInfoStatist.IdSystemModule  ==  AttributeName[intIndex])
{
return mstrIdSystemModule;
}
else if (convBrowseInfoStatist.ClassResourceID  ==  AttributeName[intIndex])
{
return mstrClassResourceID;
}
else if (convBrowseInfoStatist.BrowseInfoStatistDate  ==  AttributeName[intIndex])
{
return mstrBrowseInfoStatistDate;
}
else if (convBrowseInfoStatist.BrowseInfoStatistTime  ==  AttributeName[intIndex])
{
return mstrBrowseInfoStatistTime;
}
else if (convBrowseInfoStatist.BrowseTypeId  ==  AttributeName[intIndex])
{
return mstrBrowseTypeId;
}
else if (convBrowseInfoStatist.BrowseSpendTime  ==  AttributeName[intIndex])
{
return mfltBrowseSpendTime;
}
else if (convBrowseInfoStatist.BrowseTypeName  ==  AttributeName[intIndex])
{
return mstrBrowseTypeName;
}
return null;
}
set
{
if (convBrowseInfoStatist.IdBrowseInfoStatist  ==  AttributeName[intIndex])
{
mlngIdBrowseInfoStatist = TransNullToInt(value.ToString());
 AddUpdatedFld(convBrowseInfoStatist.IdBrowseInfoStatist);
}
else if (convBrowseInfoStatist.SystemModuleName  ==  AttributeName[intIndex])
{
mstrSystemModuleName = value.ToString();
 AddUpdatedFld(convBrowseInfoStatist.SystemModuleName);
}
else if (convBrowseInfoStatist.IdUser  ==  AttributeName[intIndex])
{
mstrIdUser = value.ToString();
 AddUpdatedFld(convBrowseInfoStatist.IdUser);
}
else if (convBrowseInfoStatist.IdSystemModule  ==  AttributeName[intIndex])
{
mstrIdSystemModule = value.ToString();
 AddUpdatedFld(convBrowseInfoStatist.IdSystemModule);
}
else if (convBrowseInfoStatist.ClassResourceID  ==  AttributeName[intIndex])
{
mstrClassResourceID = value.ToString();
 AddUpdatedFld(convBrowseInfoStatist.ClassResourceID);
}
else if (convBrowseInfoStatist.BrowseInfoStatistDate  ==  AttributeName[intIndex])
{
mstrBrowseInfoStatistDate = value.ToString();
 AddUpdatedFld(convBrowseInfoStatist.BrowseInfoStatistDate);
}
else if (convBrowseInfoStatist.BrowseInfoStatistTime  ==  AttributeName[intIndex])
{
mstrBrowseInfoStatistTime = value.ToString();
 AddUpdatedFld(convBrowseInfoStatist.BrowseInfoStatistTime);
}
else if (convBrowseInfoStatist.BrowseTypeId  ==  AttributeName[intIndex])
{
mstrBrowseTypeId = value.ToString();
 AddUpdatedFld(convBrowseInfoStatist.BrowseTypeId);
}
else if (convBrowseInfoStatist.BrowseSpendTime  ==  AttributeName[intIndex])
{
mfltBrowseSpendTime = TransNullToFloat(value.ToString());
 AddUpdatedFld(convBrowseInfoStatist.BrowseSpendTime);
}
else if (convBrowseInfoStatist.BrowseTypeName  ==  AttributeName[intIndex])
{
mstrBrowseTypeName = value.ToString();
 AddUpdatedFld(convBrowseInfoStatist.BrowseTypeName);
}
}
}

/// <summary>
/// 浏览信息统计流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdBrowseInfoStatist
{
get
{
return mlngIdBrowseInfoStatist;
}
set
{
 mlngIdBrowseInfoStatist = value;
//记录修改过的字段
 AddUpdatedFld(convBrowseInfoStatist.IdBrowseInfoStatist);
}
}
/// <summary>
/// 系统模块名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SystemModuleName
{
get
{
return mstrSystemModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSystemModuleName = value;
}
else
{
 mstrSystemModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convBrowseInfoStatist.SystemModuleName);
}
}
/// <summary>
/// id_User(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdUser
{
get
{
return mstrIdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdUser = value;
}
else
{
 mstrIdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convBrowseInfoStatist.IdUser);
}
}
/// <summary>
/// 系统模块流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSystemModule
{
get
{
return mstrIdSystemModule;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSystemModule = value;
}
else
{
 mstrIdSystemModule = value;
}
//记录修改过的字段
 AddUpdatedFld(convBrowseInfoStatist.IdSystemModule);
}
}
/// <summary>
/// 资源流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassResourceID
{
get
{
return mstrClassResourceID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassResourceID = value;
}
else
{
 mstrClassResourceID = value;
}
//记录修改过的字段
 AddUpdatedFld(convBrowseInfoStatist.ClassResourceID);
}
}
/// <summary>
/// 浏览日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BrowseInfoStatistDate
{
get
{
return mstrBrowseInfoStatistDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBrowseInfoStatistDate = value;
}
else
{
 mstrBrowseInfoStatistDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convBrowseInfoStatist.BrowseInfoStatistDate);
}
}
/// <summary>
/// 浏览时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BrowseInfoStatistTime
{
get
{
return mstrBrowseInfoStatistTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBrowseInfoStatistTime = value;
}
else
{
 mstrBrowseInfoStatistTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convBrowseInfoStatist.BrowseInfoStatistTime);
}
}
/// <summary>
/// BrowseTypeId(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BrowseTypeId
{
get
{
return mstrBrowseTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBrowseTypeId = value;
}
else
{
 mstrBrowseTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convBrowseInfoStatist.BrowseTypeId);
}
}
/// <summary>
/// 浏览花费时间(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? BrowseSpendTime
{
get
{
return mfltBrowseSpendTime;
}
set
{
 mfltBrowseSpendTime = value;
//记录修改过的字段
 AddUpdatedFld(convBrowseInfoStatist.BrowseSpendTime);
}
}
/// <summary>
/// BrowseTypeName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BrowseTypeName
{
get
{
return mstrBrowseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBrowseTypeName = value;
}
else
{
 mstrBrowseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convBrowseInfoStatist.BrowseTypeName);
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
  return mlngIdBrowseInfoStatist.ToString();
 }
 }
}
 /// <summary>
 /// v浏览信息统计(vBrowseInfoStatist)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convBrowseInfoStatist
{
public const string _CurrTabName = "vBrowseInfoStatist"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdBrowseInfoStatist"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdBrowseInfoStatist", "SystemModuleName", "IdUser", "IdSystemModule", "ClassResourceID", "BrowseInfoStatistDate", "BrowseInfoStatistTime", "BrowseTypeId", "BrowseSpendTime", "BrowseTypeName"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdBrowseInfoStatist"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdBrowseInfoStatist = "IdBrowseInfoStatist";    //浏览信息统计流水号

 /// <summary>
 /// 常量:"SystemModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SystemModuleName = "SystemModuleName";    //系统模块名称

 /// <summary>
 /// 常量:"IdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdUser = "IdUser";    //id_User

 /// <summary>
 /// 常量:"IdSystemModule"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSystemModule = "IdSystemModule";    //系统模块流水号

 /// <summary>
 /// 常量:"ClassResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassResourceID = "ClassResourceID";    //资源流水号

 /// <summary>
 /// 常量:"BrowseInfoStatistDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseInfoStatistDate = "BrowseInfoStatistDate";    //浏览日期

 /// <summary>
 /// 常量:"BrowseInfoStatistTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseInfoStatistTime = "BrowseInfoStatistTime";    //浏览时间

 /// <summary>
 /// 常量:"BrowseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseTypeId = "BrowseTypeId";    //BrowseTypeId

 /// <summary>
 /// 常量:"BrowseSpendTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseSpendTime = "BrowseSpendTime";    //浏览花费时间

 /// <summary>
 /// 常量:"BrowseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseTypeName = "BrowseTypeName";    //BrowseTypeName
}

}