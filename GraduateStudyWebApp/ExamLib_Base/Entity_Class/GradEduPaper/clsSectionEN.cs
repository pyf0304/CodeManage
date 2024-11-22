
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSectionEN
 表名:Section(01120558)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:05
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
 /// 表Section的关键字(SectionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SectionId_Section
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSectionId">表关键字</param>
public K_SectionId_Section(string strSectionId)
{
if (IsValid(strSectionId)) Value = strSectionId;
else
{
Value = null;
}
}
private static bool IsValid(string strSectionId)
{
if (string.IsNullOrEmpty(strSectionId) == true) return false;
if (strSectionId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SectionId_Section]类型的对象</returns>
public static implicit operator K_SectionId_Section(string value)
{
return new K_SectionId_Section(value);
}
}
 /// <summary>
 /// 论文节表(Section)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSectionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Section"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SectionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"SectionId", "SectionName", "PaperId", "ParentId", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected string mstrSectionId;    //节Id
protected string mstrSectionName;    //节名
protected string mstrPaperId;    //论文Id
protected string mstrParentId;    //父节点Id
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSectionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SectionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSectionId">关键字:节Id</param>
public clsSectionEN(string strSectionId)
 {
strSectionId = strSectionId.Replace("'", "''");
if (strSectionId.Length > 8)
{
throw new Exception("在表:Section中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSectionId)  ==  true)
{
throw new Exception("在表:Section中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSectionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSectionId = strSectionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SectionId");
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
if (strAttributeName  ==  conSection.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  conSection.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  conSection.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  conSection.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  conSection.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conSection.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSection.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conSection.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSection.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(conSection.SectionId);
}
else if (strAttributeName  ==  conSection.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(conSection.SectionName);
}
else if (strAttributeName  ==  conSection.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conSection.PaperId);
}
else if (strAttributeName  ==  conSection.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(conSection.ParentId);
}
else if (strAttributeName  ==  conSection.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSection.OrderNum);
}
else if (strAttributeName  ==  conSection.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSection.UpdDate);
}
else if (strAttributeName  ==  conSection.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSection.UpdUser);
}
else if (strAttributeName  ==  conSection.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSection.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSection.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (conSection.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (conSection.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (conSection.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (conSection.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conSection.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSection.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conSection.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSection.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(conSection.SectionId);
}
else if (conSection.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(conSection.SectionName);
}
else if (conSection.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conSection.PaperId);
}
else if (conSection.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(conSection.ParentId);
}
else if (conSection.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSection.OrderNum);
}
else if (conSection.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSection.UpdDate);
}
else if (conSection.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSection.UpdUser);
}
else if (conSection.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSection.Memo);
}
}
}

/// <summary>
/// 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionId
{
get
{
return mstrSectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionId = value;
}
else
{
 mstrSectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSection.SectionId);
}
}
/// <summary>
/// 节名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionName
{
get
{
return mstrSectionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionName = value;
}
else
{
 mstrSectionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSection.SectionName);
}
}
/// <summary>
/// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperId
{
get
{
return mstrPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperId = value;
}
else
{
 mstrPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSection.PaperId);
}
}
/// <summary>
/// 父节点Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentId
{
get
{
return mstrParentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentId = value;
}
else
{
 mstrParentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSection.ParentId);
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
 AddUpdatedFld(conSection.OrderNum);
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
 AddUpdatedFld(conSection.UpdDate);
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
 AddUpdatedFld(conSection.UpdUser);
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
 AddUpdatedFld(conSection.Memo);
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
  return mstrSectionId;
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
  return mstrSectionName;
 }
 }
}
 /// <summary>
 /// 论文节表(Section)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSection
{
public const string _CurrTabName = "Section"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SectionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SectionId", "SectionName", "PaperId", "ParentId", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"SectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionId = "SectionId";    //节Id

 /// <summary>
 /// 常量:"SectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionName = "SectionName";    //节名

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"ParentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentId = "ParentId";    //父节点Id

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