
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_PaperParagraphVerEN
 表名:zx_PaperParagraphVer(01120760)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:08:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学历史版本(zxHistoricalVersion)
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
 /// 表zx_PaperParagraphVer的关键字(ParagraphVId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ParagraphVId_zx_PaperParagraphVer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngParagraphVId">表关键字</param>
public K_ParagraphVId_zx_PaperParagraphVer(long lngParagraphVId)
{
if (IsValid(lngParagraphVId)) Value = lngParagraphVId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngParagraphVId)
{
if (lngParagraphVId == 0) return false;
if (lngParagraphVId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ParagraphVId_zx_PaperParagraphVer]类型的对象</returns>
public static implicit operator K_ParagraphVId_zx_PaperParagraphVer(long value)
{
return new K_ParagraphVId_zx_PaperParagraphVer(value);
}
}
 /// <summary>
 /// 作文段落版本(zx_PaperParagraphVer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_PaperParagraphVerEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_PaperParagraphVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ParagraphVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"ParagraphVId", "zxParagraphId", "zxSectionId", "zxParagraphTypeId", "ParagraphContent", "UpdDate", "UpdUser", "Memo", "TextId"};

protected long mlngParagraphVId;    //段落版本Id
protected string mstrzxParagraphId;    //段落Id
protected string mstrzxSectionId;    //节Id
protected string mstrzxParagraphTypeId;    //段落类型Id
protected string mstrParagraphContent;    //段落内容
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrTextId;    //课件Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_PaperParagraphVerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ParagraphVId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngParagraphVId">关键字:段落版本Id</param>
public clszx_PaperParagraphVerEN(long lngParagraphVId)
 {
 if (lngParagraphVId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngParagraphVId = lngParagraphVId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ParagraphVId");
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
if (strAttributeName  ==  conzx_PaperParagraphVer.ParagraphVId)
{
return mlngParagraphVId;
}
else if (strAttributeName  ==  conzx_PaperParagraphVer.zxParagraphId)
{
return mstrzxParagraphId;
}
else if (strAttributeName  ==  conzx_PaperParagraphVer.zxSectionId)
{
return mstrzxSectionId;
}
else if (strAttributeName  ==  conzx_PaperParagraphVer.zxParagraphTypeId)
{
return mstrzxParagraphTypeId;
}
else if (strAttributeName  ==  conzx_PaperParagraphVer.ParagraphContent)
{
return mstrParagraphContent;
}
else if (strAttributeName  ==  conzx_PaperParagraphVer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_PaperParagraphVer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_PaperParagraphVer.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_PaperParagraphVer.TextId)
{
return mstrTextId;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_PaperParagraphVer.ParagraphVId)
{
mlngParagraphVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_PaperParagraphVer.ParagraphVId);
}
else if (strAttributeName  ==  conzx_PaperParagraphVer.zxParagraphId)
{
mstrzxParagraphId = value.ToString();
 AddUpdatedFld(conzx_PaperParagraphVer.zxParagraphId);
}
else if (strAttributeName  ==  conzx_PaperParagraphVer.zxSectionId)
{
mstrzxSectionId = value.ToString();
 AddUpdatedFld(conzx_PaperParagraphVer.zxSectionId);
}
else if (strAttributeName  ==  conzx_PaperParagraphVer.zxParagraphTypeId)
{
mstrzxParagraphTypeId = value.ToString();
 AddUpdatedFld(conzx_PaperParagraphVer.zxParagraphTypeId);
}
else if (strAttributeName  ==  conzx_PaperParagraphVer.ParagraphContent)
{
mstrParagraphContent = value.ToString();
 AddUpdatedFld(conzx_PaperParagraphVer.ParagraphContent);
}
else if (strAttributeName  ==  conzx_PaperParagraphVer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_PaperParagraphVer.UpdDate);
}
else if (strAttributeName  ==  conzx_PaperParagraphVer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_PaperParagraphVer.UpdUser);
}
else if (strAttributeName  ==  conzx_PaperParagraphVer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_PaperParagraphVer.Memo);
}
else if (strAttributeName  ==  conzx_PaperParagraphVer.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_PaperParagraphVer.TextId);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_PaperParagraphVer.ParagraphVId  ==  AttributeName[intIndex])
{
return mlngParagraphVId;
}
else if (conzx_PaperParagraphVer.zxParagraphId  ==  AttributeName[intIndex])
{
return mstrzxParagraphId;
}
else if (conzx_PaperParagraphVer.zxSectionId  ==  AttributeName[intIndex])
{
return mstrzxSectionId;
}
else if (conzx_PaperParagraphVer.zxParagraphTypeId  ==  AttributeName[intIndex])
{
return mstrzxParagraphTypeId;
}
else if (conzx_PaperParagraphVer.ParagraphContent  ==  AttributeName[intIndex])
{
return mstrParagraphContent;
}
else if (conzx_PaperParagraphVer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_PaperParagraphVer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_PaperParagraphVer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_PaperParagraphVer.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
return null;
}
set
{
if (conzx_PaperParagraphVer.ParagraphVId  ==  AttributeName[intIndex])
{
mlngParagraphVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_PaperParagraphVer.ParagraphVId);
}
else if (conzx_PaperParagraphVer.zxParagraphId  ==  AttributeName[intIndex])
{
mstrzxParagraphId = value.ToString();
 AddUpdatedFld(conzx_PaperParagraphVer.zxParagraphId);
}
else if (conzx_PaperParagraphVer.zxSectionId  ==  AttributeName[intIndex])
{
mstrzxSectionId = value.ToString();
 AddUpdatedFld(conzx_PaperParagraphVer.zxSectionId);
}
else if (conzx_PaperParagraphVer.zxParagraphTypeId  ==  AttributeName[intIndex])
{
mstrzxParagraphTypeId = value.ToString();
 AddUpdatedFld(conzx_PaperParagraphVer.zxParagraphTypeId);
}
else if (conzx_PaperParagraphVer.ParagraphContent  ==  AttributeName[intIndex])
{
mstrParagraphContent = value.ToString();
 AddUpdatedFld(conzx_PaperParagraphVer.ParagraphContent);
}
else if (conzx_PaperParagraphVer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_PaperParagraphVer.UpdDate);
}
else if (conzx_PaperParagraphVer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_PaperParagraphVer.UpdUser);
}
else if (conzx_PaperParagraphVer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_PaperParagraphVer.Memo);
}
else if (conzx_PaperParagraphVer.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_PaperParagraphVer.TextId);
}
}
}

/// <summary>
/// 段落版本Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ParagraphVId
{
get
{
return mlngParagraphVId;
}
set
{
 mlngParagraphVId = value;
//记录修改过的字段
 AddUpdatedFld(conzx_PaperParagraphVer.ParagraphVId);
}
}
/// <summary>
/// 段落Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxParagraphId
{
get
{
return mstrzxParagraphId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxParagraphId = value;
}
else
{
 mstrzxParagraphId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_PaperParagraphVer.zxParagraphId);
}
}
/// <summary>
/// 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxSectionId
{
get
{
return mstrzxSectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxSectionId = value;
}
else
{
 mstrzxSectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_PaperParagraphVer.zxSectionId);
}
}
/// <summary>
/// 段落类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxParagraphTypeId
{
get
{
return mstrzxParagraphTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxParagraphTypeId = value;
}
else
{
 mstrzxParagraphTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_PaperParagraphVer.zxParagraphTypeId);
}
}
/// <summary>
/// 段落内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParagraphContent
{
get
{
return mstrParagraphContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParagraphContent = value;
}
else
{
 mstrParagraphContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_PaperParagraphVer.ParagraphContent);
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
 AddUpdatedFld(conzx_PaperParagraphVer.UpdDate);
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
 AddUpdatedFld(conzx_PaperParagraphVer.UpdUser);
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
 AddUpdatedFld(conzx_PaperParagraphVer.Memo);
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
 AddUpdatedFld(conzx_PaperParagraphVer.TextId);
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
  return mlngParagraphVId.ToString();
 }
 }
}
 /// <summary>
 /// 作文段落版本(zx_PaperParagraphVer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_PaperParagraphVer
{
public const string _CurrTabName = "zx_PaperParagraphVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ParagraphVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ParagraphVId", "zxParagraphId", "zxSectionId", "zxParagraphTypeId", "ParagraphContent", "UpdDate", "UpdUser", "Memo", "TextId"};
//以下是属性变量


 /// <summary>
 /// 常量:"ParagraphVId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphVId = "ParagraphVId";    //段落版本Id

 /// <summary>
 /// 常量:"zxParagraphId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxParagraphId = "zxParagraphId";    //段落Id

 /// <summary>
 /// 常量:"zxSectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxSectionId = "zxSectionId";    //节Id

 /// <summary>
 /// 常量:"zxParagraphTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxParagraphTypeId = "zxParagraphTypeId";    //段落类型Id

 /// <summary>
 /// 常量:"ParagraphContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphContent = "ParagraphContent";    //段落内容

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
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id
}

}