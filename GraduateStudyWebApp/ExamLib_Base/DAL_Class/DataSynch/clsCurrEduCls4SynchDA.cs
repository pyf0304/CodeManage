
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduCls4SynchDA
 表名:CurrEduCls4Synch(01120358)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:数据同步(DataSynch)
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
 /// 当前教学班_同步(CurrEduCls4Synch)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCurrEduCls4SynchDA : clsCommBase4DA
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
 return clsCurrEduCls4SynchEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCurrEduCls4SynchEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCurrEduCls4SynchEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCurrEduCls4SynchEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCurrEduCls4SynchEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCurrEduCls4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls4Synch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CurrEduCls4Synch(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCurrEduCls4SynchDA: GetDataTable_CurrEduCls4Synch)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCurrEduCls4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCurrEduCls4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls4Synch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCurrEduCls4SynchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCurrEduCls4SynchDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls4Synch where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls4Synch where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCurrEduCls4SynchDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CurrEduCls4Synch where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCurrEduCls4SynchDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CurrEduCls4Synch.* from CurrEduCls4Synch Left Join {1} on {2} where {3} and CurrEduCls4Synch.mId not in (Select top {5} CurrEduCls4Synch.mId from CurrEduCls4Synch Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls4Synch where {1} and mId not in (Select top {2} mId from CurrEduCls4Synch where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls4Synch where {1} and mId not in (Select top {3} mId from CurrEduCls4Synch where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCurrEduCls4SynchDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CurrEduCls4Synch.* from CurrEduCls4Synch Left Join {1} on {2} where {3} and CurrEduCls4Synch.mId not in (Select top {5} CurrEduCls4Synch.mId from CurrEduCls4Synch Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls4Synch where {1} and mId not in (Select top {2} mId from CurrEduCls4Synch where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls4Synch where {1} and mId not in (Select top {3} mId from CurrEduCls4Synch where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCurrEduCls4SynchEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCurrEduCls4SynchDA:GetObjLst)", objException.Message));
}
List<clsCurrEduCls4SynchEN> arrObjLst = new List<clsCurrEduCls4SynchEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls4Synch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN();
try
{
objCurrEduCls4SynchEN.mId = TransNullToInt(objRow[conCurrEduCls4Synch.mId].ToString().Trim()); //mId
objCurrEduCls4SynchEN.IpAddress = objRow[conCurrEduCls4Synch.IpAddress] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址
objCurrEduCls4SynchEN.IdCurrEduCls = objRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls4SynchEN.CurrEduClsId = objRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls4SynchEN.EduClsName = objRow[conCurrEduCls4Synch.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls4SynchEN.EduClsTypeId = objRow[conCurrEduCls4Synch.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls4SynchEN.CourseId = objRow[conCurrEduCls4Synch.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id
objCurrEduCls4SynchEN.TeachingSolutionId = objRow[conCurrEduCls4Synch.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls4SynchEN.IdXzCollege = objRow[conCurrEduCls4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls4SynchEN.IdEduWay = objRow[conCurrEduCls4Synch.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls4SynchEN.IdClassRoomType = objRow[conCurrEduCls4Synch.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls4SynchEN.TotalLessonQty = objRow[conCurrEduCls4Synch.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls4SynchEN.MaxStuQty = objRow[conCurrEduCls4Synch.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls4SynchEN.CurrentStuQty = objRow[conCurrEduCls4Synch.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls4SynchEN.WeekQty = objRow[conCurrEduCls4Synch.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.WeekQty].ToString().Trim()); //总周数
objCurrEduCls4SynchEN.ScheUnitPW = objRow[conCurrEduCls4Synch.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls4SynchEN.WeekStatusId = objRow[conCurrEduCls4Synch.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls4SynchEN.CustomerWeek = objRow[conCurrEduCls4Synch.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls4SynchEN.IsCompleteScore = TransNullToBool(objRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls4SynchEN.IdExecPlan = objRow[conCurrEduCls4Synch.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls4SynchEN.LessonQtyPerWeek = objRow[conCurrEduCls4Synch.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls4SynchEN.Mark = objRow[conCurrEduCls4Synch.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduCls4Synch.Mark].ToString().Trim()); //获得学分
objCurrEduCls4SynchEN.CheckClassRoom = objRow[conCurrEduCls4Synch.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls4SynchEN.CheckAdminCls = objRow[conCurrEduCls4Synch.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls4SynchEN.CheckTeacher = objRow[conCurrEduCls4Synch.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls4SynchEN.EditLocked = TransNullToBool(objRow[conCurrEduCls4Synch.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls4SynchEN.Sched = TransNullToBool(objRow[conCurrEduCls4Synch.Sched].ToString().Trim()); //是否排课
objCurrEduCls4SynchEN.IdUniZone = objRow[conCurrEduCls4Synch.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls4SynchEN.Locked = TransNullToBool(objRow[conCurrEduCls4Synch.Locked].ToString().Trim()); //锁定状态
objCurrEduCls4SynchEN.IdGradeBase = objRow[conCurrEduCls4Synch.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls4SynchEN.IsEffective = TransNullToBool(objRow[conCurrEduCls4Synch.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls4SynchEN.IsUnDeterminedClsRm = TransNullToBool(objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls4SynchEN.SchoolYear = objRow[conCurrEduCls4Synch.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年
objCurrEduCls4SynchEN.SchoolTerm = objRow[conCurrEduCls4Synch.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls4SynchEN.ArrangeCourseMemo = objRow[conCurrEduCls4Synch.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls4SynchEN.IdCourseType = objRow[conCurrEduCls4Synch.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls4SynchEN.ExportDate = objRow[conCurrEduCls4Synch.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls4SynchEN.IsDegree = TransNullToBool(objRow[conCurrEduCls4Synch.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls4SynchEN.IdScoreType = objRow[conCurrEduCls4Synch.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls4SynchEN.GetScoreWayId = objRow[conCurrEduCls4Synch.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls4SynchEN.IsProportionalCtrl = TransNullToBool(objRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls4SynchEN.IsSynchToWeb = TransNullToBool(objRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls4SynchEN.SynchToWebDate = objRow[conCurrEduCls4Synch.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期
objCurrEduCls4SynchEN.SynchToWebUser = objRow[conCurrEduCls4Synch.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls4SynchEN.SignInDate = objRow[conCurrEduCls4Synch.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls4SynchEN.SignInStateID = objRow[conCurrEduCls4Synch.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls4SynchEN.SignInUser = objRow[conCurrEduCls4Synch.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人
objCurrEduCls4SynchEN.IdExamType = objRow[conCurrEduCls4Synch.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls4SynchEN.ExamPortion = objRow[conCurrEduCls4Synch.ExamPortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls4SynchEN.MidExamScorePortion = objRow[conCurrEduCls4Synch.MidExamScorePortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls4SynchEN.IsClearScore = TransNullToBool(objRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls4SynchEN.IsGeneratePwd = TransNullToBool(objRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls4SynchEN.GeneratePwdDate = objRow[conCurrEduCls4Synch.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls4SynchEN.IsExportToGP = TransNullToBool(objRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls4SynchEN.IsExportToGPWeb = TransNullToBool(objRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls4SynchEN.IsReservedDecimal = TransNullToBool(objRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls4SynchEN.ExamTime = objRow[conCurrEduCls4Synch.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls4SynchEN.CheckState = TransNullToBool(objRow[conCurrEduCls4Synch.CheckState].ToString().Trim()); //检查状态
objCurrEduCls4SynchEN.CheckDate = objRow[conCurrEduCls4Synch.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls4SynchEN.IdEduClassInPk = objRow[conCurrEduCls4Synch.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls4SynchEN.PkWeekTime = objRow[conCurrEduCls4Synch.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls4SynchEN.PkClassRooms = objRow[conCurrEduCls4Synch.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls4SynchEN.BeginWeek = objRow[conCurrEduCls4Synch.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls4SynchEN.TeacherNames = objRow[conCurrEduCls4Synch.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls4SynchEN.IsAccessSynch = TransNullToBool(objRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objCurrEduCls4SynchEN.AccessSynchDate = objRow[conCurrEduCls4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objCurrEduCls4SynchEN.IsExistEduClsInCurr = TransNullToBool(objRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()); //当前是否存在教学班
objCurrEduCls4SynchEN.ModifyDate = objRow[conCurrEduCls4Synch.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls4SynchEN.ModifyUserId = objRow[conCurrEduCls4Synch.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls4SynchEN.Memo = objRow[conCurrEduCls4Synch.Memo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCurrEduCls4SynchDA: GetObjLst)", objException.Message));
}
objCurrEduCls4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCurrEduCls4SynchEN);
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
public List<clsCurrEduCls4SynchEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCurrEduCls4SynchDA:GetObjLstByTabName)", objException.Message));
}
List<clsCurrEduCls4SynchEN> arrObjLst = new List<clsCurrEduCls4SynchEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN();
try
{
objCurrEduCls4SynchEN.mId = TransNullToInt(objRow[conCurrEduCls4Synch.mId].ToString().Trim()); //mId
objCurrEduCls4SynchEN.IpAddress = objRow[conCurrEduCls4Synch.IpAddress] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址
objCurrEduCls4SynchEN.IdCurrEduCls = objRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls4SynchEN.CurrEduClsId = objRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls4SynchEN.EduClsName = objRow[conCurrEduCls4Synch.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls4SynchEN.EduClsTypeId = objRow[conCurrEduCls4Synch.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls4SynchEN.CourseId = objRow[conCurrEduCls4Synch.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id
objCurrEduCls4SynchEN.TeachingSolutionId = objRow[conCurrEduCls4Synch.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls4SynchEN.IdXzCollege = objRow[conCurrEduCls4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls4SynchEN.IdEduWay = objRow[conCurrEduCls4Synch.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls4SynchEN.IdClassRoomType = objRow[conCurrEduCls4Synch.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls4SynchEN.TotalLessonQty = objRow[conCurrEduCls4Synch.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls4SynchEN.MaxStuQty = objRow[conCurrEduCls4Synch.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls4SynchEN.CurrentStuQty = objRow[conCurrEduCls4Synch.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls4SynchEN.WeekQty = objRow[conCurrEduCls4Synch.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.WeekQty].ToString().Trim()); //总周数
objCurrEduCls4SynchEN.ScheUnitPW = objRow[conCurrEduCls4Synch.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls4SynchEN.WeekStatusId = objRow[conCurrEduCls4Synch.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls4SynchEN.CustomerWeek = objRow[conCurrEduCls4Synch.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls4SynchEN.IsCompleteScore = TransNullToBool(objRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls4SynchEN.IdExecPlan = objRow[conCurrEduCls4Synch.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls4SynchEN.LessonQtyPerWeek = objRow[conCurrEduCls4Synch.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls4SynchEN.Mark = objRow[conCurrEduCls4Synch.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduCls4Synch.Mark].ToString().Trim()); //获得学分
objCurrEduCls4SynchEN.CheckClassRoom = objRow[conCurrEduCls4Synch.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls4SynchEN.CheckAdminCls = objRow[conCurrEduCls4Synch.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls4SynchEN.CheckTeacher = objRow[conCurrEduCls4Synch.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls4SynchEN.EditLocked = TransNullToBool(objRow[conCurrEduCls4Synch.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls4SynchEN.Sched = TransNullToBool(objRow[conCurrEduCls4Synch.Sched].ToString().Trim()); //是否排课
objCurrEduCls4SynchEN.IdUniZone = objRow[conCurrEduCls4Synch.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls4SynchEN.Locked = TransNullToBool(objRow[conCurrEduCls4Synch.Locked].ToString().Trim()); //锁定状态
objCurrEduCls4SynchEN.IdGradeBase = objRow[conCurrEduCls4Synch.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls4SynchEN.IsEffective = TransNullToBool(objRow[conCurrEduCls4Synch.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls4SynchEN.IsUnDeterminedClsRm = TransNullToBool(objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls4SynchEN.SchoolYear = objRow[conCurrEduCls4Synch.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年
objCurrEduCls4SynchEN.SchoolTerm = objRow[conCurrEduCls4Synch.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls4SynchEN.ArrangeCourseMemo = objRow[conCurrEduCls4Synch.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls4SynchEN.IdCourseType = objRow[conCurrEduCls4Synch.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls4SynchEN.ExportDate = objRow[conCurrEduCls4Synch.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls4SynchEN.IsDegree = TransNullToBool(objRow[conCurrEduCls4Synch.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls4SynchEN.IdScoreType = objRow[conCurrEduCls4Synch.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls4SynchEN.GetScoreWayId = objRow[conCurrEduCls4Synch.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls4SynchEN.IsProportionalCtrl = TransNullToBool(objRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls4SynchEN.IsSynchToWeb = TransNullToBool(objRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls4SynchEN.SynchToWebDate = objRow[conCurrEduCls4Synch.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期
objCurrEduCls4SynchEN.SynchToWebUser = objRow[conCurrEduCls4Synch.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls4SynchEN.SignInDate = objRow[conCurrEduCls4Synch.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls4SynchEN.SignInStateID = objRow[conCurrEduCls4Synch.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls4SynchEN.SignInUser = objRow[conCurrEduCls4Synch.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人
objCurrEduCls4SynchEN.IdExamType = objRow[conCurrEduCls4Synch.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls4SynchEN.ExamPortion = objRow[conCurrEduCls4Synch.ExamPortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls4SynchEN.MidExamScorePortion = objRow[conCurrEduCls4Synch.MidExamScorePortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls4SynchEN.IsClearScore = TransNullToBool(objRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls4SynchEN.IsGeneratePwd = TransNullToBool(objRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls4SynchEN.GeneratePwdDate = objRow[conCurrEduCls4Synch.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls4SynchEN.IsExportToGP = TransNullToBool(objRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls4SynchEN.IsExportToGPWeb = TransNullToBool(objRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls4SynchEN.IsReservedDecimal = TransNullToBool(objRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls4SynchEN.ExamTime = objRow[conCurrEduCls4Synch.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls4SynchEN.CheckState = TransNullToBool(objRow[conCurrEduCls4Synch.CheckState].ToString().Trim()); //检查状态
objCurrEduCls4SynchEN.CheckDate = objRow[conCurrEduCls4Synch.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls4SynchEN.IdEduClassInPk = objRow[conCurrEduCls4Synch.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls4SynchEN.PkWeekTime = objRow[conCurrEduCls4Synch.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls4SynchEN.PkClassRooms = objRow[conCurrEduCls4Synch.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls4SynchEN.BeginWeek = objRow[conCurrEduCls4Synch.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls4SynchEN.TeacherNames = objRow[conCurrEduCls4Synch.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls4SynchEN.IsAccessSynch = TransNullToBool(objRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objCurrEduCls4SynchEN.AccessSynchDate = objRow[conCurrEduCls4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objCurrEduCls4SynchEN.IsExistEduClsInCurr = TransNullToBool(objRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()); //当前是否存在教学班
objCurrEduCls4SynchEN.ModifyDate = objRow[conCurrEduCls4Synch.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls4SynchEN.ModifyUserId = objRow[conCurrEduCls4Synch.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls4SynchEN.Memo = objRow[conCurrEduCls4Synch.Memo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCurrEduCls4SynchDA: GetObjLst)", objException.Message));
}
objCurrEduCls4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCurrEduCls4SynchEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCurrEduCls4Synch(ref clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls4Synch where mId = " + ""+ objCurrEduCls4SynchEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCurrEduCls4SynchEN.mId = TransNullToInt(objDT.Rows[0][conCurrEduCls4Synch.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objCurrEduCls4SynchEN.IpAddress = objDT.Rows[0][conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址(字段类型:varchar,字段长度:50,是否可空:True)
 objCurrEduCls4SynchEN.IdCurrEduCls = objDT.Rows[0][conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduCls4SynchEN.CurrEduClsId = objDT.Rows[0][conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objCurrEduCls4SynchEN.EduClsName = objDT.Rows[0][conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objCurrEduCls4SynchEN.EduClsTypeId = objDT.Rows[0][conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.CourseId = objDT.Rows[0][conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objCurrEduCls4SynchEN.TeachingSolutionId = objDT.Rows[0][conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduCls4SynchEN.IdXzCollege = objDT.Rows[0][conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objCurrEduCls4SynchEN.IdEduWay = objDT.Rows[0][conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.IdClassRoomType = objDT.Rows[0][conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.TotalLessonQty = TransNullToInt(objDT.Rows[0][conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()); //总课时数(字段类型:int,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.MaxStuQty = TransNullToInt(objDT.Rows[0][conCurrEduCls4Synch.MaxStuQty].ToString().Trim()); //最大学生数(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduCls4SynchEN.CurrentStuQty = TransNullToInt(objDT.Rows[0][conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()); //当前学生数(字段类型:int,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.WeekQty = TransNullToInt(objDT.Rows[0][conCurrEduCls4Synch.WeekQty].ToString().Trim()); //总周数(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduCls4SynchEN.ScheUnitPW = TransNullToShort(objDT.Rows[0][conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()); //周排课次数(字段类型:smallint,字段长度:2,是否可空:True)
 objCurrEduCls4SynchEN.WeekStatusId = objDT.Rows[0][conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduCls4SynchEN.CustomerWeek = objDT.Rows[0][conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周(字段类型:varchar,字段长度:50,是否可空:True)
 objCurrEduCls4SynchEN.IsCompleteScore = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()); //是否成绩齐全(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.IdExecPlan = objDT.Rows[0][conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduCls4SynchEN.LessonQtyPerWeek = TransNullToShort(objDT.Rows[0][conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()); //周课时数(字段类型:smallint,字段长度:2,是否可空:False)
 objCurrEduCls4SynchEN.Mark = TransNullToDouble(objDT.Rows[0][conCurrEduCls4Synch.Mark].ToString().Trim()); //获得学分(字段类型:decimal,字段长度:7,是否可空:True)
 objCurrEduCls4SynchEN.CheckClassRoom = objDT.Rows[0][conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objCurrEduCls4SynchEN.CheckAdminCls = objDT.Rows[0][conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objCurrEduCls4SynchEN.CheckTeacher = objDT.Rows[0][conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objCurrEduCls4SynchEN.EditLocked = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.EditLocked].ToString().Trim()); //编辑锁定(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls4SynchEN.Sched = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.Sched].ToString().Trim()); //是否排课(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.IdUniZone = objDT.Rows[0][conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.Locked = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.Locked].ToString().Trim()); //锁定状态(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.IdGradeBase = objDT.Rows[0][conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objCurrEduCls4SynchEN.IsEffective = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.IsUnDeterminedClsRm = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.SchoolYear = objDT.Rows[0][conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objCurrEduCls4SynchEN.SchoolTerm = objDT.Rows[0][conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.ArrangeCourseMemo = objDT.Rows[0][conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注(字段类型:varchar,字段长度:50,是否可空:True)
 objCurrEduCls4SynchEN.IdCourseType = objDT.Rows[0][conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.ExportDate = objDT.Rows[0][conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期(字段类型:varchar,字段长度:8,是否可空:True)
 objCurrEduCls4SynchEN.IsDegree = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.IsDegree].ToString().Trim()); //是否学位课(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls4SynchEN.IdScoreType = objDT.Rows[0][conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.GetScoreWayId = objDT.Rows[0][conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduCls4SynchEN.IsProportionalCtrl = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()); //是否比例控制(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.IsSynchToWeb = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()); //是否同步Web(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.SynchToWebDate = objDT.Rows[0][conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduCls4SynchEN.SynchToWebUser = objDT.Rows[0][conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduCls4SynchEN.SignInDate = objDT.Rows[0][conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduCls4SynchEN.SignInStateID = objDT.Rows[0][conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduCls4SynchEN.SignInUser = objDT.Rows[0][conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduCls4SynchEN.IdExamType = objDT.Rows[0][conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.ExamPortion = TransNullToShort(objDT.Rows[0][conCurrEduCls4Synch.ExamPortion].ToString().Trim()); //平时成绩所占比例(字段类型:smallint,字段长度:2,是否可空:False)
 objCurrEduCls4SynchEN.MidExamScorePortion = TransNullToShort(objDT.Rows[0][conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例(字段类型:smallint,字段长度:2,是否可空:True)
 objCurrEduCls4SynchEN.IsClearScore = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.IsClearScore].ToString().Trim()); //是否重录成绩(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.IsGeneratePwd = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()); //是否生成口令(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.GeneratePwdDate = objDT.Rows[0][conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduCls4SynchEN.IsExportToGP = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.IsExportToGP].ToString().Trim()); //是否导出到平台(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.IsExportToGPWeb = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.IsReservedDecimal = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()); //是否保留小数(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls4SynchEN.ExamTime = objDT.Rows[0][conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间(字段类型:varchar,字段长度:8,是否可空:True)
 objCurrEduCls4SynchEN.CheckState = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.CheckState].ToString().Trim()); //检查状态(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls4SynchEN.CheckDate = objDT.Rows[0][conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期(字段类型:varchar,字段长度:20,是否可空:False)
 objCurrEduCls4SynchEN.IdEduClassInPk = objDT.Rows[0][conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk(字段类型:char,字段长度:8,是否可空:True)
 objCurrEduCls4SynchEN.PkWeekTime = objDT.Rows[0][conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间(字段类型:varchar,字段长度:2000,是否可空:True)
 objCurrEduCls4SynchEN.PkClassRooms = objDT.Rows[0][conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室(字段类型:varchar,字段长度:150,是否可空:True)
 objCurrEduCls4SynchEN.BeginWeek = TransNullToShort(objDT.Rows[0][conCurrEduCls4Synch.BeginWeek].ToString().Trim()); //开始周(字段类型:smallint,字段长度:2,是否可空:True)
 objCurrEduCls4SynchEN.TeacherNames = objDT.Rows[0][conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:100,是否可空:True)
 objCurrEduCls4SynchEN.IsAccessSynch = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.AccessSynchDate = objDT.Rows[0][conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期(字段类型:varchar,字段长度:14,是否可空:True)
 objCurrEduCls4SynchEN.IsExistEduClsInCurr = TransNullToBool(objDT.Rows[0][conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()); //当前是否存在教学班(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.ModifyDate = objDT.Rows[0][conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduCls4SynchEN.ModifyUserId = objDT.Rows[0][conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduCls4SynchEN.Memo = objDT.Rows[0][conCurrEduCls4Synch.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCurrEduCls4SynchDA: GetCurrEduCls4Synch)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsCurrEduCls4SynchEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls4Synch where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN();
try
{
 objCurrEduCls4SynchEN.mId = Int32.Parse(objRow[conCurrEduCls4Synch.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objCurrEduCls4SynchEN.IpAddress = objRow[conCurrEduCls4Synch.IpAddress] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址(字段类型:varchar,字段长度:50,是否可空:True)
 objCurrEduCls4SynchEN.IdCurrEduCls = objRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduCls4SynchEN.CurrEduClsId = objRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objCurrEduCls4SynchEN.EduClsName = objRow[conCurrEduCls4Synch.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objCurrEduCls4SynchEN.EduClsTypeId = objRow[conCurrEduCls4Synch.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.CourseId = objRow[conCurrEduCls4Synch.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objCurrEduCls4SynchEN.TeachingSolutionId = objRow[conCurrEduCls4Synch.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduCls4SynchEN.IdXzCollege = objRow[conCurrEduCls4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objCurrEduCls4SynchEN.IdEduWay = objRow[conCurrEduCls4Synch.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.IdClassRoomType = objRow[conCurrEduCls4Synch.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.TotalLessonQty = objRow[conCurrEduCls4Synch.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()); //总课时数(字段类型:int,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.MaxStuQty = objRow[conCurrEduCls4Synch.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim()); //最大学生数(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduCls4SynchEN.CurrentStuQty = objRow[conCurrEduCls4Synch.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()); //当前学生数(字段类型:int,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.WeekQty = objRow[conCurrEduCls4Synch.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.WeekQty].ToString().Trim()); //总周数(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduCls4SynchEN.ScheUnitPW = objRow[conCurrEduCls4Synch.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()); //周排课次数(字段类型:smallint,字段长度:2,是否可空:True)
 objCurrEduCls4SynchEN.WeekStatusId = objRow[conCurrEduCls4Synch.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduCls4SynchEN.CustomerWeek = objRow[conCurrEduCls4Synch.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周(字段类型:varchar,字段长度:50,是否可空:True)
 objCurrEduCls4SynchEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()); //是否成绩齐全(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.IdExecPlan = objRow[conCurrEduCls4Synch.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduCls4SynchEN.LessonQtyPerWeek = objRow[conCurrEduCls4Synch.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()); //周课时数(字段类型:smallint,字段长度:2,是否可空:False)
 objCurrEduCls4SynchEN.Mark = objRow[conCurrEduCls4Synch.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls4Synch.Mark].ToString().Trim()); //获得学分(字段类型:decimal,字段长度:7,是否可空:True)
 objCurrEduCls4SynchEN.CheckClassRoom = objRow[conCurrEduCls4Synch.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objCurrEduCls4SynchEN.CheckAdminCls = objRow[conCurrEduCls4Synch.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objCurrEduCls4SynchEN.CheckTeacher = objRow[conCurrEduCls4Synch.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objCurrEduCls4SynchEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.EditLocked].ToString().Trim()); //编辑锁定(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls4SynchEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Sched].ToString().Trim()); //是否排课(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.IdUniZone = objRow[conCurrEduCls4Synch.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Locked].ToString().Trim()); //锁定状态(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.IdGradeBase = objRow[conCurrEduCls4Synch.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objCurrEduCls4SynchEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.SchoolYear = objRow[conCurrEduCls4Synch.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objCurrEduCls4SynchEN.SchoolTerm = objRow[conCurrEduCls4Synch.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.ArrangeCourseMemo = objRow[conCurrEduCls4Synch.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注(字段类型:varchar,字段长度:50,是否可空:True)
 objCurrEduCls4SynchEN.IdCourseType = objRow[conCurrEduCls4Synch.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.ExportDate = objRow[conCurrEduCls4Synch.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期(字段类型:varchar,字段长度:8,是否可空:True)
 objCurrEduCls4SynchEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsDegree].ToString().Trim()); //是否学位课(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls4SynchEN.IdScoreType = objRow[conCurrEduCls4Synch.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.GetScoreWayId = objRow[conCurrEduCls4Synch.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduCls4SynchEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()); //是否比例控制(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()); //是否同步Web(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.SynchToWebDate = objRow[conCurrEduCls4Synch.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduCls4SynchEN.SynchToWebUser = objRow[conCurrEduCls4Synch.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduCls4SynchEN.SignInDate = objRow[conCurrEduCls4Synch.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduCls4SynchEN.SignInStateID = objRow[conCurrEduCls4Synch.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduCls4SynchEN.SignInUser = objRow[conCurrEduCls4Synch.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduCls4SynchEN.IdExamType = objRow[conCurrEduCls4Synch.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls4SynchEN.ExamPortion = objRow[conCurrEduCls4Synch.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim()); //平时成绩所占比例(字段类型:smallint,字段长度:2,是否可空:False)
 objCurrEduCls4SynchEN.MidExamScorePortion = objRow[conCurrEduCls4Synch.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例(字段类型:smallint,字段长度:2,是否可空:True)
 objCurrEduCls4SynchEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim()); //是否重录成绩(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()); //是否生成口令(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.GeneratePwdDate = objRow[conCurrEduCls4Synch.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduCls4SynchEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim()); //是否导出到平台(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()); //是否保留小数(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls4SynchEN.ExamTime = objRow[conCurrEduCls4Synch.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间(字段类型:varchar,字段长度:8,是否可空:True)
 objCurrEduCls4SynchEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.CheckState].ToString().Trim()); //检查状态(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls4SynchEN.CheckDate = objRow[conCurrEduCls4Synch.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期(字段类型:varchar,字段长度:20,是否可空:False)
 objCurrEduCls4SynchEN.IdEduClassInPk = objRow[conCurrEduCls4Synch.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk(字段类型:char,字段长度:8,是否可空:True)
 objCurrEduCls4SynchEN.PkWeekTime = objRow[conCurrEduCls4Synch.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间(字段类型:varchar,字段长度:2000,是否可空:True)
 objCurrEduCls4SynchEN.PkClassRooms = objRow[conCurrEduCls4Synch.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室(字段类型:varchar,字段长度:150,是否可空:True)
 objCurrEduCls4SynchEN.BeginWeek = objRow[conCurrEduCls4Synch.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim()); //开始周(字段类型:smallint,字段长度:2,是否可空:True)
 objCurrEduCls4SynchEN.TeacherNames = objRow[conCurrEduCls4Synch.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:100,是否可空:True)
 objCurrEduCls4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.AccessSynchDate = objRow[conCurrEduCls4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期(字段类型:varchar,字段长度:14,是否可空:True)
 objCurrEduCls4SynchEN.IsExistEduClsInCurr = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()); //当前是否存在教学班(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls4SynchEN.ModifyDate = objRow[conCurrEduCls4Synch.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduCls4SynchEN.ModifyUserId = objRow[conCurrEduCls4Synch.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduCls4SynchEN.Memo = objRow[conCurrEduCls4Synch.Memo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCurrEduCls4SynchDA: GetObjBymId)", objException.Message));
}
return objCurrEduCls4SynchEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCurrEduCls4SynchEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCurrEduCls4SynchDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls4Synch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN()
{
mId = TransNullToInt(objRow[conCurrEduCls4Synch.mId].ToString().Trim()), //mId
IpAddress = objRow[conCurrEduCls4Synch.IpAddress] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(), //Ip地址
IdCurrEduCls = objRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(), //教学班流水号
CurrEduClsId = objRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(), //教学班Id
EduClsName = objRow[conCurrEduCls4Synch.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(), //教学班名
EduClsTypeId = objRow[conCurrEduCls4Synch.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(), //教学班类型Id
CourseId = objRow[conCurrEduCls4Synch.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CourseId].ToString().Trim(), //课程Id
TeachingSolutionId = objRow[conCurrEduCls4Synch.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(), //教学方案Id
IdXzCollege = objRow[conCurrEduCls4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(), //学院流水号
IdEduWay = objRow[conCurrEduCls4Synch.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(), //教学方式流水号
IdClassRoomType = objRow[conCurrEduCls4Synch.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(), //教室类型流水号
TotalLessonQty = objRow[conCurrEduCls4Synch.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()), //总课时数
MaxStuQty = objRow[conCurrEduCls4Synch.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim()), //最大学生数
CurrentStuQty = objRow[conCurrEduCls4Synch.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()), //当前学生数
WeekQty = objRow[conCurrEduCls4Synch.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.WeekQty].ToString().Trim()), //总周数
ScheUnitPW = objRow[conCurrEduCls4Synch.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()), //周排课次数
WeekStatusId = objRow[conCurrEduCls4Synch.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(), //周状态编号(单,双,全周)
CustomerWeek = objRow[conCurrEduCls4Synch.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(), //自定义上课周
IsCompleteScore = TransNullToBool(objRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()), //是否成绩齐全
IdExecPlan = objRow[conCurrEduCls4Synch.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(), //执行计划流水号
LessonQtyPerWeek = objRow[conCurrEduCls4Synch.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()), //周课时数
Mark = objRow[conCurrEduCls4Synch.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduCls4Synch.Mark].ToString().Trim()), //获得学分
CheckClassRoom = objRow[conCurrEduCls4Synch.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(), //检查教室结果
CheckAdminCls = objRow[conCurrEduCls4Synch.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(), //检查行政班结果
CheckTeacher = objRow[conCurrEduCls4Synch.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(), //检查教师结果
EditLocked = TransNullToBool(objRow[conCurrEduCls4Synch.EditLocked].ToString().Trim()), //编辑锁定
Sched = TransNullToBool(objRow[conCurrEduCls4Synch.Sched].ToString().Trim()), //是否排课
IdUniZone = objRow[conCurrEduCls4Synch.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(), //校区流水号
Locked = TransNullToBool(objRow[conCurrEduCls4Synch.Locked].ToString().Trim()), //锁定状态
IdGradeBase = objRow[conCurrEduCls4Synch.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(), //年级流水号
IsEffective = TransNullToBool(objRow[conCurrEduCls4Synch.IsEffective].ToString().Trim()), //是否有效
IsUnDeterminedClsRm = TransNullToBool(objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()), //是否待定教室
SchoolYear = objRow[conCurrEduCls4Synch.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(), //学年
SchoolTerm = objRow[conCurrEduCls4Synch.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(), //学期
ArrangeCourseMemo = objRow[conCurrEduCls4Synch.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(), //排课备注
IdCourseType = objRow[conCurrEduCls4Synch.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(), //课程类型流水号
ExportDate = objRow[conCurrEduCls4Synch.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(), //导出日期
IsDegree = TransNullToBool(objRow[conCurrEduCls4Synch.IsDegree].ToString().Trim()), //是否学位课
IdScoreType = objRow[conCurrEduCls4Synch.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(), //成绩类型流水号
GetScoreWayId = objRow[conCurrEduCls4Synch.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(), //获得成绩方式Id
IsProportionalCtrl = TransNullToBool(objRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()), //是否比例控制
IsSynchToWeb = TransNullToBool(objRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()), //是否同步Web
SynchToWebDate = objRow[conCurrEduCls4Synch.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(), //同步Web日期
SynchToWebUser = objRow[conCurrEduCls4Synch.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(), //同步Web用户
SignInDate = objRow[conCurrEduCls4Synch.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(), //签入时间
SignInStateID = objRow[conCurrEduCls4Synch.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(), //签入状态表流水号
SignInUser = objRow[conCurrEduCls4Synch.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(), //签入人
IdExamType = objRow[conCurrEduCls4Synch.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(), //考试方式流水号
ExamPortion = objRow[conCurrEduCls4Synch.ExamPortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim()), //平时成绩所占比例
MidExamScorePortion = objRow[conCurrEduCls4Synch.MidExamScorePortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()), //期末成绩所占比例
IsClearScore = TransNullToBool(objRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim()), //是否重录成绩
IsGeneratePwd = TransNullToBool(objRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()), //是否生成口令
GeneratePwdDate = objRow[conCurrEduCls4Synch.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(), //生成口令时间
IsExportToGP = TransNullToBool(objRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim()), //是否导出到平台
IsExportToGPWeb = TransNullToBool(objRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()), //是否导出到Web平台
IsReservedDecimal = TransNullToBool(objRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()), //是否保留小数
ExamTime = objRow[conCurrEduCls4Synch.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(), //考试时间
CheckState = TransNullToBool(objRow[conCurrEduCls4Synch.CheckState].ToString().Trim()), //检查状态
CheckDate = objRow[conCurrEduCls4Synch.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(), //检查日期
IdEduClassInPk = objRow[conCurrEduCls4Synch.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(), //id_EduClassInPk
PkWeekTime = objRow[conCurrEduCls4Synch.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(), //排课时间
PkClassRooms = objRow[conCurrEduCls4Synch.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(), //排课教室
BeginWeek = objRow[conCurrEduCls4Synch.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim()), //开始周
TeacherNames = objRow[conCurrEduCls4Synch.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(), //教师姓名
IsAccessSynch = TransNullToBool(objRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()), //是否处理同步
AccessSynchDate = objRow[conCurrEduCls4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(), //处理同步日期
IsExistEduClsInCurr = TransNullToBool(objRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()), //当前是否存在教学班
ModifyDate = objRow[conCurrEduCls4Synch.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(), //修改日期
ModifyUserId = objRow[conCurrEduCls4Synch.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(), //修改人
Memo = objRow[conCurrEduCls4Synch.Memo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.Memo].ToString().Trim() //备注
};
objCurrEduCls4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduCls4SynchEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCurrEduCls4SynchDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCurrEduCls4SynchEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN();
try
{
objCurrEduCls4SynchEN.mId = TransNullToInt(objRow[conCurrEduCls4Synch.mId].ToString().Trim()); //mId
objCurrEduCls4SynchEN.IpAddress = objRow[conCurrEduCls4Synch.IpAddress] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址
objCurrEduCls4SynchEN.IdCurrEduCls = objRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls4SynchEN.CurrEduClsId = objRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls4SynchEN.EduClsName = objRow[conCurrEduCls4Synch.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls4SynchEN.EduClsTypeId = objRow[conCurrEduCls4Synch.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls4SynchEN.CourseId = objRow[conCurrEduCls4Synch.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id
objCurrEduCls4SynchEN.TeachingSolutionId = objRow[conCurrEduCls4Synch.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls4SynchEN.IdXzCollege = objRow[conCurrEduCls4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls4SynchEN.IdEduWay = objRow[conCurrEduCls4Synch.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls4SynchEN.IdClassRoomType = objRow[conCurrEduCls4Synch.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls4SynchEN.TotalLessonQty = objRow[conCurrEduCls4Synch.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls4SynchEN.MaxStuQty = objRow[conCurrEduCls4Synch.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls4SynchEN.CurrentStuQty = objRow[conCurrEduCls4Synch.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls4SynchEN.WeekQty = objRow[conCurrEduCls4Synch.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.WeekQty].ToString().Trim()); //总周数
objCurrEduCls4SynchEN.ScheUnitPW = objRow[conCurrEduCls4Synch.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls4SynchEN.WeekStatusId = objRow[conCurrEduCls4Synch.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls4SynchEN.CustomerWeek = objRow[conCurrEduCls4Synch.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls4SynchEN.IsCompleteScore = TransNullToBool(objRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls4SynchEN.IdExecPlan = objRow[conCurrEduCls4Synch.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls4SynchEN.LessonQtyPerWeek = objRow[conCurrEduCls4Synch.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls4SynchEN.Mark = objRow[conCurrEduCls4Synch.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduCls4Synch.Mark].ToString().Trim()); //获得学分
objCurrEduCls4SynchEN.CheckClassRoom = objRow[conCurrEduCls4Synch.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls4SynchEN.CheckAdminCls = objRow[conCurrEduCls4Synch.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls4SynchEN.CheckTeacher = objRow[conCurrEduCls4Synch.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls4SynchEN.EditLocked = TransNullToBool(objRow[conCurrEduCls4Synch.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls4SynchEN.Sched = TransNullToBool(objRow[conCurrEduCls4Synch.Sched].ToString().Trim()); //是否排课
objCurrEduCls4SynchEN.IdUniZone = objRow[conCurrEduCls4Synch.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls4SynchEN.Locked = TransNullToBool(objRow[conCurrEduCls4Synch.Locked].ToString().Trim()); //锁定状态
objCurrEduCls4SynchEN.IdGradeBase = objRow[conCurrEduCls4Synch.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls4SynchEN.IsEffective = TransNullToBool(objRow[conCurrEduCls4Synch.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls4SynchEN.IsUnDeterminedClsRm = TransNullToBool(objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls4SynchEN.SchoolYear = objRow[conCurrEduCls4Synch.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年
objCurrEduCls4SynchEN.SchoolTerm = objRow[conCurrEduCls4Synch.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls4SynchEN.ArrangeCourseMemo = objRow[conCurrEduCls4Synch.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls4SynchEN.IdCourseType = objRow[conCurrEduCls4Synch.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls4SynchEN.ExportDate = objRow[conCurrEduCls4Synch.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls4SynchEN.IsDegree = TransNullToBool(objRow[conCurrEduCls4Synch.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls4SynchEN.IdScoreType = objRow[conCurrEduCls4Synch.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls4SynchEN.GetScoreWayId = objRow[conCurrEduCls4Synch.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls4SynchEN.IsProportionalCtrl = TransNullToBool(objRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls4SynchEN.IsSynchToWeb = TransNullToBool(objRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls4SynchEN.SynchToWebDate = objRow[conCurrEduCls4Synch.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期
objCurrEduCls4SynchEN.SynchToWebUser = objRow[conCurrEduCls4Synch.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls4SynchEN.SignInDate = objRow[conCurrEduCls4Synch.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls4SynchEN.SignInStateID = objRow[conCurrEduCls4Synch.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls4SynchEN.SignInUser = objRow[conCurrEduCls4Synch.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人
objCurrEduCls4SynchEN.IdExamType = objRow[conCurrEduCls4Synch.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls4SynchEN.ExamPortion = objRow[conCurrEduCls4Synch.ExamPortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls4SynchEN.MidExamScorePortion = objRow[conCurrEduCls4Synch.MidExamScorePortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls4SynchEN.IsClearScore = TransNullToBool(objRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls4SynchEN.IsGeneratePwd = TransNullToBool(objRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls4SynchEN.GeneratePwdDate = objRow[conCurrEduCls4Synch.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls4SynchEN.IsExportToGP = TransNullToBool(objRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls4SynchEN.IsExportToGPWeb = TransNullToBool(objRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls4SynchEN.IsReservedDecimal = TransNullToBool(objRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls4SynchEN.ExamTime = objRow[conCurrEduCls4Synch.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls4SynchEN.CheckState = TransNullToBool(objRow[conCurrEduCls4Synch.CheckState].ToString().Trim()); //检查状态
objCurrEduCls4SynchEN.CheckDate = objRow[conCurrEduCls4Synch.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls4SynchEN.IdEduClassInPk = objRow[conCurrEduCls4Synch.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls4SynchEN.PkWeekTime = objRow[conCurrEduCls4Synch.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls4SynchEN.PkClassRooms = objRow[conCurrEduCls4Synch.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls4SynchEN.BeginWeek = objRow[conCurrEduCls4Synch.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls4SynchEN.TeacherNames = objRow[conCurrEduCls4Synch.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls4SynchEN.IsAccessSynch = TransNullToBool(objRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objCurrEduCls4SynchEN.AccessSynchDate = objRow[conCurrEduCls4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objCurrEduCls4SynchEN.IsExistEduClsInCurr = TransNullToBool(objRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()); //当前是否存在教学班
objCurrEduCls4SynchEN.ModifyDate = objRow[conCurrEduCls4Synch.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls4SynchEN.ModifyUserId = objRow[conCurrEduCls4Synch.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls4SynchEN.Memo = objRow[conCurrEduCls4Synch.Memo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCurrEduCls4SynchDA: GetObjByDataRowCurrEduCls4Synch)", objException.Message));
}
objCurrEduCls4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduCls4SynchEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCurrEduCls4SynchEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN();
try
{
objCurrEduCls4SynchEN.mId = TransNullToInt(objRow[conCurrEduCls4Synch.mId].ToString().Trim()); //mId
objCurrEduCls4SynchEN.IpAddress = objRow[conCurrEduCls4Synch.IpAddress] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址
objCurrEduCls4SynchEN.IdCurrEduCls = objRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls4SynchEN.CurrEduClsId = objRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls4SynchEN.EduClsName = objRow[conCurrEduCls4Synch.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls4SynchEN.EduClsTypeId = objRow[conCurrEduCls4Synch.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls4SynchEN.CourseId = objRow[conCurrEduCls4Synch.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id
objCurrEduCls4SynchEN.TeachingSolutionId = objRow[conCurrEduCls4Synch.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls4SynchEN.IdXzCollege = objRow[conCurrEduCls4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls4SynchEN.IdEduWay = objRow[conCurrEduCls4Synch.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls4SynchEN.IdClassRoomType = objRow[conCurrEduCls4Synch.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls4SynchEN.TotalLessonQty = objRow[conCurrEduCls4Synch.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls4SynchEN.MaxStuQty = objRow[conCurrEduCls4Synch.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls4SynchEN.CurrentStuQty = objRow[conCurrEduCls4Synch.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls4SynchEN.WeekQty = objRow[conCurrEduCls4Synch.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls4Synch.WeekQty].ToString().Trim()); //总周数
objCurrEduCls4SynchEN.ScheUnitPW = objRow[conCurrEduCls4Synch.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls4SynchEN.WeekStatusId = objRow[conCurrEduCls4Synch.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls4SynchEN.CustomerWeek = objRow[conCurrEduCls4Synch.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls4SynchEN.IsCompleteScore = TransNullToBool(objRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls4SynchEN.IdExecPlan = objRow[conCurrEduCls4Synch.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls4SynchEN.LessonQtyPerWeek = objRow[conCurrEduCls4Synch.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls4SynchEN.Mark = objRow[conCurrEduCls4Synch.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduCls4Synch.Mark].ToString().Trim()); //获得学分
objCurrEduCls4SynchEN.CheckClassRoom = objRow[conCurrEduCls4Synch.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls4SynchEN.CheckAdminCls = objRow[conCurrEduCls4Synch.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls4SynchEN.CheckTeacher = objRow[conCurrEduCls4Synch.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls4SynchEN.EditLocked = TransNullToBool(objRow[conCurrEduCls4Synch.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls4SynchEN.Sched = TransNullToBool(objRow[conCurrEduCls4Synch.Sched].ToString().Trim()); //是否排课
objCurrEduCls4SynchEN.IdUniZone = objRow[conCurrEduCls4Synch.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls4SynchEN.Locked = TransNullToBool(objRow[conCurrEduCls4Synch.Locked].ToString().Trim()); //锁定状态
objCurrEduCls4SynchEN.IdGradeBase = objRow[conCurrEduCls4Synch.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls4SynchEN.IsEffective = TransNullToBool(objRow[conCurrEduCls4Synch.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls4SynchEN.IsUnDeterminedClsRm = TransNullToBool(objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls4SynchEN.SchoolYear = objRow[conCurrEduCls4Synch.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年
objCurrEduCls4SynchEN.SchoolTerm = objRow[conCurrEduCls4Synch.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls4SynchEN.ArrangeCourseMemo = objRow[conCurrEduCls4Synch.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls4SynchEN.IdCourseType = objRow[conCurrEduCls4Synch.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls4SynchEN.ExportDate = objRow[conCurrEduCls4Synch.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls4SynchEN.IsDegree = TransNullToBool(objRow[conCurrEduCls4Synch.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls4SynchEN.IdScoreType = objRow[conCurrEduCls4Synch.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls4SynchEN.GetScoreWayId = objRow[conCurrEduCls4Synch.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls4SynchEN.IsProportionalCtrl = TransNullToBool(objRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls4SynchEN.IsSynchToWeb = TransNullToBool(objRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls4SynchEN.SynchToWebDate = objRow[conCurrEduCls4Synch.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期
objCurrEduCls4SynchEN.SynchToWebUser = objRow[conCurrEduCls4Synch.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls4SynchEN.SignInDate = objRow[conCurrEduCls4Synch.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls4SynchEN.SignInStateID = objRow[conCurrEduCls4Synch.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls4SynchEN.SignInUser = objRow[conCurrEduCls4Synch.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人
objCurrEduCls4SynchEN.IdExamType = objRow[conCurrEduCls4Synch.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls4SynchEN.ExamPortion = objRow[conCurrEduCls4Synch.ExamPortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls4SynchEN.MidExamScorePortion = objRow[conCurrEduCls4Synch.MidExamScorePortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls4SynchEN.IsClearScore = TransNullToBool(objRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls4SynchEN.IsGeneratePwd = TransNullToBool(objRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls4SynchEN.GeneratePwdDate = objRow[conCurrEduCls4Synch.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls4SynchEN.IsExportToGP = TransNullToBool(objRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls4SynchEN.IsExportToGPWeb = TransNullToBool(objRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls4SynchEN.IsReservedDecimal = TransNullToBool(objRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls4SynchEN.ExamTime = objRow[conCurrEduCls4Synch.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls4SynchEN.CheckState = TransNullToBool(objRow[conCurrEduCls4Synch.CheckState].ToString().Trim()); //检查状态
objCurrEduCls4SynchEN.CheckDate = objRow[conCurrEduCls4Synch.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls4SynchEN.IdEduClassInPk = objRow[conCurrEduCls4Synch.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls4SynchEN.PkWeekTime = objRow[conCurrEduCls4Synch.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls4SynchEN.PkClassRooms = objRow[conCurrEduCls4Synch.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls4SynchEN.BeginWeek = objRow[conCurrEduCls4Synch.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls4SynchEN.TeacherNames = objRow[conCurrEduCls4Synch.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls4SynchEN.IsAccessSynch = TransNullToBool(objRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objCurrEduCls4SynchEN.AccessSynchDate = objRow[conCurrEduCls4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objCurrEduCls4SynchEN.IsExistEduClsInCurr = TransNullToBool(objRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()); //当前是否存在教学班
objCurrEduCls4SynchEN.ModifyDate = objRow[conCurrEduCls4Synch.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls4SynchEN.ModifyUserId = objRow[conCurrEduCls4Synch.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls4SynchEN.Memo = objRow[conCurrEduCls4Synch.Memo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCurrEduCls4SynchDA: GetObjByDataRow)", objException.Message));
}
objCurrEduCls4SynchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduCls4SynchEN;
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
objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCurrEduCls4SynchEN._CurrTabName, conCurrEduCls4Synch.mId, 8, "");
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
objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCurrEduCls4SynchEN._CurrTabName, conCurrEduCls4Synch.mId, 8, strPrefix);
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
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from CurrEduCls4Synch where " + strCondition;
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
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from CurrEduCls4Synch where " + strCondition;
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
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CurrEduCls4Synch", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCurrEduCls4SynchDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CurrEduCls4Synch", strCondition))
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
objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CurrEduCls4Synch");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
 {
 if (objCurrEduCls4SynchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduCls4SynchEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls4Synch where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CurrEduCls4Synch");
objRow = objDS.Tables["CurrEduCls4Synch"].NewRow();
 if (objCurrEduCls4SynchEN.IpAddress !=  "")
 {
objRow[conCurrEduCls4Synch.IpAddress] = objCurrEduCls4SynchEN.IpAddress; //Ip地址
 }
objRow[conCurrEduCls4Synch.IdCurrEduCls] = objCurrEduCls4SynchEN.IdCurrEduCls; //教学班流水号
objRow[conCurrEduCls4Synch.CurrEduClsId] = objCurrEduCls4SynchEN.CurrEduClsId; //教学班Id
 if (objCurrEduCls4SynchEN.EduClsName !=  "")
 {
objRow[conCurrEduCls4Synch.EduClsName] = objCurrEduCls4SynchEN.EduClsName; //教学班名
 }
 if (objCurrEduCls4SynchEN.EduClsTypeId !=  "")
 {
objRow[conCurrEduCls4Synch.EduClsTypeId] = objCurrEduCls4SynchEN.EduClsTypeId; //教学班类型Id
 }
 if (objCurrEduCls4SynchEN.CourseId !=  "")
 {
objRow[conCurrEduCls4Synch.CourseId] = objCurrEduCls4SynchEN.CourseId; //课程Id
 }
 if (objCurrEduCls4SynchEN.TeachingSolutionId !=  "")
 {
objRow[conCurrEduCls4Synch.TeachingSolutionId] = objCurrEduCls4SynchEN.TeachingSolutionId; //教学方案Id
 }
 if (objCurrEduCls4SynchEN.IdXzCollege !=  "")
 {
objRow[conCurrEduCls4Synch.IdXzCollege] = objCurrEduCls4SynchEN.IdXzCollege; //学院流水号
 }
 if (objCurrEduCls4SynchEN.IdEduWay !=  "")
 {
objRow[conCurrEduCls4Synch.IdEduWay] = objCurrEduCls4SynchEN.IdEduWay; //教学方式流水号
 }
 if (objCurrEduCls4SynchEN.IdClassRoomType !=  "")
 {
objRow[conCurrEduCls4Synch.IdClassRoomType] = objCurrEduCls4SynchEN.IdClassRoomType; //教室类型流水号
 }
objRow[conCurrEduCls4Synch.TotalLessonQty] = objCurrEduCls4SynchEN.TotalLessonQty; //总课时数
objRow[conCurrEduCls4Synch.MaxStuQty] = objCurrEduCls4SynchEN.MaxStuQty; //最大学生数
objRow[conCurrEduCls4Synch.CurrentStuQty] = objCurrEduCls4SynchEN.CurrentStuQty; //当前学生数
objRow[conCurrEduCls4Synch.WeekQty] = objCurrEduCls4SynchEN.WeekQty; //总周数
objRow[conCurrEduCls4Synch.ScheUnitPW] = objCurrEduCls4SynchEN.ScheUnitPW; //周排课次数
 if (objCurrEduCls4SynchEN.WeekStatusId !=  "")
 {
objRow[conCurrEduCls4Synch.WeekStatusId] = objCurrEduCls4SynchEN.WeekStatusId; //周状态编号(单,双,全周)
 }
 if (objCurrEduCls4SynchEN.CustomerWeek !=  "")
 {
objRow[conCurrEduCls4Synch.CustomerWeek] = objCurrEduCls4SynchEN.CustomerWeek; //自定义上课周
 }
objRow[conCurrEduCls4Synch.IsCompleteScore] = objCurrEduCls4SynchEN.IsCompleteScore; //是否成绩齐全
 if (objCurrEduCls4SynchEN.IdExecPlan !=  "")
 {
objRow[conCurrEduCls4Synch.IdExecPlan] = objCurrEduCls4SynchEN.IdExecPlan; //执行计划流水号
 }
objRow[conCurrEduCls4Synch.LessonQtyPerWeek] = objCurrEduCls4SynchEN.LessonQtyPerWeek; //周课时数
objRow[conCurrEduCls4Synch.Mark] = objCurrEduCls4SynchEN.Mark; //获得学分
 if (objCurrEduCls4SynchEN.CheckClassRoom !=  "")
 {
objRow[conCurrEduCls4Synch.CheckClassRoom] = objCurrEduCls4SynchEN.CheckClassRoom; //检查教室结果
 }
 if (objCurrEduCls4SynchEN.CheckAdminCls !=  "")
 {
objRow[conCurrEduCls4Synch.CheckAdminCls] = objCurrEduCls4SynchEN.CheckAdminCls; //检查行政班结果
 }
 if (objCurrEduCls4SynchEN.CheckTeacher !=  "")
 {
objRow[conCurrEduCls4Synch.CheckTeacher] = objCurrEduCls4SynchEN.CheckTeacher; //检查教师结果
 }
objRow[conCurrEduCls4Synch.EditLocked] = objCurrEduCls4SynchEN.EditLocked; //编辑锁定
objRow[conCurrEduCls4Synch.Sched] = objCurrEduCls4SynchEN.Sched; //是否排课
 if (objCurrEduCls4SynchEN.IdUniZone !=  "")
 {
objRow[conCurrEduCls4Synch.IdUniZone] = objCurrEduCls4SynchEN.IdUniZone; //校区流水号
 }
objRow[conCurrEduCls4Synch.Locked] = objCurrEduCls4SynchEN.Locked; //锁定状态
 if (objCurrEduCls4SynchEN.IdGradeBase !=  "")
 {
objRow[conCurrEduCls4Synch.IdGradeBase] = objCurrEduCls4SynchEN.IdGradeBase; //年级流水号
 }
objRow[conCurrEduCls4Synch.IsEffective] = objCurrEduCls4SynchEN.IsEffective; //是否有效
objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm] = objCurrEduCls4SynchEN.IsUnDeterminedClsRm; //是否待定教室
 if (objCurrEduCls4SynchEN.SchoolYear !=  "")
 {
objRow[conCurrEduCls4Synch.SchoolYear] = objCurrEduCls4SynchEN.SchoolYear; //学年
 }
 if (objCurrEduCls4SynchEN.SchoolTerm !=  "")
 {
objRow[conCurrEduCls4Synch.SchoolTerm] = objCurrEduCls4SynchEN.SchoolTerm; //学期
 }
 if (objCurrEduCls4SynchEN.ArrangeCourseMemo !=  "")
 {
objRow[conCurrEduCls4Synch.ArrangeCourseMemo] = objCurrEduCls4SynchEN.ArrangeCourseMemo; //排课备注
 }
 if (objCurrEduCls4SynchEN.IdCourseType !=  "")
 {
objRow[conCurrEduCls4Synch.IdCourseType] = objCurrEduCls4SynchEN.IdCourseType; //课程类型流水号
 }
 if (objCurrEduCls4SynchEN.ExportDate !=  "")
 {
objRow[conCurrEduCls4Synch.ExportDate] = objCurrEduCls4SynchEN.ExportDate; //导出日期
 }
objRow[conCurrEduCls4Synch.IsDegree] = objCurrEduCls4SynchEN.IsDegree; //是否学位课
 if (objCurrEduCls4SynchEN.IdScoreType !=  "")
 {
objRow[conCurrEduCls4Synch.IdScoreType] = objCurrEduCls4SynchEN.IdScoreType; //成绩类型流水号
 }
 if (objCurrEduCls4SynchEN.GetScoreWayId !=  "")
 {
objRow[conCurrEduCls4Synch.GetScoreWayId] = objCurrEduCls4SynchEN.GetScoreWayId; //获得成绩方式Id
 }
objRow[conCurrEduCls4Synch.IsProportionalCtrl] = objCurrEduCls4SynchEN.IsProportionalCtrl; //是否比例控制
objRow[conCurrEduCls4Synch.IsSynchToWeb] = objCurrEduCls4SynchEN.IsSynchToWeb; //是否同步Web
 if (objCurrEduCls4SynchEN.SynchToWebDate !=  "")
 {
objRow[conCurrEduCls4Synch.SynchToWebDate] = objCurrEduCls4SynchEN.SynchToWebDate; //同步Web日期
 }
 if (objCurrEduCls4SynchEN.SynchToWebUser !=  "")
 {
objRow[conCurrEduCls4Synch.SynchToWebUser] = objCurrEduCls4SynchEN.SynchToWebUser; //同步Web用户
 }
 if (objCurrEduCls4SynchEN.SignInDate !=  "")
 {
objRow[conCurrEduCls4Synch.SignInDate] = objCurrEduCls4SynchEN.SignInDate; //签入时间
 }
 if (objCurrEduCls4SynchEN.SignInStateID !=  "")
 {
objRow[conCurrEduCls4Synch.SignInStateID] = objCurrEduCls4SynchEN.SignInStateID; //签入状态表流水号
 }
 if (objCurrEduCls4SynchEN.SignInUser !=  "")
 {
objRow[conCurrEduCls4Synch.SignInUser] = objCurrEduCls4SynchEN.SignInUser; //签入人
 }
 if (objCurrEduCls4SynchEN.IdExamType !=  "")
 {
objRow[conCurrEduCls4Synch.IdExamType] = objCurrEduCls4SynchEN.IdExamType; //考试方式流水号
 }
objRow[conCurrEduCls4Synch.ExamPortion] = objCurrEduCls4SynchEN.ExamPortion; //平时成绩所占比例
objRow[conCurrEduCls4Synch.MidExamScorePortion] = objCurrEduCls4SynchEN.MidExamScorePortion; //期末成绩所占比例
objRow[conCurrEduCls4Synch.IsClearScore] = objCurrEduCls4SynchEN.IsClearScore; //是否重录成绩
objRow[conCurrEduCls4Synch.IsGeneratePwd] = objCurrEduCls4SynchEN.IsGeneratePwd; //是否生成口令
 if (objCurrEduCls4SynchEN.GeneratePwdDate !=  "")
 {
objRow[conCurrEduCls4Synch.GeneratePwdDate] = objCurrEduCls4SynchEN.GeneratePwdDate; //生成口令时间
 }
objRow[conCurrEduCls4Synch.IsExportToGP] = objCurrEduCls4SynchEN.IsExportToGP; //是否导出到平台
objRow[conCurrEduCls4Synch.IsExportToGPWeb] = objCurrEduCls4SynchEN.IsExportToGPWeb; //是否导出到Web平台
objRow[conCurrEduCls4Synch.IsReservedDecimal] = objCurrEduCls4SynchEN.IsReservedDecimal; //是否保留小数
 if (objCurrEduCls4SynchEN.ExamTime !=  "")
 {
objRow[conCurrEduCls4Synch.ExamTime] = objCurrEduCls4SynchEN.ExamTime; //考试时间
 }
objRow[conCurrEduCls4Synch.CheckState] = objCurrEduCls4SynchEN.CheckState; //检查状态
 if (objCurrEduCls4SynchEN.CheckDate !=  "")
 {
objRow[conCurrEduCls4Synch.CheckDate] = objCurrEduCls4SynchEN.CheckDate; //检查日期
 }
 if (objCurrEduCls4SynchEN.IdEduClassInPk !=  "")
 {
objRow[conCurrEduCls4Synch.IdEduClassInPk] = objCurrEduCls4SynchEN.IdEduClassInPk; //id_EduClassInPk
 }
 if (objCurrEduCls4SynchEN.PkWeekTime !=  "")
 {
objRow[conCurrEduCls4Synch.PkWeekTime] = objCurrEduCls4SynchEN.PkWeekTime; //排课时间
 }
 if (objCurrEduCls4SynchEN.PkClassRooms !=  "")
 {
objRow[conCurrEduCls4Synch.PkClassRooms] = objCurrEduCls4SynchEN.PkClassRooms; //排课教室
 }
objRow[conCurrEduCls4Synch.BeginWeek] = objCurrEduCls4SynchEN.BeginWeek; //开始周
 if (objCurrEduCls4SynchEN.TeacherNames !=  "")
 {
objRow[conCurrEduCls4Synch.TeacherNames] = objCurrEduCls4SynchEN.TeacherNames; //教师姓名
 }
objRow[conCurrEduCls4Synch.IsAccessSynch] = objCurrEduCls4SynchEN.IsAccessSynch; //是否处理同步
 if (objCurrEduCls4SynchEN.AccessSynchDate !=  "")
 {
objRow[conCurrEduCls4Synch.AccessSynchDate] = objCurrEduCls4SynchEN.AccessSynchDate; //处理同步日期
 }
objRow[conCurrEduCls4Synch.IsExistEduClsInCurr] = objCurrEduCls4SynchEN.IsExistEduClsInCurr; //当前是否存在教学班
 if (objCurrEduCls4SynchEN.ModifyDate !=  "")
 {
objRow[conCurrEduCls4Synch.ModifyDate] = objCurrEduCls4SynchEN.ModifyDate; //修改日期
 }
 if (objCurrEduCls4SynchEN.ModifyUserId !=  "")
 {
objRow[conCurrEduCls4Synch.ModifyUserId] = objCurrEduCls4SynchEN.ModifyUserId; //修改人
 }
 if (objCurrEduCls4SynchEN.Memo !=  "")
 {
objRow[conCurrEduCls4Synch.Memo] = objCurrEduCls4SynchEN.Memo; //备注
 }
objDS.Tables[clsCurrEduCls4SynchEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCurrEduCls4SynchEN._CurrTabName);
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
 /// <param name = "objCurrEduCls4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
 if (objCurrEduCls4SynchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduCls4SynchEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCurrEduCls4SynchEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IpAddress);
 var strIpAddress = objCurrEduCls4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduCls4SynchEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduCls4SynchEN.CurrEduClsId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CurrEduClsId);
 var strCurrEduClsId = objCurrEduCls4SynchEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCurrEduClsId + "'");
 }
 
 if (objCurrEduCls4SynchEN.EduClsName !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.EduClsName);
 var strEduClsName = objCurrEduCls4SynchEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsName + "'");
 }
 
 if (objCurrEduCls4SynchEN.EduClsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.EduClsTypeId);
 var strEduClsTypeId = objCurrEduCls4SynchEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsTypeId + "'");
 }
 
 if (objCurrEduCls4SynchEN.CourseId  ==  "")
 {
 objCurrEduCls4SynchEN.CourseId = null;
 }
 if (objCurrEduCls4SynchEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CourseId);
 var strCourseId = objCurrEduCls4SynchEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCurrEduCls4SynchEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.TeachingSolutionId);
 var strTeachingSolutionId = objCurrEduCls4SynchEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdXzCollege);
 var strIdXzCollege = objCurrEduCls4SynchEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdEduWay  ==  "")
 {
 objCurrEduCls4SynchEN.IdEduWay = null;
 }
 if (objCurrEduCls4SynchEN.IdEduWay !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdEduWay);
 var strIdEduWay = objCurrEduCls4SynchEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduWay + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdClassRoomType  ==  "")
 {
 objCurrEduCls4SynchEN.IdClassRoomType = null;
 }
 if (objCurrEduCls4SynchEN.IdClassRoomType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdClassRoomType);
 var strIdClassRoomType = objCurrEduCls4SynchEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClassRoomType + "'");
 }
 
 if (objCurrEduCls4SynchEN.TotalLessonQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.TotalLessonQty);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.TotalLessonQty.ToString());
 }
 
 if (objCurrEduCls4SynchEN.MaxStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.MaxStuQty);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.MaxStuQty.ToString());
 }
 
 if (objCurrEduCls4SynchEN.CurrentStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CurrentStuQty);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.CurrentStuQty.ToString());
 }
 
 if (objCurrEduCls4SynchEN.WeekQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.WeekQty);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.WeekQty.ToString());
 }
 
 if (objCurrEduCls4SynchEN.ScheUnitPW !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ScheUnitPW);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.ScheUnitPW.ToString());
 }
 
 if (objCurrEduCls4SynchEN.WeekStatusId  ==  "")
 {
 objCurrEduCls4SynchEN.WeekStatusId = null;
 }
 if (objCurrEduCls4SynchEN.WeekStatusId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.WeekStatusId);
 var strWeekStatusId = objCurrEduCls4SynchEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekStatusId + "'");
 }
 
 if (objCurrEduCls4SynchEN.CustomerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CustomerWeek);
 var strCustomerWeek = objCurrEduCls4SynchEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCustomerWeek + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsCompleteScore);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsCompleteScore  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.IdExecPlan !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdExecPlan);
 var strIdExecPlan = objCurrEduCls4SynchEN.IdExecPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExecPlan + "'");
 }
 
 if (objCurrEduCls4SynchEN.LessonQtyPerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.LessonQtyPerWeek);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.LessonQtyPerWeek.ToString());
 }
 
 if (objCurrEduCls4SynchEN.Mark !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.Mark);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.Mark.ToString());
 }
 
 if (objCurrEduCls4SynchEN.CheckClassRoom !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckClassRoom);
 var strCheckClassRoom = objCurrEduCls4SynchEN.CheckClassRoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckClassRoom + "'");
 }
 
 if (objCurrEduCls4SynchEN.CheckAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckAdminCls);
 var strCheckAdminCls = objCurrEduCls4SynchEN.CheckAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckAdminCls + "'");
 }
 
 if (objCurrEduCls4SynchEN.CheckTeacher !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckTeacher);
 var strCheckTeacher = objCurrEduCls4SynchEN.CheckTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckTeacher + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.EditLocked);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.EditLocked  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.Sched);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.Sched  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.IdUniZone  ==  "")
 {
 objCurrEduCls4SynchEN.IdUniZone = null;
 }
 if (objCurrEduCls4SynchEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdUniZone);
 var strIdUniZone = objCurrEduCls4SynchEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.Locked);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.Locked  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.IdGradeBase  ==  "")
 {
 objCurrEduCls4SynchEN.IdGradeBase = null;
 }
 if (objCurrEduCls4SynchEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdGradeBase);
 var strIdGradeBase = objCurrEduCls4SynchEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsEffective);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsUnDeterminedClsRm);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsUnDeterminedClsRm  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SchoolYear);
 var strSchoolYear = objCurrEduCls4SynchEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduCls4SynchEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SchoolTerm);
 var strSchoolTerm = objCurrEduCls4SynchEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduCls4SynchEN.ArrangeCourseMemo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ArrangeCourseMemo);
 var strArrangeCourseMemo = objCurrEduCls4SynchEN.ArrangeCourseMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strArrangeCourseMemo + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdCourseType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdCourseType);
 var strIdCourseType = objCurrEduCls4SynchEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseType + "'");
 }
 
 if (objCurrEduCls4SynchEN.ExportDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ExportDate);
 var strExportDate = objCurrEduCls4SynchEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExportDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsDegree);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsDegree  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.IdScoreType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdScoreType);
 var strIdScoreType = objCurrEduCls4SynchEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdScoreType + "'");
 }
 
 if (objCurrEduCls4SynchEN.GetScoreWayId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.GetScoreWayId);
 var strGetScoreWayId = objCurrEduCls4SynchEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetScoreWayId + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsProportionalCtrl);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsProportionalCtrl  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsSynchToWeb);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsSynchToWeb  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.SynchToWebDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SynchToWebDate);
 var strSynchToWebDate = objCurrEduCls4SynchEN.SynchToWebDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToWebDate + "'");
 }
 
 if (objCurrEduCls4SynchEN.SynchToWebUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SynchToWebUser);
 var strSynchToWebUser = objCurrEduCls4SynchEN.SynchToWebUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToWebUser + "'");
 }
 
 if (objCurrEduCls4SynchEN.SignInDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SignInDate);
 var strSignInDate = objCurrEduCls4SynchEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInDate + "'");
 }
 
 if (objCurrEduCls4SynchEN.SignInStateID !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SignInStateID);
 var strSignInStateID = objCurrEduCls4SynchEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInStateID + "'");
 }
 
 if (objCurrEduCls4SynchEN.SignInUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SignInUser);
 var strSignInUser = objCurrEduCls4SynchEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInUser + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdExamType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdExamType);
 var strIdExamType = objCurrEduCls4SynchEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExamType + "'");
 }
 
 if (objCurrEduCls4SynchEN.ExamPortion !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ExamPortion);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.ExamPortion.ToString());
 }
 
 if (objCurrEduCls4SynchEN.MidExamScorePortion !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.MidExamScorePortion);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.MidExamScorePortion.ToString());
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsClearScore);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsClearScore  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsGeneratePwd);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsGeneratePwd  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.GeneratePwdDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.GeneratePwdDate);
 var strGeneratePwdDate = objCurrEduCls4SynchEN.GeneratePwdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneratePwdDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsExportToGP);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsExportToGP  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsExportToGPWeb);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsExportToGPWeb  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsReservedDecimal);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsReservedDecimal  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.ExamTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ExamTime);
 var strExamTime = objCurrEduCls4SynchEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamTime + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckState);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.CheckState  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.CheckDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckDate);
 var strCheckDate = objCurrEduCls4SynchEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDate + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdEduClassInPk !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdEduClassInPk);
 var strIdEduClassInPk = objCurrEduCls4SynchEN.IdEduClassInPk.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduClassInPk + "'");
 }
 
 if (objCurrEduCls4SynchEN.PkWeekTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.PkWeekTime);
 var strPkWeekTime = objCurrEduCls4SynchEN.PkWeekTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPkWeekTime + "'");
 }
 
 if (objCurrEduCls4SynchEN.PkClassRooms !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.PkClassRooms);
 var strPkClassRooms = objCurrEduCls4SynchEN.PkClassRooms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPkClassRooms + "'");
 }
 
 if (objCurrEduCls4SynchEN.BeginWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.BeginWeek);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.BeginWeek.ToString());
 }
 
 if (objCurrEduCls4SynchEN.TeacherNames !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.TeacherNames);
 var strTeacherNames = objCurrEduCls4SynchEN.TeacherNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherNames + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsAccessSynch);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsAccessSynch  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.AccessSynchDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.AccessSynchDate);
 var strAccessSynchDate = objCurrEduCls4SynchEN.AccessSynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAccessSynchDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsExistEduClsInCurr);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsExistEduClsInCurr  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ModifyDate);
 var strModifyDate = objCurrEduCls4SynchEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduCls4SynchEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ModifyUserId);
 var strModifyUserId = objCurrEduCls4SynchEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objCurrEduCls4SynchEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.Memo);
 var strMemo = objCurrEduCls4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduCls4Synch");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
 if (objCurrEduCls4SynchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduCls4SynchEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCurrEduCls4SynchEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IpAddress);
 var strIpAddress = objCurrEduCls4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduCls4SynchEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduCls4SynchEN.CurrEduClsId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CurrEduClsId);
 var strCurrEduClsId = objCurrEduCls4SynchEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCurrEduClsId + "'");
 }
 
 if (objCurrEduCls4SynchEN.EduClsName !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.EduClsName);
 var strEduClsName = objCurrEduCls4SynchEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsName + "'");
 }
 
 if (objCurrEduCls4SynchEN.EduClsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.EduClsTypeId);
 var strEduClsTypeId = objCurrEduCls4SynchEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsTypeId + "'");
 }
 
 if (objCurrEduCls4SynchEN.CourseId  ==  "")
 {
 objCurrEduCls4SynchEN.CourseId = null;
 }
 if (objCurrEduCls4SynchEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CourseId);
 var strCourseId = objCurrEduCls4SynchEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCurrEduCls4SynchEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.TeachingSolutionId);
 var strTeachingSolutionId = objCurrEduCls4SynchEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdXzCollege);
 var strIdXzCollege = objCurrEduCls4SynchEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdEduWay  ==  "")
 {
 objCurrEduCls4SynchEN.IdEduWay = null;
 }
 if (objCurrEduCls4SynchEN.IdEduWay !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdEduWay);
 var strIdEduWay = objCurrEduCls4SynchEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduWay + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdClassRoomType  ==  "")
 {
 objCurrEduCls4SynchEN.IdClassRoomType = null;
 }
 if (objCurrEduCls4SynchEN.IdClassRoomType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdClassRoomType);
 var strIdClassRoomType = objCurrEduCls4SynchEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClassRoomType + "'");
 }
 
 if (objCurrEduCls4SynchEN.TotalLessonQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.TotalLessonQty);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.TotalLessonQty.ToString());
 }
 
 if (objCurrEduCls4SynchEN.MaxStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.MaxStuQty);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.MaxStuQty.ToString());
 }
 
 if (objCurrEduCls4SynchEN.CurrentStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CurrentStuQty);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.CurrentStuQty.ToString());
 }
 
 if (objCurrEduCls4SynchEN.WeekQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.WeekQty);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.WeekQty.ToString());
 }
 
 if (objCurrEduCls4SynchEN.ScheUnitPW !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ScheUnitPW);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.ScheUnitPW.ToString());
 }
 
 if (objCurrEduCls4SynchEN.WeekStatusId  ==  "")
 {
 objCurrEduCls4SynchEN.WeekStatusId = null;
 }
 if (objCurrEduCls4SynchEN.WeekStatusId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.WeekStatusId);
 var strWeekStatusId = objCurrEduCls4SynchEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekStatusId + "'");
 }
 
 if (objCurrEduCls4SynchEN.CustomerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CustomerWeek);
 var strCustomerWeek = objCurrEduCls4SynchEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCustomerWeek + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsCompleteScore);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsCompleteScore  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.IdExecPlan !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdExecPlan);
 var strIdExecPlan = objCurrEduCls4SynchEN.IdExecPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExecPlan + "'");
 }
 
 if (objCurrEduCls4SynchEN.LessonQtyPerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.LessonQtyPerWeek);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.LessonQtyPerWeek.ToString());
 }
 
 if (objCurrEduCls4SynchEN.Mark !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.Mark);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.Mark.ToString());
 }
 
 if (objCurrEduCls4SynchEN.CheckClassRoom !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckClassRoom);
 var strCheckClassRoom = objCurrEduCls4SynchEN.CheckClassRoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckClassRoom + "'");
 }
 
 if (objCurrEduCls4SynchEN.CheckAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckAdminCls);
 var strCheckAdminCls = objCurrEduCls4SynchEN.CheckAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckAdminCls + "'");
 }
 
 if (objCurrEduCls4SynchEN.CheckTeacher !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckTeacher);
 var strCheckTeacher = objCurrEduCls4SynchEN.CheckTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckTeacher + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.EditLocked);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.EditLocked  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.Sched);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.Sched  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.IdUniZone  ==  "")
 {
 objCurrEduCls4SynchEN.IdUniZone = null;
 }
 if (objCurrEduCls4SynchEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdUniZone);
 var strIdUniZone = objCurrEduCls4SynchEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.Locked);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.Locked  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.IdGradeBase  ==  "")
 {
 objCurrEduCls4SynchEN.IdGradeBase = null;
 }
 if (objCurrEduCls4SynchEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdGradeBase);
 var strIdGradeBase = objCurrEduCls4SynchEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsEffective);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsUnDeterminedClsRm);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsUnDeterminedClsRm  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SchoolYear);
 var strSchoolYear = objCurrEduCls4SynchEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduCls4SynchEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SchoolTerm);
 var strSchoolTerm = objCurrEduCls4SynchEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduCls4SynchEN.ArrangeCourseMemo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ArrangeCourseMemo);
 var strArrangeCourseMemo = objCurrEduCls4SynchEN.ArrangeCourseMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strArrangeCourseMemo + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdCourseType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdCourseType);
 var strIdCourseType = objCurrEduCls4SynchEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseType + "'");
 }
 
 if (objCurrEduCls4SynchEN.ExportDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ExportDate);
 var strExportDate = objCurrEduCls4SynchEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExportDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsDegree);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsDegree  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.IdScoreType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdScoreType);
 var strIdScoreType = objCurrEduCls4SynchEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdScoreType + "'");
 }
 
 if (objCurrEduCls4SynchEN.GetScoreWayId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.GetScoreWayId);
 var strGetScoreWayId = objCurrEduCls4SynchEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetScoreWayId + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsProportionalCtrl);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsProportionalCtrl  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsSynchToWeb);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsSynchToWeb  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.SynchToWebDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SynchToWebDate);
 var strSynchToWebDate = objCurrEduCls4SynchEN.SynchToWebDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToWebDate + "'");
 }
 
 if (objCurrEduCls4SynchEN.SynchToWebUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SynchToWebUser);
 var strSynchToWebUser = objCurrEduCls4SynchEN.SynchToWebUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToWebUser + "'");
 }
 
 if (objCurrEduCls4SynchEN.SignInDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SignInDate);
 var strSignInDate = objCurrEduCls4SynchEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInDate + "'");
 }
 
 if (objCurrEduCls4SynchEN.SignInStateID !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SignInStateID);
 var strSignInStateID = objCurrEduCls4SynchEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInStateID + "'");
 }
 
 if (objCurrEduCls4SynchEN.SignInUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SignInUser);
 var strSignInUser = objCurrEduCls4SynchEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInUser + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdExamType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdExamType);
 var strIdExamType = objCurrEduCls4SynchEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExamType + "'");
 }
 
 if (objCurrEduCls4SynchEN.ExamPortion !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ExamPortion);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.ExamPortion.ToString());
 }
 
 if (objCurrEduCls4SynchEN.MidExamScorePortion !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.MidExamScorePortion);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.MidExamScorePortion.ToString());
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsClearScore);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsClearScore  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsGeneratePwd);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsGeneratePwd  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.GeneratePwdDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.GeneratePwdDate);
 var strGeneratePwdDate = objCurrEduCls4SynchEN.GeneratePwdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneratePwdDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsExportToGP);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsExportToGP  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsExportToGPWeb);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsExportToGPWeb  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsReservedDecimal);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsReservedDecimal  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.ExamTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ExamTime);
 var strExamTime = objCurrEduCls4SynchEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamTime + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckState);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.CheckState  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.CheckDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckDate);
 var strCheckDate = objCurrEduCls4SynchEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDate + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdEduClassInPk !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdEduClassInPk);
 var strIdEduClassInPk = objCurrEduCls4SynchEN.IdEduClassInPk.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduClassInPk + "'");
 }
 
 if (objCurrEduCls4SynchEN.PkWeekTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.PkWeekTime);
 var strPkWeekTime = objCurrEduCls4SynchEN.PkWeekTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPkWeekTime + "'");
 }
 
 if (objCurrEduCls4SynchEN.PkClassRooms !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.PkClassRooms);
 var strPkClassRooms = objCurrEduCls4SynchEN.PkClassRooms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPkClassRooms + "'");
 }
 
 if (objCurrEduCls4SynchEN.BeginWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.BeginWeek);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.BeginWeek.ToString());
 }
 
 if (objCurrEduCls4SynchEN.TeacherNames !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.TeacherNames);
 var strTeacherNames = objCurrEduCls4SynchEN.TeacherNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherNames + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsAccessSynch);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsAccessSynch  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.AccessSynchDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.AccessSynchDate);
 var strAccessSynchDate = objCurrEduCls4SynchEN.AccessSynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAccessSynchDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsExistEduClsInCurr);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsExistEduClsInCurr  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ModifyDate);
 var strModifyDate = objCurrEduCls4SynchEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduCls4SynchEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ModifyUserId);
 var strModifyUserId = objCurrEduCls4SynchEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objCurrEduCls4SynchEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.Memo);
 var strMemo = objCurrEduCls4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduCls4Synch");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCurrEduCls4SynchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduCls4SynchEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCurrEduCls4SynchEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IpAddress);
 var strIpAddress = objCurrEduCls4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduCls4SynchEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduCls4SynchEN.CurrEduClsId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CurrEduClsId);
 var strCurrEduClsId = objCurrEduCls4SynchEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCurrEduClsId + "'");
 }
 
 if (objCurrEduCls4SynchEN.EduClsName !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.EduClsName);
 var strEduClsName = objCurrEduCls4SynchEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsName + "'");
 }
 
 if (objCurrEduCls4SynchEN.EduClsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.EduClsTypeId);
 var strEduClsTypeId = objCurrEduCls4SynchEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsTypeId + "'");
 }
 
 if (objCurrEduCls4SynchEN.CourseId  ==  "")
 {
 objCurrEduCls4SynchEN.CourseId = null;
 }
 if (objCurrEduCls4SynchEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CourseId);
 var strCourseId = objCurrEduCls4SynchEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCurrEduCls4SynchEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.TeachingSolutionId);
 var strTeachingSolutionId = objCurrEduCls4SynchEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdXzCollege);
 var strIdXzCollege = objCurrEduCls4SynchEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdEduWay  ==  "")
 {
 objCurrEduCls4SynchEN.IdEduWay = null;
 }
 if (objCurrEduCls4SynchEN.IdEduWay !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdEduWay);
 var strIdEduWay = objCurrEduCls4SynchEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduWay + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdClassRoomType  ==  "")
 {
 objCurrEduCls4SynchEN.IdClassRoomType = null;
 }
 if (objCurrEduCls4SynchEN.IdClassRoomType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdClassRoomType);
 var strIdClassRoomType = objCurrEduCls4SynchEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClassRoomType + "'");
 }
 
 if (objCurrEduCls4SynchEN.TotalLessonQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.TotalLessonQty);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.TotalLessonQty.ToString());
 }
 
 if (objCurrEduCls4SynchEN.MaxStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.MaxStuQty);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.MaxStuQty.ToString());
 }
 
 if (objCurrEduCls4SynchEN.CurrentStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CurrentStuQty);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.CurrentStuQty.ToString());
 }
 
 if (objCurrEduCls4SynchEN.WeekQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.WeekQty);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.WeekQty.ToString());
 }
 
 if (objCurrEduCls4SynchEN.ScheUnitPW !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ScheUnitPW);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.ScheUnitPW.ToString());
 }
 
 if (objCurrEduCls4SynchEN.WeekStatusId  ==  "")
 {
 objCurrEduCls4SynchEN.WeekStatusId = null;
 }
 if (objCurrEduCls4SynchEN.WeekStatusId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.WeekStatusId);
 var strWeekStatusId = objCurrEduCls4SynchEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekStatusId + "'");
 }
 
 if (objCurrEduCls4SynchEN.CustomerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CustomerWeek);
 var strCustomerWeek = objCurrEduCls4SynchEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCustomerWeek + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsCompleteScore);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsCompleteScore  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.IdExecPlan !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdExecPlan);
 var strIdExecPlan = objCurrEduCls4SynchEN.IdExecPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExecPlan + "'");
 }
 
 if (objCurrEduCls4SynchEN.LessonQtyPerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.LessonQtyPerWeek);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.LessonQtyPerWeek.ToString());
 }
 
 if (objCurrEduCls4SynchEN.Mark !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.Mark);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.Mark.ToString());
 }
 
 if (objCurrEduCls4SynchEN.CheckClassRoom !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckClassRoom);
 var strCheckClassRoom = objCurrEduCls4SynchEN.CheckClassRoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckClassRoom + "'");
 }
 
 if (objCurrEduCls4SynchEN.CheckAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckAdminCls);
 var strCheckAdminCls = objCurrEduCls4SynchEN.CheckAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckAdminCls + "'");
 }
 
 if (objCurrEduCls4SynchEN.CheckTeacher !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckTeacher);
 var strCheckTeacher = objCurrEduCls4SynchEN.CheckTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckTeacher + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.EditLocked);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.EditLocked  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.Sched);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.Sched  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.IdUniZone  ==  "")
 {
 objCurrEduCls4SynchEN.IdUniZone = null;
 }
 if (objCurrEduCls4SynchEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdUniZone);
 var strIdUniZone = objCurrEduCls4SynchEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.Locked);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.Locked  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.IdGradeBase  ==  "")
 {
 objCurrEduCls4SynchEN.IdGradeBase = null;
 }
 if (objCurrEduCls4SynchEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdGradeBase);
 var strIdGradeBase = objCurrEduCls4SynchEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsEffective);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsUnDeterminedClsRm);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsUnDeterminedClsRm  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SchoolYear);
 var strSchoolYear = objCurrEduCls4SynchEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduCls4SynchEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SchoolTerm);
 var strSchoolTerm = objCurrEduCls4SynchEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduCls4SynchEN.ArrangeCourseMemo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ArrangeCourseMemo);
 var strArrangeCourseMemo = objCurrEduCls4SynchEN.ArrangeCourseMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strArrangeCourseMemo + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdCourseType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdCourseType);
 var strIdCourseType = objCurrEduCls4SynchEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseType + "'");
 }
 
 if (objCurrEduCls4SynchEN.ExportDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ExportDate);
 var strExportDate = objCurrEduCls4SynchEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExportDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsDegree);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsDegree  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.IdScoreType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdScoreType);
 var strIdScoreType = objCurrEduCls4SynchEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdScoreType + "'");
 }
 
 if (objCurrEduCls4SynchEN.GetScoreWayId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.GetScoreWayId);
 var strGetScoreWayId = objCurrEduCls4SynchEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetScoreWayId + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsProportionalCtrl);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsProportionalCtrl  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsSynchToWeb);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsSynchToWeb  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.SynchToWebDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SynchToWebDate);
 var strSynchToWebDate = objCurrEduCls4SynchEN.SynchToWebDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToWebDate + "'");
 }
 
 if (objCurrEduCls4SynchEN.SynchToWebUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SynchToWebUser);
 var strSynchToWebUser = objCurrEduCls4SynchEN.SynchToWebUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToWebUser + "'");
 }
 
 if (objCurrEduCls4SynchEN.SignInDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SignInDate);
 var strSignInDate = objCurrEduCls4SynchEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInDate + "'");
 }
 
 if (objCurrEduCls4SynchEN.SignInStateID !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SignInStateID);
 var strSignInStateID = objCurrEduCls4SynchEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInStateID + "'");
 }
 
 if (objCurrEduCls4SynchEN.SignInUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SignInUser);
 var strSignInUser = objCurrEduCls4SynchEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInUser + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdExamType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdExamType);
 var strIdExamType = objCurrEduCls4SynchEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExamType + "'");
 }
 
 if (objCurrEduCls4SynchEN.ExamPortion !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ExamPortion);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.ExamPortion.ToString());
 }
 
 if (objCurrEduCls4SynchEN.MidExamScorePortion !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.MidExamScorePortion);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.MidExamScorePortion.ToString());
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsClearScore);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsClearScore  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsGeneratePwd);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsGeneratePwd  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.GeneratePwdDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.GeneratePwdDate);
 var strGeneratePwdDate = objCurrEduCls4SynchEN.GeneratePwdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneratePwdDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsExportToGP);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsExportToGP  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsExportToGPWeb);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsExportToGPWeb  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsReservedDecimal);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsReservedDecimal  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.ExamTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ExamTime);
 var strExamTime = objCurrEduCls4SynchEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamTime + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckState);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.CheckState  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.CheckDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckDate);
 var strCheckDate = objCurrEduCls4SynchEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDate + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdEduClassInPk !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdEduClassInPk);
 var strIdEduClassInPk = objCurrEduCls4SynchEN.IdEduClassInPk.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduClassInPk + "'");
 }
 
 if (objCurrEduCls4SynchEN.PkWeekTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.PkWeekTime);
 var strPkWeekTime = objCurrEduCls4SynchEN.PkWeekTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPkWeekTime + "'");
 }
 
 if (objCurrEduCls4SynchEN.PkClassRooms !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.PkClassRooms);
 var strPkClassRooms = objCurrEduCls4SynchEN.PkClassRooms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPkClassRooms + "'");
 }
 
 if (objCurrEduCls4SynchEN.BeginWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.BeginWeek);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.BeginWeek.ToString());
 }
 
 if (objCurrEduCls4SynchEN.TeacherNames !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.TeacherNames);
 var strTeacherNames = objCurrEduCls4SynchEN.TeacherNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherNames + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsAccessSynch);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsAccessSynch  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.AccessSynchDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.AccessSynchDate);
 var strAccessSynchDate = objCurrEduCls4SynchEN.AccessSynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAccessSynchDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsExistEduClsInCurr);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsExistEduClsInCurr  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ModifyDate);
 var strModifyDate = objCurrEduCls4SynchEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduCls4SynchEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ModifyUserId);
 var strModifyUserId = objCurrEduCls4SynchEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objCurrEduCls4SynchEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.Memo);
 var strMemo = objCurrEduCls4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduCls4Synch");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCurrEduCls4SynchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduCls4SynchEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCurrEduCls4SynchEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IpAddress);
 var strIpAddress = objCurrEduCls4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduCls4SynchEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduCls4SynchEN.CurrEduClsId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CurrEduClsId);
 var strCurrEduClsId = objCurrEduCls4SynchEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCurrEduClsId + "'");
 }
 
 if (objCurrEduCls4SynchEN.EduClsName !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.EduClsName);
 var strEduClsName = objCurrEduCls4SynchEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsName + "'");
 }
 
 if (objCurrEduCls4SynchEN.EduClsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.EduClsTypeId);
 var strEduClsTypeId = objCurrEduCls4SynchEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsTypeId + "'");
 }
 
 if (objCurrEduCls4SynchEN.CourseId  ==  "")
 {
 objCurrEduCls4SynchEN.CourseId = null;
 }
 if (objCurrEduCls4SynchEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CourseId);
 var strCourseId = objCurrEduCls4SynchEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCurrEduCls4SynchEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.TeachingSolutionId);
 var strTeachingSolutionId = objCurrEduCls4SynchEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdXzCollege);
 var strIdXzCollege = objCurrEduCls4SynchEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdEduWay  ==  "")
 {
 objCurrEduCls4SynchEN.IdEduWay = null;
 }
 if (objCurrEduCls4SynchEN.IdEduWay !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdEduWay);
 var strIdEduWay = objCurrEduCls4SynchEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduWay + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdClassRoomType  ==  "")
 {
 objCurrEduCls4SynchEN.IdClassRoomType = null;
 }
 if (objCurrEduCls4SynchEN.IdClassRoomType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdClassRoomType);
 var strIdClassRoomType = objCurrEduCls4SynchEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClassRoomType + "'");
 }
 
 if (objCurrEduCls4SynchEN.TotalLessonQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.TotalLessonQty);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.TotalLessonQty.ToString());
 }
 
 if (objCurrEduCls4SynchEN.MaxStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.MaxStuQty);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.MaxStuQty.ToString());
 }
 
 if (objCurrEduCls4SynchEN.CurrentStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CurrentStuQty);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.CurrentStuQty.ToString());
 }
 
 if (objCurrEduCls4SynchEN.WeekQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.WeekQty);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.WeekQty.ToString());
 }
 
 if (objCurrEduCls4SynchEN.ScheUnitPW !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ScheUnitPW);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.ScheUnitPW.ToString());
 }
 
 if (objCurrEduCls4SynchEN.WeekStatusId  ==  "")
 {
 objCurrEduCls4SynchEN.WeekStatusId = null;
 }
 if (objCurrEduCls4SynchEN.WeekStatusId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.WeekStatusId);
 var strWeekStatusId = objCurrEduCls4SynchEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekStatusId + "'");
 }
 
 if (objCurrEduCls4SynchEN.CustomerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CustomerWeek);
 var strCustomerWeek = objCurrEduCls4SynchEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCustomerWeek + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsCompleteScore);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsCompleteScore  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.IdExecPlan !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdExecPlan);
 var strIdExecPlan = objCurrEduCls4SynchEN.IdExecPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExecPlan + "'");
 }
 
 if (objCurrEduCls4SynchEN.LessonQtyPerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.LessonQtyPerWeek);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.LessonQtyPerWeek.ToString());
 }
 
 if (objCurrEduCls4SynchEN.Mark !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.Mark);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.Mark.ToString());
 }
 
 if (objCurrEduCls4SynchEN.CheckClassRoom !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckClassRoom);
 var strCheckClassRoom = objCurrEduCls4SynchEN.CheckClassRoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckClassRoom + "'");
 }
 
 if (objCurrEduCls4SynchEN.CheckAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckAdminCls);
 var strCheckAdminCls = objCurrEduCls4SynchEN.CheckAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckAdminCls + "'");
 }
 
 if (objCurrEduCls4SynchEN.CheckTeacher !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckTeacher);
 var strCheckTeacher = objCurrEduCls4SynchEN.CheckTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckTeacher + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.EditLocked);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.EditLocked  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.Sched);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.Sched  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.IdUniZone  ==  "")
 {
 objCurrEduCls4SynchEN.IdUniZone = null;
 }
 if (objCurrEduCls4SynchEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdUniZone);
 var strIdUniZone = objCurrEduCls4SynchEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.Locked);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.Locked  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.IdGradeBase  ==  "")
 {
 objCurrEduCls4SynchEN.IdGradeBase = null;
 }
 if (objCurrEduCls4SynchEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdGradeBase);
 var strIdGradeBase = objCurrEduCls4SynchEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsEffective);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsUnDeterminedClsRm);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsUnDeterminedClsRm  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SchoolYear);
 var strSchoolYear = objCurrEduCls4SynchEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduCls4SynchEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SchoolTerm);
 var strSchoolTerm = objCurrEduCls4SynchEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduCls4SynchEN.ArrangeCourseMemo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ArrangeCourseMemo);
 var strArrangeCourseMemo = objCurrEduCls4SynchEN.ArrangeCourseMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strArrangeCourseMemo + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdCourseType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdCourseType);
 var strIdCourseType = objCurrEduCls4SynchEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseType + "'");
 }
 
 if (objCurrEduCls4SynchEN.ExportDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ExportDate);
 var strExportDate = objCurrEduCls4SynchEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExportDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsDegree);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsDegree  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.IdScoreType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdScoreType);
 var strIdScoreType = objCurrEduCls4SynchEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdScoreType + "'");
 }
 
 if (objCurrEduCls4SynchEN.GetScoreWayId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.GetScoreWayId);
 var strGetScoreWayId = objCurrEduCls4SynchEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetScoreWayId + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsProportionalCtrl);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsProportionalCtrl  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsSynchToWeb);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsSynchToWeb  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.SynchToWebDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SynchToWebDate);
 var strSynchToWebDate = objCurrEduCls4SynchEN.SynchToWebDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToWebDate + "'");
 }
 
 if (objCurrEduCls4SynchEN.SynchToWebUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SynchToWebUser);
 var strSynchToWebUser = objCurrEduCls4SynchEN.SynchToWebUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToWebUser + "'");
 }
 
 if (objCurrEduCls4SynchEN.SignInDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SignInDate);
 var strSignInDate = objCurrEduCls4SynchEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInDate + "'");
 }
 
 if (objCurrEduCls4SynchEN.SignInStateID !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SignInStateID);
 var strSignInStateID = objCurrEduCls4SynchEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInStateID + "'");
 }
 
 if (objCurrEduCls4SynchEN.SignInUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.SignInUser);
 var strSignInUser = objCurrEduCls4SynchEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInUser + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdExamType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdExamType);
 var strIdExamType = objCurrEduCls4SynchEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExamType + "'");
 }
 
 if (objCurrEduCls4SynchEN.ExamPortion !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ExamPortion);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.ExamPortion.ToString());
 }
 
 if (objCurrEduCls4SynchEN.MidExamScorePortion !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.MidExamScorePortion);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.MidExamScorePortion.ToString());
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsClearScore);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsClearScore  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsGeneratePwd);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsGeneratePwd  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.GeneratePwdDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.GeneratePwdDate);
 var strGeneratePwdDate = objCurrEduCls4SynchEN.GeneratePwdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneratePwdDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsExportToGP);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsExportToGP  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsExportToGPWeb);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsExportToGPWeb  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsReservedDecimal);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsReservedDecimal  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.ExamTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ExamTime);
 var strExamTime = objCurrEduCls4SynchEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamTime + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckState);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.CheckState  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.CheckDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.CheckDate);
 var strCheckDate = objCurrEduCls4SynchEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDate + "'");
 }
 
 if (objCurrEduCls4SynchEN.IdEduClassInPk !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IdEduClassInPk);
 var strIdEduClassInPk = objCurrEduCls4SynchEN.IdEduClassInPk.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduClassInPk + "'");
 }
 
 if (objCurrEduCls4SynchEN.PkWeekTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.PkWeekTime);
 var strPkWeekTime = objCurrEduCls4SynchEN.PkWeekTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPkWeekTime + "'");
 }
 
 if (objCurrEduCls4SynchEN.PkClassRooms !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.PkClassRooms);
 var strPkClassRooms = objCurrEduCls4SynchEN.PkClassRooms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPkClassRooms + "'");
 }
 
 if (objCurrEduCls4SynchEN.BeginWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.BeginWeek);
 arrValueListForInsert.Add(objCurrEduCls4SynchEN.BeginWeek.ToString());
 }
 
 if (objCurrEduCls4SynchEN.TeacherNames !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.TeacherNames);
 var strTeacherNames = objCurrEduCls4SynchEN.TeacherNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherNames + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsAccessSynch);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsAccessSynch  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.AccessSynchDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.AccessSynchDate);
 var strAccessSynchDate = objCurrEduCls4SynchEN.AccessSynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAccessSynchDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls4Synch.IsExistEduClsInCurr);
 arrValueListForInsert.Add("'" + (objCurrEduCls4SynchEN.IsExistEduClsInCurr  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls4SynchEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ModifyDate);
 var strModifyDate = objCurrEduCls4SynchEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduCls4SynchEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.ModifyUserId);
 var strModifyUserId = objCurrEduCls4SynchEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objCurrEduCls4SynchEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls4Synch.Memo);
 var strMemo = objCurrEduCls4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduCls4Synch");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCurrEduCls4Synchs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls4Synch where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CurrEduCls4Synch");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCurrEduCls4SynchEN._CurrTabName ].NewRow();
objRow[conCurrEduCls4Synch.IpAddress] = oRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址
objRow[conCurrEduCls4Synch.IdCurrEduCls] = oRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conCurrEduCls4Synch.CurrEduClsId] = oRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id
objRow[conCurrEduCls4Synch.EduClsName] = oRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名
objRow[conCurrEduCls4Synch.EduClsTypeId] = oRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id
objRow[conCurrEduCls4Synch.CourseId] = oRow[conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id
objRow[conCurrEduCls4Synch.TeachingSolutionId] = oRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id
objRow[conCurrEduCls4Synch.IdXzCollege] = oRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号
objRow[conCurrEduCls4Synch.IdEduWay] = oRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号
objRow[conCurrEduCls4Synch.IdClassRoomType] = oRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号
objRow[conCurrEduCls4Synch.TotalLessonQty] = oRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim(); //总课时数
objRow[conCurrEduCls4Synch.MaxStuQty] = oRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim(); //最大学生数
objRow[conCurrEduCls4Synch.CurrentStuQty] = oRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim(); //当前学生数
objRow[conCurrEduCls4Synch.WeekQty] = oRow[conCurrEduCls4Synch.WeekQty].ToString().Trim(); //总周数
objRow[conCurrEduCls4Synch.ScheUnitPW] = oRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim(); //周排课次数
objRow[conCurrEduCls4Synch.WeekStatusId] = oRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objRow[conCurrEduCls4Synch.CustomerWeek] = oRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周
objRow[conCurrEduCls4Synch.IsCompleteScore] = oRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim(); //是否成绩齐全
objRow[conCurrEduCls4Synch.IdExecPlan] = oRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号
objRow[conCurrEduCls4Synch.LessonQtyPerWeek] = oRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim(); //周课时数
objRow[conCurrEduCls4Synch.Mark] = oRow[conCurrEduCls4Synch.Mark].ToString().Trim(); //获得学分
objRow[conCurrEduCls4Synch.CheckClassRoom] = oRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果
objRow[conCurrEduCls4Synch.CheckAdminCls] = oRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果
objRow[conCurrEduCls4Synch.CheckTeacher] = oRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果
objRow[conCurrEduCls4Synch.EditLocked] = oRow[conCurrEduCls4Synch.EditLocked].ToString().Trim(); //编辑锁定
objRow[conCurrEduCls4Synch.Sched] = oRow[conCurrEduCls4Synch.Sched].ToString().Trim(); //是否排课
objRow[conCurrEduCls4Synch.IdUniZone] = oRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号
objRow[conCurrEduCls4Synch.Locked] = oRow[conCurrEduCls4Synch.Locked].ToString().Trim(); //锁定状态
objRow[conCurrEduCls4Synch.IdGradeBase] = oRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号
objRow[conCurrEduCls4Synch.IsEffective] = oRow[conCurrEduCls4Synch.IsEffective].ToString().Trim(); //是否有效
objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm] = oRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim(); //是否待定教室
objRow[conCurrEduCls4Synch.SchoolYear] = oRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年
objRow[conCurrEduCls4Synch.SchoolTerm] = oRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期
objRow[conCurrEduCls4Synch.ArrangeCourseMemo] = oRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注
objRow[conCurrEduCls4Synch.IdCourseType] = oRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号
objRow[conCurrEduCls4Synch.ExportDate] = oRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期
objRow[conCurrEduCls4Synch.IsDegree] = oRow[conCurrEduCls4Synch.IsDegree].ToString().Trim(); //是否学位课
objRow[conCurrEduCls4Synch.IdScoreType] = oRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号
objRow[conCurrEduCls4Synch.GetScoreWayId] = oRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objRow[conCurrEduCls4Synch.IsProportionalCtrl] = oRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim(); //是否比例控制
objRow[conCurrEduCls4Synch.IsSynchToWeb] = oRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim(); //是否同步Web
objRow[conCurrEduCls4Synch.SynchToWebDate] = oRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期
objRow[conCurrEduCls4Synch.SynchToWebUser] = oRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户
objRow[conCurrEduCls4Synch.SignInDate] = oRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间
objRow[conCurrEduCls4Synch.SignInStateID] = oRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号
objRow[conCurrEduCls4Synch.SignInUser] = oRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人
objRow[conCurrEduCls4Synch.IdExamType] = oRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号
objRow[conCurrEduCls4Synch.ExamPortion] = oRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim(); //平时成绩所占比例
objRow[conCurrEduCls4Synch.MidExamScorePortion] = oRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim(); //期末成绩所占比例
objRow[conCurrEduCls4Synch.IsClearScore] = oRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim(); //是否重录成绩
objRow[conCurrEduCls4Synch.IsGeneratePwd] = oRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim(); //是否生成口令
objRow[conCurrEduCls4Synch.GeneratePwdDate] = oRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间
objRow[conCurrEduCls4Synch.IsExportToGP] = oRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim(); //是否导出到平台
objRow[conCurrEduCls4Synch.IsExportToGPWeb] = oRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim(); //是否导出到Web平台
objRow[conCurrEduCls4Synch.IsReservedDecimal] = oRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim(); //是否保留小数
objRow[conCurrEduCls4Synch.ExamTime] = oRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间
objRow[conCurrEduCls4Synch.CheckState] = oRow[conCurrEduCls4Synch.CheckState].ToString().Trim(); //检查状态
objRow[conCurrEduCls4Synch.CheckDate] = oRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期
objRow[conCurrEduCls4Synch.IdEduClassInPk] = oRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objRow[conCurrEduCls4Synch.PkWeekTime] = oRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间
objRow[conCurrEduCls4Synch.PkClassRooms] = oRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室
objRow[conCurrEduCls4Synch.BeginWeek] = oRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim(); //开始周
objRow[conCurrEduCls4Synch.TeacherNames] = oRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名
objRow[conCurrEduCls4Synch.IsAccessSynch] = oRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim(); //是否处理同步
objRow[conCurrEduCls4Synch.AccessSynchDate] = oRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objRow[conCurrEduCls4Synch.IsExistEduClsInCurr] = oRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim(); //当前是否存在教学班
objRow[conCurrEduCls4Synch.ModifyDate] = oRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期
objRow[conCurrEduCls4Synch.ModifyUserId] = oRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人
objRow[conCurrEduCls4Synch.Memo] = oRow[conCurrEduCls4Synch.Memo].ToString().Trim(); //备注
 objDS.Tables[clsCurrEduCls4SynchEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCurrEduCls4SynchEN._CurrTabName);
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
 /// <param name = "objCurrEduCls4SynchEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
 if (objCurrEduCls4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduCls4SynchEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls4Synch where mId = " + ""+ objCurrEduCls4SynchEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCurrEduCls4SynchEN._CurrTabName);
if (objDS.Tables[clsCurrEduCls4SynchEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objCurrEduCls4SynchEN.mId+"");
return false;
}
objRow = objDS.Tables[clsCurrEduCls4SynchEN._CurrTabName].Rows[0];
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IpAddress))
 {
objRow[conCurrEduCls4Synch.IpAddress] = objCurrEduCls4SynchEN.IpAddress; //Ip地址
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdCurrEduCls))
 {
objRow[conCurrEduCls4Synch.IdCurrEduCls] = objCurrEduCls4SynchEN.IdCurrEduCls; //教学班流水号
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CurrEduClsId))
 {
objRow[conCurrEduCls4Synch.CurrEduClsId] = objCurrEduCls4SynchEN.CurrEduClsId; //教学班Id
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.EduClsName))
 {
objRow[conCurrEduCls4Synch.EduClsName] = objCurrEduCls4SynchEN.EduClsName; //教学班名
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.EduClsTypeId))
 {
objRow[conCurrEduCls4Synch.EduClsTypeId] = objCurrEduCls4SynchEN.EduClsTypeId; //教学班类型Id
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CourseId))
 {
objRow[conCurrEduCls4Synch.CourseId] = objCurrEduCls4SynchEN.CourseId; //课程Id
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.TeachingSolutionId))
 {
objRow[conCurrEduCls4Synch.TeachingSolutionId] = objCurrEduCls4SynchEN.TeachingSolutionId; //教学方案Id
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdXzCollege))
 {
objRow[conCurrEduCls4Synch.IdXzCollege] = objCurrEduCls4SynchEN.IdXzCollege; //学院流水号
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdEduWay))
 {
objRow[conCurrEduCls4Synch.IdEduWay] = objCurrEduCls4SynchEN.IdEduWay; //教学方式流水号
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdClassRoomType))
 {
objRow[conCurrEduCls4Synch.IdClassRoomType] = objCurrEduCls4SynchEN.IdClassRoomType; //教室类型流水号
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.TotalLessonQty))
 {
objRow[conCurrEduCls4Synch.TotalLessonQty] = objCurrEduCls4SynchEN.TotalLessonQty; //总课时数
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.MaxStuQty))
 {
objRow[conCurrEduCls4Synch.MaxStuQty] = objCurrEduCls4SynchEN.MaxStuQty; //最大学生数
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CurrentStuQty))
 {
objRow[conCurrEduCls4Synch.CurrentStuQty] = objCurrEduCls4SynchEN.CurrentStuQty; //当前学生数
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.WeekQty))
 {
objRow[conCurrEduCls4Synch.WeekQty] = objCurrEduCls4SynchEN.WeekQty; //总周数
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ScheUnitPW))
 {
objRow[conCurrEduCls4Synch.ScheUnitPW] = objCurrEduCls4SynchEN.ScheUnitPW; //周排课次数
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.WeekStatusId))
 {
objRow[conCurrEduCls4Synch.WeekStatusId] = objCurrEduCls4SynchEN.WeekStatusId; //周状态编号(单,双,全周)
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CustomerWeek))
 {
objRow[conCurrEduCls4Synch.CustomerWeek] = objCurrEduCls4SynchEN.CustomerWeek; //自定义上课周
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsCompleteScore))
 {
objRow[conCurrEduCls4Synch.IsCompleteScore] = objCurrEduCls4SynchEN.IsCompleteScore; //是否成绩齐全
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdExecPlan))
 {
objRow[conCurrEduCls4Synch.IdExecPlan] = objCurrEduCls4SynchEN.IdExecPlan; //执行计划流水号
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.LessonQtyPerWeek))
 {
objRow[conCurrEduCls4Synch.LessonQtyPerWeek] = objCurrEduCls4SynchEN.LessonQtyPerWeek; //周课时数
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Mark))
 {
objRow[conCurrEduCls4Synch.Mark] = objCurrEduCls4SynchEN.Mark; //获得学分
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckClassRoom))
 {
objRow[conCurrEduCls4Synch.CheckClassRoom] = objCurrEduCls4SynchEN.CheckClassRoom; //检查教室结果
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckAdminCls))
 {
objRow[conCurrEduCls4Synch.CheckAdminCls] = objCurrEduCls4SynchEN.CheckAdminCls; //检查行政班结果
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckTeacher))
 {
objRow[conCurrEduCls4Synch.CheckTeacher] = objCurrEduCls4SynchEN.CheckTeacher; //检查教师结果
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.EditLocked))
 {
objRow[conCurrEduCls4Synch.EditLocked] = objCurrEduCls4SynchEN.EditLocked; //编辑锁定
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Sched))
 {
objRow[conCurrEduCls4Synch.Sched] = objCurrEduCls4SynchEN.Sched; //是否排课
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdUniZone))
 {
objRow[conCurrEduCls4Synch.IdUniZone] = objCurrEduCls4SynchEN.IdUniZone; //校区流水号
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Locked))
 {
objRow[conCurrEduCls4Synch.Locked] = objCurrEduCls4SynchEN.Locked; //锁定状态
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdGradeBase))
 {
objRow[conCurrEduCls4Synch.IdGradeBase] = objCurrEduCls4SynchEN.IdGradeBase; //年级流水号
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsEffective))
 {
objRow[conCurrEduCls4Synch.IsEffective] = objCurrEduCls4SynchEN.IsEffective; //是否有效
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsUnDeterminedClsRm))
 {
objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm] = objCurrEduCls4SynchEN.IsUnDeterminedClsRm; //是否待定教室
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SchoolYear))
 {
objRow[conCurrEduCls4Synch.SchoolYear] = objCurrEduCls4SynchEN.SchoolYear; //学年
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SchoolTerm))
 {
objRow[conCurrEduCls4Synch.SchoolTerm] = objCurrEduCls4SynchEN.SchoolTerm; //学期
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ArrangeCourseMemo))
 {
objRow[conCurrEduCls4Synch.ArrangeCourseMemo] = objCurrEduCls4SynchEN.ArrangeCourseMemo; //排课备注
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdCourseType))
 {
objRow[conCurrEduCls4Synch.IdCourseType] = objCurrEduCls4SynchEN.IdCourseType; //课程类型流水号
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ExportDate))
 {
objRow[conCurrEduCls4Synch.ExportDate] = objCurrEduCls4SynchEN.ExportDate; //导出日期
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsDegree))
 {
objRow[conCurrEduCls4Synch.IsDegree] = objCurrEduCls4SynchEN.IsDegree; //是否学位课
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdScoreType))
 {
objRow[conCurrEduCls4Synch.IdScoreType] = objCurrEduCls4SynchEN.IdScoreType; //成绩类型流水号
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.GetScoreWayId))
 {
objRow[conCurrEduCls4Synch.GetScoreWayId] = objCurrEduCls4SynchEN.GetScoreWayId; //获得成绩方式Id
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsProportionalCtrl))
 {
objRow[conCurrEduCls4Synch.IsProportionalCtrl] = objCurrEduCls4SynchEN.IsProportionalCtrl; //是否比例控制
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsSynchToWeb))
 {
objRow[conCurrEduCls4Synch.IsSynchToWeb] = objCurrEduCls4SynchEN.IsSynchToWeb; //是否同步Web
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SynchToWebDate))
 {
objRow[conCurrEduCls4Synch.SynchToWebDate] = objCurrEduCls4SynchEN.SynchToWebDate; //同步Web日期
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SynchToWebUser))
 {
objRow[conCurrEduCls4Synch.SynchToWebUser] = objCurrEduCls4SynchEN.SynchToWebUser; //同步Web用户
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SignInDate))
 {
objRow[conCurrEduCls4Synch.SignInDate] = objCurrEduCls4SynchEN.SignInDate; //签入时间
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SignInStateID))
 {
objRow[conCurrEduCls4Synch.SignInStateID] = objCurrEduCls4SynchEN.SignInStateID; //签入状态表流水号
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SignInUser))
 {
objRow[conCurrEduCls4Synch.SignInUser] = objCurrEduCls4SynchEN.SignInUser; //签入人
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdExamType))
 {
objRow[conCurrEduCls4Synch.IdExamType] = objCurrEduCls4SynchEN.IdExamType; //考试方式流水号
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ExamPortion))
 {
objRow[conCurrEduCls4Synch.ExamPortion] = objCurrEduCls4SynchEN.ExamPortion; //平时成绩所占比例
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.MidExamScorePortion))
 {
objRow[conCurrEduCls4Synch.MidExamScorePortion] = objCurrEduCls4SynchEN.MidExamScorePortion; //期末成绩所占比例
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsClearScore))
 {
objRow[conCurrEduCls4Synch.IsClearScore] = objCurrEduCls4SynchEN.IsClearScore; //是否重录成绩
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsGeneratePwd))
 {
objRow[conCurrEduCls4Synch.IsGeneratePwd] = objCurrEduCls4SynchEN.IsGeneratePwd; //是否生成口令
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.GeneratePwdDate))
 {
objRow[conCurrEduCls4Synch.GeneratePwdDate] = objCurrEduCls4SynchEN.GeneratePwdDate; //生成口令时间
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsExportToGP))
 {
objRow[conCurrEduCls4Synch.IsExportToGP] = objCurrEduCls4SynchEN.IsExportToGP; //是否导出到平台
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsExportToGPWeb))
 {
objRow[conCurrEduCls4Synch.IsExportToGPWeb] = objCurrEduCls4SynchEN.IsExportToGPWeb; //是否导出到Web平台
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsReservedDecimal))
 {
objRow[conCurrEduCls4Synch.IsReservedDecimal] = objCurrEduCls4SynchEN.IsReservedDecimal; //是否保留小数
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ExamTime))
 {
objRow[conCurrEduCls4Synch.ExamTime] = objCurrEduCls4SynchEN.ExamTime; //考试时间
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckState))
 {
objRow[conCurrEduCls4Synch.CheckState] = objCurrEduCls4SynchEN.CheckState; //检查状态
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckDate))
 {
objRow[conCurrEduCls4Synch.CheckDate] = objCurrEduCls4SynchEN.CheckDate; //检查日期
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdEduClassInPk))
 {
objRow[conCurrEduCls4Synch.IdEduClassInPk] = objCurrEduCls4SynchEN.IdEduClassInPk; //id_EduClassInPk
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.PkWeekTime))
 {
objRow[conCurrEduCls4Synch.PkWeekTime] = objCurrEduCls4SynchEN.PkWeekTime; //排课时间
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.PkClassRooms))
 {
objRow[conCurrEduCls4Synch.PkClassRooms] = objCurrEduCls4SynchEN.PkClassRooms; //排课教室
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.BeginWeek))
 {
objRow[conCurrEduCls4Synch.BeginWeek] = objCurrEduCls4SynchEN.BeginWeek; //开始周
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.TeacherNames))
 {
objRow[conCurrEduCls4Synch.TeacherNames] = objCurrEduCls4SynchEN.TeacherNames; //教师姓名
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsAccessSynch))
 {
objRow[conCurrEduCls4Synch.IsAccessSynch] = objCurrEduCls4SynchEN.IsAccessSynch; //是否处理同步
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.AccessSynchDate))
 {
objRow[conCurrEduCls4Synch.AccessSynchDate] = objCurrEduCls4SynchEN.AccessSynchDate; //处理同步日期
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsExistEduClsInCurr))
 {
objRow[conCurrEduCls4Synch.IsExistEduClsInCurr] = objCurrEduCls4SynchEN.IsExistEduClsInCurr; //当前是否存在教学班
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ModifyDate))
 {
objRow[conCurrEduCls4Synch.ModifyDate] = objCurrEduCls4SynchEN.ModifyDate; //修改日期
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ModifyUserId))
 {
objRow[conCurrEduCls4Synch.ModifyUserId] = objCurrEduCls4SynchEN.ModifyUserId; //修改人
 }
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Memo))
 {
objRow[conCurrEduCls4Synch.Memo] = objCurrEduCls4SynchEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsCurrEduCls4SynchEN._CurrTabName);
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
 /// <param name = "objCurrEduCls4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
 if (objCurrEduCls4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduCls4SynchEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CurrEduCls4Synch Set ");
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IpAddress))
 {
 if (objCurrEduCls4SynchEN.IpAddress !=  null)
 {
 var strIpAddress = objCurrEduCls4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIpAddress, conCurrEduCls4Synch.IpAddress); //Ip地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IpAddress); //Ip地址
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdCurrEduCls))
 {
 if (objCurrEduCls4SynchEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objCurrEduCls4SynchEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conCurrEduCls4Synch.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CurrEduClsId))
 {
 if (objCurrEduCls4SynchEN.CurrEduClsId !=  null)
 {
 var strCurrEduClsId = objCurrEduCls4SynchEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCurrEduClsId, conCurrEduCls4Synch.CurrEduClsId); //教学班Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CurrEduClsId); //教学班Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.EduClsName))
 {
 if (objCurrEduCls4SynchEN.EduClsName !=  null)
 {
 var strEduClsName = objCurrEduCls4SynchEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduClsName, conCurrEduCls4Synch.EduClsName); //教学班名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.EduClsName); //教学班名
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.EduClsTypeId))
 {
 if (objCurrEduCls4SynchEN.EduClsTypeId !=  null)
 {
 var strEduClsTypeId = objCurrEduCls4SynchEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduClsTypeId, conCurrEduCls4Synch.EduClsTypeId); //教学班类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.EduClsTypeId); //教学班类型Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CourseId))
 {
 if (objCurrEduCls4SynchEN.CourseId  ==  "")
 {
 objCurrEduCls4SynchEN.CourseId = null;
 }
 if (objCurrEduCls4SynchEN.CourseId !=  null)
 {
 var strCourseId = objCurrEduCls4SynchEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conCurrEduCls4Synch.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CourseId); //课程Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.TeachingSolutionId))
 {
 if (objCurrEduCls4SynchEN.TeachingSolutionId !=  null)
 {
 var strTeachingSolutionId = objCurrEduCls4SynchEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingSolutionId, conCurrEduCls4Synch.TeachingSolutionId); //教学方案Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.TeachingSolutionId); //教学方案Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdXzCollege))
 {
 if (objCurrEduCls4SynchEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCurrEduCls4SynchEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conCurrEduCls4Synch.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdXzCollege); //学院流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdEduWay))
 {
 if (objCurrEduCls4SynchEN.IdEduWay  ==  "")
 {
 objCurrEduCls4SynchEN.IdEduWay = null;
 }
 if (objCurrEduCls4SynchEN.IdEduWay !=  null)
 {
 var strIdEduWay = objCurrEduCls4SynchEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEduWay, conCurrEduCls4Synch.IdEduWay); //教学方式流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdEduWay); //教学方式流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdClassRoomType))
 {
 if (objCurrEduCls4SynchEN.IdClassRoomType  ==  "")
 {
 objCurrEduCls4SynchEN.IdClassRoomType = null;
 }
 if (objCurrEduCls4SynchEN.IdClassRoomType !=  null)
 {
 var strIdClassRoomType = objCurrEduCls4SynchEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdClassRoomType, conCurrEduCls4Synch.IdClassRoomType); //教室类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdClassRoomType); //教室类型流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.TotalLessonQty))
 {
 if (objCurrEduCls4SynchEN.TotalLessonQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.TotalLessonQty, conCurrEduCls4Synch.TotalLessonQty); //总课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.TotalLessonQty); //总课时数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.MaxStuQty))
 {
 if (objCurrEduCls4SynchEN.MaxStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.MaxStuQty, conCurrEduCls4Synch.MaxStuQty); //最大学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.MaxStuQty); //最大学生数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CurrentStuQty))
 {
 if (objCurrEduCls4SynchEN.CurrentStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.CurrentStuQty, conCurrEduCls4Synch.CurrentStuQty); //当前学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CurrentStuQty); //当前学生数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.WeekQty))
 {
 if (objCurrEduCls4SynchEN.WeekQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.WeekQty, conCurrEduCls4Synch.WeekQty); //总周数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.WeekQty); //总周数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ScheUnitPW))
 {
 if (objCurrEduCls4SynchEN.ScheUnitPW !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.ScheUnitPW, conCurrEduCls4Synch.ScheUnitPW); //周排课次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ScheUnitPW); //周排课次数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.WeekStatusId))
 {
 if (objCurrEduCls4SynchEN.WeekStatusId  ==  "")
 {
 objCurrEduCls4SynchEN.WeekStatusId = null;
 }
 if (objCurrEduCls4SynchEN.WeekStatusId !=  null)
 {
 var strWeekStatusId = objCurrEduCls4SynchEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWeekStatusId, conCurrEduCls4Synch.WeekStatusId); //周状态编号(单,双,全周)
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.WeekStatusId); //周状态编号(单,双,全周)
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CustomerWeek))
 {
 if (objCurrEduCls4SynchEN.CustomerWeek !=  null)
 {
 var strCustomerWeek = objCurrEduCls4SynchEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCustomerWeek, conCurrEduCls4Synch.CustomerWeek); //自定义上课周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CustomerWeek); //自定义上课周
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsCompleteScore))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsCompleteScore == true?"1":"0", conCurrEduCls4Synch.IsCompleteScore); //是否成绩齐全
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdExecPlan))
 {
 if (objCurrEduCls4SynchEN.IdExecPlan !=  null)
 {
 var strIdExecPlan = objCurrEduCls4SynchEN.IdExecPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdExecPlan, conCurrEduCls4Synch.IdExecPlan); //执行计划流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdExecPlan); //执行计划流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.LessonQtyPerWeek))
 {
 if (objCurrEduCls4SynchEN.LessonQtyPerWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.LessonQtyPerWeek, conCurrEduCls4Synch.LessonQtyPerWeek); //周课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.LessonQtyPerWeek); //周课时数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Mark))
 {
 if (objCurrEduCls4SynchEN.Mark !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.Mark, conCurrEduCls4Synch.Mark); //获得学分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.Mark); //获得学分
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckClassRoom))
 {
 if (objCurrEduCls4SynchEN.CheckClassRoom !=  null)
 {
 var strCheckClassRoom = objCurrEduCls4SynchEN.CheckClassRoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckClassRoom, conCurrEduCls4Synch.CheckClassRoom); //检查教室结果
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CheckClassRoom); //检查教室结果
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckAdminCls))
 {
 if (objCurrEduCls4SynchEN.CheckAdminCls !=  null)
 {
 var strCheckAdminCls = objCurrEduCls4SynchEN.CheckAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckAdminCls, conCurrEduCls4Synch.CheckAdminCls); //检查行政班结果
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CheckAdminCls); //检查行政班结果
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckTeacher))
 {
 if (objCurrEduCls4SynchEN.CheckTeacher !=  null)
 {
 var strCheckTeacher = objCurrEduCls4SynchEN.CheckTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckTeacher, conCurrEduCls4Synch.CheckTeacher); //检查教师结果
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CheckTeacher); //检查教师结果
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.EditLocked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.EditLocked == true?"1":"0", conCurrEduCls4Synch.EditLocked); //编辑锁定
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Sched))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.Sched == true?"1":"0", conCurrEduCls4Synch.Sched); //是否排课
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdUniZone))
 {
 if (objCurrEduCls4SynchEN.IdUniZone  ==  "")
 {
 objCurrEduCls4SynchEN.IdUniZone = null;
 }
 if (objCurrEduCls4SynchEN.IdUniZone !=  null)
 {
 var strIdUniZone = objCurrEduCls4SynchEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdUniZone, conCurrEduCls4Synch.IdUniZone); //校区流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdUniZone); //校区流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Locked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.Locked == true?"1":"0", conCurrEduCls4Synch.Locked); //锁定状态
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdGradeBase))
 {
 if (objCurrEduCls4SynchEN.IdGradeBase  ==  "")
 {
 objCurrEduCls4SynchEN.IdGradeBase = null;
 }
 if (objCurrEduCls4SynchEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objCurrEduCls4SynchEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGradeBase, conCurrEduCls4Synch.IdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdGradeBase); //年级流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsEffective))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsEffective == true?"1":"0", conCurrEduCls4Synch.IsEffective); //是否有效
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsUnDeterminedClsRm))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsUnDeterminedClsRm == true?"1":"0", conCurrEduCls4Synch.IsUnDeterminedClsRm); //是否待定教室
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SchoolYear))
 {
 if (objCurrEduCls4SynchEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduCls4SynchEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conCurrEduCls4Synch.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.SchoolYear); //学年
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SchoolTerm))
 {
 if (objCurrEduCls4SynchEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduCls4SynchEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conCurrEduCls4Synch.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.SchoolTerm); //学期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ArrangeCourseMemo))
 {
 if (objCurrEduCls4SynchEN.ArrangeCourseMemo !=  null)
 {
 var strArrangeCourseMemo = objCurrEduCls4SynchEN.ArrangeCourseMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strArrangeCourseMemo, conCurrEduCls4Synch.ArrangeCourseMemo); //排课备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ArrangeCourseMemo); //排课备注
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdCourseType))
 {
 if (objCurrEduCls4SynchEN.IdCourseType !=  null)
 {
 var strIdCourseType = objCurrEduCls4SynchEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCourseType, conCurrEduCls4Synch.IdCourseType); //课程类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdCourseType); //课程类型流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ExportDate))
 {
 if (objCurrEduCls4SynchEN.ExportDate !=  null)
 {
 var strExportDate = objCurrEduCls4SynchEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExportDate, conCurrEduCls4Synch.ExportDate); //导出日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ExportDate); //导出日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsDegree))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsDegree == true?"1":"0", conCurrEduCls4Synch.IsDegree); //是否学位课
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdScoreType))
 {
 if (objCurrEduCls4SynchEN.IdScoreType !=  null)
 {
 var strIdScoreType = objCurrEduCls4SynchEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdScoreType, conCurrEduCls4Synch.IdScoreType); //成绩类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdScoreType); //成绩类型流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.GetScoreWayId))
 {
 if (objCurrEduCls4SynchEN.GetScoreWayId !=  null)
 {
 var strGetScoreWayId = objCurrEduCls4SynchEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetScoreWayId, conCurrEduCls4Synch.GetScoreWayId); //获得成绩方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.GetScoreWayId); //获得成绩方式Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsProportionalCtrl))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsProportionalCtrl == true?"1":"0", conCurrEduCls4Synch.IsProportionalCtrl); //是否比例控制
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsSynchToWeb))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsSynchToWeb == true?"1":"0", conCurrEduCls4Synch.IsSynchToWeb); //是否同步Web
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SynchToWebDate))
 {
 if (objCurrEduCls4SynchEN.SynchToWebDate !=  null)
 {
 var strSynchToWebDate = objCurrEduCls4SynchEN.SynchToWebDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToWebDate, conCurrEduCls4Synch.SynchToWebDate); //同步Web日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.SynchToWebDate); //同步Web日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SynchToWebUser))
 {
 if (objCurrEduCls4SynchEN.SynchToWebUser !=  null)
 {
 var strSynchToWebUser = objCurrEduCls4SynchEN.SynchToWebUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToWebUser, conCurrEduCls4Synch.SynchToWebUser); //同步Web用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.SynchToWebUser); //同步Web用户
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SignInDate))
 {
 if (objCurrEduCls4SynchEN.SignInDate !=  null)
 {
 var strSignInDate = objCurrEduCls4SynchEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInDate, conCurrEduCls4Synch.SignInDate); //签入时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.SignInDate); //签入时间
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SignInStateID))
 {
 if (objCurrEduCls4SynchEN.SignInStateID !=  null)
 {
 var strSignInStateID = objCurrEduCls4SynchEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInStateID, conCurrEduCls4Synch.SignInStateID); //签入状态表流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.SignInStateID); //签入状态表流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SignInUser))
 {
 if (objCurrEduCls4SynchEN.SignInUser !=  null)
 {
 var strSignInUser = objCurrEduCls4SynchEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInUser, conCurrEduCls4Synch.SignInUser); //签入人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.SignInUser); //签入人
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdExamType))
 {
 if (objCurrEduCls4SynchEN.IdExamType !=  null)
 {
 var strIdExamType = objCurrEduCls4SynchEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdExamType, conCurrEduCls4Synch.IdExamType); //考试方式流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdExamType); //考试方式流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ExamPortion))
 {
 if (objCurrEduCls4SynchEN.ExamPortion !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.ExamPortion, conCurrEduCls4Synch.ExamPortion); //平时成绩所占比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ExamPortion); //平时成绩所占比例
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.MidExamScorePortion))
 {
 if (objCurrEduCls4SynchEN.MidExamScorePortion !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.MidExamScorePortion, conCurrEduCls4Synch.MidExamScorePortion); //期末成绩所占比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.MidExamScorePortion); //期末成绩所占比例
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsClearScore))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsClearScore == true?"1":"0", conCurrEduCls4Synch.IsClearScore); //是否重录成绩
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsGeneratePwd))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsGeneratePwd == true?"1":"0", conCurrEduCls4Synch.IsGeneratePwd); //是否生成口令
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.GeneratePwdDate))
 {
 if (objCurrEduCls4SynchEN.GeneratePwdDate !=  null)
 {
 var strGeneratePwdDate = objCurrEduCls4SynchEN.GeneratePwdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGeneratePwdDate, conCurrEduCls4Synch.GeneratePwdDate); //生成口令时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.GeneratePwdDate); //生成口令时间
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsExportToGP))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsExportToGP == true?"1":"0", conCurrEduCls4Synch.IsExportToGP); //是否导出到平台
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsExportToGPWeb))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsExportToGPWeb == true?"1":"0", conCurrEduCls4Synch.IsExportToGPWeb); //是否导出到Web平台
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsReservedDecimal))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsReservedDecimal == true?"1":"0", conCurrEduCls4Synch.IsReservedDecimal); //是否保留小数
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ExamTime))
 {
 if (objCurrEduCls4SynchEN.ExamTime !=  null)
 {
 var strExamTime = objCurrEduCls4SynchEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamTime, conCurrEduCls4Synch.ExamTime); //考试时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ExamTime); //考试时间
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckState))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.CheckState == true?"1":"0", conCurrEduCls4Synch.CheckState); //检查状态
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckDate))
 {
 if (objCurrEduCls4SynchEN.CheckDate !=  null)
 {
 var strCheckDate = objCurrEduCls4SynchEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckDate, conCurrEduCls4Synch.CheckDate); //检查日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CheckDate); //检查日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdEduClassInPk))
 {
 if (objCurrEduCls4SynchEN.IdEduClassInPk !=  null)
 {
 var strIdEduClassInPk = objCurrEduCls4SynchEN.IdEduClassInPk.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEduClassInPk, conCurrEduCls4Synch.IdEduClassInPk); //id_EduClassInPk
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdEduClassInPk); //id_EduClassInPk
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.PkWeekTime))
 {
 if (objCurrEduCls4SynchEN.PkWeekTime !=  null)
 {
 var strPkWeekTime = objCurrEduCls4SynchEN.PkWeekTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPkWeekTime, conCurrEduCls4Synch.PkWeekTime); //排课时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.PkWeekTime); //排课时间
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.PkClassRooms))
 {
 if (objCurrEduCls4SynchEN.PkClassRooms !=  null)
 {
 var strPkClassRooms = objCurrEduCls4SynchEN.PkClassRooms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPkClassRooms, conCurrEduCls4Synch.PkClassRooms); //排课教室
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.PkClassRooms); //排课教室
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.BeginWeek))
 {
 if (objCurrEduCls4SynchEN.BeginWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.BeginWeek, conCurrEduCls4Synch.BeginWeek); //开始周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.BeginWeek); //开始周
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.TeacherNames))
 {
 if (objCurrEduCls4SynchEN.TeacherNames !=  null)
 {
 var strTeacherNames = objCurrEduCls4SynchEN.TeacherNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeacherNames, conCurrEduCls4Synch.TeacherNames); //教师姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.TeacherNames); //教师姓名
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsAccessSynch))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsAccessSynch == true?"1":"0", conCurrEduCls4Synch.IsAccessSynch); //是否处理同步
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.AccessSynchDate))
 {
 if (objCurrEduCls4SynchEN.AccessSynchDate !=  null)
 {
 var strAccessSynchDate = objCurrEduCls4SynchEN.AccessSynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAccessSynchDate, conCurrEduCls4Synch.AccessSynchDate); //处理同步日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.AccessSynchDate); //处理同步日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsExistEduClsInCurr))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsExistEduClsInCurr == true?"1":"0", conCurrEduCls4Synch.IsExistEduClsInCurr); //当前是否存在教学班
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ModifyDate))
 {
 if (objCurrEduCls4SynchEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduCls4SynchEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conCurrEduCls4Synch.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ModifyDate); //修改日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ModifyUserId))
 {
 if (objCurrEduCls4SynchEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objCurrEduCls4SynchEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conCurrEduCls4Synch.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ModifyUserId); //修改人
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Memo))
 {
 if (objCurrEduCls4SynchEN.Memo !=  null)
 {
 var strMemo = objCurrEduCls4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCurrEduCls4Synch.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objCurrEduCls4SynchEN.mId); 
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
 /// <param name = "objCurrEduCls4SynchEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strCondition)
{
 if (objCurrEduCls4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduCls4SynchEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduCls4Synch Set ");
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IpAddress))
 {
 if (objCurrEduCls4SynchEN.IpAddress !=  null)
 {
 var strIpAddress = objCurrEduCls4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IpAddress = '{0}',", strIpAddress); //Ip地址
 }
 else
 {
 sbSQL.Append(" IpAddress = null,"); //Ip地址
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdCurrEduCls))
 {
 if (objCurrEduCls4SynchEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objCurrEduCls4SynchEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CurrEduClsId))
 {
 if (objCurrEduCls4SynchEN.CurrEduClsId !=  null)
 {
 var strCurrEduClsId = objCurrEduCls4SynchEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CurrEduClsId = '{0}',", strCurrEduClsId); //教学班Id
 }
 else
 {
 sbSQL.Append(" CurrEduClsId = null,"); //教学班Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.EduClsName))
 {
 if (objCurrEduCls4SynchEN.EduClsName !=  null)
 {
 var strEduClsName = objCurrEduCls4SynchEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduClsName = '{0}',", strEduClsName); //教学班名
 }
 else
 {
 sbSQL.Append(" EduClsName = null,"); //教学班名
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.EduClsTypeId))
 {
 if (objCurrEduCls4SynchEN.EduClsTypeId !=  null)
 {
 var strEduClsTypeId = objCurrEduCls4SynchEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduClsTypeId = '{0}',", strEduClsTypeId); //教学班类型Id
 }
 else
 {
 sbSQL.Append(" EduClsTypeId = null,"); //教学班类型Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CourseId))
 {
 if (objCurrEduCls4SynchEN.CourseId  ==  "")
 {
 objCurrEduCls4SynchEN.CourseId = null;
 }
 if (objCurrEduCls4SynchEN.CourseId !=  null)
 {
 var strCourseId = objCurrEduCls4SynchEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.TeachingSolutionId))
 {
 if (objCurrEduCls4SynchEN.TeachingSolutionId !=  null)
 {
 var strTeachingSolutionId = objCurrEduCls4SynchEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingSolutionId = '{0}',", strTeachingSolutionId); //教学方案Id
 }
 else
 {
 sbSQL.Append(" TeachingSolutionId = null,"); //教学方案Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdXzCollege))
 {
 if (objCurrEduCls4SynchEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCurrEduCls4SynchEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdEduWay))
 {
 if (objCurrEduCls4SynchEN.IdEduWay  ==  "")
 {
 objCurrEduCls4SynchEN.IdEduWay = null;
 }
 if (objCurrEduCls4SynchEN.IdEduWay !=  null)
 {
 var strIdEduWay = objCurrEduCls4SynchEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEduWay = '{0}',", strIdEduWay); //教学方式流水号
 }
 else
 {
 sbSQL.Append(" IdEduWay = null,"); //教学方式流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdClassRoomType))
 {
 if (objCurrEduCls4SynchEN.IdClassRoomType  ==  "")
 {
 objCurrEduCls4SynchEN.IdClassRoomType = null;
 }
 if (objCurrEduCls4SynchEN.IdClassRoomType !=  null)
 {
 var strIdClassRoomType = objCurrEduCls4SynchEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdClassRoomType = '{0}',", strIdClassRoomType); //教室类型流水号
 }
 else
 {
 sbSQL.Append(" IdClassRoomType = null,"); //教室类型流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.TotalLessonQty))
 {
 if (objCurrEduCls4SynchEN.TotalLessonQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.TotalLessonQty, conCurrEduCls4Synch.TotalLessonQty); //总课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.TotalLessonQty); //总课时数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.MaxStuQty))
 {
 if (objCurrEduCls4SynchEN.MaxStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.MaxStuQty, conCurrEduCls4Synch.MaxStuQty); //最大学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.MaxStuQty); //最大学生数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CurrentStuQty))
 {
 if (objCurrEduCls4SynchEN.CurrentStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.CurrentStuQty, conCurrEduCls4Synch.CurrentStuQty); //当前学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CurrentStuQty); //当前学生数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.WeekQty))
 {
 if (objCurrEduCls4SynchEN.WeekQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.WeekQty, conCurrEduCls4Synch.WeekQty); //总周数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.WeekQty); //总周数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ScheUnitPW))
 {
 if (objCurrEduCls4SynchEN.ScheUnitPW !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.ScheUnitPW, conCurrEduCls4Synch.ScheUnitPW); //周排课次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ScheUnitPW); //周排课次数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.WeekStatusId))
 {
 if (objCurrEduCls4SynchEN.WeekStatusId  ==  "")
 {
 objCurrEduCls4SynchEN.WeekStatusId = null;
 }
 if (objCurrEduCls4SynchEN.WeekStatusId !=  null)
 {
 var strWeekStatusId = objCurrEduCls4SynchEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WeekStatusId = '{0}',", strWeekStatusId); //周状态编号(单,双,全周)
 }
 else
 {
 sbSQL.Append(" WeekStatusId = null,"); //周状态编号(单,双,全周)
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CustomerWeek))
 {
 if (objCurrEduCls4SynchEN.CustomerWeek !=  null)
 {
 var strCustomerWeek = objCurrEduCls4SynchEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CustomerWeek = '{0}',", strCustomerWeek); //自定义上课周
 }
 else
 {
 sbSQL.Append(" CustomerWeek = null,"); //自定义上课周
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsCompleteScore))
 {
 sbSQL.AppendFormat(" IsCompleteScore = '{0}',", objCurrEduCls4SynchEN.IsCompleteScore == true?"1":"0"); //是否成绩齐全
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdExecPlan))
 {
 if (objCurrEduCls4SynchEN.IdExecPlan !=  null)
 {
 var strIdExecPlan = objCurrEduCls4SynchEN.IdExecPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdExecPlan = '{0}',", strIdExecPlan); //执行计划流水号
 }
 else
 {
 sbSQL.Append(" IdExecPlan = null,"); //执行计划流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.LessonQtyPerWeek))
 {
 if (objCurrEduCls4SynchEN.LessonQtyPerWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.LessonQtyPerWeek, conCurrEduCls4Synch.LessonQtyPerWeek); //周课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.LessonQtyPerWeek); //周课时数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Mark))
 {
 if (objCurrEduCls4SynchEN.Mark !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.Mark, conCurrEduCls4Synch.Mark); //获得学分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.Mark); //获得学分
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckClassRoom))
 {
 if (objCurrEduCls4SynchEN.CheckClassRoom !=  null)
 {
 var strCheckClassRoom = objCurrEduCls4SynchEN.CheckClassRoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckClassRoom = '{0}',", strCheckClassRoom); //检查教室结果
 }
 else
 {
 sbSQL.Append(" CheckClassRoom = null,"); //检查教室结果
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckAdminCls))
 {
 if (objCurrEduCls4SynchEN.CheckAdminCls !=  null)
 {
 var strCheckAdminCls = objCurrEduCls4SynchEN.CheckAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckAdminCls = '{0}',", strCheckAdminCls); //检查行政班结果
 }
 else
 {
 sbSQL.Append(" CheckAdminCls = null,"); //检查行政班结果
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckTeacher))
 {
 if (objCurrEduCls4SynchEN.CheckTeacher !=  null)
 {
 var strCheckTeacher = objCurrEduCls4SynchEN.CheckTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckTeacher = '{0}',", strCheckTeacher); //检查教师结果
 }
 else
 {
 sbSQL.Append(" CheckTeacher = null,"); //检查教师结果
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.EditLocked))
 {
 sbSQL.AppendFormat(" EditLocked = '{0}',", objCurrEduCls4SynchEN.EditLocked == true?"1":"0"); //编辑锁定
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Sched))
 {
 sbSQL.AppendFormat(" Sched = '{0}',", objCurrEduCls4SynchEN.Sched == true?"1":"0"); //是否排课
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdUniZone))
 {
 if (objCurrEduCls4SynchEN.IdUniZone  ==  "")
 {
 objCurrEduCls4SynchEN.IdUniZone = null;
 }
 if (objCurrEduCls4SynchEN.IdUniZone !=  null)
 {
 var strIdUniZone = objCurrEduCls4SynchEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdUniZone = '{0}',", strIdUniZone); //校区流水号
 }
 else
 {
 sbSQL.Append(" IdUniZone = null,"); //校区流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Locked))
 {
 sbSQL.AppendFormat(" Locked = '{0}',", objCurrEduCls4SynchEN.Locked == true?"1":"0"); //锁定状态
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdGradeBase))
 {
 if (objCurrEduCls4SynchEN.IdGradeBase  ==  "")
 {
 objCurrEduCls4SynchEN.IdGradeBase = null;
 }
 if (objCurrEduCls4SynchEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objCurrEduCls4SynchEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGradeBase = '{0}',", strIdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGradeBase = null,"); //年级流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsEffective))
 {
 sbSQL.AppendFormat(" IsEffective = '{0}',", objCurrEduCls4SynchEN.IsEffective == true?"1":"0"); //是否有效
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsUnDeterminedClsRm))
 {
 sbSQL.AppendFormat(" IsUnDeterminedClsRm = '{0}',", objCurrEduCls4SynchEN.IsUnDeterminedClsRm == true?"1":"0"); //是否待定教室
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SchoolYear))
 {
 if (objCurrEduCls4SynchEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduCls4SynchEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SchoolTerm))
 {
 if (objCurrEduCls4SynchEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduCls4SynchEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ArrangeCourseMemo))
 {
 if (objCurrEduCls4SynchEN.ArrangeCourseMemo !=  null)
 {
 var strArrangeCourseMemo = objCurrEduCls4SynchEN.ArrangeCourseMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ArrangeCourseMemo = '{0}',", strArrangeCourseMemo); //排课备注
 }
 else
 {
 sbSQL.Append(" ArrangeCourseMemo = null,"); //排课备注
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdCourseType))
 {
 if (objCurrEduCls4SynchEN.IdCourseType !=  null)
 {
 var strIdCourseType = objCurrEduCls4SynchEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCourseType = '{0}',", strIdCourseType); //课程类型流水号
 }
 else
 {
 sbSQL.Append(" IdCourseType = null,"); //课程类型流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ExportDate))
 {
 if (objCurrEduCls4SynchEN.ExportDate !=  null)
 {
 var strExportDate = objCurrEduCls4SynchEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExportDate = '{0}',", strExportDate); //导出日期
 }
 else
 {
 sbSQL.Append(" ExportDate = null,"); //导出日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsDegree))
 {
 sbSQL.AppendFormat(" IsDegree = '{0}',", objCurrEduCls4SynchEN.IsDegree == true?"1":"0"); //是否学位课
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdScoreType))
 {
 if (objCurrEduCls4SynchEN.IdScoreType !=  null)
 {
 var strIdScoreType = objCurrEduCls4SynchEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdScoreType = '{0}',", strIdScoreType); //成绩类型流水号
 }
 else
 {
 sbSQL.Append(" IdScoreType = null,"); //成绩类型流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.GetScoreWayId))
 {
 if (objCurrEduCls4SynchEN.GetScoreWayId !=  null)
 {
 var strGetScoreWayId = objCurrEduCls4SynchEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetScoreWayId = '{0}',", strGetScoreWayId); //获得成绩方式Id
 }
 else
 {
 sbSQL.Append(" GetScoreWayId = null,"); //获得成绩方式Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsProportionalCtrl))
 {
 sbSQL.AppendFormat(" IsProportionalCtrl = '{0}',", objCurrEduCls4SynchEN.IsProportionalCtrl == true?"1":"0"); //是否比例控制
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsSynchToWeb))
 {
 sbSQL.AppendFormat(" IsSynchToWeb = '{0}',", objCurrEduCls4SynchEN.IsSynchToWeb == true?"1":"0"); //是否同步Web
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SynchToWebDate))
 {
 if (objCurrEduCls4SynchEN.SynchToWebDate !=  null)
 {
 var strSynchToWebDate = objCurrEduCls4SynchEN.SynchToWebDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToWebDate = '{0}',", strSynchToWebDate); //同步Web日期
 }
 else
 {
 sbSQL.Append(" SynchToWebDate = null,"); //同步Web日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SynchToWebUser))
 {
 if (objCurrEduCls4SynchEN.SynchToWebUser !=  null)
 {
 var strSynchToWebUser = objCurrEduCls4SynchEN.SynchToWebUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToWebUser = '{0}',", strSynchToWebUser); //同步Web用户
 }
 else
 {
 sbSQL.Append(" SynchToWebUser = null,"); //同步Web用户
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SignInDate))
 {
 if (objCurrEduCls4SynchEN.SignInDate !=  null)
 {
 var strSignInDate = objCurrEduCls4SynchEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInDate = '{0}',", strSignInDate); //签入时间
 }
 else
 {
 sbSQL.Append(" SignInDate = null,"); //签入时间
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SignInStateID))
 {
 if (objCurrEduCls4SynchEN.SignInStateID !=  null)
 {
 var strSignInStateID = objCurrEduCls4SynchEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInStateID = '{0}',", strSignInStateID); //签入状态表流水号
 }
 else
 {
 sbSQL.Append(" SignInStateID = null,"); //签入状态表流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SignInUser))
 {
 if (objCurrEduCls4SynchEN.SignInUser !=  null)
 {
 var strSignInUser = objCurrEduCls4SynchEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInUser = '{0}',", strSignInUser); //签入人
 }
 else
 {
 sbSQL.Append(" SignInUser = null,"); //签入人
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdExamType))
 {
 if (objCurrEduCls4SynchEN.IdExamType !=  null)
 {
 var strIdExamType = objCurrEduCls4SynchEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdExamType = '{0}',", strIdExamType); //考试方式流水号
 }
 else
 {
 sbSQL.Append(" IdExamType = null,"); //考试方式流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ExamPortion))
 {
 if (objCurrEduCls4SynchEN.ExamPortion !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.ExamPortion, conCurrEduCls4Synch.ExamPortion); //平时成绩所占比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ExamPortion); //平时成绩所占比例
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.MidExamScorePortion))
 {
 if (objCurrEduCls4SynchEN.MidExamScorePortion !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.MidExamScorePortion, conCurrEduCls4Synch.MidExamScorePortion); //期末成绩所占比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.MidExamScorePortion); //期末成绩所占比例
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsClearScore))
 {
 sbSQL.AppendFormat(" IsClearScore = '{0}',", objCurrEduCls4SynchEN.IsClearScore == true?"1":"0"); //是否重录成绩
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsGeneratePwd))
 {
 sbSQL.AppendFormat(" IsGeneratePwd = '{0}',", objCurrEduCls4SynchEN.IsGeneratePwd == true?"1":"0"); //是否生成口令
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.GeneratePwdDate))
 {
 if (objCurrEduCls4SynchEN.GeneratePwdDate !=  null)
 {
 var strGeneratePwdDate = objCurrEduCls4SynchEN.GeneratePwdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GeneratePwdDate = '{0}',", strGeneratePwdDate); //生成口令时间
 }
 else
 {
 sbSQL.Append(" GeneratePwdDate = null,"); //生成口令时间
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsExportToGP))
 {
 sbSQL.AppendFormat(" IsExportToGP = '{0}',", objCurrEduCls4SynchEN.IsExportToGP == true?"1":"0"); //是否导出到平台
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsExportToGPWeb))
 {
 sbSQL.AppendFormat(" IsExportToGPWeb = '{0}',", objCurrEduCls4SynchEN.IsExportToGPWeb == true?"1":"0"); //是否导出到Web平台
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsReservedDecimal))
 {
 sbSQL.AppendFormat(" IsReservedDecimal = '{0}',", objCurrEduCls4SynchEN.IsReservedDecimal == true?"1":"0"); //是否保留小数
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ExamTime))
 {
 if (objCurrEduCls4SynchEN.ExamTime !=  null)
 {
 var strExamTime = objCurrEduCls4SynchEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamTime = '{0}',", strExamTime); //考试时间
 }
 else
 {
 sbSQL.Append(" ExamTime = null,"); //考试时间
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckState))
 {
 sbSQL.AppendFormat(" CheckState = '{0}',", objCurrEduCls4SynchEN.CheckState == true?"1":"0"); //检查状态
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckDate))
 {
 if (objCurrEduCls4SynchEN.CheckDate !=  null)
 {
 var strCheckDate = objCurrEduCls4SynchEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckDate = '{0}',", strCheckDate); //检查日期
 }
 else
 {
 sbSQL.Append(" CheckDate = null,"); //检查日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdEduClassInPk))
 {
 if (objCurrEduCls4SynchEN.IdEduClassInPk !=  null)
 {
 var strIdEduClassInPk = objCurrEduCls4SynchEN.IdEduClassInPk.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEduClassInPk = '{0}',", strIdEduClassInPk); //id_EduClassInPk
 }
 else
 {
 sbSQL.Append(" IdEduClassInPk = null,"); //id_EduClassInPk
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.PkWeekTime))
 {
 if (objCurrEduCls4SynchEN.PkWeekTime !=  null)
 {
 var strPkWeekTime = objCurrEduCls4SynchEN.PkWeekTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PkWeekTime = '{0}',", strPkWeekTime); //排课时间
 }
 else
 {
 sbSQL.Append(" PkWeekTime = null,"); //排课时间
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.PkClassRooms))
 {
 if (objCurrEduCls4SynchEN.PkClassRooms !=  null)
 {
 var strPkClassRooms = objCurrEduCls4SynchEN.PkClassRooms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PkClassRooms = '{0}',", strPkClassRooms); //排课教室
 }
 else
 {
 sbSQL.Append(" PkClassRooms = null,"); //排课教室
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.BeginWeek))
 {
 if (objCurrEduCls4SynchEN.BeginWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.BeginWeek, conCurrEduCls4Synch.BeginWeek); //开始周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.BeginWeek); //开始周
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.TeacherNames))
 {
 if (objCurrEduCls4SynchEN.TeacherNames !=  null)
 {
 var strTeacherNames = objCurrEduCls4SynchEN.TeacherNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeacherNames = '{0}',", strTeacherNames); //教师姓名
 }
 else
 {
 sbSQL.Append(" TeacherNames = null,"); //教师姓名
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsAccessSynch))
 {
 sbSQL.AppendFormat(" IsAccessSynch = '{0}',", objCurrEduCls4SynchEN.IsAccessSynch == true?"1":"0"); //是否处理同步
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.AccessSynchDate))
 {
 if (objCurrEduCls4SynchEN.AccessSynchDate !=  null)
 {
 var strAccessSynchDate = objCurrEduCls4SynchEN.AccessSynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AccessSynchDate = '{0}',", strAccessSynchDate); //处理同步日期
 }
 else
 {
 sbSQL.Append(" AccessSynchDate = null,"); //处理同步日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsExistEduClsInCurr))
 {
 sbSQL.AppendFormat(" IsExistEduClsInCurr = '{0}',", objCurrEduCls4SynchEN.IsExistEduClsInCurr == true?"1":"0"); //当前是否存在教学班
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ModifyDate))
 {
 if (objCurrEduCls4SynchEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduCls4SynchEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ModifyUserId))
 {
 if (objCurrEduCls4SynchEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objCurrEduCls4SynchEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Memo))
 {
 if (objCurrEduCls4SynchEN.Memo !=  null)
 {
 var strMemo = objCurrEduCls4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCurrEduCls4SynchEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCurrEduCls4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduCls4SynchEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduCls4Synch Set ");
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IpAddress))
 {
 if (objCurrEduCls4SynchEN.IpAddress !=  null)
 {
 var strIpAddress = objCurrEduCls4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IpAddress = '{0}',", strIpAddress); //Ip地址
 }
 else
 {
 sbSQL.Append(" IpAddress = null,"); //Ip地址
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdCurrEduCls))
 {
 if (objCurrEduCls4SynchEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objCurrEduCls4SynchEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CurrEduClsId))
 {
 if (objCurrEduCls4SynchEN.CurrEduClsId !=  null)
 {
 var strCurrEduClsId = objCurrEduCls4SynchEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CurrEduClsId = '{0}',", strCurrEduClsId); //教学班Id
 }
 else
 {
 sbSQL.Append(" CurrEduClsId = null,"); //教学班Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.EduClsName))
 {
 if (objCurrEduCls4SynchEN.EduClsName !=  null)
 {
 var strEduClsName = objCurrEduCls4SynchEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduClsName = '{0}',", strEduClsName); //教学班名
 }
 else
 {
 sbSQL.Append(" EduClsName = null,"); //教学班名
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.EduClsTypeId))
 {
 if (objCurrEduCls4SynchEN.EduClsTypeId !=  null)
 {
 var strEduClsTypeId = objCurrEduCls4SynchEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduClsTypeId = '{0}',", strEduClsTypeId); //教学班类型Id
 }
 else
 {
 sbSQL.Append(" EduClsTypeId = null,"); //教学班类型Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CourseId))
 {
 if (objCurrEduCls4SynchEN.CourseId  ==  "")
 {
 objCurrEduCls4SynchEN.CourseId = null;
 }
 if (objCurrEduCls4SynchEN.CourseId !=  null)
 {
 var strCourseId = objCurrEduCls4SynchEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.TeachingSolutionId))
 {
 if (objCurrEduCls4SynchEN.TeachingSolutionId !=  null)
 {
 var strTeachingSolutionId = objCurrEduCls4SynchEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingSolutionId = '{0}',", strTeachingSolutionId); //教学方案Id
 }
 else
 {
 sbSQL.Append(" TeachingSolutionId = null,"); //教学方案Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdXzCollege))
 {
 if (objCurrEduCls4SynchEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCurrEduCls4SynchEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdEduWay))
 {
 if (objCurrEduCls4SynchEN.IdEduWay  ==  "")
 {
 objCurrEduCls4SynchEN.IdEduWay = null;
 }
 if (objCurrEduCls4SynchEN.IdEduWay !=  null)
 {
 var strIdEduWay = objCurrEduCls4SynchEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEduWay = '{0}',", strIdEduWay); //教学方式流水号
 }
 else
 {
 sbSQL.Append(" IdEduWay = null,"); //教学方式流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdClassRoomType))
 {
 if (objCurrEduCls4SynchEN.IdClassRoomType  ==  "")
 {
 objCurrEduCls4SynchEN.IdClassRoomType = null;
 }
 if (objCurrEduCls4SynchEN.IdClassRoomType !=  null)
 {
 var strIdClassRoomType = objCurrEduCls4SynchEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdClassRoomType = '{0}',", strIdClassRoomType); //教室类型流水号
 }
 else
 {
 sbSQL.Append(" IdClassRoomType = null,"); //教室类型流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.TotalLessonQty))
 {
 if (objCurrEduCls4SynchEN.TotalLessonQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.TotalLessonQty, conCurrEduCls4Synch.TotalLessonQty); //总课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.TotalLessonQty); //总课时数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.MaxStuQty))
 {
 if (objCurrEduCls4SynchEN.MaxStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.MaxStuQty, conCurrEduCls4Synch.MaxStuQty); //最大学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.MaxStuQty); //最大学生数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CurrentStuQty))
 {
 if (objCurrEduCls4SynchEN.CurrentStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.CurrentStuQty, conCurrEduCls4Synch.CurrentStuQty); //当前学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CurrentStuQty); //当前学生数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.WeekQty))
 {
 if (objCurrEduCls4SynchEN.WeekQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.WeekQty, conCurrEduCls4Synch.WeekQty); //总周数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.WeekQty); //总周数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ScheUnitPW))
 {
 if (objCurrEduCls4SynchEN.ScheUnitPW !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.ScheUnitPW, conCurrEduCls4Synch.ScheUnitPW); //周排课次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ScheUnitPW); //周排课次数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.WeekStatusId))
 {
 if (objCurrEduCls4SynchEN.WeekStatusId  ==  "")
 {
 objCurrEduCls4SynchEN.WeekStatusId = null;
 }
 if (objCurrEduCls4SynchEN.WeekStatusId !=  null)
 {
 var strWeekStatusId = objCurrEduCls4SynchEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WeekStatusId = '{0}',", strWeekStatusId); //周状态编号(单,双,全周)
 }
 else
 {
 sbSQL.Append(" WeekStatusId = null,"); //周状态编号(单,双,全周)
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CustomerWeek))
 {
 if (objCurrEduCls4SynchEN.CustomerWeek !=  null)
 {
 var strCustomerWeek = objCurrEduCls4SynchEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CustomerWeek = '{0}',", strCustomerWeek); //自定义上课周
 }
 else
 {
 sbSQL.Append(" CustomerWeek = null,"); //自定义上课周
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsCompleteScore))
 {
 sbSQL.AppendFormat(" IsCompleteScore = '{0}',", objCurrEduCls4SynchEN.IsCompleteScore == true?"1":"0"); //是否成绩齐全
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdExecPlan))
 {
 if (objCurrEduCls4SynchEN.IdExecPlan !=  null)
 {
 var strIdExecPlan = objCurrEduCls4SynchEN.IdExecPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdExecPlan = '{0}',", strIdExecPlan); //执行计划流水号
 }
 else
 {
 sbSQL.Append(" IdExecPlan = null,"); //执行计划流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.LessonQtyPerWeek))
 {
 if (objCurrEduCls4SynchEN.LessonQtyPerWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.LessonQtyPerWeek, conCurrEduCls4Synch.LessonQtyPerWeek); //周课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.LessonQtyPerWeek); //周课时数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Mark))
 {
 if (objCurrEduCls4SynchEN.Mark !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.Mark, conCurrEduCls4Synch.Mark); //获得学分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.Mark); //获得学分
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckClassRoom))
 {
 if (objCurrEduCls4SynchEN.CheckClassRoom !=  null)
 {
 var strCheckClassRoom = objCurrEduCls4SynchEN.CheckClassRoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckClassRoom = '{0}',", strCheckClassRoom); //检查教室结果
 }
 else
 {
 sbSQL.Append(" CheckClassRoom = null,"); //检查教室结果
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckAdminCls))
 {
 if (objCurrEduCls4SynchEN.CheckAdminCls !=  null)
 {
 var strCheckAdminCls = objCurrEduCls4SynchEN.CheckAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckAdminCls = '{0}',", strCheckAdminCls); //检查行政班结果
 }
 else
 {
 sbSQL.Append(" CheckAdminCls = null,"); //检查行政班结果
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckTeacher))
 {
 if (objCurrEduCls4SynchEN.CheckTeacher !=  null)
 {
 var strCheckTeacher = objCurrEduCls4SynchEN.CheckTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckTeacher = '{0}',", strCheckTeacher); //检查教师结果
 }
 else
 {
 sbSQL.Append(" CheckTeacher = null,"); //检查教师结果
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.EditLocked))
 {
 sbSQL.AppendFormat(" EditLocked = '{0}',", objCurrEduCls4SynchEN.EditLocked == true?"1":"0"); //编辑锁定
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Sched))
 {
 sbSQL.AppendFormat(" Sched = '{0}',", objCurrEduCls4SynchEN.Sched == true?"1":"0"); //是否排课
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdUniZone))
 {
 if (objCurrEduCls4SynchEN.IdUniZone  ==  "")
 {
 objCurrEduCls4SynchEN.IdUniZone = null;
 }
 if (objCurrEduCls4SynchEN.IdUniZone !=  null)
 {
 var strIdUniZone = objCurrEduCls4SynchEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdUniZone = '{0}',", strIdUniZone); //校区流水号
 }
 else
 {
 sbSQL.Append(" IdUniZone = null,"); //校区流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Locked))
 {
 sbSQL.AppendFormat(" Locked = '{0}',", objCurrEduCls4SynchEN.Locked == true?"1":"0"); //锁定状态
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdGradeBase))
 {
 if (objCurrEduCls4SynchEN.IdGradeBase  ==  "")
 {
 objCurrEduCls4SynchEN.IdGradeBase = null;
 }
 if (objCurrEduCls4SynchEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objCurrEduCls4SynchEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGradeBase = '{0}',", strIdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGradeBase = null,"); //年级流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsEffective))
 {
 sbSQL.AppendFormat(" IsEffective = '{0}',", objCurrEduCls4SynchEN.IsEffective == true?"1":"0"); //是否有效
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsUnDeterminedClsRm))
 {
 sbSQL.AppendFormat(" IsUnDeterminedClsRm = '{0}',", objCurrEduCls4SynchEN.IsUnDeterminedClsRm == true?"1":"0"); //是否待定教室
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SchoolYear))
 {
 if (objCurrEduCls4SynchEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduCls4SynchEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SchoolTerm))
 {
 if (objCurrEduCls4SynchEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduCls4SynchEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ArrangeCourseMemo))
 {
 if (objCurrEduCls4SynchEN.ArrangeCourseMemo !=  null)
 {
 var strArrangeCourseMemo = objCurrEduCls4SynchEN.ArrangeCourseMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ArrangeCourseMemo = '{0}',", strArrangeCourseMemo); //排课备注
 }
 else
 {
 sbSQL.Append(" ArrangeCourseMemo = null,"); //排课备注
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdCourseType))
 {
 if (objCurrEduCls4SynchEN.IdCourseType !=  null)
 {
 var strIdCourseType = objCurrEduCls4SynchEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCourseType = '{0}',", strIdCourseType); //课程类型流水号
 }
 else
 {
 sbSQL.Append(" IdCourseType = null,"); //课程类型流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ExportDate))
 {
 if (objCurrEduCls4SynchEN.ExportDate !=  null)
 {
 var strExportDate = objCurrEduCls4SynchEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExportDate = '{0}',", strExportDate); //导出日期
 }
 else
 {
 sbSQL.Append(" ExportDate = null,"); //导出日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsDegree))
 {
 sbSQL.AppendFormat(" IsDegree = '{0}',", objCurrEduCls4SynchEN.IsDegree == true?"1":"0"); //是否学位课
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdScoreType))
 {
 if (objCurrEduCls4SynchEN.IdScoreType !=  null)
 {
 var strIdScoreType = objCurrEduCls4SynchEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdScoreType = '{0}',", strIdScoreType); //成绩类型流水号
 }
 else
 {
 sbSQL.Append(" IdScoreType = null,"); //成绩类型流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.GetScoreWayId))
 {
 if (objCurrEduCls4SynchEN.GetScoreWayId !=  null)
 {
 var strGetScoreWayId = objCurrEduCls4SynchEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetScoreWayId = '{0}',", strGetScoreWayId); //获得成绩方式Id
 }
 else
 {
 sbSQL.Append(" GetScoreWayId = null,"); //获得成绩方式Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsProportionalCtrl))
 {
 sbSQL.AppendFormat(" IsProportionalCtrl = '{0}',", objCurrEduCls4SynchEN.IsProportionalCtrl == true?"1":"0"); //是否比例控制
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsSynchToWeb))
 {
 sbSQL.AppendFormat(" IsSynchToWeb = '{0}',", objCurrEduCls4SynchEN.IsSynchToWeb == true?"1":"0"); //是否同步Web
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SynchToWebDate))
 {
 if (objCurrEduCls4SynchEN.SynchToWebDate !=  null)
 {
 var strSynchToWebDate = objCurrEduCls4SynchEN.SynchToWebDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToWebDate = '{0}',", strSynchToWebDate); //同步Web日期
 }
 else
 {
 sbSQL.Append(" SynchToWebDate = null,"); //同步Web日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SynchToWebUser))
 {
 if (objCurrEduCls4SynchEN.SynchToWebUser !=  null)
 {
 var strSynchToWebUser = objCurrEduCls4SynchEN.SynchToWebUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToWebUser = '{0}',", strSynchToWebUser); //同步Web用户
 }
 else
 {
 sbSQL.Append(" SynchToWebUser = null,"); //同步Web用户
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SignInDate))
 {
 if (objCurrEduCls4SynchEN.SignInDate !=  null)
 {
 var strSignInDate = objCurrEduCls4SynchEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInDate = '{0}',", strSignInDate); //签入时间
 }
 else
 {
 sbSQL.Append(" SignInDate = null,"); //签入时间
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SignInStateID))
 {
 if (objCurrEduCls4SynchEN.SignInStateID !=  null)
 {
 var strSignInStateID = objCurrEduCls4SynchEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInStateID = '{0}',", strSignInStateID); //签入状态表流水号
 }
 else
 {
 sbSQL.Append(" SignInStateID = null,"); //签入状态表流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SignInUser))
 {
 if (objCurrEduCls4SynchEN.SignInUser !=  null)
 {
 var strSignInUser = objCurrEduCls4SynchEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInUser = '{0}',", strSignInUser); //签入人
 }
 else
 {
 sbSQL.Append(" SignInUser = null,"); //签入人
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdExamType))
 {
 if (objCurrEduCls4SynchEN.IdExamType !=  null)
 {
 var strIdExamType = objCurrEduCls4SynchEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdExamType = '{0}',", strIdExamType); //考试方式流水号
 }
 else
 {
 sbSQL.Append(" IdExamType = null,"); //考试方式流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ExamPortion))
 {
 if (objCurrEduCls4SynchEN.ExamPortion !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.ExamPortion, conCurrEduCls4Synch.ExamPortion); //平时成绩所占比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ExamPortion); //平时成绩所占比例
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.MidExamScorePortion))
 {
 if (objCurrEduCls4SynchEN.MidExamScorePortion !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.MidExamScorePortion, conCurrEduCls4Synch.MidExamScorePortion); //期末成绩所占比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.MidExamScorePortion); //期末成绩所占比例
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsClearScore))
 {
 sbSQL.AppendFormat(" IsClearScore = '{0}',", objCurrEduCls4SynchEN.IsClearScore == true?"1":"0"); //是否重录成绩
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsGeneratePwd))
 {
 sbSQL.AppendFormat(" IsGeneratePwd = '{0}',", objCurrEduCls4SynchEN.IsGeneratePwd == true?"1":"0"); //是否生成口令
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.GeneratePwdDate))
 {
 if (objCurrEduCls4SynchEN.GeneratePwdDate !=  null)
 {
 var strGeneratePwdDate = objCurrEduCls4SynchEN.GeneratePwdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GeneratePwdDate = '{0}',", strGeneratePwdDate); //生成口令时间
 }
 else
 {
 sbSQL.Append(" GeneratePwdDate = null,"); //生成口令时间
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsExportToGP))
 {
 sbSQL.AppendFormat(" IsExportToGP = '{0}',", objCurrEduCls4SynchEN.IsExportToGP == true?"1":"0"); //是否导出到平台
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsExportToGPWeb))
 {
 sbSQL.AppendFormat(" IsExportToGPWeb = '{0}',", objCurrEduCls4SynchEN.IsExportToGPWeb == true?"1":"0"); //是否导出到Web平台
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsReservedDecimal))
 {
 sbSQL.AppendFormat(" IsReservedDecimal = '{0}',", objCurrEduCls4SynchEN.IsReservedDecimal == true?"1":"0"); //是否保留小数
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ExamTime))
 {
 if (objCurrEduCls4SynchEN.ExamTime !=  null)
 {
 var strExamTime = objCurrEduCls4SynchEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamTime = '{0}',", strExamTime); //考试时间
 }
 else
 {
 sbSQL.Append(" ExamTime = null,"); //考试时间
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckState))
 {
 sbSQL.AppendFormat(" CheckState = '{0}',", objCurrEduCls4SynchEN.CheckState == true?"1":"0"); //检查状态
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckDate))
 {
 if (objCurrEduCls4SynchEN.CheckDate !=  null)
 {
 var strCheckDate = objCurrEduCls4SynchEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckDate = '{0}',", strCheckDate); //检查日期
 }
 else
 {
 sbSQL.Append(" CheckDate = null,"); //检查日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdEduClassInPk))
 {
 if (objCurrEduCls4SynchEN.IdEduClassInPk !=  null)
 {
 var strIdEduClassInPk = objCurrEduCls4SynchEN.IdEduClassInPk.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEduClassInPk = '{0}',", strIdEduClassInPk); //id_EduClassInPk
 }
 else
 {
 sbSQL.Append(" IdEduClassInPk = null,"); //id_EduClassInPk
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.PkWeekTime))
 {
 if (objCurrEduCls4SynchEN.PkWeekTime !=  null)
 {
 var strPkWeekTime = objCurrEduCls4SynchEN.PkWeekTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PkWeekTime = '{0}',", strPkWeekTime); //排课时间
 }
 else
 {
 sbSQL.Append(" PkWeekTime = null,"); //排课时间
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.PkClassRooms))
 {
 if (objCurrEduCls4SynchEN.PkClassRooms !=  null)
 {
 var strPkClassRooms = objCurrEduCls4SynchEN.PkClassRooms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PkClassRooms = '{0}',", strPkClassRooms); //排课教室
 }
 else
 {
 sbSQL.Append(" PkClassRooms = null,"); //排课教室
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.BeginWeek))
 {
 if (objCurrEduCls4SynchEN.BeginWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.BeginWeek, conCurrEduCls4Synch.BeginWeek); //开始周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.BeginWeek); //开始周
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.TeacherNames))
 {
 if (objCurrEduCls4SynchEN.TeacherNames !=  null)
 {
 var strTeacherNames = objCurrEduCls4SynchEN.TeacherNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeacherNames = '{0}',", strTeacherNames); //教师姓名
 }
 else
 {
 sbSQL.Append(" TeacherNames = null,"); //教师姓名
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsAccessSynch))
 {
 sbSQL.AppendFormat(" IsAccessSynch = '{0}',", objCurrEduCls4SynchEN.IsAccessSynch == true?"1":"0"); //是否处理同步
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.AccessSynchDate))
 {
 if (objCurrEduCls4SynchEN.AccessSynchDate !=  null)
 {
 var strAccessSynchDate = objCurrEduCls4SynchEN.AccessSynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AccessSynchDate = '{0}',", strAccessSynchDate); //处理同步日期
 }
 else
 {
 sbSQL.Append(" AccessSynchDate = null,"); //处理同步日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsExistEduClsInCurr))
 {
 sbSQL.AppendFormat(" IsExistEduClsInCurr = '{0}',", objCurrEduCls4SynchEN.IsExistEduClsInCurr == true?"1":"0"); //当前是否存在教学班
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ModifyDate))
 {
 if (objCurrEduCls4SynchEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduCls4SynchEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ModifyUserId))
 {
 if (objCurrEduCls4SynchEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objCurrEduCls4SynchEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Memo))
 {
 if (objCurrEduCls4SynchEN.Memo !=  null)
 {
 var strMemo = objCurrEduCls4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCurrEduCls4SynchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCurrEduCls4SynchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduCls4SynchEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduCls4Synch Set ");
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IpAddress))
 {
 if (objCurrEduCls4SynchEN.IpAddress !=  null)
 {
 var strIpAddress = objCurrEduCls4SynchEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIpAddress, conCurrEduCls4Synch.IpAddress); //Ip地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IpAddress); //Ip地址
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdCurrEduCls))
 {
 if (objCurrEduCls4SynchEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objCurrEduCls4SynchEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conCurrEduCls4Synch.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CurrEduClsId))
 {
 if (objCurrEduCls4SynchEN.CurrEduClsId !=  null)
 {
 var strCurrEduClsId = objCurrEduCls4SynchEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCurrEduClsId, conCurrEduCls4Synch.CurrEduClsId); //教学班Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CurrEduClsId); //教学班Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.EduClsName))
 {
 if (objCurrEduCls4SynchEN.EduClsName !=  null)
 {
 var strEduClsName = objCurrEduCls4SynchEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduClsName, conCurrEduCls4Synch.EduClsName); //教学班名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.EduClsName); //教学班名
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.EduClsTypeId))
 {
 if (objCurrEduCls4SynchEN.EduClsTypeId !=  null)
 {
 var strEduClsTypeId = objCurrEduCls4SynchEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduClsTypeId, conCurrEduCls4Synch.EduClsTypeId); //教学班类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.EduClsTypeId); //教学班类型Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CourseId))
 {
 if (objCurrEduCls4SynchEN.CourseId  ==  "")
 {
 objCurrEduCls4SynchEN.CourseId = null;
 }
 if (objCurrEduCls4SynchEN.CourseId !=  null)
 {
 var strCourseId = objCurrEduCls4SynchEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conCurrEduCls4Synch.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CourseId); //课程Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.TeachingSolutionId))
 {
 if (objCurrEduCls4SynchEN.TeachingSolutionId !=  null)
 {
 var strTeachingSolutionId = objCurrEduCls4SynchEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingSolutionId, conCurrEduCls4Synch.TeachingSolutionId); //教学方案Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.TeachingSolutionId); //教学方案Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdXzCollege))
 {
 if (objCurrEduCls4SynchEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCurrEduCls4SynchEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conCurrEduCls4Synch.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdXzCollege); //学院流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdEduWay))
 {
 if (objCurrEduCls4SynchEN.IdEduWay  ==  "")
 {
 objCurrEduCls4SynchEN.IdEduWay = null;
 }
 if (objCurrEduCls4SynchEN.IdEduWay !=  null)
 {
 var strIdEduWay = objCurrEduCls4SynchEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEduWay, conCurrEduCls4Synch.IdEduWay); //教学方式流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdEduWay); //教学方式流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdClassRoomType))
 {
 if (objCurrEduCls4SynchEN.IdClassRoomType  ==  "")
 {
 objCurrEduCls4SynchEN.IdClassRoomType = null;
 }
 if (objCurrEduCls4SynchEN.IdClassRoomType !=  null)
 {
 var strIdClassRoomType = objCurrEduCls4SynchEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdClassRoomType, conCurrEduCls4Synch.IdClassRoomType); //教室类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdClassRoomType); //教室类型流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.TotalLessonQty))
 {
 if (objCurrEduCls4SynchEN.TotalLessonQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.TotalLessonQty, conCurrEduCls4Synch.TotalLessonQty); //总课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.TotalLessonQty); //总课时数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.MaxStuQty))
 {
 if (objCurrEduCls4SynchEN.MaxStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.MaxStuQty, conCurrEduCls4Synch.MaxStuQty); //最大学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.MaxStuQty); //最大学生数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CurrentStuQty))
 {
 if (objCurrEduCls4SynchEN.CurrentStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.CurrentStuQty, conCurrEduCls4Synch.CurrentStuQty); //当前学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CurrentStuQty); //当前学生数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.WeekQty))
 {
 if (objCurrEduCls4SynchEN.WeekQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.WeekQty, conCurrEduCls4Synch.WeekQty); //总周数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.WeekQty); //总周数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ScheUnitPW))
 {
 if (objCurrEduCls4SynchEN.ScheUnitPW !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.ScheUnitPW, conCurrEduCls4Synch.ScheUnitPW); //周排课次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ScheUnitPW); //周排课次数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.WeekStatusId))
 {
 if (objCurrEduCls4SynchEN.WeekStatusId  ==  "")
 {
 objCurrEduCls4SynchEN.WeekStatusId = null;
 }
 if (objCurrEduCls4SynchEN.WeekStatusId !=  null)
 {
 var strWeekStatusId = objCurrEduCls4SynchEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWeekStatusId, conCurrEduCls4Synch.WeekStatusId); //周状态编号(单,双,全周)
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.WeekStatusId); //周状态编号(单,双,全周)
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CustomerWeek))
 {
 if (objCurrEduCls4SynchEN.CustomerWeek !=  null)
 {
 var strCustomerWeek = objCurrEduCls4SynchEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCustomerWeek, conCurrEduCls4Synch.CustomerWeek); //自定义上课周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CustomerWeek); //自定义上课周
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsCompleteScore))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsCompleteScore == true?"1":"0", conCurrEduCls4Synch.IsCompleteScore); //是否成绩齐全
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdExecPlan))
 {
 if (objCurrEduCls4SynchEN.IdExecPlan !=  null)
 {
 var strIdExecPlan = objCurrEduCls4SynchEN.IdExecPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdExecPlan, conCurrEduCls4Synch.IdExecPlan); //执行计划流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdExecPlan); //执行计划流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.LessonQtyPerWeek))
 {
 if (objCurrEduCls4SynchEN.LessonQtyPerWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.LessonQtyPerWeek, conCurrEduCls4Synch.LessonQtyPerWeek); //周课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.LessonQtyPerWeek); //周课时数
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Mark))
 {
 if (objCurrEduCls4SynchEN.Mark !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.Mark, conCurrEduCls4Synch.Mark); //获得学分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.Mark); //获得学分
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckClassRoom))
 {
 if (objCurrEduCls4SynchEN.CheckClassRoom !=  null)
 {
 var strCheckClassRoom = objCurrEduCls4SynchEN.CheckClassRoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckClassRoom, conCurrEduCls4Synch.CheckClassRoom); //检查教室结果
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CheckClassRoom); //检查教室结果
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckAdminCls))
 {
 if (objCurrEduCls4SynchEN.CheckAdminCls !=  null)
 {
 var strCheckAdminCls = objCurrEduCls4SynchEN.CheckAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckAdminCls, conCurrEduCls4Synch.CheckAdminCls); //检查行政班结果
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CheckAdminCls); //检查行政班结果
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckTeacher))
 {
 if (objCurrEduCls4SynchEN.CheckTeacher !=  null)
 {
 var strCheckTeacher = objCurrEduCls4SynchEN.CheckTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckTeacher, conCurrEduCls4Synch.CheckTeacher); //检查教师结果
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CheckTeacher); //检查教师结果
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.EditLocked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.EditLocked == true?"1":"0", conCurrEduCls4Synch.EditLocked); //编辑锁定
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Sched))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.Sched == true?"1":"0", conCurrEduCls4Synch.Sched); //是否排课
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdUniZone))
 {
 if (objCurrEduCls4SynchEN.IdUniZone  ==  "")
 {
 objCurrEduCls4SynchEN.IdUniZone = null;
 }
 if (objCurrEduCls4SynchEN.IdUniZone !=  null)
 {
 var strIdUniZone = objCurrEduCls4SynchEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdUniZone, conCurrEduCls4Synch.IdUniZone); //校区流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdUniZone); //校区流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Locked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.Locked == true?"1":"0", conCurrEduCls4Synch.Locked); //锁定状态
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdGradeBase))
 {
 if (objCurrEduCls4SynchEN.IdGradeBase  ==  "")
 {
 objCurrEduCls4SynchEN.IdGradeBase = null;
 }
 if (objCurrEduCls4SynchEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objCurrEduCls4SynchEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGradeBase, conCurrEduCls4Synch.IdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdGradeBase); //年级流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsEffective))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsEffective == true?"1":"0", conCurrEduCls4Synch.IsEffective); //是否有效
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsUnDeterminedClsRm))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsUnDeterminedClsRm == true?"1":"0", conCurrEduCls4Synch.IsUnDeterminedClsRm); //是否待定教室
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SchoolYear))
 {
 if (objCurrEduCls4SynchEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduCls4SynchEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conCurrEduCls4Synch.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.SchoolYear); //学年
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SchoolTerm))
 {
 if (objCurrEduCls4SynchEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduCls4SynchEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conCurrEduCls4Synch.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.SchoolTerm); //学期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ArrangeCourseMemo))
 {
 if (objCurrEduCls4SynchEN.ArrangeCourseMemo !=  null)
 {
 var strArrangeCourseMemo = objCurrEduCls4SynchEN.ArrangeCourseMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strArrangeCourseMemo, conCurrEduCls4Synch.ArrangeCourseMemo); //排课备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ArrangeCourseMemo); //排课备注
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdCourseType))
 {
 if (objCurrEduCls4SynchEN.IdCourseType !=  null)
 {
 var strIdCourseType = objCurrEduCls4SynchEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCourseType, conCurrEduCls4Synch.IdCourseType); //课程类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdCourseType); //课程类型流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ExportDate))
 {
 if (objCurrEduCls4SynchEN.ExportDate !=  null)
 {
 var strExportDate = objCurrEduCls4SynchEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExportDate, conCurrEduCls4Synch.ExportDate); //导出日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ExportDate); //导出日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsDegree))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsDegree == true?"1":"0", conCurrEduCls4Synch.IsDegree); //是否学位课
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdScoreType))
 {
 if (objCurrEduCls4SynchEN.IdScoreType !=  null)
 {
 var strIdScoreType = objCurrEduCls4SynchEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdScoreType, conCurrEduCls4Synch.IdScoreType); //成绩类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdScoreType); //成绩类型流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.GetScoreWayId))
 {
 if (objCurrEduCls4SynchEN.GetScoreWayId !=  null)
 {
 var strGetScoreWayId = objCurrEduCls4SynchEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetScoreWayId, conCurrEduCls4Synch.GetScoreWayId); //获得成绩方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.GetScoreWayId); //获得成绩方式Id
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsProportionalCtrl))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsProportionalCtrl == true?"1":"0", conCurrEduCls4Synch.IsProportionalCtrl); //是否比例控制
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsSynchToWeb))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsSynchToWeb == true?"1":"0", conCurrEduCls4Synch.IsSynchToWeb); //是否同步Web
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SynchToWebDate))
 {
 if (objCurrEduCls4SynchEN.SynchToWebDate !=  null)
 {
 var strSynchToWebDate = objCurrEduCls4SynchEN.SynchToWebDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToWebDate, conCurrEduCls4Synch.SynchToWebDate); //同步Web日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.SynchToWebDate); //同步Web日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SynchToWebUser))
 {
 if (objCurrEduCls4SynchEN.SynchToWebUser !=  null)
 {
 var strSynchToWebUser = objCurrEduCls4SynchEN.SynchToWebUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToWebUser, conCurrEduCls4Synch.SynchToWebUser); //同步Web用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.SynchToWebUser); //同步Web用户
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SignInDate))
 {
 if (objCurrEduCls4SynchEN.SignInDate !=  null)
 {
 var strSignInDate = objCurrEduCls4SynchEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInDate, conCurrEduCls4Synch.SignInDate); //签入时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.SignInDate); //签入时间
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SignInStateID))
 {
 if (objCurrEduCls4SynchEN.SignInStateID !=  null)
 {
 var strSignInStateID = objCurrEduCls4SynchEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInStateID, conCurrEduCls4Synch.SignInStateID); //签入状态表流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.SignInStateID); //签入状态表流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.SignInUser))
 {
 if (objCurrEduCls4SynchEN.SignInUser !=  null)
 {
 var strSignInUser = objCurrEduCls4SynchEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInUser, conCurrEduCls4Synch.SignInUser); //签入人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.SignInUser); //签入人
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdExamType))
 {
 if (objCurrEduCls4SynchEN.IdExamType !=  null)
 {
 var strIdExamType = objCurrEduCls4SynchEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdExamType, conCurrEduCls4Synch.IdExamType); //考试方式流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdExamType); //考试方式流水号
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ExamPortion))
 {
 if (objCurrEduCls4SynchEN.ExamPortion !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.ExamPortion, conCurrEduCls4Synch.ExamPortion); //平时成绩所占比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ExamPortion); //平时成绩所占比例
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.MidExamScorePortion))
 {
 if (objCurrEduCls4SynchEN.MidExamScorePortion !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.MidExamScorePortion, conCurrEduCls4Synch.MidExamScorePortion); //期末成绩所占比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.MidExamScorePortion); //期末成绩所占比例
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsClearScore))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsClearScore == true?"1":"0", conCurrEduCls4Synch.IsClearScore); //是否重录成绩
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsGeneratePwd))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsGeneratePwd == true?"1":"0", conCurrEduCls4Synch.IsGeneratePwd); //是否生成口令
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.GeneratePwdDate))
 {
 if (objCurrEduCls4SynchEN.GeneratePwdDate !=  null)
 {
 var strGeneratePwdDate = objCurrEduCls4SynchEN.GeneratePwdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGeneratePwdDate, conCurrEduCls4Synch.GeneratePwdDate); //生成口令时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.GeneratePwdDate); //生成口令时间
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsExportToGP))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsExportToGP == true?"1":"0", conCurrEduCls4Synch.IsExportToGP); //是否导出到平台
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsExportToGPWeb))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsExportToGPWeb == true?"1":"0", conCurrEduCls4Synch.IsExportToGPWeb); //是否导出到Web平台
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsReservedDecimal))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsReservedDecimal == true?"1":"0", conCurrEduCls4Synch.IsReservedDecimal); //是否保留小数
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ExamTime))
 {
 if (objCurrEduCls4SynchEN.ExamTime !=  null)
 {
 var strExamTime = objCurrEduCls4SynchEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamTime, conCurrEduCls4Synch.ExamTime); //考试时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ExamTime); //考试时间
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckState))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.CheckState == true?"1":"0", conCurrEduCls4Synch.CheckState); //检查状态
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.CheckDate))
 {
 if (objCurrEduCls4SynchEN.CheckDate !=  null)
 {
 var strCheckDate = objCurrEduCls4SynchEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckDate, conCurrEduCls4Synch.CheckDate); //检查日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.CheckDate); //检查日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IdEduClassInPk))
 {
 if (objCurrEduCls4SynchEN.IdEduClassInPk !=  null)
 {
 var strIdEduClassInPk = objCurrEduCls4SynchEN.IdEduClassInPk.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEduClassInPk, conCurrEduCls4Synch.IdEduClassInPk); //id_EduClassInPk
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.IdEduClassInPk); //id_EduClassInPk
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.PkWeekTime))
 {
 if (objCurrEduCls4SynchEN.PkWeekTime !=  null)
 {
 var strPkWeekTime = objCurrEduCls4SynchEN.PkWeekTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPkWeekTime, conCurrEduCls4Synch.PkWeekTime); //排课时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.PkWeekTime); //排课时间
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.PkClassRooms))
 {
 if (objCurrEduCls4SynchEN.PkClassRooms !=  null)
 {
 var strPkClassRooms = objCurrEduCls4SynchEN.PkClassRooms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPkClassRooms, conCurrEduCls4Synch.PkClassRooms); //排课教室
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.PkClassRooms); //排课教室
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.BeginWeek))
 {
 if (objCurrEduCls4SynchEN.BeginWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls4SynchEN.BeginWeek, conCurrEduCls4Synch.BeginWeek); //开始周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.BeginWeek); //开始周
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.TeacherNames))
 {
 if (objCurrEduCls4SynchEN.TeacherNames !=  null)
 {
 var strTeacherNames = objCurrEduCls4SynchEN.TeacherNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeacherNames, conCurrEduCls4Synch.TeacherNames); //教师姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.TeacherNames); //教师姓名
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsAccessSynch))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsAccessSynch == true?"1":"0", conCurrEduCls4Synch.IsAccessSynch); //是否处理同步
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.AccessSynchDate))
 {
 if (objCurrEduCls4SynchEN.AccessSynchDate !=  null)
 {
 var strAccessSynchDate = objCurrEduCls4SynchEN.AccessSynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAccessSynchDate, conCurrEduCls4Synch.AccessSynchDate); //处理同步日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.AccessSynchDate); //处理同步日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.IsExistEduClsInCurr))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls4SynchEN.IsExistEduClsInCurr == true?"1":"0", conCurrEduCls4Synch.IsExistEduClsInCurr); //当前是否存在教学班
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ModifyDate))
 {
 if (objCurrEduCls4SynchEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduCls4SynchEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conCurrEduCls4Synch.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ModifyDate); //修改日期
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.ModifyUserId))
 {
 if (objCurrEduCls4SynchEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objCurrEduCls4SynchEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conCurrEduCls4Synch.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.ModifyUserId); //修改人
 }
 }
 
 if (objCurrEduCls4SynchEN.IsUpdated(conCurrEduCls4Synch.Memo))
 {
 if (objCurrEduCls4SynchEN.Memo !=  null)
 {
 var strMemo = objCurrEduCls4SynchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCurrEduCls4Synch.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls4Synch.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objCurrEduCls4SynchEN.mId); 
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
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("CurrEduCls4Synch_Delete", values);
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
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
//删除CurrEduCls4Synch本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduCls4Synch where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCurrEduCls4Synch(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
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
//删除CurrEduCls4Synch本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduCls4Synch where mId in (" + strKeyList + ")";
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
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
//删除CurrEduCls4Synch本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduCls4Synch where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCurrEduCls4Synch(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCurrEduCls4SynchDA: DelCurrEduCls4Synch)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CurrEduCls4Synch where " + strCondition ;
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
public bool DelCurrEduCls4SynchWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCurrEduCls4SynchDA: DelCurrEduCls4SynchWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CurrEduCls4Synch where " + strCondition ;
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
 /// <param name = "objCurrEduCls4SynchENS">源对象</param>
 /// <param name = "objCurrEduCls4SynchENT">目标对象</param>
public void CopyTo(clsCurrEduCls4SynchEN objCurrEduCls4SynchENS, clsCurrEduCls4SynchEN objCurrEduCls4SynchENT)
{
objCurrEduCls4SynchENT.mId = objCurrEduCls4SynchENS.mId; //mId
objCurrEduCls4SynchENT.IpAddress = objCurrEduCls4SynchENS.IpAddress; //Ip地址
objCurrEduCls4SynchENT.IdCurrEduCls = objCurrEduCls4SynchENS.IdCurrEduCls; //教学班流水号
objCurrEduCls4SynchENT.CurrEduClsId = objCurrEduCls4SynchENS.CurrEduClsId; //教学班Id
objCurrEduCls4SynchENT.EduClsName = objCurrEduCls4SynchENS.EduClsName; //教学班名
objCurrEduCls4SynchENT.EduClsTypeId = objCurrEduCls4SynchENS.EduClsTypeId; //教学班类型Id
objCurrEduCls4SynchENT.CourseId = objCurrEduCls4SynchENS.CourseId; //课程Id
objCurrEduCls4SynchENT.TeachingSolutionId = objCurrEduCls4SynchENS.TeachingSolutionId; //教学方案Id
objCurrEduCls4SynchENT.IdXzCollege = objCurrEduCls4SynchENS.IdXzCollege; //学院流水号
objCurrEduCls4SynchENT.IdEduWay = objCurrEduCls4SynchENS.IdEduWay; //教学方式流水号
objCurrEduCls4SynchENT.IdClassRoomType = objCurrEduCls4SynchENS.IdClassRoomType; //教室类型流水号
objCurrEduCls4SynchENT.TotalLessonQty = objCurrEduCls4SynchENS.TotalLessonQty; //总课时数
objCurrEduCls4SynchENT.MaxStuQty = objCurrEduCls4SynchENS.MaxStuQty; //最大学生数
objCurrEduCls4SynchENT.CurrentStuQty = objCurrEduCls4SynchENS.CurrentStuQty; //当前学生数
objCurrEduCls4SynchENT.WeekQty = objCurrEduCls4SynchENS.WeekQty; //总周数
objCurrEduCls4SynchENT.ScheUnitPW = objCurrEduCls4SynchENS.ScheUnitPW; //周排课次数
objCurrEduCls4SynchENT.WeekStatusId = objCurrEduCls4SynchENS.WeekStatusId; //周状态编号(单,双,全周)
objCurrEduCls4SynchENT.CustomerWeek = objCurrEduCls4SynchENS.CustomerWeek; //自定义上课周
objCurrEduCls4SynchENT.IsCompleteScore = objCurrEduCls4SynchENS.IsCompleteScore; //是否成绩齐全
objCurrEduCls4SynchENT.IdExecPlan = objCurrEduCls4SynchENS.IdExecPlan; //执行计划流水号
objCurrEduCls4SynchENT.LessonQtyPerWeek = objCurrEduCls4SynchENS.LessonQtyPerWeek; //周课时数
objCurrEduCls4SynchENT.Mark = objCurrEduCls4SynchENS.Mark; //获得学分
objCurrEduCls4SynchENT.CheckClassRoom = objCurrEduCls4SynchENS.CheckClassRoom; //检查教室结果
objCurrEduCls4SynchENT.CheckAdminCls = objCurrEduCls4SynchENS.CheckAdminCls; //检查行政班结果
objCurrEduCls4SynchENT.CheckTeacher = objCurrEduCls4SynchENS.CheckTeacher; //检查教师结果
objCurrEduCls4SynchENT.EditLocked = objCurrEduCls4SynchENS.EditLocked; //编辑锁定
objCurrEduCls4SynchENT.Sched = objCurrEduCls4SynchENS.Sched; //是否排课
objCurrEduCls4SynchENT.IdUniZone = objCurrEduCls4SynchENS.IdUniZone; //校区流水号
objCurrEduCls4SynchENT.Locked = objCurrEduCls4SynchENS.Locked; //锁定状态
objCurrEduCls4SynchENT.IdGradeBase = objCurrEduCls4SynchENS.IdGradeBase; //年级流水号
objCurrEduCls4SynchENT.IsEffective = objCurrEduCls4SynchENS.IsEffective; //是否有效
objCurrEduCls4SynchENT.IsUnDeterminedClsRm = objCurrEduCls4SynchENS.IsUnDeterminedClsRm; //是否待定教室
objCurrEduCls4SynchENT.SchoolYear = objCurrEduCls4SynchENS.SchoolYear; //学年
objCurrEduCls4SynchENT.SchoolTerm = objCurrEduCls4SynchENS.SchoolTerm; //学期
objCurrEduCls4SynchENT.ArrangeCourseMemo = objCurrEduCls4SynchENS.ArrangeCourseMemo; //排课备注
objCurrEduCls4SynchENT.IdCourseType = objCurrEduCls4SynchENS.IdCourseType; //课程类型流水号
objCurrEduCls4SynchENT.ExportDate = objCurrEduCls4SynchENS.ExportDate; //导出日期
objCurrEduCls4SynchENT.IsDegree = objCurrEduCls4SynchENS.IsDegree; //是否学位课
objCurrEduCls4SynchENT.IdScoreType = objCurrEduCls4SynchENS.IdScoreType; //成绩类型流水号
objCurrEduCls4SynchENT.GetScoreWayId = objCurrEduCls4SynchENS.GetScoreWayId; //获得成绩方式Id
objCurrEduCls4SynchENT.IsProportionalCtrl = objCurrEduCls4SynchENS.IsProportionalCtrl; //是否比例控制
objCurrEduCls4SynchENT.IsSynchToWeb = objCurrEduCls4SynchENS.IsSynchToWeb; //是否同步Web
objCurrEduCls4SynchENT.SynchToWebDate = objCurrEduCls4SynchENS.SynchToWebDate; //同步Web日期
objCurrEduCls4SynchENT.SynchToWebUser = objCurrEduCls4SynchENS.SynchToWebUser; //同步Web用户
objCurrEduCls4SynchENT.SignInDate = objCurrEduCls4SynchENS.SignInDate; //签入时间
objCurrEduCls4SynchENT.SignInStateID = objCurrEduCls4SynchENS.SignInStateID; //签入状态表流水号
objCurrEduCls4SynchENT.SignInUser = objCurrEduCls4SynchENS.SignInUser; //签入人
objCurrEduCls4SynchENT.IdExamType = objCurrEduCls4SynchENS.IdExamType; //考试方式流水号
objCurrEduCls4SynchENT.ExamPortion = objCurrEduCls4SynchENS.ExamPortion; //平时成绩所占比例
objCurrEduCls4SynchENT.MidExamScorePortion = objCurrEduCls4SynchENS.MidExamScorePortion; //期末成绩所占比例
objCurrEduCls4SynchENT.IsClearScore = objCurrEduCls4SynchENS.IsClearScore; //是否重录成绩
objCurrEduCls4SynchENT.IsGeneratePwd = objCurrEduCls4SynchENS.IsGeneratePwd; //是否生成口令
objCurrEduCls4SynchENT.GeneratePwdDate = objCurrEduCls4SynchENS.GeneratePwdDate; //生成口令时间
objCurrEduCls4SynchENT.IsExportToGP = objCurrEduCls4SynchENS.IsExportToGP; //是否导出到平台
objCurrEduCls4SynchENT.IsExportToGPWeb = objCurrEduCls4SynchENS.IsExportToGPWeb; //是否导出到Web平台
objCurrEduCls4SynchENT.IsReservedDecimal = objCurrEduCls4SynchENS.IsReservedDecimal; //是否保留小数
objCurrEduCls4SynchENT.ExamTime = objCurrEduCls4SynchENS.ExamTime; //考试时间
objCurrEduCls4SynchENT.CheckState = objCurrEduCls4SynchENS.CheckState; //检查状态
objCurrEduCls4SynchENT.CheckDate = objCurrEduCls4SynchENS.CheckDate; //检查日期
objCurrEduCls4SynchENT.IdEduClassInPk = objCurrEduCls4SynchENS.IdEduClassInPk; //id_EduClassInPk
objCurrEduCls4SynchENT.PkWeekTime = objCurrEduCls4SynchENS.PkWeekTime; //排课时间
objCurrEduCls4SynchENT.PkClassRooms = objCurrEduCls4SynchENS.PkClassRooms; //排课教室
objCurrEduCls4SynchENT.BeginWeek = objCurrEduCls4SynchENS.BeginWeek; //开始周
objCurrEduCls4SynchENT.TeacherNames = objCurrEduCls4SynchENS.TeacherNames; //教师姓名
objCurrEduCls4SynchENT.IsAccessSynch = objCurrEduCls4SynchENS.IsAccessSynch; //是否处理同步
objCurrEduCls4SynchENT.AccessSynchDate = objCurrEduCls4SynchENS.AccessSynchDate; //处理同步日期
objCurrEduCls4SynchENT.IsExistEduClsInCurr = objCurrEduCls4SynchENS.IsExistEduClsInCurr; //当前是否存在教学班
objCurrEduCls4SynchENT.ModifyDate = objCurrEduCls4SynchENS.ModifyDate; //修改日期
objCurrEduCls4SynchENT.ModifyUserId = objCurrEduCls4SynchENS.ModifyUserId; //修改人
objCurrEduCls4SynchENT.Memo = objCurrEduCls4SynchENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCurrEduCls4SynchEN.IdCurrEduCls, conCurrEduCls4Synch.IdCurrEduCls);
clsCheckSql.CheckFieldNotNull(objCurrEduCls4SynchEN.CurrEduClsId, conCurrEduCls4Synch.CurrEduClsId);
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IpAddress, 50, conCurrEduCls4Synch.IpAddress);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdCurrEduCls, 8, conCurrEduCls4Synch.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CurrEduClsId, 15, conCurrEduCls4Synch.CurrEduClsId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.EduClsName, 100, conCurrEduCls4Synch.EduClsName);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.EduClsTypeId, 4, conCurrEduCls4Synch.EduClsTypeId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CourseId, 8, conCurrEduCls4Synch.CourseId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.TeachingSolutionId, 8, conCurrEduCls4Synch.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdXzCollege, 4, conCurrEduCls4Synch.IdXzCollege);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdEduWay, 4, conCurrEduCls4Synch.IdEduWay);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdClassRoomType, 4, conCurrEduCls4Synch.IdClassRoomType);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.WeekStatusId, 2, conCurrEduCls4Synch.WeekStatusId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CustomerWeek, 50, conCurrEduCls4Synch.CustomerWeek);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdExecPlan, 8, conCurrEduCls4Synch.IdExecPlan);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CheckClassRoom, 2000, conCurrEduCls4Synch.CheckClassRoom);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CheckAdminCls, 2000, conCurrEduCls4Synch.CheckAdminCls);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CheckTeacher, 2000, conCurrEduCls4Synch.CheckTeacher);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdUniZone, 4, conCurrEduCls4Synch.IdUniZone);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdGradeBase, 4, conCurrEduCls4Synch.IdGradeBase);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SchoolYear, 10, conCurrEduCls4Synch.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SchoolTerm, 1, conCurrEduCls4Synch.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.ArrangeCourseMemo, 50, conCurrEduCls4Synch.ArrangeCourseMemo);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdCourseType, 4, conCurrEduCls4Synch.IdCourseType);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.ExportDate, 8, conCurrEduCls4Synch.ExportDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdScoreType, 4, conCurrEduCls4Synch.IdScoreType);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.GetScoreWayId, 2, conCurrEduCls4Synch.GetScoreWayId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SynchToWebDate, 20, conCurrEduCls4Synch.SynchToWebDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SynchToWebUser, 18, conCurrEduCls4Synch.SynchToWebUser);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SignInDate, 20, conCurrEduCls4Synch.SignInDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SignInStateID, 2, conCurrEduCls4Synch.SignInStateID);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SignInUser, 18, conCurrEduCls4Synch.SignInUser);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdExamType, 4, conCurrEduCls4Synch.IdExamType);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.GeneratePwdDate, 20, conCurrEduCls4Synch.GeneratePwdDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.ExamTime, 8, conCurrEduCls4Synch.ExamTime);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CheckDate, 20, conCurrEduCls4Synch.CheckDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdEduClassInPk, 8, conCurrEduCls4Synch.IdEduClassInPk);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.PkWeekTime, 2000, conCurrEduCls4Synch.PkWeekTime);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.PkClassRooms, 150, conCurrEduCls4Synch.PkClassRooms);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.TeacherNames, 100, conCurrEduCls4Synch.TeacherNames);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.AccessSynchDate, 14, conCurrEduCls4Synch.AccessSynchDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.ModifyDate, 20, conCurrEduCls4Synch.ModifyDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.ModifyUserId, 18, conCurrEduCls4Synch.ModifyUserId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.Memo, 1000, conCurrEduCls4Synch.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.CourseId, 8, conCurrEduCls4Synch.CourseId);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.IdEduWay, 4, conCurrEduCls4Synch.IdEduWay);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.IdClassRoomType, 4, conCurrEduCls4Synch.IdClassRoomType);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.WeekStatusId, 2, conCurrEduCls4Synch.WeekStatusId);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.IdUniZone, 4, conCurrEduCls4Synch.IdUniZone);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.IdGradeBase, 4, conCurrEduCls4Synch.IdGradeBase);
 objCurrEduCls4SynchEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IpAddress, 50, conCurrEduCls4Synch.IpAddress);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdCurrEduCls, 8, conCurrEduCls4Synch.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CurrEduClsId, 15, conCurrEduCls4Synch.CurrEduClsId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.EduClsName, 100, conCurrEduCls4Synch.EduClsName);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.EduClsTypeId, 4, conCurrEduCls4Synch.EduClsTypeId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CourseId, 8, conCurrEduCls4Synch.CourseId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.TeachingSolutionId, 8, conCurrEduCls4Synch.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdXzCollege, 4, conCurrEduCls4Synch.IdXzCollege);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdEduWay, 4, conCurrEduCls4Synch.IdEduWay);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdClassRoomType, 4, conCurrEduCls4Synch.IdClassRoomType);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.WeekStatusId, 2, conCurrEduCls4Synch.WeekStatusId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CustomerWeek, 50, conCurrEduCls4Synch.CustomerWeek);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdExecPlan, 8, conCurrEduCls4Synch.IdExecPlan);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CheckClassRoom, 2000, conCurrEduCls4Synch.CheckClassRoom);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CheckAdminCls, 2000, conCurrEduCls4Synch.CheckAdminCls);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CheckTeacher, 2000, conCurrEduCls4Synch.CheckTeacher);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdUniZone, 4, conCurrEduCls4Synch.IdUniZone);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdGradeBase, 4, conCurrEduCls4Synch.IdGradeBase);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SchoolYear, 10, conCurrEduCls4Synch.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SchoolTerm, 1, conCurrEduCls4Synch.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.ArrangeCourseMemo, 50, conCurrEduCls4Synch.ArrangeCourseMemo);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdCourseType, 4, conCurrEduCls4Synch.IdCourseType);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.ExportDate, 8, conCurrEduCls4Synch.ExportDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdScoreType, 4, conCurrEduCls4Synch.IdScoreType);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.GetScoreWayId, 2, conCurrEduCls4Synch.GetScoreWayId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SynchToWebDate, 20, conCurrEduCls4Synch.SynchToWebDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SynchToWebUser, 18, conCurrEduCls4Synch.SynchToWebUser);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SignInDate, 20, conCurrEduCls4Synch.SignInDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SignInStateID, 2, conCurrEduCls4Synch.SignInStateID);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SignInUser, 18, conCurrEduCls4Synch.SignInUser);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdExamType, 4, conCurrEduCls4Synch.IdExamType);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.GeneratePwdDate, 20, conCurrEduCls4Synch.GeneratePwdDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.ExamTime, 8, conCurrEduCls4Synch.ExamTime);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CheckDate, 20, conCurrEduCls4Synch.CheckDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdEduClassInPk, 8, conCurrEduCls4Synch.IdEduClassInPk);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.PkWeekTime, 2000, conCurrEduCls4Synch.PkWeekTime);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.PkClassRooms, 150, conCurrEduCls4Synch.PkClassRooms);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.TeacherNames, 100, conCurrEduCls4Synch.TeacherNames);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.AccessSynchDate, 14, conCurrEduCls4Synch.AccessSynchDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.ModifyDate, 20, conCurrEduCls4Synch.ModifyDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.ModifyUserId, 18, conCurrEduCls4Synch.ModifyUserId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.Memo, 1000, conCurrEduCls4Synch.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.CourseId, 8, conCurrEduCls4Synch.CourseId);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.IdEduWay, 4, conCurrEduCls4Synch.IdEduWay);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.IdClassRoomType, 4, conCurrEduCls4Synch.IdClassRoomType);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.WeekStatusId, 2, conCurrEduCls4Synch.WeekStatusId);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.IdUniZone, 4, conCurrEduCls4Synch.IdUniZone);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.IdGradeBase, 4, conCurrEduCls4Synch.IdGradeBase);
 objCurrEduCls4SynchEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IpAddress, 50, conCurrEduCls4Synch.IpAddress);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdCurrEduCls, 8, conCurrEduCls4Synch.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CurrEduClsId, 15, conCurrEduCls4Synch.CurrEduClsId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.EduClsName, 100, conCurrEduCls4Synch.EduClsName);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.EduClsTypeId, 4, conCurrEduCls4Synch.EduClsTypeId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CourseId, 8, conCurrEduCls4Synch.CourseId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.TeachingSolutionId, 8, conCurrEduCls4Synch.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdXzCollege, 4, conCurrEduCls4Synch.IdXzCollege);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdEduWay, 4, conCurrEduCls4Synch.IdEduWay);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdClassRoomType, 4, conCurrEduCls4Synch.IdClassRoomType);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.WeekStatusId, 2, conCurrEduCls4Synch.WeekStatusId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CustomerWeek, 50, conCurrEduCls4Synch.CustomerWeek);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdExecPlan, 8, conCurrEduCls4Synch.IdExecPlan);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CheckClassRoom, 2000, conCurrEduCls4Synch.CheckClassRoom);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CheckAdminCls, 2000, conCurrEduCls4Synch.CheckAdminCls);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CheckTeacher, 2000, conCurrEduCls4Synch.CheckTeacher);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdUniZone, 4, conCurrEduCls4Synch.IdUniZone);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdGradeBase, 4, conCurrEduCls4Synch.IdGradeBase);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SchoolYear, 10, conCurrEduCls4Synch.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SchoolTerm, 1, conCurrEduCls4Synch.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.ArrangeCourseMemo, 50, conCurrEduCls4Synch.ArrangeCourseMemo);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdCourseType, 4, conCurrEduCls4Synch.IdCourseType);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.ExportDate, 8, conCurrEduCls4Synch.ExportDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdScoreType, 4, conCurrEduCls4Synch.IdScoreType);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.GetScoreWayId, 2, conCurrEduCls4Synch.GetScoreWayId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SynchToWebDate, 20, conCurrEduCls4Synch.SynchToWebDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SynchToWebUser, 18, conCurrEduCls4Synch.SynchToWebUser);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SignInDate, 20, conCurrEduCls4Synch.SignInDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SignInStateID, 2, conCurrEduCls4Synch.SignInStateID);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.SignInUser, 18, conCurrEduCls4Synch.SignInUser);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdExamType, 4, conCurrEduCls4Synch.IdExamType);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.GeneratePwdDate, 20, conCurrEduCls4Synch.GeneratePwdDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.ExamTime, 8, conCurrEduCls4Synch.ExamTime);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.CheckDate, 20, conCurrEduCls4Synch.CheckDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.IdEduClassInPk, 8, conCurrEduCls4Synch.IdEduClassInPk);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.PkWeekTime, 2000, conCurrEduCls4Synch.PkWeekTime);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.PkClassRooms, 150, conCurrEduCls4Synch.PkClassRooms);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.TeacherNames, 100, conCurrEduCls4Synch.TeacherNames);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.AccessSynchDate, 14, conCurrEduCls4Synch.AccessSynchDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.ModifyDate, 20, conCurrEduCls4Synch.ModifyDate);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.ModifyUserId, 18, conCurrEduCls4Synch.ModifyUserId);
clsCheckSql.CheckFieldLen(objCurrEduCls4SynchEN.Memo, 1000, conCurrEduCls4Synch.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.IpAddress, conCurrEduCls4Synch.IpAddress);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.IdCurrEduCls, conCurrEduCls4Synch.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.CurrEduClsId, conCurrEduCls4Synch.CurrEduClsId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.EduClsName, conCurrEduCls4Synch.EduClsName);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.EduClsTypeId, conCurrEduCls4Synch.EduClsTypeId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.CourseId, conCurrEduCls4Synch.CourseId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.TeachingSolutionId, conCurrEduCls4Synch.TeachingSolutionId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.IdXzCollege, conCurrEduCls4Synch.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.IdEduWay, conCurrEduCls4Synch.IdEduWay);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.IdClassRoomType, conCurrEduCls4Synch.IdClassRoomType);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.WeekStatusId, conCurrEduCls4Synch.WeekStatusId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.CustomerWeek, conCurrEduCls4Synch.CustomerWeek);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.IdExecPlan, conCurrEduCls4Synch.IdExecPlan);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.CheckClassRoom, conCurrEduCls4Synch.CheckClassRoom);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.CheckAdminCls, conCurrEduCls4Synch.CheckAdminCls);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.CheckTeacher, conCurrEduCls4Synch.CheckTeacher);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.IdUniZone, conCurrEduCls4Synch.IdUniZone);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.IdGradeBase, conCurrEduCls4Synch.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.SchoolYear, conCurrEduCls4Synch.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.SchoolTerm, conCurrEduCls4Synch.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.ArrangeCourseMemo, conCurrEduCls4Synch.ArrangeCourseMemo);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.IdCourseType, conCurrEduCls4Synch.IdCourseType);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.ExportDate, conCurrEduCls4Synch.ExportDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.IdScoreType, conCurrEduCls4Synch.IdScoreType);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.GetScoreWayId, conCurrEduCls4Synch.GetScoreWayId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.SynchToWebDate, conCurrEduCls4Synch.SynchToWebDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.SynchToWebUser, conCurrEduCls4Synch.SynchToWebUser);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.SignInDate, conCurrEduCls4Synch.SignInDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.SignInStateID, conCurrEduCls4Synch.SignInStateID);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.SignInUser, conCurrEduCls4Synch.SignInUser);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.IdExamType, conCurrEduCls4Synch.IdExamType);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.GeneratePwdDate, conCurrEduCls4Synch.GeneratePwdDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.ExamTime, conCurrEduCls4Synch.ExamTime);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.CheckDate, conCurrEduCls4Synch.CheckDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.IdEduClassInPk, conCurrEduCls4Synch.IdEduClassInPk);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.PkWeekTime, conCurrEduCls4Synch.PkWeekTime);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.PkClassRooms, conCurrEduCls4Synch.PkClassRooms);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.TeacherNames, conCurrEduCls4Synch.TeacherNames);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.AccessSynchDate, conCurrEduCls4Synch.AccessSynchDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.ModifyDate, conCurrEduCls4Synch.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.ModifyUserId, conCurrEduCls4Synch.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls4SynchEN.Memo, conCurrEduCls4Synch.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.CourseId, 8, conCurrEduCls4Synch.CourseId);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.IdEduWay, 4, conCurrEduCls4Synch.IdEduWay);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.IdClassRoomType, 4, conCurrEduCls4Synch.IdClassRoomType);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.WeekStatusId, 2, conCurrEduCls4Synch.WeekStatusId);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.IdUniZone, 4, conCurrEduCls4Synch.IdUniZone);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls4SynchEN.IdGradeBase, 4, conCurrEduCls4Synch.IdGradeBase);
 objCurrEduCls4SynchEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetmId()
{
//获取某学院所有专业信息
string strSQL = "select mId, EduClsName from CurrEduCls4Synch ";
 clsSpecSQLforSql mySql = clsCurrEduCls4SynchDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CurrEduCls4Synch(当前教学班_同步),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduCls4SynchEN.IdCurrEduCls);
 if (objCurrEduCls4SynchEN.IpAddress == null)
{
 sbCondition.AppendFormat(" and IpAddress is null");
}
else
{
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objCurrEduCls4SynchEN.IpAddress);
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
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
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
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
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
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCurrEduCls4SynchEN._CurrTabName);
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
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCurrEduCls4SynchEN._CurrTabName, strCondition);
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
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
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
 objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}