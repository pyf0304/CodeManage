
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_StructureChartNodeEN
 表名:gs_StructureChartNode(01120877)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:55
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
 /// 表gs_StructureChartNode的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_gs_StructureChartNode
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_gs_StructureChartNode(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_gs_StructureChartNode]类型的对象</returns>
public static implicit operator K_mId_gs_StructureChartNode(long value)
{
return new K_mId_gs_StructureChartNode(value);
}
}
 /// <summary>
 /// 结构图节点(gs_StructureChartNode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_StructureChartNodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_StructureChartNode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"mId", "StructureChartId", "NodeId", "NodeTitle", "ParentId", "IsRoot", "Expanded", "Direction", "BgColor", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrStructureChartId;    //结构图Id
protected string mstrNodeId;    //节点Id
protected string mstrNodeTitle;    //节点标题
protected string mstrParentId;    //父Id
protected bool mbolIsRoot;    //IsRoot
protected bool mbolExpanded;    //扩大
protected string mstrDirection;    //方向
protected string mstrBgColor;    //背景色
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_StructureChartNodeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsgs_StructureChartNodeEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  congs_StructureChartNode.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  congs_StructureChartNode.StructureChartId)
{
return mstrStructureChartId;
}
else if (strAttributeName  ==  congs_StructureChartNode.NodeId)
{
return mstrNodeId;
}
else if (strAttributeName  ==  congs_StructureChartNode.NodeTitle)
{
return mstrNodeTitle;
}
else if (strAttributeName  ==  congs_StructureChartNode.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  congs_StructureChartNode.IsRoot)
{
return mbolIsRoot;
}
else if (strAttributeName  ==  congs_StructureChartNode.Expanded)
{
return mbolExpanded;
}
else if (strAttributeName  ==  congs_StructureChartNode.Direction)
{
return mstrDirection;
}
else if (strAttributeName  ==  congs_StructureChartNode.BgColor)
{
return mstrBgColor;
}
else if (strAttributeName  ==  congs_StructureChartNode.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_StructureChartNode.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_StructureChartNode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_StructureChartNode.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_StructureChartNode.mId);
}
else if (strAttributeName  ==  congs_StructureChartNode.StructureChartId)
{
mstrStructureChartId = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.StructureChartId);
}
else if (strAttributeName  ==  congs_StructureChartNode.NodeId)
{
mstrNodeId = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.NodeId);
}
else if (strAttributeName  ==  congs_StructureChartNode.NodeTitle)
{
mstrNodeTitle = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.NodeTitle);
}
else if (strAttributeName  ==  congs_StructureChartNode.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.ParentId);
}
else if (strAttributeName  ==  congs_StructureChartNode.IsRoot)
{
mbolIsRoot = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_StructureChartNode.IsRoot);
}
else if (strAttributeName  ==  congs_StructureChartNode.Expanded)
{
mbolExpanded = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_StructureChartNode.Expanded);
}
else if (strAttributeName  ==  congs_StructureChartNode.Direction)
{
mstrDirection = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.Direction);
}
else if (strAttributeName  ==  congs_StructureChartNode.BgColor)
{
mstrBgColor = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.BgColor);
}
else if (strAttributeName  ==  congs_StructureChartNode.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.UpdDate);
}
else if (strAttributeName  ==  congs_StructureChartNode.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.UpdUser);
}
else if (strAttributeName  ==  congs_StructureChartNode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_StructureChartNode.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (congs_StructureChartNode.StructureChartId  ==  AttributeName[intIndex])
{
return mstrStructureChartId;
}
else if (congs_StructureChartNode.NodeId  ==  AttributeName[intIndex])
{
return mstrNodeId;
}
else if (congs_StructureChartNode.NodeTitle  ==  AttributeName[intIndex])
{
return mstrNodeTitle;
}
else if (congs_StructureChartNode.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (congs_StructureChartNode.IsRoot  ==  AttributeName[intIndex])
{
return mbolIsRoot;
}
else if (congs_StructureChartNode.Expanded  ==  AttributeName[intIndex])
{
return mbolExpanded;
}
else if (congs_StructureChartNode.Direction  ==  AttributeName[intIndex])
{
return mstrDirection;
}
else if (congs_StructureChartNode.BgColor  ==  AttributeName[intIndex])
{
return mstrBgColor;
}
else if (congs_StructureChartNode.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_StructureChartNode.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_StructureChartNode.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_StructureChartNode.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_StructureChartNode.mId);
}
else if (congs_StructureChartNode.StructureChartId  ==  AttributeName[intIndex])
{
mstrStructureChartId = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.StructureChartId);
}
else if (congs_StructureChartNode.NodeId  ==  AttributeName[intIndex])
{
mstrNodeId = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.NodeId);
}
else if (congs_StructureChartNode.NodeTitle  ==  AttributeName[intIndex])
{
mstrNodeTitle = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.NodeTitle);
}
else if (congs_StructureChartNode.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.ParentId);
}
else if (congs_StructureChartNode.IsRoot  ==  AttributeName[intIndex])
{
mbolIsRoot = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_StructureChartNode.IsRoot);
}
else if (congs_StructureChartNode.Expanded  ==  AttributeName[intIndex])
{
mbolExpanded = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_StructureChartNode.Expanded);
}
else if (congs_StructureChartNode.Direction  ==  AttributeName[intIndex])
{
mstrDirection = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.Direction);
}
else if (congs_StructureChartNode.BgColor  ==  AttributeName[intIndex])
{
mstrBgColor = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.BgColor);
}
else if (congs_StructureChartNode.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.UpdDate);
}
else if (congs_StructureChartNode.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.UpdUser);
}
else if (congs_StructureChartNode.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_StructureChartNode.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(congs_StructureChartNode.mId);
}
}
/// <summary>
/// 结构图Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StructureChartId
{
get
{
return mstrStructureChartId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStructureChartId = value;
}
else
{
 mstrStructureChartId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_StructureChartNode.StructureChartId);
}
}
/// <summary>
/// 节点Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NodeId
{
get
{
return mstrNodeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNodeId = value;
}
else
{
 mstrNodeId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_StructureChartNode.NodeId);
}
}
/// <summary>
/// 节点标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NodeTitle
{
get
{
return mstrNodeTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNodeTitle = value;
}
else
{
 mstrNodeTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_StructureChartNode.NodeTitle);
}
}
/// <summary>
/// 父Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
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
 AddUpdatedFld(congs_StructureChartNode.ParentId);
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
 AddUpdatedFld(congs_StructureChartNode.IsRoot);
}
}
/// <summary>
/// 扩大(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool Expanded
{
get
{
return mbolExpanded;
}
set
{
 mbolExpanded = value;
//记录修改过的字段
 AddUpdatedFld(congs_StructureChartNode.Expanded);
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
 AddUpdatedFld(congs_StructureChartNode.Direction);
}
}
/// <summary>
/// 背景色(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BgColor
{
get
{
return mstrBgColor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBgColor = value;
}
else
{
 mstrBgColor = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_StructureChartNode.BgColor);
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
 AddUpdatedFld(congs_StructureChartNode.UpdDate);
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
 AddUpdatedFld(congs_StructureChartNode.UpdUser);
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
 AddUpdatedFld(congs_StructureChartNode.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 结构图节点(gs_StructureChartNode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_StructureChartNode
{
public const string _CurrTabName = "gs_StructureChartNode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "StructureChartId", "NodeId", "NodeTitle", "ParentId", "IsRoot", "Expanded", "Direction", "BgColor", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"StructureChartId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StructureChartId = "StructureChartId";    //结构图Id

 /// <summary>
 /// 常量:"NodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NodeId = "NodeId";    //节点Id

 /// <summary>
 /// 常量:"NodeTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NodeTitle = "NodeTitle";    //节点标题

 /// <summary>
 /// 常量:"ParentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentId = "ParentId";    //父Id

 /// <summary>
 /// 常量:"IsRoot"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRoot = "IsRoot";    //IsRoot

 /// <summary>
 /// 常量:"Expanded"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Expanded = "Expanded";    //扩大

 /// <summary>
 /// 常量:"Direction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Direction = "Direction";    //方向

 /// <summary>
 /// 常量:"BgColor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BgColor = "BgColor";    //背景色

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