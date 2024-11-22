
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SocialRelationsDA
 表名:vzx_SocialRelations(01120852)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:11
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// vzx_SocialRelations(vzx_SocialRelations)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_SocialRelationsDA : clsCommBase4DA
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
 return clsvzx_SocialRelationsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_SocialRelationsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_SocialRelationsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_SocialRelationsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_SocialRelationsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxSocialId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxSocialId)
{
strzxSocialId = strzxSocialId.Replace("'", "''");
if (strzxSocialId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vzx_SocialRelations中,检查关键字,长度不正确!(clsvzx_SocialRelationsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxSocialId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_SocialRelations中,关键字不能为空 或 null!(clsvzx_SocialRelationsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxSocialId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_SocialRelationsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_SocialRelationsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SocialRelations where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_SocialRelations(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_SocialRelationsDA: GetDataTable_vzx_SocialRelations)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SocialRelations where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_SocialRelationsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_SocialRelationsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SocialRelations where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_SocialRelationsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_SocialRelationsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_SocialRelations where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_SocialRelations where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_SocialRelationsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_SocialRelations where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_SocialRelationsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_SocialRelations.* from vzx_SocialRelations Left Join {1} on {2} where {3} and vzx_SocialRelations.zxSocialId not in (Select top {5} vzx_SocialRelations.zxSocialId from vzx_SocialRelations Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_SocialRelations where {1} and zxSocialId not in (Select top {2} zxSocialId from vzx_SocialRelations where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_SocialRelations where {1} and zxSocialId not in (Select top {3} zxSocialId from vzx_SocialRelations where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_SocialRelationsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_SocialRelations.* from vzx_SocialRelations Left Join {1} on {2} where {3} and vzx_SocialRelations.zxSocialId not in (Select top {5} vzx_SocialRelations.zxSocialId from vzx_SocialRelations Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_SocialRelations where {1} and zxSocialId not in (Select top {2} zxSocialId from vzx_SocialRelations where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_SocialRelations where {1} and zxSocialId not in (Select top {3} zxSocialId from vzx_SocialRelations where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_SocialRelationsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_SocialRelationsDA:GetObjLst)", objException.Message));
}
List<clsvzx_SocialRelationsEN> arrObjLst = new List<clsvzx_SocialRelationsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SocialRelations where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = new clsvzx_SocialRelationsEN();
try
{
objvzx_SocialRelationsEN.zxSocialId = objRow[convzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objvzx_SocialRelationsEN.FullName = objRow[convzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[convzx_SocialRelations.FullName].ToString().Trim(); //姓名
objvzx_SocialRelationsEN.Nationality = objRow[convzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[convzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objvzx_SocialRelationsEN.WorkUnit = objRow[convzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvzx_SocialRelationsEN.Major = objRow[convzx_SocialRelations.Major] == DBNull.Value ? null : objRow[convzx_SocialRelations.Major].ToString().Trim(); //专业
objvzx_SocialRelationsEN.Achievement = objRow[convzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[convzx_SocialRelations.Achievement].ToString().Trim(); //成就
objvzx_SocialRelationsEN.DetailedDescription = objRow[convzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvzx_SocialRelationsEN.UpdUser = objRow[convzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objvzx_SocialRelationsEN.CreateDate = objRow[convzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objvzx_SocialRelationsEN.UpdDate = objRow[convzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objvzx_SocialRelationsEN.IsSubmit = TransNullToBool(objRow[convzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvzx_SocialRelationsEN.VoteCount = objRow[convzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objvzx_SocialRelationsEN.CitationCount = objRow[convzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objvzx_SocialRelationsEN.VersionCount = objRow[convzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objvzx_SocialRelationsEN.IdCurrEduCls = objRow[convzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SocialRelationsEN.AppraiseCount = objRow[convzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvzx_SocialRelationsEN.Score = objRow[convzx_SocialRelations.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SocialRelations.Score].ToString().Trim()); //评分
objvzx_SocialRelationsEN.GroupTextId = objRow[convzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
objvzx_SocialRelationsEN.PdfZoom = objRow[convzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SocialRelationsEN.PdfPageTop = objRow[convzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SocialRelationsEN.PdfPageNumIn = objRow[convzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SocialRelationsEN.PdfDivTop = objRow[convzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SocialRelationsEN.PdfDivLet = objRow[convzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SocialRelationsEN.Memo = objRow[convzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[convzx_SocialRelations.Memo].ToString().Trim(); //备注
objvzx_SocialRelationsEN.PdfPageNum = objRow[convzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SocialRelationsEN.PdfContent = objRow[convzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvzx_SocialRelationsEN.zxShareId = objRow[convzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objvzx_SocialRelationsEN.TextId = objRow[convzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objvzx_SocialRelationsEN.TeaScore = objRow[convzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objvzx_SocialRelationsEN.StuScore = objRow[convzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objvzx_SocialRelationsEN.zxLevelId = objRow[convzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_SocialRelationsDA: GetObjLst)", objException.Message));
}
objvzx_SocialRelationsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_SocialRelationsEN);
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
public List<clsvzx_SocialRelationsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_SocialRelationsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_SocialRelationsEN> arrObjLst = new List<clsvzx_SocialRelationsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = new clsvzx_SocialRelationsEN();
try
{
objvzx_SocialRelationsEN.zxSocialId = objRow[convzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objvzx_SocialRelationsEN.FullName = objRow[convzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[convzx_SocialRelations.FullName].ToString().Trim(); //姓名
objvzx_SocialRelationsEN.Nationality = objRow[convzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[convzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objvzx_SocialRelationsEN.WorkUnit = objRow[convzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvzx_SocialRelationsEN.Major = objRow[convzx_SocialRelations.Major] == DBNull.Value ? null : objRow[convzx_SocialRelations.Major].ToString().Trim(); //专业
objvzx_SocialRelationsEN.Achievement = objRow[convzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[convzx_SocialRelations.Achievement].ToString().Trim(); //成就
objvzx_SocialRelationsEN.DetailedDescription = objRow[convzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvzx_SocialRelationsEN.UpdUser = objRow[convzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objvzx_SocialRelationsEN.CreateDate = objRow[convzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objvzx_SocialRelationsEN.UpdDate = objRow[convzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objvzx_SocialRelationsEN.IsSubmit = TransNullToBool(objRow[convzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvzx_SocialRelationsEN.VoteCount = objRow[convzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objvzx_SocialRelationsEN.CitationCount = objRow[convzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objvzx_SocialRelationsEN.VersionCount = objRow[convzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objvzx_SocialRelationsEN.IdCurrEduCls = objRow[convzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SocialRelationsEN.AppraiseCount = objRow[convzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvzx_SocialRelationsEN.Score = objRow[convzx_SocialRelations.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SocialRelations.Score].ToString().Trim()); //评分
objvzx_SocialRelationsEN.GroupTextId = objRow[convzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
objvzx_SocialRelationsEN.PdfZoom = objRow[convzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SocialRelationsEN.PdfPageTop = objRow[convzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SocialRelationsEN.PdfPageNumIn = objRow[convzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SocialRelationsEN.PdfDivTop = objRow[convzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SocialRelationsEN.PdfDivLet = objRow[convzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SocialRelationsEN.Memo = objRow[convzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[convzx_SocialRelations.Memo].ToString().Trim(); //备注
objvzx_SocialRelationsEN.PdfPageNum = objRow[convzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SocialRelationsEN.PdfContent = objRow[convzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvzx_SocialRelationsEN.zxShareId = objRow[convzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objvzx_SocialRelationsEN.TextId = objRow[convzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objvzx_SocialRelationsEN.TeaScore = objRow[convzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objvzx_SocialRelationsEN.StuScore = objRow[convzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objvzx_SocialRelationsEN.zxLevelId = objRow[convzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_SocialRelationsDA: GetObjLst)", objException.Message));
}
objvzx_SocialRelationsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_SocialRelationsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_SocialRelations(ref clsvzx_SocialRelationsEN objvzx_SocialRelationsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SocialRelations where zxSocialId = " + "'"+ objvzx_SocialRelationsEN.zxSocialId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_SocialRelationsEN.zxSocialId = objDT.Rows[0][convzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id(字段类型:char,字段长度:10,是否可空:False)
 objvzx_SocialRelationsEN.FullName = objDT.Rows[0][convzx_SocialRelations.FullName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SocialRelationsEN.Nationality = objDT.Rows[0][convzx_SocialRelations.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SocialRelationsEN.WorkUnit = objDT.Rows[0][convzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvzx_SocialRelationsEN.Major = objDT.Rows[0][convzx_SocialRelations.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SocialRelationsEN.Achievement = objDT.Rows[0][convzx_SocialRelations.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objvzx_SocialRelationsEN.DetailedDescription = objDT.Rows[0][convzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_SocialRelationsEN.UpdUser = objDT.Rows[0][convzx_SocialRelations.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SocialRelationsEN.CreateDate = objDT.Rows[0][convzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SocialRelationsEN.UpdDate = objDT.Rows[0][convzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SocialRelationsEN.IsSubmit = TransNullToBool(objDT.Rows[0][convzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_SocialRelationsEN.VoteCount = TransNullToInt(objDT.Rows[0][convzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SocialRelationsEN.CitationCount = TransNullToInt(objDT.Rows[0][convzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SocialRelationsEN.VersionCount = TransNullToInt(objDT.Rows[0][convzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SocialRelationsEN.IdCurrEduCls = objDT.Rows[0][convzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_SocialRelationsEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SocialRelationsEN.Score = TransNullToFloat(objDT.Rows[0][convzx_SocialRelations.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_SocialRelationsEN.GroupTextId = objDT.Rows[0][convzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_SocialRelationsEN.PdfZoom = objDT.Rows[0][convzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SocialRelationsEN.PdfPageTop = TransNullToInt(objDT.Rows[0][convzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SocialRelationsEN.PdfPageNumIn = objDT.Rows[0][convzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SocialRelationsEN.PdfDivTop = objDT.Rows[0][convzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SocialRelationsEN.PdfDivLet = objDT.Rows[0][convzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SocialRelationsEN.Memo = objDT.Rows[0][convzx_SocialRelations.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_SocialRelationsEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SocialRelationsEN.PdfContent = objDT.Rows[0][convzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_SocialRelationsEN.zxShareId = objDT.Rows[0][convzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_SocialRelationsEN.TextId = objDT.Rows[0][convzx_SocialRelations.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_SocialRelationsEN.TeaScore = TransNullToFloat(objDT.Rows[0][convzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_SocialRelationsEN.StuScore = TransNullToFloat(objDT.Rows[0][convzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_SocialRelationsEN.zxLevelId = objDT.Rows[0][convzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_SocialRelationsDA: Getvzx_SocialRelations)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxSocialId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_SocialRelationsEN GetObjByzxSocialId(string strzxSocialId)
{
CheckPrimaryKey(strzxSocialId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SocialRelations where zxSocialId = " + "'"+ strzxSocialId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = new clsvzx_SocialRelationsEN();
try
{
 objvzx_SocialRelationsEN.zxSocialId = objRow[convzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id(字段类型:char,字段长度:10,是否可空:False)
 objvzx_SocialRelationsEN.FullName = objRow[convzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[convzx_SocialRelations.FullName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SocialRelationsEN.Nationality = objRow[convzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[convzx_SocialRelations.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SocialRelationsEN.WorkUnit = objRow[convzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvzx_SocialRelationsEN.Major = objRow[convzx_SocialRelations.Major] == DBNull.Value ? null : objRow[convzx_SocialRelations.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SocialRelationsEN.Achievement = objRow[convzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[convzx_SocialRelations.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objvzx_SocialRelationsEN.DetailedDescription = objRow[convzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_SocialRelationsEN.UpdUser = objRow[convzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SocialRelationsEN.CreateDate = objRow[convzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SocialRelationsEN.UpdDate = objRow[convzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_SocialRelationsEN.VoteCount = objRow[convzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SocialRelationsEN.CitationCount = objRow[convzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SocialRelationsEN.VersionCount = objRow[convzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SocialRelationsEN.IdCurrEduCls = objRow[convzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_SocialRelationsEN.AppraiseCount = objRow[convzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SocialRelationsEN.Score = objRow[convzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_SocialRelationsEN.GroupTextId = objRow[convzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_SocialRelationsEN.PdfZoom = objRow[convzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SocialRelationsEN.PdfPageTop = objRow[convzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SocialRelationsEN.PdfPageNumIn = objRow[convzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SocialRelationsEN.PdfDivTop = objRow[convzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SocialRelationsEN.PdfDivLet = objRow[convzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SocialRelationsEN.Memo = objRow[convzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[convzx_SocialRelations.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_SocialRelationsEN.PdfPageNum = objRow[convzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SocialRelationsEN.PdfContent = objRow[convzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_SocialRelationsEN.zxShareId = objRow[convzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_SocialRelationsEN.TextId = objRow[convzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_SocialRelationsEN.TeaScore = objRow[convzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_SocialRelationsEN.StuScore = objRow[convzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_SocialRelationsEN.zxLevelId = objRow[convzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_SocialRelationsDA: GetObjByzxSocialId)", objException.Message));
}
return objvzx_SocialRelationsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_SocialRelationsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_SocialRelationsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SocialRelations where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = new clsvzx_SocialRelationsEN()
{
zxSocialId = objRow[convzx_SocialRelations.zxSocialId].ToString().Trim(), //社会Id
FullName = objRow[convzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[convzx_SocialRelations.FullName].ToString().Trim(), //姓名
Nationality = objRow[convzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[convzx_SocialRelations.Nationality].ToString().Trim(), //国籍
WorkUnit = objRow[convzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convzx_SocialRelations.WorkUnit].ToString().Trim(), //工作单位
Major = objRow[convzx_SocialRelations.Major] == DBNull.Value ? null : objRow[convzx_SocialRelations.Major].ToString().Trim(), //专业
Achievement = objRow[convzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[convzx_SocialRelations.Achievement].ToString().Trim(), //成就
DetailedDescription = objRow[convzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convzx_SocialRelations.DetailedDescription].ToString().Trim(), //详细说明
UpdUser = objRow[convzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdUser].ToString().Trim(), //修改人
CreateDate = objRow[convzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.CreateDate].ToString().Trim(), //建立日期
UpdDate = objRow[convzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdDate].ToString().Trim(), //修改日期
IsSubmit = TransNullToBool(objRow[convzx_SocialRelations.IsSubmit].ToString().Trim()), //是否提交
VoteCount = objRow[convzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.VoteCount].ToString().Trim()), //点赞计数
CitationCount = objRow[convzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[convzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.VersionCount].ToString().Trim()), //版本统计
IdCurrEduCls = objRow[convzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SocialRelations.IdCurrEduCls].ToString().Trim(), //教学班流水号
AppraiseCount = objRow[convzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[convzx_SocialRelations.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SocialRelations.Score].ToString().Trim()), //评分
GroupTextId = objRow[convzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.GroupTextId].ToString().Trim(), //小组Id
PdfZoom = objRow[convzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfZoom].ToString().Trim(), //PdfZoom
PdfPageTop = objRow[convzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfPageNumIn = objRow[convzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfDivTop = objRow[convzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfDivLet = objRow[convzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivLet].ToString().Trim(), //PdfDivLet
Memo = objRow[convzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[convzx_SocialRelations.Memo].ToString().Trim(), //备注
PdfPageNum = objRow[convzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.PdfPageNum].ToString().Trim()), //Pdf页码
PdfContent = objRow[convzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfContent].ToString().Trim(), //Pdf内容
zxShareId = objRow[convzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxShareId].ToString().Trim(), //分享Id
TextId = objRow[convzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.TextId].ToString().Trim(), //课件Id
TeaScore = objRow[convzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SocialRelations.TeaScore].ToString().Trim()), //教师评分
StuScore = objRow[convzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SocialRelations.StuScore].ToString().Trim()), //学生平均分
zxLevelId = objRow[convzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxLevelId].ToString().Trim() //级别Id
};
objvzx_SocialRelationsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_SocialRelationsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_SocialRelationsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_SocialRelationsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = new clsvzx_SocialRelationsEN();
try
{
objvzx_SocialRelationsEN.zxSocialId = objRow[convzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objvzx_SocialRelationsEN.FullName = objRow[convzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[convzx_SocialRelations.FullName].ToString().Trim(); //姓名
objvzx_SocialRelationsEN.Nationality = objRow[convzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[convzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objvzx_SocialRelationsEN.WorkUnit = objRow[convzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvzx_SocialRelationsEN.Major = objRow[convzx_SocialRelations.Major] == DBNull.Value ? null : objRow[convzx_SocialRelations.Major].ToString().Trim(); //专业
objvzx_SocialRelationsEN.Achievement = objRow[convzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[convzx_SocialRelations.Achievement].ToString().Trim(); //成就
objvzx_SocialRelationsEN.DetailedDescription = objRow[convzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvzx_SocialRelationsEN.UpdUser = objRow[convzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objvzx_SocialRelationsEN.CreateDate = objRow[convzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objvzx_SocialRelationsEN.UpdDate = objRow[convzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objvzx_SocialRelationsEN.IsSubmit = TransNullToBool(objRow[convzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvzx_SocialRelationsEN.VoteCount = objRow[convzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objvzx_SocialRelationsEN.CitationCount = objRow[convzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objvzx_SocialRelationsEN.VersionCount = objRow[convzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objvzx_SocialRelationsEN.IdCurrEduCls = objRow[convzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SocialRelationsEN.AppraiseCount = objRow[convzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvzx_SocialRelationsEN.Score = objRow[convzx_SocialRelations.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SocialRelations.Score].ToString().Trim()); //评分
objvzx_SocialRelationsEN.GroupTextId = objRow[convzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
objvzx_SocialRelationsEN.PdfZoom = objRow[convzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SocialRelationsEN.PdfPageTop = objRow[convzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SocialRelationsEN.PdfPageNumIn = objRow[convzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SocialRelationsEN.PdfDivTop = objRow[convzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SocialRelationsEN.PdfDivLet = objRow[convzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SocialRelationsEN.Memo = objRow[convzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[convzx_SocialRelations.Memo].ToString().Trim(); //备注
objvzx_SocialRelationsEN.PdfPageNum = objRow[convzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SocialRelationsEN.PdfContent = objRow[convzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvzx_SocialRelationsEN.zxShareId = objRow[convzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objvzx_SocialRelationsEN.TextId = objRow[convzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objvzx_SocialRelationsEN.TeaScore = objRow[convzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objvzx_SocialRelationsEN.StuScore = objRow[convzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objvzx_SocialRelationsEN.zxLevelId = objRow[convzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_SocialRelationsDA: GetObjByDataRowvzx_SocialRelations)", objException.Message));
}
objvzx_SocialRelationsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_SocialRelationsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_SocialRelationsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = new clsvzx_SocialRelationsEN();
try
{
objvzx_SocialRelationsEN.zxSocialId = objRow[convzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objvzx_SocialRelationsEN.FullName = objRow[convzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[convzx_SocialRelations.FullName].ToString().Trim(); //姓名
objvzx_SocialRelationsEN.Nationality = objRow[convzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[convzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objvzx_SocialRelationsEN.WorkUnit = objRow[convzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvzx_SocialRelationsEN.Major = objRow[convzx_SocialRelations.Major] == DBNull.Value ? null : objRow[convzx_SocialRelations.Major].ToString().Trim(); //专业
objvzx_SocialRelationsEN.Achievement = objRow[convzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[convzx_SocialRelations.Achievement].ToString().Trim(); //成就
objvzx_SocialRelationsEN.DetailedDescription = objRow[convzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvzx_SocialRelationsEN.UpdUser = objRow[convzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objvzx_SocialRelationsEN.CreateDate = objRow[convzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objvzx_SocialRelationsEN.UpdDate = objRow[convzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objvzx_SocialRelationsEN.IsSubmit = TransNullToBool(objRow[convzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvzx_SocialRelationsEN.VoteCount = objRow[convzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objvzx_SocialRelationsEN.CitationCount = objRow[convzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objvzx_SocialRelationsEN.VersionCount = objRow[convzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objvzx_SocialRelationsEN.IdCurrEduCls = objRow[convzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SocialRelationsEN.AppraiseCount = objRow[convzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvzx_SocialRelationsEN.Score = objRow[convzx_SocialRelations.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SocialRelations.Score].ToString().Trim()); //评分
objvzx_SocialRelationsEN.GroupTextId = objRow[convzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
objvzx_SocialRelationsEN.PdfZoom = objRow[convzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SocialRelationsEN.PdfPageTop = objRow[convzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SocialRelationsEN.PdfPageNumIn = objRow[convzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SocialRelationsEN.PdfDivTop = objRow[convzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SocialRelationsEN.PdfDivLet = objRow[convzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SocialRelationsEN.Memo = objRow[convzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[convzx_SocialRelations.Memo].ToString().Trim(); //备注
objvzx_SocialRelationsEN.PdfPageNum = objRow[convzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SocialRelationsEN.PdfContent = objRow[convzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvzx_SocialRelationsEN.zxShareId = objRow[convzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objvzx_SocialRelationsEN.TextId = objRow[convzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objvzx_SocialRelationsEN.TeaScore = objRow[convzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objvzx_SocialRelationsEN.StuScore = objRow[convzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objvzx_SocialRelationsEN.zxLevelId = objRow[convzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_SocialRelationsDA: GetObjByDataRow)", objException.Message));
}
objvzx_SocialRelationsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_SocialRelationsEN;
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
objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_SocialRelationsEN._CurrTabName, convzx_SocialRelations.zxSocialId, 10, "");
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
objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_SocialRelationsEN._CurrTabName, convzx_SocialRelations.zxSocialId, 10, strPrefix);
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
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxSocialId from vzx_SocialRelations where " + strCondition;
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
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxSocialId from vzx_SocialRelations where " + strCondition;
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
 /// <param name = "strzxSocialId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxSocialId)
{
CheckPrimaryKey(strzxSocialId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_SocialRelations", "zxSocialId = " + "'"+ strzxSocialId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_SocialRelationsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_SocialRelations", strCondition))
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
objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_SocialRelations");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsENS">源对象</param>
 /// <param name = "objvzx_SocialRelationsENT">目标对象</param>
public void CopyTo(clsvzx_SocialRelationsEN objvzx_SocialRelationsENS, clsvzx_SocialRelationsEN objvzx_SocialRelationsENT)
{
objvzx_SocialRelationsENT.zxSocialId = objvzx_SocialRelationsENS.zxSocialId; //社会Id
objvzx_SocialRelationsENT.FullName = objvzx_SocialRelationsENS.FullName; //姓名
objvzx_SocialRelationsENT.Nationality = objvzx_SocialRelationsENS.Nationality; //国籍
objvzx_SocialRelationsENT.WorkUnit = objvzx_SocialRelationsENS.WorkUnit; //工作单位
objvzx_SocialRelationsENT.Major = objvzx_SocialRelationsENS.Major; //专业
objvzx_SocialRelationsENT.Achievement = objvzx_SocialRelationsENS.Achievement; //成就
objvzx_SocialRelationsENT.DetailedDescription = objvzx_SocialRelationsENS.DetailedDescription; //详细说明
objvzx_SocialRelationsENT.UpdUser = objvzx_SocialRelationsENS.UpdUser; //修改人
objvzx_SocialRelationsENT.CreateDate = objvzx_SocialRelationsENS.CreateDate; //建立日期
objvzx_SocialRelationsENT.UpdDate = objvzx_SocialRelationsENS.UpdDate; //修改日期
objvzx_SocialRelationsENT.IsSubmit = objvzx_SocialRelationsENS.IsSubmit; //是否提交
objvzx_SocialRelationsENT.VoteCount = objvzx_SocialRelationsENS.VoteCount; //点赞计数
objvzx_SocialRelationsENT.CitationCount = objvzx_SocialRelationsENS.CitationCount; //引用统计
objvzx_SocialRelationsENT.VersionCount = objvzx_SocialRelationsENS.VersionCount; //版本统计
objvzx_SocialRelationsENT.IdCurrEduCls = objvzx_SocialRelationsENS.IdCurrEduCls; //教学班流水号
objvzx_SocialRelationsENT.AppraiseCount = objvzx_SocialRelationsENS.AppraiseCount; //评论数
objvzx_SocialRelationsENT.Score = objvzx_SocialRelationsENS.Score; //评分
objvzx_SocialRelationsENT.GroupTextId = objvzx_SocialRelationsENS.GroupTextId; //小组Id
objvzx_SocialRelationsENT.PdfZoom = objvzx_SocialRelationsENS.PdfZoom; //PdfZoom
objvzx_SocialRelationsENT.PdfPageTop = objvzx_SocialRelationsENS.PdfPageTop; //pdf页面顶部位置
objvzx_SocialRelationsENT.PdfPageNumIn = objvzx_SocialRelationsENS.PdfPageNumIn; //PdfPageNumIn
objvzx_SocialRelationsENT.PdfDivTop = objvzx_SocialRelationsENS.PdfDivTop; //PdfDivTop
objvzx_SocialRelationsENT.PdfDivLet = objvzx_SocialRelationsENS.PdfDivLet; //PdfDivLet
objvzx_SocialRelationsENT.Memo = objvzx_SocialRelationsENS.Memo; //备注
objvzx_SocialRelationsENT.PdfPageNum = objvzx_SocialRelationsENS.PdfPageNum; //Pdf页码
objvzx_SocialRelationsENT.PdfContent = objvzx_SocialRelationsENS.PdfContent; //Pdf内容
objvzx_SocialRelationsENT.zxShareId = objvzx_SocialRelationsENS.zxShareId; //分享Id
objvzx_SocialRelationsENT.TextId = objvzx_SocialRelationsENS.TextId; //课件Id
objvzx_SocialRelationsENT.TeaScore = objvzx_SocialRelationsENS.TeaScore; //教师评分
objvzx_SocialRelationsENT.StuScore = objvzx_SocialRelationsENS.StuScore; //学生平均分
objvzx_SocialRelationsENT.zxLevelId = objvzx_SocialRelationsENS.zxLevelId; //级别Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_SocialRelationsEN objvzx_SocialRelationsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.zxSocialId, 10, convzx_SocialRelations.zxSocialId);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.FullName, 50, convzx_SocialRelations.FullName);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.Nationality, 50, convzx_SocialRelations.Nationality);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.WorkUnit, 100, convzx_SocialRelations.WorkUnit);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.Major, 50, convzx_SocialRelations.Major);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.Achievement, 5000, convzx_SocialRelations.Achievement);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.UpdUser, 20, convzx_SocialRelations.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.CreateDate, 20, convzx_SocialRelations.CreateDate);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.UpdDate, 20, convzx_SocialRelations.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.IdCurrEduCls, 8, convzx_SocialRelations.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.GroupTextId, 8, convzx_SocialRelations.GroupTextId);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.PdfZoom, 50, convzx_SocialRelations.PdfZoom);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.PdfPageNumIn, 50, convzx_SocialRelations.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.PdfDivTop, 50, convzx_SocialRelations.PdfDivTop);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.PdfDivLet, 50, convzx_SocialRelations.PdfDivLet);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.Memo, 1000, convzx_SocialRelations.Memo);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.PdfContent, 2000, convzx_SocialRelations.PdfContent);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.zxShareId, 2, convzx_SocialRelations.zxShareId);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.TextId, 8, convzx_SocialRelations.TextId);
clsCheckSql.CheckFieldLen(objvzx_SocialRelationsEN.zxLevelId, 2, convzx_SocialRelations.zxLevelId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.zxSocialId, convzx_SocialRelations.zxSocialId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.FullName, convzx_SocialRelations.FullName);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.Nationality, convzx_SocialRelations.Nationality);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.WorkUnit, convzx_SocialRelations.WorkUnit);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.Major, convzx_SocialRelations.Major);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.Achievement, convzx_SocialRelations.Achievement);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.UpdUser, convzx_SocialRelations.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.CreateDate, convzx_SocialRelations.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.UpdDate, convzx_SocialRelations.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.IdCurrEduCls, convzx_SocialRelations.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.GroupTextId, convzx_SocialRelations.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.PdfZoom, convzx_SocialRelations.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.PdfPageNumIn, convzx_SocialRelations.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.PdfDivTop, convzx_SocialRelations.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.PdfDivLet, convzx_SocialRelations.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.Memo, convzx_SocialRelations.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.PdfContent, convzx_SocialRelations.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.zxShareId, convzx_SocialRelations.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.TextId, convzx_SocialRelations.TextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SocialRelationsEN.zxLevelId, convzx_SocialRelations.zxLevelId);
//检查外键字段长度
 objvzx_SocialRelationsEN._IsCheckProperty = true;
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
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
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
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
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
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_SocialRelationsEN._CurrTabName);
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
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_SocialRelationsEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_SocialRelationsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}