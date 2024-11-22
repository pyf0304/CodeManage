
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperGroupEN
 表名:gs_PaperGroup(01120749)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:11:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表gs_PaperGroup的关键字(PaperGroupId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperGroupId_gs_PaperGroup
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPaperGroupId">表关键字</param>
public K_PaperGroupId_gs_PaperGroup(string strPaperGroupId)
{
if (IsValid(strPaperGroupId)) Value = strPaperGroupId;
else
{
Value = null;
}
}
private static bool IsValid(string strPaperGroupId)
{
if (string.IsNullOrEmpty(strPaperGroupId) == true) return false;
if (strPaperGroupId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperGroupId_gs_PaperGroup]类型的对象</returns>
public static implicit operator K_PaperGroupId_gs_PaperGroup(string value)
{
return new K_PaperGroupId_gs_PaperGroup(value);
}
}
 /// <summary>
 /// 论文分组(gs_PaperGroup)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_PaperGroupEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_PaperGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperGroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"PaperGroupId", "PaperGroupName", "UpdUser", "OrderNum", "UpdDate", "Meno"};

protected string mstrPaperGroupId;    //组Id
protected string mstrPaperGroupName;    //组名
protected string mstrUpdUser;    //修改人
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrMeno;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_PaperGroupEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperGroupId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPaperGroupId">关键字:组Id</param>
public clsgs_PaperGroupEN(string strPaperGroupId)
 {
strPaperGroupId = strPaperGroupId.Replace("'", "''");
if (strPaperGroupId.Length > 8)
{
throw new Exception("在表:gs_PaperGroup中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPaperGroupId)  ==  true)
{
throw new Exception("在表:gs_PaperGroup中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperGroupId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPaperGroupId = strPaperGroupId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperGroupId");
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
if (strAttributeName  ==  congs_PaperGroup.PaperGroupId)
{
return mstrPaperGroupId;
}
else if (strAttributeName  ==  congs_PaperGroup.PaperGroupName)
{
return mstrPaperGroupName;
}
else if (strAttributeName  ==  congs_PaperGroup.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_PaperGroup.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  congs_PaperGroup.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_PaperGroup.Meno)
{
return mstrMeno;
}
return null;
}
set
{
if (strAttributeName  ==  congs_PaperGroup.PaperGroupId)
{
mstrPaperGroupId = value.ToString();
 AddUpdatedFld(congs_PaperGroup.PaperGroupId);
}
else if (strAttributeName  ==  congs_PaperGroup.PaperGroupName)
{
mstrPaperGroupName = value.ToString();
 AddUpdatedFld(congs_PaperGroup.PaperGroupName);
}
else if (strAttributeName  ==  congs_PaperGroup.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_PaperGroup.UpdUser);
}
else if (strAttributeName  ==  congs_PaperGroup.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_PaperGroup.OrderNum);
}
else if (strAttributeName  ==  congs_PaperGroup.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_PaperGroup.UpdDate);
}
else if (strAttributeName  ==  congs_PaperGroup.Meno)
{
mstrMeno = value.ToString();
 AddUpdatedFld(congs_PaperGroup.Meno);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_PaperGroup.PaperGroupId  ==  AttributeName[intIndex])
{
return mstrPaperGroupId;
}
else if (congs_PaperGroup.PaperGroupName  ==  AttributeName[intIndex])
{
return mstrPaperGroupName;
}
else if (congs_PaperGroup.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_PaperGroup.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (congs_PaperGroup.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_PaperGroup.Meno  ==  AttributeName[intIndex])
{
return mstrMeno;
}
return null;
}
set
{
if (congs_PaperGroup.PaperGroupId  ==  AttributeName[intIndex])
{
mstrPaperGroupId = value.ToString();
 AddUpdatedFld(congs_PaperGroup.PaperGroupId);
}
else if (congs_PaperGroup.PaperGroupName  ==  AttributeName[intIndex])
{
mstrPaperGroupName = value.ToString();
 AddUpdatedFld(congs_PaperGroup.PaperGroupName);
}
else if (congs_PaperGroup.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_PaperGroup.UpdUser);
}
else if (congs_PaperGroup.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_PaperGroup.OrderNum);
}
else if (congs_PaperGroup.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_PaperGroup.UpdDate);
}
else if (congs_PaperGroup.Meno  ==  AttributeName[intIndex])
{
mstrMeno = value.ToString();
 AddUpdatedFld(congs_PaperGroup.Meno);
}
}
}

/// <summary>
/// 组Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperGroupId
{
get
{
return mstrPaperGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperGroupId = value;
}
else
{
 mstrPaperGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperGroup.PaperGroupId);
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperGroupName
{
get
{
return mstrPaperGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperGroupName = value;
}
else
{
 mstrPaperGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperGroup.PaperGroupName);
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
 AddUpdatedFld(congs_PaperGroup.UpdUser);
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
 AddUpdatedFld(congs_PaperGroup.OrderNum);
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
 AddUpdatedFld(congs_PaperGroup.UpdDate);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Meno
{
get
{
return mstrMeno;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMeno = value;
}
else
{
 mstrMeno = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperGroup.Meno);
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
  return mstrPaperGroupId;
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
  return mstrPaperGroupName;
 }
 }
}
 /// <summary>
 /// 论文分组(gs_PaperGroup)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_PaperGroup
{
public const string _CurrTabName = "gs_PaperGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperGroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperGroupId", "PaperGroupName", "UpdUser", "OrderNum", "UpdDate", "Meno"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperGroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperGroupId = "PaperGroupId";    //组Id

 /// <summary>
 /// 常量:"PaperGroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperGroupName = "PaperGroupName";    //组名

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Meno"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Meno = "Meno";    //备注
}

}