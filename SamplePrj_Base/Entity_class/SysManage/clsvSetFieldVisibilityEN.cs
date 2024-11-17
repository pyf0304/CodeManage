
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSetFieldVisibilityEN
 表名:vSetFieldVisibility
 生成代码版本:2018.05.22.1
 生成日期:2018/05/23 02:01:02
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:简单工程样例
 工程ID:0116
 相关数据库:101.251.68.133,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:系统管理
 模块英文名:SysManage
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace SimplePrj.Entity
{
 /// <summary>
 /// v设置字段可视性(vSetFieldVisibility)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsvSetFieldVisibilityEN : clsEntityBase2
{
public const string CurrTabName_S = "vSetFieldVisibility"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "id_School", "SchoolId", "SchoolName", "ViewName", "CtrlType", "FieldName", "IsVisible", "Memo"};
//以下是属性变量

protected long mlngmId;    //mId
protected string mstrid_School;    //学校流水号
protected string mstrSchoolId;    //学校Id
protected string mstrSchoolName;    //学校名称
protected string mstrViewName;    //界面名称
protected string mstrCtrlType;    //控件类型
protected string mstrFieldName;    //字段名
protected bool mbolIsVisible;    //是否显示
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId = "mId";    //mId

 /// <summary>
 /// 常量:"id_School"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_School = "id_School";    //学校流水号

 /// <summary>
 /// 常量:"SchoolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SchoolId = "SchoolId";    //学校Id

 /// <summary>
 /// 常量:"SchoolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SchoolName = "SchoolName";    //学校名称

 /// <summary>
 /// 常量:"ViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewName = "ViewName";    //界面名称

 /// <summary>
 /// 常量:"CtrlType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CtrlType = "CtrlType";    //控件类型

 /// <summary>
 /// 常量:"FieldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FieldName = "FieldName";    //字段名

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvSetFieldVisibilityEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 CurrTabName = "vSetFieldVisibility";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mlngmId">关键字:mId</param>
public clsvSetFieldVisibilityEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 CurrTabName = "vSetFieldVisibility";
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  con_mId)
{
return mlngmId;
}
else if (strAttributeName  ==  con_id_School)
{
return mstrid_School;
}
else if (strAttributeName  ==  con_SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  con_SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  con_ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  con_CtrlType)
{
return mstrCtrlType;
}
else if (strAttributeName  ==  con_FieldName)
{
return mstrFieldName;
}
else if (strAttributeName  ==  con_IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (strAttributeName  ==  con_id_School)
{
mstrid_School = value.ToString();
 AddUpdatedFld(con_id_School);
}
else if (strAttributeName  ==  con_SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(con_SchoolId);
}
else if (strAttributeName  ==  con_SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(con_SchoolName);
}
else if (strAttributeName  ==  con_ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(con_ViewName);
}
else if (strAttributeName  ==  con_CtrlType)
{
mstrCtrlType = value.ToString();
 AddUpdatedFld(con_CtrlType);
}
else if (strAttributeName  ==  con_FieldName)
{
mstrFieldName = value.ToString();
 AddUpdatedFld(con_FieldName);
}
else if (strAttributeName  ==  con_IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsVisible);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (con_mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (con_id_School  ==  AttributeName[intIndex])
{
return mstrid_School;
}
else if (con_SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (con_SchoolName  ==  AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (con_ViewName  ==  AttributeName[intIndex])
{
return mstrViewName;
}
else if (con_CtrlType  ==  AttributeName[intIndex])
{
return mstrCtrlType;
}
else if (con_FieldName  ==  AttributeName[intIndex])
{
return mstrFieldName;
}
else if (con_IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (con_id_School  ==  AttributeName[intIndex])
{
mstrid_School = value.ToString();
 AddUpdatedFld(con_id_School);
}
else if (con_SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(con_SchoolId);
}
else if (con_SchoolName  ==  AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(con_SchoolName);
}
else if (con_ViewName  ==  AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(con_ViewName);
}
else if (con_CtrlType  ==  AttributeName[intIndex])
{
mstrCtrlType = value.ToString();
 AddUpdatedFld(con_CtrlType);
}
else if (con_FieldName  ==  AttributeName[intIndex])
{
mstrFieldName = value.ToString();
 AddUpdatedFld(con_FieldName);
}
else if (con_IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsVisible);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(con_mId);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string id_School
{
get
{
return mstrid_School;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_School = value;
}
else
{
 mstrid_School = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_School);
}
}
/// <summary>
/// 学校Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string SchoolId
{
get
{
return mstrSchoolId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolId = value;
}
else
{
 mstrSchoolId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SchoolId);
}
}
/// <summary>
/// 学校名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string SchoolName
{
get
{
return mstrSchoolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolName = value;
}
else
{
 mstrSchoolName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SchoolName);
}
}
/// <summary>
/// 界面名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string ViewName
{
get
{
return mstrViewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewName = value;
}
else
{
 mstrViewName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ViewName);
}
}
/// <summary>
/// 控件类型(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string CtrlType
{
get
{
return mstrCtrlType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtrlType = value;
}
else
{
 mstrCtrlType = value;
}
//记录修改过的字段
 AddUpdatedFld(con_CtrlType);
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string FieldName
{
get
{
return mstrFieldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldName = value;
}
else
{
 mstrFieldName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FieldName);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
 AddUpdatedFld(con_IsVisible);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Memo);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.AutoGCPubFuncV6:GenGetKeyId)
/// </summary>
 public override string KeyId
 {
 get
 {
  return mlngmId.ToString();
 }
 }
}
}