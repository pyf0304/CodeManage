
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMProjectAppRelaEN
 表名:vCMProjectAppRela(00050634)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:46:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表vCMProjectAppRela的关键字(CMProjectAppRelaId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CMProjectAppRelaId_vCMProjectAppRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngCMProjectAppRelaId">表关键字</param>
public K_CMProjectAppRelaId_vCMProjectAppRela(long lngCMProjectAppRelaId)
{
if (IsValid(lngCMProjectAppRelaId)) Value = lngCMProjectAppRelaId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngCMProjectAppRelaId)
{
if (lngCMProjectAppRelaId == 0) return false;
if (lngCMProjectAppRelaId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CMProjectAppRelaId_vCMProjectAppRela]类型的对象</returns>
public static implicit operator K_CMProjectAppRelaId_vCMProjectAppRela(long value)
{
return new K_CMProjectAppRelaId_vCMProjectAppRela(value);
}
}
 /// <summary>
 /// vCMProjectAppRela(vCMProjectAppRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCMProjectAppRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCMProjectAppRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CMProjectAppRelaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"CMProjectAppRelaId", "PrjId", "PrjName", "Memo", "UpdDate", "ApplicationTypeName", "ApplicationTypeENName", "ApplicationTypeSimName", "CmPrjName", "ApplicationTypeId", "CmPrjId", "UpdUser", "OrderNum", "AppOrderNum", "AppIsVisible"};

protected long mlngCMProjectAppRelaId;    //Cm工程应用关系Id
protected string mstrPrjId;    //工程ID
protected string mstrPrjName;    //工程名称
protected string mstrMemo;    //说明
protected string mstrUpdDate;    //修改日期
protected string mstrApplicationTypeName;    //应用程序类型名称
protected string mstrApplicationTypeENName;    //应用类型英文名
protected string mstrApplicationTypeSimName;    //应用程序类型简称
protected string mstrCmPrjName;    //CM工程名
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrCmPrjId;    //CM工程Id
protected string mstrUpdUser;    //修改者
protected int mintOrderNum;    //序号
protected int? mintAppOrderNum;    //AppOrderNum
protected bool mbolAppIsVisible;    //AppIsVisible

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCMProjectAppRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CMProjectAppRelaId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngCMProjectAppRelaId">关键字:Cm工程应用关系Id</param>
public clsvCMProjectAppRelaEN(long lngCMProjectAppRelaId)
 {
 if (lngCMProjectAppRelaId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngCMProjectAppRelaId = lngCMProjectAppRelaId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CMProjectAppRelaId");
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
if (strAttributeName  ==  convCMProjectAppRela.CMProjectAppRelaId)
{
return mlngCMProjectAppRelaId;
}
else if (strAttributeName  ==  convCMProjectAppRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convCMProjectAppRela.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convCMProjectAppRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCMProjectAppRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCMProjectAppRela.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  convCMProjectAppRela.ApplicationTypeENName)
{
return mstrApplicationTypeENName;
}
else if (strAttributeName  ==  convCMProjectAppRela.ApplicationTypeSimName)
{
return mstrApplicationTypeSimName;
}
else if (strAttributeName  ==  convCMProjectAppRela.CmPrjName)
{
return mstrCmPrjName;
}
else if (strAttributeName  ==  convCMProjectAppRela.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convCMProjectAppRela.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  convCMProjectAppRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCMProjectAppRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convCMProjectAppRela.AppOrderNum)
{
return mintAppOrderNum;
}
else if (strAttributeName  ==  convCMProjectAppRela.AppIsVisible)
{
return mbolAppIsVisible;
}
return null;
}
set
{
if (strAttributeName  ==  convCMProjectAppRela.CMProjectAppRelaId)
{
mlngCMProjectAppRelaId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectAppRela.CMProjectAppRelaId);
}
else if (strAttributeName  ==  convCMProjectAppRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.PrjId);
}
else if (strAttributeName  ==  convCMProjectAppRela.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.PrjName);
}
else if (strAttributeName  ==  convCMProjectAppRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.Memo);
}
else if (strAttributeName  ==  convCMProjectAppRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.UpdDate);
}
else if (strAttributeName  ==  convCMProjectAppRela.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.ApplicationTypeName);
}
else if (strAttributeName  ==  convCMProjectAppRela.ApplicationTypeENName)
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.ApplicationTypeENName);
}
else if (strAttributeName  ==  convCMProjectAppRela.ApplicationTypeSimName)
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.ApplicationTypeSimName);
}
else if (strAttributeName  ==  convCMProjectAppRela.CmPrjName)
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.CmPrjName);
}
else if (strAttributeName  ==  convCMProjectAppRela.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectAppRela.ApplicationTypeId);
}
else if (strAttributeName  ==  convCMProjectAppRela.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.CmPrjId);
}
else if (strAttributeName  ==  convCMProjectAppRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.UpdUser);
}
else if (strAttributeName  ==  convCMProjectAppRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectAppRela.OrderNum);
}
else if (strAttributeName  ==  convCMProjectAppRela.AppOrderNum)
{
mintAppOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectAppRela.AppOrderNum);
}
else if (strAttributeName  ==  convCMProjectAppRela.AppIsVisible)
{
mbolAppIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMProjectAppRela.AppIsVisible);
}
}
}
public object this[int intIndex]
{
get
{
if (convCMProjectAppRela.CMProjectAppRelaId  ==  AttributeName[intIndex])
{
return mlngCMProjectAppRelaId;
}
else if (convCMProjectAppRela.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convCMProjectAppRela.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convCMProjectAppRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCMProjectAppRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCMProjectAppRela.ApplicationTypeName  ==  AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (convCMProjectAppRela.ApplicationTypeENName  ==  AttributeName[intIndex])
{
return mstrApplicationTypeENName;
}
else if (convCMProjectAppRela.ApplicationTypeSimName  ==  AttributeName[intIndex])
{
return mstrApplicationTypeSimName;
}
else if (convCMProjectAppRela.CmPrjName  ==  AttributeName[intIndex])
{
return mstrCmPrjName;
}
else if (convCMProjectAppRela.ApplicationTypeId  ==  AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convCMProjectAppRela.CmPrjId  ==  AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (convCMProjectAppRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCMProjectAppRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convCMProjectAppRela.AppOrderNum  ==  AttributeName[intIndex])
{
return mintAppOrderNum;
}
else if (convCMProjectAppRela.AppIsVisible  ==  AttributeName[intIndex])
{
return mbolAppIsVisible;
}
return null;
}
set
{
if (convCMProjectAppRela.CMProjectAppRelaId  ==  AttributeName[intIndex])
{
mlngCMProjectAppRelaId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectAppRela.CMProjectAppRelaId);
}
else if (convCMProjectAppRela.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.PrjId);
}
else if (convCMProjectAppRela.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.PrjName);
}
else if (convCMProjectAppRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.Memo);
}
else if (convCMProjectAppRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.UpdDate);
}
else if (convCMProjectAppRela.ApplicationTypeName  ==  AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.ApplicationTypeName);
}
else if (convCMProjectAppRela.ApplicationTypeENName  ==  AttributeName[intIndex])
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.ApplicationTypeENName);
}
else if (convCMProjectAppRela.ApplicationTypeSimName  ==  AttributeName[intIndex])
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.ApplicationTypeSimName);
}
else if (convCMProjectAppRela.CmPrjName  ==  AttributeName[intIndex])
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.CmPrjName);
}
else if (convCMProjectAppRela.ApplicationTypeId  ==  AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectAppRela.ApplicationTypeId);
}
else if (convCMProjectAppRela.CmPrjId  ==  AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.CmPrjId);
}
else if (convCMProjectAppRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMProjectAppRela.UpdUser);
}
else if (convCMProjectAppRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectAppRela.OrderNum);
}
else if (convCMProjectAppRela.AppOrderNum  ==  AttributeName[intIndex])
{
mintAppOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectAppRela.AppOrderNum);
}
else if (convCMProjectAppRela.AppIsVisible  ==  AttributeName[intIndex])
{
mbolAppIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMProjectAppRela.AppIsVisible);
}
}
}

/// <summary>
/// Cm工程应用关系Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long CMProjectAppRelaId
{
get
{
return mlngCMProjectAppRelaId;
}
set
{
 mlngCMProjectAppRelaId = value;
//记录修改过的字段
 AddUpdatedFld(convCMProjectAppRela.CMProjectAppRelaId);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectAppRela.PrjId);
}
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectAppRela.PrjName);
}
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
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
 AddUpdatedFld(convCMProjectAppRela.Memo);
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
 AddUpdatedFld(convCMProjectAppRela.UpdDate);
}
}
/// <summary>
/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeName
{
get
{
return mstrApplicationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeName = value;
}
else
{
 mstrApplicationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectAppRela.ApplicationTypeName);
}
}
/// <summary>
/// 应用类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeENName
{
get
{
return mstrApplicationTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeENName = value;
}
else
{
 mstrApplicationTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectAppRela.ApplicationTypeENName);
}
}
/// <summary>
/// 应用程序类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeSimName
{
get
{
return mstrApplicationTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeSimName = value;
}
else
{
 mstrApplicationTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectAppRela.ApplicationTypeSimName);
}
}
/// <summary>
/// CM工程名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjName
{
get
{
return mstrCmPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjName = value;
}
else
{
 mstrCmPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectAppRela.CmPrjName);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(convCMProjectAppRela.ApplicationTypeId);
}
}
/// <summary>
/// CM工程Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjId
{
get
{
return mstrCmPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjId = value;
}
else
{
 mstrCmPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectAppRela.CmPrjId);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectAppRela.UpdUser);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convCMProjectAppRela.OrderNum);
}
}
/// <summary>
/// AppOrderNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AppOrderNum
{
get
{
return mintAppOrderNum;
}
set
{
 mintAppOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convCMProjectAppRela.AppOrderNum);
}
}
/// <summary>
/// AppIsVisible(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool AppIsVisible
{
get
{
return mbolAppIsVisible;
}
set
{
 mbolAppIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(convCMProjectAppRela.AppIsVisible);
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
  return mlngCMProjectAppRelaId.ToString();
 }
 }
}
 /// <summary>
 /// vCMProjectAppRela(vCMProjectAppRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCMProjectAppRela
{
public const string _CurrTabName = "vCMProjectAppRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CMProjectAppRelaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CMProjectAppRelaId", "PrjId", "PrjName", "Memo", "UpdDate", "ApplicationTypeName", "ApplicationTypeENName", "ApplicationTypeSimName", "CmPrjName", "ApplicationTypeId", "CmPrjId", "UpdUser", "OrderNum", "AppOrderNum", "AppIsVisible"};
//以下是属性变量


 /// <summary>
 /// 常量:"CMProjectAppRelaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CMProjectAppRelaId = "CMProjectAppRelaId";    //Cm工程应用关系Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"ApplicationTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeENName = "ApplicationTypeENName";    //应用类型英文名

 /// <summary>
 /// 常量:"ApplicationTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeSimName = "ApplicationTypeSimName";    //应用程序类型简称

 /// <summary>
 /// 常量:"CmPrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjName = "CmPrjName";    //CM工程名

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //CM工程Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"AppOrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppOrderNum = "AppOrderNum";    //AppOrderNum

 /// <summary>
 /// 常量:"AppIsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppIsVisible = "AppIsVisible";    //AppIsVisible
}

}