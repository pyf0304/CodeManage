﻿export class tzResponseData {
    public data = "";
    public what: number = 0;
    public IsFinished: boolean = false;
    public faultString: string = "";
    public errorId: number = 0;
    public returnBool: boolean = false;
    public returnString: string = "";

    public returnObject: any = null;
    public returnObjectList: Array<any> = new Array<any>() ;
}