
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsModuleTabRelaEN
 表名:ModuleTabRela(01120363)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:11
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 表ModuleTabRela的关键字(FuncModuleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncModuleId_ModuleTabRela
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFuncModuleId">表关键字</param>
public K_FuncModuleId_ModuleTabRela(string strFuncModuleId)
{
if (IsValid(strFuncModuleId)) Value = strFuncModuleId;
else
{
Value = null;
}
}
private static bool IsValid(string strFuncModuleId)
{
if (string.IsNullOrEmpty(strFuncModuleId) == true) return false;
if (strFuncModuleId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FuncModuleId_ModuleTabRela]类型的对象</returns>
public static implicit operator K_FuncModuleId_ModuleTabRela(string value)
{
return new K_FuncModuleId_ModuleTabRela(value);
}
}
 /// <summary>
 /// 模块表关系(ModuleTabRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsModuleTabRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ModuleTabRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncModuleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"FuncModuleId", "CollegeTab", "MajorTab", "UpdDate", "UpdUserId", "Memo"};

protected string mstrFuncModuleId;    //功能模块Id
protected string mstrCollegeTab;    //学院表
protected string mstrMajorTab;    //专业表
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsModuleTabRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncModuleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strFuncModuleId">关键字:功能模块Id</param>
public clsModuleTabRelaEN(string strFuncModuleId)
 {
strFuncModuleId = strFuncModuleId.Replace("'", "''");
if (strFuncModuleId.Length > 4)
{
throw new Exception("在表:ModuleTabRela中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncModuleId)  ==  true)
{
throw new Exception("在表:ModuleTabRela中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncModuleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFuncModuleId = strFuncModuleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncModuleId");
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
if (strAttributeName  ==  conModuleTabRela.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conModuleTabRela.CollegeTab)
{
return mstrCollegeTab;
}
else if (strAttributeName  ==  conModuleTabRela.MajorTab)
{
return mstrMajorTab;
}
else if (strAttributeName  ==  conModuleTabRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conModuleTabRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conModuleTabRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conModuleTabRela.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conModuleTabRela.FuncModuleId);
}
else if (strAttributeName  ==  conModuleTabRela.CollegeTab)
{
mstrCollegeTab = value.ToString();
 AddUpdatedFld(conModuleTabRela.CollegeTab);
}
else if (strAttributeName  ==  conModuleTabRela.MajorTab)
{
mstrMajorTab = value.ToString();
 AddUpdatedFld(conModuleTabRela.MajorTab);
}
else if (strAttributeName  ==  conModuleTabRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conModuleTabRela.UpdDate);
}
else if (strAttributeName  ==  conModuleTabRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conModuleTabRela.UpdUserId);
}
else if (strAttributeName  ==  conModuleTabRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conModuleTabRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conModuleTabRela.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conModuleTabRela.CollegeTab  ==  AttributeName[intIndex])
{
return mstrCollegeTab;
}
else if (conModuleTabRela.MajorTab  ==  AttributeName[intIndex])
{
return mstrMajorTab;
}
else if (conModuleTabRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conModuleTabRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conModuleTabRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conModuleTabRela.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conModuleTabRela.FuncModuleId);
}
else if (conModuleTabRela.CollegeTab  ==  AttributeName[intIndex])
{
mstrCollegeTab = value.ToString();
 AddUpdatedFld(conModuleTabRela.CollegeTab);
}
else if (conModuleTabRela.MajorTab  ==  AttributeName[intIndex])
{
mstrMajorTab = value.ToString();
 AddUpdatedFld(conModuleTabRela.MajorTab);
}
else if (conModuleTabRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conModuleTabRela.UpdDate);
}
else if (conModuleTabRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conModuleTabRela.UpdUserId);
}
else if (conModuleTabRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conModuleTabRela.Memo);
}
}
}

/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conModuleTabRela.FuncModuleId);
}
}
/// <summary>
/// 学院表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeTab
{
get
{
return mstrCollegeTab;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeTab = value;
}
else
{
 mstrCollegeTab = value;
}
//记录修改过的字段
 AddUpdatedFld(conModuleTabRela.CollegeTab);
}
}
/// <summary>
/// 专业表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorTab
{
get
{
return mstrMajorTab;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorTab = value;
}
else
{
 mstrMajorTab = value;
}
//记录修改过的字段
 AddUpdatedFld(conModuleTabRela.MajorTab);
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
 AddUpdatedFld(conModuleTabRela.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conModuleTabRela.UpdUserId);
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
 AddUpdatedFld(conModuleTabRela.Memo);
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
  return mstrFuncModuleId;
 }
 }
}
 /// <summary>
 /// 模块表关系(ModuleTabRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conModuleTabRela
{
public const string _CurrTabName = "ModuleTabRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncModuleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FuncModuleId", "CollegeTab", "MajorTab", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"CollegeTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeTab = "CollegeTab";    //学院表

 /// <summary>
 /// 常量:"MajorTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorTab = "MajorTab";    //专业表

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}