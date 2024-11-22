
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserLog4FunctionEN
 表名:UserLog4Function(01120337)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理(LogManage)
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
 /// 表UserLog4Function的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_UserLog4Function
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_UserLog4Function(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_UserLog4Function]类型的对象</returns>
public static implicit operator K_mId_UserLog4Function(long value)
{
return new K_mId_UserLog4Function(value);
}
}
 /// <summary>
 /// 用户使用功能日志(UserLog4Function)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserLog4FunctionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserLog4Function"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"mId", "FunctionId", "UserId", "RoleName", "IsStudent", "IsTeacher", "UseTime", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrFunctionId;    //功能Id
protected string mstrUserId;    //用户ID
protected string mstrRoleName;    //角色名
protected bool mbolIsStudent;    //是否学生
protected bool mbolIsTeacher;    //是否教师
protected string mstrUseTime;    //使用时间
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsUserLog4FunctionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsUserLog4FunctionEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conUserLog4Function.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conUserLog4Function.FunctionId)
{
return mstrFunctionId;
}
else if (strAttributeName  ==  conUserLog4Function.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUserLog4Function.RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  conUserLog4Function.IsStudent)
{
return mbolIsStudent;
}
else if (strAttributeName  ==  conUserLog4Function.IsTeacher)
{
return mbolIsTeacher;
}
else if (strAttributeName  ==  conUserLog4Function.UseTime)
{
return mstrUseTime;
}
else if (strAttributeName  ==  conUserLog4Function.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conUserLog4Function.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conUserLog4Function.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserLog4Function.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserLog4Function.mId);
}
else if (strAttributeName  ==  conUserLog4Function.FunctionId)
{
mstrFunctionId = value.ToString();
 AddUpdatedFld(conUserLog4Function.FunctionId);
}
else if (strAttributeName  ==  conUserLog4Function.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserLog4Function.UserId);
}
else if (strAttributeName  ==  conUserLog4Function.RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(conUserLog4Function.RoleName);
}
else if (strAttributeName  ==  conUserLog4Function.IsStudent)
{
mbolIsStudent = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserLog4Function.IsStudent);
}
else if (strAttributeName  ==  conUserLog4Function.IsTeacher)
{
mbolIsTeacher = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserLog4Function.IsTeacher);
}
else if (strAttributeName  ==  conUserLog4Function.UseTime)
{
mstrUseTime = value.ToString();
 AddUpdatedFld(conUserLog4Function.UseTime);
}
else if (strAttributeName  ==  conUserLog4Function.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserLog4Function.UpdDate);
}
else if (strAttributeName  ==  conUserLog4Function.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conUserLog4Function.UpdUser);
}
else if (strAttributeName  ==  conUserLog4Function.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserLog4Function.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserLog4Function.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conUserLog4Function.FunctionId  ==  AttributeName[intIndex])
{
return mstrFunctionId;
}
else if (conUserLog4Function.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUserLog4Function.RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (conUserLog4Function.IsStudent  ==  AttributeName[intIndex])
{
return mbolIsStudent;
}
else if (conUserLog4Function.IsTeacher  ==  AttributeName[intIndex])
{
return mbolIsTeacher;
}
else if (conUserLog4Function.UseTime  ==  AttributeName[intIndex])
{
return mstrUseTime;
}
else if (conUserLog4Function.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conUserLog4Function.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conUserLog4Function.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserLog4Function.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserLog4Function.mId);
}
else if (conUserLog4Function.FunctionId  ==  AttributeName[intIndex])
{
mstrFunctionId = value.ToString();
 AddUpdatedFld(conUserLog4Function.FunctionId);
}
else if (conUserLog4Function.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserLog4Function.UserId);
}
else if (conUserLog4Function.RoleName  ==  AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(conUserLog4Function.RoleName);
}
else if (conUserLog4Function.IsStudent  ==  AttributeName[intIndex])
{
mbolIsStudent = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserLog4Function.IsStudent);
}
else if (conUserLog4Function.IsTeacher  ==  AttributeName[intIndex])
{
mbolIsTeacher = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserLog4Function.IsTeacher);
}
else if (conUserLog4Function.UseTime  ==  AttributeName[intIndex])
{
mstrUseTime = value.ToString();
 AddUpdatedFld(conUserLog4Function.UseTime);
}
else if (conUserLog4Function.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserLog4Function.UpdDate);
}
else if (conUserLog4Function.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conUserLog4Function.UpdUser);
}
else if (conUserLog4Function.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserLog4Function.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conUserLog4Function.mId);
}
}
/// <summary>
/// 功能Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionId
{
get
{
return mstrFunctionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionId = value;
}
else
{
 mstrFunctionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserLog4Function.FunctionId);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserLog4Function.UserId);
}
}
/// <summary>
/// 角色名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleName
{
get
{
return mstrRoleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleName = value;
}
else
{
 mstrRoleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserLog4Function.RoleName);
}
}
/// <summary>
/// 是否学生(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsStudent
{
get
{
return mbolIsStudent;
}
set
{
 mbolIsStudent = value;
//记录修改过的字段
 AddUpdatedFld(conUserLog4Function.IsStudent);
}
}
/// <summary>
/// 是否教师(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTeacher
{
get
{
return mbolIsTeacher;
}
set
{
 mbolIsTeacher = value;
//记录修改过的字段
 AddUpdatedFld(conUserLog4Function.IsTeacher);
}
}
/// <summary>
/// 使用时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseTime
{
get
{
return mstrUseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseTime = value;
}
else
{
 mstrUseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserLog4Function.UseTime);
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
 AddUpdatedFld(conUserLog4Function.UpdDate);
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
 AddUpdatedFld(conUserLog4Function.UpdUser);
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
 AddUpdatedFld(conUserLog4Function.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 用户使用功能日志(UserLog4Function)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserLog4Function
{
public const string _CurrTabName = "UserLog4Function"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "FunctionId", "UserId", "RoleName", "IsStudent", "IsTeacher", "UseTime", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"FunctionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionId = "FunctionId";    //功能Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"RoleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleName = "RoleName";    //角色名

 /// <summary>
 /// 常量:"IsStudent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsStudent = "IsStudent";    //是否学生

 /// <summary>
 /// 常量:"IsTeacher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTeacher = "IsTeacher";    //是否教师

 /// <summary>
 /// 常量:"UseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseTime = "UseTime";    //使用时间

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