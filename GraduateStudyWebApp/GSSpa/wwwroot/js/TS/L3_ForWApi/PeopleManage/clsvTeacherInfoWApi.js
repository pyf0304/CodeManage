/**
* 类名:clsvTeacherInfoWApi
* 表名:vTeacherInfo(01120094)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:27
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:人员管理(PeopleManage)
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
        define(["require", "exports", "axios", "../../L0_Entity/PeopleManage/clsvTeacherInfoEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vTeacherInfo_GetObjFromJsonObj = exports.vTeacherInfo_CopyObjTo = exports.vTeacherInfo_GetCombineCondition = exports.vTeacherInfo_GetObjByJSONStr = exports.vTeacherInfo_GetObjLstByJSONObjLst = exports.vTeacherInfo_GetObjLstByJSONStr = exports.vTeacherInfo_GetJSONStrByObj = exports.vTeacherInfo_GetWebApiUrl = exports.vTeacherInfo_GetRecCountByCondAsync = exports.vTeacherInfo_IsExistAsync = exports.vTeacherInfo_IsExist = exports.vTeacherInfo_IsExistRecordAsync = exports.vTeacherInfo_GetObjLstByPagerAsync = exports.vTeacherInfo_GetObjLstByRange = exports.vTeacherInfo_GetObjLstByRangeAsync = exports.vTeacherInfo_GetTopObjLstAsync = exports.vTeacherInfo_GetObjLstByid_TeacherLstAsync = exports.vTeacherInfo_GetObjLstAsync = exports.vTeacherInfo_GetFirstObjAsync = exports.vTeacherInfo_GetFirstID = exports.vTeacherInfo_GetFirstIDAsync = exports.vTeacherInfo_FilterFunByKey = exports.vTeacherInfo_SortFunByKey = exports.vTeacherInfo_SortFun_Defa_2Fld = exports.vTeacherInfo_SortFun_Defa = exports.vTeacherInfo_GetObjByid_TeacherAsync = exports.vTeacherInfo_ConstructorName = exports.vTeacherInfo_Controller = void 0;
    /**
     * v教师(vTeacherInfo)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvTeacherInfoEN_js_1 = require("../../L0_Entity/PeopleManage/clsvTeacherInfoEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vTeacherInfo_Controller = "vTeacherInfoApi";
    exports.vTeacherInfo_ConstructorName = "vTeacherInfo";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_Teacher:关键字
    * @returns 对象
    **/
    async function vTeacherInfo_GetObjByid_TeacherAsync(strid_Teacher) {
        const strThisFuncName = "GetObjByid_TeacherAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_Teacher) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_Teacher]不能为空！(In GetObjByid_TeacherAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_Teacher.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_Teacher]的长度:[{0}]不正确！", strid_Teacher.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_Teacher";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_Teacher": strid_Teacher,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTeacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvTeacherInfo = vTeacherInfo_GetObjFromJsonObj(returnObj);
                return objvTeacherInfo;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetObjByid_TeacherAsync = vTeacherInfo_GetObjByid_TeacherAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vTeacherInfo_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_Teacher.localeCompare(b.id_Teacher);
    }
    exports.vTeacherInfo_SortFun_Defa = vTeacherInfo_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vTeacherInfo_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.teacherID == b.teacherID)
            return a.teacherName.localeCompare(b.teacherName);
        else
            return a.teacherID.localeCompare(b.teacherID);
    }
    exports.vTeacherInfo_SortFun_Defa_2Fld = vTeacherInfo_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vTeacherInfo_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Teacher:
                    return (a, b) => {
                        return a.id_Teacher.localeCompare(b.id_Teacher);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherID:
                    return (a, b) => {
                        return a.teacherID.localeCompare(b.teacherID);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherName:
                    return (a, b) => {
                        return a.teacherName.localeCompare(b.teacherName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Sex:
                    return (a, b) => {
                        return a.id_Sex.localeCompare(b.id_Sex);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SexDesc:
                    return (a, b) => {
                        return a.sexDesc.localeCompare(b.sexDesc);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_School_Ps:
                    return (a, b) => {
                        return a.id_School_Ps.localeCompare(b.id_School_Ps);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolId:
                    return (a, b) => {
                        return a.schoolId.localeCompare(b.schoolId);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolName:
                    return (a, b) => {
                        return a.schoolName.localeCompare(b.schoolName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Discipline_Ps:
                    return (a, b) => {
                        return a.id_Discipline_Ps.localeCompare(b.id_Discipline_Ps);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_UniZone:
                    return (a, b) => {
                        return a.id_UniZone.localeCompare(b.id_UniZone);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_UniZoneDesc:
                    return (a, b) => {
                        return a.uniZoneDesc.localeCompare(b.uniZoneDesc);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Ethnic:
                    return (a, b) => {
                        return a.id_Ethnic.localeCompare(b.id_Ethnic);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EthnicName:
                    return (a, b) => {
                        return a.ethnicName.localeCompare(b.ethnicName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Politics:
                    return (a, b) => {
                        return a.id_Politics.localeCompare(b.id_Politics);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PoliticsName:
                    return (a, b) => {
                        return a.politicsName.localeCompare(b.politicsName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_AdminGrade:
                    return (a, b) => {
                        return a.id_AdminGrade.localeCompare(b.id_AdminGrade);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_AdminGradeDesc:
                    return (a, b) => {
                        return a.adminGradeDesc.localeCompare(b.adminGradeDesc);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_ProfGrade:
                    return (a, b) => {
                        return a.id_ProfGrade.localeCompare(b.id_ProfGrade);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProfenssionalGradeName:
                    return (a, b) => {
                        return a.profenssionalGradeName.localeCompare(b.profenssionalGradeName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Qualif:
                    return (a, b) => {
                        return a.id_Qualif.localeCompare(b.id_Qualif);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QualifDesc:
                    return (a, b) => {
                        return a.qualifDesc.localeCompare(b.qualifDesc);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Degree:
                    return (a, b) => {
                        return a.id_Degree.localeCompare(b.id_Degree);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DegreeName:
                    return (a, b) => {
                        return a.degreeName.localeCompare(b.degreeName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_StaffType:
                    return (a, b) => {
                        return a.id_StaffType.localeCompare(b.id_StaffType);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_StaffTypeName:
                    return (a, b) => {
                        return a.staffTypeName.localeCompare(b.staffTypeName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Province:
                    return (a, b) => {
                        return a.id_Province.localeCompare(b.id_Province);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProvinceName:
                    return (a, b) => {
                        return a.provinceName.localeCompare(b.provinceName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CitizenID:
                    return (a, b) => {
                        return a.citizenID.localeCompare(b.citizenID);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CardNo:
                    return (a, b) => {
                        return a.cardNo.localeCompare(b.cardNo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Birthday:
                    return (a, b) => {
                        return a.birthday.localeCompare(b.birthday);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_GraduationMajor:
                    return (a, b) => {
                        return a.graduationMajor.localeCompare(b.graduationMajor);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TelNo:
                    return (a, b) => {
                        return a.telNo.localeCompare(b.telNo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Email:
                    return (a, b) => {
                        return a.email.localeCompare(b.email);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_WebSite:
                    return (a, b) => {
                        return a.webSite.localeCompare(b.webSite);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PersonBlog:
                    return (a, b) => {
                        return a.personBlog.localeCompare(b.personBlog);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDate:
                    return (a, b) => {
                        return a.entryDate.localeCompare(b.entryDate);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Offed:
                    return (a, b) => {
                        if (a.offed == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Id_CardNo:
                    return (a, b) => {
                        return a.id_CardNo.localeCompare(b.id_CardNo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsAvconUser:
                    return (a, b) => {
                        if (a.isAvconUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsGpUser:
                    return (a, b) => {
                        if (a.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsLocalUser:
                    return (a, b) => {
                        if (a.isLocalUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_FromUnit:
                    return (a, b) => {
                        return a.fromUnit.localeCompare(b.fromUnit);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzCollege:
                    return (a, b) => {
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeID:
                    return (a, b) => {
                        return a.collegeID.localeCompare(b.collegeID);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeName:
                    return (a, b) => {
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeNameA:
                    return (a, b) => {
                        return a.collegeNameA.localeCompare(b.collegeNameA);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDay:
                    return (a, b) => {
                        return a.entryDay.localeCompare(b.entryDay);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Photo:
                    return (a, b) => {
                        return a.id_Photo.localeCompare(b.id_Photo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Religion:
                    return (a, b) => {
                        return a.id_Religion.localeCompare(b.id_Religion);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ReligionName:
                    return (a, b) => {
                        return a.religionName.localeCompare(b.religionName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsMessage:
                    return (a, b) => {
                        if (a.isMessage == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Microblog:
                    return (a, b) => {
                        return a.microblog.localeCompare(b.microblog);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyUserID:
                    return (a, b) => {
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_OffedBak:
                    return (a, b) => {
                        if (a.offedBak == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PhoneNumber:
                    return (a, b) => {
                        return a.phoneNumber.localeCompare(b.phoneNumber);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QQ:
                    return (a, b) => {
                        return a.qQ.localeCompare(b.qQ);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_College:
                    return (a, b) => {
                        return a.teach_id_College.localeCompare(b.teach_id_College);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_Major:
                    return (a, b) => {
                        return a.teach_id_Major.localeCompare(b.teach_id_Major);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Tel:
                    return (a, b) => {
                        return a.tel.localeCompare(b.tel);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyDate:
                    return (a, b) => {
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_RegisterPassword:
                    return (a, b) => {
                        return a.registerPassword.localeCompare(b.registerPassword);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryYear:
                    return (a, b) => {
                        return a.entryYear.localeCompare(b.entryYear);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DisciplineName_ps:
                    return (a, b) => {
                        return a.disciplineName_ps.localeCompare(b.disciplineName_ps);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vTeacherInfo]中不存在！(in ${exports.vTeacherInfo_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Teacher:
                    return (a, b) => {
                        return b.id_Teacher.localeCompare(a.id_Teacher);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherID:
                    return (a, b) => {
                        return b.teacherID.localeCompare(a.teacherID);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherName:
                    return (a, b) => {
                        return b.teacherName.localeCompare(a.teacherName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Sex:
                    return (a, b) => {
                        return b.id_Sex.localeCompare(a.id_Sex);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SexDesc:
                    return (a, b) => {
                        return b.sexDesc.localeCompare(a.sexDesc);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_School_Ps:
                    return (a, b) => {
                        return b.id_School_Ps.localeCompare(a.id_School_Ps);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolId:
                    return (a, b) => {
                        return b.schoolId.localeCompare(a.schoolId);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolName:
                    return (a, b) => {
                        return b.schoolName.localeCompare(a.schoolName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Discipline_Ps:
                    return (a, b) => {
                        return b.id_Discipline_Ps.localeCompare(a.id_Discipline_Ps);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_UniZone:
                    return (a, b) => {
                        return b.id_UniZone.localeCompare(a.id_UniZone);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_UniZoneDesc:
                    return (a, b) => {
                        return b.uniZoneDesc.localeCompare(a.uniZoneDesc);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Ethnic:
                    return (a, b) => {
                        return b.id_Ethnic.localeCompare(a.id_Ethnic);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EthnicName:
                    return (a, b) => {
                        return b.ethnicName.localeCompare(a.ethnicName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Politics:
                    return (a, b) => {
                        return b.id_Politics.localeCompare(a.id_Politics);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PoliticsName:
                    return (a, b) => {
                        return b.politicsName.localeCompare(a.politicsName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_AdminGrade:
                    return (a, b) => {
                        return b.id_AdminGrade.localeCompare(a.id_AdminGrade);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_AdminGradeDesc:
                    return (a, b) => {
                        return b.adminGradeDesc.localeCompare(a.adminGradeDesc);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_ProfGrade:
                    return (a, b) => {
                        return b.id_ProfGrade.localeCompare(a.id_ProfGrade);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProfenssionalGradeName:
                    return (a, b) => {
                        return b.profenssionalGradeName.localeCompare(a.profenssionalGradeName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Qualif:
                    return (a, b) => {
                        return b.id_Qualif.localeCompare(a.id_Qualif);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QualifDesc:
                    return (a, b) => {
                        return b.qualifDesc.localeCompare(a.qualifDesc);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Degree:
                    return (a, b) => {
                        return b.id_Degree.localeCompare(a.id_Degree);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DegreeName:
                    return (a, b) => {
                        return b.degreeName.localeCompare(a.degreeName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_StaffType:
                    return (a, b) => {
                        return b.id_StaffType.localeCompare(a.id_StaffType);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_StaffTypeName:
                    return (a, b) => {
                        return b.staffTypeName.localeCompare(a.staffTypeName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Province:
                    return (a, b) => {
                        return b.id_Province.localeCompare(a.id_Province);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProvinceName:
                    return (a, b) => {
                        return b.provinceName.localeCompare(a.provinceName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CitizenID:
                    return (a, b) => {
                        return b.citizenID.localeCompare(a.citizenID);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CardNo:
                    return (a, b) => {
                        return b.cardNo.localeCompare(a.cardNo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Birthday:
                    return (a, b) => {
                        return b.birthday.localeCompare(a.birthday);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_GraduationMajor:
                    return (a, b) => {
                        return b.graduationMajor.localeCompare(a.graduationMajor);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TelNo:
                    return (a, b) => {
                        return b.telNo.localeCompare(a.telNo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Email:
                    return (a, b) => {
                        return b.email.localeCompare(a.email);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_WebSite:
                    return (a, b) => {
                        return b.webSite.localeCompare(a.webSite);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PersonBlog:
                    return (a, b) => {
                        return b.personBlog.localeCompare(a.personBlog);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDate:
                    return (a, b) => {
                        return b.entryDate.localeCompare(a.entryDate);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Offed:
                    return (a, b) => {
                        if (b.offed == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Id_CardNo:
                    return (a, b) => {
                        return b.id_CardNo.localeCompare(a.id_CardNo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsAvconUser:
                    return (a, b) => {
                        if (b.isAvconUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsGpUser:
                    return (a, b) => {
                        if (b.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsLocalUser:
                    return (a, b) => {
                        if (b.isLocalUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_FromUnit:
                    return (a, b) => {
                        return b.fromUnit.localeCompare(a.fromUnit);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzCollege:
                    return (a, b) => {
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeID:
                    return (a, b) => {
                        return b.collegeID.localeCompare(a.collegeID);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeName:
                    return (a, b) => {
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeNameA:
                    return (a, b) => {
                        return b.collegeNameA.localeCompare(a.collegeNameA);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDay:
                    return (a, b) => {
                        return b.entryDay.localeCompare(a.entryDay);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Photo:
                    return (a, b) => {
                        return b.id_Photo.localeCompare(a.id_Photo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Religion:
                    return (a, b) => {
                        return b.id_Religion.localeCompare(a.id_Religion);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ReligionName:
                    return (a, b) => {
                        return b.religionName.localeCompare(a.religionName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsMessage:
                    return (a, b) => {
                        if (b.isMessage == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Microblog:
                    return (a, b) => {
                        return b.microblog.localeCompare(a.microblog);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyUserID:
                    return (a, b) => {
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_OffedBak:
                    return (a, b) => {
                        if (b.offedBak == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PhoneNumber:
                    return (a, b) => {
                        return b.phoneNumber.localeCompare(a.phoneNumber);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QQ:
                    return (a, b) => {
                        return b.qQ.localeCompare(a.qQ);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_College:
                    return (a, b) => {
                        return b.teach_id_College.localeCompare(a.teach_id_College);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_Major:
                    return (a, b) => {
                        return b.teach_id_Major.localeCompare(a.teach_id_Major);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Tel:
                    return (a, b) => {
                        return b.tel.localeCompare(a.tel);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyDate:
                    return (a, b) => {
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_RegisterPassword:
                    return (a, b) => {
                        return b.registerPassword.localeCompare(a.registerPassword);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryYear:
                    return (a, b) => {
                        return b.entryYear.localeCompare(a.entryYear);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DisciplineName_ps:
                    return (a, b) => {
                        return b.disciplineName_ps.localeCompare(a.disciplineName_ps);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vTeacherInfo]中不存在！(in ${exports.vTeacherInfo_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vTeacherInfo_SortFunByKey = vTeacherInfo_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vTeacherInfo_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Teacher:
                return (obj) => {
                    return obj.id_Teacher === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherID:
                return (obj) => {
                    return obj.teacherID === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherName:
                return (obj) => {
                    return obj.teacherName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Sex:
                return (obj) => {
                    return obj.id_Sex === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SexDesc:
                return (obj) => {
                    return obj.sexDesc === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_School_Ps:
                return (obj) => {
                    return obj.id_School_Ps === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolId:
                return (obj) => {
                    return obj.schoolId === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolName:
                return (obj) => {
                    return obj.schoolName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Discipline_Ps:
                return (obj) => {
                    return obj.id_Discipline_Ps === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_UniZone:
                return (obj) => {
                    return obj.id_UniZone === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_UniZoneDesc:
                return (obj) => {
                    return obj.uniZoneDesc === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Ethnic:
                return (obj) => {
                    return obj.id_Ethnic === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EthnicName:
                return (obj) => {
                    return obj.ethnicName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Politics:
                return (obj) => {
                    return obj.id_Politics === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PoliticsName:
                return (obj) => {
                    return obj.politicsName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_AdminGrade:
                return (obj) => {
                    return obj.id_AdminGrade === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_AdminGradeDesc:
                return (obj) => {
                    return obj.adminGradeDesc === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_ProfGrade:
                return (obj) => {
                    return obj.id_ProfGrade === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProfenssionalGradeName:
                return (obj) => {
                    return obj.profenssionalGradeName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Qualif:
                return (obj) => {
                    return obj.id_Qualif === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QualifDesc:
                return (obj) => {
                    return obj.qualifDesc === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Degree:
                return (obj) => {
                    return obj.id_Degree === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DegreeName:
                return (obj) => {
                    return obj.degreeName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_StaffType:
                return (obj) => {
                    return obj.id_StaffType === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_StaffTypeName:
                return (obj) => {
                    return obj.staffTypeName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Province:
                return (obj) => {
                    return obj.id_Province === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProvinceName:
                return (obj) => {
                    return obj.provinceName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CitizenID:
                return (obj) => {
                    return obj.citizenID === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CardNo:
                return (obj) => {
                    return obj.cardNo === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Birthday:
                return (obj) => {
                    return obj.birthday === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_GraduationMajor:
                return (obj) => {
                    return obj.graduationMajor === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TelNo:
                return (obj) => {
                    return obj.telNo === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Email:
                return (obj) => {
                    return obj.email === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_WebSite:
                return (obj) => {
                    return obj.webSite === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PersonBlog:
                return (obj) => {
                    return obj.personBlog === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDate:
                return (obj) => {
                    return obj.entryDate === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Offed:
                return (obj) => {
                    return obj.offed === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Id_CardNo:
                return (obj) => {
                    return obj.id_CardNo === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsAvconUser:
                return (obj) => {
                    return obj.isAvconUser === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsGpUser:
                return (obj) => {
                    return obj.isGpUser === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsLocalUser:
                return (obj) => {
                    return obj.isLocalUser === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_FromUnit:
                return (obj) => {
                    return obj.fromUnit === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeID:
                return (obj) => {
                    return obj.collegeID === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeNameA:
                return (obj) => {
                    return obj.collegeNameA === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDay:
                return (obj) => {
                    return obj.entryDay === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Photo:
                return (obj) => {
                    return obj.id_Photo === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Religion:
                return (obj) => {
                    return obj.id_Religion === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ReligionName:
                return (obj) => {
                    return obj.religionName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsMessage:
                return (obj) => {
                    return obj.isMessage === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Microblog:
                return (obj) => {
                    return obj.microblog === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_OffedBak:
                return (obj) => {
                    return obj.offedBak === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PhoneNumber:
                return (obj) => {
                    return obj.phoneNumber === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QQ:
                return (obj) => {
                    return obj.qQ === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_College:
                return (obj) => {
                    return obj.teach_id_College === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_Major:
                return (obj) => {
                    return obj.teach_id_Major === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Tel:
                return (obj) => {
                    return obj.tel === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_RegisterPassword:
                return (obj) => {
                    return obj.registerPassword === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryYear:
                return (obj) => {
                    return obj.entryYear === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DisciplineName_ps:
                return (obj) => {
                    return obj.disciplineName_ps === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vTeacherInfo]中不存在！(in ${exports.vTeacherInfo_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vTeacherInfo_FilterFunByKey = vTeacherInfo_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vTeacherInfo_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetFirstIDAsync = vTeacherInfo_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vTeacherInfo_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetFirstID = vTeacherInfo_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vTeacherInfo_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTeacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvTeacherInfo = vTeacherInfo_GetObjFromJsonObj(returnObj);
                return objvTeacherInfo;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetFirstObjAsync = vTeacherInfo_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vTeacherInfo_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTeacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vTeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetObjLstAsync = vTeacherInfo_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_Teacher:关键字列表
    * @returns 对象列表
    **/
    async function vTeacherInfo_GetObjLstByid_TeacherLstAsync(arrid_Teacher) {
        const strThisFuncName = "GetObjLstByid_TeacherLstAsync";
        const strAction = "GetObjLstByid_TeacherLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_Teacher);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTeacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vTeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetObjLstByid_TeacherLstAsync = vTeacherInfo_GetObjLstByid_TeacherLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vTeacherInfo_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTeacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vTeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetTopObjLstAsync = vTeacherInfo_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vTeacherInfo_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTeacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vTeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetObjLstByRangeAsync = vTeacherInfo_GetObjLstByRangeAsync;
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
    async function vTeacherInfo_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetObjLstByRange = vTeacherInfo_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vTeacherInfo_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTeacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vTeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetObjLstByPagerAsync = vTeacherInfo_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vTeacherInfo_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_IsExistRecordAsync = vTeacherInfo_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_Teacher:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vTeacherInfo_IsExist(strid_Teacher, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_Teacher": strid_Teacher,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_IsExist = vTeacherInfo_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_Teacher:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vTeacherInfo_IsExistAsync(strid_Teacher) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_Teacher": strid_Teacher }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_IsExistAsync = vTeacherInfo_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vTeacherInfo_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetRecCountByCondAsync = vTeacherInfo_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vTeacherInfo_GetWebApiUrl(strController, strAction) {
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
    exports.vTeacherInfo_GetWebApiUrl = vTeacherInfo_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vTeacherInfo_GetJSONStrByObj(pobjvTeacherInfoEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvTeacherInfoEN);
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
    exports.vTeacherInfo_GetJSONStrByObj = vTeacherInfo_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vTeacherInfo_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvTeacherInfoObjLst = new Array();
        if (strJSON === "") {
            return arrvTeacherInfoObjLst;
        }
        try {
            arrvTeacherInfoObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvTeacherInfoObjLst;
        }
        return arrvTeacherInfoObjLst;
    }
    exports.vTeacherInfo_GetObjLstByJSONStr = vTeacherInfo_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvTeacherInfoObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vTeacherInfo_GetObjLstByJSONObjLst(arrvTeacherInfoObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvTeacherInfoObjLst = new Array();
        for (const objInFor of arrvTeacherInfoObjLstS) {
            const obj1 = vTeacherInfo_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvTeacherInfoObjLst.push(obj1);
        }
        return arrvTeacherInfoObjLst;
    }
    exports.vTeacherInfo_GetObjLstByJSONObjLst = vTeacherInfo_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vTeacherInfo_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvTeacherInfoEN = new clsvTeacherInfoEN_js_1.clsvTeacherInfoEN();
        if (strJSON === "") {
            return pobjvTeacherInfoEN;
        }
        try {
            pobjvTeacherInfoEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvTeacherInfoEN;
        }
        return pobjvTeacherInfoEN;
    }
    exports.vTeacherInfo_GetObjByJSONStr = vTeacherInfo_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vTeacherInfo_GetCombineCondition(objvTeacherInfo_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Teacher) == true) {
            const strComparisonOp_id_Teacher = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Teacher];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Teacher, objvTeacherInfo_Cond.id_Teacher, strComparisonOp_id_Teacher);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherID) == true) {
            const strComparisonOp_TeacherID = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherID, objvTeacherInfo_Cond.teacherID, strComparisonOp_TeacherID);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherName) == true) {
            const strComparisonOp_TeacherName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherName, objvTeacherInfo_Cond.teacherName, strComparisonOp_TeacherName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Sex) == true) {
            const strComparisonOp_id_Sex = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Sex];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Sex, objvTeacherInfo_Cond.id_Sex, strComparisonOp_id_Sex);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SexDesc) == true) {
            const strComparisonOp_SexDesc = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SexDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SexDesc, objvTeacherInfo_Cond.sexDesc, strComparisonOp_SexDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_School_Ps) == true) {
            const strComparisonOp_id_School_Ps = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_School_Ps];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_School_Ps, objvTeacherInfo_Cond.id_School_Ps, strComparisonOp_id_School_Ps);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolId) == true) {
            const strComparisonOp_SchoolId = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolId, objvTeacherInfo_Cond.schoolId, strComparisonOp_SchoolId);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolName) == true) {
            const strComparisonOp_SchoolName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolName, objvTeacherInfo_Cond.schoolName, strComparisonOp_SchoolName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Discipline_Ps) == true) {
            const strComparisonOp_id_Discipline_Ps = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Discipline_Ps];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Discipline_Ps, objvTeacherInfo_Cond.id_Discipline_Ps, strComparisonOp_id_Discipline_Ps);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_UniZone) == true) {
            const strComparisonOp_id_UniZone = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_UniZone];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_UniZone, objvTeacherInfo_Cond.id_UniZone, strComparisonOp_id_UniZone);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_UniZoneDesc) == true) {
            const strComparisonOp_UniZoneDesc = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_UniZoneDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_UniZoneDesc, objvTeacherInfo_Cond.uniZoneDesc, strComparisonOp_UniZoneDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Ethnic) == true) {
            const strComparisonOp_id_Ethnic = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Ethnic];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Ethnic, objvTeacherInfo_Cond.id_Ethnic, strComparisonOp_id_Ethnic);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EthnicName) == true) {
            const strComparisonOp_EthnicName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EthnicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EthnicName, objvTeacherInfo_Cond.ethnicName, strComparisonOp_EthnicName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Politics) == true) {
            const strComparisonOp_id_Politics = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Politics];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Politics, objvTeacherInfo_Cond.id_Politics, strComparisonOp_id_Politics);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PoliticsName) == true) {
            const strComparisonOp_PoliticsName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PoliticsName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PoliticsName, objvTeacherInfo_Cond.politicsName, strComparisonOp_PoliticsName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_AdminGrade) == true) {
            const strComparisonOp_id_AdminGrade = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_AdminGrade];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_AdminGrade, objvTeacherInfo_Cond.id_AdminGrade, strComparisonOp_id_AdminGrade);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_AdminGradeDesc) == true) {
            const strComparisonOp_AdminGradeDesc = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_AdminGradeDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_AdminGradeDesc, objvTeacherInfo_Cond.adminGradeDesc, strComparisonOp_AdminGradeDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_ProfGrade) == true) {
            const strComparisonOp_id_ProfGrade = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_ProfGrade];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_ProfGrade, objvTeacherInfo_Cond.id_ProfGrade, strComparisonOp_id_ProfGrade);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProfenssionalGradeName) == true) {
            const strComparisonOp_ProfenssionalGradeName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProfenssionalGradeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProfenssionalGradeName, objvTeacherInfo_Cond.profenssionalGradeName, strComparisonOp_ProfenssionalGradeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Qualif) == true) {
            const strComparisonOp_id_Qualif = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Qualif];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Qualif, objvTeacherInfo_Cond.id_Qualif, strComparisonOp_id_Qualif);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QualifDesc) == true) {
            const strComparisonOp_QualifDesc = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QualifDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QualifDesc, objvTeacherInfo_Cond.qualifDesc, strComparisonOp_QualifDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Degree) == true) {
            const strComparisonOp_id_Degree = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Degree];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Degree, objvTeacherInfo_Cond.id_Degree, strComparisonOp_id_Degree);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DegreeName) == true) {
            const strComparisonOp_DegreeName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DegreeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DegreeName, objvTeacherInfo_Cond.degreeName, strComparisonOp_DegreeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_StaffType) == true) {
            const strComparisonOp_id_StaffType = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_StaffType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_StaffType, objvTeacherInfo_Cond.id_StaffType, strComparisonOp_id_StaffType);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_StaffTypeName) == true) {
            const strComparisonOp_StaffTypeName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_StaffTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_StaffTypeName, objvTeacherInfo_Cond.staffTypeName, strComparisonOp_StaffTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Province) == true) {
            const strComparisonOp_id_Province = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Province];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Province, objvTeacherInfo_Cond.id_Province, strComparisonOp_id_Province);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProvinceName) == true) {
            const strComparisonOp_ProvinceName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProvinceName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProvinceName, objvTeacherInfo_Cond.provinceName, strComparisonOp_ProvinceName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CitizenID) == true) {
            const strComparisonOp_CitizenID = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CitizenID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CitizenID, objvTeacherInfo_Cond.citizenID, strComparisonOp_CitizenID);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CardNo) == true) {
            const strComparisonOp_CardNo = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CardNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CardNo, objvTeacherInfo_Cond.cardNo, strComparisonOp_CardNo);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Birthday) == true) {
            const strComparisonOp_Birthday = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Birthday];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Birthday, objvTeacherInfo_Cond.birthday, strComparisonOp_Birthday);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_GraduationMajor) == true) {
            const strComparisonOp_GraduationMajor = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_GraduationMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_GraduationMajor, objvTeacherInfo_Cond.graduationMajor, strComparisonOp_GraduationMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TelNo) == true) {
            const strComparisonOp_TelNo = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TelNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TelNo, objvTeacherInfo_Cond.telNo, strComparisonOp_TelNo);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Email) == true) {
            const strComparisonOp_Email = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Email];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Email, objvTeacherInfo_Cond.email, strComparisonOp_Email);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_WebSite) == true) {
            const strComparisonOp_WebSite = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_WebSite];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_WebSite, objvTeacherInfo_Cond.webSite, strComparisonOp_WebSite);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PersonBlog) == true) {
            const strComparisonOp_PersonBlog = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PersonBlog];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PersonBlog, objvTeacherInfo_Cond.personBlog, strComparisonOp_PersonBlog);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDate) == true) {
            const strComparisonOp_EntryDate = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDate, objvTeacherInfo_Cond.entryDate, strComparisonOp_EntryDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Offed) == true) {
            if (objvTeacherInfo_Cond.offed == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Offed);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Offed);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Id_CardNo) == true) {
            const strComparisonOp_Id_CardNo = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Id_CardNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Id_CardNo, objvTeacherInfo_Cond.id_CardNo, strComparisonOp_Id_CardNo);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsAvconUser) == true) {
            if (objvTeacherInfo_Cond.isAvconUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsAvconUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsAvconUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsGpUser) == true) {
            if (objvTeacherInfo_Cond.isGpUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsGpUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsGpUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsLocalUser) == true) {
            if (objvTeacherInfo_Cond.isLocalUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsLocalUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsLocalUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_FromUnit) == true) {
            const strComparisonOp_FromUnit = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_FromUnit];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_FromUnit, objvTeacherInfo_Cond.fromUnit, strComparisonOp_FromUnit);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Memo, objvTeacherInfo_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzCollege, objvTeacherInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeID) == true) {
            const strComparisonOp_CollegeID = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeID, objvTeacherInfo_Cond.collegeID, strComparisonOp_CollegeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeName, objvTeacherInfo_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeNameA) == true) {
            const strComparisonOp_CollegeNameA = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeNameA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeNameA, objvTeacherInfo_Cond.collegeNameA, strComparisonOp_CollegeNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzMajor, objvTeacherInfo_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDay) == true) {
            const strComparisonOp_EntryDay = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDay];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDay, objvTeacherInfo_Cond.entryDay, strComparisonOp_EntryDay);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Photo) == true) {
            const strComparisonOp_id_Photo = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Photo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Photo, objvTeacherInfo_Cond.id_Photo, strComparisonOp_id_Photo);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Religion) == true) {
            const strComparisonOp_id_Religion = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Religion];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Religion, objvTeacherInfo_Cond.id_Religion, strComparisonOp_id_Religion);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ReligionName) == true) {
            const strComparisonOp_ReligionName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ReligionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ReligionName, objvTeacherInfo_Cond.religionName, strComparisonOp_ReligionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsMessage) == true) {
            if (objvTeacherInfo_Cond.isMessage == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsMessage);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsMessage);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Microblog) == true) {
            const strComparisonOp_Microblog = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Microblog];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Microblog, objvTeacherInfo_Cond.microblog, strComparisonOp_Microblog);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyUserID, objvTeacherInfo_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_OffedBak) == true) {
            if (objvTeacherInfo_Cond.offedBak == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_OffedBak);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_OffedBak);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PhoneNumber) == true) {
            const strComparisonOp_PhoneNumber = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PhoneNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PhoneNumber, objvTeacherInfo_Cond.phoneNumber, strComparisonOp_PhoneNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QQ) == true) {
            const strComparisonOp_QQ = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QQ];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QQ, objvTeacherInfo_Cond.qQ, strComparisonOp_QQ);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_College) == true) {
            const strComparisonOp_Teach_id_College = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_College];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_College, objvTeacherInfo_Cond.teach_id_College, strComparisonOp_Teach_id_College);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_Major) == true) {
            const strComparisonOp_Teach_id_Major = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_Major];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_Major, objvTeacherInfo_Cond.teach_id_Major, strComparisonOp_Teach_id_Major);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Tel) == true) {
            const strComparisonOp_Tel = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Tel];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Tel, objvTeacherInfo_Cond.tel, strComparisonOp_Tel);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyDate, objvTeacherInfo_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_RegisterPassword) == true) {
            const strComparisonOp_RegisterPassword = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_RegisterPassword];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_RegisterPassword, objvTeacherInfo_Cond.registerPassword, strComparisonOp_RegisterPassword);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryYear) == true) {
            const strComparisonOp_EntryYear = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryYear];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryYear, objvTeacherInfo_Cond.entryYear, strComparisonOp_EntryYear);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DisciplineName_ps) == true) {
            const strComparisonOp_DisciplineName_ps = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DisciplineName_ps];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DisciplineName_ps, objvTeacherInfo_Cond.disciplineName_ps, strComparisonOp_DisciplineName_ps);
        }
        return strWhereCond;
    }
    exports.vTeacherInfo_GetCombineCondition = vTeacherInfo_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvTeacherInfoENS:源对象
     * @param objvTeacherInfoENT:目标对象
    */
    function vTeacherInfo_CopyObjTo(objvTeacherInfoENS, objvTeacherInfoENT) {
        objvTeacherInfoENT.id_Teacher = objvTeacherInfoENS.id_Teacher; //教师流水号
        objvTeacherInfoENT.teacherID = objvTeacherInfoENS.teacherID; //教师工号
        objvTeacherInfoENT.teacherName = objvTeacherInfoENS.teacherName; //教师姓名
        objvTeacherInfoENT.id_Sex = objvTeacherInfoENS.id_Sex; //性别流水号
        objvTeacherInfoENT.sexDesc = objvTeacherInfoENS.sexDesc; //性别名称
        objvTeacherInfoENT.id_School_Ps = objvTeacherInfoENS.id_School_Ps; //学校流水号
        objvTeacherInfoENT.schoolId = objvTeacherInfoENS.schoolId; //学校编号
        objvTeacherInfoENT.schoolName = objvTeacherInfoENS.schoolName; //学校名称
        objvTeacherInfoENT.id_Discipline_Ps = objvTeacherInfoENS.id_Discipline_Ps; //学科流水号
        objvTeacherInfoENT.id_UniZone = objvTeacherInfoENS.id_UniZone; //校区流水号
        objvTeacherInfoENT.uniZoneDesc = objvTeacherInfoENS.uniZoneDesc; //校区名称
        objvTeacherInfoENT.id_Ethnic = objvTeacherInfoENS.id_Ethnic; //民族流水号
        objvTeacherInfoENT.ethnicName = objvTeacherInfoENS.ethnicName; //民族名称
        objvTeacherInfoENT.id_Politics = objvTeacherInfoENS.id_Politics; //政治面貌流水号
        objvTeacherInfoENT.politicsName = objvTeacherInfoENS.politicsName; //政治面貌
        objvTeacherInfoENT.id_AdminGrade = objvTeacherInfoENS.id_AdminGrade; //行政职务流水号
        objvTeacherInfoENT.adminGradeDesc = objvTeacherInfoENS.adminGradeDesc; //行政职务描述
        objvTeacherInfoENT.id_ProfGrade = objvTeacherInfoENS.id_ProfGrade; //专业职称流水号
        objvTeacherInfoENT.profenssionalGradeName = objvTeacherInfoENS.profenssionalGradeName; //专业职称
        objvTeacherInfoENT.id_Qualif = objvTeacherInfoENS.id_Qualif; //学历流水号
        objvTeacherInfoENT.qualifDesc = objvTeacherInfoENS.qualifDesc; //QualifDesc
        objvTeacherInfoENT.id_Degree = objvTeacherInfoENS.id_Degree; //学位流水号
        objvTeacherInfoENT.degreeName = objvTeacherInfoENS.degreeName; //学位名称
        objvTeacherInfoENT.id_StaffType = objvTeacherInfoENS.id_StaffType; //职工类型流水号
        objvTeacherInfoENT.staffTypeName = objvTeacherInfoENS.staffTypeName; //职工类型名称
        objvTeacherInfoENT.id_Province = objvTeacherInfoENS.id_Province; //省份流水号
        objvTeacherInfoENT.provinceName = objvTeacherInfoENS.provinceName; //ProvinceName
        objvTeacherInfoENT.citizenID = objvTeacherInfoENS.citizenID; //身份证号
        objvTeacherInfoENT.cardNo = objvTeacherInfoENS.cardNo; //卡号
        objvTeacherInfoENT.birthday = objvTeacherInfoENS.birthday; //出生日期
        objvTeacherInfoENT.graduationMajor = objvTeacherInfoENS.graduationMajor; //毕业专业
        objvTeacherInfoENT.telNo = objvTeacherInfoENS.telNo; //电话
        objvTeacherInfoENT.email = objvTeacherInfoENS.email; //电子邮箱
        objvTeacherInfoENT.webSite = objvTeacherInfoENS.webSite; //个人主页
        objvTeacherInfoENT.personBlog = objvTeacherInfoENS.personBlog; //个人博客
        objvTeacherInfoENT.entryDate = objvTeacherInfoENS.entryDate; //进校日期
        objvTeacherInfoENT.offed = objvTeacherInfoENS.offed; //是否离校
        objvTeacherInfoENT.id_CardNo = objvTeacherInfoENS.id_CardNo; //内卡号
        objvTeacherInfoENT.isAvconUser = objvTeacherInfoENS.isAvconUser; //IsAvconUser
        objvTeacherInfoENT.isGpUser = objvTeacherInfoENS.isGpUser; //是否Gp用户
        objvTeacherInfoENT.isLocalUser = objvTeacherInfoENS.isLocalUser; //是否本地用户
        objvTeacherInfoENT.fromUnit = objvTeacherInfoENS.fromUnit; //来自单位
        objvTeacherInfoENT.memo = objvTeacherInfoENS.memo; //备注
        objvTeacherInfoENT.id_XzCollege = objvTeacherInfoENS.id_XzCollege; //学院流水号
        objvTeacherInfoENT.collegeID = objvTeacherInfoENS.collegeID; //学院ID
        objvTeacherInfoENT.collegeName = objvTeacherInfoENS.collegeName; //学院名称
        objvTeacherInfoENT.collegeNameA = objvTeacherInfoENS.collegeNameA; //学院名称简写
        objvTeacherInfoENT.id_XzMajor = objvTeacherInfoENS.id_XzMajor; //专业流水号
        objvTeacherInfoENT.entryDay = objvTeacherInfoENS.entryDay; //EntryDay
        objvTeacherInfoENT.id_Photo = objvTeacherInfoENS.id_Photo; //id_Photo
        objvTeacherInfoENT.id_Religion = objvTeacherInfoENS.id_Religion; //id_Religion
        objvTeacherInfoENT.religionName = objvTeacherInfoENS.religionName; //ReligionName
        objvTeacherInfoENT.isMessage = objvTeacherInfoENS.isMessage; //IsMessage
        objvTeacherInfoENT.microblog = objvTeacherInfoENS.microblog; //Microblog
        objvTeacherInfoENT.modifyUserID = objvTeacherInfoENS.modifyUserID; //修改人
        objvTeacherInfoENT.offedBak = objvTeacherInfoENS.offedBak; //OffedBak
        objvTeacherInfoENT.phoneNumber = objvTeacherInfoENS.phoneNumber; //PhoneNumber
        objvTeacherInfoENT.qQ = objvTeacherInfoENS.qQ; //QQ
        objvTeacherInfoENT.teach_id_College = objvTeacherInfoENS.teach_id_College; //Teach_id_College
        objvTeacherInfoENT.teach_id_Major = objvTeacherInfoENS.teach_id_Major; //Teach_id_Major
        objvTeacherInfoENT.tel = objvTeacherInfoENS.tel; //Tel
        objvTeacherInfoENT.modifyDate = objvTeacherInfoENS.modifyDate; //修改日期
        objvTeacherInfoENT.registerPassword = objvTeacherInfoENS.registerPassword; //RegisterPassword
        objvTeacherInfoENT.entryYear = objvTeacherInfoENS.entryYear; //EntryYear
        objvTeacherInfoENT.disciplineName_ps = objvTeacherInfoENS.disciplineName_ps; //学科
    }
    exports.vTeacherInfo_CopyObjTo = vTeacherInfo_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvTeacherInfoENS:源对象
     * @param objvTeacherInfoENT:目标对象
    */
    function vTeacherInfo_GetObjFromJsonObj(objvTeacherInfoENS) {
        const objvTeacherInfoENT = new clsvTeacherInfoEN_js_1.clsvTeacherInfoEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvTeacherInfoENT, objvTeacherInfoENS);
        return objvTeacherInfoENT;
    }
    exports.vTeacherInfo_GetObjFromJsonObj = vTeacherInfo_GetObjFromJsonObj;
});
