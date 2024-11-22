
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PConceptRelaDA
 表名:vgs_PConceptRela(01120668)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 论文概念关系视图(vgs_PConceptRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvgs_PConceptRelaDA : clsCommBase4DA
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
 return clsvgs_PConceptRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvgs_PConceptRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PConceptRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvgs_PConceptRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvgs_PConceptRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvgs_PConceptRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PConceptRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vgs_PConceptRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvgs_PConceptRelaDA: GetDataTable_vgs_PConceptRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PConceptRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvgs_PConceptRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvgs_PConceptRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PConceptRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvgs_PConceptRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvgs_PConceptRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PConceptRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PConceptRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvgs_PConceptRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vgs_PConceptRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvgs_PConceptRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_PConceptRela.* from vgs_PConceptRela Left Join {1} on {2} where {3} and vgs_PConceptRela.mId not in (Select top {5} vgs_PConceptRela.mId from vgs_PConceptRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PConceptRela where {1} and mId not in (Select top {2} mId from vgs_PConceptRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PConceptRela where {1} and mId not in (Select top {3} mId from vgs_PConceptRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvgs_PConceptRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_PConceptRela.* from vgs_PConceptRela Left Join {1} on {2} where {3} and vgs_PConceptRela.mId not in (Select top {5} vgs_PConceptRela.mId from vgs_PConceptRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PConceptRela where {1} and mId not in (Select top {2} mId from vgs_PConceptRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PConceptRela where {1} and mId not in (Select top {3} mId from vgs_PConceptRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvgs_PConceptRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvgs_PConceptRelaDA:GetObjLst)", objException.Message));
}
List<clsvgs_PConceptRelaEN> arrObjLst = new List<clsvgs_PConceptRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PConceptRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN();
try
{
objvgs_PConceptRelaEN.mId = TransNullToInt(objRow[convgs_PConceptRela.mId].ToString().Trim()); //mId
objvgs_PConceptRelaEN.PaperId = objRow[convgs_PConceptRela.PaperId].ToString().Trim(); //论文Id
objvgs_PConceptRelaEN.PaperTitle = objRow[convgs_PConceptRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PConceptRelaEN.PaperTypeId = objRow[convgs_PConceptRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PConceptRelaEN.SectionId = objRow[convgs_PConceptRela.SectionId] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionId].ToString().Trim(); //节Id
objvgs_PConceptRelaEN.SectionName = objRow[convgs_PConceptRela.SectionName] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionName].ToString().Trim(); //节名
objvgs_PConceptRelaEN.ConceptId = objRow[convgs_PConceptRela.ConceptId].ToString().Trim(); //概念Id
objvgs_PConceptRelaEN.ConceptName = objRow[convgs_PConceptRela.ConceptName] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptName].ToString().Trim(); //概念名称
objvgs_PConceptRelaEN.ConceptContent = objRow[convgs_PConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvgs_PConceptRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PConceptRelaEN.TeaScore = objRow[convgs_PConceptRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PConceptRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PConceptRelaEN.StuScore = objRow[convgs_PConceptRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PConceptRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PConceptRelaEN.Score = objRow[convgs_PConceptRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PConceptRela.Score].ToString().Trim()); //评分
objvgs_PConceptRelaEN.AppraiseCount = objRow[convgs_PConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PConceptRelaEN.OkCount = objRow[convgs_PConceptRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PConceptRelaEN.VersionCount = objRow[convgs_PConceptRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PConceptRelaEN.CitationCount = objRow[convgs_PConceptRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PConceptRelaEN.UpdDate = objRow[convgs_PConceptRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PConceptRelaEN.UpdUser = objRow[convgs_PConceptRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdUser].ToString().Trim(); //修改人
objvgs_PConceptRelaEN.Memo = objRow[convgs_PConceptRela.Memo] == DBNull.Value ? null : objRow[convgs_PConceptRela.Memo].ToString().Trim(); //备注
objvgs_PConceptRelaEN.ConcepUserId = objRow[convgs_PConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvgs_PConceptRelaEN.ConcepDate = objRow[convgs_PConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvgs_PConceptRelaEN.CreateDate = objRow[convgs_PConceptRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PConceptRelaEN.ShareId = objRow[convgs_PConceptRela.ShareId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_PConceptRelaDA: GetObjLst)", objException.Message));
}
objvgs_PConceptRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_PConceptRelaEN);
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
public List<clsvgs_PConceptRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvgs_PConceptRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvgs_PConceptRelaEN> arrObjLst = new List<clsvgs_PConceptRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN();
try
{
objvgs_PConceptRelaEN.mId = TransNullToInt(objRow[convgs_PConceptRela.mId].ToString().Trim()); //mId
objvgs_PConceptRelaEN.PaperId = objRow[convgs_PConceptRela.PaperId].ToString().Trim(); //论文Id
objvgs_PConceptRelaEN.PaperTitle = objRow[convgs_PConceptRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PConceptRelaEN.PaperTypeId = objRow[convgs_PConceptRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PConceptRelaEN.SectionId = objRow[convgs_PConceptRela.SectionId] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionId].ToString().Trim(); //节Id
objvgs_PConceptRelaEN.SectionName = objRow[convgs_PConceptRela.SectionName] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionName].ToString().Trim(); //节名
objvgs_PConceptRelaEN.ConceptId = objRow[convgs_PConceptRela.ConceptId].ToString().Trim(); //概念Id
objvgs_PConceptRelaEN.ConceptName = objRow[convgs_PConceptRela.ConceptName] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptName].ToString().Trim(); //概念名称
objvgs_PConceptRelaEN.ConceptContent = objRow[convgs_PConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvgs_PConceptRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PConceptRelaEN.TeaScore = objRow[convgs_PConceptRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PConceptRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PConceptRelaEN.StuScore = objRow[convgs_PConceptRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PConceptRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PConceptRelaEN.Score = objRow[convgs_PConceptRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PConceptRela.Score].ToString().Trim()); //评分
objvgs_PConceptRelaEN.AppraiseCount = objRow[convgs_PConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PConceptRelaEN.OkCount = objRow[convgs_PConceptRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PConceptRelaEN.VersionCount = objRow[convgs_PConceptRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PConceptRelaEN.CitationCount = objRow[convgs_PConceptRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PConceptRelaEN.UpdDate = objRow[convgs_PConceptRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PConceptRelaEN.UpdUser = objRow[convgs_PConceptRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdUser].ToString().Trim(); //修改人
objvgs_PConceptRelaEN.Memo = objRow[convgs_PConceptRela.Memo] == DBNull.Value ? null : objRow[convgs_PConceptRela.Memo].ToString().Trim(); //备注
objvgs_PConceptRelaEN.ConcepUserId = objRow[convgs_PConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvgs_PConceptRelaEN.ConcepDate = objRow[convgs_PConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvgs_PConceptRelaEN.CreateDate = objRow[convgs_PConceptRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PConceptRelaEN.ShareId = objRow[convgs_PConceptRela.ShareId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_PConceptRelaDA: GetObjLst)", objException.Message));
}
objvgs_PConceptRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_PConceptRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvgs_PConceptRela(ref clsvgs_PConceptRelaEN objvgs_PConceptRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PConceptRela where mId = " + ""+ objvgs_PConceptRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvgs_PConceptRelaEN.mId = TransNullToInt(objDT.Rows[0][convgs_PConceptRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvgs_PConceptRelaEN.PaperId = objDT.Rows[0][convgs_PConceptRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PConceptRelaEN.PaperTitle = objDT.Rows[0][convgs_PConceptRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_PConceptRelaEN.PaperTypeId = objDT.Rows[0][convgs_PConceptRela.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PConceptRelaEN.SectionId = objDT.Rows[0][convgs_PConceptRela.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PConceptRelaEN.SectionName = objDT.Rows[0][convgs_PConceptRela.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PConceptRelaEN.ConceptId = objDT.Rows[0][convgs_PConceptRela.ConceptId].ToString().Trim(); //概念Id(字段类型:char,字段长度:8,是否可空:False)
 objvgs_PConceptRelaEN.ConceptName = objDT.Rows[0][convgs_PConceptRela.ConceptName].ToString().Trim(); //概念名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_PConceptRelaEN.ConceptContent = objDT.Rows[0][convgs_PConceptRela.ConceptContent].ToString().Trim(); //概念内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PConceptRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][convgs_PConceptRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PConceptRelaEN.TeaScore = TransNullToFloat(objDT.Rows[0][convgs_PConceptRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PConceptRelaEN.StuScore = TransNullToFloat(objDT.Rows[0][convgs_PConceptRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PConceptRelaEN.Score = TransNullToFloat(objDT.Rows[0][convgs_PConceptRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PConceptRelaEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convgs_PConceptRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PConceptRelaEN.OkCount = TransNullToInt(objDT.Rows[0][convgs_PConceptRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PConceptRelaEN.VersionCount = TransNullToInt(objDT.Rows[0][convgs_PConceptRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PConceptRelaEN.CitationCount = TransNullToInt(objDT.Rows[0][convgs_PConceptRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PConceptRelaEN.UpdDate = objDT.Rows[0][convgs_PConceptRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PConceptRelaEN.UpdUser = objDT.Rows[0][convgs_PConceptRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PConceptRelaEN.Memo = objDT.Rows[0][convgs_PConceptRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PConceptRelaEN.ConcepUserId = objDT.Rows[0][convgs_PConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PConceptRelaEN.ConcepDate = objDT.Rows[0][convgs_PConceptRela.ConcepDate].ToString().Trim(); //ConcepDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PConceptRelaEN.CreateDate = objDT.Rows[0][convgs_PConceptRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PConceptRelaEN.ShareId = objDT.Rows[0][convgs_PConceptRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvgs_PConceptRelaDA: Getvgs_PConceptRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvgs_PConceptRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PConceptRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN();
try
{
 objvgs_PConceptRelaEN.mId = Int32.Parse(objRow[convgs_PConceptRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvgs_PConceptRelaEN.PaperId = objRow[convgs_PConceptRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PConceptRelaEN.PaperTitle = objRow[convgs_PConceptRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_PConceptRelaEN.PaperTypeId = objRow[convgs_PConceptRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PConceptRelaEN.SectionId = objRow[convgs_PConceptRela.SectionId] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PConceptRelaEN.SectionName = objRow[convgs_PConceptRela.SectionName] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PConceptRelaEN.ConceptId = objRow[convgs_PConceptRela.ConceptId].ToString().Trim(); //概念Id(字段类型:char,字段长度:8,是否可空:False)
 objvgs_PConceptRelaEN.ConceptName = objRow[convgs_PConceptRela.ConceptName] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptName].ToString().Trim(); //概念名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_PConceptRelaEN.ConceptContent = objRow[convgs_PConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptContent].ToString().Trim(); //概念内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PConceptRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PConceptRelaEN.TeaScore = objRow[convgs_PConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PConceptRelaEN.StuScore = objRow[convgs_PConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PConceptRelaEN.Score = objRow[convgs_PConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PConceptRelaEN.AppraiseCount = objRow[convgs_PConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PConceptRelaEN.OkCount = objRow[convgs_PConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PConceptRelaEN.VersionCount = objRow[convgs_PConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PConceptRelaEN.CitationCount = objRow[convgs_PConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PConceptRelaEN.UpdDate = objRow[convgs_PConceptRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PConceptRelaEN.UpdUser = objRow[convgs_PConceptRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PConceptRelaEN.Memo = objRow[convgs_PConceptRela.Memo] == DBNull.Value ? null : objRow[convgs_PConceptRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PConceptRelaEN.ConcepUserId = objRow[convgs_PConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PConceptRelaEN.ConcepDate = objRow[convgs_PConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepDate].ToString().Trim(); //ConcepDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PConceptRelaEN.CreateDate = objRow[convgs_PConceptRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PConceptRelaEN.ShareId = objRow[convgs_PConceptRela.ShareId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvgs_PConceptRelaDA: GetObjBymId)", objException.Message));
}
return objvgs_PConceptRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvgs_PConceptRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvgs_PConceptRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PConceptRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN()
{
mId = TransNullToInt(objRow[convgs_PConceptRela.mId].ToString().Trim()), //mId
PaperId = objRow[convgs_PConceptRela.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[convgs_PConceptRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTitle].ToString().Trim(), //论文标题
PaperTypeId = objRow[convgs_PConceptRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTypeId].ToString().Trim(), //论文类型Id
SectionId = objRow[convgs_PConceptRela.SectionId] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionId].ToString().Trim(), //节Id
SectionName = objRow[convgs_PConceptRela.SectionName] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionName].ToString().Trim(), //节名
ConceptId = objRow[convgs_PConceptRela.ConceptId].ToString().Trim(), //概念Id
ConceptName = objRow[convgs_PConceptRela.ConceptName] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptName].ToString().Trim(), //概念名称
ConceptContent = objRow[convgs_PConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptContent].ToString().Trim(), //概念内容
IsSubmit = TransNullToBool(objRow[convgs_PConceptRela.IsSubmit].ToString().Trim()), //是否提交
TeaScore = objRow[convgs_PConceptRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PConceptRela.TeaScore].ToString().Trim()), //教师评分
StuScore = objRow[convgs_PConceptRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PConceptRela.StuScore].ToString().Trim()), //学生平均分
Score = objRow[convgs_PConceptRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PConceptRela.Score].ToString().Trim()), //评分
AppraiseCount = objRow[convgs_PConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.AppraiseCount].ToString().Trim()), //评论数
OkCount = objRow[convgs_PConceptRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.OkCount].ToString().Trim()), //点赞统计
VersionCount = objRow[convgs_PConceptRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.VersionCount].ToString().Trim()), //版本统计
CitationCount = objRow[convgs_PConceptRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.CitationCount].ToString().Trim()), //引用统计
UpdDate = objRow[convgs_PConceptRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convgs_PConceptRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convgs_PConceptRela.Memo] == DBNull.Value ? null : objRow[convgs_PConceptRela.Memo].ToString().Trim(), //备注
ConcepUserId = objRow[convgs_PConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepUserId].ToString().Trim(), //ConcepUserId
ConcepDate = objRow[convgs_PConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepDate].ToString().Trim(), //ConcepDate
CreateDate = objRow[convgs_PConceptRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convgs_PConceptRela.ShareId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ShareId].ToString().Trim() //分享Id
};
objvgs_PConceptRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PConceptRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvgs_PConceptRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvgs_PConceptRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN();
try
{
objvgs_PConceptRelaEN.mId = TransNullToInt(objRow[convgs_PConceptRela.mId].ToString().Trim()); //mId
objvgs_PConceptRelaEN.PaperId = objRow[convgs_PConceptRela.PaperId].ToString().Trim(); //论文Id
objvgs_PConceptRelaEN.PaperTitle = objRow[convgs_PConceptRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PConceptRelaEN.PaperTypeId = objRow[convgs_PConceptRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PConceptRelaEN.SectionId = objRow[convgs_PConceptRela.SectionId] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionId].ToString().Trim(); //节Id
objvgs_PConceptRelaEN.SectionName = objRow[convgs_PConceptRela.SectionName] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionName].ToString().Trim(); //节名
objvgs_PConceptRelaEN.ConceptId = objRow[convgs_PConceptRela.ConceptId].ToString().Trim(); //概念Id
objvgs_PConceptRelaEN.ConceptName = objRow[convgs_PConceptRela.ConceptName] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptName].ToString().Trim(); //概念名称
objvgs_PConceptRelaEN.ConceptContent = objRow[convgs_PConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvgs_PConceptRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PConceptRelaEN.TeaScore = objRow[convgs_PConceptRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PConceptRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PConceptRelaEN.StuScore = objRow[convgs_PConceptRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PConceptRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PConceptRelaEN.Score = objRow[convgs_PConceptRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PConceptRela.Score].ToString().Trim()); //评分
objvgs_PConceptRelaEN.AppraiseCount = objRow[convgs_PConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PConceptRelaEN.OkCount = objRow[convgs_PConceptRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PConceptRelaEN.VersionCount = objRow[convgs_PConceptRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PConceptRelaEN.CitationCount = objRow[convgs_PConceptRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PConceptRelaEN.UpdDate = objRow[convgs_PConceptRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PConceptRelaEN.UpdUser = objRow[convgs_PConceptRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdUser].ToString().Trim(); //修改人
objvgs_PConceptRelaEN.Memo = objRow[convgs_PConceptRela.Memo] == DBNull.Value ? null : objRow[convgs_PConceptRela.Memo].ToString().Trim(); //备注
objvgs_PConceptRelaEN.ConcepUserId = objRow[convgs_PConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvgs_PConceptRelaEN.ConcepDate = objRow[convgs_PConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvgs_PConceptRelaEN.CreateDate = objRow[convgs_PConceptRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PConceptRelaEN.ShareId = objRow[convgs_PConceptRela.ShareId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvgs_PConceptRelaDA: GetObjByDataRowvgs_PConceptRela)", objException.Message));
}
objvgs_PConceptRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PConceptRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvgs_PConceptRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN();
try
{
objvgs_PConceptRelaEN.mId = TransNullToInt(objRow[convgs_PConceptRela.mId].ToString().Trim()); //mId
objvgs_PConceptRelaEN.PaperId = objRow[convgs_PConceptRela.PaperId].ToString().Trim(); //论文Id
objvgs_PConceptRelaEN.PaperTitle = objRow[convgs_PConceptRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PConceptRelaEN.PaperTypeId = objRow[convgs_PConceptRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PConceptRelaEN.SectionId = objRow[convgs_PConceptRela.SectionId] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionId].ToString().Trim(); //节Id
objvgs_PConceptRelaEN.SectionName = objRow[convgs_PConceptRela.SectionName] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionName].ToString().Trim(); //节名
objvgs_PConceptRelaEN.ConceptId = objRow[convgs_PConceptRela.ConceptId].ToString().Trim(); //概念Id
objvgs_PConceptRelaEN.ConceptName = objRow[convgs_PConceptRela.ConceptName] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptName].ToString().Trim(); //概念名称
objvgs_PConceptRelaEN.ConceptContent = objRow[convgs_PConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvgs_PConceptRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PConceptRelaEN.TeaScore = objRow[convgs_PConceptRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PConceptRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PConceptRelaEN.StuScore = objRow[convgs_PConceptRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PConceptRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PConceptRelaEN.Score = objRow[convgs_PConceptRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PConceptRela.Score].ToString().Trim()); //评分
objvgs_PConceptRelaEN.AppraiseCount = objRow[convgs_PConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PConceptRelaEN.OkCount = objRow[convgs_PConceptRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PConceptRelaEN.VersionCount = objRow[convgs_PConceptRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PConceptRelaEN.CitationCount = objRow[convgs_PConceptRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PConceptRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PConceptRelaEN.UpdDate = objRow[convgs_PConceptRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PConceptRelaEN.UpdUser = objRow[convgs_PConceptRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdUser].ToString().Trim(); //修改人
objvgs_PConceptRelaEN.Memo = objRow[convgs_PConceptRela.Memo] == DBNull.Value ? null : objRow[convgs_PConceptRela.Memo].ToString().Trim(); //备注
objvgs_PConceptRelaEN.ConcepUserId = objRow[convgs_PConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvgs_PConceptRelaEN.ConcepDate = objRow[convgs_PConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvgs_PConceptRelaEN.CreateDate = objRow[convgs_PConceptRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PConceptRelaEN.ShareId = objRow[convgs_PConceptRela.ShareId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvgs_PConceptRelaDA: GetObjByDataRow)", objException.Message));
}
objvgs_PConceptRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PConceptRelaEN;
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
objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_PConceptRelaEN._CurrTabName, convgs_PConceptRela.mId, 8, "");
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
objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_PConceptRelaEN._CurrTabName, convgs_PConceptRela.mId, 8, strPrefix);
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
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vgs_PConceptRela where " + strCondition;
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
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vgs_PConceptRela where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_PConceptRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvgs_PConceptRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_PConceptRela", strCondition))
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
objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vgs_PConceptRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaENS">源对象</param>
 /// <param name = "objvgs_PConceptRelaENT">目标对象</param>
public void CopyTo(clsvgs_PConceptRelaEN objvgs_PConceptRelaENS, clsvgs_PConceptRelaEN objvgs_PConceptRelaENT)
{
objvgs_PConceptRelaENT.mId = objvgs_PConceptRelaENS.mId; //mId
objvgs_PConceptRelaENT.PaperId = objvgs_PConceptRelaENS.PaperId; //论文Id
objvgs_PConceptRelaENT.PaperTitle = objvgs_PConceptRelaENS.PaperTitle; //论文标题
objvgs_PConceptRelaENT.PaperTypeId = objvgs_PConceptRelaENS.PaperTypeId; //论文类型Id
objvgs_PConceptRelaENT.SectionId = objvgs_PConceptRelaENS.SectionId; //节Id
objvgs_PConceptRelaENT.SectionName = objvgs_PConceptRelaENS.SectionName; //节名
objvgs_PConceptRelaENT.ConceptId = objvgs_PConceptRelaENS.ConceptId; //概念Id
objvgs_PConceptRelaENT.ConceptName = objvgs_PConceptRelaENS.ConceptName; //概念名称
objvgs_PConceptRelaENT.ConceptContent = objvgs_PConceptRelaENS.ConceptContent; //概念内容
objvgs_PConceptRelaENT.IsSubmit = objvgs_PConceptRelaENS.IsSubmit; //是否提交
objvgs_PConceptRelaENT.TeaScore = objvgs_PConceptRelaENS.TeaScore; //教师评分
objvgs_PConceptRelaENT.StuScore = objvgs_PConceptRelaENS.StuScore; //学生平均分
objvgs_PConceptRelaENT.Score = objvgs_PConceptRelaENS.Score; //评分
objvgs_PConceptRelaENT.AppraiseCount = objvgs_PConceptRelaENS.AppraiseCount; //评论数
objvgs_PConceptRelaENT.OkCount = objvgs_PConceptRelaENS.OkCount; //点赞统计
objvgs_PConceptRelaENT.VersionCount = objvgs_PConceptRelaENS.VersionCount; //版本统计
objvgs_PConceptRelaENT.CitationCount = objvgs_PConceptRelaENS.CitationCount; //引用统计
objvgs_PConceptRelaENT.UpdDate = objvgs_PConceptRelaENS.UpdDate; //修改日期
objvgs_PConceptRelaENT.UpdUser = objvgs_PConceptRelaENS.UpdUser; //修改人
objvgs_PConceptRelaENT.Memo = objvgs_PConceptRelaENS.Memo; //备注
objvgs_PConceptRelaENT.ConcepUserId = objvgs_PConceptRelaENS.ConcepUserId; //ConcepUserId
objvgs_PConceptRelaENT.ConcepDate = objvgs_PConceptRelaENS.ConcepDate; //ConcepDate
objvgs_PConceptRelaENT.CreateDate = objvgs_PConceptRelaENS.CreateDate; //建立日期
objvgs_PConceptRelaENT.ShareId = objvgs_PConceptRelaENS.ShareId; //分享Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvgs_PConceptRelaEN objvgs_PConceptRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvgs_PConceptRelaEN.PaperId, 8, convgs_PConceptRela.PaperId);
clsCheckSql.CheckFieldLen(objvgs_PConceptRelaEN.PaperTitle, 500, convgs_PConceptRela.PaperTitle);
clsCheckSql.CheckFieldLen(objvgs_PConceptRelaEN.PaperTypeId, 2, convgs_PConceptRela.PaperTypeId);
clsCheckSql.CheckFieldLen(objvgs_PConceptRelaEN.SectionId, 8, convgs_PConceptRela.SectionId);
clsCheckSql.CheckFieldLen(objvgs_PConceptRelaEN.SectionName, 100, convgs_PConceptRela.SectionName);
clsCheckSql.CheckFieldLen(objvgs_PConceptRelaEN.ConceptId, 8, convgs_PConceptRela.ConceptId);
clsCheckSql.CheckFieldLen(objvgs_PConceptRelaEN.ConceptName, 500, convgs_PConceptRela.ConceptName);
clsCheckSql.CheckFieldLen(objvgs_PConceptRelaEN.UpdDate, 20, convgs_PConceptRela.UpdDate);
clsCheckSql.CheckFieldLen(objvgs_PConceptRelaEN.UpdUser, 20, convgs_PConceptRela.UpdUser);
clsCheckSql.CheckFieldLen(objvgs_PConceptRelaEN.Memo, 1000, convgs_PConceptRela.Memo);
clsCheckSql.CheckFieldLen(objvgs_PConceptRelaEN.ConcepUserId, 50, convgs_PConceptRela.ConcepUserId);
clsCheckSql.CheckFieldLen(objvgs_PConceptRelaEN.ConcepDate, 20, convgs_PConceptRela.ConcepDate);
clsCheckSql.CheckFieldLen(objvgs_PConceptRelaEN.CreateDate, 20, convgs_PConceptRela.CreateDate);
clsCheckSql.CheckFieldLen(objvgs_PConceptRelaEN.ShareId, 2, convgs_PConceptRela.ShareId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvgs_PConceptRelaEN.PaperId, convgs_PConceptRela.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PConceptRelaEN.PaperTitle, convgs_PConceptRela.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvgs_PConceptRelaEN.PaperTypeId, convgs_PConceptRela.PaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PConceptRelaEN.SectionId, convgs_PConceptRela.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PConceptRelaEN.SectionName, convgs_PConceptRela.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PConceptRelaEN.ConceptId, convgs_PConceptRela.ConceptId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PConceptRelaEN.ConceptName, convgs_PConceptRela.ConceptName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PConceptRelaEN.UpdDate, convgs_PConceptRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PConceptRelaEN.UpdUser, convgs_PConceptRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_PConceptRelaEN.Memo, convgs_PConceptRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvgs_PConceptRelaEN.ConcepUserId, convgs_PConceptRela.ConcepUserId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PConceptRelaEN.ConcepDate, convgs_PConceptRela.ConcepDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PConceptRelaEN.CreateDate, convgs_PConceptRela.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PConceptRelaEN.ShareId, convgs_PConceptRela.ShareId);
//检查外键字段长度
 objvgs_PConceptRelaEN._IsCheckProperty = true;
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
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_PConceptRelaEN._CurrTabName);
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
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_PConceptRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvgs_PConceptRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}