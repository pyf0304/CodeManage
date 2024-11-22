
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PaperParagraphBLEx
 表名:vgs_PaperParagraph(01120747)
 生成代码版本:2020.09.09.1
 生成日期:2020/09/23 19:04:39
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
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
public static class clsvgs_PaperParagraphBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PaperParagraphEN:objvgs_PaperParagraphENT</returns>
 public static clsvgs_PaperParagraphENEx CopyToEx(this clsvgs_PaperParagraphEN objvgs_PaperParagraphENS)
{
try
{
 clsvgs_PaperParagraphENEx objvgs_PaperParagraphENT = new clsvgs_PaperParagraphENEx();
clsvgs_PaperParagraphBL.vgs_PaperParagraphDA.CopyTo(objvgs_PaperParagraphENS, objvgs_PaperParagraphENT);
 return objvgs_PaperParagraphENT;
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
 /// <param name = "objvgs_PaperParagraphENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PaperParagraphEN:objvgs_PaperParagraphENT</returns>
 public static clsvgs_PaperParagraphEN CopyTo(this clsvgs_PaperParagraphENEx objvgs_PaperParagraphENS)
{
try
{
 clsvgs_PaperParagraphEN objvgs_PaperParagraphENT = new clsvgs_PaperParagraphEN();
clsvgs_PaperParagraphBL.CopyTo(objvgs_PaperParagraphENS, objvgs_PaperParagraphENT);
 return objvgs_PaperParagraphENT;
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
 /// 论文段落视图(vgs_PaperParagraph)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvgs_PaperParagraphBLEx : clsvgs_PaperParagraphBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvgs_PaperParagraphDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvgs_PaperParagraphDAEx vgs_PaperParagraphDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvgs_PaperParagraphDAEx();
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
public static List<clsvgs_PaperParagraphENEx> GetObjExLst(string strCondition)
{
List <clsvgs_PaperParagraphEN> arrObjLst = clsvgs_PaperParagraphBL.GetObjLst(strCondition);
List <clsvgs_PaperParagraphENEx> arrObjExLst = new List<clsvgs_PaperParagraphENEx>();
foreach (clsvgs_PaperParagraphEN objInFor in arrObjLst)
{
clsvgs_PaperParagraphENEx objvgs_PaperParagraphENEx = new clsvgs_PaperParagraphENEx();
clsvgs_PaperParagraphBL.CopyTo(objInFor, objvgs_PaperParagraphENEx);
arrObjExLst.Add(objvgs_PaperParagraphENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strParagraphId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvgs_PaperParagraphENEx GetObjExByParagraphId(string strParagraphId)
{
clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = clsvgs_PaperParagraphBL.GetObjByParagraphId(strParagraphId);
clsvgs_PaperParagraphENEx objvgs_PaperParagraphENEx = new clsvgs_PaperParagraphENEx();
clsvgs_PaperParagraphBL.CopyTo(objvgs_PaperParagraphEN, objvgs_PaperParagraphENEx);
return objvgs_PaperParagraphENEx;
}
}
}