
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseExamPaperRelationshipBLEx
 表名:vcc_CourseExamPaperRelationship(01120075)
 生成代码版本:2021.02.03.1
 生成日期:2021/02/08 18:52:50
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
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
public static class clsvcc_CourseExamPaperRelationshipBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseExamPaperRelationshipEN:objvcc_CourseExamPaperRelationshipENT</returns>
 public static clsvcc_CourseExamPaperRelationshipENEx CopyToEx(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipENS)
{
try
{
 clsvcc_CourseExamPaperRelationshipENEx objvcc_CourseExamPaperRelationshipENT = new clsvcc_CourseExamPaperRelationshipENEx();
clsvcc_CourseExamPaperRelationshipBL.vcc_CourseExamPaperRelationshipDA.CopyTo(objvcc_CourseExamPaperRelationshipENS, objvcc_CourseExamPaperRelationshipENT);
 return objvcc_CourseExamPaperRelationshipENT;
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
 /// <param name = "objvcc_CourseExamPaperRelationshipENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseExamPaperRelationshipEN:objvcc_CourseExamPaperRelationshipENT</returns>
 public static clsvcc_CourseExamPaperRelationshipEN CopyTo(this clsvcc_CourseExamPaperRelationshipENEx objvcc_CourseExamPaperRelationshipENS)
{
try
{
 clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipENT = new clsvcc_CourseExamPaperRelationshipEN();
clsvcc_CourseExamPaperRelationshipBL.CopyTo(objvcc_CourseExamPaperRelationshipENS, objvcc_CourseExamPaperRelationshipENT);
 return objvcc_CourseExamPaperRelationshipENT;
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
 /// 题目与试卷关系(vcc_CourseExamPaperRelationship)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvcc_CourseExamPaperRelationshipBLEx : clsvcc_CourseExamPaperRelationshipBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvcc_CourseExamPaperRelationshipDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvcc_CourseExamPaperRelationshipDAEx vcc_CourseExamPaperRelationshipDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvcc_CourseExamPaperRelationshipDAEx();
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
public static List<clsvcc_CourseExamPaperRelationshipENEx> GetObjExLst(string strCondition)
{
List <clsvcc_CourseExamPaperRelationshipEN> arrObjLst = clsvcc_CourseExamPaperRelationshipBL.GetObjLst(strCondition);
List <clsvcc_CourseExamPaperRelationshipENEx> arrObjExLst = new List<clsvcc_CourseExamPaperRelationshipENEx>();
foreach (clsvcc_CourseExamPaperRelationshipEN objInFor in arrObjLst)
{
clsvcc_CourseExamPaperRelationshipENEx objvcc_CourseExamPaperRelationshipENEx = new clsvcc_CourseExamPaperRelationshipENEx();
clsvcc_CourseExamPaperRelationshipBL.CopyTo(objInFor, objvcc_CourseExamPaperRelationshipENEx);
arrObjExLst.Add(objvcc_CourseExamPaperRelationshipENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvcc_CourseExamPaperRelationshipENEx GetObjExBymId(long lngmId)
{
clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = clsvcc_CourseExamPaperRelationshipBL.GetObjBymId(lngmId);
clsvcc_CourseExamPaperRelationshipENEx objvcc_CourseExamPaperRelationshipENEx = new clsvcc_CourseExamPaperRelationshipENEx();
clsvcc_CourseExamPaperRelationshipBL.CopyTo(objvcc_CourseExamPaperRelationshipEN, objvcc_CourseExamPaperRelationshipENEx);
return objvcc_CourseExamPaperRelationshipENEx;
}
}
}