
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_KnowledgeModulesEN
 表名:cc_KnowledgeModules(01120959)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:28
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
 /// 表cc_KnowledgeModules的关键字(KnowledgeModuleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_KnowledgeModuleId_cc_KnowledgeModules
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strKnowledgeModuleId">表关键字</param>
public K_KnowledgeModuleId_cc_KnowledgeModules(string strKnowledgeModuleId)
{
if (IsValid(strKnowledgeModuleId)) Value = strKnowledgeModuleId;
else
{
Value = null;
}
}
private static bool IsValid(string strKnowledgeModuleId)
{
if (string.IsNullOrEmpty(strKnowledgeModuleId) == true) return false;
if (strKnowledgeModuleId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_KnowledgeModuleId_cc_KnowledgeModules]类型的对象</returns>
public static implicit operator K_KnowledgeModuleId_cc_KnowledgeModules(string value)
{
return new K_KnowledgeModuleId_cc_KnowledgeModules(value);
}
}
 /// <summary>
 /// 知识点模块(cc_KnowledgeModules)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_KnowledgeModulesEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_KnowledgeModules"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "KnowledgeModuleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"KnowledgeModuleId", "KnowledgeModuleName", "KnowledgeModuleContent", "CourseId", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected string mstrKnowledgeModuleId;    //知识点模块Id
protected string mstrKnowledgeModuleName;    //知识点模块名称
protected string mstrKnowledgeModuleContent;    //知识点模块内容
protected string mstrCourseId;    //课程Id
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_KnowledgeModulesEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("KnowledgeModuleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strKnowledgeModuleId">关键字:知识点模块Id</param>
public clscc_KnowledgeModulesEN(string strKnowledgeModuleId)
 {
strKnowledgeModuleId = strKnowledgeModuleId.Replace("'", "''");
if (strKnowledgeModuleId.Length > 8)
{
throw new Exception("在表:cc_KnowledgeModules中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strKnowledgeModuleId)  ==  true)
{
throw new Exception("在表:cc_KnowledgeModules中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strKnowledgeModuleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrKnowledgeModuleId = strKnowledgeModuleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("KnowledgeModuleId");
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
if (strAttributeName  ==  concc_KnowledgeModules.KnowledgeModuleId)
{
return mstrKnowledgeModuleId;
}
else if (strAttributeName  ==  concc_KnowledgeModules.KnowledgeModuleName)
{
return mstrKnowledgeModuleName;
}
else if (strAttributeName  ==  concc_KnowledgeModules.KnowledgeModuleContent)
{
return mstrKnowledgeModuleContent;
}
else if (strAttributeName  ==  concc_KnowledgeModules.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_KnowledgeModules.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  concc_KnowledgeModules.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_KnowledgeModules.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  concc_KnowledgeModules.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_KnowledgeModules.KnowledgeModuleId)
{
mstrKnowledgeModuleId = value.ToString();
 AddUpdatedFld(concc_KnowledgeModules.KnowledgeModuleId);
}
else if (strAttributeName  ==  concc_KnowledgeModules.KnowledgeModuleName)
{
mstrKnowledgeModuleName = value.ToString();
 AddUpdatedFld(concc_KnowledgeModules.KnowledgeModuleName);
}
else if (strAttributeName  ==  concc_KnowledgeModules.KnowledgeModuleContent)
{
mstrKnowledgeModuleContent = value.ToString();
 AddUpdatedFld(concc_KnowledgeModules.KnowledgeModuleContent);
}
else if (strAttributeName  ==  concc_KnowledgeModules.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_KnowledgeModules.CourseId);
}
else if (strAttributeName  ==  concc_KnowledgeModules.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_KnowledgeModules.OrderNum);
}
else if (strAttributeName  ==  concc_KnowledgeModules.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_KnowledgeModules.UpdDate);
}
else if (strAttributeName  ==  concc_KnowledgeModules.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concc_KnowledgeModules.UpdUser);
}
else if (strAttributeName  ==  concc_KnowledgeModules.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_KnowledgeModules.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_KnowledgeModules.KnowledgeModuleId  ==  AttributeName[intIndex])
{
return mstrKnowledgeModuleId;
}
else if (concc_KnowledgeModules.KnowledgeModuleName  ==  AttributeName[intIndex])
{
return mstrKnowledgeModuleName;
}
else if (concc_KnowledgeModules.KnowledgeModuleContent  ==  AttributeName[intIndex])
{
return mstrKnowledgeModuleContent;
}
else if (concc_KnowledgeModules.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_KnowledgeModules.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (concc_KnowledgeModules.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_KnowledgeModules.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (concc_KnowledgeModules.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_KnowledgeModules.KnowledgeModuleId  ==  AttributeName[intIndex])
{
mstrKnowledgeModuleId = value.ToString();
 AddUpdatedFld(concc_KnowledgeModules.KnowledgeModuleId);
}
else if (concc_KnowledgeModules.KnowledgeModuleName  ==  AttributeName[intIndex])
{
mstrKnowledgeModuleName = value.ToString();
 AddUpdatedFld(concc_KnowledgeModules.KnowledgeModuleName);
}
else if (concc_KnowledgeModules.KnowledgeModuleContent  ==  AttributeName[intIndex])
{
mstrKnowledgeModuleContent = value.ToString();
 AddUpdatedFld(concc_KnowledgeModules.KnowledgeModuleContent);
}
else if (concc_KnowledgeModules.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_KnowledgeModules.CourseId);
}
else if (concc_KnowledgeModules.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_KnowledgeModules.OrderNum);
}
else if (concc_KnowledgeModules.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_KnowledgeModules.UpdDate);
}
else if (concc_KnowledgeModules.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concc_KnowledgeModules.UpdUser);
}
else if (concc_KnowledgeModules.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_KnowledgeModules.Memo);
}
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
 AddUpdatedFld(concc_KnowledgeModules.KnowledgeModuleId);
}
}
/// <summary>
/// 知识点模块名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeModuleName
{
get
{
return mstrKnowledgeModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeModuleName = value;
}
else
{
 mstrKnowledgeModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_KnowledgeModules.KnowledgeModuleName);
}
}
/// <summary>
/// 知识点模块内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeModuleContent
{
get
{
return mstrKnowledgeModuleContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeModuleContent = value;
}
else
{
 mstrKnowledgeModuleContent = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_KnowledgeModules.KnowledgeModuleContent);
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
 AddUpdatedFld(concc_KnowledgeModules.CourseId);
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
 AddUpdatedFld(concc_KnowledgeModules.OrderNum);
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
 AddUpdatedFld(concc_KnowledgeModules.UpdDate);
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
 AddUpdatedFld(concc_KnowledgeModules.UpdUser);
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
 AddUpdatedFld(concc_KnowledgeModules.Memo);
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
  return mstrKnowledgeModuleId;
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
  return mstrKnowledgeModuleName;
 }
 }
}
 /// <summary>
 /// 知识点模块(cc_KnowledgeModules)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_KnowledgeModules
{
public const string _CurrTabName = "cc_KnowledgeModules"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "KnowledgeModuleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"KnowledgeModuleId", "KnowledgeModuleName", "KnowledgeModuleContent", "CourseId", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"KnowledgeModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeModuleId = "KnowledgeModuleId";    //知识点模块Id

 /// <summary>
 /// 常量:"KnowledgeModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeModuleName = "KnowledgeModuleName";    //知识点模块名称

 /// <summary>
 /// 常量:"KnowledgeModuleContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeModuleContent = "KnowledgeModuleContent";    //知识点模块内容

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

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