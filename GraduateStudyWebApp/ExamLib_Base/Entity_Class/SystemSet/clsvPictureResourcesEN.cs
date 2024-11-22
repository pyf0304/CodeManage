
//类名:clsvPictureResourcesEN
 ///----------------------
 ///生成代码版本:2016.10.01.1
 ///生成日期:2016/10/02
 ///生成者:潘以锋
 ///工程名称:问卷调查
 ///工程ID:0112
 ///模块中文名:系统设置
 ///模块英文名:SystemSet
 ///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.09.04.01
 ///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.09.04.01
 /// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace ExamLib.Entity
{
 /// <summary>
 /// vPictureResources(vPictureResources)
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsvPictureResourcesEN : clsEntityBase2
{
public const string _CurrTabName_S = "vPictureResources"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "PictureId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 19;
public static string[] AttributeName = new string[] {"Memo", "PictureId", "PictureConfigName", "PictureName", "OrginialFileName", "OrginialFileSize", "ResizePictureSize", "ThumbSize", "OrginialFileWidth", "PictureConfigerId", "ResizePictureName", "ThumbName", "PicturePath", "ThumbHeight", "OrginialFileHeight", "ThumbWidth", "ResizePictureHeight", "MaxSize", "ResizePictureWidth"};
//以下是属性变量

protected string mstrMemo;    //备注
protected int mintPictureId;    //PictureId
protected string mstrPictureConfigName;    //PictureConfigName
protected string mstrPictureName;    //PictureName
protected string mstrOrginialFileName;    //OrginialFileName
protected int mintOrginialFileSize;    //OrginialFileSize
protected int mintResizePictureSize;    //ResizePictureSize
protected int mintThumbSize;    //ThumbSize
protected int mintOrginialFileWidth;    //OrginialFileWidth
protected string mstrPictureConfigerId;    //PictureConfigerId
protected string mstrResizePictureName;    //ResizePictureName
protected string mstrThumbName;    //ThumbName
protected string mstrPicturePath;    //PicturePath
protected int mintThumbHeight;    //ThumbHeight
protected int mintOrginialFileHeight;    //OrginialFileHeight
protected int mintThumbWidth;    //ThumbWidth
protected int mintResizePictureHeight;    //ResizePictureHeight
protected string mstrMaxSize;    //MaxSize
protected int mintResizePictureWidth;    //ResizePictureWidth


 /// <summary>
 /// 常量:"Memo"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo  =  "Memo";    //备注

 /// <summary>
 /// 常量:"PictureId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PictureId  =  "PictureId";    //PictureId

 /// <summary>
 /// 常量:"PictureConfigName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PictureConfigName  =  "PictureConfigName";    //PictureConfigName

 /// <summary>
 /// 常量:"PictureName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PictureName  =  "PictureName";    //PictureName

 /// <summary>
 /// 常量:"OrginialFileName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrginialFileName  =  "OrginialFileName";    //OrginialFileName

 /// <summary>
 /// 常量:"OrginialFileSize"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrginialFileSize  =  "OrginialFileSize";    //OrginialFileSize

 /// <summary>
 /// 常量:"ResizePictureSize"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ResizePictureSize  =  "ResizePictureSize";    //ResizePictureSize

 /// <summary>
 /// 常量:"ThumbSize"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ThumbSize  =  "ThumbSize";    //ThumbSize

 /// <summary>
 /// 常量:"OrginialFileWidth"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrginialFileWidth  =  "OrginialFileWidth";    //OrginialFileWidth

 /// <summary>
 /// 常量:"PictureConfigerId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PictureConfigerId  =  "PictureConfigerId";    //PictureConfigerId

 /// <summary>
 /// 常量:"ResizePictureName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ResizePictureName  =  "ResizePictureName";    //ResizePictureName

 /// <summary>
 /// 常量:"ThumbName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ThumbName  =  "ThumbName";    //ThumbName

 /// <summary>
 /// 常量:"PicturePath"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PicturePath  =  "PicturePath";    //PicturePath

 /// <summary>
 /// 常量:"ThumbHeight"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ThumbHeight  =  "ThumbHeight";    //ThumbHeight

 /// <summary>
 /// 常量:"OrginialFileHeight"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrginialFileHeight  =  "OrginialFileHeight";    //OrginialFileHeight

 /// <summary>
 /// 常量:"ThumbWidth"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ThumbWidth  =  "ThumbWidth";    //ThumbWidth

 /// <summary>
 /// 常量:"ResizePictureHeight"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ResizePictureHeight  =  "ResizePictureHeight";    //ResizePictureHeight

 /// <summary>
 /// 常量:"MaxSize"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MaxSize  =  "MaxSize";    //MaxSize

 /// <summary>
 /// 常量:"ResizePictureWidth"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ResizePictureWidth  =  "ResizePictureWidth";    //ResizePictureWidth

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvPictureResourcesEN()
 {
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "vPictureResources";
 lstKeyFldNames.Add("PictureId");
 }

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mintPictureId">关键字:PictureId</param>
public clsvPictureResourcesEN(int intPictureId)
 {
 if (intPictureId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mintPictureId = intPictureId;
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "vPictureResources";
 lstKeyFldNames.Add("PictureId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  con_PictureId)
{
return mintPictureId;
}
else if (strAttributeName  ==  con_PictureConfigName)
{
return mstrPictureConfigName;
}
else if (strAttributeName  ==  con_PictureName)
{
return mstrPictureName;
}
else if (strAttributeName  ==  con_OrginialFileName)
{
return mstrOrginialFileName;
}
else if (strAttributeName  ==  con_OrginialFileSize)
{
return mintOrginialFileSize;
}
else if (strAttributeName  ==  con_ResizePictureSize)
{
return mintResizePictureSize;
}
else if (strAttributeName  ==  con_ThumbSize)
{
return mintThumbSize;
}
else if (strAttributeName  ==  con_OrginialFileWidth)
{
return mintOrginialFileWidth;
}
else if (strAttributeName  ==  con_PictureConfigerId)
{
return mstrPictureConfigerId;
}
else if (strAttributeName  ==  con_ResizePictureName)
{
return mstrResizePictureName;
}
else if (strAttributeName  ==  con_ThumbName)
{
return mstrThumbName;
}
else if (strAttributeName  ==  con_PicturePath)
{
return mstrPicturePath;
}
else if (strAttributeName  ==  con_ThumbHeight)
{
return mintThumbHeight;
}
else if (strAttributeName  ==  con_OrginialFileHeight)
{
return mintOrginialFileHeight;
}
else if (strAttributeName  ==  con_ThumbWidth)
{
return mintThumbWidth;
}
else if (strAttributeName  ==  con_ResizePictureHeight)
{
return mintResizePictureHeight;
}
else if (strAttributeName  ==  con_MaxSize)
{
return mstrMaxSize;
}
else if (strAttributeName  ==  con_ResizePictureWidth)
{
return mintResizePictureWidth;
}
return null;
}
set
{
if (strAttributeName  ==  con_Memo)
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (strAttributeName  ==  con_PictureId)
{
mintPictureId  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_PictureId);
}
else if (strAttributeName  ==  con_PictureConfigName)
{
mstrPictureConfigName  =  value.ToString();
 AddUpdatedFld(con_PictureConfigName);
}
else if (strAttributeName  ==  con_PictureName)
{
mstrPictureName  =  value.ToString();
 AddUpdatedFld(con_PictureName);
}
else if (strAttributeName  ==  con_OrginialFileName)
{
mstrOrginialFileName  =  value.ToString();
 AddUpdatedFld(con_OrginialFileName);
}
else if (strAttributeName  ==  con_OrginialFileSize)
{
mintOrginialFileSize  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrginialFileSize);
}
else if (strAttributeName  ==  con_ResizePictureSize)
{
mintResizePictureSize  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_ResizePictureSize);
}
else if (strAttributeName  ==  con_ThumbSize)
{
mintThumbSize  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_ThumbSize);
}
else if (strAttributeName  ==  con_OrginialFileWidth)
{
mintOrginialFileWidth  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrginialFileWidth);
}
else if (strAttributeName  ==  con_PictureConfigerId)
{
mstrPictureConfigerId  =  value.ToString();
 AddUpdatedFld(con_PictureConfigerId);
}
else if (strAttributeName  ==  con_ResizePictureName)
{
mstrResizePictureName  =  value.ToString();
 AddUpdatedFld(con_ResizePictureName);
}
else if (strAttributeName  ==  con_ThumbName)
{
mstrThumbName  =  value.ToString();
 AddUpdatedFld(con_ThumbName);
}
else if (strAttributeName  ==  con_PicturePath)
{
mstrPicturePath  =  value.ToString();
 AddUpdatedFld(con_PicturePath);
}
else if (strAttributeName  ==  con_ThumbHeight)
{
mintThumbHeight  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_ThumbHeight);
}
else if (strAttributeName  ==  con_OrginialFileHeight)
{
mintOrginialFileHeight  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrginialFileHeight);
}
else if (strAttributeName  ==  con_ThumbWidth)
{
mintThumbWidth  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_ThumbWidth);
}
else if (strAttributeName  ==  con_ResizePictureHeight)
{
mintResizePictureHeight  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_ResizePictureHeight);
}
else if (strAttributeName  ==  con_MaxSize)
{
mstrMaxSize  =  value.ToString();
 AddUpdatedFld(con_MaxSize);
}
else if (strAttributeName  ==  con_ResizePictureWidth)
{
mintResizePictureWidth  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_ResizePictureWidth);
}
}
}
public object this[int intIndex]
{
get
{
if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (con_PictureId  ==  AttributeName[intIndex])
{
return mintPictureId;
}
else if (con_PictureConfigName  ==  AttributeName[intIndex])
{
return mstrPictureConfigName;
}
else if (con_PictureName  ==  AttributeName[intIndex])
{
return mstrPictureName;
}
else if (con_OrginialFileName  ==  AttributeName[intIndex])
{
return mstrOrginialFileName;
}
else if (con_OrginialFileSize  ==  AttributeName[intIndex])
{
return mintOrginialFileSize;
}
else if (con_ResizePictureSize  ==  AttributeName[intIndex])
{
return mintResizePictureSize;
}
else if (con_ThumbSize  ==  AttributeName[intIndex])
{
return mintThumbSize;
}
else if (con_OrginialFileWidth  ==  AttributeName[intIndex])
{
return mintOrginialFileWidth;
}
else if (con_PictureConfigerId  ==  AttributeName[intIndex])
{
return mstrPictureConfigerId;
}
else if (con_ResizePictureName  ==  AttributeName[intIndex])
{
return mstrResizePictureName;
}
else if (con_ThumbName  ==  AttributeName[intIndex])
{
return mstrThumbName;
}
else if (con_PicturePath  ==  AttributeName[intIndex])
{
return mstrPicturePath;
}
else if (con_ThumbHeight  ==  AttributeName[intIndex])
{
return mintThumbHeight;
}
else if (con_OrginialFileHeight  ==  AttributeName[intIndex])
{
return mintOrginialFileHeight;
}
else if (con_ThumbWidth  ==  AttributeName[intIndex])
{
return mintThumbWidth;
}
else if (con_ResizePictureHeight  ==  AttributeName[intIndex])
{
return mintResizePictureHeight;
}
else if (con_MaxSize  ==  AttributeName[intIndex])
{
return mstrMaxSize;
}
else if (con_ResizePictureWidth  ==  AttributeName[intIndex])
{
return mintResizePictureWidth;
}
return null;
}
set
{
if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (con_PictureId  ==  AttributeName[intIndex])
{
mintPictureId  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_PictureId);
}
else if (con_PictureConfigName  ==  AttributeName[intIndex])
{
mstrPictureConfigName  =  value.ToString();
 AddUpdatedFld(con_PictureConfigName);
}
else if (con_PictureName  ==  AttributeName[intIndex])
{
mstrPictureName  =  value.ToString();
 AddUpdatedFld(con_PictureName);
}
else if (con_OrginialFileName  ==  AttributeName[intIndex])
{
mstrOrginialFileName  =  value.ToString();
 AddUpdatedFld(con_OrginialFileName);
}
else if (con_OrginialFileSize  ==  AttributeName[intIndex])
{
mintOrginialFileSize  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrginialFileSize);
}
else if (con_ResizePictureSize  ==  AttributeName[intIndex])
{
mintResizePictureSize  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_ResizePictureSize);
}
else if (con_ThumbSize  ==  AttributeName[intIndex])
{
mintThumbSize  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_ThumbSize);
}
else if (con_OrginialFileWidth  ==  AttributeName[intIndex])
{
mintOrginialFileWidth  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrginialFileWidth);
}
else if (con_PictureConfigerId  ==  AttributeName[intIndex])
{
mstrPictureConfigerId  =  value.ToString();
 AddUpdatedFld(con_PictureConfigerId);
}
else if (con_ResizePictureName  ==  AttributeName[intIndex])
{
mstrResizePictureName  =  value.ToString();
 AddUpdatedFld(con_ResizePictureName);
}
else if (con_ThumbName  ==  AttributeName[intIndex])
{
mstrThumbName  =  value.ToString();
 AddUpdatedFld(con_ThumbName);
}
else if (con_PicturePath  ==  AttributeName[intIndex])
{
mstrPicturePath  =  value.ToString();
 AddUpdatedFld(con_PicturePath);
}
else if (con_ThumbHeight  ==  AttributeName[intIndex])
{
mintThumbHeight  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_ThumbHeight);
}
else if (con_OrginialFileHeight  ==  AttributeName[intIndex])
{
mintOrginialFileHeight  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrginialFileHeight);
}
else if (con_ThumbWidth  ==  AttributeName[intIndex])
{
mintThumbWidth  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_ThumbWidth);
}
else if (con_ResizePictureHeight  ==  AttributeName[intIndex])
{
mintResizePictureHeight  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_ResizePictureHeight);
}
else if (con_MaxSize  ==  AttributeName[intIndex])
{
mstrMaxSize  =  value.ToString();
 AddUpdatedFld(con_MaxSize);
}
else if (con_ResizePictureWidth  ==  AttributeName[intIndex])
{
mintResizePictureWidth  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_ResizePictureWidth);
}
}
}

/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrMemo  =  value;
}
else
{
 mstrMemo  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_Memo);
}
}
/// <summary>
/// PictureId(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int PictureId
{
get
{
return mintPictureId;
}
set
{
 mintPictureId  =  value;
//记录修改过的字段
 AddUpdatedFld(con_PictureId);
}
}
/// <summary>
/// PictureConfigName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrPictureConfigName  =  value;
}
else
{
 mstrPictureConfigName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_PictureConfigName);
}
}
/// <summary>
/// PictureName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrPictureName  =  value;
}
else
{
 mstrPictureName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_PictureName);
}
}
/// <summary>
/// OrginialFileName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrOrginialFileName  =  value;
}
else
{
 mstrOrginialFileName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_OrginialFileName);
}
}
/// <summary>
/// OrginialFileSize(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int OrginialFileSize
{
get
{
return mintOrginialFileSize;
}
set
{
 mintOrginialFileSize  =  value;
//记录修改过的字段
 AddUpdatedFld(con_OrginialFileSize);
}
}
/// <summary>
/// ResizePictureSize(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int ResizePictureSize
{
get
{
return mintResizePictureSize;
}
set
{
 mintResizePictureSize  =  value;
//记录修改过的字段
 AddUpdatedFld(con_ResizePictureSize);
}
}
/// <summary>
/// ThumbSize(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int ThumbSize
{
get
{
return mintThumbSize;
}
set
{
 mintThumbSize  =  value;
//记录修改过的字段
 AddUpdatedFld(con_ThumbSize);
}
}
/// <summary>
/// OrginialFileWidth(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int OrginialFileWidth
{
get
{
return mintOrginialFileWidth;
}
set
{
 mintOrginialFileWidth  =  value;
//记录修改过的字段
 AddUpdatedFld(con_OrginialFileWidth);
}
}
/// <summary>
/// PictureConfigerId(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrPictureConfigerId  =  value;
}
else
{
 mstrPictureConfigerId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_PictureConfigerId);
}
}
/// <summary>
/// ResizePictureName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrResizePictureName  =  value;
}
else
{
 mstrResizePictureName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_ResizePictureName);
}
}
/// <summary>
/// ThumbName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrThumbName  =  value;
}
else
{
 mstrThumbName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_ThumbName);
}
}
/// <summary>
/// PicturePath(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrPicturePath  =  value;
}
else
{
 mstrPicturePath  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_PicturePath);
}
}
/// <summary>
/// ThumbHeight(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int ThumbHeight
{
get
{
return mintThumbHeight;
}
set
{
 mintThumbHeight  =  value;
//记录修改过的字段
 AddUpdatedFld(con_ThumbHeight);
}
}
/// <summary>
/// OrginialFileHeight(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int OrginialFileHeight
{
get
{
return mintOrginialFileHeight;
}
set
{
 mintOrginialFileHeight  =  value;
//记录修改过的字段
 AddUpdatedFld(con_OrginialFileHeight);
}
}
/// <summary>
/// ThumbWidth(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int ThumbWidth
{
get
{
return mintThumbWidth;
}
set
{
 mintThumbWidth  =  value;
//记录修改过的字段
 AddUpdatedFld(con_ThumbWidth);
}
}
/// <summary>
/// ResizePictureHeight(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int ResizePictureHeight
{
get
{
return mintResizePictureHeight;
}
set
{
 mintResizePictureHeight  =  value;
//记录修改过的字段
 AddUpdatedFld(con_ResizePictureHeight);
}
}
/// <summary>
/// MaxSize(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrMaxSize  =  value;
}
else
{
 mstrMaxSize  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_MaxSize);
}
}
/// <summary>
/// ResizePictureWidth(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int ResizePictureWidth
{
get
{
return mintResizePictureWidth;
}
set
{
 mintResizePictureWidth  =  value;
//记录修改过的字段
 AddUpdatedFld(con_ResizePictureWidth);
}
}
}
}