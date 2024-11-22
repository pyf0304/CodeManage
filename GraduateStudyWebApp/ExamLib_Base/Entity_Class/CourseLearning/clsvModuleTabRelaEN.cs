
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvModuleTabRelaEN
 表名:vModuleTabRela(01120364)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:05
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
 /// 表vModuleTabRela的关键字(FuncModuleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncModuleId_vModuleTabRela
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
public K_FuncModuleId_vModuleTabRela(string strFuncModuleId)
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
 /// <returns>返回:[K_FuncModuleId_vModuleTabRela]类型的对象</returns>
public static implicit operator K_FuncModuleId_vModuleTabRela(string value)
{
return new K_FuncModuleId_vModuleTabRela(value);
}
}
 /// <summary>
 /// v模块表关系(vModuleTabRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvModuleTabRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vModuleTabRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncModuleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "OrderNum", "CollegeTab", "MajorTab", "UpdDate", "UpdUserId", "Memo"};

protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleNameSim;    //功能模块简称
protected int? mintOrderNum;    //序号
protected string mstrCollegeTab;    //学院表
protected string mstrMajorTab;    //专业表
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvModuleTabRelaEN()
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
public clsvModuleTabRelaEN(string strFuncModuleId)
 {
strFuncModuleId = strFuncModuleId.Replace("'", "''");
if (strFuncModuleId.Length > 4)
{
throw new Exception("在表:vModuleTabRela中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncModuleId)  ==  true)
{
throw new Exception("在表:vModuleTabRela中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convModuleTabRela.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convModuleTabRela.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convModuleTabRela.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convModuleTabRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convModuleTabRela.CollegeTab)
{
return mstrCollegeTab;
}
else if (strAttributeName  ==  convModuleTabRela.MajorTab)
{
return mstrMajorTab;
}
else if (strAttributeName  ==  convModuleTabRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convModuleTabRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convModuleTabRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convModuleTabRela.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convModuleTabRela.FuncModuleId);
}
else if (strAttributeName  ==  convModuleTabRela.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convModuleTabRela.FuncModuleName);
}
else if (strAttributeName  ==  convModuleTabRela.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convModuleTabRela.FuncModuleNameSim);
}
else if (strAttributeName  ==  convModuleTabRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convModuleTabRela.OrderNum);
}
else if (strAttributeName  ==  convModuleTabRela.CollegeTab)
{
mstrCollegeTab = value.ToString();
 AddUpdatedFld(convModuleTabRela.CollegeTab);
}
else if (strAttributeName  ==  convModuleTabRela.MajorTab)
{
mstrMajorTab = value.ToString();
 AddUpdatedFld(convModuleTabRela.MajorTab);
}
else if (strAttributeName  ==  convModuleTabRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convModuleTabRela.UpdDate);
}
else if (strAttributeName  ==  convModuleTabRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convModuleTabRela.UpdUserId);
}
else if (strAttributeName  ==  convModuleTabRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convModuleTabRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convModuleTabRela.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convModuleTabRela.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convModuleTabRela.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convModuleTabRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convModuleTabRela.CollegeTab  ==  AttributeName[intIndex])
{
return mstrCollegeTab;
}
else if (convModuleTabRela.MajorTab  ==  AttributeName[intIndex])
{
return mstrMajorTab;
}
else if (convModuleTabRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convModuleTabRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convModuleTabRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convModuleTabRela.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convModuleTabRela.FuncModuleId);
}
else if (convModuleTabRela.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convModuleTabRela.FuncModuleName);
}
else if (convModuleTabRela.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convModuleTabRela.FuncModuleNameSim);
}
else if (convModuleTabRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convModuleTabRela.OrderNum);
}
else if (convModuleTabRela.CollegeTab  ==  AttributeName[intIndex])
{
mstrCollegeTab = value.ToString();
 AddUpdatedFld(convModuleTabRela.CollegeTab);
}
else if (convModuleTabRela.MajorTab  ==  AttributeName[intIndex])
{
mstrMajorTab = value.ToString();
 AddUpdatedFld(convModuleTabRela.MajorTab);
}
else if (convModuleTabRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convModuleTabRela.UpdDate);
}
else if (convModuleTabRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convModuleTabRela.UpdUserId);
}
else if (convModuleTabRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convModuleTabRela.Memo);
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
 AddUpdatedFld(convModuleTabRela.FuncModuleId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convModuleTabRela.FuncModuleName);
}
}
/// <summary>
/// 功能模块简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleNameSim
{
get
{
return mstrFuncModuleNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleNameSim = value;
}
else
{
 mstrFuncModuleNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convModuleTabRela.FuncModuleNameSim);
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
 AddUpdatedFld(convModuleTabRela.OrderNum);
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
 AddUpdatedFld(convModuleTabRela.CollegeTab);
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
 AddUpdatedFld(convModuleTabRela.MajorTab);
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
 AddUpdatedFld(convModuleTabRela.UpdDate);
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
 AddUpdatedFld(convModuleTabRela.UpdUserId);
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
 AddUpdatedFld(convModuleTabRela.Memo);
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
 /// v模块表关系(vModuleTabRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convModuleTabRela
{
public const string _CurrTabName = "vModuleTabRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncModuleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "OrderNum", "CollegeTab", "MajorTab", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"FuncModuleNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleNameSim = "FuncModuleNameSim";    //功能模块简称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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