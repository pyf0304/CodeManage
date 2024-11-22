
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SocialRelationsDA
 表名:zx_SocialRelations(01120707)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:16
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 中学社会关系(zx_SocialRelations)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_SocialRelationsDA : clsCommBase4DA
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
 return clszx_SocialRelationsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_SocialRelationsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_SocialRelationsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_SocialRelationsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_SocialRelationsEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:zx_SocialRelations中,检查关键字,长度不正确!(clszx_SocialRelationsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxSocialId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_SocialRelations中,关键字不能为空 或 null!(clszx_SocialRelationsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxSocialId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_SocialRelationsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_SocialRelationsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelations where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_SocialRelations(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_SocialRelationsDA: GetDataTable_zx_SocialRelations)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelations where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_SocialRelationsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_SocialRelationsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelations where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_SocialRelationsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_SocialRelationsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_SocialRelations where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_SocialRelations where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_SocialRelationsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_SocialRelations where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_SocialRelationsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_SocialRelations.* from zx_SocialRelations Left Join {1} on {2} where {3} and zx_SocialRelations.zxSocialId not in (Select top {5} zx_SocialRelations.zxSocialId from zx_SocialRelations Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_SocialRelations where {1} and zxSocialId not in (Select top {2} zxSocialId from zx_SocialRelations where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_SocialRelations where {1} and zxSocialId not in (Select top {3} zxSocialId from zx_SocialRelations where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_SocialRelationsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_SocialRelations.* from zx_SocialRelations Left Join {1} on {2} where {3} and zx_SocialRelations.zxSocialId not in (Select top {5} zx_SocialRelations.zxSocialId from zx_SocialRelations Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_SocialRelations where {1} and zxSocialId not in (Select top {2} zxSocialId from zx_SocialRelations where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_SocialRelations where {1} and zxSocialId not in (Select top {3} zxSocialId from zx_SocialRelations where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_SocialRelationsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_SocialRelationsDA:GetObjLst)", objException.Message));
}
List<clszx_SocialRelationsEN> arrObjLst = new List<clszx_SocialRelationsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelations where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN();
try
{
objzx_SocialRelationsEN.zxSocialId = objRow[conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsEN.FullName = objRow[conzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelations.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsEN.Nationality = objRow[conzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsEN.WorkUnit = objRow[conzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsEN.Major = objRow[conzx_SocialRelations.Major] == DBNull.Value ? null : objRow[conzx_SocialRelations.Major].ToString().Trim(); //专业
objzx_SocialRelationsEN.Achievement = objRow[conzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelations.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsEN.DetailedDescription = objRow[conzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsEN.zxLevelId = objRow[conzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsEN.IsSubmit = TransNullToBool(objRow[conzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsEN.VoteCount = objRow[conzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsEN.CitationCount = objRow[conzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsEN.VersionCount = objRow[conzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsEN.IdCurrEduCls = objRow[conzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsEN.AppraiseCount = objRow[conzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsEN.Score = objRow[conzx_SocialRelations.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelations.Score].ToString().Trim()); //评分
objzx_SocialRelationsEN.StuScore = objRow[conzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsEN.TeaScore = objRow[conzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsEN.TextId = objRow[conzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsEN.zxShareId = objRow[conzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsEN.PdfContent = objRow[conzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsEN.PdfPageNum = objRow[conzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsEN.UpdUser = objRow[conzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsEN.CreateDate = objRow[conzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsEN.UpdDate = objRow[conzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsEN.Memo = objRow[conzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelations.Memo].ToString().Trim(); //备注
objzx_SocialRelationsEN.PdfDivLet = objRow[conzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsEN.PdfDivTop = objRow[conzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsEN.PdfPageNumIn = objRow[conzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsEN.PdfPageTop = objRow[conzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsEN.PdfZoom = objRow[conzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsEN.GroupTextId = objRow[conzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_SocialRelationsDA: GetObjLst)", objException.Message));
}
objzx_SocialRelationsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_SocialRelationsEN);
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
public List<clszx_SocialRelationsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_SocialRelationsDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_SocialRelationsEN> arrObjLst = new List<clszx_SocialRelationsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN();
try
{
objzx_SocialRelationsEN.zxSocialId = objRow[conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsEN.FullName = objRow[conzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelations.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsEN.Nationality = objRow[conzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsEN.WorkUnit = objRow[conzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsEN.Major = objRow[conzx_SocialRelations.Major] == DBNull.Value ? null : objRow[conzx_SocialRelations.Major].ToString().Trim(); //专业
objzx_SocialRelationsEN.Achievement = objRow[conzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelations.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsEN.DetailedDescription = objRow[conzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsEN.zxLevelId = objRow[conzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsEN.IsSubmit = TransNullToBool(objRow[conzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsEN.VoteCount = objRow[conzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsEN.CitationCount = objRow[conzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsEN.VersionCount = objRow[conzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsEN.IdCurrEduCls = objRow[conzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsEN.AppraiseCount = objRow[conzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsEN.Score = objRow[conzx_SocialRelations.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelations.Score].ToString().Trim()); //评分
objzx_SocialRelationsEN.StuScore = objRow[conzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsEN.TeaScore = objRow[conzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsEN.TextId = objRow[conzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsEN.zxShareId = objRow[conzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsEN.PdfContent = objRow[conzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsEN.PdfPageNum = objRow[conzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsEN.UpdUser = objRow[conzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsEN.CreateDate = objRow[conzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsEN.UpdDate = objRow[conzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsEN.Memo = objRow[conzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelations.Memo].ToString().Trim(); //备注
objzx_SocialRelationsEN.PdfDivLet = objRow[conzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsEN.PdfDivTop = objRow[conzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsEN.PdfPageNumIn = objRow[conzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsEN.PdfPageTop = objRow[conzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsEN.PdfZoom = objRow[conzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsEN.GroupTextId = objRow[conzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_SocialRelationsDA: GetObjLst)", objException.Message));
}
objzx_SocialRelationsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_SocialRelationsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_SocialRelations(ref clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelations where zxSocialId = " + "'"+ objzx_SocialRelationsEN.zxSocialId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_SocialRelationsEN.zxSocialId = objDT.Rows[0][conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_SocialRelationsEN.FullName = objDT.Rows[0][conzx_SocialRelations.FullName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsEN.Nationality = objDT.Rows[0][conzx_SocialRelations.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsEN.WorkUnit = objDT.Rows[0][conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objzx_SocialRelationsEN.Major = objDT.Rows[0][conzx_SocialRelations.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsEN.Achievement = objDT.Rows[0][conzx_SocialRelations.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_SocialRelationsEN.DetailedDescription = objDT.Rows[0][conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_SocialRelationsEN.zxLevelId = objDT.Rows[0][conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objzx_SocialRelationsEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_SocialRelationsEN.VoteCount = TransNullToInt(objDT.Rows[0][conzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsEN.CitationCount = TransNullToInt(objDT.Rows[0][conzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsEN.VersionCount = TransNullToInt(objDT.Rows[0][conzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsEN.IdCurrEduCls = objDT.Rows[0][conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_SocialRelationsEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsEN.Score = TransNullToFloat(objDT.Rows[0][conzx_SocialRelations.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SocialRelationsEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SocialRelationsEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SocialRelationsEN.TextId = objDT.Rows[0][conzx_SocialRelations.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_SocialRelationsEN.zxShareId = objDT.Rows[0][conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_SocialRelationsEN.PdfContent = objDT.Rows[0][conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_SocialRelationsEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsEN.UpdUser = objDT.Rows[0][conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SocialRelationsEN.CreateDate = objDT.Rows[0][conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SocialRelationsEN.UpdDate = objDT.Rows[0][conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SocialRelationsEN.Memo = objDT.Rows[0][conzx_SocialRelations.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_SocialRelationsEN.PdfDivLet = objDT.Rows[0][conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsEN.PdfDivTop = objDT.Rows[0][conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsEN.PdfPageNumIn = objDT.Rows[0][conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsEN.PdfPageTop = TransNullToInt(objDT.Rows[0][conzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsEN.PdfZoom = objDT.Rows[0][conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsEN.GroupTextId = objDT.Rows[0][conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_SocialRelationsDA: Getzx_SocialRelations)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxSocialId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_SocialRelationsEN GetObjByzxSocialId(string strzxSocialId)
{
CheckPrimaryKey(strzxSocialId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelations where zxSocialId = " + "'"+ strzxSocialId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN();
try
{
 objzx_SocialRelationsEN.zxSocialId = objRow[conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_SocialRelationsEN.FullName = objRow[conzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelations.FullName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsEN.Nationality = objRow[conzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelations.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsEN.WorkUnit = objRow[conzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objzx_SocialRelationsEN.Major = objRow[conzx_SocialRelations.Major] == DBNull.Value ? null : objRow[conzx_SocialRelations.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsEN.Achievement = objRow[conzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelations.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_SocialRelationsEN.DetailedDescription = objRow[conzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_SocialRelationsEN.zxLevelId = objRow[conzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_SocialRelationsEN.VoteCount = objRow[conzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsEN.CitationCount = objRow[conzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsEN.VersionCount = objRow[conzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsEN.IdCurrEduCls = objRow[conzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_SocialRelationsEN.AppraiseCount = objRow[conzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsEN.Score = objRow[conzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SocialRelationsEN.StuScore = objRow[conzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SocialRelationsEN.TeaScore = objRow[conzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SocialRelationsEN.TextId = objRow[conzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_SocialRelationsEN.zxShareId = objRow[conzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_SocialRelationsEN.PdfContent = objRow[conzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_SocialRelationsEN.PdfPageNum = objRow[conzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsEN.UpdUser = objRow[conzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SocialRelationsEN.CreateDate = objRow[conzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SocialRelationsEN.UpdDate = objRow[conzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SocialRelationsEN.Memo = objRow[conzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelations.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_SocialRelationsEN.PdfDivLet = objRow[conzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsEN.PdfDivTop = objRow[conzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsEN.PdfPageNumIn = objRow[conzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsEN.PdfPageTop = objRow[conzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsEN.PdfZoom = objRow[conzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsEN.GroupTextId = objRow[conzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_SocialRelationsDA: GetObjByzxSocialId)", objException.Message));
}
return objzx_SocialRelationsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_SocialRelationsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_SocialRelationsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelations where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN()
{
zxSocialId = objRow[conzx_SocialRelations.zxSocialId].ToString().Trim(), //社会Id
FullName = objRow[conzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelations.FullName].ToString().Trim(), //姓名
Nationality = objRow[conzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelations.Nationality].ToString().Trim(), //国籍
WorkUnit = objRow[conzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelations.WorkUnit].ToString().Trim(), //工作单位
Major = objRow[conzx_SocialRelations.Major] == DBNull.Value ? null : objRow[conzx_SocialRelations.Major].ToString().Trim(), //专业
Achievement = objRow[conzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelations.Achievement].ToString().Trim(), //成就
DetailedDescription = objRow[conzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(), //详细说明
zxLevelId = objRow[conzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxLevelId].ToString().Trim(), //级别Id
IsSubmit = TransNullToBool(objRow[conzx_SocialRelations.IsSubmit].ToString().Trim()), //是否提交
VoteCount = objRow[conzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.VoteCount].ToString().Trim()), //点赞计数
CitationCount = objRow[conzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[conzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.VersionCount].ToString().Trim()), //版本统计
IdCurrEduCls = objRow[conzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(), //教学班流水号
AppraiseCount = objRow[conzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[conzx_SocialRelations.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelations.Score].ToString().Trim()), //评分
StuScore = objRow[conzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelations.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelations.TeaScore].ToString().Trim()), //教师评分
TextId = objRow[conzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.TextId].ToString().Trim(), //课件Id
zxShareId = objRow[conzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxShareId].ToString().Trim(), //分享Id
PdfContent = objRow[conzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.PdfPageNum].ToString().Trim()), //Pdf页码
UpdUser = objRow[conzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdUser].ToString().Trim(), //修改人
CreateDate = objRow[conzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.CreateDate].ToString().Trim(), //建立日期
UpdDate = objRow[conzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelations.Memo].ToString().Trim(), //备注
PdfDivLet = objRow[conzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[conzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfPageNumIn = objRow[conzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[conzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfZoom = objRow[conzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfZoom].ToString().Trim(), //PdfZoom
GroupTextId = objRow[conzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.GroupTextId].ToString().Trim() //小组Id
};
objzx_SocialRelationsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SocialRelationsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_SocialRelationsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_SocialRelationsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN();
try
{
objzx_SocialRelationsEN.zxSocialId = objRow[conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsEN.FullName = objRow[conzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelations.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsEN.Nationality = objRow[conzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsEN.WorkUnit = objRow[conzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsEN.Major = objRow[conzx_SocialRelations.Major] == DBNull.Value ? null : objRow[conzx_SocialRelations.Major].ToString().Trim(); //专业
objzx_SocialRelationsEN.Achievement = objRow[conzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelations.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsEN.DetailedDescription = objRow[conzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsEN.zxLevelId = objRow[conzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsEN.IsSubmit = TransNullToBool(objRow[conzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsEN.VoteCount = objRow[conzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsEN.CitationCount = objRow[conzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsEN.VersionCount = objRow[conzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsEN.IdCurrEduCls = objRow[conzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsEN.AppraiseCount = objRow[conzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsEN.Score = objRow[conzx_SocialRelations.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelations.Score].ToString().Trim()); //评分
objzx_SocialRelationsEN.StuScore = objRow[conzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsEN.TeaScore = objRow[conzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsEN.TextId = objRow[conzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsEN.zxShareId = objRow[conzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsEN.PdfContent = objRow[conzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsEN.PdfPageNum = objRow[conzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsEN.UpdUser = objRow[conzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsEN.CreateDate = objRow[conzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsEN.UpdDate = objRow[conzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsEN.Memo = objRow[conzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelations.Memo].ToString().Trim(); //备注
objzx_SocialRelationsEN.PdfDivLet = objRow[conzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsEN.PdfDivTop = objRow[conzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsEN.PdfPageNumIn = objRow[conzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsEN.PdfPageTop = objRow[conzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsEN.PdfZoom = objRow[conzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsEN.GroupTextId = objRow[conzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_SocialRelationsDA: GetObjByDataRowzx_SocialRelations)", objException.Message));
}
objzx_SocialRelationsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SocialRelationsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_SocialRelationsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN();
try
{
objzx_SocialRelationsEN.zxSocialId = objRow[conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsEN.FullName = objRow[conzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelations.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsEN.Nationality = objRow[conzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsEN.WorkUnit = objRow[conzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsEN.Major = objRow[conzx_SocialRelations.Major] == DBNull.Value ? null : objRow[conzx_SocialRelations.Major].ToString().Trim(); //专业
objzx_SocialRelationsEN.Achievement = objRow[conzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelations.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsEN.DetailedDescription = objRow[conzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsEN.zxLevelId = objRow[conzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsEN.IsSubmit = TransNullToBool(objRow[conzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsEN.VoteCount = objRow[conzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsEN.CitationCount = objRow[conzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsEN.VersionCount = objRow[conzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsEN.IdCurrEduCls = objRow[conzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsEN.AppraiseCount = objRow[conzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsEN.Score = objRow[conzx_SocialRelations.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelations.Score].ToString().Trim()); //评分
objzx_SocialRelationsEN.StuScore = objRow[conzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsEN.TeaScore = objRow[conzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsEN.TextId = objRow[conzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsEN.zxShareId = objRow[conzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsEN.PdfContent = objRow[conzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsEN.PdfPageNum = objRow[conzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsEN.UpdUser = objRow[conzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsEN.CreateDate = objRow[conzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsEN.UpdDate = objRow[conzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsEN.Memo = objRow[conzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelations.Memo].ToString().Trim(); //备注
objzx_SocialRelationsEN.PdfDivLet = objRow[conzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsEN.PdfDivTop = objRow[conzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsEN.PdfPageNumIn = objRow[conzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsEN.PdfPageTop = objRow[conzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsEN.PdfZoom = objRow[conzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsEN.GroupTextId = objRow[conzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_SocialRelationsDA: GetObjByDataRow)", objException.Message));
}
objzx_SocialRelationsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SocialRelationsEN;
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
objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_SocialRelationsEN._CurrTabName, conzx_SocialRelations.zxSocialId, 10, "");
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
objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_SocialRelationsEN._CurrTabName, conzx_SocialRelations.zxSocialId, 10, strPrefix);
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
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxSocialId from zx_SocialRelations where " + strCondition;
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
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxSocialId from zx_SocialRelations where " + strCondition;
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
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_SocialRelations", "zxSocialId = " + "'"+ strzxSocialId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_SocialRelationsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_SocialRelations", strCondition))
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
objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_SocialRelations");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_SocialRelationsEN objzx_SocialRelationsEN)
 {
 if (objzx_SocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SocialRelationsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelations where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_SocialRelations");
objRow = objDS.Tables["zx_SocialRelations"].NewRow();
objRow[conzx_SocialRelations.zxSocialId] = objzx_SocialRelationsEN.zxSocialId; //社会Id
 if (objzx_SocialRelationsEN.FullName !=  "")
 {
objRow[conzx_SocialRelations.FullName] = objzx_SocialRelationsEN.FullName; //姓名
 }
 if (objzx_SocialRelationsEN.Nationality !=  "")
 {
objRow[conzx_SocialRelations.Nationality] = objzx_SocialRelationsEN.Nationality; //国籍
 }
 if (objzx_SocialRelationsEN.WorkUnit !=  "")
 {
objRow[conzx_SocialRelations.WorkUnit] = objzx_SocialRelationsEN.WorkUnit; //工作单位
 }
 if (objzx_SocialRelationsEN.Major !=  "")
 {
objRow[conzx_SocialRelations.Major] = objzx_SocialRelationsEN.Major; //专业
 }
 if (objzx_SocialRelationsEN.Achievement !=  "")
 {
objRow[conzx_SocialRelations.Achievement] = objzx_SocialRelationsEN.Achievement; //成就
 }
 if (objzx_SocialRelationsEN.DetailedDescription !=  "")
 {
objRow[conzx_SocialRelations.DetailedDescription] = objzx_SocialRelationsEN.DetailedDescription; //详细说明
 }
 if (objzx_SocialRelationsEN.zxLevelId !=  "")
 {
objRow[conzx_SocialRelations.zxLevelId] = objzx_SocialRelationsEN.zxLevelId; //级别Id
 }
objRow[conzx_SocialRelations.IsSubmit] = objzx_SocialRelationsEN.IsSubmit; //是否提交
objRow[conzx_SocialRelations.VoteCount] = objzx_SocialRelationsEN.VoteCount; //点赞计数
objRow[conzx_SocialRelations.CitationCount] = objzx_SocialRelationsEN.CitationCount; //引用统计
objRow[conzx_SocialRelations.VersionCount] = objzx_SocialRelationsEN.VersionCount; //版本统计
 if (objzx_SocialRelationsEN.IdCurrEduCls !=  "")
 {
objRow[conzx_SocialRelations.IdCurrEduCls] = objzx_SocialRelationsEN.IdCurrEduCls; //教学班流水号
 }
objRow[conzx_SocialRelations.AppraiseCount] = objzx_SocialRelationsEN.AppraiseCount; //评论数
objRow[conzx_SocialRelations.Score] = objzx_SocialRelationsEN.Score; //评分
objRow[conzx_SocialRelations.StuScore] = objzx_SocialRelationsEN.StuScore; //学生平均分
objRow[conzx_SocialRelations.TeaScore] = objzx_SocialRelationsEN.TeaScore; //教师评分
 if (objzx_SocialRelationsEN.TextId !=  "")
 {
objRow[conzx_SocialRelations.TextId] = objzx_SocialRelationsEN.TextId; //课件Id
 }
 if (objzx_SocialRelationsEN.zxShareId !=  "")
 {
objRow[conzx_SocialRelations.zxShareId] = objzx_SocialRelationsEN.zxShareId; //分享Id
 }
 if (objzx_SocialRelationsEN.PdfContent !=  "")
 {
objRow[conzx_SocialRelations.PdfContent] = objzx_SocialRelationsEN.PdfContent; //Pdf内容
 }
objRow[conzx_SocialRelations.PdfPageNum] = objzx_SocialRelationsEN.PdfPageNum; //Pdf页码
 if (objzx_SocialRelationsEN.UpdUser !=  "")
 {
objRow[conzx_SocialRelations.UpdUser] = objzx_SocialRelationsEN.UpdUser; //修改人
 }
 if (objzx_SocialRelationsEN.CreateDate !=  "")
 {
objRow[conzx_SocialRelations.CreateDate] = objzx_SocialRelationsEN.CreateDate; //建立日期
 }
 if (objzx_SocialRelationsEN.UpdDate !=  "")
 {
objRow[conzx_SocialRelations.UpdDate] = objzx_SocialRelationsEN.UpdDate; //修改日期
 }
 if (objzx_SocialRelationsEN.Memo !=  "")
 {
objRow[conzx_SocialRelations.Memo] = objzx_SocialRelationsEN.Memo; //备注
 }
 if (objzx_SocialRelationsEN.PdfDivLet !=  "")
 {
objRow[conzx_SocialRelations.PdfDivLet] = objzx_SocialRelationsEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_SocialRelationsEN.PdfDivTop !=  "")
 {
objRow[conzx_SocialRelations.PdfDivTop] = objzx_SocialRelationsEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_SocialRelationsEN.PdfPageNumIn !=  "")
 {
objRow[conzx_SocialRelations.PdfPageNumIn] = objzx_SocialRelationsEN.PdfPageNumIn; //PdfPageNumIn
 }
objRow[conzx_SocialRelations.PdfPageTop] = objzx_SocialRelationsEN.PdfPageTop; //pdf页面顶部位置
 if (objzx_SocialRelationsEN.PdfZoom !=  "")
 {
objRow[conzx_SocialRelations.PdfZoom] = objzx_SocialRelationsEN.PdfZoom; //PdfZoom
 }
 if (objzx_SocialRelationsEN.GroupTextId !=  "")
 {
objRow[conzx_SocialRelations.GroupTextId] = objzx_SocialRelationsEN.GroupTextId; //小组Id
 }
objDS.Tables[clszx_SocialRelationsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_SocialRelationsEN._CurrTabName);
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
 /// <param name = "objzx_SocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
 if (objzx_SocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SocialRelationsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_SocialRelationsEN.zxSocialId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.zxSocialId);
 var strzxSocialId = objzx_SocialRelationsEN.zxSocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxSocialId + "'");
 }
 
 if (objzx_SocialRelationsEN.FullName !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.FullName);
 var strFullName = objzx_SocialRelationsEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFullName + "'");
 }
 
 if (objzx_SocialRelationsEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Nationality);
 var strNationality = objzx_SocialRelationsEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objzx_SocialRelationsEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.WorkUnit);
 var strWorkUnit = objzx_SocialRelationsEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objzx_SocialRelationsEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Major);
 var strMajor = objzx_SocialRelationsEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objzx_SocialRelationsEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Achievement);
 var strAchievement = objzx_SocialRelationsEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objzx_SocialRelationsEN.DetailedDescription !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.DetailedDescription);
 var strDetailedDescription = objzx_SocialRelationsEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailedDescription + "'");
 }
 
 if (objzx_SocialRelationsEN.zxLevelId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.zxLevelId);
 var strzxLevelId = objzx_SocialRelationsEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLevelId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_SocialRelations.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SocialRelationsEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SocialRelationsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.VoteCount);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.VoteCount.ToString());
 }
 
 if (objzx_SocialRelationsEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.CitationCount);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.CitationCount.ToString());
 }
 
 if (objzx_SocialRelationsEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.VersionCount);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.VersionCount.ToString());
 }
 
 if (objzx_SocialRelationsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SocialRelationsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_SocialRelationsEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.AppraiseCount);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.AppraiseCount.ToString());
 }
 
 if (objzx_SocialRelationsEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Score);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.Score.ToString());
 }
 
 if (objzx_SocialRelationsEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.StuScore);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.StuScore.ToString());
 }
 
 if (objzx_SocialRelationsEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.TeaScore);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.TeaScore.ToString());
 }
 
 if (objzx_SocialRelationsEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.TextId);
 var strTextId = objzx_SocialRelationsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_SocialRelationsEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.zxShareId);
 var strzxShareId = objzx_SocialRelationsEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfContent);
 var strPdfContent = objzx_SocialRelationsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfPageNum);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.PdfPageNum.ToString());
 }
 
 if (objzx_SocialRelationsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.UpdUser);
 var strUpdUser = objzx_SocialRelationsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SocialRelationsEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.CreateDate);
 var strCreateDate = objzx_SocialRelationsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_SocialRelationsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.UpdDate);
 var strUpdDate = objzx_SocialRelationsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_SocialRelationsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Memo);
 var strMemo = objzx_SocialRelationsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfDivLet);
 var strPdfDivLet = objzx_SocialRelationsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfDivTop);
 var strPdfDivTop = objzx_SocialRelationsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfPageNumIn);
 var strPdfPageNumIn = objzx_SocialRelationsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfPageTop);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.PdfPageTop.ToString());
 }
 
 if (objzx_SocialRelationsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfZoom);
 var strPdfZoom = objzx_SocialRelationsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_SocialRelationsEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.GroupTextId);
 var strGroupTextId = objzx_SocialRelationsEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SocialRelations");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
 if (objzx_SocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SocialRelationsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_SocialRelationsEN.zxSocialId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.zxSocialId);
 var strzxSocialId = objzx_SocialRelationsEN.zxSocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxSocialId + "'");
 }
 
 if (objzx_SocialRelationsEN.FullName !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.FullName);
 var strFullName = objzx_SocialRelationsEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFullName + "'");
 }
 
 if (objzx_SocialRelationsEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Nationality);
 var strNationality = objzx_SocialRelationsEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objzx_SocialRelationsEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.WorkUnit);
 var strWorkUnit = objzx_SocialRelationsEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objzx_SocialRelationsEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Major);
 var strMajor = objzx_SocialRelationsEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objzx_SocialRelationsEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Achievement);
 var strAchievement = objzx_SocialRelationsEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objzx_SocialRelationsEN.DetailedDescription !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.DetailedDescription);
 var strDetailedDescription = objzx_SocialRelationsEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailedDescription + "'");
 }
 
 if (objzx_SocialRelationsEN.zxLevelId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.zxLevelId);
 var strzxLevelId = objzx_SocialRelationsEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLevelId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_SocialRelations.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SocialRelationsEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SocialRelationsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.VoteCount);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.VoteCount.ToString());
 }
 
 if (objzx_SocialRelationsEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.CitationCount);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.CitationCount.ToString());
 }
 
 if (objzx_SocialRelationsEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.VersionCount);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.VersionCount.ToString());
 }
 
 if (objzx_SocialRelationsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SocialRelationsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_SocialRelationsEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.AppraiseCount);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.AppraiseCount.ToString());
 }
 
 if (objzx_SocialRelationsEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Score);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.Score.ToString());
 }
 
 if (objzx_SocialRelationsEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.StuScore);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.StuScore.ToString());
 }
 
 if (objzx_SocialRelationsEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.TeaScore);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.TeaScore.ToString());
 }
 
 if (objzx_SocialRelationsEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.TextId);
 var strTextId = objzx_SocialRelationsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_SocialRelationsEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.zxShareId);
 var strzxShareId = objzx_SocialRelationsEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfContent);
 var strPdfContent = objzx_SocialRelationsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfPageNum);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.PdfPageNum.ToString());
 }
 
 if (objzx_SocialRelationsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.UpdUser);
 var strUpdUser = objzx_SocialRelationsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SocialRelationsEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.CreateDate);
 var strCreateDate = objzx_SocialRelationsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_SocialRelationsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.UpdDate);
 var strUpdDate = objzx_SocialRelationsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_SocialRelationsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Memo);
 var strMemo = objzx_SocialRelationsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfDivLet);
 var strPdfDivLet = objzx_SocialRelationsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfDivTop);
 var strPdfDivTop = objzx_SocialRelationsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfPageNumIn);
 var strPdfPageNumIn = objzx_SocialRelationsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfPageTop);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.PdfPageTop.ToString());
 }
 
 if (objzx_SocialRelationsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfZoom);
 var strPdfZoom = objzx_SocialRelationsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_SocialRelationsEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.GroupTextId);
 var strGroupTextId = objzx_SocialRelationsEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SocialRelations");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_SocialRelationsEN.zxSocialId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_SocialRelationsEN objzx_SocialRelationsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_SocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SocialRelationsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_SocialRelationsEN.zxSocialId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.zxSocialId);
 var strzxSocialId = objzx_SocialRelationsEN.zxSocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxSocialId + "'");
 }
 
 if (objzx_SocialRelationsEN.FullName !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.FullName);
 var strFullName = objzx_SocialRelationsEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFullName + "'");
 }
 
 if (objzx_SocialRelationsEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Nationality);
 var strNationality = objzx_SocialRelationsEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objzx_SocialRelationsEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.WorkUnit);
 var strWorkUnit = objzx_SocialRelationsEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objzx_SocialRelationsEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Major);
 var strMajor = objzx_SocialRelationsEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objzx_SocialRelationsEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Achievement);
 var strAchievement = objzx_SocialRelationsEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objzx_SocialRelationsEN.DetailedDescription !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.DetailedDescription);
 var strDetailedDescription = objzx_SocialRelationsEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailedDescription + "'");
 }
 
 if (objzx_SocialRelationsEN.zxLevelId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.zxLevelId);
 var strzxLevelId = objzx_SocialRelationsEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLevelId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_SocialRelations.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SocialRelationsEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SocialRelationsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.VoteCount);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.VoteCount.ToString());
 }
 
 if (objzx_SocialRelationsEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.CitationCount);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.CitationCount.ToString());
 }
 
 if (objzx_SocialRelationsEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.VersionCount);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.VersionCount.ToString());
 }
 
 if (objzx_SocialRelationsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SocialRelationsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_SocialRelationsEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.AppraiseCount);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.AppraiseCount.ToString());
 }
 
 if (objzx_SocialRelationsEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Score);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.Score.ToString());
 }
 
 if (objzx_SocialRelationsEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.StuScore);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.StuScore.ToString());
 }
 
 if (objzx_SocialRelationsEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.TeaScore);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.TeaScore.ToString());
 }
 
 if (objzx_SocialRelationsEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.TextId);
 var strTextId = objzx_SocialRelationsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_SocialRelationsEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.zxShareId);
 var strzxShareId = objzx_SocialRelationsEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfContent);
 var strPdfContent = objzx_SocialRelationsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfPageNum);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.PdfPageNum.ToString());
 }
 
 if (objzx_SocialRelationsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.UpdUser);
 var strUpdUser = objzx_SocialRelationsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SocialRelationsEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.CreateDate);
 var strCreateDate = objzx_SocialRelationsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_SocialRelationsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.UpdDate);
 var strUpdDate = objzx_SocialRelationsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_SocialRelationsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Memo);
 var strMemo = objzx_SocialRelationsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfDivLet);
 var strPdfDivLet = objzx_SocialRelationsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfDivTop);
 var strPdfDivTop = objzx_SocialRelationsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfPageNumIn);
 var strPdfPageNumIn = objzx_SocialRelationsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfPageTop);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.PdfPageTop.ToString());
 }
 
 if (objzx_SocialRelationsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfZoom);
 var strPdfZoom = objzx_SocialRelationsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_SocialRelationsEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.GroupTextId);
 var strGroupTextId = objzx_SocialRelationsEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SocialRelations");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_SocialRelationsEN.zxSocialId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_SocialRelationsEN objzx_SocialRelationsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_SocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SocialRelationsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_SocialRelationsEN.zxSocialId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.zxSocialId);
 var strzxSocialId = objzx_SocialRelationsEN.zxSocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxSocialId + "'");
 }
 
 if (objzx_SocialRelationsEN.FullName !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.FullName);
 var strFullName = objzx_SocialRelationsEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFullName + "'");
 }
 
 if (objzx_SocialRelationsEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Nationality);
 var strNationality = objzx_SocialRelationsEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objzx_SocialRelationsEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.WorkUnit);
 var strWorkUnit = objzx_SocialRelationsEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objzx_SocialRelationsEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Major);
 var strMajor = objzx_SocialRelationsEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objzx_SocialRelationsEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Achievement);
 var strAchievement = objzx_SocialRelationsEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objzx_SocialRelationsEN.DetailedDescription !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.DetailedDescription);
 var strDetailedDescription = objzx_SocialRelationsEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailedDescription + "'");
 }
 
 if (objzx_SocialRelationsEN.zxLevelId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.zxLevelId);
 var strzxLevelId = objzx_SocialRelationsEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLevelId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_SocialRelations.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SocialRelationsEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SocialRelationsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.VoteCount);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.VoteCount.ToString());
 }
 
 if (objzx_SocialRelationsEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.CitationCount);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.CitationCount.ToString());
 }
 
 if (objzx_SocialRelationsEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.VersionCount);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.VersionCount.ToString());
 }
 
 if (objzx_SocialRelationsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SocialRelationsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_SocialRelationsEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.AppraiseCount);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.AppraiseCount.ToString());
 }
 
 if (objzx_SocialRelationsEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Score);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.Score.ToString());
 }
 
 if (objzx_SocialRelationsEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.StuScore);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.StuScore.ToString());
 }
 
 if (objzx_SocialRelationsEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.TeaScore);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.TeaScore.ToString());
 }
 
 if (objzx_SocialRelationsEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.TextId);
 var strTextId = objzx_SocialRelationsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_SocialRelationsEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.zxShareId);
 var strzxShareId = objzx_SocialRelationsEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfContent);
 var strPdfContent = objzx_SocialRelationsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfPageNum);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.PdfPageNum.ToString());
 }
 
 if (objzx_SocialRelationsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.UpdUser);
 var strUpdUser = objzx_SocialRelationsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SocialRelationsEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.CreateDate);
 var strCreateDate = objzx_SocialRelationsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_SocialRelationsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.UpdDate);
 var strUpdDate = objzx_SocialRelationsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_SocialRelationsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.Memo);
 var strMemo = objzx_SocialRelationsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfDivLet);
 var strPdfDivLet = objzx_SocialRelationsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfDivTop);
 var strPdfDivTop = objzx_SocialRelationsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfPageNumIn);
 var strPdfPageNumIn = objzx_SocialRelationsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_SocialRelationsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfPageTop);
 arrValueListForInsert.Add(objzx_SocialRelationsEN.PdfPageTop.ToString());
 }
 
 if (objzx_SocialRelationsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.PdfZoom);
 var strPdfZoom = objzx_SocialRelationsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_SocialRelationsEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelations.GroupTextId);
 var strGroupTextId = objzx_SocialRelationsEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SocialRelations");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_SocialRelationss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelations where zxSocialId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_SocialRelations");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strzxSocialId = oRow[conzx_SocialRelations.zxSocialId].ToString().Trim();
if (IsExist(strzxSocialId))
{
 string strResult = "关键字变量值为:" + string.Format("zxSocialId = {0}", strzxSocialId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_SocialRelationsEN._CurrTabName ].NewRow();
objRow[conzx_SocialRelations.zxSocialId] = oRow[conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objRow[conzx_SocialRelations.FullName] = oRow[conzx_SocialRelations.FullName].ToString().Trim(); //姓名
objRow[conzx_SocialRelations.Nationality] = oRow[conzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objRow[conzx_SocialRelations.WorkUnit] = oRow[conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objRow[conzx_SocialRelations.Major] = oRow[conzx_SocialRelations.Major].ToString().Trim(); //专业
objRow[conzx_SocialRelations.Achievement] = oRow[conzx_SocialRelations.Achievement].ToString().Trim(); //成就
objRow[conzx_SocialRelations.DetailedDescription] = oRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objRow[conzx_SocialRelations.zxLevelId] = oRow[conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
objRow[conzx_SocialRelations.IsSubmit] = oRow[conzx_SocialRelations.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_SocialRelations.VoteCount] = oRow[conzx_SocialRelations.VoteCount].ToString().Trim(); //点赞计数
objRow[conzx_SocialRelations.CitationCount] = oRow[conzx_SocialRelations.CitationCount].ToString().Trim(); //引用统计
objRow[conzx_SocialRelations.VersionCount] = oRow[conzx_SocialRelations.VersionCount].ToString().Trim(); //版本统计
objRow[conzx_SocialRelations.IdCurrEduCls] = oRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_SocialRelations.AppraiseCount] = oRow[conzx_SocialRelations.AppraiseCount].ToString().Trim(); //评论数
objRow[conzx_SocialRelations.Score] = oRow[conzx_SocialRelations.Score].ToString().Trim(); //评分
objRow[conzx_SocialRelations.StuScore] = oRow[conzx_SocialRelations.StuScore].ToString().Trim(); //学生平均分
objRow[conzx_SocialRelations.TeaScore] = oRow[conzx_SocialRelations.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_SocialRelations.TextId] = oRow[conzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objRow[conzx_SocialRelations.zxShareId] = oRow[conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objRow[conzx_SocialRelations.PdfContent] = oRow[conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objRow[conzx_SocialRelations.PdfPageNum] = oRow[conzx_SocialRelations.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conzx_SocialRelations.UpdUser] = oRow[conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objRow[conzx_SocialRelations.CreateDate] = oRow[conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objRow[conzx_SocialRelations.UpdDate] = oRow[conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_SocialRelations.Memo] = oRow[conzx_SocialRelations.Memo].ToString().Trim(); //备注
objRow[conzx_SocialRelations.PdfDivLet] = oRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objRow[conzx_SocialRelations.PdfDivTop] = oRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objRow[conzx_SocialRelations.PdfPageNumIn] = oRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objRow[conzx_SocialRelations.PdfPageTop] = oRow[conzx_SocialRelations.PdfPageTop].ToString().Trim(); //pdf页面顶部位置
objRow[conzx_SocialRelations.PdfZoom] = oRow[conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objRow[conzx_SocialRelations.GroupTextId] = oRow[conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
 objDS.Tables[clszx_SocialRelationsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_SocialRelationsEN._CurrTabName);
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
 /// <param name = "objzx_SocialRelationsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
 if (objzx_SocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SocialRelationsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelations where zxSocialId = " + "'"+ objzx_SocialRelationsEN.zxSocialId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_SocialRelationsEN._CurrTabName);
if (objDS.Tables[clszx_SocialRelationsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:zxSocialId = " + "'"+ objzx_SocialRelationsEN.zxSocialId+"'");
return false;
}
objRow = objDS.Tables[clszx_SocialRelationsEN._CurrTabName].Rows[0];
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.zxSocialId))
 {
objRow[conzx_SocialRelations.zxSocialId] = objzx_SocialRelationsEN.zxSocialId; //社会Id
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.FullName))
 {
objRow[conzx_SocialRelations.FullName] = objzx_SocialRelationsEN.FullName; //姓名
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Nationality))
 {
objRow[conzx_SocialRelations.Nationality] = objzx_SocialRelationsEN.Nationality; //国籍
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.WorkUnit))
 {
objRow[conzx_SocialRelations.WorkUnit] = objzx_SocialRelationsEN.WorkUnit; //工作单位
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Major))
 {
objRow[conzx_SocialRelations.Major] = objzx_SocialRelationsEN.Major; //专业
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Achievement))
 {
objRow[conzx_SocialRelations.Achievement] = objzx_SocialRelationsEN.Achievement; //成就
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.DetailedDescription))
 {
objRow[conzx_SocialRelations.DetailedDescription] = objzx_SocialRelationsEN.DetailedDescription; //详细说明
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.zxLevelId))
 {
objRow[conzx_SocialRelations.zxLevelId] = objzx_SocialRelationsEN.zxLevelId; //级别Id
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.IsSubmit))
 {
objRow[conzx_SocialRelations.IsSubmit] = objzx_SocialRelationsEN.IsSubmit; //是否提交
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.VoteCount))
 {
objRow[conzx_SocialRelations.VoteCount] = objzx_SocialRelationsEN.VoteCount; //点赞计数
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.CitationCount))
 {
objRow[conzx_SocialRelations.CitationCount] = objzx_SocialRelationsEN.CitationCount; //引用统计
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.VersionCount))
 {
objRow[conzx_SocialRelations.VersionCount] = objzx_SocialRelationsEN.VersionCount; //版本统计
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.IdCurrEduCls))
 {
objRow[conzx_SocialRelations.IdCurrEduCls] = objzx_SocialRelationsEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.AppraiseCount))
 {
objRow[conzx_SocialRelations.AppraiseCount] = objzx_SocialRelationsEN.AppraiseCount; //评论数
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Score))
 {
objRow[conzx_SocialRelations.Score] = objzx_SocialRelationsEN.Score; //评分
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.StuScore))
 {
objRow[conzx_SocialRelations.StuScore] = objzx_SocialRelationsEN.StuScore; //学生平均分
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.TeaScore))
 {
objRow[conzx_SocialRelations.TeaScore] = objzx_SocialRelationsEN.TeaScore; //教师评分
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.TextId))
 {
objRow[conzx_SocialRelations.TextId] = objzx_SocialRelationsEN.TextId; //课件Id
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.zxShareId))
 {
objRow[conzx_SocialRelations.zxShareId] = objzx_SocialRelationsEN.zxShareId; //分享Id
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfContent))
 {
objRow[conzx_SocialRelations.PdfContent] = objzx_SocialRelationsEN.PdfContent; //Pdf内容
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfPageNum))
 {
objRow[conzx_SocialRelations.PdfPageNum] = objzx_SocialRelationsEN.PdfPageNum; //Pdf页码
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.UpdUser))
 {
objRow[conzx_SocialRelations.UpdUser] = objzx_SocialRelationsEN.UpdUser; //修改人
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.CreateDate))
 {
objRow[conzx_SocialRelations.CreateDate] = objzx_SocialRelationsEN.CreateDate; //建立日期
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.UpdDate))
 {
objRow[conzx_SocialRelations.UpdDate] = objzx_SocialRelationsEN.UpdDate; //修改日期
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Memo))
 {
objRow[conzx_SocialRelations.Memo] = objzx_SocialRelationsEN.Memo; //备注
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfDivLet))
 {
objRow[conzx_SocialRelations.PdfDivLet] = objzx_SocialRelationsEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfDivTop))
 {
objRow[conzx_SocialRelations.PdfDivTop] = objzx_SocialRelationsEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfPageNumIn))
 {
objRow[conzx_SocialRelations.PdfPageNumIn] = objzx_SocialRelationsEN.PdfPageNumIn; //PdfPageNumIn
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfPageTop))
 {
objRow[conzx_SocialRelations.PdfPageTop] = objzx_SocialRelationsEN.PdfPageTop; //pdf页面顶部位置
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfZoom))
 {
objRow[conzx_SocialRelations.PdfZoom] = objzx_SocialRelationsEN.PdfZoom; //PdfZoom
 }
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.GroupTextId))
 {
objRow[conzx_SocialRelations.GroupTextId] = objzx_SocialRelationsEN.GroupTextId; //小组Id
 }
try
{
objDA.Update(objDS, clszx_SocialRelationsEN._CurrTabName);
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
 /// <param name = "objzx_SocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
 if (objzx_SocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SocialRelationsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_SocialRelations Set ");
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.FullName))
 {
 if (objzx_SocialRelationsEN.FullName !=  null)
 {
 var strFullName = objzx_SocialRelationsEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFullName, conzx_SocialRelations.FullName); //姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.FullName); //姓名
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Nationality))
 {
 if (objzx_SocialRelationsEN.Nationality !=  null)
 {
 var strNationality = objzx_SocialRelationsEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNationality, conzx_SocialRelations.Nationality); //国籍
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.Nationality); //国籍
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.WorkUnit))
 {
 if (objzx_SocialRelationsEN.WorkUnit !=  null)
 {
 var strWorkUnit = objzx_SocialRelationsEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkUnit, conzx_SocialRelations.WorkUnit); //工作单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.WorkUnit); //工作单位
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Major))
 {
 if (objzx_SocialRelationsEN.Major !=  null)
 {
 var strMajor = objzx_SocialRelationsEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajor, conzx_SocialRelations.Major); //专业
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.Major); //专业
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Achievement))
 {
 if (objzx_SocialRelationsEN.Achievement !=  null)
 {
 var strAchievement = objzx_SocialRelationsEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAchievement, conzx_SocialRelations.Achievement); //成就
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.Achievement); //成就
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.DetailedDescription))
 {
 if (objzx_SocialRelationsEN.DetailedDescription !=  null)
 {
 var strDetailedDescription = objzx_SocialRelationsEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDetailedDescription, conzx_SocialRelations.DetailedDescription); //详细说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.DetailedDescription); //详细说明
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.zxLevelId))
 {
 if (objzx_SocialRelationsEN.zxLevelId !=  null)
 {
 var strzxLevelId = objzx_SocialRelationsEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxLevelId, conzx_SocialRelations.zxLevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.zxLevelId); //级别Id
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_SocialRelationsEN.IsSubmit == true?"1":"0", conzx_SocialRelations.IsSubmit); //是否提交
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.VoteCount))
 {
 if (objzx_SocialRelationsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.VoteCount, conzx_SocialRelations.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.VoteCount); //点赞计数
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.CitationCount))
 {
 if (objzx_SocialRelationsEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.CitationCount, conzx_SocialRelations.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.CitationCount); //引用统计
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.VersionCount))
 {
 if (objzx_SocialRelationsEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.VersionCount, conzx_SocialRelations.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.VersionCount); //版本统计
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.IdCurrEduCls))
 {
 if (objzx_SocialRelationsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SocialRelationsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_SocialRelations.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.AppraiseCount))
 {
 if (objzx_SocialRelationsEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.AppraiseCount, conzx_SocialRelations.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.AppraiseCount); //评论数
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Score))
 {
 if (objzx_SocialRelationsEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.Score, conzx_SocialRelations.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.Score); //评分
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.StuScore))
 {
 if (objzx_SocialRelationsEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.StuScore, conzx_SocialRelations.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.StuScore); //学生平均分
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.TeaScore))
 {
 if (objzx_SocialRelationsEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.TeaScore, conzx_SocialRelations.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.TeaScore); //教师评分
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.TextId))
 {
 if (objzx_SocialRelationsEN.TextId !=  null)
 {
 var strTextId = objzx_SocialRelationsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_SocialRelations.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.TextId); //课件Id
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.zxShareId))
 {
 if (objzx_SocialRelationsEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_SocialRelationsEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_SocialRelations.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.zxShareId); //分享Id
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfContent))
 {
 if (objzx_SocialRelationsEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_SocialRelationsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_SocialRelations.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfPageNum))
 {
 if (objzx_SocialRelationsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.PdfPageNum, conzx_SocialRelations.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.UpdUser))
 {
 if (objzx_SocialRelationsEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SocialRelationsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_SocialRelations.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.UpdUser); //修改人
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.CreateDate))
 {
 if (objzx_SocialRelationsEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_SocialRelationsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_SocialRelations.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.CreateDate); //建立日期
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.UpdDate))
 {
 if (objzx_SocialRelationsEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SocialRelationsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_SocialRelations.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.UpdDate); //修改日期
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Memo))
 {
 if (objzx_SocialRelationsEN.Memo !=  null)
 {
 var strMemo = objzx_SocialRelationsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_SocialRelations.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.Memo); //备注
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfDivLet))
 {
 if (objzx_SocialRelationsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_SocialRelationsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_SocialRelations.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfDivTop))
 {
 if (objzx_SocialRelationsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_SocialRelationsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_SocialRelations.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfPageNumIn))
 {
 if (objzx_SocialRelationsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_SocialRelationsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_SocialRelations.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfPageTop))
 {
 if (objzx_SocialRelationsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.PdfPageTop, conzx_SocialRelations.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfZoom))
 {
 if (objzx_SocialRelationsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_SocialRelationsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_SocialRelations.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.GroupTextId))
 {
 if (objzx_SocialRelationsEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_SocialRelationsEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_SocialRelations.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxSocialId = '{0}'", objzx_SocialRelationsEN.zxSocialId); 
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
 /// <param name = "objzx_SocialRelationsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_SocialRelationsEN objzx_SocialRelationsEN, string strCondition)
{
 if (objzx_SocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SocialRelationsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_SocialRelations Set ");
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.FullName))
 {
 if (objzx_SocialRelationsEN.FullName !=  null)
 {
 var strFullName = objzx_SocialRelationsEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FullName = '{0}',", strFullName); //姓名
 }
 else
 {
 sbSQL.Append(" FullName = null,"); //姓名
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Nationality))
 {
 if (objzx_SocialRelationsEN.Nationality !=  null)
 {
 var strNationality = objzx_SocialRelationsEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Nationality = '{0}',", strNationality); //国籍
 }
 else
 {
 sbSQL.Append(" Nationality = null,"); //国籍
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.WorkUnit))
 {
 if (objzx_SocialRelationsEN.WorkUnit !=  null)
 {
 var strWorkUnit = objzx_SocialRelationsEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkUnit = '{0}',", strWorkUnit); //工作单位
 }
 else
 {
 sbSQL.Append(" WorkUnit = null,"); //工作单位
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Major))
 {
 if (objzx_SocialRelationsEN.Major !=  null)
 {
 var strMajor = objzx_SocialRelationsEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Major = '{0}',", strMajor); //专业
 }
 else
 {
 sbSQL.Append(" Major = null,"); //专业
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Achievement))
 {
 if (objzx_SocialRelationsEN.Achievement !=  null)
 {
 var strAchievement = objzx_SocialRelationsEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Achievement = '{0}',", strAchievement); //成就
 }
 else
 {
 sbSQL.Append(" Achievement = null,"); //成就
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.DetailedDescription))
 {
 if (objzx_SocialRelationsEN.DetailedDescription !=  null)
 {
 var strDetailedDescription = objzx_SocialRelationsEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DetailedDescription = '{0}',", strDetailedDescription); //详细说明
 }
 else
 {
 sbSQL.Append(" DetailedDescription = null,"); //详细说明
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.zxLevelId))
 {
 if (objzx_SocialRelationsEN.zxLevelId !=  null)
 {
 var strzxLevelId = objzx_SocialRelationsEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxLevelId = '{0}',", strzxLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" zxLevelId = null,"); //级别Id
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_SocialRelationsEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.VoteCount))
 {
 if (objzx_SocialRelationsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.VoteCount, conzx_SocialRelations.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.VoteCount); //点赞计数
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.CitationCount))
 {
 if (objzx_SocialRelationsEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.CitationCount, conzx_SocialRelations.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.CitationCount); //引用统计
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.VersionCount))
 {
 if (objzx_SocialRelationsEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.VersionCount, conzx_SocialRelations.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.VersionCount); //版本统计
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.IdCurrEduCls))
 {
 if (objzx_SocialRelationsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SocialRelationsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.AppraiseCount))
 {
 if (objzx_SocialRelationsEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.AppraiseCount, conzx_SocialRelations.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.AppraiseCount); //评论数
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Score))
 {
 if (objzx_SocialRelationsEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.Score, conzx_SocialRelations.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.Score); //评分
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.StuScore))
 {
 if (objzx_SocialRelationsEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.StuScore, conzx_SocialRelations.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.StuScore); //学生平均分
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.TeaScore))
 {
 if (objzx_SocialRelationsEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.TeaScore, conzx_SocialRelations.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.TeaScore); //教师评分
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.TextId))
 {
 if (objzx_SocialRelationsEN.TextId !=  null)
 {
 var strTextId = objzx_SocialRelationsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.zxShareId))
 {
 if (objzx_SocialRelationsEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_SocialRelationsEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfContent))
 {
 if (objzx_SocialRelationsEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_SocialRelationsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfPageNum))
 {
 if (objzx_SocialRelationsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.PdfPageNum, conzx_SocialRelations.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.UpdUser))
 {
 if (objzx_SocialRelationsEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SocialRelationsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.CreateDate))
 {
 if (objzx_SocialRelationsEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_SocialRelationsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.UpdDate))
 {
 if (objzx_SocialRelationsEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SocialRelationsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Memo))
 {
 if (objzx_SocialRelationsEN.Memo !=  null)
 {
 var strMemo = objzx_SocialRelationsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfDivLet))
 {
 if (objzx_SocialRelationsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_SocialRelationsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfDivTop))
 {
 if (objzx_SocialRelationsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_SocialRelationsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfPageNumIn))
 {
 if (objzx_SocialRelationsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_SocialRelationsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfPageTop))
 {
 if (objzx_SocialRelationsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.PdfPageTop, conzx_SocialRelations.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfZoom))
 {
 if (objzx_SocialRelationsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_SocialRelationsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.GroupTextId))
 {
 if (objzx_SocialRelationsEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_SocialRelationsEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
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
 /// <param name = "objzx_SocialRelationsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_SocialRelationsEN objzx_SocialRelationsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_SocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SocialRelationsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_SocialRelations Set ");
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.FullName))
 {
 if (objzx_SocialRelationsEN.FullName !=  null)
 {
 var strFullName = objzx_SocialRelationsEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FullName = '{0}',", strFullName); //姓名
 }
 else
 {
 sbSQL.Append(" FullName = null,"); //姓名
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Nationality))
 {
 if (objzx_SocialRelationsEN.Nationality !=  null)
 {
 var strNationality = objzx_SocialRelationsEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Nationality = '{0}',", strNationality); //国籍
 }
 else
 {
 sbSQL.Append(" Nationality = null,"); //国籍
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.WorkUnit))
 {
 if (objzx_SocialRelationsEN.WorkUnit !=  null)
 {
 var strWorkUnit = objzx_SocialRelationsEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkUnit = '{0}',", strWorkUnit); //工作单位
 }
 else
 {
 sbSQL.Append(" WorkUnit = null,"); //工作单位
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Major))
 {
 if (objzx_SocialRelationsEN.Major !=  null)
 {
 var strMajor = objzx_SocialRelationsEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Major = '{0}',", strMajor); //专业
 }
 else
 {
 sbSQL.Append(" Major = null,"); //专业
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Achievement))
 {
 if (objzx_SocialRelationsEN.Achievement !=  null)
 {
 var strAchievement = objzx_SocialRelationsEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Achievement = '{0}',", strAchievement); //成就
 }
 else
 {
 sbSQL.Append(" Achievement = null,"); //成就
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.DetailedDescription))
 {
 if (objzx_SocialRelationsEN.DetailedDescription !=  null)
 {
 var strDetailedDescription = objzx_SocialRelationsEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DetailedDescription = '{0}',", strDetailedDescription); //详细说明
 }
 else
 {
 sbSQL.Append(" DetailedDescription = null,"); //详细说明
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.zxLevelId))
 {
 if (objzx_SocialRelationsEN.zxLevelId !=  null)
 {
 var strzxLevelId = objzx_SocialRelationsEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxLevelId = '{0}',", strzxLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" zxLevelId = null,"); //级别Id
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_SocialRelationsEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.VoteCount))
 {
 if (objzx_SocialRelationsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.VoteCount, conzx_SocialRelations.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.VoteCount); //点赞计数
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.CitationCount))
 {
 if (objzx_SocialRelationsEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.CitationCount, conzx_SocialRelations.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.CitationCount); //引用统计
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.VersionCount))
 {
 if (objzx_SocialRelationsEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.VersionCount, conzx_SocialRelations.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.VersionCount); //版本统计
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.IdCurrEduCls))
 {
 if (objzx_SocialRelationsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SocialRelationsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.AppraiseCount))
 {
 if (objzx_SocialRelationsEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.AppraiseCount, conzx_SocialRelations.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.AppraiseCount); //评论数
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Score))
 {
 if (objzx_SocialRelationsEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.Score, conzx_SocialRelations.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.Score); //评分
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.StuScore))
 {
 if (objzx_SocialRelationsEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.StuScore, conzx_SocialRelations.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.StuScore); //学生平均分
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.TeaScore))
 {
 if (objzx_SocialRelationsEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.TeaScore, conzx_SocialRelations.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.TeaScore); //教师评分
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.TextId))
 {
 if (objzx_SocialRelationsEN.TextId !=  null)
 {
 var strTextId = objzx_SocialRelationsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.zxShareId))
 {
 if (objzx_SocialRelationsEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_SocialRelationsEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfContent))
 {
 if (objzx_SocialRelationsEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_SocialRelationsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfPageNum))
 {
 if (objzx_SocialRelationsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.PdfPageNum, conzx_SocialRelations.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.UpdUser))
 {
 if (objzx_SocialRelationsEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SocialRelationsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.CreateDate))
 {
 if (objzx_SocialRelationsEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_SocialRelationsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.UpdDate))
 {
 if (objzx_SocialRelationsEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SocialRelationsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Memo))
 {
 if (objzx_SocialRelationsEN.Memo !=  null)
 {
 var strMemo = objzx_SocialRelationsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfDivLet))
 {
 if (objzx_SocialRelationsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_SocialRelationsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfDivTop))
 {
 if (objzx_SocialRelationsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_SocialRelationsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfPageNumIn))
 {
 if (objzx_SocialRelationsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_SocialRelationsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfPageTop))
 {
 if (objzx_SocialRelationsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.PdfPageTop, conzx_SocialRelations.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfZoom))
 {
 if (objzx_SocialRelationsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_SocialRelationsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.GroupTextId))
 {
 if (objzx_SocialRelationsEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_SocialRelationsEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
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
 /// <param name = "objzx_SocialRelationsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_SocialRelationsEN objzx_SocialRelationsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_SocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SocialRelationsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_SocialRelations Set ");
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.FullName))
 {
 if (objzx_SocialRelationsEN.FullName !=  null)
 {
 var strFullName = objzx_SocialRelationsEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFullName, conzx_SocialRelations.FullName); //姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.FullName); //姓名
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Nationality))
 {
 if (objzx_SocialRelationsEN.Nationality !=  null)
 {
 var strNationality = objzx_SocialRelationsEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNationality, conzx_SocialRelations.Nationality); //国籍
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.Nationality); //国籍
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.WorkUnit))
 {
 if (objzx_SocialRelationsEN.WorkUnit !=  null)
 {
 var strWorkUnit = objzx_SocialRelationsEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkUnit, conzx_SocialRelations.WorkUnit); //工作单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.WorkUnit); //工作单位
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Major))
 {
 if (objzx_SocialRelationsEN.Major !=  null)
 {
 var strMajor = objzx_SocialRelationsEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajor, conzx_SocialRelations.Major); //专业
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.Major); //专业
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Achievement))
 {
 if (objzx_SocialRelationsEN.Achievement !=  null)
 {
 var strAchievement = objzx_SocialRelationsEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAchievement, conzx_SocialRelations.Achievement); //成就
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.Achievement); //成就
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.DetailedDescription))
 {
 if (objzx_SocialRelationsEN.DetailedDescription !=  null)
 {
 var strDetailedDescription = objzx_SocialRelationsEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDetailedDescription, conzx_SocialRelations.DetailedDescription); //详细说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.DetailedDescription); //详细说明
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.zxLevelId))
 {
 if (objzx_SocialRelationsEN.zxLevelId !=  null)
 {
 var strzxLevelId = objzx_SocialRelationsEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxLevelId, conzx_SocialRelations.zxLevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.zxLevelId); //级别Id
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_SocialRelationsEN.IsSubmit == true?"1":"0", conzx_SocialRelations.IsSubmit); //是否提交
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.VoteCount))
 {
 if (objzx_SocialRelationsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.VoteCount, conzx_SocialRelations.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.VoteCount); //点赞计数
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.CitationCount))
 {
 if (objzx_SocialRelationsEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.CitationCount, conzx_SocialRelations.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.CitationCount); //引用统计
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.VersionCount))
 {
 if (objzx_SocialRelationsEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.VersionCount, conzx_SocialRelations.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.VersionCount); //版本统计
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.IdCurrEduCls))
 {
 if (objzx_SocialRelationsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SocialRelationsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_SocialRelations.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.AppraiseCount))
 {
 if (objzx_SocialRelationsEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.AppraiseCount, conzx_SocialRelations.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.AppraiseCount); //评论数
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Score))
 {
 if (objzx_SocialRelationsEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.Score, conzx_SocialRelations.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.Score); //评分
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.StuScore))
 {
 if (objzx_SocialRelationsEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.StuScore, conzx_SocialRelations.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.StuScore); //学生平均分
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.TeaScore))
 {
 if (objzx_SocialRelationsEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.TeaScore, conzx_SocialRelations.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.TeaScore); //教师评分
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.TextId))
 {
 if (objzx_SocialRelationsEN.TextId !=  null)
 {
 var strTextId = objzx_SocialRelationsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_SocialRelations.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.TextId); //课件Id
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.zxShareId))
 {
 if (objzx_SocialRelationsEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_SocialRelationsEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_SocialRelations.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.zxShareId); //分享Id
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfContent))
 {
 if (objzx_SocialRelationsEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_SocialRelationsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_SocialRelations.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfPageNum))
 {
 if (objzx_SocialRelationsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.PdfPageNum, conzx_SocialRelations.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.UpdUser))
 {
 if (objzx_SocialRelationsEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SocialRelationsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_SocialRelations.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.UpdUser); //修改人
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.CreateDate))
 {
 if (objzx_SocialRelationsEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_SocialRelationsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_SocialRelations.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.CreateDate); //建立日期
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.UpdDate))
 {
 if (objzx_SocialRelationsEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SocialRelationsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_SocialRelations.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.UpdDate); //修改日期
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.Memo))
 {
 if (objzx_SocialRelationsEN.Memo !=  null)
 {
 var strMemo = objzx_SocialRelationsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_SocialRelations.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.Memo); //备注
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfDivLet))
 {
 if (objzx_SocialRelationsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_SocialRelationsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_SocialRelations.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfDivTop))
 {
 if (objzx_SocialRelationsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_SocialRelationsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_SocialRelations.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfPageNumIn))
 {
 if (objzx_SocialRelationsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_SocialRelationsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_SocialRelations.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfPageTop))
 {
 if (objzx_SocialRelationsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsEN.PdfPageTop, conzx_SocialRelations.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.PdfZoom))
 {
 if (objzx_SocialRelationsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_SocialRelationsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_SocialRelations.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_SocialRelationsEN.IsUpdated(conzx_SocialRelations.GroupTextId))
 {
 if (objzx_SocialRelationsEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_SocialRelationsEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_SocialRelations.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelations.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxSocialId = '{0}'", objzx_SocialRelationsEN.zxSocialId); 
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
 /// <param name = "strzxSocialId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strzxSocialId) 
{
CheckPrimaryKey(strzxSocialId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strzxSocialId,
};
 objSQL.ExecSP("zx_SocialRelations_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strzxSocialId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strzxSocialId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strzxSocialId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
//删除zx_SocialRelations本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_SocialRelations where zxSocialId = " + "'"+ strzxSocialId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_SocialRelations(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
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
//删除zx_SocialRelations本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_SocialRelations where zxSocialId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strzxSocialId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strzxSocialId) 
{
CheckPrimaryKey(strzxSocialId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
//删除zx_SocialRelations本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_SocialRelations where zxSocialId = " + "'"+ strzxSocialId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_SocialRelations(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_SocialRelationsDA: Delzx_SocialRelations)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_SocialRelations where " + strCondition ;
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
public bool Delzx_SocialRelationsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_SocialRelationsDA: Delzx_SocialRelationsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_SocialRelations where " + strCondition ;
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
 /// <param name = "objzx_SocialRelationsENS">源对象</param>
 /// <param name = "objzx_SocialRelationsENT">目标对象</param>
public void CopyTo(clszx_SocialRelationsEN objzx_SocialRelationsENS, clszx_SocialRelationsEN objzx_SocialRelationsENT)
{
objzx_SocialRelationsENT.zxSocialId = objzx_SocialRelationsENS.zxSocialId; //社会Id
objzx_SocialRelationsENT.FullName = objzx_SocialRelationsENS.FullName; //姓名
objzx_SocialRelationsENT.Nationality = objzx_SocialRelationsENS.Nationality; //国籍
objzx_SocialRelationsENT.WorkUnit = objzx_SocialRelationsENS.WorkUnit; //工作单位
objzx_SocialRelationsENT.Major = objzx_SocialRelationsENS.Major; //专业
objzx_SocialRelationsENT.Achievement = objzx_SocialRelationsENS.Achievement; //成就
objzx_SocialRelationsENT.DetailedDescription = objzx_SocialRelationsENS.DetailedDescription; //详细说明
objzx_SocialRelationsENT.zxLevelId = objzx_SocialRelationsENS.zxLevelId; //级别Id
objzx_SocialRelationsENT.IsSubmit = objzx_SocialRelationsENS.IsSubmit; //是否提交
objzx_SocialRelationsENT.VoteCount = objzx_SocialRelationsENS.VoteCount; //点赞计数
objzx_SocialRelationsENT.CitationCount = objzx_SocialRelationsENS.CitationCount; //引用统计
objzx_SocialRelationsENT.VersionCount = objzx_SocialRelationsENS.VersionCount; //版本统计
objzx_SocialRelationsENT.IdCurrEduCls = objzx_SocialRelationsENS.IdCurrEduCls; //教学班流水号
objzx_SocialRelationsENT.AppraiseCount = objzx_SocialRelationsENS.AppraiseCount; //评论数
objzx_SocialRelationsENT.Score = objzx_SocialRelationsENS.Score; //评分
objzx_SocialRelationsENT.StuScore = objzx_SocialRelationsENS.StuScore; //学生平均分
objzx_SocialRelationsENT.TeaScore = objzx_SocialRelationsENS.TeaScore; //教师评分
objzx_SocialRelationsENT.TextId = objzx_SocialRelationsENS.TextId; //课件Id
objzx_SocialRelationsENT.zxShareId = objzx_SocialRelationsENS.zxShareId; //分享Id
objzx_SocialRelationsENT.PdfContent = objzx_SocialRelationsENS.PdfContent; //Pdf内容
objzx_SocialRelationsENT.PdfPageNum = objzx_SocialRelationsENS.PdfPageNum; //Pdf页码
objzx_SocialRelationsENT.UpdUser = objzx_SocialRelationsENS.UpdUser; //修改人
objzx_SocialRelationsENT.CreateDate = objzx_SocialRelationsENS.CreateDate; //建立日期
objzx_SocialRelationsENT.UpdDate = objzx_SocialRelationsENS.UpdDate; //修改日期
objzx_SocialRelationsENT.Memo = objzx_SocialRelationsENS.Memo; //备注
objzx_SocialRelationsENT.PdfDivLet = objzx_SocialRelationsENS.PdfDivLet; //PdfDivLet
objzx_SocialRelationsENT.PdfDivTop = objzx_SocialRelationsENS.PdfDivTop; //PdfDivTop
objzx_SocialRelationsENT.PdfPageNumIn = objzx_SocialRelationsENS.PdfPageNumIn; //PdfPageNumIn
objzx_SocialRelationsENT.PdfPageTop = objzx_SocialRelationsENS.PdfPageTop; //pdf页面顶部位置
objzx_SocialRelationsENT.PdfZoom = objzx_SocialRelationsENS.PdfZoom; //PdfZoom
objzx_SocialRelationsENT.GroupTextId = objzx_SocialRelationsENS.GroupTextId; //小组Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.zxSocialId, 10, conzx_SocialRelations.zxSocialId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.FullName, 50, conzx_SocialRelations.FullName);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.Nationality, 50, conzx_SocialRelations.Nationality);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.WorkUnit, 100, conzx_SocialRelations.WorkUnit);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.Major, 50, conzx_SocialRelations.Major);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.Achievement, 5000, conzx_SocialRelations.Achievement);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.zxLevelId, 2, conzx_SocialRelations.zxLevelId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.IdCurrEduCls, 8, conzx_SocialRelations.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.TextId, 8, conzx_SocialRelations.TextId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.zxShareId, 2, conzx_SocialRelations.zxShareId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.PdfContent, 2000, conzx_SocialRelations.PdfContent);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.UpdUser, 20, conzx_SocialRelations.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.CreateDate, 20, conzx_SocialRelations.CreateDate);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.UpdDate, 20, conzx_SocialRelations.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.Memo, 1000, conzx_SocialRelations.Memo);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.PdfDivLet, 50, conzx_SocialRelations.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.PdfDivTop, 50, conzx_SocialRelations.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.PdfPageNumIn, 50, conzx_SocialRelations.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.PdfZoom, 50, conzx_SocialRelations.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.GroupTextId, 8, conzx_SocialRelations.GroupTextId);
//检查字段外键固定长度
 objzx_SocialRelationsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.FullName, 50, conzx_SocialRelations.FullName);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.Nationality, 50, conzx_SocialRelations.Nationality);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.WorkUnit, 100, conzx_SocialRelations.WorkUnit);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.Major, 50, conzx_SocialRelations.Major);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.Achievement, 5000, conzx_SocialRelations.Achievement);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.zxLevelId, 2, conzx_SocialRelations.zxLevelId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.IdCurrEduCls, 8, conzx_SocialRelations.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.TextId, 8, conzx_SocialRelations.TextId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.zxShareId, 2, conzx_SocialRelations.zxShareId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.PdfContent, 2000, conzx_SocialRelations.PdfContent);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.UpdUser, 20, conzx_SocialRelations.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.CreateDate, 20, conzx_SocialRelations.CreateDate);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.UpdDate, 20, conzx_SocialRelations.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.Memo, 1000, conzx_SocialRelations.Memo);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.PdfDivLet, 50, conzx_SocialRelations.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.PdfDivTop, 50, conzx_SocialRelations.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.PdfPageNumIn, 50, conzx_SocialRelations.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.PdfZoom, 50, conzx_SocialRelations.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.GroupTextId, 8, conzx_SocialRelations.GroupTextId);
//检查外键字段长度
 objzx_SocialRelationsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.zxSocialId, 10, conzx_SocialRelations.zxSocialId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.FullName, 50, conzx_SocialRelations.FullName);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.Nationality, 50, conzx_SocialRelations.Nationality);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.WorkUnit, 100, conzx_SocialRelations.WorkUnit);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.Major, 50, conzx_SocialRelations.Major);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.Achievement, 5000, conzx_SocialRelations.Achievement);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.zxLevelId, 2, conzx_SocialRelations.zxLevelId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.IdCurrEduCls, 8, conzx_SocialRelations.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.TextId, 8, conzx_SocialRelations.TextId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.zxShareId, 2, conzx_SocialRelations.zxShareId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.PdfContent, 2000, conzx_SocialRelations.PdfContent);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.UpdUser, 20, conzx_SocialRelations.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.CreateDate, 20, conzx_SocialRelations.CreateDate);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.UpdDate, 20, conzx_SocialRelations.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.Memo, 1000, conzx_SocialRelations.Memo);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.PdfDivLet, 50, conzx_SocialRelations.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.PdfDivTop, 50, conzx_SocialRelations.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.PdfPageNumIn, 50, conzx_SocialRelations.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.PdfZoom, 50, conzx_SocialRelations.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsEN.GroupTextId, 8, conzx_SocialRelations.GroupTextId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.zxSocialId, conzx_SocialRelations.zxSocialId);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.FullName, conzx_SocialRelations.FullName);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.Nationality, conzx_SocialRelations.Nationality);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.WorkUnit, conzx_SocialRelations.WorkUnit);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.Major, conzx_SocialRelations.Major);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.Achievement, conzx_SocialRelations.Achievement);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.zxLevelId, conzx_SocialRelations.zxLevelId);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.IdCurrEduCls, conzx_SocialRelations.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.TextId, conzx_SocialRelations.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.zxShareId, conzx_SocialRelations.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.PdfContent, conzx_SocialRelations.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.UpdUser, conzx_SocialRelations.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.CreateDate, conzx_SocialRelations.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.UpdDate, conzx_SocialRelations.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.Memo, conzx_SocialRelations.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.PdfDivLet, conzx_SocialRelations.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.PdfDivTop, conzx_SocialRelations.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.PdfPageNumIn, conzx_SocialRelations.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.PdfZoom, conzx_SocialRelations.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsEN.GroupTextId, conzx_SocialRelations.GroupTextId);
//检查外键字段长度
 objzx_SocialRelationsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetzxSocialId()
{
//获取某学院所有专业信息
string strSQL = "select zxSocialId, zxLevelId from zx_SocialRelations ";
 clsSpecSQLforSql mySql = clszx_SocialRelationsDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_SocialRelations(中学社会关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objzx_SocialRelationsEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null");
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_SocialRelationsEN.TextId);
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
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
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
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
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
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_SocialRelationsEN._CurrTabName);
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
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_SocialRelationsEN._CurrTabName, strCondition);
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
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
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
 objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}