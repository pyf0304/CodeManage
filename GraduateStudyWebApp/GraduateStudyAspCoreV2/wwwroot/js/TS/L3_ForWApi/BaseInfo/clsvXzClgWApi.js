/**
* 类名:clsvXzClgWApi
* 表名:vXzClg(01120139)
* 版本:2023.02.24.1(服务器:WIN-SRV103-116)
* 日期:2023/02/24 13:48:02
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:基本信息维护(BaseInfo)
* 框架-层名:WA_访问层(TS)(WA_Access)
* 编程语言:TypeScript
* 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
  *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
**/
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "axios", "../../L0_Entity/BaseInfo/clsvXzClgEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vXzClg_GetObjFromJsonObj = exports.vXzClg_CopyObjTo = exports.vXzClg_GetCombineCondition = exports.vXzClg_GetObjByJSONStr = exports.vXzClg_GetObjLstByJSONObjLst = exports.vXzClg_GetObjLstByJSONStr = exports.vXzClg_GetJSONStrByObj = exports.vXzClg_GetWebApiUrl = exports.vXzClg_GetRecCountByCondAsync = exports.vXzClg_IsExistAsync = exports.vXzClg_IsExist = exports.vXzClg_IsExistRecordAsync = exports.vXzClg_GetObjLstByPagerAsync = exports.vXzClg_GetObjLstByRange = exports.vXzClg_GetObjLstByRangeAsync = exports.vXzClg_GetTopObjLstAsync = exports.vXzClg_GetObjLstByid_XzCollegeLstAsync = exports.vXzClg_GetObjLstAsync = exports.vXzClg_GetFirstObjAsync = exports.vXzClg_GetFirstID = exports.vXzClg_GetFirstIDAsync = exports.vXzClg_FilterFunByKey = exports.vXzClg_SortFunByKey = exports.vXzClg_SortFun_Defa_2Fld = exports.vXzClg_SortFun_Defa = exports.vXzClg_GetObjByid_XzCollegeAsync = exports.vXzClg_ConstructorName = exports.vXzClg_Controller = void 0;
    /**
     * v学院(vXzClg)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年02月24日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvXzClgEN_js_1 = require("../../L0_Entity/BaseInfo/clsvXzClgEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vXzClg_Controller = "vXzClgApi";
    exports.vXzClg_ConstructorName = "vXzClg";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_XzCollege:关键字
    * @returns 对象
    **/
    async function vXzClg_GetObjByid_XzCollegeAsync(strid_XzCollege) {
        const strThisFuncName = "GetObjByid_XzCollegeAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzCollege) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzCollege]不能为空！(In GetObjByid_XzCollegeAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzCollege.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzCollege]的长度:[{0}]不正确！", strid_XzCollege.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_XzCollege";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzClg_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_XzCollege": strid_XzCollege,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvXzClg = vXzClg_GetObjFromJsonObj(returnObj);
                return objvXzClg;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzClg_GetObjByid_XzCollegeAsync = vXzClg_GetObjByid_XzCollegeAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vXzClg_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_XzCollege.localeCompare(b.id_XzCollege);
    }
    exports.vXzClg_SortFun_Defa = vXzClg_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vXzClg_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.collegeID == b.collegeID)
            return a.collegeName.localeCompare(b.collegeName);
        else
            return a.collegeID.localeCompare(b.collegeID);
    }
    exports.vXzClg_SortFun_Defa_2Fld = vXzClg_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vXzClg_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvXzClgEN_js_1.clsvXzClgEN.con_id_XzCollege:
                    return (a, b) => {
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeID:
                    return (a, b) => {
                        if (a.collegeID == null)
                            return -1;
                        if (b.collegeID == null)
                            return 1;
                        return a.collegeID.localeCompare(b.collegeID);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeName:
                    return (a, b) => {
                        if (a.collegeName == null)
                            return -1;
                        if (b.collegeName == null)
                            return 1;
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeIdInGP:
                    return (a, b) => {
                        if (a.collegeIdInGP == null)
                            return -1;
                        if (b.collegeIdInGP == null)
                            return 1;
                        return a.collegeIdInGP.localeCompare(b.collegeIdInGP);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_ClgEnglishName:
                    return (a, b) => {
                        if (a.clgEnglishName == null)
                            return -1;
                        if (b.clgEnglishName == null)
                            return 1;
                        return a.clgEnglishName.localeCompare(b.clgEnglishName);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeNameA:
                    return (a, b) => {
                        if (a.collegeNameA == null)
                            return -1;
                        if (b.collegeNameA == null)
                            return 1;
                        return a.collegeNameA.localeCompare(b.collegeNameA);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_PhoneNumber:
                    return (a, b) => {
                        if (a.phoneNumber == null)
                            return -1;
                        if (b.phoneNumber == null)
                            return 1;
                        return a.phoneNumber.localeCompare(b.phoneNumber);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_WebSite:
                    return (a, b) => {
                        if (a.webSite == null)
                            return -1;
                        if (b.webSite == null)
                            return 1;
                        return a.webSite.localeCompare(b.webSite);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_id_School:
                    return (a, b) => {
                        if (a.id_School == null)
                            return -1;
                        if (b.id_School == null)
                            return 1;
                        return a.id_School.localeCompare(b.id_School);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolId:
                    return (a, b) => {
                        if (a.schoolId == null)
                            return -1;
                        if (b.schoolId == null)
                            return 1;
                        return a.schoolId.localeCompare(b.schoolId);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolName:
                    return (a, b) => {
                        if (a.schoolName == null)
                            return -1;
                        if (b.schoolName == null)
                            return 1;
                        return a.schoolName.localeCompare(b.schoolName);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolNameA:
                    return (a, b) => {
                        if (a.schoolNameA == null)
                            return -1;
                        if (b.schoolNameA == null)
                            return 1;
                        return a.schoolNameA.localeCompare(b.schoolNameA);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_id_Uni:
                    return (a, b) => {
                        if (a.id_Uni == null)
                            return -1;
                        if (b.id_Uni == null)
                            return 1;
                        return a.id_Uni.localeCompare(b.id_Uni);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_IsVisible:
                    return (a, b) => {
                        if (a.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_ModifyDate:
                    return (a, b) => {
                        if (a.modifyDate == null)
                            return -1;
                        if (b.modifyDate == null)
                            return 1;
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_ModifyUserID:
                    return (a, b) => {
                        if (a.modifyUserID == null)
                            return -1;
                        if (b.modifyUserID == null)
                            return 1;
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_MajorNum:
                    return (a, b) => {
                        return a.majorNum - b.majorNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vXzClg]中不存在！(in ${exports.vXzClg_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvXzClgEN_js_1.clsvXzClgEN.con_id_XzCollege:
                    return (a, b) => {
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeID:
                    return (a, b) => {
                        if (b.collegeID == null)
                            return -1;
                        if (a.collegeID == null)
                            return 1;
                        return b.collegeID.localeCompare(a.collegeID);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeName:
                    return (a, b) => {
                        if (b.collegeName == null)
                            return -1;
                        if (a.collegeName == null)
                            return 1;
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeIdInGP:
                    return (a, b) => {
                        if (b.collegeIdInGP == null)
                            return -1;
                        if (a.collegeIdInGP == null)
                            return 1;
                        return b.collegeIdInGP.localeCompare(a.collegeIdInGP);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_ClgEnglishName:
                    return (a, b) => {
                        if (b.clgEnglishName == null)
                            return -1;
                        if (a.clgEnglishName == null)
                            return 1;
                        return b.clgEnglishName.localeCompare(a.clgEnglishName);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeNameA:
                    return (a, b) => {
                        if (b.collegeNameA == null)
                            return -1;
                        if (a.collegeNameA == null)
                            return 1;
                        return b.collegeNameA.localeCompare(a.collegeNameA);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_PhoneNumber:
                    return (a, b) => {
                        if (b.phoneNumber == null)
                            return -1;
                        if (a.phoneNumber == null)
                            return 1;
                        return b.phoneNumber.localeCompare(a.phoneNumber);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_WebSite:
                    return (a, b) => {
                        if (b.webSite == null)
                            return -1;
                        if (a.webSite == null)
                            return 1;
                        return b.webSite.localeCompare(a.webSite);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_id_School:
                    return (a, b) => {
                        if (b.id_School == null)
                            return -1;
                        if (a.id_School == null)
                            return 1;
                        return b.id_School.localeCompare(a.id_School);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolId:
                    return (a, b) => {
                        if (b.schoolId == null)
                            return -1;
                        if (a.schoolId == null)
                            return 1;
                        return b.schoolId.localeCompare(a.schoolId);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolName:
                    return (a, b) => {
                        if (b.schoolName == null)
                            return -1;
                        if (a.schoolName == null)
                            return 1;
                        return b.schoolName.localeCompare(a.schoolName);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolNameA:
                    return (a, b) => {
                        if (b.schoolNameA == null)
                            return -1;
                        if (a.schoolNameA == null)
                            return 1;
                        return b.schoolNameA.localeCompare(a.schoolNameA);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_id_Uni:
                    return (a, b) => {
                        if (b.id_Uni == null)
                            return -1;
                        if (a.id_Uni == null)
                            return 1;
                        return b.id_Uni.localeCompare(a.id_Uni);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_IsVisible:
                    return (a, b) => {
                        if (b.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_ModifyDate:
                    return (a, b) => {
                        if (b.modifyDate == null)
                            return -1;
                        if (a.modifyDate == null)
                            return 1;
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_ModifyUserID:
                    return (a, b) => {
                        if (b.modifyUserID == null)
                            return -1;
                        if (a.modifyUserID == null)
                            return 1;
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvXzClgEN_js_1.clsvXzClgEN.con_MajorNum:
                    return (a, b) => {
                        return b.majorNum - a.majorNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vXzClg]中不存在！(in ${exports.vXzClg_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vXzClg_SortFunByKey = vXzClg_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vXzClg_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvXzClgEN_js_1.clsvXzClgEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeID:
                return (obj) => {
                    return obj.collegeID === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeIdInGP:
                return (obj) => {
                    return obj.collegeIdInGP === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_ClgEnglishName:
                return (obj) => {
                    return obj.clgEnglishName === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeNameA:
                return (obj) => {
                    return obj.collegeNameA === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_PhoneNumber:
                return (obj) => {
                    return obj.phoneNumber === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_WebSite:
                return (obj) => {
                    return obj.webSite === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_id_School:
                return (obj) => {
                    return obj.id_School === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolId:
                return (obj) => {
                    return obj.schoolId === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolName:
                return (obj) => {
                    return obj.schoolName === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolNameA:
                return (obj) => {
                    return obj.schoolNameA === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_id_Uni:
                return (obj) => {
                    return obj.id_Uni === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_IsVisible:
                return (obj) => {
                    return obj.isVisible === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvXzClgEN_js_1.clsvXzClgEN.con_MajorNum:
                return (obj) => {
                    return obj.majorNum === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vXzClg]中不存在！(in ${exports.vXzClg_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vXzClg_FilterFunByKey = vXzClg_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vXzClg_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzClg_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnStr;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzClg_GetFirstIDAsync = vXzClg_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vXzClg_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzClg_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzClg_GetFirstID = vXzClg_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vXzClg_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzClg_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvXzClg = vXzClg_GetObjFromJsonObj(returnObj);
                return objvXzClg;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzClg_GetFirstObjAsync = vXzClg_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vXzClg_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzClg_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzClg_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzClg_GetObjLstByJSONObjLst(returnObjLst);
                return (arrObjLst);
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzClg_GetObjLstAsync = vXzClg_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_XzCollege:关键字列表
    * @returns 对象列表
    **/
    async function vXzClg_GetObjLstByid_XzCollegeLstAsync(arrid_XzCollege) {
        const strThisFuncName = "GetObjLstByid_XzCollegeLstAsync";
        const strAction = "GetObjLstByid_XzCollegeLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzClg_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_XzCollege);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzClg_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzClg_GetObjLstByJSONObjLst(returnObjLst);
                return arrObjLst;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzClg_GetObjLstByid_XzCollegeLstAsync = vXzClg_GetObjLstByid_XzCollegeLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vXzClg_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzClg_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzClg_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzClg_GetObjLstByJSONObjLst(returnObjLst);
                return (arrObjLst);
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzClg_GetTopObjLstAsync = vXzClg_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vXzClg_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzClg_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzClg_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzClg_GetObjLstByJSONObjLst(returnObjLst);
                return arrObjLst;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzClg_GetObjLstByRangeAsync = vXzClg_GetObjLstByRangeAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRange)
     * @param intMinNum:最小记录号
     * @param intMaxNum:最大记录号
     * @param strWhereCond:给定条件
     * @param strOrderBy:排序方式
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取的相应记录对象列表
    */
    async function vXzClg_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzClg_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "intMinNum": intMinNum,
                    "intMaxNum": intMaxNum,
                    "strWhereCond": strWhereCond,
                    "strOrderBy": strOrderBy,
                }
            });
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzClg_GetObjLstByRange = vXzClg_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vXzClg_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzClg_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzClg_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzClg_GetObjLstByJSONObjLst(returnObjLst);
                return arrObjLst;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzClg_GetObjLstByPagerAsync = vXzClg_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vXzClg_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzClg_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnBool;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzClg_IsExistRecordAsync = vXzClg_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_XzCollege:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vXzClg_IsExist(strid_XzCollege, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzClg_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_XzCollege": strid_XzCollege,
                }
            });
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzClg_IsExist = vXzClg_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_XzCollege:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vXzClg_IsExistAsync(strid_XzCollege) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzClg_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_XzCollege": strid_XzCollege }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return (data.returnBool);
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzClg_IsExistAsync = vXzClg_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vXzClg_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzClg_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnInt;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzClg_GetRecCountByCondAsync = vXzClg_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vXzClg_GetWebApiUrl(strController, strAction) {
        const strThisFuncName = "GetWebApiUrl";
        let strServiceUrl;
        let strCurrIPAddressAndPort = "";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort;
        }
        else {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local;
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx) == true) {
            strServiceUrl = (0, clsString_js_1.Format)("{0}/{1}/{2}", strCurrIPAddressAndPort, strController, strAction);
        }
        else {
            strServiceUrl = (0, clsString_js_1.Format)("{0}/{1}/{2}/{3}", strCurrIPAddressAndPort, clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx, strController, strAction);
        }
        return strServiceUrl;
    }
    exports.vXzClg_GetWebApiUrl = vXzClg_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vXzClg_GetJSONStrByObj(pobjvXzClgEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvXzClgEN);
        }
        catch (objException) {
            const strEx = (0, clsCommFunc4Web_js_1.GetExceptionStr)(objException);
            (0, clsCommFunc4Web_js_1.myShowErrorMsg)(strEx);
        }
        if (strJson == undefined)
            return "";
        else
            return strJson;
    }
    exports.vXzClg_GetJSONStrByObj = vXzClg_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vXzClg_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvXzClgObjLst = new Array();
        if (strJSON === "") {
            return arrvXzClgObjLst;
        }
        try {
            arrvXzClgObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvXzClgObjLst;
        }
        return arrvXzClgObjLst;
    }
    exports.vXzClg_GetObjLstByJSONStr = vXzClg_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvXzClgObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vXzClg_GetObjLstByJSONObjLst(arrvXzClgObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvXzClgObjLst = new Array();
        for (const objInFor of arrvXzClgObjLstS) {
            const obj1 = vXzClg_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvXzClgObjLst.push(obj1);
        }
        return arrvXzClgObjLst;
    }
    exports.vXzClg_GetObjLstByJSONObjLst = vXzClg_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vXzClg_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvXzClgEN = new clsvXzClgEN_js_1.clsvXzClgEN();
        if (strJSON === "") {
            return pobjvXzClgEN;
        }
        try {
            pobjvXzClgEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvXzClgEN;
        }
        return pobjvXzClgEN;
    }
    exports.vXzClg_GetObjByJSONStr = vXzClg_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vXzClg_GetCombineCondition(objvXzClg_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzClgEN_js_1.clsvXzClgEN.con_id_XzCollege, objvXzClg_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeID) == true) {
            const strComparisonOp_CollegeID = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeID, objvXzClg_Cond.collegeID, strComparisonOp_CollegeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeName, objvXzClg_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeIdInGP) == true) {
            const strComparisonOp_CollegeIdInGP = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeIdInGP];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeIdInGP, objvXzClg_Cond.collegeIdInGP, strComparisonOp_CollegeIdInGP);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_ClgEnglishName) == true) {
            const strComparisonOp_ClgEnglishName = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_ClgEnglishName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzClgEN_js_1.clsvXzClgEN.con_ClgEnglishName, objvXzClg_Cond.clgEnglishName, strComparisonOp_ClgEnglishName);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeNameA) == true) {
            const strComparisonOp_CollegeNameA = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeNameA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzClgEN_js_1.clsvXzClgEN.con_CollegeNameA, objvXzClg_Cond.collegeNameA, strComparisonOp_CollegeNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_PhoneNumber) == true) {
            const strComparisonOp_PhoneNumber = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_PhoneNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzClgEN_js_1.clsvXzClgEN.con_PhoneNumber, objvXzClg_Cond.phoneNumber, strComparisonOp_PhoneNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_WebSite) == true) {
            const strComparisonOp_WebSite = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_WebSite];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzClgEN_js_1.clsvXzClgEN.con_WebSite, objvXzClg_Cond.webSite, strComparisonOp_WebSite);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_id_School) == true) {
            const strComparisonOp_id_School = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_id_School];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzClgEN_js_1.clsvXzClgEN.con_id_School, objvXzClg_Cond.id_School, strComparisonOp_id_School);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolId) == true) {
            const strComparisonOp_SchoolId = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolId, objvXzClg_Cond.schoolId, strComparisonOp_SchoolId);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolName) == true) {
            const strComparisonOp_SchoolName = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolName, objvXzClg_Cond.schoolName, strComparisonOp_SchoolName);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolNameA) == true) {
            const strComparisonOp_SchoolNameA = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolNameA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzClgEN_js_1.clsvXzClgEN.con_SchoolNameA, objvXzClg_Cond.schoolNameA, strComparisonOp_SchoolNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_id_Uni) == true) {
            const strComparisonOp_id_Uni = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_id_Uni];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzClgEN_js_1.clsvXzClgEN.con_id_Uni, objvXzClg_Cond.id_Uni, strComparisonOp_id_Uni);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_IsVisible) == true) {
            if (objvXzClg_Cond.isVisible == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvXzClgEN_js_1.clsvXzClgEN.con_IsVisible);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvXzClgEN_js_1.clsvXzClgEN.con_IsVisible);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvXzClgEN_js_1.clsvXzClgEN.con_OrderNum, objvXzClg_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzClgEN_js_1.clsvXzClgEN.con_ModifyDate, objvXzClg_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzClgEN_js_1.clsvXzClgEN.con_ModifyUserID, objvXzClg_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzClgEN_js_1.clsvXzClgEN.con_Memo, objvXzClg_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN_js_1.clsvXzClgEN.con_MajorNum) == true) {
            const strComparisonOp_MajorNum = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN_js_1.clsvXzClgEN.con_MajorNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvXzClgEN_js_1.clsvXzClgEN.con_MajorNum, objvXzClg_Cond.majorNum, strComparisonOp_MajorNum);
        }
        return strWhereCond;
    }
    exports.vXzClg_GetCombineCondition = vXzClg_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvXzClgENS:源对象
     * @param objvXzClgENT:目标对象
    */
    function vXzClg_CopyObjTo(objvXzClgENS, objvXzClgENT) {
        objvXzClgENT.id_XzCollege = objvXzClgENS.id_XzCollege; //学院流水号
        objvXzClgENT.collegeID = objvXzClgENS.collegeID; //学院ID
        objvXzClgENT.collegeName = objvXzClgENS.collegeName; //学院名称
        objvXzClgENT.collegeIdInGP = objvXzClgENS.collegeIdInGP; //CollegeIdInGP
        objvXzClgENT.clgEnglishName = objvXzClgENS.clgEnglishName; //ClgEnglishName
        objvXzClgENT.collegeNameA = objvXzClgENS.collegeNameA; //学院名称简写
        objvXzClgENT.phoneNumber = objvXzClgENS.phoneNumber; //PhoneNumber
        objvXzClgENT.webSite = objvXzClgENS.webSite; //个人主页
        objvXzClgENT.id_School = objvXzClgENS.id_School; //学校流水号
        objvXzClgENT.schoolId = objvXzClgENS.schoolId; //学校编号
        objvXzClgENT.schoolName = objvXzClgENS.schoolName; //学校名称
        objvXzClgENT.schoolNameA = objvXzClgENS.schoolNameA; //学校简称
        objvXzClgENT.id_Uni = objvXzClgENS.id_Uni; //id_Uni
        objvXzClgENT.isVisible = objvXzClgENS.isVisible; //是否显示
        objvXzClgENT.orderNum = objvXzClgENS.orderNum; //序号
        objvXzClgENT.modifyDate = objvXzClgENS.modifyDate; //修改日期
        objvXzClgENT.modifyUserID = objvXzClgENS.modifyUserID; //修改人
        objvXzClgENT.memo = objvXzClgENS.memo; //备注
        objvXzClgENT.majorNum = objvXzClgENS.majorNum; //MajorNum
    }
    exports.vXzClg_CopyObjTo = vXzClg_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvXzClgENS:源对象
     * @param objvXzClgENT:目标对象
    */
    function vXzClg_GetObjFromJsonObj(objvXzClgENS) {
        const objvXzClgENT = new clsvXzClgEN_js_1.clsvXzClgEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvXzClgENT, objvXzClgENS);
        return objvXzClgENT;
    }
    exports.vXzClg_GetObjFromJsonObj = vXzClg_GetObjFromJsonObj;
});
