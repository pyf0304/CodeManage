
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseCaseDA
 表名:cc_CourseCase(01120080)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:02
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
 /// 课程教案(cc_CourseCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_CourseCaseDA : clsCommBase4DA
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
 return clscc_CourseCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_CourseCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_CourseCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_CourseCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_CourseCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCourseCaseId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCourseCaseId)
{
strCourseCaseId = strCourseCaseId.Replace("'", "''");
if (strCourseCaseId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:cc_CourseCase中,检查关键字,长度不正确!(clscc_CourseCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCourseCaseId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:cc_CourseCase中,关键字不能为空 或 null!(clscc_CourseCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseCaseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clscc_CourseCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_CourseCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_CourseCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_CourseCaseDA: GetDataTable_cc_CourseCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_CourseCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_CourseCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_CourseCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_CourseCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_CourseCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_CourseCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_CourseCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_CourseCase.* from cc_CourseCase Left Join {1} on {2} where {3} and cc_CourseCase.CourseCaseId not in (Select top {5} cc_CourseCase.CourseCaseId from cc_CourseCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseCase where {1} and CourseCaseId not in (Select top {2} CourseCaseId from cc_CourseCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseCase where {1} and CourseCaseId not in (Select top {3} CourseCaseId from cc_CourseCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_CourseCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_CourseCase.* from cc_CourseCase Left Join {1} on {2} where {3} and cc_CourseCase.CourseCaseId not in (Select top {5} cc_CourseCase.CourseCaseId from cc_CourseCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseCase where {1} and CourseCaseId not in (Select top {2} CourseCaseId from cc_CourseCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseCase where {1} and CourseCaseId not in (Select top {3} CourseCaseId from cc_CourseCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_CourseCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_CourseCaseDA:GetObjLst)", objException.Message));
}
List<clscc_CourseCaseEN> arrObjLst = new List<clscc_CourseCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseCaseEN objcc_CourseCaseEN = new clscc_CourseCaseEN();
try
{
objcc_CourseCaseEN.CourseCaseId = objRow[concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id
objcc_CourseCaseEN.CourseChapterId = objRow[concc_CourseCase.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseCaseEN.UserId = objRow[concc_CourseCase.UserId].ToString().Trim(); //用户ID
objcc_CourseCaseEN.FilePath = objRow[concc_CourseCase.FilePath] == DBNull.Value ? null : objRow[concc_CourseCase.FilePath].ToString().Trim(); //文件路径
objcc_CourseCaseEN.FileSize = objRow[concc_CourseCase.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseCase.FileSize].ToString().Trim()); //文件大小
objcc_CourseCaseEN.FileSizeUnit = objRow[concc_CourseCase.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseCaseEN.UploadDate = objRow[concc_CourseCase.UploadDate] == DBNull.Value ? null : objRow[concc_CourseCase.UploadDate].ToString().Trim(); //上传时间
objcc_CourseCaseEN.IsShow = TransNullToBool(objRow[concc_CourseCase.IsShow].ToString().Trim()); //是否启用
objcc_CourseCaseEN.CourseResourceName = objRow[concc_CourseCase.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseCaseEN.ResourcePicPath = objRow[concc_CourseCase.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseCaseEN.IsCast = TransNullToBool(objRow[concc_CourseCase.IsCast].ToString().Trim()); //是否播放
objcc_CourseCaseEN.IsDown = TransNullToBool(objRow[concc_CourseCase.IsDown].ToString().Trim()); //是否下载
objcc_CourseCaseEN.LikeCount = objRow[concc_CourseCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseCase.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseCaseEN.CourseId = objRow[concc_CourseCase.CourseId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseId].ToString().Trim(); //课程Id
objcc_CourseCaseEN.ResourceType = objRow[concc_CourseCase.ResourceType] == DBNull.Value ? null : objRow[concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_CourseCaseDA: GetObjLst)", objException.Message));
}
objcc_CourseCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_CourseCaseEN);
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
public List<clscc_CourseCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_CourseCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_CourseCaseEN> arrObjLst = new List<clscc_CourseCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseCaseEN objcc_CourseCaseEN = new clscc_CourseCaseEN();
try
{
objcc_CourseCaseEN.CourseCaseId = objRow[concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id
objcc_CourseCaseEN.CourseChapterId = objRow[concc_CourseCase.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseCaseEN.UserId = objRow[concc_CourseCase.UserId].ToString().Trim(); //用户ID
objcc_CourseCaseEN.FilePath = objRow[concc_CourseCase.FilePath] == DBNull.Value ? null : objRow[concc_CourseCase.FilePath].ToString().Trim(); //文件路径
objcc_CourseCaseEN.FileSize = objRow[concc_CourseCase.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseCase.FileSize].ToString().Trim()); //文件大小
objcc_CourseCaseEN.FileSizeUnit = objRow[concc_CourseCase.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseCaseEN.UploadDate = objRow[concc_CourseCase.UploadDate] == DBNull.Value ? null : objRow[concc_CourseCase.UploadDate].ToString().Trim(); //上传时间
objcc_CourseCaseEN.IsShow = TransNullToBool(objRow[concc_CourseCase.IsShow].ToString().Trim()); //是否启用
objcc_CourseCaseEN.CourseResourceName = objRow[concc_CourseCase.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseCaseEN.ResourcePicPath = objRow[concc_CourseCase.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseCaseEN.IsCast = TransNullToBool(objRow[concc_CourseCase.IsCast].ToString().Trim()); //是否播放
objcc_CourseCaseEN.IsDown = TransNullToBool(objRow[concc_CourseCase.IsDown].ToString().Trim()); //是否下载
objcc_CourseCaseEN.LikeCount = objRow[concc_CourseCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseCase.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseCaseEN.CourseId = objRow[concc_CourseCase.CourseId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseId].ToString().Trim(); //课程Id
objcc_CourseCaseEN.ResourceType = objRow[concc_CourseCase.ResourceType] == DBNull.Value ? null : objRow[concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_CourseCaseDA: GetObjLst)", objException.Message));
}
objcc_CourseCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_CourseCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_CourseCase(ref clscc_CourseCaseEN objcc_CourseCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseCase where CourseCaseId = " + "'"+ objcc_CourseCaseEN.CourseCaseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_CourseCaseEN.CourseCaseId = objDT.Rows[0][concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseCaseEN.CourseChapterId = objDT.Rows[0][concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseCaseEN.UserId = objDT.Rows[0][concc_CourseCase.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objcc_CourseCaseEN.FilePath = objDT.Rows[0][concc_CourseCase.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objcc_CourseCaseEN.FileSize = TransNullToDouble(objDT.Rows[0][concc_CourseCase.FileSize].ToString().Trim()); //文件大小(字段类型:decimal,字段长度:22,是否可空:True)
 objcc_CourseCaseEN.FileSizeUnit = objDT.Rows[0][concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_CourseCaseEN.UploadDate = objDT.Rows[0][concc_CourseCase.UploadDate].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:20,是否可空:False)
 objcc_CourseCaseEN.IsShow = TransNullToBool(objDT.Rows[0][concc_CourseCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseCaseEN.CourseResourceName = objDT.Rows[0][concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称(字段类型:varchar,字段长度:200,是否可空:False)
 objcc_CourseCaseEN.ResourcePicPath = objDT.Rows[0][concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置(字段类型:varchar,字段长度:500,是否可空:True)
 objcc_CourseCaseEN.IsCast = TransNullToBool(objDT.Rows[0][concc_CourseCase.IsCast].ToString().Trim()); //是否播放(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseCaseEN.IsDown = TransNullToBool(objDT.Rows[0][concc_CourseCase.IsDown].ToString().Trim()); //是否下载(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseCaseEN.LikeCount = TransNullToInt(objDT.Rows[0][concc_CourseCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_CourseCaseEN.CourseId = objDT.Rows[0][concc_CourseCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseCaseEN.ResourceType = objDT.Rows[0][concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_CourseCaseDA: Getcc_CourseCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseCaseId">表关键字</param>
 /// <returns>表对象</returns>
public clscc_CourseCaseEN GetObjByCourseCaseId(string strCourseCaseId)
{
CheckPrimaryKey(strCourseCaseId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseCase where CourseCaseId = " + "'"+ strCourseCaseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_CourseCaseEN objcc_CourseCaseEN = new clscc_CourseCaseEN();
try
{
 objcc_CourseCaseEN.CourseCaseId = objRow[concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseCaseEN.CourseChapterId = objRow[concc_CourseCase.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseCaseEN.UserId = objRow[concc_CourseCase.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objcc_CourseCaseEN.FilePath = objRow[concc_CourseCase.FilePath] == DBNull.Value ? null : objRow[concc_CourseCase.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objcc_CourseCaseEN.FileSize = objRow[concc_CourseCase.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseCase.FileSize].ToString().Trim()); //文件大小(字段类型:decimal,字段长度:22,是否可空:True)
 objcc_CourseCaseEN.FileSizeUnit = objRow[concc_CourseCase.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_CourseCaseEN.UploadDate = objRow[concc_CourseCase.UploadDate] == DBNull.Value ? null : objRow[concc_CourseCase.UploadDate].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:20,是否可空:False)
 objcc_CourseCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseCaseEN.CourseResourceName = objRow[concc_CourseCase.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称(字段类型:varchar,字段长度:200,是否可空:False)
 objcc_CourseCaseEN.ResourcePicPath = objRow[concc_CourseCase.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置(字段类型:varchar,字段长度:500,是否可空:True)
 objcc_CourseCaseEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsCast].ToString().Trim()); //是否播放(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseCaseEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsDown].ToString().Trim()); //是否下载(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseCaseEN.LikeCount = objRow[concc_CourseCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_CourseCaseEN.CourseId = objRow[concc_CourseCase.CourseId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseCaseEN.ResourceType = objRow[concc_CourseCase.ResourceType] == DBNull.Value ? null : objRow[concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_CourseCaseDA: GetObjByCourseCaseId)", objException.Message));
}
return objcc_CourseCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_CourseCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_CourseCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_CourseCaseEN objcc_CourseCaseEN = new clscc_CourseCaseEN()
{
CourseCaseId = objRow[concc_CourseCase.CourseCaseId].ToString().Trim(), //课程教案Id
CourseChapterId = objRow[concc_CourseCase.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseChapterId].ToString().Trim(), //课程章节ID
UserId = objRow[concc_CourseCase.UserId].ToString().Trim(), //用户ID
FilePath = objRow[concc_CourseCase.FilePath] == DBNull.Value ? null : objRow[concc_CourseCase.FilePath].ToString().Trim(), //文件路径
FileSize = objRow[concc_CourseCase.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseCase.FileSize].ToString().Trim()), //文件大小
FileSizeUnit = objRow[concc_CourseCase.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseCase.FileSizeUnit].ToString().Trim(), //文件大小单位
UploadDate = objRow[concc_CourseCase.UploadDate] == DBNull.Value ? null : objRow[concc_CourseCase.UploadDate].ToString().Trim(), //上传时间
IsShow = TransNullToBool(objRow[concc_CourseCase.IsShow].ToString().Trim()), //是否启用
CourseResourceName = objRow[concc_CourseCase.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseCase.CourseResourceName].ToString().Trim(), //教学视频名称
ResourcePicPath = objRow[concc_CourseCase.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseCase.ResourcePicPath].ToString().Trim(), //图片位置
IsCast = TransNullToBool(objRow[concc_CourseCase.IsCast].ToString().Trim()), //是否播放
IsDown = TransNullToBool(objRow[concc_CourseCase.IsDown].ToString().Trim()), //是否下载
LikeCount = objRow[concc_CourseCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseCase.LikeCount].ToString().Trim()), //资源喜欢数量
CourseId = objRow[concc_CourseCase.CourseId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseId].ToString().Trim(), //课程Id
ResourceType = objRow[concc_CourseCase.ResourceType] == DBNull.Value ? null : objRow[concc_CourseCase.ResourceType].ToString().Trim() //ResourceType
};
objcc_CourseCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_CourseCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_CourseCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_CourseCaseEN objcc_CourseCaseEN = new clscc_CourseCaseEN();
try
{
objcc_CourseCaseEN.CourseCaseId = objRow[concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id
objcc_CourseCaseEN.CourseChapterId = objRow[concc_CourseCase.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseCaseEN.UserId = objRow[concc_CourseCase.UserId].ToString().Trim(); //用户ID
objcc_CourseCaseEN.FilePath = objRow[concc_CourseCase.FilePath] == DBNull.Value ? null : objRow[concc_CourseCase.FilePath].ToString().Trim(); //文件路径
objcc_CourseCaseEN.FileSize = objRow[concc_CourseCase.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseCase.FileSize].ToString().Trim()); //文件大小
objcc_CourseCaseEN.FileSizeUnit = objRow[concc_CourseCase.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseCaseEN.UploadDate = objRow[concc_CourseCase.UploadDate] == DBNull.Value ? null : objRow[concc_CourseCase.UploadDate].ToString().Trim(); //上传时间
objcc_CourseCaseEN.IsShow = TransNullToBool(objRow[concc_CourseCase.IsShow].ToString().Trim()); //是否启用
objcc_CourseCaseEN.CourseResourceName = objRow[concc_CourseCase.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseCaseEN.ResourcePicPath = objRow[concc_CourseCase.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseCaseEN.IsCast = TransNullToBool(objRow[concc_CourseCase.IsCast].ToString().Trim()); //是否播放
objcc_CourseCaseEN.IsDown = TransNullToBool(objRow[concc_CourseCase.IsDown].ToString().Trim()); //是否下载
objcc_CourseCaseEN.LikeCount = objRow[concc_CourseCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseCase.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseCaseEN.CourseId = objRow[concc_CourseCase.CourseId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseId].ToString().Trim(); //课程Id
objcc_CourseCaseEN.ResourceType = objRow[concc_CourseCase.ResourceType] == DBNull.Value ? null : objRow[concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_CourseCaseDA: GetObjByDataRowcc_CourseCase)", objException.Message));
}
objcc_CourseCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_CourseCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_CourseCaseEN objcc_CourseCaseEN = new clscc_CourseCaseEN();
try
{
objcc_CourseCaseEN.CourseCaseId = objRow[concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id
objcc_CourseCaseEN.CourseChapterId = objRow[concc_CourseCase.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseCaseEN.UserId = objRow[concc_CourseCase.UserId].ToString().Trim(); //用户ID
objcc_CourseCaseEN.FilePath = objRow[concc_CourseCase.FilePath] == DBNull.Value ? null : objRow[concc_CourseCase.FilePath].ToString().Trim(); //文件路径
objcc_CourseCaseEN.FileSize = objRow[concc_CourseCase.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseCase.FileSize].ToString().Trim()); //文件大小
objcc_CourseCaseEN.FileSizeUnit = objRow[concc_CourseCase.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseCaseEN.UploadDate = objRow[concc_CourseCase.UploadDate] == DBNull.Value ? null : objRow[concc_CourseCase.UploadDate].ToString().Trim(); //上传时间
objcc_CourseCaseEN.IsShow = TransNullToBool(objRow[concc_CourseCase.IsShow].ToString().Trim()); //是否启用
objcc_CourseCaseEN.CourseResourceName = objRow[concc_CourseCase.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseCaseEN.ResourcePicPath = objRow[concc_CourseCase.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseCaseEN.IsCast = TransNullToBool(objRow[concc_CourseCase.IsCast].ToString().Trim()); //是否播放
objcc_CourseCaseEN.IsDown = TransNullToBool(objRow[concc_CourseCase.IsDown].ToString().Trim()); //是否下载
objcc_CourseCaseEN.LikeCount = objRow[concc_CourseCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseCase.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseCaseEN.CourseId = objRow[concc_CourseCase.CourseId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseId].ToString().Trim(); //课程Id
objcc_CourseCaseEN.ResourceType = objRow[concc_CourseCase.ResourceType] == DBNull.Value ? null : objRow[concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_CourseCaseDA: GetObjByDataRow)", objException.Message));
}
objcc_CourseCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseCaseEN;
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
objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_CourseCaseEN._CurrTabName, concc_CourseCase.CourseCaseId, 8, "");
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
objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_CourseCaseEN._CurrTabName, concc_CourseCase.CourseCaseId, 8, strPrefix);
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
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CourseCaseId from cc_CourseCase where " + strCondition;
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
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CourseCaseId from cc_CourseCase where " + strCondition;
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
 /// <param name = "strCourseCaseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCourseCaseId)
{
CheckPrimaryKey(strCourseCaseId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_CourseCase", "CourseCaseId = " + "'"+ strCourseCaseId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_CourseCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_CourseCase", strCondition))
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
objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_CourseCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_CourseCaseEN objcc_CourseCaseEN)
 {
 if (objcc_CourseCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseCaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseCase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_CourseCase");
objRow = objDS.Tables["cc_CourseCase"].NewRow();
objRow[concc_CourseCase.CourseCaseId] = objcc_CourseCaseEN.CourseCaseId; //课程教案Id
 if (objcc_CourseCaseEN.CourseChapterId !=  "")
 {
objRow[concc_CourseCase.CourseChapterId] = objcc_CourseCaseEN.CourseChapterId; //课程章节ID
 }
objRow[concc_CourseCase.UserId] = objcc_CourseCaseEN.UserId; //用户ID
 if (objcc_CourseCaseEN.FilePath !=  "")
 {
objRow[concc_CourseCase.FilePath] = objcc_CourseCaseEN.FilePath; //文件路径
 }
objRow[concc_CourseCase.FileSize] = objcc_CourseCaseEN.FileSize; //文件大小
 if (objcc_CourseCaseEN.FileSizeUnit !=  "")
 {
objRow[concc_CourseCase.FileSizeUnit] = objcc_CourseCaseEN.FileSizeUnit; //文件大小单位
 }
 if (objcc_CourseCaseEN.UploadDate !=  "")
 {
objRow[concc_CourseCase.UploadDate] = objcc_CourseCaseEN.UploadDate; //上传时间
 }
objRow[concc_CourseCase.IsShow] = objcc_CourseCaseEN.IsShow; //是否启用
 if (objcc_CourseCaseEN.CourseResourceName !=  "")
 {
objRow[concc_CourseCase.CourseResourceName] = objcc_CourseCaseEN.CourseResourceName; //教学视频名称
 }
 if (objcc_CourseCaseEN.ResourcePicPath !=  "")
 {
objRow[concc_CourseCase.ResourcePicPath] = objcc_CourseCaseEN.ResourcePicPath; //图片位置
 }
objRow[concc_CourseCase.IsCast] = objcc_CourseCaseEN.IsCast; //是否播放
objRow[concc_CourseCase.IsDown] = objcc_CourseCaseEN.IsDown; //是否下载
objRow[concc_CourseCase.LikeCount] = objcc_CourseCaseEN.LikeCount; //资源喜欢数量
 if (objcc_CourseCaseEN.CourseId !=  "")
 {
objRow[concc_CourseCase.CourseId] = objcc_CourseCaseEN.CourseId; //课程Id
 }
 if (objcc_CourseCaseEN.ResourceType !=  "")
 {
objRow[concc_CourseCase.ResourceType] = objcc_CourseCaseEN.ResourceType; //ResourceType
 }
objDS.Tables[clscc_CourseCaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_CourseCaseEN._CurrTabName);
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
 /// <param name = "objcc_CourseCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_CourseCaseEN objcc_CourseCaseEN)
{
 if (objcc_CourseCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseCaseEN.CourseCaseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.CourseCaseId);
 var strCourseCaseId = objcc_CourseCaseEN.CourseCaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseCaseId + "'");
 }
 
 if (objcc_CourseCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.CourseChapterId);
 var strCourseChapterId = objcc_CourseCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_CourseCaseEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.UserId);
 var strUserId = objcc_CourseCaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objcc_CourseCaseEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.FilePath);
 var strFilePath = objcc_CourseCaseEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objcc_CourseCaseEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.FileSize);
 arrValueListForInsert.Add(objcc_CourseCaseEN.FileSize.ToString());
 }
 
 if (objcc_CourseCaseEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.FileSizeUnit);
 var strFileSizeUnit = objcc_CourseCaseEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objcc_CourseCaseEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.UploadDate);
 var strUploadDate = objcc_CourseCaseEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseCase.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseCaseEN.CourseResourceName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.CourseResourceName);
 var strCourseResourceName = objcc_CourseCaseEN.CourseResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseResourceName + "'");
 }
 
 if (objcc_CourseCaseEN.ResourcePicPath !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.ResourcePicPath);
 var strResourcePicPath = objcc_CourseCaseEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourcePicPath + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseCase.IsCast);
 arrValueListForInsert.Add("'" + (objcc_CourseCaseEN.IsCast  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseCase.IsDown);
 arrValueListForInsert.Add("'" + (objcc_CourseCaseEN.IsDown  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.LikeCount);
 arrValueListForInsert.Add(objcc_CourseCaseEN.LikeCount.ToString());
 }
 
 if (objcc_CourseCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.CourseId);
 var strCourseId = objcc_CourseCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseCaseEN.ResourceType !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.ResourceType);
 var strResourceType = objcc_CourseCaseEN.ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceType + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_CourseCaseEN objcc_CourseCaseEN)
{
 if (objcc_CourseCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseCaseEN.CourseCaseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.CourseCaseId);
 var strCourseCaseId = objcc_CourseCaseEN.CourseCaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseCaseId + "'");
 }
 
 if (objcc_CourseCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.CourseChapterId);
 var strCourseChapterId = objcc_CourseCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_CourseCaseEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.UserId);
 var strUserId = objcc_CourseCaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objcc_CourseCaseEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.FilePath);
 var strFilePath = objcc_CourseCaseEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objcc_CourseCaseEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.FileSize);
 arrValueListForInsert.Add(objcc_CourseCaseEN.FileSize.ToString());
 }
 
 if (objcc_CourseCaseEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.FileSizeUnit);
 var strFileSizeUnit = objcc_CourseCaseEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objcc_CourseCaseEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.UploadDate);
 var strUploadDate = objcc_CourseCaseEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseCase.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseCaseEN.CourseResourceName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.CourseResourceName);
 var strCourseResourceName = objcc_CourseCaseEN.CourseResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseResourceName + "'");
 }
 
 if (objcc_CourseCaseEN.ResourcePicPath !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.ResourcePicPath);
 var strResourcePicPath = objcc_CourseCaseEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourcePicPath + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseCase.IsCast);
 arrValueListForInsert.Add("'" + (objcc_CourseCaseEN.IsCast  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseCase.IsDown);
 arrValueListForInsert.Add("'" + (objcc_CourseCaseEN.IsDown  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.LikeCount);
 arrValueListForInsert.Add(objcc_CourseCaseEN.LikeCount.ToString());
 }
 
 if (objcc_CourseCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.CourseId);
 var strCourseId = objcc_CourseCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseCaseEN.ResourceType !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.ResourceType);
 var strResourceType = objcc_CourseCaseEN.ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceType + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objcc_CourseCaseEN.CourseCaseId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_CourseCaseEN objcc_CourseCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_CourseCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseCaseEN.CourseCaseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.CourseCaseId);
 var strCourseCaseId = objcc_CourseCaseEN.CourseCaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseCaseId + "'");
 }
 
 if (objcc_CourseCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.CourseChapterId);
 var strCourseChapterId = objcc_CourseCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_CourseCaseEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.UserId);
 var strUserId = objcc_CourseCaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objcc_CourseCaseEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.FilePath);
 var strFilePath = objcc_CourseCaseEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objcc_CourseCaseEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.FileSize);
 arrValueListForInsert.Add(objcc_CourseCaseEN.FileSize.ToString());
 }
 
 if (objcc_CourseCaseEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.FileSizeUnit);
 var strFileSizeUnit = objcc_CourseCaseEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objcc_CourseCaseEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.UploadDate);
 var strUploadDate = objcc_CourseCaseEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseCase.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseCaseEN.CourseResourceName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.CourseResourceName);
 var strCourseResourceName = objcc_CourseCaseEN.CourseResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseResourceName + "'");
 }
 
 if (objcc_CourseCaseEN.ResourcePicPath !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.ResourcePicPath);
 var strResourcePicPath = objcc_CourseCaseEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourcePicPath + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseCase.IsCast);
 arrValueListForInsert.Add("'" + (objcc_CourseCaseEN.IsCast  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseCase.IsDown);
 arrValueListForInsert.Add("'" + (objcc_CourseCaseEN.IsDown  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.LikeCount);
 arrValueListForInsert.Add(objcc_CourseCaseEN.LikeCount.ToString());
 }
 
 if (objcc_CourseCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.CourseId);
 var strCourseId = objcc_CourseCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseCaseEN.ResourceType !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.ResourceType);
 var strResourceType = objcc_CourseCaseEN.ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceType + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objcc_CourseCaseEN.CourseCaseId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_CourseCaseEN objcc_CourseCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objcc_CourseCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseCaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseCaseEN.CourseCaseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.CourseCaseId);
 var strCourseCaseId = objcc_CourseCaseEN.CourseCaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseCaseId + "'");
 }
 
 if (objcc_CourseCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.CourseChapterId);
 var strCourseChapterId = objcc_CourseCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_CourseCaseEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.UserId);
 var strUserId = objcc_CourseCaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objcc_CourseCaseEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.FilePath);
 var strFilePath = objcc_CourseCaseEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objcc_CourseCaseEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.FileSize);
 arrValueListForInsert.Add(objcc_CourseCaseEN.FileSize.ToString());
 }
 
 if (objcc_CourseCaseEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.FileSizeUnit);
 var strFileSizeUnit = objcc_CourseCaseEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objcc_CourseCaseEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.UploadDate);
 var strUploadDate = objcc_CourseCaseEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseCase.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseCaseEN.CourseResourceName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.CourseResourceName);
 var strCourseResourceName = objcc_CourseCaseEN.CourseResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseResourceName + "'");
 }
 
 if (objcc_CourseCaseEN.ResourcePicPath !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.ResourcePicPath);
 var strResourcePicPath = objcc_CourseCaseEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourcePicPath + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseCase.IsCast);
 arrValueListForInsert.Add("'" + (objcc_CourseCaseEN.IsCast  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseCase.IsDown);
 arrValueListForInsert.Add("'" + (objcc_CourseCaseEN.IsDown  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.LikeCount);
 arrValueListForInsert.Add(objcc_CourseCaseEN.LikeCount.ToString());
 }
 
 if (objcc_CourseCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.CourseId);
 var strCourseId = objcc_CourseCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseCaseEN.ResourceType !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseCase.ResourceType);
 var strResourceType = objcc_CourseCaseEN.ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceType + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_CourseCases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseCase where CourseCaseId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_CourseCase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCourseCaseId = oRow[concc_CourseCase.CourseCaseId].ToString().Trim();
if (IsExist(strCourseCaseId))
{
 string strResult = "关键字变量值为:" + string.Format("CourseCaseId = {0}", strCourseCaseId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_CourseCaseEN._CurrTabName ].NewRow();
objRow[concc_CourseCase.CourseCaseId] = oRow[concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id
objRow[concc_CourseCase.CourseChapterId] = oRow[concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID
objRow[concc_CourseCase.UserId] = oRow[concc_CourseCase.UserId].ToString().Trim(); //用户ID
objRow[concc_CourseCase.FilePath] = oRow[concc_CourseCase.FilePath].ToString().Trim(); //文件路径
objRow[concc_CourseCase.FileSize] = oRow[concc_CourseCase.FileSize].ToString().Trim(); //文件大小
objRow[concc_CourseCase.FileSizeUnit] = oRow[concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位
objRow[concc_CourseCase.UploadDate] = oRow[concc_CourseCase.UploadDate].ToString().Trim(); //上传时间
objRow[concc_CourseCase.IsShow] = oRow[concc_CourseCase.IsShow].ToString().Trim(); //是否启用
objRow[concc_CourseCase.CourseResourceName] = oRow[concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称
objRow[concc_CourseCase.ResourcePicPath] = oRow[concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置
objRow[concc_CourseCase.IsCast] = oRow[concc_CourseCase.IsCast].ToString().Trim(); //是否播放
objRow[concc_CourseCase.IsDown] = oRow[concc_CourseCase.IsDown].ToString().Trim(); //是否下载
objRow[concc_CourseCase.LikeCount] = oRow[concc_CourseCase.LikeCount].ToString().Trim(); //资源喜欢数量
objRow[concc_CourseCase.CourseId] = oRow[concc_CourseCase.CourseId].ToString().Trim(); //课程Id
objRow[concc_CourseCase.ResourceType] = oRow[concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType
 objDS.Tables[clscc_CourseCaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_CourseCaseEN._CurrTabName);
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
 /// <param name = "objcc_CourseCaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_CourseCaseEN objcc_CourseCaseEN)
{
 if (objcc_CourseCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseCaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseCase where CourseCaseId = " + "'"+ objcc_CourseCaseEN.CourseCaseId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_CourseCaseEN._CurrTabName);
if (objDS.Tables[clscc_CourseCaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CourseCaseId = " + "'"+ objcc_CourseCaseEN.CourseCaseId+"'");
return false;
}
objRow = objDS.Tables[clscc_CourseCaseEN._CurrTabName].Rows[0];
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.CourseCaseId))
 {
objRow[concc_CourseCase.CourseCaseId] = objcc_CourseCaseEN.CourseCaseId; //课程教案Id
 }
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.CourseChapterId))
 {
objRow[concc_CourseCase.CourseChapterId] = objcc_CourseCaseEN.CourseChapterId; //课程章节ID
 }
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.UserId))
 {
objRow[concc_CourseCase.UserId] = objcc_CourseCaseEN.UserId; //用户ID
 }
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.FilePath))
 {
objRow[concc_CourseCase.FilePath] = objcc_CourseCaseEN.FilePath; //文件路径
 }
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.FileSize))
 {
objRow[concc_CourseCase.FileSize] = objcc_CourseCaseEN.FileSize; //文件大小
 }
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.FileSizeUnit))
 {
objRow[concc_CourseCase.FileSizeUnit] = objcc_CourseCaseEN.FileSizeUnit; //文件大小单位
 }
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.UploadDate))
 {
objRow[concc_CourseCase.UploadDate] = objcc_CourseCaseEN.UploadDate; //上传时间
 }
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.IsShow))
 {
objRow[concc_CourseCase.IsShow] = objcc_CourseCaseEN.IsShow; //是否启用
 }
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.CourseResourceName))
 {
objRow[concc_CourseCase.CourseResourceName] = objcc_CourseCaseEN.CourseResourceName; //教学视频名称
 }
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.ResourcePicPath))
 {
objRow[concc_CourseCase.ResourcePicPath] = objcc_CourseCaseEN.ResourcePicPath; //图片位置
 }
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.IsCast))
 {
objRow[concc_CourseCase.IsCast] = objcc_CourseCaseEN.IsCast; //是否播放
 }
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.IsDown))
 {
objRow[concc_CourseCase.IsDown] = objcc_CourseCaseEN.IsDown; //是否下载
 }
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.LikeCount))
 {
objRow[concc_CourseCase.LikeCount] = objcc_CourseCaseEN.LikeCount; //资源喜欢数量
 }
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.CourseId))
 {
objRow[concc_CourseCase.CourseId] = objcc_CourseCaseEN.CourseId; //课程Id
 }
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.ResourceType))
 {
objRow[concc_CourseCase.ResourceType] = objcc_CourseCaseEN.ResourceType; //ResourceType
 }
try
{
objDA.Update(objDS, clscc_CourseCaseEN._CurrTabName);
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
 /// <param name = "objcc_CourseCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_CourseCaseEN objcc_CourseCaseEN)
{
 if (objcc_CourseCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_CourseCase Set ");
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.CourseChapterId))
 {
 if (objcc_CourseCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_CourseCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, concc_CourseCase.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.CourseChapterId); //课程章节ID
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.UserId))
 {
 if (objcc_CourseCaseEN.UserId !=  null)
 {
 var strUserId = objcc_CourseCaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, concc_CourseCase.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.UserId); //用户ID
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.FilePath))
 {
 if (objcc_CourseCaseEN.FilePath !=  null)
 {
 var strFilePath = objcc_CourseCaseEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, concc_CourseCase.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.FilePath); //文件路径
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.FileSize))
 {
 if (objcc_CourseCaseEN.FileSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseCaseEN.FileSize, concc_CourseCase.FileSize); //文件大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.FileSize); //文件大小
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.FileSizeUnit))
 {
 if (objcc_CourseCaseEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objcc_CourseCaseEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileSizeUnit, concc_CourseCase.FileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.FileSizeUnit); //文件大小单位
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.UploadDate))
 {
 if (objcc_CourseCaseEN.UploadDate !=  null)
 {
 var strUploadDate = objcc_CourseCaseEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadDate, concc_CourseCase.UploadDate); //上传时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.UploadDate); //上传时间
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseCaseEN.IsShow == true?"1":"0", concc_CourseCase.IsShow); //是否启用
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.CourseResourceName))
 {
 if (objcc_CourseCaseEN.CourseResourceName !=  null)
 {
 var strCourseResourceName = objcc_CourseCaseEN.CourseResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseResourceName, concc_CourseCase.CourseResourceName); //教学视频名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.CourseResourceName); //教学视频名称
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.ResourcePicPath))
 {
 if (objcc_CourseCaseEN.ResourcePicPath !=  null)
 {
 var strResourcePicPath = objcc_CourseCaseEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourcePicPath, concc_CourseCase.ResourcePicPath); //图片位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.ResourcePicPath); //图片位置
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.IsCast))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseCaseEN.IsCast == true?"1":"0", concc_CourseCase.IsCast); //是否播放
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.IsDown))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseCaseEN.IsDown == true?"1":"0", concc_CourseCase.IsDown); //是否下载
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.LikeCount))
 {
 if (objcc_CourseCaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseCaseEN.LikeCount, concc_CourseCase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.CourseId))
 {
 if (objcc_CourseCaseEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_CourseCase.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.CourseId); //课程Id
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.ResourceType))
 {
 if (objcc_CourseCaseEN.ResourceType !=  null)
 {
 var strResourceType = objcc_CourseCaseEN.ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceType, concc_CourseCase.ResourceType); //ResourceType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.ResourceType); //ResourceType
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CourseCaseId = '{0}'", objcc_CourseCaseEN.CourseCaseId); 
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
 /// <param name = "objcc_CourseCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_CourseCaseEN objcc_CourseCaseEN, string strCondition)
{
 if (objcc_CourseCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseCase Set ");
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.CourseChapterId))
 {
 if (objcc_CourseCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_CourseCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.UserId))
 {
 if (objcc_CourseCaseEN.UserId !=  null)
 {
 var strUserId = objcc_CourseCaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.FilePath))
 {
 if (objcc_CourseCaseEN.FilePath !=  null)
 {
 var strFilePath = objcc_CourseCaseEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.FileSize))
 {
 sbSQL.AppendFormat(" FileSize = {0},", objcc_CourseCaseEN.FileSize); //文件大小
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.FileSizeUnit))
 {
 if (objcc_CourseCaseEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objcc_CourseCaseEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileSizeUnit = '{0}',", strFileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.Append(" FileSizeUnit = null,"); //文件大小单位
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.UploadDate))
 {
 if (objcc_CourseCaseEN.UploadDate !=  null)
 {
 var strUploadDate = objcc_CourseCaseEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadDate = '{0}',", strUploadDate); //上传时间
 }
 else
 {
 sbSQL.Append(" UploadDate = null,"); //上传时间
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objcc_CourseCaseEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.CourseResourceName))
 {
 if (objcc_CourseCaseEN.CourseResourceName !=  null)
 {
 var strCourseResourceName = objcc_CourseCaseEN.CourseResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseResourceName = '{0}',", strCourseResourceName); //教学视频名称
 }
 else
 {
 sbSQL.Append(" CourseResourceName = null,"); //教学视频名称
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.ResourcePicPath))
 {
 if (objcc_CourseCaseEN.ResourcePicPath !=  null)
 {
 var strResourcePicPath = objcc_CourseCaseEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourcePicPath = '{0}',", strResourcePicPath); //图片位置
 }
 else
 {
 sbSQL.Append(" ResourcePicPath = null,"); //图片位置
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.IsCast))
 {
 sbSQL.AppendFormat(" IsCast = '{0}',", objcc_CourseCaseEN.IsCast == true?"1":"0"); //是否播放
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.IsDown))
 {
 sbSQL.AppendFormat(" IsDown = '{0}',", objcc_CourseCaseEN.IsDown == true?"1":"0"); //是否下载
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.LikeCount))
 {
 sbSQL.AppendFormat(" LikeCount = {0},", objcc_CourseCaseEN.LikeCount); //资源喜欢数量
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.CourseId))
 {
 if (objcc_CourseCaseEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.ResourceType))
 {
 if (objcc_CourseCaseEN.ResourceType !=  null)
 {
 var strResourceType = objcc_CourseCaseEN.ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_CourseCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_CourseCaseEN objcc_CourseCaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_CourseCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseCase Set ");
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.CourseChapterId))
 {
 if (objcc_CourseCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_CourseCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.UserId))
 {
 if (objcc_CourseCaseEN.UserId !=  null)
 {
 var strUserId = objcc_CourseCaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.FilePath))
 {
 if (objcc_CourseCaseEN.FilePath !=  null)
 {
 var strFilePath = objcc_CourseCaseEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.FileSize))
 {
 sbSQL.AppendFormat(" FileSize = {0},", objcc_CourseCaseEN.FileSize); //文件大小
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.FileSizeUnit))
 {
 if (objcc_CourseCaseEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objcc_CourseCaseEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileSizeUnit = '{0}',", strFileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.Append(" FileSizeUnit = null,"); //文件大小单位
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.UploadDate))
 {
 if (objcc_CourseCaseEN.UploadDate !=  null)
 {
 var strUploadDate = objcc_CourseCaseEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadDate = '{0}',", strUploadDate); //上传时间
 }
 else
 {
 sbSQL.Append(" UploadDate = null,"); //上传时间
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objcc_CourseCaseEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.CourseResourceName))
 {
 if (objcc_CourseCaseEN.CourseResourceName !=  null)
 {
 var strCourseResourceName = objcc_CourseCaseEN.CourseResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseResourceName = '{0}',", strCourseResourceName); //教学视频名称
 }
 else
 {
 sbSQL.Append(" CourseResourceName = null,"); //教学视频名称
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.ResourcePicPath))
 {
 if (objcc_CourseCaseEN.ResourcePicPath !=  null)
 {
 var strResourcePicPath = objcc_CourseCaseEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourcePicPath = '{0}',", strResourcePicPath); //图片位置
 }
 else
 {
 sbSQL.Append(" ResourcePicPath = null,"); //图片位置
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.IsCast))
 {
 sbSQL.AppendFormat(" IsCast = '{0}',", objcc_CourseCaseEN.IsCast == true?"1":"0"); //是否播放
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.IsDown))
 {
 sbSQL.AppendFormat(" IsDown = '{0}',", objcc_CourseCaseEN.IsDown == true?"1":"0"); //是否下载
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.LikeCount))
 {
 sbSQL.AppendFormat(" LikeCount = {0},", objcc_CourseCaseEN.LikeCount); //资源喜欢数量
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.CourseId))
 {
 if (objcc_CourseCaseEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.ResourceType))
 {
 if (objcc_CourseCaseEN.ResourceType !=  null)
 {
 var strResourceType = objcc_CourseCaseEN.ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_CourseCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_CourseCaseEN objcc_CourseCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objcc_CourseCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseCase Set ");
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.CourseChapterId))
 {
 if (objcc_CourseCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_CourseCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, concc_CourseCase.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.CourseChapterId); //课程章节ID
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.UserId))
 {
 if (objcc_CourseCaseEN.UserId !=  null)
 {
 var strUserId = objcc_CourseCaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, concc_CourseCase.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.UserId); //用户ID
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.FilePath))
 {
 if (objcc_CourseCaseEN.FilePath !=  null)
 {
 var strFilePath = objcc_CourseCaseEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, concc_CourseCase.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.FilePath); //文件路径
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.FileSize))
 {
 if (objcc_CourseCaseEN.FileSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseCaseEN.FileSize, concc_CourseCase.FileSize); //文件大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.FileSize); //文件大小
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.FileSizeUnit))
 {
 if (objcc_CourseCaseEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objcc_CourseCaseEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileSizeUnit, concc_CourseCase.FileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.FileSizeUnit); //文件大小单位
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.UploadDate))
 {
 if (objcc_CourseCaseEN.UploadDate !=  null)
 {
 var strUploadDate = objcc_CourseCaseEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadDate, concc_CourseCase.UploadDate); //上传时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.UploadDate); //上传时间
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseCaseEN.IsShow == true?"1":"0", concc_CourseCase.IsShow); //是否启用
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.CourseResourceName))
 {
 if (objcc_CourseCaseEN.CourseResourceName !=  null)
 {
 var strCourseResourceName = objcc_CourseCaseEN.CourseResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseResourceName, concc_CourseCase.CourseResourceName); //教学视频名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.CourseResourceName); //教学视频名称
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.ResourcePicPath))
 {
 if (objcc_CourseCaseEN.ResourcePicPath !=  null)
 {
 var strResourcePicPath = objcc_CourseCaseEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourcePicPath, concc_CourseCase.ResourcePicPath); //图片位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.ResourcePicPath); //图片位置
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.IsCast))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseCaseEN.IsCast == true?"1":"0", concc_CourseCase.IsCast); //是否播放
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.IsDown))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseCaseEN.IsDown == true?"1":"0", concc_CourseCase.IsDown); //是否下载
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.LikeCount))
 {
 if (objcc_CourseCaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseCaseEN.LikeCount, concc_CourseCase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.CourseId))
 {
 if (objcc_CourseCaseEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_CourseCase.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.CourseId); //课程Id
 }
 }
 
 if (objcc_CourseCaseEN.IsUpdated(concc_CourseCase.ResourceType))
 {
 if (objcc_CourseCaseEN.ResourceType !=  null)
 {
 var strResourceType = objcc_CourseCaseEN.ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceType, concc_CourseCase.ResourceType); //ResourceType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseCase.ResourceType); //ResourceType
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CourseCaseId = '{0}'", objcc_CourseCaseEN.CourseCaseId); 
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
 /// <param name = "strCourseCaseId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCourseCaseId) 
{
CheckPrimaryKey(strCourseCaseId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCourseCaseId,
};
 objSQL.ExecSP("cc_CourseCase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCourseCaseId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCourseCaseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCourseCaseId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
//删除cc_CourseCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseCase where CourseCaseId = " + "'"+ strCourseCaseId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_CourseCase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
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
//删除cc_CourseCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseCase where CourseCaseId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCourseCaseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCourseCaseId) 
{
CheckPrimaryKey(strCourseCaseId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
//删除cc_CourseCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseCase where CourseCaseId = " + "'"+ strCourseCaseId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_CourseCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_CourseCaseDA: Delcc_CourseCase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_CourseCase where " + strCondition ;
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
public bool Delcc_CourseCaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_CourseCaseDA: Delcc_CourseCaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_CourseCase where " + strCondition ;
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
 /// <param name = "objcc_CourseCaseENS">源对象</param>
 /// <param name = "objcc_CourseCaseENT">目标对象</param>
public void CopyTo(clscc_CourseCaseEN objcc_CourseCaseENS, clscc_CourseCaseEN objcc_CourseCaseENT)
{
objcc_CourseCaseENT.CourseCaseId = objcc_CourseCaseENS.CourseCaseId; //课程教案Id
objcc_CourseCaseENT.CourseChapterId = objcc_CourseCaseENS.CourseChapterId; //课程章节ID
objcc_CourseCaseENT.UserId = objcc_CourseCaseENS.UserId; //用户ID
objcc_CourseCaseENT.FilePath = objcc_CourseCaseENS.FilePath; //文件路径
objcc_CourseCaseENT.FileSize = objcc_CourseCaseENS.FileSize; //文件大小
objcc_CourseCaseENT.FileSizeUnit = objcc_CourseCaseENS.FileSizeUnit; //文件大小单位
objcc_CourseCaseENT.UploadDate = objcc_CourseCaseENS.UploadDate; //上传时间
objcc_CourseCaseENT.IsShow = objcc_CourseCaseENS.IsShow; //是否启用
objcc_CourseCaseENT.CourseResourceName = objcc_CourseCaseENS.CourseResourceName; //教学视频名称
objcc_CourseCaseENT.ResourcePicPath = objcc_CourseCaseENS.ResourcePicPath; //图片位置
objcc_CourseCaseENT.IsCast = objcc_CourseCaseENS.IsCast; //是否播放
objcc_CourseCaseENT.IsDown = objcc_CourseCaseENS.IsDown; //是否下载
objcc_CourseCaseENT.LikeCount = objcc_CourseCaseENS.LikeCount; //资源喜欢数量
objcc_CourseCaseENT.CourseId = objcc_CourseCaseENS.CourseId; //课程Id
objcc_CourseCaseENT.ResourceType = objcc_CourseCaseENS.ResourceType; //ResourceType
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_CourseCaseEN objcc_CourseCaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_CourseCaseEN.UserId, concc_CourseCase.UserId);
clsCheckSql.CheckFieldNotNull(objcc_CourseCaseEN.IsShow, concc_CourseCase.IsShow);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.CourseCaseId, 8, concc_CourseCase.CourseCaseId);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.CourseChapterId, 8, concc_CourseCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.UserId, 18, concc_CourseCase.UserId);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.FilePath, 500, concc_CourseCase.FilePath);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.FileSizeUnit, 10, concc_CourseCase.FileSizeUnit);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.UploadDate, 20, concc_CourseCase.UploadDate);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.CourseResourceName, 200, concc_CourseCase.CourseResourceName);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.ResourcePicPath, 500, concc_CourseCase.ResourcePicPath);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.CourseId, 8, concc_CourseCase.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.ResourceType, 50, concc_CourseCase.ResourceType);
//检查字段外键固定长度
 objcc_CourseCaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_CourseCaseEN objcc_CourseCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.CourseChapterId, 8, concc_CourseCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.UserId, 18, concc_CourseCase.UserId);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.FilePath, 500, concc_CourseCase.FilePath);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.FileSizeUnit, 10, concc_CourseCase.FileSizeUnit);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.UploadDate, 20, concc_CourseCase.UploadDate);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.CourseResourceName, 200, concc_CourseCase.CourseResourceName);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.ResourcePicPath, 500, concc_CourseCase.ResourcePicPath);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.CourseId, 8, concc_CourseCase.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.ResourceType, 50, concc_CourseCase.ResourceType);
//检查外键字段长度
 objcc_CourseCaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_CourseCaseEN objcc_CourseCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.CourseCaseId, 8, concc_CourseCase.CourseCaseId);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.CourseChapterId, 8, concc_CourseCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.UserId, 18, concc_CourseCase.UserId);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.FilePath, 500, concc_CourseCase.FilePath);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.FileSizeUnit, 10, concc_CourseCase.FileSizeUnit);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.UploadDate, 20, concc_CourseCase.UploadDate);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.CourseResourceName, 200, concc_CourseCase.CourseResourceName);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.ResourcePicPath, 500, concc_CourseCase.ResourcePicPath);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.CourseId, 8, concc_CourseCase.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseCaseEN.ResourceType, 50, concc_CourseCase.ResourceType);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_CourseCaseEN.CourseCaseId, concc_CourseCase.CourseCaseId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseCaseEN.CourseChapterId, concc_CourseCase.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseCaseEN.UserId, concc_CourseCase.UserId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseCaseEN.FilePath, concc_CourseCase.FilePath);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseCaseEN.FileSizeUnit, concc_CourseCase.FileSizeUnit);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseCaseEN.UploadDate, concc_CourseCase.UploadDate);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseCaseEN.CourseResourceName, concc_CourseCase.CourseResourceName);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseCaseEN.ResourcePicPath, concc_CourseCase.ResourcePicPath);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseCaseEN.CourseId, concc_CourseCase.CourseId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseCaseEN.ResourceType, concc_CourseCase.ResourceType);
//检查外键字段长度
 objcc_CourseCaseEN._IsCheckProperty = true;
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
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_CourseCaseEN._CurrTabName);
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
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_CourseCaseEN._CurrTabName, strCondition);
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
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}