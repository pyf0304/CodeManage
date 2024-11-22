
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointScoreEN
 表名:vViewpointScore(01120609)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:06
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// 表vViewpointScore的关键字(ViewpointScoreId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewpointScoreId_vViewpointScore
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
public K_ViewpointScoreId_vViewpointScore(long lngViewpointScoreId)
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
 /// <returns>返回:[K_ViewpointScoreId_vViewpointScore]类型的对象</returns>
public static implicit operator K_ViewpointScoreId_vViewpointScore(long value)
{
return new K_ViewpointScoreId_vViewpointScore(value);
}
}
 /// <summary>
 /// vViewpointScore(vViewpointScore)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewpointScoreEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewpointScore"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewpointScoreId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"ViewpointScoreId", "ViewpointScore", "ViewpointId", "UpdDate", "UpdUserId", "Memo", "UserName", "ViewpointName", "ViewpointContent", "Reason"};

protected long mlngViewpointScoreId;    //评分Id
protected float? mfltViewpointScore;    //评分
protected string mstrViewpointId;    //观点Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected string mstrUserName;    //用户名
protected string mstrViewpointName;    //观点名称
protected string mstrViewpointContent;    //观点内容
protected string mstrReason;    //理由

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvViewpointScoreEN()
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
public clsvViewpointScoreEN(long lngViewpointScoreId)
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
if (strAttributeName  ==  convViewpointScore.ViewpointScoreId)
{
return mlngViewpointScoreId;
}
else if (strAttributeName  ==  convViewpointScore.ViewpointScore)
{
return mfltViewpointScore;
}
else if (strAttributeName  ==  convViewpointScore.ViewpointId)
{
return mstrViewpointId;
}
else if (strAttributeName  ==  convViewpointScore.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convViewpointScore.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convViewpointScore.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convViewpointScore.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convViewpointScore.ViewpointName)
{
return mstrViewpointName;
}
else if (strAttributeName  ==  convViewpointScore.ViewpointContent)
{
return mstrViewpointContent;
}
else if (strAttributeName  ==  convViewpointScore.Reason)
{
return mstrReason;
}
return null;
}
set
{
if (strAttributeName  ==  convViewpointScore.ViewpointScoreId)
{
mlngViewpointScoreId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpointScore.ViewpointScoreId);
}
else if (strAttributeName  ==  convViewpointScore.ViewpointScore)
{
mfltViewpointScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convViewpointScore.ViewpointScore);
}
else if (strAttributeName  ==  convViewpointScore.ViewpointId)
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(convViewpointScore.ViewpointId);
}
else if (strAttributeName  ==  convViewpointScore.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewpointScore.UpdDate);
}
else if (strAttributeName  ==  convViewpointScore.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convViewpointScore.UpdUserId);
}
else if (strAttributeName  ==  convViewpointScore.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewpointScore.Memo);
}
else if (strAttributeName  ==  convViewpointScore.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convViewpointScore.UserName);
}
else if (strAttributeName  ==  convViewpointScore.ViewpointName)
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(convViewpointScore.ViewpointName);
}
else if (strAttributeName  ==  convViewpointScore.ViewpointContent)
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(convViewpointScore.ViewpointContent);
}
else if (strAttributeName  ==  convViewpointScore.Reason)
{
mstrReason = value.ToString();
 AddUpdatedFld(convViewpointScore.Reason);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewpointScore.ViewpointScoreId  ==  AttributeName[intIndex])
{
return mlngViewpointScoreId;
}
else if (convViewpointScore.ViewpointScore  ==  AttributeName[intIndex])
{
return mfltViewpointScore;
}
else if (convViewpointScore.ViewpointId  ==  AttributeName[intIndex])
{
return mstrViewpointId;
}
else if (convViewpointScore.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convViewpointScore.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convViewpointScore.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convViewpointScore.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convViewpointScore.ViewpointName  ==  AttributeName[intIndex])
{
return mstrViewpointName;
}
else if (convViewpointScore.ViewpointContent  ==  AttributeName[intIndex])
{
return mstrViewpointContent;
}
else if (convViewpointScore.Reason  ==  AttributeName[intIndex])
{
return mstrReason;
}
return null;
}
set
{
if (convViewpointScore.ViewpointScoreId  ==  AttributeName[intIndex])
{
mlngViewpointScoreId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpointScore.ViewpointScoreId);
}
else if (convViewpointScore.ViewpointScore  ==  AttributeName[intIndex])
{
mfltViewpointScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convViewpointScore.ViewpointScore);
}
else if (convViewpointScore.ViewpointId  ==  AttributeName[intIndex])
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(convViewpointScore.ViewpointId);
}
else if (convViewpointScore.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewpointScore.UpdDate);
}
else if (convViewpointScore.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convViewpointScore.UpdUserId);
}
else if (convViewpointScore.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewpointScore.Memo);
}
else if (convViewpointScore.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convViewpointScore.UserName);
}
else if (convViewpointScore.ViewpointName  ==  AttributeName[intIndex])
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(convViewpointScore.ViewpointName);
}
else if (convViewpointScore.ViewpointContent  ==  AttributeName[intIndex])
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(convViewpointScore.ViewpointContent);
}
else if (convViewpointScore.Reason  ==  AttributeName[intIndex])
{
mstrReason = value.ToString();
 AddUpdatedFld(convViewpointScore.Reason);
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
 AddUpdatedFld(convViewpointScore.ViewpointScoreId);
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
 AddUpdatedFld(convViewpointScore.ViewpointScore);
}
}
/// <summary>
/// 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointId
{
get
{
return mstrViewpointId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointId = value;
}
else
{
 mstrViewpointId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointScore.ViewpointId);
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
 AddUpdatedFld(convViewpointScore.UpdDate);
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
 AddUpdatedFld(convViewpointScore.UpdUserId);
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
 AddUpdatedFld(convViewpointScore.Memo);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointScore.UserName);
}
}
/// <summary>
/// 观点名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointName
{
get
{
return mstrViewpointName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointName = value;
}
else
{
 mstrViewpointName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointScore.ViewpointName);
}
}
/// <summary>
/// 观点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointContent
{
get
{
return mstrViewpointContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointContent = value;
}
else
{
 mstrViewpointContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointScore.ViewpointContent);
}
}
/// <summary>
/// 理由(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Reason
{
get
{
return mstrReason;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReason = value;
}
else
{
 mstrReason = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointScore.Reason);
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
 /// vViewpointScore(vViewpointScore)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewpointScore
{
public const string _CurrTabName = "vViewpointScore"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewpointScoreId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ViewpointScoreId", "ViewpointScore", "ViewpointId", "UpdDate", "UpdUserId", "Memo", "UserName", "ViewpointName", "ViewpointContent", "Reason"};
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
 /// 常量:"ViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointId = "ViewpointId";    //观点Id

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

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"ViewpointName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointName = "ViewpointName";    //观点名称

 /// <summary>
 /// 常量:"ViewpointContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointContent = "ViewpointContent";    //观点内容

 /// <summary>
 /// 常量:"Reason"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Reason = "Reason";    //理由
}

}