
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPictureConfigerEN
 表名:PictureConfiger(01120039)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
 /// 表PictureConfiger的关键字(PictureConfigerId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PictureConfigerId_PictureConfiger
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPictureConfigerId">表关键字</param>
public K_PictureConfigerId_PictureConfiger(string strPictureConfigerId)
{
if (IsValid(strPictureConfigerId)) Value = strPictureConfigerId;
else
{
Value = null;
}
}
private static bool IsValid(string strPictureConfigerId)
{
if (string.IsNullOrEmpty(strPictureConfigerId) == true) return false;
if (strPictureConfigerId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PictureConfigerId_PictureConfiger]类型的对象</returns>
public static implicit operator K_PictureConfigerId_PictureConfiger(string value)
{
return new K_PictureConfigerId_PictureConfiger(value);
}
}
 /// <summary>
 /// 图片配置(PictureConfiger)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPictureConfigerEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PictureConfiger"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PictureConfigerId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"PictureConfigerId", "PictureConfigName", "PicturePath", "ThumbHeight", "ThumbWidth", "ResizePictureHeight", "MaxSize", "ResizePictureWidth", "Memo"};

protected string mstrPictureConfigerId;    //PictureConfigerId
protected string mstrPictureConfigName;    //PictureConfigName
protected string mstrPicturePath;    //PicturePath
protected int mintThumbHeight;    //ThumbHeight
protected int mintThumbWidth;    //ThumbWidth
protected int mintResizePictureHeight;    //ResizePictureHeight
protected string mstrMaxSize;    //MaxSize
protected int mintResizePictureWidth;    //ResizePictureWidth
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPictureConfigerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PictureConfigerId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPictureConfigerId">关键字:PictureConfigerId</param>
public clsPictureConfigerEN(string strPictureConfigerId)
 {
strPictureConfigerId = strPictureConfigerId.Replace("'", "''");
if (strPictureConfigerId.Length > 4)
{
throw new Exception("在表:PictureConfiger中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPictureConfigerId)  ==  true)
{
throw new Exception("在表:PictureConfiger中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPictureConfigerId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPictureConfigerId = strPictureConfigerId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PictureConfigerId");
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
if (strAttributeName  ==  conPictureConfiger.PictureConfigerId)
{
return mstrPictureConfigerId;
}
else if (strAttributeName  ==  conPictureConfiger.PictureConfigName)
{
return mstrPictureConfigName;
}
else if (strAttributeName  ==  conPictureConfiger.PicturePath)
{
return mstrPicturePath;
}
else if (strAttributeName  ==  conPictureConfiger.ThumbHeight)
{
return mintThumbHeight;
}
else if (strAttributeName  ==  conPictureConfiger.ThumbWidth)
{
return mintThumbWidth;
}
else if (strAttributeName  ==  conPictureConfiger.ResizePictureHeight)
{
return mintResizePictureHeight;
}
else if (strAttributeName  ==  conPictureConfiger.MaxSize)
{
return mstrMaxSize;
}
else if (strAttributeName  ==  conPictureConfiger.ResizePictureWidth)
{
return mintResizePictureWidth;
}
else if (strAttributeName  ==  conPictureConfiger.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPictureConfiger.PictureConfigerId)
{
mstrPictureConfigerId = value.ToString();
 AddUpdatedFld(conPictureConfiger.PictureConfigerId);
}
else if (strAttributeName  ==  conPictureConfiger.PictureConfigName)
{
mstrPictureConfigName = value.ToString();
 AddUpdatedFld(conPictureConfiger.PictureConfigName);
}
else if (strAttributeName  ==  conPictureConfiger.PicturePath)
{
mstrPicturePath = value.ToString();
 AddUpdatedFld(conPictureConfiger.PicturePath);
}
else if (strAttributeName  ==  conPictureConfiger.ThumbHeight)
{
mintThumbHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureConfiger.ThumbHeight);
}
else if (strAttributeName  ==  conPictureConfiger.ThumbWidth)
{
mintThumbWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureConfiger.ThumbWidth);
}
else if (strAttributeName  ==  conPictureConfiger.ResizePictureHeight)
{
mintResizePictureHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureConfiger.ResizePictureHeight);
}
else if (strAttributeName  ==  conPictureConfiger.MaxSize)
{
mstrMaxSize = value.ToString();
 AddUpdatedFld(conPictureConfiger.MaxSize);
}
else if (strAttributeName  ==  conPictureConfiger.ResizePictureWidth)
{
mintResizePictureWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureConfiger.ResizePictureWidth);
}
else if (strAttributeName  ==  conPictureConfiger.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPictureConfiger.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPictureConfiger.PictureConfigerId  ==  AttributeName[intIndex])
{
return mstrPictureConfigerId;
}
else if (conPictureConfiger.PictureConfigName  ==  AttributeName[intIndex])
{
return mstrPictureConfigName;
}
else if (conPictureConfiger.PicturePath  ==  AttributeName[intIndex])
{
return mstrPicturePath;
}
else if (conPictureConfiger.ThumbHeight  ==  AttributeName[intIndex])
{
return mintThumbHeight;
}
else if (conPictureConfiger.ThumbWidth  ==  AttributeName[intIndex])
{
return mintThumbWidth;
}
else if (conPictureConfiger.ResizePictureHeight  ==  AttributeName[intIndex])
{
return mintResizePictureHeight;
}
else if (conPictureConfiger.MaxSize  ==  AttributeName[intIndex])
{
return mstrMaxSize;
}
else if (conPictureConfiger.ResizePictureWidth  ==  AttributeName[intIndex])
{
return mintResizePictureWidth;
}
else if (conPictureConfiger.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPictureConfiger.PictureConfigerId  ==  AttributeName[intIndex])
{
mstrPictureConfigerId = value.ToString();
 AddUpdatedFld(conPictureConfiger.PictureConfigerId);
}
else if (conPictureConfiger.PictureConfigName  ==  AttributeName[intIndex])
{
mstrPictureConfigName = value.ToString();
 AddUpdatedFld(conPictureConfiger.PictureConfigName);
}
else if (conPictureConfiger.PicturePath  ==  AttributeName[intIndex])
{
mstrPicturePath = value.ToString();
 AddUpdatedFld(conPictureConfiger.PicturePath);
}
else if (conPictureConfiger.ThumbHeight  ==  AttributeName[intIndex])
{
mintThumbHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureConfiger.ThumbHeight);
}
else if (conPictureConfiger.ThumbWidth  ==  AttributeName[intIndex])
{
mintThumbWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureConfiger.ThumbWidth);
}
else if (conPictureConfiger.ResizePictureHeight  ==  AttributeName[intIndex])
{
mintResizePictureHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureConfiger.ResizePictureHeight);
}
else if (conPictureConfiger.MaxSize  ==  AttributeName[intIndex])
{
mstrMaxSize = value.ToString();
 AddUpdatedFld(conPictureConfiger.MaxSize);
}
else if (conPictureConfiger.ResizePictureWidth  ==  AttributeName[intIndex])
{
mintResizePictureWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureConfiger.ResizePictureWidth);
}
else if (conPictureConfiger.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPictureConfiger.Memo);
}
}
}

/// <summary>
/// PictureConfigerId(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PictureConfigerId
{
get
{
return mstrPictureConfigerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPictureConfigerId = value;
}
else
{
 mstrPictureConfigerId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPictureConfiger.PictureConfigerId);
}
}
/// <summary>
/// PictureConfigName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PictureConfigName
{
get
{
return mstrPictureConfigName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPictureConfigName = value;
}
else
{
 mstrPictureConfigName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPictureConfiger.PictureConfigName);
}
}
/// <summary>
/// PicturePath(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PicturePath
{
get
{
return mstrPicturePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPicturePath = value;
}
else
{
 mstrPicturePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conPictureConfiger.PicturePath);
}
}
/// <summary>
/// ThumbHeight(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ThumbHeight
{
get
{
return mintThumbHeight;
}
set
{
 mintThumbHeight = value;
//记录修改过的字段
 AddUpdatedFld(conPictureConfiger.ThumbHeight);
}
}
/// <summary>
/// ThumbWidth(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ThumbWidth
{
get
{
return mintThumbWidth;
}
set
{
 mintThumbWidth = value;
//记录修改过的字段
 AddUpdatedFld(conPictureConfiger.ThumbWidth);
}
}
/// <summary>
/// ResizePictureHeight(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ResizePictureHeight
{
get
{
return mintResizePictureHeight;
}
set
{
 mintResizePictureHeight = value;
//记录修改过的字段
 AddUpdatedFld(conPictureConfiger.ResizePictureHeight);
}
}
/// <summary>
/// MaxSize(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MaxSize
{
get
{
return mstrMaxSize;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMaxSize = value;
}
else
{
 mstrMaxSize = value;
}
//记录修改过的字段
 AddUpdatedFld(conPictureConfiger.MaxSize);
}
}
/// <summary>
/// ResizePictureWidth(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ResizePictureWidth
{
get
{
return mintResizePictureWidth;
}
set
{
 mintResizePictureWidth = value;
//记录修改过的字段
 AddUpdatedFld(conPictureConfiger.ResizePictureWidth);
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
 AddUpdatedFld(conPictureConfiger.Memo);
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
  return mstrPictureConfigerId;
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
  return mstrPictureConfigName;
 }
 }
}
 /// <summary>
 /// 图片配置(PictureConfiger)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPictureConfiger
{
public const string _CurrTabName = "PictureConfiger"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PictureConfigerId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PictureConfigerId", "PictureConfigName", "PicturePath", "ThumbHeight", "ThumbWidth", "ResizePictureHeight", "MaxSize", "ResizePictureWidth", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PictureConfigerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PictureConfigerId = "PictureConfigerId";    //PictureConfigerId

 /// <summary>
 /// 常量:"PictureConfigName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PictureConfigName = "PictureConfigName";    //PictureConfigName

 /// <summary>
 /// 常量:"PicturePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PicturePath = "PicturePath";    //PicturePath

 /// <summary>
 /// 常量:"ThumbHeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThumbHeight = "ThumbHeight";    //ThumbHeight

 /// <summary>
 /// 常量:"ThumbWidth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThumbWidth = "ThumbWidth";    //ThumbWidth

 /// <summary>
 /// 常量:"ResizePictureHeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResizePictureHeight = "ResizePictureHeight";    //ResizePictureHeight

 /// <summary>
 /// 常量:"MaxSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MaxSize = "MaxSize";    //MaxSize

 /// <summary>
 /// 常量:"ResizePictureWidth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResizePictureWidth = "ResizePictureWidth";    //ResizePictureWidth

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}