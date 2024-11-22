
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseQuantitySenateEN
 表名:PubClassCaseQuantitySenate(01120415)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// 表PubClassCaseQuantitySenate的关键字(IdpubClassCaseQuantitySenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdpubClassCaseQuantitySenate_PubClassCaseQuantitySenate
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdpubClassCaseQuantitySenate">表关键字</param>
public K_IdpubClassCaseQuantitySenate_PubClassCaseQuantitySenate(long lngIdpubClassCaseQuantitySenate)
{
if (IsValid(lngIdpubClassCaseQuantitySenate)) Value = lngIdpubClassCaseQuantitySenate;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdpubClassCaseQuantitySenate)
{
if (lngIdpubClassCaseQuantitySenate == 0) return false;
if (lngIdpubClassCaseQuantitySenate == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdpubClassCaseQuantitySenate_PubClassCaseQuantitySenate]类型的对象</returns>
public static implicit operator K_IdpubClassCaseQuantitySenate_PubClassCaseQuantitySenate(long value)
{
return new K_IdpubClassCaseQuantitySenate_PubClassCaseQuantitySenate(value);
}
}
 /// <summary>
 /// 公开课案例量化评价(PubClassCaseQuantitySenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPubClassCaseQuantitySenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PubClassCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdpubClassCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"IdpubClassCaseQuantitySenate", "IdPubClassCase", "IdsenateGauge", "pubClassCaseQuantitySenateScore", "UserId", "OptDate"};

protected long mlngIdpubClassCaseQuantitySenate;    //流水号
protected string mstrIdPubClassCase;    //案例流水号
protected string mstrIdsenateGauge;    //评价量规流水号
protected int mintpubClassCaseQuantitySenateScore;    //评分
protected string mstrUserId;    //用户ID
protected string mstrOptDate;    //OptDate

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPubClassCaseQuantitySenateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdpubClassCaseQuantitySenate");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdpubClassCaseQuantitySenate">关键字:流水号</param>
public clsPubClassCaseQuantitySenateEN(long lngIdpubClassCaseQuantitySenate)
 {
 if (lngIdpubClassCaseQuantitySenate  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdpubClassCaseQuantitySenate = lngIdpubClassCaseQuantitySenate;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdpubClassCaseQuantitySenate");
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
if (strAttributeName  ==  conPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate)
{
return mlngIdpubClassCaseQuantitySenate;
}
else if (strAttributeName  ==  conPubClassCaseQuantitySenate.IdPubClassCase)
{
return mstrIdPubClassCase;
}
else if (strAttributeName  ==  conPubClassCaseQuantitySenate.IdsenateGauge)
{
return mstrIdsenateGauge;
}
else if (strAttributeName  ==  conPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore)
{
return mintpubClassCaseQuantitySenateScore;
}
else if (strAttributeName  ==  conPubClassCaseQuantitySenate.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conPubClassCaseQuantitySenate.OptDate)
{
return mstrOptDate;
}
return null;
}
set
{
if (strAttributeName  ==  conPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate)
{
mlngIdpubClassCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate);
}
else if (strAttributeName  ==  conPubClassCaseQuantitySenate.IdPubClassCase)
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(conPubClassCaseQuantitySenate.IdPubClassCase);
}
else if (strAttributeName  ==  conPubClassCaseQuantitySenate.IdsenateGauge)
{
mstrIdsenateGauge = value.ToString();
 AddUpdatedFld(conPubClassCaseQuantitySenate.IdsenateGauge);
}
else if (strAttributeName  ==  conPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore)
{
mintpubClassCaseQuantitySenateScore = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore);
}
else if (strAttributeName  ==  conPubClassCaseQuantitySenate.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conPubClassCaseQuantitySenate.UserId);
}
else if (strAttributeName  ==  conPubClassCaseQuantitySenate.OptDate)
{
mstrOptDate = value.ToString();
 AddUpdatedFld(conPubClassCaseQuantitySenate.OptDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate  ==  AttributeName[intIndex])
{
return mlngIdpubClassCaseQuantitySenate;
}
else if (conPubClassCaseQuantitySenate.IdPubClassCase  ==  AttributeName[intIndex])
{
return mstrIdPubClassCase;
}
else if (conPubClassCaseQuantitySenate.IdsenateGauge  ==  AttributeName[intIndex])
{
return mstrIdsenateGauge;
}
else if (conPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore  ==  AttributeName[intIndex])
{
return mintpubClassCaseQuantitySenateScore;
}
else if (conPubClassCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conPubClassCaseQuantitySenate.OptDate  ==  AttributeName[intIndex])
{
return mstrOptDate;
}
return null;
}
set
{
if (conPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate  ==  AttributeName[intIndex])
{
mlngIdpubClassCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate);
}
else if (conPubClassCaseQuantitySenate.IdPubClassCase  ==  AttributeName[intIndex])
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(conPubClassCaseQuantitySenate.IdPubClassCase);
}
else if (conPubClassCaseQuantitySenate.IdsenateGauge  ==  AttributeName[intIndex])
{
mstrIdsenateGauge = value.ToString();
 AddUpdatedFld(conPubClassCaseQuantitySenate.IdsenateGauge);
}
else if (conPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore  ==  AttributeName[intIndex])
{
mintpubClassCaseQuantitySenateScore = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore);
}
else if (conPubClassCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conPubClassCaseQuantitySenate.UserId);
}
else if (conPubClassCaseQuantitySenate.OptDate  ==  AttributeName[intIndex])
{
mstrOptDate = value.ToString();
 AddUpdatedFld(conPubClassCaseQuantitySenate.OptDate);
}
}
}

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdpubClassCaseQuantitySenate
{
get
{
return mlngIdpubClassCaseQuantitySenate;
}
set
{
 mlngIdpubClassCaseQuantitySenate = value;
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate);
}
}
/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubClassCase
{
get
{
return mstrIdPubClassCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubClassCase = value;
}
else
{
 mstrIdPubClassCase = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseQuantitySenate.IdPubClassCase);
}
}
/// <summary>
/// 评价量规流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdsenateGauge
{
get
{
return mstrIdsenateGauge;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdsenateGauge = value;
}
else
{
 mstrIdsenateGauge = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseQuantitySenate.IdsenateGauge);
}
}
/// <summary>
/// 评分(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int pubClassCaseQuantitySenateScore
{
get
{
return mintpubClassCaseQuantitySenateScore;
}
set
{
 mintpubClassCaseQuantitySenateScore = value;
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseQuantitySenate.UserId);
}
}
/// <summary>
/// OptDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OptDate
{
get
{
return mstrOptDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOptDate = value;
}
else
{
 mstrOptDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseQuantitySenate.OptDate);
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
  return mlngIdpubClassCaseQuantitySenate.ToString();
 }
 }
}
 /// <summary>
 /// 公开课案例量化评价(PubClassCaseQuantitySenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPubClassCaseQuantitySenate
{
public const string _CurrTabName = "PubClassCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdpubClassCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdpubClassCaseQuantitySenate", "IdPubClassCase", "IdsenateGauge", "pubClassCaseQuantitySenateScore", "UserId", "OptDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdpubClassCaseQuantitySenate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdpubClassCaseQuantitySenate = "IdpubClassCaseQuantitySenate";    //流水号

 /// <summary>
 /// 常量:"IdPubClassCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCase = "IdPubClassCase";    //案例流水号

 /// <summary>
 /// 常量:"IdsenateGauge"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdsenateGauge = "IdsenateGauge";    //评价量规流水号

 /// <summary>
 /// 常量:"pubClassCaseQuantitySenateScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string pubClassCaseQuantitySenateScore = "pubClassCaseQuantitySenateScore";    //评分

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"OptDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OptDate = "OptDate";    //OptDate
}

}