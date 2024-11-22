﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkStuRelation4GoodLibDA
 表名:cc_WorkStuRelation4GoodLib(01120223)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:52
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
 /// 学生好题集(cc_WorkStuRelation4GoodLib)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_WorkStuRelation4GoodLibDA : clsCommBase4DA
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
 return clscc_WorkStuRelation4GoodLibEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_WorkStuRelation4GoodLibEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_WorkStuRelation4GoodLibEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_WorkStuRelation4GoodLibEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_WorkStuRelation4GoodLibEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_WorkStuRelation4GoodLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation4GoodLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_WorkStuRelation4GoodLib(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_WorkStuRelation4GoodLibDA: GetDataTable_cc_WorkStuRelation4GoodLib)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation4GoodLib where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_WorkStuRelation4GoodLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_WorkStuRelation4GoodLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation4GoodLib where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_WorkStuRelation4GoodLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_WorkStuRelation4GoodLibDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkStuRelation4GoodLib where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkStuRelation4GoodLib where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_WorkStuRelation4GoodLibDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_WorkStuRelation4GoodLib where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_WorkStuRelation4GoodLibDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_WorkStuRelation4GoodLib.* from cc_WorkStuRelation4GoodLib Left Join {1} on {2} where {3} and cc_WorkStuRelation4GoodLib.mId not in (Select top {5} cc_WorkStuRelation4GoodLib.mId from cc_WorkStuRelation4GoodLib Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkStuRelation4GoodLib where {1} and mId not in (Select top {2} mId from cc_WorkStuRelation4GoodLib where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkStuRelation4GoodLib where {1} and mId not in (Select top {3} mId from cc_WorkStuRelation4GoodLib where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_WorkStuRelation4GoodLibDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_WorkStuRelation4GoodLib.* from cc_WorkStuRelation4GoodLib Left Join {1} on {2} where {3} and cc_WorkStuRelation4GoodLib.mId not in (Select top {5} cc_WorkStuRelation4GoodLib.mId from cc_WorkStuRelation4GoodLib Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkStuRelation4GoodLib where {1} and mId not in (Select top {2} mId from cc_WorkStuRelation4GoodLib where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkStuRelation4GoodLib where {1} and mId not in (Select top {3} mId from cc_WorkStuRelation4GoodLib where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_WorkStuRelation4GoodLibEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_WorkStuRelation4GoodLibDA:GetObjLst)", objException.Message));
}
List<clscc_WorkStuRelation4GoodLibEN> arrObjLst = new List<clscc_WorkStuRelation4GoodLibEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation4GoodLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN = new clscc_WorkStuRelation4GoodLibEN();
try
{
objcc_WorkStuRelation4GoodLibEN.mId = TransNullToInt(objRow[concc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objcc_WorkStuRelation4GoodLibEN.CourseId = objRow[concc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[concc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation4GoodLibEN.QuestionId = TransNullToInt(objRow[concc_WorkStuRelation4GoodLib.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelation4GoodLibEN.Creator = objRow[concc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[concc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[concc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objcc_WorkStuRelation4GoodLibEN.IsRedo = TransNullToBool(objRow[concc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[concc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objcc_WorkStuRelation4GoodLibEN.IsPassed = TransNullToBool(objRow[concc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[concc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[concc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objcc_WorkStuRelation4GoodLibEN.Memo = objRow[concc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_WorkStuRelation4GoodLibDA: GetObjLst)", objException.Message));
}
objcc_WorkStuRelation4GoodLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_WorkStuRelation4GoodLibEN);
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
public List<clscc_WorkStuRelation4GoodLibEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_WorkStuRelation4GoodLibDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_WorkStuRelation4GoodLibEN> arrObjLst = new List<clscc_WorkStuRelation4GoodLibEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN = new clscc_WorkStuRelation4GoodLibEN();
try
{
objcc_WorkStuRelation4GoodLibEN.mId = TransNullToInt(objRow[concc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objcc_WorkStuRelation4GoodLibEN.CourseId = objRow[concc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[concc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation4GoodLibEN.QuestionId = TransNullToInt(objRow[concc_WorkStuRelation4GoodLib.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelation4GoodLibEN.Creator = objRow[concc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[concc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[concc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objcc_WorkStuRelation4GoodLibEN.IsRedo = TransNullToBool(objRow[concc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[concc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objcc_WorkStuRelation4GoodLibEN.IsPassed = TransNullToBool(objRow[concc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[concc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[concc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objcc_WorkStuRelation4GoodLibEN.Memo = objRow[concc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_WorkStuRelation4GoodLibDA: GetObjLst)", objException.Message));
}
objcc_WorkStuRelation4GoodLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_WorkStuRelation4GoodLibEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_WorkStuRelation4GoodLib(ref clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation4GoodLib where mId = " + ""+ objcc_WorkStuRelation4GoodLibEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_WorkStuRelation4GoodLibEN.mId = TransNullToInt(objDT.Rows[0][concc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_WorkStuRelation4GoodLibEN.CourseId = objDT.Rows[0][concc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objDT.Rows[0][concc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_WorkStuRelation4GoodLibEN.QuestionId = TransNullToInt(objDT.Rows[0][concc_WorkStuRelation4GoodLib.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_WorkStuRelation4GoodLibEN.Creator = objDT.Rows[0][concc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者(字段类型:varchar,字段长度:18,是否可空:True)
 objcc_WorkStuRelation4GoodLibEN.CreateDate = objDT.Rows[0][concc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkStuRelation4GoodLibEN.SourceTypeId = objDT.Rows[0][concc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objcc_WorkStuRelation4GoodLibEN.IsRedo = TransNullToBool(objDT.Rows[0][concc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做(字段类型:bit,字段长度:1,是否可空:False)
 objcc_WorkStuRelation4GoodLibEN.RedoDate = objDT.Rows[0][concc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期(字段类型:varchar,字段长度:8,是否可空:True)
 objcc_WorkStuRelation4GoodLibEN.IsPassed = TransNullToBool(objDT.Rows[0][concc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过(字段类型:bit,字段长度:1,是否可空:False)
 objcc_WorkStuRelation4GoodLibEN.UpdDate = objDT.Rows[0][concc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkStuRelation4GoodLibEN.UpdUser = objDT.Rows[0][concc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkStuRelation4GoodLibEN.Memo = objDT.Rows[0][concc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_WorkStuRelation4GoodLibDA: Getcc_WorkStuRelation4GoodLib)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clscc_WorkStuRelation4GoodLibEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation4GoodLib where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN = new clscc_WorkStuRelation4GoodLibEN();
try
{
 objcc_WorkStuRelation4GoodLibEN.mId = Int32.Parse(objRow[concc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_WorkStuRelation4GoodLibEN.CourseId = objRow[concc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[concc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_WorkStuRelation4GoodLibEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation4GoodLib.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_WorkStuRelation4GoodLibEN.Creator = objRow[concc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者(字段类型:varchar,字段长度:18,是否可空:True)
 objcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[concc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[concc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objcc_WorkStuRelation4GoodLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做(字段类型:bit,字段长度:1,是否可空:False)
 objcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[concc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期(字段类型:varchar,字段长度:8,是否可空:True)
 objcc_WorkStuRelation4GoodLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过(字段类型:bit,字段长度:1,是否可空:False)
 objcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[concc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[concc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkStuRelation4GoodLibEN.Memo = objRow[concc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_WorkStuRelation4GoodLibDA: GetObjBymId)", objException.Message));
}
return objcc_WorkStuRelation4GoodLibEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_WorkStuRelation4GoodLibEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_WorkStuRelation4GoodLibDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation4GoodLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN = new clscc_WorkStuRelation4GoodLibEN()
{
mId = TransNullToInt(objRow[concc_WorkStuRelation4GoodLib.mId].ToString().Trim()), //mId
CourseId = objRow[concc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(), //课程Id
IdStudentInfo = objRow[concc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(), //学生流水号
QuestionId = TransNullToInt(objRow[concc_WorkStuRelation4GoodLib.QuestionId].ToString().Trim()), //题目Id
Creator = objRow[concc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.Creator].ToString().Trim(), //创建者
CreateDate = objRow[concc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(), //建立日期
SourceTypeId = objRow[concc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(), //来源类型Id
IsRedo = TransNullToBool(objRow[concc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()), //是否重做
RedoDate = objRow[concc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(), //重做日期
IsPassed = TransNullToBool(objRow[concc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()), //是否通过
UpdDate = objRow[concc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[concc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(), //修改人
Memo = objRow[concc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.Memo].ToString().Trim() //备注
};
objcc_WorkStuRelation4GoodLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_WorkStuRelation4GoodLibEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_WorkStuRelation4GoodLibDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_WorkStuRelation4GoodLibEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN = new clscc_WorkStuRelation4GoodLibEN();
try
{
objcc_WorkStuRelation4GoodLibEN.mId = TransNullToInt(objRow[concc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objcc_WorkStuRelation4GoodLibEN.CourseId = objRow[concc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[concc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation4GoodLibEN.QuestionId = TransNullToInt(objRow[concc_WorkStuRelation4GoodLib.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelation4GoodLibEN.Creator = objRow[concc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[concc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[concc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objcc_WorkStuRelation4GoodLibEN.IsRedo = TransNullToBool(objRow[concc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[concc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objcc_WorkStuRelation4GoodLibEN.IsPassed = TransNullToBool(objRow[concc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[concc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[concc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objcc_WorkStuRelation4GoodLibEN.Memo = objRow[concc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_WorkStuRelation4GoodLibDA: GetObjByDataRowcc_WorkStuRelation4GoodLib)", objException.Message));
}
objcc_WorkStuRelation4GoodLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_WorkStuRelation4GoodLibEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_WorkStuRelation4GoodLibEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN = new clscc_WorkStuRelation4GoodLibEN();
try
{
objcc_WorkStuRelation4GoodLibEN.mId = TransNullToInt(objRow[concc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objcc_WorkStuRelation4GoodLibEN.CourseId = objRow[concc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[concc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation4GoodLibEN.QuestionId = TransNullToInt(objRow[concc_WorkStuRelation4GoodLib.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelation4GoodLibEN.Creator = objRow[concc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[concc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[concc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objcc_WorkStuRelation4GoodLibEN.IsRedo = TransNullToBool(objRow[concc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[concc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objcc_WorkStuRelation4GoodLibEN.IsPassed = TransNullToBool(objRow[concc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[concc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[concc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objcc_WorkStuRelation4GoodLibEN.Memo = objRow[concc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_WorkStuRelation4GoodLibDA: GetObjByDataRow)", objException.Message));
}
objcc_WorkStuRelation4GoodLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_WorkStuRelation4GoodLibEN;
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
objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_WorkStuRelation4GoodLibEN._CurrTabName, concc_WorkStuRelation4GoodLib.mId, 8, "");
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
objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_WorkStuRelation4GoodLibEN._CurrTabName, concc_WorkStuRelation4GoodLib.mId, 8, strPrefix);
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
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from cc_WorkStuRelation4GoodLib where " + strCondition;
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
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from cc_WorkStuRelation4GoodLib where " + strCondition;
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
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_WorkStuRelation4GoodLib", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_WorkStuRelation4GoodLibDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_WorkStuRelation4GoodLib", strCondition))
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
objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_WorkStuRelation4GoodLib");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
 {
 objcc_WorkStuRelation4GoodLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelation4GoodLibEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkStuRelation4GoodLibEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation4GoodLib where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_WorkStuRelation4GoodLib");
objRow = objDS.Tables["cc_WorkStuRelation4GoodLib"].NewRow();
objRow[concc_WorkStuRelation4GoodLib.CourseId] = objcc_WorkStuRelation4GoodLibEN.CourseId; //课程Id
objRow[concc_WorkStuRelation4GoodLib.IdStudentInfo] = objcc_WorkStuRelation4GoodLibEN.IdStudentInfo; //学生流水号
objRow[concc_WorkStuRelation4GoodLib.QuestionId] = objcc_WorkStuRelation4GoodLibEN.QuestionId; //题目Id
 if (objcc_WorkStuRelation4GoodLibEN.Creator !=  "")
 {
objRow[concc_WorkStuRelation4GoodLib.Creator] = objcc_WorkStuRelation4GoodLibEN.Creator; //创建者
 }
 if (objcc_WorkStuRelation4GoodLibEN.CreateDate !=  "")
 {
objRow[concc_WorkStuRelation4GoodLib.CreateDate] = objcc_WorkStuRelation4GoodLibEN.CreateDate; //建立日期
 }
objRow[concc_WorkStuRelation4GoodLib.SourceTypeId] = objcc_WorkStuRelation4GoodLibEN.SourceTypeId; //来源类型Id
objRow[concc_WorkStuRelation4GoodLib.IsRedo] = objcc_WorkStuRelation4GoodLibEN.IsRedo; //是否重做
 if (objcc_WorkStuRelation4GoodLibEN.RedoDate !=  "")
 {
objRow[concc_WorkStuRelation4GoodLib.RedoDate] = objcc_WorkStuRelation4GoodLibEN.RedoDate; //重做日期
 }
objRow[concc_WorkStuRelation4GoodLib.IsPassed] = objcc_WorkStuRelation4GoodLibEN.IsPassed; //是否通过
 if (objcc_WorkStuRelation4GoodLibEN.UpdDate !=  "")
 {
objRow[concc_WorkStuRelation4GoodLib.UpdDate] = objcc_WorkStuRelation4GoodLibEN.UpdDate; //修改日期
 }
 if (objcc_WorkStuRelation4GoodLibEN.UpdUser !=  "")
 {
objRow[concc_WorkStuRelation4GoodLib.UpdUser] = objcc_WorkStuRelation4GoodLibEN.UpdUser; //修改人
 }
 if (objcc_WorkStuRelation4GoodLibEN.Memo !=  "")
 {
objRow[concc_WorkStuRelation4GoodLib.Memo] = objcc_WorkStuRelation4GoodLibEN.Memo; //备注
 }
objDS.Tables[clscc_WorkStuRelation4GoodLibEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_WorkStuRelation4GoodLibEN._CurrTabName);
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
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
{
 objcc_WorkStuRelation4GoodLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelation4GoodLibEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkStuRelation4GoodLibEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_WorkStuRelation4GoodLibEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.CourseId);
 var strCourseId = objcc_WorkStuRelation4GoodLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.IdStudentInfo);
 var strIdStudentInfo = objcc_WorkStuRelation4GoodLibEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.QuestionId);
 arrValueListForInsert.Add(objcc_WorkStuRelation4GoodLibEN.QuestionId.ToString());
 
 if (objcc_WorkStuRelation4GoodLibEN.Creator !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.Creator);
 var strCreator = objcc_WorkStuRelation4GoodLibEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreator + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.CreateDate);
 var strCreateDate = objcc_WorkStuRelation4GoodLibEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.SourceTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.SourceTypeId);
 var strSourceTypeId = objcc_WorkStuRelation4GoodLibEN.SourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceTypeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.IsRedo);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelation4GoodLibEN.IsRedo  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelation4GoodLibEN.RedoDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.RedoDate);
 var strRedoDate = objcc_WorkStuRelation4GoodLibEN.RedoDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRedoDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.IsPassed);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelation4GoodLibEN.IsPassed  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelation4GoodLibEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.UpdDate);
 var strUpdDate = objcc_WorkStuRelation4GoodLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.UpdUser);
 var strUpdUser = objcc_WorkStuRelation4GoodLibEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.Memo);
 var strMemo = objcc_WorkStuRelation4GoodLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_WorkStuRelation4GoodLib");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
{
 objcc_WorkStuRelation4GoodLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelation4GoodLibEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkStuRelation4GoodLibEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_WorkStuRelation4GoodLibEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.CourseId);
 var strCourseId = objcc_WorkStuRelation4GoodLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.IdStudentInfo);
 var strIdStudentInfo = objcc_WorkStuRelation4GoodLibEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.QuestionId);
 arrValueListForInsert.Add(objcc_WorkStuRelation4GoodLibEN.QuestionId.ToString());
 
 if (objcc_WorkStuRelation4GoodLibEN.Creator !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.Creator);
 var strCreator = objcc_WorkStuRelation4GoodLibEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreator + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.CreateDate);
 var strCreateDate = objcc_WorkStuRelation4GoodLibEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.SourceTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.SourceTypeId);
 var strSourceTypeId = objcc_WorkStuRelation4GoodLibEN.SourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceTypeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.IsRedo);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelation4GoodLibEN.IsRedo  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelation4GoodLibEN.RedoDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.RedoDate);
 var strRedoDate = objcc_WorkStuRelation4GoodLibEN.RedoDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRedoDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.IsPassed);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelation4GoodLibEN.IsPassed  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelation4GoodLibEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.UpdDate);
 var strUpdDate = objcc_WorkStuRelation4GoodLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.UpdUser);
 var strUpdUser = objcc_WorkStuRelation4GoodLibEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.Memo);
 var strMemo = objcc_WorkStuRelation4GoodLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_WorkStuRelation4GoodLib");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_WorkStuRelation4GoodLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelation4GoodLibEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkStuRelation4GoodLibEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_WorkStuRelation4GoodLibEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.CourseId);
 var strCourseId = objcc_WorkStuRelation4GoodLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.IdStudentInfo);
 var strIdStudentInfo = objcc_WorkStuRelation4GoodLibEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.QuestionId);
 arrValueListForInsert.Add(objcc_WorkStuRelation4GoodLibEN.QuestionId.ToString());
 
 if (objcc_WorkStuRelation4GoodLibEN.Creator !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.Creator);
 var strCreator = objcc_WorkStuRelation4GoodLibEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreator + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.CreateDate);
 var strCreateDate = objcc_WorkStuRelation4GoodLibEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.SourceTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.SourceTypeId);
 var strSourceTypeId = objcc_WorkStuRelation4GoodLibEN.SourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceTypeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.IsRedo);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelation4GoodLibEN.IsRedo  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelation4GoodLibEN.RedoDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.RedoDate);
 var strRedoDate = objcc_WorkStuRelation4GoodLibEN.RedoDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRedoDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.IsPassed);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelation4GoodLibEN.IsPassed  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelation4GoodLibEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.UpdDate);
 var strUpdDate = objcc_WorkStuRelation4GoodLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.UpdUser);
 var strUpdUser = objcc_WorkStuRelation4GoodLibEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.Memo);
 var strMemo = objcc_WorkStuRelation4GoodLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_WorkStuRelation4GoodLib");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_WorkStuRelation4GoodLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelation4GoodLibEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkStuRelation4GoodLibEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_WorkStuRelation4GoodLibEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.CourseId);
 var strCourseId = objcc_WorkStuRelation4GoodLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.IdStudentInfo);
 var strIdStudentInfo = objcc_WorkStuRelation4GoodLibEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.QuestionId);
 arrValueListForInsert.Add(objcc_WorkStuRelation4GoodLibEN.QuestionId.ToString());
 
 if (objcc_WorkStuRelation4GoodLibEN.Creator !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.Creator);
 var strCreator = objcc_WorkStuRelation4GoodLibEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreator + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.CreateDate);
 var strCreateDate = objcc_WorkStuRelation4GoodLibEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.SourceTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.SourceTypeId);
 var strSourceTypeId = objcc_WorkStuRelation4GoodLibEN.SourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceTypeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.IsRedo);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelation4GoodLibEN.IsRedo  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelation4GoodLibEN.RedoDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.RedoDate);
 var strRedoDate = objcc_WorkStuRelation4GoodLibEN.RedoDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRedoDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.IsPassed);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelation4GoodLibEN.IsPassed  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelation4GoodLibEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.UpdDate);
 var strUpdDate = objcc_WorkStuRelation4GoodLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.UpdUser);
 var strUpdUser = objcc_WorkStuRelation4GoodLibEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation4GoodLib.Memo);
 var strMemo = objcc_WorkStuRelation4GoodLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_WorkStuRelation4GoodLib");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_WorkStuRelation4GoodLibs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation4GoodLib where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_WorkStuRelation4GoodLib");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_WorkStuRelation4GoodLibEN._CurrTabName ].NewRow();
objRow[concc_WorkStuRelation4GoodLib.CourseId] = oRow[concc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objRow[concc_WorkStuRelation4GoodLib.IdStudentInfo] = oRow[concc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objRow[concc_WorkStuRelation4GoodLib.QuestionId] = oRow[concc_WorkStuRelation4GoodLib.QuestionId].ToString().Trim(); //题目Id
objRow[concc_WorkStuRelation4GoodLib.Creator] = oRow[concc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objRow[concc_WorkStuRelation4GoodLib.CreateDate] = oRow[concc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objRow[concc_WorkStuRelation4GoodLib.SourceTypeId] = oRow[concc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objRow[concc_WorkStuRelation4GoodLib.IsRedo] = oRow[concc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim(); //是否重做
objRow[concc_WorkStuRelation4GoodLib.RedoDate] = oRow[concc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objRow[concc_WorkStuRelation4GoodLib.IsPassed] = oRow[concc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim(); //是否通过
objRow[concc_WorkStuRelation4GoodLib.UpdDate] = oRow[concc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objRow[concc_WorkStuRelation4GoodLib.UpdUser] = oRow[concc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objRow[concc_WorkStuRelation4GoodLib.Memo] = oRow[concc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_WorkStuRelation4GoodLibEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_WorkStuRelation4GoodLibEN._CurrTabName);
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
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
{
 objcc_WorkStuRelation4GoodLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelation4GoodLibEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkStuRelation4GoodLibEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation4GoodLib where mId = " + ""+ objcc_WorkStuRelation4GoodLibEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_WorkStuRelation4GoodLibEN._CurrTabName);
if (objDS.Tables[clscc_WorkStuRelation4GoodLibEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objcc_WorkStuRelation4GoodLibEN.mId+"");
return false;
}
objRow = objDS.Tables[clscc_WorkStuRelation4GoodLibEN._CurrTabName].Rows[0];
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.CourseId))
 {
objRow[concc_WorkStuRelation4GoodLib.CourseId] = objcc_WorkStuRelation4GoodLibEN.CourseId; //课程Id
 }
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.IdStudentInfo))
 {
objRow[concc_WorkStuRelation4GoodLib.IdStudentInfo] = objcc_WorkStuRelation4GoodLibEN.IdStudentInfo; //学生流水号
 }
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.QuestionId))
 {
objRow[concc_WorkStuRelation4GoodLib.QuestionId] = objcc_WorkStuRelation4GoodLibEN.QuestionId; //题目Id
 }
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.Creator))
 {
objRow[concc_WorkStuRelation4GoodLib.Creator] = objcc_WorkStuRelation4GoodLibEN.Creator; //创建者
 }
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.CreateDate))
 {
objRow[concc_WorkStuRelation4GoodLib.CreateDate] = objcc_WorkStuRelation4GoodLibEN.CreateDate; //建立日期
 }
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.SourceTypeId))
 {
objRow[concc_WorkStuRelation4GoodLib.SourceTypeId] = objcc_WorkStuRelation4GoodLibEN.SourceTypeId; //来源类型Id
 }
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.IsRedo))
 {
objRow[concc_WorkStuRelation4GoodLib.IsRedo] = objcc_WorkStuRelation4GoodLibEN.IsRedo; //是否重做
 }
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.RedoDate))
 {
objRow[concc_WorkStuRelation4GoodLib.RedoDate] = objcc_WorkStuRelation4GoodLibEN.RedoDate; //重做日期
 }
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.IsPassed))
 {
objRow[concc_WorkStuRelation4GoodLib.IsPassed] = objcc_WorkStuRelation4GoodLibEN.IsPassed; //是否通过
 }
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.UpdDate))
 {
objRow[concc_WorkStuRelation4GoodLib.UpdDate] = objcc_WorkStuRelation4GoodLibEN.UpdDate; //修改日期
 }
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.UpdUser))
 {
objRow[concc_WorkStuRelation4GoodLib.UpdUser] = objcc_WorkStuRelation4GoodLibEN.UpdUser; //修改人
 }
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.Memo))
 {
objRow[concc_WorkStuRelation4GoodLib.Memo] = objcc_WorkStuRelation4GoodLibEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_WorkStuRelation4GoodLibEN._CurrTabName);
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
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
{
 objcc_WorkStuRelation4GoodLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelation4GoodLibEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkStuRelation4GoodLibEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_WorkStuRelation4GoodLib Set ");
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.CourseId))
 {
 if (objcc_WorkStuRelation4GoodLibEN.CourseId !=  null)
 {
 var strCourseId = objcc_WorkStuRelation4GoodLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_WorkStuRelation4GoodLib.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.CourseId); //课程Id
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.IdStudentInfo))
 {
 if (objcc_WorkStuRelation4GoodLibEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objcc_WorkStuRelation4GoodLibEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudentInfo, concc_WorkStuRelation4GoodLib.IdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.IdStudentInfo); //学生流水号
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkStuRelation4GoodLibEN.QuestionId, concc_WorkStuRelation4GoodLib.QuestionId); //题目Id
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.Creator))
 {
 if (objcc_WorkStuRelation4GoodLibEN.Creator !=  null)
 {
 var strCreator = objcc_WorkStuRelation4GoodLibEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreator, concc_WorkStuRelation4GoodLib.Creator); //创建者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.Creator); //创建者
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.CreateDate))
 {
 if (objcc_WorkStuRelation4GoodLibEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_WorkStuRelation4GoodLibEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, concc_WorkStuRelation4GoodLib.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.CreateDate); //建立日期
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.SourceTypeId))
 {
 if (objcc_WorkStuRelation4GoodLibEN.SourceTypeId !=  null)
 {
 var strSourceTypeId = objcc_WorkStuRelation4GoodLibEN.SourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceTypeId, concc_WorkStuRelation4GoodLib.SourceTypeId); //来源类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.SourceTypeId); //来源类型Id
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.IsRedo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelation4GoodLibEN.IsRedo == true?"1":"0", concc_WorkStuRelation4GoodLib.IsRedo); //是否重做
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.RedoDate))
 {
 if (objcc_WorkStuRelation4GoodLibEN.RedoDate !=  null)
 {
 var strRedoDate = objcc_WorkStuRelation4GoodLibEN.RedoDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRedoDate, concc_WorkStuRelation4GoodLib.RedoDate); //重做日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.RedoDate); //重做日期
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.IsPassed))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelation4GoodLibEN.IsPassed == true?"1":"0", concc_WorkStuRelation4GoodLib.IsPassed); //是否通过
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.UpdDate))
 {
 if (objcc_WorkStuRelation4GoodLibEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkStuRelation4GoodLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_WorkStuRelation4GoodLib.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.UpdDate); //修改日期
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.UpdUser))
 {
 if (objcc_WorkStuRelation4GoodLibEN.UpdUser !=  null)
 {
 var strUpdUser = objcc_WorkStuRelation4GoodLibEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, concc_WorkStuRelation4GoodLib.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.UpdUser); //修改人
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.Memo))
 {
 if (objcc_WorkStuRelation4GoodLibEN.Memo !=  null)
 {
 var strMemo = objcc_WorkStuRelation4GoodLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_WorkStuRelation4GoodLib.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objcc_WorkStuRelation4GoodLibEN.mId); 
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
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, string strCondition)
{
 objcc_WorkStuRelation4GoodLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelation4GoodLibEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkStuRelation4GoodLibEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_WorkStuRelation4GoodLib Set ");
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.CourseId))
 {
 if (objcc_WorkStuRelation4GoodLibEN.CourseId !=  null)
 {
 var strCourseId = objcc_WorkStuRelation4GoodLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.IdStudentInfo))
 {
 if (objcc_WorkStuRelation4GoodLibEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objcc_WorkStuRelation4GoodLibEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudentInfo = '{0}',", strIdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.Append(" IdStudentInfo = null,"); //学生流水号
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objcc_WorkStuRelation4GoodLibEN.QuestionId); //题目Id
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.Creator))
 {
 if (objcc_WorkStuRelation4GoodLibEN.Creator !=  null)
 {
 var strCreator = objcc_WorkStuRelation4GoodLibEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Creator = '{0}',", strCreator); //创建者
 }
 else
 {
 sbSQL.Append(" Creator = null,"); //创建者
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.CreateDate))
 {
 if (objcc_WorkStuRelation4GoodLibEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_WorkStuRelation4GoodLibEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.SourceTypeId))
 {
 if (objcc_WorkStuRelation4GoodLibEN.SourceTypeId !=  null)
 {
 var strSourceTypeId = objcc_WorkStuRelation4GoodLibEN.SourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceTypeId = '{0}',", strSourceTypeId); //来源类型Id
 }
 else
 {
 sbSQL.Append(" SourceTypeId = null,"); //来源类型Id
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.IsRedo))
 {
 sbSQL.AppendFormat(" IsRedo = '{0}',", objcc_WorkStuRelation4GoodLibEN.IsRedo == true?"1":"0"); //是否重做
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.RedoDate))
 {
 if (objcc_WorkStuRelation4GoodLibEN.RedoDate !=  null)
 {
 var strRedoDate = objcc_WorkStuRelation4GoodLibEN.RedoDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RedoDate = '{0}',", strRedoDate); //重做日期
 }
 else
 {
 sbSQL.Append(" RedoDate = null,"); //重做日期
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.IsPassed))
 {
 sbSQL.AppendFormat(" IsPassed = '{0}',", objcc_WorkStuRelation4GoodLibEN.IsPassed == true?"1":"0"); //是否通过
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.UpdDate))
 {
 if (objcc_WorkStuRelation4GoodLibEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkStuRelation4GoodLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.UpdUser))
 {
 if (objcc_WorkStuRelation4GoodLibEN.UpdUser !=  null)
 {
 var strUpdUser = objcc_WorkStuRelation4GoodLibEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.Memo))
 {
 if (objcc_WorkStuRelation4GoodLibEN.Memo !=  null)
 {
 var strMemo = objcc_WorkStuRelation4GoodLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_WorkStuRelation4GoodLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelation4GoodLibEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkStuRelation4GoodLibEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_WorkStuRelation4GoodLib Set ");
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.CourseId))
 {
 if (objcc_WorkStuRelation4GoodLibEN.CourseId !=  null)
 {
 var strCourseId = objcc_WorkStuRelation4GoodLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.IdStudentInfo))
 {
 if (objcc_WorkStuRelation4GoodLibEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objcc_WorkStuRelation4GoodLibEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudentInfo = '{0}',", strIdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.Append(" IdStudentInfo = null,"); //学生流水号
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objcc_WorkStuRelation4GoodLibEN.QuestionId); //题目Id
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.Creator))
 {
 if (objcc_WorkStuRelation4GoodLibEN.Creator !=  null)
 {
 var strCreator = objcc_WorkStuRelation4GoodLibEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Creator = '{0}',", strCreator); //创建者
 }
 else
 {
 sbSQL.Append(" Creator = null,"); //创建者
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.CreateDate))
 {
 if (objcc_WorkStuRelation4GoodLibEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_WorkStuRelation4GoodLibEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.SourceTypeId))
 {
 if (objcc_WorkStuRelation4GoodLibEN.SourceTypeId !=  null)
 {
 var strSourceTypeId = objcc_WorkStuRelation4GoodLibEN.SourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceTypeId = '{0}',", strSourceTypeId); //来源类型Id
 }
 else
 {
 sbSQL.Append(" SourceTypeId = null,"); //来源类型Id
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.IsRedo))
 {
 sbSQL.AppendFormat(" IsRedo = '{0}',", objcc_WorkStuRelation4GoodLibEN.IsRedo == true?"1":"0"); //是否重做
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.RedoDate))
 {
 if (objcc_WorkStuRelation4GoodLibEN.RedoDate !=  null)
 {
 var strRedoDate = objcc_WorkStuRelation4GoodLibEN.RedoDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RedoDate = '{0}',", strRedoDate); //重做日期
 }
 else
 {
 sbSQL.Append(" RedoDate = null,"); //重做日期
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.IsPassed))
 {
 sbSQL.AppendFormat(" IsPassed = '{0}',", objcc_WorkStuRelation4GoodLibEN.IsPassed == true?"1":"0"); //是否通过
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.UpdDate))
 {
 if (objcc_WorkStuRelation4GoodLibEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkStuRelation4GoodLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.UpdUser))
 {
 if (objcc_WorkStuRelation4GoodLibEN.UpdUser !=  null)
 {
 var strUpdUser = objcc_WorkStuRelation4GoodLibEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.Memo))
 {
 if (objcc_WorkStuRelation4GoodLibEN.Memo !=  null)
 {
 var strMemo = objcc_WorkStuRelation4GoodLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_WorkStuRelation4GoodLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelation4GoodLibEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkStuRelation4GoodLibEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_WorkStuRelation4GoodLib Set ");
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.CourseId))
 {
 if (objcc_WorkStuRelation4GoodLibEN.CourseId !=  null)
 {
 var strCourseId = objcc_WorkStuRelation4GoodLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_WorkStuRelation4GoodLib.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.CourseId); //课程Id
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.IdStudentInfo))
 {
 if (objcc_WorkStuRelation4GoodLibEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objcc_WorkStuRelation4GoodLibEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudentInfo, concc_WorkStuRelation4GoodLib.IdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.IdStudentInfo); //学生流水号
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkStuRelation4GoodLibEN.QuestionId, concc_WorkStuRelation4GoodLib.QuestionId); //题目Id
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.Creator))
 {
 if (objcc_WorkStuRelation4GoodLibEN.Creator !=  null)
 {
 var strCreator = objcc_WorkStuRelation4GoodLibEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreator, concc_WorkStuRelation4GoodLib.Creator); //创建者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.Creator); //创建者
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.CreateDate))
 {
 if (objcc_WorkStuRelation4GoodLibEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_WorkStuRelation4GoodLibEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, concc_WorkStuRelation4GoodLib.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.CreateDate); //建立日期
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.SourceTypeId))
 {
 if (objcc_WorkStuRelation4GoodLibEN.SourceTypeId !=  null)
 {
 var strSourceTypeId = objcc_WorkStuRelation4GoodLibEN.SourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceTypeId, concc_WorkStuRelation4GoodLib.SourceTypeId); //来源类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.SourceTypeId); //来源类型Id
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.IsRedo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelation4GoodLibEN.IsRedo == true?"1":"0", concc_WorkStuRelation4GoodLib.IsRedo); //是否重做
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.RedoDate))
 {
 if (objcc_WorkStuRelation4GoodLibEN.RedoDate !=  null)
 {
 var strRedoDate = objcc_WorkStuRelation4GoodLibEN.RedoDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRedoDate, concc_WorkStuRelation4GoodLib.RedoDate); //重做日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.RedoDate); //重做日期
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.IsPassed))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelation4GoodLibEN.IsPassed == true?"1":"0", concc_WorkStuRelation4GoodLib.IsPassed); //是否通过
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.UpdDate))
 {
 if (objcc_WorkStuRelation4GoodLibEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkStuRelation4GoodLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_WorkStuRelation4GoodLib.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.UpdDate); //修改日期
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.UpdUser))
 {
 if (objcc_WorkStuRelation4GoodLibEN.UpdUser !=  null)
 {
 var strUpdUser = objcc_WorkStuRelation4GoodLibEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, concc_WorkStuRelation4GoodLib.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.UpdUser); //修改人
 }
 }
 
 if (objcc_WorkStuRelation4GoodLibEN.IsUpdated(concc_WorkStuRelation4GoodLib.Memo))
 {
 if (objcc_WorkStuRelation4GoodLibEN.Memo !=  null)
 {
 var strMemo = objcc_WorkStuRelation4GoodLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_WorkStuRelation4GoodLib.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation4GoodLib.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objcc_WorkStuRelation4GoodLibEN.mId); 
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
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("cc_WorkStuRelation4GoodLib_Delete", values);
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
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
//删除cc_WorkStuRelation4GoodLib本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_WorkStuRelation4GoodLib where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_WorkStuRelation4GoodLib(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
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
//删除cc_WorkStuRelation4GoodLib本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_WorkStuRelation4GoodLib where mId in (" + strKeyList + ")";
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
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
//删除cc_WorkStuRelation4GoodLib本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_WorkStuRelation4GoodLib where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_WorkStuRelation4GoodLib(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_WorkStuRelation4GoodLibDA: Delcc_WorkStuRelation4GoodLib)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_WorkStuRelation4GoodLib where " + strCondition ;
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
public bool Delcc_WorkStuRelation4GoodLibWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_WorkStuRelation4GoodLibDA: Delcc_WorkStuRelation4GoodLibWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_WorkStuRelation4GoodLib where " + strCondition ;
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
 /// <param name = "objcc_WorkStuRelation4GoodLibENS">源对象</param>
 /// <param name = "objcc_WorkStuRelation4GoodLibENT">目标对象</param>
public void CopyTo(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibENS, clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibENT)
{
objcc_WorkStuRelation4GoodLibENT.mId = objcc_WorkStuRelation4GoodLibENS.mId; //mId
objcc_WorkStuRelation4GoodLibENT.CourseId = objcc_WorkStuRelation4GoodLibENS.CourseId; //课程Id
objcc_WorkStuRelation4GoodLibENT.IdStudentInfo = objcc_WorkStuRelation4GoodLibENS.IdStudentInfo; //学生流水号
objcc_WorkStuRelation4GoodLibENT.QuestionId = objcc_WorkStuRelation4GoodLibENS.QuestionId; //题目Id
objcc_WorkStuRelation4GoodLibENT.Creator = objcc_WorkStuRelation4GoodLibENS.Creator; //创建者
objcc_WorkStuRelation4GoodLibENT.CreateDate = objcc_WorkStuRelation4GoodLibENS.CreateDate; //建立日期
objcc_WorkStuRelation4GoodLibENT.SourceTypeId = objcc_WorkStuRelation4GoodLibENS.SourceTypeId; //来源类型Id
objcc_WorkStuRelation4GoodLibENT.IsRedo = objcc_WorkStuRelation4GoodLibENS.IsRedo; //是否重做
objcc_WorkStuRelation4GoodLibENT.RedoDate = objcc_WorkStuRelation4GoodLibENS.RedoDate; //重做日期
objcc_WorkStuRelation4GoodLibENT.IsPassed = objcc_WorkStuRelation4GoodLibENS.IsPassed; //是否通过
objcc_WorkStuRelation4GoodLibENT.UpdDate = objcc_WorkStuRelation4GoodLibENS.UpdDate; //修改日期
objcc_WorkStuRelation4GoodLibENT.UpdUser = objcc_WorkStuRelation4GoodLibENS.UpdUser; //修改人
objcc_WorkStuRelation4GoodLibENT.Memo = objcc_WorkStuRelation4GoodLibENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_WorkStuRelation4GoodLibEN.CourseId, concc_WorkStuRelation4GoodLib.CourseId);
clsCheckSql.CheckFieldNotNull(objcc_WorkStuRelation4GoodLibEN.IdStudentInfo, concc_WorkStuRelation4GoodLib.IdStudentInfo);
clsCheckSql.CheckFieldNotNull(objcc_WorkStuRelation4GoodLibEN.QuestionId, concc_WorkStuRelation4GoodLib.QuestionId);
clsCheckSql.CheckFieldNotNull(objcc_WorkStuRelation4GoodLibEN.SourceTypeId, concc_WorkStuRelation4GoodLib.SourceTypeId);
clsCheckSql.CheckFieldNotNull(objcc_WorkStuRelation4GoodLibEN.IsRedo, concc_WorkStuRelation4GoodLib.IsRedo);
clsCheckSql.CheckFieldNotNull(objcc_WorkStuRelation4GoodLibEN.IsPassed, concc_WorkStuRelation4GoodLib.IsPassed);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.CourseId, 8, concc_WorkStuRelation4GoodLib.CourseId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.IdStudentInfo, 8, concc_WorkStuRelation4GoodLib.IdStudentInfo);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.Creator, 18, concc_WorkStuRelation4GoodLib.Creator);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.CreateDate, 20, concc_WorkStuRelation4GoodLib.CreateDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.SourceTypeId, 2, concc_WorkStuRelation4GoodLib.SourceTypeId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.RedoDate, 8, concc_WorkStuRelation4GoodLib.RedoDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.UpdDate, 20, concc_WorkStuRelation4GoodLib.UpdDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.UpdUser, 20, concc_WorkStuRelation4GoodLib.UpdUser);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.Memo, 1000, concc_WorkStuRelation4GoodLib.Memo);
//检查字段外键固定长度
 objcc_WorkStuRelation4GoodLibEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.CourseId, 8, concc_WorkStuRelation4GoodLib.CourseId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.IdStudentInfo, 8, concc_WorkStuRelation4GoodLib.IdStudentInfo);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.Creator, 18, concc_WorkStuRelation4GoodLib.Creator);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.CreateDate, 20, concc_WorkStuRelation4GoodLib.CreateDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.SourceTypeId, 2, concc_WorkStuRelation4GoodLib.SourceTypeId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.RedoDate, 8, concc_WorkStuRelation4GoodLib.RedoDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.UpdDate, 20, concc_WorkStuRelation4GoodLib.UpdDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.UpdUser, 20, concc_WorkStuRelation4GoodLib.UpdUser);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.Memo, 1000, concc_WorkStuRelation4GoodLib.Memo);
//检查外键字段长度
 objcc_WorkStuRelation4GoodLibEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.CourseId, 8, concc_WorkStuRelation4GoodLib.CourseId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.IdStudentInfo, 8, concc_WorkStuRelation4GoodLib.IdStudentInfo);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.Creator, 18, concc_WorkStuRelation4GoodLib.Creator);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.CreateDate, 20, concc_WorkStuRelation4GoodLib.CreateDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.SourceTypeId, 2, concc_WorkStuRelation4GoodLib.SourceTypeId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.RedoDate, 8, concc_WorkStuRelation4GoodLib.RedoDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.UpdDate, 20, concc_WorkStuRelation4GoodLib.UpdDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.UpdUser, 20, concc_WorkStuRelation4GoodLib.UpdUser);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelation4GoodLibEN.Memo, 1000, concc_WorkStuRelation4GoodLib.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelation4GoodLibEN.CourseId, concc_WorkStuRelation4GoodLib.CourseId);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelation4GoodLibEN.IdStudentInfo, concc_WorkStuRelation4GoodLib.IdStudentInfo);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelation4GoodLibEN.Creator, concc_WorkStuRelation4GoodLib.Creator);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelation4GoodLibEN.CreateDate, concc_WorkStuRelation4GoodLib.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelation4GoodLibEN.SourceTypeId, concc_WorkStuRelation4GoodLib.SourceTypeId);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelation4GoodLibEN.RedoDate, concc_WorkStuRelation4GoodLib.RedoDate);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelation4GoodLibEN.UpdDate, concc_WorkStuRelation4GoodLib.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelation4GoodLibEN.UpdUser, concc_WorkStuRelation4GoodLib.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelation4GoodLibEN.Memo, concc_WorkStuRelation4GoodLib.Memo);
//检查外键字段长度
 objcc_WorkStuRelation4GoodLibEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_WorkStuRelation4GoodLib(学生好题集),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_WorkStuRelation4GoodLibEN.QuestionId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_WorkStuRelation4GoodLibEN.IdStudentInfo);
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
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
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
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
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
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_WorkStuRelation4GoodLibEN._CurrTabName);
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
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_WorkStuRelation4GoodLibEN._CurrTabName, strCondition);
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
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
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
 objSQL = clscc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}