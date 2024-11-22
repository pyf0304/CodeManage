
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_KnowledgesGraphTypeEN
 表名:gs_KnowledgesGraphType(01120888)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:32
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
 /// 表gs_KnowledgesGraphType的关键字(GraphTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_GraphTypeId_gs_KnowledgesGraphType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strGraphTypeId">表关键字</param>
public K_GraphTypeId_gs_KnowledgesGraphType(string strGraphTypeId)
{
if (IsValid(strGraphTypeId)) Value = strGraphTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strGraphTypeId)
{
if (string.IsNullOrEmpty(strGraphTypeId) == true) return false;
if (strGraphTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_GraphTypeId_gs_KnowledgesGraphType]类型的对象</returns>
public static implicit operator K_GraphTypeId_gs_KnowledgesGraphType(string value)
{
return new K_GraphTypeId_gs_KnowledgesGraphType(value);
}
}
 /// <summary>
 /// 知识点图谱类型(gs_KnowledgesGraphType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_KnowledgesGraphTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_KnowledgesGraphType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "GraphTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"GraphTypeId", "GraphTypeName", "Memo"};

protected string mstrGraphTypeId;    //图谱类型Id
protected string mstrGraphTypeName;    //图谱类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_KnowledgesGraphTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GraphTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strGraphTypeId">关键字:图谱类型Id</param>
public clsgs_KnowledgesGraphTypeEN(string strGraphTypeId)
 {
strGraphTypeId = strGraphTypeId.Replace("'", "''");
if (strGraphTypeId.Length > 2)
{
throw new Exception("在表:gs_KnowledgesGraphType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strGraphTypeId)  ==  true)
{
throw new Exception("在表:gs_KnowledgesGraphType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGraphTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrGraphTypeId = strGraphTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GraphTypeId");
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
if (strAttributeName  ==  congs_KnowledgesGraphType.GraphTypeId)
{
return mstrGraphTypeId;
}
else if (strAttributeName  ==  congs_KnowledgesGraphType.GraphTypeName)
{
return mstrGraphTypeName;
}
else if (strAttributeName  ==  congs_KnowledgesGraphType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_KnowledgesGraphType.GraphTypeId)
{
mstrGraphTypeId = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraphType.GraphTypeId);
}
else if (strAttributeName  ==  congs_KnowledgesGraphType.GraphTypeName)
{
mstrGraphTypeName = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraphType.GraphTypeName);
}
else if (strAttributeName  ==  congs_KnowledgesGraphType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraphType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_KnowledgesGraphType.GraphTypeId  ==  AttributeName[intIndex])
{
return mstrGraphTypeId;
}
else if (congs_KnowledgesGraphType.GraphTypeName  ==  AttributeName[intIndex])
{
return mstrGraphTypeName;
}
else if (congs_KnowledgesGraphType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_KnowledgesGraphType.GraphTypeId  ==  AttributeName[intIndex])
{
mstrGraphTypeId = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraphType.GraphTypeId);
}
else if (congs_KnowledgesGraphType.GraphTypeName  ==  AttributeName[intIndex])
{
mstrGraphTypeName = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraphType.GraphTypeName);
}
else if (congs_KnowledgesGraphType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraphType.Memo);
}
}
}

/// <summary>
/// 图谱类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GraphTypeId
{
get
{
return mstrGraphTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGraphTypeId = value;
}
else
{
 mstrGraphTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesGraphType.GraphTypeId);
}
}
/// <summary>
/// 图谱类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GraphTypeName
{
get
{
return mstrGraphTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGraphTypeName = value;
}
else
{
 mstrGraphTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesGraphType.GraphTypeName);
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
 AddUpdatedFld(congs_KnowledgesGraphType.Memo);
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
  return mstrGraphTypeId;
 }
 }
}
 /// <summary>
 /// 知识点图谱类型(gs_KnowledgesGraphType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_KnowledgesGraphType
{
public const string _CurrTabName = "gs_KnowledgesGraphType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "GraphTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"GraphTypeId", "GraphTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"GraphTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GraphTypeId = "GraphTypeId";    //图谱类型Id

 /// <summary>
 /// 常量:"GraphTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GraphTypeName = "GraphTypeName";    //图谱类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}