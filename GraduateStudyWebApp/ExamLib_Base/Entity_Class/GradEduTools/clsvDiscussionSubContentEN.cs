
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDiscussionSubContentEN
 表名:vDiscussionSubContent(01120585)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:53:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表vDiscussionSubContent的关键字(SubContentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SubContentId_vDiscussionSubContent
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
public K_SubContentId_vDiscussionSubContent(string strSubContentId)
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
 /// <returns>返回:[K_SubContentId_vDiscussionSubContent]类型的对象</returns>
public static implicit operator K_SubContentId_vDiscussionSubContent(string value)
{
return new K_SubContentId_vDiscussionSubContent(value);
}
}
 /// <summary>
 /// v讨论子内容视图(vDiscussionSubContent)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvDiscussionSubContentEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vDiscussionSubContent"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SubContentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"SubContent", "TopicsId", "TopicsTitle", "IsTop", "UpdDate", "UpdUser", "Memo", "CollegeName", "IdXzCollege", "IdXzMajor", "MajorName", "UserName", "BrowseNumber", "IdCurrEduCls", "ParentId", "TopicsContent", "UserId", "vUpdDate", "vUpdUser", "SubContentId"};

protected string mstrSubContent;    //子内容
protected string mstrTopicsId;    //主题Id
protected string mstrTopicsTitle;    //主题标题
protected bool mbolIsTop;    //是否置顶
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrCollegeName;    //学院名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrUserName;    //用户名
protected int? mintBrowseNumber;    //浏览量
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrParentId;    //父节点Id
protected string mstrTopicsContent;    //主题内容
protected string mstrUserId;    //用户ID
protected string mstrvUpdDate;    //vUpdDate
protected string mstrvUpdUser;    //vUpdUser
protected string mstrSubContentId;    //子内容Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvDiscussionSubContentEN()
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
public clsvDiscussionSubContentEN(string strSubContentId)
 {
strSubContentId = strSubContentId.Replace("'", "''");
if (strSubContentId.Length > 10)
{
throw new Exception("在表:vDiscussionSubContent中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSubContentId)  ==  true)
{
throw new Exception("在表:vDiscussionSubContent中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convDiscussionSubContent.SubContent)
{
return mstrSubContent;
}
else if (strAttributeName  ==  convDiscussionSubContent.TopicsId)
{
return mstrTopicsId;
}
else if (strAttributeName  ==  convDiscussionSubContent.TopicsTitle)
{
return mstrTopicsTitle;
}
else if (strAttributeName  ==  convDiscussionSubContent.IsTop)
{
return mbolIsTop;
}
else if (strAttributeName  ==  convDiscussionSubContent.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convDiscussionSubContent.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convDiscussionSubContent.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convDiscussionSubContent.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convDiscussionSubContent.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convDiscussionSubContent.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convDiscussionSubContent.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convDiscussionSubContent.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convDiscussionSubContent.BrowseNumber)
{
return mintBrowseNumber;
}
else if (strAttributeName  ==  convDiscussionSubContent.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convDiscussionSubContent.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  convDiscussionSubContent.TopicsContent)
{
return mstrTopicsContent;
}
else if (strAttributeName  ==  convDiscussionSubContent.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convDiscussionSubContent.vUpdDate)
{
return mstrvUpdDate;
}
else if (strAttributeName  ==  convDiscussionSubContent.vUpdUser)
{
return mstrvUpdUser;
}
else if (strAttributeName  ==  convDiscussionSubContent.SubContentId)
{
return mstrSubContentId;
}
return null;
}
set
{
if (strAttributeName  ==  convDiscussionSubContent.SubContent)
{
mstrSubContent = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.SubContent);
}
else if (strAttributeName  ==  convDiscussionSubContent.TopicsId)
{
mstrTopicsId = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.TopicsId);
}
else if (strAttributeName  ==  convDiscussionSubContent.TopicsTitle)
{
mstrTopicsTitle = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.TopicsTitle);
}
else if (strAttributeName  ==  convDiscussionSubContent.IsTop)
{
mbolIsTop = TransNullToBool(value.ToString());
 AddUpdatedFld(convDiscussionSubContent.IsTop);
}
else if (strAttributeName  ==  convDiscussionSubContent.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.UpdDate);
}
else if (strAttributeName  ==  convDiscussionSubContent.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.UpdUser);
}
else if (strAttributeName  ==  convDiscussionSubContent.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.Memo);
}
else if (strAttributeName  ==  convDiscussionSubContent.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.CollegeName);
}
else if (strAttributeName  ==  convDiscussionSubContent.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.IdXzCollege);
}
else if (strAttributeName  ==  convDiscussionSubContent.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.IdXzMajor);
}
else if (strAttributeName  ==  convDiscussionSubContent.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.MajorName);
}
else if (strAttributeName  ==  convDiscussionSubContent.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.UserName);
}
else if (strAttributeName  ==  convDiscussionSubContent.BrowseNumber)
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convDiscussionSubContent.BrowseNumber);
}
else if (strAttributeName  ==  convDiscussionSubContent.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.IdCurrEduCls);
}
else if (strAttributeName  ==  convDiscussionSubContent.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.ParentId);
}
else if (strAttributeName  ==  convDiscussionSubContent.TopicsContent)
{
mstrTopicsContent = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.TopicsContent);
}
else if (strAttributeName  ==  convDiscussionSubContent.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.UserId);
}
else if (strAttributeName  ==  convDiscussionSubContent.vUpdDate)
{
mstrvUpdDate = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.vUpdDate);
}
else if (strAttributeName  ==  convDiscussionSubContent.vUpdUser)
{
mstrvUpdUser = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.vUpdUser);
}
else if (strAttributeName  ==  convDiscussionSubContent.SubContentId)
{
mstrSubContentId = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.SubContentId);
}
}
}
public object this[int intIndex]
{
get
{
if (convDiscussionSubContent.SubContent  ==  AttributeName[intIndex])
{
return mstrSubContent;
}
else if (convDiscussionSubContent.TopicsId  ==  AttributeName[intIndex])
{
return mstrTopicsId;
}
else if (convDiscussionSubContent.TopicsTitle  ==  AttributeName[intIndex])
{
return mstrTopicsTitle;
}
else if (convDiscussionSubContent.IsTop  ==  AttributeName[intIndex])
{
return mbolIsTop;
}
else if (convDiscussionSubContent.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convDiscussionSubContent.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convDiscussionSubContent.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convDiscussionSubContent.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convDiscussionSubContent.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convDiscussionSubContent.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convDiscussionSubContent.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convDiscussionSubContent.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convDiscussionSubContent.BrowseNumber  ==  AttributeName[intIndex])
{
return mintBrowseNumber;
}
else if (convDiscussionSubContent.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convDiscussionSubContent.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (convDiscussionSubContent.TopicsContent  ==  AttributeName[intIndex])
{
return mstrTopicsContent;
}
else if (convDiscussionSubContent.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convDiscussionSubContent.vUpdDate  ==  AttributeName[intIndex])
{
return mstrvUpdDate;
}
else if (convDiscussionSubContent.vUpdUser  ==  AttributeName[intIndex])
{
return mstrvUpdUser;
}
else if (convDiscussionSubContent.SubContentId  ==  AttributeName[intIndex])
{
return mstrSubContentId;
}
return null;
}
set
{
if (convDiscussionSubContent.SubContent  ==  AttributeName[intIndex])
{
mstrSubContent = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.SubContent);
}
else if (convDiscussionSubContent.TopicsId  ==  AttributeName[intIndex])
{
mstrTopicsId = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.TopicsId);
}
else if (convDiscussionSubContent.TopicsTitle  ==  AttributeName[intIndex])
{
mstrTopicsTitle = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.TopicsTitle);
}
else if (convDiscussionSubContent.IsTop  ==  AttributeName[intIndex])
{
mbolIsTop = TransNullToBool(value.ToString());
 AddUpdatedFld(convDiscussionSubContent.IsTop);
}
else if (convDiscussionSubContent.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.UpdDate);
}
else if (convDiscussionSubContent.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.UpdUser);
}
else if (convDiscussionSubContent.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.Memo);
}
else if (convDiscussionSubContent.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.CollegeName);
}
else if (convDiscussionSubContent.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.IdXzCollege);
}
else if (convDiscussionSubContent.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.IdXzMajor);
}
else if (convDiscussionSubContent.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.MajorName);
}
else if (convDiscussionSubContent.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.UserName);
}
else if (convDiscussionSubContent.BrowseNumber  ==  AttributeName[intIndex])
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convDiscussionSubContent.BrowseNumber);
}
else if (convDiscussionSubContent.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.IdCurrEduCls);
}
else if (convDiscussionSubContent.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.ParentId);
}
else if (convDiscussionSubContent.TopicsContent  ==  AttributeName[intIndex])
{
mstrTopicsContent = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.TopicsContent);
}
else if (convDiscussionSubContent.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.UserId);
}
else if (convDiscussionSubContent.vUpdDate  ==  AttributeName[intIndex])
{
mstrvUpdDate = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.vUpdDate);
}
else if (convDiscussionSubContent.vUpdUser  ==  AttributeName[intIndex])
{
mstrvUpdUser = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.vUpdUser);
}
else if (convDiscussionSubContent.SubContentId  ==  AttributeName[intIndex])
{
mstrSubContentId = value.ToString();
 AddUpdatedFld(convDiscussionSubContent.SubContentId);
}
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
 AddUpdatedFld(convDiscussionSubContent.SubContent);
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
 AddUpdatedFld(convDiscussionSubContent.TopicsId);
}
}
/// <summary>
/// 主题标题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicsTitle
{
get
{
return mstrTopicsTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicsTitle = value;
}
else
{
 mstrTopicsTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convDiscussionSubContent.TopicsTitle);
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
 AddUpdatedFld(convDiscussionSubContent.IsTop);
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
 AddUpdatedFld(convDiscussionSubContent.UpdDate);
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
 AddUpdatedFld(convDiscussionSubContent.UpdUser);
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
 AddUpdatedFld(convDiscussionSubContent.Memo);
}
}
/// <summary>
/// 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName
{
get
{
return mstrCollegeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName = value;
}
else
{
 mstrCollegeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDiscussionSubContent.CollegeName);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzCollege
{
get
{
return mstrIdXzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzCollege = value;
}
else
{
 mstrIdXzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(convDiscussionSubContent.IdXzCollege);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajor
{
get
{
return mstrIdXzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajor = value;
}
else
{
 mstrIdXzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(convDiscussionSubContent.IdXzMajor);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDiscussionSubContent.MajorName);
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
 AddUpdatedFld(convDiscussionSubContent.UserName);
}
}
/// <summary>
/// 浏览量(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseNumber
{
get
{
return mintBrowseNumber;
}
set
{
 mintBrowseNumber = value;
//记录修改过的字段
 AddUpdatedFld(convDiscussionSubContent.BrowseNumber);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(convDiscussionSubContent.IdCurrEduCls);
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
 AddUpdatedFld(convDiscussionSubContent.ParentId);
}
}
/// <summary>
/// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicsContent
{
get
{
return mstrTopicsContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicsContent = value;
}
else
{
 mstrTopicsContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convDiscussionSubContent.TopicsContent);
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
 AddUpdatedFld(convDiscussionSubContent.UserId);
}
}
/// <summary>
/// vUpdDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string vUpdDate
{
get
{
return mstrvUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrvUpdDate = value;
}
else
{
 mstrvUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convDiscussionSubContent.vUpdDate);
}
}
/// <summary>
/// vUpdUser(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string vUpdUser
{
get
{
return mstrvUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrvUpdUser = value;
}
else
{
 mstrvUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convDiscussionSubContent.vUpdUser);
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
 AddUpdatedFld(convDiscussionSubContent.SubContentId);
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
 /// v讨论子内容视图(vDiscussionSubContent)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convDiscussionSubContent
{
public const string _CurrTabName = "vDiscussionSubContent"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SubContentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SubContent", "TopicsId", "TopicsTitle", "IsTop", "UpdDate", "UpdUser", "Memo", "CollegeName", "IdXzCollege", "IdXzMajor", "MajorName", "UserName", "BrowseNumber", "IdCurrEduCls", "ParentId", "TopicsContent", "UserId", "vUpdDate", "vUpdUser", "SubContentId"};
//以下是属性变量


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
 /// 常量:"TopicsTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicsTitle = "TopicsTitle";    //主题标题

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
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"BrowseNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseNumber = "BrowseNumber";    //浏览量

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"ParentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentId = "ParentId";    //父节点Id

 /// <summary>
 /// 常量:"TopicsContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicsContent = "TopicsContent";    //主题内容

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"vUpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string vUpdDate = "vUpdDate";    //vUpdDate

 /// <summary>
 /// 常量:"vUpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string vUpdUser = "vUpdUser";    //vUpdUser

 /// <summary>
 /// 常量:"SubContentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubContentId = "SubContentId";    //子内容Id
}

}