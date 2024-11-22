
/*-- -- -- -- -- -- -- -- -- -- --
类名:SysScoreWeight_QUDI_TSEx
表名:SysScoreWeight(01120629)
生成代码版本:2020.04.17.1
生成日期:2020/04/21 16:37:28
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_界面脚本后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { SysScoreWeight_QUDI_TS } from "./SysScoreWeight_QUDI_TS.js";
import { clsvSysScoreWeightEN } from "../TS/L0_Entity/GraduateEduTools/clsvSysScoreWeightEN.js";
import { clsCurrEduClsEN } from "../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { CurrEduCls_GetSubObjLst_Cache } from "../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* SysScoreWeight_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class SysScoreWeight_QUDI_TSEx extends SysScoreWeight_QUDI_TS {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortSysScoreWeightBy: string = "scoreWeightId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }
    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public CombinevSysScoreWeightCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.IsPublic_q == true) {
            //    strWhereCond += ` And ${clsvSysScoreWeightEN.con_IsPublic} = '1'`;
            //}
            //else {
            //    strWhereCond += ` And ${clsvSysScoreWeightEN.con_IsPublic} = '0'`;
            //}

            if (this.id_CurrEduCls_q != null && this.id_CurrEduCls_q != "0") {
                strWhereCond += ` And ${clsvSysScoreWeightEN.con_id_CurrEduCls} = '${this.id_CurrEduCls_q}'`;
            }

          
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineSysScoreWeightCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }


    /// <summary>
    /// 绑定基于Web的下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    public static async BindDdl_id_CurrEduCls_Cache(strDdlName: string, objCurrEduCls_Cond: clsCurrEduClsEN) {
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_id_CurrEduCls_Cache");
        var arrObjLst_Sel: Array<clsCurrEduClsEN> = await CurrEduCls_GetSubObjLst_Cache(objCurrEduCls_Cond);
        clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsCurrEduClsEN.con_id_CurrEduCls, clsCurrEduClsEN.con_EduClsName, "教学班");
    }

}