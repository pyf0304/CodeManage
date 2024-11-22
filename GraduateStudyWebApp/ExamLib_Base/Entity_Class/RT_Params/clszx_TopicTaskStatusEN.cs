
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TopicTaskStatusEN
 表名:zx_TopicTaskStatus(01120823)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:54:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 表zx_TopicTaskStatus的关键字(zxStatusId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxStatusId_zx_TopicTaskStatus
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxStatusId">表关键字</param>
public K_zxStatusId_zx_TopicTaskStatus(string strzxStatusId)
{
if (IsValid(strzxStatusId)) Value = strzxStatusId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxStatusId)
{
if (string.IsNullOrEmpty(strzxStatusId) == true) return false;
if (strzxStatusId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxStatusId_zx_TopicTaskStatus]类型的对象</returns>
public static implicit operator K_zxStatusId_zx_TopicTaskStatus(string value)
{
return new K_zxStatusId_zx_TopicTaskStatus(value);
}
}
 /// <summary>
 /// 中学主题任务状态(zx_TopicTaskStatus)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_TopicTaskStatusEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_TopicTaskStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxStatusId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"zxStatusId", "StatusName", "UpdUser", "UpdDate", "Memo"};

protected string mstrzxStatusId;    //状态Id
protected string mstrStatusName;    //状态名称
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_TopicTaskStatusEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxStatusId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxStatusId">关键字:状态Id</param>
public clszx_TopicTaskStatusEN(string strzxStatusId)
 {
strzxStatusId = strzxStatusId.Replace("'", "''");
if (strzxStatusId.Length > 2)
{
throw new Exception("在表:zx_TopicTaskStatus中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxStatusId)  ==  true)
{
throw new Exception("在表:zx_TopicTaskStatus中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxStatusId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxStatusId = strzxStatusId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxStatusId");
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
if (strAttributeName  ==  conzx_TopicTaskStatus.zxStatusId)
{
return mstrzxStatusId;
}
else if (strAttributeName  ==  conzx_TopicTaskStatus.StatusName)
{
return mstrStatusName;
}
else if (strAttributeName  ==  conzx_TopicTaskStatus.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_TopicTaskStatus.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_TopicTaskStatus.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_TopicTaskStatus.zxStatusId)
{
mstrzxStatusId = value.ToString();
 AddUpdatedFld(conzx_TopicTaskStatus.zxStatusId);
}
else if (strAttributeName  ==  conzx_TopicTaskStatus.StatusName)
{
mstrStatusName = value.ToString();
 AddUpdatedFld(conzx_TopicTaskStatus.StatusName);
}
else if (strAttributeName  ==  conzx_TopicTaskStatus.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TopicTaskStatus.UpdUser);
}
else if (strAttributeName  ==  conzx_TopicTaskStatus.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TopicTaskStatus.UpdDate);
}
else if (strAttributeName  ==  conzx_TopicTaskStatus.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TopicTaskStatus.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_TopicTaskStatus.zxStatusId  ==  AttributeName[intIndex])
{
return mstrzxStatusId;
}
else if (conzx_TopicTaskStatus.StatusName  ==  AttributeName[intIndex])
{
return mstrStatusName;
}
else if (conzx_TopicTaskStatus.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_TopicTaskStatus.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_TopicTaskStatus.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_TopicTaskStatus.zxStatusId  ==  AttributeName[intIndex])
{
mstrzxStatusId = value.ToString();
 AddUpdatedFld(conzx_TopicTaskStatus.zxStatusId);
}
else if (conzx_TopicTaskStatus.StatusName  ==  AttributeName[intIndex])
{
mstrStatusName = value.ToString();
 AddUpdatedFld(conzx_TopicTaskStatus.StatusName);
}
else if (conzx_TopicTaskStatus.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TopicTaskStatus.UpdUser);
}
else if (conzx_TopicTaskStatus.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TopicTaskStatus.UpdDate);
}
else if (conzx_TopicTaskStatus.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TopicTaskStatus.Memo);
}
}
}

/// <summary>
/// 状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxStatusId
{
get
{
return mstrzxStatusId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxStatusId = value;
}
else
{
 mstrzxStatusId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TopicTaskStatus.zxStatusId);
}
}
/// <summary>
/// 状态名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StatusName
{
get
{
return mstrStatusName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStatusName = value;
}
else
{
 mstrStatusName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TopicTaskStatus.StatusName);
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
 AddUpdatedFld(conzx_TopicTaskStatus.UpdUser);
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
 AddUpdatedFld(conzx_TopicTaskStatus.UpdDate);
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
 AddUpdatedFld(conzx_TopicTaskStatus.Memo);
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
  return mstrzxStatusId;
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
  return mstrStatusName;
 }
 }
}
 /// <summary>
 /// 中学主题任务状态(zx_TopicTaskStatus)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_TopicTaskStatus
{
public const string _CurrTabName = "zx_TopicTaskStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxStatusId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxStatusId", "StatusName", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxStatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxStatusId = "zxStatusId";    //状态Id

 /// <summary>
 /// 常量:"StatusName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StatusName = "StatusName";    //状态名称

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}