﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkDA
 表名:cc_Work(01120144)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:35
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 作业(cc_Work)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_WorkDA : clsCommBase4DA
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
 return clscc_WorkEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_WorkEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_WorkEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_WorkEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_WorkEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdWork">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdWork)
{
strIdWork = strIdWork.Replace("'", "''");
if (strIdWork.Length > 8)
{
throw new Exception("(errid:Data000001)在表:cc_Work中,检查关键字,长度不正确!(clscc_WorkDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdWork)  ==  true)
{
throw new Exception("(errid:Data000002)在表:cc_Work中,关键字不能为空 或 null!(clscc_WorkDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdWork);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clscc_WorkDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_WorkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_Work where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_Work(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_WorkDA: GetDataTable_cc_Work)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_Work where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_WorkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_WorkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_Work where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_WorkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_WorkDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_Work where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_Work where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_WorkDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_Work where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_WorkDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_Work.* from cc_Work Left Join {1} on {2} where {3} and cc_Work.IdWork not in (Select top {5} cc_Work.IdWork from cc_Work Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_Work where {1} and IdWork not in (Select top {2} IdWork from cc_Work where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_Work where {1} and IdWork not in (Select top {3} IdWork from cc_Work where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_WorkDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_Work.* from cc_Work Left Join {1} on {2} where {3} and cc_Work.IdWork not in (Select top {5} cc_Work.IdWork from cc_Work Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_Work where {1} and IdWork not in (Select top {2} IdWork from cc_Work where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_Work where {1} and IdWork not in (Select top {3} IdWork from cc_Work where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_WorkEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_WorkDA:GetObjLst)", objException.Message));
}
List<clscc_WorkEN> arrObjLst = new List<clscc_WorkEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_Work where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkEN objcc_WorkEN = new clscc_WorkEN();
try
{
objcc_WorkEN.IdWork = objRow[concc_Work.IdWork].ToString().Trim(); //作业流水号
objcc_WorkEN.WorkIndex = objRow[concc_Work.WorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Work.WorkIndex].ToString().Trim()); //作业序号
objcc_WorkEN.WorkName = objRow[concc_Work.WorkName].ToString().Trim(); //作业名称
objcc_WorkEN.WorkDesc = objRow[concc_Work.WorkDesc] == DBNull.Value ? null : objRow[concc_Work.WorkDesc].ToString().Trim(); //作业说明
objcc_WorkEN.CourseId = objRow[concc_Work.CourseId].ToString().Trim(); //课程Id
objcc_WorkEN.CourseChapterId = objRow[concc_Work.CourseChapterId] == DBNull.Value ? null : objRow[concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_WorkEN.Creator = objRow[concc_Work.Creator] == DBNull.Value ? null : objRow[concc_Work.Creator].ToString().Trim(); //创建者
objcc_WorkEN.CreateDate = objRow[concc_Work.CreateDate] == DBNull.Value ? null : objRow[concc_Work.CreateDate].ToString().Trim(); //建立日期
objcc_WorkEN.AnswerAttLimitSize = objRow[concc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objcc_WorkEN.LimitedResourceType = objRow[concc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objcc_WorkEN.UpdDate = objRow[concc_Work.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEN.UpdUserId = objRow[concc_Work.UpdUserId] == DBNull.Value ? null : objRow[concc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEN.Memo = objRow[concc_Work.Memo] == DBNull.Value ? null : objRow[concc_Work.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_WorkDA: GetObjLst)", objException.Message));
}
objcc_WorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_WorkEN);
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
public List<clscc_WorkEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_WorkDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_WorkEN> arrObjLst = new List<clscc_WorkEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkEN objcc_WorkEN = new clscc_WorkEN();
try
{
objcc_WorkEN.IdWork = objRow[concc_Work.IdWork].ToString().Trim(); //作业流水号
objcc_WorkEN.WorkIndex = objRow[concc_Work.WorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Work.WorkIndex].ToString().Trim()); //作业序号
objcc_WorkEN.WorkName = objRow[concc_Work.WorkName].ToString().Trim(); //作业名称
objcc_WorkEN.WorkDesc = objRow[concc_Work.WorkDesc] == DBNull.Value ? null : objRow[concc_Work.WorkDesc].ToString().Trim(); //作业说明
objcc_WorkEN.CourseId = objRow[concc_Work.CourseId].ToString().Trim(); //课程Id
objcc_WorkEN.CourseChapterId = objRow[concc_Work.CourseChapterId] == DBNull.Value ? null : objRow[concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_WorkEN.Creator = objRow[concc_Work.Creator] == DBNull.Value ? null : objRow[concc_Work.Creator].ToString().Trim(); //创建者
objcc_WorkEN.CreateDate = objRow[concc_Work.CreateDate] == DBNull.Value ? null : objRow[concc_Work.CreateDate].ToString().Trim(); //建立日期
objcc_WorkEN.AnswerAttLimitSize = objRow[concc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objcc_WorkEN.LimitedResourceType = objRow[concc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objcc_WorkEN.UpdDate = objRow[concc_Work.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEN.UpdUserId = objRow[concc_Work.UpdUserId] == DBNull.Value ? null : objRow[concc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEN.Memo = objRow[concc_Work.Memo] == DBNull.Value ? null : objRow[concc_Work.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_WorkDA: GetObjLst)", objException.Message));
}
objcc_WorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_WorkEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_Work(ref clscc_WorkEN objcc_WorkEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_Work where IdWork = " + "'"+ objcc_WorkEN.IdWork+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_WorkEN.IdWork = objDT.Rows[0][concc_Work.IdWork].ToString().Trim(); //作业流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_WorkEN.WorkIndex = TransNullToInt(objDT.Rows[0][concc_Work.WorkIndex].ToString().Trim()); //作业序号(字段类型:int,字段长度:4,是否可空:True)
 objcc_WorkEN.WorkName = objDT.Rows[0][concc_Work.WorkName].ToString().Trim(); //作业名称(字段类型:varchar,字段长度:5000,是否可空:False)
 objcc_WorkEN.WorkDesc = objDT.Rows[0][concc_Work.WorkDesc].ToString().Trim(); //作业说明(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_WorkEN.CourseId = objDT.Rows[0][concc_Work.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_WorkEN.CourseChapterId = objDT.Rows[0][concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objcc_WorkEN.Creator = objDT.Rows[0][concc_Work.Creator].ToString().Trim(); //创建者(字段类型:varchar,字段长度:18,是否可空:True)
 objcc_WorkEN.CreateDate = objDT.Rows[0][concc_Work.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkEN.AnswerAttLimitSize = TransNullToInt(objDT.Rows[0][concc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_WorkEN.LimitedResourceType = objDT.Rows[0][concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_WorkEN.UpdDate = objDT.Rows[0][concc_Work.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkEN.UpdUserId = objDT.Rows[0][concc_Work.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkEN.Memo = objDT.Rows[0][concc_Work.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_WorkDA: Getcc_Work)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdWork">表关键字</param>
 /// <returns>表对象</returns>
public clscc_WorkEN GetObjByIdWork(string strIdWork)
{
CheckPrimaryKey(strIdWork);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_Work where IdWork = " + "'"+ strIdWork+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_WorkEN objcc_WorkEN = new clscc_WorkEN();
try
{
 objcc_WorkEN.IdWork = objRow[concc_Work.IdWork].ToString().Trim(); //作业流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_WorkEN.WorkIndex = objRow[concc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.WorkIndex].ToString().Trim()); //作业序号(字段类型:int,字段长度:4,是否可空:True)
 objcc_WorkEN.WorkName = objRow[concc_Work.WorkName].ToString().Trim(); //作业名称(字段类型:varchar,字段长度:5000,是否可空:False)
 objcc_WorkEN.WorkDesc = objRow[concc_Work.WorkDesc] == DBNull.Value ? null : objRow[concc_Work.WorkDesc].ToString().Trim(); //作业说明(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_WorkEN.CourseId = objRow[concc_Work.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_WorkEN.CourseChapterId = objRow[concc_Work.CourseChapterId] == DBNull.Value ? null : objRow[concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objcc_WorkEN.Creator = objRow[concc_Work.Creator] == DBNull.Value ? null : objRow[concc_Work.Creator].ToString().Trim(); //创建者(字段类型:varchar,字段长度:18,是否可空:True)
 objcc_WorkEN.CreateDate = objRow[concc_Work.CreateDate] == DBNull.Value ? null : objRow[concc_Work.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkEN.AnswerAttLimitSize = objRow[concc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_WorkEN.LimitedResourceType = objRow[concc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_WorkEN.UpdDate = objRow[concc_Work.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkEN.UpdUserId = objRow[concc_Work.UpdUserId] == DBNull.Value ? null : objRow[concc_Work.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkEN.Memo = objRow[concc_Work.Memo] == DBNull.Value ? null : objRow[concc_Work.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_WorkDA: GetObjByIdWork)", objException.Message));
}
return objcc_WorkEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_WorkEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_WorkDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_Work where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_WorkEN objcc_WorkEN = new clscc_WorkEN()
{
IdWork = objRow[concc_Work.IdWork].ToString().Trim(), //作业流水号
WorkIndex = objRow[concc_Work.WorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Work.WorkIndex].ToString().Trim()), //作业序号
WorkName = objRow[concc_Work.WorkName].ToString().Trim(), //作业名称
WorkDesc = objRow[concc_Work.WorkDesc] == DBNull.Value ? null : objRow[concc_Work.WorkDesc].ToString().Trim(), //作业说明
CourseId = objRow[concc_Work.CourseId].ToString().Trim(), //课程Id
CourseChapterId = objRow[concc_Work.CourseChapterId] == DBNull.Value ? null : objRow[concc_Work.CourseChapterId].ToString().Trim(), //课程章节ID
Creator = objRow[concc_Work.Creator] == DBNull.Value ? null : objRow[concc_Work.Creator].ToString().Trim(), //创建者
CreateDate = objRow[concc_Work.CreateDate] == DBNull.Value ? null : objRow[concc_Work.CreateDate].ToString().Trim(), //建立日期
AnswerAttLimitSize = objRow[concc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_Work.AnswerAttLimitSize].ToString().Trim()), //回答附件限制大小
LimitedResourceType = objRow[concc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[concc_Work.LimitedResourceType].ToString().Trim(), //限制资源类型
UpdDate = objRow[concc_Work.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[concc_Work.UpdUserId] == DBNull.Value ? null : objRow[concc_Work.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[concc_Work.Memo] == DBNull.Value ? null : objRow[concc_Work.Memo].ToString().Trim() //备注
};
objcc_WorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_WorkEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_WorkDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_WorkEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_WorkEN objcc_WorkEN = new clscc_WorkEN();
try
{
objcc_WorkEN.IdWork = objRow[concc_Work.IdWork].ToString().Trim(); //作业流水号
objcc_WorkEN.WorkIndex = objRow[concc_Work.WorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Work.WorkIndex].ToString().Trim()); //作业序号
objcc_WorkEN.WorkName = objRow[concc_Work.WorkName].ToString().Trim(); //作业名称
objcc_WorkEN.WorkDesc = objRow[concc_Work.WorkDesc] == DBNull.Value ? null : objRow[concc_Work.WorkDesc].ToString().Trim(); //作业说明
objcc_WorkEN.CourseId = objRow[concc_Work.CourseId].ToString().Trim(); //课程Id
objcc_WorkEN.CourseChapterId = objRow[concc_Work.CourseChapterId] == DBNull.Value ? null : objRow[concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_WorkEN.Creator = objRow[concc_Work.Creator] == DBNull.Value ? null : objRow[concc_Work.Creator].ToString().Trim(); //创建者
objcc_WorkEN.CreateDate = objRow[concc_Work.CreateDate] == DBNull.Value ? null : objRow[concc_Work.CreateDate].ToString().Trim(); //建立日期
objcc_WorkEN.AnswerAttLimitSize = objRow[concc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objcc_WorkEN.LimitedResourceType = objRow[concc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objcc_WorkEN.UpdDate = objRow[concc_Work.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEN.UpdUserId = objRow[concc_Work.UpdUserId] == DBNull.Value ? null : objRow[concc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEN.Memo = objRow[concc_Work.Memo] == DBNull.Value ? null : objRow[concc_Work.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_WorkDA: GetObjByDataRowcc_Work)", objException.Message));
}
objcc_WorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_WorkEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_WorkEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_WorkEN objcc_WorkEN = new clscc_WorkEN();
try
{
objcc_WorkEN.IdWork = objRow[concc_Work.IdWork].ToString().Trim(); //作业流水号
objcc_WorkEN.WorkIndex = objRow[concc_Work.WorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Work.WorkIndex].ToString().Trim()); //作业序号
objcc_WorkEN.WorkName = objRow[concc_Work.WorkName].ToString().Trim(); //作业名称
objcc_WorkEN.WorkDesc = objRow[concc_Work.WorkDesc] == DBNull.Value ? null : objRow[concc_Work.WorkDesc].ToString().Trim(); //作业说明
objcc_WorkEN.CourseId = objRow[concc_Work.CourseId].ToString().Trim(); //课程Id
objcc_WorkEN.CourseChapterId = objRow[concc_Work.CourseChapterId] == DBNull.Value ? null : objRow[concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_WorkEN.Creator = objRow[concc_Work.Creator] == DBNull.Value ? null : objRow[concc_Work.Creator].ToString().Trim(); //创建者
objcc_WorkEN.CreateDate = objRow[concc_Work.CreateDate] == DBNull.Value ? null : objRow[concc_Work.CreateDate].ToString().Trim(); //建立日期
objcc_WorkEN.AnswerAttLimitSize = objRow[concc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objcc_WorkEN.LimitedResourceType = objRow[concc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objcc_WorkEN.UpdDate = objRow[concc_Work.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEN.UpdUserId = objRow[concc_Work.UpdUserId] == DBNull.Value ? null : objRow[concc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEN.Memo = objRow[concc_Work.Memo] == DBNull.Value ? null : objRow[concc_Work.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_WorkDA: GetObjByDataRow)", objException.Message));
}
objcc_WorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_WorkEN;
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
objSQL = clscc_WorkDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_WorkEN._CurrTabName, concc_Work.IdWork, 8, "");
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
objSQL = clscc_WorkDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_WorkEN._CurrTabName, concc_Work.IdWork, 8, strPrefix);
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
 objSQL = clscc_WorkDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdWork from cc_Work where " + strCondition;
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
 objSQL = clscc_WorkDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdWork from cc_Work where " + strCondition;
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
 /// <param name = "strIdWork">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdWork)
{
CheckPrimaryKey(strIdWork);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_Work", "IdWork = " + "'"+ strIdWork+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_WorkDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_Work", strCondition))
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
objSQL = clscc_WorkDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_Work");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_WorkEN objcc_WorkEN)
 {
 objcc_WorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_Work where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_Work");
objRow = objDS.Tables["cc_Work"].NewRow();
objRow[concc_Work.IdWork] = objcc_WorkEN.IdWork; //作业流水号
objRow[concc_Work.WorkIndex] = objcc_WorkEN.WorkIndex; //作业序号
objRow[concc_Work.WorkName] = objcc_WorkEN.WorkName; //作业名称
 if (objcc_WorkEN.WorkDesc !=  "")
 {
objRow[concc_Work.WorkDesc] = objcc_WorkEN.WorkDesc; //作业说明
 }
objRow[concc_Work.CourseId] = objcc_WorkEN.CourseId; //课程Id
 if (objcc_WorkEN.CourseChapterId !=  "")
 {
objRow[concc_Work.CourseChapterId] = objcc_WorkEN.CourseChapterId; //课程章节ID
 }
 if (objcc_WorkEN.Creator !=  "")
 {
objRow[concc_Work.Creator] = objcc_WorkEN.Creator; //创建者
 }
 if (objcc_WorkEN.CreateDate !=  "")
 {
objRow[concc_Work.CreateDate] = objcc_WorkEN.CreateDate; //建立日期
 }
objRow[concc_Work.AnswerAttLimitSize] = objcc_WorkEN.AnswerAttLimitSize; //回答附件限制大小
 if (objcc_WorkEN.LimitedResourceType !=  "")
 {
objRow[concc_Work.LimitedResourceType] = objcc_WorkEN.LimitedResourceType; //限制资源类型
 }
objRow[concc_Work.UpdDate] = objcc_WorkEN.UpdDate; //修改日期
 if (objcc_WorkEN.UpdUserId !=  "")
 {
objRow[concc_Work.UpdUserId] = objcc_WorkEN.UpdUserId; //修改用户Id
 }
 if (objcc_WorkEN.Memo !=  "")
 {
objRow[concc_Work.Memo] = objcc_WorkEN.Memo; //备注
 }
objDS.Tables[clscc_WorkEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_WorkEN._CurrTabName);
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
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_WorkEN objcc_WorkEN)
{
 objcc_WorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_WorkEN.IdWork !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.IdWork);
 var strIdWork = objcc_WorkEN.IdWork.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdWork + "'");
 }
 
 if (objcc_WorkEN.WorkIndex !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.WorkIndex);
 arrValueListForInsert.Add(objcc_WorkEN.WorkIndex.ToString());
 }
 
 if (objcc_WorkEN.WorkName !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.WorkName);
 var strWorkName = objcc_WorkEN.WorkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkName + "'");
 }
 
 if (objcc_WorkEN.WorkDesc !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.WorkDesc);
 var strWorkDesc = objcc_WorkEN.WorkDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkDesc + "'");
 }
 
 if (objcc_WorkEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.CourseId);
 var strCourseId = objcc_WorkEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_WorkEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.CourseChapterId);
 var strCourseChapterId = objcc_WorkEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_WorkEN.Creator !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.Creator);
 var strCreator = objcc_WorkEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreator + "'");
 }
 
 if (objcc_WorkEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.CreateDate);
 var strCreateDate = objcc_WorkEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objcc_WorkEN.AnswerAttLimitSize !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.AnswerAttLimitSize);
 arrValueListForInsert.Add(objcc_WorkEN.AnswerAttLimitSize.ToString());
 }
 
 if (objcc_WorkEN.LimitedResourceType !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.LimitedResourceType);
 var strLimitedResourceType = objcc_WorkEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLimitedResourceType + "'");
 }
 
 if (objcc_WorkEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.UpdDate);
 var strUpdDate = objcc_WorkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.UpdUserId);
 var strUpdUserId = objcc_WorkEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_WorkEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.Memo);
 var strMemo = objcc_WorkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_Work");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_WorkEN objcc_WorkEN)
{
 objcc_WorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_WorkEN.IdWork !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.IdWork);
 var strIdWork = objcc_WorkEN.IdWork.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdWork + "'");
 }
 
 if (objcc_WorkEN.WorkIndex !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.WorkIndex);
 arrValueListForInsert.Add(objcc_WorkEN.WorkIndex.ToString());
 }
 
 if (objcc_WorkEN.WorkName !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.WorkName);
 var strWorkName = objcc_WorkEN.WorkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkName + "'");
 }
 
 if (objcc_WorkEN.WorkDesc !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.WorkDesc);
 var strWorkDesc = objcc_WorkEN.WorkDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkDesc + "'");
 }
 
 if (objcc_WorkEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.CourseId);
 var strCourseId = objcc_WorkEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_WorkEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.CourseChapterId);
 var strCourseChapterId = objcc_WorkEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_WorkEN.Creator !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.Creator);
 var strCreator = objcc_WorkEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreator + "'");
 }
 
 if (objcc_WorkEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.CreateDate);
 var strCreateDate = objcc_WorkEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objcc_WorkEN.AnswerAttLimitSize !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.AnswerAttLimitSize);
 arrValueListForInsert.Add(objcc_WorkEN.AnswerAttLimitSize.ToString());
 }
 
 if (objcc_WorkEN.LimitedResourceType !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.LimitedResourceType);
 var strLimitedResourceType = objcc_WorkEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLimitedResourceType + "'");
 }
 
 if (objcc_WorkEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.UpdDate);
 var strUpdDate = objcc_WorkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.UpdUserId);
 var strUpdUserId = objcc_WorkEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_WorkEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.Memo);
 var strMemo = objcc_WorkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_Work");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objcc_WorkEN.IdWork;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_WorkEN objcc_WorkEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_WorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_WorkEN.IdWork !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.IdWork);
 var strIdWork = objcc_WorkEN.IdWork.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdWork + "'");
 }
 
 if (objcc_WorkEN.WorkIndex !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.WorkIndex);
 arrValueListForInsert.Add(objcc_WorkEN.WorkIndex.ToString());
 }
 
 if (objcc_WorkEN.WorkName !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.WorkName);
 var strWorkName = objcc_WorkEN.WorkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkName + "'");
 }
 
 if (objcc_WorkEN.WorkDesc !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.WorkDesc);
 var strWorkDesc = objcc_WorkEN.WorkDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkDesc + "'");
 }
 
 if (objcc_WorkEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.CourseId);
 var strCourseId = objcc_WorkEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_WorkEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.CourseChapterId);
 var strCourseChapterId = objcc_WorkEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_WorkEN.Creator !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.Creator);
 var strCreator = objcc_WorkEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreator + "'");
 }
 
 if (objcc_WorkEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.CreateDate);
 var strCreateDate = objcc_WorkEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objcc_WorkEN.AnswerAttLimitSize !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.AnswerAttLimitSize);
 arrValueListForInsert.Add(objcc_WorkEN.AnswerAttLimitSize.ToString());
 }
 
 if (objcc_WorkEN.LimitedResourceType !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.LimitedResourceType);
 var strLimitedResourceType = objcc_WorkEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLimitedResourceType + "'");
 }
 
 if (objcc_WorkEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.UpdDate);
 var strUpdDate = objcc_WorkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.UpdUserId);
 var strUpdUserId = objcc_WorkEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_WorkEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.Memo);
 var strMemo = objcc_WorkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_Work");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objcc_WorkEN.IdWork;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_WorkEN objcc_WorkEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_WorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_WorkEN.IdWork !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.IdWork);
 var strIdWork = objcc_WorkEN.IdWork.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdWork + "'");
 }
 
 if (objcc_WorkEN.WorkIndex !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.WorkIndex);
 arrValueListForInsert.Add(objcc_WorkEN.WorkIndex.ToString());
 }
 
 if (objcc_WorkEN.WorkName !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.WorkName);
 var strWorkName = objcc_WorkEN.WorkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkName + "'");
 }
 
 if (objcc_WorkEN.WorkDesc !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.WorkDesc);
 var strWorkDesc = objcc_WorkEN.WorkDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkDesc + "'");
 }
 
 if (objcc_WorkEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.CourseId);
 var strCourseId = objcc_WorkEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_WorkEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.CourseChapterId);
 var strCourseChapterId = objcc_WorkEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_WorkEN.Creator !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.Creator);
 var strCreator = objcc_WorkEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreator + "'");
 }
 
 if (objcc_WorkEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.CreateDate);
 var strCreateDate = objcc_WorkEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objcc_WorkEN.AnswerAttLimitSize !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.AnswerAttLimitSize);
 arrValueListForInsert.Add(objcc_WorkEN.AnswerAttLimitSize.ToString());
 }
 
 if (objcc_WorkEN.LimitedResourceType !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.LimitedResourceType);
 var strLimitedResourceType = objcc_WorkEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLimitedResourceType + "'");
 }
 
 if (objcc_WorkEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.UpdDate);
 var strUpdDate = objcc_WorkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.UpdUserId);
 var strUpdUserId = objcc_WorkEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_WorkEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_Work.Memo);
 var strMemo = objcc_WorkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_Work");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_Works(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_Work where IdWork = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_Work");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdWork = oRow[concc_Work.IdWork].ToString().Trim();
if (IsExist(strIdWork))
{
 string strResult = "关键字变量值为:" + string.Format("IdWork = {0}", strIdWork) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_WorkEN._CurrTabName ].NewRow();
objRow[concc_Work.IdWork] = oRow[concc_Work.IdWork].ToString().Trim(); //作业流水号
objRow[concc_Work.WorkIndex] = oRow[concc_Work.WorkIndex].ToString().Trim(); //作业序号
objRow[concc_Work.WorkName] = oRow[concc_Work.WorkName].ToString().Trim(); //作业名称
objRow[concc_Work.WorkDesc] = oRow[concc_Work.WorkDesc].ToString().Trim(); //作业说明
objRow[concc_Work.CourseId] = oRow[concc_Work.CourseId].ToString().Trim(); //课程Id
objRow[concc_Work.CourseChapterId] = oRow[concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objRow[concc_Work.Creator] = oRow[concc_Work.Creator].ToString().Trim(); //创建者
objRow[concc_Work.CreateDate] = oRow[concc_Work.CreateDate].ToString().Trim(); //建立日期
objRow[concc_Work.AnswerAttLimitSize] = oRow[concc_Work.AnswerAttLimitSize].ToString().Trim(); //回答附件限制大小
objRow[concc_Work.LimitedResourceType] = oRow[concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objRow[concc_Work.UpdDate] = oRow[concc_Work.UpdDate].ToString().Trim(); //修改日期
objRow[concc_Work.UpdUserId] = oRow[concc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objRow[concc_Work.Memo] = oRow[concc_Work.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_WorkEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_WorkEN._CurrTabName);
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
 /// <param name = "objcc_WorkEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_WorkEN objcc_WorkEN)
{
 objcc_WorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_Work where IdWork = " + "'"+ objcc_WorkEN.IdWork+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_WorkEN._CurrTabName);
if (objDS.Tables[clscc_WorkEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdWork = " + "'"+ objcc_WorkEN.IdWork+"'");
return false;
}
objRow = objDS.Tables[clscc_WorkEN._CurrTabName].Rows[0];
 if (objcc_WorkEN.IsUpdated(concc_Work.IdWork))
 {
objRow[concc_Work.IdWork] = objcc_WorkEN.IdWork; //作业流水号
 }
 if (objcc_WorkEN.IsUpdated(concc_Work.WorkIndex))
 {
objRow[concc_Work.WorkIndex] = objcc_WorkEN.WorkIndex; //作业序号
 }
 if (objcc_WorkEN.IsUpdated(concc_Work.WorkName))
 {
objRow[concc_Work.WorkName] = objcc_WorkEN.WorkName; //作业名称
 }
 if (objcc_WorkEN.IsUpdated(concc_Work.WorkDesc))
 {
objRow[concc_Work.WorkDesc] = objcc_WorkEN.WorkDesc; //作业说明
 }
 if (objcc_WorkEN.IsUpdated(concc_Work.CourseId))
 {
objRow[concc_Work.CourseId] = objcc_WorkEN.CourseId; //课程Id
 }
 if (objcc_WorkEN.IsUpdated(concc_Work.CourseChapterId))
 {
objRow[concc_Work.CourseChapterId] = objcc_WorkEN.CourseChapterId; //课程章节ID
 }
 if (objcc_WorkEN.IsUpdated(concc_Work.Creator))
 {
objRow[concc_Work.Creator] = objcc_WorkEN.Creator; //创建者
 }
 if (objcc_WorkEN.IsUpdated(concc_Work.CreateDate))
 {
objRow[concc_Work.CreateDate] = objcc_WorkEN.CreateDate; //建立日期
 }
 if (objcc_WorkEN.IsUpdated(concc_Work.AnswerAttLimitSize))
 {
objRow[concc_Work.AnswerAttLimitSize] = objcc_WorkEN.AnswerAttLimitSize; //回答附件限制大小
 }
 if (objcc_WorkEN.IsUpdated(concc_Work.LimitedResourceType))
 {
objRow[concc_Work.LimitedResourceType] = objcc_WorkEN.LimitedResourceType; //限制资源类型
 }
 if (objcc_WorkEN.IsUpdated(concc_Work.UpdDate))
 {
objRow[concc_Work.UpdDate] = objcc_WorkEN.UpdDate; //修改日期
 }
 if (objcc_WorkEN.IsUpdated(concc_Work.UpdUserId))
 {
objRow[concc_Work.UpdUserId] = objcc_WorkEN.UpdUserId; //修改用户Id
 }
 if (objcc_WorkEN.IsUpdated(concc_Work.Memo))
 {
objRow[concc_Work.Memo] = objcc_WorkEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_WorkEN._CurrTabName);
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
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_WorkEN objcc_WorkEN)
{
 objcc_WorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_Work Set ");
 
 if (objcc_WorkEN.IsUpdated(concc_Work.WorkIndex))
 {
 if (objcc_WorkEN.WorkIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEN.WorkIndex, concc_Work.WorkIndex); //作业序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.WorkIndex); //作业序号
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.WorkName))
 {
 if (objcc_WorkEN.WorkName !=  null)
 {
 var strWorkName = objcc_WorkEN.WorkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkName, concc_Work.WorkName); //作业名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.WorkName); //作业名称
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.WorkDesc))
 {
 if (objcc_WorkEN.WorkDesc !=  null)
 {
 var strWorkDesc = objcc_WorkEN.WorkDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkDesc, concc_Work.WorkDesc); //作业说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.WorkDesc); //作业说明
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.CourseId))
 {
 if (objcc_WorkEN.CourseId !=  null)
 {
 var strCourseId = objcc_WorkEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_Work.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.CourseId); //课程Id
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.CourseChapterId))
 {
 if (objcc_WorkEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_WorkEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, concc_Work.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.CourseChapterId); //课程章节ID
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.Creator))
 {
 if (objcc_WorkEN.Creator !=  null)
 {
 var strCreator = objcc_WorkEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreator, concc_Work.Creator); //创建者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.Creator); //创建者
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.CreateDate))
 {
 if (objcc_WorkEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_WorkEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, concc_Work.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.CreateDate); //建立日期
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.AnswerAttLimitSize))
 {
 if (objcc_WorkEN.AnswerAttLimitSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEN.AnswerAttLimitSize, concc_Work.AnswerAttLimitSize); //回答附件限制大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.AnswerAttLimitSize); //回答附件限制大小
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.LimitedResourceType))
 {
 if (objcc_WorkEN.LimitedResourceType !=  null)
 {
 var strLimitedResourceType = objcc_WorkEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLimitedResourceType, concc_Work.LimitedResourceType); //限制资源类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.LimitedResourceType); //限制资源类型
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.UpdDate))
 {
 if (objcc_WorkEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_Work.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.UpdDate); //修改日期
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.UpdUserId))
 {
 if (objcc_WorkEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_WorkEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_Work.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.Memo))
 {
 if (objcc_WorkEN.Memo !=  null)
 {
 var strMemo = objcc_WorkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_Work.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdWork = '{0}'", objcc_WorkEN.IdWork); 
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
 /// <param name = "objcc_WorkEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_WorkEN objcc_WorkEN, string strCondition)
{
 objcc_WorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_Work Set ");
 
 if (objcc_WorkEN.IsUpdated(concc_Work.WorkIndex))
 {
 if (objcc_WorkEN.WorkIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEN.WorkIndex, concc_Work.WorkIndex); //作业序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.WorkIndex); //作业序号
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.WorkName))
 {
 if (objcc_WorkEN.WorkName !=  null)
 {
 var strWorkName = objcc_WorkEN.WorkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkName = '{0}',", strWorkName); //作业名称
 }
 else
 {
 sbSQL.Append(" WorkName = null,"); //作业名称
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.WorkDesc))
 {
 if (objcc_WorkEN.WorkDesc !=  null)
 {
 var strWorkDesc = objcc_WorkEN.WorkDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkDesc = '{0}',", strWorkDesc); //作业说明
 }
 else
 {
 sbSQL.Append(" WorkDesc = null,"); //作业说明
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.CourseId))
 {
 if (objcc_WorkEN.CourseId !=  null)
 {
 var strCourseId = objcc_WorkEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.CourseChapterId))
 {
 if (objcc_WorkEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_WorkEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.Creator))
 {
 if (objcc_WorkEN.Creator !=  null)
 {
 var strCreator = objcc_WorkEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Creator = '{0}',", strCreator); //创建者
 }
 else
 {
 sbSQL.Append(" Creator = null,"); //创建者
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.CreateDate))
 {
 if (objcc_WorkEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_WorkEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.AnswerAttLimitSize))
 {
 if (objcc_WorkEN.AnswerAttLimitSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEN.AnswerAttLimitSize, concc_Work.AnswerAttLimitSize); //回答附件限制大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.AnswerAttLimitSize); //回答附件限制大小
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.LimitedResourceType))
 {
 if (objcc_WorkEN.LimitedResourceType !=  null)
 {
 var strLimitedResourceType = objcc_WorkEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LimitedResourceType = '{0}',", strLimitedResourceType); //限制资源类型
 }
 else
 {
 sbSQL.Append(" LimitedResourceType = null,"); //限制资源类型
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.UpdDate))
 {
 if (objcc_WorkEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.UpdUserId))
 {
 if (objcc_WorkEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_WorkEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.Memo))
 {
 if (objcc_WorkEN.Memo !=  null)
 {
 var strMemo = objcc_WorkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_WorkEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_WorkEN objcc_WorkEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_WorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_Work Set ");
 
 if (objcc_WorkEN.IsUpdated(concc_Work.WorkIndex))
 {
 if (objcc_WorkEN.WorkIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEN.WorkIndex, concc_Work.WorkIndex); //作业序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.WorkIndex); //作业序号
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.WorkName))
 {
 if (objcc_WorkEN.WorkName !=  null)
 {
 var strWorkName = objcc_WorkEN.WorkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkName = '{0}',", strWorkName); //作业名称
 }
 else
 {
 sbSQL.Append(" WorkName = null,"); //作业名称
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.WorkDesc))
 {
 if (objcc_WorkEN.WorkDesc !=  null)
 {
 var strWorkDesc = objcc_WorkEN.WorkDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkDesc = '{0}',", strWorkDesc); //作业说明
 }
 else
 {
 sbSQL.Append(" WorkDesc = null,"); //作业说明
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.CourseId))
 {
 if (objcc_WorkEN.CourseId !=  null)
 {
 var strCourseId = objcc_WorkEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.CourseChapterId))
 {
 if (objcc_WorkEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_WorkEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.Creator))
 {
 if (objcc_WorkEN.Creator !=  null)
 {
 var strCreator = objcc_WorkEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Creator = '{0}',", strCreator); //创建者
 }
 else
 {
 sbSQL.Append(" Creator = null,"); //创建者
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.CreateDate))
 {
 if (objcc_WorkEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_WorkEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.AnswerAttLimitSize))
 {
 if (objcc_WorkEN.AnswerAttLimitSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEN.AnswerAttLimitSize, concc_Work.AnswerAttLimitSize); //回答附件限制大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.AnswerAttLimitSize); //回答附件限制大小
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.LimitedResourceType))
 {
 if (objcc_WorkEN.LimitedResourceType !=  null)
 {
 var strLimitedResourceType = objcc_WorkEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LimitedResourceType = '{0}',", strLimitedResourceType); //限制资源类型
 }
 else
 {
 sbSQL.Append(" LimitedResourceType = null,"); //限制资源类型
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.UpdDate))
 {
 if (objcc_WorkEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.UpdUserId))
 {
 if (objcc_WorkEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_WorkEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.Memo))
 {
 if (objcc_WorkEN.Memo !=  null)
 {
 var strMemo = objcc_WorkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_WorkEN objcc_WorkEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_WorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_Work Set ");
 
 if (objcc_WorkEN.IsUpdated(concc_Work.WorkIndex))
 {
 if (objcc_WorkEN.WorkIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEN.WorkIndex, concc_Work.WorkIndex); //作业序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.WorkIndex); //作业序号
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.WorkName))
 {
 if (objcc_WorkEN.WorkName !=  null)
 {
 var strWorkName = objcc_WorkEN.WorkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkName, concc_Work.WorkName); //作业名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.WorkName); //作业名称
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.WorkDesc))
 {
 if (objcc_WorkEN.WorkDesc !=  null)
 {
 var strWorkDesc = objcc_WorkEN.WorkDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkDesc, concc_Work.WorkDesc); //作业说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.WorkDesc); //作业说明
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.CourseId))
 {
 if (objcc_WorkEN.CourseId !=  null)
 {
 var strCourseId = objcc_WorkEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_Work.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.CourseId); //课程Id
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.CourseChapterId))
 {
 if (objcc_WorkEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_WorkEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, concc_Work.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.CourseChapterId); //课程章节ID
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.Creator))
 {
 if (objcc_WorkEN.Creator !=  null)
 {
 var strCreator = objcc_WorkEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreator, concc_Work.Creator); //创建者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.Creator); //创建者
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.CreateDate))
 {
 if (objcc_WorkEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_WorkEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, concc_Work.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.CreateDate); //建立日期
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.AnswerAttLimitSize))
 {
 if (objcc_WorkEN.AnswerAttLimitSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEN.AnswerAttLimitSize, concc_Work.AnswerAttLimitSize); //回答附件限制大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.AnswerAttLimitSize); //回答附件限制大小
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.LimitedResourceType))
 {
 if (objcc_WorkEN.LimitedResourceType !=  null)
 {
 var strLimitedResourceType = objcc_WorkEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLimitedResourceType, concc_Work.LimitedResourceType); //限制资源类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.LimitedResourceType); //限制资源类型
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.UpdDate))
 {
 if (objcc_WorkEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_Work.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.UpdDate); //修改日期
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.UpdUserId))
 {
 if (objcc_WorkEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_WorkEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_Work.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_WorkEN.IsUpdated(concc_Work.Memo))
 {
 if (objcc_WorkEN.Memo !=  null)
 {
 var strMemo = objcc_WorkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_Work.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Work.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdWork = '{0}'", objcc_WorkEN.IdWork); 
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
 /// <param name = "strIdWork">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdWork) 
{
CheckPrimaryKey(strIdWork);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdWork,
};
 objSQL.ExecSP("cc_Work_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdWork">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdWork, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdWork);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
//删除cc_Work本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_Work where IdWork = " + "'"+ strIdWork+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_Work(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
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
//删除cc_Work本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_Work where IdWork in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdWork">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdWork) 
{
CheckPrimaryKey(strIdWork);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
//删除cc_Work本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_Work where IdWork = " + "'"+ strIdWork+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_Work(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_WorkDA: Delcc_Work)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_Work where " + strCondition ;
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
public bool Delcc_WorkWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_WorkDA: Delcc_WorkWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_Work where " + strCondition ;
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
 /// <param name = "objcc_WorkENS">源对象</param>
 /// <param name = "objcc_WorkENT">目标对象</param>
public void CopyTo(clscc_WorkEN objcc_WorkENS, clscc_WorkEN objcc_WorkENT)
{
objcc_WorkENT.IdWork = objcc_WorkENS.IdWork; //作业流水号
objcc_WorkENT.WorkIndex = objcc_WorkENS.WorkIndex; //作业序号
objcc_WorkENT.WorkName = objcc_WorkENS.WorkName; //作业名称
objcc_WorkENT.WorkDesc = objcc_WorkENS.WorkDesc; //作业说明
objcc_WorkENT.CourseId = objcc_WorkENS.CourseId; //课程Id
objcc_WorkENT.CourseChapterId = objcc_WorkENS.CourseChapterId; //课程章节ID
objcc_WorkENT.Creator = objcc_WorkENS.Creator; //创建者
objcc_WorkENT.CreateDate = objcc_WorkENS.CreateDate; //建立日期
objcc_WorkENT.AnswerAttLimitSize = objcc_WorkENS.AnswerAttLimitSize; //回答附件限制大小
objcc_WorkENT.LimitedResourceType = objcc_WorkENS.LimitedResourceType; //限制资源类型
objcc_WorkENT.UpdDate = objcc_WorkENS.UpdDate; //修改日期
objcc_WorkENT.UpdUserId = objcc_WorkENS.UpdUserId; //修改用户Id
objcc_WorkENT.Memo = objcc_WorkENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_WorkEN objcc_WorkEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_WorkEN.WorkName, concc_Work.WorkName);
clsCheckSql.CheckFieldNotNull(objcc_WorkEN.CourseId, concc_Work.CourseId);
clsCheckSql.CheckFieldNotNull(objcc_WorkEN.UpdDate, concc_Work.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_WorkEN.IdWork, 8, concc_Work.IdWork);
clsCheckSql.CheckFieldLen(objcc_WorkEN.WorkName, 5000, concc_Work.WorkName);
clsCheckSql.CheckFieldLen(objcc_WorkEN.CourseId, 8, concc_Work.CourseId);
clsCheckSql.CheckFieldLen(objcc_WorkEN.CourseChapterId, 8, concc_Work.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_WorkEN.Creator, 18, concc_Work.Creator);
clsCheckSql.CheckFieldLen(objcc_WorkEN.CreateDate, 20, concc_Work.CreateDate);
clsCheckSql.CheckFieldLen(objcc_WorkEN.LimitedResourceType, 100, concc_Work.LimitedResourceType);
clsCheckSql.CheckFieldLen(objcc_WorkEN.UpdDate, 20, concc_Work.UpdDate);
clsCheckSql.CheckFieldLen(objcc_WorkEN.UpdUserId, 20, concc_Work.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_WorkEN.Memo, 1000, concc_Work.Memo);
//检查字段外键固定长度
 objcc_WorkEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_WorkEN objcc_WorkEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_WorkEN.WorkName, 5000, concc_Work.WorkName);
clsCheckSql.CheckFieldLen(objcc_WorkEN.CourseId, 8, concc_Work.CourseId);
clsCheckSql.CheckFieldLen(objcc_WorkEN.CourseChapterId, 8, concc_Work.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_WorkEN.Creator, 18, concc_Work.Creator);
clsCheckSql.CheckFieldLen(objcc_WorkEN.CreateDate, 20, concc_Work.CreateDate);
clsCheckSql.CheckFieldLen(objcc_WorkEN.LimitedResourceType, 100, concc_Work.LimitedResourceType);
clsCheckSql.CheckFieldLen(objcc_WorkEN.UpdDate, 20, concc_Work.UpdDate);
clsCheckSql.CheckFieldLen(objcc_WorkEN.UpdUserId, 20, concc_Work.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_WorkEN.Memo, 1000, concc_Work.Memo);
//检查外键字段长度
 objcc_WorkEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_WorkEN objcc_WorkEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_WorkEN.IdWork, 8, concc_Work.IdWork);
clsCheckSql.CheckFieldLen(objcc_WorkEN.WorkName, 5000, concc_Work.WorkName);
clsCheckSql.CheckFieldLen(objcc_WorkEN.CourseId, 8, concc_Work.CourseId);
clsCheckSql.CheckFieldLen(objcc_WorkEN.CourseChapterId, 8, concc_Work.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_WorkEN.Creator, 18, concc_Work.Creator);
clsCheckSql.CheckFieldLen(objcc_WorkEN.CreateDate, 20, concc_Work.CreateDate);
clsCheckSql.CheckFieldLen(objcc_WorkEN.LimitedResourceType, 100, concc_Work.LimitedResourceType);
clsCheckSql.CheckFieldLen(objcc_WorkEN.UpdDate, 20, concc_Work.UpdDate);
clsCheckSql.CheckFieldLen(objcc_WorkEN.UpdUserId, 20, concc_Work.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_WorkEN.Memo, 1000, concc_Work.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEN.IdWork, concc_Work.IdWork);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEN.WorkName, concc_Work.WorkName);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEN.CourseId, concc_Work.CourseId);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEN.CourseChapterId, concc_Work.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEN.Creator, concc_Work.Creator);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEN.CreateDate, concc_Work.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEN.LimitedResourceType, concc_Work.LimitedResourceType);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEN.UpdDate, concc_Work.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEN.UpdUserId, concc_Work.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEN.Memo, concc_Work.Memo);
//检查外键字段长度
 objcc_WorkEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdWork()
{
//获取某学院所有专业信息
string strSQL = "select IdWork, WorkName from cc_Work ";
 clsSpecSQLforSql mySql = clscc_WorkDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_Work(作业),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_WorkEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_WorkEN objcc_WorkEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and WorkName = '{0}'", objcc_WorkEN.WorkName);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_WorkEN.CourseId);
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
 objSQL = clscc_WorkDA.GetSpecSQLObj();
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
 objSQL = clscc_WorkDA.GetSpecSQLObj();
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
 objSQL = clscc_WorkDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_WorkEN._CurrTabName);
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
 objSQL = clscc_WorkDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_WorkEN._CurrTabName, strCondition);
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
 objSQL = clscc_WorkDA.GetSpecSQLObj();
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
 objSQL = clscc_WorkDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}