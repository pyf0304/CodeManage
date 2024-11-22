
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzMajorEN
 表名:vXzMajor(01120066)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:12
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
 /// 表vXzMajor的关键字(IdXzMajor)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdXzMajor_vXzMajor
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdXzMajor">表关键字</param>
public K_IdXzMajor_vXzMajor(string strIdXzMajor)
{
if (IsValid(strIdXzMajor)) Value = strIdXzMajor;
else
{
Value = null;
}
}
private static bool IsValid(string strIdXzMajor)
{
if (string.IsNullOrEmpty(strIdXzMajor) == true) return false;
if (strIdXzMajor.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdXzMajor_vXzMajor]类型的对象</returns>
public static implicit operator K_IdXzMajor_vXzMajor(string value)
{
return new K_IdXzMajor_vXzMajor(value);
}
}
 /// <summary>
 /// v专业(vXzMajor)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvXzMajorEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vXzMajor"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdXzMajor"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 24;
public static string[] AttributeName = new string[] {"IdXzMajor", "MajorID", "MajorName", "MajorEnglishName", "MajorExplain", "MajorNationalID", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "IdMajorType", "MajorTypeName", "IdDegreeType", "XwTypeDesc", "IsMainMajor", "MajorDirection", "IsVisible", "IsNormal", "ModifyDate", "ModifyUserId", "Memo", "IsVisible4XzClg", "TypeName", "IdXzMajorShoolType"};

protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称
protected string mstrMajorEnglishName;    //专业英文名称
protected string mstrMajorExplain;    //专业说明
protected string mstrMajorNationalID;    //专业国家代码
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeId;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdMajorType;    //专业类型(文理工)流水号
protected string mstrMajorTypeName;    //专业类型名称
protected string mstrIdDegreeType;    //学位类型流水号
protected string mstrXwTypeDesc;    //学位类型名称
protected bool mbolIsMainMajor;    //是否重要专业
protected string mstrMajorDirection;    //专业方向
protected bool mbolIsVisible;    //是否显示
protected bool mbolIsNormal;    //IsNormal
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人
protected string mstrMemo;    //备注
protected bool mbolIsVisible4XzClg;    //IsVisible4XzClg
protected string mstrTypeName;    //类型名称
protected string mstrIdXzMajorShoolType;    //专业学校类型流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvXzMajorEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdXzMajor");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdXzMajor">关键字:专业流水号</param>
public clsvXzMajorEN(string strIdXzMajor)
 {
strIdXzMajor = strIdXzMajor.Replace("'", "''");
if (strIdXzMajor.Length > 8)
{
throw new Exception("在表:vXzMajor中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdXzMajor)  ==  true)
{
throw new Exception("在表:vXzMajor中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdXzMajor);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdXzMajor = strIdXzMajor;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdXzMajor");
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
if (strAttributeName  ==  convXzMajor.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convXzMajor.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convXzMajor.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convXzMajor.MajorEnglishName)
{
return mstrMajorEnglishName;
}
else if (strAttributeName  ==  convXzMajor.MajorExplain)
{
return mstrMajorExplain;
}
else if (strAttributeName  ==  convXzMajor.MajorNationalID)
{
return mstrMajorNationalID;
}
else if (strAttributeName  ==  convXzMajor.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convXzMajor.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convXzMajor.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convXzMajor.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convXzMajor.IdMajorType)
{
return mstrIdMajorType;
}
else if (strAttributeName  ==  convXzMajor.MajorTypeName)
{
return mstrMajorTypeName;
}
else if (strAttributeName  ==  convXzMajor.IdDegreeType)
{
return mstrIdDegreeType;
}
else if (strAttributeName  ==  convXzMajor.XwTypeDesc)
{
return mstrXwTypeDesc;
}
else if (strAttributeName  ==  convXzMajor.IsMainMajor)
{
return mbolIsMainMajor;
}
else if (strAttributeName  ==  convXzMajor.MajorDirection)
{
return mstrMajorDirection;
}
else if (strAttributeName  ==  convXzMajor.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convXzMajor.IsNormal)
{
return mbolIsNormal;
}
else if (strAttributeName  ==  convXzMajor.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  convXzMajor.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  convXzMajor.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convXzMajor.IsVisible4XzClg)
{
return mbolIsVisible4XzClg;
}
else if (strAttributeName  ==  convXzMajor.TypeName)
{
return mstrTypeName;
}
else if (strAttributeName  ==  convXzMajor.IdXzMajorShoolType)
{
return mstrIdXzMajorShoolType;
}
return null;
}
set
{
if (strAttributeName  ==  convXzMajor.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convXzMajor.IdXzMajor);
}
else if (strAttributeName  ==  convXzMajor.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convXzMajor.MajorID);
}
else if (strAttributeName  ==  convXzMajor.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convXzMajor.MajorName);
}
else if (strAttributeName  ==  convXzMajor.MajorEnglishName)
{
mstrMajorEnglishName = value.ToString();
 AddUpdatedFld(convXzMajor.MajorEnglishName);
}
else if (strAttributeName  ==  convXzMajor.MajorExplain)
{
mstrMajorExplain = value.ToString();
 AddUpdatedFld(convXzMajor.MajorExplain);
}
else if (strAttributeName  ==  convXzMajor.MajorNationalID)
{
mstrMajorNationalID = value.ToString();
 AddUpdatedFld(convXzMajor.MajorNationalID);
}
else if (strAttributeName  ==  convXzMajor.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convXzMajor.IdXzCollege);
}
else if (strAttributeName  ==  convXzMajor.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convXzMajor.CollegeId);
}
else if (strAttributeName  ==  convXzMajor.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convXzMajor.CollegeName);
}
else if (strAttributeName  ==  convXzMajor.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convXzMajor.CollegeNameA);
}
else if (strAttributeName  ==  convXzMajor.IdMajorType)
{
mstrIdMajorType = value.ToString();
 AddUpdatedFld(convXzMajor.IdMajorType);
}
else if (strAttributeName  ==  convXzMajor.MajorTypeName)
{
mstrMajorTypeName = value.ToString();
 AddUpdatedFld(convXzMajor.MajorTypeName);
}
else if (strAttributeName  ==  convXzMajor.IdDegreeType)
{
mstrIdDegreeType = value.ToString();
 AddUpdatedFld(convXzMajor.IdDegreeType);
}
else if (strAttributeName  ==  convXzMajor.XwTypeDesc)
{
mstrXwTypeDesc = value.ToString();
 AddUpdatedFld(convXzMajor.XwTypeDesc);
}
else if (strAttributeName  ==  convXzMajor.IsMainMajor)
{
mbolIsMainMajor = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzMajor.IsMainMajor);
}
else if (strAttributeName  ==  convXzMajor.MajorDirection)
{
mstrMajorDirection = value.ToString();
 AddUpdatedFld(convXzMajor.MajorDirection);
}
else if (strAttributeName  ==  convXzMajor.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzMajor.IsVisible);
}
else if (strAttributeName  ==  convXzMajor.IsNormal)
{
mbolIsNormal = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzMajor.IsNormal);
}
else if (strAttributeName  ==  convXzMajor.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convXzMajor.ModifyDate);
}
else if (strAttributeName  ==  convXzMajor.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convXzMajor.ModifyUserId);
}
else if (strAttributeName  ==  convXzMajor.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzMajor.Memo);
}
else if (strAttributeName  ==  convXzMajor.IsVisible4XzClg)
{
mbolIsVisible4XzClg = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzMajor.IsVisible4XzClg);
}
else if (strAttributeName  ==  convXzMajor.TypeName)
{
mstrTypeName = value.ToString();
 AddUpdatedFld(convXzMajor.TypeName);
}
else if (strAttributeName  ==  convXzMajor.IdXzMajorShoolType)
{
mstrIdXzMajorShoolType = value.ToString();
 AddUpdatedFld(convXzMajor.IdXzMajorShoolType);
}
}
}
public object this[int intIndex]
{
get
{
if (convXzMajor.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convXzMajor.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convXzMajor.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convXzMajor.MajorEnglishName  ==  AttributeName[intIndex])
{
return mstrMajorEnglishName;
}
else if (convXzMajor.MajorExplain  ==  AttributeName[intIndex])
{
return mstrMajorExplain;
}
else if (convXzMajor.MajorNationalID  ==  AttributeName[intIndex])
{
return mstrMajorNationalID;
}
else if (convXzMajor.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convXzMajor.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convXzMajor.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convXzMajor.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convXzMajor.IdMajorType  ==  AttributeName[intIndex])
{
return mstrIdMajorType;
}
else if (convXzMajor.MajorTypeName  ==  AttributeName[intIndex])
{
return mstrMajorTypeName;
}
else if (convXzMajor.IdDegreeType  ==  AttributeName[intIndex])
{
return mstrIdDegreeType;
}
else if (convXzMajor.XwTypeDesc  ==  AttributeName[intIndex])
{
return mstrXwTypeDesc;
}
else if (convXzMajor.IsMainMajor  ==  AttributeName[intIndex])
{
return mbolIsMainMajor;
}
else if (convXzMajor.MajorDirection  ==  AttributeName[intIndex])
{
return mstrMajorDirection;
}
else if (convXzMajor.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convXzMajor.IsNormal  ==  AttributeName[intIndex])
{
return mbolIsNormal;
}
else if (convXzMajor.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (convXzMajor.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (convXzMajor.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convXzMajor.IsVisible4XzClg  ==  AttributeName[intIndex])
{
return mbolIsVisible4XzClg;
}
else if (convXzMajor.TypeName  ==  AttributeName[intIndex])
{
return mstrTypeName;
}
else if (convXzMajor.IdXzMajorShoolType  ==  AttributeName[intIndex])
{
return mstrIdXzMajorShoolType;
}
return null;
}
set
{
if (convXzMajor.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convXzMajor.IdXzMajor);
}
else if (convXzMajor.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convXzMajor.MajorID);
}
else if (convXzMajor.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convXzMajor.MajorName);
}
else if (convXzMajor.MajorEnglishName  ==  AttributeName[intIndex])
{
mstrMajorEnglishName = value.ToString();
 AddUpdatedFld(convXzMajor.MajorEnglishName);
}
else if (convXzMajor.MajorExplain  ==  AttributeName[intIndex])
{
mstrMajorExplain = value.ToString();
 AddUpdatedFld(convXzMajor.MajorExplain);
}
else if (convXzMajor.MajorNationalID  ==  AttributeName[intIndex])
{
mstrMajorNationalID = value.ToString();
 AddUpdatedFld(convXzMajor.MajorNationalID);
}
else if (convXzMajor.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convXzMajor.IdXzCollege);
}
else if (convXzMajor.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convXzMajor.CollegeId);
}
else if (convXzMajor.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convXzMajor.CollegeName);
}
else if (convXzMajor.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convXzMajor.CollegeNameA);
}
else if (convXzMajor.IdMajorType  ==  AttributeName[intIndex])
{
mstrIdMajorType = value.ToString();
 AddUpdatedFld(convXzMajor.IdMajorType);
}
else if (convXzMajor.MajorTypeName  ==  AttributeName[intIndex])
{
mstrMajorTypeName = value.ToString();
 AddUpdatedFld(convXzMajor.MajorTypeName);
}
else if (convXzMajor.IdDegreeType  ==  AttributeName[intIndex])
{
mstrIdDegreeType = value.ToString();
 AddUpdatedFld(convXzMajor.IdDegreeType);
}
else if (convXzMajor.XwTypeDesc  ==  AttributeName[intIndex])
{
mstrXwTypeDesc = value.ToString();
 AddUpdatedFld(convXzMajor.XwTypeDesc);
}
else if (convXzMajor.IsMainMajor  ==  AttributeName[intIndex])
{
mbolIsMainMajor = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzMajor.IsMainMajor);
}
else if (convXzMajor.MajorDirection  ==  AttributeName[intIndex])
{
mstrMajorDirection = value.ToString();
 AddUpdatedFld(convXzMajor.MajorDirection);
}
else if (convXzMajor.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzMajor.IsVisible);
}
else if (convXzMajor.IsNormal  ==  AttributeName[intIndex])
{
mbolIsNormal = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzMajor.IsNormal);
}
else if (convXzMajor.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convXzMajor.ModifyDate);
}
else if (convXzMajor.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convXzMajor.ModifyUserId);
}
else if (convXzMajor.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzMajor.Memo);
}
else if (convXzMajor.IsVisible4XzClg  ==  AttributeName[intIndex])
{
mbolIsVisible4XzClg = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzMajor.IsVisible4XzClg);
}
else if (convXzMajor.TypeName  ==  AttributeName[intIndex])
{
mstrTypeName = value.ToString();
 AddUpdatedFld(convXzMajor.TypeName);
}
else if (convXzMajor.IdXzMajorShoolType  ==  AttributeName[intIndex])
{
mstrIdXzMajorShoolType = value.ToString();
 AddUpdatedFld(convXzMajor.IdXzMajorShoolType);
}
}
}

/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajor
{
get
{
return mstrIdXzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajor = value;
}
else
{
 mstrIdXzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.IdXzMajor);
}
}
/// <summary>
/// 专业ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorID
{
get
{
return mstrMajorID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorID = value;
}
else
{
 mstrMajorID = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.MajorID);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.MajorName);
}
}
/// <summary>
/// 专业英文名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorEnglishName
{
get
{
return mstrMajorEnglishName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorEnglishName = value;
}
else
{
 mstrMajorEnglishName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.MajorEnglishName);
}
}
/// <summary>
/// 专业说明(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorExplain
{
get
{
return mstrMajorExplain;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorExplain = value;
}
else
{
 mstrMajorExplain = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.MajorExplain);
}
}
/// <summary>
/// 专业国家代码(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorNationalID
{
get
{
return mstrMajorNationalID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorNationalID = value;
}
else
{
 mstrMajorNationalID = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.MajorNationalID);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzCollege
{
get
{
return mstrIdXzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzCollege = value;
}
else
{
 mstrIdXzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.IdXzCollege);
}
}
/// <summary>
/// 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeId
{
get
{
return mstrCollegeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeId = value;
}
else
{
 mstrCollegeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.CollegeId);
}
}
/// <summary>
/// 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName
{
get
{
return mstrCollegeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName = value;
}
else
{
 mstrCollegeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.CollegeName);
}
}
/// <summary>
/// 学院名称简写(说明:;字段类型:varchar;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeNameA
{
get
{
return mstrCollegeNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeNameA = value;
}
else
{
 mstrCollegeNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.CollegeNameA);
}
}
/// <summary>
/// 专业类型(文理工)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMajorType
{
get
{
return mstrIdMajorType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMajorType = value;
}
else
{
 mstrIdMajorType = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.IdMajorType);
}
}
/// <summary>
/// 专业类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorTypeName
{
get
{
return mstrMajorTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorTypeName = value;
}
else
{
 mstrMajorTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.MajorTypeName);
}
}
/// <summary>
/// 学位类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdDegreeType
{
get
{
return mstrIdDegreeType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdDegreeType = value;
}
else
{
 mstrIdDegreeType = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.IdDegreeType);
}
}
/// <summary>
/// 学位类型名称(说明:;字段类型:varchar;字段长度:60;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string XwTypeDesc
{
get
{
return mstrXwTypeDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrXwTypeDesc = value;
}
else
{
 mstrXwTypeDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.XwTypeDesc);
}
}
/// <summary>
/// 是否重要专业(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMainMajor
{
get
{
return mbolIsMainMajor;
}
set
{
 mbolIsMainMajor = value;
//记录修改过的字段
 AddUpdatedFld(convXzMajor.IsMainMajor);
}
}
/// <summary>
/// 专业方向(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorDirection
{
get
{
return mstrMajorDirection;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorDirection = value;
}
else
{
 mstrMajorDirection = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.MajorDirection);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(convXzMajor.IsVisible);
}
}
/// <summary>
/// IsNormal(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNormal
{
get
{
return mbolIsNormal;
}
set
{
 mbolIsNormal = value;
//记录修改过的字段
 AddUpdatedFld(convXzMajor.IsNormal);
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
 AddUpdatedFld(convXzMajor.ModifyDate);
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
 AddUpdatedFld(convXzMajor.ModifyUserId);
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
 AddUpdatedFld(convXzMajor.Memo);
}
}
/// <summary>
/// IsVisible4XzClg(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible4XzClg
{
get
{
return mbolIsVisible4XzClg;
}
set
{
 mbolIsVisible4XzClg = value;
//记录修改过的字段
 AddUpdatedFld(convXzMajor.IsVisible4XzClg);
}
}
/// <summary>
/// 类型名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TypeName
{
get
{
return mstrTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTypeName = value;
}
else
{
 mstrTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.TypeName);
}
}
/// <summary>
/// 专业学校类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajorShoolType
{
get
{
return mstrIdXzMajorShoolType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajorShoolType = value;
}
else
{
 mstrIdXzMajorShoolType = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajor.IdXzMajorShoolType);
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
  return mstrIdXzMajor;
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
  return mstrMajorName;
 }
 }
}
 /// <summary>
 /// v专业(vXzMajor)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convXzMajor
{
public const string _CurrTabName = "vXzMajor"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdXzMajor"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdXzMajor", "MajorID", "MajorName", "MajorEnglishName", "MajorExplain", "MajorNationalID", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "IdMajorType", "MajorTypeName", "IdDegreeType", "XwTypeDesc", "IsMainMajor", "MajorDirection", "IsVisible", "IsNormal", "ModifyDate", "ModifyUserId", "Memo", "IsVisible4XzClg", "TypeName", "IdXzMajorShoolType"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorID = "MajorID";    //专业ID

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"MajorEnglishName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorEnglishName = "MajorEnglishName";    //专业英文名称

 /// <summary>
 /// 常量:"MajorExplain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorExplain = "MajorExplain";    //专业说明

 /// <summary>
 /// 常量:"MajorNationalID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorNationalID = "MajorNationalID";    //专业国家代码

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeId = "CollegeId";    //学院ID

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

 /// <summary>
 /// 常量:"IdMajorType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMajorType = "IdMajorType";    //专业类型(文理工)流水号

 /// <summary>
 /// 常量:"MajorTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorTypeName = "MajorTypeName";    //专业类型名称

 /// <summary>
 /// 常量:"IdDegreeType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDegreeType = "IdDegreeType";    //学位类型流水号

 /// <summary>
 /// 常量:"XwTypeDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string XwTypeDesc = "XwTypeDesc";    //学位类型名称

 /// <summary>
 /// 常量:"IsMainMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMainMajor = "IsMainMajor";    //是否重要专业

 /// <summary>
 /// 常量:"MajorDirection"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorDirection = "MajorDirection";    //专业方向

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"IsNormal"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNormal = "IsNormal";    //IsNormal

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

 /// <summary>
 /// 常量:"IsVisible4XzClg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible4XzClg = "IsVisible4XzClg";    //IsVisible4XzClg

 /// <summary>
 /// 常量:"TypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TypeName = "TypeName";    //类型名称

 /// <summary>
 /// 常量:"IdXzMajorShoolType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajorShoolType = "IdXzMajorShoolType";    //专业学校类型流水号
}

}