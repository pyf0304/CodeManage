
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzMajorDA
 表名:vXzMajor(01120066)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
 /// v专业(vXzMajor)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvXzMajorDA : clsCommBase4DA
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
 return clsvXzMajorEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvXzMajorEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzMajorEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvXzMajorEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvXzMajorEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdXzMajor">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdXzMajor)
{
strIdXzMajor = strIdXzMajor.Replace("'", "''");
if (strIdXzMajor.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vXzMajor中,检查关键字,长度不正确!(clsvXzMajorDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdXzMajor)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vXzMajor中,关键字不能为空 或 null!(clsvXzMajorDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdXzMajor);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvXzMajorDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvXzMajorDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from vXzMajor where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vXzMajor(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvXzMajorDA: GetDataTable_vXzMajor)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from vXzMajor where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvXzMajorDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvXzMajorDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from vXzMajor where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvXzMajorDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvXzMajorDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzMajor where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzMajor where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvXzMajorDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vXzMajor where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvXzMajorDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vXzMajor.* from vXzMajor Left Join {1} on {2} where {3} and vXzMajor.IdXzMajor not in (Select top {5} vXzMajor.IdXzMajor from vXzMajor Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzMajor where {1} and IdXzMajor not in (Select top {2} IdXzMajor from vXzMajor where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzMajor where {1} and IdXzMajor not in (Select top {3} IdXzMajor from vXzMajor where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvXzMajorDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vXzMajor.* from vXzMajor Left Join {1} on {2} where {3} and vXzMajor.IdXzMajor not in (Select top {5} vXzMajor.IdXzMajor from vXzMajor Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzMajor where {1} and IdXzMajor not in (Select top {2} IdXzMajor from vXzMajor where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzMajor where {1} and IdXzMajor not in (Select top {3} IdXzMajor from vXzMajor where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvXzMajorEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvXzMajorDA:GetObjLst)", objException.Message));
}
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from vXzMajor where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.IdXzMajor = objRow[convXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //专业ID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.MajorEnglishName = objRow[convXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[convXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objvXzMajorEN.MajorExplain = objRow[convXzMajor.MajorExplain] == DBNull.Value ? null : objRow[convXzMajor.MajorExplain].ToString().Trim(); //专业说明
objvXzMajorEN.MajorNationalID = objRow[convXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[convXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objvXzMajorEN.IdXzCollege = objRow[convXzMajor.IdXzCollege] == DBNull.Value ? null : objRow[convXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院ID
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.CollegeNameA = objRow[convXzMajor.CollegeNameA] == DBNull.Value ? null : objRow[convXzMajor.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzMajorEN.IdMajorType = objRow[convXzMajor.IdMajorType] == DBNull.Value ? null : objRow[convXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objvXzMajorEN.MajorTypeName = objRow[convXzMajor.MajorTypeName].ToString().Trim(); //专业类型名称
objvXzMajorEN.IdDegreeType = objRow[convXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[convXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objvXzMajorEN.XwTypeDesc = objRow[convXzMajor.XwTypeDesc].ToString().Trim(); //学位类型名称
objvXzMajorEN.IsMainMajor = TransNullToBool(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.MajorDirection = objRow[convXzMajor.MajorDirection] == DBNull.Value ? null : objRow[convXzMajor.MajorDirection].ToString().Trim(); //专业方向
objvXzMajorEN.IsVisible = TransNullToBool(objRow[convXzMajor.IsVisible].ToString().Trim()); //是否显示
objvXzMajorEN.IsNormal = TransNullToBool(objRow[convXzMajor.IsNormal].ToString().Trim()); //IsNormal
objvXzMajorEN.ModifyDate = objRow[convXzMajor.ModifyDate] == DBNull.Value ? null : objRow[convXzMajor.ModifyDate].ToString().Trim(); //修改日期
objvXzMajorEN.ModifyUserId = objRow[convXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[convXzMajor.ModifyUserId].ToString().Trim(); //修改人
objvXzMajorEN.Memo = objRow[convXzMajor.Memo] == DBNull.Value ? null : objRow[convXzMajor.Memo].ToString().Trim(); //备注
objvXzMajorEN.IsVisible4XzClg = TransNullToBool(objRow[convXzMajor.IsVisible4XzClg].ToString().Trim()); //IsVisible4XzClg
objvXzMajorEN.TypeName = objRow[convXzMajor.TypeName] == DBNull.Value ? null : objRow[convXzMajor.TypeName].ToString().Trim(); //类型名称
objvXzMajorEN.IdXzMajorShoolType = objRow[convXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[convXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvXzMajorDA: GetObjLst)", objException.Message));
}
objvXzMajorEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvXzMajorEN);
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
public List<clsvXzMajorEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvXzMajorDA:GetObjLstByTabName)", objException.Message));
}
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.IdXzMajor = objRow[convXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //专业ID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.MajorEnglishName = objRow[convXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[convXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objvXzMajorEN.MajorExplain = objRow[convXzMajor.MajorExplain] == DBNull.Value ? null : objRow[convXzMajor.MajorExplain].ToString().Trim(); //专业说明
objvXzMajorEN.MajorNationalID = objRow[convXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[convXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objvXzMajorEN.IdXzCollege = objRow[convXzMajor.IdXzCollege] == DBNull.Value ? null : objRow[convXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院ID
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.CollegeNameA = objRow[convXzMajor.CollegeNameA] == DBNull.Value ? null : objRow[convXzMajor.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzMajorEN.IdMajorType = objRow[convXzMajor.IdMajorType] == DBNull.Value ? null : objRow[convXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objvXzMajorEN.MajorTypeName = objRow[convXzMajor.MajorTypeName].ToString().Trim(); //专业类型名称
objvXzMajorEN.IdDegreeType = objRow[convXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[convXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objvXzMajorEN.XwTypeDesc = objRow[convXzMajor.XwTypeDesc].ToString().Trim(); //学位类型名称
objvXzMajorEN.IsMainMajor = TransNullToBool(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.MajorDirection = objRow[convXzMajor.MajorDirection] == DBNull.Value ? null : objRow[convXzMajor.MajorDirection].ToString().Trim(); //专业方向
objvXzMajorEN.IsVisible = TransNullToBool(objRow[convXzMajor.IsVisible].ToString().Trim()); //是否显示
objvXzMajorEN.IsNormal = TransNullToBool(objRow[convXzMajor.IsNormal].ToString().Trim()); //IsNormal
objvXzMajorEN.ModifyDate = objRow[convXzMajor.ModifyDate] == DBNull.Value ? null : objRow[convXzMajor.ModifyDate].ToString().Trim(); //修改日期
objvXzMajorEN.ModifyUserId = objRow[convXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[convXzMajor.ModifyUserId].ToString().Trim(); //修改人
objvXzMajorEN.Memo = objRow[convXzMajor.Memo] == DBNull.Value ? null : objRow[convXzMajor.Memo].ToString().Trim(); //备注
objvXzMajorEN.IsVisible4XzClg = TransNullToBool(objRow[convXzMajor.IsVisible4XzClg].ToString().Trim()); //IsVisible4XzClg
objvXzMajorEN.TypeName = objRow[convXzMajor.TypeName] == DBNull.Value ? null : objRow[convXzMajor.TypeName].ToString().Trim(); //类型名称
objvXzMajorEN.IdXzMajorShoolType = objRow[convXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[convXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvXzMajorDA: GetObjLst)", objException.Message));
}
objvXzMajorEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvXzMajorEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvXzMajor(ref clsvXzMajorEN objvXzMajorEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from vXzMajor where IdXzMajor = " + "'"+ objvXzMajorEN.IdXzMajor+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvXzMajorEN.IdXzMajor = objDT.Rows[0][convXzMajor.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvXzMajorEN.MajorID = objDT.Rows[0][convXzMajor.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvXzMajorEN.MajorName = objDT.Rows[0][convXzMajor.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvXzMajorEN.MajorEnglishName = objDT.Rows[0][convXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvXzMajorEN.MajorExplain = objDT.Rows[0][convXzMajor.MajorExplain].ToString().Trim(); //专业说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvXzMajorEN.MajorNationalID = objDT.Rows[0][convXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码(字段类型:varchar,字段长度:10,是否可空:True)
 objvXzMajorEN.IdXzCollege = objDT.Rows[0][convXzMajor.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzMajorEN.CollegeId = objDT.Rows[0][convXzMajor.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvXzMajorEN.CollegeName = objDT.Rows[0][convXzMajor.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvXzMajorEN.CollegeNameA = objDT.Rows[0][convXzMajor.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvXzMajorEN.IdMajorType = objDT.Rows[0][convXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号(字段类型:char,字段长度:4,是否可空:False)
 objvXzMajorEN.MajorTypeName = objDT.Rows[0][convXzMajor.MajorTypeName].ToString().Trim(); //专业类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvXzMajorEN.IdDegreeType = objDT.Rows[0][convXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvXzMajorEN.XwTypeDesc = objDT.Rows[0][convXzMajor.XwTypeDesc].ToString().Trim(); //学位类型名称(字段类型:varchar,字段长度:60,是否可空:False)
 objvXzMajorEN.IsMainMajor = TransNullToBool(objDT.Rows[0][convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业(字段类型:bit,字段长度:1,是否可空:False)
 objvXzMajorEN.MajorDirection = objDT.Rows[0][convXzMajor.MajorDirection].ToString().Trim(); //专业方向(字段类型:varchar,字段长度:30,是否可空:True)
 objvXzMajorEN.IsVisible = TransNullToBool(objDT.Rows[0][convXzMajor.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvXzMajorEN.IsNormal = TransNullToBool(objDT.Rows[0][convXzMajor.IsNormal].ToString().Trim()); //IsNormal(字段类型:bit,字段长度:1,是否可空:True)
 objvXzMajorEN.ModifyDate = objDT.Rows[0][convXzMajor.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzMajorEN.ModifyUserId = objDT.Rows[0][convXzMajor.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objvXzMajorEN.Memo = objDT.Rows[0][convXzMajor.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvXzMajorEN.IsVisible4XzClg = TransNullToBool(objDT.Rows[0][convXzMajor.IsVisible4XzClg].ToString().Trim()); //IsVisible4XzClg(字段类型:bit,字段长度:1,是否可空:True)
 objvXzMajorEN.TypeName = objDT.Rows[0][convXzMajor.TypeName].ToString().Trim(); //类型名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvXzMajorEN.IdXzMajorShoolType = objDT.Rows[0][convXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvXzMajorDA: GetvXzMajor)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdXzMajor">表关键字</param>
 /// <returns>表对象</returns>
public clsvXzMajorEN GetObjByIdXzMajor(string strIdXzMajor)
{
CheckPrimaryKey(strIdXzMajor);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from vXzMajor where IdXzMajor = " + "'"+ strIdXzMajor+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
 objvXzMajorEN.IdXzMajor = objRow[convXzMajor.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvXzMajorEN.MajorEnglishName = objRow[convXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[convXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvXzMajorEN.MajorExplain = objRow[convXzMajor.MajorExplain] == DBNull.Value ? null : objRow[convXzMajor.MajorExplain].ToString().Trim(); //专业说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvXzMajorEN.MajorNationalID = objRow[convXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[convXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码(字段类型:varchar,字段长度:10,是否可空:True)
 objvXzMajorEN.IdXzCollege = objRow[convXzMajor.IdXzCollege] == DBNull.Value ? null : objRow[convXzMajor.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvXzMajorEN.CollegeNameA = objRow[convXzMajor.CollegeNameA] == DBNull.Value ? null : objRow[convXzMajor.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvXzMajorEN.IdMajorType = objRow[convXzMajor.IdMajorType] == DBNull.Value ? null : objRow[convXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号(字段类型:char,字段长度:4,是否可空:False)
 objvXzMajorEN.MajorTypeName = objRow[convXzMajor.MajorTypeName].ToString().Trim(); //专业类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvXzMajorEN.IdDegreeType = objRow[convXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[convXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvXzMajorEN.XwTypeDesc = objRow[convXzMajor.XwTypeDesc].ToString().Trim(); //学位类型名称(字段类型:varchar,字段长度:60,是否可空:False)
 objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业(字段类型:bit,字段长度:1,是否可空:False)
 objvXzMajorEN.MajorDirection = objRow[convXzMajor.MajorDirection] == DBNull.Value ? null : objRow[convXzMajor.MajorDirection].ToString().Trim(); //专业方向(字段类型:varchar,字段长度:30,是否可空:True)
 objvXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsNormal].ToString().Trim()); //IsNormal(字段类型:bit,字段长度:1,是否可空:True)
 objvXzMajorEN.ModifyDate = objRow[convXzMajor.ModifyDate] == DBNull.Value ? null : objRow[convXzMajor.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzMajorEN.ModifyUserId = objRow[convXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[convXzMajor.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objvXzMajorEN.Memo = objRow[convXzMajor.Memo] == DBNull.Value ? null : objRow[convXzMajor.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvXzMajorEN.IsVisible4XzClg = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible4XzClg].ToString().Trim()); //IsVisible4XzClg(字段类型:bit,字段长度:1,是否可空:True)
 objvXzMajorEN.TypeName = objRow[convXzMajor.TypeName] == DBNull.Value ? null : objRow[convXzMajor.TypeName].ToString().Trim(); //类型名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvXzMajorEN.IdXzMajorShoolType = objRow[convXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[convXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvXzMajorDA: GetObjByIdXzMajor)", objException.Message));
}
return objvXzMajorEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvXzMajorEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvXzMajorDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from vXzMajor where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN()
{
IdXzMajor = objRow[convXzMajor.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convXzMajor.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convXzMajor.MajorName].ToString().Trim(), //专业名称
MajorEnglishName = objRow[convXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[convXzMajor.MajorEnglishName].ToString().Trim(), //专业英文名称
MajorExplain = objRow[convXzMajor.MajorExplain] == DBNull.Value ? null : objRow[convXzMajor.MajorExplain].ToString().Trim(), //专业说明
MajorNationalID = objRow[convXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[convXzMajor.MajorNationalID].ToString().Trim(), //专业国家代码
IdXzCollege = objRow[convXzMajor.IdXzCollege] == DBNull.Value ? null : objRow[convXzMajor.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convXzMajor.CollegeNameA] == DBNull.Value ? null : objRow[convXzMajor.CollegeNameA].ToString().Trim(), //学院名称简写
IdMajorType = objRow[convXzMajor.IdMajorType] == DBNull.Value ? null : objRow[convXzMajor.IdMajorType].ToString().Trim(), //专业类型(文理工)流水号
MajorTypeName = objRow[convXzMajor.MajorTypeName].ToString().Trim(), //专业类型名称
IdDegreeType = objRow[convXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[convXzMajor.IdDegreeType].ToString().Trim(), //学位类型流水号
XwTypeDesc = objRow[convXzMajor.XwTypeDesc].ToString().Trim(), //学位类型名称
IsMainMajor = TransNullToBool(objRow[convXzMajor.IsMainMajor].ToString().Trim()), //是否重要专业
MajorDirection = objRow[convXzMajor.MajorDirection] == DBNull.Value ? null : objRow[convXzMajor.MajorDirection].ToString().Trim(), //专业方向
IsVisible = TransNullToBool(objRow[convXzMajor.IsVisible].ToString().Trim()), //是否显示
IsNormal = TransNullToBool(objRow[convXzMajor.IsNormal].ToString().Trim()), //IsNormal
ModifyDate = objRow[convXzMajor.ModifyDate] == DBNull.Value ? null : objRow[convXzMajor.ModifyDate].ToString().Trim(), //修改日期
ModifyUserId = objRow[convXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[convXzMajor.ModifyUserId].ToString().Trim(), //修改人
Memo = objRow[convXzMajor.Memo] == DBNull.Value ? null : objRow[convXzMajor.Memo].ToString().Trim(), //备注
IsVisible4XzClg = TransNullToBool(objRow[convXzMajor.IsVisible4XzClg].ToString().Trim()), //IsVisible4XzClg
TypeName = objRow[convXzMajor.TypeName] == DBNull.Value ? null : objRow[convXzMajor.TypeName].ToString().Trim(), //类型名称
IdXzMajorShoolType = objRow[convXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[convXzMajor.IdXzMajorShoolType].ToString().Trim() //专业学校类型流水号
};
objvXzMajorEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzMajorEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvXzMajorDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvXzMajorEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.IdXzMajor = objRow[convXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //专业ID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.MajorEnglishName = objRow[convXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[convXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objvXzMajorEN.MajorExplain = objRow[convXzMajor.MajorExplain] == DBNull.Value ? null : objRow[convXzMajor.MajorExplain].ToString().Trim(); //专业说明
objvXzMajorEN.MajorNationalID = objRow[convXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[convXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objvXzMajorEN.IdXzCollege = objRow[convXzMajor.IdXzCollege] == DBNull.Value ? null : objRow[convXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院ID
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.CollegeNameA = objRow[convXzMajor.CollegeNameA] == DBNull.Value ? null : objRow[convXzMajor.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzMajorEN.IdMajorType = objRow[convXzMajor.IdMajorType] == DBNull.Value ? null : objRow[convXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objvXzMajorEN.MajorTypeName = objRow[convXzMajor.MajorTypeName].ToString().Trim(); //专业类型名称
objvXzMajorEN.IdDegreeType = objRow[convXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[convXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objvXzMajorEN.XwTypeDesc = objRow[convXzMajor.XwTypeDesc].ToString().Trim(); //学位类型名称
objvXzMajorEN.IsMainMajor = TransNullToBool(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.MajorDirection = objRow[convXzMajor.MajorDirection] == DBNull.Value ? null : objRow[convXzMajor.MajorDirection].ToString().Trim(); //专业方向
objvXzMajorEN.IsVisible = TransNullToBool(objRow[convXzMajor.IsVisible].ToString().Trim()); //是否显示
objvXzMajorEN.IsNormal = TransNullToBool(objRow[convXzMajor.IsNormal].ToString().Trim()); //IsNormal
objvXzMajorEN.ModifyDate = objRow[convXzMajor.ModifyDate] == DBNull.Value ? null : objRow[convXzMajor.ModifyDate].ToString().Trim(); //修改日期
objvXzMajorEN.ModifyUserId = objRow[convXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[convXzMajor.ModifyUserId].ToString().Trim(); //修改人
objvXzMajorEN.Memo = objRow[convXzMajor.Memo] == DBNull.Value ? null : objRow[convXzMajor.Memo].ToString().Trim(); //备注
objvXzMajorEN.IsVisible4XzClg = TransNullToBool(objRow[convXzMajor.IsVisible4XzClg].ToString().Trim()); //IsVisible4XzClg
objvXzMajorEN.TypeName = objRow[convXzMajor.TypeName] == DBNull.Value ? null : objRow[convXzMajor.TypeName].ToString().Trim(); //类型名称
objvXzMajorEN.IdXzMajorShoolType = objRow[convXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[convXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvXzMajorDA: GetObjByDataRowvXzMajor)", objException.Message));
}
objvXzMajorEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzMajorEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvXzMajorEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.IdXzMajor = objRow[convXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //专业ID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.MajorEnglishName = objRow[convXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[convXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objvXzMajorEN.MajorExplain = objRow[convXzMajor.MajorExplain] == DBNull.Value ? null : objRow[convXzMajor.MajorExplain].ToString().Trim(); //专业说明
objvXzMajorEN.MajorNationalID = objRow[convXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[convXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objvXzMajorEN.IdXzCollege = objRow[convXzMajor.IdXzCollege] == DBNull.Value ? null : objRow[convXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院ID
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.CollegeNameA = objRow[convXzMajor.CollegeNameA] == DBNull.Value ? null : objRow[convXzMajor.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzMajorEN.IdMajorType = objRow[convXzMajor.IdMajorType] == DBNull.Value ? null : objRow[convXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objvXzMajorEN.MajorTypeName = objRow[convXzMajor.MajorTypeName].ToString().Trim(); //专业类型名称
objvXzMajorEN.IdDegreeType = objRow[convXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[convXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objvXzMajorEN.XwTypeDesc = objRow[convXzMajor.XwTypeDesc].ToString().Trim(); //学位类型名称
objvXzMajorEN.IsMainMajor = TransNullToBool(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.MajorDirection = objRow[convXzMajor.MajorDirection] == DBNull.Value ? null : objRow[convXzMajor.MajorDirection].ToString().Trim(); //专业方向
objvXzMajorEN.IsVisible = TransNullToBool(objRow[convXzMajor.IsVisible].ToString().Trim()); //是否显示
objvXzMajorEN.IsNormal = TransNullToBool(objRow[convXzMajor.IsNormal].ToString().Trim()); //IsNormal
objvXzMajorEN.ModifyDate = objRow[convXzMajor.ModifyDate] == DBNull.Value ? null : objRow[convXzMajor.ModifyDate].ToString().Trim(); //修改日期
objvXzMajorEN.ModifyUserId = objRow[convXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[convXzMajor.ModifyUserId].ToString().Trim(); //修改人
objvXzMajorEN.Memo = objRow[convXzMajor.Memo] == DBNull.Value ? null : objRow[convXzMajor.Memo].ToString().Trim(); //备注
objvXzMajorEN.IsVisible4XzClg = TransNullToBool(objRow[convXzMajor.IsVisible4XzClg].ToString().Trim()); //IsVisible4XzClg
objvXzMajorEN.TypeName = objRow[convXzMajor.TypeName] == DBNull.Value ? null : objRow[convXzMajor.TypeName].ToString().Trim(); //类型名称
objvXzMajorEN.IdXzMajorShoolType = objRow[convXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[convXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvXzMajorDA: GetObjByDataRow)", objException.Message));
}
objvXzMajorEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzMajorEN;
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
objSQL = clsvXzMajorDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvXzMajorEN._CurrTabName, convXzMajor.IdXzMajor, 8, "");
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
objSQL = clsvXzMajorDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvXzMajorEN._CurrTabName, convXzMajor.IdXzMajor, 8, strPrefix);
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
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdXzMajor from vXzMajor where " + strCondition;
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
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdXzMajor from vXzMajor where " + strCondition;
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
 /// <param name = "strIdXzMajor">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdXzMajor)
{
CheckPrimaryKey(strIdXzMajor);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vXzMajor", "IdXzMajor = " + "'"+ strIdXzMajor+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvXzMajorDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vXzMajor", strCondition))
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
objSQL = clsvXzMajorDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vXzMajor");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvXzMajorENS">源对象</param>
 /// <param name = "objvXzMajorENT">目标对象</param>
public void CopyTo(clsvXzMajorEN objvXzMajorENS, clsvXzMajorEN objvXzMajorENT)
{
objvXzMajorENT.IdXzMajor = objvXzMajorENS.IdXzMajor; //专业流水号
objvXzMajorENT.MajorID = objvXzMajorENS.MajorID; //专业ID
objvXzMajorENT.MajorName = objvXzMajorENS.MajorName; //专业名称
objvXzMajorENT.MajorEnglishName = objvXzMajorENS.MajorEnglishName; //专业英文名称
objvXzMajorENT.MajorExplain = objvXzMajorENS.MajorExplain; //专业说明
objvXzMajorENT.MajorNationalID = objvXzMajorENS.MajorNationalID; //专业国家代码
objvXzMajorENT.IdXzCollege = objvXzMajorENS.IdXzCollege; //学院流水号
objvXzMajorENT.CollegeId = objvXzMajorENS.CollegeId; //学院ID
objvXzMajorENT.CollegeName = objvXzMajorENS.CollegeName; //学院名称
objvXzMajorENT.CollegeNameA = objvXzMajorENS.CollegeNameA; //学院名称简写
objvXzMajorENT.IdMajorType = objvXzMajorENS.IdMajorType; //专业类型(文理工)流水号
objvXzMajorENT.MajorTypeName = objvXzMajorENS.MajorTypeName; //专业类型名称
objvXzMajorENT.IdDegreeType = objvXzMajorENS.IdDegreeType; //学位类型流水号
objvXzMajorENT.XwTypeDesc = objvXzMajorENS.XwTypeDesc; //学位类型名称
objvXzMajorENT.IsMainMajor = objvXzMajorENS.IsMainMajor; //是否重要专业
objvXzMajorENT.MajorDirection = objvXzMajorENS.MajorDirection; //专业方向
objvXzMajorENT.IsVisible = objvXzMajorENS.IsVisible; //是否显示
objvXzMajorENT.IsNormal = objvXzMajorENS.IsNormal; //IsNormal
objvXzMajorENT.ModifyDate = objvXzMajorENS.ModifyDate; //修改日期
objvXzMajorENT.ModifyUserId = objvXzMajorENS.ModifyUserId; //修改人
objvXzMajorENT.Memo = objvXzMajorENS.Memo; //备注
objvXzMajorENT.IsVisible4XzClg = objvXzMajorENS.IsVisible4XzClg; //IsVisible4XzClg
objvXzMajorENT.TypeName = objvXzMajorENS.TypeName; //类型名称
objvXzMajorENT.IdXzMajorShoolType = objvXzMajorENS.IdXzMajorShoolType; //专业学校类型流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvXzMajorEN objvXzMajorEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvXzMajorEN.IdXzMajor, 8, convXzMajor.IdXzMajor);
clsCheckSql.CheckFieldLen(objvXzMajorEN.MajorID, 4, convXzMajor.MajorID);
clsCheckSql.CheckFieldLen(objvXzMajorEN.MajorName, 100, convXzMajor.MajorName);
clsCheckSql.CheckFieldLen(objvXzMajorEN.MajorEnglishName, 200, convXzMajor.MajorEnglishName);
clsCheckSql.CheckFieldLen(objvXzMajorEN.MajorExplain, 2000, convXzMajor.MajorExplain);
clsCheckSql.CheckFieldLen(objvXzMajorEN.MajorNationalID, 10, convXzMajor.MajorNationalID);
clsCheckSql.CheckFieldLen(objvXzMajorEN.IdXzCollege, 4, convXzMajor.IdXzCollege);
clsCheckSql.CheckFieldLen(objvXzMajorEN.CollegeId, 4, convXzMajor.CollegeId);
clsCheckSql.CheckFieldLen(objvXzMajorEN.CollegeName, 100, convXzMajor.CollegeName);
clsCheckSql.CheckFieldLen(objvXzMajorEN.CollegeNameA, 12, convXzMajor.CollegeNameA);
clsCheckSql.CheckFieldLen(objvXzMajorEN.IdMajorType, 4, convXzMajor.IdMajorType);
clsCheckSql.CheckFieldLen(objvXzMajorEN.MajorTypeName, 50, convXzMajor.MajorTypeName);
clsCheckSql.CheckFieldLen(objvXzMajorEN.IdDegreeType, 4, convXzMajor.IdDegreeType);
clsCheckSql.CheckFieldLen(objvXzMajorEN.XwTypeDesc, 60, convXzMajor.XwTypeDesc);
clsCheckSql.CheckFieldLen(objvXzMajorEN.MajorDirection, 30, convXzMajor.MajorDirection);
clsCheckSql.CheckFieldLen(objvXzMajorEN.ModifyDate, 20, convXzMajor.ModifyDate);
clsCheckSql.CheckFieldLen(objvXzMajorEN.ModifyUserId, 18, convXzMajor.ModifyUserId);
clsCheckSql.CheckFieldLen(objvXzMajorEN.Memo, 1000, convXzMajor.Memo);
clsCheckSql.CheckFieldLen(objvXzMajorEN.TypeName, 200, convXzMajor.TypeName);
clsCheckSql.CheckFieldLen(objvXzMajorEN.IdXzMajorShoolType, 4, convXzMajor.IdXzMajorShoolType);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.IdXzMajor, convXzMajor.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.MajorID, convXzMajor.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.MajorName, convXzMajor.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.MajorEnglishName, convXzMajor.MajorEnglishName);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.MajorExplain, convXzMajor.MajorExplain);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.MajorNationalID, convXzMajor.MajorNationalID);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.IdXzCollege, convXzMajor.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.CollegeId, convXzMajor.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.CollegeName, convXzMajor.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.CollegeNameA, convXzMajor.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.IdMajorType, convXzMajor.IdMajorType);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.MajorTypeName, convXzMajor.MajorTypeName);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.IdDegreeType, convXzMajor.IdDegreeType);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.XwTypeDesc, convXzMajor.XwTypeDesc);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.MajorDirection, convXzMajor.MajorDirection);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.ModifyDate, convXzMajor.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.ModifyUserId, convXzMajor.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.Memo, convXzMajor.Memo);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.TypeName, convXzMajor.TypeName);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorEN.IdXzMajorShoolType, convXzMajor.IdXzMajorShoolType);
//检查外键字段长度
 objvXzMajorEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdXzMajor()
{
//获取某学院所有专业信息
string strSQL = "select IdXzMajor, MajorName from vXzMajor ";
 clsSpecSQLforSql mySql = clsvXzMajorDA.GetSpecSQLObj();
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
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
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
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
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
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvXzMajorEN._CurrTabName);
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
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvXzMajorEN._CurrTabName, strCondition);
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
 objSQL = clsvXzMajorDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}