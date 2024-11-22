
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StructureSectionEN
 表名:ge_StructureSection(01120896)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:11
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
 /// 表ge_StructureSection的关键字(StructureSectionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_StructureSectionId_ge_StructureSection
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strStructureSectionId">表关键字</param>
public K_StructureSectionId_ge_StructureSection(string strStructureSectionId)
{
if (IsValid(strStructureSectionId)) Value = strStructureSectionId;
else
{
Value = null;
}
}
private static bool IsValid(string strStructureSectionId)
{
if (string.IsNullOrEmpty(strStructureSectionId) == true) return false;
if (strStructureSectionId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_StructureSectionId_ge_StructureSection]类型的对象</returns>
public static implicit operator K_StructureSectionId_ge_StructureSection(string value)
{
return new K_StructureSectionId_ge_StructureSection(value);
}
}
 /// <summary>
 /// 结构章节(ge_StructureSection)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_StructureSectionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_StructureSection"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "StructureSectionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"StructureSectionId", "StructureSectionName", "StructureSectionContent", "CourseId", "IsShow", "UpdDate", "UpdUser", "Memo", "SectionTypeId", "Direction", "IsExpanded", "IsRoot", "ParentId", "OrderNum"};

protected string mstrStructureSectionId;    //结构章节Id
protected string mstrStructureSectionName;    //结构章节名称
protected string mstrStructureSectionContent;    //结构章节内容
protected string mstrCourseId;    //课程Id
protected bool mbolIsShow;    //是否启用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrSectionTypeId;    //节点类型Id
protected string mstrDirection;    //方向
protected bool mbolIsExpanded;    //是否扩展
protected bool mbolIsRoot;    //IsRoot
protected string mstrParentId;    //父节点Id
protected int? mintOrderNum;    //序号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_StructureSectionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StructureSectionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strStructureSectionId">关键字:结构章节Id</param>
public clsge_StructureSectionEN(string strStructureSectionId)
 {
strStructureSectionId = strStructureSectionId.Replace("'", "''");
if (strStructureSectionId.Length > 10)
{
throw new Exception("在表:ge_StructureSection中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strStructureSectionId)  ==  true)
{
throw new Exception("在表:ge_StructureSection中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStructureSectionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrStructureSectionId = strStructureSectionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StructureSectionId");
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
if (strAttributeName  ==  conge_StructureSection.StructureSectionId)
{
return mstrStructureSectionId;
}
else if (strAttributeName  ==  conge_StructureSection.StructureSectionName)
{
return mstrStructureSectionName;
}
else if (strAttributeName  ==  conge_StructureSection.StructureSectionContent)
{
return mstrStructureSectionContent;
}
else if (strAttributeName  ==  conge_StructureSection.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conge_StructureSection.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  conge_StructureSection.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_StructureSection.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_StructureSection.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conge_StructureSection.SectionTypeId)
{
return mstrSectionTypeId;
}
else if (strAttributeName  ==  conge_StructureSection.Direction)
{
return mstrDirection;
}
else if (strAttributeName  ==  conge_StructureSection.IsExpanded)
{
return mbolIsExpanded;
}
else if (strAttributeName  ==  conge_StructureSection.IsRoot)
{
return mbolIsRoot;
}
else if (strAttributeName  ==  conge_StructureSection.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  conge_StructureSection.OrderNum)
{
return mintOrderNum;
}
return null;
}
set
{
if (strAttributeName  ==  conge_StructureSection.StructureSectionId)
{
mstrStructureSectionId = value.ToString();
 AddUpdatedFld(conge_StructureSection.StructureSectionId);
}
else if (strAttributeName  ==  conge_StructureSection.StructureSectionName)
{
mstrStructureSectionName = value.ToString();
 AddUpdatedFld(conge_StructureSection.StructureSectionName);
}
else if (strAttributeName  ==  conge_StructureSection.StructureSectionContent)
{
mstrStructureSectionContent = value.ToString();
 AddUpdatedFld(conge_StructureSection.StructureSectionContent);
}
else if (strAttributeName  ==  conge_StructureSection.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_StructureSection.CourseId);
}
else if (strAttributeName  ==  conge_StructureSection.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureSection.IsShow);
}
else if (strAttributeName  ==  conge_StructureSection.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_StructureSection.UpdDate);
}
else if (strAttributeName  ==  conge_StructureSection.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_StructureSection.UpdUser);
}
else if (strAttributeName  ==  conge_StructureSection.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_StructureSection.Memo);
}
else if (strAttributeName  ==  conge_StructureSection.SectionTypeId)
{
mstrSectionTypeId = value.ToString();
 AddUpdatedFld(conge_StructureSection.SectionTypeId);
}
else if (strAttributeName  ==  conge_StructureSection.Direction)
{
mstrDirection = value.ToString();
 AddUpdatedFld(conge_StructureSection.Direction);
}
else if (strAttributeName  ==  conge_StructureSection.IsExpanded)
{
mbolIsExpanded = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureSection.IsExpanded);
}
else if (strAttributeName  ==  conge_StructureSection.IsRoot)
{
mbolIsRoot = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureSection.IsRoot);
}
else if (strAttributeName  ==  conge_StructureSection.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(conge_StructureSection.ParentId);
}
else if (strAttributeName  ==  conge_StructureSection.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StructureSection.OrderNum);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_StructureSection.StructureSectionId  ==  AttributeName[intIndex])
{
return mstrStructureSectionId;
}
else if (conge_StructureSection.StructureSectionName  ==  AttributeName[intIndex])
{
return mstrStructureSectionName;
}
else if (conge_StructureSection.StructureSectionContent  ==  AttributeName[intIndex])
{
return mstrStructureSectionContent;
}
else if (conge_StructureSection.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conge_StructureSection.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (conge_StructureSection.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_StructureSection.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_StructureSection.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conge_StructureSection.SectionTypeId  ==  AttributeName[intIndex])
{
return mstrSectionTypeId;
}
else if (conge_StructureSection.Direction  ==  AttributeName[intIndex])
{
return mstrDirection;
}
else if (conge_StructureSection.IsExpanded  ==  AttributeName[intIndex])
{
return mbolIsExpanded;
}
else if (conge_StructureSection.IsRoot  ==  AttributeName[intIndex])
{
return mbolIsRoot;
}
else if (conge_StructureSection.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (conge_StructureSection.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
return null;
}
set
{
if (conge_StructureSection.StructureSectionId  ==  AttributeName[intIndex])
{
mstrStructureSectionId = value.ToString();
 AddUpdatedFld(conge_StructureSection.StructureSectionId);
}
else if (conge_StructureSection.StructureSectionName  ==  AttributeName[intIndex])
{
mstrStructureSectionName = value.ToString();
 AddUpdatedFld(conge_StructureSection.StructureSectionName);
}
else if (conge_StructureSection.StructureSectionContent  ==  AttributeName[intIndex])
{
mstrStructureSectionContent = value.ToString();
 AddUpdatedFld(conge_StructureSection.StructureSectionContent);
}
else if (conge_StructureSection.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_StructureSection.CourseId);
}
else if (conge_StructureSection.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureSection.IsShow);
}
else if (conge_StructureSection.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_StructureSection.UpdDate);
}
else if (conge_StructureSection.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_StructureSection.UpdUser);
}
else if (conge_StructureSection.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_StructureSection.Memo);
}
else if (conge_StructureSection.SectionTypeId  ==  AttributeName[intIndex])
{
mstrSectionTypeId = value.ToString();
 AddUpdatedFld(conge_StructureSection.SectionTypeId);
}
else if (conge_StructureSection.Direction  ==  AttributeName[intIndex])
{
mstrDirection = value.ToString();
 AddUpdatedFld(conge_StructureSection.Direction);
}
else if (conge_StructureSection.IsExpanded  ==  AttributeName[intIndex])
{
mbolIsExpanded = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureSection.IsExpanded);
}
else if (conge_StructureSection.IsRoot  ==  AttributeName[intIndex])
{
mbolIsRoot = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureSection.IsRoot);
}
else if (conge_StructureSection.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(conge_StructureSection.ParentId);
}
else if (conge_StructureSection.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StructureSection.OrderNum);
}
}
}

/// <summary>
/// 结构章节Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StructureSectionId
{
get
{
return mstrStructureSectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStructureSectionId = value;
}
else
{
 mstrStructureSectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureSection.StructureSectionId);
}
}
/// <summary>
/// 结构章节名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StructureSectionName
{
get
{
return mstrStructureSectionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStructureSectionName = value;
}
else
{
 mstrStructureSectionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureSection.StructureSectionName);
}
}
/// <summary>
/// 结构章节内容(说明:;字段类型:varchar;字段长度:3000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StructureSectionContent
{
get
{
return mstrStructureSectionContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStructureSectionContent = value;
}
else
{
 mstrStructureSectionContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureSection.StructureSectionContent);
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
 AddUpdatedFld(conge_StructureSection.CourseId);
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
 AddUpdatedFld(conge_StructureSection.IsShow);
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
 AddUpdatedFld(conge_StructureSection.UpdDate);
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
 AddUpdatedFld(conge_StructureSection.UpdUser);
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
 AddUpdatedFld(conge_StructureSection.Memo);
}
}
/// <summary>
/// 节点类型Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionTypeId
{
get
{
return mstrSectionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionTypeId = value;
}
else
{
 mstrSectionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureSection.SectionTypeId);
}
}
/// <summary>
/// 方向(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Direction
{
get
{
return mstrDirection;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDirection = value;
}
else
{
 mstrDirection = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureSection.Direction);
}
}
/// <summary>
/// 是否扩展(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExpanded
{
get
{
return mbolIsExpanded;
}
set
{
 mbolIsExpanded = value;
//记录修改过的字段
 AddUpdatedFld(conge_StructureSection.IsExpanded);
}
}
/// <summary>
/// IsRoot(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRoot
{
get
{
return mbolIsRoot;
}
set
{
 mbolIsRoot = value;
//记录修改过的字段
 AddUpdatedFld(conge_StructureSection.IsRoot);
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
 AddUpdatedFld(conge_StructureSection.ParentId);
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
 AddUpdatedFld(conge_StructureSection.OrderNum);
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
  return mstrStructureSectionId;
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
  return mstrStructureSectionName;
 }
 }
}
 /// <summary>
 /// 结构章节(ge_StructureSection)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_StructureSection
{
public const string _CurrTabName = "ge_StructureSection"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "StructureSectionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"StructureSectionId", "StructureSectionName", "StructureSectionContent", "CourseId", "IsShow", "UpdDate", "UpdUser", "Memo", "SectionTypeId", "Direction", "IsExpanded", "IsRoot", "ParentId", "OrderNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"StructureSectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StructureSectionId = "StructureSectionId";    //结构章节Id

 /// <summary>
 /// 常量:"StructureSectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StructureSectionName = "StructureSectionName";    //结构章节名称

 /// <summary>
 /// 常量:"StructureSectionContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StructureSectionContent = "StructureSectionContent";    //结构章节内容

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

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
 /// 常量:"SectionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionTypeId = "SectionTypeId";    //节点类型Id

 /// <summary>
 /// 常量:"Direction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Direction = "Direction";    //方向

 /// <summary>
 /// 常量:"IsExpanded"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExpanded = "IsExpanded";    //是否扩展

 /// <summary>
 /// 常量:"IsRoot"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRoot = "IsRoot";    //IsRoot

 /// <summary>
 /// 常量:"ParentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentId = "ParentId";    //父节点Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号
}

}