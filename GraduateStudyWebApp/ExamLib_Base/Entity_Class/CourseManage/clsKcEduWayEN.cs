
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKcEduWayEN
 表名:KcEduWay(01120347)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理(CourseManage)
 框架-层名:实体层(CS)(EntityLayer,0001)
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
using System.Collections.Generic;

namespace ExamLib.Entity
{
 /// <summary>
 /// 表KcEduWay的关键字(IdEduWay)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdEduWay_KcEduWay
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdEduWay">表关键字</param>
public K_IdEduWay_KcEduWay(string strIdEduWay)
{
if (IsValid(strIdEduWay)) Value = strIdEduWay;
else
{
Value = null;
}
}
private static bool IsValid(string strIdEduWay)
{
if (string.IsNullOrEmpty(strIdEduWay) == true) return false;
if (strIdEduWay.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdEduWay_KcEduWay]类型的对象</returns>
public static implicit operator K_IdEduWay_KcEduWay(string value)
{
return new K_IdEduWay_KcEduWay(value);
}
}
 /// <summary>
 /// 教学方式(KcEduWay)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsKcEduWayEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "KcEduWay"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdEduWay"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"IdEduWay", "EduWayID", "EduWayName"};

protected string mstrIdEduWay;    //教学方式流水号
protected string mstrEduWayID;    //教学方式代号
protected string mstrEduWayName;    //教学方式名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsKcEduWayEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEduWay");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdEduWay">关键字:教学方式流水号</param>
public clsKcEduWayEN(string strIdEduWay)
 {
strIdEduWay = strIdEduWay.Replace("'", "''");
if (strIdEduWay.Length > 4)
{
throw new Exception("在表:KcEduWay中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdEduWay)  ==  true)
{
throw new Exception("在表:KcEduWay中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdEduWay);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdEduWay = strIdEduWay;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEduWay");
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
if (strAttributeName  ==  conKcEduWay.IdEduWay)
{
return mstrIdEduWay;
}
else if (strAttributeName  ==  conKcEduWay.EduWayID)
{
return mstrEduWayID;
}
else if (strAttributeName  ==  conKcEduWay.EduWayName)
{
return mstrEduWayName;
}
return null;
}
set
{
if (strAttributeName  ==  conKcEduWay.IdEduWay)
{
mstrIdEduWay = value.ToString();
 AddUpdatedFld(conKcEduWay.IdEduWay);
}
else if (strAttributeName  ==  conKcEduWay.EduWayID)
{
mstrEduWayID = value.ToString();
 AddUpdatedFld(conKcEduWay.EduWayID);
}
else if (strAttributeName  ==  conKcEduWay.EduWayName)
{
mstrEduWayName = value.ToString();
 AddUpdatedFld(conKcEduWay.EduWayName);
}
}
}
public object this[int intIndex]
{
get
{
if (conKcEduWay.IdEduWay  ==  AttributeName[intIndex])
{
return mstrIdEduWay;
}
else if (conKcEduWay.EduWayID  ==  AttributeName[intIndex])
{
return mstrEduWayID;
}
else if (conKcEduWay.EduWayName  ==  AttributeName[intIndex])
{
return mstrEduWayName;
}
return null;
}
set
{
if (conKcEduWay.IdEduWay  ==  AttributeName[intIndex])
{
mstrIdEduWay = value.ToString();
 AddUpdatedFld(conKcEduWay.IdEduWay);
}
else if (conKcEduWay.EduWayID  ==  AttributeName[intIndex])
{
mstrEduWayID = value.ToString();
 AddUpdatedFld(conKcEduWay.EduWayID);
}
else if (conKcEduWay.EduWayName  ==  AttributeName[intIndex])
{
mstrEduWayName = value.ToString();
 AddUpdatedFld(conKcEduWay.EduWayName);
}
}
}

/// <summary>
/// 教学方式流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdEduWay
{
get
{
return mstrIdEduWay;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdEduWay = value;
}
else
{
 mstrIdEduWay = value;
}
//记录修改过的字段
 AddUpdatedFld(conKcEduWay.IdEduWay);
}
}
/// <summary>
/// 教学方式代号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduWayID
{
get
{
return mstrEduWayID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduWayID = value;
}
else
{
 mstrEduWayID = value;
}
//记录修改过的字段
 AddUpdatedFld(conKcEduWay.EduWayID);
}
}
/// <summary>
/// 教学方式名称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduWayName
{
get
{
return mstrEduWayName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduWayName = value;
}
else
{
 mstrEduWayName = value;
}
//记录修改过的字段
 AddUpdatedFld(conKcEduWay.EduWayName);
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
  return mstrIdEduWay;
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
  return mstrEduWayName;
 }
 }
}
 /// <summary>
 /// 教学方式(KcEduWay)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conKcEduWay
{
public const string _CurrTabName = "KcEduWay"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdEduWay"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdEduWay", "EduWayID", "EduWayName"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdEduWay"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEduWay = "IdEduWay";    //教学方式流水号

 /// <summary>
 /// 常量:"EduWayID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduWayID = "EduWayID";    //教学方式代号

 /// <summary>
 /// 常量:"EduWayName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduWayName = "EduWayName";    //教学方式名称
}

}