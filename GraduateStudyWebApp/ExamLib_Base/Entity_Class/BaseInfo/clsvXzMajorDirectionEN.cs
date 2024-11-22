
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzMajorDirectionEN
 表名:vXzMajorDirection(01120553)
 * 版本:2023.10.12.1(服务器:WIN-SRV103-116)
 日期:2023/10/28 09:46:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
 /// 表vXzMajorDirection的关键字(MajorDirectionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MajorDirectionId_vXzMajorDirection
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strMajorDirectionId">表关键字</param>
public K_MajorDirectionId_vXzMajorDirection(string strMajorDirectionId)
{
if (IsValid(strMajorDirectionId)) Value = strMajorDirectionId;
else
{
Value = null;
}
}
private static bool IsValid(string strMajorDirectionId)
{
if (string.IsNullOrEmpty(strMajorDirectionId) == true) return false;
if (strMajorDirectionId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_MajorDirectionId_vXzMajorDirection]类型的对象</returns>
public static implicit operator K_MajorDirectionId_vXzMajorDirection(string value)
{
return new K_MajorDirectionId_vXzMajorDirection(value);
}
}
 /// <summary>
 /// v专业方向(vXzMajorDirection)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvXzMajorDirectionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vXzMajorDirection"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MajorDirectionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"MajorDirectionId", "IdXzMajor", "MajorID", "MajorName", "MajorDirectionName", "MajorDirectionENName", "MajorDirectionExplain", "IsVisible", "UpdDate", "UpdUser", "Memo"};

protected string mstrMajorDirectionId;    //研究方向Id
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称
protected string mstrMajorDirectionName;    //研究方向名
protected string mstrMajorDirectionENName;    //研究方向英文名
protected string mstrMajorDirectionExplain;    //专业方向说明
protected bool mbolIsVisible;    //是否显示
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvXzMajorDirectionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MajorDirectionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strMajorDirectionId">关键字:研究方向Id</param>
public clsvXzMajorDirectionEN(string strMajorDirectionId)
 {
strMajorDirectionId = strMajorDirectionId.Replace("'", "''");
if (strMajorDirectionId.Length > 8)
{
throw new Exception("在表:vXzMajorDirection中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strMajorDirectionId)  ==  true)
{
throw new Exception("在表:vXzMajorDirection中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMajorDirectionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrMajorDirectionId = strMajorDirectionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MajorDirectionId");
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
if (strAttributeName  ==  convXzMajorDirection.MajorDirectionId)
{
return mstrMajorDirectionId;
}
else if (strAttributeName  ==  convXzMajorDirection.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convXzMajorDirection.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convXzMajorDirection.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convXzMajorDirection.MajorDirectionName)
{
return mstrMajorDirectionName;
}
else if (strAttributeName  ==  convXzMajorDirection.MajorDirectionENName)
{
return mstrMajorDirectionENName;
}
else if (strAttributeName  ==  convXzMajorDirection.MajorDirectionExplain)
{
return mstrMajorDirectionExplain;
}
else if (strAttributeName  ==  convXzMajorDirection.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convXzMajorDirection.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convXzMajorDirection.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convXzMajorDirection.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convXzMajorDirection.MajorDirectionId)
{
mstrMajorDirectionId = value.ToString();
 AddUpdatedFld(convXzMajorDirection.MajorDirectionId);
}
else if (strAttributeName  ==  convXzMajorDirection.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convXzMajorDirection.IdXzMajor);
}
else if (strAttributeName  ==  convXzMajorDirection.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convXzMajorDirection.MajorID);
}
else if (strAttributeName  ==  convXzMajorDirection.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convXzMajorDirection.MajorName);
}
else if (strAttributeName  ==  convXzMajorDirection.MajorDirectionName)
{
mstrMajorDirectionName = value.ToString();
 AddUpdatedFld(convXzMajorDirection.MajorDirectionName);
}
else if (strAttributeName  ==  convXzMajorDirection.MajorDirectionENName)
{
mstrMajorDirectionENName = value.ToString();
 AddUpdatedFld(convXzMajorDirection.MajorDirectionENName);
}
else if (strAttributeName  ==  convXzMajorDirection.MajorDirectionExplain)
{
mstrMajorDirectionExplain = value.ToString();
 AddUpdatedFld(convXzMajorDirection.MajorDirectionExplain);
}
else if (strAttributeName  ==  convXzMajorDirection.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzMajorDirection.IsVisible);
}
else if (strAttributeName  ==  convXzMajorDirection.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convXzMajorDirection.UpdDate);
}
else if (strAttributeName  ==  convXzMajorDirection.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convXzMajorDirection.UpdUser);
}
else if (strAttributeName  ==  convXzMajorDirection.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzMajorDirection.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convXzMajorDirection.MajorDirectionId  ==  AttributeName[intIndex])
{
return mstrMajorDirectionId;
}
else if (convXzMajorDirection.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convXzMajorDirection.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convXzMajorDirection.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convXzMajorDirection.MajorDirectionName  ==  AttributeName[intIndex])
{
return mstrMajorDirectionName;
}
else if (convXzMajorDirection.MajorDirectionENName  ==  AttributeName[intIndex])
{
return mstrMajorDirectionENName;
}
else if (convXzMajorDirection.MajorDirectionExplain  ==  AttributeName[intIndex])
{
return mstrMajorDirectionExplain;
}
else if (convXzMajorDirection.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convXzMajorDirection.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convXzMajorDirection.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convXzMajorDirection.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convXzMajorDirection.MajorDirectionId  ==  AttributeName[intIndex])
{
mstrMajorDirectionId = value.ToString();
 AddUpdatedFld(convXzMajorDirection.MajorDirectionId);
}
else if (convXzMajorDirection.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convXzMajorDirection.IdXzMajor);
}
else if (convXzMajorDirection.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convXzMajorDirection.MajorID);
}
else if (convXzMajorDirection.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convXzMajorDirection.MajorName);
}
else if (convXzMajorDirection.MajorDirectionName  ==  AttributeName[intIndex])
{
mstrMajorDirectionName = value.ToString();
 AddUpdatedFld(convXzMajorDirection.MajorDirectionName);
}
else if (convXzMajorDirection.MajorDirectionENName  ==  AttributeName[intIndex])
{
mstrMajorDirectionENName = value.ToString();
 AddUpdatedFld(convXzMajorDirection.MajorDirectionENName);
}
else if (convXzMajorDirection.MajorDirectionExplain  ==  AttributeName[intIndex])
{
mstrMajorDirectionExplain = value.ToString();
 AddUpdatedFld(convXzMajorDirection.MajorDirectionExplain);
}
else if (convXzMajorDirection.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzMajorDirection.IsVisible);
}
else if (convXzMajorDirection.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convXzMajorDirection.UpdDate);
}
else if (convXzMajorDirection.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convXzMajorDirection.UpdUser);
}
else if (convXzMajorDirection.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzMajorDirection.Memo);
}
}
}

/// <summary>
/// 研究方向Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorDirectionId
{
get
{
return mstrMajorDirectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorDirectionId = value;
}
else
{
 mstrMajorDirectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajorDirection.MajorDirectionId);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajor
{
get
{
return mstrIdXzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajor = value;
}
else
{
 mstrIdXzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajorDirection.IdXzMajor);
}
}
/// <summary>
/// 专业ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorID
{
get
{
return mstrMajorID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorID = value;
}
else
{
 mstrMajorID = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajorDirection.MajorID);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajorDirection.MajorName);
}
}
/// <summary>
/// 研究方向名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorDirectionName
{
get
{
return mstrMajorDirectionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorDirectionName = value;
}
else
{
 mstrMajorDirectionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajorDirection.MajorDirectionName);
}
}
/// <summary>
/// 研究方向英文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorDirectionENName
{
get
{
return mstrMajorDirectionENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorDirectionENName = value;
}
else
{
 mstrMajorDirectionENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajorDirection.MajorDirectionENName);
}
}
/// <summary>
/// 专业方向说明(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorDirectionExplain
{
get
{
return mstrMajorDirectionExplain;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorDirectionExplain = value;
}
else
{
 mstrMajorDirectionExplain = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzMajorDirection.MajorDirectionExplain);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(convXzMajorDirection.IsVisible);
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
 AddUpdatedFld(convXzMajorDirection.UpdDate);
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
 AddUpdatedFld(convXzMajorDirection.UpdUser);
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
 AddUpdatedFld(convXzMajorDirection.Memo);
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
  return mstrMajorDirectionId;
 }
 }
}
 /// <summary>
 /// v专业方向(vXzMajorDirection)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convXzMajorDirection
{
public const string _CurrTabName = "vXzMajorDirection"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MajorDirectionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"MajorDirectionId", "IdXzMajor", "MajorID", "MajorName", "MajorDirectionName", "MajorDirectionENName", "MajorDirectionExplain", "IsVisible", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"MajorDirectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorDirectionId = "MajorDirectionId";    //研究方向Id

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorID = "MajorID";    //专业ID

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"MajorDirectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorDirectionName = "MajorDirectionName";    //研究方向名

 /// <summary>
 /// 常量:"MajorDirectionENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorDirectionENName = "MajorDirectionENName";    //研究方向英文名

 /// <summary>
 /// 常量:"MajorDirectionExplain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorDirectionExplain = "MajorDirectionExplain";    //专业方向说明

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

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