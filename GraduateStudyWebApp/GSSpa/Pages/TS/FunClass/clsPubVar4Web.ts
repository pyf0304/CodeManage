/*
 * 功能:为Web提供一些几个公共的功能函数
 * 版本:2019-08-07-01
 * 作者:潘以锋
 * */

declare const document: any;

export class clsPubVar4Web {
    public static sortFun() { }
    /*
    * 重新转向本项目新的Url地址
    */
    public static GetRegionId(strViewId: string, strRegionTypeId: string): number {
        return 0;
    }
 
}
export function GetLst_TabCacheAdditionCondition() {
    const arrTabCacheAdditionCondition = [
        {
            tabName: "vFieldTab_Sim",
            cacheAdditionCondition: "FldId in (select fldid from prjtabfld)"
        },
        {
            tabName: "vPrjTab_Sim",
            cacheAdditionCondition: "TabStateId='01'"
        },
    ];
    return arrTabCacheAdditionCondition;

}