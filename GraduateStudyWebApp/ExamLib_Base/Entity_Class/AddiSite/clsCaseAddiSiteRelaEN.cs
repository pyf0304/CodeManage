﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseAddiSiteRelaEN
 表名:CaseAddiSiteRela(01120519)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:附加网站(AddiSite)
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
 /// 表CaseAddiSiteRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_CaseAddiSiteRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_CaseAddiSiteRela(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_CaseAddiSiteRela]类型的对象</returns>
public static implicit operator K_mId_CaseAddiSiteRela(long value)
{
return new K_mId_CaseAddiSiteRela(value);
}
}
 /// <summary>
 /// 案例和附加网站关系(CaseAddiSiteRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCaseAddiSiteRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CaseAddiSiteRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"mId", "IdDecompressionFile", "IdCase", "FuncModuleId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected long mlngIdDecompressionFile;    //解压缩文件流水号
protected string mstrIdCase;    //案例流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCaseAddiSiteRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsCaseAddiSiteRelaEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conCaseAddiSiteRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conCaseAddiSiteRela.IdDecompressionFile)
{
return mlngIdDecompressionFile;
}
else if (strAttributeName  ==  conCaseAddiSiteRela.IdCase)
{
return mstrIdCase;
}
else if (strAttributeName  ==  conCaseAddiSiteRela.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conCaseAddiSiteRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCaseAddiSiteRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCaseAddiSiteRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCaseAddiSiteRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseAddiSiteRela.mId);
}
else if (strAttributeName  ==  conCaseAddiSiteRela.IdDecompressionFile)
{
mlngIdDecompressionFile = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseAddiSiteRela.IdDecompressionFile);
}
else if (strAttributeName  ==  conCaseAddiSiteRela.IdCase)
{
mstrIdCase = value.ToString();
 AddUpdatedFld(conCaseAddiSiteRela.IdCase);
}
else if (strAttributeName  ==  conCaseAddiSiteRela.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conCaseAddiSiteRela.FuncModuleId);
}
else if (strAttributeName  ==  conCaseAddiSiteRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCaseAddiSiteRela.UpdDate);
}
else if (strAttributeName  ==  conCaseAddiSiteRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCaseAddiSiteRela.UpdUser);
}
else if (strAttributeName  ==  conCaseAddiSiteRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseAddiSiteRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCaseAddiSiteRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conCaseAddiSiteRela.IdDecompressionFile  ==  AttributeName[intIndex])
{
return mlngIdDecompressionFile;
}
else if (conCaseAddiSiteRela.IdCase  ==  AttributeName[intIndex])
{
return mstrIdCase;
}
else if (conCaseAddiSiteRela.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conCaseAddiSiteRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCaseAddiSiteRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCaseAddiSiteRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCaseAddiSiteRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseAddiSiteRela.mId);
}
else if (conCaseAddiSiteRela.IdDecompressionFile  ==  AttributeName[intIndex])
{
mlngIdDecompressionFile = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseAddiSiteRela.IdDecompressionFile);
}
else if (conCaseAddiSiteRela.IdCase  ==  AttributeName[intIndex])
{
mstrIdCase = value.ToString();
 AddUpdatedFld(conCaseAddiSiteRela.IdCase);
}
else if (conCaseAddiSiteRela.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conCaseAddiSiteRela.FuncModuleId);
}
else if (conCaseAddiSiteRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCaseAddiSiteRela.UpdDate);
}
else if (conCaseAddiSiteRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCaseAddiSiteRela.UpdUser);
}
else if (conCaseAddiSiteRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseAddiSiteRela.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conCaseAddiSiteRela.mId);
}
}
/// <summary>
/// 解压缩文件流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdDecompressionFile
{
get
{
return mlngIdDecompressionFile;
}
set
{
 mlngIdDecompressionFile = value;
//记录修改过的字段
 AddUpdatedFld(conCaseAddiSiteRela.IdDecompressionFile);
}
}
/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCase
{
get
{
return mstrIdCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCase = value;
}
else
{
 mstrIdCase = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseAddiSiteRela.IdCase);
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
 AddUpdatedFld(conCaseAddiSiteRela.FuncModuleId);
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
 AddUpdatedFld(conCaseAddiSiteRela.UpdDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
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
 AddUpdatedFld(conCaseAddiSiteRela.UpdUser);
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
 AddUpdatedFld(conCaseAddiSiteRela.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 案例和附加网站关系(CaseAddiSiteRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCaseAddiSiteRela
{
public const string _CurrTabName = "CaseAddiSiteRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IdDecompressionFile", "IdCase", "FuncModuleId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"IdDecompressionFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDecompressionFile = "IdDecompressionFile";    //解压缩文件流水号

 /// <summary>
 /// 常量:"IdCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCase = "IdCase";    //案例流水号

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}