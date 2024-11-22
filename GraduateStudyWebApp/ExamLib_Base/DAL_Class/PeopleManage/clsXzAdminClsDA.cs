
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzAdminClsDA
 表名:XzAdminCls(01120194)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:人员管理(PeopleManage)
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
 /// 行政班(XzAdminCls)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsXzAdminClsDA : clsCommBase4DA
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
 return clsXzAdminClsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsXzAdminClsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzAdminClsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsXzAdminClsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsXzAdminClsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdAdminCls">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdAdminCls)
{
strIdAdminCls = strIdAdminCls.Replace("'", "''");
if (strIdAdminCls.Length > 8)
{
throw new Exception("(errid:Data000001)在表:XzAdminCls中,检查关键字,长度不正确!(clsXzAdminClsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdAdminCls)  ==  true)
{
throw new Exception("(errid:Data000002)在表:XzAdminCls中,关键字不能为空 或 null!(clsXzAdminClsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdAdminCls);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsXzAdminClsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsXzAdminClsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from XzAdminCls where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_XzAdminCls(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsXzAdminClsDA: GetDataTable_XzAdminCls)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from XzAdminCls where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsXzAdminClsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsXzAdminClsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from XzAdminCls where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsXzAdminClsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsXzAdminClsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzAdminCls where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzAdminCls where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsXzAdminClsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from XzAdminCls where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsXzAdminClsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} XzAdminCls.* from XzAdminCls Left Join {1} on {2} where {3} and XzAdminCls.IdAdminCls not in (Select top {5} XzAdminCls.IdAdminCls from XzAdminCls Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzAdminCls where {1} and IdAdminCls not in (Select top {2} IdAdminCls from XzAdminCls where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzAdminCls where {1} and IdAdminCls not in (Select top {3} IdAdminCls from XzAdminCls where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsXzAdminClsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} XzAdminCls.* from XzAdminCls Left Join {1} on {2} where {3} and XzAdminCls.IdAdminCls not in (Select top {5} XzAdminCls.IdAdminCls from XzAdminCls Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzAdminCls where {1} and IdAdminCls not in (Select top {2} IdAdminCls from XzAdminCls where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzAdminCls where {1} and IdAdminCls not in (Select top {3} IdAdminCls from XzAdminCls where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsXzAdminClsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsXzAdminClsDA:GetObjLst)", objException.Message));
}
List<clsXzAdminClsEN> arrObjLst = new List<clsXzAdminClsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from XzAdminCls where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN();
try
{
objXzAdminClsEN.IdAdminCls = objRow[conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objXzAdminClsEN.AdminClsName = objRow[conXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objXzAdminClsEN.IdXzMajor = objRow[conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objXzAdminClsEN.IdXzCollege = objRow[conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objXzAdminClsEN.IdUniZone = objRow[conXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objXzAdminClsEN.CurrentStuQty = objRow[conXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objXzAdminClsEN.IdGradeBase = objRow[conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objXzAdminClsEN.AdminClsId = objRow[conXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objXzAdminClsEN.IdAdminClsType = objRow[conXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objXzAdminClsEN.AdminClsIndex = objRow[conXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objXzAdminClsEN.Memo = objRow[conXzAdminCls.Memo] == DBNull.Value ? null : objRow[conXzAdminCls.Memo].ToString().Trim(); //备注
objXzAdminClsEN.ModifyUserId = objRow[conXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objXzAdminClsEN.ModifyDate = objRow[conXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsXzAdminClsDA: GetObjLst)", objException.Message));
}
objXzAdminClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzAdminClsEN);
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
public List<clsXzAdminClsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsXzAdminClsDA:GetObjLstByTabName)", objException.Message));
}
List<clsXzAdminClsEN> arrObjLst = new List<clsXzAdminClsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN();
try
{
objXzAdminClsEN.IdAdminCls = objRow[conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objXzAdminClsEN.AdminClsName = objRow[conXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objXzAdminClsEN.IdXzMajor = objRow[conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objXzAdminClsEN.IdXzCollege = objRow[conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objXzAdminClsEN.IdUniZone = objRow[conXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objXzAdminClsEN.CurrentStuQty = objRow[conXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objXzAdminClsEN.IdGradeBase = objRow[conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objXzAdminClsEN.AdminClsId = objRow[conXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objXzAdminClsEN.IdAdminClsType = objRow[conXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objXzAdminClsEN.AdminClsIndex = objRow[conXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objXzAdminClsEN.Memo = objRow[conXzAdminCls.Memo] == DBNull.Value ? null : objRow[conXzAdminCls.Memo].ToString().Trim(); //备注
objXzAdminClsEN.ModifyUserId = objRow[conXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objXzAdminClsEN.ModifyDate = objRow[conXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsXzAdminClsDA: GetObjLst)", objException.Message));
}
objXzAdminClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzAdminClsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetXzAdminCls(ref clsXzAdminClsEN objXzAdminClsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from XzAdminCls where IdAdminCls = " + "'"+ objXzAdminClsEN.IdAdminCls+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objXzAdminClsEN.IdAdminCls = objDT.Rows[0][conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objXzAdminClsEN.AdminClsName = objDT.Rows[0][conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objXzAdminClsEN.IdXzMajor = objDT.Rows[0][conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objXzAdminClsEN.IdXzCollege = objDT.Rows[0][conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objXzAdminClsEN.IdUniZone = objDT.Rows[0][conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objXzAdminClsEN.CurrentStuQty = TransNullToInt(objDT.Rows[0][conXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数(字段类型:int,字段长度:4,是否可空:False)
 objXzAdminClsEN.IdGradeBase = objDT.Rows[0][conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objXzAdminClsEN.AdminClsId = objDT.Rows[0][conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objXzAdminClsEN.IdAdminClsType = objDT.Rows[0][conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objXzAdminClsEN.AdminClsIndex = TransNullToInt(objDT.Rows[0][conXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex(字段类型:int,字段长度:4,是否可空:True)
 objXzAdminClsEN.Memo = objDT.Rows[0][conXzAdminCls.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objXzAdminClsEN.ModifyUserId = objDT.Rows[0][conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objXzAdminClsEN.ModifyDate = objDT.Rows[0][conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsXzAdminClsDA: GetXzAdminCls)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdAdminCls">表关键字</param>
 /// <returns>表对象</returns>
public clsXzAdminClsEN GetObjByIdAdminCls(string strIdAdminCls)
{
CheckPrimaryKey(strIdAdminCls);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from XzAdminCls where IdAdminCls = " + "'"+ strIdAdminCls+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN();
try
{
 objXzAdminClsEN.IdAdminCls = objRow[conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objXzAdminClsEN.AdminClsName = objRow[conXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objXzAdminClsEN.IdXzMajor = objRow[conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objXzAdminClsEN.IdXzCollege = objRow[conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objXzAdminClsEN.IdUniZone = objRow[conXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objXzAdminClsEN.CurrentStuQty = objRow[conXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数(字段类型:int,字段长度:4,是否可空:False)
 objXzAdminClsEN.IdGradeBase = objRow[conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objXzAdminClsEN.AdminClsId = objRow[conXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objXzAdminClsEN.IdAdminClsType = objRow[conXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objXzAdminClsEN.AdminClsIndex = objRow[conXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex(字段类型:int,字段长度:4,是否可空:True)
 objXzAdminClsEN.Memo = objRow[conXzAdminCls.Memo] == DBNull.Value ? null : objRow[conXzAdminCls.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objXzAdminClsEN.ModifyUserId = objRow[conXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objXzAdminClsEN.ModifyDate = objRow[conXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsXzAdminClsDA: GetObjByIdAdminCls)", objException.Message));
}
return objXzAdminClsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsXzAdminClsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsXzAdminClsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from XzAdminCls where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN()
{
IdAdminCls = objRow[conXzAdminCls.IdAdminCls].ToString().Trim(), //行政班流水号
AdminClsName = objRow[conXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsName].ToString().Trim(), //行政班名称
IdXzMajor = objRow[conXzAdminCls.IdXzMajor].ToString().Trim(), //专业流水号
IdXzCollege = objRow[conXzAdminCls.IdXzCollege].ToString().Trim(), //学院流水号
IdUniZone = objRow[conXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[conXzAdminCls.IdUniZone].ToString().Trim(), //校区流水号
CurrentStuQty = objRow[conXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzAdminCls.CurrentStuQty].ToString().Trim()), //当前学生数
IdGradeBase = objRow[conXzAdminCls.IdGradeBase].ToString().Trim(), //年级流水号
AdminClsId = objRow[conXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsId].ToString().Trim(), //行政班代号
IdAdminClsType = objRow[conXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[conXzAdminCls.IdAdminClsType].ToString().Trim(), //行政班级类型流水号
AdminClsIndex = objRow[conXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzAdminCls.AdminClsIndex].ToString().Trim()), //AdminClsIndex
Memo = objRow[conXzAdminCls.Memo] == DBNull.Value ? null : objRow[conXzAdminCls.Memo].ToString().Trim(), //备注
ModifyUserId = objRow[conXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyUserId].ToString().Trim(), //修改人
ModifyDate = objRow[conXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyDate].ToString().Trim() //修改日期
};
objXzAdminClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzAdminClsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsXzAdminClsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsXzAdminClsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN();
try
{
objXzAdminClsEN.IdAdminCls = objRow[conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objXzAdminClsEN.AdminClsName = objRow[conXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objXzAdminClsEN.IdXzMajor = objRow[conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objXzAdminClsEN.IdXzCollege = objRow[conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objXzAdminClsEN.IdUniZone = objRow[conXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objXzAdminClsEN.CurrentStuQty = objRow[conXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objXzAdminClsEN.IdGradeBase = objRow[conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objXzAdminClsEN.AdminClsId = objRow[conXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objXzAdminClsEN.IdAdminClsType = objRow[conXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objXzAdminClsEN.AdminClsIndex = objRow[conXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objXzAdminClsEN.Memo = objRow[conXzAdminCls.Memo] == DBNull.Value ? null : objRow[conXzAdminCls.Memo].ToString().Trim(); //备注
objXzAdminClsEN.ModifyUserId = objRow[conXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objXzAdminClsEN.ModifyDate = objRow[conXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsXzAdminClsDA: GetObjByDataRowXzAdminCls)", objException.Message));
}
objXzAdminClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzAdminClsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsXzAdminClsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN();
try
{
objXzAdminClsEN.IdAdminCls = objRow[conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objXzAdminClsEN.AdminClsName = objRow[conXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objXzAdminClsEN.IdXzMajor = objRow[conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objXzAdminClsEN.IdXzCollege = objRow[conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objXzAdminClsEN.IdUniZone = objRow[conXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objXzAdminClsEN.CurrentStuQty = objRow[conXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objXzAdminClsEN.IdGradeBase = objRow[conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objXzAdminClsEN.AdminClsId = objRow[conXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objXzAdminClsEN.IdAdminClsType = objRow[conXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objXzAdminClsEN.AdminClsIndex = objRow[conXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objXzAdminClsEN.Memo = objRow[conXzAdminCls.Memo] == DBNull.Value ? null : objRow[conXzAdminCls.Memo].ToString().Trim(); //备注
objXzAdminClsEN.ModifyUserId = objRow[conXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objXzAdminClsEN.ModifyDate = objRow[conXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsXzAdminClsDA: GetObjByDataRow)", objException.Message));
}
objXzAdminClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzAdminClsEN;
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
objSQL = clsXzAdminClsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsXzAdminClsEN._CurrTabName, conXzAdminCls.IdAdminCls, 8, "");
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
objSQL = clsXzAdminClsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsXzAdminClsEN._CurrTabName, conXzAdminCls.IdAdminCls, 8, strPrefix);
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
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdAdminCls from XzAdminCls where " + strCondition;
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
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdAdminCls from XzAdminCls where " + strCondition;
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
 /// <param name = "strIdAdminCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdAdminCls)
{
CheckPrimaryKey(strIdAdminCls);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("XzAdminCls", "IdAdminCls = " + "'"+ strIdAdminCls+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsXzAdminClsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("XzAdminCls", strCondition))
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
objSQL = clsXzAdminClsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("XzAdminCls");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsXzAdminClsEN objXzAdminClsEN)
 {
 if (objXzAdminClsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzAdminClsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from XzAdminCls where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "XzAdminCls");
objRow = objDS.Tables["XzAdminCls"].NewRow();
objRow[conXzAdminCls.IdAdminCls] = objXzAdminClsEN.IdAdminCls; //行政班流水号
 if (objXzAdminClsEN.AdminClsName !=  "")
 {
objRow[conXzAdminCls.AdminClsName] = objXzAdminClsEN.AdminClsName; //行政班名称
 }
objRow[conXzAdminCls.IdXzMajor] = objXzAdminClsEN.IdXzMajor; //专业流水号
objRow[conXzAdminCls.IdXzCollege] = objXzAdminClsEN.IdXzCollege; //学院流水号
 if (objXzAdminClsEN.IdUniZone !=  "")
 {
objRow[conXzAdminCls.IdUniZone] = objXzAdminClsEN.IdUniZone; //校区流水号
 }
objRow[conXzAdminCls.CurrentStuQty] = objXzAdminClsEN.CurrentStuQty; //当前学生数
objRow[conXzAdminCls.IdGradeBase] = objXzAdminClsEN.IdGradeBase; //年级流水号
 if (objXzAdminClsEN.AdminClsId !=  "")
 {
objRow[conXzAdminCls.AdminClsId] = objXzAdminClsEN.AdminClsId; //行政班代号
 }
 if (objXzAdminClsEN.IdAdminClsType !=  "")
 {
objRow[conXzAdminCls.IdAdminClsType] = objXzAdminClsEN.IdAdminClsType; //行政班级类型流水号
 }
objRow[conXzAdminCls.AdminClsIndex] = objXzAdminClsEN.AdminClsIndex; //AdminClsIndex
 if (objXzAdminClsEN.Memo !=  "")
 {
objRow[conXzAdminCls.Memo] = objXzAdminClsEN.Memo; //备注
 }
 if (objXzAdminClsEN.ModifyUserId !=  "")
 {
objRow[conXzAdminCls.ModifyUserId] = objXzAdminClsEN.ModifyUserId; //修改人
 }
 if (objXzAdminClsEN.ModifyDate !=  "")
 {
objRow[conXzAdminCls.ModifyDate] = objXzAdminClsEN.ModifyDate; //修改日期
 }
objDS.Tables[clsXzAdminClsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsXzAdminClsEN._CurrTabName);
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
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsXzAdminClsEN objXzAdminClsEN)
{
 if (objXzAdminClsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzAdminClsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzAdminClsEN.IdAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdAdminCls);
 var strIdAdminCls = objXzAdminClsEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminCls + "'");
 }
 
 if (objXzAdminClsEN.AdminClsName !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.AdminClsName);
 var strAdminClsName = objXzAdminClsEN.AdminClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAdminClsName + "'");
 }
 
 if (objXzAdminClsEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdXzMajor);
 var strIdXzMajor = objXzAdminClsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objXzAdminClsEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdXzCollege);
 var strIdXzCollege = objXzAdminClsEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objXzAdminClsEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdUniZone);
 var strIdUniZone = objXzAdminClsEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 if (objXzAdminClsEN.CurrentStuQty !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.CurrentStuQty);
 arrValueListForInsert.Add(objXzAdminClsEN.CurrentStuQty.ToString());
 }
 
 if (objXzAdminClsEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdGradeBase);
 var strIdGradeBase = objXzAdminClsEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objXzAdminClsEN.AdminClsId !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.AdminClsId);
 var strAdminClsId = objXzAdminClsEN.AdminClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAdminClsId + "'");
 }
 
 if (objXzAdminClsEN.IdAdminClsType !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdAdminClsType);
 var strIdAdminClsType = objXzAdminClsEN.IdAdminClsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminClsType + "'");
 }
 
 if (objXzAdminClsEN.AdminClsIndex !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.AdminClsIndex);
 arrValueListForInsert.Add(objXzAdminClsEN.AdminClsIndex.ToString());
 }
 
 if (objXzAdminClsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.Memo);
 var strMemo = objXzAdminClsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objXzAdminClsEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.ModifyUserId);
 var strModifyUserId = objXzAdminClsEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objXzAdminClsEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.ModifyDate);
 var strModifyDate = objXzAdminClsEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzAdminCls");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsXzAdminClsEN objXzAdminClsEN)
{
 if (objXzAdminClsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzAdminClsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzAdminClsEN.IdAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdAdminCls);
 var strIdAdminCls = objXzAdminClsEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminCls + "'");
 }
 
 if (objXzAdminClsEN.AdminClsName !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.AdminClsName);
 var strAdminClsName = objXzAdminClsEN.AdminClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAdminClsName + "'");
 }
 
 if (objXzAdminClsEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdXzMajor);
 var strIdXzMajor = objXzAdminClsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objXzAdminClsEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdXzCollege);
 var strIdXzCollege = objXzAdminClsEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objXzAdminClsEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdUniZone);
 var strIdUniZone = objXzAdminClsEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 if (objXzAdminClsEN.CurrentStuQty !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.CurrentStuQty);
 arrValueListForInsert.Add(objXzAdminClsEN.CurrentStuQty.ToString());
 }
 
 if (objXzAdminClsEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdGradeBase);
 var strIdGradeBase = objXzAdminClsEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objXzAdminClsEN.AdminClsId !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.AdminClsId);
 var strAdminClsId = objXzAdminClsEN.AdminClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAdminClsId + "'");
 }
 
 if (objXzAdminClsEN.IdAdminClsType !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdAdminClsType);
 var strIdAdminClsType = objXzAdminClsEN.IdAdminClsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminClsType + "'");
 }
 
 if (objXzAdminClsEN.AdminClsIndex !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.AdminClsIndex);
 arrValueListForInsert.Add(objXzAdminClsEN.AdminClsIndex.ToString());
 }
 
 if (objXzAdminClsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.Memo);
 var strMemo = objXzAdminClsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objXzAdminClsEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.ModifyUserId);
 var strModifyUserId = objXzAdminClsEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objXzAdminClsEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.ModifyDate);
 var strModifyDate = objXzAdminClsEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzAdminCls");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objXzAdminClsEN.IdAdminCls;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsXzAdminClsEN objXzAdminClsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objXzAdminClsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzAdminClsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzAdminClsEN.IdAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdAdminCls);
 var strIdAdminCls = objXzAdminClsEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminCls + "'");
 }
 
 if (objXzAdminClsEN.AdminClsName !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.AdminClsName);
 var strAdminClsName = objXzAdminClsEN.AdminClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAdminClsName + "'");
 }
 
 if (objXzAdminClsEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdXzMajor);
 var strIdXzMajor = objXzAdminClsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objXzAdminClsEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdXzCollege);
 var strIdXzCollege = objXzAdminClsEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objXzAdminClsEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdUniZone);
 var strIdUniZone = objXzAdminClsEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 if (objXzAdminClsEN.CurrentStuQty !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.CurrentStuQty);
 arrValueListForInsert.Add(objXzAdminClsEN.CurrentStuQty.ToString());
 }
 
 if (objXzAdminClsEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdGradeBase);
 var strIdGradeBase = objXzAdminClsEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objXzAdminClsEN.AdminClsId !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.AdminClsId);
 var strAdminClsId = objXzAdminClsEN.AdminClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAdminClsId + "'");
 }
 
 if (objXzAdminClsEN.IdAdminClsType !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdAdminClsType);
 var strIdAdminClsType = objXzAdminClsEN.IdAdminClsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminClsType + "'");
 }
 
 if (objXzAdminClsEN.AdminClsIndex !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.AdminClsIndex);
 arrValueListForInsert.Add(objXzAdminClsEN.AdminClsIndex.ToString());
 }
 
 if (objXzAdminClsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.Memo);
 var strMemo = objXzAdminClsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objXzAdminClsEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.ModifyUserId);
 var strModifyUserId = objXzAdminClsEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objXzAdminClsEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.ModifyDate);
 var strModifyDate = objXzAdminClsEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzAdminCls");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objXzAdminClsEN.IdAdminCls;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsXzAdminClsEN objXzAdminClsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objXzAdminClsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzAdminClsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzAdminClsEN.IdAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdAdminCls);
 var strIdAdminCls = objXzAdminClsEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminCls + "'");
 }
 
 if (objXzAdminClsEN.AdminClsName !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.AdminClsName);
 var strAdminClsName = objXzAdminClsEN.AdminClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAdminClsName + "'");
 }
 
 if (objXzAdminClsEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdXzMajor);
 var strIdXzMajor = objXzAdminClsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objXzAdminClsEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdXzCollege);
 var strIdXzCollege = objXzAdminClsEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objXzAdminClsEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdUniZone);
 var strIdUniZone = objXzAdminClsEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 if (objXzAdminClsEN.CurrentStuQty !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.CurrentStuQty);
 arrValueListForInsert.Add(objXzAdminClsEN.CurrentStuQty.ToString());
 }
 
 if (objXzAdminClsEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdGradeBase);
 var strIdGradeBase = objXzAdminClsEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objXzAdminClsEN.AdminClsId !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.AdminClsId);
 var strAdminClsId = objXzAdminClsEN.AdminClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAdminClsId + "'");
 }
 
 if (objXzAdminClsEN.IdAdminClsType !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.IdAdminClsType);
 var strIdAdminClsType = objXzAdminClsEN.IdAdminClsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminClsType + "'");
 }
 
 if (objXzAdminClsEN.AdminClsIndex !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.AdminClsIndex);
 arrValueListForInsert.Add(objXzAdminClsEN.AdminClsIndex.ToString());
 }
 
 if (objXzAdminClsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.Memo);
 var strMemo = objXzAdminClsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objXzAdminClsEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.ModifyUserId);
 var strModifyUserId = objXzAdminClsEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objXzAdminClsEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conXzAdminCls.ModifyDate);
 var strModifyDate = objXzAdminClsEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzAdminCls");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewXzAdminClss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from XzAdminCls where IdAdminCls = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "XzAdminCls");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdAdminCls = oRow[conXzAdminCls.IdAdminCls].ToString().Trim();
if (IsExist(strIdAdminCls))
{
 string strResult = "关键字变量值为:" + string.Format("IdAdminCls = {0}", strIdAdminCls) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsXzAdminClsEN._CurrTabName ].NewRow();
objRow[conXzAdminCls.IdAdminCls] = oRow[conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objRow[conXzAdminCls.AdminClsName] = oRow[conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objRow[conXzAdminCls.IdXzMajor] = oRow[conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objRow[conXzAdminCls.IdXzCollege] = oRow[conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objRow[conXzAdminCls.IdUniZone] = oRow[conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objRow[conXzAdminCls.CurrentStuQty] = oRow[conXzAdminCls.CurrentStuQty].ToString().Trim(); //当前学生数
objRow[conXzAdminCls.IdGradeBase] = oRow[conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objRow[conXzAdminCls.AdminClsId] = oRow[conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objRow[conXzAdminCls.IdAdminClsType] = oRow[conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objRow[conXzAdminCls.AdminClsIndex] = oRow[conXzAdminCls.AdminClsIndex].ToString().Trim(); //AdminClsIndex
objRow[conXzAdminCls.Memo] = oRow[conXzAdminCls.Memo].ToString().Trim(); //备注
objRow[conXzAdminCls.ModifyUserId] = oRow[conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objRow[conXzAdminCls.ModifyDate] = oRow[conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
 objDS.Tables[clsXzAdminClsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsXzAdminClsEN._CurrTabName);
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
 /// <param name = "objXzAdminClsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsXzAdminClsEN objXzAdminClsEN)
{
 if (objXzAdminClsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzAdminClsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from XzAdminCls where IdAdminCls = " + "'"+ objXzAdminClsEN.IdAdminCls+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsXzAdminClsEN._CurrTabName);
if (objDS.Tables[clsXzAdminClsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdAdminCls = " + "'"+ objXzAdminClsEN.IdAdminCls+"'");
return false;
}
objRow = objDS.Tables[clsXzAdminClsEN._CurrTabName].Rows[0];
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdAdminCls))
 {
objRow[conXzAdminCls.IdAdminCls] = objXzAdminClsEN.IdAdminCls; //行政班流水号
 }
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.AdminClsName))
 {
objRow[conXzAdminCls.AdminClsName] = objXzAdminClsEN.AdminClsName; //行政班名称
 }
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdXzMajor))
 {
objRow[conXzAdminCls.IdXzMajor] = objXzAdminClsEN.IdXzMajor; //专业流水号
 }
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdXzCollege))
 {
objRow[conXzAdminCls.IdXzCollege] = objXzAdminClsEN.IdXzCollege; //学院流水号
 }
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdUniZone))
 {
objRow[conXzAdminCls.IdUniZone] = objXzAdminClsEN.IdUniZone; //校区流水号
 }
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.CurrentStuQty))
 {
objRow[conXzAdminCls.CurrentStuQty] = objXzAdminClsEN.CurrentStuQty; //当前学生数
 }
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdGradeBase))
 {
objRow[conXzAdminCls.IdGradeBase] = objXzAdminClsEN.IdGradeBase; //年级流水号
 }
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.AdminClsId))
 {
objRow[conXzAdminCls.AdminClsId] = objXzAdminClsEN.AdminClsId; //行政班代号
 }
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdAdminClsType))
 {
objRow[conXzAdminCls.IdAdminClsType] = objXzAdminClsEN.IdAdminClsType; //行政班级类型流水号
 }
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.AdminClsIndex))
 {
objRow[conXzAdminCls.AdminClsIndex] = objXzAdminClsEN.AdminClsIndex; //AdminClsIndex
 }
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.Memo))
 {
objRow[conXzAdminCls.Memo] = objXzAdminClsEN.Memo; //备注
 }
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.ModifyUserId))
 {
objRow[conXzAdminCls.ModifyUserId] = objXzAdminClsEN.ModifyUserId; //修改人
 }
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.ModifyDate))
 {
objRow[conXzAdminCls.ModifyDate] = objXzAdminClsEN.ModifyDate; //修改日期
 }
try
{
objDA.Update(objDS, clsXzAdminClsEN._CurrTabName);
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
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsXzAdminClsEN objXzAdminClsEN)
{
 if (objXzAdminClsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzAdminClsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update XzAdminCls Set ");
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.AdminClsName))
 {
 if (objXzAdminClsEN.AdminClsName !=  null)
 {
 var strAdminClsName = objXzAdminClsEN.AdminClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAdminClsName, conXzAdminCls.AdminClsName); //行政班名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.AdminClsName); //行政班名称
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdXzMajor))
 {
 if (objXzAdminClsEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objXzAdminClsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conXzAdminCls.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.IdXzMajor); //专业流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdXzCollege))
 {
 if (objXzAdminClsEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objXzAdminClsEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conXzAdminCls.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.IdXzCollege); //学院流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdUniZone))
 {
 if (objXzAdminClsEN.IdUniZone !=  null)
 {
 var strIdUniZone = objXzAdminClsEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdUniZone, conXzAdminCls.IdUniZone); //校区流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.IdUniZone); //校区流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.CurrentStuQty))
 {
 if (objXzAdminClsEN.CurrentStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzAdminClsEN.CurrentStuQty, conXzAdminCls.CurrentStuQty); //当前学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.CurrentStuQty); //当前学生数
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdGradeBase))
 {
 if (objXzAdminClsEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objXzAdminClsEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGradeBase, conXzAdminCls.IdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.IdGradeBase); //年级流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.AdminClsId))
 {
 if (objXzAdminClsEN.AdminClsId !=  null)
 {
 var strAdminClsId = objXzAdminClsEN.AdminClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAdminClsId, conXzAdminCls.AdminClsId); //行政班代号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.AdminClsId); //行政班代号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdAdminClsType))
 {
 if (objXzAdminClsEN.IdAdminClsType !=  null)
 {
 var strIdAdminClsType = objXzAdminClsEN.IdAdminClsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdAdminClsType, conXzAdminCls.IdAdminClsType); //行政班级类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.IdAdminClsType); //行政班级类型流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.AdminClsIndex))
 {
 if (objXzAdminClsEN.AdminClsIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzAdminClsEN.AdminClsIndex, conXzAdminCls.AdminClsIndex); //AdminClsIndex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.AdminClsIndex); //AdminClsIndex
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.Memo))
 {
 if (objXzAdminClsEN.Memo !=  null)
 {
 var strMemo = objXzAdminClsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conXzAdminCls.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.Memo); //备注
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.ModifyUserId))
 {
 if (objXzAdminClsEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objXzAdminClsEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conXzAdminCls.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.ModifyUserId); //修改人
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.ModifyDate))
 {
 if (objXzAdminClsEN.ModifyDate !=  null)
 {
 var strModifyDate = objXzAdminClsEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conXzAdminCls.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.ModifyDate); //修改日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdAdminCls = '{0}'", objXzAdminClsEN.IdAdminCls); 
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
 /// <param name = "objXzAdminClsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsXzAdminClsEN objXzAdminClsEN, string strCondition)
{
 if (objXzAdminClsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzAdminClsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzAdminCls Set ");
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.AdminClsName))
 {
 if (objXzAdminClsEN.AdminClsName !=  null)
 {
 var strAdminClsName = objXzAdminClsEN.AdminClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AdminClsName = '{0}',", strAdminClsName); //行政班名称
 }
 else
 {
 sbSQL.Append(" AdminClsName = null,"); //行政班名称
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdXzMajor))
 {
 if (objXzAdminClsEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objXzAdminClsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdXzCollege))
 {
 if (objXzAdminClsEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objXzAdminClsEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdUniZone))
 {
 if (objXzAdminClsEN.IdUniZone !=  null)
 {
 var strIdUniZone = objXzAdminClsEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdUniZone = '{0}',", strIdUniZone); //校区流水号
 }
 else
 {
 sbSQL.Append(" IdUniZone = null,"); //校区流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.CurrentStuQty))
 {
 if (objXzAdminClsEN.CurrentStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzAdminClsEN.CurrentStuQty, conXzAdminCls.CurrentStuQty); //当前学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.CurrentStuQty); //当前学生数
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdGradeBase))
 {
 if (objXzAdminClsEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objXzAdminClsEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGradeBase = '{0}',", strIdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGradeBase = null,"); //年级流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.AdminClsId))
 {
 if (objXzAdminClsEN.AdminClsId !=  null)
 {
 var strAdminClsId = objXzAdminClsEN.AdminClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AdminClsId = '{0}',", strAdminClsId); //行政班代号
 }
 else
 {
 sbSQL.Append(" AdminClsId = null,"); //行政班代号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdAdminClsType))
 {
 if (objXzAdminClsEN.IdAdminClsType !=  null)
 {
 var strIdAdminClsType = objXzAdminClsEN.IdAdminClsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdAdminClsType = '{0}',", strIdAdminClsType); //行政班级类型流水号
 }
 else
 {
 sbSQL.Append(" IdAdminClsType = null,"); //行政班级类型流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.AdminClsIndex))
 {
 if (objXzAdminClsEN.AdminClsIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzAdminClsEN.AdminClsIndex, conXzAdminCls.AdminClsIndex); //AdminClsIndex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.AdminClsIndex); //AdminClsIndex
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.Memo))
 {
 if (objXzAdminClsEN.Memo !=  null)
 {
 var strMemo = objXzAdminClsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.ModifyUserId))
 {
 if (objXzAdminClsEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objXzAdminClsEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.ModifyDate))
 {
 if (objXzAdminClsEN.ModifyDate !=  null)
 {
 var strModifyDate = objXzAdminClsEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
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
 /// <param name = "objXzAdminClsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsXzAdminClsEN objXzAdminClsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objXzAdminClsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzAdminClsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzAdminCls Set ");
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.AdminClsName))
 {
 if (objXzAdminClsEN.AdminClsName !=  null)
 {
 var strAdminClsName = objXzAdminClsEN.AdminClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AdminClsName = '{0}',", strAdminClsName); //行政班名称
 }
 else
 {
 sbSQL.Append(" AdminClsName = null,"); //行政班名称
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdXzMajor))
 {
 if (objXzAdminClsEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objXzAdminClsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdXzCollege))
 {
 if (objXzAdminClsEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objXzAdminClsEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdUniZone))
 {
 if (objXzAdminClsEN.IdUniZone !=  null)
 {
 var strIdUniZone = objXzAdminClsEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdUniZone = '{0}',", strIdUniZone); //校区流水号
 }
 else
 {
 sbSQL.Append(" IdUniZone = null,"); //校区流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.CurrentStuQty))
 {
 if (objXzAdminClsEN.CurrentStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzAdminClsEN.CurrentStuQty, conXzAdminCls.CurrentStuQty); //当前学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.CurrentStuQty); //当前学生数
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdGradeBase))
 {
 if (objXzAdminClsEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objXzAdminClsEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGradeBase = '{0}',", strIdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGradeBase = null,"); //年级流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.AdminClsId))
 {
 if (objXzAdminClsEN.AdminClsId !=  null)
 {
 var strAdminClsId = objXzAdminClsEN.AdminClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AdminClsId = '{0}',", strAdminClsId); //行政班代号
 }
 else
 {
 sbSQL.Append(" AdminClsId = null,"); //行政班代号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdAdminClsType))
 {
 if (objXzAdminClsEN.IdAdminClsType !=  null)
 {
 var strIdAdminClsType = objXzAdminClsEN.IdAdminClsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdAdminClsType = '{0}',", strIdAdminClsType); //行政班级类型流水号
 }
 else
 {
 sbSQL.Append(" IdAdminClsType = null,"); //行政班级类型流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.AdminClsIndex))
 {
 if (objXzAdminClsEN.AdminClsIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzAdminClsEN.AdminClsIndex, conXzAdminCls.AdminClsIndex); //AdminClsIndex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.AdminClsIndex); //AdminClsIndex
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.Memo))
 {
 if (objXzAdminClsEN.Memo !=  null)
 {
 var strMemo = objXzAdminClsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.ModifyUserId))
 {
 if (objXzAdminClsEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objXzAdminClsEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.ModifyDate))
 {
 if (objXzAdminClsEN.ModifyDate !=  null)
 {
 var strModifyDate = objXzAdminClsEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
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
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsXzAdminClsEN objXzAdminClsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objXzAdminClsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzAdminClsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzAdminCls Set ");
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.AdminClsName))
 {
 if (objXzAdminClsEN.AdminClsName !=  null)
 {
 var strAdminClsName = objXzAdminClsEN.AdminClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAdminClsName, conXzAdminCls.AdminClsName); //行政班名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.AdminClsName); //行政班名称
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdXzMajor))
 {
 if (objXzAdminClsEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objXzAdminClsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conXzAdminCls.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.IdXzMajor); //专业流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdXzCollege))
 {
 if (objXzAdminClsEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objXzAdminClsEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conXzAdminCls.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.IdXzCollege); //学院流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdUniZone))
 {
 if (objXzAdminClsEN.IdUniZone !=  null)
 {
 var strIdUniZone = objXzAdminClsEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdUniZone, conXzAdminCls.IdUniZone); //校区流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.IdUniZone); //校区流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.CurrentStuQty))
 {
 if (objXzAdminClsEN.CurrentStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzAdminClsEN.CurrentStuQty, conXzAdminCls.CurrentStuQty); //当前学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.CurrentStuQty); //当前学生数
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdGradeBase))
 {
 if (objXzAdminClsEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objXzAdminClsEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGradeBase, conXzAdminCls.IdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.IdGradeBase); //年级流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.AdminClsId))
 {
 if (objXzAdminClsEN.AdminClsId !=  null)
 {
 var strAdminClsId = objXzAdminClsEN.AdminClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAdminClsId, conXzAdminCls.AdminClsId); //行政班代号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.AdminClsId); //行政班代号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.IdAdminClsType))
 {
 if (objXzAdminClsEN.IdAdminClsType !=  null)
 {
 var strIdAdminClsType = objXzAdminClsEN.IdAdminClsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdAdminClsType, conXzAdminCls.IdAdminClsType); //行政班级类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.IdAdminClsType); //行政班级类型流水号
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.AdminClsIndex))
 {
 if (objXzAdminClsEN.AdminClsIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzAdminClsEN.AdminClsIndex, conXzAdminCls.AdminClsIndex); //AdminClsIndex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.AdminClsIndex); //AdminClsIndex
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.Memo))
 {
 if (objXzAdminClsEN.Memo !=  null)
 {
 var strMemo = objXzAdminClsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conXzAdminCls.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.Memo); //备注
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.ModifyUserId))
 {
 if (objXzAdminClsEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objXzAdminClsEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conXzAdminCls.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.ModifyUserId); //修改人
 }
 }
 
 if (objXzAdminClsEN.IsUpdated(conXzAdminCls.ModifyDate))
 {
 if (objXzAdminClsEN.ModifyDate !=  null)
 {
 var strModifyDate = objXzAdminClsEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conXzAdminCls.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzAdminCls.ModifyDate); //修改日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdAdminCls = '{0}'", objXzAdminClsEN.IdAdminCls); 
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
 /// <param name = "strIdAdminCls">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdAdminCls) 
{
CheckPrimaryKey(strIdAdminCls);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdAdminCls,
};
 objSQL.ExecSP("XzAdminCls_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdAdminCls">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdAdminCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdAdminCls);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
//删除XzAdminCls本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzAdminCls where IdAdminCls = " + "'"+ strIdAdminCls+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelXzAdminCls(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
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
//删除XzAdminCls本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzAdminCls where IdAdminCls in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdAdminCls">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdAdminCls) 
{
CheckPrimaryKey(strIdAdminCls);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
//删除XzAdminCls本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzAdminCls where IdAdminCls = " + "'"+ strIdAdminCls+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelXzAdminCls(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsXzAdminClsDA: DelXzAdminCls)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from XzAdminCls where " + strCondition ;
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
public bool DelXzAdminClsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsXzAdminClsDA: DelXzAdminClsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from XzAdminCls where " + strCondition ;
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
 /// <param name = "objXzAdminClsENS">源对象</param>
 /// <param name = "objXzAdminClsENT">目标对象</param>
public void CopyTo(clsXzAdminClsEN objXzAdminClsENS, clsXzAdminClsEN objXzAdminClsENT)
{
objXzAdminClsENT.IdAdminCls = objXzAdminClsENS.IdAdminCls; //行政班流水号
objXzAdminClsENT.AdminClsName = objXzAdminClsENS.AdminClsName; //行政班名称
objXzAdminClsENT.IdXzMajor = objXzAdminClsENS.IdXzMajor; //专业流水号
objXzAdminClsENT.IdXzCollege = objXzAdminClsENS.IdXzCollege; //学院流水号
objXzAdminClsENT.IdUniZone = objXzAdminClsENS.IdUniZone; //校区流水号
objXzAdminClsENT.CurrentStuQty = objXzAdminClsENS.CurrentStuQty; //当前学生数
objXzAdminClsENT.IdGradeBase = objXzAdminClsENS.IdGradeBase; //年级流水号
objXzAdminClsENT.AdminClsId = objXzAdminClsENS.AdminClsId; //行政班代号
objXzAdminClsENT.IdAdminClsType = objXzAdminClsENS.IdAdminClsType; //行政班级类型流水号
objXzAdminClsENT.AdminClsIndex = objXzAdminClsENS.AdminClsIndex; //AdminClsIndex
objXzAdminClsENT.Memo = objXzAdminClsENS.Memo; //备注
objXzAdminClsENT.ModifyUserId = objXzAdminClsENS.ModifyUserId; //修改人
objXzAdminClsENT.ModifyDate = objXzAdminClsENS.ModifyDate; //修改日期
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsXzAdminClsEN objXzAdminClsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objXzAdminClsEN.IdXzMajor, conXzAdminCls.IdXzMajor);
clsCheckSql.CheckFieldNotNull(objXzAdminClsEN.IdXzCollege, conXzAdminCls.IdXzCollege);
clsCheckSql.CheckFieldNotNull(objXzAdminClsEN.IdGradeBase, conXzAdminCls.IdGradeBase);
//检查字段长度
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdAdminCls, 8, conXzAdminCls.IdAdminCls);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.AdminClsName, 100, conXzAdminCls.AdminClsName);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdXzMajor, 8, conXzAdminCls.IdXzMajor);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdXzCollege, 4, conXzAdminCls.IdXzCollege);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdUniZone, 4, conXzAdminCls.IdUniZone);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdGradeBase, 4, conXzAdminCls.IdGradeBase);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.AdminClsId, 8, conXzAdminCls.AdminClsId);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdAdminClsType, 4, conXzAdminCls.IdAdminClsType);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.Memo, 1000, conXzAdminCls.Memo);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.ModifyUserId, 18, conXzAdminCls.ModifyUserId);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.ModifyDate, 20, conXzAdminCls.ModifyDate);
//检查字段外键固定长度
 objXzAdminClsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsXzAdminClsEN objXzAdminClsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objXzAdminClsEN.AdminClsName, 100, conXzAdminCls.AdminClsName);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdXzMajor, 8, conXzAdminCls.IdXzMajor);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdXzCollege, 4, conXzAdminCls.IdXzCollege);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdUniZone, 4, conXzAdminCls.IdUniZone);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdGradeBase, 4, conXzAdminCls.IdGradeBase);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.AdminClsId, 8, conXzAdminCls.AdminClsId);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdAdminClsType, 4, conXzAdminCls.IdAdminClsType);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.Memo, 1000, conXzAdminCls.Memo);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.ModifyUserId, 18, conXzAdminCls.ModifyUserId);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.ModifyDate, 20, conXzAdminCls.ModifyDate);
//检查外键字段长度
 objXzAdminClsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsXzAdminClsEN objXzAdminClsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdAdminCls, 8, conXzAdminCls.IdAdminCls);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.AdminClsName, 100, conXzAdminCls.AdminClsName);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdXzMajor, 8, conXzAdminCls.IdXzMajor);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdXzCollege, 4, conXzAdminCls.IdXzCollege);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdUniZone, 4, conXzAdminCls.IdUniZone);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdGradeBase, 4, conXzAdminCls.IdGradeBase);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.AdminClsId, 8, conXzAdminCls.AdminClsId);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.IdAdminClsType, 4, conXzAdminCls.IdAdminClsType);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.Memo, 1000, conXzAdminCls.Memo);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.ModifyUserId, 18, conXzAdminCls.ModifyUserId);
clsCheckSql.CheckFieldLen(objXzAdminClsEN.ModifyDate, 20, conXzAdminCls.ModifyDate);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objXzAdminClsEN.IdAdminCls, conXzAdminCls.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objXzAdminClsEN.AdminClsName, conXzAdminCls.AdminClsName);
clsCheckSql.CheckSqlInjection4Field(objXzAdminClsEN.IdXzMajor, conXzAdminCls.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objXzAdminClsEN.IdXzCollege, conXzAdminCls.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objXzAdminClsEN.IdUniZone, conXzAdminCls.IdUniZone);
clsCheckSql.CheckSqlInjection4Field(objXzAdminClsEN.IdGradeBase, conXzAdminCls.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objXzAdminClsEN.AdminClsId, conXzAdminCls.AdminClsId);
clsCheckSql.CheckSqlInjection4Field(objXzAdminClsEN.IdAdminClsType, conXzAdminCls.IdAdminClsType);
clsCheckSql.CheckSqlInjection4Field(objXzAdminClsEN.Memo, conXzAdminCls.Memo);
clsCheckSql.CheckSqlInjection4Field(objXzAdminClsEN.ModifyUserId, conXzAdminCls.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objXzAdminClsEN.ModifyDate, conXzAdminCls.ModifyDate);
//检查外键字段长度
 objXzAdminClsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdAdminCls()
{
//获取某学院所有专业信息
string strSQL = "select IdAdminCls, AdminClsName from XzAdminCls ";
 clsSpecSQLforSql mySql = clsXzAdminClsDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--XzAdminCls(行政班),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objXzAdminClsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsXzAdminClsEN objXzAdminClsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objXzAdminClsEN.AdminClsName == null)
{
 sbCondition.AppendFormat(" and AdminClsName is null");
}
else
{
 sbCondition.AppendFormat(" and AdminClsName = '{0}'", objXzAdminClsEN.AdminClsName);
}
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
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
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
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
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
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsXzAdminClsEN._CurrTabName);
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
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsXzAdminClsEN._CurrTabName, strCondition);
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
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
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
 objSQL = clsXzAdminClsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}