
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseIsLike_TtlEN
 表名:vcc_CourseIsLike_Ttl(01120201)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理(CourseManage)
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
 /// 表vcc_CourseIsLike_Ttl的关键字(CourseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CourseId_vcc_CourseIsLike_Ttl
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCourseId">表关键字</param>
public K_CourseId_vcc_CourseIsLike_Ttl(string strCourseId)
{
if (IsValid(strCourseId)) Value = strCourseId;
else
{
Value = null;
}
}
private static bool IsValid(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true) return false;
if (strCourseId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CourseId_vcc_CourseIsLike_Ttl]类型的对象</returns>
public static implicit operator K_CourseId_vcc_CourseIsLike_Ttl(string value)
{
return new K_CourseId_vcc_CourseIsLike_Ttl(value);
}
}
 /// <summary>
 /// vcc_CourseIsLike_Ttl(vcc_CourseIsLike_Ttl)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_CourseIsLike_TtlEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_CourseIsLike_Ttl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CourseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"CourseId", "LikeCount"};

protected string mstrCourseId;    //课程Id
protected int? mintLikeCount;    //LikeCount

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_CourseIsLike_TtlEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCourseId">关键字:课程Id</param>
public clsvcc_CourseIsLike_TtlEN(string strCourseId)
 {
strCourseId = strCourseId.Replace("'", "''");
if (strCourseId.Length > 8)
{
throw new Exception("在表:vcc_CourseIsLike_Ttl中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCourseId)  ==  true)
{
throw new Exception("在表:vcc_CourseIsLike_Ttl中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCourseId = strCourseId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseId");
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
if (strAttributeName  ==  convcc_CourseIsLike_Ttl.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_CourseIsLike_Ttl.LikeCount)
{
return mintLikeCount;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_CourseIsLike_Ttl.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CourseIsLike_Ttl.CourseId);
}
else if (strAttributeName  ==  convcc_CourseIsLike_Ttl.LikeCount)
{
mintLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseIsLike_Ttl.LikeCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_CourseIsLike_Ttl.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_CourseIsLike_Ttl.LikeCount  ==  AttributeName[intIndex])
{
return mintLikeCount;
}
return null;
}
set
{
if (convcc_CourseIsLike_Ttl.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CourseIsLike_Ttl.CourseId);
}
else if (convcc_CourseIsLike_Ttl.LikeCount  ==  AttributeName[intIndex])
{
mintLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseIsLike_Ttl.LikeCount);
}
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
 AddUpdatedFld(convcc_CourseIsLike_Ttl.CourseId);
}
}
/// <summary>
/// LikeCount(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LikeCount
{
get
{
return mintLikeCount;
}
set
{
 mintLikeCount = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseIsLike_Ttl.LikeCount);
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
  return mstrCourseId;
 }
 }
}
 /// <summary>
 /// vcc_CourseIsLike_Ttl(vcc_CourseIsLike_Ttl)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_CourseIsLike_Ttl
{
public const string _CurrTabName = "vcc_CourseIsLike_Ttl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CourseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseId", "LikeCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"LikeCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeCount = "LikeCount";    //LikeCount
}

}