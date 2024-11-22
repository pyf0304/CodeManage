
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCaseQuantitySenateItems_AvgEN
 表名:vMicroteachCaseQuantitySenateItems_Avg(01120491)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:56
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 表vMicroteachCaseQuantitySenateItems_Avg的关键字(IdmicroteachCaseQuantitySenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdmicroteachCaseQuantitySenate_vMicroteachCaseQuantitySenateItems_Avg
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdmicroteachCaseQuantitySenate">表关键字</param>
public K_IdmicroteachCaseQuantitySenate_vMicroteachCaseQuantitySenateItems_Avg(long lngIdmicroteachCaseQuantitySenate)
{
if (IsValid(lngIdmicroteachCaseQuantitySenate)) Value = lngIdmicroteachCaseQuantitySenate;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdmicroteachCaseQuantitySenate)
{
if (lngIdmicroteachCaseQuantitySenate == 0) return false;
if (lngIdmicroteachCaseQuantitySenate == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdmicroteachCaseQuantitySenate_vMicroteachCaseQuantitySenateItems_Avg]类型的对象</returns>
public static implicit operator K_IdmicroteachCaseQuantitySenate_vMicroteachCaseQuantitySenateItems_Avg(long value)
{
return new K_IdmicroteachCaseQuantitySenate_vMicroteachCaseQuantitySenateItems_Avg(value);
}
}
 /// <summary>
 /// v微格量化评价详细指标_Avg(vMicroteachCaseQuantitySenateItems_Avg)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvMicroteachCaseQuantitySenateItems_AvgEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vMicroteachCaseQuantitySenateItems_Avg"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenate", "IdSenateGaugeItem", "SenateScoreAvg"};

protected long mlngIdmicroteachCaseQuantitySenate;    //微格量化评价流水号
protected string mstrIdSenateGaugeItem;    //量表指标流水号
protected float? mfltSenateScoreAvg;    //评议平均分

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvMicroteachCaseQuantitySenateItems_AvgEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdmicroteachCaseQuantitySenate");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdmicroteachCaseQuantitySenate">关键字:微格量化评价流水号</param>
public clsvMicroteachCaseQuantitySenateItems_AvgEN(long lngIdmicroteachCaseQuantitySenate)
 {
 if (lngIdmicroteachCaseQuantitySenate  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdmicroteachCaseQuantitySenate = lngIdmicroteachCaseQuantitySenate;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdmicroteachCaseQuantitySenate");
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
if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate)
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem)
{
return mstrIdSenateGaugeItem;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg)
{
return mfltSenateScoreAvg;
}
return null;
}
set
{
if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate)
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem)
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg)
{
mfltSenateScoreAvg = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg);
}
}
}
public object this[int intIndex]
{
get
{
if (convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeItem;
}
else if (convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg  ==  AttributeName[intIndex])
{
return mfltSenateScoreAvg;
}
return null;
}
set
{
if (convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate);
}
else if (convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem);
}
else if (convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg  ==  AttributeName[intIndex])
{
mfltSenateScoreAvg = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg);
}
}
}

/// <summary>
/// 微格量化评价流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdmicroteachCaseQuantitySenate
{
get
{
return mlngIdmicroteachCaseQuantitySenate;
}
set
{
 mlngIdmicroteachCaseQuantitySenate = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate);
}
}
/// <summary>
/// 量表指标流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSenateGaugeItem
{
get
{
return mstrIdSenateGaugeItem;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSenateGaugeItem = value;
}
else
{
 mstrIdSenateGaugeItem = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem);
}
}
/// <summary>
/// 评议平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? SenateScoreAvg
{
get
{
return mfltSenateScoreAvg;
}
set
{
 mfltSenateScoreAvg = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg);
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
  return mlngIdmicroteachCaseQuantitySenate.ToString();
 }
 }
}
 /// <summary>
 /// v微格量化评价详细指标_Avg(vMicroteachCaseQuantitySenateItems_Avg)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convMicroteachCaseQuantitySenateItems_Avg
{
public const string _CurrTabName = "vMicroteachCaseQuantitySenateItems_Avg"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenate", "IdSenateGaugeItem", "SenateScoreAvg"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdmicroteachCaseQuantitySenate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdmicroteachCaseQuantitySenate = "IdmicroteachCaseQuantitySenate";    //微格量化评价流水号

 /// <summary>
 /// 常量:"IdSenateGaugeItem"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeItem = "IdSenateGaugeItem";    //量表指标流水号

 /// <summary>
 /// 常量:"SenateScoreAvg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateScoreAvg = "SenateScoreAvg";    //评议平均分
}

}