
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsBigConceptDA
 表名:BigConcept(01120972)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:22
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:大概念教学(BigConceptTeaching)
 框架-层名:数据处理层(CS)(DALCode,0002)
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
 /// 大概念(BigConcept)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsBigConceptDA : clsCommBase4DA
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
 return clsBigConceptEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsBigConceptEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsBigConceptEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsBigConceptEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsBigConceptEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdBigConcept">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdBigConcept)
{
strIdBigConcept = strIdBigConcept.Replace("'", "''");
if (strIdBigConcept.Length > 8)
{
throw new Exception("(errid:Data000001)在表:BigConcept中,检查关键字,长度不正确!(clsBigConceptDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdBigConcept)  ==  true)
{
throw new Exception("(errid:Data000002)在表:BigConcept中,关键字不能为空 或 null!(clsBigConceptDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdBigConcept);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsBigConceptDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsBigConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
strSQL = "Select * from BigConcept where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_BigConcept(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsBigConceptDA: GetDataTable_BigConcept)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
strSQL = "Select * from BigConcept where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsBigConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsBigConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
strSQL = "Select * from BigConcept where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsBigConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsBigConceptDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from BigConcept where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from BigConcept where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsBigConceptDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from BigConcept where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsBigConceptDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} BigConcept.* from BigConcept Left Join {1} on {2} where {3} and BigConcept.IdBigConcept not in (Select top {5} BigConcept.IdBigConcept from BigConcept Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from BigConcept where {1} and IdBigConcept not in (Select top {2} IdBigConcept from BigConcept where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from BigConcept where {1} and IdBigConcept not in (Select top {3} IdBigConcept from BigConcept where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsBigConceptDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} BigConcept.* from BigConcept Left Join {1} on {2} where {3} and BigConcept.IdBigConcept not in (Select top {5} BigConcept.IdBigConcept from BigConcept Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from BigConcept where {1} and IdBigConcept not in (Select top {2} IdBigConcept from BigConcept where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from BigConcept where {1} and IdBigConcept not in (Select top {3} IdBigConcept from BigConcept where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsBigConceptEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsBigConceptDA:GetObjLst)", objException.Message));
}
List<clsBigConceptEN> arrObjLst = new List<clsBigConceptEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
strSQL = "Select * from BigConcept where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsBigConceptEN objBigConceptEN = new clsBigConceptEN();
try
{
objBigConceptEN.IdBigConcept = objRow[conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号
objBigConceptEN.BigConceptId = objRow[conBigConcept.BigConceptId].ToString().Trim(); //大概念编号
objBigConceptEN.BigConceptName = objRow[conBigConcept.BigConceptName].ToString().Trim(); //大概念名称
objBigConceptEN.IdGrade = objRow[conBigConcept.IdGrade].ToString().Trim(); //年级流水号
objBigConceptEN.SchoolTerm = objRow[conBigConcept.SchoolTerm].ToString().Trim(); //学期
objBigConceptEN.CourseId = objRow[conBigConcept.CourseId].ToString().Trim(); //课程Id
objBigConceptEN.IsClgCheck = TransNullToBool(objRow[conBigConcept.IsClgCheck].ToString().Trim()); //是否学院审批
objBigConceptEN.ClgNote = objRow[conBigConcept.ClgNote] == DBNull.Value ? null : objRow[conBigConcept.ClgNote].ToString().Trim(); //学院审批意见
objBigConceptEN.ClgCheckerId = objRow[conBigConcept.ClgCheckerId] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id
objBigConceptEN.ClgCheckDate = objRow[conBigConcept.ClgCheckDate] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期
objBigConceptEN.IsSchCheck = TransNullToBool(objRow[conBigConcept.IsSchCheck].ToString().Trim()); //是否学校审批
objBigConceptEN.SchNote = objRow[conBigConcept.SchNote] == DBNull.Value ? null : objRow[conBigConcept.SchNote].ToString().Trim(); //学校审批意见
objBigConceptEN.SchCheckerId = objRow[conBigConcept.SchCheckerId] == DBNull.Value ? null : objRow[conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id
objBigConceptEN.SchCheckDate = objRow[conBigConcept.SchCheckDate] == DBNull.Value ? null : objRow[conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期
objBigConceptEN.IdSubmitStatus = objRow[conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objBigConceptEN.Memo = objRow[conBigConcept.Memo] == DBNull.Value ? null : objRow[conBigConcept.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsBigConceptDA: GetObjLst)", objException.Message));
}
objBigConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objBigConceptEN);
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
public List<clsBigConceptEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsBigConceptDA:GetObjLstByTabName)", objException.Message));
}
List<clsBigConceptEN> arrObjLst = new List<clsBigConceptEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsBigConceptEN objBigConceptEN = new clsBigConceptEN();
try
{
objBigConceptEN.IdBigConcept = objRow[conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号
objBigConceptEN.BigConceptId = objRow[conBigConcept.BigConceptId].ToString().Trim(); //大概念编号
objBigConceptEN.BigConceptName = objRow[conBigConcept.BigConceptName].ToString().Trim(); //大概念名称
objBigConceptEN.IdGrade = objRow[conBigConcept.IdGrade].ToString().Trim(); //年级流水号
objBigConceptEN.SchoolTerm = objRow[conBigConcept.SchoolTerm].ToString().Trim(); //学期
objBigConceptEN.CourseId = objRow[conBigConcept.CourseId].ToString().Trim(); //课程Id
objBigConceptEN.IsClgCheck = TransNullToBool(objRow[conBigConcept.IsClgCheck].ToString().Trim()); //是否学院审批
objBigConceptEN.ClgNote = objRow[conBigConcept.ClgNote] == DBNull.Value ? null : objRow[conBigConcept.ClgNote].ToString().Trim(); //学院审批意见
objBigConceptEN.ClgCheckerId = objRow[conBigConcept.ClgCheckerId] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id
objBigConceptEN.ClgCheckDate = objRow[conBigConcept.ClgCheckDate] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期
objBigConceptEN.IsSchCheck = TransNullToBool(objRow[conBigConcept.IsSchCheck].ToString().Trim()); //是否学校审批
objBigConceptEN.SchNote = objRow[conBigConcept.SchNote] == DBNull.Value ? null : objRow[conBigConcept.SchNote].ToString().Trim(); //学校审批意见
objBigConceptEN.SchCheckerId = objRow[conBigConcept.SchCheckerId] == DBNull.Value ? null : objRow[conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id
objBigConceptEN.SchCheckDate = objRow[conBigConcept.SchCheckDate] == DBNull.Value ? null : objRow[conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期
objBigConceptEN.IdSubmitStatus = objRow[conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objBigConceptEN.Memo = objRow[conBigConcept.Memo] == DBNull.Value ? null : objRow[conBigConcept.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsBigConceptDA: GetObjLst)", objException.Message));
}
objBigConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objBigConceptEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objBigConceptEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetBigConcept(ref clsBigConceptEN objBigConceptEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
strSQL = "Select * from BigConcept where IdBigConcept = " + "'"+ objBigConceptEN.IdBigConcept+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objBigConceptEN.IdBigConcept = objDT.Rows[0][conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号(字段类型:char,字段长度:8,是否可空:False)
 objBigConceptEN.BigConceptId = objDT.Rows[0][conBigConcept.BigConceptId].ToString().Trim(); //大概念编号(字段类型:char,字段长度:12,是否可空:True)
 objBigConceptEN.BigConceptName = objDT.Rows[0][conBigConcept.BigConceptName].ToString().Trim(); //大概念名称(字段类型:varchar,字段长度:100,是否可空:True)
 objBigConceptEN.IdGrade = objDT.Rows[0][conBigConcept.IdGrade].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:False)
 objBigConceptEN.SchoolTerm = objDT.Rows[0][conBigConcept.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objBigConceptEN.CourseId = objDT.Rows[0][conBigConcept.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objBigConceptEN.IsClgCheck = TransNullToBool(objDT.Rows[0][conBigConcept.IsClgCheck].ToString().Trim()); //是否学院审批(字段类型:bit,字段长度:1,是否可空:True)
 objBigConceptEN.ClgNote = objDT.Rows[0][conBigConcept.ClgNote].ToString().Trim(); //学院审批意见(字段类型:text,字段长度:2147483647,是否可空:True)
 objBigConceptEN.ClgCheckerId = objDT.Rows[0][conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id(字段类型:varchar,字段长度:18,是否可空:True)
 objBigConceptEN.ClgCheckDate = objDT.Rows[0][conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期(字段类型:char,字段长度:8,是否可空:True)
 objBigConceptEN.IsSchCheck = TransNullToBool(objDT.Rows[0][conBigConcept.IsSchCheck].ToString().Trim()); //是否学校审批(字段类型:bit,字段长度:1,是否可空:True)
 objBigConceptEN.SchNote = objDT.Rows[0][conBigConcept.SchNote].ToString().Trim(); //学校审批意见(字段类型:text,字段长度:16,是否可空:True)
 objBigConceptEN.SchCheckerId = objDT.Rows[0][conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id(字段类型:varchar,字段长度:18,是否可空:True)
 objBigConceptEN.SchCheckDate = objDT.Rows[0][conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期(字段类型:char,字段长度:8,是否可空:True)
 objBigConceptEN.IdSubmitStatus = objDT.Rows[0][conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号(字段类型:char,字段长度:2,是否可空:False)
 objBigConceptEN.Memo = objDT.Rows[0][conBigConcept.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsBigConceptDA: GetBigConcept)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdBigConcept">表关键字</param>
 /// <returns>表对象</returns>
public clsBigConceptEN GetObjByIdBigConcept(string strIdBigConcept)
{
CheckPrimaryKey(strIdBigConcept);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
strSQL = "Select * from BigConcept where IdBigConcept = " + "'"+ strIdBigConcept+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsBigConceptEN objBigConceptEN = new clsBigConceptEN();
try
{
 objBigConceptEN.IdBigConcept = objRow[conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号(字段类型:char,字段长度:8,是否可空:False)
 objBigConceptEN.BigConceptId = objRow[conBigConcept.BigConceptId].ToString().Trim(); //大概念编号(字段类型:char,字段长度:12,是否可空:True)
 objBigConceptEN.BigConceptName = objRow[conBigConcept.BigConceptName].ToString().Trim(); //大概念名称(字段类型:varchar,字段长度:100,是否可空:True)
 objBigConceptEN.IdGrade = objRow[conBigConcept.IdGrade].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:False)
 objBigConceptEN.SchoolTerm = objRow[conBigConcept.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objBigConceptEN.CourseId = objRow[conBigConcept.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objBigConceptEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsClgCheck].ToString().Trim()); //是否学院审批(字段类型:bit,字段长度:1,是否可空:True)
 objBigConceptEN.ClgNote = objRow[conBigConcept.ClgNote] == DBNull.Value ? null : objRow[conBigConcept.ClgNote].ToString().Trim(); //学院审批意见(字段类型:text,字段长度:2147483647,是否可空:True)
 objBigConceptEN.ClgCheckerId = objRow[conBigConcept.ClgCheckerId] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id(字段类型:varchar,字段长度:18,是否可空:True)
 objBigConceptEN.ClgCheckDate = objRow[conBigConcept.ClgCheckDate] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期(字段类型:char,字段长度:8,是否可空:True)
 objBigConceptEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsSchCheck].ToString().Trim()); //是否学校审批(字段类型:bit,字段长度:1,是否可空:True)
 objBigConceptEN.SchNote = objRow[conBigConcept.SchNote] == DBNull.Value ? null : objRow[conBigConcept.SchNote].ToString().Trim(); //学校审批意见(字段类型:text,字段长度:16,是否可空:True)
 objBigConceptEN.SchCheckerId = objRow[conBigConcept.SchCheckerId] == DBNull.Value ? null : objRow[conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id(字段类型:varchar,字段长度:18,是否可空:True)
 objBigConceptEN.SchCheckDate = objRow[conBigConcept.SchCheckDate] == DBNull.Value ? null : objRow[conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期(字段类型:char,字段长度:8,是否可空:True)
 objBigConceptEN.IdSubmitStatus = objRow[conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号(字段类型:char,字段长度:2,是否可空:False)
 objBigConceptEN.Memo = objRow[conBigConcept.Memo] == DBNull.Value ? null : objRow[conBigConcept.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsBigConceptDA: GetObjByIdBigConcept)", objException.Message));
}
return objBigConceptEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsBigConceptEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsBigConceptDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
strSQL = "Select * from BigConcept where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsBigConceptEN objBigConceptEN = new clsBigConceptEN()
{
IdBigConcept = objRow[conBigConcept.IdBigConcept].ToString().Trim(), //大概念流水号
BigConceptId = objRow[conBigConcept.BigConceptId].ToString().Trim(), //大概念编号
BigConceptName = objRow[conBigConcept.BigConceptName].ToString().Trim(), //大概念名称
IdGrade = objRow[conBigConcept.IdGrade].ToString().Trim(), //年级流水号
SchoolTerm = objRow[conBigConcept.SchoolTerm].ToString().Trim(), //学期
CourseId = objRow[conBigConcept.CourseId].ToString().Trim(), //课程Id
IsClgCheck = TransNullToBool(objRow[conBigConcept.IsClgCheck].ToString().Trim()), //是否学院审批
ClgNote = objRow[conBigConcept.ClgNote] == DBNull.Value ? null : objRow[conBigConcept.ClgNote].ToString().Trim(), //学院审批意见
ClgCheckerId = objRow[conBigConcept.ClgCheckerId] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckerId].ToString().Trim(), //学院审批人id
ClgCheckDate = objRow[conBigConcept.ClgCheckDate] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckDate].ToString().Trim(), //学院审批日期
IsSchCheck = TransNullToBool(objRow[conBigConcept.IsSchCheck].ToString().Trim()), //是否学校审批
SchNote = objRow[conBigConcept.SchNote] == DBNull.Value ? null : objRow[conBigConcept.SchNote].ToString().Trim(), //学校审批意见
SchCheckerId = objRow[conBigConcept.SchCheckerId] == DBNull.Value ? null : objRow[conBigConcept.SchCheckerId].ToString().Trim(), //学校审批人Id
SchCheckDate = objRow[conBigConcept.SchCheckDate] == DBNull.Value ? null : objRow[conBigConcept.SchCheckDate].ToString().Trim(), //学校审批日期
IdSubmitStatus = objRow[conBigConcept.IdSubmitStatus].ToString().Trim(), //送审状态流水号
Memo = objRow[conBigConcept.Memo] == DBNull.Value ? null : objRow[conBigConcept.Memo].ToString().Trim() //备注
};
objBigConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objBigConceptEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsBigConceptDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsBigConceptEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsBigConceptEN objBigConceptEN = new clsBigConceptEN();
try
{
objBigConceptEN.IdBigConcept = objRow[conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号
objBigConceptEN.BigConceptId = objRow[conBigConcept.BigConceptId].ToString().Trim(); //大概念编号
objBigConceptEN.BigConceptName = objRow[conBigConcept.BigConceptName].ToString().Trim(); //大概念名称
objBigConceptEN.IdGrade = objRow[conBigConcept.IdGrade].ToString().Trim(); //年级流水号
objBigConceptEN.SchoolTerm = objRow[conBigConcept.SchoolTerm].ToString().Trim(); //学期
objBigConceptEN.CourseId = objRow[conBigConcept.CourseId].ToString().Trim(); //课程Id
objBigConceptEN.IsClgCheck = TransNullToBool(objRow[conBigConcept.IsClgCheck].ToString().Trim()); //是否学院审批
objBigConceptEN.ClgNote = objRow[conBigConcept.ClgNote] == DBNull.Value ? null : objRow[conBigConcept.ClgNote].ToString().Trim(); //学院审批意见
objBigConceptEN.ClgCheckerId = objRow[conBigConcept.ClgCheckerId] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id
objBigConceptEN.ClgCheckDate = objRow[conBigConcept.ClgCheckDate] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期
objBigConceptEN.IsSchCheck = TransNullToBool(objRow[conBigConcept.IsSchCheck].ToString().Trim()); //是否学校审批
objBigConceptEN.SchNote = objRow[conBigConcept.SchNote] == DBNull.Value ? null : objRow[conBigConcept.SchNote].ToString().Trim(); //学校审批意见
objBigConceptEN.SchCheckerId = objRow[conBigConcept.SchCheckerId] == DBNull.Value ? null : objRow[conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id
objBigConceptEN.SchCheckDate = objRow[conBigConcept.SchCheckDate] == DBNull.Value ? null : objRow[conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期
objBigConceptEN.IdSubmitStatus = objRow[conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objBigConceptEN.Memo = objRow[conBigConcept.Memo] == DBNull.Value ? null : objRow[conBigConcept.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsBigConceptDA: GetObjByDataRowBigConcept)", objException.Message));
}
objBigConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objBigConceptEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsBigConceptEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsBigConceptEN objBigConceptEN = new clsBigConceptEN();
try
{
objBigConceptEN.IdBigConcept = objRow[conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号
objBigConceptEN.BigConceptId = objRow[conBigConcept.BigConceptId].ToString().Trim(); //大概念编号
objBigConceptEN.BigConceptName = objRow[conBigConcept.BigConceptName].ToString().Trim(); //大概念名称
objBigConceptEN.IdGrade = objRow[conBigConcept.IdGrade].ToString().Trim(); //年级流水号
objBigConceptEN.SchoolTerm = objRow[conBigConcept.SchoolTerm].ToString().Trim(); //学期
objBigConceptEN.CourseId = objRow[conBigConcept.CourseId].ToString().Trim(); //课程Id
objBigConceptEN.IsClgCheck = TransNullToBool(objRow[conBigConcept.IsClgCheck].ToString().Trim()); //是否学院审批
objBigConceptEN.ClgNote = objRow[conBigConcept.ClgNote] == DBNull.Value ? null : objRow[conBigConcept.ClgNote].ToString().Trim(); //学院审批意见
objBigConceptEN.ClgCheckerId = objRow[conBigConcept.ClgCheckerId] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id
objBigConceptEN.ClgCheckDate = objRow[conBigConcept.ClgCheckDate] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期
objBigConceptEN.IsSchCheck = TransNullToBool(objRow[conBigConcept.IsSchCheck].ToString().Trim()); //是否学校审批
objBigConceptEN.SchNote = objRow[conBigConcept.SchNote] == DBNull.Value ? null : objRow[conBigConcept.SchNote].ToString().Trim(); //学校审批意见
objBigConceptEN.SchCheckerId = objRow[conBigConcept.SchCheckerId] == DBNull.Value ? null : objRow[conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id
objBigConceptEN.SchCheckDate = objRow[conBigConcept.SchCheckDate] == DBNull.Value ? null : objRow[conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期
objBigConceptEN.IdSubmitStatus = objRow[conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objBigConceptEN.Memo = objRow[conBigConcept.Memo] == DBNull.Value ? null : objRow[conBigConcept.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsBigConceptDA: GetObjByDataRow)", objException.Message));
}
objBigConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objBigConceptEN;
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
objSQL = clsBigConceptDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsBigConceptEN._CurrTabName, conBigConcept.IdBigConcept, 8, "");
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
objSQL = clsBigConceptDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsBigConceptEN._CurrTabName, conBigConcept.IdBigConcept, 8, strPrefix);
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
 objSQL = clsBigConceptDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdBigConcept from BigConcept where " + strCondition;
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
 objSQL = clsBigConceptDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdBigConcept from BigConcept where " + strCondition;
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
 /// <param name = "strIdBigConcept">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdBigConcept)
{
CheckPrimaryKey(strIdBigConcept);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("BigConcept", "IdBigConcept = " + "'"+ strIdBigConcept+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsBigConceptDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("BigConcept", strCondition))
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
objSQL = clsBigConceptDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("BigConcept");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsBigConceptEN objBigConceptEN)
 {
 if (objBigConceptEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objBigConceptEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
strSQL = "Select * from BigConcept where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "BigConcept");
objRow = objDS.Tables["BigConcept"].NewRow();
objRow[conBigConcept.IdBigConcept] = objBigConceptEN.IdBigConcept; //大概念流水号
objRow[conBigConcept.BigConceptId] = objBigConceptEN.BigConceptId; //大概念编号
objRow[conBigConcept.BigConceptName] = objBigConceptEN.BigConceptName; //大概念名称
objRow[conBigConcept.IdGrade] = objBigConceptEN.IdGrade; //年级流水号
objRow[conBigConcept.SchoolTerm] = objBigConceptEN.SchoolTerm; //学期
objRow[conBigConcept.CourseId] = objBigConceptEN.CourseId; //课程Id
objRow[conBigConcept.IsClgCheck] = objBigConceptEN.IsClgCheck; //是否学院审批
 if (objBigConceptEN.ClgNote !=  "")
 {
objRow[conBigConcept.ClgNote] = objBigConceptEN.ClgNote; //学院审批意见
 }
 if (objBigConceptEN.ClgCheckerId !=  "")
 {
objRow[conBigConcept.ClgCheckerId] = objBigConceptEN.ClgCheckerId; //学院审批人id
 }
 if (objBigConceptEN.ClgCheckDate !=  "")
 {
objRow[conBigConcept.ClgCheckDate] = objBigConceptEN.ClgCheckDate; //学院审批日期
 }
objRow[conBigConcept.IsSchCheck] = objBigConceptEN.IsSchCheck; //是否学校审批
 if (objBigConceptEN.SchNote !=  "")
 {
objRow[conBigConcept.SchNote] = objBigConceptEN.SchNote; //学校审批意见
 }
 if (objBigConceptEN.SchCheckerId !=  "")
 {
objRow[conBigConcept.SchCheckerId] = objBigConceptEN.SchCheckerId; //学校审批人Id
 }
 if (objBigConceptEN.SchCheckDate !=  "")
 {
objRow[conBigConcept.SchCheckDate] = objBigConceptEN.SchCheckDate; //学校审批日期
 }
objRow[conBigConcept.IdSubmitStatus] = objBigConceptEN.IdSubmitStatus; //送审状态流水号
 if (objBigConceptEN.Memo !=  "")
 {
objRow[conBigConcept.Memo] = objBigConceptEN.Memo; //备注
 }
objDS.Tables[clsBigConceptEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsBigConceptEN._CurrTabName);
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
 /// <param name = "objBigConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsBigConceptEN objBigConceptEN)
{
 if (objBigConceptEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objBigConceptEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objBigConceptEN.IdBigConcept !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.IdBigConcept);
 var strIdBigConcept = objBigConceptEN.IdBigConcept.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdBigConcept + "'");
 }
 
 if (objBigConceptEN.BigConceptId !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.BigConceptId);
 var strBigConceptId = objBigConceptEN.BigConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBigConceptId + "'");
 }
 
 if (objBigConceptEN.BigConceptName !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.BigConceptName);
 var strBigConceptName = objBigConceptEN.BigConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBigConceptName + "'");
 }
 
 if (objBigConceptEN.IdGrade !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.IdGrade);
 var strIdGrade = objBigConceptEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGrade + "'");
 }
 
 if (objBigConceptEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.SchoolTerm);
 var strSchoolTerm = objBigConceptEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objBigConceptEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.CourseId);
 var strCourseId = objBigConceptEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(conBigConcept.IsClgCheck);
 arrValueListForInsert.Add("'" + (objBigConceptEN.IsClgCheck  ==  false ? "0" : "1") + "'");
 
 if (objBigConceptEN.ClgNote !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.ClgNote);
 var strClgNote = objBigConceptEN.ClgNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgNote + "'");
 }
 
 if (objBigConceptEN.ClgCheckerId !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.ClgCheckerId);
 var strClgCheckerId = objBigConceptEN.ClgCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgCheckerId + "'");
 }
 
 if (objBigConceptEN.ClgCheckDate !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.ClgCheckDate);
 var strClgCheckDate = objBigConceptEN.ClgCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgCheckDate + "'");
 }
 
 arrFieldListForInsert.Add(conBigConcept.IsSchCheck);
 arrValueListForInsert.Add("'" + (objBigConceptEN.IsSchCheck  ==  false ? "0" : "1") + "'");
 
 if (objBigConceptEN.SchNote !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.SchNote);
 var strSchNote = objBigConceptEN.SchNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchNote + "'");
 }
 
 if (objBigConceptEN.SchCheckerId !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.SchCheckerId);
 var strSchCheckerId = objBigConceptEN.SchCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchCheckerId + "'");
 }
 
 if (objBigConceptEN.SchCheckDate !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.SchCheckDate);
 var strSchCheckDate = objBigConceptEN.SchCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchCheckDate + "'");
 }
 
 if (objBigConceptEN.IdSubmitStatus  ==  "")
 {
 objBigConceptEN.IdSubmitStatus = null;
 }
 if (objBigConceptEN.IdSubmitStatus !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.IdSubmitStatus);
 var strIdSubmitStatus = objBigConceptEN.IdSubmitStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSubmitStatus + "'");
 }
 
 if (objBigConceptEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.Memo);
 var strMemo = objBigConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into BigConcept");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objBigConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsBigConceptEN objBigConceptEN)
{
 if (objBigConceptEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objBigConceptEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objBigConceptEN.IdBigConcept !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.IdBigConcept);
 var strIdBigConcept = objBigConceptEN.IdBigConcept.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdBigConcept + "'");
 }
 
 if (objBigConceptEN.BigConceptId !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.BigConceptId);
 var strBigConceptId = objBigConceptEN.BigConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBigConceptId + "'");
 }
 
 if (objBigConceptEN.BigConceptName !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.BigConceptName);
 var strBigConceptName = objBigConceptEN.BigConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBigConceptName + "'");
 }
 
 if (objBigConceptEN.IdGrade !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.IdGrade);
 var strIdGrade = objBigConceptEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGrade + "'");
 }
 
 if (objBigConceptEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.SchoolTerm);
 var strSchoolTerm = objBigConceptEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objBigConceptEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.CourseId);
 var strCourseId = objBigConceptEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(conBigConcept.IsClgCheck);
 arrValueListForInsert.Add("'" + (objBigConceptEN.IsClgCheck  ==  false ? "0" : "1") + "'");
 
 if (objBigConceptEN.ClgNote !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.ClgNote);
 var strClgNote = objBigConceptEN.ClgNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgNote + "'");
 }
 
 if (objBigConceptEN.ClgCheckerId !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.ClgCheckerId);
 var strClgCheckerId = objBigConceptEN.ClgCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgCheckerId + "'");
 }
 
 if (objBigConceptEN.ClgCheckDate !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.ClgCheckDate);
 var strClgCheckDate = objBigConceptEN.ClgCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgCheckDate + "'");
 }
 
 arrFieldListForInsert.Add(conBigConcept.IsSchCheck);
 arrValueListForInsert.Add("'" + (objBigConceptEN.IsSchCheck  ==  false ? "0" : "1") + "'");
 
 if (objBigConceptEN.SchNote !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.SchNote);
 var strSchNote = objBigConceptEN.SchNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchNote + "'");
 }
 
 if (objBigConceptEN.SchCheckerId !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.SchCheckerId);
 var strSchCheckerId = objBigConceptEN.SchCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchCheckerId + "'");
 }
 
 if (objBigConceptEN.SchCheckDate !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.SchCheckDate);
 var strSchCheckDate = objBigConceptEN.SchCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchCheckDate + "'");
 }
 
 if (objBigConceptEN.IdSubmitStatus  ==  "")
 {
 objBigConceptEN.IdSubmitStatus = null;
 }
 if (objBigConceptEN.IdSubmitStatus !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.IdSubmitStatus);
 var strIdSubmitStatus = objBigConceptEN.IdSubmitStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSubmitStatus + "'");
 }
 
 if (objBigConceptEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.Memo);
 var strMemo = objBigConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into BigConcept");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objBigConceptEN.IdBigConcept;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objBigConceptEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsBigConceptEN objBigConceptEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objBigConceptEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objBigConceptEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objBigConceptEN.IdBigConcept !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.IdBigConcept);
 var strIdBigConcept = objBigConceptEN.IdBigConcept.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdBigConcept + "'");
 }
 
 if (objBigConceptEN.BigConceptId !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.BigConceptId);
 var strBigConceptId = objBigConceptEN.BigConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBigConceptId + "'");
 }
 
 if (objBigConceptEN.BigConceptName !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.BigConceptName);
 var strBigConceptName = objBigConceptEN.BigConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBigConceptName + "'");
 }
 
 if (objBigConceptEN.IdGrade !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.IdGrade);
 var strIdGrade = objBigConceptEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGrade + "'");
 }
 
 if (objBigConceptEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.SchoolTerm);
 var strSchoolTerm = objBigConceptEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objBigConceptEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.CourseId);
 var strCourseId = objBigConceptEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(conBigConcept.IsClgCheck);
 arrValueListForInsert.Add("'" + (objBigConceptEN.IsClgCheck  ==  false ? "0" : "1") + "'");
 
 if (objBigConceptEN.ClgNote !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.ClgNote);
 var strClgNote = objBigConceptEN.ClgNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgNote + "'");
 }
 
 if (objBigConceptEN.ClgCheckerId !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.ClgCheckerId);
 var strClgCheckerId = objBigConceptEN.ClgCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgCheckerId + "'");
 }
 
 if (objBigConceptEN.ClgCheckDate !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.ClgCheckDate);
 var strClgCheckDate = objBigConceptEN.ClgCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgCheckDate + "'");
 }
 
 arrFieldListForInsert.Add(conBigConcept.IsSchCheck);
 arrValueListForInsert.Add("'" + (objBigConceptEN.IsSchCheck  ==  false ? "0" : "1") + "'");
 
 if (objBigConceptEN.SchNote !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.SchNote);
 var strSchNote = objBigConceptEN.SchNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchNote + "'");
 }
 
 if (objBigConceptEN.SchCheckerId !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.SchCheckerId);
 var strSchCheckerId = objBigConceptEN.SchCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchCheckerId + "'");
 }
 
 if (objBigConceptEN.SchCheckDate !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.SchCheckDate);
 var strSchCheckDate = objBigConceptEN.SchCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchCheckDate + "'");
 }
 
 if (objBigConceptEN.IdSubmitStatus  ==  "")
 {
 objBigConceptEN.IdSubmitStatus = null;
 }
 if (objBigConceptEN.IdSubmitStatus !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.IdSubmitStatus);
 var strIdSubmitStatus = objBigConceptEN.IdSubmitStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSubmitStatus + "'");
 }
 
 if (objBigConceptEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.Memo);
 var strMemo = objBigConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into BigConcept");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objBigConceptEN.IdBigConcept;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objBigConceptEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsBigConceptEN objBigConceptEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objBigConceptEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objBigConceptEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objBigConceptEN.IdBigConcept !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.IdBigConcept);
 var strIdBigConcept = objBigConceptEN.IdBigConcept.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdBigConcept + "'");
 }
 
 if (objBigConceptEN.BigConceptId !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.BigConceptId);
 var strBigConceptId = objBigConceptEN.BigConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBigConceptId + "'");
 }
 
 if (objBigConceptEN.BigConceptName !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.BigConceptName);
 var strBigConceptName = objBigConceptEN.BigConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBigConceptName + "'");
 }
 
 if (objBigConceptEN.IdGrade !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.IdGrade);
 var strIdGrade = objBigConceptEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGrade + "'");
 }
 
 if (objBigConceptEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.SchoolTerm);
 var strSchoolTerm = objBigConceptEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objBigConceptEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.CourseId);
 var strCourseId = objBigConceptEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(conBigConcept.IsClgCheck);
 arrValueListForInsert.Add("'" + (objBigConceptEN.IsClgCheck  ==  false ? "0" : "1") + "'");
 
 if (objBigConceptEN.ClgNote !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.ClgNote);
 var strClgNote = objBigConceptEN.ClgNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgNote + "'");
 }
 
 if (objBigConceptEN.ClgCheckerId !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.ClgCheckerId);
 var strClgCheckerId = objBigConceptEN.ClgCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgCheckerId + "'");
 }
 
 if (objBigConceptEN.ClgCheckDate !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.ClgCheckDate);
 var strClgCheckDate = objBigConceptEN.ClgCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgCheckDate + "'");
 }
 
 arrFieldListForInsert.Add(conBigConcept.IsSchCheck);
 arrValueListForInsert.Add("'" + (objBigConceptEN.IsSchCheck  ==  false ? "0" : "1") + "'");
 
 if (objBigConceptEN.SchNote !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.SchNote);
 var strSchNote = objBigConceptEN.SchNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchNote + "'");
 }
 
 if (objBigConceptEN.SchCheckerId !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.SchCheckerId);
 var strSchCheckerId = objBigConceptEN.SchCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchCheckerId + "'");
 }
 
 if (objBigConceptEN.SchCheckDate !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.SchCheckDate);
 var strSchCheckDate = objBigConceptEN.SchCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchCheckDate + "'");
 }
 
 if (objBigConceptEN.IdSubmitStatus  ==  "")
 {
 objBigConceptEN.IdSubmitStatus = null;
 }
 if (objBigConceptEN.IdSubmitStatus !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.IdSubmitStatus);
 var strIdSubmitStatus = objBigConceptEN.IdSubmitStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSubmitStatus + "'");
 }
 
 if (objBigConceptEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conBigConcept.Memo);
 var strMemo = objBigConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into BigConcept");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewBigConcepts(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
strSQL = "Select * from BigConcept where IdBigConcept = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "BigConcept");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdBigConcept = oRow[conBigConcept.IdBigConcept].ToString().Trim();
if (IsExist(strIdBigConcept))
{
 string strResult = "关键字变量值为:" + string.Format("IdBigConcept = {0}", strIdBigConcept) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsBigConceptEN._CurrTabName ].NewRow();
objRow[conBigConcept.IdBigConcept] = oRow[conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号
objRow[conBigConcept.BigConceptId] = oRow[conBigConcept.BigConceptId].ToString().Trim(); //大概念编号
objRow[conBigConcept.BigConceptName] = oRow[conBigConcept.BigConceptName].ToString().Trim(); //大概念名称
objRow[conBigConcept.IdGrade] = oRow[conBigConcept.IdGrade].ToString().Trim(); //年级流水号
objRow[conBigConcept.SchoolTerm] = oRow[conBigConcept.SchoolTerm].ToString().Trim(); //学期
objRow[conBigConcept.CourseId] = oRow[conBigConcept.CourseId].ToString().Trim(); //课程Id
objRow[conBigConcept.IsClgCheck] = oRow[conBigConcept.IsClgCheck].ToString().Trim(); //是否学院审批
objRow[conBigConcept.ClgNote] = oRow[conBigConcept.ClgNote].ToString().Trim(); //学院审批意见
objRow[conBigConcept.ClgCheckerId] = oRow[conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id
objRow[conBigConcept.ClgCheckDate] = oRow[conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期
objRow[conBigConcept.IsSchCheck] = oRow[conBigConcept.IsSchCheck].ToString().Trim(); //是否学校审批
objRow[conBigConcept.SchNote] = oRow[conBigConcept.SchNote].ToString().Trim(); //学校审批意见
objRow[conBigConcept.SchCheckerId] = oRow[conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id
objRow[conBigConcept.SchCheckDate] = oRow[conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期
objRow[conBigConcept.IdSubmitStatus] = oRow[conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objRow[conBigConcept.Memo] = oRow[conBigConcept.Memo].ToString().Trim(); //备注
 objDS.Tables[clsBigConceptEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsBigConceptEN._CurrTabName);
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
 /// <param name = "objBigConceptEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsBigConceptEN objBigConceptEN)
{
 if (objBigConceptEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objBigConceptEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
strSQL = "Select * from BigConcept where IdBigConcept = " + "'"+ objBigConceptEN.IdBigConcept+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsBigConceptEN._CurrTabName);
if (objDS.Tables[clsBigConceptEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdBigConcept = " + "'"+ objBigConceptEN.IdBigConcept+"'");
return false;
}
objRow = objDS.Tables[clsBigConceptEN._CurrTabName].Rows[0];
 if (objBigConceptEN.IsUpdated(conBigConcept.IdBigConcept))
 {
objRow[conBigConcept.IdBigConcept] = objBigConceptEN.IdBigConcept; //大概念流水号
 }
 if (objBigConceptEN.IsUpdated(conBigConcept.BigConceptId))
 {
objRow[conBigConcept.BigConceptId] = objBigConceptEN.BigConceptId; //大概念编号
 }
 if (objBigConceptEN.IsUpdated(conBigConcept.BigConceptName))
 {
objRow[conBigConcept.BigConceptName] = objBigConceptEN.BigConceptName; //大概念名称
 }
 if (objBigConceptEN.IsUpdated(conBigConcept.IdGrade))
 {
objRow[conBigConcept.IdGrade] = objBigConceptEN.IdGrade; //年级流水号
 }
 if (objBigConceptEN.IsUpdated(conBigConcept.SchoolTerm))
 {
objRow[conBigConcept.SchoolTerm] = objBigConceptEN.SchoolTerm; //学期
 }
 if (objBigConceptEN.IsUpdated(conBigConcept.CourseId))
 {
objRow[conBigConcept.CourseId] = objBigConceptEN.CourseId; //课程Id
 }
 if (objBigConceptEN.IsUpdated(conBigConcept.IsClgCheck))
 {
objRow[conBigConcept.IsClgCheck] = objBigConceptEN.IsClgCheck; //是否学院审批
 }
 if (objBigConceptEN.IsUpdated(conBigConcept.ClgNote))
 {
objRow[conBigConcept.ClgNote] = objBigConceptEN.ClgNote; //学院审批意见
 }
 if (objBigConceptEN.IsUpdated(conBigConcept.ClgCheckerId))
 {
objRow[conBigConcept.ClgCheckerId] = objBigConceptEN.ClgCheckerId; //学院审批人id
 }
 if (objBigConceptEN.IsUpdated(conBigConcept.ClgCheckDate))
 {
objRow[conBigConcept.ClgCheckDate] = objBigConceptEN.ClgCheckDate; //学院审批日期
 }
 if (objBigConceptEN.IsUpdated(conBigConcept.IsSchCheck))
 {
objRow[conBigConcept.IsSchCheck] = objBigConceptEN.IsSchCheck; //是否学校审批
 }
 if (objBigConceptEN.IsUpdated(conBigConcept.SchNote))
 {
objRow[conBigConcept.SchNote] = objBigConceptEN.SchNote; //学校审批意见
 }
 if (objBigConceptEN.IsUpdated(conBigConcept.SchCheckerId))
 {
objRow[conBigConcept.SchCheckerId] = objBigConceptEN.SchCheckerId; //学校审批人Id
 }
 if (objBigConceptEN.IsUpdated(conBigConcept.SchCheckDate))
 {
objRow[conBigConcept.SchCheckDate] = objBigConceptEN.SchCheckDate; //学校审批日期
 }
 if (objBigConceptEN.IsUpdated(conBigConcept.IdSubmitStatus))
 {
objRow[conBigConcept.IdSubmitStatus] = objBigConceptEN.IdSubmitStatus; //送审状态流水号
 }
 if (objBigConceptEN.IsUpdated(conBigConcept.Memo))
 {
objRow[conBigConcept.Memo] = objBigConceptEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsBigConceptEN._CurrTabName);
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
 /// <param name = "objBigConceptEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsBigConceptEN objBigConceptEN)
{
 if (objBigConceptEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objBigConceptEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update BigConcept Set ");
 
 if (objBigConceptEN.IsUpdated(conBigConcept.BigConceptId))
 {
 if (objBigConceptEN.BigConceptId !=  null)
 {
 var strBigConceptId = objBigConceptEN.BigConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBigConceptId, conBigConcept.BigConceptId); //大概念编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.BigConceptId); //大概念编号
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.BigConceptName))
 {
 if (objBigConceptEN.BigConceptName !=  null)
 {
 var strBigConceptName = objBigConceptEN.BigConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBigConceptName, conBigConcept.BigConceptName); //大概念名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.BigConceptName); //大概念名称
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.IdGrade))
 {
 if (objBigConceptEN.IdGrade !=  null)
 {
 var strIdGrade = objBigConceptEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGrade, conBigConcept.IdGrade); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.IdGrade); //年级流水号
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.SchoolTerm))
 {
 if (objBigConceptEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objBigConceptEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conBigConcept.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.SchoolTerm); //学期
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.CourseId))
 {
 if (objBigConceptEN.CourseId !=  null)
 {
 var strCourseId = objBigConceptEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conBigConcept.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.CourseId); //课程Id
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.IsClgCheck))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objBigConceptEN.IsClgCheck == true?"1":"0", conBigConcept.IsClgCheck); //是否学院审批
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.ClgNote))
 {
 if (objBigConceptEN.ClgNote !=  null)
 {
 var strClgNote = objBigConceptEN.ClgNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClgNote, conBigConcept.ClgNote); //学院审批意见
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.ClgNote); //学院审批意见
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.ClgCheckerId))
 {
 if (objBigConceptEN.ClgCheckerId !=  null)
 {
 var strClgCheckerId = objBigConceptEN.ClgCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClgCheckerId, conBigConcept.ClgCheckerId); //学院审批人id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.ClgCheckerId); //学院审批人id
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.ClgCheckDate))
 {
 if (objBigConceptEN.ClgCheckDate !=  null)
 {
 var strClgCheckDate = objBigConceptEN.ClgCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClgCheckDate, conBigConcept.ClgCheckDate); //学院审批日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.ClgCheckDate); //学院审批日期
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.IsSchCheck))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objBigConceptEN.IsSchCheck == true?"1":"0", conBigConcept.IsSchCheck); //是否学校审批
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.SchNote))
 {
 if (objBigConceptEN.SchNote !=  null)
 {
 var strSchNote = objBigConceptEN.SchNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchNote, conBigConcept.SchNote); //学校审批意见
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.SchNote); //学校审批意见
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.SchCheckerId))
 {
 if (objBigConceptEN.SchCheckerId !=  null)
 {
 var strSchCheckerId = objBigConceptEN.SchCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchCheckerId, conBigConcept.SchCheckerId); //学校审批人Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.SchCheckerId); //学校审批人Id
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.SchCheckDate))
 {
 if (objBigConceptEN.SchCheckDate !=  null)
 {
 var strSchCheckDate = objBigConceptEN.SchCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchCheckDate, conBigConcept.SchCheckDate); //学校审批日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.SchCheckDate); //学校审批日期
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.IdSubmitStatus))
 {
 if (objBigConceptEN.IdSubmitStatus  ==  "")
 {
 objBigConceptEN.IdSubmitStatus = null;
 }
 if (objBigConceptEN.IdSubmitStatus !=  null)
 {
 var strIdSubmitStatus = objBigConceptEN.IdSubmitStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSubmitStatus, conBigConcept.IdSubmitStatus); //送审状态流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.IdSubmitStatus); //送审状态流水号
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.Memo))
 {
 if (objBigConceptEN.Memo !=  null)
 {
 var strMemo = objBigConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conBigConcept.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdBigConcept = '{0}'", objBigConceptEN.IdBigConcept); 
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
 /// <param name = "objBigConceptEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsBigConceptEN objBigConceptEN, string strCondition)
{
 if (objBigConceptEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objBigConceptEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update BigConcept Set ");
 
 if (objBigConceptEN.IsUpdated(conBigConcept.BigConceptId))
 {
 if (objBigConceptEN.BigConceptId !=  null)
 {
 var strBigConceptId = objBigConceptEN.BigConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BigConceptId = '{0}',", strBigConceptId); //大概念编号
 }
 else
 {
 sbSQL.Append(" BigConceptId = null,"); //大概念编号
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.BigConceptName))
 {
 if (objBigConceptEN.BigConceptName !=  null)
 {
 var strBigConceptName = objBigConceptEN.BigConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BigConceptName = '{0}',", strBigConceptName); //大概念名称
 }
 else
 {
 sbSQL.Append(" BigConceptName = null,"); //大概念名称
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.IdGrade))
 {
 if (objBigConceptEN.IdGrade !=  null)
 {
 var strIdGrade = objBigConceptEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGrade = '{0}',", strIdGrade); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGrade = null,"); //年级流水号
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.SchoolTerm))
 {
 if (objBigConceptEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objBigConceptEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.CourseId))
 {
 if (objBigConceptEN.CourseId !=  null)
 {
 var strCourseId = objBigConceptEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.IsClgCheck))
 {
 sbSQL.AppendFormat(" IsClgCheck = '{0}',", objBigConceptEN.IsClgCheck == true?"1":"0"); //是否学院审批
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.ClgNote))
 {
 if (objBigConceptEN.ClgNote !=  null)
 {
 var strClgNote = objBigConceptEN.ClgNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClgNote = '{0}',", strClgNote); //学院审批意见
 }
 else
 {
 sbSQL.Append(" ClgNote = null,"); //学院审批意见
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.ClgCheckerId))
 {
 if (objBigConceptEN.ClgCheckerId !=  null)
 {
 var strClgCheckerId = objBigConceptEN.ClgCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClgCheckerId = '{0}',", strClgCheckerId); //学院审批人id
 }
 else
 {
 sbSQL.Append(" ClgCheckerId = null,"); //学院审批人id
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.ClgCheckDate))
 {
 if (objBigConceptEN.ClgCheckDate !=  null)
 {
 var strClgCheckDate = objBigConceptEN.ClgCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClgCheckDate = '{0}',", strClgCheckDate); //学院审批日期
 }
 else
 {
 sbSQL.Append(" ClgCheckDate = null,"); //学院审批日期
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.IsSchCheck))
 {
 sbSQL.AppendFormat(" IsSchCheck = '{0}',", objBigConceptEN.IsSchCheck == true?"1":"0"); //是否学校审批
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.SchNote))
 {
 if (objBigConceptEN.SchNote !=  null)
 {
 var strSchNote = objBigConceptEN.SchNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchNote = '{0}',", strSchNote); //学校审批意见
 }
 else
 {
 sbSQL.Append(" SchNote = null,"); //学校审批意见
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.SchCheckerId))
 {
 if (objBigConceptEN.SchCheckerId !=  null)
 {
 var strSchCheckerId = objBigConceptEN.SchCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchCheckerId = '{0}',", strSchCheckerId); //学校审批人Id
 }
 else
 {
 sbSQL.Append(" SchCheckerId = null,"); //学校审批人Id
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.SchCheckDate))
 {
 if (objBigConceptEN.SchCheckDate !=  null)
 {
 var strSchCheckDate = objBigConceptEN.SchCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchCheckDate = '{0}',", strSchCheckDate); //学校审批日期
 }
 else
 {
 sbSQL.Append(" SchCheckDate = null,"); //学校审批日期
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.IdSubmitStatus))
 {
 if (objBigConceptEN.IdSubmitStatus  ==  "")
 {
 objBigConceptEN.IdSubmitStatus = null;
 }
 if (objBigConceptEN.IdSubmitStatus !=  null)
 {
 var strIdSubmitStatus = objBigConceptEN.IdSubmitStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSubmitStatus = '{0}',", strIdSubmitStatus); //送审状态流水号
 }
 else
 {
 sbSQL.Append(" IdSubmitStatus = null,"); //送审状态流水号
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.Memo))
 {
 if (objBigConceptEN.Memo !=  null)
 {
 var strMemo = objBigConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
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
 /// <param name = "objBigConceptEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsBigConceptEN objBigConceptEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objBigConceptEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objBigConceptEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update BigConcept Set ");
 
 if (objBigConceptEN.IsUpdated(conBigConcept.BigConceptId))
 {
 if (objBigConceptEN.BigConceptId !=  null)
 {
 var strBigConceptId = objBigConceptEN.BigConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BigConceptId = '{0}',", strBigConceptId); //大概念编号
 }
 else
 {
 sbSQL.Append(" BigConceptId = null,"); //大概念编号
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.BigConceptName))
 {
 if (objBigConceptEN.BigConceptName !=  null)
 {
 var strBigConceptName = objBigConceptEN.BigConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BigConceptName = '{0}',", strBigConceptName); //大概念名称
 }
 else
 {
 sbSQL.Append(" BigConceptName = null,"); //大概念名称
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.IdGrade))
 {
 if (objBigConceptEN.IdGrade !=  null)
 {
 var strIdGrade = objBigConceptEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGrade = '{0}',", strIdGrade); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGrade = null,"); //年级流水号
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.SchoolTerm))
 {
 if (objBigConceptEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objBigConceptEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.CourseId))
 {
 if (objBigConceptEN.CourseId !=  null)
 {
 var strCourseId = objBigConceptEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.IsClgCheck))
 {
 sbSQL.AppendFormat(" IsClgCheck = '{0}',", objBigConceptEN.IsClgCheck == true?"1":"0"); //是否学院审批
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.ClgNote))
 {
 if (objBigConceptEN.ClgNote !=  null)
 {
 var strClgNote = objBigConceptEN.ClgNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClgNote = '{0}',", strClgNote); //学院审批意见
 }
 else
 {
 sbSQL.Append(" ClgNote = null,"); //学院审批意见
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.ClgCheckerId))
 {
 if (objBigConceptEN.ClgCheckerId !=  null)
 {
 var strClgCheckerId = objBigConceptEN.ClgCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClgCheckerId = '{0}',", strClgCheckerId); //学院审批人id
 }
 else
 {
 sbSQL.Append(" ClgCheckerId = null,"); //学院审批人id
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.ClgCheckDate))
 {
 if (objBigConceptEN.ClgCheckDate !=  null)
 {
 var strClgCheckDate = objBigConceptEN.ClgCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClgCheckDate = '{0}',", strClgCheckDate); //学院审批日期
 }
 else
 {
 sbSQL.Append(" ClgCheckDate = null,"); //学院审批日期
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.IsSchCheck))
 {
 sbSQL.AppendFormat(" IsSchCheck = '{0}',", objBigConceptEN.IsSchCheck == true?"1":"0"); //是否学校审批
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.SchNote))
 {
 if (objBigConceptEN.SchNote !=  null)
 {
 var strSchNote = objBigConceptEN.SchNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchNote = '{0}',", strSchNote); //学校审批意见
 }
 else
 {
 sbSQL.Append(" SchNote = null,"); //学校审批意见
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.SchCheckerId))
 {
 if (objBigConceptEN.SchCheckerId !=  null)
 {
 var strSchCheckerId = objBigConceptEN.SchCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchCheckerId = '{0}',", strSchCheckerId); //学校审批人Id
 }
 else
 {
 sbSQL.Append(" SchCheckerId = null,"); //学校审批人Id
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.SchCheckDate))
 {
 if (objBigConceptEN.SchCheckDate !=  null)
 {
 var strSchCheckDate = objBigConceptEN.SchCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchCheckDate = '{0}',", strSchCheckDate); //学校审批日期
 }
 else
 {
 sbSQL.Append(" SchCheckDate = null,"); //学校审批日期
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.IdSubmitStatus))
 {
 if (objBigConceptEN.IdSubmitStatus  ==  "")
 {
 objBigConceptEN.IdSubmitStatus = null;
 }
 if (objBigConceptEN.IdSubmitStatus !=  null)
 {
 var strIdSubmitStatus = objBigConceptEN.IdSubmitStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSubmitStatus = '{0}',", strIdSubmitStatus); //送审状态流水号
 }
 else
 {
 sbSQL.Append(" IdSubmitStatus = null,"); //送审状态流水号
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.Memo))
 {
 if (objBigConceptEN.Memo !=  null)
 {
 var strMemo = objBigConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
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
 /// <param name = "objBigConceptEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsBigConceptEN objBigConceptEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objBigConceptEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objBigConceptEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update BigConcept Set ");
 
 if (objBigConceptEN.IsUpdated(conBigConcept.BigConceptId))
 {
 if (objBigConceptEN.BigConceptId !=  null)
 {
 var strBigConceptId = objBigConceptEN.BigConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBigConceptId, conBigConcept.BigConceptId); //大概念编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.BigConceptId); //大概念编号
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.BigConceptName))
 {
 if (objBigConceptEN.BigConceptName !=  null)
 {
 var strBigConceptName = objBigConceptEN.BigConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBigConceptName, conBigConcept.BigConceptName); //大概念名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.BigConceptName); //大概念名称
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.IdGrade))
 {
 if (objBigConceptEN.IdGrade !=  null)
 {
 var strIdGrade = objBigConceptEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGrade, conBigConcept.IdGrade); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.IdGrade); //年级流水号
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.SchoolTerm))
 {
 if (objBigConceptEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objBigConceptEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conBigConcept.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.SchoolTerm); //学期
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.CourseId))
 {
 if (objBigConceptEN.CourseId !=  null)
 {
 var strCourseId = objBigConceptEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conBigConcept.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.CourseId); //课程Id
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.IsClgCheck))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objBigConceptEN.IsClgCheck == true?"1":"0", conBigConcept.IsClgCheck); //是否学院审批
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.ClgNote))
 {
 if (objBigConceptEN.ClgNote !=  null)
 {
 var strClgNote = objBigConceptEN.ClgNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClgNote, conBigConcept.ClgNote); //学院审批意见
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.ClgNote); //学院审批意见
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.ClgCheckerId))
 {
 if (objBigConceptEN.ClgCheckerId !=  null)
 {
 var strClgCheckerId = objBigConceptEN.ClgCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClgCheckerId, conBigConcept.ClgCheckerId); //学院审批人id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.ClgCheckerId); //学院审批人id
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.ClgCheckDate))
 {
 if (objBigConceptEN.ClgCheckDate !=  null)
 {
 var strClgCheckDate = objBigConceptEN.ClgCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClgCheckDate, conBigConcept.ClgCheckDate); //学院审批日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.ClgCheckDate); //学院审批日期
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.IsSchCheck))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objBigConceptEN.IsSchCheck == true?"1":"0", conBigConcept.IsSchCheck); //是否学校审批
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.SchNote))
 {
 if (objBigConceptEN.SchNote !=  null)
 {
 var strSchNote = objBigConceptEN.SchNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchNote, conBigConcept.SchNote); //学校审批意见
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.SchNote); //学校审批意见
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.SchCheckerId))
 {
 if (objBigConceptEN.SchCheckerId !=  null)
 {
 var strSchCheckerId = objBigConceptEN.SchCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchCheckerId, conBigConcept.SchCheckerId); //学校审批人Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.SchCheckerId); //学校审批人Id
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.SchCheckDate))
 {
 if (objBigConceptEN.SchCheckDate !=  null)
 {
 var strSchCheckDate = objBigConceptEN.SchCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchCheckDate, conBigConcept.SchCheckDate); //学校审批日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.SchCheckDate); //学校审批日期
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.IdSubmitStatus))
 {
 if (objBigConceptEN.IdSubmitStatus  ==  "")
 {
 objBigConceptEN.IdSubmitStatus = null;
 }
 if (objBigConceptEN.IdSubmitStatus !=  null)
 {
 var strIdSubmitStatus = objBigConceptEN.IdSubmitStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSubmitStatus, conBigConcept.IdSubmitStatus); //送审状态流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.IdSubmitStatus); //送审状态流水号
 }
 }
 
 if (objBigConceptEN.IsUpdated(conBigConcept.Memo))
 {
 if (objBigConceptEN.Memo !=  null)
 {
 var strMemo = objBigConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conBigConcept.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBigConcept.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdBigConcept = '{0}'", objBigConceptEN.IdBigConcept); 
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
 /// <param name = "strIdBigConcept">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdBigConcept) 
{
CheckPrimaryKey(strIdBigConcept);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdBigConcept,
};
 objSQL.ExecSP("BigConcept_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdBigConcept">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdBigConcept, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdBigConcept);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
//删除BigConcept本表中与当前对象有关的记录
strSQL = strSQL + "Delete from BigConcept where IdBigConcept = " + "'"+ strIdBigConcept+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelBigConcept(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
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
//删除BigConcept本表中与当前对象有关的记录
strSQL = strSQL + "Delete from BigConcept where IdBigConcept in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdBigConcept">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdBigConcept) 
{
CheckPrimaryKey(strIdBigConcept);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
//删除BigConcept本表中与当前对象有关的记录
strSQL = strSQL + "Delete from BigConcept where IdBigConcept = " + "'"+ strIdBigConcept+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelBigConcept(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsBigConceptDA: DelBigConcept)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from BigConcept where " + strCondition ;
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
public bool DelBigConceptWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsBigConceptDA: DelBigConceptWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBigConceptDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from BigConcept where " + strCondition ;
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
 /// <param name = "objBigConceptENS">源对象</param>
 /// <param name = "objBigConceptENT">目标对象</param>
public void CopyTo(clsBigConceptEN objBigConceptENS, clsBigConceptEN objBigConceptENT)
{
objBigConceptENT.IdBigConcept = objBigConceptENS.IdBigConcept; //大概念流水号
objBigConceptENT.BigConceptId = objBigConceptENS.BigConceptId; //大概念编号
objBigConceptENT.BigConceptName = objBigConceptENS.BigConceptName; //大概念名称
objBigConceptENT.IdGrade = objBigConceptENS.IdGrade; //年级流水号
objBigConceptENT.SchoolTerm = objBigConceptENS.SchoolTerm; //学期
objBigConceptENT.CourseId = objBigConceptENS.CourseId; //课程Id
objBigConceptENT.IsClgCheck = objBigConceptENS.IsClgCheck; //是否学院审批
objBigConceptENT.ClgNote = objBigConceptENS.ClgNote; //学院审批意见
objBigConceptENT.ClgCheckerId = objBigConceptENS.ClgCheckerId; //学院审批人id
objBigConceptENT.ClgCheckDate = objBigConceptENS.ClgCheckDate; //学院审批日期
objBigConceptENT.IsSchCheck = objBigConceptENS.IsSchCheck; //是否学校审批
objBigConceptENT.SchNote = objBigConceptENS.SchNote; //学校审批意见
objBigConceptENT.SchCheckerId = objBigConceptENS.SchCheckerId; //学校审批人Id
objBigConceptENT.SchCheckDate = objBigConceptENS.SchCheckDate; //学校审批日期
objBigConceptENT.IdSubmitStatus = objBigConceptENS.IdSubmitStatus; //送审状态流水号
objBigConceptENT.Memo = objBigConceptENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsBigConceptEN objBigConceptEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objBigConceptEN.BigConceptId, conBigConcept.BigConceptId);
clsCheckSql.CheckFieldNotNull(objBigConceptEN.BigConceptName, conBigConcept.BigConceptName);
clsCheckSql.CheckFieldNotNull(objBigConceptEN.IdGrade, conBigConcept.IdGrade);
clsCheckSql.CheckFieldNotNull(objBigConceptEN.SchoolTerm, conBigConcept.SchoolTerm);
clsCheckSql.CheckFieldNotNull(objBigConceptEN.CourseId, conBigConcept.CourseId);
clsCheckSql.CheckFieldNotNull(objBigConceptEN.IdSubmitStatus, conBigConcept.IdSubmitStatus);
//检查字段长度
clsCheckSql.CheckFieldLen(objBigConceptEN.IdBigConcept, 8, conBigConcept.IdBigConcept);
clsCheckSql.CheckFieldLen(objBigConceptEN.BigConceptId, 12, conBigConcept.BigConceptId);
clsCheckSql.CheckFieldLen(objBigConceptEN.BigConceptName, 100, conBigConcept.BigConceptName);
clsCheckSql.CheckFieldLen(objBigConceptEN.IdGrade, 4, conBigConcept.IdGrade);
clsCheckSql.CheckFieldLen(objBigConceptEN.SchoolTerm, 1, conBigConcept.SchoolTerm);
clsCheckSql.CheckFieldLen(objBigConceptEN.CourseId, 8, conBigConcept.CourseId);
clsCheckSql.CheckFieldLen(objBigConceptEN.ClgCheckerId, 18, conBigConcept.ClgCheckerId);
clsCheckSql.CheckFieldLen(objBigConceptEN.ClgCheckDate, 8, conBigConcept.ClgCheckDate);
clsCheckSql.CheckFieldLen(objBigConceptEN.SchCheckerId, 18, conBigConcept.SchCheckerId);
clsCheckSql.CheckFieldLen(objBigConceptEN.SchCheckDate, 8, conBigConcept.SchCheckDate);
clsCheckSql.CheckFieldLen(objBigConceptEN.IdSubmitStatus, 2, conBigConcept.IdSubmitStatus);
clsCheckSql.CheckFieldLen(objBigConceptEN.Memo, 1000, conBigConcept.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objBigConceptEN.IdSubmitStatus, 2, conBigConcept.IdSubmitStatus);
 objBigConceptEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsBigConceptEN objBigConceptEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objBigConceptEN.BigConceptId, 12, conBigConcept.BigConceptId);
clsCheckSql.CheckFieldLen(objBigConceptEN.BigConceptName, 100, conBigConcept.BigConceptName);
clsCheckSql.CheckFieldLen(objBigConceptEN.IdGrade, 4, conBigConcept.IdGrade);
clsCheckSql.CheckFieldLen(objBigConceptEN.SchoolTerm, 1, conBigConcept.SchoolTerm);
clsCheckSql.CheckFieldLen(objBigConceptEN.CourseId, 8, conBigConcept.CourseId);
clsCheckSql.CheckFieldLen(objBigConceptEN.ClgCheckerId, 18, conBigConcept.ClgCheckerId);
clsCheckSql.CheckFieldLen(objBigConceptEN.ClgCheckDate, 8, conBigConcept.ClgCheckDate);
clsCheckSql.CheckFieldLen(objBigConceptEN.SchCheckerId, 18, conBigConcept.SchCheckerId);
clsCheckSql.CheckFieldLen(objBigConceptEN.SchCheckDate, 8, conBigConcept.SchCheckDate);
clsCheckSql.CheckFieldLen(objBigConceptEN.IdSubmitStatus, 2, conBigConcept.IdSubmitStatus);
clsCheckSql.CheckFieldLen(objBigConceptEN.Memo, 1000, conBigConcept.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objBigConceptEN.IdSubmitStatus, 2, conBigConcept.IdSubmitStatus);
 objBigConceptEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsBigConceptEN objBigConceptEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objBigConceptEN.IdBigConcept, 8, conBigConcept.IdBigConcept);
clsCheckSql.CheckFieldLen(objBigConceptEN.BigConceptId, 12, conBigConcept.BigConceptId);
clsCheckSql.CheckFieldLen(objBigConceptEN.BigConceptName, 100, conBigConcept.BigConceptName);
clsCheckSql.CheckFieldLen(objBigConceptEN.IdGrade, 4, conBigConcept.IdGrade);
clsCheckSql.CheckFieldLen(objBigConceptEN.SchoolTerm, 1, conBigConcept.SchoolTerm);
clsCheckSql.CheckFieldLen(objBigConceptEN.CourseId, 8, conBigConcept.CourseId);
clsCheckSql.CheckFieldLen(objBigConceptEN.ClgCheckerId, 18, conBigConcept.ClgCheckerId);
clsCheckSql.CheckFieldLen(objBigConceptEN.ClgCheckDate, 8, conBigConcept.ClgCheckDate);
clsCheckSql.CheckFieldLen(objBigConceptEN.SchCheckerId, 18, conBigConcept.SchCheckerId);
clsCheckSql.CheckFieldLen(objBigConceptEN.SchCheckDate, 8, conBigConcept.SchCheckDate);
clsCheckSql.CheckFieldLen(objBigConceptEN.IdSubmitStatus, 2, conBigConcept.IdSubmitStatus);
clsCheckSql.CheckFieldLen(objBigConceptEN.Memo, 1000, conBigConcept.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objBigConceptEN.IdBigConcept, conBigConcept.IdBigConcept);
clsCheckSql.CheckSqlInjection4Field(objBigConceptEN.BigConceptId, conBigConcept.BigConceptId);
clsCheckSql.CheckSqlInjection4Field(objBigConceptEN.BigConceptName, conBigConcept.BigConceptName);
clsCheckSql.CheckSqlInjection4Field(objBigConceptEN.IdGrade, conBigConcept.IdGrade);
clsCheckSql.CheckSqlInjection4Field(objBigConceptEN.SchoolTerm, conBigConcept.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objBigConceptEN.CourseId, conBigConcept.CourseId);
clsCheckSql.CheckSqlInjection4Field(objBigConceptEN.ClgCheckerId, conBigConcept.ClgCheckerId);
clsCheckSql.CheckSqlInjection4Field(objBigConceptEN.ClgCheckDate, conBigConcept.ClgCheckDate);
clsCheckSql.CheckSqlInjection4Field(objBigConceptEN.SchCheckerId, conBigConcept.SchCheckerId);
clsCheckSql.CheckSqlInjection4Field(objBigConceptEN.SchCheckDate, conBigConcept.SchCheckDate);
clsCheckSql.CheckSqlInjection4Field(objBigConceptEN.IdSubmitStatus, conBigConcept.IdSubmitStatus);
clsCheckSql.CheckSqlInjection4Field(objBigConceptEN.Memo, conBigConcept.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objBigConceptEN.IdSubmitStatus, 2, conBigConcept.IdSubmitStatus);
 objBigConceptEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdBigConcept()
{
//获取某学院所有专业信息
string strSQL = "select IdBigConcept, BigConceptName from BigConcept ";
 clsSpecSQLforSql mySql = clsBigConceptDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--BigConcept(大概念),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objBigConceptEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsBigConceptEN objBigConceptEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and BigConceptName = '{0}'", objBigConceptEN.BigConceptName);
 sbCondition.AppendFormat(" and IdGrade = '{0}'", objBigConceptEN.IdGrade);
return sbCondition.ToString();
}

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
 objSQL = clsBigConceptDA.GetSpecSQLObj();
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
 objSQL = clsBigConceptDA.GetSpecSQLObj();
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
 objSQL = clsBigConceptDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsBigConceptEN._CurrTabName);
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
 objSQL = clsBigConceptDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsBigConceptEN._CurrTabName, strCondition);
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
 objSQL = clsBigConceptDA.GetSpecSQLObj();
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
 objSQL = clsBigConceptDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}