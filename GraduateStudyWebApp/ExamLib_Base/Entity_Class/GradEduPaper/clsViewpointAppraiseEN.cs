
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewpointAppraiseEN
 表名:ViewpointAppraise(01120599)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表ViewpointAppraise的关键字(ViewpointAppraiseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewpointAppraiseId_ViewpointAppraise
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngViewpointAppraiseId">表关键字</param>
public K_ViewpointAppraiseId_ViewpointAppraise(long lngViewpointAppraiseId)
{
if (IsValid(lngViewpointAppraiseId)) Value = lngViewpointAppraiseId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngViewpointAppraiseId)
{
if (lngViewpointAppraiseId == 0) return false;
if (lngViewpointAppraiseId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewpointAppraiseId_ViewpointAppraise]类型的对象</returns>
public static implicit operator K_ViewpointAppraiseId_ViewpointAppraise(long value)
{
return new K_ViewpointAppraiseId_ViewpointAppraise(value);
}
}
 /// <summary>
 /// 观点评论表(ViewpointAppraise)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewpointAppraiseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewpointAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewpointAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"ViewpointAppraiseId", "ViewpointId", "AppraiseContent", "UpdDate", "Memo", "UpdUser"};

protected long mlngViewpointAppraiseId;    //观点评论Id
protected string mstrViewpointId;    //观点Id
protected string mstrAppraiseContent;    //评议内容
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsViewpointAppraiseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointAppraiseId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngViewpointAppraiseId">关键字:观点评论Id</param>
public clsViewpointAppraiseEN(long lngViewpointAppraiseId)
 {
 if (lngViewpointAppraiseId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngViewpointAppraiseId = lngViewpointAppraiseId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointAppraiseId");
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
if (strAttributeName  ==  conViewpointAppraise.ViewpointAppraiseId)
{
return mlngViewpointAppraiseId;
}
else if (strAttributeName  ==  conViewpointAppraise.ViewpointId)
{
return mstrViewpointId;
}
else if (strAttributeName  ==  conViewpointAppraise.AppraiseContent)
{
return mstrAppraiseContent;
}
else if (strAttributeName  ==  conViewpointAppraise.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conViewpointAppraise.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conViewpointAppraise.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  conViewpointAppraise.ViewpointAppraiseId)
{
mlngViewpointAppraiseId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewpointAppraise.ViewpointAppraiseId);
}
else if (strAttributeName  ==  conViewpointAppraise.ViewpointId)
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(conViewpointAppraise.ViewpointId);
}
else if (strAttributeName  ==  conViewpointAppraise.AppraiseContent)
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(conViewpointAppraise.AppraiseContent);
}
else if (strAttributeName  ==  conViewpointAppraise.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewpointAppraise.UpdDate);
}
else if (strAttributeName  ==  conViewpointAppraise.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewpointAppraise.Memo);
}
else if (strAttributeName  ==  conViewpointAppraise.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conViewpointAppraise.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewpointAppraise.ViewpointAppraiseId  ==  AttributeName[intIndex])
{
return mlngViewpointAppraiseId;
}
else if (conViewpointAppraise.ViewpointId  ==  AttributeName[intIndex])
{
return mstrViewpointId;
}
else if (conViewpointAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
return mstrAppraiseContent;
}
else if (conViewpointAppraise.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conViewpointAppraise.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conViewpointAppraise.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (conViewpointAppraise.ViewpointAppraiseId  ==  AttributeName[intIndex])
{
mlngViewpointAppraiseId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewpointAppraise.ViewpointAppraiseId);
}
else if (conViewpointAppraise.ViewpointId  ==  AttributeName[intIndex])
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(conViewpointAppraise.ViewpointId);
}
else if (conViewpointAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(conViewpointAppraise.AppraiseContent);
}
else if (conViewpointAppraise.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewpointAppraise.UpdDate);
}
else if (conViewpointAppraise.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewpointAppraise.Memo);
}
else if (conViewpointAppraise.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conViewpointAppraise.UpdUser);
}
}
}

/// <summary>
/// 观点评论Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ViewpointAppraiseId
{
get
{
return mlngViewpointAppraiseId;
}
set
{
 mlngViewpointAppraiseId = value;
//记录修改过的字段
 AddUpdatedFld(conViewpointAppraise.ViewpointAppraiseId);
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
 AddUpdatedFld(conViewpointAppraise.ViewpointId);
}
}
/// <summary>
/// 评议内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseContent
{
get
{
return mstrAppraiseContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseContent = value;
}
else
{
 mstrAppraiseContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewpointAppraise.AppraiseContent);
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
 AddUpdatedFld(conViewpointAppraise.UpdDate);
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
 AddUpdatedFld(conViewpointAppraise.Memo);
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
 AddUpdatedFld(conViewpointAppraise.UpdUser);
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
  return mlngViewpointAppraiseId.ToString();
 }
 }
}
 /// <summary>
 /// 观点评论表(ViewpointAppraise)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewpointAppraise
{
public const string _CurrTabName = "ViewpointAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewpointAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ViewpointAppraiseId", "ViewpointId", "AppraiseContent", "UpdDate", "Memo", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewpointAppraiseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointAppraiseId = "ViewpointAppraiseId";    //观点评论Id

 /// <summary>
 /// 常量:"ViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointId = "ViewpointId";    //观点Id

 /// <summary>
 /// 常量:"AppraiseContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseContent = "AppraiseContent";    //评议内容

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人
}

}