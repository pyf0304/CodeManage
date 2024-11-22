
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TeamMemberEN
 表名:zx_TeamMember(01120718)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:36
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// 表zx_TeamMember的关键字(TeammenberId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TeammenberId_zx_TeamMember
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTeammenberId">表关键字</param>
public K_TeammenberId_zx_TeamMember(string strTeammenberId)
{
if (IsValid(strTeammenberId)) Value = strTeammenberId;
else
{
Value = null;
}
}
private static bool IsValid(string strTeammenberId)
{
if (string.IsNullOrEmpty(strTeammenberId) == true) return false;
if (strTeammenberId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TeammenberId_zx_TeamMember]类型的对象</returns>
public static implicit operator K_TeammenberId_zx_TeamMember(string value)
{
return new K_TeammenberId_zx_TeamMember(value);
}
}
 /// <summary>
 /// 小组成员(zx_TeamMember)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_TeamMemberEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_TeamMember"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TeammenberId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"TeammenberId", "TeamName", "UpdDate", "UpdUser", "Memo"};

protected string mstrTeammenberId;    //主键
protected string mstrTeamName;    //团队名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_TeamMemberEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TeammenberId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTeammenberId">关键字:主键</param>
public clszx_TeamMemberEN(string strTeammenberId)
 {
strTeammenberId = strTeammenberId.Replace("'", "''");
if (strTeammenberId.Length > 8)
{
throw new Exception("在表:zx_TeamMember中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTeammenberId)  ==  true)
{
throw new Exception("在表:zx_TeamMember中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTeammenberId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTeammenberId = strTeammenberId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TeammenberId");
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
if (strAttributeName  ==  conzx_TeamMember.TeammenberId)
{
return mstrTeammenberId;
}
else if (strAttributeName  ==  conzx_TeamMember.TeamName)
{
return mstrTeamName;
}
else if (strAttributeName  ==  conzx_TeamMember.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_TeamMember.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_TeamMember.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_TeamMember.TeammenberId)
{
mstrTeammenberId = value.ToString();
 AddUpdatedFld(conzx_TeamMember.TeammenberId);
}
else if (strAttributeName  ==  conzx_TeamMember.TeamName)
{
mstrTeamName = value.ToString();
 AddUpdatedFld(conzx_TeamMember.TeamName);
}
else if (strAttributeName  ==  conzx_TeamMember.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TeamMember.UpdDate);
}
else if (strAttributeName  ==  conzx_TeamMember.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TeamMember.UpdUser);
}
else if (strAttributeName  ==  conzx_TeamMember.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TeamMember.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_TeamMember.TeammenberId  ==  AttributeName[intIndex])
{
return mstrTeammenberId;
}
else if (conzx_TeamMember.TeamName  ==  AttributeName[intIndex])
{
return mstrTeamName;
}
else if (conzx_TeamMember.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_TeamMember.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_TeamMember.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_TeamMember.TeammenberId  ==  AttributeName[intIndex])
{
mstrTeammenberId = value.ToString();
 AddUpdatedFld(conzx_TeamMember.TeammenberId);
}
else if (conzx_TeamMember.TeamName  ==  AttributeName[intIndex])
{
mstrTeamName = value.ToString();
 AddUpdatedFld(conzx_TeamMember.TeamName);
}
else if (conzx_TeamMember.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TeamMember.UpdDate);
}
else if (conzx_TeamMember.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TeamMember.UpdUser);
}
else if (conzx_TeamMember.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TeamMember.Memo);
}
}
}

/// <summary>
/// 主键(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeammenberId
{
get
{
return mstrTeammenberId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeammenberId = value;
}
else
{
 mstrTeammenberId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TeamMember.TeammenberId);
}
}
/// <summary>
/// 团队名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeamName
{
get
{
return mstrTeamName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeamName = value;
}
else
{
 mstrTeamName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TeamMember.TeamName);
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
 AddUpdatedFld(conzx_TeamMember.UpdDate);
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
 AddUpdatedFld(conzx_TeamMember.UpdUser);
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
 AddUpdatedFld(conzx_TeamMember.Memo);
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
  return mstrTeammenberId;
 }
 }
}
 /// <summary>
 /// 小组成员(zx_TeamMember)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_TeamMember
{
public const string _CurrTabName = "zx_TeamMember"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TeammenberId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TeammenberId", "TeamName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TeammenberId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeammenberId = "TeammenberId";    //主键

 /// <summary>
 /// 常量:"TeamName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeamName = "TeamName";    //团队名称

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