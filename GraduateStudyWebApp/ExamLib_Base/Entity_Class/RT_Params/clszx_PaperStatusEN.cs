
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_PaperStatusEN
 表名:zx_PaperStatus(01120818)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:54:41
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
 /// 表zx_PaperStatus的关键字(zxPaperStatusId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxPaperStatusId_zx_PaperStatus
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxPaperStatusId">表关键字</param>
public K_zxPaperStatusId_zx_PaperStatus(string strzxPaperStatusId)
{
if (IsValid(strzxPaperStatusId)) Value = strzxPaperStatusId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxPaperStatusId)
{
if (string.IsNullOrEmpty(strzxPaperStatusId) == true) return false;
if (strzxPaperStatusId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxPaperStatusId_zx_PaperStatus]类型的对象</returns>
public static implicit operator K_zxPaperStatusId_zx_PaperStatus(string value)
{
return new K_zxPaperStatusId_zx_PaperStatus(value);
}
}
 /// <summary>
 /// 中学论文状态表(zx_PaperStatus)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_PaperStatusEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_PaperStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxPaperStatusId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"zxPaperStatusId", "PaperStatusName", "UpdUser", "UpdDate", "Memo"};

protected string mstrzxPaperStatusId;    //论文状态Id
protected string mstrPaperStatusName;    //论文状态名
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_PaperStatusEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxPaperStatusId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxPaperStatusId">关键字:论文状态Id</param>
public clszx_PaperStatusEN(string strzxPaperStatusId)
 {
strzxPaperStatusId = strzxPaperStatusId.Replace("'", "''");
if (strzxPaperStatusId.Length > 2)
{
throw new Exception("在表:zx_PaperStatus中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxPaperStatusId)  ==  true)
{
throw new Exception("在表:zx_PaperStatus中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxPaperStatusId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxPaperStatusId = strzxPaperStatusId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxPaperStatusId");
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
if (strAttributeName  ==  conzx_PaperStatus.zxPaperStatusId)
{
return mstrzxPaperStatusId;
}
else if (strAttributeName  ==  conzx_PaperStatus.PaperStatusName)
{
return mstrPaperStatusName;
}
else if (strAttributeName  ==  conzx_PaperStatus.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_PaperStatus.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_PaperStatus.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_PaperStatus.zxPaperStatusId)
{
mstrzxPaperStatusId = value.ToString();
 AddUpdatedFld(conzx_PaperStatus.zxPaperStatusId);
}
else if (strAttributeName  ==  conzx_PaperStatus.PaperStatusName)
{
mstrPaperStatusName = value.ToString();
 AddUpdatedFld(conzx_PaperStatus.PaperStatusName);
}
else if (strAttributeName  ==  conzx_PaperStatus.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_PaperStatus.UpdUser);
}
else if (strAttributeName  ==  conzx_PaperStatus.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_PaperStatus.UpdDate);
}
else if (strAttributeName  ==  conzx_PaperStatus.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_PaperStatus.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_PaperStatus.zxPaperStatusId  ==  AttributeName[intIndex])
{
return mstrzxPaperStatusId;
}
else if (conzx_PaperStatus.PaperStatusName  ==  AttributeName[intIndex])
{
return mstrPaperStatusName;
}
else if (conzx_PaperStatus.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_PaperStatus.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_PaperStatus.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_PaperStatus.zxPaperStatusId  ==  AttributeName[intIndex])
{
mstrzxPaperStatusId = value.ToString();
 AddUpdatedFld(conzx_PaperStatus.zxPaperStatusId);
}
else if (conzx_PaperStatus.PaperStatusName  ==  AttributeName[intIndex])
{
mstrPaperStatusName = value.ToString();
 AddUpdatedFld(conzx_PaperStatus.PaperStatusName);
}
else if (conzx_PaperStatus.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_PaperStatus.UpdUser);
}
else if (conzx_PaperStatus.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_PaperStatus.UpdDate);
}
else if (conzx_PaperStatus.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_PaperStatus.Memo);
}
}
}

/// <summary>
/// 论文状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxPaperStatusId
{
get
{
return mstrzxPaperStatusId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxPaperStatusId = value;
}
else
{
 mstrzxPaperStatusId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_PaperStatus.zxPaperStatusId);
}
}
/// <summary>
/// 论文状态名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperStatusName
{
get
{
return mstrPaperStatusName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperStatusName = value;
}
else
{
 mstrPaperStatusName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_PaperStatus.PaperStatusName);
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
 AddUpdatedFld(conzx_PaperStatus.UpdUser);
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
 AddUpdatedFld(conzx_PaperStatus.UpdDate);
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
 AddUpdatedFld(conzx_PaperStatus.Memo);
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
  return mstrzxPaperStatusId;
 }
 }
}
 /// <summary>
 /// 中学论文状态表(zx_PaperStatus)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_PaperStatus
{
public const string _CurrTabName = "zx_PaperStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxPaperStatusId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxPaperStatusId", "PaperStatusName", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxPaperStatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxPaperStatusId = "zxPaperStatusId";    //论文状态Id

 /// <summary>
 /// 常量:"PaperStatusName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperStatusName = "PaperStatusName";    //论文状态名

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