
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsBrowseInfoStatistEN
 表名:BrowseInfoStatist(01120469)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:实习记录(PracticeRecord)
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
 /// 表BrowseInfoStatist的关键字(IdBrowseInfoStatist)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdBrowseInfoStatist_BrowseInfoStatist
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
public K_IdBrowseInfoStatist_BrowseInfoStatist(long lngIdBrowseInfoStatist)
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
 /// <returns>返回:[K_IdBrowseInfoStatist_BrowseInfoStatist]类型的对象</returns>
public static implicit operator K_IdBrowseInfoStatist_BrowseInfoStatist(long value)
{
return new K_IdBrowseInfoStatist_BrowseInfoStatist(value);
}
}
 /// <summary>
 /// 浏览信息统计(BrowseInfoStatist)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsBrowseInfoStatistEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "BrowseInfoStatist"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdBrowseInfoStatist"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"IdBrowseInfoStatist", "IdUser", "IdSystemModule", "ClassResourceID", "BrowseInfoStatistDate", "BrowseInfoStatistTime", "BrowseTypeId", "BrowseSpendTime"};

protected long mlngIdBrowseInfoStatist;    //浏览信息统计流水号
protected string mstrIdUser;    //用户流水号
protected string mstrIdSystemModule;    //系统模块流水号
protected string mstrClassResourceID;    //资源流水号
protected string mstrBrowseInfoStatistDate;    //浏览日期
protected string mstrBrowseInfoStatistTime;    //浏览时间
protected string mstrBrowseTypeId;    //BrowseTypeId
protected float? mfltBrowseSpendTime;    //浏览花费时间

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsBrowseInfoStatistEN()
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
public clsBrowseInfoStatistEN(long lngIdBrowseInfoStatist)
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
if (strAttributeName  ==  conBrowseInfoStatist.IdBrowseInfoStatist)
{
return mlngIdBrowseInfoStatist;
}
else if (strAttributeName  ==  conBrowseInfoStatist.IdUser)
{
return mstrIdUser;
}
else if (strAttributeName  ==  conBrowseInfoStatist.IdSystemModule)
{
return mstrIdSystemModule;
}
else if (strAttributeName  ==  conBrowseInfoStatist.ClassResourceID)
{
return mstrClassResourceID;
}
else if (strAttributeName  ==  conBrowseInfoStatist.BrowseInfoStatistDate)
{
return mstrBrowseInfoStatistDate;
}
else if (strAttributeName  ==  conBrowseInfoStatist.BrowseInfoStatistTime)
{
return mstrBrowseInfoStatistTime;
}
else if (strAttributeName  ==  conBrowseInfoStatist.BrowseTypeId)
{
return mstrBrowseTypeId;
}
else if (strAttributeName  ==  conBrowseInfoStatist.BrowseSpendTime)
{
return mfltBrowseSpendTime;
}
return null;
}
set
{
if (strAttributeName  ==  conBrowseInfoStatist.IdBrowseInfoStatist)
{
mlngIdBrowseInfoStatist = TransNullToInt(value.ToString());
 AddUpdatedFld(conBrowseInfoStatist.IdBrowseInfoStatist);
}
else if (strAttributeName  ==  conBrowseInfoStatist.IdUser)
{
mstrIdUser = value.ToString();
 AddUpdatedFld(conBrowseInfoStatist.IdUser);
}
else if (strAttributeName  ==  conBrowseInfoStatist.IdSystemModule)
{
mstrIdSystemModule = value.ToString();
 AddUpdatedFld(conBrowseInfoStatist.IdSystemModule);
}
else if (strAttributeName  ==  conBrowseInfoStatist.ClassResourceID)
{
mstrClassResourceID = value.ToString();
 AddUpdatedFld(conBrowseInfoStatist.ClassResourceID);
}
else if (strAttributeName  ==  conBrowseInfoStatist.BrowseInfoStatistDate)
{
mstrBrowseInfoStatistDate = value.ToString();
 AddUpdatedFld(conBrowseInfoStatist.BrowseInfoStatistDate);
}
else if (strAttributeName  ==  conBrowseInfoStatist.BrowseInfoStatistTime)
{
mstrBrowseInfoStatistTime = value.ToString();
 AddUpdatedFld(conBrowseInfoStatist.BrowseInfoStatistTime);
}
else if (strAttributeName  ==  conBrowseInfoStatist.BrowseTypeId)
{
mstrBrowseTypeId = value.ToString();
 AddUpdatedFld(conBrowseInfoStatist.BrowseTypeId);
}
else if (strAttributeName  ==  conBrowseInfoStatist.BrowseSpendTime)
{
mfltBrowseSpendTime = TransNullToFloat(value.ToString());
 AddUpdatedFld(conBrowseInfoStatist.BrowseSpendTime);
}
}
}
public object this[int intIndex]
{
get
{
if (conBrowseInfoStatist.IdBrowseInfoStatist  ==  AttributeName[intIndex])
{
return mlngIdBrowseInfoStatist;
}
else if (conBrowseInfoStatist.IdUser  ==  AttributeName[intIndex])
{
return mstrIdUser;
}
else if (conBrowseInfoStatist.IdSystemModule  ==  AttributeName[intIndex])
{
return mstrIdSystemModule;
}
else if (conBrowseInfoStatist.ClassResourceID  ==  AttributeName[intIndex])
{
return mstrClassResourceID;
}
else if (conBrowseInfoStatist.BrowseInfoStatistDate  ==  AttributeName[intIndex])
{
return mstrBrowseInfoStatistDate;
}
else if (conBrowseInfoStatist.BrowseInfoStatistTime  ==  AttributeName[intIndex])
{
return mstrBrowseInfoStatistTime;
}
else if (conBrowseInfoStatist.BrowseTypeId  ==  AttributeName[intIndex])
{
return mstrBrowseTypeId;
}
else if (conBrowseInfoStatist.BrowseSpendTime  ==  AttributeName[intIndex])
{
return mfltBrowseSpendTime;
}
return null;
}
set
{
if (conBrowseInfoStatist.IdBrowseInfoStatist  ==  AttributeName[intIndex])
{
mlngIdBrowseInfoStatist = TransNullToInt(value.ToString());
 AddUpdatedFld(conBrowseInfoStatist.IdBrowseInfoStatist);
}
else if (conBrowseInfoStatist.IdUser  ==  AttributeName[intIndex])
{
mstrIdUser = value.ToString();
 AddUpdatedFld(conBrowseInfoStatist.IdUser);
}
else if (conBrowseInfoStatist.IdSystemModule  ==  AttributeName[intIndex])
{
mstrIdSystemModule = value.ToString();
 AddUpdatedFld(conBrowseInfoStatist.IdSystemModule);
}
else if (conBrowseInfoStatist.ClassResourceID  ==  AttributeName[intIndex])
{
mstrClassResourceID = value.ToString();
 AddUpdatedFld(conBrowseInfoStatist.ClassResourceID);
}
else if (conBrowseInfoStatist.BrowseInfoStatistDate  ==  AttributeName[intIndex])
{
mstrBrowseInfoStatistDate = value.ToString();
 AddUpdatedFld(conBrowseInfoStatist.BrowseInfoStatistDate);
}
else if (conBrowseInfoStatist.BrowseInfoStatistTime  ==  AttributeName[intIndex])
{
mstrBrowseInfoStatistTime = value.ToString();
 AddUpdatedFld(conBrowseInfoStatist.BrowseInfoStatistTime);
}
else if (conBrowseInfoStatist.BrowseTypeId  ==  AttributeName[intIndex])
{
mstrBrowseTypeId = value.ToString();
 AddUpdatedFld(conBrowseInfoStatist.BrowseTypeId);
}
else if (conBrowseInfoStatist.BrowseSpendTime  ==  AttributeName[intIndex])
{
mfltBrowseSpendTime = TransNullToFloat(value.ToString());
 AddUpdatedFld(conBrowseInfoStatist.BrowseSpendTime);
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
 AddUpdatedFld(conBrowseInfoStatist.IdBrowseInfoStatist);
}
}
/// <summary>
/// 用户流水号(说明:;字段类型:varchar;字段长度:50;是否可空:False)
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
 AddUpdatedFld(conBrowseInfoStatist.IdUser);
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
 AddUpdatedFld(conBrowseInfoStatist.IdSystemModule);
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
 AddUpdatedFld(conBrowseInfoStatist.ClassResourceID);
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
 AddUpdatedFld(conBrowseInfoStatist.BrowseInfoStatistDate);
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
 AddUpdatedFld(conBrowseInfoStatist.BrowseInfoStatistTime);
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
 AddUpdatedFld(conBrowseInfoStatist.BrowseTypeId);
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
 AddUpdatedFld(conBrowseInfoStatist.BrowseSpendTime);
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
 /// 浏览信息统计(BrowseInfoStatist)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conBrowseInfoStatist
{
public const string _CurrTabName = "BrowseInfoStatist"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdBrowseInfoStatist"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdBrowseInfoStatist", "IdUser", "IdSystemModule", "ClassResourceID", "BrowseInfoStatistDate", "BrowseInfoStatistTime", "BrowseTypeId", "BrowseSpendTime"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdBrowseInfoStatist"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdBrowseInfoStatist = "IdBrowseInfoStatist";    //浏览信息统计流水号

 /// <summary>
 /// 常量:"IdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdUser = "IdUser";    //用户流水号

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
}

}