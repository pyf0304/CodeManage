
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_ConnectLookChartNodeEN
 表名:ge_ConnectLookChartNode(01120917)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:39
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
 /// 表ge_ConnectLookChartNode的关键字(ConnectLookNodeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ConnectLookNodeId_ge_ConnectLookChartNode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strConnectLookNodeId">表关键字</param>
public K_ConnectLookNodeId_ge_ConnectLookChartNode(string strConnectLookNodeId)
{
if (IsValid(strConnectLookNodeId)) Value = strConnectLookNodeId;
else
{
Value = null;
}
}
private static bool IsValid(string strConnectLookNodeId)
{
if (string.IsNullOrEmpty(strConnectLookNodeId) == true) return false;
if (strConnectLookNodeId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ConnectLookNodeId_ge_ConnectLookChartNode]类型的对象</returns>
public static implicit operator K_ConnectLookNodeId_ge_ConnectLookChartNode(string value)
{
return new K_ConnectLookNodeId_ge_ConnectLookChartNode(value);
}
}
 /// <summary>
 /// 连连看图节点(ge_ConnectLookChartNode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_ConnectLookChartNodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_ConnectLookChartNode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ConnectLookNodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"ConnectLookNodeId", "ConnectLookNodeName", "ConnectLookChartId", "XPosition", "YPosition", "LogicNodeId", "ClassName", "UpdDate", "UpdUser", "Memo", "ConnectLookNodeTypeId"};

protected string mstrConnectLookNodeId;    //连连看节点Id
protected string mstrConnectLookNodeName;    //连连看节点名称
protected string mstrConnectLookChartId;    //连连看图Id
protected float? mfltXPosition;    //X_坐标
protected float? mfltYPosition;    //Y_坐标
protected string mstrLogicNodeId;    //逻辑节点Id
protected string mstrClassName;    //样式名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrConnectLookNodeTypeId;    //连连看节点类型

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_ConnectLookChartNodeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConnectLookNodeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strConnectLookNodeId">关键字:连连看节点Id</param>
public clsge_ConnectLookChartNodeEN(string strConnectLookNodeId)
 {
strConnectLookNodeId = strConnectLookNodeId.Replace("'", "''");
if (strConnectLookNodeId.Length > 10)
{
throw new Exception("在表:ge_ConnectLookChartNode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strConnectLookNodeId)  ==  true)
{
throw new Exception("在表:ge_ConnectLookChartNode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strConnectLookNodeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrConnectLookNodeId = strConnectLookNodeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConnectLookNodeId");
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
if (strAttributeName  ==  conge_ConnectLookChartNode.ConnectLookNodeId)
{
return mstrConnectLookNodeId;
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.ConnectLookNodeName)
{
return mstrConnectLookNodeName;
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.ConnectLookChartId)
{
return mstrConnectLookChartId;
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.XPosition)
{
return mfltXPosition;
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.YPosition)
{
return mfltYPosition;
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.LogicNodeId)
{
return mstrLogicNodeId;
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.ClassName)
{
return mstrClassName;
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.ConnectLookNodeTypeId)
{
return mstrConnectLookNodeTypeId;
}
return null;
}
set
{
if (strAttributeName  ==  conge_ConnectLookChartNode.ConnectLookNodeId)
{
mstrConnectLookNodeId = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.ConnectLookNodeId);
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.ConnectLookNodeName)
{
mstrConnectLookNodeName = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.ConnectLookNodeName);
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.ConnectLookChartId)
{
mstrConnectLookChartId = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.ConnectLookChartId);
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.XPosition)
{
mfltXPosition = TransNullToFloat(value.ToString());
 AddUpdatedFld(conge_ConnectLookChartNode.XPosition);
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.YPosition)
{
mfltYPosition = TransNullToFloat(value.ToString());
 AddUpdatedFld(conge_ConnectLookChartNode.YPosition);
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.LogicNodeId)
{
mstrLogicNodeId = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.LogicNodeId);
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.ClassName)
{
mstrClassName = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.ClassName);
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.UpdDate);
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.UpdUser);
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.Memo);
}
else if (strAttributeName  ==  conge_ConnectLookChartNode.ConnectLookNodeTypeId)
{
mstrConnectLookNodeTypeId = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.ConnectLookNodeTypeId);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_ConnectLookChartNode.ConnectLookNodeId  ==  AttributeName[intIndex])
{
return mstrConnectLookNodeId;
}
else if (conge_ConnectLookChartNode.ConnectLookNodeName  ==  AttributeName[intIndex])
{
return mstrConnectLookNodeName;
}
else if (conge_ConnectLookChartNode.ConnectLookChartId  ==  AttributeName[intIndex])
{
return mstrConnectLookChartId;
}
else if (conge_ConnectLookChartNode.XPosition  ==  AttributeName[intIndex])
{
return mfltXPosition;
}
else if (conge_ConnectLookChartNode.YPosition  ==  AttributeName[intIndex])
{
return mfltYPosition;
}
else if (conge_ConnectLookChartNode.LogicNodeId  ==  AttributeName[intIndex])
{
return mstrLogicNodeId;
}
else if (conge_ConnectLookChartNode.ClassName  ==  AttributeName[intIndex])
{
return mstrClassName;
}
else if (conge_ConnectLookChartNode.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_ConnectLookChartNode.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_ConnectLookChartNode.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conge_ConnectLookChartNode.ConnectLookNodeTypeId  ==  AttributeName[intIndex])
{
return mstrConnectLookNodeTypeId;
}
return null;
}
set
{
if (conge_ConnectLookChartNode.ConnectLookNodeId  ==  AttributeName[intIndex])
{
mstrConnectLookNodeId = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.ConnectLookNodeId);
}
else if (conge_ConnectLookChartNode.ConnectLookNodeName  ==  AttributeName[intIndex])
{
mstrConnectLookNodeName = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.ConnectLookNodeName);
}
else if (conge_ConnectLookChartNode.ConnectLookChartId  ==  AttributeName[intIndex])
{
mstrConnectLookChartId = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.ConnectLookChartId);
}
else if (conge_ConnectLookChartNode.XPosition  ==  AttributeName[intIndex])
{
mfltXPosition = TransNullToFloat(value.ToString());
 AddUpdatedFld(conge_ConnectLookChartNode.XPosition);
}
else if (conge_ConnectLookChartNode.YPosition  ==  AttributeName[intIndex])
{
mfltYPosition = TransNullToFloat(value.ToString());
 AddUpdatedFld(conge_ConnectLookChartNode.YPosition);
}
else if (conge_ConnectLookChartNode.LogicNodeId  ==  AttributeName[intIndex])
{
mstrLogicNodeId = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.LogicNodeId);
}
else if (conge_ConnectLookChartNode.ClassName  ==  AttributeName[intIndex])
{
mstrClassName = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.ClassName);
}
else if (conge_ConnectLookChartNode.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.UpdDate);
}
else if (conge_ConnectLookChartNode.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.UpdUser);
}
else if (conge_ConnectLookChartNode.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.Memo);
}
else if (conge_ConnectLookChartNode.ConnectLookNodeTypeId  ==  AttributeName[intIndex])
{
mstrConnectLookNodeTypeId = value.ToString();
 AddUpdatedFld(conge_ConnectLookChartNode.ConnectLookNodeTypeId);
}
}
}

/// <summary>
/// 连连看节点Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConnectLookNodeId
{
get
{
return mstrConnectLookNodeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConnectLookNodeId = value;
}
else
{
 mstrConnectLookNodeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ConnectLookChartNode.ConnectLookNodeId);
}
}
/// <summary>
/// 连连看节点名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConnectLookNodeName
{
get
{
return mstrConnectLookNodeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConnectLookNodeName = value;
}
else
{
 mstrConnectLookNodeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ConnectLookChartNode.ConnectLookNodeName);
}
}
/// <summary>
/// 连连看图Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConnectLookChartId
{
get
{
return mstrConnectLookChartId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConnectLookChartId = value;
}
else
{
 mstrConnectLookChartId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ConnectLookChartNode.ConnectLookChartId);
}
}
/// <summary>
/// X_坐标(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? XPosition
{
get
{
return mfltXPosition;
}
set
{
 mfltXPosition = value;
//记录修改过的字段
 AddUpdatedFld(conge_ConnectLookChartNode.XPosition);
}
}
/// <summary>
/// Y_坐标(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? YPosition
{
get
{
return mfltYPosition;
}
set
{
 mfltYPosition = value;
//记录修改过的字段
 AddUpdatedFld(conge_ConnectLookChartNode.YPosition);
}
}
/// <summary>
/// 逻辑节点Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LogicNodeId
{
get
{
return mstrLogicNodeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLogicNodeId = value;
}
else
{
 mstrLogicNodeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ConnectLookChartNode.LogicNodeId);
}
}
/// <summary>
/// 样式名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassName
{
get
{
return mstrClassName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassName = value;
}
else
{
 mstrClassName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ConnectLookChartNode.ClassName);
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
 AddUpdatedFld(conge_ConnectLookChartNode.UpdDate);
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
 AddUpdatedFld(conge_ConnectLookChartNode.UpdUser);
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
 AddUpdatedFld(conge_ConnectLookChartNode.Memo);
}
}
/// <summary>
/// 连连看节点类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConnectLookNodeTypeId
{
get
{
return mstrConnectLookNodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConnectLookNodeTypeId = value;
}
else
{
 mstrConnectLookNodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ConnectLookChartNode.ConnectLookNodeTypeId);
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
  return mstrConnectLookNodeId;
 }
 }
}
 /// <summary>
 /// 连连看图节点(ge_ConnectLookChartNode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_ConnectLookChartNode
{
public const string _CurrTabName = "ge_ConnectLookChartNode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ConnectLookNodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ConnectLookNodeId", "ConnectLookNodeName", "ConnectLookChartId", "XPosition", "YPosition", "LogicNodeId", "ClassName", "UpdDate", "UpdUser", "Memo", "ConnectLookNodeTypeId"};
//以下是属性变量


 /// <summary>
 /// 常量:"ConnectLookNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConnectLookNodeId = "ConnectLookNodeId";    //连连看节点Id

 /// <summary>
 /// 常量:"ConnectLookNodeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConnectLookNodeName = "ConnectLookNodeName";    //连连看节点名称

 /// <summary>
 /// 常量:"ConnectLookChartId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConnectLookChartId = "ConnectLookChartId";    //连连看图Id

 /// <summary>
 /// 常量:"XPosition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string XPosition = "XPosition";    //X_坐标

 /// <summary>
 /// 常量:"YPosition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YPosition = "YPosition";    //Y_坐标

 /// <summary>
 /// 常量:"LogicNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LogicNodeId = "LogicNodeId";    //逻辑节点Id

 /// <summary>
 /// 常量:"ClassName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassName = "ClassName";    //样式名称

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
 /// 常量:"ConnectLookNodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConnectLookNodeTypeId = "ConnectLookNodeTypeId";    //连连看节点类型
}

}