
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StructureChartNodeEN
 表名:ge_StructureChartNode(01120894)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:51
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
 /// 表ge_StructureChartNode的关键字(StructureNodeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_StructureNodeId_ge_StructureChartNode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strStructureNodeId">表关键字</param>
public K_StructureNodeId_ge_StructureChartNode(string strStructureNodeId)
{
if (IsValid(strStructureNodeId)) Value = strStructureNodeId;
else
{
Value = null;
}
}
private static bool IsValid(string strStructureNodeId)
{
if (string.IsNullOrEmpty(strStructureNodeId) == true) return false;
if (strStructureNodeId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_StructureNodeId_ge_StructureChartNode]类型的对象</returns>
public static implicit operator K_StructureNodeId_ge_StructureChartNode(string value)
{
return new K_StructureNodeId_ge_StructureChartNode(value);
}
}
 /// <summary>
 /// 知识点结构图(ge_StructureChartNode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_StructureChartNodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_StructureChartNode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "StructureNodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"StructureNodeId", "StructureNodeName", "UpdDate", "UpdUser", "Memo", "ParentId", "IsRoot", "background", "foreground", "StructureGraphId", "Direction", "IsExpanded", "StructureSectionId", "OrderNum"};

protected string mstrStructureNodeId;    //结构Id
protected string mstrStructureNodeName;    //结构名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrParentId;    //父节点Id
protected bool mbolIsRoot;    //IsRoot
protected string mstrbackground;    //背景色
protected string mstrforeground;    //背景字颜色
protected string mstrStructureGraphId;    //知识图谱Id
protected string mstrDirection;    //方向
protected bool mbolIsExpanded;    //是否扩展
protected string mstrStructureSectionId;    //结构章节Id
protected int? mintOrderNum;    //序号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_StructureChartNodeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StructureNodeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strStructureNodeId">关键字:结构Id</param>
public clsge_StructureChartNodeEN(string strStructureNodeId)
 {
strStructureNodeId = strStructureNodeId.Replace("'", "''");
if (strStructureNodeId.Length > 10)
{
throw new Exception("在表:ge_StructureChartNode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strStructureNodeId)  ==  true)
{
throw new Exception("在表:ge_StructureChartNode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStructureNodeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrStructureNodeId = strStructureNodeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StructureNodeId");
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
if (strAttributeName  ==  conge_StructureChartNode.StructureNodeId)
{
return mstrStructureNodeId;
}
else if (strAttributeName  ==  conge_StructureChartNode.StructureNodeName)
{
return mstrStructureNodeName;
}
else if (strAttributeName  ==  conge_StructureChartNode.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_StructureChartNode.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_StructureChartNode.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conge_StructureChartNode.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  conge_StructureChartNode.IsRoot)
{
return mbolIsRoot;
}
else if (strAttributeName  ==  conge_StructureChartNode.background)
{
return mstrbackground;
}
else if (strAttributeName  ==  conge_StructureChartNode.foreground)
{
return mstrforeground;
}
else if (strAttributeName  ==  conge_StructureChartNode.StructureGraphId)
{
return mstrStructureGraphId;
}
else if (strAttributeName  ==  conge_StructureChartNode.Direction)
{
return mstrDirection;
}
else if (strAttributeName  ==  conge_StructureChartNode.IsExpanded)
{
return mbolIsExpanded;
}
else if (strAttributeName  ==  conge_StructureChartNode.StructureSectionId)
{
return mstrStructureSectionId;
}
else if (strAttributeName  ==  conge_StructureChartNode.OrderNum)
{
return mintOrderNum;
}
return null;
}
set
{
if (strAttributeName  ==  conge_StructureChartNode.StructureNodeId)
{
mstrStructureNodeId = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.StructureNodeId);
}
else if (strAttributeName  ==  conge_StructureChartNode.StructureNodeName)
{
mstrStructureNodeName = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.StructureNodeName);
}
else if (strAttributeName  ==  conge_StructureChartNode.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.UpdDate);
}
else if (strAttributeName  ==  conge_StructureChartNode.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.UpdUser);
}
else if (strAttributeName  ==  conge_StructureChartNode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.Memo);
}
else if (strAttributeName  ==  conge_StructureChartNode.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.ParentId);
}
else if (strAttributeName  ==  conge_StructureChartNode.IsRoot)
{
mbolIsRoot = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureChartNode.IsRoot);
}
else if (strAttributeName  ==  conge_StructureChartNode.background)
{
mstrbackground = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.background);
}
else if (strAttributeName  ==  conge_StructureChartNode.foreground)
{
mstrforeground = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.foreground);
}
else if (strAttributeName  ==  conge_StructureChartNode.StructureGraphId)
{
mstrStructureGraphId = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.StructureGraphId);
}
else if (strAttributeName  ==  conge_StructureChartNode.Direction)
{
mstrDirection = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.Direction);
}
else if (strAttributeName  ==  conge_StructureChartNode.IsExpanded)
{
mbolIsExpanded = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureChartNode.IsExpanded);
}
else if (strAttributeName  ==  conge_StructureChartNode.StructureSectionId)
{
mstrStructureSectionId = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.StructureSectionId);
}
else if (strAttributeName  ==  conge_StructureChartNode.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StructureChartNode.OrderNum);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_StructureChartNode.StructureNodeId  ==  AttributeName[intIndex])
{
return mstrStructureNodeId;
}
else if (conge_StructureChartNode.StructureNodeName  ==  AttributeName[intIndex])
{
return mstrStructureNodeName;
}
else if (conge_StructureChartNode.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_StructureChartNode.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_StructureChartNode.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conge_StructureChartNode.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (conge_StructureChartNode.IsRoot  ==  AttributeName[intIndex])
{
return mbolIsRoot;
}
else if (conge_StructureChartNode.background  ==  AttributeName[intIndex])
{
return mstrbackground;
}
else if (conge_StructureChartNode.foreground  ==  AttributeName[intIndex])
{
return mstrforeground;
}
else if (conge_StructureChartNode.StructureGraphId  ==  AttributeName[intIndex])
{
return mstrStructureGraphId;
}
else if (conge_StructureChartNode.Direction  ==  AttributeName[intIndex])
{
return mstrDirection;
}
else if (conge_StructureChartNode.IsExpanded  ==  AttributeName[intIndex])
{
return mbolIsExpanded;
}
else if (conge_StructureChartNode.StructureSectionId  ==  AttributeName[intIndex])
{
return mstrStructureSectionId;
}
else if (conge_StructureChartNode.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
return null;
}
set
{
if (conge_StructureChartNode.StructureNodeId  ==  AttributeName[intIndex])
{
mstrStructureNodeId = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.StructureNodeId);
}
else if (conge_StructureChartNode.StructureNodeName  ==  AttributeName[intIndex])
{
mstrStructureNodeName = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.StructureNodeName);
}
else if (conge_StructureChartNode.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.UpdDate);
}
else if (conge_StructureChartNode.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.UpdUser);
}
else if (conge_StructureChartNode.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.Memo);
}
else if (conge_StructureChartNode.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.ParentId);
}
else if (conge_StructureChartNode.IsRoot  ==  AttributeName[intIndex])
{
mbolIsRoot = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureChartNode.IsRoot);
}
else if (conge_StructureChartNode.background  ==  AttributeName[intIndex])
{
mstrbackground = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.background);
}
else if (conge_StructureChartNode.foreground  ==  AttributeName[intIndex])
{
mstrforeground = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.foreground);
}
else if (conge_StructureChartNode.StructureGraphId  ==  AttributeName[intIndex])
{
mstrStructureGraphId = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.StructureGraphId);
}
else if (conge_StructureChartNode.Direction  ==  AttributeName[intIndex])
{
mstrDirection = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.Direction);
}
else if (conge_StructureChartNode.IsExpanded  ==  AttributeName[intIndex])
{
mbolIsExpanded = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureChartNode.IsExpanded);
}
else if (conge_StructureChartNode.StructureSectionId  ==  AttributeName[intIndex])
{
mstrStructureSectionId = value.ToString();
 AddUpdatedFld(conge_StructureChartNode.StructureSectionId);
}
else if (conge_StructureChartNode.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StructureChartNode.OrderNum);
}
}
}

/// <summary>
/// 结构Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StructureNodeId
{
get
{
return mstrStructureNodeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStructureNodeId = value;
}
else
{
 mstrStructureNodeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureChartNode.StructureNodeId);
}
}
/// <summary>
/// 结构名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StructureNodeName
{
get
{
return mstrStructureNodeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStructureNodeName = value;
}
else
{
 mstrStructureNodeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureChartNode.StructureNodeName);
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
 AddUpdatedFld(conge_StructureChartNode.UpdDate);
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
 AddUpdatedFld(conge_StructureChartNode.UpdUser);
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
 AddUpdatedFld(conge_StructureChartNode.Memo);
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
 AddUpdatedFld(conge_StructureChartNode.ParentId);
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
 AddUpdatedFld(conge_StructureChartNode.IsRoot);
}
}
/// <summary>
/// 背景色(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string background
{
get
{
return mstrbackground;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrbackground = value;
}
else
{
 mstrbackground = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureChartNode.background);
}
}
/// <summary>
/// 背景字颜色(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string foreground
{
get
{
return mstrforeground;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrforeground = value;
}
else
{
 mstrforeground = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureChartNode.foreground);
}
}
/// <summary>
/// 知识图谱Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StructureGraphId
{
get
{
return mstrStructureGraphId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStructureGraphId = value;
}
else
{
 mstrStructureGraphId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureChartNode.StructureGraphId);
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
 AddUpdatedFld(conge_StructureChartNode.Direction);
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
 AddUpdatedFld(conge_StructureChartNode.IsExpanded);
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
 AddUpdatedFld(conge_StructureChartNode.StructureSectionId);
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
 AddUpdatedFld(conge_StructureChartNode.OrderNum);
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
  return mstrStructureNodeId;
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
  return mstrStructureNodeName;
 }
 }
}
 /// <summary>
 /// 知识点结构图(ge_StructureChartNode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_StructureChartNode
{
public const string _CurrTabName = "ge_StructureChartNode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "StructureNodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"StructureNodeId", "StructureNodeName", "UpdDate", "UpdUser", "Memo", "ParentId", "IsRoot", "background", "foreground", "StructureGraphId", "Direction", "IsExpanded", "StructureSectionId", "OrderNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"StructureNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StructureNodeId = "StructureNodeId";    //结构Id

 /// <summary>
 /// 常量:"StructureNodeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StructureNodeName = "StructureNodeName";    //结构名称

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
 /// 常量:"IsRoot"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRoot = "IsRoot";    //IsRoot

 /// <summary>
 /// 常量:"background"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string background = "background";    //背景色

 /// <summary>
 /// 常量:"foreground"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string foreground = "foreground";    //背景字颜色

 /// <summary>
 /// 常量:"StructureGraphId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StructureGraphId = "StructureGraphId";    //知识图谱Id

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
 /// 常量:"StructureSectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StructureSectionId = "StructureSectionId";    //结构章节Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号
}

}