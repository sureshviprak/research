// ==UserScript==
// @name        EJ
// @namespace   com.viprak.ejobs
// @description Adding default text for biddinh
// @include     https://www.elance.com/j/*
// @include     https://www.elance.com/myelance
// @version     1
// @grant       GM_registerMenuCommand
// ==/UserScript==

function addText(tbExpr, str){
  var tb = document.querySelector(tbExpr);
  if(tb){
    tb.value = str || "";
  }
}

function addBothInfo(exp, approach){
  addText("#bid_exp-plaintext", exp);
  addText("#bid_desc-plaintext", approach);
}

function smallText(combined){
  var str1 = "Hello Sir,\n\
\n\
We have been working on C#/.Net platform from last 10+ years. We have completed  over 300 projects across various contracts and have worked on almost all technologies related to .Net platform.\n\
\n\
Considering our expertise in these technologies, we are confident of giving you better services to help you with your project.\n\
\n",
      str2 = "It would be great if you could share some more details about your project and specification if possible so that we can go through it to get back to you with questions/comments.\n\
\n\
Thanks,\n\
Prakash \n";
  if(combined === true) {
	  addBothInfo("", str1 + str2);
  } else {
    addBothInfo(str1, str2);
  }
}

function bigText(combined){
  var str1 = "Hello Sir,\n\
\n\
We have been working on C#/.Net platform from last 10+ years. We have completed  over 300 projects across various contracts and have worked on almost all technologies related to .Net platform which includes :\n\
- MVC 3/4/5\n\
- WCF\n\
- WPF/XAML\n\
- Silverlight\n\
- Azure\n\
- LINQ\n\
- EntityFramework 4/5/6\n\
\n\
Third Party Components:\n\
- Telerik\n\
- DevExpress\n\
- ComponentOne\n\
- Infragistics etc.\n\
\n\
Database:\n\
- MSSQL server 2008/2008R2/2012\n\
- MySQL 5.x\n\
- MariaDB 10.x\n\
\n\
And along with that we have expertise in client-side javascript libraries like:\n\
- Underscore\n\
- jQuery\n\
- mootools\n\
- bootstrap\n\
- prototype.js etc\n\
\n\
JS framwork libs like\n\
- ExJs,\n\
- AngularJS,\n\
- Backbone.js\n\
- Knockout\n\
- Ember.js etc.\n\
\n\
Version Control Systems:\n\
- SVN\n\
- TFS\n\
- Git\n\
\n\
Considering our expertise in these technologies, we are confident of giving you better services to help you with your project.\n\
\n\
We already have 4 of our developers working full time with similar service agreements and we ensure you quality services from our side.\n\
\n",
      str2 = "It would be great if you could give us some heads up about your project and specification if possible so that we can go through it to get a feel of it to start with.\n\
\n\
Thanks,\n\
Prakash \n";
  if(combined === true) {
    addBothInfo("", str1 + str2);
  } else {
    addBothInfo(str1, str2);
  }
}

function notEnoughInfo(combined){
  var str1 = "Hello Sir,\n\
\n\
We read your description but its very difficult to estimate time & cost from this. It would be great if you could tell us something more about what\n\
\n";
  var str2 = "Waiting for your inputs.\n\
\n\
Thanks,\n\
Prakash\n\
 \n";
  var d = document.querySelector("#zeroAmount");
  if(d && !d.checked) {
    d.checked = true;
  }
  // addBothInfo(str1, str2);
  if(combined === true) {
    addBothInfo("", str1 + str2);
  } else {
    addBothInfo(str1, str2);
  }
}

function toLocalTime(dtInET){
  var a = new Date(),
      b = dtInET.replace(/.*(<br?>)/,"").split(/[:\s]/g),
      c = (10 * 60 + 30) // +10.30 in mins;
  a.setHours(parseInt(b[0], 10) + (b[2] == "pm" ? 12 : 0));
  a.setMinutes(parseInt(b[1], 10));
  a.setMinutes(a.getMinutes() + c);
  return a.toLocaleTimeString();
}

function addLocalTime(){
  var a = document.querySelectorAll(".msgdateWidth"),
      i = 0,
      item,
      txt;
  console.log(a.length);
  if(a && a.length > 0){
    for(i = 0; i < a.length; i++){
      item = a[i];
      txt = item.innerHTML;
      item.innerHTML = txt + "<br />" + toLocalTime(txt);
    }
  }
}

function evaluateXPath(aNode, aExpr) {
  var xpe = aNode.ownerDocument || aNode;
  var nsResolver = xpe.createNSResolver(xpe.documentElement);
  var result = xpe.evaluate(aExpr, aNode, nsResolver, 0, null);
  var found = [];
  var res;
  while (res = result.iterateNext())
    found.push(res);
  return found;
}

var $x = function(expr){ evaluateXPath(document, expr); };

function selectAwarded(){
  var a = $x("//div[contains(@class,'dashboard') and contains(., 'Awarded')]/descendant::div[contains(@class,'checkbox')]");
  var f = function() { 
    a.pop().click(); 
    if(a.length > 0) { 
      window.setTimeout(f, 1000); 
    } else {
      console.log("Click on Move to folders");
    }
  };
  if(a.length > 0) {
    f();
  }
}
function smallText1() { smallText(true); }
function bigText1() { bigText(true); }
function notEnoughInfo1() { notEnoughInfo(true); }

GM_registerMenuCommand("Small", smallText, "S");
GM_registerMenuCommand("Big", bigText, "B");
GM_registerMenuCommand("Small 1", smallText1, "S");
GM_registerMenuCommand("Big 1", bigText1, "B");
GM_registerMenuCommand("Not enough", notEnoughInfo, "N");
GM_registerMenuCommand("Not enough 1", notEnoughInfo1, "N");
GM_registerMenuCommand("Add Local Time", addLocalTime, "A");
GM_registerMenuCommand("selectAwarded", selectAwarded, "E");

//addLocalTime();