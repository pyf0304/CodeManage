﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFeatureRequirementDA
 表名:vCMFeatureRequirement(00050521)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:53:05
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
using AGC.Entity;

namespace AGC.DAL
{
 /// <summary>
 /// vCM功能需求关系(vCMFeatureRequirement)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCMFeatureRequirementDA : clsCommBase4DA
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
 return clsvCMFeatureRequirementEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCMFeatureRequirementEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMFeatureRequirementEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCMFeatureRequirementEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCMFeatureRequirementEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCMFeatureRequirementDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from vCMFeatureRequirement where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCMFeatureRequirement(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCMFeatureRequirementDA: GetDataTable_vCMFeatureRequirement)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from vCMFeatureRequirement where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCMFeatureRequirementDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCMFeatureRequirementDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from vCMFeatureRequirement where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCMFeatureRequirementDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCMFeatureRequirementDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFeatureRequirement where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFeatureRequirement where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCMFeatureRequirementDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCMFeatureRequirement where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCMFeatureRequirementDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCMFeatureRequirement.* from vCMFeatureRequirement Left Join {1} on {2} where {3} and vCMFeatureRequirement.mId not in (Select top {5} vCMFeatureRequirement.mId from vCMFeatureRequirement Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFeatureRequirement where {1} and mId not in (Select top {2} mId from vCMFeatureRequirement where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFeatureRequirement where {1} and mId not in (Select top {3} mId from vCMFeatureRequirement where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCMFeatureRequirementDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCMFeatureRequirement.* from vCMFeatureRequirement Left Join {1} on {2} where {3} and vCMFeatureRequirement.mId not in (Select top {5} vCMFeatureRequirement.mId from vCMFeatureRequirement Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFeatureRequirement where {1} and mId not in (Select top {2} mId from vCMFeatureRequirement where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFeatureRequirement where {1} and mId not in (Select top {3} mId from vCMFeatureRequirement where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCMFeatureRequirementEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCMFeatureRequirementDA:GetObjLst)", objException.Message));
}
List<clsvCMFeatureRequirementEN> arrObjLst = new List<clsvCMFeatureRequirementEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from vCMFeatureRequirement where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN();
try
{
objvCMFeatureRequirementEN.mId = TransNullToInt(objRow[convCMFeatureRequirement.mId].ToString().Trim()); //mId
objvCMFeatureRequirementEN.CmFeatureId = objRow[convCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureRequirementEN.FeatureName = objRow[convCMFeatureRequirement.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureRequirementEN.CmParentFeatureId = objRow[convCMFeatureRequirement.CmParentFeatureId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureRequirementEN.ParentFeatureName = objRow[convCMFeatureRequirement.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeatureRequirement.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureRequirementEN.FuncModuleAgcId = objRow[convCMFeatureRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureRequirementEN.CmPrjId = objRow[convCMFeatureRequirement.CmPrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmPrjId].ToString().Trim(); //CM工程Id
objvCMFeatureRequirementEN.ReqId = objRow[convCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objvCMFeatureRequirementEN.PrjId = objRow[convCMFeatureRequirement.PrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.PrjId].ToString().Trim(); //工程ID
objvCMFeatureRequirementEN.RequirementName = objRow[convCMFeatureRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMFeatureRequirementEN.OrderNum = TransNullToInt(objRow[convCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objvCMFeatureRequirementEN.ReqContent = objRow[convCMFeatureRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMFeatureRequirementEN.UpdDate = objRow[convCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureRequirementEN.UpdUser = objRow[convCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objvCMFeatureRequirementEN.Memo = objRow[convCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[convCMFeatureRequirement.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMFeatureRequirementDA: GetObjLst)", objException.Message));
}
objvCMFeatureRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMFeatureRequirementEN);
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
public List<clsvCMFeatureRequirementEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCMFeatureRequirementDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCMFeatureRequirementEN> arrObjLst = new List<clsvCMFeatureRequirementEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN();
try
{
objvCMFeatureRequirementEN.mId = TransNullToInt(objRow[convCMFeatureRequirement.mId].ToString().Trim()); //mId
objvCMFeatureRequirementEN.CmFeatureId = objRow[convCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureRequirementEN.FeatureName = objRow[convCMFeatureRequirement.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureRequirementEN.CmParentFeatureId = objRow[convCMFeatureRequirement.CmParentFeatureId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureRequirementEN.ParentFeatureName = objRow[convCMFeatureRequirement.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeatureRequirement.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureRequirementEN.FuncModuleAgcId = objRow[convCMFeatureRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureRequirementEN.CmPrjId = objRow[convCMFeatureRequirement.CmPrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmPrjId].ToString().Trim(); //CM工程Id
objvCMFeatureRequirementEN.ReqId = objRow[convCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objvCMFeatureRequirementEN.PrjId = objRow[convCMFeatureRequirement.PrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.PrjId].ToString().Trim(); //工程ID
objvCMFeatureRequirementEN.RequirementName = objRow[convCMFeatureRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMFeatureRequirementEN.OrderNum = TransNullToInt(objRow[convCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objvCMFeatureRequirementEN.ReqContent = objRow[convCMFeatureRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMFeatureRequirementEN.UpdDate = objRow[convCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureRequirementEN.UpdUser = objRow[convCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objvCMFeatureRequirementEN.Memo = objRow[convCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[convCMFeatureRequirement.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMFeatureRequirementDA: GetObjLst)", objException.Message));
}
objvCMFeatureRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMFeatureRequirementEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCMFeatureRequirement(ref clsvCMFeatureRequirementEN objvCMFeatureRequirementEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from vCMFeatureRequirement where mId = " + ""+ objvCMFeatureRequirementEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCMFeatureRequirementEN.mId = TransNullToInt(objDT.Rows[0][convCMFeatureRequirement.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvCMFeatureRequirementEN.CmFeatureId = objDT.Rows[0][convCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFeatureRequirementEN.FeatureName = objDT.Rows[0][convCMFeatureRequirement.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMFeatureRequirementEN.CmParentFeatureId = objDT.Rows[0][convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(); //父功能Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFeatureRequirementEN.ParentFeatureName = objDT.Rows[0][convCMFeatureRequirement.ParentFeatureName].ToString().Trim(); //父功能名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFeatureRequirementEN.FuncModuleAgcId = objDT.Rows[0][convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFeatureRequirementEN.CmPrjId = objDT.Rows[0][convCMFeatureRequirement.CmPrjId].ToString().Trim(); //CM工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvCMFeatureRequirementEN.ReqId = objDT.Rows[0][convCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFeatureRequirementEN.PrjId = objDT.Rows[0][convCMFeatureRequirement.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvCMFeatureRequirementEN.RequirementName = objDT.Rows[0][convCMFeatureRequirement.RequirementName].ToString().Trim(); //需求名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCMFeatureRequirementEN.OrderNum = TransNullToInt(objDT.Rows[0][convCMFeatureRequirement.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCMFeatureRequirementEN.ReqContent = objDT.Rows[0][convCMFeatureRequirement.ReqContent].ToString().Trim(); //需求内容(字段类型:varchar,字段长度:4000,是否可空:False)
 objvCMFeatureRequirementEN.UpdDate = objDT.Rows[0][convCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFeatureRequirementEN.UpdUser = objDT.Rows[0][convCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFeatureRequirementEN.Memo = objDT.Rows[0][convCMFeatureRequirement.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCMFeatureRequirementDA: GetvCMFeatureRequirement)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvCMFeatureRequirementEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from vCMFeatureRequirement where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN();
try
{
 objvCMFeatureRequirementEN.mId = Int32.Parse(objRow[convCMFeatureRequirement.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvCMFeatureRequirementEN.CmFeatureId = objRow[convCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFeatureRequirementEN.FeatureName = objRow[convCMFeatureRequirement.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMFeatureRequirementEN.CmParentFeatureId = objRow[convCMFeatureRequirement.CmParentFeatureId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(); //父功能Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFeatureRequirementEN.ParentFeatureName = objRow[convCMFeatureRequirement.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeatureRequirement.ParentFeatureName].ToString().Trim(); //父功能名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFeatureRequirementEN.FuncModuleAgcId = objRow[convCMFeatureRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFeatureRequirementEN.CmPrjId = objRow[convCMFeatureRequirement.CmPrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmPrjId].ToString().Trim(); //CM工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvCMFeatureRequirementEN.ReqId = objRow[convCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFeatureRequirementEN.PrjId = objRow[convCMFeatureRequirement.PrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvCMFeatureRequirementEN.RequirementName = objRow[convCMFeatureRequirement.RequirementName].ToString().Trim(); //需求名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCMFeatureRequirementEN.OrderNum = Int32.Parse(objRow[convCMFeatureRequirement.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCMFeatureRequirementEN.ReqContent = objRow[convCMFeatureRequirement.ReqContent].ToString().Trim(); //需求内容(字段类型:varchar,字段长度:4000,是否可空:False)
 objvCMFeatureRequirementEN.UpdDate = objRow[convCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFeatureRequirementEN.UpdUser = objRow[convCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFeatureRequirementEN.Memo = objRow[convCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[convCMFeatureRequirement.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCMFeatureRequirementDA: GetObjBymId)", objException.Message));
}
return objvCMFeatureRequirementEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCMFeatureRequirementEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCMFeatureRequirementDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from vCMFeatureRequirement where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN()
{
mId = TransNullToInt(objRow[convCMFeatureRequirement.mId].ToString().Trim()), //mId
CmFeatureId = objRow[convCMFeatureRequirement.CmFeatureId].ToString().Trim(), //功能Id
FeatureName = objRow[convCMFeatureRequirement.FeatureName].ToString().Trim(), //功能名称
CmParentFeatureId = objRow[convCMFeatureRequirement.CmParentFeatureId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(), //父功能Id
ParentFeatureName = objRow[convCMFeatureRequirement.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeatureRequirement.ParentFeatureName].ToString().Trim(), //父功能名
FuncModuleAgcId = objRow[convCMFeatureRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(), //功能模块Id
CmPrjId = objRow[convCMFeatureRequirement.CmPrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmPrjId].ToString().Trim(), //CM工程Id
ReqId = objRow[convCMFeatureRequirement.ReqId].ToString().Trim(), //需求Id
PrjId = objRow[convCMFeatureRequirement.PrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.PrjId].ToString().Trim(), //工程ID
RequirementName = objRow[convCMFeatureRequirement.RequirementName].ToString().Trim(), //需求名称
OrderNum = TransNullToInt(objRow[convCMFeatureRequirement.OrderNum].ToString().Trim()), //序号
ReqContent = objRow[convCMFeatureRequirement.ReqContent].ToString().Trim(), //需求内容
UpdDate = objRow[convCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[convCMFeatureRequirement.Memo].ToString().Trim() //说明
};
objvCMFeatureRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFeatureRequirementEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCMFeatureRequirementDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCMFeatureRequirementEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN();
try
{
objvCMFeatureRequirementEN.mId = TransNullToInt(objRow[convCMFeatureRequirement.mId].ToString().Trim()); //mId
objvCMFeatureRequirementEN.CmFeatureId = objRow[convCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureRequirementEN.FeatureName = objRow[convCMFeatureRequirement.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureRequirementEN.CmParentFeatureId = objRow[convCMFeatureRequirement.CmParentFeatureId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureRequirementEN.ParentFeatureName = objRow[convCMFeatureRequirement.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeatureRequirement.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureRequirementEN.FuncModuleAgcId = objRow[convCMFeatureRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureRequirementEN.CmPrjId = objRow[convCMFeatureRequirement.CmPrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmPrjId].ToString().Trim(); //CM工程Id
objvCMFeatureRequirementEN.ReqId = objRow[convCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objvCMFeatureRequirementEN.PrjId = objRow[convCMFeatureRequirement.PrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.PrjId].ToString().Trim(); //工程ID
objvCMFeatureRequirementEN.RequirementName = objRow[convCMFeatureRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMFeatureRequirementEN.OrderNum = TransNullToInt(objRow[convCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objvCMFeatureRequirementEN.ReqContent = objRow[convCMFeatureRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMFeatureRequirementEN.UpdDate = objRow[convCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureRequirementEN.UpdUser = objRow[convCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objvCMFeatureRequirementEN.Memo = objRow[convCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[convCMFeatureRequirement.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCMFeatureRequirementDA: GetObjByDataRowvCMFeatureRequirement)", objException.Message));
}
objvCMFeatureRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFeatureRequirementEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCMFeatureRequirementEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN();
try
{
objvCMFeatureRequirementEN.mId = TransNullToInt(objRow[convCMFeatureRequirement.mId].ToString().Trim()); //mId
objvCMFeatureRequirementEN.CmFeatureId = objRow[convCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureRequirementEN.FeatureName = objRow[convCMFeatureRequirement.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureRequirementEN.CmParentFeatureId = objRow[convCMFeatureRequirement.CmParentFeatureId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureRequirementEN.ParentFeatureName = objRow[convCMFeatureRequirement.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeatureRequirement.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureRequirementEN.FuncModuleAgcId = objRow[convCMFeatureRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureRequirementEN.CmPrjId = objRow[convCMFeatureRequirement.CmPrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmPrjId].ToString().Trim(); //CM工程Id
objvCMFeatureRequirementEN.ReqId = objRow[convCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objvCMFeatureRequirementEN.PrjId = objRow[convCMFeatureRequirement.PrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.PrjId].ToString().Trim(); //工程ID
objvCMFeatureRequirementEN.RequirementName = objRow[convCMFeatureRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMFeatureRequirementEN.OrderNum = TransNullToInt(objRow[convCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objvCMFeatureRequirementEN.ReqContent = objRow[convCMFeatureRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMFeatureRequirementEN.UpdDate = objRow[convCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureRequirementEN.UpdUser = objRow[convCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objvCMFeatureRequirementEN.Memo = objRow[convCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[convCMFeatureRequirement.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCMFeatureRequirementDA: GetObjByDataRow)", objException.Message));
}
objvCMFeatureRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFeatureRequirementEN;
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
objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMFeatureRequirementEN._CurrTabName, convCMFeatureRequirement.mId, 8, "");
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
objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMFeatureRequirementEN._CurrTabName, convCMFeatureRequirement.mId, 8, strPrefix);
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
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vCMFeatureRequirement where " + strCondition;
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
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vCMFeatureRequirement where " + strCondition;
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
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMFeatureRequirement", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCMFeatureRequirementDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMFeatureRequirement", strCondition))
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
objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCMFeatureRequirement");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementENS">源对象</param>
 /// <param name = "objvCMFeatureRequirementENT">目标对象</param>
public void CopyTo(clsvCMFeatureRequirementEN objvCMFeatureRequirementENS, clsvCMFeatureRequirementEN objvCMFeatureRequirementENT)
{
objvCMFeatureRequirementENT.mId = objvCMFeatureRequirementENS.mId; //mId
objvCMFeatureRequirementENT.CmFeatureId = objvCMFeatureRequirementENS.CmFeatureId; //功能Id
objvCMFeatureRequirementENT.FeatureName = objvCMFeatureRequirementENS.FeatureName; //功能名称
objvCMFeatureRequirementENT.CmParentFeatureId = objvCMFeatureRequirementENS.CmParentFeatureId; //父功能Id
objvCMFeatureRequirementENT.ParentFeatureName = objvCMFeatureRequirementENS.ParentFeatureName; //父功能名
objvCMFeatureRequirementENT.FuncModuleAgcId = objvCMFeatureRequirementENS.FuncModuleAgcId; //功能模块Id
objvCMFeatureRequirementENT.CmPrjId = objvCMFeatureRequirementENS.CmPrjId; //CM工程Id
objvCMFeatureRequirementENT.ReqId = objvCMFeatureRequirementENS.ReqId; //需求Id
objvCMFeatureRequirementENT.PrjId = objvCMFeatureRequirementENS.PrjId; //工程ID
objvCMFeatureRequirementENT.RequirementName = objvCMFeatureRequirementENS.RequirementName; //需求名称
objvCMFeatureRequirementENT.OrderNum = objvCMFeatureRequirementENS.OrderNum; //序号
objvCMFeatureRequirementENT.ReqContent = objvCMFeatureRequirementENS.ReqContent; //需求内容
objvCMFeatureRequirementENT.UpdDate = objvCMFeatureRequirementENS.UpdDate; //修改日期
objvCMFeatureRequirementENT.UpdUser = objvCMFeatureRequirementENS.UpdUser; //修改者
objvCMFeatureRequirementENT.Memo = objvCMFeatureRequirementENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCMFeatureRequirementEN objvCMFeatureRequirementEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCMFeatureRequirementEN.CmFeatureId, 8, convCMFeatureRequirement.CmFeatureId);
clsCheckSql.CheckFieldLen(objvCMFeatureRequirementEN.FeatureName, 100, convCMFeatureRequirement.FeatureName);
clsCheckSql.CheckFieldLen(objvCMFeatureRequirementEN.CmParentFeatureId, 8, convCMFeatureRequirement.CmParentFeatureId);
clsCheckSql.CheckFieldLen(objvCMFeatureRequirementEN.ParentFeatureName, 500, convCMFeatureRequirement.ParentFeatureName);
clsCheckSql.CheckFieldLen(objvCMFeatureRequirementEN.FuncModuleAgcId, 8, convCMFeatureRequirement.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvCMFeatureRequirementEN.CmPrjId, 6, convCMFeatureRequirement.CmPrjId);
clsCheckSql.CheckFieldLen(objvCMFeatureRequirementEN.ReqId, 8, convCMFeatureRequirement.ReqId);
clsCheckSql.CheckFieldLen(objvCMFeatureRequirementEN.PrjId, 4, convCMFeatureRequirement.PrjId);
clsCheckSql.CheckFieldLen(objvCMFeatureRequirementEN.RequirementName, 50, convCMFeatureRequirement.RequirementName);
clsCheckSql.CheckFieldLen(objvCMFeatureRequirementEN.ReqContent, 4000, convCMFeatureRequirement.ReqContent);
clsCheckSql.CheckFieldLen(objvCMFeatureRequirementEN.UpdDate, 20, convCMFeatureRequirement.UpdDate);
clsCheckSql.CheckFieldLen(objvCMFeatureRequirementEN.UpdUser, 20, convCMFeatureRequirement.UpdUser);
clsCheckSql.CheckFieldLen(objvCMFeatureRequirementEN.Memo, 1000, convCMFeatureRequirement.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureRequirementEN.CmFeatureId, convCMFeatureRequirement.CmFeatureId);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureRequirementEN.FeatureName, convCMFeatureRequirement.FeatureName);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureRequirementEN.CmParentFeatureId, convCMFeatureRequirement.CmParentFeatureId);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureRequirementEN.ParentFeatureName, convCMFeatureRequirement.ParentFeatureName);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureRequirementEN.FuncModuleAgcId, convCMFeatureRequirement.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureRequirementEN.CmPrjId, convCMFeatureRequirement.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureRequirementEN.ReqId, convCMFeatureRequirement.ReqId);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureRequirementEN.PrjId, convCMFeatureRequirement.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureRequirementEN.RequirementName, convCMFeatureRequirement.RequirementName);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureRequirementEN.ReqContent, convCMFeatureRequirement.ReqContent);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureRequirementEN.UpdDate, convCMFeatureRequirement.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureRequirementEN.UpdUser, convCMFeatureRequirement.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureRequirementEN.Memo, convCMFeatureRequirement.Memo);
//检查外键字段长度
 objvCMFeatureRequirementEN._IsCheckProperty = true;
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
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
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
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
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
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMFeatureRequirementEN._CurrTabName);
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
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMFeatureRequirementEN._CurrTabName, strCondition);
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
 objSQL = clsvCMFeatureRequirementDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}