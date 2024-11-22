/*
 * 功能：为Web提供一些几个公共的功能函数
 * 版本：2019-08-07-01
 * 作者：潘以锋
 * */



declare var document;

export class clsPubFun4Web {

    /*
    * 重新转向本项目新的Url地址
    */
    public static GetRegionId(strViewId: string, strRegionTypeId: string): number {
        return 0;
    }



    /*
  * 获取当前时间
  */
    public static getNowDate(): string {
        const date = new Date();
        let strMonth: string | number = date.getMonth() + 1;
        let strDate: string | number = date.getDate();

        let strHours: string | number = date.getHours();
        let strMinutes: string | number = date.getMinutes();
        let strSeconds: string | number = date.getSeconds();


        if (strMonth <= 9) {
            strMonth = "0" + strMonth;
        }
        if (strDate <= 9) {
            strDate = "0" + strDate;
        }
        if (strHours <= 9) {
            strHours = "0" + strHours;
        }
        if (strMinutes <= 9) {
            strMinutes = "0" + strMinutes;
        }
        if (strSeconds <= 9) {
            strSeconds = "0" + strSeconds;
        }


        return date.getFullYear().toString() + "-" + strMonth + "-" + strDate + " " + strHours + ":" + strMinutes + ":" + strSeconds;
    }

    /*
  * 获取当前时间的年月日
  */
    public static getNowDate_ymd(): string {
        const date = new Date();
        let strMonth: string | number = date.getMonth() + 1;
        let strDate: string | number = date.getDate();

        let strHours: string | number = date.getHours();
        let strMinutes: string | number = date.getMinutes();
        let strSeconds: string | number = date.getSeconds();


        if (strMonth <= 9) {
            strMonth = "0" + strMonth;
        }
        if (strDate <= 9) {
            strDate = "0" + strDate;
        }
        return date.getFullYear().toString() + "-" + strMonth + "-" + strDate;
    }


    //日期转换
    public static substrDate(strDate: string): string {
        var strUpdDate = strDate.substr(2, 14);
        return strUpdDate;
    }


}
