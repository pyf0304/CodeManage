
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzGrade_psDA
 表名:vXzGrade_ps(01120368)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:21
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中小学教学(K12Edu)
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
 /// v年级表_ps(vXzGrade_ps)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvXzGrade_psDA : clsCommBase4DA
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
 return clsvXzGrade_psEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvXzGrade_psEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzGrade_psEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvXzGrade_psEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvXzGrade_psEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdGradeBase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdGradeBase)
{
strIdGradeBase = strIdGradeBase.Replace("'", "''");
if (strIdGradeBase.Length > 4)
{
throw new Exception("(errid:Data000001)在表:vXzGrade_ps中,检查关键字,长度不正确!(clsvXzGrade_psDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdGradeBase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vXzGrade_ps中,关键字不能为空 或 null!(clsvXzGrade_psDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdGradeBase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvXzGrade_psDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvXzGrade_psDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
strSQL = "Select * from vXzGrade_ps where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vXzGrade_ps(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvXzGrade_psDA: GetDataTable_vXzGrade_ps)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
strSQL = "Select * from vXzGrade_ps where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvXzGrade_psDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvXzGrade_psDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
strSQL = "Select * from vXzGrade_ps where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvXzGrade_psDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvXzGrade_psDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzGrade_ps where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzGrade_ps where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvXzGrade_psDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vXzGrade_ps where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvXzGrade_psDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vXzGrade_ps.* from vXzGrade_ps Left Join {1} on {2} where {3} and vXzGrade_ps.IdGradeBase not in (Select top {5} vXzGrade_ps.IdGradeBase from vXzGrade_ps Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzGrade_ps where {1} and IdGradeBase not in (Select top {2} IdGradeBase from vXzGrade_ps where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzGrade_ps where {1} and IdGradeBase not in (Select top {3} IdGradeBase from vXzGrade_ps where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvXzGrade_psDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vXzGrade_ps.* from vXzGrade_ps Left Join {1} on {2} where {3} and vXzGrade_ps.IdGradeBase not in (Select top {5} vXzGrade_ps.IdGradeBase from vXzGrade_ps Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzGrade_ps where {1} and IdGradeBase not in (Select top {2} IdGradeBase from vXzGrade_ps where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzGrade_ps where {1} and IdGradeBase not in (Select top {3} IdGradeBase from vXzGrade_ps where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvXzGrade_psEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvXzGrade_psDA:GetObjLst)", objException.Message));
}
List<clsvXzGrade_psEN> arrObjLst = new List<clsvXzGrade_psEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
strSQL = "Select * from vXzGrade_ps where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN();
try
{
objvXzGrade_psEN.IdGradeBase = objRow[convXzGrade_ps.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGrade_psEN.GradeBaseId = objRow[convXzGrade_ps.GradeBaseId].ToString().Trim(); //年级代号
objvXzGrade_psEN.GradeBaseName = objRow[convXzGrade_ps.GradeBaseName].ToString().Trim(); //年级名称
objvXzGrade_psEN.IsVisible = TransNullToBool(objRow[convXzGrade_ps.IsVisible].ToString().Trim()); //是否显示
objvXzGrade_psEN.OrderNum = objRow[convXzGrade_ps.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzGrade_ps.OrderNum].ToString().Trim()); //序号
objvXzGrade_psEN.SchoolId = objRow[convXzGrade_ps.SchoolId].ToString().Trim(); //学校编号
objvXzGrade_psEN.SchoolName = objRow[convXzGrade_ps.SchoolName].ToString().Trim(); //学校名称
objvXzGrade_psEN.IdSchool = objRow[convXzGrade_ps.IdSchool] == DBNull.Value ? null : objRow[convXzGrade_ps.IdSchool].ToString().Trim(); //学校流水号
objvXzGrade_psEN.Memo = objRow[convXzGrade_ps.Memo] == DBNull.Value ? null : objRow[convXzGrade_ps.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvXzGrade_psDA: GetObjLst)", objException.Message));
}
objvXzGrade_psEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvXzGrade_psEN);
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
public List<clsvXzGrade_psEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvXzGrade_psDA:GetObjLstByTabName)", objException.Message));
}
List<clsvXzGrade_psEN> arrObjLst = new List<clsvXzGrade_psEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN();
try
{
objvXzGrade_psEN.IdGradeBase = objRow[convXzGrade_ps.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGrade_psEN.GradeBaseId = objRow[convXzGrade_ps.GradeBaseId].ToString().Trim(); //年级代号
objvXzGrade_psEN.GradeBaseName = objRow[convXzGrade_ps.GradeBaseName].ToString().Trim(); //年级名称
objvXzGrade_psEN.IsVisible = TransNullToBool(objRow[convXzGrade_ps.IsVisible].ToString().Trim()); //是否显示
objvXzGrade_psEN.OrderNum = objRow[convXzGrade_ps.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzGrade_ps.OrderNum].ToString().Trim()); //序号
objvXzGrade_psEN.SchoolId = objRow[convXzGrade_ps.SchoolId].ToString().Trim(); //学校编号
objvXzGrade_psEN.SchoolName = objRow[convXzGrade_ps.SchoolName].ToString().Trim(); //学校名称
objvXzGrade_psEN.IdSchool = objRow[convXzGrade_ps.IdSchool] == DBNull.Value ? null : objRow[convXzGrade_ps.IdSchool].ToString().Trim(); //学校流水号
objvXzGrade_psEN.Memo = objRow[convXzGrade_ps.Memo] == DBNull.Value ? null : objRow[convXzGrade_ps.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvXzGrade_psDA: GetObjLst)", objException.Message));
}
objvXzGrade_psEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvXzGrade_psEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvXzGrade_ps(ref clsvXzGrade_psEN objvXzGrade_psEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
strSQL = "Select * from vXzGrade_ps where IdGradeBase = " + "'"+ objvXzGrade_psEN.IdGradeBase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvXzGrade_psEN.IdGradeBase = objDT.Rows[0][convXzGrade_ps.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzGrade_psEN.GradeBaseId = objDT.Rows[0][convXzGrade_ps.GradeBaseId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objvXzGrade_psEN.GradeBaseName = objDT.Rows[0][convXzGrade_ps.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvXzGrade_psEN.IsVisible = TransNullToBool(objDT.Rows[0][convXzGrade_ps.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvXzGrade_psEN.OrderNum = TransNullToInt(objDT.Rows[0][convXzGrade_ps.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvXzGrade_psEN.SchoolId = objDT.Rows[0][convXzGrade_ps.SchoolId].ToString().Trim(); //学校编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvXzGrade_psEN.SchoolName = objDT.Rows[0][convXzGrade_ps.SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvXzGrade_psEN.IdSchool = objDT.Rows[0][convXzGrade_ps.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzGrade_psEN.Memo = objDT.Rows[0][convXzGrade_ps.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvXzGrade_psDA: GetvXzGrade_ps)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdGradeBase">表关键字</param>
 /// <returns>表对象</returns>
public clsvXzGrade_psEN GetObjByIdGradeBase(string strIdGradeBase)
{
CheckPrimaryKey(strIdGradeBase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
strSQL = "Select * from vXzGrade_ps where IdGradeBase = " + "'"+ strIdGradeBase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN();
try
{
 objvXzGrade_psEN.IdGradeBase = objRow[convXzGrade_ps.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzGrade_psEN.GradeBaseId = objRow[convXzGrade_ps.GradeBaseId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objvXzGrade_psEN.GradeBaseName = objRow[convXzGrade_ps.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvXzGrade_psEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGrade_ps.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvXzGrade_psEN.OrderNum = objRow[convXzGrade_ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGrade_ps.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvXzGrade_psEN.SchoolId = objRow[convXzGrade_ps.SchoolId].ToString().Trim(); //学校编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvXzGrade_psEN.SchoolName = objRow[convXzGrade_ps.SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvXzGrade_psEN.IdSchool = objRow[convXzGrade_ps.IdSchool] == DBNull.Value ? null : objRow[convXzGrade_ps.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzGrade_psEN.Memo = objRow[convXzGrade_ps.Memo] == DBNull.Value ? null : objRow[convXzGrade_ps.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvXzGrade_psDA: GetObjByIdGradeBase)", objException.Message));
}
return objvXzGrade_psEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvXzGrade_psEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvXzGrade_psDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
strSQL = "Select * from vXzGrade_ps where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN()
{
IdGradeBase = objRow[convXzGrade_ps.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseId = objRow[convXzGrade_ps.GradeBaseId].ToString().Trim(), //年级代号
GradeBaseName = objRow[convXzGrade_ps.GradeBaseName].ToString().Trim(), //年级名称
IsVisible = TransNullToBool(objRow[convXzGrade_ps.IsVisible].ToString().Trim()), //是否显示
OrderNum = objRow[convXzGrade_ps.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzGrade_ps.OrderNum].ToString().Trim()), //序号
SchoolId = objRow[convXzGrade_ps.SchoolId].ToString().Trim(), //学校编号
SchoolName = objRow[convXzGrade_ps.SchoolName].ToString().Trim(), //学校名称
IdSchool = objRow[convXzGrade_ps.IdSchool] == DBNull.Value ? null : objRow[convXzGrade_ps.IdSchool].ToString().Trim(), //学校流水号
Memo = objRow[convXzGrade_ps.Memo] == DBNull.Value ? null : objRow[convXzGrade_ps.Memo].ToString().Trim() //备注
};
objvXzGrade_psEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzGrade_psEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvXzGrade_psDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvXzGrade_psEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN();
try
{
objvXzGrade_psEN.IdGradeBase = objRow[convXzGrade_ps.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGrade_psEN.GradeBaseId = objRow[convXzGrade_ps.GradeBaseId].ToString().Trim(); //年级代号
objvXzGrade_psEN.GradeBaseName = objRow[convXzGrade_ps.GradeBaseName].ToString().Trim(); //年级名称
objvXzGrade_psEN.IsVisible = TransNullToBool(objRow[convXzGrade_ps.IsVisible].ToString().Trim()); //是否显示
objvXzGrade_psEN.OrderNum = objRow[convXzGrade_ps.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzGrade_ps.OrderNum].ToString().Trim()); //序号
objvXzGrade_psEN.SchoolId = objRow[convXzGrade_ps.SchoolId].ToString().Trim(); //学校编号
objvXzGrade_psEN.SchoolName = objRow[convXzGrade_ps.SchoolName].ToString().Trim(); //学校名称
objvXzGrade_psEN.IdSchool = objRow[convXzGrade_ps.IdSchool] == DBNull.Value ? null : objRow[convXzGrade_ps.IdSchool].ToString().Trim(); //学校流水号
objvXzGrade_psEN.Memo = objRow[convXzGrade_ps.Memo] == DBNull.Value ? null : objRow[convXzGrade_ps.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvXzGrade_psDA: GetObjByDataRowvXzGrade_ps)", objException.Message));
}
objvXzGrade_psEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzGrade_psEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvXzGrade_psEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN();
try
{
objvXzGrade_psEN.IdGradeBase = objRow[convXzGrade_ps.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGrade_psEN.GradeBaseId = objRow[convXzGrade_ps.GradeBaseId].ToString().Trim(); //年级代号
objvXzGrade_psEN.GradeBaseName = objRow[convXzGrade_ps.GradeBaseName].ToString().Trim(); //年级名称
objvXzGrade_psEN.IsVisible = TransNullToBool(objRow[convXzGrade_ps.IsVisible].ToString().Trim()); //是否显示
objvXzGrade_psEN.OrderNum = objRow[convXzGrade_ps.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzGrade_ps.OrderNum].ToString().Trim()); //序号
objvXzGrade_psEN.SchoolId = objRow[convXzGrade_ps.SchoolId].ToString().Trim(); //学校编号
objvXzGrade_psEN.SchoolName = objRow[convXzGrade_ps.SchoolName].ToString().Trim(); //学校名称
objvXzGrade_psEN.IdSchool = objRow[convXzGrade_ps.IdSchool] == DBNull.Value ? null : objRow[convXzGrade_ps.IdSchool].ToString().Trim(); //学校流水号
objvXzGrade_psEN.Memo = objRow[convXzGrade_ps.Memo] == DBNull.Value ? null : objRow[convXzGrade_ps.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvXzGrade_psDA: GetObjByDataRow)", objException.Message));
}
objvXzGrade_psEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzGrade_psEN;
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
objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvXzGrade_psEN._CurrTabName, convXzGrade_ps.IdGradeBase, 4, "");
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
objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvXzGrade_psEN._CurrTabName, convXzGrade_ps.IdGradeBase, 4, strPrefix);
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
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdGradeBase from vXzGrade_ps where " + strCondition;
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
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdGradeBase from vXzGrade_ps where " + strCondition;
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
 /// <param name = "strIdGradeBase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdGradeBase)
{
CheckPrimaryKey(strIdGradeBase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vXzGrade_ps", "IdGradeBase = " + "'"+ strIdGradeBase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvXzGrade_psDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vXzGrade_ps", strCondition))
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
objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vXzGrade_ps");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvXzGrade_psENS">源对象</param>
 /// <param name = "objvXzGrade_psENT">目标对象</param>
public void CopyTo(clsvXzGrade_psEN objvXzGrade_psENS, clsvXzGrade_psEN objvXzGrade_psENT)
{
objvXzGrade_psENT.IdGradeBase = objvXzGrade_psENS.IdGradeBase; //年级流水号
objvXzGrade_psENT.GradeBaseId = objvXzGrade_psENS.GradeBaseId; //年级代号
objvXzGrade_psENT.GradeBaseName = objvXzGrade_psENS.GradeBaseName; //年级名称
objvXzGrade_psENT.IsVisible = objvXzGrade_psENS.IsVisible; //是否显示
objvXzGrade_psENT.OrderNum = objvXzGrade_psENS.OrderNum; //序号
objvXzGrade_psENT.SchoolId = objvXzGrade_psENS.SchoolId; //学校编号
objvXzGrade_psENT.SchoolName = objvXzGrade_psENS.SchoolName; //学校名称
objvXzGrade_psENT.IdSchool = objvXzGrade_psENS.IdSchool; //学校流水号
objvXzGrade_psENT.Memo = objvXzGrade_psENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvXzGrade_psEN objvXzGrade_psEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvXzGrade_psEN.IdGradeBase, 4, convXzGrade_ps.IdGradeBase);
clsCheckSql.CheckFieldLen(objvXzGrade_psEN.GradeBaseId, 4, convXzGrade_ps.GradeBaseId);
clsCheckSql.CheckFieldLen(objvXzGrade_psEN.GradeBaseName, 50, convXzGrade_ps.GradeBaseName);
clsCheckSql.CheckFieldLen(objvXzGrade_psEN.SchoolId, 10, convXzGrade_ps.SchoolId);
clsCheckSql.CheckFieldLen(objvXzGrade_psEN.SchoolName, 50, convXzGrade_ps.SchoolName);
clsCheckSql.CheckFieldLen(objvXzGrade_psEN.IdSchool, 4, convXzGrade_ps.IdSchool);
clsCheckSql.CheckFieldLen(objvXzGrade_psEN.Memo, 1000, convXzGrade_ps.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvXzGrade_psEN.IdGradeBase, convXzGrade_ps.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvXzGrade_psEN.GradeBaseId, convXzGrade_ps.GradeBaseId);
clsCheckSql.CheckSqlInjection4Field(objvXzGrade_psEN.GradeBaseName, convXzGrade_ps.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvXzGrade_psEN.SchoolId, convXzGrade_ps.SchoolId);
clsCheckSql.CheckSqlInjection4Field(objvXzGrade_psEN.SchoolName, convXzGrade_ps.SchoolName);
clsCheckSql.CheckSqlInjection4Field(objvXzGrade_psEN.IdSchool, convXzGrade_ps.IdSchool);
clsCheckSql.CheckSqlInjection4Field(objvXzGrade_psEN.Memo, convXzGrade_ps.Memo);
//检查外键字段长度
 objvXzGrade_psEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdGradeBase()
{
//获取某学院所有专业信息
string strSQL = "select IdGradeBase, GradeBaseName from vXzGrade_ps ";
 clsSpecSQLforSql mySql = clsvXzGrade_psDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
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
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
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
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvXzGrade_psEN._CurrTabName);
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
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvXzGrade_psEN._CurrTabName, strCondition);
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
 objSQL = clsvXzGrade_psDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}