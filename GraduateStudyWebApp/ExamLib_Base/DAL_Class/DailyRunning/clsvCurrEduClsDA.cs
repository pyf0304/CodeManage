
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsDA
 表名:vCurrEduCls(01120126)
 * 版本:2024.03.11.1(服务器:WIN-SRV103-116)
 日期:2024/03/18 12:58:40
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
 /// v当前教学班(vCurrEduCls)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCurrEduClsDA : clsCommBase4DA
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
 return clsvCurrEduClsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCurrEduClsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCurrEduClsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCurrEduClsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCurrEduClsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdCurrEduCls)
{
strIdCurrEduCls = strIdCurrEduCls.Replace("'", "''");
if (strIdCurrEduCls.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vCurrEduCls中,检查关键字,长度不正确!(clsvCurrEduClsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCurrEduCls)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCurrEduCls中,关键字不能为空 或 null!(clsvCurrEduClsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCurrEduCls);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCurrEduClsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCurrEduClsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCurrEduCls(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCurrEduClsDA: GetDataTable_vCurrEduCls)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCurrEduClsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCurrEduClsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCurrEduClsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCurrEduClsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCurrEduClsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCurrEduCls where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCurrEduClsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCurrEduCls.* from vCurrEduCls Left Join {1} on {2} where {3} and vCurrEduCls.IdCurrEduCls not in (Select top {5} vCurrEduCls.IdCurrEduCls from vCurrEduCls Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls where {1} and IdCurrEduCls not in (Select top {2} IdCurrEduCls from vCurrEduCls where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls where {1} and IdCurrEduCls not in (Select top {3} IdCurrEduCls from vCurrEduCls where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCurrEduClsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCurrEduCls.* from vCurrEduCls Left Join {1} on {2} where {3} and vCurrEduCls.IdCurrEduCls not in (Select top {5} vCurrEduCls.IdCurrEduCls from vCurrEduCls Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls where {1} and IdCurrEduCls not in (Select top {2} IdCurrEduCls from vCurrEduCls where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls where {1} and IdCurrEduCls not in (Select top {3} IdCurrEduCls from vCurrEduCls where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCurrEduClsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCurrEduClsDA:GetObjLst)", objException.Message));
}
List<clsvCurrEduClsEN> arrObjLst = new List<clsvCurrEduClsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN();
try
{
objvCurrEduClsEN.IdCurrEduCls = objRow[convCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsEN.CurrEduClsId = objRow[convCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsEN.EduClsName = objRow[convCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsEN.EduClsTypeId = objRow[convCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsEN.EduClsTypeName = objRow[convCurrEduCls.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsEN.CourseId = objRow[convCurrEduCls.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsEN.CourseCode = objRow[convCurrEduCls.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsEN.CourseDescription = objRow[convCurrEduCls.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduClsEN.CourseName = objRow[convCurrEduCls.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsEN.ViewCount = objRow[convCurrEduCls.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.ViewCount].ToString().Trim()); //浏览量
objvCurrEduClsEN.ExampleImgPath = objRow[convCurrEduCls.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsEN.TeachingSolutionId = objRow[convCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsEN.TeachingSolutionName = objRow[convCurrEduCls.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduCls.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsEN.IdTeacher = objRow[convCurrEduCls.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduCls.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsEN.TeacherId = objRow[convCurrEduCls.TeacherId] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsEN.TeacherName = objRow[convCurrEduCls.TeacherName] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsEN.IdXzCollege = objRow[convCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsEN.CollegeId = objRow[convCurrEduCls.CollegeId] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsEN.CollegeName = objRow[convCurrEduCls.CollegeName] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsEN.ClgEnglishName = objRow[convCurrEduCls.ClgEnglishName] == DBNull.Value ? null : objRow[convCurrEduCls.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvCurrEduClsEN.PhoneNumber = objRow[convCurrEduCls.PhoneNumber] == DBNull.Value ? null : objRow[convCurrEduCls.PhoneNumber].ToString().Trim(); //电话
objvCurrEduClsEN.IdXzMajor = objRow[convCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduClsEN.MajorName = objRow[convCurrEduCls.MajorName] == DBNull.Value ? null : objRow[convCurrEduCls.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsEN.IdEduWay = objRow[convCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsEN.IdClassRoomType = objRow[convCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduClsEN.TotalLessonQty = TransNullToInt(objRow[convCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsEN.MaxStuQty = objRow[convCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsEN.WeekQty = objRow[convCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsEN.ScheUnitPW = objRow[convCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsEN.WeekStatusId = objRow[convCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsEN.CustomerWeek = objRow[convCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsEN.LessonQtyPerWeek = objRow[convCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsEN.Mark = objRow[convCurrEduCls.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduCls.Mark].ToString().Trim()); //获得学分
objvCurrEduClsEN.IdUniZone = objRow[convCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsEN.IdGradeBase = objRow[convCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsEN.GradeBaseId = objRow[convCurrEduCls.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsEN.GradeBaseName = objRow[convCurrEduCls.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsEN.GradeBaseNameA = objRow[convCurrEduCls.GradeBaseNameA] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduClsEN.IsEffective = TransNullToBool(objRow[convCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsEN.IsForPaperReading = TransNullToBool(objRow[convCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduClsEN.SchoolYear = objRow[convCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsEN.SchoolTerm = objRow[convCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsEN.IdCourseType = objRow[convCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsEN.CourseTypeId = objRow[convCurrEduCls.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsEN.CourseTypeName = objRow[convCurrEduCls.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsEN.IsDegree = TransNullToBool(objRow[convCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsEN.IdScoreType = objRow[convCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsEN.GetScoreWayId = objRow[convCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduClsEN.IsProportionalCtrl = TransNullToBool(objRow[convCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsEN.IdExamType = objRow[convCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[convCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsEN.BeginWeek = objRow[convCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsEN.UserType = objRow[convCurrEduCls.UserType] == DBNull.Value ? null : objRow[convCurrEduCls.UserType].ToString().Trim(); //用户类型
objvCurrEduClsEN.ModifyDate = objRow[convCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsEN.ModifyUserId = objRow[convCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsEN.Memo = objRow[convCurrEduCls.Memo] == DBNull.Value ? null : objRow[convCurrEduCls.Memo].ToString().Trim(); //备注
objvCurrEduClsEN.CurrStuNumValid = objRow[convCurrEduCls.CurrStuNumValid] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsEN.CurrStuNum = objRow[convCurrEduCls.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.CurrStuNum].ToString().Trim()); //当前学生数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCurrEduClsDA: GetObjLst)", objException.Message));
}
objvCurrEduClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCurrEduClsEN);
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
public List<clsvCurrEduClsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCurrEduClsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCurrEduClsEN> arrObjLst = new List<clsvCurrEduClsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN();
try
{
objvCurrEduClsEN.IdCurrEduCls = objRow[convCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsEN.CurrEduClsId = objRow[convCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsEN.EduClsName = objRow[convCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsEN.EduClsTypeId = objRow[convCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsEN.EduClsTypeName = objRow[convCurrEduCls.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsEN.CourseId = objRow[convCurrEduCls.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsEN.CourseCode = objRow[convCurrEduCls.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsEN.CourseDescription = objRow[convCurrEduCls.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduClsEN.CourseName = objRow[convCurrEduCls.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsEN.ViewCount = objRow[convCurrEduCls.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.ViewCount].ToString().Trim()); //浏览量
objvCurrEduClsEN.ExampleImgPath = objRow[convCurrEduCls.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsEN.TeachingSolutionId = objRow[convCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsEN.TeachingSolutionName = objRow[convCurrEduCls.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduCls.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsEN.IdTeacher = objRow[convCurrEduCls.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduCls.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsEN.TeacherId = objRow[convCurrEduCls.TeacherId] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsEN.TeacherName = objRow[convCurrEduCls.TeacherName] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsEN.IdXzCollege = objRow[convCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsEN.CollegeId = objRow[convCurrEduCls.CollegeId] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsEN.CollegeName = objRow[convCurrEduCls.CollegeName] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsEN.ClgEnglishName = objRow[convCurrEduCls.ClgEnglishName] == DBNull.Value ? null : objRow[convCurrEduCls.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvCurrEduClsEN.PhoneNumber = objRow[convCurrEduCls.PhoneNumber] == DBNull.Value ? null : objRow[convCurrEduCls.PhoneNumber].ToString().Trim(); //电话
objvCurrEduClsEN.IdXzMajor = objRow[convCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduClsEN.MajorName = objRow[convCurrEduCls.MajorName] == DBNull.Value ? null : objRow[convCurrEduCls.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsEN.IdEduWay = objRow[convCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsEN.IdClassRoomType = objRow[convCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduClsEN.TotalLessonQty = TransNullToInt(objRow[convCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsEN.MaxStuQty = objRow[convCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsEN.WeekQty = objRow[convCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsEN.ScheUnitPW = objRow[convCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsEN.WeekStatusId = objRow[convCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsEN.CustomerWeek = objRow[convCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsEN.LessonQtyPerWeek = objRow[convCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsEN.Mark = objRow[convCurrEduCls.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduCls.Mark].ToString().Trim()); //获得学分
objvCurrEduClsEN.IdUniZone = objRow[convCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsEN.IdGradeBase = objRow[convCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsEN.GradeBaseId = objRow[convCurrEduCls.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsEN.GradeBaseName = objRow[convCurrEduCls.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsEN.GradeBaseNameA = objRow[convCurrEduCls.GradeBaseNameA] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduClsEN.IsEffective = TransNullToBool(objRow[convCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsEN.IsForPaperReading = TransNullToBool(objRow[convCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduClsEN.SchoolYear = objRow[convCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsEN.SchoolTerm = objRow[convCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsEN.IdCourseType = objRow[convCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsEN.CourseTypeId = objRow[convCurrEduCls.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsEN.CourseTypeName = objRow[convCurrEduCls.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsEN.IsDegree = TransNullToBool(objRow[convCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsEN.IdScoreType = objRow[convCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsEN.GetScoreWayId = objRow[convCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduClsEN.IsProportionalCtrl = TransNullToBool(objRow[convCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsEN.IdExamType = objRow[convCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[convCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsEN.BeginWeek = objRow[convCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsEN.UserType = objRow[convCurrEduCls.UserType] == DBNull.Value ? null : objRow[convCurrEduCls.UserType].ToString().Trim(); //用户类型
objvCurrEduClsEN.ModifyDate = objRow[convCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsEN.ModifyUserId = objRow[convCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsEN.Memo = objRow[convCurrEduCls.Memo] == DBNull.Value ? null : objRow[convCurrEduCls.Memo].ToString().Trim(); //备注
objvCurrEduClsEN.CurrStuNumValid = objRow[convCurrEduCls.CurrStuNumValid] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsEN.CurrStuNum = objRow[convCurrEduCls.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.CurrStuNum].ToString().Trim()); //当前学生数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCurrEduClsDA: GetObjLst)", objException.Message));
}
objvCurrEduClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCurrEduClsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCurrEduClsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCurrEduCls(ref clsvCurrEduClsEN objvCurrEduClsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls where IdCurrEduCls = " + "'"+ objvCurrEduClsEN.IdCurrEduCls+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCurrEduClsEN.IdCurrEduCls = objDT.Rows[0][convCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsEN.CurrEduClsId = objDT.Rows[0][convCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objvCurrEduClsEN.EduClsName = objDT.Rows[0][convCurrEduCls.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsEN.EduClsTypeId = objDT.Rows[0][convCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsEN.EduClsTypeName = objDT.Rows[0][convCurrEduCls.EduClsTypeName].ToString().Trim(); //教学班类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduClsEN.CourseId = objDT.Rows[0][convCurrEduCls.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduClsEN.CourseCode = objDT.Rows[0][convCurrEduCls.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsEN.CourseDescription = objDT.Rows[0][convCurrEduCls.CourseDescription].ToString().Trim(); //课程描述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCurrEduClsEN.CourseName = objDT.Rows[0][convCurrEduCls.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduClsEN.ViewCount = TransNullToInt(objDT.Rows[0][convCurrEduCls.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsEN.ExampleImgPath = objDT.Rows[0][convCurrEduCls.ExampleImgPath].ToString().Trim(); //示例图路径(字段类型:varchar,字段长度:300,是否可空:True)
 objvCurrEduClsEN.TeachingSolutionId = objDT.Rows[0][convCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsEN.TeachingSolutionName = objDT.Rows[0][convCurrEduCls.TeachingSolutionName].ToString().Trim(); //教学方案名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsEN.IdTeacher = objDT.Rows[0][convCurrEduCls.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsEN.TeacherId = objDT.Rows[0][convCurrEduCls.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvCurrEduClsEN.TeacherName = objDT.Rows[0][convCurrEduCls.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCurrEduClsEN.IdXzCollege = objDT.Rows[0][convCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduClsEN.CollegeId = objDT.Rows[0][convCurrEduCls.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCurrEduClsEN.CollegeName = objDT.Rows[0][convCurrEduCls.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsEN.ClgEnglishName = objDT.Rows[0][convCurrEduCls.ClgEnglishName].ToString().Trim(); //ClgEnglishName(字段类型:varchar,字段长度:60,是否可空:True)
 objvCurrEduClsEN.PhoneNumber = objDT.Rows[0][convCurrEduCls.PhoneNumber].ToString().Trim(); //电话(字段类型:varchar,字段长度:15,是否可空:True)
 objvCurrEduClsEN.IdXzMajor = objDT.Rows[0][convCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsEN.MajorName = objDT.Rows[0][convCurrEduCls.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsEN.IdEduWay = objDT.Rows[0][convCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsEN.IdClassRoomType = objDT.Rows[0][convCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsEN.TotalLessonQty = TransNullToInt(objDT.Rows[0][convCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数(字段类型:int,字段长度:4,是否可空:False)
 objvCurrEduClsEN.MaxStuQty = TransNullToInt(objDT.Rows[0][convCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsEN.WeekQty = TransNullToInt(objDT.Rows[0][convCurrEduCls.WeekQty].ToString().Trim()); //总周数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsEN.ScheUnitPW = TransNullToShort(objDT.Rows[0][convCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数(字段类型:smallint,字段长度:2,是否可空:True)
 objvCurrEduClsEN.WeekStatusId = objDT.Rows[0][convCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)(字段类型:char,字段长度:2,是否可空:True)
 objvCurrEduClsEN.CustomerWeek = objDT.Rows[0][convCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周(字段类型:varchar,字段长度:50,是否可空:True)
 objvCurrEduClsEN.LessonQtyPerWeek = TransNullToShort(objDT.Rows[0][convCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数(字段类型:smallint,字段长度:2,是否可空:False)
 objvCurrEduClsEN.Mark = TransNullToDouble(objDT.Rows[0][convCurrEduCls.Mark].ToString().Trim()); //获得学分(字段类型:decimal,字段长度:7,是否可空:True)
 objvCurrEduClsEN.IdUniZone = objDT.Rows[0][convCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsEN.IdGradeBase = objDT.Rows[0][convCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduClsEN.GradeBaseId = objDT.Rows[0][convCurrEduCls.GradeBaseId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduClsEN.GradeBaseName = objDT.Rows[0][convCurrEduCls.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCurrEduClsEN.GradeBaseNameA = objDT.Rows[0][convCurrEduCls.GradeBaseNameA].ToString().Trim(); //年级名称缩写(字段类型:varchar,字段长度:10,是否可空:False)
 objvCurrEduClsEN.IsEffective = TransNullToBool(objDT.Rows[0][convCurrEduCls.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduClsEN.IsForPaperReading = TransNullToBool(objDT.Rows[0][convCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduClsEN.SchoolYear = objDT.Rows[0][convCurrEduCls.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objvCurrEduClsEN.SchoolTerm = objDT.Rows[0][convCurrEduCls.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objvCurrEduClsEN.IdCourseType = objDT.Rows[0][convCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsEN.CourseTypeId = objDT.Rows[0][convCurrEduCls.CourseTypeId].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsEN.CourseTypeName = objDT.Rows[0][convCurrEduCls.CourseTypeName].ToString().Trim(); //课程类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCurrEduClsEN.IsDegree = TransNullToBool(objDT.Rows[0][convCurrEduCls.IsDegree].ToString().Trim()); //是否学位课(字段类型:bit,字段长度:1,是否可空:False)
 objvCurrEduClsEN.IdScoreType = objDT.Rows[0][convCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsEN.GetScoreWayId = objDT.Rows[0][convCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id(字段类型:char,字段长度:2,是否可空:True)
 objvCurrEduClsEN.IsProportionalCtrl = TransNullToBool(objDT.Rows[0][convCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduClsEN.IdExamType = objDT.Rows[0][convCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsEN.BeginWeek = TransNullToShort(objDT.Rows[0][convCurrEduCls.BeginWeek].ToString().Trim()); //开始周(字段类型:smallint,字段长度:2,是否可空:True)
 objvCurrEduClsEN.UserType = objDT.Rows[0][convCurrEduCls.UserType].ToString().Trim(); //用户类型(字段类型:varchar,字段长度:50,是否可空:True)
 objvCurrEduClsEN.ModifyDate = objDT.Rows[0][convCurrEduCls.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsEN.ModifyUserId = objDT.Rows[0][convCurrEduCls.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objvCurrEduClsEN.Memo = objDT.Rows[0][convCurrEduCls.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCurrEduClsEN.CurrStuNumValid = TransNullToInt(objDT.Rows[0][convCurrEduCls.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsEN.CurrStuNum = TransNullToInt(objDT.Rows[0][convCurrEduCls.CurrStuNum].ToString().Trim()); //当前学生数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCurrEduClsDA: GetvCurrEduCls)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public clsvCurrEduClsEN GetObjByIdCurrEduCls(string strIdCurrEduCls)
{
CheckPrimaryKey(strIdCurrEduCls);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls where IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN();
try
{
 objvCurrEduClsEN.IdCurrEduCls = objRow[convCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsEN.CurrEduClsId = objRow[convCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objvCurrEduClsEN.EduClsName = objRow[convCurrEduCls.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsEN.EduClsTypeId = objRow[convCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsEN.EduClsTypeName = objRow[convCurrEduCls.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.EduClsTypeName].ToString().Trim(); //教学班类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduClsEN.CourseId = objRow[convCurrEduCls.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduClsEN.CourseCode = objRow[convCurrEduCls.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsEN.CourseDescription = objRow[convCurrEduCls.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls.CourseDescription].ToString().Trim(); //课程描述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCurrEduClsEN.CourseName = objRow[convCurrEduCls.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduClsEN.ViewCount = objRow[convCurrEduCls.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsEN.ExampleImgPath = objRow[convCurrEduCls.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls.ExampleImgPath].ToString().Trim(); //示例图路径(字段类型:varchar,字段长度:300,是否可空:True)
 objvCurrEduClsEN.TeachingSolutionId = objRow[convCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsEN.TeachingSolutionName = objRow[convCurrEduCls.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduCls.TeachingSolutionName].ToString().Trim(); //教学方案名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsEN.IdTeacher = objRow[convCurrEduCls.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduCls.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsEN.TeacherId = objRow[convCurrEduCls.TeacherId] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvCurrEduClsEN.TeacherName = objRow[convCurrEduCls.TeacherName] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCurrEduClsEN.IdXzCollege = objRow[convCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduClsEN.CollegeId = objRow[convCurrEduCls.CollegeId] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCurrEduClsEN.CollegeName = objRow[convCurrEduCls.CollegeName] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsEN.ClgEnglishName = objRow[convCurrEduCls.ClgEnglishName] == DBNull.Value ? null : objRow[convCurrEduCls.ClgEnglishName].ToString().Trim(); //ClgEnglishName(字段类型:varchar,字段长度:60,是否可空:True)
 objvCurrEduClsEN.PhoneNumber = objRow[convCurrEduCls.PhoneNumber] == DBNull.Value ? null : objRow[convCurrEduCls.PhoneNumber].ToString().Trim(); //电话(字段类型:varchar,字段长度:15,是否可空:True)
 objvCurrEduClsEN.IdXzMajor = objRow[convCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsEN.MajorName = objRow[convCurrEduCls.MajorName] == DBNull.Value ? null : objRow[convCurrEduCls.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsEN.IdEduWay = objRow[convCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsEN.IdClassRoomType = objRow[convCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数(字段类型:int,字段长度:4,是否可空:False)
 objvCurrEduClsEN.MaxStuQty = objRow[convCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsEN.WeekQty = objRow[convCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.WeekQty].ToString().Trim()); //总周数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsEN.ScheUnitPW = objRow[convCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数(字段类型:smallint,字段长度:2,是否可空:True)
 objvCurrEduClsEN.WeekStatusId = objRow[convCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)(字段类型:char,字段长度:2,是否可空:True)
 objvCurrEduClsEN.CustomerWeek = objRow[convCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周(字段类型:varchar,字段长度:50,是否可空:True)
 objvCurrEduClsEN.LessonQtyPerWeek = objRow[convCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数(字段类型:smallint,字段长度:2,是否可空:False)
 objvCurrEduClsEN.Mark = objRow[convCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls.Mark].ToString().Trim()); //获得学分(字段类型:decimal,字段长度:7,是否可空:True)
 objvCurrEduClsEN.IdUniZone = objRow[convCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsEN.IdGradeBase = objRow[convCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduClsEN.GradeBaseId = objRow[convCurrEduCls.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduClsEN.GradeBaseName = objRow[convCurrEduCls.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCurrEduClsEN.GradeBaseNameA = objRow[convCurrEduCls.GradeBaseNameA] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseNameA].ToString().Trim(); //年级名称缩写(字段类型:varchar,字段长度:10,是否可空:False)
 objvCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduClsEN.SchoolYear = objRow[convCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objvCurrEduClsEN.SchoolTerm = objRow[convCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objvCurrEduClsEN.IdCourseType = objRow[convCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsEN.CourseTypeId = objRow[convCurrEduCls.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeId].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsEN.CourseTypeName = objRow[convCurrEduCls.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeName].ToString().Trim(); //课程类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsDegree].ToString().Trim()); //是否学位课(字段类型:bit,字段长度:1,是否可空:False)
 objvCurrEduClsEN.IdScoreType = objRow[convCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsEN.GetScoreWayId = objRow[convCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id(字段类型:char,字段长度:2,是否可空:True)
 objvCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduClsEN.IdExamType = objRow[convCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[convCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsEN.BeginWeek = objRow[convCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls.BeginWeek].ToString().Trim()); //开始周(字段类型:smallint,字段长度:2,是否可空:True)
 objvCurrEduClsEN.UserType = objRow[convCurrEduCls.UserType] == DBNull.Value ? null : objRow[convCurrEduCls.UserType].ToString().Trim(); //用户类型(字段类型:varchar,字段长度:50,是否可空:True)
 objvCurrEduClsEN.ModifyDate = objRow[convCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsEN.ModifyUserId = objRow[convCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objvCurrEduClsEN.Memo = objRow[convCurrEduCls.Memo] == DBNull.Value ? null : objRow[convCurrEduCls.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCurrEduClsEN.CurrStuNumValid = objRow[convCurrEduCls.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsEN.CurrStuNum = objRow[convCurrEduCls.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls.CurrStuNum].ToString().Trim()); //当前学生数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCurrEduClsDA: GetObjByIdCurrEduCls)", objException.Message));
}
return objvCurrEduClsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCurrEduClsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCurrEduClsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN()
{
IdCurrEduCls = objRow[convCurrEduCls.IdCurrEduCls].ToString().Trim(), //教学班流水号
CurrEduClsId = objRow[convCurrEduCls.CurrEduClsId].ToString().Trim(), //教学班Id
EduClsName = objRow[convCurrEduCls.EduClsName].ToString().Trim(), //教学班名
EduClsTypeId = objRow[convCurrEduCls.EduClsTypeId].ToString().Trim(), //教学班类型Id
EduClsTypeName = objRow[convCurrEduCls.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.EduClsTypeName].ToString().Trim(), //教学班类型名称
CourseId = objRow[convCurrEduCls.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCurrEduCls.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls.CourseCode].ToString().Trim(), //课程代码
CourseDescription = objRow[convCurrEduCls.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls.CourseDescription].ToString().Trim(), //课程描述
CourseName = objRow[convCurrEduCls.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseName].ToString().Trim(), //课程名称
ViewCount = objRow[convCurrEduCls.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.ViewCount].ToString().Trim()), //浏览量
ExampleImgPath = objRow[convCurrEduCls.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls.ExampleImgPath].ToString().Trim(), //示例图路径
TeachingSolutionId = objRow[convCurrEduCls.TeachingSolutionId].ToString().Trim(), //教学方案Id
TeachingSolutionName = objRow[convCurrEduCls.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduCls.TeachingSolutionName].ToString().Trim(), //教学方案名称
IdTeacher = objRow[convCurrEduCls.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduCls.IdTeacher].ToString().Trim(), //教师流水号
TeacherId = objRow[convCurrEduCls.TeacherId] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherId].ToString().Trim(), //教师工号
TeacherName = objRow[convCurrEduCls.TeacherName] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherName].ToString().Trim(), //教师姓名
IdXzCollege = objRow[convCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convCurrEduCls.CollegeId] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convCurrEduCls.CollegeName] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeName].ToString().Trim(), //学院名称
ClgEnglishName = objRow[convCurrEduCls.ClgEnglishName] == DBNull.Value ? null : objRow[convCurrEduCls.ClgEnglishName].ToString().Trim(), //ClgEnglishName
PhoneNumber = objRow[convCurrEduCls.PhoneNumber] == DBNull.Value ? null : objRow[convCurrEduCls.PhoneNumber].ToString().Trim(), //电话
IdXzMajor = objRow[convCurrEduCls.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convCurrEduCls.MajorName] == DBNull.Value ? null : objRow[convCurrEduCls.MajorName].ToString().Trim(), //专业名称
IdEduWay = objRow[convCurrEduCls.IdEduWay].ToString().Trim(), //教学方式流水号
IdClassRoomType = objRow[convCurrEduCls.IdClassRoomType].ToString().Trim(), //教室类型流水号
TotalLessonQty = TransNullToInt(objRow[convCurrEduCls.TotalLessonQty].ToString().Trim()), //总课时数
MaxStuQty = objRow[convCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.MaxStuQty].ToString().Trim()), //最大学生数
WeekQty = objRow[convCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.WeekQty].ToString().Trim()), //总周数
ScheUnitPW = objRow[convCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls.ScheUnitPW].ToString().Trim()), //周排课次数
WeekStatusId = objRow[convCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls.WeekStatusId].ToString().Trim(), //周状态编号(单,双,全周)
CustomerWeek = objRow[convCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls.CustomerWeek].ToString().Trim(), //自定义上课周
LessonQtyPerWeek = objRow[convCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls.LessonQtyPerWeek].ToString().Trim()), //周课时数
Mark = objRow[convCurrEduCls.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduCls.Mark].ToString().Trim()), //获得学分
IdUniZone = objRow[convCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduCls.IdUniZone].ToString().Trim(), //校区流水号
IdGradeBase = objRow[convCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseId = objRow[convCurrEduCls.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseId].ToString().Trim(), //年级代号
GradeBaseName = objRow[convCurrEduCls.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseName].ToString().Trim(), //年级名称
GradeBaseNameA = objRow[convCurrEduCls.GradeBaseNameA] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseNameA].ToString().Trim(), //年级名称缩写
IsEffective = TransNullToBool(objRow[convCurrEduCls.IsEffective].ToString().Trim()), //是否有效
IsForPaperReading = TransNullToBool(objRow[convCurrEduCls.IsForPaperReading].ToString().Trim()), //是否参与论文阅读
SchoolYear = objRow[convCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolYear].ToString().Trim(), //学年
SchoolTerm = objRow[convCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolTerm].ToString().Trim(), //学期
IdCourseType = objRow[convCurrEduCls.IdCourseType].ToString().Trim(), //课程类型流水号
CourseTypeId = objRow[convCurrEduCls.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeId].ToString().Trim(), //课程类型ID
CourseTypeName = objRow[convCurrEduCls.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeName].ToString().Trim(), //课程类型名称
IsDegree = TransNullToBool(objRow[convCurrEduCls.IsDegree].ToString().Trim()), //是否学位课
IdScoreType = objRow[convCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduCls.IdScoreType].ToString().Trim(), //成绩类型流水号
GetScoreWayId = objRow[convCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls.GetScoreWayId].ToString().Trim(), //获得成绩方式Id
IsProportionalCtrl = TransNullToBool(objRow[convCurrEduCls.IsProportionalCtrl].ToString().Trim()), //是否比例控制
IdExamType = objRow[convCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[convCurrEduCls.IdExamType].ToString().Trim(), //考试方式流水号
BeginWeek = objRow[convCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls.BeginWeek].ToString().Trim()), //开始周
UserType = objRow[convCurrEduCls.UserType] == DBNull.Value ? null : objRow[convCurrEduCls.UserType].ToString().Trim(), //用户类型
ModifyDate = objRow[convCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyDate].ToString().Trim(), //修改日期
ModifyUserId = objRow[convCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyUserId].ToString().Trim(), //修改人
Memo = objRow[convCurrEduCls.Memo] == DBNull.Value ? null : objRow[convCurrEduCls.Memo].ToString().Trim(), //备注
CurrStuNumValid = objRow[convCurrEduCls.CurrStuNumValid] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.CurrStuNumValid].ToString().Trim()), //CurrStuNum_Valid
CurrStuNum = objRow[convCurrEduCls.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.CurrStuNum].ToString().Trim()) //当前学生数
};
objvCurrEduClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCurrEduClsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCurrEduClsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCurrEduClsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN();
try
{
objvCurrEduClsEN.IdCurrEduCls = objRow[convCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsEN.CurrEduClsId = objRow[convCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsEN.EduClsName = objRow[convCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsEN.EduClsTypeId = objRow[convCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsEN.EduClsTypeName = objRow[convCurrEduCls.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsEN.CourseId = objRow[convCurrEduCls.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsEN.CourseCode = objRow[convCurrEduCls.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsEN.CourseDescription = objRow[convCurrEduCls.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduClsEN.CourseName = objRow[convCurrEduCls.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsEN.ViewCount = objRow[convCurrEduCls.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.ViewCount].ToString().Trim()); //浏览量
objvCurrEduClsEN.ExampleImgPath = objRow[convCurrEduCls.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsEN.TeachingSolutionId = objRow[convCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsEN.TeachingSolutionName = objRow[convCurrEduCls.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduCls.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsEN.IdTeacher = objRow[convCurrEduCls.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduCls.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsEN.TeacherId = objRow[convCurrEduCls.TeacherId] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsEN.TeacherName = objRow[convCurrEduCls.TeacherName] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsEN.IdXzCollege = objRow[convCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsEN.CollegeId = objRow[convCurrEduCls.CollegeId] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsEN.CollegeName = objRow[convCurrEduCls.CollegeName] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsEN.ClgEnglishName = objRow[convCurrEduCls.ClgEnglishName] == DBNull.Value ? null : objRow[convCurrEduCls.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvCurrEduClsEN.PhoneNumber = objRow[convCurrEduCls.PhoneNumber] == DBNull.Value ? null : objRow[convCurrEduCls.PhoneNumber].ToString().Trim(); //电话
objvCurrEduClsEN.IdXzMajor = objRow[convCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduClsEN.MajorName = objRow[convCurrEduCls.MajorName] == DBNull.Value ? null : objRow[convCurrEduCls.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsEN.IdEduWay = objRow[convCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsEN.IdClassRoomType = objRow[convCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduClsEN.TotalLessonQty = TransNullToInt(objRow[convCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsEN.MaxStuQty = objRow[convCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsEN.WeekQty = objRow[convCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsEN.ScheUnitPW = objRow[convCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsEN.WeekStatusId = objRow[convCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsEN.CustomerWeek = objRow[convCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsEN.LessonQtyPerWeek = objRow[convCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsEN.Mark = objRow[convCurrEduCls.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduCls.Mark].ToString().Trim()); //获得学分
objvCurrEduClsEN.IdUniZone = objRow[convCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsEN.IdGradeBase = objRow[convCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsEN.GradeBaseId = objRow[convCurrEduCls.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsEN.GradeBaseName = objRow[convCurrEduCls.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsEN.GradeBaseNameA = objRow[convCurrEduCls.GradeBaseNameA] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduClsEN.IsEffective = TransNullToBool(objRow[convCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsEN.IsForPaperReading = TransNullToBool(objRow[convCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduClsEN.SchoolYear = objRow[convCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsEN.SchoolTerm = objRow[convCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsEN.IdCourseType = objRow[convCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsEN.CourseTypeId = objRow[convCurrEduCls.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsEN.CourseTypeName = objRow[convCurrEduCls.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsEN.IsDegree = TransNullToBool(objRow[convCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsEN.IdScoreType = objRow[convCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsEN.GetScoreWayId = objRow[convCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduClsEN.IsProportionalCtrl = TransNullToBool(objRow[convCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsEN.IdExamType = objRow[convCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[convCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsEN.BeginWeek = objRow[convCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsEN.UserType = objRow[convCurrEduCls.UserType] == DBNull.Value ? null : objRow[convCurrEduCls.UserType].ToString().Trim(); //用户类型
objvCurrEduClsEN.ModifyDate = objRow[convCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsEN.ModifyUserId = objRow[convCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsEN.Memo = objRow[convCurrEduCls.Memo] == DBNull.Value ? null : objRow[convCurrEduCls.Memo].ToString().Trim(); //备注
objvCurrEduClsEN.CurrStuNumValid = objRow[convCurrEduCls.CurrStuNumValid] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsEN.CurrStuNum = objRow[convCurrEduCls.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.CurrStuNum].ToString().Trim()); //当前学生数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCurrEduClsDA: GetObjByDataRowvCurrEduCls)", objException.Message));
}
objvCurrEduClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCurrEduClsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCurrEduClsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCurrEduClsEN objvCurrEduClsEN = new clsvCurrEduClsEN();
try
{
objvCurrEduClsEN.IdCurrEduCls = objRow[convCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsEN.CurrEduClsId = objRow[convCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsEN.EduClsName = objRow[convCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsEN.EduClsTypeId = objRow[convCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsEN.EduClsTypeName = objRow[convCurrEduCls.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsEN.CourseId = objRow[convCurrEduCls.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsEN.CourseCode = objRow[convCurrEduCls.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsEN.CourseDescription = objRow[convCurrEduCls.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduClsEN.CourseName = objRow[convCurrEduCls.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsEN.ViewCount = objRow[convCurrEduCls.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.ViewCount].ToString().Trim()); //浏览量
objvCurrEduClsEN.ExampleImgPath = objRow[convCurrEduCls.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsEN.TeachingSolutionId = objRow[convCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsEN.TeachingSolutionName = objRow[convCurrEduCls.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduCls.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsEN.IdTeacher = objRow[convCurrEduCls.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduCls.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsEN.TeacherId = objRow[convCurrEduCls.TeacherId] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsEN.TeacherName = objRow[convCurrEduCls.TeacherName] == DBNull.Value ? null : objRow[convCurrEduCls.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsEN.IdXzCollege = objRow[convCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsEN.CollegeId = objRow[convCurrEduCls.CollegeId] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsEN.CollegeName = objRow[convCurrEduCls.CollegeName] == DBNull.Value ? null : objRow[convCurrEduCls.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsEN.ClgEnglishName = objRow[convCurrEduCls.ClgEnglishName] == DBNull.Value ? null : objRow[convCurrEduCls.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvCurrEduClsEN.PhoneNumber = objRow[convCurrEduCls.PhoneNumber] == DBNull.Value ? null : objRow[convCurrEduCls.PhoneNumber].ToString().Trim(); //电话
objvCurrEduClsEN.IdXzMajor = objRow[convCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduClsEN.MajorName = objRow[convCurrEduCls.MajorName] == DBNull.Value ? null : objRow[convCurrEduCls.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsEN.IdEduWay = objRow[convCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsEN.IdClassRoomType = objRow[convCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduClsEN.TotalLessonQty = TransNullToInt(objRow[convCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsEN.MaxStuQty = objRow[convCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsEN.WeekQty = objRow[convCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsEN.ScheUnitPW = objRow[convCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsEN.WeekStatusId = objRow[convCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsEN.CustomerWeek = objRow[convCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsEN.LessonQtyPerWeek = objRow[convCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsEN.Mark = objRow[convCurrEduCls.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduCls.Mark].ToString().Trim()); //获得学分
objvCurrEduClsEN.IdUniZone = objRow[convCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsEN.IdGradeBase = objRow[convCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsEN.GradeBaseId = objRow[convCurrEduCls.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsEN.GradeBaseName = objRow[convCurrEduCls.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsEN.GradeBaseNameA = objRow[convCurrEduCls.GradeBaseNameA] == DBNull.Value ? null : objRow[convCurrEduCls.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduClsEN.IsEffective = TransNullToBool(objRow[convCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsEN.IsForPaperReading = TransNullToBool(objRow[convCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduClsEN.SchoolYear = objRow[convCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsEN.SchoolTerm = objRow[convCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsEN.IdCourseType = objRow[convCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsEN.CourseTypeId = objRow[convCurrEduCls.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsEN.CourseTypeName = objRow[convCurrEduCls.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduCls.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsEN.IsDegree = TransNullToBool(objRow[convCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsEN.IdScoreType = objRow[convCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsEN.GetScoreWayId = objRow[convCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduClsEN.IsProportionalCtrl = TransNullToBool(objRow[convCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsEN.IdExamType = objRow[convCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[convCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsEN.BeginWeek = objRow[convCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsEN.UserType = objRow[convCurrEduCls.UserType] == DBNull.Value ? null : objRow[convCurrEduCls.UserType].ToString().Trim(); //用户类型
objvCurrEduClsEN.ModifyDate = objRow[convCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsEN.ModifyUserId = objRow[convCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsEN.Memo = objRow[convCurrEduCls.Memo] == DBNull.Value ? null : objRow[convCurrEduCls.Memo].ToString().Trim(); //备注
objvCurrEduClsEN.CurrStuNumValid = objRow[convCurrEduCls.CurrStuNumValid] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsEN.CurrStuNum = objRow[convCurrEduCls.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls.CurrStuNum].ToString().Trim()); //当前学生数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCurrEduClsDA: GetObjByDataRow)", objException.Message));
}
objvCurrEduClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCurrEduClsEN;
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
objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCurrEduClsEN._CurrTabName, convCurrEduCls.IdCurrEduCls, 8, "");
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
objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCurrEduClsEN._CurrTabName, convCurrEduCls.IdCurrEduCls, 8, strPrefix);
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
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCurrEduCls from vCurrEduCls where " + strCondition;
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
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCurrEduCls from vCurrEduCls where " + strCondition;
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdCurrEduCls)
{
CheckPrimaryKey(strIdCurrEduCls);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCurrEduCls", "IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCurrEduClsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCurrEduCls", strCondition))
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
objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCurrEduCls");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCurrEduClsENS">源对象</param>
 /// <param name = "objvCurrEduClsENT">目标对象</param>
public void CopyTo(clsvCurrEduClsEN objvCurrEduClsENS, clsvCurrEduClsEN objvCurrEduClsENT)
{
objvCurrEduClsENT.IdCurrEduCls = objvCurrEduClsENS.IdCurrEduCls; //教学班流水号
objvCurrEduClsENT.CurrEduClsId = objvCurrEduClsENS.CurrEduClsId; //教学班Id
objvCurrEduClsENT.EduClsName = objvCurrEduClsENS.EduClsName; //教学班名
objvCurrEduClsENT.EduClsTypeId = objvCurrEduClsENS.EduClsTypeId; //教学班类型Id
objvCurrEduClsENT.EduClsTypeName = objvCurrEduClsENS.EduClsTypeName; //教学班类型名称
objvCurrEduClsENT.CourseId = objvCurrEduClsENS.CourseId; //课程Id
objvCurrEduClsENT.CourseCode = objvCurrEduClsENS.CourseCode; //课程代码
objvCurrEduClsENT.CourseDescription = objvCurrEduClsENS.CourseDescription; //课程描述
objvCurrEduClsENT.CourseName = objvCurrEduClsENS.CourseName; //课程名称
objvCurrEduClsENT.ViewCount = objvCurrEduClsENS.ViewCount; //浏览量
objvCurrEduClsENT.ExampleImgPath = objvCurrEduClsENS.ExampleImgPath; //示例图路径
objvCurrEduClsENT.TeachingSolutionId = objvCurrEduClsENS.TeachingSolutionId; //教学方案Id
objvCurrEduClsENT.TeachingSolutionName = objvCurrEduClsENS.TeachingSolutionName; //教学方案名称
objvCurrEduClsENT.IdTeacher = objvCurrEduClsENS.IdTeacher; //教师流水号
objvCurrEduClsENT.TeacherId = objvCurrEduClsENS.TeacherId; //教师工号
objvCurrEduClsENT.TeacherName = objvCurrEduClsENS.TeacherName; //教师姓名
objvCurrEduClsENT.IdXzCollege = objvCurrEduClsENS.IdXzCollege; //学院流水号
objvCurrEduClsENT.CollegeId = objvCurrEduClsENS.CollegeId; //学院ID
objvCurrEduClsENT.CollegeName = objvCurrEduClsENS.CollegeName; //学院名称
objvCurrEduClsENT.ClgEnglishName = objvCurrEduClsENS.ClgEnglishName; //ClgEnglishName
objvCurrEduClsENT.PhoneNumber = objvCurrEduClsENS.PhoneNumber; //电话
objvCurrEduClsENT.IdXzMajor = objvCurrEduClsENS.IdXzMajor; //专业流水号
objvCurrEduClsENT.MajorName = objvCurrEduClsENS.MajorName; //专业名称
objvCurrEduClsENT.IdEduWay = objvCurrEduClsENS.IdEduWay; //教学方式流水号
objvCurrEduClsENT.IdClassRoomType = objvCurrEduClsENS.IdClassRoomType; //教室类型流水号
objvCurrEduClsENT.TotalLessonQty = objvCurrEduClsENS.TotalLessonQty; //总课时数
objvCurrEduClsENT.MaxStuQty = objvCurrEduClsENS.MaxStuQty; //最大学生数
objvCurrEduClsENT.WeekQty = objvCurrEduClsENS.WeekQty; //总周数
objvCurrEduClsENT.ScheUnitPW = objvCurrEduClsENS.ScheUnitPW; //周排课次数
objvCurrEduClsENT.WeekStatusId = objvCurrEduClsENS.WeekStatusId; //周状态编号(单,双,全周)
objvCurrEduClsENT.CustomerWeek = objvCurrEduClsENS.CustomerWeek; //自定义上课周
objvCurrEduClsENT.LessonQtyPerWeek = objvCurrEduClsENS.LessonQtyPerWeek; //周课时数
objvCurrEduClsENT.Mark = objvCurrEduClsENS.Mark; //获得学分
objvCurrEduClsENT.IdUniZone = objvCurrEduClsENS.IdUniZone; //校区流水号
objvCurrEduClsENT.IdGradeBase = objvCurrEduClsENS.IdGradeBase; //年级流水号
objvCurrEduClsENT.GradeBaseId = objvCurrEduClsENS.GradeBaseId; //年级代号
objvCurrEduClsENT.GradeBaseName = objvCurrEduClsENS.GradeBaseName; //年级名称
objvCurrEduClsENT.GradeBaseNameA = objvCurrEduClsENS.GradeBaseNameA; //年级名称缩写
objvCurrEduClsENT.IsEffective = objvCurrEduClsENS.IsEffective; //是否有效
objvCurrEduClsENT.IsForPaperReading = objvCurrEduClsENS.IsForPaperReading; //是否参与论文阅读
objvCurrEduClsENT.SchoolYear = objvCurrEduClsENS.SchoolYear; //学年
objvCurrEduClsENT.SchoolTerm = objvCurrEduClsENS.SchoolTerm; //学期
objvCurrEduClsENT.IdCourseType = objvCurrEduClsENS.IdCourseType; //课程类型流水号
objvCurrEduClsENT.CourseTypeId = objvCurrEduClsENS.CourseTypeId; //课程类型ID
objvCurrEduClsENT.CourseTypeName = objvCurrEduClsENS.CourseTypeName; //课程类型名称
objvCurrEduClsENT.IsDegree = objvCurrEduClsENS.IsDegree; //是否学位课
objvCurrEduClsENT.IdScoreType = objvCurrEduClsENS.IdScoreType; //成绩类型流水号
objvCurrEduClsENT.GetScoreWayId = objvCurrEduClsENS.GetScoreWayId; //获得成绩方式Id
objvCurrEduClsENT.IsProportionalCtrl = objvCurrEduClsENS.IsProportionalCtrl; //是否比例控制
objvCurrEduClsENT.IdExamType = objvCurrEduClsENS.IdExamType; //考试方式流水号
objvCurrEduClsENT.BeginWeek = objvCurrEduClsENS.BeginWeek; //开始周
objvCurrEduClsENT.UserType = objvCurrEduClsENS.UserType; //用户类型
objvCurrEduClsENT.ModifyDate = objvCurrEduClsENS.ModifyDate; //修改日期
objvCurrEduClsENT.ModifyUserId = objvCurrEduClsENS.ModifyUserId; //修改人
objvCurrEduClsENT.Memo = objvCurrEduClsENS.Memo; //备注
objvCurrEduClsENT.CurrStuNumValid = objvCurrEduClsENS.CurrStuNumValid; //CurrStuNum_Valid
objvCurrEduClsENT.CurrStuNum = objvCurrEduClsENS.CurrStuNum; //当前学生数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCurrEduClsEN objvCurrEduClsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.IdCurrEduCls, 8, convCurrEduCls.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.CurrEduClsId, 15, convCurrEduCls.CurrEduClsId);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.EduClsName, 100, convCurrEduCls.EduClsName);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.EduClsTypeId, 4, convCurrEduCls.EduClsTypeId);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.EduClsTypeName, 100, convCurrEduCls.EduClsTypeName);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.CourseId, 8, convCurrEduCls.CourseId);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.CourseCode, 20, convCurrEduCls.CourseCode);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.CourseDescription, 8000, convCurrEduCls.CourseDescription);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.CourseName, 100, convCurrEduCls.CourseName);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.ExampleImgPath, 300, convCurrEduCls.ExampleImgPath);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.TeachingSolutionId, 8, convCurrEduCls.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.TeachingSolutionName, 100, convCurrEduCls.TeachingSolutionName);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.IdTeacher, 8, convCurrEduCls.IdTeacher);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.TeacherId, 12, convCurrEduCls.TeacherId);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.TeacherName, 50, convCurrEduCls.TeacherName);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.IdXzCollege, 4, convCurrEduCls.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.CollegeId, 4, convCurrEduCls.CollegeId);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.CollegeName, 100, convCurrEduCls.CollegeName);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.ClgEnglishName, 60, convCurrEduCls.ClgEnglishName);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.PhoneNumber, 15, convCurrEduCls.PhoneNumber);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.IdXzMajor, 8, convCurrEduCls.IdXzMajor);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.MajorName, 100, convCurrEduCls.MajorName);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.IdEduWay, 4, convCurrEduCls.IdEduWay);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.IdClassRoomType, 4, convCurrEduCls.IdClassRoomType);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.WeekStatusId, 2, convCurrEduCls.WeekStatusId);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.CustomerWeek, 50, convCurrEduCls.CustomerWeek);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.IdUniZone, 4, convCurrEduCls.IdUniZone);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.IdGradeBase, 4, convCurrEduCls.IdGradeBase);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.GradeBaseId, 4, convCurrEduCls.GradeBaseId);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.GradeBaseName, 50, convCurrEduCls.GradeBaseName);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.GradeBaseNameA, 10, convCurrEduCls.GradeBaseNameA);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.SchoolYear, 10, convCurrEduCls.SchoolYear);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.SchoolTerm, 1, convCurrEduCls.SchoolTerm);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.IdCourseType, 4, convCurrEduCls.IdCourseType);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.CourseTypeId, 4, convCurrEduCls.CourseTypeId);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.CourseTypeName, 30, convCurrEduCls.CourseTypeName);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.IdScoreType, 4, convCurrEduCls.IdScoreType);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.GetScoreWayId, 2, convCurrEduCls.GetScoreWayId);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.IdExamType, 4, convCurrEduCls.IdExamType);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.UserType, 50, convCurrEduCls.UserType);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.ModifyDate, 20, convCurrEduCls.ModifyDate);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.ModifyUserId, 18, convCurrEduCls.ModifyUserId);
clsCheckSql.CheckFieldLen(objvCurrEduClsEN.Memo, 1000, convCurrEduCls.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.IdCurrEduCls, convCurrEduCls.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.CurrEduClsId, convCurrEduCls.CurrEduClsId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.EduClsName, convCurrEduCls.EduClsName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.EduClsTypeId, convCurrEduCls.EduClsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.EduClsTypeName, convCurrEduCls.EduClsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.CourseId, convCurrEduCls.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.CourseCode, convCurrEduCls.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.CourseDescription, convCurrEduCls.CourseDescription);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.CourseName, convCurrEduCls.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.ExampleImgPath, convCurrEduCls.ExampleImgPath);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.TeachingSolutionId, convCurrEduCls.TeachingSolutionId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.TeachingSolutionName, convCurrEduCls.TeachingSolutionName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.IdTeacher, convCurrEduCls.IdTeacher);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.TeacherId, convCurrEduCls.TeacherId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.TeacherName, convCurrEduCls.TeacherName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.IdXzCollege, convCurrEduCls.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.CollegeId, convCurrEduCls.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.CollegeName, convCurrEduCls.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.ClgEnglishName, convCurrEduCls.ClgEnglishName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.PhoneNumber, convCurrEduCls.PhoneNumber);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.IdXzMajor, convCurrEduCls.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.MajorName, convCurrEduCls.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.IdEduWay, convCurrEduCls.IdEduWay);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.IdClassRoomType, convCurrEduCls.IdClassRoomType);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.WeekStatusId, convCurrEduCls.WeekStatusId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.CustomerWeek, convCurrEduCls.CustomerWeek);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.IdUniZone, convCurrEduCls.IdUniZone);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.IdGradeBase, convCurrEduCls.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.GradeBaseId, convCurrEduCls.GradeBaseId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.GradeBaseName, convCurrEduCls.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.GradeBaseNameA, convCurrEduCls.GradeBaseNameA);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.SchoolYear, convCurrEduCls.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.SchoolTerm, convCurrEduCls.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.IdCourseType, convCurrEduCls.IdCourseType);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.CourseTypeId, convCurrEduCls.CourseTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.CourseTypeName, convCurrEduCls.CourseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.IdScoreType, convCurrEduCls.IdScoreType);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.GetScoreWayId, convCurrEduCls.GetScoreWayId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.IdExamType, convCurrEduCls.IdExamType);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.UserType, convCurrEduCls.UserType);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.ModifyDate, convCurrEduCls.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.ModifyUserId, convCurrEduCls.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsEN.Memo, convCurrEduCls.Memo);
//检查外键字段长度
 objvCurrEduClsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdCurrEduCls()
{
//获取某学院所有专业信息
string strSQL = "select IdCurrEduCls, EduClsName from vCurrEduCls ";
 clsSpecSQLforSql mySql = clsvCurrEduClsDA.GetSpecSQLObj();
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
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
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
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
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
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCurrEduClsEN._CurrTabName);
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
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCurrEduClsEN._CurrTabName, strCondition);
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
 objSQL = clsvCurrEduClsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}