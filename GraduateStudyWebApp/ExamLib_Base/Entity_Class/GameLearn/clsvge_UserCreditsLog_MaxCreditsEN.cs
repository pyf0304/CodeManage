
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvge_UserCreditsLog_MaxCreditsEN
 表名:vge_UserCreditsLog_MaxCredits(01120939)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:05:22
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
 /// 表vge_UserCreditsLog_MaxCredits的关键字(GameLevelId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_GameLevelId_vge_UserCreditsLog_MaxCredits
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strGameLevelId">表关键字</param>
public K_GameLevelId_vge_UserCreditsLog_MaxCredits(string strGameLevelId)
{
if (IsValid(strGameLevelId)) Value = strGameLevelId;
else
{
Value = null;
}
}
private static bool IsValid(string strGameLevelId)
{
if (string.IsNullOrEmpty(strGameLevelId) == true) return false;
if (strGameLevelId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_GameLevelId_vge_UserCreditsLog_MaxCredits]类型的对象</returns>
public static implicit operator K_GameLevelId_vge_UserCreditsLog_MaxCredits(string value)
{
return new K_GameLevelId_vge_UserCreditsLog_MaxCredits(value);
}
}
 /// <summary>
 /// v用户积分日志_最高分(vge_UserCreditsLog_MaxCredits)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvge_UserCreditsLog_MaxCreditsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vge_UserCreditsLog_MaxCredits"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "GameLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"GameLevelId", "Credits", "UserId", "IdCurrEduCls", "CourseId"};

protected string mstrGameLevelId;    //游戏关卡Id
protected int? mintCredits;    //积分
protected string mstrUserId;    //用户ID
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCourseId;    //课程Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvge_UserCreditsLog_MaxCreditsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GameLevelId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strGameLevelId">关键字:游戏关卡Id</param>
public clsvge_UserCreditsLog_MaxCreditsEN(string strGameLevelId)
 {
strGameLevelId = strGameLevelId.Replace("'", "''");
if (strGameLevelId.Length > 8)
{
throw new Exception("在表:vge_UserCreditsLog_MaxCredits中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strGameLevelId)  ==  true)
{
throw new Exception("在表:vge_UserCreditsLog_MaxCredits中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGameLevelId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrGameLevelId = strGameLevelId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GameLevelId");
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
if (strAttributeName  ==  convge_UserCreditsLog_MaxCredits.GameLevelId)
{
return mstrGameLevelId;
}
else if (strAttributeName  ==  convge_UserCreditsLog_MaxCredits.Credits)
{
return mintCredits;
}
else if (strAttributeName  ==  convge_UserCreditsLog_MaxCredits.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convge_UserCreditsLog_MaxCredits.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convge_UserCreditsLog_MaxCredits.CourseId)
{
return mstrCourseId;
}
return null;
}
set
{
if (strAttributeName  ==  convge_UserCreditsLog_MaxCredits.GameLevelId)
{
mstrGameLevelId = value.ToString();
 AddUpdatedFld(convge_UserCreditsLog_MaxCredits.GameLevelId);
}
else if (strAttributeName  ==  convge_UserCreditsLog_MaxCredits.Credits)
{
mintCredits = TransNullToInt(value.ToString());
 AddUpdatedFld(convge_UserCreditsLog_MaxCredits.Credits);
}
else if (strAttributeName  ==  convge_UserCreditsLog_MaxCredits.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convge_UserCreditsLog_MaxCredits.UserId);
}
else if (strAttributeName  ==  convge_UserCreditsLog_MaxCredits.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convge_UserCreditsLog_MaxCredits.IdCurrEduCls);
}
else if (strAttributeName  ==  convge_UserCreditsLog_MaxCredits.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convge_UserCreditsLog_MaxCredits.CourseId);
}
}
}
public object this[int intIndex]
{
get
{
if (convge_UserCreditsLog_MaxCredits.GameLevelId  ==  AttributeName[intIndex])
{
return mstrGameLevelId;
}
else if (convge_UserCreditsLog_MaxCredits.Credits  ==  AttributeName[intIndex])
{
return mintCredits;
}
else if (convge_UserCreditsLog_MaxCredits.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convge_UserCreditsLog_MaxCredits.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convge_UserCreditsLog_MaxCredits.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
return null;
}
set
{
if (convge_UserCreditsLog_MaxCredits.GameLevelId  ==  AttributeName[intIndex])
{
mstrGameLevelId = value.ToString();
 AddUpdatedFld(convge_UserCreditsLog_MaxCredits.GameLevelId);
}
else if (convge_UserCreditsLog_MaxCredits.Credits  ==  AttributeName[intIndex])
{
mintCredits = TransNullToInt(value.ToString());
 AddUpdatedFld(convge_UserCreditsLog_MaxCredits.Credits);
}
else if (convge_UserCreditsLog_MaxCredits.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convge_UserCreditsLog_MaxCredits.UserId);
}
else if (convge_UserCreditsLog_MaxCredits.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convge_UserCreditsLog_MaxCredits.IdCurrEduCls);
}
else if (convge_UserCreditsLog_MaxCredits.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convge_UserCreditsLog_MaxCredits.CourseId);
}
}
}

/// <summary>
/// 游戏关卡Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GameLevelId
{
get
{
return mstrGameLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGameLevelId = value;
}
else
{
 mstrGameLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(convge_UserCreditsLog_MaxCredits.GameLevelId);
}
}
/// <summary>
/// 积分(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Credits
{
get
{
return mintCredits;
}
set
{
 mintCredits = value;
//记录修改过的字段
 AddUpdatedFld(convge_UserCreditsLog_MaxCredits.Credits);
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
 AddUpdatedFld(convge_UserCreditsLog_MaxCredits.UserId);
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
 AddUpdatedFld(convge_UserCreditsLog_MaxCredits.IdCurrEduCls);
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
 AddUpdatedFld(convge_UserCreditsLog_MaxCredits.CourseId);
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
  return mstrGameLevelId;
 }
 }
}
 /// <summary>
 /// v用户积分日志_最高分(vge_UserCreditsLog_MaxCredits)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convge_UserCreditsLog_MaxCredits
{
public const string _CurrTabName = "vge_UserCreditsLog_MaxCredits"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "GameLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"GameLevelId", "Credits", "UserId", "IdCurrEduCls", "CourseId"};
//以下是属性变量


 /// <summary>
 /// 常量:"GameLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GameLevelId = "GameLevelId";    //游戏关卡Id

 /// <summary>
 /// 常量:"Credits"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Credits = "Credits";    //积分

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id
}

}