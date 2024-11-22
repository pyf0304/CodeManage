
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDiscussionSubContentEN
 表名:DiscussionSubContent(01120587)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表DiscussionSubContent的关键字(SubContentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SubContentId_DiscussionSubContent
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSubContentId">表关键字</param>
public K_SubContentId_DiscussionSubContent(string strSubContentId)
{
if (IsValid(strSubContentId)) Value = strSubContentId;
else
{
Value = null;
}
}
private static bool IsValid(string strSubContentId)
{
if (string.IsNullOrEmpty(strSubContentId) == true) return false;
if (strSubContentId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SubContentId_DiscussionSubContent]类型的对象</returns>
public static implicit operator K_SubContentId_DiscussionSubContent(string value)
{
return new K_SubContentId_DiscussionSubContent(value);
}
}
 /// <summary>
 /// 讨论子内容(DiscussionSubContent)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDiscussionSubContentEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DiscussionSubContent"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SubContentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"SubContentId", "SubContent", "TopicsId", "IsTop", "UpdDate", "UpdUser", "Memo", "ParentId", "UserId"};

protected string mstrSubContentId;    //子内容Id
protected string mstrSubContent;    //子内容
protected string mstrTopicsId;    //主题Id
protected bool mbolIsTop;    //是否置顶
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrParentId;    //父节点Id
protected string mstrUserId;    //用户ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDiscussionSubContentEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SubContentId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSubContentId">关键字:子内容Id</param>
public clsDiscussionSubContentEN(string strSubContentId)
 {
strSubContentId = strSubContentId.Replace("'", "''");
if (strSubContentId.Length > 10)
{
throw new Exception("在表:DiscussionSubContent中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSubContentId)  ==  true)
{
throw new Exception("在表:DiscussionSubContent中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSubContentId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSubContentId = strSubContentId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SubContentId");
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
if (strAttributeName  ==  conDiscussionSubContent.SubContentId)
{
return mstrSubContentId;
}
else if (strAttributeName  ==  conDiscussionSubContent.SubContent)
{
return mstrSubContent;
}
else if (strAttributeName  ==  conDiscussionSubContent.TopicsId)
{
return mstrTopicsId;
}
else if (strAttributeName  ==  conDiscussionSubContent.IsTop)
{
return mbolIsTop;
}
else if (strAttributeName  ==  conDiscussionSubContent.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDiscussionSubContent.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDiscussionSubContent.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conDiscussionSubContent.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  conDiscussionSubContent.UserId)
{
return mstrUserId;
}
return null;
}
set
{
if (strAttributeName  ==  conDiscussionSubContent.SubContentId)
{
mstrSubContentId = value.ToString();
 AddUpdatedFld(conDiscussionSubContent.SubContentId);
}
else if (strAttributeName  ==  conDiscussionSubContent.SubContent)
{
mstrSubContent = value.ToString();
 AddUpdatedFld(conDiscussionSubContent.SubContent);
}
else if (strAttributeName  ==  conDiscussionSubContent.TopicsId)
{
mstrTopicsId = value.ToString();
 AddUpdatedFld(conDiscussionSubContent.TopicsId);
}
else if (strAttributeName  ==  conDiscussionSubContent.IsTop)
{
mbolIsTop = TransNullToBool(value.ToString());
 AddUpdatedFld(conDiscussionSubContent.IsTop);
}
else if (strAttributeName  ==  conDiscussionSubContent.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDiscussionSubContent.UpdDate);
}
else if (strAttributeName  ==  conDiscussionSubContent.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDiscussionSubContent.UpdUser);
}
else if (strAttributeName  ==  conDiscussionSubContent.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDiscussionSubContent.Memo);
}
else if (strAttributeName  ==  conDiscussionSubContent.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(conDiscussionSubContent.ParentId);
}
else if (strAttributeName  ==  conDiscussionSubContent.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conDiscussionSubContent.UserId);
}
}
}
public object this[int intIndex]
{
get
{
if (conDiscussionSubContent.SubContentId  ==  AttributeName[intIndex])
{
return mstrSubContentId;
}
else if (conDiscussionSubContent.SubContent  ==  AttributeName[intIndex])
{
return mstrSubContent;
}
else if (conDiscussionSubContent.TopicsId  ==  AttributeName[intIndex])
{
return mstrTopicsId;
}
else if (conDiscussionSubContent.IsTop  ==  AttributeName[intIndex])
{
return mbolIsTop;
}
else if (conDiscussionSubContent.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDiscussionSubContent.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDiscussionSubContent.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conDiscussionSubContent.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (conDiscussionSubContent.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
return null;
}
set
{
if (conDiscussionSubContent.SubContentId  ==  AttributeName[intIndex])
{
mstrSubContentId = value.ToString();
 AddUpdatedFld(conDiscussionSubContent.SubContentId);
}
else if (conDiscussionSubContent.SubContent  ==  AttributeName[intIndex])
{
mstrSubContent = value.ToString();
 AddUpdatedFld(conDiscussionSubContent.SubContent);
}
else if (conDiscussionSubContent.TopicsId  ==  AttributeName[intIndex])
{
mstrTopicsId = value.ToString();
 AddUpdatedFld(conDiscussionSubContent.TopicsId);
}
else if (conDiscussionSubContent.IsTop  ==  AttributeName[intIndex])
{
mbolIsTop = TransNullToBool(value.ToString());
 AddUpdatedFld(conDiscussionSubContent.IsTop);
}
else if (conDiscussionSubContent.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDiscussionSubContent.UpdDate);
}
else if (conDiscussionSubContent.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDiscussionSubContent.UpdUser);
}
else if (conDiscussionSubContent.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDiscussionSubContent.Memo);
}
else if (conDiscussionSubContent.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(conDiscussionSubContent.ParentId);
}
else if (conDiscussionSubContent.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conDiscussionSubContent.UserId);
}
}
}

/// <summary>
/// 子内容Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubContentId
{
get
{
return mstrSubContentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubContentId = value;
}
else
{
 mstrSubContentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDiscussionSubContent.SubContentId);
}
}
/// <summary>
/// 子内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubContent
{
get
{
return mstrSubContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubContent = value;
}
else
{
 mstrSubContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conDiscussionSubContent.SubContent);
}
}
/// <summary>
/// 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicsId
{
get
{
return mstrTopicsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicsId = value;
}
else
{
 mstrTopicsId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDiscussionSubContent.TopicsId);
}
}
/// <summary>
/// 是否置顶(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTop
{
get
{
return mbolIsTop;
}
set
{
 mbolIsTop = value;
//记录修改过的字段
 AddUpdatedFld(conDiscussionSubContent.IsTop);
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
 AddUpdatedFld(conDiscussionSubContent.UpdDate);
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
 AddUpdatedFld(conDiscussionSubContent.UpdUser);
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
 AddUpdatedFld(conDiscussionSubContent.Memo);
}
}
/// <summary>
/// 父节点Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentId
{
get
{
return mstrParentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentId = value;
}
else
{
 mstrParentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDiscussionSubContent.ParentId);
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
 AddUpdatedFld(conDiscussionSubContent.UserId);
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
  return mstrSubContentId;
 }
 }
}
 /// <summary>
 /// 讨论子内容(DiscussionSubContent)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDiscussionSubContent
{
public const string _CurrTabName = "DiscussionSubContent"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SubContentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SubContentId", "SubContent", "TopicsId", "IsTop", "UpdDate", "UpdUser", "Memo", "ParentId", "UserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"SubContentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubContentId = "SubContentId";    //子内容Id

 /// <summary>
 /// 常量:"SubContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubContent = "SubContent";    //子内容

 /// <summary>
 /// 常量:"TopicsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicsId = "TopicsId";    //主题Id

 /// <summary>
 /// 常量:"IsTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTop = "IsTop";    //是否置顶

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

 /// <summary>
 /// 常量:"ParentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentId = "ParentId";    //父节点Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID
}

}