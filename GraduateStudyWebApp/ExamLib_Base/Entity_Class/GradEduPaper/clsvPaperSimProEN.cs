
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSimProEN
 表名:vPaperSimPro(01120944)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:21:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表vPaperSimPro的关键字(PaperId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperId_vPaperSimPro
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPaperId">表关键字</param>
public K_PaperId_vPaperSimPro(string strPaperId)
{
if (IsValid(strPaperId)) Value = strPaperId;
else
{
Value = null;
}
}
private static bool IsValid(string strPaperId)
{
if (string.IsNullOrEmpty(strPaperId) == true) return false;
if (strPaperId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperId_vPaperSimPro]类型的对象</returns>
public static implicit operator K_PaperId_vPaperSimPro(string value)
{
return new K_PaperId_vPaperSimPro(value);
}
}
 /// <summary>
 /// vPaperSimPro(vPaperSimPro)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPaperSimProEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPaperSimPro"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = "PaperId in (Select PaperId from PaperEduClsRela where IdCurrEduCls='{0}')"; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"PaperId", "PaperTitle", "PaperContent", "Periodical", "Author"};

protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected string mstrPaperContent;    //主题内容
protected string mstrPeriodical;    //期刊
protected string mstrAuthor;    //作者

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPaperSimProEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPaperId">关键字:论文Id</param>
public clsvPaperSimProEN(string strPaperId)
 {
strPaperId = strPaperId.Replace("'", "''");
if (strPaperId.Length > 8)
{
throw new Exception("在表:vPaperSimPro中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPaperId)  ==  true)
{
throw new Exception("在表:vPaperSimPro中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPaperId = strPaperId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperId");
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
if (strAttributeName  ==  convPaperSimPro.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convPaperSimPro.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convPaperSimPro.PaperContent)
{
return mstrPaperContent;
}
else if (strAttributeName  ==  convPaperSimPro.Periodical)
{
return mstrPeriodical;
}
else if (strAttributeName  ==  convPaperSimPro.Author)
{
return mstrAuthor;
}
return null;
}
set
{
if (strAttributeName  ==  convPaperSimPro.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperSimPro.PaperId);
}
else if (strAttributeName  ==  convPaperSimPro.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperSimPro.PaperTitle);
}
else if (strAttributeName  ==  convPaperSimPro.PaperContent)
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convPaperSimPro.PaperContent);
}
else if (strAttributeName  ==  convPaperSimPro.Periodical)
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convPaperSimPro.Periodical);
}
else if (strAttributeName  ==  convPaperSimPro.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convPaperSimPro.Author);
}
}
}
public object this[int intIndex]
{
get
{
if (convPaperSimPro.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convPaperSimPro.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convPaperSimPro.PaperContent  ==  AttributeName[intIndex])
{
return mstrPaperContent;
}
else if (convPaperSimPro.Periodical  ==  AttributeName[intIndex])
{
return mstrPeriodical;
}
else if (convPaperSimPro.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
return null;
}
set
{
if (convPaperSimPro.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperSimPro.PaperId);
}
else if (convPaperSimPro.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperSimPro.PaperTitle);
}
else if (convPaperSimPro.PaperContent  ==  AttributeName[intIndex])
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convPaperSimPro.PaperContent);
}
else if (convPaperSimPro.Periodical  ==  AttributeName[intIndex])
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convPaperSimPro.Periodical);
}
else if (convPaperSimPro.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convPaperSimPro.Author);
}
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
 AddUpdatedFld(convPaperSimPro.PaperId);
}
}
/// <summary>
/// 论文标题(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTitle
{
get
{
return mstrPaperTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTitle = value;
}
else
{
 mstrPaperTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSimPro.PaperTitle);
}
}
/// <summary>
/// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperContent
{
get
{
return mstrPaperContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperContent = value;
}
else
{
 mstrPaperContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSimPro.PaperContent);
}
}
/// <summary>
/// 期刊(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Periodical
{
get
{
return mstrPeriodical;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPeriodical = value;
}
else
{
 mstrPeriodical = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSimPro.Periodical);
}
}
/// <summary>
/// 作者(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Author
{
get
{
return mstrAuthor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAuthor = value;
}
else
{
 mstrAuthor = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSimPro.Author);
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
  return mstrPaperId;
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
  return mstrPaperTitle;
 }
 }
}
 /// <summary>
 /// vPaperSimPro(vPaperSimPro)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPaperSimPro
{
public const string _CurrTabName = "vPaperSimPro"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperId", "PaperTitle", "PaperContent", "Periodical", "Author"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"PaperContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperContent = "PaperContent";    //主题内容

 /// <summary>
 /// 常量:"Periodical"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Periodical = "Periodical";    //期刊

 /// <summary>
 /// 常量:"Author"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Author = "Author";    //作者
}

}