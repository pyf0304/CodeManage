
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserRightDetailDA
 表名:QxUserRightDetail(01120178)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
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
 /// 用户权限详细关系(QxUserRightDetail)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQxUserRightDetailDA : clsCommBase4DA
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
 return clsQxUserRightDetailEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQxUserRightDetailEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUserRightDetailEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQxUserRightDetailEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQxUserRightDetailEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQxUserRightDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserRightDetail where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QxUserRightDetail(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQxUserRightDetailDA: GetDataTable_QxUserRightDetail)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserRightDetail where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQxUserRightDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQxUserRightDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserRightDetail where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQxUserRightDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQxUserRightDetailDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUserRightDetail where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUserRightDetail where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQxUserRightDetailDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QxUserRightDetail where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQxUserRightDetailDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUserRightDetail.* from QxUserRightDetail Left Join {1} on {2} where {3} and QxUserRightDetail.mId not in (Select top {5} QxUserRightDetail.mId from QxUserRightDetail Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUserRightDetail where {1} and mId not in (Select top {2} mId from QxUserRightDetail where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUserRightDetail where {1} and mId not in (Select top {3} mId from QxUserRightDetail where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQxUserRightDetailDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QxUserRightDetail.* from QxUserRightDetail Left Join {1} on {2} where {3} and QxUserRightDetail.mId not in (Select top {5} QxUserRightDetail.mId from QxUserRightDetail Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QxUserRightDetail where {1} and mId not in (Select top {2} mId from QxUserRightDetail where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QxUserRightDetail where {1} and mId not in (Select top {3} mId from QxUserRightDetail where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsQxUserRightDetailEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQxUserRightDetailDA:GetObjLst)", objException.Message));
}
List<clsQxUserRightDetailEN> arrObjLst = new List<clsQxUserRightDetailEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserRightDetail where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightDetailEN objQxUserRightDetailEN = new clsQxUserRightDetailEN();
try
{
objQxUserRightDetailEN.mId = TransNullToInt(objRow[conQxUserRightDetail.mId].ToString().Trim()); //mId
objQxUserRightDetailEN.UserId = objRow[conQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[conQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objQxUserRightDetailEN.RightId = objRow[conQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objQxUserRightDetailEN.Authorizer = objRow[conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objQxUserRightDetailEN.mKeyId = objRow[conQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objQxUserRightDetailEN.UpdDate = objRow[conQxUserRightDetail.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objQxUserRightDetailEN.UpdUser = objRow[conQxUserRightDetail.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objQxUserRightDetailEN.Memo = objRow[conQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[conQxUserRightDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxUserRightDetailDA: GetObjLst)", objException.Message));
}
objQxUserRightDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUserRightDetailEN);
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
public List<clsQxUserRightDetailEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQxUserRightDetailDA:GetObjLstByTabName)", objException.Message));
}
List<clsQxUserRightDetailEN> arrObjLst = new List<clsQxUserRightDetailEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightDetailEN objQxUserRightDetailEN = new clsQxUserRightDetailEN();
try
{
objQxUserRightDetailEN.mId = TransNullToInt(objRow[conQxUserRightDetail.mId].ToString().Trim()); //mId
objQxUserRightDetailEN.UserId = objRow[conQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[conQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objQxUserRightDetailEN.RightId = objRow[conQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objQxUserRightDetailEN.Authorizer = objRow[conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objQxUserRightDetailEN.mKeyId = objRow[conQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objQxUserRightDetailEN.UpdDate = objRow[conQxUserRightDetail.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objQxUserRightDetailEN.UpdUser = objRow[conQxUserRightDetail.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objQxUserRightDetailEN.Memo = objRow[conQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[conQxUserRightDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQxUserRightDetailDA: GetObjLst)", objException.Message));
}
objQxUserRightDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQxUserRightDetailEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQxUserRightDetail(ref clsQxUserRightDetailEN objQxUserRightDetailEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserRightDetail where mId = " + ""+ objQxUserRightDetailEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQxUserRightDetailEN.mId = TransNullToInt(objDT.Rows[0][conQxUserRightDetail.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objQxUserRightDetailEN.UserId = objDT.Rows[0][conQxUserRightDetail.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objQxUserRightDetailEN.RightId = objDT.Rows[0][conQxUserRightDetail.RightId].ToString().Trim(); //权限编号(字段类型:char,字段长度:8,是否可空:False)
 objQxUserRightDetailEN.Authorizer = objDT.Rows[0][conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUserRightDetailEN.mKeyId = objDT.Rows[0][conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id(字段类型:varchar,字段长度:10,是否可空:True)
 objQxUserRightDetailEN.UpdDate = objDT.Rows[0][conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUserRightDetailEN.UpdUser = objDT.Rows[0][conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUserRightDetailEN.Memo = objDT.Rows[0][conQxUserRightDetail.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQxUserRightDetailDA: GetQxUserRightDetail)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsQxUserRightDetailEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserRightDetail where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQxUserRightDetailEN objQxUserRightDetailEN = new clsQxUserRightDetailEN();
try
{
 objQxUserRightDetailEN.mId = Int32.Parse(objRow[conQxUserRightDetail.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objQxUserRightDetailEN.UserId = objRow[conQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[conQxUserRightDetail.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objQxUserRightDetailEN.RightId = objRow[conQxUserRightDetail.RightId].ToString().Trim(); //权限编号(字段类型:char,字段长度:8,是否可空:False)
 objQxUserRightDetailEN.Authorizer = objRow[conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人(字段类型:varchar,字段长度:18,是否可空:False)
 objQxUserRightDetailEN.mKeyId = objRow[conQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id(字段类型:varchar,字段长度:10,是否可空:True)
 objQxUserRightDetailEN.UpdDate = objRow[conQxUserRightDetail.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUserRightDetailEN.UpdUser = objRow[conQxUserRightDetail.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objQxUserRightDetailEN.Memo = objRow[conQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[conQxUserRightDetail.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQxUserRightDetailDA: GetObjBymId)", objException.Message));
}
return objQxUserRightDetailEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQxUserRightDetailEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQxUserRightDetailDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserRightDetail where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQxUserRightDetailEN objQxUserRightDetailEN = new clsQxUserRightDetailEN()
{
mId = TransNullToInt(objRow[conQxUserRightDetail.mId].ToString().Trim()), //mId
UserId = objRow[conQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[conQxUserRightDetail.UserId].ToString().Trim(), //用户ID
RightId = objRow[conQxUserRightDetail.RightId].ToString().Trim(), //权限编号
Authorizer = objRow[conQxUserRightDetail.Authorizer].ToString().Trim(), //授权人
mKeyId = objRow[conQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[conQxUserRightDetail.mKeyId].ToString().Trim(), //关键字Id
UpdDate = objRow[conQxUserRightDetail.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conQxUserRightDetail.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[conQxUserRightDetail.Memo].ToString().Trim() //备注
};
objQxUserRightDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUserRightDetailEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQxUserRightDetailDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQxUserRightDetailEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxUserRightDetailEN objQxUserRightDetailEN = new clsQxUserRightDetailEN();
try
{
objQxUserRightDetailEN.mId = TransNullToInt(objRow[conQxUserRightDetail.mId].ToString().Trim()); //mId
objQxUserRightDetailEN.UserId = objRow[conQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[conQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objQxUserRightDetailEN.RightId = objRow[conQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objQxUserRightDetailEN.Authorizer = objRow[conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objQxUserRightDetailEN.mKeyId = objRow[conQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objQxUserRightDetailEN.UpdDate = objRow[conQxUserRightDetail.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objQxUserRightDetailEN.UpdUser = objRow[conQxUserRightDetail.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objQxUserRightDetailEN.Memo = objRow[conQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[conQxUserRightDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQxUserRightDetailDA: GetObjByDataRowQxUserRightDetail)", objException.Message));
}
objQxUserRightDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUserRightDetailEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQxUserRightDetailEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQxUserRightDetailEN objQxUserRightDetailEN = new clsQxUserRightDetailEN();
try
{
objQxUserRightDetailEN.mId = TransNullToInt(objRow[conQxUserRightDetail.mId].ToString().Trim()); //mId
objQxUserRightDetailEN.UserId = objRow[conQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[conQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objQxUserRightDetailEN.RightId = objRow[conQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objQxUserRightDetailEN.Authorizer = objRow[conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objQxUserRightDetailEN.mKeyId = objRow[conQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objQxUserRightDetailEN.UpdDate = objRow[conQxUserRightDetail.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objQxUserRightDetailEN.UpdUser = objRow[conQxUserRightDetail.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objQxUserRightDetailEN.Memo = objRow[conQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[conQxUserRightDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQxUserRightDetailDA: GetObjByDataRow)", objException.Message));
}
objQxUserRightDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQxUserRightDetailEN;
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
objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxUserRightDetailEN._CurrTabName, conQxUserRightDetail.mId, 8, "");
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
objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQxUserRightDetailEN._CurrTabName, conQxUserRightDetail.mId, 8, strPrefix);
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
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from QxUserRightDetail where " + strCondition;
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
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from QxUserRightDetail where " + strCondition;
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
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxUserRightDetail", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQxUserRightDetailDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QxUserRightDetail", strCondition))
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
objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QxUserRightDetail");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQxUserRightDetailEN objQxUserRightDetailEN)
 {
 objQxUserRightDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUserRightDetailEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserRightDetailEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserRightDetail where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxUserRightDetail");
objRow = objDS.Tables["QxUserRightDetail"].NewRow();
 if (objQxUserRightDetailEN.UserId !=  "")
 {
objRow[conQxUserRightDetail.UserId] = objQxUserRightDetailEN.UserId; //用户ID
 }
objRow[conQxUserRightDetail.RightId] = objQxUserRightDetailEN.RightId; //权限编号
objRow[conQxUserRightDetail.Authorizer] = objQxUserRightDetailEN.Authorizer; //授权人
 if (objQxUserRightDetailEN.mKeyId !=  "")
 {
objRow[conQxUserRightDetail.mKeyId] = objQxUserRightDetailEN.mKeyId; //关键字Id
 }
 if (objQxUserRightDetailEN.UpdDate !=  "")
 {
objRow[conQxUserRightDetail.UpdDate] = objQxUserRightDetailEN.UpdDate; //修改日期
 }
 if (objQxUserRightDetailEN.UpdUser !=  "")
 {
objRow[conQxUserRightDetail.UpdUser] = objQxUserRightDetailEN.UpdUser; //修改人
 }
 if (objQxUserRightDetailEN.Memo !=  "")
 {
objRow[conQxUserRightDetail.Memo] = objQxUserRightDetailEN.Memo; //备注
 }
objDS.Tables[clsQxUserRightDetailEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQxUserRightDetailEN._CurrTabName);
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
 /// <param name = "objQxUserRightDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxUserRightDetailEN objQxUserRightDetailEN)
{
 objQxUserRightDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUserRightDetailEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserRightDetailEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxUserRightDetailEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.UserId);
 var strUserId = objQxUserRightDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUserRightDetailEN.RightId  ==  "")
 {
 objQxUserRightDetailEN.RightId = null;
 }
 if (objQxUserRightDetailEN.RightId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.RightId);
 var strRightId = objQxUserRightDetailEN.RightId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRightId + "'");
 }
 
 if (objQxUserRightDetailEN.Authorizer !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.Authorizer);
 var strAuthorizer = objQxUserRightDetailEN.Authorizer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthorizer + "'");
 }
 
 if (objQxUserRightDetailEN.mKeyId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.mKeyId);
 var strmKeyId = objQxUserRightDetailEN.mKeyId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmKeyId + "'");
 }
 
 if (objQxUserRightDetailEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.UpdDate);
 var strUpdDate = objQxUserRightDetailEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxUserRightDetailEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.UpdUser);
 var strUpdUser = objQxUserRightDetailEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxUserRightDetailEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.Memo);
 var strMemo = objQxUserRightDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUserRightDetail");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxUserRightDetailEN objQxUserRightDetailEN)
{
 objQxUserRightDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUserRightDetailEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserRightDetailEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxUserRightDetailEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.UserId);
 var strUserId = objQxUserRightDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUserRightDetailEN.RightId  ==  "")
 {
 objQxUserRightDetailEN.RightId = null;
 }
 if (objQxUserRightDetailEN.RightId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.RightId);
 var strRightId = objQxUserRightDetailEN.RightId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRightId + "'");
 }
 
 if (objQxUserRightDetailEN.Authorizer !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.Authorizer);
 var strAuthorizer = objQxUserRightDetailEN.Authorizer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthorizer + "'");
 }
 
 if (objQxUserRightDetailEN.mKeyId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.mKeyId);
 var strmKeyId = objQxUserRightDetailEN.mKeyId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmKeyId + "'");
 }
 
 if (objQxUserRightDetailEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.UpdDate);
 var strUpdDate = objQxUserRightDetailEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxUserRightDetailEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.UpdUser);
 var strUpdUser = objQxUserRightDetailEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxUserRightDetailEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.Memo);
 var strMemo = objQxUserRightDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUserRightDetail");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQxUserRightDetailEN objQxUserRightDetailEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxUserRightDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUserRightDetailEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserRightDetailEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxUserRightDetailEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.UserId);
 var strUserId = objQxUserRightDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUserRightDetailEN.RightId  ==  "")
 {
 objQxUserRightDetailEN.RightId = null;
 }
 if (objQxUserRightDetailEN.RightId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.RightId);
 var strRightId = objQxUserRightDetailEN.RightId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRightId + "'");
 }
 
 if (objQxUserRightDetailEN.Authorizer !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.Authorizer);
 var strAuthorizer = objQxUserRightDetailEN.Authorizer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthorizer + "'");
 }
 
 if (objQxUserRightDetailEN.mKeyId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.mKeyId);
 var strmKeyId = objQxUserRightDetailEN.mKeyId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmKeyId + "'");
 }
 
 if (objQxUserRightDetailEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.UpdDate);
 var strUpdDate = objQxUserRightDetailEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxUserRightDetailEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.UpdUser);
 var strUpdUser = objQxUserRightDetailEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxUserRightDetailEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.Memo);
 var strMemo = objQxUserRightDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUserRightDetail");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQxUserRightDetailEN objQxUserRightDetailEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxUserRightDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUserRightDetailEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQxUserRightDetailEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQxUserRightDetailEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.UserId);
 var strUserId = objQxUserRightDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objQxUserRightDetailEN.RightId  ==  "")
 {
 objQxUserRightDetailEN.RightId = null;
 }
 if (objQxUserRightDetailEN.RightId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.RightId);
 var strRightId = objQxUserRightDetailEN.RightId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRightId + "'");
 }
 
 if (objQxUserRightDetailEN.Authorizer !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.Authorizer);
 var strAuthorizer = objQxUserRightDetailEN.Authorizer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthorizer + "'");
 }
 
 if (objQxUserRightDetailEN.mKeyId !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.mKeyId);
 var strmKeyId = objQxUserRightDetailEN.mKeyId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmKeyId + "'");
 }
 
 if (objQxUserRightDetailEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.UpdDate);
 var strUpdDate = objQxUserRightDetailEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQxUserRightDetailEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.UpdUser);
 var strUpdUser = objQxUserRightDetailEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQxUserRightDetailEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQxUserRightDetail.Memo);
 var strMemo = objQxUserRightDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QxUserRightDetail");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQxUserRightDetails(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserRightDetail where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QxUserRightDetail");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQxUserRightDetailEN._CurrTabName ].NewRow();
objRow[conQxUserRightDetail.UserId] = oRow[conQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objRow[conQxUserRightDetail.RightId] = oRow[conQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objRow[conQxUserRightDetail.Authorizer] = oRow[conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objRow[conQxUserRightDetail.mKeyId] = oRow[conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objRow[conQxUserRightDetail.UpdDate] = oRow[conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objRow[conQxUserRightDetail.UpdUser] = oRow[conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objRow[conQxUserRightDetail.Memo] = oRow[conQxUserRightDetail.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQxUserRightDetailEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQxUserRightDetailEN._CurrTabName);
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
 /// <param name = "objQxUserRightDetailEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQxUserRightDetailEN objQxUserRightDetailEN)
{
 objQxUserRightDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUserRightDetailEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserRightDetailEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from QxUserRightDetail where mId = " + ""+ objQxUserRightDetailEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQxUserRightDetailEN._CurrTabName);
if (objDS.Tables[clsQxUserRightDetailEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objQxUserRightDetailEN.mId+"");
return false;
}
objRow = objDS.Tables[clsQxUserRightDetailEN._CurrTabName].Rows[0];
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.UserId))
 {
objRow[conQxUserRightDetail.UserId] = objQxUserRightDetailEN.UserId; //用户ID
 }
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.RightId))
 {
objRow[conQxUserRightDetail.RightId] = objQxUserRightDetailEN.RightId; //权限编号
 }
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.Authorizer))
 {
objRow[conQxUserRightDetail.Authorizer] = objQxUserRightDetailEN.Authorizer; //授权人
 }
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.mKeyId))
 {
objRow[conQxUserRightDetail.mKeyId] = objQxUserRightDetailEN.mKeyId; //关键字Id
 }
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.UpdDate))
 {
objRow[conQxUserRightDetail.UpdDate] = objQxUserRightDetailEN.UpdDate; //修改日期
 }
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.UpdUser))
 {
objRow[conQxUserRightDetail.UpdUser] = objQxUserRightDetailEN.UpdUser; //修改人
 }
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.Memo))
 {
objRow[conQxUserRightDetail.Memo] = objQxUserRightDetailEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQxUserRightDetailEN._CurrTabName);
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
 /// <param name = "objQxUserRightDetailEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxUserRightDetailEN objQxUserRightDetailEN)
{
 objQxUserRightDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUserRightDetailEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserRightDetailEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QxUserRightDetail Set ");
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.UserId))
 {
 if (objQxUserRightDetailEN.UserId !=  null)
 {
 var strUserId = objQxUserRightDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conQxUserRightDetail.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserRightDetail.UserId); //用户ID
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.RightId))
 {
 if (objQxUserRightDetailEN.RightId  ==  "")
 {
 objQxUserRightDetailEN.RightId = null;
 }
 if (objQxUserRightDetailEN.RightId !=  null)
 {
 var strRightId = objQxUserRightDetailEN.RightId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRightId, conQxUserRightDetail.RightId); //权限编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserRightDetail.RightId); //权限编号
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.Authorizer))
 {
 if (objQxUserRightDetailEN.Authorizer !=  null)
 {
 var strAuthorizer = objQxUserRightDetailEN.Authorizer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuthorizer, conQxUserRightDetail.Authorizer); //授权人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserRightDetail.Authorizer); //授权人
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.mKeyId))
 {
 if (objQxUserRightDetailEN.mKeyId !=  null)
 {
 var strmKeyId = objQxUserRightDetailEN.mKeyId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strmKeyId, conQxUserRightDetail.mKeyId); //关键字Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserRightDetail.mKeyId); //关键字Id
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.UpdDate))
 {
 if (objQxUserRightDetailEN.UpdDate !=  null)
 {
 var strUpdDate = objQxUserRightDetailEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxUserRightDetail.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserRightDetail.UpdDate); //修改日期
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.UpdUser))
 {
 if (objQxUserRightDetailEN.UpdUser !=  null)
 {
 var strUpdUser = objQxUserRightDetailEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQxUserRightDetail.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserRightDetail.UpdUser); //修改人
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.Memo))
 {
 if (objQxUserRightDetailEN.Memo !=  null)
 {
 var strMemo = objQxUserRightDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxUserRightDetail.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserRightDetail.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objQxUserRightDetailEN.mId); 
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
 /// <param name = "objQxUserRightDetailEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQxUserRightDetailEN objQxUserRightDetailEN, string strCondition)
{
 objQxUserRightDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUserRightDetailEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserRightDetailEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUserRightDetail Set ");
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.UserId))
 {
 if (objQxUserRightDetailEN.UserId !=  null)
 {
 var strUserId = objQxUserRightDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.RightId))
 {
 if (objQxUserRightDetailEN.RightId  ==  "")
 {
 objQxUserRightDetailEN.RightId = null;
 }
 if (objQxUserRightDetailEN.RightId !=  null)
 {
 var strRightId = objQxUserRightDetailEN.RightId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RightId = '{0}',", strRightId); //权限编号
 }
 else
 {
 sbSQL.Append(" RightId = null,"); //权限编号
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.Authorizer))
 {
 if (objQxUserRightDetailEN.Authorizer !=  null)
 {
 var strAuthorizer = objQxUserRightDetailEN.Authorizer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Authorizer = '{0}',", strAuthorizer); //授权人
 }
 else
 {
 sbSQL.Append(" Authorizer = null,"); //授权人
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.mKeyId))
 {
 if (objQxUserRightDetailEN.mKeyId !=  null)
 {
 var strmKeyId = objQxUserRightDetailEN.mKeyId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" mKeyId = '{0}',", strmKeyId); //关键字Id
 }
 else
 {
 sbSQL.Append(" mKeyId = null,"); //关键字Id
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.UpdDate))
 {
 if (objQxUserRightDetailEN.UpdDate !=  null)
 {
 var strUpdDate = objQxUserRightDetailEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.UpdUser))
 {
 if (objQxUserRightDetailEN.UpdUser !=  null)
 {
 var strUpdUser = objQxUserRightDetailEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.Memo))
 {
 if (objQxUserRightDetailEN.Memo !=  null)
 {
 var strMemo = objQxUserRightDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxUserRightDetailEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQxUserRightDetailEN objQxUserRightDetailEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQxUserRightDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUserRightDetailEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserRightDetailEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUserRightDetail Set ");
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.UserId))
 {
 if (objQxUserRightDetailEN.UserId !=  null)
 {
 var strUserId = objQxUserRightDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.RightId))
 {
 if (objQxUserRightDetailEN.RightId  ==  "")
 {
 objQxUserRightDetailEN.RightId = null;
 }
 if (objQxUserRightDetailEN.RightId !=  null)
 {
 var strRightId = objQxUserRightDetailEN.RightId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RightId = '{0}',", strRightId); //权限编号
 }
 else
 {
 sbSQL.Append(" RightId = null,"); //权限编号
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.Authorizer))
 {
 if (objQxUserRightDetailEN.Authorizer !=  null)
 {
 var strAuthorizer = objQxUserRightDetailEN.Authorizer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Authorizer = '{0}',", strAuthorizer); //授权人
 }
 else
 {
 sbSQL.Append(" Authorizer = null,"); //授权人
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.mKeyId))
 {
 if (objQxUserRightDetailEN.mKeyId !=  null)
 {
 var strmKeyId = objQxUserRightDetailEN.mKeyId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" mKeyId = '{0}',", strmKeyId); //关键字Id
 }
 else
 {
 sbSQL.Append(" mKeyId = null,"); //关键字Id
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.UpdDate))
 {
 if (objQxUserRightDetailEN.UpdDate !=  null)
 {
 var strUpdDate = objQxUserRightDetailEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.UpdUser))
 {
 if (objQxUserRightDetailEN.UpdUser !=  null)
 {
 var strUpdUser = objQxUserRightDetailEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.Memo))
 {
 if (objQxUserRightDetailEN.Memo !=  null)
 {
 var strMemo = objQxUserRightDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQxUserRightDetailEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQxUserRightDetailEN objQxUserRightDetailEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQxUserRightDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQxUserRightDetailEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQxUserRightDetailEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QxUserRightDetail Set ");
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.UserId))
 {
 if (objQxUserRightDetailEN.UserId !=  null)
 {
 var strUserId = objQxUserRightDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conQxUserRightDetail.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserRightDetail.UserId); //用户ID
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.RightId))
 {
 if (objQxUserRightDetailEN.RightId  ==  "")
 {
 objQxUserRightDetailEN.RightId = null;
 }
 if (objQxUserRightDetailEN.RightId !=  null)
 {
 var strRightId = objQxUserRightDetailEN.RightId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRightId, conQxUserRightDetail.RightId); //权限编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserRightDetail.RightId); //权限编号
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.Authorizer))
 {
 if (objQxUserRightDetailEN.Authorizer !=  null)
 {
 var strAuthorizer = objQxUserRightDetailEN.Authorizer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuthorizer, conQxUserRightDetail.Authorizer); //授权人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserRightDetail.Authorizer); //授权人
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.mKeyId))
 {
 if (objQxUserRightDetailEN.mKeyId !=  null)
 {
 var strmKeyId = objQxUserRightDetailEN.mKeyId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strmKeyId, conQxUserRightDetail.mKeyId); //关键字Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserRightDetail.mKeyId); //关键字Id
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.UpdDate))
 {
 if (objQxUserRightDetailEN.UpdDate !=  null)
 {
 var strUpdDate = objQxUserRightDetailEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQxUserRightDetail.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserRightDetail.UpdDate); //修改日期
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.UpdUser))
 {
 if (objQxUserRightDetailEN.UpdUser !=  null)
 {
 var strUpdUser = objQxUserRightDetailEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQxUserRightDetail.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserRightDetail.UpdUser); //修改人
 }
 }
 
 if (objQxUserRightDetailEN.IsUpdated(conQxUserRightDetail.Memo))
 {
 if (objQxUserRightDetailEN.Memo !=  null)
 {
 var strMemo = objQxUserRightDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQxUserRightDetail.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQxUserRightDetail.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objQxUserRightDetailEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("QxUserRightDetail_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
//删除QxUserRightDetail本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUserRightDetail where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQxUserRightDetail(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除QxUserRightDetail本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUserRightDetail where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
//删除QxUserRightDetail本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QxUserRightDetail where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQxUserRightDetail(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQxUserRightDetailDA: DelQxUserRightDetail)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxUserRightDetail where " + strCondition ;
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
public bool DelQxUserRightDetailWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQxUserRightDetailDA: DelQxUserRightDetailWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QxUserRightDetail where " + strCondition ;
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
 /// <param name = "objQxUserRightDetailENS">源对象</param>
 /// <param name = "objQxUserRightDetailENT">目标对象</param>
public void CopyTo(clsQxUserRightDetailEN objQxUserRightDetailENS, clsQxUserRightDetailEN objQxUserRightDetailENT)
{
objQxUserRightDetailENT.mId = objQxUserRightDetailENS.mId; //mId
objQxUserRightDetailENT.UserId = objQxUserRightDetailENS.UserId; //用户ID
objQxUserRightDetailENT.RightId = objQxUserRightDetailENS.RightId; //权限编号
objQxUserRightDetailENT.Authorizer = objQxUserRightDetailENS.Authorizer; //授权人
objQxUserRightDetailENT.mKeyId = objQxUserRightDetailENS.mKeyId; //关键字Id
objQxUserRightDetailENT.UpdDate = objQxUserRightDetailENS.UpdDate; //修改日期
objQxUserRightDetailENT.UpdUser = objQxUserRightDetailENS.UpdUser; //修改人
objQxUserRightDetailENT.Memo = objQxUserRightDetailENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUserRightDetailEN objQxUserRightDetailEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQxUserRightDetailEN.RightId, conQxUserRightDetail.RightId);
clsCheckSql.CheckFieldNotNull(objQxUserRightDetailEN.Authorizer, conQxUserRightDetail.Authorizer);
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.UserId, 18, conQxUserRightDetail.UserId);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.RightId, 8, conQxUserRightDetail.RightId);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.Authorizer, 18, conQxUserRightDetail.Authorizer);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.mKeyId, 10, conQxUserRightDetail.mKeyId);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.UpdDate, 20, conQxUserRightDetail.UpdDate);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.UpdUser, 20, conQxUserRightDetail.UpdUser);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.Memo, 1000, conQxUserRightDetail.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQxUserRightDetailEN.RightId, 8, conQxUserRightDetail.RightId);
 objQxUserRightDetailEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQxUserRightDetailEN objQxUserRightDetailEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.UserId, 18, conQxUserRightDetail.UserId);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.RightId, 8, conQxUserRightDetail.RightId);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.Authorizer, 18, conQxUserRightDetail.Authorizer);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.mKeyId, 10, conQxUserRightDetail.mKeyId);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.UpdDate, 20, conQxUserRightDetail.UpdDate);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.UpdUser, 20, conQxUserRightDetail.UpdUser);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.Memo, 1000, conQxUserRightDetail.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxUserRightDetailEN.RightId, 8, conQxUserRightDetail.RightId);
 objQxUserRightDetailEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQxUserRightDetailEN objQxUserRightDetailEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.UserId, 18, conQxUserRightDetail.UserId);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.RightId, 8, conQxUserRightDetail.RightId);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.Authorizer, 18, conQxUserRightDetail.Authorizer);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.mKeyId, 10, conQxUserRightDetail.mKeyId);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.UpdDate, 20, conQxUserRightDetail.UpdDate);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.UpdUser, 20, conQxUserRightDetail.UpdUser);
clsCheckSql.CheckFieldLen(objQxUserRightDetailEN.Memo, 1000, conQxUserRightDetail.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQxUserRightDetailEN.UserId, conQxUserRightDetail.UserId);
clsCheckSql.CheckSqlInjection4Field(objQxUserRightDetailEN.RightId, conQxUserRightDetail.RightId);
clsCheckSql.CheckSqlInjection4Field(objQxUserRightDetailEN.Authorizer, conQxUserRightDetail.Authorizer);
clsCheckSql.CheckSqlInjection4Field(objQxUserRightDetailEN.mKeyId, conQxUserRightDetail.mKeyId);
clsCheckSql.CheckSqlInjection4Field(objQxUserRightDetailEN.UpdDate, conQxUserRightDetail.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQxUserRightDetailEN.UpdUser, conQxUserRightDetail.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objQxUserRightDetailEN.Memo, conQxUserRightDetail.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQxUserRightDetailEN.RightId, 8, conQxUserRightDetail.RightId);
 objQxUserRightDetailEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QxUserRightDetail(用户权限详细关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQxUserRightDetailEN objQxUserRightDetailEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objQxUserRightDetailEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null");
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserRightDetailEN.UserId);
}
 sbCondition.AppendFormat(" and RightId = '{0}'", objQxUserRightDetailEN.RightId);
 if (objQxUserRightDetailEN.mKeyId == null)
{
 sbCondition.AppendFormat(" and mKeyId is null");
}
else
{
 sbCondition.AppendFormat(" and mKeyId = '{0}'", objQxUserRightDetailEN.mKeyId);
}
 sbCondition.AppendFormat(" and Authorizer = '{0}'", objQxUserRightDetailEN.Authorizer);
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
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
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
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
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
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxUserRightDetailEN._CurrTabName);
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
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQxUserRightDetailEN._CurrTabName, strCondition);
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
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
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
 objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}