
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRTUserRelaDA
 表名:RTUserRela(01120582)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 主题用户关系(RTUserRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsRTUserRelaDA : clsCommBase4DA
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
 return clsRTUserRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsRTUserRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsRTUserRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsRTUserRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsRTUserRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsRTUserRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTUserRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_RTUserRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsRTUserRelaDA: GetDataTable_RTUserRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTUserRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsRTUserRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsRTUserRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTUserRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsRTUserRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsRTUserRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from RTUserRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from RTUserRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsRTUserRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from RTUserRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsRTUserRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} RTUserRela.* from RTUserRela Left Join {1} on {2} where {3} and RTUserRela.mId not in (Select top {5} RTUserRela.mId from RTUserRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from RTUserRela where {1} and mId not in (Select top {2} mId from RTUserRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from RTUserRela where {1} and mId not in (Select top {3} mId from RTUserRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsRTUserRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} RTUserRela.* from RTUserRela Left Join {1} on {2} where {3} and RTUserRela.mId not in (Select top {5} RTUserRela.mId from RTUserRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from RTUserRela where {1} and mId not in (Select top {2} mId from RTUserRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from RTUserRela where {1} and mId not in (Select top {3} mId from RTUserRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsRTUserRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsRTUserRelaDA:GetObjLst)", objException.Message));
}
List<clsRTUserRelaEN> arrObjLst = new List<clsRTUserRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTUserRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTUserRelaEN objRTUserRelaEN = new clsRTUserRelaEN();
try
{
objRTUserRelaEN.mId = TransNullToInt(objRow[conRTUserRela.mId].ToString().Trim()); //mId
objRTUserRelaEN.TopicId = objRow[conRTUserRela.TopicId] == DBNull.Value ? null : objRow[conRTUserRela.TopicId].ToString().Trim(); //主题Id
objRTUserRelaEN.UserId = objRow[conRTUserRela.UserId] == DBNull.Value ? null : objRow[conRTUserRela.UserId].ToString().Trim(); //用户ID
objRTUserRelaEN.TopicUserRoleId = objRow[conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objRTUserRelaEN.ColorId = objRow[conRTUserRela.ColorId] == DBNull.Value ? null : objRow[conRTUserRela.ColorId].ToString().Trim(); //颜色Id
objRTUserRelaEN.OrderNum = objRow[conRTUserRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conRTUserRela.OrderNum].ToString().Trim()); //序号
objRTUserRelaEN.UserBgColor = objRow[conRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objRTUserRelaEN.IdCurrEduCls = objRow[conRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRTUserRelaEN.AppraiseCount = objRow[conRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objRTUserRelaEN.OkCount = objRow[conRTUserRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conRTUserRela.OkCount].ToString().Trim()); //点赞统计
objRTUserRelaEN.Score = objRow[conRTUserRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conRTUserRela.Score].ToString().Trim()); //评分
objRTUserRelaEN.StuScore = objRow[conRTUserRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conRTUserRela.StuScore].ToString().Trim()); //学生平均分
objRTUserRelaEN.TeaScore = objRow[conRTUserRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conRTUserRela.TeaScore].ToString().Trim()); //教师评分
objRTUserRelaEN.IsSubmit = TransNullToBool(objRow[conRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objRTUserRelaEN.LastVisitedDate = objRow[conRTUserRela.LastVisitedDate] == DBNull.Value ? null : objRow[conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdDate = objRow[conRTUserRela.UpdDate] == DBNull.Value ? null : objRow[conRTUserRela.UpdDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdUser = objRow[conRTUserRela.UpdUser] == DBNull.Value ? null : objRow[conRTUserRela.UpdUser].ToString().Trim(); //修改人
objRTUserRelaEN.Memo = objRow[conRTUserRela.Memo] == DBNull.Value ? null : objRow[conRTUserRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsRTUserRelaDA: GetObjLst)", objException.Message));
}
objRTUserRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objRTUserRelaEN);
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
public List<clsRTUserRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsRTUserRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsRTUserRelaEN> arrObjLst = new List<clsRTUserRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTUserRelaEN objRTUserRelaEN = new clsRTUserRelaEN();
try
{
objRTUserRelaEN.mId = TransNullToInt(objRow[conRTUserRela.mId].ToString().Trim()); //mId
objRTUserRelaEN.TopicId = objRow[conRTUserRela.TopicId] == DBNull.Value ? null : objRow[conRTUserRela.TopicId].ToString().Trim(); //主题Id
objRTUserRelaEN.UserId = objRow[conRTUserRela.UserId] == DBNull.Value ? null : objRow[conRTUserRela.UserId].ToString().Trim(); //用户ID
objRTUserRelaEN.TopicUserRoleId = objRow[conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objRTUserRelaEN.ColorId = objRow[conRTUserRela.ColorId] == DBNull.Value ? null : objRow[conRTUserRela.ColorId].ToString().Trim(); //颜色Id
objRTUserRelaEN.OrderNum = objRow[conRTUserRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conRTUserRela.OrderNum].ToString().Trim()); //序号
objRTUserRelaEN.UserBgColor = objRow[conRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objRTUserRelaEN.IdCurrEduCls = objRow[conRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRTUserRelaEN.AppraiseCount = objRow[conRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objRTUserRelaEN.OkCount = objRow[conRTUserRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conRTUserRela.OkCount].ToString().Trim()); //点赞统计
objRTUserRelaEN.Score = objRow[conRTUserRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conRTUserRela.Score].ToString().Trim()); //评分
objRTUserRelaEN.StuScore = objRow[conRTUserRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conRTUserRela.StuScore].ToString().Trim()); //学生平均分
objRTUserRelaEN.TeaScore = objRow[conRTUserRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conRTUserRela.TeaScore].ToString().Trim()); //教师评分
objRTUserRelaEN.IsSubmit = TransNullToBool(objRow[conRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objRTUserRelaEN.LastVisitedDate = objRow[conRTUserRela.LastVisitedDate] == DBNull.Value ? null : objRow[conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdDate = objRow[conRTUserRela.UpdDate] == DBNull.Value ? null : objRow[conRTUserRela.UpdDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdUser = objRow[conRTUserRela.UpdUser] == DBNull.Value ? null : objRow[conRTUserRela.UpdUser].ToString().Trim(); //修改人
objRTUserRelaEN.Memo = objRow[conRTUserRela.Memo] == DBNull.Value ? null : objRow[conRTUserRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsRTUserRelaDA: GetObjLst)", objException.Message));
}
objRTUserRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objRTUserRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetRTUserRela(ref clsRTUserRelaEN objRTUserRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTUserRela where mId = " + ""+ objRTUserRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objRTUserRelaEN.mId = TransNullToInt(objDT.Rows[0][conRTUserRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objRTUserRelaEN.TopicId = objDT.Rows[0][conRTUserRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objRTUserRelaEN.UserId = objDT.Rows[0][conRTUserRela.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objRTUserRelaEN.TopicUserRoleId = objDT.Rows[0][conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id(字段类型:char,字段长度:4,是否可空:False)
 objRTUserRelaEN.ColorId = objDT.Rows[0][conRTUserRela.ColorId].ToString().Trim(); //颜色Id(字段类型:char,字段长度:2,是否可空:False)
 objRTUserRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][conRTUserRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objRTUserRelaEN.UserBgColor = objDT.Rows[0][conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景(字段类型:varchar,字段长度:200,是否可空:True)
 objRTUserRelaEN.IdCurrEduCls = objDT.Rows[0][conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objRTUserRelaEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conRTUserRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objRTUserRelaEN.OkCount = TransNullToInt(objDT.Rows[0][conRTUserRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objRTUserRelaEN.Score = TransNullToFloat(objDT.Rows[0][conRTUserRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objRTUserRelaEN.StuScore = TransNullToFloat(objDT.Rows[0][conRTUserRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objRTUserRelaEN.TeaScore = TransNullToFloat(objDT.Rows[0][conRTUserRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objRTUserRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][conRTUserRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objRTUserRelaEN.LastVisitedDate = objDT.Rows[0][conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objRTUserRelaEN.UpdDate = objDT.Rows[0][conRTUserRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objRTUserRelaEN.UpdUser = objDT.Rows[0][conRTUserRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objRTUserRelaEN.Memo = objDT.Rows[0][conRTUserRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsRTUserRelaDA: GetRTUserRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsRTUserRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTUserRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsRTUserRelaEN objRTUserRelaEN = new clsRTUserRelaEN();
try
{
 objRTUserRelaEN.mId = Int32.Parse(objRow[conRTUserRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objRTUserRelaEN.TopicId = objRow[conRTUserRela.TopicId] == DBNull.Value ? null : objRow[conRTUserRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objRTUserRelaEN.UserId = objRow[conRTUserRela.UserId] == DBNull.Value ? null : objRow[conRTUserRela.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objRTUserRelaEN.TopicUserRoleId = objRow[conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id(字段类型:char,字段长度:4,是否可空:False)
 objRTUserRelaEN.ColorId = objRow[conRTUserRela.ColorId] == DBNull.Value ? null : objRow[conRTUserRela.ColorId].ToString().Trim(); //颜色Id(字段类型:char,字段长度:2,是否可空:False)
 objRTUserRelaEN.OrderNum = objRow[conRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objRTUserRelaEN.UserBgColor = objRow[conRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景(字段类型:varchar,字段长度:200,是否可空:True)
 objRTUserRelaEN.IdCurrEduCls = objRow[conRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objRTUserRelaEN.AppraiseCount = objRow[conRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objRTUserRelaEN.OkCount = objRow[conRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objRTUserRelaEN.Score = objRow[conRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objRTUserRelaEN.StuScore = objRow[conRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objRTUserRelaEN.TeaScore = objRow[conRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conRTUserRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objRTUserRelaEN.LastVisitedDate = objRow[conRTUserRela.LastVisitedDate] == DBNull.Value ? null : objRow[conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objRTUserRelaEN.UpdDate = objRow[conRTUserRela.UpdDate] == DBNull.Value ? null : objRow[conRTUserRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objRTUserRelaEN.UpdUser = objRow[conRTUserRela.UpdUser] == DBNull.Value ? null : objRow[conRTUserRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objRTUserRelaEN.Memo = objRow[conRTUserRela.Memo] == DBNull.Value ? null : objRow[conRTUserRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsRTUserRelaDA: GetObjBymId)", objException.Message));
}
return objRTUserRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsRTUserRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsRTUserRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTUserRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsRTUserRelaEN objRTUserRelaEN = new clsRTUserRelaEN()
{
mId = TransNullToInt(objRow[conRTUserRela.mId].ToString().Trim()), //mId
TopicId = objRow[conRTUserRela.TopicId] == DBNull.Value ? null : objRow[conRTUserRela.TopicId].ToString().Trim(), //主题Id
UserId = objRow[conRTUserRela.UserId] == DBNull.Value ? null : objRow[conRTUserRela.UserId].ToString().Trim(), //用户ID
TopicUserRoleId = objRow[conRTUserRela.TopicUserRoleId].ToString().Trim(), //主键Id
ColorId = objRow[conRTUserRela.ColorId] == DBNull.Value ? null : objRow[conRTUserRela.ColorId].ToString().Trim(), //颜色Id
OrderNum = objRow[conRTUserRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conRTUserRela.OrderNum].ToString().Trim()), //序号
UserBgColor = objRow[conRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[conRTUserRela.UserBgColor].ToString().Trim(), //用户段落背景
IdCurrEduCls = objRow[conRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTUserRela.IdCurrEduCls].ToString().Trim(), //教学班流水号
AppraiseCount = objRow[conRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conRTUserRela.AppraiseCount].ToString().Trim()), //评论数
OkCount = objRow[conRTUserRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conRTUserRela.OkCount].ToString().Trim()), //点赞统计
Score = objRow[conRTUserRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conRTUserRela.Score].ToString().Trim()), //评分
StuScore = objRow[conRTUserRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conRTUserRela.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conRTUserRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conRTUserRela.TeaScore].ToString().Trim()), //教师评分
IsSubmit = TransNullToBool(objRow[conRTUserRela.IsSubmit].ToString().Trim()), //是否提交
LastVisitedDate = objRow[conRTUserRela.LastVisitedDate] == DBNull.Value ? null : objRow[conRTUserRela.LastVisitedDate].ToString().Trim(), //修改日期
UpdDate = objRow[conRTUserRela.UpdDate] == DBNull.Value ? null : objRow[conRTUserRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conRTUserRela.UpdUser] == DBNull.Value ? null : objRow[conRTUserRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conRTUserRela.Memo] == DBNull.Value ? null : objRow[conRTUserRela.Memo].ToString().Trim() //备注
};
objRTUserRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objRTUserRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsRTUserRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsRTUserRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsRTUserRelaEN objRTUserRelaEN = new clsRTUserRelaEN();
try
{
objRTUserRelaEN.mId = TransNullToInt(objRow[conRTUserRela.mId].ToString().Trim()); //mId
objRTUserRelaEN.TopicId = objRow[conRTUserRela.TopicId] == DBNull.Value ? null : objRow[conRTUserRela.TopicId].ToString().Trim(); //主题Id
objRTUserRelaEN.UserId = objRow[conRTUserRela.UserId] == DBNull.Value ? null : objRow[conRTUserRela.UserId].ToString().Trim(); //用户ID
objRTUserRelaEN.TopicUserRoleId = objRow[conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objRTUserRelaEN.ColorId = objRow[conRTUserRela.ColorId] == DBNull.Value ? null : objRow[conRTUserRela.ColorId].ToString().Trim(); //颜色Id
objRTUserRelaEN.OrderNum = objRow[conRTUserRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conRTUserRela.OrderNum].ToString().Trim()); //序号
objRTUserRelaEN.UserBgColor = objRow[conRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objRTUserRelaEN.IdCurrEduCls = objRow[conRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRTUserRelaEN.AppraiseCount = objRow[conRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objRTUserRelaEN.OkCount = objRow[conRTUserRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conRTUserRela.OkCount].ToString().Trim()); //点赞统计
objRTUserRelaEN.Score = objRow[conRTUserRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conRTUserRela.Score].ToString().Trim()); //评分
objRTUserRelaEN.StuScore = objRow[conRTUserRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conRTUserRela.StuScore].ToString().Trim()); //学生平均分
objRTUserRelaEN.TeaScore = objRow[conRTUserRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conRTUserRela.TeaScore].ToString().Trim()); //教师评分
objRTUserRelaEN.IsSubmit = TransNullToBool(objRow[conRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objRTUserRelaEN.LastVisitedDate = objRow[conRTUserRela.LastVisitedDate] == DBNull.Value ? null : objRow[conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdDate = objRow[conRTUserRela.UpdDate] == DBNull.Value ? null : objRow[conRTUserRela.UpdDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdUser = objRow[conRTUserRela.UpdUser] == DBNull.Value ? null : objRow[conRTUserRela.UpdUser].ToString().Trim(); //修改人
objRTUserRelaEN.Memo = objRow[conRTUserRela.Memo] == DBNull.Value ? null : objRow[conRTUserRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsRTUserRelaDA: GetObjByDataRowRTUserRela)", objException.Message));
}
objRTUserRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objRTUserRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsRTUserRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsRTUserRelaEN objRTUserRelaEN = new clsRTUserRelaEN();
try
{
objRTUserRelaEN.mId = TransNullToInt(objRow[conRTUserRela.mId].ToString().Trim()); //mId
objRTUserRelaEN.TopicId = objRow[conRTUserRela.TopicId] == DBNull.Value ? null : objRow[conRTUserRela.TopicId].ToString().Trim(); //主题Id
objRTUserRelaEN.UserId = objRow[conRTUserRela.UserId] == DBNull.Value ? null : objRow[conRTUserRela.UserId].ToString().Trim(); //用户ID
objRTUserRelaEN.TopicUserRoleId = objRow[conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objRTUserRelaEN.ColorId = objRow[conRTUserRela.ColorId] == DBNull.Value ? null : objRow[conRTUserRela.ColorId].ToString().Trim(); //颜色Id
objRTUserRelaEN.OrderNum = objRow[conRTUserRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conRTUserRela.OrderNum].ToString().Trim()); //序号
objRTUserRelaEN.UserBgColor = objRow[conRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objRTUserRelaEN.IdCurrEduCls = objRow[conRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRTUserRelaEN.AppraiseCount = objRow[conRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objRTUserRelaEN.OkCount = objRow[conRTUserRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conRTUserRela.OkCount].ToString().Trim()); //点赞统计
objRTUserRelaEN.Score = objRow[conRTUserRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conRTUserRela.Score].ToString().Trim()); //评分
objRTUserRelaEN.StuScore = objRow[conRTUserRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conRTUserRela.StuScore].ToString().Trim()); //学生平均分
objRTUserRelaEN.TeaScore = objRow[conRTUserRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conRTUserRela.TeaScore].ToString().Trim()); //教师评分
objRTUserRelaEN.IsSubmit = TransNullToBool(objRow[conRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objRTUserRelaEN.LastVisitedDate = objRow[conRTUserRela.LastVisitedDate] == DBNull.Value ? null : objRow[conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdDate = objRow[conRTUserRela.UpdDate] == DBNull.Value ? null : objRow[conRTUserRela.UpdDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdUser = objRow[conRTUserRela.UpdUser] == DBNull.Value ? null : objRow[conRTUserRela.UpdUser].ToString().Trim(); //修改人
objRTUserRelaEN.Memo = objRow[conRTUserRela.Memo] == DBNull.Value ? null : objRow[conRTUserRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsRTUserRelaDA: GetObjByDataRow)", objException.Message));
}
objRTUserRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objRTUserRelaEN;
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
objSQL = clsRTUserRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsRTUserRelaEN._CurrTabName, conRTUserRela.mId, 8, "");
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
objSQL = clsRTUserRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsRTUserRelaEN._CurrTabName, conRTUserRela.mId, 8, strPrefix);
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
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from RTUserRela where " + strCondition;
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
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from RTUserRela where " + strCondition;
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
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("RTUserRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsRTUserRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("RTUserRela", strCondition))
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
objSQL = clsRTUserRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("RTUserRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsRTUserRelaEN objRTUserRelaEN)
 {
 objRTUserRelaEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 objRTUserRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTUserRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRTUserRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTUserRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "RTUserRela");
objRow = objDS.Tables["RTUserRela"].NewRow();
 if (objRTUserRelaEN.TopicId !=  "")
 {
objRow[conRTUserRela.TopicId] = objRTUserRelaEN.TopicId; //主题Id
 }
 if (objRTUserRelaEN.UserId !=  "")
 {
objRow[conRTUserRela.UserId] = objRTUserRelaEN.UserId; //用户ID
 }
objRow[conRTUserRela.TopicUserRoleId] = objRTUserRelaEN.TopicUserRoleId; //主键Id
 if (objRTUserRelaEN.ColorId !=  "")
 {
objRow[conRTUserRela.ColorId] = objRTUserRelaEN.ColorId; //颜色Id
 }
objRow[conRTUserRela.OrderNum] = objRTUserRelaEN.OrderNum; //序号
 if (objRTUserRelaEN.UserBgColor !=  "")
 {
objRow[conRTUserRela.UserBgColor] = objRTUserRelaEN.UserBgColor; //用户段落背景
 }
 if (objRTUserRelaEN.IdCurrEduCls !=  "")
 {
objRow[conRTUserRela.IdCurrEduCls] = objRTUserRelaEN.IdCurrEduCls; //教学班流水号
 }
objRow[conRTUserRela.AppraiseCount] = objRTUserRelaEN.AppraiseCount; //评论数
objRow[conRTUserRela.OkCount] = objRTUserRelaEN.OkCount; //点赞统计
objRow[conRTUserRela.Score] = objRTUserRelaEN.Score; //评分
objRow[conRTUserRela.StuScore] = objRTUserRelaEN.StuScore; //学生平均分
objRow[conRTUserRela.TeaScore] = objRTUserRelaEN.TeaScore; //教师评分
objRow[conRTUserRela.IsSubmit] = objRTUserRelaEN.IsSubmit; //是否提交
 if (objRTUserRelaEN.LastVisitedDate !=  "")
 {
objRow[conRTUserRela.LastVisitedDate] = objRTUserRelaEN.LastVisitedDate; //修改日期
 }
 if (objRTUserRelaEN.UpdDate !=  "")
 {
objRow[conRTUserRela.UpdDate] = objRTUserRelaEN.UpdDate; //修改日期
 }
 if (objRTUserRelaEN.UpdUser !=  "")
 {
objRow[conRTUserRela.UpdUser] = objRTUserRelaEN.UpdUser; //修改人
 }
 if (objRTUserRelaEN.Memo !=  "")
 {
objRow[conRTUserRela.Memo] = objRTUserRelaEN.Memo; //备注
 }
objDS.Tables[clsRTUserRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsRTUserRelaEN._CurrTabName);
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
 /// <param name = "objRTUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsRTUserRelaEN objRTUserRelaEN)
{
 objRTUserRelaEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 objRTUserRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTUserRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRTUserRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objRTUserRelaEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.TopicId);
 var strTopicId = objRTUserRelaEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objRTUserRelaEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.UserId);
 var strUserId = objRTUserRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objRTUserRelaEN.TopicUserRoleId  ==  "")
 {
 objRTUserRelaEN.TopicUserRoleId = null;
 }
 if (objRTUserRelaEN.TopicUserRoleId !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.TopicUserRoleId);
 var strTopicUserRoleId = objRTUserRelaEN.TopicUserRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicUserRoleId + "'");
 }
 
 if (objRTUserRelaEN.ColorId !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.ColorId);
 var strColorId = objRTUserRelaEN.ColorId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strColorId + "'");
 }
 
 if (objRTUserRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.OrderNum);
 arrValueListForInsert.Add(objRTUserRelaEN.OrderNum.ToString());
 }
 
 if (objRTUserRelaEN.UserBgColor !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.UserBgColor);
 var strUserBgColor = objRTUserRelaEN.UserBgColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserBgColor + "'");
 }
 
 if (objRTUserRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.IdCurrEduCls);
 var strIdCurrEduCls = objRTUserRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objRTUserRelaEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.AppraiseCount);
 arrValueListForInsert.Add(objRTUserRelaEN.AppraiseCount.ToString());
 }
 
 if (objRTUserRelaEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.OkCount);
 arrValueListForInsert.Add(objRTUserRelaEN.OkCount.ToString());
 }
 
 if (objRTUserRelaEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.Score);
 arrValueListForInsert.Add(objRTUserRelaEN.Score.ToString());
 }
 
 if (objRTUserRelaEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.StuScore);
 arrValueListForInsert.Add(objRTUserRelaEN.StuScore.ToString());
 }
 
 if (objRTUserRelaEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.TeaScore);
 arrValueListForInsert.Add(objRTUserRelaEN.TeaScore.ToString());
 }
 
 arrFieldListForInsert.Add(conRTUserRela.IsSubmit);
 arrValueListForInsert.Add("'" + (objRTUserRelaEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objRTUserRelaEN.LastVisitedDate !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.LastVisitedDate);
 var strLastVisitedDate = objRTUserRelaEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastVisitedDate + "'");
 }
 
 if (objRTUserRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.UpdDate);
 var strUpdDate = objRTUserRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objRTUserRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.UpdUser);
 var strUpdUser = objRTUserRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objRTUserRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.Memo);
 var strMemo = objRTUserRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RTUserRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsRTUserRelaEN objRTUserRelaEN)
{
 objRTUserRelaEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 objRTUserRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTUserRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRTUserRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objRTUserRelaEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.TopicId);
 var strTopicId = objRTUserRelaEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objRTUserRelaEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.UserId);
 var strUserId = objRTUserRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objRTUserRelaEN.TopicUserRoleId  ==  "")
 {
 objRTUserRelaEN.TopicUserRoleId = null;
 }
 if (objRTUserRelaEN.TopicUserRoleId !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.TopicUserRoleId);
 var strTopicUserRoleId = objRTUserRelaEN.TopicUserRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicUserRoleId + "'");
 }
 
 if (objRTUserRelaEN.ColorId !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.ColorId);
 var strColorId = objRTUserRelaEN.ColorId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strColorId + "'");
 }
 
 if (objRTUserRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.OrderNum);
 arrValueListForInsert.Add(objRTUserRelaEN.OrderNum.ToString());
 }
 
 if (objRTUserRelaEN.UserBgColor !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.UserBgColor);
 var strUserBgColor = objRTUserRelaEN.UserBgColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserBgColor + "'");
 }
 
 if (objRTUserRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.IdCurrEduCls);
 var strIdCurrEduCls = objRTUserRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objRTUserRelaEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.AppraiseCount);
 arrValueListForInsert.Add(objRTUserRelaEN.AppraiseCount.ToString());
 }
 
 if (objRTUserRelaEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.OkCount);
 arrValueListForInsert.Add(objRTUserRelaEN.OkCount.ToString());
 }
 
 if (objRTUserRelaEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.Score);
 arrValueListForInsert.Add(objRTUserRelaEN.Score.ToString());
 }
 
 if (objRTUserRelaEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.StuScore);
 arrValueListForInsert.Add(objRTUserRelaEN.StuScore.ToString());
 }
 
 if (objRTUserRelaEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.TeaScore);
 arrValueListForInsert.Add(objRTUserRelaEN.TeaScore.ToString());
 }
 
 arrFieldListForInsert.Add(conRTUserRela.IsSubmit);
 arrValueListForInsert.Add("'" + (objRTUserRelaEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objRTUserRelaEN.LastVisitedDate !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.LastVisitedDate);
 var strLastVisitedDate = objRTUserRelaEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastVisitedDate + "'");
 }
 
 if (objRTUserRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.UpdDate);
 var strUpdDate = objRTUserRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objRTUserRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.UpdUser);
 var strUpdUser = objRTUserRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objRTUserRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.Memo);
 var strMemo = objRTUserRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RTUserRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsRTUserRelaEN objRTUserRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objRTUserRelaEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 objRTUserRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTUserRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRTUserRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objRTUserRelaEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.TopicId);
 var strTopicId = objRTUserRelaEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objRTUserRelaEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.UserId);
 var strUserId = objRTUserRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objRTUserRelaEN.TopicUserRoleId  ==  "")
 {
 objRTUserRelaEN.TopicUserRoleId = null;
 }
 if (objRTUserRelaEN.TopicUserRoleId !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.TopicUserRoleId);
 var strTopicUserRoleId = objRTUserRelaEN.TopicUserRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicUserRoleId + "'");
 }
 
 if (objRTUserRelaEN.ColorId !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.ColorId);
 var strColorId = objRTUserRelaEN.ColorId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strColorId + "'");
 }
 
 if (objRTUserRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.OrderNum);
 arrValueListForInsert.Add(objRTUserRelaEN.OrderNum.ToString());
 }
 
 if (objRTUserRelaEN.UserBgColor !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.UserBgColor);
 var strUserBgColor = objRTUserRelaEN.UserBgColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserBgColor + "'");
 }
 
 if (objRTUserRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.IdCurrEduCls);
 var strIdCurrEduCls = objRTUserRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objRTUserRelaEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.AppraiseCount);
 arrValueListForInsert.Add(objRTUserRelaEN.AppraiseCount.ToString());
 }
 
 if (objRTUserRelaEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.OkCount);
 arrValueListForInsert.Add(objRTUserRelaEN.OkCount.ToString());
 }
 
 if (objRTUserRelaEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.Score);
 arrValueListForInsert.Add(objRTUserRelaEN.Score.ToString());
 }
 
 if (objRTUserRelaEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.StuScore);
 arrValueListForInsert.Add(objRTUserRelaEN.StuScore.ToString());
 }
 
 if (objRTUserRelaEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.TeaScore);
 arrValueListForInsert.Add(objRTUserRelaEN.TeaScore.ToString());
 }
 
 arrFieldListForInsert.Add(conRTUserRela.IsSubmit);
 arrValueListForInsert.Add("'" + (objRTUserRelaEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objRTUserRelaEN.LastVisitedDate !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.LastVisitedDate);
 var strLastVisitedDate = objRTUserRelaEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastVisitedDate + "'");
 }
 
 if (objRTUserRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.UpdDate);
 var strUpdDate = objRTUserRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objRTUserRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.UpdUser);
 var strUpdUser = objRTUserRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objRTUserRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.Memo);
 var strMemo = objRTUserRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RTUserRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsRTUserRelaEN objRTUserRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objRTUserRelaEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 objRTUserRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTUserRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRTUserRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objRTUserRelaEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.TopicId);
 var strTopicId = objRTUserRelaEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objRTUserRelaEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.UserId);
 var strUserId = objRTUserRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objRTUserRelaEN.TopicUserRoleId  ==  "")
 {
 objRTUserRelaEN.TopicUserRoleId = null;
 }
 if (objRTUserRelaEN.TopicUserRoleId !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.TopicUserRoleId);
 var strTopicUserRoleId = objRTUserRelaEN.TopicUserRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicUserRoleId + "'");
 }
 
 if (objRTUserRelaEN.ColorId !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.ColorId);
 var strColorId = objRTUserRelaEN.ColorId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strColorId + "'");
 }
 
 if (objRTUserRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.OrderNum);
 arrValueListForInsert.Add(objRTUserRelaEN.OrderNum.ToString());
 }
 
 if (objRTUserRelaEN.UserBgColor !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.UserBgColor);
 var strUserBgColor = objRTUserRelaEN.UserBgColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserBgColor + "'");
 }
 
 if (objRTUserRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.IdCurrEduCls);
 var strIdCurrEduCls = objRTUserRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objRTUserRelaEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.AppraiseCount);
 arrValueListForInsert.Add(objRTUserRelaEN.AppraiseCount.ToString());
 }
 
 if (objRTUserRelaEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.OkCount);
 arrValueListForInsert.Add(objRTUserRelaEN.OkCount.ToString());
 }
 
 if (objRTUserRelaEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.Score);
 arrValueListForInsert.Add(objRTUserRelaEN.Score.ToString());
 }
 
 if (objRTUserRelaEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.StuScore);
 arrValueListForInsert.Add(objRTUserRelaEN.StuScore.ToString());
 }
 
 if (objRTUserRelaEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.TeaScore);
 arrValueListForInsert.Add(objRTUserRelaEN.TeaScore.ToString());
 }
 
 arrFieldListForInsert.Add(conRTUserRela.IsSubmit);
 arrValueListForInsert.Add("'" + (objRTUserRelaEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objRTUserRelaEN.LastVisitedDate !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.LastVisitedDate);
 var strLastVisitedDate = objRTUserRelaEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastVisitedDate + "'");
 }
 
 if (objRTUserRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.UpdDate);
 var strUpdDate = objRTUserRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objRTUserRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.UpdUser);
 var strUpdUser = objRTUserRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objRTUserRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conRTUserRela.Memo);
 var strMemo = objRTUserRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RTUserRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewRTUserRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTUserRela where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "RTUserRela");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsRTUserRelaEN._CurrTabName ].NewRow();
objRow[conRTUserRela.TopicId] = oRow[conRTUserRela.TopicId].ToString().Trim(); //主题Id
objRow[conRTUserRela.UserId] = oRow[conRTUserRela.UserId].ToString().Trim(); //用户ID
objRow[conRTUserRela.TopicUserRoleId] = oRow[conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objRow[conRTUserRela.ColorId] = oRow[conRTUserRela.ColorId].ToString().Trim(); //颜色Id
objRow[conRTUserRela.OrderNum] = oRow[conRTUserRela.OrderNum].ToString().Trim(); //序号
objRow[conRTUserRela.UserBgColor] = oRow[conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objRow[conRTUserRela.IdCurrEduCls] = oRow[conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conRTUserRela.AppraiseCount] = oRow[conRTUserRela.AppraiseCount].ToString().Trim(); //评论数
objRow[conRTUserRela.OkCount] = oRow[conRTUserRela.OkCount].ToString().Trim(); //点赞统计
objRow[conRTUserRela.Score] = oRow[conRTUserRela.Score].ToString().Trim(); //评分
objRow[conRTUserRela.StuScore] = oRow[conRTUserRela.StuScore].ToString().Trim(); //学生平均分
objRow[conRTUserRela.TeaScore] = oRow[conRTUserRela.TeaScore].ToString().Trim(); //教师评分
objRow[conRTUserRela.IsSubmit] = oRow[conRTUserRela.IsSubmit].ToString().Trim(); //是否提交
objRow[conRTUserRela.LastVisitedDate] = oRow[conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期
objRow[conRTUserRela.UpdDate] = oRow[conRTUserRela.UpdDate].ToString().Trim(); //修改日期
objRow[conRTUserRela.UpdUser] = oRow[conRTUserRela.UpdUser].ToString().Trim(); //修改人
objRow[conRTUserRela.Memo] = oRow[conRTUserRela.Memo].ToString().Trim(); //备注
 objDS.Tables[clsRTUserRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsRTUserRelaEN._CurrTabName);
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
 /// <param name = "objRTUserRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsRTUserRelaEN objRTUserRelaEN)
{
 objRTUserRelaEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 objRTUserRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTUserRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRTUserRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTUserRela where mId = " + ""+ objRTUserRelaEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsRTUserRelaEN._CurrTabName);
if (objDS.Tables[clsRTUserRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objRTUserRelaEN.mId+"");
return false;
}
objRow = objDS.Tables[clsRTUserRelaEN._CurrTabName].Rows[0];
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.TopicId))
 {
objRow[conRTUserRela.TopicId] = objRTUserRelaEN.TopicId; //主题Id
 }
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UserId))
 {
objRow[conRTUserRela.UserId] = objRTUserRelaEN.UserId; //用户ID
 }
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.TopicUserRoleId))
 {
objRow[conRTUserRela.TopicUserRoleId] = objRTUserRelaEN.TopicUserRoleId; //主键Id
 }
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.ColorId))
 {
objRow[conRTUserRela.ColorId] = objRTUserRelaEN.ColorId; //颜色Id
 }
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.OrderNum))
 {
objRow[conRTUserRela.OrderNum] = objRTUserRelaEN.OrderNum; //序号
 }
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UserBgColor))
 {
objRow[conRTUserRela.UserBgColor] = objRTUserRelaEN.UserBgColor; //用户段落背景
 }
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.IdCurrEduCls))
 {
objRow[conRTUserRela.IdCurrEduCls] = objRTUserRelaEN.IdCurrEduCls; //教学班流水号
 }
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.AppraiseCount))
 {
objRow[conRTUserRela.AppraiseCount] = objRTUserRelaEN.AppraiseCount; //评论数
 }
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.OkCount))
 {
objRow[conRTUserRela.OkCount] = objRTUserRelaEN.OkCount; //点赞统计
 }
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.Score))
 {
objRow[conRTUserRela.Score] = objRTUserRelaEN.Score; //评分
 }
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.StuScore))
 {
objRow[conRTUserRela.StuScore] = objRTUserRelaEN.StuScore; //学生平均分
 }
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.TeaScore))
 {
objRow[conRTUserRela.TeaScore] = objRTUserRelaEN.TeaScore; //教师评分
 }
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.IsSubmit))
 {
objRow[conRTUserRela.IsSubmit] = objRTUserRelaEN.IsSubmit; //是否提交
 }
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.LastVisitedDate))
 {
objRow[conRTUserRela.LastVisitedDate] = objRTUserRelaEN.LastVisitedDate; //修改日期
 }
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UpdDate))
 {
objRow[conRTUserRela.UpdDate] = objRTUserRelaEN.UpdDate; //修改日期
 }
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UpdUser))
 {
objRow[conRTUserRela.UpdUser] = objRTUserRelaEN.UpdUser; //修改人
 }
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.Memo))
 {
objRow[conRTUserRela.Memo] = objRTUserRelaEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsRTUserRelaEN._CurrTabName);
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
 /// <param name = "objRTUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsRTUserRelaEN objRTUserRelaEN)
{
 objRTUserRelaEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 objRTUserRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTUserRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRTUserRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update RTUserRela Set ");
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.TopicId))
 {
 if (objRTUserRelaEN.TopicId !=  null)
 {
 var strTopicId = objRTUserRelaEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, conRTUserRela.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.TopicId); //主题Id
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UserId))
 {
 if (objRTUserRelaEN.UserId !=  null)
 {
 var strUserId = objRTUserRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conRTUserRela.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.UserId); //用户ID
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.TopicUserRoleId))
 {
 if (objRTUserRelaEN.TopicUserRoleId  ==  "")
 {
 objRTUserRelaEN.TopicUserRoleId = null;
 }
 if (objRTUserRelaEN.TopicUserRoleId !=  null)
 {
 var strTopicUserRoleId = objRTUserRelaEN.TopicUserRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicUserRoleId, conRTUserRela.TopicUserRoleId); //主键Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.TopicUserRoleId); //主键Id
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.ColorId))
 {
 if (objRTUserRelaEN.ColorId !=  null)
 {
 var strColorId = objRTUserRelaEN.ColorId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strColorId, conRTUserRela.ColorId); //颜色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.ColorId); //颜色Id
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.OrderNum))
 {
 if (objRTUserRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.OrderNum, conRTUserRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.OrderNum); //序号
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UserBgColor))
 {
 if (objRTUserRelaEN.UserBgColor !=  null)
 {
 var strUserBgColor = objRTUserRelaEN.UserBgColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserBgColor, conRTUserRela.UserBgColor); //用户段落背景
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.UserBgColor); //用户段落背景
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.IdCurrEduCls))
 {
 if (objRTUserRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objRTUserRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conRTUserRela.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.AppraiseCount))
 {
 if (objRTUserRelaEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.AppraiseCount, conRTUserRela.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.AppraiseCount); //评论数
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.OkCount))
 {
 if (objRTUserRelaEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.OkCount, conRTUserRela.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.OkCount); //点赞统计
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.Score))
 {
 if (objRTUserRelaEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.Score, conRTUserRela.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.Score); //评分
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.StuScore))
 {
 if (objRTUserRelaEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.StuScore, conRTUserRela.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.StuScore); //学生平均分
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.TeaScore))
 {
 if (objRTUserRelaEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.TeaScore, conRTUserRela.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.TeaScore); //教师评分
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objRTUserRelaEN.IsSubmit == true?"1":"0", conRTUserRela.IsSubmit); //是否提交
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.LastVisitedDate))
 {
 if (objRTUserRelaEN.LastVisitedDate !=  null)
 {
 var strLastVisitedDate = objRTUserRelaEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLastVisitedDate, conRTUserRela.LastVisitedDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.LastVisitedDate); //修改日期
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UpdDate))
 {
 if (objRTUserRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objRTUserRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conRTUserRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.UpdDate); //修改日期
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UpdUser))
 {
 if (objRTUserRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objRTUserRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conRTUserRela.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.UpdUser); //修改人
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.Memo))
 {
 if (objRTUserRelaEN.Memo !=  null)
 {
 var strMemo = objRTUserRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conRTUserRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objRTUserRelaEN.mId); 
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
 /// <param name = "objRTUserRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsRTUserRelaEN objRTUserRelaEN, string strCondition)
{
 objRTUserRelaEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 objRTUserRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTUserRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRTUserRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update RTUserRela Set ");
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.TopicId))
 {
 if (objRTUserRelaEN.TopicId !=  null)
 {
 var strTopicId = objRTUserRelaEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UserId))
 {
 if (objRTUserRelaEN.UserId !=  null)
 {
 var strUserId = objRTUserRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.TopicUserRoleId))
 {
 if (objRTUserRelaEN.TopicUserRoleId  ==  "")
 {
 objRTUserRelaEN.TopicUserRoleId = null;
 }
 if (objRTUserRelaEN.TopicUserRoleId !=  null)
 {
 var strTopicUserRoleId = objRTUserRelaEN.TopicUserRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicUserRoleId = '{0}',", strTopicUserRoleId); //主键Id
 }
 else
 {
 sbSQL.Append(" TopicUserRoleId = null,"); //主键Id
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.ColorId))
 {
 if (objRTUserRelaEN.ColorId !=  null)
 {
 var strColorId = objRTUserRelaEN.ColorId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ColorId = '{0}',", strColorId); //颜色Id
 }
 else
 {
 sbSQL.Append(" ColorId = null,"); //颜色Id
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.OrderNum))
 {
 if (objRTUserRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.OrderNum, conRTUserRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.OrderNum); //序号
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UserBgColor))
 {
 if (objRTUserRelaEN.UserBgColor !=  null)
 {
 var strUserBgColor = objRTUserRelaEN.UserBgColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserBgColor = '{0}',", strUserBgColor); //用户段落背景
 }
 else
 {
 sbSQL.Append(" UserBgColor = null,"); //用户段落背景
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.IdCurrEduCls))
 {
 if (objRTUserRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objRTUserRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.AppraiseCount))
 {
 if (objRTUserRelaEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.AppraiseCount, conRTUserRela.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.AppraiseCount); //评论数
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.OkCount))
 {
 if (objRTUserRelaEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.OkCount, conRTUserRela.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.OkCount); //点赞统计
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.Score))
 {
 if (objRTUserRelaEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.Score, conRTUserRela.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.Score); //评分
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.StuScore))
 {
 if (objRTUserRelaEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.StuScore, conRTUserRela.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.StuScore); //学生平均分
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.TeaScore))
 {
 if (objRTUserRelaEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.TeaScore, conRTUserRela.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.TeaScore); //教师评分
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objRTUserRelaEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.LastVisitedDate))
 {
 if (objRTUserRelaEN.LastVisitedDate !=  null)
 {
 var strLastVisitedDate = objRTUserRelaEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastVisitedDate = '{0}',", strLastVisitedDate); //修改日期
 }
 else
 {
 sbSQL.Append(" LastVisitedDate = null,"); //修改日期
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UpdDate))
 {
 if (objRTUserRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objRTUserRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UpdUser))
 {
 if (objRTUserRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objRTUserRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.Memo))
 {
 if (objRTUserRelaEN.Memo !=  null)
 {
 var strMemo = objRTUserRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objRTUserRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsRTUserRelaEN objRTUserRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objRTUserRelaEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 objRTUserRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTUserRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRTUserRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update RTUserRela Set ");
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.TopicId))
 {
 if (objRTUserRelaEN.TopicId !=  null)
 {
 var strTopicId = objRTUserRelaEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UserId))
 {
 if (objRTUserRelaEN.UserId !=  null)
 {
 var strUserId = objRTUserRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.TopicUserRoleId))
 {
 if (objRTUserRelaEN.TopicUserRoleId  ==  "")
 {
 objRTUserRelaEN.TopicUserRoleId = null;
 }
 if (objRTUserRelaEN.TopicUserRoleId !=  null)
 {
 var strTopicUserRoleId = objRTUserRelaEN.TopicUserRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicUserRoleId = '{0}',", strTopicUserRoleId); //主键Id
 }
 else
 {
 sbSQL.Append(" TopicUserRoleId = null,"); //主键Id
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.ColorId))
 {
 if (objRTUserRelaEN.ColorId !=  null)
 {
 var strColorId = objRTUserRelaEN.ColorId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ColorId = '{0}',", strColorId); //颜色Id
 }
 else
 {
 sbSQL.Append(" ColorId = null,"); //颜色Id
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.OrderNum))
 {
 if (objRTUserRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.OrderNum, conRTUserRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.OrderNum); //序号
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UserBgColor))
 {
 if (objRTUserRelaEN.UserBgColor !=  null)
 {
 var strUserBgColor = objRTUserRelaEN.UserBgColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserBgColor = '{0}',", strUserBgColor); //用户段落背景
 }
 else
 {
 sbSQL.Append(" UserBgColor = null,"); //用户段落背景
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.IdCurrEduCls))
 {
 if (objRTUserRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objRTUserRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.AppraiseCount))
 {
 if (objRTUserRelaEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.AppraiseCount, conRTUserRela.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.AppraiseCount); //评论数
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.OkCount))
 {
 if (objRTUserRelaEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.OkCount, conRTUserRela.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.OkCount); //点赞统计
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.Score))
 {
 if (objRTUserRelaEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.Score, conRTUserRela.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.Score); //评分
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.StuScore))
 {
 if (objRTUserRelaEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.StuScore, conRTUserRela.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.StuScore); //学生平均分
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.TeaScore))
 {
 if (objRTUserRelaEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.TeaScore, conRTUserRela.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.TeaScore); //教师评分
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objRTUserRelaEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.LastVisitedDate))
 {
 if (objRTUserRelaEN.LastVisitedDate !=  null)
 {
 var strLastVisitedDate = objRTUserRelaEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastVisitedDate = '{0}',", strLastVisitedDate); //修改日期
 }
 else
 {
 sbSQL.Append(" LastVisitedDate = null,"); //修改日期
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UpdDate))
 {
 if (objRTUserRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objRTUserRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UpdUser))
 {
 if (objRTUserRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objRTUserRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.Memo))
 {
 if (objRTUserRelaEN.Memo !=  null)
 {
 var strMemo = objRTUserRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objRTUserRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsRTUserRelaEN objRTUserRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objRTUserRelaEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 objRTUserRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTUserRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRTUserRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update RTUserRela Set ");
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.TopicId))
 {
 if (objRTUserRelaEN.TopicId !=  null)
 {
 var strTopicId = objRTUserRelaEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, conRTUserRela.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.TopicId); //主题Id
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UserId))
 {
 if (objRTUserRelaEN.UserId !=  null)
 {
 var strUserId = objRTUserRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conRTUserRela.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.UserId); //用户ID
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.TopicUserRoleId))
 {
 if (objRTUserRelaEN.TopicUserRoleId  ==  "")
 {
 objRTUserRelaEN.TopicUserRoleId = null;
 }
 if (objRTUserRelaEN.TopicUserRoleId !=  null)
 {
 var strTopicUserRoleId = objRTUserRelaEN.TopicUserRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicUserRoleId, conRTUserRela.TopicUserRoleId); //主键Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.TopicUserRoleId); //主键Id
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.ColorId))
 {
 if (objRTUserRelaEN.ColorId !=  null)
 {
 var strColorId = objRTUserRelaEN.ColorId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strColorId, conRTUserRela.ColorId); //颜色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.ColorId); //颜色Id
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.OrderNum))
 {
 if (objRTUserRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.OrderNum, conRTUserRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.OrderNum); //序号
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UserBgColor))
 {
 if (objRTUserRelaEN.UserBgColor !=  null)
 {
 var strUserBgColor = objRTUserRelaEN.UserBgColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserBgColor, conRTUserRela.UserBgColor); //用户段落背景
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.UserBgColor); //用户段落背景
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.IdCurrEduCls))
 {
 if (objRTUserRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objRTUserRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conRTUserRela.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.AppraiseCount))
 {
 if (objRTUserRelaEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.AppraiseCount, conRTUserRela.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.AppraiseCount); //评论数
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.OkCount))
 {
 if (objRTUserRelaEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.OkCount, conRTUserRela.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.OkCount); //点赞统计
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.Score))
 {
 if (objRTUserRelaEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.Score, conRTUserRela.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.Score); //评分
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.StuScore))
 {
 if (objRTUserRelaEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.StuScore, conRTUserRela.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.StuScore); //学生平均分
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.TeaScore))
 {
 if (objRTUserRelaEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTUserRelaEN.TeaScore, conRTUserRela.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.TeaScore); //教师评分
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objRTUserRelaEN.IsSubmit == true?"1":"0", conRTUserRela.IsSubmit); //是否提交
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.LastVisitedDate))
 {
 if (objRTUserRelaEN.LastVisitedDate !=  null)
 {
 var strLastVisitedDate = objRTUserRelaEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLastVisitedDate, conRTUserRela.LastVisitedDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.LastVisitedDate); //修改日期
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UpdDate))
 {
 if (objRTUserRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objRTUserRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conRTUserRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.UpdDate); //修改日期
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.UpdUser))
 {
 if (objRTUserRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objRTUserRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conRTUserRela.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.UpdUser); //修改人
 }
 }
 
 if (objRTUserRelaEN.IsUpdated(conRTUserRela.Memo))
 {
 if (objRTUserRelaEN.Memo !=  null)
 {
 var strMemo = objRTUserRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conRTUserRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTUserRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objRTUserRelaEN.mId); 
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
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("RTUserRela_Delete", values);
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
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
//删除RTUserRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from RTUserRela where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelRTUserRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
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
//删除RTUserRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from RTUserRela where mId in (" + strKeyList + ")";
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
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
//删除RTUserRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from RTUserRela where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelRTUserRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsRTUserRelaDA: DelRTUserRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from RTUserRela where " + strCondition ;
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
public bool DelRTUserRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsRTUserRelaDA: DelRTUserRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from RTUserRela where " + strCondition ;
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
 /// <param name = "objRTUserRelaENS">源对象</param>
 /// <param name = "objRTUserRelaENT">目标对象</param>
public void CopyTo(clsRTUserRelaEN objRTUserRelaENS, clsRTUserRelaEN objRTUserRelaENT)
{
objRTUserRelaENT.mId = objRTUserRelaENS.mId; //mId
objRTUserRelaENT.TopicId = objRTUserRelaENS.TopicId; //主题Id
objRTUserRelaENT.UserId = objRTUserRelaENS.UserId; //用户ID
objRTUserRelaENT.TopicUserRoleId = objRTUserRelaENS.TopicUserRoleId; //主键Id
objRTUserRelaENT.ColorId = objRTUserRelaENS.ColorId; //颜色Id
objRTUserRelaENT.OrderNum = objRTUserRelaENS.OrderNum; //序号
objRTUserRelaENT.UserBgColor = objRTUserRelaENS.UserBgColor; //用户段落背景
objRTUserRelaENT.IdCurrEduCls = objRTUserRelaENS.IdCurrEduCls; //教学班流水号
objRTUserRelaENT.AppraiseCount = objRTUserRelaENS.AppraiseCount; //评论数
objRTUserRelaENT.OkCount = objRTUserRelaENS.OkCount; //点赞统计
objRTUserRelaENT.Score = objRTUserRelaENS.Score; //评分
objRTUserRelaENT.StuScore = objRTUserRelaENS.StuScore; //学生平均分
objRTUserRelaENT.TeaScore = objRTUserRelaENS.TeaScore; //教师评分
objRTUserRelaENT.IsSubmit = objRTUserRelaENS.IsSubmit; //是否提交
objRTUserRelaENT.LastVisitedDate = objRTUserRelaENS.LastVisitedDate; //修改日期
objRTUserRelaENT.UpdDate = objRTUserRelaENS.UpdDate; //修改日期
objRTUserRelaENT.UpdUser = objRTUserRelaENS.UpdUser; //修改人
objRTUserRelaENT.Memo = objRTUserRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsRTUserRelaEN objRTUserRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objRTUserRelaEN.TopicUserRoleId, conRTUserRela.TopicUserRoleId);
//检查字段长度
clsCheckSql.CheckFieldLen(objRTUserRelaEN.TopicId, 8, conRTUserRela.TopicId);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.UserId, 18, conRTUserRela.UserId);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.TopicUserRoleId, 4, conRTUserRela.TopicUserRoleId);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.ColorId, 2, conRTUserRela.ColorId);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.UserBgColor, 200, conRTUserRela.UserBgColor);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.IdCurrEduCls, 8, conRTUserRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.LastVisitedDate, 20, conRTUserRela.LastVisitedDate);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.UpdDate, 20, conRTUserRela.UpdDate);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.UpdUser, 20, conRTUserRela.UpdUser);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.Memo, 1000, conRTUserRela.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objRTUserRelaEN.TopicUserRoleId, 4, conRTUserRela.TopicUserRoleId);
 objRTUserRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsRTUserRelaEN objRTUserRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objRTUserRelaEN.TopicId, 8, conRTUserRela.TopicId);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.UserId, 18, conRTUserRela.UserId);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.TopicUserRoleId, 4, conRTUserRela.TopicUserRoleId);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.ColorId, 2, conRTUserRela.ColorId);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.UserBgColor, 200, conRTUserRela.UserBgColor);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.IdCurrEduCls, 8, conRTUserRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.LastVisitedDate, 20, conRTUserRela.LastVisitedDate);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.UpdDate, 20, conRTUserRela.UpdDate);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.UpdUser, 20, conRTUserRela.UpdUser);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.Memo, 1000, conRTUserRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objRTUserRelaEN.TopicUserRoleId, 4, conRTUserRela.TopicUserRoleId);
 objRTUserRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsRTUserRelaEN objRTUserRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objRTUserRelaEN.TopicId, 8, conRTUserRela.TopicId);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.UserId, 18, conRTUserRela.UserId);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.TopicUserRoleId, 4, conRTUserRela.TopicUserRoleId);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.ColorId, 2, conRTUserRela.ColorId);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.UserBgColor, 200, conRTUserRela.UserBgColor);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.IdCurrEduCls, 8, conRTUserRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.LastVisitedDate, 20, conRTUserRela.LastVisitedDate);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.UpdDate, 20, conRTUserRela.UpdDate);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.UpdUser, 20, conRTUserRela.UpdUser);
clsCheckSql.CheckFieldLen(objRTUserRelaEN.Memo, 1000, conRTUserRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objRTUserRelaEN.TopicId, conRTUserRela.TopicId);
clsCheckSql.CheckSqlInjection4Field(objRTUserRelaEN.UserId, conRTUserRela.UserId);
clsCheckSql.CheckSqlInjection4Field(objRTUserRelaEN.TopicUserRoleId, conRTUserRela.TopicUserRoleId);
clsCheckSql.CheckSqlInjection4Field(objRTUserRelaEN.ColorId, conRTUserRela.ColorId);
clsCheckSql.CheckSqlInjection4Field(objRTUserRelaEN.UserBgColor, conRTUserRela.UserBgColor);
clsCheckSql.CheckSqlInjection4Field(objRTUserRelaEN.IdCurrEduCls, conRTUserRela.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objRTUserRelaEN.LastVisitedDate, conRTUserRela.LastVisitedDate);
clsCheckSql.CheckSqlInjection4Field(objRTUserRelaEN.UpdDate, conRTUserRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objRTUserRelaEN.UpdUser, conRTUserRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objRTUserRelaEN.Memo, conRTUserRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objRTUserRelaEN.TopicUserRoleId, 4, conRTUserRela.TopicUserRoleId);
 objRTUserRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--RTUserRela(主题用户关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objRTUserRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsRTUserRelaEN objRTUserRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objRTUserRelaEN.TopicId == null)
{
 sbCondition.AppendFormat(" and TopicId is null");
}
else
{
 sbCondition.AppendFormat(" and TopicId = '{0}'", objRTUserRelaEN.TopicId);
}
 if (objRTUserRelaEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null");
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objRTUserRelaEN.UserId);
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
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
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
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
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
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsRTUserRelaEN._CurrTabName);
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
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsRTUserRelaEN._CurrTabName, strCondition);
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
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
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
 objSQL = clsRTUserRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}