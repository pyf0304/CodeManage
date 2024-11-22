
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointAppraiseEN
 表名:vViewpointAppraise(01120610)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:05:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表vViewpointAppraise的关键字(ViewpointAppraiseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewpointAppraiseId_vViewpointAppraise
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
public K_ViewpointAppraiseId_vViewpointAppraise(long lngViewpointAppraiseId)
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
 /// <returns>返回:[K_ViewpointAppraiseId_vViewpointAppraise]类型的对象</returns>
public static implicit operator K_ViewpointAppraiseId_vViewpointAppraise(long value)
{
return new K_ViewpointAppraiseId_vViewpointAppraise(value);
}
}
 /// <summary>
 /// vViewpointAppraise(vViewpointAppraise)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewpointAppraiseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewpointAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewpointAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"UserName", "ViewpointAppraiseId", "ViewpointId", "AppraiseContent", "UpdDate", "Memo", "ViewpointName", "ViewpointContent", "Reason", "UpdUser"};

protected string mstrUserName;    //用户名
protected long mlngViewpointAppraiseId;    //观点评论Id
protected string mstrViewpointId;    //观点Id
protected string mstrAppraiseContent;    //评议内容
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrViewpointName;    //观点名称
protected string mstrViewpointContent;    //观点内容
protected string mstrReason;    //理由
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvViewpointAppraiseEN()
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
public clsvViewpointAppraiseEN(long lngViewpointAppraiseId)
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
if (strAttributeName  ==  convViewpointAppraise.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convViewpointAppraise.ViewpointAppraiseId)
{
return mlngViewpointAppraiseId;
}
else if (strAttributeName  ==  convViewpointAppraise.ViewpointId)
{
return mstrViewpointId;
}
else if (strAttributeName  ==  convViewpointAppraise.AppraiseContent)
{
return mstrAppraiseContent;
}
else if (strAttributeName  ==  convViewpointAppraise.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convViewpointAppraise.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convViewpointAppraise.ViewpointName)
{
return mstrViewpointName;
}
else if (strAttributeName  ==  convViewpointAppraise.ViewpointContent)
{
return mstrViewpointContent;
}
else if (strAttributeName  ==  convViewpointAppraise.Reason)
{
return mstrReason;
}
else if (strAttributeName  ==  convViewpointAppraise.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  convViewpointAppraise.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convViewpointAppraise.UserName);
}
else if (strAttributeName  ==  convViewpointAppraise.ViewpointAppraiseId)
{
mlngViewpointAppraiseId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpointAppraise.ViewpointAppraiseId);
}
else if (strAttributeName  ==  convViewpointAppraise.ViewpointId)
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(convViewpointAppraise.ViewpointId);
}
else if (strAttributeName  ==  convViewpointAppraise.AppraiseContent)
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(convViewpointAppraise.AppraiseContent);
}
else if (strAttributeName  ==  convViewpointAppraise.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewpointAppraise.UpdDate);
}
else if (strAttributeName  ==  convViewpointAppraise.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewpointAppraise.Memo);
}
else if (strAttributeName  ==  convViewpointAppraise.ViewpointName)
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(convViewpointAppraise.ViewpointName);
}
else if (strAttributeName  ==  convViewpointAppraise.ViewpointContent)
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(convViewpointAppraise.ViewpointContent);
}
else if (strAttributeName  ==  convViewpointAppraise.Reason)
{
mstrReason = value.ToString();
 AddUpdatedFld(convViewpointAppraise.Reason);
}
else if (strAttributeName  ==  convViewpointAppraise.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convViewpointAppraise.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewpointAppraise.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convViewpointAppraise.ViewpointAppraiseId  ==  AttributeName[intIndex])
{
return mlngViewpointAppraiseId;
}
else if (convViewpointAppraise.ViewpointId  ==  AttributeName[intIndex])
{
return mstrViewpointId;
}
else if (convViewpointAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
return mstrAppraiseContent;
}
else if (convViewpointAppraise.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convViewpointAppraise.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convViewpointAppraise.ViewpointName  ==  AttributeName[intIndex])
{
return mstrViewpointName;
}
else if (convViewpointAppraise.ViewpointContent  ==  AttributeName[intIndex])
{
return mstrViewpointContent;
}
else if (convViewpointAppraise.Reason  ==  AttributeName[intIndex])
{
return mstrReason;
}
else if (convViewpointAppraise.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (convViewpointAppraise.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convViewpointAppraise.UserName);
}
else if (convViewpointAppraise.ViewpointAppraiseId  ==  AttributeName[intIndex])
{
mlngViewpointAppraiseId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpointAppraise.ViewpointAppraiseId);
}
else if (convViewpointAppraise.ViewpointId  ==  AttributeName[intIndex])
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(convViewpointAppraise.ViewpointId);
}
else if (convViewpointAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(convViewpointAppraise.AppraiseContent);
}
else if (convViewpointAppraise.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewpointAppraise.UpdDate);
}
else if (convViewpointAppraise.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewpointAppraise.Memo);
}
else if (convViewpointAppraise.ViewpointName  ==  AttributeName[intIndex])
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(convViewpointAppraise.ViewpointName);
}
else if (convViewpointAppraise.ViewpointContent  ==  AttributeName[intIndex])
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(convViewpointAppraise.ViewpointContent);
}
else if (convViewpointAppraise.Reason  ==  AttributeName[intIndex])
{
mstrReason = value.ToString();
 AddUpdatedFld(convViewpointAppraise.Reason);
}
else if (convViewpointAppraise.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convViewpointAppraise.UpdUser);
}
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
 AddUpdatedFld(convViewpointAppraise.UserName);
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
 AddUpdatedFld(convViewpointAppraise.ViewpointAppraiseId);
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
 AddUpdatedFld(convViewpointAppraise.ViewpointId);
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
 AddUpdatedFld(convViewpointAppraise.AppraiseContent);
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
 AddUpdatedFld(convViewpointAppraise.UpdDate);
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
 AddUpdatedFld(convViewpointAppraise.Memo);
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
 AddUpdatedFld(convViewpointAppraise.ViewpointName);
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
 AddUpdatedFld(convViewpointAppraise.ViewpointContent);
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
 AddUpdatedFld(convViewpointAppraise.Reason);
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
 AddUpdatedFld(convViewpointAppraise.UpdUser);
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
 /// vViewpointAppraise(vViewpointAppraise)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewpointAppraise
{
public const string _CurrTabName = "vViewpointAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewpointAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserName", "ViewpointAppraiseId", "ViewpointId", "AppraiseContent", "UpdDate", "Memo", "ViewpointName", "ViewpointContent", "Reason", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

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

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人
}

}