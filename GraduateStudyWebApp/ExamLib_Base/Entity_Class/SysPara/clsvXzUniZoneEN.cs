
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzUniZoneEN
 表名:vXzUniZone(01120332)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表vXzUniZone的关键字(IdUniZone)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdUniZone_vXzUniZone
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdUniZone">表关键字</param>
public K_IdUniZone_vXzUniZone(string strIdUniZone)
{
if (IsValid(strIdUniZone)) Value = strIdUniZone;
else
{
Value = null;
}
}
private static bool IsValid(string strIdUniZone)
{
if (string.IsNullOrEmpty(strIdUniZone) == true) return false;
if (strIdUniZone.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdUniZone_vXzUniZone]类型的对象</returns>
public static implicit operator K_IdUniZone_vXzUniZone(string value)
{
return new K_IdUniZone_vXzUniZone(value);
}
}
 /// <summary>
 /// v校区(vXzUniZone)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvXzUniZoneEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vXzUniZone"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdUniZone"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"IdUniZone", "UniZoneID", "UniZoneDesc", "UniZoneDescA", "IdSchool", "SchoolId", "SchoolName", "SchoolNameA", "IdUni", "ModifyDate", "ModifyUserId", "Memo"};

protected string mstrIdUniZone;    //校区流水号
protected string mstrUniZoneID;    //校区编号
protected string mstrUniZoneDesc;    //校区名称
protected string mstrUniZoneDescA;    //UniZoneDescA
protected string mstrIdSchool;    //学校流水号
protected string mstrSchoolId;    //学校编号
protected string mstrSchoolName;    //学校名称
protected string mstrSchoolNameA;    //学校简称
protected string mstrIdUni;    //id_Uni
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvXzUniZoneEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdUniZone");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdUniZone">关键字:校区流水号</param>
public clsvXzUniZoneEN(string strIdUniZone)
 {
strIdUniZone = strIdUniZone.Replace("'", "''");
if (strIdUniZone.Length > 4)
{
throw new Exception("在表:vXzUniZone中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdUniZone)  ==  true)
{
throw new Exception("在表:vXzUniZone中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdUniZone);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdUniZone = strIdUniZone;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdUniZone");
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
if (strAttributeName  ==  convXzUniZone.IdUniZone)
{
return mstrIdUniZone;
}
else if (strAttributeName  ==  convXzUniZone.UniZoneID)
{
return mstrUniZoneID;
}
else if (strAttributeName  ==  convXzUniZone.UniZoneDesc)
{
return mstrUniZoneDesc;
}
else if (strAttributeName  ==  convXzUniZone.UniZoneDescA)
{
return mstrUniZoneDescA;
}
else if (strAttributeName  ==  convXzUniZone.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  convXzUniZone.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  convXzUniZone.SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  convXzUniZone.SchoolNameA)
{
return mstrSchoolNameA;
}
else if (strAttributeName  ==  convXzUniZone.IdUni)
{
return mstrIdUni;
}
else if (strAttributeName  ==  convXzUniZone.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  convXzUniZone.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  convXzUniZone.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convXzUniZone.IdUniZone)
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(convXzUniZone.IdUniZone);
}
else if (strAttributeName  ==  convXzUniZone.UniZoneID)
{
mstrUniZoneID = value.ToString();
 AddUpdatedFld(convXzUniZone.UniZoneID);
}
else if (strAttributeName  ==  convXzUniZone.UniZoneDesc)
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convXzUniZone.UniZoneDesc);
}
else if (strAttributeName  ==  convXzUniZone.UniZoneDescA)
{
mstrUniZoneDescA = value.ToString();
 AddUpdatedFld(convXzUniZone.UniZoneDescA);
}
else if (strAttributeName  ==  convXzUniZone.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convXzUniZone.IdSchool);
}
else if (strAttributeName  ==  convXzUniZone.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convXzUniZone.SchoolId);
}
else if (strAttributeName  ==  convXzUniZone.SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convXzUniZone.SchoolName);
}
else if (strAttributeName  ==  convXzUniZone.SchoolNameA)
{
mstrSchoolNameA = value.ToString();
 AddUpdatedFld(convXzUniZone.SchoolNameA);
}
else if (strAttributeName  ==  convXzUniZone.IdUni)
{
mstrIdUni = value.ToString();
 AddUpdatedFld(convXzUniZone.IdUni);
}
else if (strAttributeName  ==  convXzUniZone.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convXzUniZone.ModifyDate);
}
else if (strAttributeName  ==  convXzUniZone.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convXzUniZone.ModifyUserId);
}
else if (strAttributeName  ==  convXzUniZone.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzUniZone.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convXzUniZone.IdUniZone  ==  AttributeName[intIndex])
{
return mstrIdUniZone;
}
else if (convXzUniZone.UniZoneID  ==  AttributeName[intIndex])
{
return mstrUniZoneID;
}
else if (convXzUniZone.UniZoneDesc  ==  AttributeName[intIndex])
{
return mstrUniZoneDesc;
}
else if (convXzUniZone.UniZoneDescA  ==  AttributeName[intIndex])
{
return mstrUniZoneDescA;
}
else if (convXzUniZone.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (convXzUniZone.SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (convXzUniZone.SchoolName  ==  AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (convXzUniZone.SchoolNameA  ==  AttributeName[intIndex])
{
return mstrSchoolNameA;
}
else if (convXzUniZone.IdUni  ==  AttributeName[intIndex])
{
return mstrIdUni;
}
else if (convXzUniZone.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (convXzUniZone.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (convXzUniZone.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convXzUniZone.IdUniZone  ==  AttributeName[intIndex])
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(convXzUniZone.IdUniZone);
}
else if (convXzUniZone.UniZoneID  ==  AttributeName[intIndex])
{
mstrUniZoneID = value.ToString();
 AddUpdatedFld(convXzUniZone.UniZoneID);
}
else if (convXzUniZone.UniZoneDesc  ==  AttributeName[intIndex])
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convXzUniZone.UniZoneDesc);
}
else if (convXzUniZone.UniZoneDescA  ==  AttributeName[intIndex])
{
mstrUniZoneDescA = value.ToString();
 AddUpdatedFld(convXzUniZone.UniZoneDescA);
}
else if (convXzUniZone.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convXzUniZone.IdSchool);
}
else if (convXzUniZone.SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convXzUniZone.SchoolId);
}
else if (convXzUniZone.SchoolName  ==  AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convXzUniZone.SchoolName);
}
else if (convXzUniZone.SchoolNameA  ==  AttributeName[intIndex])
{
mstrSchoolNameA = value.ToString();
 AddUpdatedFld(convXzUniZone.SchoolNameA);
}
else if (convXzUniZone.IdUni  ==  AttributeName[intIndex])
{
mstrIdUni = value.ToString();
 AddUpdatedFld(convXzUniZone.IdUni);
}
else if (convXzUniZone.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convXzUniZone.ModifyDate);
}
else if (convXzUniZone.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convXzUniZone.ModifyUserId);
}
else if (convXzUniZone.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzUniZone.Memo);
}
}
}

/// <summary>
/// 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdUniZone
{
get
{
return mstrIdUniZone;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdUniZone = value;
}
else
{
 mstrIdUniZone = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzUniZone.IdUniZone);
}
}
/// <summary>
/// 校区编号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UniZoneID
{
get
{
return mstrUniZoneID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUniZoneID = value;
}
else
{
 mstrUniZoneID = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzUniZone.UniZoneID);
}
}
/// <summary>
/// 校区名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UniZoneDesc
{
get
{
return mstrUniZoneDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUniZoneDesc = value;
}
else
{
 mstrUniZoneDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzUniZone.UniZoneDesc);
}
}
/// <summary>
/// UniZoneDescA(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UniZoneDescA
{
get
{
return mstrUniZoneDescA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUniZoneDescA = value;
}
else
{
 mstrUniZoneDescA = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzUniZone.UniZoneDescA);
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
 AddUpdatedFld(convXzUniZone.IdSchool);
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
 AddUpdatedFld(convXzUniZone.SchoolId);
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
 AddUpdatedFld(convXzUniZone.SchoolName);
}
}
/// <summary>
/// 学校简称(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolNameA
{
get
{
return mstrSchoolNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolNameA = value;
}
else
{
 mstrSchoolNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzUniZone.SchoolNameA);
}
}
/// <summary>
/// id_Uni(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdUni
{
get
{
return mstrIdUni;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdUni = value;
}
else
{
 mstrIdUni = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzUniZone.IdUni);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzUniZone.ModifyDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserId
{
get
{
return mstrModifyUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserId = value;
}
else
{
 mstrModifyUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzUniZone.ModifyUserId);
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
 AddUpdatedFld(convXzUniZone.Memo);
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
  return mstrIdUniZone;
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
  return mstrUniZoneDesc;
 }
 }
}
 /// <summary>
 /// v校区(vXzUniZone)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convXzUniZone
{
public const string _CurrTabName = "vXzUniZone"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdUniZone"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdUniZone", "UniZoneID", "UniZoneDesc", "UniZoneDescA", "IdSchool", "SchoolId", "SchoolName", "SchoolNameA", "IdUni", "ModifyDate", "ModifyUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdUniZone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdUniZone = "IdUniZone";    //校区流水号

 /// <summary>
 /// 常量:"UniZoneID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UniZoneID = "UniZoneID";    //校区编号

 /// <summary>
 /// 常量:"UniZoneDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UniZoneDesc = "UniZoneDesc";    //校区名称

 /// <summary>
 /// 常量:"UniZoneDescA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UniZoneDescA = "UniZoneDescA";    //UniZoneDescA

 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

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

 /// <summary>
 /// 常量:"SchoolNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolNameA = "SchoolNameA";    //学校简称

 /// <summary>
 /// 常量:"IdUni"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdUni = "IdUni";    //id_Uni

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}