//import * as QQ from "q";
import { Dictionary } from "../../PubFun/tzDictionary.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import axios from "axios";
import { Format } from "../../PubFun/clsString.js";
var ResponseData: tzResponseData;

export class clsgs_UserRelaExWApi {
    public static mstrController: string = "gs_UserRelaExApi";

    /// <summary>
    /// 同步用户关系
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>是否存在记录？</returns>
    public static async SynUserRelaNumAsync(strid_CurrEduCls: string, strUpdUser: string): Promise<boolean> {
        const strThisFuncName = "";
        var strAction = "SynUserRelaNum";
        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
        var mapParam: Dictionary = new Dictionary();
     
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        try {
            const response = await axios.get(strUrl,
                {
                    params: {
                        "strid_CurrEduCls": strid_CurrEduCls,
                        "strUpdUser": strUpdUser
                    }
                });
            const data = response.data;
            if (data.errorId == 0) {
                return (data.returnBool);
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        } catch (error: any) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, this.mstrController, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, this.mstrController, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }

    /// <summary>
    /// 获取WebApi的地址
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
    /// </summary>
    /// <returns>返回当前文件中Web服务的地址</returns>
    public static GetWebApiUrl(strController: string, strAction: string): string {
        var strServiceUrl: string;
        if (clsSysPara4WebApi.bolIsLocalHost == false) {
            strServiceUrl = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
        }
        else {
            strServiceUrl = `${clsSysPara4WebApi.CurrIPAddressAndPort_Local}/${clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
        }
        return strServiceUrl;
    }
}
