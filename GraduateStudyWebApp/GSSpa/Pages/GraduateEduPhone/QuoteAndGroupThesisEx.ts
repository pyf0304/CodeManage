﻿//import { clsThesisEN } from "../TS/L0_Entity/GraduateEdu/clsThesisEN.js";
//import { clsThesisBL } from "../TS/L2_BLL/GraduateEdu/clsThesisBL.js";
//import { clsThesisWApi } from "../TS/L3_ForWApi/GraduateEdu/clsThesisWApi.js";
//import { clsvThesisEN } from "../TS/L0_Entity/GraduateEdu/clsvThesisEN.js";
//import { clsvThesisWApi } from "../TS/L3_ForWApi/GraduateEdu/clsvThesisWApi.js";
//import { Thesis_QUDI_TS } from "../GraduateEduTopic/Thesis_QUDI_TS.js";
//import { clsThesisWApiEx } from "../TS/L3_ForWApiEx/GraduateEdu/clsThesisWApiEx.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog(): void;
/*
* 宣布一个已经在其他地方定义存在的变量strUrl_Session_SetString，
* 用于定义处理Session-设置String函数的地址
*/
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
/*
* 宣布一个已经在其他地方定义存在的变量strCurrPrjId，
* 用于定义当前工程Id
*/
declare var strCurrPrjId;
//declare var $;
/* Thesis_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/