
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SkillDA
 表名:zx_Skill(01120706)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:07:41
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
 /// 中学技能表(zx_Skill)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_SkillDA : clsCommBase4DA
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
 return clszx_SkillEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_SkillEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_SkillEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_SkillEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_SkillEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxSkillId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxSkillId)
{
strzxSkillId = strzxSkillId.Replace("'", "''");
if (strzxSkillId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:zx_Skill中,检查关键字,长度不正确!(clszx_SkillDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxSkillId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_Skill中,关键字不能为空 或 null!(clszx_SkillDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxSkillId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_SkillDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_SkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
strSQL = "Select * from zx_Skill where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_Skill(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_SkillDA: GetDataTable_zx_Skill)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
strSQL = "Select * from zx_Skill where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_SkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_SkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
strSQL = "Select * from zx_Skill where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_SkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_SkillDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Skill where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Skill where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_SkillDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_Skill where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_SkillDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_Skill.* from zx_Skill Left Join {1} on {2} where {3} and zx_Skill.zxSkillId not in (Select top {5} zx_Skill.zxSkillId from zx_Skill Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Skill where {1} and zxSkillId not in (Select top {2} zxSkillId from zx_Skill where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Skill where {1} and zxSkillId not in (Select top {3} zxSkillId from zx_Skill where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_SkillDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_Skill.* from zx_Skill Left Join {1} on {2} where {3} and zx_Skill.zxSkillId not in (Select top {5} zx_Skill.zxSkillId from zx_Skill Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Skill where {1} and zxSkillId not in (Select top {2} zxSkillId from zx_Skill where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Skill where {1} and zxSkillId not in (Select top {3} zxSkillId from zx_Skill where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_SkillEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_SkillDA:GetObjLst)", objException.Message));
}
List<clszx_SkillEN> arrObjLst = new List<clszx_SkillEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
strSQL = "Select * from zx_Skill where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillEN objzx_SkillEN = new clszx_SkillEN();
try
{
objzx_SkillEN.zxSkillId = objRow[conzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillEN.SkillName = objRow[conzx_Skill.SkillName] == DBNull.Value ? null : objRow[conzx_Skill.SkillName].ToString().Trim(); //技能名称
objzx_SkillEN.zxOperationTypeId = objRow[conzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillEN.Process = objRow[conzx_Skill.Process] == DBNull.Value ? null : objRow[conzx_Skill.Process].ToString().Trim(); //实施过程
objzx_SkillEN.zxLevelId = objRow[conzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[conzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillEN.IsSubmit = TransNullToBool(objRow[conzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillEN.TextId = objRow[conzx_Skill.TextId] == DBNull.Value ? null : objRow[conzx_Skill.TextId].ToString().Trim(); //课件Id
objzx_SkillEN.VoteCount = objRow[conzx_Skill.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillEN.AppraiseCount = objRow[conzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillEN.Score = objRow[conzx_Skill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Skill.Score].ToString().Trim()); //评分
objzx_SkillEN.StuScore = objRow[conzx_Skill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Skill.StuScore].ToString().Trim()); //学生平均分
objzx_SkillEN.TeaScore = objRow[conzx_Skill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Skill.TeaScore].ToString().Trim()); //教师评分
objzx_SkillEN.IdCurrEduCls = objRow[conzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillEN.PdfContent = objRow[conzx_Skill.PdfContent] == DBNull.Value ? null : objRow[conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillEN.PdfPageNum = objRow[conzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillEN.CitationCount = objRow[conzx_Skill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.CitationCount].ToString().Trim()); //引用统计
objzx_SkillEN.VersionCount = objRow[conzx_Skill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.VersionCount].ToString().Trim()); //版本统计
objzx_SkillEN.zxShareId = objRow[conzx_Skill.zxShareId] == DBNull.Value ? null : objRow[conzx_Skill.zxShareId].ToString().Trim(); //分享Id
objzx_SkillEN.UpdUser = objRow[conzx_Skill.UpdUser] == DBNull.Value ? null : objRow[conzx_Skill.UpdUser].ToString().Trim(); //修改人
objzx_SkillEN.CreateDate = objRow[conzx_Skill.CreateDate] == DBNull.Value ? null : objRow[conzx_Skill.CreateDate].ToString().Trim(); //建立日期
objzx_SkillEN.UpdDate = objRow[conzx_Skill.UpdDate] == DBNull.Value ? null : objRow[conzx_Skill.UpdDate].ToString().Trim(); //修改日期
objzx_SkillEN.Memo = objRow[conzx_Skill.Memo] == DBNull.Value ? null : objRow[conzx_Skill.Memo].ToString().Trim(); //备注
objzx_SkillEN.PdfDivLet = objRow[conzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillEN.PdfDivTop = objRow[conzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillEN.PdfPageNumIn = objRow[conzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillEN.PdfPageTop = objRow[conzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillEN.PdfZoom = objRow[conzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillEN.GroupTextId = objRow[conzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[conzx_Skill.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_SkillDA: GetObjLst)", objException.Message));
}
objzx_SkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_SkillEN);
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
public List<clszx_SkillEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_SkillDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_SkillEN> arrObjLst = new List<clszx_SkillEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillEN objzx_SkillEN = new clszx_SkillEN();
try
{
objzx_SkillEN.zxSkillId = objRow[conzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillEN.SkillName = objRow[conzx_Skill.SkillName] == DBNull.Value ? null : objRow[conzx_Skill.SkillName].ToString().Trim(); //技能名称
objzx_SkillEN.zxOperationTypeId = objRow[conzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillEN.Process = objRow[conzx_Skill.Process] == DBNull.Value ? null : objRow[conzx_Skill.Process].ToString().Trim(); //实施过程
objzx_SkillEN.zxLevelId = objRow[conzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[conzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillEN.IsSubmit = TransNullToBool(objRow[conzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillEN.TextId = objRow[conzx_Skill.TextId] == DBNull.Value ? null : objRow[conzx_Skill.TextId].ToString().Trim(); //课件Id
objzx_SkillEN.VoteCount = objRow[conzx_Skill.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillEN.AppraiseCount = objRow[conzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillEN.Score = objRow[conzx_Skill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Skill.Score].ToString().Trim()); //评分
objzx_SkillEN.StuScore = objRow[conzx_Skill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Skill.StuScore].ToString().Trim()); //学生平均分
objzx_SkillEN.TeaScore = objRow[conzx_Skill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Skill.TeaScore].ToString().Trim()); //教师评分
objzx_SkillEN.IdCurrEduCls = objRow[conzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillEN.PdfContent = objRow[conzx_Skill.PdfContent] == DBNull.Value ? null : objRow[conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillEN.PdfPageNum = objRow[conzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillEN.CitationCount = objRow[conzx_Skill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.CitationCount].ToString().Trim()); //引用统计
objzx_SkillEN.VersionCount = objRow[conzx_Skill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.VersionCount].ToString().Trim()); //版本统计
objzx_SkillEN.zxShareId = objRow[conzx_Skill.zxShareId] == DBNull.Value ? null : objRow[conzx_Skill.zxShareId].ToString().Trim(); //分享Id
objzx_SkillEN.UpdUser = objRow[conzx_Skill.UpdUser] == DBNull.Value ? null : objRow[conzx_Skill.UpdUser].ToString().Trim(); //修改人
objzx_SkillEN.CreateDate = objRow[conzx_Skill.CreateDate] == DBNull.Value ? null : objRow[conzx_Skill.CreateDate].ToString().Trim(); //建立日期
objzx_SkillEN.UpdDate = objRow[conzx_Skill.UpdDate] == DBNull.Value ? null : objRow[conzx_Skill.UpdDate].ToString().Trim(); //修改日期
objzx_SkillEN.Memo = objRow[conzx_Skill.Memo] == DBNull.Value ? null : objRow[conzx_Skill.Memo].ToString().Trim(); //备注
objzx_SkillEN.PdfDivLet = objRow[conzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillEN.PdfDivTop = objRow[conzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillEN.PdfPageNumIn = objRow[conzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillEN.PdfPageTop = objRow[conzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillEN.PdfZoom = objRow[conzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillEN.GroupTextId = objRow[conzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[conzx_Skill.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_SkillDA: GetObjLst)", objException.Message));
}
objzx_SkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_SkillEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_Skill(ref clszx_SkillEN objzx_SkillEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
strSQL = "Select * from zx_Skill where zxSkillId = " + "'"+ objzx_SkillEN.zxSkillId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_SkillEN.zxSkillId = objDT.Rows[0][conzx_Skill.zxSkillId].ToString().Trim(); //技能Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_SkillEN.SkillName = objDT.Rows[0][conzx_Skill.SkillName].ToString().Trim(); //技能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objzx_SkillEN.zxOperationTypeId = objDT.Rows[0][conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:2,是否可空:False)
 objzx_SkillEN.Process = objDT.Rows[0][conzx_Skill.Process].ToString().Trim(); //实施过程(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_SkillEN.zxLevelId = objDT.Rows[0][conzx_Skill.zxLevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objzx_SkillEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_Skill.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_SkillEN.TextId = objDT.Rows[0][conzx_Skill.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_SkillEN.VoteCount = TransNullToInt(objDT.Rows[0][conzx_Skill.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conzx_Skill.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillEN.Score = TransNullToFloat(objDT.Rows[0][conzx_Skill.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SkillEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_Skill.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SkillEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_Skill.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SkillEN.IdCurrEduCls = objDT.Rows[0][conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_SkillEN.PdfContent = objDT.Rows[0][conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_SkillEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillEN.CitationCount = TransNullToInt(objDT.Rows[0][conzx_Skill.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillEN.VersionCount = TransNullToInt(objDT.Rows[0][conzx_Skill.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillEN.zxShareId = objDT.Rows[0][conzx_Skill.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_SkillEN.UpdUser = objDT.Rows[0][conzx_Skill.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SkillEN.CreateDate = objDT.Rows[0][conzx_Skill.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SkillEN.UpdDate = objDT.Rows[0][conzx_Skill.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SkillEN.Memo = objDT.Rows[0][conzx_Skill.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_SkillEN.PdfDivLet = objDT.Rows[0][conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SkillEN.PdfDivTop = objDT.Rows[0][conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SkillEN.PdfPageNumIn = objDT.Rows[0][conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SkillEN.PdfPageTop = TransNullToInt(objDT.Rows[0][conzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillEN.PdfZoom = objDT.Rows[0][conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SkillEN.GroupTextId = objDT.Rows[0][conzx_Skill.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_SkillDA: Getzx_Skill)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxSkillId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_SkillEN GetObjByzxSkillId(string strzxSkillId)
{
CheckPrimaryKey(strzxSkillId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
strSQL = "Select * from zx_Skill where zxSkillId = " + "'"+ strzxSkillId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_SkillEN objzx_SkillEN = new clszx_SkillEN();
try
{
 objzx_SkillEN.zxSkillId = objRow[conzx_Skill.zxSkillId].ToString().Trim(); //技能Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_SkillEN.SkillName = objRow[conzx_Skill.SkillName] == DBNull.Value ? null : objRow[conzx_Skill.SkillName].ToString().Trim(); //技能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objzx_SkillEN.zxOperationTypeId = objRow[conzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:2,是否可空:False)
 objzx_SkillEN.Process = objRow[conzx_Skill.Process] == DBNull.Value ? null : objRow[conzx_Skill.Process].ToString().Trim(); //实施过程(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_SkillEN.zxLevelId = objRow[conzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[conzx_Skill.zxLevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Skill.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_SkillEN.TextId = objRow[conzx_Skill.TextId] == DBNull.Value ? null : objRow[conzx_Skill.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_SkillEN.VoteCount = objRow[conzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillEN.AppraiseCount = objRow[conzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillEN.Score = objRow[conzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SkillEN.StuScore = objRow[conzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SkillEN.TeaScore = objRow[conzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SkillEN.IdCurrEduCls = objRow[conzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_SkillEN.PdfContent = objRow[conzx_Skill.PdfContent] == DBNull.Value ? null : objRow[conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_SkillEN.PdfPageNum = objRow[conzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillEN.CitationCount = objRow[conzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillEN.VersionCount = objRow[conzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillEN.zxShareId = objRow[conzx_Skill.zxShareId] == DBNull.Value ? null : objRow[conzx_Skill.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_SkillEN.UpdUser = objRow[conzx_Skill.UpdUser] == DBNull.Value ? null : objRow[conzx_Skill.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SkillEN.CreateDate = objRow[conzx_Skill.CreateDate] == DBNull.Value ? null : objRow[conzx_Skill.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SkillEN.UpdDate = objRow[conzx_Skill.UpdDate] == DBNull.Value ? null : objRow[conzx_Skill.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SkillEN.Memo = objRow[conzx_Skill.Memo] == DBNull.Value ? null : objRow[conzx_Skill.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_SkillEN.PdfDivLet = objRow[conzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SkillEN.PdfDivTop = objRow[conzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SkillEN.PdfPageNumIn = objRow[conzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SkillEN.PdfPageTop = objRow[conzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillEN.PdfZoom = objRow[conzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SkillEN.GroupTextId = objRow[conzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[conzx_Skill.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_SkillDA: GetObjByzxSkillId)", objException.Message));
}
return objzx_SkillEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_SkillEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_SkillDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
strSQL = "Select * from zx_Skill where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_SkillEN objzx_SkillEN = new clszx_SkillEN()
{
zxSkillId = objRow[conzx_Skill.zxSkillId].ToString().Trim(), //技能Id
SkillName = objRow[conzx_Skill.SkillName] == DBNull.Value ? null : objRow[conzx_Skill.SkillName].ToString().Trim(), //技能名称
zxOperationTypeId = objRow[conzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_Skill.zxOperationTypeId].ToString().Trim(), //操作类型ID
Process = objRow[conzx_Skill.Process] == DBNull.Value ? null : objRow[conzx_Skill.Process].ToString().Trim(), //实施过程
zxLevelId = objRow[conzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[conzx_Skill.zxLevelId].ToString().Trim(), //级别Id
IsSubmit = TransNullToBool(objRow[conzx_Skill.IsSubmit].ToString().Trim()), //是否提交
TextId = objRow[conzx_Skill.TextId] == DBNull.Value ? null : objRow[conzx_Skill.TextId].ToString().Trim(), //课件Id
VoteCount = objRow[conzx_Skill.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.VoteCount].ToString().Trim()), //点赞计数
AppraiseCount = objRow[conzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[conzx_Skill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Skill.Score].ToString().Trim()), //评分
StuScore = objRow[conzx_Skill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Skill.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conzx_Skill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Skill.TeaScore].ToString().Trim()), //教师评分
IdCurrEduCls = objRow[conzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Skill.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[conzx_Skill.PdfContent] == DBNull.Value ? null : objRow[conzx_Skill.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[conzx_Skill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[conzx_Skill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.VersionCount].ToString().Trim()), //版本统计
zxShareId = objRow[conzx_Skill.zxShareId] == DBNull.Value ? null : objRow[conzx_Skill.zxShareId].ToString().Trim(), //分享Id
UpdUser = objRow[conzx_Skill.UpdUser] == DBNull.Value ? null : objRow[conzx_Skill.UpdUser].ToString().Trim(), //修改人
CreateDate = objRow[conzx_Skill.CreateDate] == DBNull.Value ? null : objRow[conzx_Skill.CreateDate].ToString().Trim(), //建立日期
UpdDate = objRow[conzx_Skill.UpdDate] == DBNull.Value ? null : objRow[conzx_Skill.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conzx_Skill.Memo] == DBNull.Value ? null : objRow[conzx_Skill.Memo].ToString().Trim(), //备注
PdfDivLet = objRow[conzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[conzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfPageNumIn = objRow[conzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Skill.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[conzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfZoom = objRow[conzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[conzx_Skill.PdfZoom].ToString().Trim(), //PdfZoom
GroupTextId = objRow[conzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[conzx_Skill.GroupTextId].ToString().Trim() //小组Id
};
objzx_SkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SkillEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_SkillDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_SkillEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_SkillEN objzx_SkillEN = new clszx_SkillEN();
try
{
objzx_SkillEN.zxSkillId = objRow[conzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillEN.SkillName = objRow[conzx_Skill.SkillName] == DBNull.Value ? null : objRow[conzx_Skill.SkillName].ToString().Trim(); //技能名称
objzx_SkillEN.zxOperationTypeId = objRow[conzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillEN.Process = objRow[conzx_Skill.Process] == DBNull.Value ? null : objRow[conzx_Skill.Process].ToString().Trim(); //实施过程
objzx_SkillEN.zxLevelId = objRow[conzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[conzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillEN.IsSubmit = TransNullToBool(objRow[conzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillEN.TextId = objRow[conzx_Skill.TextId] == DBNull.Value ? null : objRow[conzx_Skill.TextId].ToString().Trim(); //课件Id
objzx_SkillEN.VoteCount = objRow[conzx_Skill.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillEN.AppraiseCount = objRow[conzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillEN.Score = objRow[conzx_Skill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Skill.Score].ToString().Trim()); //评分
objzx_SkillEN.StuScore = objRow[conzx_Skill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Skill.StuScore].ToString().Trim()); //学生平均分
objzx_SkillEN.TeaScore = objRow[conzx_Skill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Skill.TeaScore].ToString().Trim()); //教师评分
objzx_SkillEN.IdCurrEduCls = objRow[conzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillEN.PdfContent = objRow[conzx_Skill.PdfContent] == DBNull.Value ? null : objRow[conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillEN.PdfPageNum = objRow[conzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillEN.CitationCount = objRow[conzx_Skill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.CitationCount].ToString().Trim()); //引用统计
objzx_SkillEN.VersionCount = objRow[conzx_Skill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.VersionCount].ToString().Trim()); //版本统计
objzx_SkillEN.zxShareId = objRow[conzx_Skill.zxShareId] == DBNull.Value ? null : objRow[conzx_Skill.zxShareId].ToString().Trim(); //分享Id
objzx_SkillEN.UpdUser = objRow[conzx_Skill.UpdUser] == DBNull.Value ? null : objRow[conzx_Skill.UpdUser].ToString().Trim(); //修改人
objzx_SkillEN.CreateDate = objRow[conzx_Skill.CreateDate] == DBNull.Value ? null : objRow[conzx_Skill.CreateDate].ToString().Trim(); //建立日期
objzx_SkillEN.UpdDate = objRow[conzx_Skill.UpdDate] == DBNull.Value ? null : objRow[conzx_Skill.UpdDate].ToString().Trim(); //修改日期
objzx_SkillEN.Memo = objRow[conzx_Skill.Memo] == DBNull.Value ? null : objRow[conzx_Skill.Memo].ToString().Trim(); //备注
objzx_SkillEN.PdfDivLet = objRow[conzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillEN.PdfDivTop = objRow[conzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillEN.PdfPageNumIn = objRow[conzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillEN.PdfPageTop = objRow[conzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillEN.PdfZoom = objRow[conzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillEN.GroupTextId = objRow[conzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[conzx_Skill.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_SkillDA: GetObjByDataRowzx_Skill)", objException.Message));
}
objzx_SkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SkillEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_SkillEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_SkillEN objzx_SkillEN = new clszx_SkillEN();
try
{
objzx_SkillEN.zxSkillId = objRow[conzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillEN.SkillName = objRow[conzx_Skill.SkillName] == DBNull.Value ? null : objRow[conzx_Skill.SkillName].ToString().Trim(); //技能名称
objzx_SkillEN.zxOperationTypeId = objRow[conzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillEN.Process = objRow[conzx_Skill.Process] == DBNull.Value ? null : objRow[conzx_Skill.Process].ToString().Trim(); //实施过程
objzx_SkillEN.zxLevelId = objRow[conzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[conzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillEN.IsSubmit = TransNullToBool(objRow[conzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillEN.TextId = objRow[conzx_Skill.TextId] == DBNull.Value ? null : objRow[conzx_Skill.TextId].ToString().Trim(); //课件Id
objzx_SkillEN.VoteCount = objRow[conzx_Skill.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillEN.AppraiseCount = objRow[conzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillEN.Score = objRow[conzx_Skill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Skill.Score].ToString().Trim()); //评分
objzx_SkillEN.StuScore = objRow[conzx_Skill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Skill.StuScore].ToString().Trim()); //学生平均分
objzx_SkillEN.TeaScore = objRow[conzx_Skill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Skill.TeaScore].ToString().Trim()); //教师评分
objzx_SkillEN.IdCurrEduCls = objRow[conzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillEN.PdfContent = objRow[conzx_Skill.PdfContent] == DBNull.Value ? null : objRow[conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillEN.PdfPageNum = objRow[conzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillEN.CitationCount = objRow[conzx_Skill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.CitationCount].ToString().Trim()); //引用统计
objzx_SkillEN.VersionCount = objRow[conzx_Skill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.VersionCount].ToString().Trim()); //版本统计
objzx_SkillEN.zxShareId = objRow[conzx_Skill.zxShareId] == DBNull.Value ? null : objRow[conzx_Skill.zxShareId].ToString().Trim(); //分享Id
objzx_SkillEN.UpdUser = objRow[conzx_Skill.UpdUser] == DBNull.Value ? null : objRow[conzx_Skill.UpdUser].ToString().Trim(); //修改人
objzx_SkillEN.CreateDate = objRow[conzx_Skill.CreateDate] == DBNull.Value ? null : objRow[conzx_Skill.CreateDate].ToString().Trim(); //建立日期
objzx_SkillEN.UpdDate = objRow[conzx_Skill.UpdDate] == DBNull.Value ? null : objRow[conzx_Skill.UpdDate].ToString().Trim(); //修改日期
objzx_SkillEN.Memo = objRow[conzx_Skill.Memo] == DBNull.Value ? null : objRow[conzx_Skill.Memo].ToString().Trim(); //备注
objzx_SkillEN.PdfDivLet = objRow[conzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillEN.PdfDivTop = objRow[conzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillEN.PdfPageNumIn = objRow[conzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillEN.PdfPageTop = objRow[conzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillEN.PdfZoom = objRow[conzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillEN.GroupTextId = objRow[conzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[conzx_Skill.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_SkillDA: GetObjByDataRow)", objException.Message));
}
objzx_SkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SkillEN;
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
objSQL = clszx_SkillDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_SkillEN._CurrTabName, conzx_Skill.zxSkillId, 10, "");
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
objSQL = clszx_SkillDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_SkillEN._CurrTabName, conzx_Skill.zxSkillId, 10, strPrefix);
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
 objSQL = clszx_SkillDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxSkillId from zx_Skill where " + strCondition;
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
 objSQL = clszx_SkillDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxSkillId from zx_Skill where " + strCondition;
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
 /// <param name = "strzxSkillId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxSkillId)
{
CheckPrimaryKey(strzxSkillId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_Skill", "zxSkillId = " + "'"+ strzxSkillId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_SkillDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_Skill", strCondition))
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
objSQL = clszx_SkillDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_Skill");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_SkillEN objzx_SkillEN)
 {
 if (objzx_SkillEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SkillEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
strSQL = "Select * from zx_Skill where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_Skill");
objRow = objDS.Tables["zx_Skill"].NewRow();
objRow[conzx_Skill.zxSkillId] = objzx_SkillEN.zxSkillId; //技能Id
 if (objzx_SkillEN.SkillName !=  "")
 {
objRow[conzx_Skill.SkillName] = objzx_SkillEN.SkillName; //技能名称
 }
 if (objzx_SkillEN.zxOperationTypeId !=  "")
 {
objRow[conzx_Skill.zxOperationTypeId] = objzx_SkillEN.zxOperationTypeId; //操作类型ID
 }
 if (objzx_SkillEN.Process !=  "")
 {
objRow[conzx_Skill.Process] = objzx_SkillEN.Process; //实施过程
 }
 if (objzx_SkillEN.zxLevelId !=  "")
 {
objRow[conzx_Skill.zxLevelId] = objzx_SkillEN.zxLevelId; //级别Id
 }
objRow[conzx_Skill.IsSubmit] = objzx_SkillEN.IsSubmit; //是否提交
 if (objzx_SkillEN.TextId !=  "")
 {
objRow[conzx_Skill.TextId] = objzx_SkillEN.TextId; //课件Id
 }
objRow[conzx_Skill.VoteCount] = objzx_SkillEN.VoteCount; //点赞计数
objRow[conzx_Skill.AppraiseCount] = objzx_SkillEN.AppraiseCount; //评论数
objRow[conzx_Skill.Score] = objzx_SkillEN.Score; //评分
objRow[conzx_Skill.StuScore] = objzx_SkillEN.StuScore; //学生平均分
objRow[conzx_Skill.TeaScore] = objzx_SkillEN.TeaScore; //教师评分
 if (objzx_SkillEN.IdCurrEduCls !=  "")
 {
objRow[conzx_Skill.IdCurrEduCls] = objzx_SkillEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_SkillEN.PdfContent !=  "")
 {
objRow[conzx_Skill.PdfContent] = objzx_SkillEN.PdfContent; //Pdf内容
 }
objRow[conzx_Skill.PdfPageNum] = objzx_SkillEN.PdfPageNum; //Pdf页码
objRow[conzx_Skill.CitationCount] = objzx_SkillEN.CitationCount; //引用统计
objRow[conzx_Skill.VersionCount] = objzx_SkillEN.VersionCount; //版本统计
 if (objzx_SkillEN.zxShareId !=  "")
 {
objRow[conzx_Skill.zxShareId] = objzx_SkillEN.zxShareId; //分享Id
 }
 if (objzx_SkillEN.UpdUser !=  "")
 {
objRow[conzx_Skill.UpdUser] = objzx_SkillEN.UpdUser; //修改人
 }
 if (objzx_SkillEN.CreateDate !=  "")
 {
objRow[conzx_Skill.CreateDate] = objzx_SkillEN.CreateDate; //建立日期
 }
 if (objzx_SkillEN.UpdDate !=  "")
 {
objRow[conzx_Skill.UpdDate] = objzx_SkillEN.UpdDate; //修改日期
 }
 if (objzx_SkillEN.Memo !=  "")
 {
objRow[conzx_Skill.Memo] = objzx_SkillEN.Memo; //备注
 }
 if (objzx_SkillEN.PdfDivLet !=  "")
 {
objRow[conzx_Skill.PdfDivLet] = objzx_SkillEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_SkillEN.PdfDivTop !=  "")
 {
objRow[conzx_Skill.PdfDivTop] = objzx_SkillEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_SkillEN.PdfPageNumIn !=  "")
 {
objRow[conzx_Skill.PdfPageNumIn] = objzx_SkillEN.PdfPageNumIn; //PdfPageNumIn
 }
objRow[conzx_Skill.PdfPageTop] = objzx_SkillEN.PdfPageTop; //pdf页面顶部位置
 if (objzx_SkillEN.PdfZoom !=  "")
 {
objRow[conzx_Skill.PdfZoom] = objzx_SkillEN.PdfZoom; //PdfZoom
 }
 if (objzx_SkillEN.GroupTextId !=  "")
 {
objRow[conzx_Skill.GroupTextId] = objzx_SkillEN.GroupTextId; //小组Id
 }
objDS.Tables[clszx_SkillEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_SkillEN._CurrTabName);
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
 /// <param name = "objzx_SkillEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_SkillEN objzx_SkillEN)
{
 if (objzx_SkillEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SkillEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_SkillEN.zxSkillId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.zxSkillId);
 var strzxSkillId = objzx_SkillEN.zxSkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxSkillId + "'");
 }
 
 if (objzx_SkillEN.SkillName !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.SkillName);
 var strSkillName = objzx_SkillEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillName + "'");
 }
 
 if (objzx_SkillEN.zxOperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.zxOperationTypeId);
 var strzxOperationTypeId = objzx_SkillEN.zxOperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxOperationTypeId + "'");
 }
 
 if (objzx_SkillEN.Process !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.Process);
 var strProcess = objzx_SkillEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProcess + "'");
 }
 
 if (objzx_SkillEN.zxLevelId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.zxLevelId);
 var strzxLevelId = objzx_SkillEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLevelId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Skill.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SkillEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SkillEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.TextId);
 var strTextId = objzx_SkillEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_SkillEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.VoteCount);
 arrValueListForInsert.Add(objzx_SkillEN.VoteCount.ToString());
 }
 
 if (objzx_SkillEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.AppraiseCount);
 arrValueListForInsert.Add(objzx_SkillEN.AppraiseCount.ToString());
 }
 
 if (objzx_SkillEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.Score);
 arrValueListForInsert.Add(objzx_SkillEN.Score.ToString());
 }
 
 if (objzx_SkillEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.StuScore);
 arrValueListForInsert.Add(objzx_SkillEN.StuScore.ToString());
 }
 
 if (objzx_SkillEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.TeaScore);
 arrValueListForInsert.Add(objzx_SkillEN.TeaScore.ToString());
 }
 
 if (objzx_SkillEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SkillEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_SkillEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfContent);
 var strPdfContent = objzx_SkillEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_SkillEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfPageNum);
 arrValueListForInsert.Add(objzx_SkillEN.PdfPageNum.ToString());
 }
 
 if (objzx_SkillEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.CitationCount);
 arrValueListForInsert.Add(objzx_SkillEN.CitationCount.ToString());
 }
 
 if (objzx_SkillEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.VersionCount);
 arrValueListForInsert.Add(objzx_SkillEN.VersionCount.ToString());
 }
 
 if (objzx_SkillEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.zxShareId);
 var strzxShareId = objzx_SkillEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_SkillEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.UpdUser);
 var strUpdUser = objzx_SkillEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SkillEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.CreateDate);
 var strCreateDate = objzx_SkillEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_SkillEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.UpdDate);
 var strUpdDate = objzx_SkillEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_SkillEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.Memo);
 var strMemo = objzx_SkillEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_SkillEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfDivLet);
 var strPdfDivLet = objzx_SkillEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_SkillEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfDivTop);
 var strPdfDivTop = objzx_SkillEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_SkillEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfPageNumIn);
 var strPdfPageNumIn = objzx_SkillEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_SkillEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfPageTop);
 arrValueListForInsert.Add(objzx_SkillEN.PdfPageTop.ToString());
 }
 
 if (objzx_SkillEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfZoom);
 var strPdfZoom = objzx_SkillEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_SkillEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.GroupTextId);
 var strGroupTextId = objzx_SkillEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Skill");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_SkillEN objzx_SkillEN)
{
 if (objzx_SkillEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SkillEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_SkillEN.zxSkillId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.zxSkillId);
 var strzxSkillId = objzx_SkillEN.zxSkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxSkillId + "'");
 }
 
 if (objzx_SkillEN.SkillName !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.SkillName);
 var strSkillName = objzx_SkillEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillName + "'");
 }
 
 if (objzx_SkillEN.zxOperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.zxOperationTypeId);
 var strzxOperationTypeId = objzx_SkillEN.zxOperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxOperationTypeId + "'");
 }
 
 if (objzx_SkillEN.Process !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.Process);
 var strProcess = objzx_SkillEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProcess + "'");
 }
 
 if (objzx_SkillEN.zxLevelId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.zxLevelId);
 var strzxLevelId = objzx_SkillEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLevelId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Skill.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SkillEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SkillEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.TextId);
 var strTextId = objzx_SkillEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_SkillEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.VoteCount);
 arrValueListForInsert.Add(objzx_SkillEN.VoteCount.ToString());
 }
 
 if (objzx_SkillEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.AppraiseCount);
 arrValueListForInsert.Add(objzx_SkillEN.AppraiseCount.ToString());
 }
 
 if (objzx_SkillEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.Score);
 arrValueListForInsert.Add(objzx_SkillEN.Score.ToString());
 }
 
 if (objzx_SkillEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.StuScore);
 arrValueListForInsert.Add(objzx_SkillEN.StuScore.ToString());
 }
 
 if (objzx_SkillEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.TeaScore);
 arrValueListForInsert.Add(objzx_SkillEN.TeaScore.ToString());
 }
 
 if (objzx_SkillEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SkillEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_SkillEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfContent);
 var strPdfContent = objzx_SkillEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_SkillEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfPageNum);
 arrValueListForInsert.Add(objzx_SkillEN.PdfPageNum.ToString());
 }
 
 if (objzx_SkillEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.CitationCount);
 arrValueListForInsert.Add(objzx_SkillEN.CitationCount.ToString());
 }
 
 if (objzx_SkillEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.VersionCount);
 arrValueListForInsert.Add(objzx_SkillEN.VersionCount.ToString());
 }
 
 if (objzx_SkillEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.zxShareId);
 var strzxShareId = objzx_SkillEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_SkillEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.UpdUser);
 var strUpdUser = objzx_SkillEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SkillEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.CreateDate);
 var strCreateDate = objzx_SkillEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_SkillEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.UpdDate);
 var strUpdDate = objzx_SkillEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_SkillEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.Memo);
 var strMemo = objzx_SkillEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_SkillEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfDivLet);
 var strPdfDivLet = objzx_SkillEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_SkillEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfDivTop);
 var strPdfDivTop = objzx_SkillEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_SkillEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfPageNumIn);
 var strPdfPageNumIn = objzx_SkillEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_SkillEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfPageTop);
 arrValueListForInsert.Add(objzx_SkillEN.PdfPageTop.ToString());
 }
 
 if (objzx_SkillEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfZoom);
 var strPdfZoom = objzx_SkillEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_SkillEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.GroupTextId);
 var strGroupTextId = objzx_SkillEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Skill");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_SkillEN.zxSkillId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_SkillEN objzx_SkillEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_SkillEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SkillEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_SkillEN.zxSkillId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.zxSkillId);
 var strzxSkillId = objzx_SkillEN.zxSkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxSkillId + "'");
 }
 
 if (objzx_SkillEN.SkillName !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.SkillName);
 var strSkillName = objzx_SkillEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillName + "'");
 }
 
 if (objzx_SkillEN.zxOperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.zxOperationTypeId);
 var strzxOperationTypeId = objzx_SkillEN.zxOperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxOperationTypeId + "'");
 }
 
 if (objzx_SkillEN.Process !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.Process);
 var strProcess = objzx_SkillEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProcess + "'");
 }
 
 if (objzx_SkillEN.zxLevelId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.zxLevelId);
 var strzxLevelId = objzx_SkillEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLevelId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Skill.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SkillEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SkillEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.TextId);
 var strTextId = objzx_SkillEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_SkillEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.VoteCount);
 arrValueListForInsert.Add(objzx_SkillEN.VoteCount.ToString());
 }
 
 if (objzx_SkillEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.AppraiseCount);
 arrValueListForInsert.Add(objzx_SkillEN.AppraiseCount.ToString());
 }
 
 if (objzx_SkillEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.Score);
 arrValueListForInsert.Add(objzx_SkillEN.Score.ToString());
 }
 
 if (objzx_SkillEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.StuScore);
 arrValueListForInsert.Add(objzx_SkillEN.StuScore.ToString());
 }
 
 if (objzx_SkillEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.TeaScore);
 arrValueListForInsert.Add(objzx_SkillEN.TeaScore.ToString());
 }
 
 if (objzx_SkillEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SkillEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_SkillEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfContent);
 var strPdfContent = objzx_SkillEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_SkillEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfPageNum);
 arrValueListForInsert.Add(objzx_SkillEN.PdfPageNum.ToString());
 }
 
 if (objzx_SkillEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.CitationCount);
 arrValueListForInsert.Add(objzx_SkillEN.CitationCount.ToString());
 }
 
 if (objzx_SkillEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.VersionCount);
 arrValueListForInsert.Add(objzx_SkillEN.VersionCount.ToString());
 }
 
 if (objzx_SkillEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.zxShareId);
 var strzxShareId = objzx_SkillEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_SkillEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.UpdUser);
 var strUpdUser = objzx_SkillEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SkillEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.CreateDate);
 var strCreateDate = objzx_SkillEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_SkillEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.UpdDate);
 var strUpdDate = objzx_SkillEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_SkillEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.Memo);
 var strMemo = objzx_SkillEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_SkillEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfDivLet);
 var strPdfDivLet = objzx_SkillEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_SkillEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfDivTop);
 var strPdfDivTop = objzx_SkillEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_SkillEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfPageNumIn);
 var strPdfPageNumIn = objzx_SkillEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_SkillEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfPageTop);
 arrValueListForInsert.Add(objzx_SkillEN.PdfPageTop.ToString());
 }
 
 if (objzx_SkillEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfZoom);
 var strPdfZoom = objzx_SkillEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_SkillEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.GroupTextId);
 var strGroupTextId = objzx_SkillEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Skill");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_SkillEN.zxSkillId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_SkillEN objzx_SkillEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_SkillEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SkillEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_SkillEN.zxSkillId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.zxSkillId);
 var strzxSkillId = objzx_SkillEN.zxSkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxSkillId + "'");
 }
 
 if (objzx_SkillEN.SkillName !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.SkillName);
 var strSkillName = objzx_SkillEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillName + "'");
 }
 
 if (objzx_SkillEN.zxOperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.zxOperationTypeId);
 var strzxOperationTypeId = objzx_SkillEN.zxOperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxOperationTypeId + "'");
 }
 
 if (objzx_SkillEN.Process !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.Process);
 var strProcess = objzx_SkillEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProcess + "'");
 }
 
 if (objzx_SkillEN.zxLevelId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.zxLevelId);
 var strzxLevelId = objzx_SkillEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLevelId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Skill.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SkillEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SkillEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.TextId);
 var strTextId = objzx_SkillEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_SkillEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.VoteCount);
 arrValueListForInsert.Add(objzx_SkillEN.VoteCount.ToString());
 }
 
 if (objzx_SkillEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.AppraiseCount);
 arrValueListForInsert.Add(objzx_SkillEN.AppraiseCount.ToString());
 }
 
 if (objzx_SkillEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.Score);
 arrValueListForInsert.Add(objzx_SkillEN.Score.ToString());
 }
 
 if (objzx_SkillEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.StuScore);
 arrValueListForInsert.Add(objzx_SkillEN.StuScore.ToString());
 }
 
 if (objzx_SkillEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.TeaScore);
 arrValueListForInsert.Add(objzx_SkillEN.TeaScore.ToString());
 }
 
 if (objzx_SkillEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SkillEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_SkillEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfContent);
 var strPdfContent = objzx_SkillEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_SkillEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfPageNum);
 arrValueListForInsert.Add(objzx_SkillEN.PdfPageNum.ToString());
 }
 
 if (objzx_SkillEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.CitationCount);
 arrValueListForInsert.Add(objzx_SkillEN.CitationCount.ToString());
 }
 
 if (objzx_SkillEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.VersionCount);
 arrValueListForInsert.Add(objzx_SkillEN.VersionCount.ToString());
 }
 
 if (objzx_SkillEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.zxShareId);
 var strzxShareId = objzx_SkillEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_SkillEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.UpdUser);
 var strUpdUser = objzx_SkillEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SkillEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.CreateDate);
 var strCreateDate = objzx_SkillEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_SkillEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.UpdDate);
 var strUpdDate = objzx_SkillEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_SkillEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.Memo);
 var strMemo = objzx_SkillEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_SkillEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfDivLet);
 var strPdfDivLet = objzx_SkillEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_SkillEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfDivTop);
 var strPdfDivTop = objzx_SkillEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_SkillEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfPageNumIn);
 var strPdfPageNumIn = objzx_SkillEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_SkillEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfPageTop);
 arrValueListForInsert.Add(objzx_SkillEN.PdfPageTop.ToString());
 }
 
 if (objzx_SkillEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.PdfZoom);
 var strPdfZoom = objzx_SkillEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_SkillEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Skill.GroupTextId);
 var strGroupTextId = objzx_SkillEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Skill");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_Skills(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
strSQL = "Select * from zx_Skill where zxSkillId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_Skill");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strzxSkillId = oRow[conzx_Skill.zxSkillId].ToString().Trim();
if (IsExist(strzxSkillId))
{
 string strResult = "关键字变量值为:" + string.Format("zxSkillId = {0}", strzxSkillId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_SkillEN._CurrTabName ].NewRow();
objRow[conzx_Skill.zxSkillId] = oRow[conzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objRow[conzx_Skill.SkillName] = oRow[conzx_Skill.SkillName].ToString().Trim(); //技能名称
objRow[conzx_Skill.zxOperationTypeId] = oRow[conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objRow[conzx_Skill.Process] = oRow[conzx_Skill.Process].ToString().Trim(); //实施过程
objRow[conzx_Skill.zxLevelId] = oRow[conzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objRow[conzx_Skill.IsSubmit] = oRow[conzx_Skill.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_Skill.TextId] = oRow[conzx_Skill.TextId].ToString().Trim(); //课件Id
objRow[conzx_Skill.VoteCount] = oRow[conzx_Skill.VoteCount].ToString().Trim(); //点赞计数
objRow[conzx_Skill.AppraiseCount] = oRow[conzx_Skill.AppraiseCount].ToString().Trim(); //评论数
objRow[conzx_Skill.Score] = oRow[conzx_Skill.Score].ToString().Trim(); //评分
objRow[conzx_Skill.StuScore] = oRow[conzx_Skill.StuScore].ToString().Trim(); //学生平均分
objRow[conzx_Skill.TeaScore] = oRow[conzx_Skill.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_Skill.IdCurrEduCls] = oRow[conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_Skill.PdfContent] = oRow[conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
objRow[conzx_Skill.PdfPageNum] = oRow[conzx_Skill.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conzx_Skill.CitationCount] = oRow[conzx_Skill.CitationCount].ToString().Trim(); //引用统计
objRow[conzx_Skill.VersionCount] = oRow[conzx_Skill.VersionCount].ToString().Trim(); //版本统计
objRow[conzx_Skill.zxShareId] = oRow[conzx_Skill.zxShareId].ToString().Trim(); //分享Id
objRow[conzx_Skill.UpdUser] = oRow[conzx_Skill.UpdUser].ToString().Trim(); //修改人
objRow[conzx_Skill.CreateDate] = oRow[conzx_Skill.CreateDate].ToString().Trim(); //建立日期
objRow[conzx_Skill.UpdDate] = oRow[conzx_Skill.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_Skill.Memo] = oRow[conzx_Skill.Memo].ToString().Trim(); //备注
objRow[conzx_Skill.PdfDivLet] = oRow[conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objRow[conzx_Skill.PdfDivTop] = oRow[conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objRow[conzx_Skill.PdfPageNumIn] = oRow[conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objRow[conzx_Skill.PdfPageTop] = oRow[conzx_Skill.PdfPageTop].ToString().Trim(); //pdf页面顶部位置
objRow[conzx_Skill.PdfZoom] = oRow[conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objRow[conzx_Skill.GroupTextId] = oRow[conzx_Skill.GroupTextId].ToString().Trim(); //小组Id
 objDS.Tables[clszx_SkillEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_SkillEN._CurrTabName);
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
 /// <param name = "objzx_SkillEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_SkillEN objzx_SkillEN)
{
 if (objzx_SkillEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SkillEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
strSQL = "Select * from zx_Skill where zxSkillId = " + "'"+ objzx_SkillEN.zxSkillId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_SkillEN._CurrTabName);
if (objDS.Tables[clszx_SkillEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:zxSkillId = " + "'"+ objzx_SkillEN.zxSkillId+"'");
return false;
}
objRow = objDS.Tables[clszx_SkillEN._CurrTabName].Rows[0];
 if (objzx_SkillEN.IsUpdated(conzx_Skill.zxSkillId))
 {
objRow[conzx_Skill.zxSkillId] = objzx_SkillEN.zxSkillId; //技能Id
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.SkillName))
 {
objRow[conzx_Skill.SkillName] = objzx_SkillEN.SkillName; //技能名称
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.zxOperationTypeId))
 {
objRow[conzx_Skill.zxOperationTypeId] = objzx_SkillEN.zxOperationTypeId; //操作类型ID
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.Process))
 {
objRow[conzx_Skill.Process] = objzx_SkillEN.Process; //实施过程
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.zxLevelId))
 {
objRow[conzx_Skill.zxLevelId] = objzx_SkillEN.zxLevelId; //级别Id
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.IsSubmit))
 {
objRow[conzx_Skill.IsSubmit] = objzx_SkillEN.IsSubmit; //是否提交
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.TextId))
 {
objRow[conzx_Skill.TextId] = objzx_SkillEN.TextId; //课件Id
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.VoteCount))
 {
objRow[conzx_Skill.VoteCount] = objzx_SkillEN.VoteCount; //点赞计数
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.AppraiseCount))
 {
objRow[conzx_Skill.AppraiseCount] = objzx_SkillEN.AppraiseCount; //评论数
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.Score))
 {
objRow[conzx_Skill.Score] = objzx_SkillEN.Score; //评分
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.StuScore))
 {
objRow[conzx_Skill.StuScore] = objzx_SkillEN.StuScore; //学生平均分
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.TeaScore))
 {
objRow[conzx_Skill.TeaScore] = objzx_SkillEN.TeaScore; //教师评分
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.IdCurrEduCls))
 {
objRow[conzx_Skill.IdCurrEduCls] = objzx_SkillEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfContent))
 {
objRow[conzx_Skill.PdfContent] = objzx_SkillEN.PdfContent; //Pdf内容
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfPageNum))
 {
objRow[conzx_Skill.PdfPageNum] = objzx_SkillEN.PdfPageNum; //Pdf页码
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.CitationCount))
 {
objRow[conzx_Skill.CitationCount] = objzx_SkillEN.CitationCount; //引用统计
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.VersionCount))
 {
objRow[conzx_Skill.VersionCount] = objzx_SkillEN.VersionCount; //版本统计
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.zxShareId))
 {
objRow[conzx_Skill.zxShareId] = objzx_SkillEN.zxShareId; //分享Id
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.UpdUser))
 {
objRow[conzx_Skill.UpdUser] = objzx_SkillEN.UpdUser; //修改人
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.CreateDate))
 {
objRow[conzx_Skill.CreateDate] = objzx_SkillEN.CreateDate; //建立日期
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.UpdDate))
 {
objRow[conzx_Skill.UpdDate] = objzx_SkillEN.UpdDate; //修改日期
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.Memo))
 {
objRow[conzx_Skill.Memo] = objzx_SkillEN.Memo; //备注
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfDivLet))
 {
objRow[conzx_Skill.PdfDivLet] = objzx_SkillEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfDivTop))
 {
objRow[conzx_Skill.PdfDivTop] = objzx_SkillEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfPageNumIn))
 {
objRow[conzx_Skill.PdfPageNumIn] = objzx_SkillEN.PdfPageNumIn; //PdfPageNumIn
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfPageTop))
 {
objRow[conzx_Skill.PdfPageTop] = objzx_SkillEN.PdfPageTop; //pdf页面顶部位置
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfZoom))
 {
objRow[conzx_Skill.PdfZoom] = objzx_SkillEN.PdfZoom; //PdfZoom
 }
 if (objzx_SkillEN.IsUpdated(conzx_Skill.GroupTextId))
 {
objRow[conzx_Skill.GroupTextId] = objzx_SkillEN.GroupTextId; //小组Id
 }
try
{
objDA.Update(objDS, clszx_SkillEN._CurrTabName);
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
 /// <param name = "objzx_SkillEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_SkillEN objzx_SkillEN)
{
 if (objzx_SkillEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SkillEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_Skill Set ");
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.SkillName))
 {
 if (objzx_SkillEN.SkillName !=  null)
 {
 var strSkillName = objzx_SkillEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSkillName, conzx_Skill.SkillName); //技能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.SkillName); //技能名称
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.zxOperationTypeId))
 {
 if (objzx_SkillEN.zxOperationTypeId !=  null)
 {
 var strzxOperationTypeId = objzx_SkillEN.zxOperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxOperationTypeId, conzx_Skill.zxOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.zxOperationTypeId); //操作类型ID
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.Process))
 {
 if (objzx_SkillEN.Process !=  null)
 {
 var strProcess = objzx_SkillEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProcess, conzx_Skill.Process); //实施过程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.Process); //实施过程
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.zxLevelId))
 {
 if (objzx_SkillEN.zxLevelId !=  null)
 {
 var strzxLevelId = objzx_SkillEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxLevelId, conzx_Skill.zxLevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.zxLevelId); //级别Id
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_SkillEN.IsSubmit == true?"1":"0", conzx_Skill.IsSubmit); //是否提交
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.TextId))
 {
 if (objzx_SkillEN.TextId !=  null)
 {
 var strTextId = objzx_SkillEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_Skill.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.TextId); //课件Id
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.VoteCount))
 {
 if (objzx_SkillEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.VoteCount, conzx_Skill.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.VoteCount); //点赞计数
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.AppraiseCount))
 {
 if (objzx_SkillEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.AppraiseCount, conzx_Skill.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.AppraiseCount); //评论数
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.Score))
 {
 if (objzx_SkillEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.Score, conzx_Skill.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.Score); //评分
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.StuScore))
 {
 if (objzx_SkillEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.StuScore, conzx_Skill.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.StuScore); //学生平均分
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.TeaScore))
 {
 if (objzx_SkillEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.TeaScore, conzx_Skill.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.TeaScore); //教师评分
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.IdCurrEduCls))
 {
 if (objzx_SkillEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SkillEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_Skill.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfContent))
 {
 if (objzx_SkillEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_SkillEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_Skill.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfPageNum))
 {
 if (objzx_SkillEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.PdfPageNum, conzx_Skill.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.CitationCount))
 {
 if (objzx_SkillEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.CitationCount, conzx_Skill.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.CitationCount); //引用统计
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.VersionCount))
 {
 if (objzx_SkillEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.VersionCount, conzx_Skill.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.VersionCount); //版本统计
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.zxShareId))
 {
 if (objzx_SkillEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_SkillEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_Skill.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.zxShareId); //分享Id
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.UpdUser))
 {
 if (objzx_SkillEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SkillEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_Skill.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.UpdUser); //修改人
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.CreateDate))
 {
 if (objzx_SkillEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_SkillEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_Skill.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.CreateDate); //建立日期
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.UpdDate))
 {
 if (objzx_SkillEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SkillEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_Skill.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.UpdDate); //修改日期
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.Memo))
 {
 if (objzx_SkillEN.Memo !=  null)
 {
 var strMemo = objzx_SkillEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_Skill.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.Memo); //备注
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfDivLet))
 {
 if (objzx_SkillEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_SkillEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_Skill.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfDivTop))
 {
 if (objzx_SkillEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_SkillEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_Skill.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfPageNumIn))
 {
 if (objzx_SkillEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_SkillEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_Skill.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfPageTop))
 {
 if (objzx_SkillEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.PdfPageTop, conzx_Skill.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfZoom))
 {
 if (objzx_SkillEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_SkillEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_Skill.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.GroupTextId))
 {
 if (objzx_SkillEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_SkillEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_Skill.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxSkillId = '{0}'", objzx_SkillEN.zxSkillId); 
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
 /// <param name = "objzx_SkillEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_SkillEN objzx_SkillEN, string strCondition)
{
 if (objzx_SkillEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SkillEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Skill Set ");
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.SkillName))
 {
 if (objzx_SkillEN.SkillName !=  null)
 {
 var strSkillName = objzx_SkillEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SkillName = '{0}',", strSkillName); //技能名称
 }
 else
 {
 sbSQL.Append(" SkillName = null,"); //技能名称
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.zxOperationTypeId))
 {
 if (objzx_SkillEN.zxOperationTypeId !=  null)
 {
 var strzxOperationTypeId = objzx_SkillEN.zxOperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxOperationTypeId = '{0}',", strzxOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.Append(" zxOperationTypeId = null,"); //操作类型ID
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.Process))
 {
 if (objzx_SkillEN.Process !=  null)
 {
 var strProcess = objzx_SkillEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Process = '{0}',", strProcess); //实施过程
 }
 else
 {
 sbSQL.Append(" Process = null,"); //实施过程
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.zxLevelId))
 {
 if (objzx_SkillEN.zxLevelId !=  null)
 {
 var strzxLevelId = objzx_SkillEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxLevelId = '{0}',", strzxLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" zxLevelId = null,"); //级别Id
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_SkillEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.TextId))
 {
 if (objzx_SkillEN.TextId !=  null)
 {
 var strTextId = objzx_SkillEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.VoteCount))
 {
 if (objzx_SkillEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.VoteCount, conzx_Skill.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.VoteCount); //点赞计数
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.AppraiseCount))
 {
 if (objzx_SkillEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.AppraiseCount, conzx_Skill.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.AppraiseCount); //评论数
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.Score))
 {
 if (objzx_SkillEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.Score, conzx_Skill.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.Score); //评分
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.StuScore))
 {
 if (objzx_SkillEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.StuScore, conzx_Skill.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.StuScore); //学生平均分
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.TeaScore))
 {
 if (objzx_SkillEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.TeaScore, conzx_Skill.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.TeaScore); //教师评分
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.IdCurrEduCls))
 {
 if (objzx_SkillEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SkillEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfContent))
 {
 if (objzx_SkillEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_SkillEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfPageNum))
 {
 if (objzx_SkillEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.PdfPageNum, conzx_Skill.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.CitationCount))
 {
 if (objzx_SkillEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.CitationCount, conzx_Skill.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.CitationCount); //引用统计
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.VersionCount))
 {
 if (objzx_SkillEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.VersionCount, conzx_Skill.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.VersionCount); //版本统计
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.zxShareId))
 {
 if (objzx_SkillEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_SkillEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.UpdUser))
 {
 if (objzx_SkillEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SkillEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.CreateDate))
 {
 if (objzx_SkillEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_SkillEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.UpdDate))
 {
 if (objzx_SkillEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SkillEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.Memo))
 {
 if (objzx_SkillEN.Memo !=  null)
 {
 var strMemo = objzx_SkillEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfDivLet))
 {
 if (objzx_SkillEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_SkillEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfDivTop))
 {
 if (objzx_SkillEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_SkillEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfPageNumIn))
 {
 if (objzx_SkillEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_SkillEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfPageTop))
 {
 if (objzx_SkillEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.PdfPageTop, conzx_Skill.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfZoom))
 {
 if (objzx_SkillEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_SkillEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.GroupTextId))
 {
 if (objzx_SkillEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_SkillEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_SkillEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_SkillEN objzx_SkillEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_SkillEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SkillEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Skill Set ");
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.SkillName))
 {
 if (objzx_SkillEN.SkillName !=  null)
 {
 var strSkillName = objzx_SkillEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SkillName = '{0}',", strSkillName); //技能名称
 }
 else
 {
 sbSQL.Append(" SkillName = null,"); //技能名称
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.zxOperationTypeId))
 {
 if (objzx_SkillEN.zxOperationTypeId !=  null)
 {
 var strzxOperationTypeId = objzx_SkillEN.zxOperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxOperationTypeId = '{0}',", strzxOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.Append(" zxOperationTypeId = null,"); //操作类型ID
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.Process))
 {
 if (objzx_SkillEN.Process !=  null)
 {
 var strProcess = objzx_SkillEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Process = '{0}',", strProcess); //实施过程
 }
 else
 {
 sbSQL.Append(" Process = null,"); //实施过程
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.zxLevelId))
 {
 if (objzx_SkillEN.zxLevelId !=  null)
 {
 var strzxLevelId = objzx_SkillEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxLevelId = '{0}',", strzxLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" zxLevelId = null,"); //级别Id
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_SkillEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.TextId))
 {
 if (objzx_SkillEN.TextId !=  null)
 {
 var strTextId = objzx_SkillEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.VoteCount))
 {
 if (objzx_SkillEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.VoteCount, conzx_Skill.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.VoteCount); //点赞计数
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.AppraiseCount))
 {
 if (objzx_SkillEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.AppraiseCount, conzx_Skill.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.AppraiseCount); //评论数
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.Score))
 {
 if (objzx_SkillEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.Score, conzx_Skill.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.Score); //评分
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.StuScore))
 {
 if (objzx_SkillEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.StuScore, conzx_Skill.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.StuScore); //学生平均分
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.TeaScore))
 {
 if (objzx_SkillEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.TeaScore, conzx_Skill.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.TeaScore); //教师评分
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.IdCurrEduCls))
 {
 if (objzx_SkillEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SkillEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfContent))
 {
 if (objzx_SkillEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_SkillEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfPageNum))
 {
 if (objzx_SkillEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.PdfPageNum, conzx_Skill.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.CitationCount))
 {
 if (objzx_SkillEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.CitationCount, conzx_Skill.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.CitationCount); //引用统计
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.VersionCount))
 {
 if (objzx_SkillEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.VersionCount, conzx_Skill.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.VersionCount); //版本统计
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.zxShareId))
 {
 if (objzx_SkillEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_SkillEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.UpdUser))
 {
 if (objzx_SkillEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SkillEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.CreateDate))
 {
 if (objzx_SkillEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_SkillEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.UpdDate))
 {
 if (objzx_SkillEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SkillEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.Memo))
 {
 if (objzx_SkillEN.Memo !=  null)
 {
 var strMemo = objzx_SkillEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfDivLet))
 {
 if (objzx_SkillEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_SkillEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfDivTop))
 {
 if (objzx_SkillEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_SkillEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfPageNumIn))
 {
 if (objzx_SkillEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_SkillEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfPageTop))
 {
 if (objzx_SkillEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.PdfPageTop, conzx_Skill.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfZoom))
 {
 if (objzx_SkillEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_SkillEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.GroupTextId))
 {
 if (objzx_SkillEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_SkillEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_SkillEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_SkillEN objzx_SkillEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_SkillEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SkillEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Skill Set ");
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.SkillName))
 {
 if (objzx_SkillEN.SkillName !=  null)
 {
 var strSkillName = objzx_SkillEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSkillName, conzx_Skill.SkillName); //技能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.SkillName); //技能名称
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.zxOperationTypeId))
 {
 if (objzx_SkillEN.zxOperationTypeId !=  null)
 {
 var strzxOperationTypeId = objzx_SkillEN.zxOperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxOperationTypeId, conzx_Skill.zxOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.zxOperationTypeId); //操作类型ID
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.Process))
 {
 if (objzx_SkillEN.Process !=  null)
 {
 var strProcess = objzx_SkillEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProcess, conzx_Skill.Process); //实施过程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.Process); //实施过程
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.zxLevelId))
 {
 if (objzx_SkillEN.zxLevelId !=  null)
 {
 var strzxLevelId = objzx_SkillEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxLevelId, conzx_Skill.zxLevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.zxLevelId); //级别Id
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_SkillEN.IsSubmit == true?"1":"0", conzx_Skill.IsSubmit); //是否提交
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.TextId))
 {
 if (objzx_SkillEN.TextId !=  null)
 {
 var strTextId = objzx_SkillEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_Skill.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.TextId); //课件Id
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.VoteCount))
 {
 if (objzx_SkillEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.VoteCount, conzx_Skill.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.VoteCount); //点赞计数
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.AppraiseCount))
 {
 if (objzx_SkillEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.AppraiseCount, conzx_Skill.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.AppraiseCount); //评论数
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.Score))
 {
 if (objzx_SkillEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.Score, conzx_Skill.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.Score); //评分
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.StuScore))
 {
 if (objzx_SkillEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.StuScore, conzx_Skill.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.StuScore); //学生平均分
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.TeaScore))
 {
 if (objzx_SkillEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.TeaScore, conzx_Skill.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.TeaScore); //教师评分
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.IdCurrEduCls))
 {
 if (objzx_SkillEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SkillEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_Skill.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfContent))
 {
 if (objzx_SkillEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_SkillEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_Skill.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfPageNum))
 {
 if (objzx_SkillEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.PdfPageNum, conzx_Skill.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.CitationCount))
 {
 if (objzx_SkillEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.CitationCount, conzx_Skill.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.CitationCount); //引用统计
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.VersionCount))
 {
 if (objzx_SkillEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.VersionCount, conzx_Skill.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.VersionCount); //版本统计
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.zxShareId))
 {
 if (objzx_SkillEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_SkillEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_Skill.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.zxShareId); //分享Id
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.UpdUser))
 {
 if (objzx_SkillEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SkillEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_Skill.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.UpdUser); //修改人
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.CreateDate))
 {
 if (objzx_SkillEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_SkillEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_Skill.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.CreateDate); //建立日期
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.UpdDate))
 {
 if (objzx_SkillEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SkillEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_Skill.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.UpdDate); //修改日期
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.Memo))
 {
 if (objzx_SkillEN.Memo !=  null)
 {
 var strMemo = objzx_SkillEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_Skill.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.Memo); //备注
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfDivLet))
 {
 if (objzx_SkillEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_SkillEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_Skill.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfDivTop))
 {
 if (objzx_SkillEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_SkillEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_Skill.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfPageNumIn))
 {
 if (objzx_SkillEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_SkillEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_Skill.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfPageTop))
 {
 if (objzx_SkillEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillEN.PdfPageTop, conzx_Skill.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.PdfZoom))
 {
 if (objzx_SkillEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_SkillEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_Skill.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_SkillEN.IsUpdated(conzx_Skill.GroupTextId))
 {
 if (objzx_SkillEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_SkillEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_Skill.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Skill.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxSkillId = '{0}'", objzx_SkillEN.zxSkillId); 
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
 /// <param name = "strzxSkillId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strzxSkillId) 
{
CheckPrimaryKey(strzxSkillId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strzxSkillId,
};
 objSQL.ExecSP("zx_Skill_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strzxSkillId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strzxSkillId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strzxSkillId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
//删除zx_Skill本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Skill where zxSkillId = " + "'"+ strzxSkillId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_Skill(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
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
//删除zx_Skill本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Skill where zxSkillId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strzxSkillId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strzxSkillId) 
{
CheckPrimaryKey(strzxSkillId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
//删除zx_Skill本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Skill where zxSkillId = " + "'"+ strzxSkillId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_Skill(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_SkillDA: Delzx_Skill)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_Skill where " + strCondition ;
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
public bool Delzx_SkillWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_SkillDA: Delzx_SkillWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_Skill where " + strCondition ;
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
 /// <param name = "objzx_SkillENS">源对象</param>
 /// <param name = "objzx_SkillENT">目标对象</param>
public void CopyTo(clszx_SkillEN objzx_SkillENS, clszx_SkillEN objzx_SkillENT)
{
objzx_SkillENT.zxSkillId = objzx_SkillENS.zxSkillId; //技能Id
objzx_SkillENT.SkillName = objzx_SkillENS.SkillName; //技能名称
objzx_SkillENT.zxOperationTypeId = objzx_SkillENS.zxOperationTypeId; //操作类型ID
objzx_SkillENT.Process = objzx_SkillENS.Process; //实施过程
objzx_SkillENT.zxLevelId = objzx_SkillENS.zxLevelId; //级别Id
objzx_SkillENT.IsSubmit = objzx_SkillENS.IsSubmit; //是否提交
objzx_SkillENT.TextId = objzx_SkillENS.TextId; //课件Id
objzx_SkillENT.VoteCount = objzx_SkillENS.VoteCount; //点赞计数
objzx_SkillENT.AppraiseCount = objzx_SkillENS.AppraiseCount; //评论数
objzx_SkillENT.Score = objzx_SkillENS.Score; //评分
objzx_SkillENT.StuScore = objzx_SkillENS.StuScore; //学生平均分
objzx_SkillENT.TeaScore = objzx_SkillENS.TeaScore; //教师评分
objzx_SkillENT.IdCurrEduCls = objzx_SkillENS.IdCurrEduCls; //教学班流水号
objzx_SkillENT.PdfContent = objzx_SkillENS.PdfContent; //Pdf内容
objzx_SkillENT.PdfPageNum = objzx_SkillENS.PdfPageNum; //Pdf页码
objzx_SkillENT.CitationCount = objzx_SkillENS.CitationCount; //引用统计
objzx_SkillENT.VersionCount = objzx_SkillENS.VersionCount; //版本统计
objzx_SkillENT.zxShareId = objzx_SkillENS.zxShareId; //分享Id
objzx_SkillENT.UpdUser = objzx_SkillENS.UpdUser; //修改人
objzx_SkillENT.CreateDate = objzx_SkillENS.CreateDate; //建立日期
objzx_SkillENT.UpdDate = objzx_SkillENS.UpdDate; //修改日期
objzx_SkillENT.Memo = objzx_SkillENS.Memo; //备注
objzx_SkillENT.PdfDivLet = objzx_SkillENS.PdfDivLet; //PdfDivLet
objzx_SkillENT.PdfDivTop = objzx_SkillENS.PdfDivTop; //PdfDivTop
objzx_SkillENT.PdfPageNumIn = objzx_SkillENS.PdfPageNumIn; //PdfPageNumIn
objzx_SkillENT.PdfPageTop = objzx_SkillENS.PdfPageTop; //pdf页面顶部位置
objzx_SkillENT.PdfZoom = objzx_SkillENS.PdfZoom; //PdfZoom
objzx_SkillENT.GroupTextId = objzx_SkillENS.GroupTextId; //小组Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_SkillEN objzx_SkillEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SkillEN.zxSkillId, 10, conzx_Skill.zxSkillId);
clsCheckSql.CheckFieldLen(objzx_SkillEN.SkillName, 200, conzx_Skill.SkillName);
clsCheckSql.CheckFieldLen(objzx_SkillEN.zxOperationTypeId, 2, conzx_Skill.zxOperationTypeId);
clsCheckSql.CheckFieldLen(objzx_SkillEN.zxLevelId, 2, conzx_Skill.zxLevelId);
clsCheckSql.CheckFieldLen(objzx_SkillEN.TextId, 8, conzx_Skill.TextId);
clsCheckSql.CheckFieldLen(objzx_SkillEN.IdCurrEduCls, 8, conzx_Skill.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_SkillEN.PdfContent, 2000, conzx_Skill.PdfContent);
clsCheckSql.CheckFieldLen(objzx_SkillEN.zxShareId, 2, conzx_Skill.zxShareId);
clsCheckSql.CheckFieldLen(objzx_SkillEN.UpdUser, 20, conzx_Skill.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SkillEN.CreateDate, 20, conzx_Skill.CreateDate);
clsCheckSql.CheckFieldLen(objzx_SkillEN.UpdDate, 20, conzx_Skill.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SkillEN.Memo, 1000, conzx_Skill.Memo);
clsCheckSql.CheckFieldLen(objzx_SkillEN.PdfDivLet, 50, conzx_Skill.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_SkillEN.PdfDivTop, 50, conzx_Skill.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_SkillEN.PdfPageNumIn, 50, conzx_Skill.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_SkillEN.PdfZoom, 50, conzx_Skill.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_SkillEN.GroupTextId, 8, conzx_Skill.GroupTextId);
//检查字段外键固定长度
 objzx_SkillEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_SkillEN objzx_SkillEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SkillEN.SkillName, 200, conzx_Skill.SkillName);
clsCheckSql.CheckFieldLen(objzx_SkillEN.zxOperationTypeId, 2, conzx_Skill.zxOperationTypeId);
clsCheckSql.CheckFieldLen(objzx_SkillEN.zxLevelId, 2, conzx_Skill.zxLevelId);
clsCheckSql.CheckFieldLen(objzx_SkillEN.TextId, 8, conzx_Skill.TextId);
clsCheckSql.CheckFieldLen(objzx_SkillEN.IdCurrEduCls, 8, conzx_Skill.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_SkillEN.PdfContent, 2000, conzx_Skill.PdfContent);
clsCheckSql.CheckFieldLen(objzx_SkillEN.zxShareId, 2, conzx_Skill.zxShareId);
clsCheckSql.CheckFieldLen(objzx_SkillEN.UpdUser, 20, conzx_Skill.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SkillEN.CreateDate, 20, conzx_Skill.CreateDate);
clsCheckSql.CheckFieldLen(objzx_SkillEN.UpdDate, 20, conzx_Skill.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SkillEN.Memo, 1000, conzx_Skill.Memo);
clsCheckSql.CheckFieldLen(objzx_SkillEN.PdfDivLet, 50, conzx_Skill.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_SkillEN.PdfDivTop, 50, conzx_Skill.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_SkillEN.PdfPageNumIn, 50, conzx_Skill.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_SkillEN.PdfZoom, 50, conzx_Skill.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_SkillEN.GroupTextId, 8, conzx_Skill.GroupTextId);
//检查外键字段长度
 objzx_SkillEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_SkillEN objzx_SkillEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SkillEN.zxSkillId, 10, conzx_Skill.zxSkillId);
clsCheckSql.CheckFieldLen(objzx_SkillEN.SkillName, 200, conzx_Skill.SkillName);
clsCheckSql.CheckFieldLen(objzx_SkillEN.zxOperationTypeId, 2, conzx_Skill.zxOperationTypeId);
clsCheckSql.CheckFieldLen(objzx_SkillEN.zxLevelId, 2, conzx_Skill.zxLevelId);
clsCheckSql.CheckFieldLen(objzx_SkillEN.TextId, 8, conzx_Skill.TextId);
clsCheckSql.CheckFieldLen(objzx_SkillEN.IdCurrEduCls, 8, conzx_Skill.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_SkillEN.PdfContent, 2000, conzx_Skill.PdfContent);
clsCheckSql.CheckFieldLen(objzx_SkillEN.zxShareId, 2, conzx_Skill.zxShareId);
clsCheckSql.CheckFieldLen(objzx_SkillEN.UpdUser, 20, conzx_Skill.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SkillEN.CreateDate, 20, conzx_Skill.CreateDate);
clsCheckSql.CheckFieldLen(objzx_SkillEN.UpdDate, 20, conzx_Skill.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SkillEN.Memo, 1000, conzx_Skill.Memo);
clsCheckSql.CheckFieldLen(objzx_SkillEN.PdfDivLet, 50, conzx_Skill.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_SkillEN.PdfDivTop, 50, conzx_Skill.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_SkillEN.PdfPageNumIn, 50, conzx_Skill.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_SkillEN.PdfZoom, 50, conzx_Skill.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_SkillEN.GroupTextId, 8, conzx_Skill.GroupTextId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.zxSkillId, conzx_Skill.zxSkillId);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.SkillName, conzx_Skill.SkillName);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.zxOperationTypeId, conzx_Skill.zxOperationTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.zxLevelId, conzx_Skill.zxLevelId);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.TextId, conzx_Skill.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.IdCurrEduCls, conzx_Skill.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.PdfContent, conzx_Skill.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.zxShareId, conzx_Skill.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.UpdUser, conzx_Skill.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.CreateDate, conzx_Skill.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.UpdDate, conzx_Skill.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.Memo, conzx_Skill.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.PdfDivLet, conzx_Skill.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.PdfDivTop, conzx_Skill.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.PdfPageNumIn, conzx_Skill.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.PdfZoom, conzx_Skill.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillEN.GroupTextId, conzx_Skill.GroupTextId);
//检查外键字段长度
 objzx_SkillEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetzxSkillId()
{
//获取某学院所有专业信息
string strSQL = "select zxSkillId, zxLevelId from zx_Skill ";
 clsSpecSQLforSql mySql = clszx_SkillDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_Skill(中学技能表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_SkillEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_SkillEN objzx_SkillEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objzx_SkillEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null");
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_SkillEN.TextId);
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
 objSQL = clszx_SkillDA.GetSpecSQLObj();
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
 objSQL = clszx_SkillDA.GetSpecSQLObj();
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
 objSQL = clszx_SkillDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_SkillEN._CurrTabName);
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
 objSQL = clszx_SkillDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_SkillEN._CurrTabName, strCondition);
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
 objSQL = clszx_SkillDA.GetSpecSQLObj();
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
 objSQL = clszx_SkillDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}