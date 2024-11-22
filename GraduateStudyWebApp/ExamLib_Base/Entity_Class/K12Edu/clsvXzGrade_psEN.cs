
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzGrade_psEN
 表名:vXzGrade_ps(01120368)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:21
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中小学教学(K12Edu)
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
 /// 表vXzGrade_ps的关键字(IdGradeBase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdGradeBase_vXzGrade_ps
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdGradeBase">表关键字</param>
public K_IdGradeBase_vXzGrade_ps(string strIdGradeBase)
{
if (IsValid(strIdGradeBase)) Value = strIdGradeBase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdGradeBase)
{
if (string.IsNullOrEmpty(strIdGradeBase) == true) return false;
if (strIdGradeBase.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdGradeBase_vXzGrade_ps]类型的对象</returns>
public static implicit operator K_IdGradeBase_vXzGrade_ps(string value)
{
return new K_IdGradeBase_vXzGrade_ps(value);
}
}
 /// <summary>
 /// v年级表_ps(vXzGrade_ps)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvXzGrade_psEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vXzGrade_ps"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdGradeBase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"IdGradeBase", "GradeBaseId", "GradeBaseName", "IsVisible", "OrderNum", "SchoolId", "SchoolName", "IdSchool", "Memo"};

protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseId;    //年级代号
protected string mstrGradeBaseName;    //年级名称
protected bool mbolIsVisible;    //是否显示
protected int? mintOrderNum;    //序号
protected string mstrSchoolId;    //学校编号
protected string mstrSchoolName;    //学校名称
protected string mstrIdSchool;    //学校流水号
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvXzGrade_psEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdGradeBase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdGradeBase">关键字:年级流水号</param>
public clsvXzGrade_psEN(string strIdGradeBase)
 {
strIdGradeBase = strIdGradeBase.Replace("'", "''");
if (strIdGradeBase.Length > 4)
{
throw new Exception("在表:vXzGrade_ps中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdGradeBase)  ==  true)
{
throw new Exception("在表:vXzGrade_ps中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdGradeBase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdGradeBase = strIdGradeBase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdGradeBase");
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
if (strAttributeName  ==  convXzGrade_ps.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convXzGrade_ps.GradeBaseId)
{
return mstrGradeBaseId;
}
else if (strAttributeName  ==  convXzGrade_ps.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convXzGrade_ps.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convXzGrade_ps.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convXzGrade_ps.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  convXzGrade_ps.SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  convXzGrade_ps.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  convXzGrade_ps.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convXzGrade_ps.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convXzGrade_ps.IdGradeBase);
}
else if (strAttributeName  ==  convXzGrade_ps.GradeBaseId)
{
mstrGradeBaseId = value.ToString();
 AddUpdatedFld(convXzGrade_ps.GradeBaseId);
}
else if (strAttributeName  ==  convXzGrade_ps.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convXzGrade_ps.GradeBaseName);
}
else if (strAttributeName  ==  convXzGrade_ps.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzGrade_ps.IsVisible);
}
else if (strAttributeName  ==  convXzGrade_ps.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzGrade_ps.OrderNum);
}
else if (strAttributeName  ==  convXzGrade_ps.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convXzGrade_ps.SchoolId);
}
else if (strAttributeName  ==  convXzGrade_ps.SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convXzGrade_ps.SchoolName);
}
else if (strAttributeName  ==  convXzGrade_ps.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convXzGrade_ps.IdSchool);
}
else if (strAttributeName  ==  convXzGrade_ps.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzGrade_ps.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convXzGrade_ps.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convXzGrade_ps.GradeBaseId  ==  AttributeName[intIndex])
{
return mstrGradeBaseId;
}
else if (convXzGrade_ps.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convXzGrade_ps.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convXzGrade_ps.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convXzGrade_ps.SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (convXzGrade_ps.SchoolName  ==  AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (convXzGrade_ps.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (convXzGrade_ps.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convXzGrade_ps.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convXzGrade_ps.IdGradeBase);
}
else if (convXzGrade_ps.GradeBaseId  ==  AttributeName[intIndex])
{
mstrGradeBaseId = value.ToString();
 AddUpdatedFld(convXzGrade_ps.GradeBaseId);
}
else if (convXzGrade_ps.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convXzGrade_ps.GradeBaseName);
}
else if (convXzGrade_ps.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzGrade_ps.IsVisible);
}
else if (convXzGrade_ps.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzGrade_ps.OrderNum);
}
else if (convXzGrade_ps.SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convXzGrade_ps.SchoolId);
}
else if (convXzGrade_ps.SchoolName  ==  AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convXzGrade_ps.SchoolName);
}
else if (convXzGrade_ps.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convXzGrade_ps.IdSchool);
}
else if (convXzGrade_ps.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzGrade_ps.Memo);
}
}
}

/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGradeBase
{
get
{
return mstrIdGradeBase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGradeBase = value;
}
else
{
 mstrIdGradeBase = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGrade_ps.IdGradeBase);
}
}
/// <summary>
/// 年级代号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseId
{
get
{
return mstrGradeBaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseId = value;
}
else
{
 mstrGradeBaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGrade_ps.GradeBaseId);
}
}
/// <summary>
/// 年级名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseName
{
get
{
return mstrGradeBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseName = value;
}
else
{
 mstrGradeBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGrade_ps.GradeBaseName);
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
 AddUpdatedFld(convXzGrade_ps.IsVisible);
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
 AddUpdatedFld(convXzGrade_ps.OrderNum);
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
 AddUpdatedFld(convXzGrade_ps.SchoolId);
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
 AddUpdatedFld(convXzGrade_ps.SchoolName);
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
 AddUpdatedFld(convXzGrade_ps.IdSchool);
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
 AddUpdatedFld(convXzGrade_ps.Memo);
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
  return mstrIdGradeBase;
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
  return mstrGradeBaseName;
 }
 }
}
 /// <summary>
 /// v年级表_ps(vXzGrade_ps)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convXzGrade_ps
{
public const string _CurrTabName = "vXzGrade_ps"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdGradeBase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdGradeBase", "GradeBaseId", "GradeBaseName", "IsVisible", "OrderNum", "SchoolId", "SchoolName", "IdSchool", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

 /// <summary>
 /// 常量:"GradeBaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseId = "GradeBaseId";    //年级代号

 /// <summary>
 /// 常量:"GradeBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseName = "GradeBaseName";    //年级名称

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}