
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseCourseKnowledgeRelaTypeEN
 表名:CaseCourseKnowledgeRelaType(01120528)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 表CaseCourseKnowledgeRelaType的关键字(IdCaseCourseKnowledgeRelaType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCaseCourseKnowledgeRelaType_CaseCourseKnowledgeRelaType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCaseCourseKnowledgeRelaType">表关键字</param>
public K_IdCaseCourseKnowledgeRelaType_CaseCourseKnowledgeRelaType(string strIdCaseCourseKnowledgeRelaType)
{
if (IsValid(strIdCaseCourseKnowledgeRelaType)) Value = strIdCaseCourseKnowledgeRelaType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCaseCourseKnowledgeRelaType)
{
if (string.IsNullOrEmpty(strIdCaseCourseKnowledgeRelaType) == true) return false;
if (strIdCaseCourseKnowledgeRelaType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCaseCourseKnowledgeRelaType_CaseCourseKnowledgeRelaType]类型的对象</returns>
public static implicit operator K_IdCaseCourseKnowledgeRelaType_CaseCourseKnowledgeRelaType(string value)
{
return new K_IdCaseCourseKnowledgeRelaType_CaseCourseKnowledgeRelaType(value);
}
}
 /// <summary>
 /// 案例知识点关系类型(CaseCourseKnowledgeRelaType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCaseCourseKnowledgeRelaTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CaseCourseKnowledgeRelaType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCaseCourseKnowledgeRelaType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdCaseCourseKnowledgeRelaType", "CaseCourseKnowledgeRelaTypeID", "CaseCourseKnowledgeRelaTypeName", "Memo"};

protected string mstrIdCaseCourseKnowledgeRelaType;    //案例知识点关系类型流水号
protected string mstrCaseCourseKnowledgeRelaTypeID;    //案例题库关系类型ID
protected string mstrCaseCourseKnowledgeRelaTypeName;    //案例知识点关系类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCaseCourseKnowledgeRelaTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseCourseKnowledgeRelaType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCaseCourseKnowledgeRelaType">关键字:案例知识点关系类型流水号</param>
public clsCaseCourseKnowledgeRelaTypeEN(string strIdCaseCourseKnowledgeRelaType)
 {
strIdCaseCourseKnowledgeRelaType = strIdCaseCourseKnowledgeRelaType.Replace("'", "''");
if (strIdCaseCourseKnowledgeRelaType.Length > 4)
{
throw new Exception("在表:CaseCourseKnowledgeRelaType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCaseCourseKnowledgeRelaType)  ==  true)
{
throw new Exception("在表:CaseCourseKnowledgeRelaType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCaseCourseKnowledgeRelaType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCaseCourseKnowledgeRelaType = strIdCaseCourseKnowledgeRelaType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseCourseKnowledgeRelaType");
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
if (strAttributeName  ==  conCaseCourseKnowledgeRelaType.IdCaseCourseKnowledgeRelaType)
{
return mstrIdCaseCourseKnowledgeRelaType;
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID)
{
return mstrCaseCourseKnowledgeRelaTypeID;
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName)
{
return mstrCaseCourseKnowledgeRelaTypeName;
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRelaType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCaseCourseKnowledgeRelaType.IdCaseCourseKnowledgeRelaType)
{
mstrIdCaseCourseKnowledgeRelaType = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRelaType.IdCaseCourseKnowledgeRelaType);
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID)
{
mstrCaseCourseKnowledgeRelaTypeID = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID);
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName)
{
mstrCaseCourseKnowledgeRelaTypeName = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName);
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRelaType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRelaType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCaseCourseKnowledgeRelaType.IdCaseCourseKnowledgeRelaType  ==  AttributeName[intIndex])
{
return mstrIdCaseCourseKnowledgeRelaType;
}
else if (conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID  ==  AttributeName[intIndex])
{
return mstrCaseCourseKnowledgeRelaTypeID;
}
else if (conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName  ==  AttributeName[intIndex])
{
return mstrCaseCourseKnowledgeRelaTypeName;
}
else if (conCaseCourseKnowledgeRelaType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCaseCourseKnowledgeRelaType.IdCaseCourseKnowledgeRelaType  ==  AttributeName[intIndex])
{
mstrIdCaseCourseKnowledgeRelaType = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRelaType.IdCaseCourseKnowledgeRelaType);
}
else if (conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID  ==  AttributeName[intIndex])
{
mstrCaseCourseKnowledgeRelaTypeID = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID);
}
else if (conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName  ==  AttributeName[intIndex])
{
mstrCaseCourseKnowledgeRelaTypeName = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName);
}
else if (conCaseCourseKnowledgeRelaType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRelaType.Memo);
}
}
}

/// <summary>
/// 案例知识点关系类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCaseCourseKnowledgeRelaType
{
get
{
return mstrIdCaseCourseKnowledgeRelaType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCaseCourseKnowledgeRelaType = value;
}
else
{
 mstrIdCaseCourseKnowledgeRelaType = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCourseKnowledgeRelaType.IdCaseCourseKnowledgeRelaType);
}
}
/// <summary>
/// 案例题库关系类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseCourseKnowledgeRelaTypeID
{
get
{
return mstrCaseCourseKnowledgeRelaTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseCourseKnowledgeRelaTypeID = value;
}
else
{
 mstrCaseCourseKnowledgeRelaTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID);
}
}
/// <summary>
/// 案例知识点关系类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseCourseKnowledgeRelaTypeName
{
get
{
return mstrCaseCourseKnowledgeRelaTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseCourseKnowledgeRelaTypeName = value;
}
else
{
 mstrCaseCourseKnowledgeRelaTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName);
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
 AddUpdatedFld(conCaseCourseKnowledgeRelaType.Memo);
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
  return mstrIdCaseCourseKnowledgeRelaType;
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
  return mstrCaseCourseKnowledgeRelaTypeName;
 }
 }
}
 /// <summary>
 /// 案例知识点关系类型(CaseCourseKnowledgeRelaType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCaseCourseKnowledgeRelaType
{
public const string _CurrTabName = "CaseCourseKnowledgeRelaType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCaseCourseKnowledgeRelaType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCaseCourseKnowledgeRelaType", "CaseCourseKnowledgeRelaTypeID", "CaseCourseKnowledgeRelaTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCaseCourseKnowledgeRelaType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseCourseKnowledgeRelaType = "IdCaseCourseKnowledgeRelaType";    //案例知识点关系类型流水号

 /// <summary>
 /// 常量:"CaseCourseKnowledgeRelaTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseCourseKnowledgeRelaTypeID = "CaseCourseKnowledgeRelaTypeID";    //案例题库关系类型ID

 /// <summary>
 /// 常量:"CaseCourseKnowledgeRelaTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseCourseKnowledgeRelaTypeName = "CaseCourseKnowledgeRelaTypeName";    //案例知识点关系类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}