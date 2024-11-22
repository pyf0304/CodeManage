
import { UsersCRUD } from "../PagesBase/UserManage_Share/UsersCRUD.js";
import { clsXzClgEN } from "../TS/L0_Entity/BaseInfo_Share/clsXzClgEN.js";
import { clsXzMajorEN } from "../TS/L0_Entity/BaseInfo_Share/clsXzMajorEN.js";
import { clsXzGradeBaseEN } from "../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js";
import { clsUserIdentityEN } from "../TS/L0_Entity/UserManage_Share/clsUserIdentityEN.js";
import { clsvUsersEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersEN.js";
import { XzClg_BindDdl_id_XzCollegeInDiv_Cache } from "../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js";
import { XzMajor_BindDdl_id_XzMajorByid_XzCollegeInDiv_Cache, XzMajor_BindDdl_id_XzMajorInDiv_Cache } from "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js";
import { XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache } from "../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js";
import { UserIdentity_BindDdl_IdentityIDInDiv_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js";
import { vUsers_GetObjLstByPagerAsync, vUsers_GetRecCountByCondAsync } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersWApi.js";
import { XzClgEx_BindDdl_id_XzCollegeForvUsersSimInDiv_CacheEx } from "../TS/L3_ForWApiEx/BaseInfo_Share/clsXzClgExWApi.js";
import { XzMajorEx_BindDdl_id_XzMajorForvUsersSimInDiv_CacheEx } from "../TS/L3_ForWApiEx/BaseInfo_Share/clsXzMajorExWApi.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Users_QUDIEx extends UsersCRUD {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvUsersBy: string = "userId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }
    /* 函数功能:页面导入,当页面开始运行时所发生的事件
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
  */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            this.SetEventFunc();
            //1、为下拉框设置数据源,绑定列表数据
            
            //1、为下拉框设置数据源,绑定列表数据
            
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            UsersCRUD.sortvUsersBy = "userId Asc";
            
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            await this.BindGv_vUsers();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public async CombinevUsersCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and isGSuser=1";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (IsNullOrEmpty(this.id_XzCollege_q) == false && this.id_XzCollege_q != "0") {
                strWhereCond += ` And ${clsvUsersEN.con_id_XzCollege} = '${this.id_XzCollege_q}'`;
            }
            if (IsNullOrEmpty(this.id_XzMajor_q) == false && this.id_XzMajor_q != "0") {
                strWhereCond += ` And ${clsvUsersEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
            }
            if (IsNullOrEmpty(this.userName_q) == false) {
                strWhereCond += ` And ${clsvUsersEN.con_UserName} like '% ${this.userName_q}%'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineUsersCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_vUsers() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevUsersCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvUsersObjLst: Array<clsvUsersEN> = [];
        try {
            this.recCount = await vUsers_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: UsersCRUD.sortvUsersBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vUsers_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvUsersObjLst = <Array<clsvUsersEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        if (arrvUsersObjLst.length == 0) {
            var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vUsers(strListDiv, arrvUsersObjLst);
            console.log("完成BindGv_vUsers!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }


    /** 函数功能:系统生成的Change事件函数
    * (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript+<>c__DisplayClass12_0:<Gen_WApi_Ts_GeneEventFuncEx>b__1)
    **/
    public async ddlid_XzCollege_q_SelectedIndexChanged() {
        //alert('请在扩展层:UsersCRUDExEx中重写该函数！');
        if (IsNullOrEmpty(this.id_XzCollege_q) == true) return;
        this.SetDdl_id_XzMajorById_CollegeInDiv(this.id_XzCollege_q)
    }

    public async SetDdl_id_XzMajorById_CollegeInDiv(strid_XzCollege: string) {
        await XzMajor_BindDdl_id_XzMajorByid_XzCollegeInDiv_Cache(this.divName4Query, "ddlid_XzMajor_q", strid_XzCollege);//
    }


    /**
    * 设置绑定下拉框，针对字段:[id_XzCollege]
    * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
    **/

    public async SetDdl_id_XzCollegeInDiv() {
        await XzClgEx_BindDdl_id_XzCollegeForvUsersSimInDiv_CacheEx(this.divName4Query, "ddlid_XzCollege_q", clsSysPara4WebApi.cmPrjId);//
    }

    /**
    * 设置绑定下拉框，针对字段:[id_XzMajor]
    * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
    **/

    public async SetDdl_id_XzMajorInDiv() {
        await XzMajorEx_BindDdl_id_XzMajorForvUsersSimInDiv_CacheEx(this.divName4Query, "ddlid_XzMajor_q", clsSysPara4WebApi.cmPrjId);//
    }

}