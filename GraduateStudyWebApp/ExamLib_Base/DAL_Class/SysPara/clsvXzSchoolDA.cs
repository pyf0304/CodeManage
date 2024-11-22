
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzSchoolDA
 表名:vXzSchool(01120028)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:07:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// v学校(vXzSchool)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvXzSchoolDA : clsCommBase4DA
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
 return clsvXzSchoolEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvXzSchoolEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzSchoolEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvXzSchoolEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvXzSchoolEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdSchool">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdSchool)
{
strIdSchool = strIdSchool.Replace("'", "''");
if (strIdSchool.Length > 4)
{
throw new Exception("(errid:Data000001)在表:vXzSchool中,检查关键字,长度不正确!(clsvXzSchoolDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdSchool)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vXzSchool中,关键字不能为空 或 null!(clsvXzSchoolDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSchool);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvXzSchoolDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvXzSchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from vXzSchool where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vXzSchool(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvXzSchoolDA: GetDataTable_vXzSchool)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from vXzSchool where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvXzSchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvXzSchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from vXzSchool where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvXzSchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvXzSchoolDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzSchool where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzSchool where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvXzSchoolDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vXzSchool where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvXzSchoolDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vXzSchool.* from vXzSchool Left Join {1} on {2} where {3} and vXzSchool.IdSchool not in (Select top {5} vXzSchool.IdSchool from vXzSchool Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzSchool where {1} and IdSchool not in (Select top {2} IdSchool from vXzSchool where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzSchool where {1} and IdSchool not in (Select top {3} IdSchool from vXzSchool where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvXzSchoolDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vXzSchool.* from vXzSchool Left Join {1} on {2} where {3} and vXzSchool.IdSchool not in (Select top {5} vXzSchool.IdSchool from vXzSchool Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzSchool where {1} and IdSchool not in (Select top {2} IdSchool from vXzSchool where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzSchool where {1} and IdSchool not in (Select top {3} IdSchool from vXzSchool where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvXzSchoolEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvXzSchoolDA:GetObjLst)", objException.Message));
}
List<clsvXzSchoolEN> arrObjLst = new List<clsvXzSchoolEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from vXzSchool where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzSchoolEN objvXzSchoolEN = new clsvXzSchoolEN();
try
{
objvXzSchoolEN.IdSchool = objRow[convXzSchool.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolEN.SchoolId = objRow[convXzSchool.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolEN.SchoolName = objRow[convXzSchool.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolEN.SchoolNameA = objRow[convXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolEN.SchoolTypeId = objRow[convXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolEN.SchoolTypeName = objRow[convXzSchool.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchool.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolEN.IsCurrentUse = TransNullToBool(objRow[convXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolEN.UpdDate = objRow[convXzSchool.UpdDate] == DBNull.Value ? null : objRow[convXzSchool.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolEN.UpdUserId = objRow[convXzSchool.UpdUserId] == DBNull.Value ? null : objRow[convXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolEN.Memo = objRow[convXzSchool.Memo] == DBNull.Value ? null : objRow[convXzSchool.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvXzSchoolDA: GetObjLst)", objException.Message));
}
objvXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvXzSchoolEN);
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
public List<clsvXzSchoolEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvXzSchoolDA:GetObjLstByTabName)", objException.Message));
}
List<clsvXzSchoolEN> arrObjLst = new List<clsvXzSchoolEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzSchoolEN objvXzSchoolEN = new clsvXzSchoolEN();
try
{
objvXzSchoolEN.IdSchool = objRow[convXzSchool.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolEN.SchoolId = objRow[convXzSchool.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolEN.SchoolName = objRow[convXzSchool.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolEN.SchoolNameA = objRow[convXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolEN.SchoolTypeId = objRow[convXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolEN.SchoolTypeName = objRow[convXzSchool.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchool.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolEN.IsCurrentUse = TransNullToBool(objRow[convXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolEN.UpdDate = objRow[convXzSchool.UpdDate] == DBNull.Value ? null : objRow[convXzSchool.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolEN.UpdUserId = objRow[convXzSchool.UpdUserId] == DBNull.Value ? null : objRow[convXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolEN.Memo = objRow[convXzSchool.Memo] == DBNull.Value ? null : objRow[convXzSchool.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvXzSchoolDA: GetObjLst)", objException.Message));
}
objvXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvXzSchoolEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvXzSchoolEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvXzSchool(ref clsvXzSchoolEN objvXzSchoolEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from vXzSchool where IdSchool = " + "'"+ objvXzSchoolEN.IdSchool+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvXzSchoolEN.IdSchool = objDT.Rows[0][convXzSchool.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzSchoolEN.SchoolId = objDT.Rows[0][convXzSchool.SchoolId].ToString().Trim(); //学校编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvXzSchoolEN.SchoolName = objDT.Rows[0][convXzSchool.SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvXzSchoolEN.SchoolNameA = objDT.Rows[0][convXzSchool.SchoolNameA].ToString().Trim(); //学校简称(字段类型:varchar,字段长度:14,是否可空:True)
 objvXzSchoolEN.SchoolTypeId = objDT.Rows[0][convXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvXzSchoolEN.SchoolTypeName = objDT.Rows[0][convXzSchool.SchoolTypeName].ToString().Trim(); //学校类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvXzSchoolEN.IsCurrentUse = TransNullToBool(objDT.Rows[0][convXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用(字段类型:bit,字段长度:1,是否可空:True)
 objvXzSchoolEN.UpdDate = objDT.Rows[0][convXzSchool.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzSchoolEN.UpdUserId = objDT.Rows[0][convXzSchool.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzSchoolEN.Memo = objDT.Rows[0][convXzSchool.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvXzSchoolDA: GetvXzSchool)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdSchool">表关键字</param>
 /// <returns>表对象</returns>
public clsvXzSchoolEN GetObjByIdSchool(string strIdSchool)
{
CheckPrimaryKey(strIdSchool);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from vXzSchool where IdSchool = " + "'"+ strIdSchool+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvXzSchoolEN objvXzSchoolEN = new clsvXzSchoolEN();
try
{
 objvXzSchoolEN.IdSchool = objRow[convXzSchool.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzSchoolEN.SchoolId = objRow[convXzSchool.SchoolId].ToString().Trim(); //学校编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvXzSchoolEN.SchoolName = objRow[convXzSchool.SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvXzSchoolEN.SchoolNameA = objRow[convXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchool.SchoolNameA].ToString().Trim(); //学校简称(字段类型:varchar,字段长度:14,是否可空:True)
 objvXzSchoolEN.SchoolTypeId = objRow[convXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvXzSchoolEN.SchoolTypeName = objRow[convXzSchool.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchool.SchoolTypeName].ToString().Trim(); //学校类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用(字段类型:bit,字段长度:1,是否可空:True)
 objvXzSchoolEN.UpdDate = objRow[convXzSchool.UpdDate] == DBNull.Value ? null : objRow[convXzSchool.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzSchoolEN.UpdUserId = objRow[convXzSchool.UpdUserId] == DBNull.Value ? null : objRow[convXzSchool.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzSchoolEN.Memo = objRow[convXzSchool.Memo] == DBNull.Value ? null : objRow[convXzSchool.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvXzSchoolDA: GetObjByIdSchool)", objException.Message));
}
return objvXzSchoolEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvXzSchoolEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvXzSchoolDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from vXzSchool where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvXzSchoolEN objvXzSchoolEN = new clsvXzSchoolEN()
{
IdSchool = objRow[convXzSchool.IdSchool].ToString().Trim(), //学校流水号
SchoolId = objRow[convXzSchool.SchoolId].ToString().Trim(), //学校编号
SchoolName = objRow[convXzSchool.SchoolName].ToString().Trim(), //学校名称
SchoolNameA = objRow[convXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchool.SchoolNameA].ToString().Trim(), //学校简称
SchoolTypeId = objRow[convXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchool.SchoolTypeId].ToString().Trim(), //学校类型Id
SchoolTypeName = objRow[convXzSchool.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchool.SchoolTypeName].ToString().Trim(), //学校类型名
IsCurrentUse = TransNullToBool(objRow[convXzSchool.IsCurrentUse].ToString().Trim()), //是否当前使用
UpdDate = objRow[convXzSchool.UpdDate] == DBNull.Value ? null : objRow[convXzSchool.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convXzSchool.UpdUserId] == DBNull.Value ? null : objRow[convXzSchool.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convXzSchool.Memo] == DBNull.Value ? null : objRow[convXzSchool.Memo].ToString().Trim() //备注
};
objvXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzSchoolEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvXzSchoolDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvXzSchoolEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvXzSchoolEN objvXzSchoolEN = new clsvXzSchoolEN();
try
{
objvXzSchoolEN.IdSchool = objRow[convXzSchool.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolEN.SchoolId = objRow[convXzSchool.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolEN.SchoolName = objRow[convXzSchool.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolEN.SchoolNameA = objRow[convXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolEN.SchoolTypeId = objRow[convXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolEN.SchoolTypeName = objRow[convXzSchool.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchool.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolEN.IsCurrentUse = TransNullToBool(objRow[convXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolEN.UpdDate = objRow[convXzSchool.UpdDate] == DBNull.Value ? null : objRow[convXzSchool.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolEN.UpdUserId = objRow[convXzSchool.UpdUserId] == DBNull.Value ? null : objRow[convXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolEN.Memo = objRow[convXzSchool.Memo] == DBNull.Value ? null : objRow[convXzSchool.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvXzSchoolDA: GetObjByDataRowvXzSchool)", objException.Message));
}
objvXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzSchoolEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvXzSchoolEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvXzSchoolEN objvXzSchoolEN = new clsvXzSchoolEN();
try
{
objvXzSchoolEN.IdSchool = objRow[convXzSchool.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolEN.SchoolId = objRow[convXzSchool.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolEN.SchoolName = objRow[convXzSchool.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolEN.SchoolNameA = objRow[convXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolEN.SchoolTypeId = objRow[convXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolEN.SchoolTypeName = objRow[convXzSchool.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchool.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolEN.IsCurrentUse = TransNullToBool(objRow[convXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolEN.UpdDate = objRow[convXzSchool.UpdDate] == DBNull.Value ? null : objRow[convXzSchool.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolEN.UpdUserId = objRow[convXzSchool.UpdUserId] == DBNull.Value ? null : objRow[convXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolEN.Memo = objRow[convXzSchool.Memo] == DBNull.Value ? null : objRow[convXzSchool.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvXzSchoolDA: GetObjByDataRow)", objException.Message));
}
objvXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzSchoolEN;
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
objSQL = clsvXzSchoolDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvXzSchoolEN._CurrTabName, convXzSchool.IdSchool, 4, "");
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
objSQL = clsvXzSchoolDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvXzSchoolEN._CurrTabName, convXzSchool.IdSchool, 4, strPrefix);
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
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdSchool from vXzSchool where " + strCondition;
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
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdSchool from vXzSchool where " + strCondition;
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
 /// <param name = "strIdSchool">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdSchool)
{
CheckPrimaryKey(strIdSchool);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vXzSchool", "IdSchool = " + "'"+ strIdSchool+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvXzSchoolDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vXzSchool", strCondition))
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
objSQL = clsvXzSchoolDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vXzSchool");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvXzSchoolENS">源对象</param>
 /// <param name = "objvXzSchoolENT">目标对象</param>
public void CopyTo(clsvXzSchoolEN objvXzSchoolENS, clsvXzSchoolEN objvXzSchoolENT)
{
objvXzSchoolENT.IdSchool = objvXzSchoolENS.IdSchool; //学校流水号
objvXzSchoolENT.SchoolId = objvXzSchoolENS.SchoolId; //学校编号
objvXzSchoolENT.SchoolName = objvXzSchoolENS.SchoolName; //学校名称
objvXzSchoolENT.SchoolNameA = objvXzSchoolENS.SchoolNameA; //学校简称
objvXzSchoolENT.SchoolTypeId = objvXzSchoolENS.SchoolTypeId; //学校类型Id
objvXzSchoolENT.SchoolTypeName = objvXzSchoolENS.SchoolTypeName; //学校类型名
objvXzSchoolENT.IsCurrentUse = objvXzSchoolENS.IsCurrentUse; //是否当前使用
objvXzSchoolENT.UpdDate = objvXzSchoolENS.UpdDate; //修改日期
objvXzSchoolENT.UpdUserId = objvXzSchoolENS.UpdUserId; //修改用户Id
objvXzSchoolENT.Memo = objvXzSchoolENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvXzSchoolEN objvXzSchoolEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvXzSchoolEN.IdSchool, 4, convXzSchool.IdSchool);
clsCheckSql.CheckFieldLen(objvXzSchoolEN.SchoolId, 10, convXzSchool.SchoolId);
clsCheckSql.CheckFieldLen(objvXzSchoolEN.SchoolName, 50, convXzSchool.SchoolName);
clsCheckSql.CheckFieldLen(objvXzSchoolEN.SchoolNameA, 14, convXzSchool.SchoolNameA);
clsCheckSql.CheckFieldLen(objvXzSchoolEN.SchoolTypeId, 2, convXzSchool.SchoolTypeId);
clsCheckSql.CheckFieldLen(objvXzSchoolEN.SchoolTypeName, 30, convXzSchool.SchoolTypeName);
clsCheckSql.CheckFieldLen(objvXzSchoolEN.UpdDate, 20, convXzSchool.UpdDate);
clsCheckSql.CheckFieldLen(objvXzSchoolEN.UpdUserId, 20, convXzSchool.UpdUserId);
clsCheckSql.CheckFieldLen(objvXzSchoolEN.Memo, 1000, convXzSchool.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolEN.IdSchool, convXzSchool.IdSchool);
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolEN.SchoolId, convXzSchool.SchoolId);
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolEN.SchoolName, convXzSchool.SchoolName);
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolEN.SchoolNameA, convXzSchool.SchoolNameA);
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolEN.SchoolTypeId, convXzSchool.SchoolTypeId);
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolEN.SchoolTypeName, convXzSchool.SchoolTypeName);
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolEN.UpdDate, convXzSchool.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolEN.UpdUserId, convXzSchool.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolEN.Memo, convXzSchool.Memo);
//检查外键字段长度
 objvXzSchoolEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdSchool()
{
//获取某学院所有专业信息
string strSQL = "select IdSchool, SchoolName from vXzSchool ";
 clsSpecSQLforSql mySql = clsvXzSchoolDA.GetSpecSQLObj();
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
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
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
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
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
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvXzSchoolEN._CurrTabName);
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
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvXzSchoolEN._CurrTabName, strCondition);
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
 objSQL = clsvXzSchoolDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}