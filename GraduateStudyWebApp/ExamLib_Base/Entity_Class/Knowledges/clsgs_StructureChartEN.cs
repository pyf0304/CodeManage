
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_StructureChartEN
 表名:gs_StructureChart(01120878)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:58
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表gs_StructureChart的关键字(StructureChartId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_StructureChartId_gs_StructureChart
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strStructureChartId">表关键字</param>
public K_StructureChartId_gs_StructureChart(string strStructureChartId)
{
if (IsValid(strStructureChartId)) Value = strStructureChartId;
else
{
Value = null;
}
}
private static bool IsValid(string strStructureChartId)
{
if (string.IsNullOrEmpty(strStructureChartId) == true) return false;
if (strStructureChartId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_StructureChartId_gs_StructureChart]类型的对象</returns>
public static implicit operator K_StructureChartId_gs_StructureChart(string value)
{
return new K_StructureChartId_gs_StructureChart(value);
}
}
 /// <summary>
 /// 结构图表(gs_StructureChart)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_StructureChartEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_StructureChart"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "StructureChartId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"StructureChartId", "StructureChartTitle", "IdCurrEduCls", "CreateUser", "UpdDate", "UpdUser", "Memo"};

protected string mstrStructureChartId;    //结构图Id
protected string mstrStructureChartTitle;    //结构图标题
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCreateUser;    //建立用户
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_StructureChartEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StructureChartId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strStructureChartId">关键字:结构图Id</param>
public clsgs_StructureChartEN(string strStructureChartId)
 {
strStructureChartId = strStructureChartId.Replace("'", "''");
if (strStructureChartId.Length > 10)
{
throw new Exception("在表:gs_StructureChart中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strStructureChartId)  ==  true)
{
throw new Exception("在表:gs_StructureChart中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStructureChartId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrStructureChartId = strStructureChartId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StructureChartId");
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
if (strAttributeName  ==  congs_StructureChart.StructureChartId)
{
return mstrStructureChartId;
}
else if (strAttributeName  ==  congs_StructureChart.StructureChartTitle)
{
return mstrStructureChartTitle;
}
else if (strAttributeName  ==  congs_StructureChart.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  congs_StructureChart.CreateUser)
{
return mstrCreateUser;
}
else if (strAttributeName  ==  congs_StructureChart.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_StructureChart.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_StructureChart.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_StructureChart.StructureChartId)
{
mstrStructureChartId = value.ToString();
 AddUpdatedFld(congs_StructureChart.StructureChartId);
}
else if (strAttributeName  ==  congs_StructureChart.StructureChartTitle)
{
mstrStructureChartTitle = value.ToString();
 AddUpdatedFld(congs_StructureChart.StructureChartTitle);
}
else if (strAttributeName  ==  congs_StructureChart.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_StructureChart.IdCurrEduCls);
}
else if (strAttributeName  ==  congs_StructureChart.CreateUser)
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(congs_StructureChart.CreateUser);
}
else if (strAttributeName  ==  congs_StructureChart.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_StructureChart.UpdDate);
}
else if (strAttributeName  ==  congs_StructureChart.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_StructureChart.UpdUser);
}
else if (strAttributeName  ==  congs_StructureChart.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_StructureChart.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_StructureChart.StructureChartId  ==  AttributeName[intIndex])
{
return mstrStructureChartId;
}
else if (congs_StructureChart.StructureChartTitle  ==  AttributeName[intIndex])
{
return mstrStructureChartTitle;
}
else if (congs_StructureChart.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (congs_StructureChart.CreateUser  ==  AttributeName[intIndex])
{
return mstrCreateUser;
}
else if (congs_StructureChart.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_StructureChart.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_StructureChart.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_StructureChart.StructureChartId  ==  AttributeName[intIndex])
{
mstrStructureChartId = value.ToString();
 AddUpdatedFld(congs_StructureChart.StructureChartId);
}
else if (congs_StructureChart.StructureChartTitle  ==  AttributeName[intIndex])
{
mstrStructureChartTitle = value.ToString();
 AddUpdatedFld(congs_StructureChart.StructureChartTitle);
}
else if (congs_StructureChart.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_StructureChart.IdCurrEduCls);
}
else if (congs_StructureChart.CreateUser  ==  AttributeName[intIndex])
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(congs_StructureChart.CreateUser);
}
else if (congs_StructureChart.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_StructureChart.UpdDate);
}
else if (congs_StructureChart.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_StructureChart.UpdUser);
}
else if (congs_StructureChart.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_StructureChart.Memo);
}
}
}

/// <summary>
/// 结构图Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StructureChartId
{
get
{
return mstrStructureChartId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStructureChartId = value;
}
else
{
 mstrStructureChartId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_StructureChart.StructureChartId);
}
}
/// <summary>
/// 结构图标题(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StructureChartTitle
{
get
{
return mstrStructureChartTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStructureChartTitle = value;
}
else
{
 mstrStructureChartTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_StructureChart.StructureChartTitle);
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
 AddUpdatedFld(congs_StructureChart.IdCurrEduCls);
}
}
/// <summary>
/// 建立用户(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateUser
{
get
{
return mstrCreateUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateUser = value;
}
else
{
 mstrCreateUser = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_StructureChart.CreateUser);
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
 AddUpdatedFld(congs_StructureChart.UpdDate);
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
 AddUpdatedFld(congs_StructureChart.UpdUser);
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
 AddUpdatedFld(congs_StructureChart.Memo);
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
  return mstrStructureChartId;
 }
 }
}
 /// <summary>
 /// 结构图表(gs_StructureChart)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_StructureChart
{
public const string _CurrTabName = "gs_StructureChart"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "StructureChartId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"StructureChartId", "StructureChartTitle", "IdCurrEduCls", "CreateUser", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"StructureChartId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StructureChartId = "StructureChartId";    //结构图Id

 /// <summary>
 /// 常量:"StructureChartTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StructureChartTitle = "StructureChartTitle";    //结构图标题

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"CreateUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateUser = "CreateUser";    //建立用户

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