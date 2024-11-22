
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubCaseTypeEN
 表名:vPubCaseType(01120507)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// 表vPubCaseType的关键字(IdPubCaseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubCaseType_vPubCaseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdPubCaseType">表关键字</param>
public K_IdPubCaseType_vPubCaseType(string strIdPubCaseType)
{
if (IsValid(strIdPubCaseType)) Value = strIdPubCaseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdPubCaseType)
{
if (string.IsNullOrEmpty(strIdPubCaseType) == true) return false;
if (strIdPubCaseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPubCaseType_vPubCaseType]类型的对象</returns>
public static implicit operator K_IdPubCaseType_vPubCaseType(string value)
{
return new K_IdPubCaseType_vPubCaseType(value);
}
}
 /// <summary>
 /// v公开课案例类型(vPubCaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPubCaseTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPubCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"IdPubCaseType", "PubCaseTypeID", "PubCaseTypeName", "IdSchool", "Memo", "SchoolId", "SchoolName"};

protected string mstrIdPubCaseType;    //公开课案例类型流水号
protected string mstrPubCaseTypeID;    //公开课案例类型ID
protected string mstrPubCaseTypeName;    //公开课案例类型名称
protected string mstrIdSchool;    //学校流水号
protected string mstrMemo;    //备注
protected string mstrSchoolId;    //学校编号
protected string mstrSchoolName;    //学校名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPubCaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubCaseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdPubCaseType">关键字:公开课案例类型流水号</param>
public clsvPubCaseTypeEN(string strIdPubCaseType)
 {
strIdPubCaseType = strIdPubCaseType.Replace("'", "''");
if (strIdPubCaseType.Length > 4)
{
throw new Exception("在表:vPubCaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdPubCaseType)  ==  true)
{
throw new Exception("在表:vPubCaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdPubCaseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdPubCaseType = strIdPubCaseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubCaseType");
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
if (strAttributeName  ==  convPubCaseType.IdPubCaseType)
{
return mstrIdPubCaseType;
}
else if (strAttributeName  ==  convPubCaseType.PubCaseTypeID)
{
return mstrPubCaseTypeID;
}
else if (strAttributeName  ==  convPubCaseType.PubCaseTypeName)
{
return mstrPubCaseTypeName;
}
else if (strAttributeName  ==  convPubCaseType.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  convPubCaseType.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPubCaseType.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  convPubCaseType.SchoolName)
{
return mstrSchoolName;
}
return null;
}
set
{
if (strAttributeName  ==  convPubCaseType.IdPubCaseType)
{
mstrIdPubCaseType = value.ToString();
 AddUpdatedFld(convPubCaseType.IdPubCaseType);
}
else if (strAttributeName  ==  convPubCaseType.PubCaseTypeID)
{
mstrPubCaseTypeID = value.ToString();
 AddUpdatedFld(convPubCaseType.PubCaseTypeID);
}
else if (strAttributeName  ==  convPubCaseType.PubCaseTypeName)
{
mstrPubCaseTypeName = value.ToString();
 AddUpdatedFld(convPubCaseType.PubCaseTypeName);
}
else if (strAttributeName  ==  convPubCaseType.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convPubCaseType.IdSchool);
}
else if (strAttributeName  ==  convPubCaseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPubCaseType.Memo);
}
else if (strAttributeName  ==  convPubCaseType.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convPubCaseType.SchoolId);
}
else if (strAttributeName  ==  convPubCaseType.SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convPubCaseType.SchoolName);
}
}
}
public object this[int intIndex]
{
get
{
if (convPubCaseType.IdPubCaseType  ==  AttributeName[intIndex])
{
return mstrIdPubCaseType;
}
else if (convPubCaseType.PubCaseTypeID  ==  AttributeName[intIndex])
{
return mstrPubCaseTypeID;
}
else if (convPubCaseType.PubCaseTypeName  ==  AttributeName[intIndex])
{
return mstrPubCaseTypeName;
}
else if (convPubCaseType.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (convPubCaseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPubCaseType.SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (convPubCaseType.SchoolName  ==  AttributeName[intIndex])
{
return mstrSchoolName;
}
return null;
}
set
{
if (convPubCaseType.IdPubCaseType  ==  AttributeName[intIndex])
{
mstrIdPubCaseType = value.ToString();
 AddUpdatedFld(convPubCaseType.IdPubCaseType);
}
else if (convPubCaseType.PubCaseTypeID  ==  AttributeName[intIndex])
{
mstrPubCaseTypeID = value.ToString();
 AddUpdatedFld(convPubCaseType.PubCaseTypeID);
}
else if (convPubCaseType.PubCaseTypeName  ==  AttributeName[intIndex])
{
mstrPubCaseTypeName = value.ToString();
 AddUpdatedFld(convPubCaseType.PubCaseTypeName);
}
else if (convPubCaseType.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convPubCaseType.IdSchool);
}
else if (convPubCaseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPubCaseType.Memo);
}
else if (convPubCaseType.SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convPubCaseType.SchoolId);
}
else if (convPubCaseType.SchoolName  ==  AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convPubCaseType.SchoolName);
}
}
}

/// <summary>
/// 公开课案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubCaseType
{
get
{
return mstrIdPubCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubCaseType = value;
}
else
{
 mstrIdPubCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubCaseType.IdPubCaseType);
}
}
/// <summary>
/// 公开课案例类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubCaseTypeID
{
get
{
return mstrPubCaseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubCaseTypeID = value;
}
else
{
 mstrPubCaseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubCaseType.PubCaseTypeID);
}
}
/// <summary>
/// 公开课案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubCaseTypeName
{
get
{
return mstrPubCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubCaseTypeName = value;
}
else
{
 mstrPubCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubCaseType.PubCaseTypeName);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchool
{
get
{
return mstrIdSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchool = value;
}
else
{
 mstrIdSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubCaseType.IdSchool);
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
 AddUpdatedFld(convPubCaseType.Memo);
}
}
/// <summary>
/// 学校编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolId
{
get
{
return mstrSchoolId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolId = value;
}
else
{
 mstrSchoolId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubCaseType.SchoolId);
}
}
/// <summary>
/// 学校名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolName
{
get
{
return mstrSchoolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolName = value;
}
else
{
 mstrSchoolName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubCaseType.SchoolName);
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
  return mstrIdPubCaseType;
 }
 }
}
 /// <summary>
 /// v公开课案例类型(vPubCaseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPubCaseType
{
public const string _CurrTabName = "vPubCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubCaseType", "PubCaseTypeID", "PubCaseTypeName", "IdSchool", "Memo", "SchoolId", "SchoolName"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPubCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubCaseType = "IdPubCaseType";    //公开课案例类型流水号

 /// <summary>
 /// 常量:"PubCaseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubCaseTypeID = "PubCaseTypeID";    //公开课案例类型ID

 /// <summary>
 /// 常量:"PubCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubCaseTypeName = "PubCaseTypeName";    //公开课案例类型名称

 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"SchoolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolId = "SchoolId";    //学校编号

 /// <summary>
 /// 常量:"SchoolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolName = "SchoolName";    //学校名称
}

}