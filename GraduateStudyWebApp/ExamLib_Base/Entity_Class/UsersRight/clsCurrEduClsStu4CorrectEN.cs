
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsStu4CorrectEN
 表名:CurrEduClsStu4Correct(01120180)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:38
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
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
 /// 表CurrEduClsStu4Correct的关键字(IdCurrEduClsStu4Correct)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCurrEduClsStu4Correct_CurrEduClsStu4Correct
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdCurrEduClsStu4Correct">表关键字</param>
public K_IdCurrEduClsStu4Correct_CurrEduClsStu4Correct(long lngIdCurrEduClsStu4Correct)
{
if (IsValid(lngIdCurrEduClsStu4Correct)) Value = lngIdCurrEduClsStu4Correct;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdCurrEduClsStu4Correct)
{
if (lngIdCurrEduClsStu4Correct == 0) return false;
if (lngIdCurrEduClsStu4Correct == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCurrEduClsStu4Correct_CurrEduClsStu4Correct]类型的对象</returns>
public static implicit operator K_IdCurrEduClsStu4Correct_CurrEduClsStu4Correct(long value)
{
return new K_IdCurrEduClsStu4Correct_CurrEduClsStu4Correct(value);
}
}
 /// <summary>
 /// 教学班学生_批改作业(CurrEduClsStu4Correct)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCurrEduClsStu4CorrectEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CurrEduClsStu4Correct"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCurrEduClsStu4Correct"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"IdCurrEduClsStu4Correct", "IdCurrEduCls", "IdStu", "RightId", "SchoolTerm", "SchoolYear", "ModifyDate", "ModifyUserID", "Memo"};

protected long mlngIdCurrEduClsStu4Correct;    //教学班学生_批改作业流水号
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrIdStu;    //学生流水号
protected string mstrRightId;    //权限编号
protected string mstrSchoolTerm;    //学期
protected string mstrSchoolYear;    //学年
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserID;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCurrEduClsStu4CorrectEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCurrEduClsStu4Correct");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdCurrEduClsStu4Correct">关键字:教学班学生_批改作业流水号</param>
public clsCurrEduClsStu4CorrectEN(long lngIdCurrEduClsStu4Correct)
 {
 if (lngIdCurrEduClsStu4Correct  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdCurrEduClsStu4Correct = lngIdCurrEduClsStu4Correct;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCurrEduClsStu4Correct");
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
if (strAttributeName  ==  conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct)
{
return mlngIdCurrEduClsStu4Correct;
}
else if (strAttributeName  ==  conCurrEduClsStu4Correct.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conCurrEduClsStu4Correct.IdStu)
{
return mstrIdStu;
}
else if (strAttributeName  ==  conCurrEduClsStu4Correct.RightId)
{
return mstrRightId;
}
else if (strAttributeName  ==  conCurrEduClsStu4Correct.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  conCurrEduClsStu4Correct.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  conCurrEduClsStu4Correct.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conCurrEduClsStu4Correct.ModifyUserID)
{
return mstrModifyUserID;
}
else if (strAttributeName  ==  conCurrEduClsStu4Correct.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct)
{
mlngIdCurrEduClsStu4Correct = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct);
}
else if (strAttributeName  ==  conCurrEduClsStu4Correct.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conCurrEduClsStu4Correct.IdCurrEduCls);
}
else if (strAttributeName  ==  conCurrEduClsStu4Correct.IdStu)
{
mstrIdStu = value.ToString();
 AddUpdatedFld(conCurrEduClsStu4Correct.IdStu);
}
else if (strAttributeName  ==  conCurrEduClsStu4Correct.RightId)
{
mstrRightId = value.ToString();
 AddUpdatedFld(conCurrEduClsStu4Correct.RightId);
}
else if (strAttributeName  ==  conCurrEduClsStu4Correct.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conCurrEduClsStu4Correct.SchoolTerm);
}
else if (strAttributeName  ==  conCurrEduClsStu4Correct.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conCurrEduClsStu4Correct.SchoolYear);
}
else if (strAttributeName  ==  conCurrEduClsStu4Correct.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conCurrEduClsStu4Correct.ModifyDate);
}
else if (strAttributeName  ==  conCurrEduClsStu4Correct.ModifyUserID)
{
mstrModifyUserID = value.ToString();
 AddUpdatedFld(conCurrEduClsStu4Correct.ModifyUserID);
}
else if (strAttributeName  ==  conCurrEduClsStu4Correct.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCurrEduClsStu4Correct.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct  ==  AttributeName[intIndex])
{
return mlngIdCurrEduClsStu4Correct;
}
else if (conCurrEduClsStu4Correct.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conCurrEduClsStu4Correct.IdStu  ==  AttributeName[intIndex])
{
return mstrIdStu;
}
else if (conCurrEduClsStu4Correct.RightId  ==  AttributeName[intIndex])
{
return mstrRightId;
}
else if (conCurrEduClsStu4Correct.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (conCurrEduClsStu4Correct.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (conCurrEduClsStu4Correct.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conCurrEduClsStu4Correct.ModifyUserID  ==  AttributeName[intIndex])
{
return mstrModifyUserID;
}
else if (conCurrEduClsStu4Correct.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct  ==  AttributeName[intIndex])
{
mlngIdCurrEduClsStu4Correct = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct);
}
else if (conCurrEduClsStu4Correct.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conCurrEduClsStu4Correct.IdCurrEduCls);
}
else if (conCurrEduClsStu4Correct.IdStu  ==  AttributeName[intIndex])
{
mstrIdStu = value.ToString();
 AddUpdatedFld(conCurrEduClsStu4Correct.IdStu);
}
else if (conCurrEduClsStu4Correct.RightId  ==  AttributeName[intIndex])
{
mstrRightId = value.ToString();
 AddUpdatedFld(conCurrEduClsStu4Correct.RightId);
}
else if (conCurrEduClsStu4Correct.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conCurrEduClsStu4Correct.SchoolTerm);
}
else if (conCurrEduClsStu4Correct.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conCurrEduClsStu4Correct.SchoolYear);
}
else if (conCurrEduClsStu4Correct.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conCurrEduClsStu4Correct.ModifyDate);
}
else if (conCurrEduClsStu4Correct.ModifyUserID  ==  AttributeName[intIndex])
{
mstrModifyUserID = value.ToString();
 AddUpdatedFld(conCurrEduClsStu4Correct.ModifyUserID);
}
else if (conCurrEduClsStu4Correct.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCurrEduClsStu4Correct.Memo);
}
}
}

/// <summary>
/// 教学班学生_批改作业流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdCurrEduClsStu4Correct
{
get
{
return mlngIdCurrEduClsStu4Correct;
}
set
{
 mlngIdCurrEduClsStu4Correct = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu4Correct.IdCurrEduCls);
}
}
/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStu
{
get
{
return mstrIdStu;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStu = value;
}
else
{
 mstrIdStu = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu4Correct.IdStu);
}
}
/// <summary>
/// 权限编号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RightId
{
get
{
return mstrRightId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRightId = value;
}
else
{
 mstrRightId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu4Correct.RightId);
}
}
/// <summary>
/// 学期(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolTerm
{
get
{
return mstrSchoolTerm;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolTerm = value;
}
else
{
 mstrSchoolTerm = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu4Correct.SchoolTerm);
}
}
/// <summary>
/// 学年(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolYear
{
get
{
return mstrSchoolYear;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolYear = value;
}
else
{
 mstrSchoolYear = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu4Correct.SchoolYear);
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
 AddUpdatedFld(conCurrEduClsStu4Correct.ModifyDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserID
{
get
{
return mstrModifyUserID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserID = value;
}
else
{
 mstrModifyUserID = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu4Correct.ModifyUserID);
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
 AddUpdatedFld(conCurrEduClsStu4Correct.Memo);
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
  return mlngIdCurrEduClsStu4Correct.ToString();
 }
 }
}
 /// <summary>
 /// 教学班学生_批改作业(CurrEduClsStu4Correct)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCurrEduClsStu4Correct
{
public const string _CurrTabName = "CurrEduClsStu4Correct"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCurrEduClsStu4Correct"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCurrEduClsStu4Correct", "IdCurrEduCls", "IdStu", "RightId", "SchoolTerm", "SchoolYear", "ModifyDate", "ModifyUserID", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCurrEduClsStu4Correct"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduClsStu4Correct = "IdCurrEduClsStu4Correct";    //教学班学生_批改作业流水号

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"IdStu"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStu = "IdStu";    //学生流水号

 /// <summary>
 /// 常量:"RightId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RightId = "RightId";    //权限编号

 /// <summary>
 /// 常量:"SchoolTerm"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTerm = "SchoolTerm";    //学期

 /// <summary>
 /// 常量:"SchoolYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolYear = "SchoolYear";    //学年

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUserID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserID = "ModifyUserID";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}