
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TagsTypeBLEx
 表名:zx_TagsType(01120808)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/15 00:01:09
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置
 模块英文名:GraduateEduTools
 框架-层名:业务逻辑扩展层(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;
using ExamLib.BusinessLogic;


namespace ExamLib.BusinessLogicEx
{
public static class clszx_TagsTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_TagsTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_TagsTypeEN:objzx_TagsTypeENT</returns>
 public static clszx_TagsTypeENEx CopyToEx(this clszx_TagsTypeEN objzx_TagsTypeENS)
{
try
{
 clszx_TagsTypeENEx objzx_TagsTypeENT = new clszx_TagsTypeENEx();
clszx_TagsTypeBL.zx_TagsTypeDA.CopyTo(objzx_TagsTypeENS, objzx_TagsTypeENT);
 return objzx_TagsTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objzx_TagsTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_TagsTypeEN:objzx_TagsTypeENT</returns>
 public static clszx_TagsTypeEN CopyTo(this clszx_TagsTypeENEx objzx_TagsTypeENS)
{
try
{
 clszx_TagsTypeEN objzx_TagsTypeENT = new clszx_TagsTypeEN();
clszx_TagsTypeBL.CopyTo(objzx_TagsTypeENS, objzx_TagsTypeENT);
 return objzx_TagsTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 中学标注类型(zx_TagsType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_TagsTypeBLEx : clszx_TagsTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_TagsTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_TagsTypeDAEx zx_TagsTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_TagsTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_TagsTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_TagsTypeEN:objzx_TagsTypeENT</returns>
 public static clszx_TagsTypeENEx CopyToEx(clszx_TagsTypeEN objzx_TagsTypeENS)
{
try
{
 clszx_TagsTypeENEx objzx_TagsTypeENT = new clszx_TagsTypeENEx();
clszx_TagsTypeBL.zx_TagsTypeDA.CopyTo(objzx_TagsTypeENS, objzx_TagsTypeENT);
 return objzx_TagsTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clszx_TagsTypeENEx> GetObjExLst(string strCondition)
{
List <clszx_TagsTypeEN> arrObjLst = clszx_TagsTypeBL.GetObjLst(strCondition);
List <clszx_TagsTypeENEx> arrObjExLst = new List<clszx_TagsTypeENEx>();
foreach (clszx_TagsTypeEN objInFor in arrObjLst)
{
clszx_TagsTypeENEx objzx_TagsTypeENEx = new clszx_TagsTypeENEx();
clszx_TagsTypeBL.CopyTo(objInFor, objzx_TagsTypeENEx);
arrObjExLst.Add(objzx_TagsTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxTagsTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_TagsTypeENEx GetObjExByzxTagsTypeId(string strzxTagsTypeId)
{
clszx_TagsTypeEN objzx_TagsTypeEN = clszx_TagsTypeBL.GetObjByzxTagsTypeId(strzxTagsTypeId);
clszx_TagsTypeENEx objzx_TagsTypeENEx = new clszx_TagsTypeENEx();
clszx_TagsTypeBL.CopyTo(objzx_TagsTypeEN, objzx_TagsTypeENEx);
return objzx_TagsTypeENEx;
}
}
}