﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_UserGroupDA
 表名:zx_UserGroup(01120731)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:00:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
 /// 中学用户小组(zx_UserGroup)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_UserGroupDA : clsCommBase4DA
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
 return clszx_UserGroupEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_UserGroupEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_UserGroupEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_UserGroupEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_UserGroupEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_UserGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from zx_UserGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_UserGroup(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_UserGroupDA: GetDataTable_zx_UserGroup)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from zx_UserGroup where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_UserGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_UserGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from zx_UserGroup where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_UserGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_UserGroupDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_UserGroup where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_UserGroup where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_UserGroupDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_UserGroup where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_UserGroupDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_UserGroup.* from zx_UserGroup Left Join {1} on {2} where {3} and zx_UserGroup.mId not in (Select top {5} zx_UserGroup.mId from zx_UserGroup Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_UserGroup where {1} and mId not in (Select top {2} mId from zx_UserGroup where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_UserGroup where {1} and mId not in (Select top {3} mId from zx_UserGroup where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_UserGroupDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_UserGroup.* from zx_UserGroup Left Join {1} on {2} where {3} and zx_UserGroup.mId not in (Select top {5} zx_UserGroup.mId from zx_UserGroup Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_UserGroup where {1} and mId not in (Select top {2} mId from zx_UserGroup where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_UserGroup where {1} and mId not in (Select top {3} mId from zx_UserGroup where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_UserGroupEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_UserGroupDA:GetObjLst)", objException.Message));
}
List<clszx_UserGroupEN> arrObjLst = new List<clszx_UserGroupEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from zx_UserGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_UserGroupEN objzx_UserGroupEN = new clszx_UserGroupEN();
try
{
objzx_UserGroupEN.mId = TransNullToInt(objRow[conzx_UserGroup.mId].ToString().Trim()); //mId
objzx_UserGroupEN.UserId = objRow[conzx_UserGroup.UserId] == DBNull.Value ? null : objRow[conzx_UserGroup.UserId].ToString().Trim(); //用户ID
objzx_UserGroupEN.UpdDate = objRow[conzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[conzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objzx_UserGroupEN.UpdUser = objRow[conzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[conzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objzx_UserGroupEN.Memo = objRow[conzx_UserGroup.Memo] == DBNull.Value ? null : objRow[conzx_UserGroup.Memo].ToString().Trim(); //备注
objzx_UserGroupEN.zxTopicUserRoleId = objRow[conzx_UserGroup.zxTopicUserRoleId] == DBNull.Value ? null : objRow[conzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objzx_UserGroupEN.GroupTextId = objRow[conzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[conzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objzx_UserGroupEN.OrderNum = objRow[conzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_UserGroup.OrderNum].ToString().Trim()); //序号
objzx_UserGroupEN.zxColorId = objRow[conzx_UserGroup.zxColorId] == DBNull.Value ? null : objRow[conzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_UserGroupDA: GetObjLst)", objException.Message));
}
objzx_UserGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_UserGroupEN);
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
public List<clszx_UserGroupEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_UserGroupDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_UserGroupEN> arrObjLst = new List<clszx_UserGroupEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_UserGroupEN objzx_UserGroupEN = new clszx_UserGroupEN();
try
{
objzx_UserGroupEN.mId = TransNullToInt(objRow[conzx_UserGroup.mId].ToString().Trim()); //mId
objzx_UserGroupEN.UserId = objRow[conzx_UserGroup.UserId] == DBNull.Value ? null : objRow[conzx_UserGroup.UserId].ToString().Trim(); //用户ID
objzx_UserGroupEN.UpdDate = objRow[conzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[conzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objzx_UserGroupEN.UpdUser = objRow[conzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[conzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objzx_UserGroupEN.Memo = objRow[conzx_UserGroup.Memo] == DBNull.Value ? null : objRow[conzx_UserGroup.Memo].ToString().Trim(); //备注
objzx_UserGroupEN.zxTopicUserRoleId = objRow[conzx_UserGroup.zxTopicUserRoleId] == DBNull.Value ? null : objRow[conzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objzx_UserGroupEN.GroupTextId = objRow[conzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[conzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objzx_UserGroupEN.OrderNum = objRow[conzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_UserGroup.OrderNum].ToString().Trim()); //序号
objzx_UserGroupEN.zxColorId = objRow[conzx_UserGroup.zxColorId] == DBNull.Value ? null : objRow[conzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_UserGroupDA: GetObjLst)", objException.Message));
}
objzx_UserGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_UserGroupEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_UserGroupEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_UserGroup(ref clszx_UserGroupEN objzx_UserGroupEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from zx_UserGroup where mId = " + ""+ objzx_UserGroupEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_UserGroupEN.mId = TransNullToInt(objDT.Rows[0][conzx_UserGroup.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objzx_UserGroupEN.UserId = objDT.Rows[0][conzx_UserGroup.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objzx_UserGroupEN.UpdDate = objDT.Rows[0][conzx_UserGroup.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_UserGroupEN.UpdUser = objDT.Rows[0][conzx_UserGroup.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_UserGroupEN.Memo = objDT.Rows[0][conzx_UserGroup.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_UserGroupEN.zxTopicUserRoleId = objDT.Rows[0][conzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id(字段类型:char,字段长度:4,是否可空:False)
 objzx_UserGroupEN.GroupTextId = objDT.Rows[0][conzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_UserGroupEN.OrderNum = TransNullToInt(objDT.Rows[0][conzx_UserGroup.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objzx_UserGroupEN.zxColorId = objDT.Rows[0][conzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_UserGroupDA: Getzx_UserGroup)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_UserGroupEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from zx_UserGroup where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_UserGroupEN objzx_UserGroupEN = new clszx_UserGroupEN();
try
{
 objzx_UserGroupEN.mId = Int32.Parse(objRow[conzx_UserGroup.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objzx_UserGroupEN.UserId = objRow[conzx_UserGroup.UserId] == DBNull.Value ? null : objRow[conzx_UserGroup.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objzx_UserGroupEN.UpdDate = objRow[conzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[conzx_UserGroup.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_UserGroupEN.UpdUser = objRow[conzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[conzx_UserGroup.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_UserGroupEN.Memo = objRow[conzx_UserGroup.Memo] == DBNull.Value ? null : objRow[conzx_UserGroup.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_UserGroupEN.zxTopicUserRoleId = objRow[conzx_UserGroup.zxTopicUserRoleId] == DBNull.Value ? null : objRow[conzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id(字段类型:char,字段长度:4,是否可空:False)
 objzx_UserGroupEN.GroupTextId = objRow[conzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[conzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_UserGroupEN.OrderNum = objRow[conzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_UserGroup.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objzx_UserGroupEN.zxColorId = objRow[conzx_UserGroup.zxColorId] == DBNull.Value ? null : objRow[conzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_UserGroupDA: GetObjBymId)", objException.Message));
}
return objzx_UserGroupEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_UserGroupEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_UserGroupDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from zx_UserGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_UserGroupEN objzx_UserGroupEN = new clszx_UserGroupEN()
{
mId = TransNullToInt(objRow[conzx_UserGroup.mId].ToString().Trim()), //mId
UserId = objRow[conzx_UserGroup.UserId] == DBNull.Value ? null : objRow[conzx_UserGroup.UserId].ToString().Trim(), //用户ID
UpdDate = objRow[conzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[conzx_UserGroup.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[conzx_UserGroup.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conzx_UserGroup.Memo] == DBNull.Value ? null : objRow[conzx_UserGroup.Memo].ToString().Trim(), //备注
zxTopicUserRoleId = objRow[conzx_UserGroup.zxTopicUserRoleId] == DBNull.Value ? null : objRow[conzx_UserGroup.zxTopicUserRoleId].ToString().Trim(), //主键Id
GroupTextId = objRow[conzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[conzx_UserGroup.GroupTextId].ToString().Trim(), //小组Id
OrderNum = objRow[conzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_UserGroup.OrderNum].ToString().Trim()), //序号
zxColorId = objRow[conzx_UserGroup.zxColorId] == DBNull.Value ? null : objRow[conzx_UserGroup.zxColorId].ToString().Trim() //颜色Id
};
objzx_UserGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_UserGroupEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_UserGroupDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_UserGroupEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_UserGroupEN objzx_UserGroupEN = new clszx_UserGroupEN();
try
{
objzx_UserGroupEN.mId = TransNullToInt(objRow[conzx_UserGroup.mId].ToString().Trim()); //mId
objzx_UserGroupEN.UserId = objRow[conzx_UserGroup.UserId] == DBNull.Value ? null : objRow[conzx_UserGroup.UserId].ToString().Trim(); //用户ID
objzx_UserGroupEN.UpdDate = objRow[conzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[conzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objzx_UserGroupEN.UpdUser = objRow[conzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[conzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objzx_UserGroupEN.Memo = objRow[conzx_UserGroup.Memo] == DBNull.Value ? null : objRow[conzx_UserGroup.Memo].ToString().Trim(); //备注
objzx_UserGroupEN.zxTopicUserRoleId = objRow[conzx_UserGroup.zxTopicUserRoleId] == DBNull.Value ? null : objRow[conzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objzx_UserGroupEN.GroupTextId = objRow[conzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[conzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objzx_UserGroupEN.OrderNum = objRow[conzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_UserGroup.OrderNum].ToString().Trim()); //序号
objzx_UserGroupEN.zxColorId = objRow[conzx_UserGroup.zxColorId] == DBNull.Value ? null : objRow[conzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_UserGroupDA: GetObjByDataRowzx_UserGroup)", objException.Message));
}
objzx_UserGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_UserGroupEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_UserGroupEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_UserGroupEN objzx_UserGroupEN = new clszx_UserGroupEN();
try
{
objzx_UserGroupEN.mId = TransNullToInt(objRow[conzx_UserGroup.mId].ToString().Trim()); //mId
objzx_UserGroupEN.UserId = objRow[conzx_UserGroup.UserId] == DBNull.Value ? null : objRow[conzx_UserGroup.UserId].ToString().Trim(); //用户ID
objzx_UserGroupEN.UpdDate = objRow[conzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[conzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objzx_UserGroupEN.UpdUser = objRow[conzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[conzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objzx_UserGroupEN.Memo = objRow[conzx_UserGroup.Memo] == DBNull.Value ? null : objRow[conzx_UserGroup.Memo].ToString().Trim(); //备注
objzx_UserGroupEN.zxTopicUserRoleId = objRow[conzx_UserGroup.zxTopicUserRoleId] == DBNull.Value ? null : objRow[conzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objzx_UserGroupEN.GroupTextId = objRow[conzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[conzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objzx_UserGroupEN.OrderNum = objRow[conzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_UserGroup.OrderNum].ToString().Trim()); //序号
objzx_UserGroupEN.zxColorId = objRow[conzx_UserGroup.zxColorId] == DBNull.Value ? null : objRow[conzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_UserGroupDA: GetObjByDataRow)", objException.Message));
}
objzx_UserGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_UserGroupEN;
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
objSQL = clszx_UserGroupDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_UserGroupEN._CurrTabName, conzx_UserGroup.mId, 8, "");
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
objSQL = clszx_UserGroupDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_UserGroupEN._CurrTabName, conzx_UserGroup.mId, 8, strPrefix);
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
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from zx_UserGroup where " + strCondition;
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
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from zx_UserGroup where " + strCondition;
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
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_UserGroup", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_UserGroupDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_UserGroup", strCondition))
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
objSQL = clszx_UserGroupDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_UserGroup");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_UserGroupEN objzx_UserGroupEN)
 {
 if (objzx_UserGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_UserGroupEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from zx_UserGroup where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_UserGroup");
objRow = objDS.Tables["zx_UserGroup"].NewRow();
 if (objzx_UserGroupEN.UserId !=  "")
 {
objRow[conzx_UserGroup.UserId] = objzx_UserGroupEN.UserId; //用户ID
 }
 if (objzx_UserGroupEN.UpdDate !=  "")
 {
objRow[conzx_UserGroup.UpdDate] = objzx_UserGroupEN.UpdDate; //修改日期
 }
 if (objzx_UserGroupEN.UpdUser !=  "")
 {
objRow[conzx_UserGroup.UpdUser] = objzx_UserGroupEN.UpdUser; //修改人
 }
 if (objzx_UserGroupEN.Memo !=  "")
 {
objRow[conzx_UserGroup.Memo] = objzx_UserGroupEN.Memo; //备注
 }
 if (objzx_UserGroupEN.zxTopicUserRoleId !=  "")
 {
objRow[conzx_UserGroup.zxTopicUserRoleId] = objzx_UserGroupEN.zxTopicUserRoleId; //主键Id
 }
 if (objzx_UserGroupEN.GroupTextId !=  "")
 {
objRow[conzx_UserGroup.GroupTextId] = objzx_UserGroupEN.GroupTextId; //小组Id
 }
objRow[conzx_UserGroup.OrderNum] = objzx_UserGroupEN.OrderNum; //序号
 if (objzx_UserGroupEN.zxColorId !=  "")
 {
objRow[conzx_UserGroup.zxColorId] = objzx_UserGroupEN.zxColorId; //颜色Id
 }
objDS.Tables[clszx_UserGroupEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_UserGroupEN._CurrTabName);
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
 /// <param name = "objzx_UserGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_UserGroupEN objzx_UserGroupEN)
{
 if (objzx_UserGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_UserGroupEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_UserGroupEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.UserId);
 var strUserId = objzx_UserGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objzx_UserGroupEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.UpdDate);
 var strUpdDate = objzx_UserGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_UserGroupEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.UpdUser);
 var strUpdUser = objzx_UserGroupEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_UserGroupEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.Memo);
 var strMemo = objzx_UserGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_UserGroupEN.zxTopicUserRoleId !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.zxTopicUserRoleId);
 var strzxTopicUserRoleId = objzx_UserGroupEN.zxTopicUserRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTopicUserRoleId + "'");
 }
 
 if (objzx_UserGroupEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.GroupTextId);
 var strGroupTextId = objzx_UserGroupEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 if (objzx_UserGroupEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.OrderNum);
 arrValueListForInsert.Add(objzx_UserGroupEN.OrderNum.ToString());
 }
 
 if (objzx_UserGroupEN.zxColorId !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.zxColorId);
 var strzxColorId = objzx_UserGroupEN.zxColorId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxColorId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_UserGroup");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_UserGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_UserGroupEN objzx_UserGroupEN)
{
 if (objzx_UserGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_UserGroupEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_UserGroupEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.UserId);
 var strUserId = objzx_UserGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objzx_UserGroupEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.UpdDate);
 var strUpdDate = objzx_UserGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_UserGroupEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.UpdUser);
 var strUpdUser = objzx_UserGroupEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_UserGroupEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.Memo);
 var strMemo = objzx_UserGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_UserGroupEN.zxTopicUserRoleId !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.zxTopicUserRoleId);
 var strzxTopicUserRoleId = objzx_UserGroupEN.zxTopicUserRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTopicUserRoleId + "'");
 }
 
 if (objzx_UserGroupEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.GroupTextId);
 var strGroupTextId = objzx_UserGroupEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 if (objzx_UserGroupEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.OrderNum);
 arrValueListForInsert.Add(objzx_UserGroupEN.OrderNum.ToString());
 }
 
 if (objzx_UserGroupEN.zxColorId !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.zxColorId);
 var strzxColorId = objzx_UserGroupEN.zxColorId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxColorId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_UserGroup");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_UserGroupEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_UserGroupEN objzx_UserGroupEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_UserGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_UserGroupEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_UserGroupEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.UserId);
 var strUserId = objzx_UserGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objzx_UserGroupEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.UpdDate);
 var strUpdDate = objzx_UserGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_UserGroupEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.UpdUser);
 var strUpdUser = objzx_UserGroupEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_UserGroupEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.Memo);
 var strMemo = objzx_UserGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_UserGroupEN.zxTopicUserRoleId !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.zxTopicUserRoleId);
 var strzxTopicUserRoleId = objzx_UserGroupEN.zxTopicUserRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTopicUserRoleId + "'");
 }
 
 if (objzx_UserGroupEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.GroupTextId);
 var strGroupTextId = objzx_UserGroupEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 if (objzx_UserGroupEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.OrderNum);
 arrValueListForInsert.Add(objzx_UserGroupEN.OrderNum.ToString());
 }
 
 if (objzx_UserGroupEN.zxColorId !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.zxColorId);
 var strzxColorId = objzx_UserGroupEN.zxColorId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxColorId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_UserGroup");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_UserGroupEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_UserGroupEN objzx_UserGroupEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_UserGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_UserGroupEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_UserGroupEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.UserId);
 var strUserId = objzx_UserGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objzx_UserGroupEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.UpdDate);
 var strUpdDate = objzx_UserGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_UserGroupEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.UpdUser);
 var strUpdUser = objzx_UserGroupEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_UserGroupEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.Memo);
 var strMemo = objzx_UserGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_UserGroupEN.zxTopicUserRoleId !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.zxTopicUserRoleId);
 var strzxTopicUserRoleId = objzx_UserGroupEN.zxTopicUserRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTopicUserRoleId + "'");
 }
 
 if (objzx_UserGroupEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.GroupTextId);
 var strGroupTextId = objzx_UserGroupEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 if (objzx_UserGroupEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.OrderNum);
 arrValueListForInsert.Add(objzx_UserGroupEN.OrderNum.ToString());
 }
 
 if (objzx_UserGroupEN.zxColorId !=  null)
 {
 arrFieldListForInsert.Add(conzx_UserGroup.zxColorId);
 var strzxColorId = objzx_UserGroupEN.zxColorId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxColorId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_UserGroup");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_UserGroups(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from zx_UserGroup where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_UserGroup");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_UserGroupEN._CurrTabName ].NewRow();
objRow[conzx_UserGroup.UserId] = oRow[conzx_UserGroup.UserId].ToString().Trim(); //用户ID
objRow[conzx_UserGroup.UpdDate] = oRow[conzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_UserGroup.UpdUser] = oRow[conzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objRow[conzx_UserGroup.Memo] = oRow[conzx_UserGroup.Memo].ToString().Trim(); //备注
objRow[conzx_UserGroup.zxTopicUserRoleId] = oRow[conzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objRow[conzx_UserGroup.GroupTextId] = oRow[conzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objRow[conzx_UserGroup.OrderNum] = oRow[conzx_UserGroup.OrderNum].ToString().Trim(); //序号
objRow[conzx_UserGroup.zxColorId] = oRow[conzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
 objDS.Tables[clszx_UserGroupEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_UserGroupEN._CurrTabName);
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
 /// <param name = "objzx_UserGroupEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_UserGroupEN objzx_UserGroupEN)
{
 if (objzx_UserGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_UserGroupEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from zx_UserGroup where mId = " + ""+ objzx_UserGroupEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_UserGroupEN._CurrTabName);
if (objDS.Tables[clszx_UserGroupEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objzx_UserGroupEN.mId+"");
return false;
}
objRow = objDS.Tables[clszx_UserGroupEN._CurrTabName].Rows[0];
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.UserId))
 {
objRow[conzx_UserGroup.UserId] = objzx_UserGroupEN.UserId; //用户ID
 }
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.UpdDate))
 {
objRow[conzx_UserGroup.UpdDate] = objzx_UserGroupEN.UpdDate; //修改日期
 }
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.UpdUser))
 {
objRow[conzx_UserGroup.UpdUser] = objzx_UserGroupEN.UpdUser; //修改人
 }
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.Memo))
 {
objRow[conzx_UserGroup.Memo] = objzx_UserGroupEN.Memo; //备注
 }
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.zxTopicUserRoleId))
 {
objRow[conzx_UserGroup.zxTopicUserRoleId] = objzx_UserGroupEN.zxTopicUserRoleId; //主键Id
 }
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.GroupTextId))
 {
objRow[conzx_UserGroup.GroupTextId] = objzx_UserGroupEN.GroupTextId; //小组Id
 }
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.OrderNum))
 {
objRow[conzx_UserGroup.OrderNum] = objzx_UserGroupEN.OrderNum; //序号
 }
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.zxColorId))
 {
objRow[conzx_UserGroup.zxColorId] = objzx_UserGroupEN.zxColorId; //颜色Id
 }
try
{
objDA.Update(objDS, clszx_UserGroupEN._CurrTabName);
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
 /// <param name = "objzx_UserGroupEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_UserGroupEN objzx_UserGroupEN)
{
 if (objzx_UserGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_UserGroupEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_UserGroup Set ");
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.UserId))
 {
 if (objzx_UserGroupEN.UserId !=  null)
 {
 var strUserId = objzx_UserGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conzx_UserGroup.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.UserId); //用户ID
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.UpdDate))
 {
 if (objzx_UserGroupEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_UserGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_UserGroup.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.UpdDate); //修改日期
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.UpdUser))
 {
 if (objzx_UserGroupEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_UserGroupEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_UserGroup.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.UpdUser); //修改人
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.Memo))
 {
 if (objzx_UserGroupEN.Memo !=  null)
 {
 var strMemo = objzx_UserGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_UserGroup.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.Memo); //备注
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.zxTopicUserRoleId))
 {
 if (objzx_UserGroupEN.zxTopicUserRoleId !=  null)
 {
 var strzxTopicUserRoleId = objzx_UserGroupEN.zxTopicUserRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxTopicUserRoleId, conzx_UserGroup.zxTopicUserRoleId); //主键Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.zxTopicUserRoleId); //主键Id
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.GroupTextId))
 {
 if (objzx_UserGroupEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_UserGroupEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_UserGroup.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.GroupTextId); //小组Id
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.OrderNum))
 {
 if (objzx_UserGroupEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_UserGroupEN.OrderNum, conzx_UserGroup.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.OrderNum); //序号
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.zxColorId))
 {
 if (objzx_UserGroupEN.zxColorId !=  null)
 {
 var strzxColorId = objzx_UserGroupEN.zxColorId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxColorId, conzx_UserGroup.zxColorId); //颜色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.zxColorId); //颜色Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objzx_UserGroupEN.mId); 
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
 /// <param name = "objzx_UserGroupEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_UserGroupEN objzx_UserGroupEN, string strCondition)
{
 if (objzx_UserGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_UserGroupEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_UserGroup Set ");
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.UserId))
 {
 if (objzx_UserGroupEN.UserId !=  null)
 {
 var strUserId = objzx_UserGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.UpdDate))
 {
 if (objzx_UserGroupEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_UserGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.UpdUser))
 {
 if (objzx_UserGroupEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_UserGroupEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.Memo))
 {
 if (objzx_UserGroupEN.Memo !=  null)
 {
 var strMemo = objzx_UserGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.zxTopicUserRoleId))
 {
 if (objzx_UserGroupEN.zxTopicUserRoleId !=  null)
 {
 var strzxTopicUserRoleId = objzx_UserGroupEN.zxTopicUserRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxTopicUserRoleId = '{0}',", strzxTopicUserRoleId); //主键Id
 }
 else
 {
 sbSQL.Append(" zxTopicUserRoleId = null,"); //主键Id
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.GroupTextId))
 {
 if (objzx_UserGroupEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_UserGroupEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.OrderNum))
 {
 if (objzx_UserGroupEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_UserGroupEN.OrderNum, conzx_UserGroup.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.OrderNum); //序号
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.zxColorId))
 {
 if (objzx_UserGroupEN.zxColorId !=  null)
 {
 var strzxColorId = objzx_UserGroupEN.zxColorId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxColorId = '{0}',", strzxColorId); //颜色Id
 }
 else
 {
 sbSQL.Append(" zxColorId = null,"); //颜色Id
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
 /// <param name = "objzx_UserGroupEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_UserGroupEN objzx_UserGroupEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_UserGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_UserGroupEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_UserGroup Set ");
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.UserId))
 {
 if (objzx_UserGroupEN.UserId !=  null)
 {
 var strUserId = objzx_UserGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.UpdDate))
 {
 if (objzx_UserGroupEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_UserGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.UpdUser))
 {
 if (objzx_UserGroupEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_UserGroupEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.Memo))
 {
 if (objzx_UserGroupEN.Memo !=  null)
 {
 var strMemo = objzx_UserGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.zxTopicUserRoleId))
 {
 if (objzx_UserGroupEN.zxTopicUserRoleId !=  null)
 {
 var strzxTopicUserRoleId = objzx_UserGroupEN.zxTopicUserRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxTopicUserRoleId = '{0}',", strzxTopicUserRoleId); //主键Id
 }
 else
 {
 sbSQL.Append(" zxTopicUserRoleId = null,"); //主键Id
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.GroupTextId))
 {
 if (objzx_UserGroupEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_UserGroupEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.OrderNum))
 {
 if (objzx_UserGroupEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_UserGroupEN.OrderNum, conzx_UserGroup.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.OrderNum); //序号
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.zxColorId))
 {
 if (objzx_UserGroupEN.zxColorId !=  null)
 {
 var strzxColorId = objzx_UserGroupEN.zxColorId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxColorId = '{0}',", strzxColorId); //颜色Id
 }
 else
 {
 sbSQL.Append(" zxColorId = null,"); //颜色Id
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
 /// <param name = "objzx_UserGroupEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_UserGroupEN objzx_UserGroupEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_UserGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_UserGroupEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_UserGroup Set ");
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.UserId))
 {
 if (objzx_UserGroupEN.UserId !=  null)
 {
 var strUserId = objzx_UserGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conzx_UserGroup.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.UserId); //用户ID
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.UpdDate))
 {
 if (objzx_UserGroupEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_UserGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_UserGroup.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.UpdDate); //修改日期
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.UpdUser))
 {
 if (objzx_UserGroupEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_UserGroupEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_UserGroup.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.UpdUser); //修改人
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.Memo))
 {
 if (objzx_UserGroupEN.Memo !=  null)
 {
 var strMemo = objzx_UserGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_UserGroup.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.Memo); //备注
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.zxTopicUserRoleId))
 {
 if (objzx_UserGroupEN.zxTopicUserRoleId !=  null)
 {
 var strzxTopicUserRoleId = objzx_UserGroupEN.zxTopicUserRoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxTopicUserRoleId, conzx_UserGroup.zxTopicUserRoleId); //主键Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.zxTopicUserRoleId); //主键Id
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.GroupTextId))
 {
 if (objzx_UserGroupEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_UserGroupEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_UserGroup.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.GroupTextId); //小组Id
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.OrderNum))
 {
 if (objzx_UserGroupEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_UserGroupEN.OrderNum, conzx_UserGroup.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.OrderNum); //序号
 }
 }
 
 if (objzx_UserGroupEN.IsUpdated(conzx_UserGroup.zxColorId))
 {
 if (objzx_UserGroupEN.zxColorId !=  null)
 {
 var strzxColorId = objzx_UserGroupEN.zxColorId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxColorId, conzx_UserGroup.zxColorId); //颜色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_UserGroup.zxColorId); //颜色Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objzx_UserGroupEN.mId); 
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
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("zx_UserGroup_Delete", values);
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
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
//删除zx_UserGroup本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_UserGroup where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_UserGroup(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
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
//删除zx_UserGroup本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_UserGroup where mId in (" + strKeyList + ")";
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
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
//删除zx_UserGroup本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_UserGroup where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_UserGroup(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_UserGroupDA: Delzx_UserGroup)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_UserGroup where " + strCondition ;
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
public bool Delzx_UserGroupWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_UserGroupDA: Delzx_UserGroupWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_UserGroup where " + strCondition ;
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
 /// <param name = "objzx_UserGroupENS">源对象</param>
 /// <param name = "objzx_UserGroupENT">目标对象</param>
public void CopyTo(clszx_UserGroupEN objzx_UserGroupENS, clszx_UserGroupEN objzx_UserGroupENT)
{
objzx_UserGroupENT.mId = objzx_UserGroupENS.mId; //mId
objzx_UserGroupENT.UserId = objzx_UserGroupENS.UserId; //用户ID
objzx_UserGroupENT.UpdDate = objzx_UserGroupENS.UpdDate; //修改日期
objzx_UserGroupENT.UpdUser = objzx_UserGroupENS.UpdUser; //修改人
objzx_UserGroupENT.Memo = objzx_UserGroupENS.Memo; //备注
objzx_UserGroupENT.zxTopicUserRoleId = objzx_UserGroupENS.zxTopicUserRoleId; //主键Id
objzx_UserGroupENT.GroupTextId = objzx_UserGroupENS.GroupTextId; //小组Id
objzx_UserGroupENT.OrderNum = objzx_UserGroupENS.OrderNum; //序号
objzx_UserGroupENT.zxColorId = objzx_UserGroupENS.zxColorId; //颜色Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_UserGroupEN objzx_UserGroupEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.UserId, 18, conzx_UserGroup.UserId);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.UpdDate, 20, conzx_UserGroup.UpdDate);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.UpdUser, 20, conzx_UserGroup.UpdUser);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.Memo, 1000, conzx_UserGroup.Memo);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.zxTopicUserRoleId, 4, conzx_UserGroup.zxTopicUserRoleId);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.GroupTextId, 8, conzx_UserGroup.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.zxColorId, 2, conzx_UserGroup.zxColorId);
//检查字段外键固定长度
 objzx_UserGroupEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_UserGroupEN objzx_UserGroupEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.UserId, 18, conzx_UserGroup.UserId);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.UpdDate, 20, conzx_UserGroup.UpdDate);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.UpdUser, 20, conzx_UserGroup.UpdUser);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.Memo, 1000, conzx_UserGroup.Memo);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.zxTopicUserRoleId, 4, conzx_UserGroup.zxTopicUserRoleId);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.GroupTextId, 8, conzx_UserGroup.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.zxColorId, 2, conzx_UserGroup.zxColorId);
//检查外键字段长度
 objzx_UserGroupEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_UserGroupEN objzx_UserGroupEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.UserId, 18, conzx_UserGroup.UserId);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.UpdDate, 20, conzx_UserGroup.UpdDate);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.UpdUser, 20, conzx_UserGroup.UpdUser);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.Memo, 1000, conzx_UserGroup.Memo);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.zxTopicUserRoleId, 4, conzx_UserGroup.zxTopicUserRoleId);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.GroupTextId, 8, conzx_UserGroup.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_UserGroupEN.zxColorId, 2, conzx_UserGroup.zxColorId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_UserGroupEN.UserId, conzx_UserGroup.UserId);
clsCheckSql.CheckSqlInjection4Field(objzx_UserGroupEN.UpdDate, conzx_UserGroup.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_UserGroupEN.UpdUser, conzx_UserGroup.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_UserGroupEN.Memo, conzx_UserGroup.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_UserGroupEN.zxTopicUserRoleId, conzx_UserGroup.zxTopicUserRoleId);
clsCheckSql.CheckSqlInjection4Field(objzx_UserGroupEN.GroupTextId, conzx_UserGroup.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objzx_UserGroupEN.zxColorId, conzx_UserGroup.zxColorId);
//检查外键字段长度
 objzx_UserGroupEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_UserGroup(中学用户小组),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_UserGroupEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_UserGroupEN objzx_UserGroupEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objzx_UserGroupEN.mId);
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
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
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
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
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
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_UserGroupEN._CurrTabName);
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
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_UserGroupEN._CurrTabName, strCondition);
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
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
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
 objSQL = clszx_UserGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}