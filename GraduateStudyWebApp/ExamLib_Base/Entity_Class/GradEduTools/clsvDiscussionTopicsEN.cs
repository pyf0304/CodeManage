
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDiscussionTopicsEN
 表名:vDiscussionTopics(01120586)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:00:39
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
 /// 表vDiscussionTopics的关键字(TopicsId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TopicsId_vDiscussionTopics
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTopicsId">表关键字</param>
public K_TopicsId_vDiscussionTopics(string strTopicsId)
{
if (IsValid(strTopicsId)) Value = strTopicsId;
else
{
Value = null;
}
}
private static bool IsValid(string strTopicsId)
{
if (string.IsNullOrEmpty(strTopicsId) == true) return false;
if (strTopicsId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TopicsId_vDiscussionTopics]类型的对象</returns>
public static implicit operator K_TopicsId_vDiscussionTopics(string value)
{
return new K_TopicsId_vDiscussionTopics(value);
}
}
 /// <summary>
 /// v讨论主题视图(vDiscussionTopics)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvDiscussionTopicsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vDiscussionTopics"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TopicsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"TopicsId", "DiscussionTypeId", "DiscussionTypeName", "TopicsTitle", "TopicsContent", "IsAudit", "IsTop", "BrowseNumber", "UpdDate", "UpdUser", "Memo", "CollegeName", "IdXzCollege", "IdXzMajor", "MajorName", "UserName", "SubCount", "IdCurrEduCls"};

protected string mstrTopicsId;    //主题Id
protected string mstrDiscussionTypeId;    //讨论类型Id
protected string mstrDiscussionTypeName;    //讨论类型名称
protected string mstrTopicsTitle;    //主题标题
protected string mstrTopicsContent;    //主题内容
protected bool mbolIsAudit;    //是否审核
protected bool mbolIsTop;    //是否置顶
protected int? mintBrowseNumber;    //浏览量
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrCollegeName;    //学院名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrUserName;    //用户名
protected int? mintSubCount;    //SubCount
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvDiscussionTopicsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicsId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTopicsId">关键字:主题Id</param>
public clsvDiscussionTopicsEN(string strTopicsId)
 {
strTopicsId = strTopicsId.Replace("'", "''");
if (strTopicsId.Length > 8)
{
throw new Exception("在表:vDiscussionTopics中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTopicsId)  ==  true)
{
throw new Exception("在表:vDiscussionTopics中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTopicsId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTopicsId = strTopicsId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicsId");
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
if (strAttributeName  ==  convDiscussionTopics.TopicsId)
{
return mstrTopicsId;
}
else if (strAttributeName  ==  convDiscussionTopics.DiscussionTypeId)
{
return mstrDiscussionTypeId;
}
else if (strAttributeName  ==  convDiscussionTopics.DiscussionTypeName)
{
return mstrDiscussionTypeName;
}
else if (strAttributeName  ==  convDiscussionTopics.TopicsTitle)
{
return mstrTopicsTitle;
}
else if (strAttributeName  ==  convDiscussionTopics.TopicsContent)
{
return mstrTopicsContent;
}
else if (strAttributeName  ==  convDiscussionTopics.IsAudit)
{
return mbolIsAudit;
}
else if (strAttributeName  ==  convDiscussionTopics.IsTop)
{
return mbolIsTop;
}
else if (strAttributeName  ==  convDiscussionTopics.BrowseNumber)
{
return mintBrowseNumber;
}
else if (strAttributeName  ==  convDiscussionTopics.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convDiscussionTopics.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convDiscussionTopics.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convDiscussionTopics.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convDiscussionTopics.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convDiscussionTopics.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convDiscussionTopics.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convDiscussionTopics.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convDiscussionTopics.SubCount)
{
return mintSubCount;
}
else if (strAttributeName  ==  convDiscussionTopics.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  convDiscussionTopics.TopicsId)
{
mstrTopicsId = value.ToString();
 AddUpdatedFld(convDiscussionTopics.TopicsId);
}
else if (strAttributeName  ==  convDiscussionTopics.DiscussionTypeId)
{
mstrDiscussionTypeId = value.ToString();
 AddUpdatedFld(convDiscussionTopics.DiscussionTypeId);
}
else if (strAttributeName  ==  convDiscussionTopics.DiscussionTypeName)
{
mstrDiscussionTypeName = value.ToString();
 AddUpdatedFld(convDiscussionTopics.DiscussionTypeName);
}
else if (strAttributeName  ==  convDiscussionTopics.TopicsTitle)
{
mstrTopicsTitle = value.ToString();
 AddUpdatedFld(convDiscussionTopics.TopicsTitle);
}
else if (strAttributeName  ==  convDiscussionTopics.TopicsContent)
{
mstrTopicsContent = value.ToString();
 AddUpdatedFld(convDiscussionTopics.TopicsContent);
}
else if (strAttributeName  ==  convDiscussionTopics.IsAudit)
{
mbolIsAudit = TransNullToBool(value.ToString());
 AddUpdatedFld(convDiscussionTopics.IsAudit);
}
else if (strAttributeName  ==  convDiscussionTopics.IsTop)
{
mbolIsTop = TransNullToBool(value.ToString());
 AddUpdatedFld(convDiscussionTopics.IsTop);
}
else if (strAttributeName  ==  convDiscussionTopics.BrowseNumber)
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convDiscussionTopics.BrowseNumber);
}
else if (strAttributeName  ==  convDiscussionTopics.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDiscussionTopics.UpdDate);
}
else if (strAttributeName  ==  convDiscussionTopics.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convDiscussionTopics.UpdUser);
}
else if (strAttributeName  ==  convDiscussionTopics.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDiscussionTopics.Memo);
}
else if (strAttributeName  ==  convDiscussionTopics.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convDiscussionTopics.CollegeName);
}
else if (strAttributeName  ==  convDiscussionTopics.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convDiscussionTopics.IdXzCollege);
}
else if (strAttributeName  ==  convDiscussionTopics.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convDiscussionTopics.IdXzMajor);
}
else if (strAttributeName  ==  convDiscussionTopics.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convDiscussionTopics.MajorName);
}
else if (strAttributeName  ==  convDiscussionTopics.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convDiscussionTopics.UserName);
}
else if (strAttributeName  ==  convDiscussionTopics.SubCount)
{
mintSubCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convDiscussionTopics.SubCount);
}
else if (strAttributeName  ==  convDiscussionTopics.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convDiscussionTopics.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (convDiscussionTopics.TopicsId  ==  AttributeName[intIndex])
{
return mstrTopicsId;
}
else if (convDiscussionTopics.DiscussionTypeId  ==  AttributeName[intIndex])
{
return mstrDiscussionTypeId;
}
else if (convDiscussionTopics.DiscussionTypeName  ==  AttributeName[intIndex])
{
return mstrDiscussionTypeName;
}
else if (convDiscussionTopics.TopicsTitle  ==  AttributeName[intIndex])
{
return mstrTopicsTitle;
}
else if (convDiscussionTopics.TopicsContent  ==  AttributeName[intIndex])
{
return mstrTopicsContent;
}
else if (convDiscussionTopics.IsAudit  ==  AttributeName[intIndex])
{
return mbolIsAudit;
}
else if (convDiscussionTopics.IsTop  ==  AttributeName[intIndex])
{
return mbolIsTop;
}
else if (convDiscussionTopics.BrowseNumber  ==  AttributeName[intIndex])
{
return mintBrowseNumber;
}
else if (convDiscussionTopics.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convDiscussionTopics.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convDiscussionTopics.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convDiscussionTopics.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convDiscussionTopics.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convDiscussionTopics.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convDiscussionTopics.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convDiscussionTopics.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convDiscussionTopics.SubCount  ==  AttributeName[intIndex])
{
return mintSubCount;
}
else if (convDiscussionTopics.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (convDiscussionTopics.TopicsId  ==  AttributeName[intIndex])
{
mstrTopicsId = value.ToString();
 AddUpdatedFld(convDiscussionTopics.TopicsId);
}
else if (convDiscussionTopics.DiscussionTypeId  ==  AttributeName[intIndex])
{
mstrDiscussionTypeId = value.ToString();
 AddUpdatedFld(convDiscussionTopics.DiscussionTypeId);
}
else if (convDiscussionTopics.DiscussionTypeName  ==  AttributeName[intIndex])
{
mstrDiscussionTypeName = value.ToString();
 AddUpdatedFld(convDiscussionTopics.DiscussionTypeName);
}
else if (convDiscussionTopics.TopicsTitle  ==  AttributeName[intIndex])
{
mstrTopicsTitle = value.ToString();
 AddUpdatedFld(convDiscussionTopics.TopicsTitle);
}
else if (convDiscussionTopics.TopicsContent  ==  AttributeName[intIndex])
{
mstrTopicsContent = value.ToString();
 AddUpdatedFld(convDiscussionTopics.TopicsContent);
}
else if (convDiscussionTopics.IsAudit  ==  AttributeName[intIndex])
{
mbolIsAudit = TransNullToBool(value.ToString());
 AddUpdatedFld(convDiscussionTopics.IsAudit);
}
else if (convDiscussionTopics.IsTop  ==  AttributeName[intIndex])
{
mbolIsTop = TransNullToBool(value.ToString());
 AddUpdatedFld(convDiscussionTopics.IsTop);
}
else if (convDiscussionTopics.BrowseNumber  ==  AttributeName[intIndex])
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convDiscussionTopics.BrowseNumber);
}
else if (convDiscussionTopics.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDiscussionTopics.UpdDate);
}
else if (convDiscussionTopics.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convDiscussionTopics.UpdUser);
}
else if (convDiscussionTopics.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDiscussionTopics.Memo);
}
else if (convDiscussionTopics.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convDiscussionTopics.CollegeName);
}
else if (convDiscussionTopics.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convDiscussionTopics.IdXzCollege);
}
else if (convDiscussionTopics.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convDiscussionTopics.IdXzMajor);
}
else if (convDiscussionTopics.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convDiscussionTopics.MajorName);
}
else if (convDiscussionTopics.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convDiscussionTopics.UserName);
}
else if (convDiscussionTopics.SubCount  ==  AttributeName[intIndex])
{
mintSubCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convDiscussionTopics.SubCount);
}
else if (convDiscussionTopics.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convDiscussionTopics.IdCurrEduCls);
}
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
 AddUpdatedFld(convDiscussionTopics.TopicsId);
}
}
/// <summary>
/// 讨论类型Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DiscussionTypeId
{
get
{
return mstrDiscussionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDiscussionTypeId = value;
}
else
{
 mstrDiscussionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convDiscussionTopics.DiscussionTypeId);
}
}
/// <summary>
/// 讨论类型名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DiscussionTypeName
{
get
{
return mstrDiscussionTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDiscussionTypeName = value;
}
else
{
 mstrDiscussionTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDiscussionTopics.DiscussionTypeName);
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
 AddUpdatedFld(convDiscussionTopics.TopicsTitle);
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
 AddUpdatedFld(convDiscussionTopics.TopicsContent);
}
}
/// <summary>
/// 是否审核(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAudit
{
get
{
return mbolIsAudit;
}
set
{
 mbolIsAudit = value;
//记录修改过的字段
 AddUpdatedFld(convDiscussionTopics.IsAudit);
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
 AddUpdatedFld(convDiscussionTopics.IsTop);
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
 AddUpdatedFld(convDiscussionTopics.BrowseNumber);
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
 AddUpdatedFld(convDiscussionTopics.UpdDate);
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
 AddUpdatedFld(convDiscussionTopics.UpdUser);
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
 AddUpdatedFld(convDiscussionTopics.Memo);
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
 AddUpdatedFld(convDiscussionTopics.CollegeName);
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
 AddUpdatedFld(convDiscussionTopics.IdXzCollege);
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
 AddUpdatedFld(convDiscussionTopics.IdXzMajor);
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
 AddUpdatedFld(convDiscussionTopics.MajorName);
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
 AddUpdatedFld(convDiscussionTopics.UserName);
}
}
/// <summary>
/// SubCount(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SubCount
{
get
{
return mintSubCount;
}
set
{
 mintSubCount = value;
//记录修改过的字段
 AddUpdatedFld(convDiscussionTopics.SubCount);
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
 AddUpdatedFld(convDiscussionTopics.IdCurrEduCls);
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
  return mstrTopicsId;
 }
 }
}
 /// <summary>
 /// v讨论主题视图(vDiscussionTopics)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convDiscussionTopics
{
public const string _CurrTabName = "vDiscussionTopics"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TopicsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TopicsId", "DiscussionTypeId", "DiscussionTypeName", "TopicsTitle", "TopicsContent", "IsAudit", "IsTop", "BrowseNumber", "UpdDate", "UpdUser", "Memo", "CollegeName", "IdXzCollege", "IdXzMajor", "MajorName", "UserName", "SubCount", "IdCurrEduCls"};
//以下是属性变量


 /// <summary>
 /// 常量:"TopicsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicsId = "TopicsId";    //主题Id

 /// <summary>
 /// 常量:"DiscussionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DiscussionTypeId = "DiscussionTypeId";    //讨论类型Id

 /// <summary>
 /// 常量:"DiscussionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DiscussionTypeName = "DiscussionTypeName";    //讨论类型名称

 /// <summary>
 /// 常量:"TopicsTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicsTitle = "TopicsTitle";    //主题标题

 /// <summary>
 /// 常量:"TopicsContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicsContent = "TopicsContent";    //主题内容

 /// <summary>
 /// 常量:"IsAudit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAudit = "IsAudit";    //是否审核

 /// <summary>
 /// 常量:"IsTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTop = "IsTop";    //是否置顶

 /// <summary>
 /// 常量:"BrowseNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseNumber = "BrowseNumber";    //浏览量

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
 /// 常量:"SubCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubCount = "SubCount";    //SubCount

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号
}

}