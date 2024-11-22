
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewpointScoreEN
 表名:zx_ViewpointScore(01120859)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:54:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研究生培养(GraduateEdu)
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
 /// 表zx_ViewpointScore的关键字(ViewpointScoreId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewpointScoreId_zx_ViewpointScore
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngViewpointScoreId">表关键字</param>
public K_ViewpointScoreId_zx_ViewpointScore(long lngViewpointScoreId)
{
if (IsValid(lngViewpointScoreId)) Value = lngViewpointScoreId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngViewpointScoreId)
{
if (lngViewpointScoreId == 0) return false;
if (lngViewpointScoreId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewpointScoreId_zx_ViewpointScore]类型的对象</returns>
public static implicit operator K_ViewpointScoreId_zx_ViewpointScore(long value)
{
return new K_ViewpointScoreId_zx_ViewpointScore(value);
}
}
 /// <summary>
 /// 中学观点评分表(zx_ViewpointScore)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_ViewpointScoreEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_ViewpointScore"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewpointScoreId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"ViewpointScoreId", "ViewpointScore", "zxViewpointId", "UpdDate", "UpdUserId", "Memo"};

protected long mlngViewpointScoreId;    //评分Id
protected float? mfltViewpointScore;    //评分
protected string mstrzxViewpointId;    //观点Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_ViewpointScoreEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointScoreId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngViewpointScoreId">关键字:评分Id</param>
public clszx_ViewpointScoreEN(long lngViewpointScoreId)
 {
 if (lngViewpointScoreId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngViewpointScoreId = lngViewpointScoreId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointScoreId");
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
if (strAttributeName  ==  conzx_ViewpointScore.ViewpointScoreId)
{
return mlngViewpointScoreId;
}
else if (strAttributeName  ==  conzx_ViewpointScore.ViewpointScore)
{
return mfltViewpointScore;
}
else if (strAttributeName  ==  conzx_ViewpointScore.zxViewpointId)
{
return mstrzxViewpointId;
}
else if (strAttributeName  ==  conzx_ViewpointScore.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_ViewpointScore.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conzx_ViewpointScore.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_ViewpointScore.ViewpointScoreId)
{
mlngViewpointScoreId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointScore.ViewpointScoreId);
}
else if (strAttributeName  ==  conzx_ViewpointScore.ViewpointScore)
{
mfltViewpointScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_ViewpointScore.ViewpointScore);
}
else if (strAttributeName  ==  conzx_ViewpointScore.zxViewpointId)
{
mstrzxViewpointId = value.ToString();
 AddUpdatedFld(conzx_ViewpointScore.zxViewpointId);
}
else if (strAttributeName  ==  conzx_ViewpointScore.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_ViewpointScore.UpdDate);
}
else if (strAttributeName  ==  conzx_ViewpointScore.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conzx_ViewpointScore.UpdUserId);
}
else if (strAttributeName  ==  conzx_ViewpointScore.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ViewpointScore.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_ViewpointScore.ViewpointScoreId  ==  AttributeName[intIndex])
{
return mlngViewpointScoreId;
}
else if (conzx_ViewpointScore.ViewpointScore  ==  AttributeName[intIndex])
{
return mfltViewpointScore;
}
else if (conzx_ViewpointScore.zxViewpointId  ==  AttributeName[intIndex])
{
return mstrzxViewpointId;
}
else if (conzx_ViewpointScore.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_ViewpointScore.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conzx_ViewpointScore.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_ViewpointScore.ViewpointScoreId  ==  AttributeName[intIndex])
{
mlngViewpointScoreId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointScore.ViewpointScoreId);
}
else if (conzx_ViewpointScore.ViewpointScore  ==  AttributeName[intIndex])
{
mfltViewpointScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_ViewpointScore.ViewpointScore);
}
else if (conzx_ViewpointScore.zxViewpointId  ==  AttributeName[intIndex])
{
mstrzxViewpointId = value.ToString();
 AddUpdatedFld(conzx_ViewpointScore.zxViewpointId);
}
else if (conzx_ViewpointScore.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_ViewpointScore.UpdDate);
}
else if (conzx_ViewpointScore.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conzx_ViewpointScore.UpdUserId);
}
else if (conzx_ViewpointScore.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ViewpointScore.Memo);
}
}
}

/// <summary>
/// 评分Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ViewpointScoreId
{
get
{
return mlngViewpointScoreId;
}
set
{
 mlngViewpointScoreId = value;
//记录修改过的字段
 AddUpdatedFld(conzx_ViewpointScore.ViewpointScoreId);
}
}
/// <summary>
/// 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? ViewpointScore
{
get
{
return mfltViewpointScore;
}
set
{
 mfltViewpointScore = value;
//记录修改过的字段
 AddUpdatedFld(conzx_ViewpointScore.ViewpointScore);
}
}
/// <summary>
/// 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxViewpointId
{
get
{
return mstrzxViewpointId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxViewpointId = value;
}
else
{
 mstrzxViewpointId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ViewpointScore.zxViewpointId);
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
 AddUpdatedFld(conzx_ViewpointScore.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ViewpointScore.UpdUserId);
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
 AddUpdatedFld(conzx_ViewpointScore.Memo);
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
  return mlngViewpointScoreId.ToString();
 }
 }
}
 /// <summary>
 /// 中学观点评分表(zx_ViewpointScore)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_ViewpointScore
{
public const string _CurrTabName = "zx_ViewpointScore"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewpointScoreId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ViewpointScoreId", "ViewpointScore", "zxViewpointId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewpointScoreId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointScoreId = "ViewpointScoreId";    //评分Id

 /// <summary>
 /// 常量:"ViewpointScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointScore = "ViewpointScore";    //评分

 /// <summary>
 /// 常量:"zxViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxViewpointId = "zxViewpointId";    //观点Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}