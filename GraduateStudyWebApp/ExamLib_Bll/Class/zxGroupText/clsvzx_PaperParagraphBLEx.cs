
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_PaperParagraphBLEx
 表名:vzx_PaperParagraph(01120766)
 生成代码版本:2020.09.24.1
 生成日期:2020/11/08 15:39:15
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
public static class clsvzx_PaperParagraphBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphENS">源对象</param>
 /// <returns>目标对象=>clsvzx_PaperParagraphEN:objvzx_PaperParagraphENT</returns>
 public static clsvzx_PaperParagraphENEx CopyToEx(this clsvzx_PaperParagraphEN objvzx_PaperParagraphENS)
{
try
{
 clsvzx_PaperParagraphENEx objvzx_PaperParagraphENT = new clsvzx_PaperParagraphENEx();
clsvzx_PaperParagraphBL.vzx_PaperParagraphDA.CopyTo(objvzx_PaperParagraphENS, objvzx_PaperParagraphENT);
 return objvzx_PaperParagraphENT;
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
 /// <param name = "objvzx_PaperParagraphENS">源对象</param>
 /// <returns>目标对象=>clsvzx_PaperParagraphEN:objvzx_PaperParagraphENT</returns>
 public static clsvzx_PaperParagraphEN CopyTo(this clsvzx_PaperParagraphENEx objvzx_PaperParagraphENS)
{
try
{
 clsvzx_PaperParagraphEN objvzx_PaperParagraphENT = new clsvzx_PaperParagraphEN();
clsvzx_PaperParagraphBL.CopyTo(objvzx_PaperParagraphENS, objvzx_PaperParagraphENT);
 return objvzx_PaperParagraphENT;
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
 /// vzx_PaperParagraph(vzx_PaperParagraph)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvzx_PaperParagraphBLEx : clsvzx_PaperParagraphBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvzx_PaperParagraphDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvzx_PaperParagraphDAEx vzx_PaperParagraphDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvzx_PaperParagraphDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsvzx_PaperParagraphENEx> GetObjExLst(string strCondition)
{
List <clsvzx_PaperParagraphEN> arrObjLst = clsvzx_PaperParagraphBL.GetObjLst(strCondition);
List <clsvzx_PaperParagraphENEx> arrObjExLst = new List<clsvzx_PaperParagraphENEx>();
foreach (clsvzx_PaperParagraphEN objInFor in arrObjLst)
{
clsvzx_PaperParagraphENEx objvzx_PaperParagraphENEx = new clsvzx_PaperParagraphENEx();
clsvzx_PaperParagraphBL.CopyTo(objInFor, objvzx_PaperParagraphENEx);
arrObjExLst.Add(objvzx_PaperParagraphENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strParagraphId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvzx_PaperParagraphENEx GetObjExByParagraphId(string strParagraphId)
{
clsvzx_PaperParagraphEN objvzx_PaperParagraphEN = clsvzx_PaperParagraphBL.GetObjByzxParagraphId(strParagraphId);
clsvzx_PaperParagraphENEx objvzx_PaperParagraphENEx = new clsvzx_PaperParagraphENEx();
clsvzx_PaperParagraphBL.CopyTo(objvzx_PaperParagraphEN, objvzx_PaperParagraphENEx);
return objvzx_PaperParagraphENEx;
}
}
}