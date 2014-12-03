// ==UserScript==
// @id             ElanceFilterScript
// @name           Filter for Elance site
// @version        1.0
// @namespace      com.viprak.elancefilter
// @author         Prakash Solanki
// @description    Filters for Elance site
// @include        https://www.elance.com/r/jobs/*
// @run-at         document-start
// @grant          GM_registerMenuCommand
// ==/UserScript==
function addStyles(){
  var sheet = (function() {
    // Create the <style> tag
    var style = document.createElement("style");

    // Add a media (and/or media query) here if you'd like!
    // style.setAttribute("media", "screen")
    // style.setAttribute("media", "only screen and (max-width : 1024px)")

    // WebKit hack :(
    style.appendChild(document.createTextNode(""));

    // Add the <style> element to the page
    document.head.appendChild(style);

    return style.sheet;
  })();
  
  function addCSSRule(sheet, selector, rules, index) {
    if("insertRule" in sheet) {
      sheet.insertRule(selector + "{" + rules + "}", index);
    }
    else if("addRule" in sheet) {
      sheet.addRule(selector, rules, index);
    }
  }
  //addCSSRule(sheet, "header", "float: left");
  sheet.insertRule(".ifNotCountry { border: 1px solid red; display: none; }", 0);
  sheet.insertRule(".ifNotTech { border: 1px solid yellow; display: none; }", 0);
  sheet.insertRule(".ifNotLocation { border: 1px solid cyan; display: none; }", 0);
}
function showHidden(){
  var list = document.querySelectorAll(".ifNotCountry, .ifNotTech, .ifNotLocation");
  if(list){
    for(i = 0; i < list.length; i++){
      list[i].style.display = "block";
    }
  }
}
function addClassIf(test, matches, div, childSelector, values, cssClass){
  var child = div.querySelector(childSelector),
      ret = false,
      func = function(v, i ,a){
        return matches ? child.textContent.indexOf(v) > -1 : child.textContent.indexOf(v) == -1;
      };
  if(child != null){
    ret = test.call(values, func);
    if(ret){
      div.classList.add(cssClass);
    }
  }
  return ret;
}
function checkPostedBy(div){
  var notAllowedCountries = ["India", "Pakistan", "Bangladesh", "Sri Lanka"],
      childSelector = "div.prof:nth-last-of-type(1)",
      cssClass = "ifNotCountry";
  var ret = addClassIf(Array.prototype.some, true, div, childSelector, notAllowedCountries, cssClass);
  return ret;
}
function techMatches(div){
  var childSelector = "div.left.padtop:nth-of-type(2) .skilllist",
      reqSkills = [".NET", "C#"],
      cssClass = "ifNotTech";
  var ret = addClassIf(Array.prototype.every, false, div, childSelector, reqSkills, cssClass);
  return ret;
}
function notPrefLocation(div){
  var childSelector = "div.left.padtop:nth-of-type(3)",
      cssClass = "ifNotLocation",
      allowedCountries = ["India"],
      list = div.querySelector(childSelector);
  var ret = list != null && list.textContent.indexOf("India") == -1;
  if(ret){
    div.classList.add(cssClass);
  }
  return ret;
}
function checkPage(){
  var divs = document.querySelectorAll(".jobCard"),
      i = 0,
      cnt = 0,
      div;
  console.log("Total: " + divs.length);
  for(i = 0; i < divs.length; i++){
    div = divs[i];
    checkPostedBy(div);
    techMatches(div);
    //notPrefLocation(div);
  }
  //console.log("Found: " + cnt);
}
//checkPage();
document.addEventListener("readystatechange", function() {
  if(document.readyState == "complete"){
    addStyles();
    checkPage();
  }
});
GM_registerMenuCommand("Show Hidden", showHidden, "S");