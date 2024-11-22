
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseKnowledgesEN
 表名:cc_CourseKnowledges(01120082)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表cc_CourseKnowledges的关键字(CourseKnowledgeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CourseKnowledgeId_cc_CourseKnowledges
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCourseKnowledgeId">表关键字</param>
public K_CourseKnowledgeId_cc_CourseKnowledges(string strCourseKnowledgeId)
{
if (IsValid(strCourseKnowledgeId)) Value = strCourseKnowledgeId;
else
{
Value = null;
}
}
private static bool IsValid(string strCourseKnowledgeId)
{
if (string.IsNullOrEmpty(strCourseKnowledgeId) == true) return false;
if (strCourseKnowledgeId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CourseKnowledgeId_cc_CourseKnowledges]类型的对象</returns>
public static implicit operator K_CourseKnowledgeId_cc_CourseKnowledges(string value)
{
return new K_CourseKnowledgeId_cc_CourseKnowledges(value);
}
}
 /// <summary>
 /// 知识点(cc_CourseKnowledges)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_CourseKnowledgesEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_CourseKnowledges"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CourseKnowledgeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"CourseKnowledgeId", "KnowledgeName", "KnowledgeTitle", "KnowledgeContent", "KnowledgeModuleId", "CourseId", "KnowledgeTypeId", "CourseChapterId", "ModuleWeight", "UserId", "UploadDate", "IsShow", "IsCast", "LikeCount", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected string mstrCourseKnowledgeId;    //知识点Id
protected string mstrKnowledgeName;    //知识点名称
protected string mstrKnowledgeTitle;    //知识点标题
protected string mstrKnowledgeContent;    //知识点内容
protected string mstrKnowledgeModuleId;    //知识点模块Id
protected string mstrCourseId;    //课程Id
protected string mstrKnowledgeTypeId;    //知识点类型Id
protected string mstrCourseChapterId;    //课程章节ID
protected double? mdblModuleWeight;    //模块权重
protected string mstrUserId;    //用户ID
protected string mstrUploadDate;    //上传时间
protected bool mbolIsShow;    //是否启用
protected bool mbolIsCast;    //是否播放
protected long? mlngLikeCount;    //资源喜欢数量
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_CourseKnowledgesEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseKnowledgeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCourseKnowledgeId">关键字:知识点Id</param>
public clscc_CourseKnowledgesEN(string strCourseKnowledgeId)
 {
strCourseKnowledgeId = strCourseKnowledgeId.Replace("'", "''");
if (strCourseKnowledgeId.Length > 8)
{
throw new Exception("在表:cc_CourseKnowledges中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCourseKnowledgeId)  ==  true)
{
throw new Exception("在表:cc_CourseKnowledges中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseKnowledgeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCourseKnowledgeId = strCourseKnowledgeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseKnowledgeId");
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
if (strAttributeName  ==  concc_CourseKnowledges.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  concc_CourseKnowledges.KnowledgeName)
{
return mstrKnowledgeName;
}
else if (strAttributeName  ==  concc_CourseKnowledges.KnowledgeTitle)
{
return mstrKnowledgeTitle;
}
else if (strAttributeName  ==  concc_CourseKnowledges.KnowledgeContent)
{
return mstrKnowledgeContent;
}
else if (strAttributeName  ==  concc_CourseKnowledges.KnowledgeModuleId)
{
return mstrKnowledgeModuleId;
}
else if (strAttributeName  ==  concc_CourseKnowledges.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_CourseKnowledges.KnowledgeTypeId)
{
return mstrKnowledgeTypeId;
}
else if (strAttributeName  ==  concc_CourseKnowledges.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  concc_CourseKnowledges.ModuleWeight)
{
return mdblModuleWeight;
}
else if (strAttributeName  ==  concc_CourseKnowledges.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  concc_CourseKnowledges.UploadDate)
{
return mstrUploadDate;
}
else if (strAttributeName  ==  concc_CourseKnowledges.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  concc_CourseKnowledges.IsCast)
{
return mbolIsCast;
}
else if (strAttributeName  ==  concc_CourseKnowledges.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  concc_CourseKnowledges.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  concc_CourseKnowledges.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_CourseKnowledges.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  concc_CourseKnowledges.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_CourseKnowledges.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.CourseKnowledgeId);
}
else if (strAttributeName  ==  concc_CourseKnowledges.KnowledgeName)
{
mstrKnowledgeName = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.KnowledgeName);
}
else if (strAttributeName  ==  concc_CourseKnowledges.KnowledgeTitle)
{
mstrKnowledgeTitle = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.KnowledgeTitle);
}
else if (strAttributeName  ==  concc_CourseKnowledges.KnowledgeContent)
{
mstrKnowledgeContent = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.KnowledgeContent);
}
else if (strAttributeName  ==  concc_CourseKnowledges.KnowledgeModuleId)
{
mstrKnowledgeModuleId = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.KnowledgeModuleId);
}
else if (strAttributeName  ==  concc_CourseKnowledges.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.CourseId);
}
else if (strAttributeName  ==  concc_CourseKnowledges.KnowledgeTypeId)
{
mstrKnowledgeTypeId = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.KnowledgeTypeId);
}
else if (strAttributeName  ==  concc_CourseKnowledges.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.CourseChapterId);
}
else if (strAttributeName  ==  concc_CourseKnowledges.ModuleWeight)
{
mdblModuleWeight = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_CourseKnowledges.ModuleWeight);
}
else if (strAttributeName  ==  concc_CourseKnowledges.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.UserId);
}
else if (strAttributeName  ==  concc_CourseKnowledges.UploadDate)
{
mstrUploadDate = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.UploadDate);
}
else if (strAttributeName  ==  concc_CourseKnowledges.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseKnowledges.IsShow);
}
else if (strAttributeName  ==  concc_CourseKnowledges.IsCast)
{
mbolIsCast = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseKnowledges.IsCast);
}
else if (strAttributeName  ==  concc_CourseKnowledges.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseKnowledges.LikeCount);
}
else if (strAttributeName  ==  concc_CourseKnowledges.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseKnowledges.OrderNum);
}
else if (strAttributeName  ==  concc_CourseKnowledges.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.UpdDate);
}
else if (strAttributeName  ==  concc_CourseKnowledges.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.UpdUser);
}
else if (strAttributeName  ==  concc_CourseKnowledges.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_CourseKnowledges.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (concc_CourseKnowledges.KnowledgeName  ==  AttributeName[intIndex])
{
return mstrKnowledgeName;
}
else if (concc_CourseKnowledges.KnowledgeTitle  ==  AttributeName[intIndex])
{
return mstrKnowledgeTitle;
}
else if (concc_CourseKnowledges.KnowledgeContent  ==  AttributeName[intIndex])
{
return mstrKnowledgeContent;
}
else if (concc_CourseKnowledges.KnowledgeModuleId  ==  AttributeName[intIndex])
{
return mstrKnowledgeModuleId;
}
else if (concc_CourseKnowledges.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_CourseKnowledges.KnowledgeTypeId  ==  AttributeName[intIndex])
{
return mstrKnowledgeTypeId;
}
else if (concc_CourseKnowledges.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (concc_CourseKnowledges.ModuleWeight  ==  AttributeName[intIndex])
{
return mdblModuleWeight;
}
else if (concc_CourseKnowledges.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (concc_CourseKnowledges.UploadDate  ==  AttributeName[intIndex])
{
return mstrUploadDate;
}
else if (concc_CourseKnowledges.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (concc_CourseKnowledges.IsCast  ==  AttributeName[intIndex])
{
return mbolIsCast;
}
else if (concc_CourseKnowledges.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (concc_CourseKnowledges.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (concc_CourseKnowledges.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_CourseKnowledges.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (concc_CourseKnowledges.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_CourseKnowledges.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.CourseKnowledgeId);
}
else if (concc_CourseKnowledges.KnowledgeName  ==  AttributeName[intIndex])
{
mstrKnowledgeName = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.KnowledgeName);
}
else if (concc_CourseKnowledges.KnowledgeTitle  ==  AttributeName[intIndex])
{
mstrKnowledgeTitle = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.KnowledgeTitle);
}
else if (concc_CourseKnowledges.KnowledgeContent  ==  AttributeName[intIndex])
{
mstrKnowledgeContent = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.KnowledgeContent);
}
else if (concc_CourseKnowledges.KnowledgeModuleId  ==  AttributeName[intIndex])
{
mstrKnowledgeModuleId = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.KnowledgeModuleId);
}
else if (concc_CourseKnowledges.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.CourseId);
}
else if (concc_CourseKnowledges.KnowledgeTypeId  ==  AttributeName[intIndex])
{
mstrKnowledgeTypeId = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.KnowledgeTypeId);
}
else if (concc_CourseKnowledges.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.CourseChapterId);
}
else if (concc_CourseKnowledges.ModuleWeight  ==  AttributeName[intIndex])
{
mdblModuleWeight = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_CourseKnowledges.ModuleWeight);
}
else if (concc_CourseKnowledges.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.UserId);
}
else if (concc_CourseKnowledges.UploadDate  ==  AttributeName[intIndex])
{
mstrUploadDate = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.UploadDate);
}
else if (concc_CourseKnowledges.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseKnowledges.IsShow);
}
else if (concc_CourseKnowledges.IsCast  ==  AttributeName[intIndex])
{
mbolIsCast = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseKnowledges.IsCast);
}
else if (concc_CourseKnowledges.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseKnowledges.LikeCount);
}
else if (concc_CourseKnowledges.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseKnowledges.OrderNum);
}
else if (concc_CourseKnowledges.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.UpdDate);
}
else if (concc_CourseKnowledges.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.UpdUser);
}
else if (concc_CourseKnowledges.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_CourseKnowledges.Memo);
}
}
}

/// <summary>
/// 知识点Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseKnowledgeId
{
get
{
return mstrCourseKnowledgeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseKnowledgeId = value;
}
else
{
 mstrCourseKnowledgeId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseKnowledges.CourseKnowledgeId);
}
}
/// <summary>
/// 知识点名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeName
{
get
{
return mstrKnowledgeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeName = value;
}
else
{
 mstrKnowledgeName = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseKnowledges.KnowledgeName);
}
}
/// <summary>
/// 知识点标题(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeTitle
{
get
{
return mstrKnowledgeTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeTitle = value;
}
else
{
 mstrKnowledgeTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseKnowledges.KnowledgeTitle);
}
}
/// <summary>
/// 知识点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeContent
{
get
{
return mstrKnowledgeContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeContent = value;
}
else
{
 mstrKnowledgeContent = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseKnowledges.KnowledgeContent);
}
}
/// <summary>
/// 知识点模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeModuleId
{
get
{
return mstrKnowledgeModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeModuleId = value;
}
else
{
 mstrKnowledgeModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseKnowledges.KnowledgeModuleId);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseKnowledges.CourseId);
}
}
/// <summary>
/// 知识点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeTypeId
{
get
{
return mstrKnowledgeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeTypeId = value;
}
else
{
 mstrKnowledgeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseKnowledges.KnowledgeTypeId);
}
}
/// <summary>
/// 课程章节ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterId
{
get
{
return mstrCourseChapterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterId = value;
}
else
{
 mstrCourseChapterId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseKnowledges.CourseChapterId);
}
}
/// <summary>
/// 模块权重(说明:;字段类型:numeric;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? ModuleWeight
{
get
{
return mdblModuleWeight;
}
set
{
 mdblModuleWeight = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseKnowledges.ModuleWeight);
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
 AddUpdatedFld(concc_CourseKnowledges.UserId);
}
}
/// <summary>
/// 上传时间(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UploadDate
{
get
{
return mstrUploadDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUploadDate = value;
}
else
{
 mstrUploadDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseKnowledges.UploadDate);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShow
{
get
{
return mbolIsShow;
}
set
{
 mbolIsShow = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseKnowledges.IsShow);
}
}
/// <summary>
/// 是否播放(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCast
{
get
{
return mbolIsCast;
}
set
{
 mbolIsCast = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseKnowledges.IsCast);
}
}
/// <summary>
/// 资源喜欢数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? LikeCount
{
get
{
return mlngLikeCount;
}
set
{
 mlngLikeCount = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseKnowledges.LikeCount);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseKnowledges.OrderNum);
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
 AddUpdatedFld(concc_CourseKnowledges.UpdDate);
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
 AddUpdatedFld(concc_CourseKnowledges.UpdUser);
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
 AddUpdatedFld(concc_CourseKnowledges.Memo);
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
  return mstrCourseKnowledgeId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrKnowledgeName;
 }
 }
}
 /// <summary>
 /// 知识点(cc_CourseKnowledges)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_CourseKnowledges
{
public const string _CurrTabName = "cc_CourseKnowledges"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CourseKnowledgeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseKnowledgeId", "KnowledgeName", "KnowledgeTitle", "KnowledgeContent", "KnowledgeModuleId", "CourseId", "KnowledgeTypeId", "CourseChapterId", "ModuleWeight", "UserId", "UploadDate", "IsShow", "IsCast", "LikeCount", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CourseKnowledgeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeId = "CourseKnowledgeId";    //知识点Id

 /// <summary>
 /// 常量:"KnowledgeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeName = "KnowledgeName";    //知识点名称

 /// <summary>
 /// 常量:"KnowledgeTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeTitle = "KnowledgeTitle";    //知识点标题

 /// <summary>
 /// 常量:"KnowledgeContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeContent = "KnowledgeContent";    //知识点内容

 /// <summary>
 /// 常量:"KnowledgeModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeModuleId = "KnowledgeModuleId";    //知识点模块Id

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"KnowledgeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeTypeId = "KnowledgeTypeId";    //知识点类型Id

 /// <summary>
 /// 常量:"CourseChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterId = "CourseChapterId";    //课程章节ID

 /// <summary>
 /// 常量:"ModuleWeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModuleWeight = "ModuleWeight";    //模块权重

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"UploadDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UploadDate = "UploadDate";    //上传时间

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

 /// <summary>
 /// 常量:"IsCast"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCast = "IsCast";    //是否播放

 /// <summary>
 /// 常量:"LikeCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeCount = "LikeCount";    //资源喜欢数量

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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