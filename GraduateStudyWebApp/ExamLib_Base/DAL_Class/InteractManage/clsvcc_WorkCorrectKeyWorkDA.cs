
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkCorrectKeyWorkDA
 表名:vcc_WorkCorrectKeyWork(01120192)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// v作业批改关键词(vcc_WorkCorrectKeyWork)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_WorkCorrectKeyWorkDA : clsCommBase4DA
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
 return clsvcc_WorkCorrectKeyWorkEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcc_WorkCorrectKeyWorkEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_WorkCorrectKeyWorkEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcc_WorkCorrectKeyWorkEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_WorkCorrectKeyWorkEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkCorrectKeyWork where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_WorkCorrectKeyWork(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: GetDataTable_vcc_WorkCorrectKeyWork)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkCorrectKeyWork where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkCorrectKeyWork where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkCorrectKeyWork where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkCorrectKeyWork where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_WorkCorrectKeyWork where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_WorkCorrectKeyWork.* from vcc_WorkCorrectKeyWork Left Join {1} on {2} where {3} and vcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork not in (Select top {5} vcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork from vcc_WorkCorrectKeyWork Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkCorrectKeyWork where {1} and IdWorkCorrectKeyWork not in (Select top {2} IdWorkCorrectKeyWork from vcc_WorkCorrectKeyWork where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkCorrectKeyWork where {1} and IdWorkCorrectKeyWork not in (Select top {3} IdWorkCorrectKeyWork from vcc_WorkCorrectKeyWork where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_WorkCorrectKeyWork.* from vcc_WorkCorrectKeyWork Left Join {1} on {2} where {3} and vcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork not in (Select top {5} vcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork from vcc_WorkCorrectKeyWork Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkCorrectKeyWork where {1} and IdWorkCorrectKeyWork not in (Select top {2} IdWorkCorrectKeyWork from vcc_WorkCorrectKeyWork where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkCorrectKeyWork where {1} and IdWorkCorrectKeyWork not in (Select top {3} IdWorkCorrectKeyWork from vcc_WorkCorrectKeyWork where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcc_WorkCorrectKeyWorkEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_WorkCorrectKeyWorkDA:GetObjLst)", objException.Message));
}
List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = new List<clsvcc_WorkCorrectKeyWorkEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkCorrectKeyWork where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = new clsvcc_WorkCorrectKeyWorkEN();
try
{
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = TransNullToInt(objRow[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objvcc_WorkCorrectKeyWorkEN.QuestionID = objRow[convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkCorrectKeyWorkEN.WorkIndex = objRow[convcc_WorkCorrectKeyWork.WorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkCorrectKeyWorkEN.WorkName = objRow[convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(); //作业名称
objvcc_WorkCorrectKeyWorkEN.WorkDesc = objRow[convcc_WorkCorrectKeyWork.WorkDesc] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkCorrectKeyWorkEN.CourseId = objRow[convcc_WorkCorrectKeyWork.CourseId] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(); //课程Id
objvcc_WorkCorrectKeyWorkEN.CourseName = objRow[convcc_WorkCorrectKeyWork.CourseName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(); //课程名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objRow[convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objRow[convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objRow[convcc_WorkCorrectKeyWork.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objRow[convcc_WorkCorrectKeyWork.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = TransNullToBool(objRow[convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objvcc_WorkCorrectKeyWorkEN.FormatPara = objRow[convcc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objRow[convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(); //InOut类型类型
objvcc_WorkCorrectKeyWorkEN.Creator = objRow[convcc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objvcc_WorkCorrectKeyWorkEN.CreateDate = objRow[convcc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkCorrectKeyWorkEN.IsEnable = TransNullToBool(objRow[convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objvcc_WorkCorrectKeyWorkEN.UpdDate = objRow[convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkCorrectKeyWorkEN.UpdUser = objRow[convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objvcc_WorkCorrectKeyWorkEN.Memo = objRow[convcc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
objvcc_WorkCorrectKeyWorkEN.IdWork = objRow[convcc_WorkCorrectKeyWork.IdWork] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.IdWork].ToString().Trim(); //作业流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: GetObjLst)", objException.Message));
}
objvcc_WorkCorrectKeyWorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_WorkCorrectKeyWorkEN);
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
public List<clsvcc_WorkCorrectKeyWorkEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_WorkCorrectKeyWorkDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_WorkCorrectKeyWorkEN> arrObjLst = new List<clsvcc_WorkCorrectKeyWorkEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = new clsvcc_WorkCorrectKeyWorkEN();
try
{
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = TransNullToInt(objRow[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objvcc_WorkCorrectKeyWorkEN.QuestionID = objRow[convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkCorrectKeyWorkEN.WorkIndex = objRow[convcc_WorkCorrectKeyWork.WorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkCorrectKeyWorkEN.WorkName = objRow[convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(); //作业名称
objvcc_WorkCorrectKeyWorkEN.WorkDesc = objRow[convcc_WorkCorrectKeyWork.WorkDesc] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkCorrectKeyWorkEN.CourseId = objRow[convcc_WorkCorrectKeyWork.CourseId] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(); //课程Id
objvcc_WorkCorrectKeyWorkEN.CourseName = objRow[convcc_WorkCorrectKeyWork.CourseName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(); //课程名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objRow[convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objRow[convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objRow[convcc_WorkCorrectKeyWork.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objRow[convcc_WorkCorrectKeyWork.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = TransNullToBool(objRow[convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objvcc_WorkCorrectKeyWorkEN.FormatPara = objRow[convcc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objRow[convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(); //InOut类型类型
objvcc_WorkCorrectKeyWorkEN.Creator = objRow[convcc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objvcc_WorkCorrectKeyWorkEN.CreateDate = objRow[convcc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkCorrectKeyWorkEN.IsEnable = TransNullToBool(objRow[convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objvcc_WorkCorrectKeyWorkEN.UpdDate = objRow[convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkCorrectKeyWorkEN.UpdUser = objRow[convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objvcc_WorkCorrectKeyWorkEN.Memo = objRow[convcc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
objvcc_WorkCorrectKeyWorkEN.IdWork = objRow[convcc_WorkCorrectKeyWork.IdWork] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.IdWork].ToString().Trim(); //作业流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: GetObjLst)", objException.Message));
}
objvcc_WorkCorrectKeyWorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_WorkCorrectKeyWorkEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_WorkCorrectKeyWork(ref clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkCorrectKeyWork where IdWorkCorrectKeyWork = " + ""+ objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = TransNullToInt(objDT.Rows[0][convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_WorkCorrectKeyWorkEN.QuestionID = objDT.Rows[0][convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.WorkIndex = TransNullToInt(objDT.Rows[0][convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()); //作业序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.WorkName = objDT.Rows[0][convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(); //作业名称(字段类型:varchar,字段长度:5000,是否可空:False)
 objvcc_WorkCorrectKeyWorkEN.WorkDesc = objDT.Rows[0][convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(); //作业说明(字段类型:text,字段长度:2147483647,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.CourseId = objDT.Rows[0][convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.CourseName = objDT.Rows[0][convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objDT.Rows[0][convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objDT.Rows[0][convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objDT.Rows[0][convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objDT.Rows[0][convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objDT.Rows[0][convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objDT.Rows[0][convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = TransNullToInt(objDT.Rows[0][convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objDT.Rows[0][convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词(字段类型:varchar,字段长度:200,是否可空:False)
 objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = TransNullToBool(objDT.Rows[0][convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.FormatPara = objDT.Rows[0][convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objDT.Rows[0][convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objDT.Rows[0][convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(); //InOut类型类型(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_WorkCorrectKeyWorkEN.Creator = objDT.Rows[0][convcc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者(字段类型:varchar,字段长度:18,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.CreateDate = objDT.Rows[0][convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.IsEnable = TransNullToBool(objDT.Rows[0][convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:False)
 objvcc_WorkCorrectKeyWorkEN.UpdDate = objDT.Rows[0][convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.UpdUser = objDT.Rows[0][convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.Memo = objDT.Rows[0][convcc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.IdWork = objDT.Rows[0][convcc_WorkCorrectKeyWork.IdWork].ToString().Trim(); //作业流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: Getvcc_WorkCorrectKeyWork)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdWorkCorrectKeyWork">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_WorkCorrectKeyWorkEN GetObjByIdWorkCorrectKeyWork(long lngIdWorkCorrectKeyWork)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkCorrectKeyWork where IdWorkCorrectKeyWork = " + ""+ lngIdWorkCorrectKeyWork+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = new clsvcc_WorkCorrectKeyWorkEN();
try
{
 objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_WorkCorrectKeyWorkEN.QuestionID = objRow[convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.WorkIndex = objRow[convcc_WorkCorrectKeyWork.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()); //作业序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.WorkName = objRow[convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(); //作业名称(字段类型:varchar,字段长度:5000,是否可空:False)
 objvcc_WorkCorrectKeyWorkEN.WorkDesc = objRow[convcc_WorkCorrectKeyWork.WorkDesc] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(); //作业说明(字段类型:text,字段长度:2147483647,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.CourseId = objRow[convcc_WorkCorrectKeyWork.CourseId] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.CourseName = objRow[convcc_WorkCorrectKeyWork.CourseName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objRow[convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objRow[convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objRow[convcc_WorkCorrectKeyWork.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objRow[convcc_WorkCorrectKeyWork.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词(字段类型:varchar,字段长度:200,是否可空:False)
 objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.FormatPara = objRow[convcc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objRow[convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(); //InOut类型类型(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_WorkCorrectKeyWorkEN.Creator = objRow[convcc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者(字段类型:varchar,字段长度:18,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.CreateDate = objRow[convcc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:False)
 objvcc_WorkCorrectKeyWorkEN.UpdDate = objRow[convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.UpdUser = objRow[convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.Memo = objRow[convcc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_WorkCorrectKeyWorkEN.IdWork = objRow[convcc_WorkCorrectKeyWork.IdWork] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.IdWork].ToString().Trim(); //作业流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: GetObjByIdWorkCorrectKeyWork)", objException.Message));
}
return objvcc_WorkCorrectKeyWorkEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_WorkCorrectKeyWorkEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkCorrectKeyWork where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = new clsvcc_WorkCorrectKeyWorkEN()
{
IdWorkCorrectKeyWork = TransNullToInt(objRow[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()), //作业批改关键词流水号
QuestionID = objRow[convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(), //题目ID
WorkIndex = objRow[convcc_WorkCorrectKeyWork.WorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()), //作业序号
WorkName = objRow[convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(), //作业名称
WorkDesc = objRow[convcc_WorkCorrectKeyWork.WorkDesc] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(), //作业说明
CourseId = objRow[convcc_WorkCorrectKeyWork.CourseId] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(), //课程Id
CourseName = objRow[convcc_WorkCorrectKeyWork.CourseName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(), //课程名称
CourseChapterId = objRow[convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(), //课程章节名称
CourseChapterReferred = objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(), //节简称
ParentNodeID = objRow[convcc_WorkCorrectKeyWork.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(), //父节点编号
ParentNodeName = objRow[convcc_WorkCorrectKeyWork.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(), //父节点名称
ParentNodeReferred = objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(), //章简称
KeyWorkIndex = objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()), //关键字序号
CorrectKeyWork = objRow[convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(), //批改关键词
IsUseFormatPara = TransNullToBool(objRow[convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()), //是否使用格式化参数
FormatPara = objRow[convcc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(), //格式化参数
InOutTypeId = objRow[convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(), //InOut类型Id
InOutTypeName = objRow[convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(), //InOut类型类型
Creator = objRow[convcc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Creator].ToString().Trim(), //创建者
CreateDate = objRow[convcc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(), //建立日期
IsEnable = TransNullToBool(objRow[convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()), //是否启用
UpdDate = objRow[convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convcc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Memo].ToString().Trim(), //备注
IdWork = objRow[convcc_WorkCorrectKeyWork.IdWork] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.IdWork].ToString().Trim() //作业流水号
};
objvcc_WorkCorrectKeyWorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_WorkCorrectKeyWorkEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_WorkCorrectKeyWorkEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = new clsvcc_WorkCorrectKeyWorkEN();
try
{
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = TransNullToInt(objRow[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objvcc_WorkCorrectKeyWorkEN.QuestionID = objRow[convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkCorrectKeyWorkEN.WorkIndex = objRow[convcc_WorkCorrectKeyWork.WorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkCorrectKeyWorkEN.WorkName = objRow[convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(); //作业名称
objvcc_WorkCorrectKeyWorkEN.WorkDesc = objRow[convcc_WorkCorrectKeyWork.WorkDesc] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkCorrectKeyWorkEN.CourseId = objRow[convcc_WorkCorrectKeyWork.CourseId] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(); //课程Id
objvcc_WorkCorrectKeyWorkEN.CourseName = objRow[convcc_WorkCorrectKeyWork.CourseName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(); //课程名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objRow[convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objRow[convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objRow[convcc_WorkCorrectKeyWork.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objRow[convcc_WorkCorrectKeyWork.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = TransNullToBool(objRow[convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objvcc_WorkCorrectKeyWorkEN.FormatPara = objRow[convcc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objRow[convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(); //InOut类型类型
objvcc_WorkCorrectKeyWorkEN.Creator = objRow[convcc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objvcc_WorkCorrectKeyWorkEN.CreateDate = objRow[convcc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkCorrectKeyWorkEN.IsEnable = TransNullToBool(objRow[convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objvcc_WorkCorrectKeyWorkEN.UpdDate = objRow[convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkCorrectKeyWorkEN.UpdUser = objRow[convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objvcc_WorkCorrectKeyWorkEN.Memo = objRow[convcc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
objvcc_WorkCorrectKeyWorkEN.IdWork = objRow[convcc_WorkCorrectKeyWork.IdWork] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.IdWork].ToString().Trim(); //作业流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: GetObjByDataRowvcc_WorkCorrectKeyWork)", objException.Message));
}
objvcc_WorkCorrectKeyWorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_WorkCorrectKeyWorkEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_WorkCorrectKeyWorkEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN = new clsvcc_WorkCorrectKeyWorkEN();
try
{
objvcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = TransNullToInt(objRow[convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objvcc_WorkCorrectKeyWorkEN.QuestionID = objRow[convcc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkCorrectKeyWorkEN.WorkIndex = objRow[convcc_WorkCorrectKeyWork.WorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkCorrectKeyWork.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkCorrectKeyWorkEN.WorkName = objRow[convcc_WorkCorrectKeyWork.WorkName].ToString().Trim(); //作业名称
objvcc_WorkCorrectKeyWorkEN.WorkDesc = objRow[convcc_WorkCorrectKeyWork.WorkDesc] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkCorrectKeyWorkEN.CourseId = objRow[convcc_WorkCorrectKeyWork.CourseId] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseId].ToString().Trim(); //课程Id
objvcc_WorkCorrectKeyWorkEN.CourseName = objRow[convcc_WorkCorrectKeyWork.CourseName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseName].ToString().Trim(); //课程名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterId = objRow[convcc_WorkCorrectKeyWork.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkCorrectKeyWorkEN.CourseChapterName = objRow[convcc_WorkCorrectKeyWork.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred = objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkCorrectKeyWorkEN.ParentNodeID = objRow[convcc_WorkCorrectKeyWork.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkCorrectKeyWorkEN.ParentNodeName = objRow[convcc_WorkCorrectKeyWork.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred = objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[convcc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objvcc_WorkCorrectKeyWorkEN.IsUseFormatPara = TransNullToBool(objRow[convcc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objvcc_WorkCorrectKeyWorkEN.FormatPara = objRow[convcc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objvcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[convcc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objvcc_WorkCorrectKeyWorkEN.InOutTypeName = objRow[convcc_WorkCorrectKeyWork.InOutTypeName].ToString().Trim(); //InOut类型类型
objvcc_WorkCorrectKeyWorkEN.Creator = objRow[convcc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objvcc_WorkCorrectKeyWorkEN.CreateDate = objRow[convcc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkCorrectKeyWorkEN.IsEnable = TransNullToBool(objRow[convcc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objvcc_WorkCorrectKeyWorkEN.UpdDate = objRow[convcc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkCorrectKeyWorkEN.UpdUser = objRow[convcc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objvcc_WorkCorrectKeyWorkEN.Memo = objRow[convcc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
objvcc_WorkCorrectKeyWorkEN.IdWork = objRow[convcc_WorkCorrectKeyWork.IdWork] == DBNull.Value ? null : objRow[convcc_WorkCorrectKeyWork.IdWork].ToString().Trim(); //作业流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_WorkCorrectKeyWorkDA: GetObjByDataRow)", objException.Message));
}
objvcc_WorkCorrectKeyWorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_WorkCorrectKeyWorkEN;
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
objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_WorkCorrectKeyWorkEN._CurrTabName, convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork, 8, "");
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
objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_WorkCorrectKeyWorkEN._CurrTabName, convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdWorkCorrectKeyWork from vcc_WorkCorrectKeyWork where " + strCondition;
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
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
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
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdWorkCorrectKeyWork from vcc_WorkCorrectKeyWork where " + strCondition;
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
 /// <param name = "lngIdWorkCorrectKeyWork">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdWorkCorrectKeyWork)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_WorkCorrectKeyWork", "IdWorkCorrectKeyWork = " + ""+ lngIdWorkCorrectKeyWork+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_WorkCorrectKeyWorkDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_WorkCorrectKeyWork", strCondition))
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
objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_WorkCorrectKeyWork");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_WorkCorrectKeyWorkENS">源对象</param>
 /// <param name = "objvcc_WorkCorrectKeyWorkENT">目标对象</param>
public void CopyTo(clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkENS, clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkENT)
{
objvcc_WorkCorrectKeyWorkENT.IdWorkCorrectKeyWork = objvcc_WorkCorrectKeyWorkENS.IdWorkCorrectKeyWork; //作业批改关键词流水号
objvcc_WorkCorrectKeyWorkENT.QuestionID = objvcc_WorkCorrectKeyWorkENS.QuestionID; //题目ID
objvcc_WorkCorrectKeyWorkENT.WorkIndex = objvcc_WorkCorrectKeyWorkENS.WorkIndex; //作业序号
objvcc_WorkCorrectKeyWorkENT.WorkName = objvcc_WorkCorrectKeyWorkENS.WorkName; //作业名称
objvcc_WorkCorrectKeyWorkENT.WorkDesc = objvcc_WorkCorrectKeyWorkENS.WorkDesc; //作业说明
objvcc_WorkCorrectKeyWorkENT.CourseId = objvcc_WorkCorrectKeyWorkENS.CourseId; //课程Id
objvcc_WorkCorrectKeyWorkENT.CourseName = objvcc_WorkCorrectKeyWorkENS.CourseName; //课程名称
objvcc_WorkCorrectKeyWorkENT.CourseChapterId = objvcc_WorkCorrectKeyWorkENS.CourseChapterId; //课程章节ID
objvcc_WorkCorrectKeyWorkENT.CourseChapterName = objvcc_WorkCorrectKeyWorkENS.CourseChapterName; //课程章节名称
objvcc_WorkCorrectKeyWorkENT.CourseChapterReferred = objvcc_WorkCorrectKeyWorkENS.CourseChapterReferred; //节简称
objvcc_WorkCorrectKeyWorkENT.ParentNodeID = objvcc_WorkCorrectKeyWorkENS.ParentNodeID; //父节点编号
objvcc_WorkCorrectKeyWorkENT.ParentNodeName = objvcc_WorkCorrectKeyWorkENS.ParentNodeName; //父节点名称
objvcc_WorkCorrectKeyWorkENT.ParentNodeReferred = objvcc_WorkCorrectKeyWorkENS.ParentNodeReferred; //章简称
objvcc_WorkCorrectKeyWorkENT.KeyWorkIndex = objvcc_WorkCorrectKeyWorkENS.KeyWorkIndex; //关键字序号
objvcc_WorkCorrectKeyWorkENT.CorrectKeyWork = objvcc_WorkCorrectKeyWorkENS.CorrectKeyWork; //批改关键词
objvcc_WorkCorrectKeyWorkENT.IsUseFormatPara = objvcc_WorkCorrectKeyWorkENS.IsUseFormatPara; //是否使用格式化参数
objvcc_WorkCorrectKeyWorkENT.FormatPara = objvcc_WorkCorrectKeyWorkENS.FormatPara; //格式化参数
objvcc_WorkCorrectKeyWorkENT.InOutTypeId = objvcc_WorkCorrectKeyWorkENS.InOutTypeId; //InOut类型Id
objvcc_WorkCorrectKeyWorkENT.InOutTypeName = objvcc_WorkCorrectKeyWorkENS.InOutTypeName; //InOut类型类型
objvcc_WorkCorrectKeyWorkENT.Creator = objvcc_WorkCorrectKeyWorkENS.Creator; //创建者
objvcc_WorkCorrectKeyWorkENT.CreateDate = objvcc_WorkCorrectKeyWorkENS.CreateDate; //建立日期
objvcc_WorkCorrectKeyWorkENT.IsEnable = objvcc_WorkCorrectKeyWorkENS.IsEnable; //是否启用
objvcc_WorkCorrectKeyWorkENT.UpdDate = objvcc_WorkCorrectKeyWorkENS.UpdDate; //修改日期
objvcc_WorkCorrectKeyWorkENT.UpdUser = objvcc_WorkCorrectKeyWorkENS.UpdUser; //修改人
objvcc_WorkCorrectKeyWorkENT.Memo = objvcc_WorkCorrectKeyWorkENS.Memo; //备注
objvcc_WorkCorrectKeyWorkENT.IdWork = objvcc_WorkCorrectKeyWorkENS.IdWork; //作业流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_WorkCorrectKeyWorkEN objvcc_WorkCorrectKeyWorkEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.QuestionID, 8, convcc_WorkCorrectKeyWork.QuestionID);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.WorkName, 5000, convcc_WorkCorrectKeyWork.WorkName);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.CourseId, 8, convcc_WorkCorrectKeyWork.CourseId);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.CourseName, 100, convcc_WorkCorrectKeyWork.CourseName);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.CourseChapterId, 8, convcc_WorkCorrectKeyWork.CourseChapterId);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.CourseChapterName, 100, convcc_WorkCorrectKeyWork.CourseChapterName);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred, 10, convcc_WorkCorrectKeyWork.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.ParentNodeID, 8, convcc_WorkCorrectKeyWork.ParentNodeID);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.ParentNodeName, 50, convcc_WorkCorrectKeyWork.ParentNodeName);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred, 10, convcc_WorkCorrectKeyWork.ParentNodeReferred);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork, 200, convcc_WorkCorrectKeyWork.CorrectKeyWork);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.FormatPara, 100, convcc_WorkCorrectKeyWork.FormatPara);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.InOutTypeId, 2, convcc_WorkCorrectKeyWork.InOutTypeId);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.InOutTypeName, 30, convcc_WorkCorrectKeyWork.InOutTypeName);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.Creator, 18, convcc_WorkCorrectKeyWork.Creator);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.CreateDate, 20, convcc_WorkCorrectKeyWork.CreateDate);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.UpdDate, 20, convcc_WorkCorrectKeyWork.UpdDate);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.UpdUser, 20, convcc_WorkCorrectKeyWork.UpdUser);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.Memo, 1000, convcc_WorkCorrectKeyWork.Memo);
clsCheckSql.CheckFieldLen(objvcc_WorkCorrectKeyWorkEN.IdWork, 8, convcc_WorkCorrectKeyWork.IdWork);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.QuestionID, convcc_WorkCorrectKeyWork.QuestionID);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.WorkName, convcc_WorkCorrectKeyWork.WorkName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.CourseId, convcc_WorkCorrectKeyWork.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.CourseName, convcc_WorkCorrectKeyWork.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.CourseChapterId, convcc_WorkCorrectKeyWork.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.CourseChapterName, convcc_WorkCorrectKeyWork.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.CourseChapterReferred, convcc_WorkCorrectKeyWork.CourseChapterReferred);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.ParentNodeID, convcc_WorkCorrectKeyWork.ParentNodeID);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.ParentNodeName, convcc_WorkCorrectKeyWork.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.ParentNodeReferred, convcc_WorkCorrectKeyWork.ParentNodeReferred);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.CorrectKeyWork, convcc_WorkCorrectKeyWork.CorrectKeyWork);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.FormatPara, convcc_WorkCorrectKeyWork.FormatPara);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.InOutTypeId, convcc_WorkCorrectKeyWork.InOutTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.InOutTypeName, convcc_WorkCorrectKeyWork.InOutTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.Creator, convcc_WorkCorrectKeyWork.Creator);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.CreateDate, convcc_WorkCorrectKeyWork.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.UpdDate, convcc_WorkCorrectKeyWork.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.UpdUser, convcc_WorkCorrectKeyWork.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.Memo, convcc_WorkCorrectKeyWork.Memo);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkCorrectKeyWorkEN.IdWork, convcc_WorkCorrectKeyWork.IdWork);
//检查外键字段长度
 objvcc_WorkCorrectKeyWorkEN._IsCheckProperty = true;
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
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
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
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
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
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_WorkCorrectKeyWorkEN._CurrTabName);
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
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_WorkCorrectKeyWorkEN._CurrTabName, strCondition);
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
 objSQL = clsvcc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}