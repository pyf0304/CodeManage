
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClsRmTypeBLEx
 表名:ClsRmType(01120576)
 生成代码版本:2021.02.03.1
 生成日期:2021/02/08 17:27:12
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教室管理
 模块英文名:ClassroomManage
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
public static class clsClsRmTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objClsRmTypeENS">源对象</param>
 /// <returns>目标对象=>clsClsRmTypeEN:objClsRmTypeENT</returns>
 public static clsClsRmTypeENEx CopyToEx(this clsClsRmTypeEN objClsRmTypeENS)
{
try
{
 clsClsRmTypeENEx objClsRmTypeENT = new clsClsRmTypeENEx();
clsClsRmTypeBL.ClsRmTypeDA.CopyTo(objClsRmTypeENS, objClsRmTypeENT);
 return objClsRmTypeENT;
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
 /// <param name = "objClsRmTypeENS">源对象</param>
 /// <returns>目标对象=>clsClsRmTypeEN:objClsRmTypeENT</returns>
 public static clsClsRmTypeEN CopyTo(this clsClsRmTypeENEx objClsRmTypeENS)
{
try
{
 clsClsRmTypeEN objClsRmTypeENT = new clsClsRmTypeEN();
clsClsRmTypeBL.CopyTo(objClsRmTypeENS, objClsRmTypeENT);
 return objClsRmTypeENT;
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
 /// 教室类型(ClsRmType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsClsRmTypeBLEx : clsClsRmTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsClsRmTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsClsRmTypeDAEx ClsRmTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsClsRmTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objClsRmTypeENS">源对象</param>
 /// <returns>目标对象=>clsClsRmTypeEN:objClsRmTypeENT</returns>
 public static clsClsRmTypeENEx CopyToEx(clsClsRmTypeEN objClsRmTypeENS)
{
try
{
 clsClsRmTypeENEx objClsRmTypeENT = new clsClsRmTypeENEx();
clsClsRmTypeBL.ClsRmTypeDA.CopyTo(objClsRmTypeENS, objClsRmTypeENT);
 return objClsRmTypeENT;
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
public static List<clsClsRmTypeENEx> GetObjExLst(string strCondition)
{
List <clsClsRmTypeEN> arrObjLst = clsClsRmTypeBL.GetObjLst(strCondition);
List <clsClsRmTypeENEx> arrObjExLst = new List<clsClsRmTypeENEx>();
foreach (clsClsRmTypeEN objInFor in arrObjLst)
{
clsClsRmTypeENEx objClsRmTypeENEx = new clsClsRmTypeENEx();
clsClsRmTypeBL.CopyTo(objInFor, objClsRmTypeENEx);
arrObjExLst.Add(objClsRmTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strid_ClassRoomType">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsClsRmTypeENEx GetObjExByid_ClassRoomType(string strid_ClassRoomType)
{
clsClsRmTypeEN objClsRmTypeEN = clsClsRmTypeBL.GetObjByIdClassRoomType(strid_ClassRoomType);
clsClsRmTypeENEx objClsRmTypeENEx = new clsClsRmTypeENEx();
clsClsRmTypeBL.CopyTo(objClsRmTypeEN, objClsRmTypeENEx);
return objClsRmTypeENEx;
}
}
}