
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SectionBLEx
 表名:zx_Section(01120762)
 生成代码版本:2020.09.24.1
 生成日期:2020/11/08 00:56:51
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文
 模块英文名:zxGroupText
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
public static class clszx_SectionBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_SectionENS">源对象</param>
 /// <returns>目标对象=>clszx_SectionEN:objzx_SectionENT</returns>
 public static clszx_SectionENEx CopyToEx(this clszx_SectionEN objzx_SectionENS)
{
try
{
 clszx_SectionENEx objzx_SectionENT = new clszx_SectionENEx();
clszx_SectionBL.zx_SectionDA.CopyTo(objzx_SectionENS, objzx_SectionENT);
 return objzx_SectionENT;
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
 /// <param name = "objzx_SectionENS">源对象</param>
 /// <returns>目标对象=>clszx_SectionEN:objzx_SectionENT</returns>
 public static clszx_SectionEN CopyTo(this clszx_SectionENEx objzx_SectionENS)
{
try
{
 clszx_SectionEN objzx_SectionENT = new clszx_SectionEN();
clszx_SectionBL.CopyTo(objzx_SectionENS, objzx_SectionENT);
 return objzx_SectionENT;
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
 /// 作文节表(zx_Section)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_SectionBLEx : clszx_SectionBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_SectionDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_SectionDAEx zx_SectionDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_SectionDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_SectionENS">源对象</param>
 /// <returns>目标对象=>clszx_SectionEN:objzx_SectionENT</returns>
 public static clszx_SectionENEx CopyToEx(clszx_SectionEN objzx_SectionENS)
{
try
{
 clszx_SectionENEx objzx_SectionENT = new clszx_SectionENEx();
clszx_SectionBL.zx_SectionDA.CopyTo(objzx_SectionENS, objzx_SectionENT);
 return objzx_SectionENT;
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
public static List<clszx_SectionENEx> GetObjExLst(string strCondition)
{
List <clszx_SectionEN> arrObjLst = clszx_SectionBL.GetObjLst(strCondition);
List <clszx_SectionENEx> arrObjExLst = new List<clszx_SectionENEx>();
foreach (clszx_SectionEN objInFor in arrObjLst)
{
clszx_SectionENEx objzx_SectionENEx = new clszx_SectionENEx();
clszx_SectionBL.CopyTo(objInFor, objzx_SectionENEx);
arrObjExLst.Add(objzx_SectionENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strSectionId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_SectionENEx GetObjExBySectionId(string strSectionId)
{
clszx_SectionEN objzx_SectionEN = clszx_SectionBL.GetObjByzxSectionId(strSectionId);
clszx_SectionENEx objzx_SectionENEx = new clszx_SectionENEx();
clszx_SectionBL.CopyTo(objzx_SectionEN, objzx_SectionENEx);
return objzx_SectionENEx;
}
}
}