
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTSysSkillDA
 表名:vRTSysSkill(01120656)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// vRTSysSkill(vRTSysSkill)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvRTSysSkillDA : clsCommBase4DA
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
 return clsvRTSysSkillEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvRTSysSkillEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTSysSkillEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvRTSysSkillEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvRTSysSkillEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvRTSysSkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSkill where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vRTSysSkill(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvRTSysSkillDA: GetDataTable_vRTSysSkill)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSkill where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvRTSysSkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvRTSysSkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSkill where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvRTSysSkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvRTSysSkillDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSkill where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSkill where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvRTSysSkillDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vRTSysSkill where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvRTSysSkillDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTSysSkill.* from vRTSysSkill Left Join {1} on {2} where {3} and vRTSysSkill.mId not in (Select top {5} vRTSysSkill.mId from vRTSysSkill Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSkill where {1} and mId not in (Select top {2} mId from vRTSysSkill where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSkill where {1} and mId not in (Select top {3} mId from vRTSysSkill where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvRTSysSkillDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTSysSkill.* from vRTSysSkill Left Join {1} on {2} where {3} and vRTSysSkill.mId not in (Select top {5} vRTSysSkill.mId from vRTSysSkill Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSkill where {1} and mId not in (Select top {2} mId from vRTSysSkill where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSkill where {1} and mId not in (Select top {3} mId from vRTSysSkill where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvRTSysSkillEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvRTSysSkillDA:GetObjLst)", objException.Message));
}
List<clsvRTSysSkillEN> arrObjLst = new List<clsvRTSysSkillEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSkill where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN();
try
{
objvRTSysSkillEN.TopicName = objRow[convRTSysSkill.TopicName] == DBNull.Value ? null : objRow[convRTSysSkill.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillEN.SkillName = objRow[convRTSysSkill.SkillName] == DBNull.Value ? null : objRow[convRTSysSkill.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillEN.OperationTypeId = objRow[convRTSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillEN.Process = objRow[convRTSysSkill.Process] == DBNull.Value ? null : objRow[convRTSysSkill.Process].ToString().Trim(); //实施过程
objvRTSysSkillEN.LevelId = objRow[convRTSysSkill.LevelId] == DBNull.Value ? null : objRow[convRTSysSkill.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillEN.LevelName = objRow[convRTSysSkill.LevelName] == DBNull.Value ? null : objRow[convRTSysSkill.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillEN.SkillUpdUser = objRow[convRTSysSkill.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillEN.SkillUpdDate = objRow[convRTSysSkill.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillEN.OrderNum = objRow[convRTSysSkill.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.OrderNum].ToString().Trim()); //序号
objvRTSysSkillEN.IdCurrEduCls = objRow[convRTSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillEN.TopicProposePeople = objRow[convRTSysSkill.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkill.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillEN.TopicContent = objRow[convRTSysSkill.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkill.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillEN.IsSubmit = TransNullToBool(objRow[convRTSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillEN.AppraiseCount = objRow[convRTSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillEN.Score = objRow[convRTSysSkill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkill.Score].ToString().Trim()); //评分
objvRTSysSkillEN.StuScore = objRow[convRTSysSkill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkill.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillEN.TeaScore = objRow[convRTSysSkill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkill.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillEN.PdfContent = objRow[convRTSysSkill.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillEN.PdfPageNum = objRow[convRTSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillEN.CitationCount = objRow[convRTSysSkill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillEN.VersionCount = objRow[convRTSysSkill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillEN.OperationTypeName = objRow[convRTSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillEN.OkCount = objRow[convRTSysSkill.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillEN.CitationId = objRow[convRTSysSkill.CitationId] == DBNull.Value ? null : objRow[convRTSysSkill.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillEN.mId = TransNullToInt(objRow[convRTSysSkill.mId].ToString().Trim()); //mId
objvRTSysSkillEN.TopicId = objRow[convRTSysSkill.TopicId] == DBNull.Value ? null : objRow[convRTSysSkill.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillEN.SkillId = objRow[convRTSysSkill.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillEN.UpdDate = objRow[convRTSysSkill.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillEN.Memo = objRow[convRTSysSkill.Memo] == DBNull.Value ? null : objRow[convRTSysSkill.Memo].ToString().Trim(); //备注
objvRTSysSkillEN.UpdUser = objRow[convRTSysSkill.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillEN.CreateDate = objRow[convRTSysSkill.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkill.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillEN.ShareId = objRow[convRTSysSkill.ShareId] == DBNull.Value ? null : objRow[convRTSysSkill.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillEN.ClassificationId = objRow[convRTSysSkill.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkill.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTSysSkillDA: GetObjLst)", objException.Message));
}
objvRTSysSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTSysSkillEN);
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
public List<clsvRTSysSkillEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvRTSysSkillDA:GetObjLstByTabName)", objException.Message));
}
List<clsvRTSysSkillEN> arrObjLst = new List<clsvRTSysSkillEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN();
try
{
objvRTSysSkillEN.TopicName = objRow[convRTSysSkill.TopicName] == DBNull.Value ? null : objRow[convRTSysSkill.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillEN.SkillName = objRow[convRTSysSkill.SkillName] == DBNull.Value ? null : objRow[convRTSysSkill.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillEN.OperationTypeId = objRow[convRTSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillEN.Process = objRow[convRTSysSkill.Process] == DBNull.Value ? null : objRow[convRTSysSkill.Process].ToString().Trim(); //实施过程
objvRTSysSkillEN.LevelId = objRow[convRTSysSkill.LevelId] == DBNull.Value ? null : objRow[convRTSysSkill.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillEN.LevelName = objRow[convRTSysSkill.LevelName] == DBNull.Value ? null : objRow[convRTSysSkill.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillEN.SkillUpdUser = objRow[convRTSysSkill.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillEN.SkillUpdDate = objRow[convRTSysSkill.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillEN.OrderNum = objRow[convRTSysSkill.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.OrderNum].ToString().Trim()); //序号
objvRTSysSkillEN.IdCurrEduCls = objRow[convRTSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillEN.TopicProposePeople = objRow[convRTSysSkill.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkill.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillEN.TopicContent = objRow[convRTSysSkill.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkill.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillEN.IsSubmit = TransNullToBool(objRow[convRTSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillEN.AppraiseCount = objRow[convRTSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillEN.Score = objRow[convRTSysSkill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkill.Score].ToString().Trim()); //评分
objvRTSysSkillEN.StuScore = objRow[convRTSysSkill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkill.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillEN.TeaScore = objRow[convRTSysSkill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkill.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillEN.PdfContent = objRow[convRTSysSkill.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillEN.PdfPageNum = objRow[convRTSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillEN.CitationCount = objRow[convRTSysSkill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillEN.VersionCount = objRow[convRTSysSkill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillEN.OperationTypeName = objRow[convRTSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillEN.OkCount = objRow[convRTSysSkill.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillEN.CitationId = objRow[convRTSysSkill.CitationId] == DBNull.Value ? null : objRow[convRTSysSkill.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillEN.mId = TransNullToInt(objRow[convRTSysSkill.mId].ToString().Trim()); //mId
objvRTSysSkillEN.TopicId = objRow[convRTSysSkill.TopicId] == DBNull.Value ? null : objRow[convRTSysSkill.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillEN.SkillId = objRow[convRTSysSkill.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillEN.UpdDate = objRow[convRTSysSkill.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillEN.Memo = objRow[convRTSysSkill.Memo] == DBNull.Value ? null : objRow[convRTSysSkill.Memo].ToString().Trim(); //备注
objvRTSysSkillEN.UpdUser = objRow[convRTSysSkill.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillEN.CreateDate = objRow[convRTSysSkill.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkill.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillEN.ShareId = objRow[convRTSysSkill.ShareId] == DBNull.Value ? null : objRow[convRTSysSkill.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillEN.ClassificationId = objRow[convRTSysSkill.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkill.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTSysSkillDA: GetObjLst)", objException.Message));
}
objvRTSysSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTSysSkillEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvRTSysSkill(ref clsvRTSysSkillEN objvRTSysSkillEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSkill where mId = " + ""+ objvRTSysSkillEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvRTSysSkillEN.TopicName = objDT.Rows[0][convRTSysSkill.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTSysSkillEN.SkillName = objDT.Rows[0][convRTSysSkill.SkillName].ToString().Trim(); //技能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTSysSkillEN.OperationTypeId = objDT.Rows[0][convRTSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvRTSysSkillEN.Process = objDT.Rows[0][convRTSysSkill.Process].ToString().Trim(); //实施过程(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTSysSkillEN.LevelId = objDT.Rows[0][convRTSysSkill.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objvRTSysSkillEN.LevelName = objDT.Rows[0][convRTSysSkill.LevelName].ToString().Trim(); //级别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSkillEN.SkillUpdUser = objDT.Rows[0][convRTSysSkill.SkillUpdUser].ToString().Trim(); //SkillUpdUser(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillEN.SkillUpdDate = objDT.Rows[0][convRTSysSkill.SkillUpdDate].ToString().Trim(); //SkillUpdDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillEN.OrderNum = TransNullToInt(objDT.Rows[0][convRTSysSkill.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillEN.IdCurrEduCls = objDT.Rows[0][convRTSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTSysSkillEN.TopicProposePeople = objDT.Rows[0][convRTSysSkill.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSkillEN.TopicContent = objDT.Rows[0][convRTSysSkill.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTSysSkillEN.IsSubmit = TransNullToBool(objDT.Rows[0][convRTSysSkill.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTSysSkillEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convRTSysSkill.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillEN.Score = TransNullToFloat(objDT.Rows[0][convRTSysSkill.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSkillEN.StuScore = TransNullToFloat(objDT.Rows[0][convRTSysSkill.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSkillEN.TeaScore = TransNullToFloat(objDT.Rows[0][convRTSysSkill.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSkillEN.PdfContent = objDT.Rows[0][convRTSysSkill.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvRTSysSkillEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convRTSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillEN.CitationCount = TransNullToInt(objDT.Rows[0][convRTSysSkill.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillEN.VersionCount = TransNullToInt(objDT.Rows[0][convRTSysSkill.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillEN.OperationTypeName = objDT.Rows[0][convRTSysSkill.OperationTypeName].ToString().Trim(); //操作类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvRTSysSkillEN.OkCount = TransNullToInt(objDT.Rows[0][convRTSysSkill.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillEN.CitationId = objDT.Rows[0][convRTSysSkill.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTSysSkillEN.mId = TransNullToInt(objDT.Rows[0][convRTSysSkill.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTSysSkillEN.TopicId = objDT.Rows[0][convRTSysSkill.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTSysSkillEN.SkillId = objDT.Rows[0][convRTSysSkill.SkillId].ToString().Trim(); //技能Id(字段类型:char,字段长度:10,是否可空:False)
 objvRTSysSkillEN.UpdDate = objDT.Rows[0][convRTSysSkill.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillEN.Memo = objDT.Rows[0][convRTSysSkill.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvRTSysSkillEN.UpdUser = objDT.Rows[0][convRTSysSkill.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillEN.CreateDate = objDT.Rows[0][convRTSysSkill.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillEN.ShareId = objDT.Rows[0][convRTSysSkill.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTSysSkillEN.ClassificationId = objDT.Rows[0][convRTSysSkill.ClassificationId].ToString().Trim(); //分类Id(字段类型:char,字段长度:10,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvRTSysSkillDA: GetvRTSysSkill)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvRTSysSkillEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSkill where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN();
try
{
 objvRTSysSkillEN.TopicName = objRow[convRTSysSkill.TopicName] == DBNull.Value ? null : objRow[convRTSysSkill.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTSysSkillEN.SkillName = objRow[convRTSysSkill.SkillName] == DBNull.Value ? null : objRow[convRTSysSkill.SkillName].ToString().Trim(); //技能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTSysSkillEN.OperationTypeId = objRow[convRTSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvRTSysSkillEN.Process = objRow[convRTSysSkill.Process] == DBNull.Value ? null : objRow[convRTSysSkill.Process].ToString().Trim(); //实施过程(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTSysSkillEN.LevelId = objRow[convRTSysSkill.LevelId] == DBNull.Value ? null : objRow[convRTSysSkill.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objvRTSysSkillEN.LevelName = objRow[convRTSysSkill.LevelName] == DBNull.Value ? null : objRow[convRTSysSkill.LevelName].ToString().Trim(); //级别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSkillEN.SkillUpdUser = objRow[convRTSysSkill.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdUser].ToString().Trim(); //SkillUpdUser(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillEN.SkillUpdDate = objRow[convRTSysSkill.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdDate].ToString().Trim(); //SkillUpdDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillEN.OrderNum = objRow[convRTSysSkill.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillEN.IdCurrEduCls = objRow[convRTSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTSysSkillEN.TopicProposePeople = objRow[convRTSysSkill.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkill.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSkillEN.TopicContent = objRow[convRTSysSkill.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkill.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkill.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTSysSkillEN.AppraiseCount = objRow[convRTSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillEN.Score = objRow[convRTSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSkillEN.StuScore = objRow[convRTSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSkillEN.TeaScore = objRow[convRTSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSkillEN.PdfContent = objRow[convRTSysSkill.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkill.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvRTSysSkillEN.PdfPageNum = objRow[convRTSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillEN.CitationCount = objRow[convRTSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillEN.VersionCount = objRow[convRTSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillEN.OperationTypeName = objRow[convRTSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeName].ToString().Trim(); //操作类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvRTSysSkillEN.OkCount = objRow[convRTSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillEN.CitationId = objRow[convRTSysSkill.CitationId] == DBNull.Value ? null : objRow[convRTSysSkill.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTSysSkillEN.mId = Int32.Parse(objRow[convRTSysSkill.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTSysSkillEN.TopicId = objRow[convRTSysSkill.TopicId] == DBNull.Value ? null : objRow[convRTSysSkill.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTSysSkillEN.SkillId = objRow[convRTSysSkill.SkillId].ToString().Trim(); //技能Id(字段类型:char,字段长度:10,是否可空:False)
 objvRTSysSkillEN.UpdDate = objRow[convRTSysSkill.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillEN.Memo = objRow[convRTSysSkill.Memo] == DBNull.Value ? null : objRow[convRTSysSkill.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvRTSysSkillEN.UpdUser = objRow[convRTSysSkill.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillEN.CreateDate = objRow[convRTSysSkill.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkill.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillEN.ShareId = objRow[convRTSysSkill.ShareId] == DBNull.Value ? null : objRow[convRTSysSkill.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTSysSkillEN.ClassificationId = objRow[convRTSysSkill.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkill.ClassificationId].ToString().Trim(); //分类Id(字段类型:char,字段长度:10,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvRTSysSkillDA: GetObjBymId)", objException.Message));
}
return objvRTSysSkillEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvRTSysSkillEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvRTSysSkillDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSkill where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN()
{
TopicName = objRow[convRTSysSkill.TopicName] == DBNull.Value ? null : objRow[convRTSysSkill.TopicName].ToString().Trim(), //栏目主题
SkillName = objRow[convRTSysSkill.SkillName] == DBNull.Value ? null : objRow[convRTSysSkill.SkillName].ToString().Trim(), //技能名称
OperationTypeId = objRow[convRTSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeId].ToString().Trim(), //操作类型ID
Process = objRow[convRTSysSkill.Process] == DBNull.Value ? null : objRow[convRTSysSkill.Process].ToString().Trim(), //实施过程
LevelId = objRow[convRTSysSkill.LevelId] == DBNull.Value ? null : objRow[convRTSysSkill.LevelId].ToString().Trim(), //级别Id
LevelName = objRow[convRTSysSkill.LevelName] == DBNull.Value ? null : objRow[convRTSysSkill.LevelName].ToString().Trim(), //级别名称
SkillUpdUser = objRow[convRTSysSkill.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdUser].ToString().Trim(), //SkillUpdUser
SkillUpdDate = objRow[convRTSysSkill.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdDate].ToString().Trim(), //SkillUpdDate
OrderNum = objRow[convRTSysSkill.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.OrderNum].ToString().Trim()), //序号
IdCurrEduCls = objRow[convRTSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkill.IdCurrEduCls].ToString().Trim(), //教学班流水号
TopicProposePeople = objRow[convRTSysSkill.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkill.TopicProposePeople].ToString().Trim(), //主题提出人
TopicContent = objRow[convRTSysSkill.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkill.TopicContent].ToString().Trim(), //主题内容
IsSubmit = TransNullToBool(objRow[convRTSysSkill.IsSubmit].ToString().Trim()), //是否提交
AppraiseCount = objRow[convRTSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[convRTSysSkill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkill.Score].ToString().Trim()), //评分
StuScore = objRow[convRTSysSkill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkill.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convRTSysSkill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkill.TeaScore].ToString().Trim()), //教师评分
PdfContent = objRow[convRTSysSkill.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkill.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[convRTSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[convRTSysSkill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[convRTSysSkill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.VersionCount].ToString().Trim()), //版本统计
OperationTypeName = objRow[convRTSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeName].ToString().Trim(), //操作类型名
OkCount = objRow[convRTSysSkill.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.OkCount].ToString().Trim()), //点赞统计
CitationId = objRow[convRTSysSkill.CitationId] == DBNull.Value ? null : objRow[convRTSysSkill.CitationId].ToString().Trim(), //引用Id
mId = TransNullToInt(objRow[convRTSysSkill.mId].ToString().Trim()), //mId
TopicId = objRow[convRTSysSkill.TopicId] == DBNull.Value ? null : objRow[convRTSysSkill.TopicId].ToString().Trim(), //主题Id
SkillId = objRow[convRTSysSkill.SkillId].ToString().Trim(), //技能Id
UpdDate = objRow[convRTSysSkill.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convRTSysSkill.Memo] == DBNull.Value ? null : objRow[convRTSysSkill.Memo].ToString().Trim(), //备注
UpdUser = objRow[convRTSysSkill.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.UpdUser].ToString().Trim(), //修改人
CreateDate = objRow[convRTSysSkill.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkill.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convRTSysSkill.ShareId] == DBNull.Value ? null : objRow[convRTSysSkill.ShareId].ToString().Trim(), //分享Id
ClassificationId = objRow[convRTSysSkill.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkill.ClassificationId].ToString().Trim() //分类Id
};
objvRTSysSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTSysSkillEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvRTSysSkillDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvRTSysSkillEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN();
try
{
objvRTSysSkillEN.TopicName = objRow[convRTSysSkill.TopicName] == DBNull.Value ? null : objRow[convRTSysSkill.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillEN.SkillName = objRow[convRTSysSkill.SkillName] == DBNull.Value ? null : objRow[convRTSysSkill.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillEN.OperationTypeId = objRow[convRTSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillEN.Process = objRow[convRTSysSkill.Process] == DBNull.Value ? null : objRow[convRTSysSkill.Process].ToString().Trim(); //实施过程
objvRTSysSkillEN.LevelId = objRow[convRTSysSkill.LevelId] == DBNull.Value ? null : objRow[convRTSysSkill.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillEN.LevelName = objRow[convRTSysSkill.LevelName] == DBNull.Value ? null : objRow[convRTSysSkill.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillEN.SkillUpdUser = objRow[convRTSysSkill.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillEN.SkillUpdDate = objRow[convRTSysSkill.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillEN.OrderNum = objRow[convRTSysSkill.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.OrderNum].ToString().Trim()); //序号
objvRTSysSkillEN.IdCurrEduCls = objRow[convRTSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillEN.TopicProposePeople = objRow[convRTSysSkill.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkill.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillEN.TopicContent = objRow[convRTSysSkill.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkill.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillEN.IsSubmit = TransNullToBool(objRow[convRTSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillEN.AppraiseCount = objRow[convRTSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillEN.Score = objRow[convRTSysSkill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkill.Score].ToString().Trim()); //评分
objvRTSysSkillEN.StuScore = objRow[convRTSysSkill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkill.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillEN.TeaScore = objRow[convRTSysSkill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkill.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillEN.PdfContent = objRow[convRTSysSkill.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillEN.PdfPageNum = objRow[convRTSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillEN.CitationCount = objRow[convRTSysSkill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillEN.VersionCount = objRow[convRTSysSkill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillEN.OperationTypeName = objRow[convRTSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillEN.OkCount = objRow[convRTSysSkill.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillEN.CitationId = objRow[convRTSysSkill.CitationId] == DBNull.Value ? null : objRow[convRTSysSkill.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillEN.mId = TransNullToInt(objRow[convRTSysSkill.mId].ToString().Trim()); //mId
objvRTSysSkillEN.TopicId = objRow[convRTSysSkill.TopicId] == DBNull.Value ? null : objRow[convRTSysSkill.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillEN.SkillId = objRow[convRTSysSkill.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillEN.UpdDate = objRow[convRTSysSkill.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillEN.Memo = objRow[convRTSysSkill.Memo] == DBNull.Value ? null : objRow[convRTSysSkill.Memo].ToString().Trim(); //备注
objvRTSysSkillEN.UpdUser = objRow[convRTSysSkill.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillEN.CreateDate = objRow[convRTSysSkill.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkill.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillEN.ShareId = objRow[convRTSysSkill.ShareId] == DBNull.Value ? null : objRow[convRTSysSkill.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillEN.ClassificationId = objRow[convRTSysSkill.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkill.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvRTSysSkillDA: GetObjByDataRowvRTSysSkill)", objException.Message));
}
objvRTSysSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTSysSkillEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvRTSysSkillEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN();
try
{
objvRTSysSkillEN.TopicName = objRow[convRTSysSkill.TopicName] == DBNull.Value ? null : objRow[convRTSysSkill.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillEN.SkillName = objRow[convRTSysSkill.SkillName] == DBNull.Value ? null : objRow[convRTSysSkill.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillEN.OperationTypeId = objRow[convRTSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillEN.Process = objRow[convRTSysSkill.Process] == DBNull.Value ? null : objRow[convRTSysSkill.Process].ToString().Trim(); //实施过程
objvRTSysSkillEN.LevelId = objRow[convRTSysSkill.LevelId] == DBNull.Value ? null : objRow[convRTSysSkill.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillEN.LevelName = objRow[convRTSysSkill.LevelName] == DBNull.Value ? null : objRow[convRTSysSkill.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillEN.SkillUpdUser = objRow[convRTSysSkill.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillEN.SkillUpdDate = objRow[convRTSysSkill.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillEN.OrderNum = objRow[convRTSysSkill.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.OrderNum].ToString().Trim()); //序号
objvRTSysSkillEN.IdCurrEduCls = objRow[convRTSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillEN.TopicProposePeople = objRow[convRTSysSkill.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkill.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillEN.TopicContent = objRow[convRTSysSkill.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkill.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillEN.IsSubmit = TransNullToBool(objRow[convRTSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillEN.AppraiseCount = objRow[convRTSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillEN.Score = objRow[convRTSysSkill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkill.Score].ToString().Trim()); //评分
objvRTSysSkillEN.StuScore = objRow[convRTSysSkill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkill.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillEN.TeaScore = objRow[convRTSysSkill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkill.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillEN.PdfContent = objRow[convRTSysSkill.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillEN.PdfPageNum = objRow[convRTSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillEN.CitationCount = objRow[convRTSysSkill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillEN.VersionCount = objRow[convRTSysSkill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillEN.OperationTypeName = objRow[convRTSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillEN.OkCount = objRow[convRTSysSkill.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkill.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillEN.CitationId = objRow[convRTSysSkill.CitationId] == DBNull.Value ? null : objRow[convRTSysSkill.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillEN.mId = TransNullToInt(objRow[convRTSysSkill.mId].ToString().Trim()); //mId
objvRTSysSkillEN.TopicId = objRow[convRTSysSkill.TopicId] == DBNull.Value ? null : objRow[convRTSysSkill.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillEN.SkillId = objRow[convRTSysSkill.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillEN.UpdDate = objRow[convRTSysSkill.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillEN.Memo = objRow[convRTSysSkill.Memo] == DBNull.Value ? null : objRow[convRTSysSkill.Memo].ToString().Trim(); //备注
objvRTSysSkillEN.UpdUser = objRow[convRTSysSkill.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillEN.CreateDate = objRow[convRTSysSkill.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkill.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillEN.ShareId = objRow[convRTSysSkill.ShareId] == DBNull.Value ? null : objRow[convRTSysSkill.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillEN.ClassificationId = objRow[convRTSysSkill.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkill.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvRTSysSkillDA: GetObjByDataRow)", objException.Message));
}
objvRTSysSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTSysSkillEN;
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
objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTSysSkillEN._CurrTabName, convRTSysSkill.mId, 8, "");
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
objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTSysSkillEN._CurrTabName, convRTSysSkill.mId, 8, strPrefix);
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
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vRTSysSkill where " + strCondition;
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
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vRTSysSkill where " + strCondition;
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
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTSysSkill", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvRTSysSkillDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTSysSkill", strCondition))
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
objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vRTSysSkill");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvRTSysSkillENS">源对象</param>
 /// <param name = "objvRTSysSkillENT">目标对象</param>
public void CopyTo(clsvRTSysSkillEN objvRTSysSkillENS, clsvRTSysSkillEN objvRTSysSkillENT)
{
objvRTSysSkillENT.TopicName = objvRTSysSkillENS.TopicName; //栏目主题
objvRTSysSkillENT.SkillName = objvRTSysSkillENS.SkillName; //技能名称
objvRTSysSkillENT.OperationTypeId = objvRTSysSkillENS.OperationTypeId; //操作类型ID
objvRTSysSkillENT.Process = objvRTSysSkillENS.Process; //实施过程
objvRTSysSkillENT.LevelId = objvRTSysSkillENS.LevelId; //级别Id
objvRTSysSkillENT.LevelName = objvRTSysSkillENS.LevelName; //级别名称
objvRTSysSkillENT.SkillUpdUser = objvRTSysSkillENS.SkillUpdUser; //SkillUpdUser
objvRTSysSkillENT.SkillUpdDate = objvRTSysSkillENS.SkillUpdDate; //SkillUpdDate
objvRTSysSkillENT.OrderNum = objvRTSysSkillENS.OrderNum; //序号
objvRTSysSkillENT.IdCurrEduCls = objvRTSysSkillENS.IdCurrEduCls; //教学班流水号
objvRTSysSkillENT.TopicProposePeople = objvRTSysSkillENS.TopicProposePeople; //主题提出人
objvRTSysSkillENT.TopicContent = objvRTSysSkillENS.TopicContent; //主题内容
objvRTSysSkillENT.IsSubmit = objvRTSysSkillENS.IsSubmit; //是否提交
objvRTSysSkillENT.AppraiseCount = objvRTSysSkillENS.AppraiseCount; //评论数
objvRTSysSkillENT.Score = objvRTSysSkillENS.Score; //评分
objvRTSysSkillENT.StuScore = objvRTSysSkillENS.StuScore; //学生平均分
objvRTSysSkillENT.TeaScore = objvRTSysSkillENS.TeaScore; //教师评分
objvRTSysSkillENT.PdfContent = objvRTSysSkillENS.PdfContent; //Pdf内容
objvRTSysSkillENT.PdfPageNum = objvRTSysSkillENS.PdfPageNum; //Pdf页码
objvRTSysSkillENT.CitationCount = objvRTSysSkillENS.CitationCount; //引用统计
objvRTSysSkillENT.VersionCount = objvRTSysSkillENS.VersionCount; //版本统计
objvRTSysSkillENT.OperationTypeName = objvRTSysSkillENS.OperationTypeName; //操作类型名
objvRTSysSkillENT.OkCount = objvRTSysSkillENS.OkCount; //点赞统计
objvRTSysSkillENT.CitationId = objvRTSysSkillENS.CitationId; //引用Id
objvRTSysSkillENT.mId = objvRTSysSkillENS.mId; //mId
objvRTSysSkillENT.TopicId = objvRTSysSkillENS.TopicId; //主题Id
objvRTSysSkillENT.SkillId = objvRTSysSkillENS.SkillId; //技能Id
objvRTSysSkillENT.UpdDate = objvRTSysSkillENS.UpdDate; //修改日期
objvRTSysSkillENT.Memo = objvRTSysSkillENS.Memo; //备注
objvRTSysSkillENT.UpdUser = objvRTSysSkillENS.UpdUser; //修改人
objvRTSysSkillENT.CreateDate = objvRTSysSkillENS.CreateDate; //建立日期
objvRTSysSkillENT.ShareId = objvRTSysSkillENS.ShareId; //分享Id
objvRTSysSkillENT.ClassificationId = objvRTSysSkillENS.ClassificationId; //分类Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvRTSysSkillEN objvRTSysSkillEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.TopicName, 200, convRTSysSkill.TopicName);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.SkillName, 200, convRTSysSkill.SkillName);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.OperationTypeId, 4, convRTSysSkill.OperationTypeId);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.LevelId, 2, convRTSysSkill.LevelId);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.LevelName, 50, convRTSysSkill.LevelName);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.SkillUpdUser, 20, convRTSysSkill.SkillUpdUser);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.SkillUpdDate, 20, convRTSysSkill.SkillUpdDate);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.IdCurrEduCls, 8, convRTSysSkill.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.TopicProposePeople, 50, convRTSysSkill.TopicProposePeople);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.PdfContent, 2000, convRTSysSkill.PdfContent);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.OperationTypeName, 50, convRTSysSkill.OperationTypeName);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.CitationId, 8, convRTSysSkill.CitationId);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.TopicId, 8, convRTSysSkill.TopicId);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.SkillId, 10, convRTSysSkill.SkillId);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.UpdDate, 20, convRTSysSkill.UpdDate);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.Memo, 1000, convRTSysSkill.Memo);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.UpdUser, 20, convRTSysSkill.UpdUser);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.CreateDate, 20, convRTSysSkill.CreateDate);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.ShareId, 2, convRTSysSkill.ShareId);
clsCheckSql.CheckFieldLen(objvRTSysSkillEN.ClassificationId, 10, convRTSysSkill.ClassificationId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.TopicName, convRTSysSkill.TopicName);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.SkillName, convRTSysSkill.SkillName);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.OperationTypeId, convRTSysSkill.OperationTypeId);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.LevelId, convRTSysSkill.LevelId);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.LevelName, convRTSysSkill.LevelName);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.SkillUpdUser, convRTSysSkill.SkillUpdUser);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.SkillUpdDate, convRTSysSkill.SkillUpdDate);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.IdCurrEduCls, convRTSysSkill.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.TopicProposePeople, convRTSysSkill.TopicProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.PdfContent, convRTSysSkill.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.OperationTypeName, convRTSysSkill.OperationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.CitationId, convRTSysSkill.CitationId);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.TopicId, convRTSysSkill.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.SkillId, convRTSysSkill.SkillId);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.UpdDate, convRTSysSkill.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.Memo, convRTSysSkill.Memo);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.UpdUser, convRTSysSkill.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.CreateDate, convRTSysSkill.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.ShareId, convRTSysSkill.ShareId);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillEN.ClassificationId, convRTSysSkill.ClassificationId);
//检查外键字段长度
 objvRTSysSkillEN._IsCheckProperty = true;
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
string strSQL = "select mId, LevelId from vRTSysSkill ";
 clsSpecSQLforSql mySql = clsvRTSysSkillDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vRTSysSkill(vRTSysSkill),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvRTSysSkillEN objvRTSysSkillEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvRTSysSkillEN.mId);
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
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
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
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
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
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTSysSkillEN._CurrTabName);
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
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTSysSkillEN._CurrTabName, strCondition);
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
 objSQL = clsvRTSysSkillDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}