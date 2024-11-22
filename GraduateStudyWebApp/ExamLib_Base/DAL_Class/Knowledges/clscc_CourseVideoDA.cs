
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseVideoDA
 表名:cc_CourseVideo(01120081)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:11
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
 框架-层名:数据处理层(CS)(DALCode)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using ExamLib.Entity;

namespace ExamLib.DAL
{
 /// <summary>
 /// 课程视频(cc_CourseVideo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_CourseVideoDA : clsCommBase4DA
{
 /// <summary>
 /// 错误信息
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected const string EXCEPTION_MSG = "出错:"; //there was an error in the method. please see the Application Log for details.";
 /// <summary>
 /// 模块名称
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected string mstrModuleName;
//以下是属性变量

 /// <summary>
 /// 当前表名
 /// </summary>
 public override string _CurrTabName
 {
 get
 {
 return clscc_CourseVideoEN._CurrTabName;
 }
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.DALCode4CSharp:Gen_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clscc_CourseVideoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_CourseVideoEN._ConnectString);
}
return objSQL;
}


 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetSpecSQLObj_Obj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public override clsSpecSQLforSql GetSpecSQLObj_Obj() 
{
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
 if (string.IsNullOrEmpty(clscc_CourseVideoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_CourseVideoEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCourseVideoId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCourseVideoId)
{
strCourseVideoId = strCourseVideoId.Replace("'", "''");
if (strCourseVideoId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:cc_CourseVideo中,检查关键字,长度不正确!(clscc_CourseVideoDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCourseVideoId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:cc_CourseVideo中,关键字不能为空 或 null!(clscc_CourseVideoDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseVideoId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clscc_CourseVideoDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_CourseVideoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseVideo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_CourseVideo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_CourseVideoDA: GetDataTable_cc_CourseVideo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseVideo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_CourseVideoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_CourseVideoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseVideo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_CourseVideoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_CourseVideoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseVideo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseVideo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_Exclude)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_CourseVideoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_CourseVideo where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_CourseVideoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} cc_CourseVideo.* from cc_CourseVideo Left Join {1} on {2} where {3} and cc_CourseVideo.CourseVideoId not in (Select top {5} cc_CourseVideo.CourseVideoId from cc_CourseVideo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseVideo where {1} and CourseVideoId not in (Select top {2} CourseVideoId from cc_CourseVideo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseVideo where {1} and CourseVideoId not in (Select top {3} CourseVideoId from cc_CourseVideo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_Exclude)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_CourseVideoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} cc_CourseVideo.* from cc_CourseVideo Left Join {1} on {2} where {3} and cc_CourseVideo.CourseVideoId not in (Select top {5} cc_CourseVideo.CourseVideoId from cc_CourseVideo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseVideo where {1} and CourseVideoId not in (Select top {2} CourseVideoId from cc_CourseVideo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseVideo where {1} and CourseVideoId not in (Select top {3} CourseVideoId from cc_CourseVideo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 #endregion 获取数据表的DataTable

 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clscc_CourseVideoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_CourseVideoDA:GetObjLst)", objException.Message));
}
List<clscc_CourseVideoEN> arrObjLst = new List<clscc_CourseVideoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseVideo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseVideoEN objcc_CourseVideoEN = new clscc_CourseVideoEN();
try
{
objcc_CourseVideoEN.CourseVideoId = objRow[concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id
objcc_CourseVideoEN.UserId = objRow[concc_CourseVideo.UserId].ToString().Trim(); //用户ID
objcc_CourseVideoEN.FilePath = objRow[concc_CourseVideo.FilePath] == DBNull.Value ? null : objRow[concc_CourseVideo.FilePath].ToString().Trim(); //文件路径
objcc_CourseVideoEN.FileSize = objRow[concc_CourseVideo.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseVideo.FileSize].ToString().Trim()); //文件大小
objcc_CourseVideoEN.FileSizeUnit = objRow[concc_CourseVideo.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseVideoEN.UploadDate = objRow[concc_CourseVideo.UploadDate] == DBNull.Value ? null : objRow[concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间
objcc_CourseVideoEN.IsShow = TransNullToBool(objRow[concc_CourseVideo.IsShow].ToString().Trim()); //是否启用
objcc_CourseVideoEN.CourseResourceName = objRow[concc_CourseVideo.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseVideoEN.ResourcePicPath = objRow[concc_CourseVideo.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseVideoEN.IsCast = TransNullToBool(objRow[concc_CourseVideo.IsCast].ToString().Trim()); //是否播放
objcc_CourseVideoEN.IsDown = TransNullToBool(objRow[concc_CourseVideo.IsDown].ToString().Trim()); //是否下载
objcc_CourseVideoEN.LikeCount = objRow[concc_CourseVideo.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseVideo.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseVideoEN.CourseId = objRow[concc_CourseVideo.CourseId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseId].ToString().Trim(); //课程Id
objcc_CourseVideoEN.CourseChapterId = objRow[concc_CourseVideo.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseVideoEN.ResourceType = objRow[concc_CourseVideo.ResourceType] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_CourseVideoDA: GetObjLst)", objException.Message));
}
objcc_CourseVideoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_CourseVideoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clscc_CourseVideoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_CourseVideoDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_CourseVideoEN> arrObjLst = new List<clscc_CourseVideoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseVideoEN objcc_CourseVideoEN = new clscc_CourseVideoEN();
try
{
objcc_CourseVideoEN.CourseVideoId = objRow[concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id
objcc_CourseVideoEN.UserId = objRow[concc_CourseVideo.UserId].ToString().Trim(); //用户ID
objcc_CourseVideoEN.FilePath = objRow[concc_CourseVideo.FilePath] == DBNull.Value ? null : objRow[concc_CourseVideo.FilePath].ToString().Trim(); //文件路径
objcc_CourseVideoEN.FileSize = objRow[concc_CourseVideo.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseVideo.FileSize].ToString().Trim()); //文件大小
objcc_CourseVideoEN.FileSizeUnit = objRow[concc_CourseVideo.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseVideoEN.UploadDate = objRow[concc_CourseVideo.UploadDate] == DBNull.Value ? null : objRow[concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间
objcc_CourseVideoEN.IsShow = TransNullToBool(objRow[concc_CourseVideo.IsShow].ToString().Trim()); //是否启用
objcc_CourseVideoEN.CourseResourceName = objRow[concc_CourseVideo.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseVideoEN.ResourcePicPath = objRow[concc_CourseVideo.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseVideoEN.IsCast = TransNullToBool(objRow[concc_CourseVideo.IsCast].ToString().Trim()); //是否播放
objcc_CourseVideoEN.IsDown = TransNullToBool(objRow[concc_CourseVideo.IsDown].ToString().Trim()); //是否下载
objcc_CourseVideoEN.LikeCount = objRow[concc_CourseVideo.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseVideo.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseVideoEN.CourseId = objRow[concc_CourseVideo.CourseId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseId].ToString().Trim(); //课程Id
objcc_CourseVideoEN.CourseChapterId = objRow[concc_CourseVideo.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseVideoEN.ResourceType = objRow[concc_CourseVideo.ResourceType] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_CourseVideoDA: GetObjLst)", objException.Message));
}
objcc_CourseVideoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_CourseVideoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_CourseVideo(ref clscc_CourseVideoEN objcc_CourseVideoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseVideo where CourseVideoId = " + "'"+ objcc_CourseVideoEN.CourseVideoId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_CourseVideoEN.CourseVideoId = objDT.Rows[0][concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseVideoEN.UserId = objDT.Rows[0][concc_CourseVideo.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objcc_CourseVideoEN.FilePath = objDT.Rows[0][concc_CourseVideo.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objcc_CourseVideoEN.FileSize = TransNullToDouble(objDT.Rows[0][concc_CourseVideo.FileSize].ToString().Trim()); //文件大小(字段类型:decimal,字段长度:22,是否可空:True)
 objcc_CourseVideoEN.FileSizeUnit = objDT.Rows[0][concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_CourseVideoEN.UploadDate = objDT.Rows[0][concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:20,是否可空:False)
 objcc_CourseVideoEN.IsShow = TransNullToBool(objDT.Rows[0][concc_CourseVideo.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseVideoEN.CourseResourceName = objDT.Rows[0][concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称(字段类型:varchar,字段长度:200,是否可空:False)
 objcc_CourseVideoEN.ResourcePicPath = objDT.Rows[0][concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置(字段类型:varchar,字段长度:500,是否可空:True)
 objcc_CourseVideoEN.IsCast = TransNullToBool(objDT.Rows[0][concc_CourseVideo.IsCast].ToString().Trim()); //是否播放(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseVideoEN.IsDown = TransNullToBool(objDT.Rows[0][concc_CourseVideo.IsDown].ToString().Trim()); //是否下载(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseVideoEN.LikeCount = TransNullToInt(objDT.Rows[0][concc_CourseVideo.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_CourseVideoEN.CourseId = objDT.Rows[0][concc_CourseVideo.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseVideoEN.CourseChapterId = objDT.Rows[0][concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseVideoEN.ResourceType = objDT.Rows[0][concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_CourseVideoDA: Getcc_CourseVideo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseVideoId">表关键字</param>
 /// <returns>表对象</returns>
public clscc_CourseVideoEN GetObjByCourseVideoId(string strCourseVideoId)
{
CheckPrimaryKey(strCourseVideoId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseVideo where CourseVideoId = " + "'"+ strCourseVideoId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_CourseVideoEN objcc_CourseVideoEN = new clscc_CourseVideoEN();
try
{
 objcc_CourseVideoEN.CourseVideoId = objRow[concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseVideoEN.UserId = objRow[concc_CourseVideo.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objcc_CourseVideoEN.FilePath = objRow[concc_CourseVideo.FilePath] == DBNull.Value ? null : objRow[concc_CourseVideo.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objcc_CourseVideoEN.FileSize = objRow[concc_CourseVideo.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseVideo.FileSize].ToString().Trim()); //文件大小(字段类型:decimal,字段长度:22,是否可空:True)
 objcc_CourseVideoEN.FileSizeUnit = objRow[concc_CourseVideo.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_CourseVideoEN.UploadDate = objRow[concc_CourseVideo.UploadDate] == DBNull.Value ? null : objRow[concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:20,是否可空:False)
 objcc_CourseVideoEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseVideoEN.CourseResourceName = objRow[concc_CourseVideo.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称(字段类型:varchar,字段长度:200,是否可空:False)
 objcc_CourseVideoEN.ResourcePicPath = objRow[concc_CourseVideo.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置(字段类型:varchar,字段长度:500,是否可空:True)
 objcc_CourseVideoEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsCast].ToString().Trim()); //是否播放(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseVideoEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsDown].ToString().Trim()); //是否下载(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseVideoEN.LikeCount = objRow[concc_CourseVideo.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseVideo.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_CourseVideoEN.CourseId = objRow[concc_CourseVideo.CourseId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseVideoEN.CourseChapterId = objRow[concc_CourseVideo.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseVideoEN.ResourceType = objRow[concc_CourseVideo.ResourceType] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_CourseVideoDA: GetObjByCourseVideoId)", objException.Message));
}
return objcc_CourseVideoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_CourseVideoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_CourseVideoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseVideo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_CourseVideoEN objcc_CourseVideoEN = new clscc_CourseVideoEN()
{
CourseVideoId = objRow[concc_CourseVideo.CourseVideoId].ToString().Trim(), //课程视频Id
UserId = objRow[concc_CourseVideo.UserId].ToString().Trim(), //用户ID
FilePath = objRow[concc_CourseVideo.FilePath] == DBNull.Value ? null : objRow[concc_CourseVideo.FilePath].ToString().Trim(), //文件路径
FileSize = objRow[concc_CourseVideo.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseVideo.FileSize].ToString().Trim()), //文件大小
FileSizeUnit = objRow[concc_CourseVideo.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(), //文件大小单位
UploadDate = objRow[concc_CourseVideo.UploadDate] == DBNull.Value ? null : objRow[concc_CourseVideo.UploadDate].ToString().Trim(), //上传时间
IsShow = TransNullToBool(objRow[concc_CourseVideo.IsShow].ToString().Trim()), //是否启用
CourseResourceName = objRow[concc_CourseVideo.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseResourceName].ToString().Trim(), //教学视频名称
ResourcePicPath = objRow[concc_CourseVideo.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(), //图片位置
IsCast = TransNullToBool(objRow[concc_CourseVideo.IsCast].ToString().Trim()), //是否播放
IsDown = TransNullToBool(objRow[concc_CourseVideo.IsDown].ToString().Trim()), //是否下载
LikeCount = objRow[concc_CourseVideo.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseVideo.LikeCount].ToString().Trim()), //资源喜欢数量
CourseId = objRow[concc_CourseVideo.CourseId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseId].ToString().Trim(), //课程Id
CourseChapterId = objRow[concc_CourseVideo.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseChapterId].ToString().Trim(), //课程章节ID
ResourceType = objRow[concc_CourseVideo.ResourceType] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourceType].ToString().Trim() //ResourceType
};
objcc_CourseVideoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseVideoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_CourseVideoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_CourseVideoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_CourseVideoEN objcc_CourseVideoEN = new clscc_CourseVideoEN();
try
{
objcc_CourseVideoEN.CourseVideoId = objRow[concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id
objcc_CourseVideoEN.UserId = objRow[concc_CourseVideo.UserId].ToString().Trim(); //用户ID
objcc_CourseVideoEN.FilePath = objRow[concc_CourseVideo.FilePath] == DBNull.Value ? null : objRow[concc_CourseVideo.FilePath].ToString().Trim(); //文件路径
objcc_CourseVideoEN.FileSize = objRow[concc_CourseVideo.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseVideo.FileSize].ToString().Trim()); //文件大小
objcc_CourseVideoEN.FileSizeUnit = objRow[concc_CourseVideo.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseVideoEN.UploadDate = objRow[concc_CourseVideo.UploadDate] == DBNull.Value ? null : objRow[concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间
objcc_CourseVideoEN.IsShow = TransNullToBool(objRow[concc_CourseVideo.IsShow].ToString().Trim()); //是否启用
objcc_CourseVideoEN.CourseResourceName = objRow[concc_CourseVideo.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseVideoEN.ResourcePicPath = objRow[concc_CourseVideo.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseVideoEN.IsCast = TransNullToBool(objRow[concc_CourseVideo.IsCast].ToString().Trim()); //是否播放
objcc_CourseVideoEN.IsDown = TransNullToBool(objRow[concc_CourseVideo.IsDown].ToString().Trim()); //是否下载
objcc_CourseVideoEN.LikeCount = objRow[concc_CourseVideo.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseVideo.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseVideoEN.CourseId = objRow[concc_CourseVideo.CourseId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseId].ToString().Trim(); //课程Id
objcc_CourseVideoEN.CourseChapterId = objRow[concc_CourseVideo.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseVideoEN.ResourceType = objRow[concc_CourseVideo.ResourceType] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_CourseVideoDA: GetObjByDataRowcc_CourseVideo)", objException.Message));
}
objcc_CourseVideoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseVideoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_CourseVideoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_CourseVideoEN objcc_CourseVideoEN = new clscc_CourseVideoEN();
try
{
objcc_CourseVideoEN.CourseVideoId = objRow[concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id
objcc_CourseVideoEN.UserId = objRow[concc_CourseVideo.UserId].ToString().Trim(); //用户ID
objcc_CourseVideoEN.FilePath = objRow[concc_CourseVideo.FilePath] == DBNull.Value ? null : objRow[concc_CourseVideo.FilePath].ToString().Trim(); //文件路径
objcc_CourseVideoEN.FileSize = objRow[concc_CourseVideo.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseVideo.FileSize].ToString().Trim()); //文件大小
objcc_CourseVideoEN.FileSizeUnit = objRow[concc_CourseVideo.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseVideoEN.UploadDate = objRow[concc_CourseVideo.UploadDate] == DBNull.Value ? null : objRow[concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间
objcc_CourseVideoEN.IsShow = TransNullToBool(objRow[concc_CourseVideo.IsShow].ToString().Trim()); //是否启用
objcc_CourseVideoEN.CourseResourceName = objRow[concc_CourseVideo.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseVideoEN.ResourcePicPath = objRow[concc_CourseVideo.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseVideoEN.IsCast = TransNullToBool(objRow[concc_CourseVideo.IsCast].ToString().Trim()); //是否播放
objcc_CourseVideoEN.IsDown = TransNullToBool(objRow[concc_CourseVideo.IsDown].ToString().Trim()); //是否下载
objcc_CourseVideoEN.LikeCount = objRow[concc_CourseVideo.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseVideo.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseVideoEN.CourseId = objRow[concc_CourseVideo.CourseId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseId].ToString().Trim(); //课程Id
objcc_CourseVideoEN.CourseChapterId = objRow[concc_CourseVideo.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseVideoEN.ResourceType = objRow[concc_CourseVideo.ResourceType] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_CourseVideoDA: GetObjByDataRow)", objException.Message));
}
objcc_CourseVideoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseVideoEN;
}

 #endregion 获取一个实体对象

 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrID)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public static string GetMaxStrId()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_CourseVideoEN._CurrTabName, concc_CourseVideo.CourseVideoId, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_CourseVideoEN._CurrTabName, concc_CourseVideo.CourseVideoId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CourseVideoId from cc_CourseVideo where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
return strKeyValue;
}

 #endregion 获取一个关键字值

 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的所有记录的关键字值列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetPrimaryKeyID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的关键字值列表</returns>
public List<string> GetID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
List<string> arrList = new List<string>();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CourseVideoId from cc_CourseVideo where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return null;
}
for (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)
{
strKeyValue = "";
for (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)
{
if (iCol  ==  0)
{
strKeyValue +=  objDT.Rows[iRow][iCol].ToString();
}
else
{
strKeyValue +=  "//" + objDT.Rows[iRow][iCol].ToString();
}
}
arrList.Add(strKeyValue);
}
return arrList;
}

 #endregion 获取多个关键字值列表

 #region 判断记录是否存在

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExist_S)
 /// </summary>
 /// <param name = "strCourseVideoId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCourseVideoId)
{
CheckPrimaryKey(strCourseVideoId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_CourseVideo", "CourseVideoId = " + "'"+ strCourseVideoId+"'"))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistCondRec_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public bool IsExistCondRec(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_CourseVideoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_CourseVideo", strCondition))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_CourseVideo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_CourseVideoEN objcc_CourseVideoEN)
 {
 if (objcc_CourseVideoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseVideoEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseVideo where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_CourseVideo");
objRow = objDS.Tables["cc_CourseVideo"].NewRow();
objRow[concc_CourseVideo.CourseVideoId] = objcc_CourseVideoEN.CourseVideoId; //课程视频Id
objRow[concc_CourseVideo.UserId] = objcc_CourseVideoEN.UserId; //用户ID
 if (objcc_CourseVideoEN.FilePath !=  "")
 {
objRow[concc_CourseVideo.FilePath] = objcc_CourseVideoEN.FilePath; //文件路径
 }
objRow[concc_CourseVideo.FileSize] = objcc_CourseVideoEN.FileSize; //文件大小
 if (objcc_CourseVideoEN.FileSizeUnit !=  "")
 {
objRow[concc_CourseVideo.FileSizeUnit] = objcc_CourseVideoEN.FileSizeUnit; //文件大小单位
 }
 if (objcc_CourseVideoEN.UploadDate !=  "")
 {
objRow[concc_CourseVideo.UploadDate] = objcc_CourseVideoEN.UploadDate; //上传时间
 }
objRow[concc_CourseVideo.IsShow] = objcc_CourseVideoEN.IsShow; //是否启用
 if (objcc_CourseVideoEN.CourseResourceName !=  "")
 {
objRow[concc_CourseVideo.CourseResourceName] = objcc_CourseVideoEN.CourseResourceName; //教学视频名称
 }
 if (objcc_CourseVideoEN.ResourcePicPath !=  "")
 {
objRow[concc_CourseVideo.ResourcePicPath] = objcc_CourseVideoEN.ResourcePicPath; //图片位置
 }
objRow[concc_CourseVideo.IsCast] = objcc_CourseVideoEN.IsCast; //是否播放
objRow[concc_CourseVideo.IsDown] = objcc_CourseVideoEN.IsDown; //是否下载
objRow[concc_CourseVideo.LikeCount] = objcc_CourseVideoEN.LikeCount; //资源喜欢数量
 if (objcc_CourseVideoEN.CourseId !=  "")
 {
objRow[concc_CourseVideo.CourseId] = objcc_CourseVideoEN.CourseId; //课程Id
 }
 if (objcc_CourseVideoEN.CourseChapterId !=  "")
 {
objRow[concc_CourseVideo.CourseChapterId] = objcc_CourseVideoEN.CourseChapterId; //课程章节ID
 }
 if (objcc_CourseVideoEN.ResourceType !=  "")
 {
objRow[concc_CourseVideo.ResourceType] = objcc_CourseVideoEN.ResourceType; //ResourceType
 }
objDS.Tables[clscc_CourseVideoEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_CourseVideoEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_CourseVideoEN objcc_CourseVideoEN)
{
 if (objcc_CourseVideoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseVideoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseVideoEN.CourseVideoId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.CourseVideoId);
 var strCourseVideoId = objcc_CourseVideoEN.CourseVideoId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseVideoId + "'");
 }
 
 if (objcc_CourseVideoEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.UserId);
 var strUserId = objcc_CourseVideoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objcc_CourseVideoEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.FilePath);
 var strFilePath = objcc_CourseVideoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objcc_CourseVideoEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.FileSize);
 arrValueListForInsert.Add(objcc_CourseVideoEN.FileSize.ToString());
 }
 
 if (objcc_CourseVideoEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.FileSizeUnit);
 var strFileSizeUnit = objcc_CourseVideoEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objcc_CourseVideoEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.UploadDate);
 var strUploadDate = objcc_CourseVideoEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseVideo.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseVideoEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseVideoEN.CourseResourceName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.CourseResourceName);
 var strCourseResourceName = objcc_CourseVideoEN.CourseResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseResourceName + "'");
 }
 
 if (objcc_CourseVideoEN.ResourcePicPath !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.ResourcePicPath);
 var strResourcePicPath = objcc_CourseVideoEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourcePicPath + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseVideo.IsCast);
 arrValueListForInsert.Add("'" + (objcc_CourseVideoEN.IsCast  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseVideo.IsDown);
 arrValueListForInsert.Add("'" + (objcc_CourseVideoEN.IsDown  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseVideoEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.LikeCount);
 arrValueListForInsert.Add(objcc_CourseVideoEN.LikeCount.ToString());
 }
 
 if (objcc_CourseVideoEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.CourseId);
 var strCourseId = objcc_CourseVideoEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseVideoEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.CourseChapterId);
 var strCourseChapterId = objcc_CourseVideoEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_CourseVideoEN.ResourceType !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.ResourceType);
 var strResourceType = objcc_CourseVideoEN.ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceType + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseVideo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_CourseVideoEN objcc_CourseVideoEN)
{
 if (objcc_CourseVideoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseVideoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseVideoEN.CourseVideoId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.CourseVideoId);
 var strCourseVideoId = objcc_CourseVideoEN.CourseVideoId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseVideoId + "'");
 }
 
 if (objcc_CourseVideoEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.UserId);
 var strUserId = objcc_CourseVideoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objcc_CourseVideoEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.FilePath);
 var strFilePath = objcc_CourseVideoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objcc_CourseVideoEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.FileSize);
 arrValueListForInsert.Add(objcc_CourseVideoEN.FileSize.ToString());
 }
 
 if (objcc_CourseVideoEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.FileSizeUnit);
 var strFileSizeUnit = objcc_CourseVideoEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objcc_CourseVideoEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.UploadDate);
 var strUploadDate = objcc_CourseVideoEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseVideo.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseVideoEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseVideoEN.CourseResourceName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.CourseResourceName);
 var strCourseResourceName = objcc_CourseVideoEN.CourseResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseResourceName + "'");
 }
 
 if (objcc_CourseVideoEN.ResourcePicPath !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.ResourcePicPath);
 var strResourcePicPath = objcc_CourseVideoEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourcePicPath + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseVideo.IsCast);
 arrValueListForInsert.Add("'" + (objcc_CourseVideoEN.IsCast  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseVideo.IsDown);
 arrValueListForInsert.Add("'" + (objcc_CourseVideoEN.IsDown  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseVideoEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.LikeCount);
 arrValueListForInsert.Add(objcc_CourseVideoEN.LikeCount.ToString());
 }
 
 if (objcc_CourseVideoEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.CourseId);
 var strCourseId = objcc_CourseVideoEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseVideoEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.CourseChapterId);
 var strCourseChapterId = objcc_CourseVideoEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_CourseVideoEN.ResourceType !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.ResourceType);
 var strResourceType = objcc_CourseVideoEN.ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceType + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseVideo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objcc_CourseVideoEN.CourseVideoId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_CourseVideoEN objcc_CourseVideoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_CourseVideoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseVideoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseVideoEN.CourseVideoId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.CourseVideoId);
 var strCourseVideoId = objcc_CourseVideoEN.CourseVideoId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseVideoId + "'");
 }
 
 if (objcc_CourseVideoEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.UserId);
 var strUserId = objcc_CourseVideoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objcc_CourseVideoEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.FilePath);
 var strFilePath = objcc_CourseVideoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objcc_CourseVideoEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.FileSize);
 arrValueListForInsert.Add(objcc_CourseVideoEN.FileSize.ToString());
 }
 
 if (objcc_CourseVideoEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.FileSizeUnit);
 var strFileSizeUnit = objcc_CourseVideoEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objcc_CourseVideoEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.UploadDate);
 var strUploadDate = objcc_CourseVideoEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseVideo.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseVideoEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseVideoEN.CourseResourceName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.CourseResourceName);
 var strCourseResourceName = objcc_CourseVideoEN.CourseResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseResourceName + "'");
 }
 
 if (objcc_CourseVideoEN.ResourcePicPath !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.ResourcePicPath);
 var strResourcePicPath = objcc_CourseVideoEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourcePicPath + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseVideo.IsCast);
 arrValueListForInsert.Add("'" + (objcc_CourseVideoEN.IsCast  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseVideo.IsDown);
 arrValueListForInsert.Add("'" + (objcc_CourseVideoEN.IsDown  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseVideoEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.LikeCount);
 arrValueListForInsert.Add(objcc_CourseVideoEN.LikeCount.ToString());
 }
 
 if (objcc_CourseVideoEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.CourseId);
 var strCourseId = objcc_CourseVideoEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseVideoEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.CourseChapterId);
 var strCourseChapterId = objcc_CourseVideoEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_CourseVideoEN.ResourceType !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.ResourceType);
 var strResourceType = objcc_CourseVideoEN.ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceType + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseVideo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objcc_CourseVideoEN.CourseVideoId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_CourseVideoEN objcc_CourseVideoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objcc_CourseVideoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseVideoEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseVideoEN.CourseVideoId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.CourseVideoId);
 var strCourseVideoId = objcc_CourseVideoEN.CourseVideoId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseVideoId + "'");
 }
 
 if (objcc_CourseVideoEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.UserId);
 var strUserId = objcc_CourseVideoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objcc_CourseVideoEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.FilePath);
 var strFilePath = objcc_CourseVideoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objcc_CourseVideoEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.FileSize);
 arrValueListForInsert.Add(objcc_CourseVideoEN.FileSize.ToString());
 }
 
 if (objcc_CourseVideoEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.FileSizeUnit);
 var strFileSizeUnit = objcc_CourseVideoEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objcc_CourseVideoEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.UploadDate);
 var strUploadDate = objcc_CourseVideoEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseVideo.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseVideoEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseVideoEN.CourseResourceName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.CourseResourceName);
 var strCourseResourceName = objcc_CourseVideoEN.CourseResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseResourceName + "'");
 }
 
 if (objcc_CourseVideoEN.ResourcePicPath !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.ResourcePicPath);
 var strResourcePicPath = objcc_CourseVideoEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourcePicPath + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseVideo.IsCast);
 arrValueListForInsert.Add("'" + (objcc_CourseVideoEN.IsCast  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseVideo.IsDown);
 arrValueListForInsert.Add("'" + (objcc_CourseVideoEN.IsDown  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseVideoEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.LikeCount);
 arrValueListForInsert.Add(objcc_CourseVideoEN.LikeCount.ToString());
 }
 
 if (objcc_CourseVideoEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.CourseId);
 var strCourseId = objcc_CourseVideoEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseVideoEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.CourseChapterId);
 var strCourseChapterId = objcc_CourseVideoEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_CourseVideoEN.ResourceType !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseVideo.ResourceType);
 var strResourceType = objcc_CourseVideoEN.ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceType + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseVideo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_CourseVideos(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseVideo where CourseVideoId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_CourseVideo");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCourseVideoId = oRow[concc_CourseVideo.CourseVideoId].ToString().Trim();
if (IsExist(strCourseVideoId))
{
 string strResult = "关键字变量值为:" + string.Format("CourseVideoId = {0}", strCourseVideoId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_CourseVideoEN._CurrTabName ].NewRow();
objRow[concc_CourseVideo.CourseVideoId] = oRow[concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id
objRow[concc_CourseVideo.UserId] = oRow[concc_CourseVideo.UserId].ToString().Trim(); //用户ID
objRow[concc_CourseVideo.FilePath] = oRow[concc_CourseVideo.FilePath].ToString().Trim(); //文件路径
objRow[concc_CourseVideo.FileSize] = oRow[concc_CourseVideo.FileSize].ToString().Trim(); //文件大小
objRow[concc_CourseVideo.FileSizeUnit] = oRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位
objRow[concc_CourseVideo.UploadDate] = oRow[concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间
objRow[concc_CourseVideo.IsShow] = oRow[concc_CourseVideo.IsShow].ToString().Trim(); //是否启用
objRow[concc_CourseVideo.CourseResourceName] = oRow[concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称
objRow[concc_CourseVideo.ResourcePicPath] = oRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置
objRow[concc_CourseVideo.IsCast] = oRow[concc_CourseVideo.IsCast].ToString().Trim(); //是否播放
objRow[concc_CourseVideo.IsDown] = oRow[concc_CourseVideo.IsDown].ToString().Trim(); //是否下载
objRow[concc_CourseVideo.LikeCount] = oRow[concc_CourseVideo.LikeCount].ToString().Trim(); //资源喜欢数量
objRow[concc_CourseVideo.CourseId] = oRow[concc_CourseVideo.CourseId].ToString().Trim(); //课程Id
objRow[concc_CourseVideo.CourseChapterId] = oRow[concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID
objRow[concc_CourseVideo.ResourceType] = oRow[concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType
 objDS.Tables[clscc_CourseVideoEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_CourseVideoEN._CurrTabName);
}
catch(Exception objException) 
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objSQL.SQLConnect.Close();
}
return true;
}

 #endregion 添加记录

 #region 修改记录

 /// <summary>
 /// 功能:通过ADO修改记录
 /// (AutoGCLib.DALCode4CSharp:GenUpdate)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_CourseVideoEN objcc_CourseVideoEN)
{
 if (objcc_CourseVideoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseVideoEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseVideo where CourseVideoId = " + "'"+ objcc_CourseVideoEN.CourseVideoId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_CourseVideoEN._CurrTabName);
if (objDS.Tables[clscc_CourseVideoEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CourseVideoId = " + "'"+ objcc_CourseVideoEN.CourseVideoId+"'");
return false;
}
objRow = objDS.Tables[clscc_CourseVideoEN._CurrTabName].Rows[0];
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.CourseVideoId))
 {
objRow[concc_CourseVideo.CourseVideoId] = objcc_CourseVideoEN.CourseVideoId; //课程视频Id
 }
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.UserId))
 {
objRow[concc_CourseVideo.UserId] = objcc_CourseVideoEN.UserId; //用户ID
 }
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.FilePath))
 {
objRow[concc_CourseVideo.FilePath] = objcc_CourseVideoEN.FilePath; //文件路径
 }
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.FileSize))
 {
objRow[concc_CourseVideo.FileSize] = objcc_CourseVideoEN.FileSize; //文件大小
 }
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.FileSizeUnit))
 {
objRow[concc_CourseVideo.FileSizeUnit] = objcc_CourseVideoEN.FileSizeUnit; //文件大小单位
 }
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.UploadDate))
 {
objRow[concc_CourseVideo.UploadDate] = objcc_CourseVideoEN.UploadDate; //上传时间
 }
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.IsShow))
 {
objRow[concc_CourseVideo.IsShow] = objcc_CourseVideoEN.IsShow; //是否启用
 }
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.CourseResourceName))
 {
objRow[concc_CourseVideo.CourseResourceName] = objcc_CourseVideoEN.CourseResourceName; //教学视频名称
 }
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.ResourcePicPath))
 {
objRow[concc_CourseVideo.ResourcePicPath] = objcc_CourseVideoEN.ResourcePicPath; //图片位置
 }
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.IsCast))
 {
objRow[concc_CourseVideo.IsCast] = objcc_CourseVideoEN.IsCast; //是否播放
 }
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.IsDown))
 {
objRow[concc_CourseVideo.IsDown] = objcc_CourseVideoEN.IsDown; //是否下载
 }
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.LikeCount))
 {
objRow[concc_CourseVideo.LikeCount] = objcc_CourseVideoEN.LikeCount; //资源喜欢数量
 }
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.CourseId))
 {
objRow[concc_CourseVideo.CourseId] = objcc_CourseVideoEN.CourseId; //课程Id
 }
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.CourseChapterId))
 {
objRow[concc_CourseVideo.CourseChapterId] = objcc_CourseVideoEN.CourseChapterId; //课程章节ID
 }
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.ResourceType))
 {
objRow[concc_CourseVideo.ResourceType] = objcc_CourseVideoEN.ResourceType; //ResourceType
 }
try
{
objDA.Update(objDS, clscc_CourseVideoEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_CourseVideoEN objcc_CourseVideoEN)
{
 if (objcc_CourseVideoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseVideoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_CourseVideo Set ");
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.UserId))
 {
 if (objcc_CourseVideoEN.UserId !=  null)
 {
 var strUserId = objcc_CourseVideoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, concc_CourseVideo.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.UserId); //用户ID
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.FilePath))
 {
 if (objcc_CourseVideoEN.FilePath !=  null)
 {
 var strFilePath = objcc_CourseVideoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, concc_CourseVideo.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.FilePath); //文件路径
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.FileSize))
 {
 if (objcc_CourseVideoEN.FileSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseVideoEN.FileSize, concc_CourseVideo.FileSize); //文件大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.FileSize); //文件大小
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.FileSizeUnit))
 {
 if (objcc_CourseVideoEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objcc_CourseVideoEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileSizeUnit, concc_CourseVideo.FileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.FileSizeUnit); //文件大小单位
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.UploadDate))
 {
 if (objcc_CourseVideoEN.UploadDate !=  null)
 {
 var strUploadDate = objcc_CourseVideoEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadDate, concc_CourseVideo.UploadDate); //上传时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.UploadDate); //上传时间
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseVideoEN.IsShow == true?"1":"0", concc_CourseVideo.IsShow); //是否启用
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.CourseResourceName))
 {
 if (objcc_CourseVideoEN.CourseResourceName !=  null)
 {
 var strCourseResourceName = objcc_CourseVideoEN.CourseResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseResourceName, concc_CourseVideo.CourseResourceName); //教学视频名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.CourseResourceName); //教学视频名称
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.ResourcePicPath))
 {
 if (objcc_CourseVideoEN.ResourcePicPath !=  null)
 {
 var strResourcePicPath = objcc_CourseVideoEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourcePicPath, concc_CourseVideo.ResourcePicPath); //图片位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.ResourcePicPath); //图片位置
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.IsCast))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseVideoEN.IsCast == true?"1":"0", concc_CourseVideo.IsCast); //是否播放
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.IsDown))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseVideoEN.IsDown == true?"1":"0", concc_CourseVideo.IsDown); //是否下载
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.LikeCount))
 {
 if (objcc_CourseVideoEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseVideoEN.LikeCount, concc_CourseVideo.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.LikeCount); //资源喜欢数量
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.CourseId))
 {
 if (objcc_CourseVideoEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseVideoEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_CourseVideo.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.CourseId); //课程Id
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.CourseChapterId))
 {
 if (objcc_CourseVideoEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_CourseVideoEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, concc_CourseVideo.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.CourseChapterId); //课程章节ID
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.ResourceType))
 {
 if (objcc_CourseVideoEN.ResourceType !=  null)
 {
 var strResourceType = objcc_CourseVideoEN.ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceType, concc_CourseVideo.ResourceType); //ResourceType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.ResourceType); //ResourceType
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CourseVideoId = '{0}'", objcc_CourseVideoEN.CourseVideoId); 
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
string strMsg = string.Format("发生错误:[{0}].SQL:[{1}].({2})",
     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_CourseVideoEN objcc_CourseVideoEN, string strCondition)
{
 if (objcc_CourseVideoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseVideoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseVideo Set ");
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.UserId))
 {
 if (objcc_CourseVideoEN.UserId !=  null)
 {
 var strUserId = objcc_CourseVideoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.FilePath))
 {
 if (objcc_CourseVideoEN.FilePath !=  null)
 {
 var strFilePath = objcc_CourseVideoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.FileSize))
 {
 sbSQL.AppendFormat(" FileSize = {0},", objcc_CourseVideoEN.FileSize); //文件大小
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.FileSizeUnit))
 {
 if (objcc_CourseVideoEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objcc_CourseVideoEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileSizeUnit = '{0}',", strFileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.Append(" FileSizeUnit = null,"); //文件大小单位
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.UploadDate))
 {
 if (objcc_CourseVideoEN.UploadDate !=  null)
 {
 var strUploadDate = objcc_CourseVideoEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadDate = '{0}',", strUploadDate); //上传时间
 }
 else
 {
 sbSQL.Append(" UploadDate = null,"); //上传时间
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objcc_CourseVideoEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.CourseResourceName))
 {
 if (objcc_CourseVideoEN.CourseResourceName !=  null)
 {
 var strCourseResourceName = objcc_CourseVideoEN.CourseResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseResourceName = '{0}',", strCourseResourceName); //教学视频名称
 }
 else
 {
 sbSQL.Append(" CourseResourceName = null,"); //教学视频名称
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.ResourcePicPath))
 {
 if (objcc_CourseVideoEN.ResourcePicPath !=  null)
 {
 var strResourcePicPath = objcc_CourseVideoEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourcePicPath = '{0}',", strResourcePicPath); //图片位置
 }
 else
 {
 sbSQL.Append(" ResourcePicPath = null,"); //图片位置
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.IsCast))
 {
 sbSQL.AppendFormat(" IsCast = '{0}',", objcc_CourseVideoEN.IsCast == true?"1":"0"); //是否播放
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.IsDown))
 {
 sbSQL.AppendFormat(" IsDown = '{0}',", objcc_CourseVideoEN.IsDown == true?"1":"0"); //是否下载
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.LikeCount))
 {
 sbSQL.AppendFormat(" LikeCount = {0},", objcc_CourseVideoEN.LikeCount); //资源喜欢数量
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.CourseId))
 {
 if (objcc_CourseVideoEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseVideoEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.CourseChapterId))
 {
 if (objcc_CourseVideoEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_CourseVideoEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.ResourceType))
 {
 if (objcc_CourseVideoEN.ResourceType !=  null)
 {
 var strResourceType = objcc_CourseVideoEN.ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceType = '{0}',", strResourceType); //ResourceType
 }
 else
 {
 sbSQL.Append(" ResourceType = null,"); //ResourceType
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式,根据条件修改记录.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithConditionTransaction)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_CourseVideoEN objcc_CourseVideoEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_CourseVideoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseVideoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseVideo Set ");
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.UserId))
 {
 if (objcc_CourseVideoEN.UserId !=  null)
 {
 var strUserId = objcc_CourseVideoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.FilePath))
 {
 if (objcc_CourseVideoEN.FilePath !=  null)
 {
 var strFilePath = objcc_CourseVideoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.FileSize))
 {
 sbSQL.AppendFormat(" FileSize = {0},", objcc_CourseVideoEN.FileSize); //文件大小
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.FileSizeUnit))
 {
 if (objcc_CourseVideoEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objcc_CourseVideoEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileSizeUnit = '{0}',", strFileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.Append(" FileSizeUnit = null,"); //文件大小单位
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.UploadDate))
 {
 if (objcc_CourseVideoEN.UploadDate !=  null)
 {
 var strUploadDate = objcc_CourseVideoEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadDate = '{0}',", strUploadDate); //上传时间
 }
 else
 {
 sbSQL.Append(" UploadDate = null,"); //上传时间
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objcc_CourseVideoEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.CourseResourceName))
 {
 if (objcc_CourseVideoEN.CourseResourceName !=  null)
 {
 var strCourseResourceName = objcc_CourseVideoEN.CourseResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseResourceName = '{0}',", strCourseResourceName); //教学视频名称
 }
 else
 {
 sbSQL.Append(" CourseResourceName = null,"); //教学视频名称
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.ResourcePicPath))
 {
 if (objcc_CourseVideoEN.ResourcePicPath !=  null)
 {
 var strResourcePicPath = objcc_CourseVideoEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourcePicPath = '{0}',", strResourcePicPath); //图片位置
 }
 else
 {
 sbSQL.Append(" ResourcePicPath = null,"); //图片位置
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.IsCast))
 {
 sbSQL.AppendFormat(" IsCast = '{0}',", objcc_CourseVideoEN.IsCast == true?"1":"0"); //是否播放
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.IsDown))
 {
 sbSQL.AppendFormat(" IsDown = '{0}',", objcc_CourseVideoEN.IsDown == true?"1":"0"); //是否下载
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.LikeCount))
 {
 sbSQL.AppendFormat(" LikeCount = {0},", objcc_CourseVideoEN.LikeCount); //资源喜欢数量
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.CourseId))
 {
 if (objcc_CourseVideoEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseVideoEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.CourseChapterId))
 {
 if (objcc_CourseVideoEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_CourseVideoEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.ResourceType))
 {
 if (objcc_CourseVideoEN.ResourceType !=  null)
 {
 var strResourceType = objcc_CourseVideoEN.ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceType = '{0}',", strResourceType); //ResourceType
 }
 else
 {
 sbSQL.Append(" ResourceType = null,"); //ResourceType
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithTransaction2)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_CourseVideoEN objcc_CourseVideoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objcc_CourseVideoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseVideoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseVideo Set ");
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.UserId))
 {
 if (objcc_CourseVideoEN.UserId !=  null)
 {
 var strUserId = objcc_CourseVideoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, concc_CourseVideo.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.UserId); //用户ID
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.FilePath))
 {
 if (objcc_CourseVideoEN.FilePath !=  null)
 {
 var strFilePath = objcc_CourseVideoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, concc_CourseVideo.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.FilePath); //文件路径
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.FileSize))
 {
 if (objcc_CourseVideoEN.FileSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseVideoEN.FileSize, concc_CourseVideo.FileSize); //文件大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.FileSize); //文件大小
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.FileSizeUnit))
 {
 if (objcc_CourseVideoEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objcc_CourseVideoEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileSizeUnit, concc_CourseVideo.FileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.FileSizeUnit); //文件大小单位
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.UploadDate))
 {
 if (objcc_CourseVideoEN.UploadDate !=  null)
 {
 var strUploadDate = objcc_CourseVideoEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadDate, concc_CourseVideo.UploadDate); //上传时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.UploadDate); //上传时间
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseVideoEN.IsShow == true?"1":"0", concc_CourseVideo.IsShow); //是否启用
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.CourseResourceName))
 {
 if (objcc_CourseVideoEN.CourseResourceName !=  null)
 {
 var strCourseResourceName = objcc_CourseVideoEN.CourseResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseResourceName, concc_CourseVideo.CourseResourceName); //教学视频名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.CourseResourceName); //教学视频名称
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.ResourcePicPath))
 {
 if (objcc_CourseVideoEN.ResourcePicPath !=  null)
 {
 var strResourcePicPath = objcc_CourseVideoEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourcePicPath, concc_CourseVideo.ResourcePicPath); //图片位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.ResourcePicPath); //图片位置
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.IsCast))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseVideoEN.IsCast == true?"1":"0", concc_CourseVideo.IsCast); //是否播放
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.IsDown))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseVideoEN.IsDown == true?"1":"0", concc_CourseVideo.IsDown); //是否下载
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.LikeCount))
 {
 if (objcc_CourseVideoEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseVideoEN.LikeCount, concc_CourseVideo.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.LikeCount); //资源喜欢数量
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.CourseId))
 {
 if (objcc_CourseVideoEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseVideoEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_CourseVideo.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.CourseId); //课程Id
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.CourseChapterId))
 {
 if (objcc_CourseVideoEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_CourseVideoEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, concc_CourseVideo.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.CourseChapterId); //课程章节ID
 }
 }
 
 if (objcc_CourseVideoEN.IsUpdated(concc_CourseVideo.ResourceType))
 {
 if (objcc_CourseVideoEN.ResourceType !=  null)
 {
 var strResourceType = objcc_CourseVideoEN.ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceType, concc_CourseVideo.ResourceType); //ResourceType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseVideo.ResourceType); //ResourceType
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CourseVideoId = '{0}'", objcc_CourseVideoEN.CourseVideoId); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 #endregion 修改记录

 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySP)
 /// </summary>
 /// <param name = "strCourseVideoId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCourseVideoId) 
{
CheckPrimaryKey(strCourseVideoId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCourseVideoId,
};
 objSQL.ExecSP("cc_CourseVideo_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCourseVideoId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCourseVideoId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCourseVideoId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
//删除cc_CourseVideo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseVideo where CourseVideoId = " + "'"+ strCourseVideoId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_CourseVideo(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除cc_CourseVideo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseVideo where CourseVideoId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCourseVideoId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCourseVideoId) 
{
CheckPrimaryKey(strCourseVideoId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
//删除cc_CourseVideo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseVideo where CourseVideoId = " + "'"+ strCourseVideoId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_CourseVideo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_CourseVideoDA: Delcc_CourseVideo)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_CourseVideo where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool Delcc_CourseVideoWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_CourseVideoDA: Delcc_CourseVideoWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_CourseVideo where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objcc_CourseVideoENS">源对象</param>
 /// <param name = "objcc_CourseVideoENT">目标对象</param>
public void CopyTo(clscc_CourseVideoEN objcc_CourseVideoENS, clscc_CourseVideoEN objcc_CourseVideoENT)
{
objcc_CourseVideoENT.CourseVideoId = objcc_CourseVideoENS.CourseVideoId; //课程视频Id
objcc_CourseVideoENT.UserId = objcc_CourseVideoENS.UserId; //用户ID
objcc_CourseVideoENT.FilePath = objcc_CourseVideoENS.FilePath; //文件路径
objcc_CourseVideoENT.FileSize = objcc_CourseVideoENS.FileSize; //文件大小
objcc_CourseVideoENT.FileSizeUnit = objcc_CourseVideoENS.FileSizeUnit; //文件大小单位
objcc_CourseVideoENT.UploadDate = objcc_CourseVideoENS.UploadDate; //上传时间
objcc_CourseVideoENT.IsShow = objcc_CourseVideoENS.IsShow; //是否启用
objcc_CourseVideoENT.CourseResourceName = objcc_CourseVideoENS.CourseResourceName; //教学视频名称
objcc_CourseVideoENT.ResourcePicPath = objcc_CourseVideoENS.ResourcePicPath; //图片位置
objcc_CourseVideoENT.IsCast = objcc_CourseVideoENS.IsCast; //是否播放
objcc_CourseVideoENT.IsDown = objcc_CourseVideoENS.IsDown; //是否下载
objcc_CourseVideoENT.LikeCount = objcc_CourseVideoENS.LikeCount; //资源喜欢数量
objcc_CourseVideoENT.CourseId = objcc_CourseVideoENS.CourseId; //课程Id
objcc_CourseVideoENT.CourseChapterId = objcc_CourseVideoENS.CourseChapterId; //课程章节ID
objcc_CourseVideoENT.ResourceType = objcc_CourseVideoENS.ResourceType; //ResourceType
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_CourseVideoEN objcc_CourseVideoEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_CourseVideoEN.UserId, concc_CourseVideo.UserId);
clsCheckSql.CheckFieldNotNull(objcc_CourseVideoEN.IsShow, concc_CourseVideo.IsShow);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.CourseVideoId, 8, concc_CourseVideo.CourseVideoId);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.UserId, 18, concc_CourseVideo.UserId);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.FilePath, 500, concc_CourseVideo.FilePath);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.FileSizeUnit, 10, concc_CourseVideo.FileSizeUnit);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.UploadDate, 20, concc_CourseVideo.UploadDate);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.CourseResourceName, 200, concc_CourseVideo.CourseResourceName);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.ResourcePicPath, 500, concc_CourseVideo.ResourcePicPath);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.CourseId, 8, concc_CourseVideo.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.CourseChapterId, 8, concc_CourseVideo.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.ResourceType, 50, concc_CourseVideo.ResourceType);
//检查字段外键固定长度
 objcc_CourseVideoEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_CourseVideoEN objcc_CourseVideoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.UserId, 18, concc_CourseVideo.UserId);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.FilePath, 500, concc_CourseVideo.FilePath);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.FileSizeUnit, 10, concc_CourseVideo.FileSizeUnit);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.UploadDate, 20, concc_CourseVideo.UploadDate);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.CourseResourceName, 200, concc_CourseVideo.CourseResourceName);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.ResourcePicPath, 500, concc_CourseVideo.ResourcePicPath);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.CourseId, 8, concc_CourseVideo.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.CourseChapterId, 8, concc_CourseVideo.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.ResourceType, 50, concc_CourseVideo.ResourceType);
//检查外键字段长度
 objcc_CourseVideoEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_CourseVideoEN objcc_CourseVideoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.CourseVideoId, 8, concc_CourseVideo.CourseVideoId);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.UserId, 18, concc_CourseVideo.UserId);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.FilePath, 500, concc_CourseVideo.FilePath);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.FileSizeUnit, 10, concc_CourseVideo.FileSizeUnit);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.UploadDate, 20, concc_CourseVideo.UploadDate);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.CourseResourceName, 200, concc_CourseVideo.CourseResourceName);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.ResourcePicPath, 500, concc_CourseVideo.ResourcePicPath);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.CourseId, 8, concc_CourseVideo.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.CourseChapterId, 8, concc_CourseVideo.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseVideoEN.ResourceType, 50, concc_CourseVideo.ResourceType);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_CourseVideoEN.CourseVideoId, concc_CourseVideo.CourseVideoId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseVideoEN.UserId, concc_CourseVideo.UserId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseVideoEN.FilePath, concc_CourseVideo.FilePath);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseVideoEN.FileSizeUnit, concc_CourseVideo.FileSizeUnit);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseVideoEN.UploadDate, concc_CourseVideo.UploadDate);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseVideoEN.CourseResourceName, concc_CourseVideo.CourseResourceName);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseVideoEN.ResourcePicPath, concc_CourseVideo.ResourcePicPath);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseVideoEN.CourseId, concc_CourseVideo.CourseId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseVideoEN.CourseChapterId, concc_CourseVideo.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseVideoEN.ResourceType, concc_CourseVideo.ResourceType);
//检查外键字段长度
 objcc_CourseVideoEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 #endregion 检查唯一性

 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName, strCondition);
return intRecCount;
}



 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCount()
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_CourseVideoEN._CurrTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond)
 /// </summary>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCountByCond(string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_CourseVideoEN._CurrTabName, strCondition);
return intRecCount;
}

 /// <summary>
 /// 功能:获取给定表中的符合条件的某字段的值,以列表返回
 /// (AutoGCLib.DALCode4CSharp:GenGetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>获取的字段值列表</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.DALCode4CSharp:GenfunSetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "varValue">值</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}