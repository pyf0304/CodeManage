
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvStudentInfoDA
 表名:vStudentInfo(01120132)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:24:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
 /// v学生(vStudentInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvStudentInfoDA : clsCommBase4DA
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
 return clsvStudentInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvStudentInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvStudentInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvStudentInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvStudentInfoEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdStudentInfo">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdStudentInfo)
{
strIdStudentInfo = strIdStudentInfo.Replace("'", "''");
if (strIdStudentInfo.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vStudentInfo中,检查关键字,长度不正确!(clsvStudentInfoDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdStudentInfo)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vStudentInfo中,关键字不能为空 或 null!(clsvStudentInfoDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdStudentInfo);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvStudentInfoDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvStudentInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from vStudentInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vStudentInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvStudentInfoDA: GetDataTable_vStudentInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from vStudentInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvStudentInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvStudentInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from vStudentInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvStudentInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvStudentInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vStudentInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vStudentInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvStudentInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vStudentInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvStudentInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vStudentInfo.* from vStudentInfo Left Join {1} on {2} where {3} and vStudentInfo.IdStudentInfo not in (Select top {5} vStudentInfo.IdStudentInfo from vStudentInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vStudentInfo where {1} and IdStudentInfo not in (Select top {2} IdStudentInfo from vStudentInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vStudentInfo where {1} and IdStudentInfo not in (Select top {3} IdStudentInfo from vStudentInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvStudentInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vStudentInfo.* from vStudentInfo Left Join {1} on {2} where {3} and vStudentInfo.IdStudentInfo not in (Select top {5} vStudentInfo.IdStudentInfo from vStudentInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vStudentInfo where {1} and IdStudentInfo not in (Select top {2} IdStudentInfo from vStudentInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vStudentInfo where {1} and IdStudentInfo not in (Select top {3} IdStudentInfo from vStudentInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvStudentInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvStudentInfoDA:GetObjLst)", objException.Message));
}
List<clsvStudentInfoEN> arrObjLst = new List<clsvStudentInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from vStudentInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfoEN objvStudentInfoEN = new clsvStudentInfoEN();
try
{
objvStudentInfoEN.IdStudentInfo = objRow[convStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfoEN.StuId = objRow[convStudentInfo.StuId].ToString().Trim(); //学号
objvStudentInfoEN.StuName = objRow[convStudentInfo.StuName].ToString().Trim(); //姓名
objvStudentInfoEN.IdPolitics = objRow[convStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvStudentInfoEN.PoliticsId = objRow[convStudentInfo.PoliticsId] == DBNull.Value ? null : objRow[convStudentInfo.PoliticsId].ToString().Trim(); //政治面貌Id
objvStudentInfoEN.PoliticsName = objRow[convStudentInfo.PoliticsName].ToString().Trim(); //政治面貌
objvStudentInfoEN.IdSex = objRow[convStudentInfo.IdSex].ToString().Trim(); //性别流水号
objvStudentInfoEN.SexDesc = objRow[convStudentInfo.SexDesc] == DBNull.Value ? null : objRow[convStudentInfo.SexDesc].ToString().Trim(); //性别名称
objvStudentInfoEN.IdEthnic = objRow[convStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objvStudentInfoEN.EthnicId = objRow[convStudentInfo.EthnicId] == DBNull.Value ? null : objRow[convStudentInfo.EthnicId].ToString().Trim(); //民族Id
objvStudentInfoEN.EthnicName = objRow[convStudentInfo.EthnicName] == DBNull.Value ? null : objRow[convStudentInfo.EthnicName].ToString().Trim(); //民族名称
objvStudentInfoEN.IdUniZone = objRow[convStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objvStudentInfoEN.UniZoneDesc = objRow[convStudentInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvStudentInfoEN.IdStuType = objRow[convStudentInfo.IdStuType] == DBNull.Value ? null : objRow[convStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objvStudentInfoEN.StuTypeID = objRow[convStudentInfo.StuTypeID] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeID].ToString().Trim(); //学生类别ID
objvStudentInfoEN.StuTypeDesc = objRow[convStudentInfo.StuTypeDesc] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeDesc].ToString().Trim(); //学生类别名称
objvStudentInfoEN.IdXzCollege = objRow[convStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[convStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvStudentInfoEN.CollegeId = objRow[convStudentInfo.CollegeId] == DBNull.Value ? null : objRow[convStudentInfo.CollegeId].ToString().Trim(); //学院ID
objvStudentInfoEN.CollegeName = objRow[convStudentInfo.CollegeName].ToString().Trim(); //学院名称
objvStudentInfoEN.CollegeIdInGP = objRow[convStudentInfo.CollegeIdInGP] == DBNull.Value ? null : objRow[convStudentInfo.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvStudentInfoEN.CollegeNameA = objRow[convStudentInfo.CollegeNameA] == DBNull.Value ? null : objRow[convStudentInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvStudentInfoEN.IdXzMajor = objRow[convStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[convStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvStudentInfoEN.MajorID = objRow[convStudentInfo.MajorID] == DBNull.Value ? null : objRow[convStudentInfo.MajorID].ToString().Trim(); //专业ID
objvStudentInfoEN.MajorName = objRow[convStudentInfo.MajorName].ToString().Trim(); //专业名称
objvStudentInfoEN.IsNormal = TransNullToBool(objRow[convStudentInfo.IsNormal].ToString().Trim()); //IsNormal
objvStudentInfoEN.IdGradeBase = objRow[convStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objvStudentInfoEN.GradeBaseName = objRow[convStudentInfo.GradeBaseName] == DBNull.Value ? null : objRow[convStudentInfo.GradeBaseName].ToString().Trim(); //年级名称
objvStudentInfoEN.IdAdminCls = objRow[convStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objvStudentInfoEN.AdminClsName = objRow[convStudentInfo.AdminClsName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsName].ToString().Trim(); //行政班名称
objvStudentInfoEN.AdminClsId = objRow[convStudentInfo.AdminClsId] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsId].ToString().Trim(); //行政班代号
objvStudentInfoEN.IdAdminClsType = objRow[convStudentInfo.IdAdminClsType] == DBNull.Value ? null : objRow[convStudentInfo.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvStudentInfoEN.AdminClsTypeName = objRow[convStudentInfo.AdminClsTypeName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvStudentInfoEN.Birthday = objRow[convStudentInfo.Birthday] == DBNull.Value ? null : objRow[convStudentInfo.Birthday].ToString().Trim(); //出生日期
objvStudentInfoEN.NativePlace = objRow[convStudentInfo.NativePlace] == DBNull.Value ? null : objRow[convStudentInfo.NativePlace].ToString().Trim(); //籍贯
objvStudentInfoEN.Duty = objRow[convStudentInfo.Duty] == DBNull.Value ? null : objRow[convStudentInfo.Duty].ToString().Trim(); //职位
objvStudentInfoEN.IdCardNo = objRow[convStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objvStudentInfoEN.StuCardNo = objRow[convStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[convStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objvStudentInfoEN.LiveAddress = objRow[convStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[convStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objvStudentInfoEN.HomePhone = objRow[convStudentInfo.HomePhone] == DBNull.Value ? null : objRow[convStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objvStudentInfoEN.IdCardNo2 = objRow[convStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objvStudentInfoEN.CardNo = objRow[convStudentInfo.CardNo] == DBNull.Value ? null : objRow[convStudentInfo.CardNo].ToString().Trim(); //卡号
objvStudentInfoEN.IsAvconClassUser = TransNullToBool(objRow[convStudentInfo.IsAvconClassUser].ToString().Trim()); //IsAvconClassUser
objvStudentInfoEN.IsAvconUser = TransNullToBool(objRow[convStudentInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvStudentInfoEN.IsGpUser = TransNullToBool(objRow[convStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvStudentInfoEN.IsLocalUser = TransNullToBool(objRow[convStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvStudentInfoEN.IsLeaved = TransNullToBool(objRow[convStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objvStudentInfoEN.UserId = objRow[convStudentInfo.UserId] == DBNull.Value ? null : objRow[convStudentInfo.UserId].ToString().Trim(); //用户ID
objvStudentInfoEN.UserId4Avcon = objRow[convStudentInfo.UserId4Avcon] == DBNull.Value ? null : objRow[convStudentInfo.UserId4Avcon].ToString().Trim(); //UserId4Avcon
objvStudentInfoEN.EnrollmentDate = objRow[convStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[convStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objvStudentInfoEN.PostCode = objRow[convStudentInfo.PostCode] == DBNull.Value ? null : objRow[convStudentInfo.PostCode].ToString().Trim(); //邮编
objvStudentInfoEN.Email = objRow[convStudentInfo.Email] == DBNull.Value ? null : objRow[convStudentInfo.Email].ToString().Trim(); //电子邮箱
objvStudentInfoEN.IsMessage = TransNullToBool(objRow[convStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objvStudentInfoEN.Microblog = objRow[convStudentInfo.Microblog] == DBNull.Value ? null : objRow[convStudentInfo.Microblog].ToString().Trim(); //Microblog
objvStudentInfoEN.PhoneNumber = objRow[convStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[convStudentInfo.PhoneNumber].ToString().Trim(); //电话
objvStudentInfoEN.QQ = objRow[convStudentInfo.QQ] == DBNull.Value ? null : objRow[convStudentInfo.QQ].ToString().Trim(); //QQ
objvStudentInfoEN.RegisterPassword = objRow[convStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[convStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvStudentInfoEN.UpdDate = objRow[convStudentInfo.UpdDate] == DBNull.Value ? null : objRow[convStudentInfo.UpdDate].ToString().Trim(); //修改日期
objvStudentInfoEN.UpdUser = objRow[convStudentInfo.UpdUser] == DBNull.Value ? null : objRow[convStudentInfo.UpdUser].ToString().Trim(); //修改人
objvStudentInfoEN.Memo = objRow[convStudentInfo.Memo] == DBNull.Value ? null : objRow[convStudentInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvStudentInfoDA: GetObjLst)", objException.Message));
}
objvStudentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvStudentInfoEN);
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
public List<clsvStudentInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvStudentInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvStudentInfoEN> arrObjLst = new List<clsvStudentInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfoEN objvStudentInfoEN = new clsvStudentInfoEN();
try
{
objvStudentInfoEN.IdStudentInfo = objRow[convStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfoEN.StuId = objRow[convStudentInfo.StuId].ToString().Trim(); //学号
objvStudentInfoEN.StuName = objRow[convStudentInfo.StuName].ToString().Trim(); //姓名
objvStudentInfoEN.IdPolitics = objRow[convStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvStudentInfoEN.PoliticsId = objRow[convStudentInfo.PoliticsId] == DBNull.Value ? null : objRow[convStudentInfo.PoliticsId].ToString().Trim(); //政治面貌Id
objvStudentInfoEN.PoliticsName = objRow[convStudentInfo.PoliticsName].ToString().Trim(); //政治面貌
objvStudentInfoEN.IdSex = objRow[convStudentInfo.IdSex].ToString().Trim(); //性别流水号
objvStudentInfoEN.SexDesc = objRow[convStudentInfo.SexDesc] == DBNull.Value ? null : objRow[convStudentInfo.SexDesc].ToString().Trim(); //性别名称
objvStudentInfoEN.IdEthnic = objRow[convStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objvStudentInfoEN.EthnicId = objRow[convStudentInfo.EthnicId] == DBNull.Value ? null : objRow[convStudentInfo.EthnicId].ToString().Trim(); //民族Id
objvStudentInfoEN.EthnicName = objRow[convStudentInfo.EthnicName] == DBNull.Value ? null : objRow[convStudentInfo.EthnicName].ToString().Trim(); //民族名称
objvStudentInfoEN.IdUniZone = objRow[convStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objvStudentInfoEN.UniZoneDesc = objRow[convStudentInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvStudentInfoEN.IdStuType = objRow[convStudentInfo.IdStuType] == DBNull.Value ? null : objRow[convStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objvStudentInfoEN.StuTypeID = objRow[convStudentInfo.StuTypeID] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeID].ToString().Trim(); //学生类别ID
objvStudentInfoEN.StuTypeDesc = objRow[convStudentInfo.StuTypeDesc] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeDesc].ToString().Trim(); //学生类别名称
objvStudentInfoEN.IdXzCollege = objRow[convStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[convStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvStudentInfoEN.CollegeId = objRow[convStudentInfo.CollegeId] == DBNull.Value ? null : objRow[convStudentInfo.CollegeId].ToString().Trim(); //学院ID
objvStudentInfoEN.CollegeName = objRow[convStudentInfo.CollegeName].ToString().Trim(); //学院名称
objvStudentInfoEN.CollegeIdInGP = objRow[convStudentInfo.CollegeIdInGP] == DBNull.Value ? null : objRow[convStudentInfo.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvStudentInfoEN.CollegeNameA = objRow[convStudentInfo.CollegeNameA] == DBNull.Value ? null : objRow[convStudentInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvStudentInfoEN.IdXzMajor = objRow[convStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[convStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvStudentInfoEN.MajorID = objRow[convStudentInfo.MajorID] == DBNull.Value ? null : objRow[convStudentInfo.MajorID].ToString().Trim(); //专业ID
objvStudentInfoEN.MajorName = objRow[convStudentInfo.MajorName].ToString().Trim(); //专业名称
objvStudentInfoEN.IsNormal = TransNullToBool(objRow[convStudentInfo.IsNormal].ToString().Trim()); //IsNormal
objvStudentInfoEN.IdGradeBase = objRow[convStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objvStudentInfoEN.GradeBaseName = objRow[convStudentInfo.GradeBaseName] == DBNull.Value ? null : objRow[convStudentInfo.GradeBaseName].ToString().Trim(); //年级名称
objvStudentInfoEN.IdAdminCls = objRow[convStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objvStudentInfoEN.AdminClsName = objRow[convStudentInfo.AdminClsName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsName].ToString().Trim(); //行政班名称
objvStudentInfoEN.AdminClsId = objRow[convStudentInfo.AdminClsId] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsId].ToString().Trim(); //行政班代号
objvStudentInfoEN.IdAdminClsType = objRow[convStudentInfo.IdAdminClsType] == DBNull.Value ? null : objRow[convStudentInfo.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvStudentInfoEN.AdminClsTypeName = objRow[convStudentInfo.AdminClsTypeName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvStudentInfoEN.Birthday = objRow[convStudentInfo.Birthday] == DBNull.Value ? null : objRow[convStudentInfo.Birthday].ToString().Trim(); //出生日期
objvStudentInfoEN.NativePlace = objRow[convStudentInfo.NativePlace] == DBNull.Value ? null : objRow[convStudentInfo.NativePlace].ToString().Trim(); //籍贯
objvStudentInfoEN.Duty = objRow[convStudentInfo.Duty] == DBNull.Value ? null : objRow[convStudentInfo.Duty].ToString().Trim(); //职位
objvStudentInfoEN.IdCardNo = objRow[convStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objvStudentInfoEN.StuCardNo = objRow[convStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[convStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objvStudentInfoEN.LiveAddress = objRow[convStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[convStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objvStudentInfoEN.HomePhone = objRow[convStudentInfo.HomePhone] == DBNull.Value ? null : objRow[convStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objvStudentInfoEN.IdCardNo2 = objRow[convStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objvStudentInfoEN.CardNo = objRow[convStudentInfo.CardNo] == DBNull.Value ? null : objRow[convStudentInfo.CardNo].ToString().Trim(); //卡号
objvStudentInfoEN.IsAvconClassUser = TransNullToBool(objRow[convStudentInfo.IsAvconClassUser].ToString().Trim()); //IsAvconClassUser
objvStudentInfoEN.IsAvconUser = TransNullToBool(objRow[convStudentInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvStudentInfoEN.IsGpUser = TransNullToBool(objRow[convStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvStudentInfoEN.IsLocalUser = TransNullToBool(objRow[convStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvStudentInfoEN.IsLeaved = TransNullToBool(objRow[convStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objvStudentInfoEN.UserId = objRow[convStudentInfo.UserId] == DBNull.Value ? null : objRow[convStudentInfo.UserId].ToString().Trim(); //用户ID
objvStudentInfoEN.UserId4Avcon = objRow[convStudentInfo.UserId4Avcon] == DBNull.Value ? null : objRow[convStudentInfo.UserId4Avcon].ToString().Trim(); //UserId4Avcon
objvStudentInfoEN.EnrollmentDate = objRow[convStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[convStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objvStudentInfoEN.PostCode = objRow[convStudentInfo.PostCode] == DBNull.Value ? null : objRow[convStudentInfo.PostCode].ToString().Trim(); //邮编
objvStudentInfoEN.Email = objRow[convStudentInfo.Email] == DBNull.Value ? null : objRow[convStudentInfo.Email].ToString().Trim(); //电子邮箱
objvStudentInfoEN.IsMessage = TransNullToBool(objRow[convStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objvStudentInfoEN.Microblog = objRow[convStudentInfo.Microblog] == DBNull.Value ? null : objRow[convStudentInfo.Microblog].ToString().Trim(); //Microblog
objvStudentInfoEN.PhoneNumber = objRow[convStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[convStudentInfo.PhoneNumber].ToString().Trim(); //电话
objvStudentInfoEN.QQ = objRow[convStudentInfo.QQ] == DBNull.Value ? null : objRow[convStudentInfo.QQ].ToString().Trim(); //QQ
objvStudentInfoEN.RegisterPassword = objRow[convStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[convStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvStudentInfoEN.UpdDate = objRow[convStudentInfo.UpdDate] == DBNull.Value ? null : objRow[convStudentInfo.UpdDate].ToString().Trim(); //修改日期
objvStudentInfoEN.UpdUser = objRow[convStudentInfo.UpdUser] == DBNull.Value ? null : objRow[convStudentInfo.UpdUser].ToString().Trim(); //修改人
objvStudentInfoEN.Memo = objRow[convStudentInfo.Memo] == DBNull.Value ? null : objRow[convStudentInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvStudentInfoDA: GetObjLst)", objException.Message));
}
objvStudentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvStudentInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvStudentInfo(ref clsvStudentInfoEN objvStudentInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from vStudentInfo where IdStudentInfo = " + "'"+ objvStudentInfoEN.IdStudentInfo+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvStudentInfoEN.IdStudentInfo = objDT.Rows[0][convStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvStudentInfoEN.StuId = objDT.Rows[0][convStudentInfo.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvStudentInfoEN.StuName = objDT.Rows[0][convStudentInfo.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvStudentInfoEN.IdPolitics = objDT.Rows[0][convStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.PoliticsId = objDT.Rows[0][convStudentInfo.PoliticsId].ToString().Trim(); //政治面貌Id(字段类型:varchar,字段长度:4,是否可空:False)
 objvStudentInfoEN.PoliticsName = objDT.Rows[0][convStudentInfo.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvStudentInfoEN.IdSex = objDT.Rows[0][convStudentInfo.IdSex].ToString().Trim(); //性别流水号(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.SexDesc = objDT.Rows[0][convStudentInfo.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvStudentInfoEN.IdEthnic = objDT.Rows[0][convStudentInfo.IdEthnic].ToString().Trim(); //民族流水号(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.EthnicId = objDT.Rows[0][convStudentInfo.EthnicId].ToString().Trim(); //民族Id(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.EthnicName = objDT.Rows[0][convStudentInfo.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvStudentInfoEN.IdUniZone = objDT.Rows[0][convStudentInfo.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.UniZoneDesc = objDT.Rows[0][convStudentInfo.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvStudentInfoEN.IdStuType = objDT.Rows[0][convStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.StuTypeID = objDT.Rows[0][convStudentInfo.StuTypeID].ToString().Trim(); //学生类别ID(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.StuTypeDesc = objDT.Rows[0][convStudentInfo.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvStudentInfoEN.IdXzCollege = objDT.Rows[0][convStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvStudentInfoEN.CollegeId = objDT.Rows[0][convStudentInfo.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvStudentInfoEN.CollegeName = objDT.Rows[0][convStudentInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvStudentInfoEN.CollegeIdInGP = objDT.Rows[0][convStudentInfo.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP(字段类型:varchar,字段长度:6,是否可空:True)
 objvStudentInfoEN.CollegeNameA = objDT.Rows[0][convStudentInfo.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvStudentInfoEN.IdXzMajor = objDT.Rows[0][convStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvStudentInfoEN.MajorID = objDT.Rows[0][convStudentInfo.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.MajorName = objDT.Rows[0][convStudentInfo.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvStudentInfoEN.IsNormal = TransNullToBool(objDT.Rows[0][convStudentInfo.IsNormal].ToString().Trim()); //IsNormal(字段类型:bit,字段长度:1,是否可空:True)
 objvStudentInfoEN.IdGradeBase = objDT.Rows[0][convStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvStudentInfoEN.GradeBaseName = objDT.Rows[0][convStudentInfo.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvStudentInfoEN.IdAdminCls = objDT.Rows[0][convStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvStudentInfoEN.AdminClsName = objDT.Rows[0][convStudentInfo.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvStudentInfoEN.AdminClsId = objDT.Rows[0][convStudentInfo.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvStudentInfoEN.IdAdminClsType = objDT.Rows[0][convStudentInfo.IdAdminClsType].ToString().Trim(); //行政班级类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.AdminClsTypeName = objDT.Rows[0][convStudentInfo.AdminClsTypeName].ToString().Trim(); //行政班级类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvStudentInfoEN.Birthday = objDT.Rows[0][convStudentInfo.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvStudentInfoEN.NativePlace = objDT.Rows[0][convStudentInfo.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvStudentInfoEN.Duty = objDT.Rows[0][convStudentInfo.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvStudentInfoEN.IdCardNo = objDT.Rows[0][convStudentInfo.IdCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvStudentInfoEN.StuCardNo = objDT.Rows[0][convStudentInfo.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvStudentInfoEN.LiveAddress = objDT.Rows[0][convStudentInfo.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvStudentInfoEN.HomePhone = objDT.Rows[0][convStudentInfo.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvStudentInfoEN.IdCardNo2 = objDT.Rows[0][convStudentInfo.IdCardNo2].ToString().Trim(); //内卡号(字段类型:varchar,字段长度:20,是否可空:True)
 objvStudentInfoEN.CardNo = objDT.Rows[0][convStudentInfo.CardNo].ToString().Trim(); //卡号(字段类型:varchar,字段长度:18,是否可空:True)
 objvStudentInfoEN.IsAvconClassUser = TransNullToBool(objDT.Rows[0][convStudentInfo.IsAvconClassUser].ToString().Trim()); //IsAvconClassUser(字段类型:bit,字段长度:1,是否可空:True)
 objvStudentInfoEN.IsAvconUser = TransNullToBool(objDT.Rows[0][convStudentInfo.IsAvconUser].ToString().Trim()); //IsAvconUser(字段类型:bit,字段长度:1,是否可空:True)
 objvStudentInfoEN.IsGpUser = TransNullToBool(objDT.Rows[0][convStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户(字段类型:bit,字段长度:1,是否可空:True)
 objvStudentInfoEN.IsLocalUser = TransNullToBool(objDT.Rows[0][convStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户(字段类型:bit,字段长度:1,是否可空:True)
 objvStudentInfoEN.IsLeaved = TransNullToBool(objDT.Rows[0][convStudentInfo.IsLeaved].ToString().Trim()); //是否离开(字段类型:bit,字段长度:1,是否可空:True)
 objvStudentInfoEN.UserId = objDT.Rows[0][convStudentInfo.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvStudentInfoEN.UserId4Avcon = objDT.Rows[0][convStudentInfo.UserId4Avcon].ToString().Trim(); //UserId4Avcon(字段类型:varchar,字段长度:20,是否可空:True)
 objvStudentInfoEN.EnrollmentDate = objDT.Rows[0][convStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvStudentInfoEN.PostCode = objDT.Rows[0][convStudentInfo.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvStudentInfoEN.Email = objDT.Rows[0][convStudentInfo.Email].ToString().Trim(); //电子邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objvStudentInfoEN.IsMessage = TransNullToBool(objDT.Rows[0][convStudentInfo.IsMessage].ToString().Trim()); //IsMessage(字段类型:bit,字段长度:1,是否可空:True)
 objvStudentInfoEN.Microblog = objDT.Rows[0][convStudentInfo.Microblog].ToString().Trim(); //Microblog(字段类型:varchar,字段长度:200,是否可空:True)
 objvStudentInfoEN.PhoneNumber = objDT.Rows[0][convStudentInfo.PhoneNumber].ToString().Trim(); //电话(字段类型:varchar,字段长度:15,是否可空:True)
 objvStudentInfoEN.QQ = objDT.Rows[0][convStudentInfo.QQ].ToString().Trim(); //QQ(字段类型:varchar,字段长度:100,是否可空:True)
 objvStudentInfoEN.RegisterPassword = objDT.Rows[0][convStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword(字段类型:varchar,字段长度:30,是否可空:True)
 objvStudentInfoEN.UpdDate = objDT.Rows[0][convStudentInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvStudentInfoEN.UpdUser = objDT.Rows[0][convStudentInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvStudentInfoEN.Memo = objDT.Rows[0][convStudentInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvStudentInfoDA: GetvStudentInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdStudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsvStudentInfoEN GetObjByIdStudentInfo(string strIdStudentInfo)
{
CheckPrimaryKey(strIdStudentInfo);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from vStudentInfo where IdStudentInfo = " + "'"+ strIdStudentInfo+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvStudentInfoEN objvStudentInfoEN = new clsvStudentInfoEN();
try
{
 objvStudentInfoEN.IdStudentInfo = objRow[convStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvStudentInfoEN.StuId = objRow[convStudentInfo.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvStudentInfoEN.StuName = objRow[convStudentInfo.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvStudentInfoEN.IdPolitics = objRow[convStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.PoliticsId = objRow[convStudentInfo.PoliticsId] == DBNull.Value ? null : objRow[convStudentInfo.PoliticsId].ToString().Trim(); //政治面貌Id(字段类型:varchar,字段长度:4,是否可空:False)
 objvStudentInfoEN.PoliticsName = objRow[convStudentInfo.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvStudentInfoEN.IdSex = objRow[convStudentInfo.IdSex].ToString().Trim(); //性别流水号(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.SexDesc = objRow[convStudentInfo.SexDesc] == DBNull.Value ? null : objRow[convStudentInfo.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvStudentInfoEN.IdEthnic = objRow[convStudentInfo.IdEthnic].ToString().Trim(); //民族流水号(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.EthnicId = objRow[convStudentInfo.EthnicId] == DBNull.Value ? null : objRow[convStudentInfo.EthnicId].ToString().Trim(); //民族Id(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.EthnicName = objRow[convStudentInfo.EthnicName] == DBNull.Value ? null : objRow[convStudentInfo.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvStudentInfoEN.IdUniZone = objRow[convStudentInfo.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.UniZoneDesc = objRow[convStudentInfo.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvStudentInfoEN.IdStuType = objRow[convStudentInfo.IdStuType] == DBNull.Value ? null : objRow[convStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.StuTypeID = objRow[convStudentInfo.StuTypeID] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeID].ToString().Trim(); //学生类别ID(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.StuTypeDesc = objRow[convStudentInfo.StuTypeDesc] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvStudentInfoEN.IdXzCollege = objRow[convStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[convStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvStudentInfoEN.CollegeId = objRow[convStudentInfo.CollegeId] == DBNull.Value ? null : objRow[convStudentInfo.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvStudentInfoEN.CollegeName = objRow[convStudentInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvStudentInfoEN.CollegeIdInGP = objRow[convStudentInfo.CollegeIdInGP] == DBNull.Value ? null : objRow[convStudentInfo.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP(字段类型:varchar,字段长度:6,是否可空:True)
 objvStudentInfoEN.CollegeNameA = objRow[convStudentInfo.CollegeNameA] == DBNull.Value ? null : objRow[convStudentInfo.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvStudentInfoEN.IdXzMajor = objRow[convStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[convStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvStudentInfoEN.MajorID = objRow[convStudentInfo.MajorID] == DBNull.Value ? null : objRow[convStudentInfo.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.MajorName = objRow[convStudentInfo.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvStudentInfoEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsNormal].ToString().Trim()); //IsNormal(字段类型:bit,字段长度:1,是否可空:True)
 objvStudentInfoEN.IdGradeBase = objRow[convStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvStudentInfoEN.GradeBaseName = objRow[convStudentInfo.GradeBaseName] == DBNull.Value ? null : objRow[convStudentInfo.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvStudentInfoEN.IdAdminCls = objRow[convStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvStudentInfoEN.AdminClsName = objRow[convStudentInfo.AdminClsName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvStudentInfoEN.AdminClsId = objRow[convStudentInfo.AdminClsId] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvStudentInfoEN.IdAdminClsType = objRow[convStudentInfo.IdAdminClsType] == DBNull.Value ? null : objRow[convStudentInfo.IdAdminClsType].ToString().Trim(); //行政班级类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvStudentInfoEN.AdminClsTypeName = objRow[convStudentInfo.AdminClsTypeName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsTypeName].ToString().Trim(); //行政班级类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvStudentInfoEN.Birthday = objRow[convStudentInfo.Birthday] == DBNull.Value ? null : objRow[convStudentInfo.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvStudentInfoEN.NativePlace = objRow[convStudentInfo.NativePlace] == DBNull.Value ? null : objRow[convStudentInfo.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvStudentInfoEN.Duty = objRow[convStudentInfo.Duty] == DBNull.Value ? null : objRow[convStudentInfo.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvStudentInfoEN.IdCardNo = objRow[convStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvStudentInfoEN.StuCardNo = objRow[convStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[convStudentInfo.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvStudentInfoEN.LiveAddress = objRow[convStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[convStudentInfo.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvStudentInfoEN.HomePhone = objRow[convStudentInfo.HomePhone] == DBNull.Value ? null : objRow[convStudentInfo.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvStudentInfoEN.IdCardNo2 = objRow[convStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo2].ToString().Trim(); //内卡号(字段类型:varchar,字段长度:20,是否可空:True)
 objvStudentInfoEN.CardNo = objRow[convStudentInfo.CardNo] == DBNull.Value ? null : objRow[convStudentInfo.CardNo].ToString().Trim(); //卡号(字段类型:varchar,字段长度:18,是否可空:True)
 objvStudentInfoEN.IsAvconClassUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconClassUser].ToString().Trim()); //IsAvconClassUser(字段类型:bit,字段长度:1,是否可空:True)
 objvStudentInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconUser].ToString().Trim()); //IsAvconUser(字段类型:bit,字段长度:1,是否可空:True)
 objvStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户(字段类型:bit,字段长度:1,是否可空:True)
 objvStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户(字段类型:bit,字段长度:1,是否可空:True)
 objvStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLeaved].ToString().Trim()); //是否离开(字段类型:bit,字段长度:1,是否可空:True)
 objvStudentInfoEN.UserId = objRow[convStudentInfo.UserId] == DBNull.Value ? null : objRow[convStudentInfo.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvStudentInfoEN.UserId4Avcon = objRow[convStudentInfo.UserId4Avcon] == DBNull.Value ? null : objRow[convStudentInfo.UserId4Avcon].ToString().Trim(); //UserId4Avcon(字段类型:varchar,字段长度:20,是否可空:True)
 objvStudentInfoEN.EnrollmentDate = objRow[convStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[convStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvStudentInfoEN.PostCode = objRow[convStudentInfo.PostCode] == DBNull.Value ? null : objRow[convStudentInfo.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvStudentInfoEN.Email = objRow[convStudentInfo.Email] == DBNull.Value ? null : objRow[convStudentInfo.Email].ToString().Trim(); //电子邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objvStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsMessage].ToString().Trim()); //IsMessage(字段类型:bit,字段长度:1,是否可空:True)
 objvStudentInfoEN.Microblog = objRow[convStudentInfo.Microblog] == DBNull.Value ? null : objRow[convStudentInfo.Microblog].ToString().Trim(); //Microblog(字段类型:varchar,字段长度:200,是否可空:True)
 objvStudentInfoEN.PhoneNumber = objRow[convStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[convStudentInfo.PhoneNumber].ToString().Trim(); //电话(字段类型:varchar,字段长度:15,是否可空:True)
 objvStudentInfoEN.QQ = objRow[convStudentInfo.QQ] == DBNull.Value ? null : objRow[convStudentInfo.QQ].ToString().Trim(); //QQ(字段类型:varchar,字段长度:100,是否可空:True)
 objvStudentInfoEN.RegisterPassword = objRow[convStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[convStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword(字段类型:varchar,字段长度:30,是否可空:True)
 objvStudentInfoEN.UpdDate = objRow[convStudentInfo.UpdDate] == DBNull.Value ? null : objRow[convStudentInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvStudentInfoEN.UpdUser = objRow[convStudentInfo.UpdUser] == DBNull.Value ? null : objRow[convStudentInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvStudentInfoEN.Memo = objRow[convStudentInfo.Memo] == DBNull.Value ? null : objRow[convStudentInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvStudentInfoDA: GetObjByIdStudentInfo)", objException.Message));
}
return objvStudentInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvStudentInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvStudentInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from vStudentInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvStudentInfoEN objvStudentInfoEN = new clsvStudentInfoEN()
{
IdStudentInfo = objRow[convStudentInfo.IdStudentInfo].ToString().Trim(), //学生流水号
StuId = objRow[convStudentInfo.StuId].ToString().Trim(), //学号
StuName = objRow[convStudentInfo.StuName].ToString().Trim(), //姓名
IdPolitics = objRow[convStudentInfo.IdPolitics].ToString().Trim(), //政治面貌流水号
PoliticsId = objRow[convStudentInfo.PoliticsId] == DBNull.Value ? null : objRow[convStudentInfo.PoliticsId].ToString().Trim(), //政治面貌Id
PoliticsName = objRow[convStudentInfo.PoliticsName].ToString().Trim(), //政治面貌
IdSex = objRow[convStudentInfo.IdSex].ToString().Trim(), //性别流水号
SexDesc = objRow[convStudentInfo.SexDesc] == DBNull.Value ? null : objRow[convStudentInfo.SexDesc].ToString().Trim(), //性别名称
IdEthnic = objRow[convStudentInfo.IdEthnic].ToString().Trim(), //民族流水号
EthnicId = objRow[convStudentInfo.EthnicId] == DBNull.Value ? null : objRow[convStudentInfo.EthnicId].ToString().Trim(), //民族Id
EthnicName = objRow[convStudentInfo.EthnicName] == DBNull.Value ? null : objRow[convStudentInfo.EthnicName].ToString().Trim(), //民族名称
IdUniZone = objRow[convStudentInfo.IdUniZone].ToString().Trim(), //校区流水号
UniZoneDesc = objRow[convStudentInfo.UniZoneDesc].ToString().Trim(), //校区名称
IdStuType = objRow[convStudentInfo.IdStuType] == DBNull.Value ? null : objRow[convStudentInfo.IdStuType].ToString().Trim(), //学生类别流水号
StuTypeID = objRow[convStudentInfo.StuTypeID] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeID].ToString().Trim(), //学生类别ID
StuTypeDesc = objRow[convStudentInfo.StuTypeDesc] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeDesc].ToString().Trim(), //学生类别名称
IdXzCollege = objRow[convStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[convStudentInfo.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convStudentInfo.CollegeId] == DBNull.Value ? null : objRow[convStudentInfo.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convStudentInfo.CollegeName].ToString().Trim(), //学院名称
CollegeIdInGP = objRow[convStudentInfo.CollegeIdInGP] == DBNull.Value ? null : objRow[convStudentInfo.CollegeIdInGP].ToString().Trim(), //CollegeIdInGP
CollegeNameA = objRow[convStudentInfo.CollegeNameA] == DBNull.Value ? null : objRow[convStudentInfo.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[convStudentInfo.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convStudentInfo.MajorID] == DBNull.Value ? null : objRow[convStudentInfo.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convStudentInfo.MajorName].ToString().Trim(), //专业名称
IsNormal = TransNullToBool(objRow[convStudentInfo.IsNormal].ToString().Trim()), //IsNormal
IdGradeBase = objRow[convStudentInfo.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convStudentInfo.GradeBaseName] == DBNull.Value ? null : objRow[convStudentInfo.GradeBaseName].ToString().Trim(), //年级名称
IdAdminCls = objRow[convStudentInfo.IdAdminCls].ToString().Trim(), //行政班流水号
AdminClsName = objRow[convStudentInfo.AdminClsName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsName].ToString().Trim(), //行政班名称
AdminClsId = objRow[convStudentInfo.AdminClsId] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsId].ToString().Trim(), //行政班代号
IdAdminClsType = objRow[convStudentInfo.IdAdminClsType] == DBNull.Value ? null : objRow[convStudentInfo.IdAdminClsType].ToString().Trim(), //行政班级类型流水号
AdminClsTypeName = objRow[convStudentInfo.AdminClsTypeName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsTypeName].ToString().Trim(), //行政班级类型名称
Birthday = objRow[convStudentInfo.Birthday] == DBNull.Value ? null : objRow[convStudentInfo.Birthday].ToString().Trim(), //出生日期
NativePlace = objRow[convStudentInfo.NativePlace] == DBNull.Value ? null : objRow[convStudentInfo.NativePlace].ToString().Trim(), //籍贯
Duty = objRow[convStudentInfo.Duty] == DBNull.Value ? null : objRow[convStudentInfo.Duty].ToString().Trim(), //职位
IdCardNo = objRow[convStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo].ToString().Trim(), //身份证号
StuCardNo = objRow[convStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[convStudentInfo.StuCardNo].ToString().Trim(), //学生证号
LiveAddress = objRow[convStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[convStudentInfo.LiveAddress].ToString().Trim(), //居住地址
HomePhone = objRow[convStudentInfo.HomePhone] == DBNull.Value ? null : objRow[convStudentInfo.HomePhone].ToString().Trim(), //住宅电话
IdCardNo2 = objRow[convStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo2].ToString().Trim(), //内卡号
CardNo = objRow[convStudentInfo.CardNo] == DBNull.Value ? null : objRow[convStudentInfo.CardNo].ToString().Trim(), //卡号
IsAvconClassUser = TransNullToBool(objRow[convStudentInfo.IsAvconClassUser].ToString().Trim()), //IsAvconClassUser
IsAvconUser = TransNullToBool(objRow[convStudentInfo.IsAvconUser].ToString().Trim()), //IsAvconUser
IsGpUser = TransNullToBool(objRow[convStudentInfo.IsGpUser].ToString().Trim()), //是否Gp用户
IsLocalUser = TransNullToBool(objRow[convStudentInfo.IsLocalUser].ToString().Trim()), //是否本地用户
IsLeaved = TransNullToBool(objRow[convStudentInfo.IsLeaved].ToString().Trim()), //是否离开
UserId = objRow[convStudentInfo.UserId] == DBNull.Value ? null : objRow[convStudentInfo.UserId].ToString().Trim(), //用户ID
UserId4Avcon = objRow[convStudentInfo.UserId4Avcon] == DBNull.Value ? null : objRow[convStudentInfo.UserId4Avcon].ToString().Trim(), //UserId4Avcon
EnrollmentDate = objRow[convStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[convStudentInfo.EnrollmentDate].ToString().Trim(), //入校日期
PostCode = objRow[convStudentInfo.PostCode] == DBNull.Value ? null : objRow[convStudentInfo.PostCode].ToString().Trim(), //邮编
Email = objRow[convStudentInfo.Email] == DBNull.Value ? null : objRow[convStudentInfo.Email].ToString().Trim(), //电子邮箱
IsMessage = TransNullToBool(objRow[convStudentInfo.IsMessage].ToString().Trim()), //IsMessage
Microblog = objRow[convStudentInfo.Microblog] == DBNull.Value ? null : objRow[convStudentInfo.Microblog].ToString().Trim(), //Microblog
PhoneNumber = objRow[convStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[convStudentInfo.PhoneNumber].ToString().Trim(), //电话
QQ = objRow[convStudentInfo.QQ] == DBNull.Value ? null : objRow[convStudentInfo.QQ].ToString().Trim(), //QQ
RegisterPassword = objRow[convStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[convStudentInfo.RegisterPassword].ToString().Trim(), //RegisterPassword
UpdDate = objRow[convStudentInfo.UpdDate] == DBNull.Value ? null : objRow[convStudentInfo.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convStudentInfo.UpdUser] == DBNull.Value ? null : objRow[convStudentInfo.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convStudentInfo.Memo] == DBNull.Value ? null : objRow[convStudentInfo.Memo].ToString().Trim() //备注
};
objvStudentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvStudentInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvStudentInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvStudentInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvStudentInfoEN objvStudentInfoEN = new clsvStudentInfoEN();
try
{
objvStudentInfoEN.IdStudentInfo = objRow[convStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfoEN.StuId = objRow[convStudentInfo.StuId].ToString().Trim(); //学号
objvStudentInfoEN.StuName = objRow[convStudentInfo.StuName].ToString().Trim(); //姓名
objvStudentInfoEN.IdPolitics = objRow[convStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvStudentInfoEN.PoliticsId = objRow[convStudentInfo.PoliticsId] == DBNull.Value ? null : objRow[convStudentInfo.PoliticsId].ToString().Trim(); //政治面貌Id
objvStudentInfoEN.PoliticsName = objRow[convStudentInfo.PoliticsName].ToString().Trim(); //政治面貌
objvStudentInfoEN.IdSex = objRow[convStudentInfo.IdSex].ToString().Trim(); //性别流水号
objvStudentInfoEN.SexDesc = objRow[convStudentInfo.SexDesc] == DBNull.Value ? null : objRow[convStudentInfo.SexDesc].ToString().Trim(); //性别名称
objvStudentInfoEN.IdEthnic = objRow[convStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objvStudentInfoEN.EthnicId = objRow[convStudentInfo.EthnicId] == DBNull.Value ? null : objRow[convStudentInfo.EthnicId].ToString().Trim(); //民族Id
objvStudentInfoEN.EthnicName = objRow[convStudentInfo.EthnicName] == DBNull.Value ? null : objRow[convStudentInfo.EthnicName].ToString().Trim(); //民族名称
objvStudentInfoEN.IdUniZone = objRow[convStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objvStudentInfoEN.UniZoneDesc = objRow[convStudentInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvStudentInfoEN.IdStuType = objRow[convStudentInfo.IdStuType] == DBNull.Value ? null : objRow[convStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objvStudentInfoEN.StuTypeID = objRow[convStudentInfo.StuTypeID] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeID].ToString().Trim(); //学生类别ID
objvStudentInfoEN.StuTypeDesc = objRow[convStudentInfo.StuTypeDesc] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeDesc].ToString().Trim(); //学生类别名称
objvStudentInfoEN.IdXzCollege = objRow[convStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[convStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvStudentInfoEN.CollegeId = objRow[convStudentInfo.CollegeId] == DBNull.Value ? null : objRow[convStudentInfo.CollegeId].ToString().Trim(); //学院ID
objvStudentInfoEN.CollegeName = objRow[convStudentInfo.CollegeName].ToString().Trim(); //学院名称
objvStudentInfoEN.CollegeIdInGP = objRow[convStudentInfo.CollegeIdInGP] == DBNull.Value ? null : objRow[convStudentInfo.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvStudentInfoEN.CollegeNameA = objRow[convStudentInfo.CollegeNameA] == DBNull.Value ? null : objRow[convStudentInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvStudentInfoEN.IdXzMajor = objRow[convStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[convStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvStudentInfoEN.MajorID = objRow[convStudentInfo.MajorID] == DBNull.Value ? null : objRow[convStudentInfo.MajorID].ToString().Trim(); //专业ID
objvStudentInfoEN.MajorName = objRow[convStudentInfo.MajorName].ToString().Trim(); //专业名称
objvStudentInfoEN.IsNormal = TransNullToBool(objRow[convStudentInfo.IsNormal].ToString().Trim()); //IsNormal
objvStudentInfoEN.IdGradeBase = objRow[convStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objvStudentInfoEN.GradeBaseName = objRow[convStudentInfo.GradeBaseName] == DBNull.Value ? null : objRow[convStudentInfo.GradeBaseName].ToString().Trim(); //年级名称
objvStudentInfoEN.IdAdminCls = objRow[convStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objvStudentInfoEN.AdminClsName = objRow[convStudentInfo.AdminClsName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsName].ToString().Trim(); //行政班名称
objvStudentInfoEN.AdminClsId = objRow[convStudentInfo.AdminClsId] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsId].ToString().Trim(); //行政班代号
objvStudentInfoEN.IdAdminClsType = objRow[convStudentInfo.IdAdminClsType] == DBNull.Value ? null : objRow[convStudentInfo.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvStudentInfoEN.AdminClsTypeName = objRow[convStudentInfo.AdminClsTypeName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvStudentInfoEN.Birthday = objRow[convStudentInfo.Birthday] == DBNull.Value ? null : objRow[convStudentInfo.Birthday].ToString().Trim(); //出生日期
objvStudentInfoEN.NativePlace = objRow[convStudentInfo.NativePlace] == DBNull.Value ? null : objRow[convStudentInfo.NativePlace].ToString().Trim(); //籍贯
objvStudentInfoEN.Duty = objRow[convStudentInfo.Duty] == DBNull.Value ? null : objRow[convStudentInfo.Duty].ToString().Trim(); //职位
objvStudentInfoEN.IdCardNo = objRow[convStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objvStudentInfoEN.StuCardNo = objRow[convStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[convStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objvStudentInfoEN.LiveAddress = objRow[convStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[convStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objvStudentInfoEN.HomePhone = objRow[convStudentInfo.HomePhone] == DBNull.Value ? null : objRow[convStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objvStudentInfoEN.IdCardNo2 = objRow[convStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objvStudentInfoEN.CardNo = objRow[convStudentInfo.CardNo] == DBNull.Value ? null : objRow[convStudentInfo.CardNo].ToString().Trim(); //卡号
objvStudentInfoEN.IsAvconClassUser = TransNullToBool(objRow[convStudentInfo.IsAvconClassUser].ToString().Trim()); //IsAvconClassUser
objvStudentInfoEN.IsAvconUser = TransNullToBool(objRow[convStudentInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvStudentInfoEN.IsGpUser = TransNullToBool(objRow[convStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvStudentInfoEN.IsLocalUser = TransNullToBool(objRow[convStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvStudentInfoEN.IsLeaved = TransNullToBool(objRow[convStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objvStudentInfoEN.UserId = objRow[convStudentInfo.UserId] == DBNull.Value ? null : objRow[convStudentInfo.UserId].ToString().Trim(); //用户ID
objvStudentInfoEN.UserId4Avcon = objRow[convStudentInfo.UserId4Avcon] == DBNull.Value ? null : objRow[convStudentInfo.UserId4Avcon].ToString().Trim(); //UserId4Avcon
objvStudentInfoEN.EnrollmentDate = objRow[convStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[convStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objvStudentInfoEN.PostCode = objRow[convStudentInfo.PostCode] == DBNull.Value ? null : objRow[convStudentInfo.PostCode].ToString().Trim(); //邮编
objvStudentInfoEN.Email = objRow[convStudentInfo.Email] == DBNull.Value ? null : objRow[convStudentInfo.Email].ToString().Trim(); //电子邮箱
objvStudentInfoEN.IsMessage = TransNullToBool(objRow[convStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objvStudentInfoEN.Microblog = objRow[convStudentInfo.Microblog] == DBNull.Value ? null : objRow[convStudentInfo.Microblog].ToString().Trim(); //Microblog
objvStudentInfoEN.PhoneNumber = objRow[convStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[convStudentInfo.PhoneNumber].ToString().Trim(); //电话
objvStudentInfoEN.QQ = objRow[convStudentInfo.QQ] == DBNull.Value ? null : objRow[convStudentInfo.QQ].ToString().Trim(); //QQ
objvStudentInfoEN.RegisterPassword = objRow[convStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[convStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvStudentInfoEN.UpdDate = objRow[convStudentInfo.UpdDate] == DBNull.Value ? null : objRow[convStudentInfo.UpdDate].ToString().Trim(); //修改日期
objvStudentInfoEN.UpdUser = objRow[convStudentInfo.UpdUser] == DBNull.Value ? null : objRow[convStudentInfo.UpdUser].ToString().Trim(); //修改人
objvStudentInfoEN.Memo = objRow[convStudentInfo.Memo] == DBNull.Value ? null : objRow[convStudentInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvStudentInfoDA: GetObjByDataRowvStudentInfo)", objException.Message));
}
objvStudentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvStudentInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvStudentInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvStudentInfoEN objvStudentInfoEN = new clsvStudentInfoEN();
try
{
objvStudentInfoEN.IdStudentInfo = objRow[convStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfoEN.StuId = objRow[convStudentInfo.StuId].ToString().Trim(); //学号
objvStudentInfoEN.StuName = objRow[convStudentInfo.StuName].ToString().Trim(); //姓名
objvStudentInfoEN.IdPolitics = objRow[convStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvStudentInfoEN.PoliticsId = objRow[convStudentInfo.PoliticsId] == DBNull.Value ? null : objRow[convStudentInfo.PoliticsId].ToString().Trim(); //政治面貌Id
objvStudentInfoEN.PoliticsName = objRow[convStudentInfo.PoliticsName].ToString().Trim(); //政治面貌
objvStudentInfoEN.IdSex = objRow[convStudentInfo.IdSex].ToString().Trim(); //性别流水号
objvStudentInfoEN.SexDesc = objRow[convStudentInfo.SexDesc] == DBNull.Value ? null : objRow[convStudentInfo.SexDesc].ToString().Trim(); //性别名称
objvStudentInfoEN.IdEthnic = objRow[convStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objvStudentInfoEN.EthnicId = objRow[convStudentInfo.EthnicId] == DBNull.Value ? null : objRow[convStudentInfo.EthnicId].ToString().Trim(); //民族Id
objvStudentInfoEN.EthnicName = objRow[convStudentInfo.EthnicName] == DBNull.Value ? null : objRow[convStudentInfo.EthnicName].ToString().Trim(); //民族名称
objvStudentInfoEN.IdUniZone = objRow[convStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objvStudentInfoEN.UniZoneDesc = objRow[convStudentInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvStudentInfoEN.IdStuType = objRow[convStudentInfo.IdStuType] == DBNull.Value ? null : objRow[convStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objvStudentInfoEN.StuTypeID = objRow[convStudentInfo.StuTypeID] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeID].ToString().Trim(); //学生类别ID
objvStudentInfoEN.StuTypeDesc = objRow[convStudentInfo.StuTypeDesc] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeDesc].ToString().Trim(); //学生类别名称
objvStudentInfoEN.IdXzCollege = objRow[convStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[convStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvStudentInfoEN.CollegeId = objRow[convStudentInfo.CollegeId] == DBNull.Value ? null : objRow[convStudentInfo.CollegeId].ToString().Trim(); //学院ID
objvStudentInfoEN.CollegeName = objRow[convStudentInfo.CollegeName].ToString().Trim(); //学院名称
objvStudentInfoEN.CollegeIdInGP = objRow[convStudentInfo.CollegeIdInGP] == DBNull.Value ? null : objRow[convStudentInfo.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvStudentInfoEN.CollegeNameA = objRow[convStudentInfo.CollegeNameA] == DBNull.Value ? null : objRow[convStudentInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvStudentInfoEN.IdXzMajor = objRow[convStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[convStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvStudentInfoEN.MajorID = objRow[convStudentInfo.MajorID] == DBNull.Value ? null : objRow[convStudentInfo.MajorID].ToString().Trim(); //专业ID
objvStudentInfoEN.MajorName = objRow[convStudentInfo.MajorName].ToString().Trim(); //专业名称
objvStudentInfoEN.IsNormal = TransNullToBool(objRow[convStudentInfo.IsNormal].ToString().Trim()); //IsNormal
objvStudentInfoEN.IdGradeBase = objRow[convStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objvStudentInfoEN.GradeBaseName = objRow[convStudentInfo.GradeBaseName] == DBNull.Value ? null : objRow[convStudentInfo.GradeBaseName].ToString().Trim(); //年级名称
objvStudentInfoEN.IdAdminCls = objRow[convStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objvStudentInfoEN.AdminClsName = objRow[convStudentInfo.AdminClsName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsName].ToString().Trim(); //行政班名称
objvStudentInfoEN.AdminClsId = objRow[convStudentInfo.AdminClsId] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsId].ToString().Trim(); //行政班代号
objvStudentInfoEN.IdAdminClsType = objRow[convStudentInfo.IdAdminClsType] == DBNull.Value ? null : objRow[convStudentInfo.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvStudentInfoEN.AdminClsTypeName = objRow[convStudentInfo.AdminClsTypeName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvStudentInfoEN.Birthday = objRow[convStudentInfo.Birthday] == DBNull.Value ? null : objRow[convStudentInfo.Birthday].ToString().Trim(); //出生日期
objvStudentInfoEN.NativePlace = objRow[convStudentInfo.NativePlace] == DBNull.Value ? null : objRow[convStudentInfo.NativePlace].ToString().Trim(); //籍贯
objvStudentInfoEN.Duty = objRow[convStudentInfo.Duty] == DBNull.Value ? null : objRow[convStudentInfo.Duty].ToString().Trim(); //职位
objvStudentInfoEN.IdCardNo = objRow[convStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objvStudentInfoEN.StuCardNo = objRow[convStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[convStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objvStudentInfoEN.LiveAddress = objRow[convStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[convStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objvStudentInfoEN.HomePhone = objRow[convStudentInfo.HomePhone] == DBNull.Value ? null : objRow[convStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objvStudentInfoEN.IdCardNo2 = objRow[convStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objvStudentInfoEN.CardNo = objRow[convStudentInfo.CardNo] == DBNull.Value ? null : objRow[convStudentInfo.CardNo].ToString().Trim(); //卡号
objvStudentInfoEN.IsAvconClassUser = TransNullToBool(objRow[convStudentInfo.IsAvconClassUser].ToString().Trim()); //IsAvconClassUser
objvStudentInfoEN.IsAvconUser = TransNullToBool(objRow[convStudentInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvStudentInfoEN.IsGpUser = TransNullToBool(objRow[convStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvStudentInfoEN.IsLocalUser = TransNullToBool(objRow[convStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvStudentInfoEN.IsLeaved = TransNullToBool(objRow[convStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objvStudentInfoEN.UserId = objRow[convStudentInfo.UserId] == DBNull.Value ? null : objRow[convStudentInfo.UserId].ToString().Trim(); //用户ID
objvStudentInfoEN.UserId4Avcon = objRow[convStudentInfo.UserId4Avcon] == DBNull.Value ? null : objRow[convStudentInfo.UserId4Avcon].ToString().Trim(); //UserId4Avcon
objvStudentInfoEN.EnrollmentDate = objRow[convStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[convStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objvStudentInfoEN.PostCode = objRow[convStudentInfo.PostCode] == DBNull.Value ? null : objRow[convStudentInfo.PostCode].ToString().Trim(); //邮编
objvStudentInfoEN.Email = objRow[convStudentInfo.Email] == DBNull.Value ? null : objRow[convStudentInfo.Email].ToString().Trim(); //电子邮箱
objvStudentInfoEN.IsMessage = TransNullToBool(objRow[convStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objvStudentInfoEN.Microblog = objRow[convStudentInfo.Microblog] == DBNull.Value ? null : objRow[convStudentInfo.Microblog].ToString().Trim(); //Microblog
objvStudentInfoEN.PhoneNumber = objRow[convStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[convStudentInfo.PhoneNumber].ToString().Trim(); //电话
objvStudentInfoEN.QQ = objRow[convStudentInfo.QQ] == DBNull.Value ? null : objRow[convStudentInfo.QQ].ToString().Trim(); //QQ
objvStudentInfoEN.RegisterPassword = objRow[convStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[convStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvStudentInfoEN.UpdDate = objRow[convStudentInfo.UpdDate] == DBNull.Value ? null : objRow[convStudentInfo.UpdDate].ToString().Trim(); //修改日期
objvStudentInfoEN.UpdUser = objRow[convStudentInfo.UpdUser] == DBNull.Value ? null : objRow[convStudentInfo.UpdUser].ToString().Trim(); //修改人
objvStudentInfoEN.Memo = objRow[convStudentInfo.Memo] == DBNull.Value ? null : objRow[convStudentInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvStudentInfoDA: GetObjByDataRow)", objException.Message));
}
objvStudentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvStudentInfoEN;
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
objSQL = clsvStudentInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvStudentInfoEN._CurrTabName, convStudentInfo.IdStudentInfo, 8, "");
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
objSQL = clsvStudentInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvStudentInfoEN._CurrTabName, convStudentInfo.IdStudentInfo, 8, strPrefix);
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
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdStudentInfo from vStudentInfo where " + strCondition;
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
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdStudentInfo from vStudentInfo where " + strCondition;
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
 /// <param name = "strIdStudentInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdStudentInfo)
{
CheckPrimaryKey(strIdStudentInfo);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vStudentInfo", "IdStudentInfo = " + "'"+ strIdStudentInfo+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvStudentInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vStudentInfo", strCondition))
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
objSQL = clsvStudentInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vStudentInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvStudentInfoENS">源对象</param>
 /// <param name = "objvStudentInfoENT">目标对象</param>
public void CopyTo(clsvStudentInfoEN objvStudentInfoENS, clsvStudentInfoEN objvStudentInfoENT)
{
objvStudentInfoENT.IdStudentInfo = objvStudentInfoENS.IdStudentInfo; //学生流水号
objvStudentInfoENT.StuId = objvStudentInfoENS.StuId; //学号
objvStudentInfoENT.StuName = objvStudentInfoENS.StuName; //姓名
objvStudentInfoENT.IdPolitics = objvStudentInfoENS.IdPolitics; //政治面貌流水号
objvStudentInfoENT.PoliticsId = objvStudentInfoENS.PoliticsId; //政治面貌Id
objvStudentInfoENT.PoliticsName = objvStudentInfoENS.PoliticsName; //政治面貌
objvStudentInfoENT.IdSex = objvStudentInfoENS.IdSex; //性别流水号
objvStudentInfoENT.SexDesc = objvStudentInfoENS.SexDesc; //性别名称
objvStudentInfoENT.IdEthnic = objvStudentInfoENS.IdEthnic; //民族流水号
objvStudentInfoENT.EthnicId = objvStudentInfoENS.EthnicId; //民族Id
objvStudentInfoENT.EthnicName = objvStudentInfoENS.EthnicName; //民族名称
objvStudentInfoENT.IdUniZone = objvStudentInfoENS.IdUniZone; //校区流水号
objvStudentInfoENT.UniZoneDesc = objvStudentInfoENS.UniZoneDesc; //校区名称
objvStudentInfoENT.IdStuType = objvStudentInfoENS.IdStuType; //学生类别流水号
objvStudentInfoENT.StuTypeID = objvStudentInfoENS.StuTypeID; //学生类别ID
objvStudentInfoENT.StuTypeDesc = objvStudentInfoENS.StuTypeDesc; //学生类别名称
objvStudentInfoENT.IdXzCollege = objvStudentInfoENS.IdXzCollege; //学院流水号
objvStudentInfoENT.CollegeId = objvStudentInfoENS.CollegeId; //学院ID
objvStudentInfoENT.CollegeName = objvStudentInfoENS.CollegeName; //学院名称
objvStudentInfoENT.CollegeIdInGP = objvStudentInfoENS.CollegeIdInGP; //CollegeIdInGP
objvStudentInfoENT.CollegeNameA = objvStudentInfoENS.CollegeNameA; //学院名称简写
objvStudentInfoENT.IdXzMajor = objvStudentInfoENS.IdXzMajor; //专业流水号
objvStudentInfoENT.MajorID = objvStudentInfoENS.MajorID; //专业ID
objvStudentInfoENT.MajorName = objvStudentInfoENS.MajorName; //专业名称
objvStudentInfoENT.IsNormal = objvStudentInfoENS.IsNormal; //IsNormal
objvStudentInfoENT.IdGradeBase = objvStudentInfoENS.IdGradeBase; //年级流水号
objvStudentInfoENT.GradeBaseName = objvStudentInfoENS.GradeBaseName; //年级名称
objvStudentInfoENT.IdAdminCls = objvStudentInfoENS.IdAdminCls; //行政班流水号
objvStudentInfoENT.AdminClsName = objvStudentInfoENS.AdminClsName; //行政班名称
objvStudentInfoENT.AdminClsId = objvStudentInfoENS.AdminClsId; //行政班代号
objvStudentInfoENT.IdAdminClsType = objvStudentInfoENS.IdAdminClsType; //行政班级类型流水号
objvStudentInfoENT.AdminClsTypeName = objvStudentInfoENS.AdminClsTypeName; //行政班级类型名称
objvStudentInfoENT.Birthday = objvStudentInfoENS.Birthday; //出生日期
objvStudentInfoENT.NativePlace = objvStudentInfoENS.NativePlace; //籍贯
objvStudentInfoENT.Duty = objvStudentInfoENS.Duty; //职位
objvStudentInfoENT.IdCardNo = objvStudentInfoENS.IdCardNo; //身份证号
objvStudentInfoENT.StuCardNo = objvStudentInfoENS.StuCardNo; //学生证号
objvStudentInfoENT.LiveAddress = objvStudentInfoENS.LiveAddress; //居住地址
objvStudentInfoENT.HomePhone = objvStudentInfoENS.HomePhone; //住宅电话
objvStudentInfoENT.IdCardNo2 = objvStudentInfoENS.IdCardNo2; //内卡号
objvStudentInfoENT.CardNo = objvStudentInfoENS.CardNo; //卡号
objvStudentInfoENT.IsAvconClassUser = objvStudentInfoENS.IsAvconClassUser; //IsAvconClassUser
objvStudentInfoENT.IsAvconUser = objvStudentInfoENS.IsAvconUser; //IsAvconUser
objvStudentInfoENT.IsGpUser = objvStudentInfoENS.IsGpUser; //是否Gp用户
objvStudentInfoENT.IsLocalUser = objvStudentInfoENS.IsLocalUser; //是否本地用户
objvStudentInfoENT.IsLeaved = objvStudentInfoENS.IsLeaved; //是否离开
objvStudentInfoENT.UserId = objvStudentInfoENS.UserId; //用户ID
objvStudentInfoENT.UserId4Avcon = objvStudentInfoENS.UserId4Avcon; //UserId4Avcon
objvStudentInfoENT.EnrollmentDate = objvStudentInfoENS.EnrollmentDate; //入校日期
objvStudentInfoENT.PostCode = objvStudentInfoENS.PostCode; //邮编
objvStudentInfoENT.Email = objvStudentInfoENS.Email; //电子邮箱
objvStudentInfoENT.IsMessage = objvStudentInfoENS.IsMessage; //IsMessage
objvStudentInfoENT.Microblog = objvStudentInfoENS.Microblog; //Microblog
objvStudentInfoENT.PhoneNumber = objvStudentInfoENS.PhoneNumber; //电话
objvStudentInfoENT.QQ = objvStudentInfoENS.QQ; //QQ
objvStudentInfoENT.RegisterPassword = objvStudentInfoENS.RegisterPassword; //RegisterPassword
objvStudentInfoENT.UpdDate = objvStudentInfoENS.UpdDate; //修改日期
objvStudentInfoENT.UpdUser = objvStudentInfoENS.UpdUser; //修改人
objvStudentInfoENT.Memo = objvStudentInfoENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvStudentInfoEN objvStudentInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvStudentInfoEN.IdStudentInfo, 8, convStudentInfo.IdStudentInfo);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.StuId, 20, convStudentInfo.StuId);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.StuName, 50, convStudentInfo.StuName);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.IdPolitics, 4, convStudentInfo.IdPolitics);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.PoliticsId, 4, convStudentInfo.PoliticsId);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.PoliticsName, 30, convStudentInfo.PoliticsName);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.IdSex, 4, convStudentInfo.IdSex);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.SexDesc, 10, convStudentInfo.SexDesc);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.IdEthnic, 4, convStudentInfo.IdEthnic);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.EthnicId, 4, convStudentInfo.EthnicId);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.EthnicName, 30, convStudentInfo.EthnicName);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.IdUniZone, 4, convStudentInfo.IdUniZone);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.UniZoneDesc, 20, convStudentInfo.UniZoneDesc);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.IdStuType, 4, convStudentInfo.IdStuType);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.StuTypeID, 4, convStudentInfo.StuTypeID);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.StuTypeDesc, 50, convStudentInfo.StuTypeDesc);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.IdXzCollege, 4, convStudentInfo.IdXzCollege);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.CollegeId, 4, convStudentInfo.CollegeId);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.CollegeName, 100, convStudentInfo.CollegeName);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.CollegeIdInGP, 6, convStudentInfo.CollegeIdInGP);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.CollegeNameA, 12, convStudentInfo.CollegeNameA);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.IdXzMajor, 8, convStudentInfo.IdXzMajor);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.MajorID, 4, convStudentInfo.MajorID);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.MajorName, 100, convStudentInfo.MajorName);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.IdGradeBase, 4, convStudentInfo.IdGradeBase);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.GradeBaseName, 50, convStudentInfo.GradeBaseName);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.IdAdminCls, 8, convStudentInfo.IdAdminCls);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.AdminClsName, 100, convStudentInfo.AdminClsName);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.AdminClsId, 8, convStudentInfo.AdminClsId);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.IdAdminClsType, 4, convStudentInfo.IdAdminClsType);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.AdminClsTypeName, 30, convStudentInfo.AdminClsTypeName);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.Birthday, 8, convStudentInfo.Birthday);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.NativePlace, 200, convStudentInfo.NativePlace);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.Duty, 30, convStudentInfo.Duty);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.IdCardNo, 20, convStudentInfo.IdCardNo);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.StuCardNo, 20, convStudentInfo.StuCardNo);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.LiveAddress, 200, convStudentInfo.LiveAddress);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.HomePhone, 20, convStudentInfo.HomePhone);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.IdCardNo2, 20, convStudentInfo.IdCardNo2);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.CardNo, 18, convStudentInfo.CardNo);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.UserId, 18, convStudentInfo.UserId);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.UserId4Avcon, 20, convStudentInfo.UserId4Avcon);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.EnrollmentDate, 8, convStudentInfo.EnrollmentDate);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.PostCode, 6, convStudentInfo.PostCode);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.Email, 100, convStudentInfo.Email);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.Microblog, 200, convStudentInfo.Microblog);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.PhoneNumber, 15, convStudentInfo.PhoneNumber);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.QQ, 100, convStudentInfo.QQ);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.RegisterPassword, 30, convStudentInfo.RegisterPassword);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.UpdDate, 20, convStudentInfo.UpdDate);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.UpdUser, 20, convStudentInfo.UpdUser);
clsCheckSql.CheckFieldLen(objvStudentInfoEN.Memo, 1000, convStudentInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.IdStudentInfo, convStudentInfo.IdStudentInfo);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.StuId, convStudentInfo.StuId);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.StuName, convStudentInfo.StuName);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.IdPolitics, convStudentInfo.IdPolitics);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.PoliticsId, convStudentInfo.PoliticsId);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.PoliticsName, convStudentInfo.PoliticsName);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.IdSex, convStudentInfo.IdSex);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.SexDesc, convStudentInfo.SexDesc);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.IdEthnic, convStudentInfo.IdEthnic);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.EthnicId, convStudentInfo.EthnicId);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.EthnicName, convStudentInfo.EthnicName);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.IdUniZone, convStudentInfo.IdUniZone);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.UniZoneDesc, convStudentInfo.UniZoneDesc);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.IdStuType, convStudentInfo.IdStuType);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.StuTypeID, convStudentInfo.StuTypeID);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.StuTypeDesc, convStudentInfo.StuTypeDesc);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.IdXzCollege, convStudentInfo.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.CollegeId, convStudentInfo.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.CollegeName, convStudentInfo.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.CollegeIdInGP, convStudentInfo.CollegeIdInGP);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.CollegeNameA, convStudentInfo.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.IdXzMajor, convStudentInfo.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.MajorID, convStudentInfo.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.MajorName, convStudentInfo.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.IdGradeBase, convStudentInfo.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.GradeBaseName, convStudentInfo.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.IdAdminCls, convStudentInfo.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.AdminClsName, convStudentInfo.AdminClsName);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.AdminClsId, convStudentInfo.AdminClsId);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.IdAdminClsType, convStudentInfo.IdAdminClsType);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.AdminClsTypeName, convStudentInfo.AdminClsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.Birthday, convStudentInfo.Birthday);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.NativePlace, convStudentInfo.NativePlace);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.Duty, convStudentInfo.Duty);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.IdCardNo, convStudentInfo.IdCardNo);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.StuCardNo, convStudentInfo.StuCardNo);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.LiveAddress, convStudentInfo.LiveAddress);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.HomePhone, convStudentInfo.HomePhone);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.IdCardNo2, convStudentInfo.IdCardNo2);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.CardNo, convStudentInfo.CardNo);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.UserId, convStudentInfo.UserId);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.UserId4Avcon, convStudentInfo.UserId4Avcon);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.EnrollmentDate, convStudentInfo.EnrollmentDate);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.PostCode, convStudentInfo.PostCode);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.Email, convStudentInfo.Email);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.Microblog, convStudentInfo.Microblog);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.PhoneNumber, convStudentInfo.PhoneNumber);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.QQ, convStudentInfo.QQ);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.RegisterPassword, convStudentInfo.RegisterPassword);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.UpdDate, convStudentInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.UpdUser, convStudentInfo.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvStudentInfoEN.Memo, convStudentInfo.Memo);
//检查外键字段长度
 objvStudentInfoEN._IsCheckProperty = true;
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
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
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
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
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
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvStudentInfoEN._CurrTabName);
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
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvStudentInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvStudentInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}