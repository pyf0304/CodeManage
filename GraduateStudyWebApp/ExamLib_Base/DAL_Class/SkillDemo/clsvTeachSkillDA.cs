
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachSkillDA
 表名:vTeachSkill(01120314)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
 /// 教学技能视图(vTeachSkill)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTeachSkillDA : clsCommBase4DA
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
 return clsvTeachSkillEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTeachSkillEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachSkillEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTeachSkillEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTeachSkillEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdTeachSkill">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdTeachSkill)
{
strIdTeachSkill = strIdTeachSkill.Replace("'", "''");
if (strIdTeachSkill.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vTeachSkill中,检查关键字,长度不正确!(clsvTeachSkillDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdTeachSkill)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vTeachSkill中,关键字不能为空 或 null!(clsvTeachSkillDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachSkill);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvTeachSkillDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTeachSkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
strSQL = "Select * from vTeachSkill where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTeachSkill(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTeachSkillDA: GetDataTable_vTeachSkill)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
strSQL = "Select * from vTeachSkill where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTeachSkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTeachSkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
strSQL = "Select * from vTeachSkill where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTeachSkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTeachSkillDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachSkill where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachSkill where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTeachSkillDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTeachSkill where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTeachSkillDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachSkill.* from vTeachSkill Left Join {1} on {2} where {3} and vTeachSkill.IdTeachSkill not in (Select top {5} vTeachSkill.IdTeachSkill from vTeachSkill Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachSkill where {1} and IdTeachSkill not in (Select top {2} IdTeachSkill from vTeachSkill where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachSkill where {1} and IdTeachSkill not in (Select top {3} IdTeachSkill from vTeachSkill where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTeachSkillDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachSkill.* from vTeachSkill Left Join {1} on {2} where {3} and vTeachSkill.IdTeachSkill not in (Select top {5} vTeachSkill.IdTeachSkill from vTeachSkill Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachSkill where {1} and IdTeachSkill not in (Select top {2} IdTeachSkill from vTeachSkill where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachSkill where {1} and IdTeachSkill not in (Select top {3} IdTeachSkill from vTeachSkill where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTeachSkillEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTeachSkillDA:GetObjLst)", objException.Message));
}
List<clsvTeachSkillEN> arrObjLst = new List<clsvTeachSkillEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
strSQL = "Select * from vTeachSkill where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachSkillEN objvTeachSkillEN = new clsvTeachSkillEN();
try
{
objvTeachSkillEN.IdTeachSkill = objRow[convTeachSkill.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachSkillEN.TeachSkillID = objRow[convTeachSkill.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachSkillEN.SkillTypeName = objRow[convTeachSkill.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachSkillEN.TeachSkillName = objRow[convTeachSkill.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachSkillEN.TeachSkillTheory = objRow[convTeachSkill.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachSkillEN.TeachSkillOperMethod = objRow[convTeachSkill.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachSkillEN.IdSkillType = objRow[convTeachSkill.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachSkillEN.Memo = objRow[convTeachSkill.Memo] == DBNull.Value ? null : objRow[convTeachSkill.Memo].ToString().Trim(); //备注
objvTeachSkillEN.SkillTypeID = objRow[convTeachSkill.SkillTypeID].ToString().Trim(); //技能类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachSkillDA: GetObjLst)", objException.Message));
}
objvTeachSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachSkillEN);
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
public List<clsvTeachSkillEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTeachSkillDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTeachSkillEN> arrObjLst = new List<clsvTeachSkillEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachSkillEN objvTeachSkillEN = new clsvTeachSkillEN();
try
{
objvTeachSkillEN.IdTeachSkill = objRow[convTeachSkill.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachSkillEN.TeachSkillID = objRow[convTeachSkill.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachSkillEN.SkillTypeName = objRow[convTeachSkill.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachSkillEN.TeachSkillName = objRow[convTeachSkill.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachSkillEN.TeachSkillTheory = objRow[convTeachSkill.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachSkillEN.TeachSkillOperMethod = objRow[convTeachSkill.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachSkillEN.IdSkillType = objRow[convTeachSkill.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachSkillEN.Memo = objRow[convTeachSkill.Memo] == DBNull.Value ? null : objRow[convTeachSkill.Memo].ToString().Trim(); //备注
objvTeachSkillEN.SkillTypeID = objRow[convTeachSkill.SkillTypeID].ToString().Trim(); //技能类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachSkillDA: GetObjLst)", objException.Message));
}
objvTeachSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachSkillEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTeachSkill(ref clsvTeachSkillEN objvTeachSkillEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
strSQL = "Select * from vTeachSkill where IdTeachSkill = " + "'"+ objvTeachSkillEN.IdTeachSkill+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTeachSkillEN.IdTeachSkill = objDT.Rows[0][convTeachSkill.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachSkillEN.TeachSkillID = objDT.Rows[0][convTeachSkill.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachSkillEN.SkillTypeName = objDT.Rows[0][convTeachSkill.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachSkillEN.TeachSkillName = objDT.Rows[0][convTeachSkill.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachSkillEN.TeachSkillTheory = objDT.Rows[0][convTeachSkill.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachSkillEN.TeachSkillOperMethod = objDT.Rows[0][convTeachSkill.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvTeachSkillEN.IdSkillType = objDT.Rows[0][convTeachSkill.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachSkillEN.Memo = objDT.Rows[0][convTeachSkill.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachSkillEN.SkillTypeID = objDT.Rows[0][convTeachSkill.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTeachSkillDA: GetvTeachSkill)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdTeachSkill">表关键字</param>
 /// <returns>表对象</returns>
public clsvTeachSkillEN GetObjByIdTeachSkill(string strIdTeachSkill)
{
CheckPrimaryKey(strIdTeachSkill);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
strSQL = "Select * from vTeachSkill where IdTeachSkill = " + "'"+ strIdTeachSkill+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTeachSkillEN objvTeachSkillEN = new clsvTeachSkillEN();
try
{
 objvTeachSkillEN.IdTeachSkill = objRow[convTeachSkill.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachSkillEN.TeachSkillID = objRow[convTeachSkill.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachSkillEN.SkillTypeName = objRow[convTeachSkill.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachSkillEN.TeachSkillName = objRow[convTeachSkill.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachSkillEN.TeachSkillTheory = objRow[convTeachSkill.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachSkillEN.TeachSkillOperMethod = objRow[convTeachSkill.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvTeachSkillEN.IdSkillType = objRow[convTeachSkill.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachSkillEN.Memo = objRow[convTeachSkill.Memo] == DBNull.Value ? null : objRow[convTeachSkill.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachSkillEN.SkillTypeID = objRow[convTeachSkill.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTeachSkillDA: GetObjByIdTeachSkill)", objException.Message));
}
return objvTeachSkillEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTeachSkillEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTeachSkillDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
strSQL = "Select * from vTeachSkill where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTeachSkillEN objvTeachSkillEN = new clsvTeachSkillEN()
{
IdTeachSkill = objRow[convTeachSkill.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convTeachSkill.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convTeachSkill.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convTeachSkill.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convTeachSkill.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convTeachSkill.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convTeachSkill.IdSkillType].ToString().Trim(), //技能类型流水号
Memo = objRow[convTeachSkill.Memo] == DBNull.Value ? null : objRow[convTeachSkill.Memo].ToString().Trim(), //备注
SkillTypeID = objRow[convTeachSkill.SkillTypeID].ToString().Trim() //技能类型ID
};
objvTeachSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachSkillEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTeachSkillDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTeachSkillEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachSkillEN objvTeachSkillEN = new clsvTeachSkillEN();
try
{
objvTeachSkillEN.IdTeachSkill = objRow[convTeachSkill.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachSkillEN.TeachSkillID = objRow[convTeachSkill.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachSkillEN.SkillTypeName = objRow[convTeachSkill.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachSkillEN.TeachSkillName = objRow[convTeachSkill.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachSkillEN.TeachSkillTheory = objRow[convTeachSkill.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachSkillEN.TeachSkillOperMethod = objRow[convTeachSkill.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachSkillEN.IdSkillType = objRow[convTeachSkill.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachSkillEN.Memo = objRow[convTeachSkill.Memo] == DBNull.Value ? null : objRow[convTeachSkill.Memo].ToString().Trim(); //备注
objvTeachSkillEN.SkillTypeID = objRow[convTeachSkill.SkillTypeID].ToString().Trim(); //技能类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTeachSkillDA: GetObjByDataRowvTeachSkill)", objException.Message));
}
objvTeachSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachSkillEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTeachSkillEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachSkillEN objvTeachSkillEN = new clsvTeachSkillEN();
try
{
objvTeachSkillEN.IdTeachSkill = objRow[convTeachSkill.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachSkillEN.TeachSkillID = objRow[convTeachSkill.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachSkillEN.SkillTypeName = objRow[convTeachSkill.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachSkillEN.TeachSkillName = objRow[convTeachSkill.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachSkillEN.TeachSkillTheory = objRow[convTeachSkill.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachSkillEN.TeachSkillOperMethod = objRow[convTeachSkill.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachSkillEN.IdSkillType = objRow[convTeachSkill.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachSkillEN.Memo = objRow[convTeachSkill.Memo] == DBNull.Value ? null : objRow[convTeachSkill.Memo].ToString().Trim(); //备注
objvTeachSkillEN.SkillTypeID = objRow[convTeachSkill.SkillTypeID].ToString().Trim(); //技能类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTeachSkillDA: GetObjByDataRow)", objException.Message));
}
objvTeachSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachSkillEN;
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
objSQL = clsvTeachSkillDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachSkillEN._CurrTabName, convTeachSkill.IdTeachSkill, 8, "");
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
objSQL = clsvTeachSkillDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachSkillEN._CurrTabName, convTeachSkill.IdTeachSkill, 8, strPrefix);
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
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdTeachSkill from vTeachSkill where " + strCondition;
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
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdTeachSkill from vTeachSkill where " + strCondition;
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
 /// <param name = "strIdTeachSkill">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdTeachSkill)
{
CheckPrimaryKey(strIdTeachSkill);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachSkill", "IdTeachSkill = " + "'"+ strIdTeachSkill+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTeachSkillDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachSkill", strCondition))
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
objSQL = clsvTeachSkillDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTeachSkill");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTeachSkillENS">源对象</param>
 /// <param name = "objvTeachSkillENT">目标对象</param>
public void CopyTo(clsvTeachSkillEN objvTeachSkillENS, clsvTeachSkillEN objvTeachSkillENT)
{
objvTeachSkillENT.IdTeachSkill = objvTeachSkillENS.IdTeachSkill; //教学技能流水号
objvTeachSkillENT.TeachSkillID = objvTeachSkillENS.TeachSkillID; //教学技能ID
objvTeachSkillENT.SkillTypeName = objvTeachSkillENS.SkillTypeName; //技能类型名称
objvTeachSkillENT.TeachSkillName = objvTeachSkillENS.TeachSkillName; //教学技能名称
objvTeachSkillENT.TeachSkillTheory = objvTeachSkillENS.TeachSkillTheory; //教学技能理论阐述
objvTeachSkillENT.TeachSkillOperMethod = objvTeachSkillENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachSkillENT.IdSkillType = objvTeachSkillENS.IdSkillType; //技能类型流水号
objvTeachSkillENT.Memo = objvTeachSkillENS.Memo; //备注
objvTeachSkillENT.SkillTypeID = objvTeachSkillENS.SkillTypeID; //技能类型ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTeachSkillEN objvTeachSkillEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTeachSkillEN.IdTeachSkill, 8, convTeachSkill.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvTeachSkillEN.TeachSkillID, 8, convTeachSkill.TeachSkillID);
clsCheckSql.CheckFieldLen(objvTeachSkillEN.SkillTypeName, 50, convTeachSkill.SkillTypeName);
clsCheckSql.CheckFieldLen(objvTeachSkillEN.TeachSkillName, 50, convTeachSkill.TeachSkillName);
clsCheckSql.CheckFieldLen(objvTeachSkillEN.TeachSkillTheory, 8000, convTeachSkill.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvTeachSkillEN.TeachSkillOperMethod, 2000, convTeachSkill.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvTeachSkillEN.IdSkillType, 4, convTeachSkill.IdSkillType);
clsCheckSql.CheckFieldLen(objvTeachSkillEN.Memo, 1000, convTeachSkill.Memo);
clsCheckSql.CheckFieldLen(objvTeachSkillEN.SkillTypeID, 4, convTeachSkill.SkillTypeID);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTeachSkillEN.IdTeachSkill, convTeachSkill.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvTeachSkillEN.TeachSkillID, convTeachSkill.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvTeachSkillEN.SkillTypeName, convTeachSkill.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachSkillEN.TeachSkillName, convTeachSkill.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvTeachSkillEN.TeachSkillTheory, convTeachSkill.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvTeachSkillEN.TeachSkillOperMethod, convTeachSkill.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvTeachSkillEN.IdSkillType, convTeachSkill.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvTeachSkillEN.Memo, convTeachSkill.Memo);
clsCheckSql.CheckSqlInjection4Field(objvTeachSkillEN.SkillTypeID, convTeachSkill.SkillTypeID);
//检查外键字段长度
 objvTeachSkillEN._IsCheckProperty = true;
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
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
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
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
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
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachSkillEN._CurrTabName);
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
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachSkillEN._CurrTabName, strCondition);
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
 objSQL = clsvTeachSkillDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}