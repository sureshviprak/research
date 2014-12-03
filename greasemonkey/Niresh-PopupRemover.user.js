// ==UserScript==
// @id             www.niresh.co-0fdcce0e-1586-4cdf-8a72-02896c603861@scriptish
// @name           Niresh-PopupRemover
// @version        1.0
// @namespace      
// @author         
// @description    
// @include        http://www.niresh.co/
// @include        http://hackintosh.zone/
// @run-at         document-end
// @grant          none
// ==/UserScript==
var nl = document.querySelectorAll("#some_ad_block_key_popup, #document_modal");
if(nl) {
  Array.prototype.slice.call(nl, 0)
   .forEach(function(v,i,a){
     //console.log(v);
      v.style.display = "none";
    });
}
