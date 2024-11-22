
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clske_SubEN
 表名:ke_Sub(01120660)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表ke_Sub的关键字(KeSubId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_KeSubId_ke_Sub
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strKeSubId">表关键字</param>
public K_KeSubId_ke_Sub(string strKeSubId)
{
if (IsValid(strKeSubId)) Value = strKeSubId;
else
{
Value = null;
}
}
private static bool IsValid(string strKeSubId)
{
if (string.IsNullOrEmpty(strKeSubId) == true) return false;
if (strKeSubId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_KeSubId_ke_Sub]类型的对象</returns>
public static implicit operator K_KeSubId_ke_Sub(string value)
{
return new K_KeSubId_ke_Sub(value);
}
}
 /// <summary>
 /// 知识经济子类(ke_Sub)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clske_SubEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ke_Sub"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "KeSubId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"KeSubId", "KeSuperId", "KeSubNameCn", "KeSubNameEn", "KeSubDescribeCn", "KeSubDescribeEn", "UpdDate", "UpdUser", "Memo", "Link"};

protected string mstrKeSubId;    //知识子类Id
protected string mstrKeSuperId;    //知识分类Id
protected string mstrKeSubNameCn;    //知识子类名
protected string mstrKeSubNameEn;    //知识子类英文名
protected string mstrKeSubDescribeCn;    //知识子类描述
protected string mstrKeSubDescribeEn;    //知识子类英文描述
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrLink;    //相应链接

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clske_SubEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("KeSubId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strKeSubId">关键字:知识子类Id</param>
public clske_SubEN(string strKeSubId)
 {
strKeSubId = strKeSubId.Replace("'", "''");
if (strKeSubId.Length > 4)
{
throw new Exception("在表:ke_Sub中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strKeSubId)  ==  true)
{
throw new Exception("在表:ke_Sub中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strKeSubId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrKeSubId = strKeSubId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("KeSubId");
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
if (strAttributeName  ==  conke_Sub.KeSubId)
{
return mstrKeSubId;
}
else if (strAttributeName  ==  conke_Sub.KeSuperId)
{
return mstrKeSuperId;
}
else if (strAttributeName  ==  conke_Sub.KeSubNameCn)
{
return mstrKeSubNameCn;
}
else if (strAttributeName  ==  conke_Sub.KeSubNameEn)
{
return mstrKeSubNameEn;
}
else if (strAttributeName  ==  conke_Sub.KeSubDescribeCn)
{
return mstrKeSubDescribeCn;
}
else if (strAttributeName  ==  conke_Sub.KeSubDescribeEn)
{
return mstrKeSubDescribeEn;
}
else if (strAttributeName  ==  conke_Sub.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conke_Sub.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conke_Sub.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conke_Sub.Link)
{
return mstrLink;
}
return null;
}
set
{
if (strAttributeName  ==  conke_Sub.KeSubId)
{
mstrKeSubId = value.ToString();
 AddUpdatedFld(conke_Sub.KeSubId);
}
else if (strAttributeName  ==  conke_Sub.KeSuperId)
{
mstrKeSuperId = value.ToString();
 AddUpdatedFld(conke_Sub.KeSuperId);
}
else if (strAttributeName  ==  conke_Sub.KeSubNameCn)
{
mstrKeSubNameCn = value.ToString();
 AddUpdatedFld(conke_Sub.KeSubNameCn);
}
else if (strAttributeName  ==  conke_Sub.KeSubNameEn)
{
mstrKeSubNameEn = value.ToString();
 AddUpdatedFld(conke_Sub.KeSubNameEn);
}
else if (strAttributeName  ==  conke_Sub.KeSubDescribeCn)
{
mstrKeSubDescribeCn = value.ToString();
 AddUpdatedFld(conke_Sub.KeSubDescribeCn);
}
else if (strAttributeName  ==  conke_Sub.KeSubDescribeEn)
{
mstrKeSubDescribeEn = value.ToString();
 AddUpdatedFld(conke_Sub.KeSubDescribeEn);
}
else if (strAttributeName  ==  conke_Sub.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conke_Sub.UpdDate);
}
else if (strAttributeName  ==  conke_Sub.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conke_Sub.UpdUser);
}
else if (strAttributeName  ==  conke_Sub.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conke_Sub.Memo);
}
else if (strAttributeName  ==  conke_Sub.Link)
{
mstrLink = value.ToString();
 AddUpdatedFld(conke_Sub.Link);
}
}
}
public object this[int intIndex]
{
get
{
if (conke_Sub.KeSubId  ==  AttributeName[intIndex])
{
return mstrKeSubId;
}
else if (conke_Sub.KeSuperId  ==  AttributeName[intIndex])
{
return mstrKeSuperId;
}
else if (conke_Sub.KeSubNameCn  ==  AttributeName[intIndex])
{
return mstrKeSubNameCn;
}
else if (conke_Sub.KeSubNameEn  ==  AttributeName[intIndex])
{
return mstrKeSubNameEn;
}
else if (conke_Sub.KeSubDescribeCn  ==  AttributeName[intIndex])
{
return mstrKeSubDescribeCn;
}
else if (conke_Sub.KeSubDescribeEn  ==  AttributeName[intIndex])
{
return mstrKeSubDescribeEn;
}
else if (conke_Sub.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conke_Sub.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conke_Sub.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conke_Sub.Link  ==  AttributeName[intIndex])
{
return mstrLink;
}
return null;
}
set
{
if (conke_Sub.KeSubId  ==  AttributeName[intIndex])
{
mstrKeSubId = value.ToString();
 AddUpdatedFld(conke_Sub.KeSubId);
}
else if (conke_Sub.KeSuperId  ==  AttributeName[intIndex])
{
mstrKeSuperId = value.ToString();
 AddUpdatedFld(conke_Sub.KeSuperId);
}
else if (conke_Sub.KeSubNameCn  ==  AttributeName[intIndex])
{
mstrKeSubNameCn = value.ToString();
 AddUpdatedFld(conke_Sub.KeSubNameCn);
}
else if (conke_Sub.KeSubNameEn  ==  AttributeName[intIndex])
{
mstrKeSubNameEn = value.ToString();
 AddUpdatedFld(conke_Sub.KeSubNameEn);
}
else if (conke_Sub.KeSubDescribeCn  ==  AttributeName[intIndex])
{
mstrKeSubDescribeCn = value.ToString();
 AddUpdatedFld(conke_Sub.KeSubDescribeCn);
}
else if (conke_Sub.KeSubDescribeEn  ==  AttributeName[intIndex])
{
mstrKeSubDescribeEn = value.ToString();
 AddUpdatedFld(conke_Sub.KeSubDescribeEn);
}
else if (conke_Sub.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conke_Sub.UpdDate);
}
else if (conke_Sub.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conke_Sub.UpdUser);
}
else if (conke_Sub.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conke_Sub.Memo);
}
else if (conke_Sub.Link  ==  AttributeName[intIndex])
{
mstrLink = value.ToString();
 AddUpdatedFld(conke_Sub.Link);
}
}
}

/// <summary>
/// 知识子类Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSubId
{
get
{
return mstrKeSubId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSubId = value;
}
else
{
 mstrKeSubId = value;
}
//记录修改过的字段
 AddUpdatedFld(conke_Sub.KeSubId);
}
}
/// <summary>
/// 知识分类Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSuperId
{
get
{
return mstrKeSuperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSuperId = value;
}
else
{
 mstrKeSuperId = value;
}
//记录修改过的字段
 AddUpdatedFld(conke_Sub.KeSuperId);
}
}
/// <summary>
/// 知识子类名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSubNameCn
{
get
{
return mstrKeSubNameCn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSubNameCn = value;
}
else
{
 mstrKeSubNameCn = value;
}
//记录修改过的字段
 AddUpdatedFld(conke_Sub.KeSubNameCn);
}
}
/// <summary>
/// 知识子类英文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSubNameEn
{
get
{
return mstrKeSubNameEn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSubNameEn = value;
}
else
{
 mstrKeSubNameEn = value;
}
//记录修改过的字段
 AddUpdatedFld(conke_Sub.KeSubNameEn);
}
}
/// <summary>
/// 知识子类描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSubDescribeCn
{
get
{
return mstrKeSubDescribeCn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSubDescribeCn = value;
}
else
{
 mstrKeSubDescribeCn = value;
}
//记录修改过的字段
 AddUpdatedFld(conke_Sub.KeSubDescribeCn);
}
}
/// <summary>
/// 知识子类英文描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSubDescribeEn
{
get
{
return mstrKeSubDescribeEn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSubDescribeEn = value;
}
else
{
 mstrKeSubDescribeEn = value;
}
//记录修改过的字段
 AddUpdatedFld(conke_Sub.KeSubDescribeEn);
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
 AddUpdatedFld(conke_Sub.UpdDate);
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
 AddUpdatedFld(conke_Sub.UpdUser);
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
 AddUpdatedFld(conke_Sub.Memo);
}
}
/// <summary>
/// 相应链接(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Link
{
get
{
return mstrLink;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLink = value;
}
else
{
 mstrLink = value;
}
//记录修改过的字段
 AddUpdatedFld(conke_Sub.Link);
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
  return mstrKeSubId;
 }
 }
}
 /// <summary>
 /// 知识经济子类(ke_Sub)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conke_Sub
{
public const string _CurrTabName = "ke_Sub"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "KeSubId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"KeSubId", "KeSuperId", "KeSubNameCn", "KeSubNameEn", "KeSubDescribeCn", "KeSubDescribeEn", "UpdDate", "UpdUser", "Memo", "Link"};
//以下是属性变量


 /// <summary>
 /// 常量:"KeSubId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSubId = "KeSubId";    //知识子类Id

 /// <summary>
 /// 常量:"KeSuperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSuperId = "KeSuperId";    //知识分类Id

 /// <summary>
 /// 常量:"KeSubNameCn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSubNameCn = "KeSubNameCn";    //知识子类名

 /// <summary>
 /// 常量:"KeSubNameEn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSubNameEn = "KeSubNameEn";    //知识子类英文名

 /// <summary>
 /// 常量:"KeSubDescribeCn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSubDescribeCn = "KeSubDescribeCn";    //知识子类描述

 /// <summary>
 /// 常量:"KeSubDescribeEn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSubDescribeEn = "KeSubDescribeEn";    //知识子类英文描述

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

 /// <summary>
 /// 常量:"Link"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Link = "Link";    //相应链接
}

}