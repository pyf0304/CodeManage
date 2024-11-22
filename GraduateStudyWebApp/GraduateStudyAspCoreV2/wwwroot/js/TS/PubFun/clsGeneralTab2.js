/*
 * 功能：公共数据实体底层
 * 版本：2019-07-24-01
 * 作者：潘以锋
 * */
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsGeneralTab2 = exports.clsGeneralTab_Sim2 = void 0;
    class clsGeneralTab_Sim2 {
    }
    exports.clsGeneralTab_Sim2 = clsGeneralTab_Sim2;
    class clsGeneralTab2 {
        //以下是属性变量
        ///该函数不存在:
        constructor() {
            this.whereCond = "";
            //以下是出错信息
            //public mstrErrMsg :Array<String> = [ "0:正常", "1:院系号为空", "2:专业编号为空", "3:已有相同的编号"];
            //以下是出错信息号码
            //public mintErrNo: Number = 0; //0:正常,1:房间号为空,2:学号为空
            //public mstrDispErrMsg: string; //对外显示的错误信息
            //public mstrModuleName: string;
            //		public static String mstrClassName;
            //public mblnDisposed : boolean = false; //是否已经释放对象(用于析构函数)
            //public EXCEPTION_MSG = " there was an error in the method. please see the Application Log for details.";
            /// <summary>
            /// 常量:"intTag"
            /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            this.con_IntTag = "intTag"; //整型Tag
            /// <summary>
            /// 常量:"StrTag"
            /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            this.con_StrTag = "StrTag"; //字符型标签
            /// <summary>
            /// 常量:"IsCheckProperty"
            /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            this.con_IsCheckProperty = "IsCheckProperty"; //是否检查属性
            this.mintIntTag = 0; //整型Tag
            this.mstrStrTag = ""; //字符型标签
            this.mbolIsCheckProperty = false; //是否检查属性
            this.hmProperty = {};
            this.dicFldComparisonOp = {};
            this.mstrsf_UpdFldSetStr = ""; //修改字符标志串
            this.mstrsf_FldComparisonOp = ""; //修改字符标志串
            this.whereCond = "";
        }
        /// <summary>
        /// 整型Tag(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
        /// </summary>
        get intTag() {
            return this.mintIntTag;
        }
        set intTag(value) {
            this.mintIntTag = value;
            //记录修改过的字段
            this.hmProperty["intTag"] = true;
        }
        /// <summary>
        /// 字符型标签(说明:;字段类型:string;字段长度:1000;是否可空:False)
        /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
        /// </summary>
        get StrTag() {
            return this.mstrStrTag;
        }
        set StrTag(value) {
            if (value === "") {
                //this.mintErrNo = 1;
                this.mstrStrTag = value;
            }
            else {
                this.mstrStrTag = value;
            }
            //记录修改过的字段
            this.hmProperty["StrTag"] = true;
        }
        get sf_UpdFldSetStr() {
            return this.mstrsf_UpdFldSetStr;
        }
        set sf_UpdFldSetStr(value) {
            this.mstrsf_UpdFldSetStr = value;
        }
        get sf_FldComparisonOp() {
            return this.mstrsf_FldComparisonOp;
        }
        set sf_FldComparisonOp(value) {
            this.mstrsf_FldComparisonOp = value;
        }
        //public get hmProperty()// : String
        //{
        //    return this.hmProperty;
        //}
        //public sethmProperty(value: string, IsUpdated:boolean) {
        //    this.hmProperty[value] = IsUpdated;
        //}
        /// <summary>
        /// 是否检查属性(说明:;字段类型:bool;字段长度:1;是否可空:False)
        /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
        /// </summary>
        get _IsCheckProperty() {
            return this.mbolIsCheckProperty;
        }
        set _IsCheckProperty(value) {
            this.mbolIsCheckProperty = value;
            //记录修改过的字段
            this.hmProperty["IsCheckProperty"] = true;
        }
        /// <summary>
        /// 设置类的有些属性初始值
        /// </summary>
        //public SetInit () {
        //    this.CurrTabName = "Users"; //当前表名，与该类相关的表名
        //    this.KeyFldName = "userId"; //当前表的关键字字段的名称
        //    this.hmProperty = {};//new { [key: string]: string }();
        //    //mstrModuleName = this.GetType().toString();
        //}
        get UpdFldProperty() {
            return this.hmProperty;
        }
        /*
         * 获取修改的字段名串
         */
        get updFldString() {
            var sbMsg = "";
            //var iLen = this.hmProperty.length();
            for (let key in this.hmProperty) {
                var value = this.hmProperty[key];
                sbMsg = sbMsg + key + "|";
            }
            return sbMsg;
        }
    }
    exports.clsGeneralTab2 = clsGeneralTab2;
    clsGeneralTab2._CurrTabName = ""; //当前表名，与该类相关的表名
    clsGeneralTab2._KeyFldName = ""; //当前表的关键字字段的名称
});
