
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_GroupTextRelaEN
 表名:zx_GroupTextRela(01120735)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:56
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
 /// 表zx_GroupTextRela的关键字(GroupTextRelaId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_GroupTextRelaId_zx_GroupTextRela
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strGroupTextRelaId">表关键字</param>
public K_GroupTextRelaId_zx_GroupTextRela(string strGroupTextRelaId)
{
if (IsValid(strGroupTextRelaId)) Value = strGroupTextRelaId;
else
{
Value = null;
}
}
private static bool IsValid(string strGroupTextRelaId)
{
if (string.IsNullOrEmpty(strGroupTextRelaId) == true) return false;
if (strGroupTextRelaId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_GroupTextRelaId_zx_GroupTextRela]类型的对象</returns>
public static implicit operator K_GroupTextRelaId_zx_GroupTextRela(string value)
{
return new K_GroupTextRelaId_zx_GroupTextRela(value);
}
}
 /// <summary>
 /// 小组课文关系表(zx_GroupTextRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_GroupTextRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_GroupTextRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "GroupTextRelaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"GroupTextRelaId", "GroupTextId", "TextId", "UpdUser", "UpdDate", "Memo"};

protected string mstrGroupTextRelaId;    //主键
protected string mstrGroupTextId;    //小组Id
protected string mstrTextId;    //课件Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_GroupTextRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GroupTextRelaId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strGroupTextRelaId">关键字:主键</param>
public clszx_GroupTextRelaEN(string strGroupTextRelaId)
 {
strGroupTextRelaId = strGroupTextRelaId.Replace("'", "''");
if (strGroupTextRelaId.Length > 8)
{
throw new Exception("在表:zx_GroupTextRela中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strGroupTextRelaId)  ==  true)
{
throw new Exception("在表:zx_GroupTextRela中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGroupTextRelaId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrGroupTextRelaId = strGroupTextRelaId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GroupTextRelaId");
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
if (strAttributeName  ==  conzx_GroupTextRela.GroupTextRelaId)
{
return mstrGroupTextRelaId;
}
else if (strAttributeName  ==  conzx_GroupTextRela.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  conzx_GroupTextRela.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  conzx_GroupTextRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_GroupTextRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_GroupTextRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_GroupTextRela.GroupTextRelaId)
{
mstrGroupTextRelaId = value.ToString();
 AddUpdatedFld(conzx_GroupTextRela.GroupTextRelaId);
}
else if (strAttributeName  ==  conzx_GroupTextRela.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_GroupTextRela.GroupTextId);
}
else if (strAttributeName  ==  conzx_GroupTextRela.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_GroupTextRela.TextId);
}
else if (strAttributeName  ==  conzx_GroupTextRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_GroupTextRela.UpdUser);
}
else if (strAttributeName  ==  conzx_GroupTextRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_GroupTextRela.UpdDate);
}
else if (strAttributeName  ==  conzx_GroupTextRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_GroupTextRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_GroupTextRela.GroupTextRelaId  ==  AttributeName[intIndex])
{
return mstrGroupTextRelaId;
}
else if (conzx_GroupTextRela.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (conzx_GroupTextRela.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (conzx_GroupTextRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_GroupTextRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_GroupTextRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_GroupTextRela.GroupTextRelaId  ==  AttributeName[intIndex])
{
mstrGroupTextRelaId = value.ToString();
 AddUpdatedFld(conzx_GroupTextRela.GroupTextRelaId);
}
else if (conzx_GroupTextRela.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_GroupTextRela.GroupTextId);
}
else if (conzx_GroupTextRela.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_GroupTextRela.TextId);
}
else if (conzx_GroupTextRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_GroupTextRela.UpdUser);
}
else if (conzx_GroupTextRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_GroupTextRela.UpdDate);
}
else if (conzx_GroupTextRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_GroupTextRela.Memo);
}
}
}

/// <summary>
/// 主键(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextRelaId
{
get
{
return mstrGroupTextRelaId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextRelaId = value;
}
else
{
 mstrGroupTextRelaId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_GroupTextRela.GroupTextRelaId);
}
}
/// <summary>
/// 小组Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextId
{
get
{
return mstrGroupTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextId = value;
}
else
{
 mstrGroupTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_GroupTextRela.GroupTextId);
}
}
/// <summary>
/// 课件Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextId
{
get
{
return mstrTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextId = value;
}
else
{
 mstrTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_GroupTextRela.TextId);
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
 AddUpdatedFld(conzx_GroupTextRela.UpdUser);
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
 AddUpdatedFld(conzx_GroupTextRela.UpdDate);
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
 AddUpdatedFld(conzx_GroupTextRela.Memo);
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
  return mstrGroupTextRelaId;
 }
 }
}
 /// <summary>
 /// 小组课文关系表(zx_GroupTextRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_GroupTextRela
{
public const string _CurrTabName = "zx_GroupTextRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "GroupTextRelaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"GroupTextRelaId", "GroupTextId", "TextId", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"GroupTextRelaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextRelaId = "GroupTextRelaId";    //主键

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

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