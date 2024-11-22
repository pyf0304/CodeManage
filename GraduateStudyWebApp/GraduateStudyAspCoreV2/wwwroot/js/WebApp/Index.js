(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Index = void 0;
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Index {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortUsersBy: string = "userId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        static async Page_Load() {
            // 在此处放置用户代码以初始化页面
            var strUserId_Hid = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            // var strcourseID_Hid = $("#hidCourseID").val();
            try {
                if (strUserId_Hid != "") {
                    ////把课程ID存入session
                    //var strCourseId: string = $("#hidCourseID").val();
                    //const bolIsSuccess = this.SetSessionAsync("courseId", strCourseId);
                    //var strWhereCond: string = " userId='" + strUserId_Hid + "'";
                    ////var strWhereCond: string = " userId='" + strUserId_Hid + "' and courseId='" + strcourseID_Hid + "'";
                    //var arrvUserRoleRelationObjLst: Array<clsvQxUserRoleRelationEN> = [];
                    //const responseObjLst = await vQxUserRoleRelation_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                    //    var objvUserRoleRelation: clsvQxUserRoleRelationEN = <clsvQxUserRoleRelationEN>jsonData;
                    //    //              console.log(objUserLoginInfo);
                    //   // $('#IndexTitle').html(objvUserRoleRelation.PrjName);
                    //    var strJson = JSON.stringify(objvUserRoleRelation);
                    //    console.log(strJson);
                    //    const bolIsSuccess = this.SetSessionAsync("objvUserRoleRelation", strJson);
                    //});
                }
                else {
                    //var strUserInfo_Hid = $("#hidUserInfo").val();
                    //if (strUserInfo_Hid != "") {
                    //    var objvUserRoleRelation: clsvQxUserRoleRelationEN;
                    //    objvUserRoleRelation = stuUserLoginInfo.GetObjByHtmlString2(strUserInfo_Hid);
                    //  //  $('#IndexTitle').html('课程管理(' + objvUserRoleRelation.PrjName + ')');
                    //}
                    //else {
                    window.location.href = "/GraduateStudyWebApp/WebApp/Login";
                    // }
                }
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
         设置Session
         <param name = "Key">关键字</param>
         <param name = "Value">值</param>
        */
        static SetSessionAsync(Key, Value) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl_Session_SetString,
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key,
                        Value: Value
                    },
                    success: function (data) {
                        //$('#myValue').val(text);
                        var strKey = data.key;
                        var strValue = data.value;
                        //$('#myKey').html(strKey);
                        //$('#myValue').html(strValue);
                        console.log(strKey + strValue);
                    }
                });
            });
        }
        /*
    获取Session 关键字的值
    <param name = "Key">关键字</param>
    <return>值</return>
    */
        static GetSessionAsync(Key) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: "/Session/GetString",
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key
                    },
                    success: function (data) {
                        var strValue = data.value;
                        console.log(Key + strValue);
                        resolve(data);
                    },
                    error: (e) => {
                        var strErrMsg = decodeURIComponent(e.responseText);
                        reject(e);
                    }
                });
            });
        }
    }
    exports.Index = Index;
});
