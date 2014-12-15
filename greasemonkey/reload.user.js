// ==UserScript==
// @name        Reload
// @namespace   com.viprak.local
// @description Reload page after set interval
// @include     http://192.168.0.1//userRpm/SystemStatisticRpm.htm
// @include     http://119.160.192.114/userportal/accGraph.do?actid=vbpatel2
// @version     1
// @grant       GM_registerMenuCommand
// ==/UserScript== 
window.setTimeout(function(){
	document.forms[0].submit();
}, 2 * 60 * 1000)