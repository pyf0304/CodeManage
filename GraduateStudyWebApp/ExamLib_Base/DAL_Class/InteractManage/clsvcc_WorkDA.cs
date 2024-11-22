
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkDA
 表名:vcc_Work(01120146)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:11
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
 /// 作业(vcc_Work)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_WorkDA : clsCommBase4DA
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
 return clsvcc_WorkEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcc_WorkEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_WorkEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcc_WorkEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_WorkEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdWork">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdWork)
{
strIdWork = strIdWork.Replace("'", "''");
if (strIdWork.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vcc_Work中,检查关键字,长度不正确!(clsvcc_WorkDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdWork)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vcc_Work中,关键字不能为空 或 null!(clsvcc_WorkDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdWork);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvcc_WorkDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_WorkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Work where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_Work(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_WorkDA: GetDataTable_vcc_Work)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Work where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_WorkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_WorkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Work where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_WorkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_WorkDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_Work where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_Work where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_WorkDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_Work where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_WorkDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_Work.* from vcc_Work Left Join {1} on {2} where {3} and vcc_Work.IdWork not in (Select top {5} vcc_Work.IdWork from vcc_Work Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_Work where {1} and IdWork not in (Select top {2} IdWork from vcc_Work where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_Work where {1} and IdWork not in (Select top {3} IdWork from vcc_Work where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_WorkDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_Work.* from vcc_Work Left Join {1} on {2} where {3} and vcc_Work.IdWork not in (Select top {5} vcc_Work.IdWork from vcc_Work Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_Work where {1} and IdWork not in (Select top {2} IdWork from vcc_Work where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_Work where {1} and IdWork not in (Select top {3} IdWork from vcc_Work where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcc_WorkEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_WorkDA:GetObjLst)", objException.Message));
}
List<clsvcc_WorkEN> arrObjLst = new List<clsvcc_WorkEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Work where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEN objvcc_WorkEN = new clsvcc_WorkEN();
try
{
objvcc_WorkEN.IdWork = objRow[convcc_Work.IdWork].ToString().Trim(); //作业流水号
objvcc_WorkEN.WorkIndex = objRow[convcc_Work.WorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkEN.WorkName = objRow[convcc_Work.WorkName].ToString().Trim(); //作业名称
objvcc_WorkEN.WorkDesc = objRow[convcc_Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkEN.CourseId = objRow[convcc_Work.CourseId] == DBNull.Value ? null : objRow[convcc_Work.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEN.CourseName = objRow[convcc_Work.CourseName] == DBNull.Value ? null : objRow[convcc_Work.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEN.CourseChapterId = objRow[convcc_Work.CourseChapterId] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEN.CourseChapterName = objRow[convcc_Work.CourseChapterName] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEN.ChapterName = objRow[convcc_Work.ChapterName] == DBNull.Value ? null : objRow[convcc_Work.ChapterName].ToString().Trim(); //章名
objvcc_WorkEN.SectionName = objRow[convcc_Work.SectionName] == DBNull.Value ? null : objRow[convcc_Work.SectionName].ToString().Trim(); //节名
objvcc_WorkEN.ChapterNameSim = objRow[convcc_Work.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_Work.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEN.SectionNameSim = objRow[convcc_Work.SectionNameSim] == DBNull.Value ? null : objRow[convcc_Work.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEN.ParentNodeID = objRow[convcc_Work.ParentNodeID] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkEN.CourseChapterReferred = objRow[convcc_Work.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEN.ParentNodeName = objRow[convcc_Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEN.ParentNodeReferred = objRow[convcc_Work.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEN.Creator = objRow[convcc_Work.Creator] == DBNull.Value ? null : objRow[convcc_Work.Creator].ToString().Trim(); //创建者
objvcc_WorkEN.CreateDate = objRow[convcc_Work.CreateDate] == DBNull.Value ? null : objRow[convcc_Work.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkEN.AnswerAttLimitSize = objRow[convcc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEN.LimitedResourceType = objRow[convcc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEN.UpdDate = objRow[convcc_Work.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEN.UpdUserId = objRow[convcc_Work.UpdUserId] == DBNull.Value ? null : objRow[convcc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEN.Memo = objRow[convcc_Work.Memo] == DBNull.Value ? null : objRow[convcc_Work.Memo].ToString().Trim(); //备注
objvcc_WorkEN.CourseId4Chapter = objRow[convcc_Work.CourseId4Chapter] == DBNull.Value ? null : objRow[convcc_Work.CourseId4Chapter].ToString().Trim(); //CourseId4Chapter
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_WorkDA: GetObjLst)", objException.Message));
}
objvcc_WorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_WorkEN);
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
public List<clsvcc_WorkEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_WorkDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_WorkEN> arrObjLst = new List<clsvcc_WorkEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEN objvcc_WorkEN = new clsvcc_WorkEN();
try
{
objvcc_WorkEN.IdWork = objRow[convcc_Work.IdWork].ToString().Trim(); //作业流水号
objvcc_WorkEN.WorkIndex = objRow[convcc_Work.WorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkEN.WorkName = objRow[convcc_Work.WorkName].ToString().Trim(); //作业名称
objvcc_WorkEN.WorkDesc = objRow[convcc_Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkEN.CourseId = objRow[convcc_Work.CourseId] == DBNull.Value ? null : objRow[convcc_Work.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEN.CourseName = objRow[convcc_Work.CourseName] == DBNull.Value ? null : objRow[convcc_Work.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEN.CourseChapterId = objRow[convcc_Work.CourseChapterId] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEN.CourseChapterName = objRow[convcc_Work.CourseChapterName] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEN.ChapterName = objRow[convcc_Work.ChapterName] == DBNull.Value ? null : objRow[convcc_Work.ChapterName].ToString().Trim(); //章名
objvcc_WorkEN.SectionName = objRow[convcc_Work.SectionName] == DBNull.Value ? null : objRow[convcc_Work.SectionName].ToString().Trim(); //节名
objvcc_WorkEN.ChapterNameSim = objRow[convcc_Work.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_Work.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEN.SectionNameSim = objRow[convcc_Work.SectionNameSim] == DBNull.Value ? null : objRow[convcc_Work.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEN.ParentNodeID = objRow[convcc_Work.ParentNodeID] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkEN.CourseChapterReferred = objRow[convcc_Work.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEN.ParentNodeName = objRow[convcc_Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEN.ParentNodeReferred = objRow[convcc_Work.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEN.Creator = objRow[convcc_Work.Creator] == DBNull.Value ? null : objRow[convcc_Work.Creator].ToString().Trim(); //创建者
objvcc_WorkEN.CreateDate = objRow[convcc_Work.CreateDate] == DBNull.Value ? null : objRow[convcc_Work.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkEN.AnswerAttLimitSize = objRow[convcc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEN.LimitedResourceType = objRow[convcc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEN.UpdDate = objRow[convcc_Work.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEN.UpdUserId = objRow[convcc_Work.UpdUserId] == DBNull.Value ? null : objRow[convcc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEN.Memo = objRow[convcc_Work.Memo] == DBNull.Value ? null : objRow[convcc_Work.Memo].ToString().Trim(); //备注
objvcc_WorkEN.CourseId4Chapter = objRow[convcc_Work.CourseId4Chapter] == DBNull.Value ? null : objRow[convcc_Work.CourseId4Chapter].ToString().Trim(); //CourseId4Chapter
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_WorkDA: GetObjLst)", objException.Message));
}
objvcc_WorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_WorkEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_WorkEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_Work(ref clsvcc_WorkEN objvcc_WorkEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Work where IdWork = " + "'"+ objvcc_WorkEN.IdWork+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_WorkEN.IdWork = objDT.Rows[0][convcc_Work.IdWork].ToString().Trim(); //作业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkEN.WorkIndex = TransNullToInt(objDT.Rows[0][convcc_Work.WorkIndex].ToString().Trim()); //作业序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkEN.WorkName = objDT.Rows[0][convcc_Work.WorkName].ToString().Trim(); //作业名称(字段类型:varchar,字段长度:5000,是否可空:False)
 objvcc_WorkEN.WorkDesc = objDT.Rows[0][convcc_Work.WorkDesc].ToString().Trim(); //作业说明(字段类型:text,字段长度:2147483647,是否可空:True)
 objvcc_WorkEN.CourseId = objDT.Rows[0][convcc_Work.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkEN.CourseName = objDT.Rows[0][convcc_Work.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEN.CourseChapterId = objDT.Rows[0][convcc_Work.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkEN.CourseChapterName = objDT.Rows[0][convcc_Work.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkEN.ChapterName = objDT.Rows[0][convcc_Work.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEN.SectionName = objDT.Rows[0][convcc_Work.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEN.ChapterNameSim = objDT.Rows[0][convcc_Work.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkEN.SectionNameSim = objDT.Rows[0][convcc_Work.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkEN.ParentNodeID = objDT.Rows[0][convcc_Work.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_WorkEN.CourseChapterReferred = objDT.Rows[0][convcc_Work.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkEN.ParentNodeName = objDT.Rows[0][convcc_Work.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_WorkEN.ParentNodeReferred = objDT.Rows[0][convcc_Work.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkEN.Creator = objDT.Rows[0][convcc_Work.Creator].ToString().Trim(); //创建者(字段类型:varchar,字段长度:18,是否可空:True)
 objvcc_WorkEN.CreateDate = objDT.Rows[0][convcc_Work.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkEN.AnswerAttLimitSize = TransNullToInt(objDT.Rows[0][convcc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_WorkEN.LimitedResourceType = objDT.Rows[0][convcc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEN.UpdDate = objDT.Rows[0][convcc_Work.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkEN.UpdUserId = objDT.Rows[0][convcc_Work.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkEN.Memo = objDT.Rows[0][convcc_Work.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_WorkEN.CourseId4Chapter = objDT.Rows[0][convcc_Work.CourseId4Chapter].ToString().Trim(); //CourseId4Chapter(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_WorkDA: Getvcc_Work)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdWork">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_WorkEN GetObjByIdWork(string strIdWork)
{
CheckPrimaryKey(strIdWork);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Work where IdWork = " + "'"+ strIdWork+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_WorkEN objvcc_WorkEN = new clsvcc_WorkEN();
try
{
 objvcc_WorkEN.IdWork = objRow[convcc_Work.IdWork].ToString().Trim(); //作业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkEN.WorkIndex = objRow[convcc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.WorkIndex].ToString().Trim()); //作业序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkEN.WorkName = objRow[convcc_Work.WorkName].ToString().Trim(); //作业名称(字段类型:varchar,字段长度:5000,是否可空:False)
 objvcc_WorkEN.WorkDesc = objRow[convcc_Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Work.WorkDesc].ToString().Trim(); //作业说明(字段类型:text,字段长度:2147483647,是否可空:True)
 objvcc_WorkEN.CourseId = objRow[convcc_Work.CourseId] == DBNull.Value ? null : objRow[convcc_Work.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkEN.CourseName = objRow[convcc_Work.CourseName] == DBNull.Value ? null : objRow[convcc_Work.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEN.CourseChapterId = objRow[convcc_Work.CourseChapterId] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkEN.CourseChapterName = objRow[convcc_Work.CourseChapterName] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkEN.ChapterName = objRow[convcc_Work.ChapterName] == DBNull.Value ? null : objRow[convcc_Work.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEN.SectionName = objRow[convcc_Work.SectionName] == DBNull.Value ? null : objRow[convcc_Work.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEN.ChapterNameSim = objRow[convcc_Work.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_Work.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkEN.SectionNameSim = objRow[convcc_Work.SectionNameSim] == DBNull.Value ? null : objRow[convcc_Work.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkEN.ParentNodeID = objRow[convcc_Work.ParentNodeID] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_WorkEN.CourseChapterReferred = objRow[convcc_Work.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkEN.ParentNodeName = objRow[convcc_Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_WorkEN.ParentNodeReferred = objRow[convcc_Work.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkEN.Creator = objRow[convcc_Work.Creator] == DBNull.Value ? null : objRow[convcc_Work.Creator].ToString().Trim(); //创建者(字段类型:varchar,字段长度:18,是否可空:True)
 objvcc_WorkEN.CreateDate = objRow[convcc_Work.CreateDate] == DBNull.Value ? null : objRow[convcc_Work.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkEN.AnswerAttLimitSize = objRow[convcc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_WorkEN.LimitedResourceType = objRow[convcc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEN.UpdDate = objRow[convcc_Work.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkEN.UpdUserId = objRow[convcc_Work.UpdUserId] == DBNull.Value ? null : objRow[convcc_Work.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkEN.Memo = objRow[convcc_Work.Memo] == DBNull.Value ? null : objRow[convcc_Work.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_WorkEN.CourseId4Chapter = objRow[convcc_Work.CourseId4Chapter] == DBNull.Value ? null : objRow[convcc_Work.CourseId4Chapter].ToString().Trim(); //CourseId4Chapter(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_WorkDA: GetObjByIdWork)", objException.Message));
}
return objvcc_WorkEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_WorkEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_WorkDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Work where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_WorkEN objvcc_WorkEN = new clsvcc_WorkEN()
{
IdWork = objRow[convcc_Work.IdWork].ToString().Trim(), //作业流水号
WorkIndex = objRow[convcc_Work.WorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Work.WorkIndex].ToString().Trim()), //作业序号
WorkName = objRow[convcc_Work.WorkName].ToString().Trim(), //作业名称
WorkDesc = objRow[convcc_Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Work.WorkDesc].ToString().Trim(), //作业说明
CourseId = objRow[convcc_Work.CourseId] == DBNull.Value ? null : objRow[convcc_Work.CourseId].ToString().Trim(), //课程Id
CourseName = objRow[convcc_Work.CourseName] == DBNull.Value ? null : objRow[convcc_Work.CourseName].ToString().Trim(), //课程名称
CourseChapterId = objRow[convcc_Work.CourseChapterId] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convcc_Work.CourseChapterName] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterName].ToString().Trim(), //课程章节名称
ChapterName = objRow[convcc_Work.ChapterName] == DBNull.Value ? null : objRow[convcc_Work.ChapterName].ToString().Trim(), //章名
SectionName = objRow[convcc_Work.SectionName] == DBNull.Value ? null : objRow[convcc_Work.SectionName].ToString().Trim(), //节名
ChapterNameSim = objRow[convcc_Work.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_Work.ChapterNameSim].ToString().Trim(), //章名简称
SectionNameSim = objRow[convcc_Work.SectionNameSim] == DBNull.Value ? null : objRow[convcc_Work.SectionNameSim].ToString().Trim(), //节名简称
ParentNodeID = objRow[convcc_Work.ParentNodeID] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeID].ToString().Trim(), //父节点编号
CourseChapterReferred = objRow[convcc_Work.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterReferred].ToString().Trim(), //节简称
ParentNodeName = objRow[convcc_Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeName].ToString().Trim(), //父节点名称
ParentNodeReferred = objRow[convcc_Work.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeReferred].ToString().Trim(), //章简称
Creator = objRow[convcc_Work.Creator] == DBNull.Value ? null : objRow[convcc_Work.Creator].ToString().Trim(), //创建者
CreateDate = objRow[convcc_Work.CreateDate] == DBNull.Value ? null : objRow[convcc_Work.CreateDate].ToString().Trim(), //建立日期
AnswerAttLimitSize = objRow[convcc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_Work.AnswerAttLimitSize].ToString().Trim()), //回答附件限制大小
LimitedResourceType = objRow[convcc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_Work.LimitedResourceType].ToString().Trim(), //限制资源类型
UpdDate = objRow[convcc_Work.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convcc_Work.UpdUserId] == DBNull.Value ? null : objRow[convcc_Work.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convcc_Work.Memo] == DBNull.Value ? null : objRow[convcc_Work.Memo].ToString().Trim(), //备注
CourseId4Chapter = objRow[convcc_Work.CourseId4Chapter] == DBNull.Value ? null : objRow[convcc_Work.CourseId4Chapter].ToString().Trim() //CourseId4Chapter
};
objvcc_WorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_WorkEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_WorkDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_WorkEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_WorkEN objvcc_WorkEN = new clsvcc_WorkEN();
try
{
objvcc_WorkEN.IdWork = objRow[convcc_Work.IdWork].ToString().Trim(); //作业流水号
objvcc_WorkEN.WorkIndex = objRow[convcc_Work.WorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkEN.WorkName = objRow[convcc_Work.WorkName].ToString().Trim(); //作业名称
objvcc_WorkEN.WorkDesc = objRow[convcc_Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkEN.CourseId = objRow[convcc_Work.CourseId] == DBNull.Value ? null : objRow[convcc_Work.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEN.CourseName = objRow[convcc_Work.CourseName] == DBNull.Value ? null : objRow[convcc_Work.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEN.CourseChapterId = objRow[convcc_Work.CourseChapterId] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEN.CourseChapterName = objRow[convcc_Work.CourseChapterName] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEN.ChapterName = objRow[convcc_Work.ChapterName] == DBNull.Value ? null : objRow[convcc_Work.ChapterName].ToString().Trim(); //章名
objvcc_WorkEN.SectionName = objRow[convcc_Work.SectionName] == DBNull.Value ? null : objRow[convcc_Work.SectionName].ToString().Trim(); //节名
objvcc_WorkEN.ChapterNameSim = objRow[convcc_Work.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_Work.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEN.SectionNameSim = objRow[convcc_Work.SectionNameSim] == DBNull.Value ? null : objRow[convcc_Work.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEN.ParentNodeID = objRow[convcc_Work.ParentNodeID] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkEN.CourseChapterReferred = objRow[convcc_Work.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEN.ParentNodeName = objRow[convcc_Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEN.ParentNodeReferred = objRow[convcc_Work.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEN.Creator = objRow[convcc_Work.Creator] == DBNull.Value ? null : objRow[convcc_Work.Creator].ToString().Trim(); //创建者
objvcc_WorkEN.CreateDate = objRow[convcc_Work.CreateDate] == DBNull.Value ? null : objRow[convcc_Work.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkEN.AnswerAttLimitSize = objRow[convcc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEN.LimitedResourceType = objRow[convcc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEN.UpdDate = objRow[convcc_Work.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEN.UpdUserId = objRow[convcc_Work.UpdUserId] == DBNull.Value ? null : objRow[convcc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEN.Memo = objRow[convcc_Work.Memo] == DBNull.Value ? null : objRow[convcc_Work.Memo].ToString().Trim(); //备注
objvcc_WorkEN.CourseId4Chapter = objRow[convcc_Work.CourseId4Chapter] == DBNull.Value ? null : objRow[convcc_Work.CourseId4Chapter].ToString().Trim(); //CourseId4Chapter
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_WorkDA: GetObjByDataRowvcc_Work)", objException.Message));
}
objvcc_WorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_WorkEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_WorkEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_WorkEN objvcc_WorkEN = new clsvcc_WorkEN();
try
{
objvcc_WorkEN.IdWork = objRow[convcc_Work.IdWork].ToString().Trim(); //作业流水号
objvcc_WorkEN.WorkIndex = objRow[convcc_Work.WorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_WorkEN.WorkName = objRow[convcc_Work.WorkName].ToString().Trim(); //作业名称
objvcc_WorkEN.WorkDesc = objRow[convcc_Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_WorkEN.CourseId = objRow[convcc_Work.CourseId] == DBNull.Value ? null : objRow[convcc_Work.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEN.CourseName = objRow[convcc_Work.CourseName] == DBNull.Value ? null : objRow[convcc_Work.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEN.CourseChapterId = objRow[convcc_Work.CourseChapterId] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEN.CourseChapterName = objRow[convcc_Work.CourseChapterName] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEN.ChapterName = objRow[convcc_Work.ChapterName] == DBNull.Value ? null : objRow[convcc_Work.ChapterName].ToString().Trim(); //章名
objvcc_WorkEN.SectionName = objRow[convcc_Work.SectionName] == DBNull.Value ? null : objRow[convcc_Work.SectionName].ToString().Trim(); //节名
objvcc_WorkEN.ChapterNameSim = objRow[convcc_Work.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_Work.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEN.SectionNameSim = objRow[convcc_Work.SectionNameSim] == DBNull.Value ? null : objRow[convcc_Work.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEN.ParentNodeID = objRow[convcc_Work.ParentNodeID] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkEN.CourseChapterReferred = objRow[convcc_Work.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_Work.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEN.ParentNodeName = objRow[convcc_Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEN.ParentNodeReferred = objRow[convcc_Work.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_Work.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEN.Creator = objRow[convcc_Work.Creator] == DBNull.Value ? null : objRow[convcc_Work.Creator].ToString().Trim(); //创建者
objvcc_WorkEN.CreateDate = objRow[convcc_Work.CreateDate] == DBNull.Value ? null : objRow[convcc_Work.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkEN.AnswerAttLimitSize = objRow[convcc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEN.LimitedResourceType = objRow[convcc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEN.UpdDate = objRow[convcc_Work.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEN.UpdUserId = objRow[convcc_Work.UpdUserId] == DBNull.Value ? null : objRow[convcc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEN.Memo = objRow[convcc_Work.Memo] == DBNull.Value ? null : objRow[convcc_Work.Memo].ToString().Trim(); //备注
objvcc_WorkEN.CourseId4Chapter = objRow[convcc_Work.CourseId4Chapter] == DBNull.Value ? null : objRow[convcc_Work.CourseId4Chapter].ToString().Trim(); //CourseId4Chapter
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_WorkDA: GetObjByDataRow)", objException.Message));
}
objvcc_WorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_WorkEN;
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
objSQL = clsvcc_WorkDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_WorkEN._CurrTabName, convcc_Work.IdWork, 8, "");
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
objSQL = clsvcc_WorkDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_WorkEN._CurrTabName, convcc_Work.IdWork, 8, strPrefix);
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
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdWork from vcc_Work where " + strCondition;
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
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdWork from vcc_Work where " + strCondition;
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
 /// <param name = "strIdWork">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdWork)
{
CheckPrimaryKey(strIdWork);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_Work", "IdWork = " + "'"+ strIdWork+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_WorkDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_Work", strCondition))
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
objSQL = clsvcc_WorkDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_Work");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_WorkENS">源对象</param>
 /// <param name = "objvcc_WorkENT">目标对象</param>
public void CopyTo(clsvcc_WorkEN objvcc_WorkENS, clsvcc_WorkEN objvcc_WorkENT)
{
objvcc_WorkENT.IdWork = objvcc_WorkENS.IdWork; //作业流水号
objvcc_WorkENT.WorkIndex = objvcc_WorkENS.WorkIndex; //作业序号
objvcc_WorkENT.WorkName = objvcc_WorkENS.WorkName; //作业名称
objvcc_WorkENT.WorkDesc = objvcc_WorkENS.WorkDesc; //作业说明
objvcc_WorkENT.CourseId = objvcc_WorkENS.CourseId; //课程Id
objvcc_WorkENT.CourseName = objvcc_WorkENS.CourseName; //课程名称
objvcc_WorkENT.CourseChapterId = objvcc_WorkENS.CourseChapterId; //课程章节ID
objvcc_WorkENT.CourseChapterName = objvcc_WorkENS.CourseChapterName; //课程章节名称
objvcc_WorkENT.ChapterName = objvcc_WorkENS.ChapterName; //章名
objvcc_WorkENT.SectionName = objvcc_WorkENS.SectionName; //节名
objvcc_WorkENT.ChapterNameSim = objvcc_WorkENS.ChapterNameSim; //章名简称
objvcc_WorkENT.SectionNameSim = objvcc_WorkENS.SectionNameSim; //节名简称
objvcc_WorkENT.ParentNodeID = objvcc_WorkENS.ParentNodeID; //父节点编号
objvcc_WorkENT.CourseChapterReferred = objvcc_WorkENS.CourseChapterReferred; //节简称
objvcc_WorkENT.ParentNodeName = objvcc_WorkENS.ParentNodeName; //父节点名称
objvcc_WorkENT.ParentNodeReferred = objvcc_WorkENS.ParentNodeReferred; //章简称
objvcc_WorkENT.Creator = objvcc_WorkENS.Creator; //创建者
objvcc_WorkENT.CreateDate = objvcc_WorkENS.CreateDate; //建立日期
objvcc_WorkENT.AnswerAttLimitSize = objvcc_WorkENS.AnswerAttLimitSize; //回答附件限制大小
objvcc_WorkENT.LimitedResourceType = objvcc_WorkENS.LimitedResourceType; //限制资源类型
objvcc_WorkENT.UpdDate = objvcc_WorkENS.UpdDate; //修改日期
objvcc_WorkENT.UpdUserId = objvcc_WorkENS.UpdUserId; //修改用户Id
objvcc_WorkENT.Memo = objvcc_WorkENS.Memo; //备注
objvcc_WorkENT.CourseId4Chapter = objvcc_WorkENS.CourseId4Chapter; //CourseId4Chapter
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_WorkEN objvcc_WorkEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_WorkEN.IdWork, 8, convcc_Work.IdWork);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.WorkName, 5000, convcc_Work.WorkName);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.CourseId, 8, convcc_Work.CourseId);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.CourseName, 100, convcc_Work.CourseName);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.CourseChapterId, 8, convcc_Work.CourseChapterId);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.CourseChapterName, 100, convcc_Work.CourseChapterName);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.ChapterName, 100, convcc_Work.ChapterName);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.SectionName, 100, convcc_Work.SectionName);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.ChapterNameSim, 10, convcc_Work.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.SectionNameSim, 10, convcc_Work.SectionNameSim);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.ParentNodeID, 8, convcc_Work.ParentNodeID);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.CourseChapterReferred, 10, convcc_Work.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.ParentNodeName, 50, convcc_Work.ParentNodeName);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.ParentNodeReferred, 10, convcc_Work.ParentNodeReferred);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.Creator, 18, convcc_Work.Creator);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.CreateDate, 20, convcc_Work.CreateDate);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.LimitedResourceType, 100, convcc_Work.LimitedResourceType);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.UpdDate, 20, convcc_Work.UpdDate);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.UpdUserId, 20, convcc_Work.UpdUserId);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.Memo, 1000, convcc_Work.Memo);
clsCheckSql.CheckFieldLen(objvcc_WorkEN.CourseId4Chapter, 8, convcc_Work.CourseId4Chapter);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.IdWork, convcc_Work.IdWork);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.WorkName, convcc_Work.WorkName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.CourseId, convcc_Work.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.CourseName, convcc_Work.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.CourseChapterId, convcc_Work.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.CourseChapterName, convcc_Work.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.ChapterName, convcc_Work.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.SectionName, convcc_Work.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.ChapterNameSim, convcc_Work.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.SectionNameSim, convcc_Work.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.ParentNodeID, convcc_Work.ParentNodeID);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.CourseChapterReferred, convcc_Work.CourseChapterReferred);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.ParentNodeName, convcc_Work.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.ParentNodeReferred, convcc_Work.ParentNodeReferred);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.Creator, convcc_Work.Creator);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.CreateDate, convcc_Work.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.LimitedResourceType, convcc_Work.LimitedResourceType);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.UpdDate, convcc_Work.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.UpdUserId, convcc_Work.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.Memo, convcc_Work.Memo);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEN.CourseId4Chapter, convcc_Work.CourseId4Chapter);
//检查外键字段长度
 objvcc_WorkEN._IsCheckProperty = true;
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
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
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
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
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
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_WorkEN._CurrTabName);
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
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_WorkEN._CurrTabName, strCondition);
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
 objSQL = clsvcc_WorkDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}