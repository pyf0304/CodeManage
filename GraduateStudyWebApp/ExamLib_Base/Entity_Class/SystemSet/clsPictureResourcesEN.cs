
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPictureResourcesEN
 表名:PictureResources(01120040)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
 /// 表PictureResources的关键字(PictureId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PictureId_PictureResources
{
private int _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public int Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="intPictureId">表关键字</param>
public K_PictureId_PictureResources(int intPictureId)
{
if (IsValid(intPictureId)) Value = intPictureId;
else
{
Value = 0;
}
}
private static bool IsValid(int intPictureId)
{
if (intPictureId == 0) return false;
if (intPictureId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PictureId_PictureResources]类型的对象</returns>
public static implicit operator K_PictureId_PictureResources(int value)
{
return new K_PictureId_PictureResources(value);
}
}
 /// <summary>
 /// 图片资源(PictureResources)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPictureResourcesEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PictureResources"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PictureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"Memo", "PictureId", "PictureName", "OrginialFileName", "OrginialFileSize", "ResizePictureSize", "ThumbSize", "OrginialFileWidth", "PictureConfigerId", "ResizePictureName", "ThumbName", "OrginialFileHeight"};

protected string mstrMemo;    //备注
protected int mintPictureId;    //PictureId
protected string mstrPictureName;    //PictureName
protected string mstrOrginialFileName;    //OrginialFileName
protected int? mintOrginialFileSize;    //OrginialFileSize
protected int? mintResizePictureSize;    //ResizePictureSize
protected int mintThumbSize;    //ThumbSize
protected int mintOrginialFileWidth;    //OrginialFileWidth
protected string mstrPictureConfigerId;    //PictureConfigerId
protected string mstrResizePictureName;    //ResizePictureName
protected string mstrThumbName;    //ThumbName
protected int? mintOrginialFileHeight;    //OrginialFileHeight

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPictureResourcesEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PictureId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "intPictureId">关键字:PictureId</param>
public clsPictureResourcesEN(int intPictureId)
 {
 if (intPictureId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mintPictureId = intPictureId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PictureId");
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
if (strAttributeName  ==  conPictureResources.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conPictureResources.PictureId)
{
return mintPictureId;
}
else if (strAttributeName  ==  conPictureResources.PictureName)
{
return mstrPictureName;
}
else if (strAttributeName  ==  conPictureResources.OrginialFileName)
{
return mstrOrginialFileName;
}
else if (strAttributeName  ==  conPictureResources.OrginialFileSize)
{
return mintOrginialFileSize;
}
else if (strAttributeName  ==  conPictureResources.ResizePictureSize)
{
return mintResizePictureSize;
}
else if (strAttributeName  ==  conPictureResources.ThumbSize)
{
return mintThumbSize;
}
else if (strAttributeName  ==  conPictureResources.OrginialFileWidth)
{
return mintOrginialFileWidth;
}
else if (strAttributeName  ==  conPictureResources.PictureConfigerId)
{
return mstrPictureConfigerId;
}
else if (strAttributeName  ==  conPictureResources.ResizePictureName)
{
return mstrResizePictureName;
}
else if (strAttributeName  ==  conPictureResources.ThumbName)
{
return mstrThumbName;
}
else if (strAttributeName  ==  conPictureResources.OrginialFileHeight)
{
return mintOrginialFileHeight;
}
return null;
}
set
{
if (strAttributeName  ==  conPictureResources.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPictureResources.Memo);
}
else if (strAttributeName  ==  conPictureResources.PictureId)
{
mintPictureId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureResources.PictureId);
}
else if (strAttributeName  ==  conPictureResources.PictureName)
{
mstrPictureName = value.ToString();
 AddUpdatedFld(conPictureResources.PictureName);
}
else if (strAttributeName  ==  conPictureResources.OrginialFileName)
{
mstrOrginialFileName = value.ToString();
 AddUpdatedFld(conPictureResources.OrginialFileName);
}
else if (strAttributeName  ==  conPictureResources.OrginialFileSize)
{
mintOrginialFileSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureResources.OrginialFileSize);
}
else if (strAttributeName  ==  conPictureResources.ResizePictureSize)
{
mintResizePictureSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureResources.ResizePictureSize);
}
else if (strAttributeName  ==  conPictureResources.ThumbSize)
{
mintThumbSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureResources.ThumbSize);
}
else if (strAttributeName  ==  conPictureResources.OrginialFileWidth)
{
mintOrginialFileWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureResources.OrginialFileWidth);
}
else if (strAttributeName  ==  conPictureResources.PictureConfigerId)
{
mstrPictureConfigerId = value.ToString();
 AddUpdatedFld(conPictureResources.PictureConfigerId);
}
else if (strAttributeName  ==  conPictureResources.ResizePictureName)
{
mstrResizePictureName = value.ToString();
 AddUpdatedFld(conPictureResources.ResizePictureName);
}
else if (strAttributeName  ==  conPictureResources.ThumbName)
{
mstrThumbName = value.ToString();
 AddUpdatedFld(conPictureResources.ThumbName);
}
else if (strAttributeName  ==  conPictureResources.OrginialFileHeight)
{
mintOrginialFileHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureResources.OrginialFileHeight);
}
}
}
public object this[int intIndex]
{
get
{
if (conPictureResources.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conPictureResources.PictureId  ==  AttributeName[intIndex])
{
return mintPictureId;
}
else if (conPictureResources.PictureName  ==  AttributeName[intIndex])
{
return mstrPictureName;
}
else if (conPictureResources.OrginialFileName  ==  AttributeName[intIndex])
{
return mstrOrginialFileName;
}
else if (conPictureResources.OrginialFileSize  ==  AttributeName[intIndex])
{
return mintOrginialFileSize;
}
else if (conPictureResources.ResizePictureSize  ==  AttributeName[intIndex])
{
return mintResizePictureSize;
}
else if (conPictureResources.ThumbSize  ==  AttributeName[intIndex])
{
return mintThumbSize;
}
else if (conPictureResources.OrginialFileWidth  ==  AttributeName[intIndex])
{
return mintOrginialFileWidth;
}
else if (conPictureResources.PictureConfigerId  ==  AttributeName[intIndex])
{
return mstrPictureConfigerId;
}
else if (conPictureResources.ResizePictureName  ==  AttributeName[intIndex])
{
return mstrResizePictureName;
}
else if (conPictureResources.ThumbName  ==  AttributeName[intIndex])
{
return mstrThumbName;
}
else if (conPictureResources.OrginialFileHeight  ==  AttributeName[intIndex])
{
return mintOrginialFileHeight;
}
return null;
}
set
{
if (conPictureResources.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPictureResources.Memo);
}
else if (conPictureResources.PictureId  ==  AttributeName[intIndex])
{
mintPictureId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureResources.PictureId);
}
else if (conPictureResources.PictureName  ==  AttributeName[intIndex])
{
mstrPictureName = value.ToString();
 AddUpdatedFld(conPictureResources.PictureName);
}
else if (conPictureResources.OrginialFileName  ==  AttributeName[intIndex])
{
mstrOrginialFileName = value.ToString();
 AddUpdatedFld(conPictureResources.OrginialFileName);
}
else if (conPictureResources.OrginialFileSize  ==  AttributeName[intIndex])
{
mintOrginialFileSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureResources.OrginialFileSize);
}
else if (conPictureResources.ResizePictureSize  ==  AttributeName[intIndex])
{
mintResizePictureSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureResources.ResizePictureSize);
}
else if (conPictureResources.ThumbSize  ==  AttributeName[intIndex])
{
mintThumbSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureResources.ThumbSize);
}
else if (conPictureResources.OrginialFileWidth  ==  AttributeName[intIndex])
{
mintOrginialFileWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureResources.OrginialFileWidth);
}
else if (conPictureResources.PictureConfigerId  ==  AttributeName[intIndex])
{
mstrPictureConfigerId = value.ToString();
 AddUpdatedFld(conPictureResources.PictureConfigerId);
}
else if (conPictureResources.ResizePictureName  ==  AttributeName[intIndex])
{
mstrResizePictureName = value.ToString();
 AddUpdatedFld(conPictureResources.ResizePictureName);
}
else if (conPictureResources.ThumbName  ==  AttributeName[intIndex])
{
mstrThumbName = value.ToString();
 AddUpdatedFld(conPictureResources.ThumbName);
}
else if (conPictureResources.OrginialFileHeight  ==  AttributeName[intIndex])
{
mintOrginialFileHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conPictureResources.OrginialFileHeight);
}
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
 AddUpdatedFld(conPictureResources.Memo);
}
}
/// <summary>
/// PictureId(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int PictureId
{
get
{
return mintPictureId;
}
set
{
 mintPictureId = value;
//记录修改过的字段
 AddUpdatedFld(conPictureResources.PictureId);
}
}
/// <summary>
/// PictureName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PictureName
{
get
{
return mstrPictureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPictureName = value;
}
else
{
 mstrPictureName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPictureResources.PictureName);
}
}
/// <summary>
/// OrginialFileName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OrginialFileName
{
get
{
return mstrOrginialFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOrginialFileName = value;
}
else
{
 mstrOrginialFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPictureResources.OrginialFileName);
}
}
/// <summary>
/// OrginialFileSize(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrginialFileSize
{
get
{
return mintOrginialFileSize;
}
set
{
 mintOrginialFileSize = value;
//记录修改过的字段
 AddUpdatedFld(conPictureResources.OrginialFileSize);
}
}
/// <summary>
/// ResizePictureSize(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ResizePictureSize
{
get
{
return mintResizePictureSize;
}
set
{
 mintResizePictureSize = value;
//记录修改过的字段
 AddUpdatedFld(conPictureResources.ResizePictureSize);
}
}
/// <summary>
/// ThumbSize(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ThumbSize
{
get
{
return mintThumbSize;
}
set
{
 mintThumbSize = value;
//记录修改过的字段
 AddUpdatedFld(conPictureResources.ThumbSize);
}
}
/// <summary>
/// OrginialFileWidth(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrginialFileWidth
{
get
{
return mintOrginialFileWidth;
}
set
{
 mintOrginialFileWidth = value;
//记录修改过的字段
 AddUpdatedFld(conPictureResources.OrginialFileWidth);
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
 AddUpdatedFld(conPictureResources.PictureConfigerId);
}
}
/// <summary>
/// ResizePictureName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResizePictureName
{
get
{
return mstrResizePictureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResizePictureName = value;
}
else
{
 mstrResizePictureName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPictureResources.ResizePictureName);
}
}
/// <summary>
/// ThumbName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ThumbName
{
get
{
return mstrThumbName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrThumbName = value;
}
else
{
 mstrThumbName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPictureResources.ThumbName);
}
}
/// <summary>
/// OrginialFileHeight(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrginialFileHeight
{
get
{
return mintOrginialFileHeight;
}
set
{
 mintOrginialFileHeight = value;
//记录修改过的字段
 AddUpdatedFld(conPictureResources.OrginialFileHeight);
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
  return mintPictureId.ToString();
 }
 }
}
 /// <summary>
 /// 图片资源(PictureResources)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPictureResources
{
public const string _CurrTabName = "PictureResources"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PictureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"Memo", "PictureId", "PictureName", "OrginialFileName", "OrginialFileSize", "ResizePictureSize", "ThumbSize", "OrginialFileWidth", "PictureConfigerId", "ResizePictureName", "ThumbName", "OrginialFileHeight"};
//以下是属性变量


 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"PictureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PictureId = "PictureId";    //PictureId

 /// <summary>
 /// 常量:"PictureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PictureName = "PictureName";    //PictureName

 /// <summary>
 /// 常量:"OrginialFileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrginialFileName = "OrginialFileName";    //OrginialFileName

 /// <summary>
 /// 常量:"OrginialFileSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrginialFileSize = "OrginialFileSize";    //OrginialFileSize

 /// <summary>
 /// 常量:"ResizePictureSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResizePictureSize = "ResizePictureSize";    //ResizePictureSize

 /// <summary>
 /// 常量:"ThumbSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThumbSize = "ThumbSize";    //ThumbSize

 /// <summary>
 /// 常量:"OrginialFileWidth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrginialFileWidth = "OrginialFileWidth";    //OrginialFileWidth

 /// <summary>
 /// 常量:"PictureConfigerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PictureConfigerId = "PictureConfigerId";    //PictureConfigerId

 /// <summary>
 /// 常量:"ResizePictureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResizePictureName = "ResizePictureName";    //ResizePictureName

 /// <summary>
 /// 常量:"ThumbName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThumbName = "ThumbName";    //ThumbName

 /// <summary>
 /// 常量:"OrginialFileHeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrginialFileHeight = "OrginialFileHeight";    //OrginialFileHeight
}

}