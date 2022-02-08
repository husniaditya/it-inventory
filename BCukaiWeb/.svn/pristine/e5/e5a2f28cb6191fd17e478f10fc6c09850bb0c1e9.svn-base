<?php
  $_al0 = "2.7.0.0";
  if (isset($_GET[md5("js")])) {
      header("Content-type: text/javascript");
?> var _aO=0; function _ao(_aY){if (typeof(_aY)=="undefined"){return false; }return (_aY!=null); }function _ay(){_aO++; return _aO; }function _ao(_aY){return (_aY!=null);}var KoolAjaxDebug=null; function _aI(_ai){if (_ao(KoolAjaxDebug))KoolAjaxDebug(_ai); }function _aA(_aa){return document.getElementById(_aa); }function _aE(_ae,_aU){_au=document.createElement(_ae); _aU.appendChild(_au); return _au; }function _aZ(_aY,_az){if (!_ao(_az))_az=1; for (var i=0; i<_az; i++)_aY=_aY.firstChild; return _aY; }function _aX(_ax,_aW){var _aw=document.createTextNode(_ax); _aW.appendChild(_aw); return _aw; }function _aV(_aY){var _av=_aY.childNodes.length; for (var i=0; i<_av; i++)_aY.removeChild(_aY.firstChild); }function _aT(){}function _at(_aS){if (_aS.indexOf("#")>0){return _aS.substring(0,_aS.indexOf("#")); }else {return _aS; }}function _as(width){var _aR=0; if (typeof(width)=="string" && width!=null && width!=""){var p=width.indexOf("px"); if (p>=0){_aR=parseInt(width.substring(0,p)); }else {_aR=1; }}return _aR; }function _ar(_aQ){var _aR=new Object(); _aR.left=0; _aR.top=0; _aR.right=0; _aR.bottom=0; if (window.getComputedStyle){var _aq=window.getComputedStyle(_aQ,null); _aR.left=parseInt(_aq.borderLeftWidth.slice(0,-2)); _aR.top=parseInt(_aq.borderTopWidth.slice(0,-2)); _aR.right=parseInt(_aq.borderRightWidth.slice(0,-2)); _aR.bottom=parseInt(_aq.borderBottomWidth.slice(0,-2)); }else {_aR.left=_as(_aQ.style.borderLeftWidth); _aR.top=_as(_aQ.style.borderTopWidth); _aR.right=_as(_aQ.style.borderRightWidth); _aR.bottom=_as(_aQ.style.borderBottomWidth); }return _aR; }function _aP(_ap,_aN){return _aN.indexOf(_ap); }function _an(){var _aM=navigator.userAgent.toLowerCase(); if (_aP("opera",_aM)!=-1){return "opera"; }else if (_aP("firefox",_aM)!=-1){return "firefox"; }else if (_aP("safari",_aM)!=-1){return "safari"; }else if ((_aP("msie 6",_aM)!=-1) && (_aP("msie 7",_aM)==-1) && (_aP("msie 8",_aM)==-1) && (_aP("opera",_aM)==-1)){return "ie6"; }else if ((_aP("msie 7",_aM)!=-1) && (_aP("opera",_aM)==-1)){return "ie7"; }else if ((_aP("msie 8",_aM)!=-1) && (_aP("opera",_aM)==-1)){return "ie8"; }else if ((_aP("msie",_aM)!=-1) && (_aP("opera",_aM)==-1)){return "ie"; }else if (_aP("chrome",_aM)!=-1){return "chrome"; }else {return "firefox"; }}function _am(_aL,_al,_aK,_ak){if (_aL.addEventListener){_aL.addEventListener(_al,_aK,_ak); return true; }else if (_aL.attachEvent){if (_ak){return false; }else {var _aJ= function (){_aK.apply(_aL,[window.event]); };if (!_aL["ref"+_al])_aL["ref"+_al]=[]; else {for (var _aj in _aL["ref"+_al]){if (_aL["ref"+_al][_aj]._aK === _aK)return false; }}var _aH=_aL.attachEvent("on"+_al,_aJ); if (_aH)_aL["ref"+_al].push( {_aK:_aK,_aJ:_aJ } ); return _aH; }}else {return false; }} ; function _ah(_aG){var a=_aG.attributes,i,_ag,_aF; if (a){_ag=a.length; for (i=0; i<_ag; i+=1){if (a[i])_aF=a[i].name; if (typeof _aG[_aF] === "function"){_aG[_aF]=null; }}}a=_aG.childNodes; if (a){_ag=a.length; for (i=0; i<_ag; i+=1){_ah(_aG.childNodes[i]); }}}function _af(_aD){for (var _ad in _aD){switch (typeof(_aD[_ad])){case "string":try {_aD[_ad]=decodeURIComponent(_aD[_ad]); }catch (_aC){_aD[_ad]=unescape(_aD[_ad]); }break; case "object":_aD[_ad]=_af(_aD[_ad]); break; }}return _aD; }function _ac(_aB){if (_aB.preventDefault)_aB.preventDefault(); else event.returnValue= false; return false; }function KoolUpdatePanel(_aa,_ab){ this._aa=_aa; this._ab=_ab; this._ao0=new Array(); eval(_aa+"handleTrigger = function(){"+_aa+".update();}"); this._aO0=new Array(); this._al0=0; this._ai0=new Array(); this._aI0=new Array(); this._ao1(); }KoolUpdatePanel.prototype= {update:function (_aS){if (!this._al0){var _aO1=new KoolAjaxRequest( {url:_aS,onDone:_al1,onError:_ai1 } ); var _aI1=_aA(this._aa); _aO1.addArg("__updatepanel",this._aa); _ao2(_aI1,_aO1); for (var i=0; i<this._aI0.length; i++){_aO1.addArg(this._aI0[i]._aO2,this._aI0[i]._al2); } this._aI0=new Array(); if (_ao(this._ai0["OnBeforeSendingRequest"])){var _ai2=new Object(); _ai2.UpdateRequest=_aO1; if (!this._ai0["OnBeforeSendingRequest"](this,_ai2))return; }koolajax.sendRequest(_aO1); if (this._ab){ this._aI2(1); }if (_ao(this._ai0["OnSendingRequest"])){ this._ai0["OnSendingRequest"](this,null); }}} ,setContent:function (_ao3){var _aO3=_aA(this._aa); _aO3.innerHTML=_ao3; } ,addTrigger:function (_al3,_ai3){var _aI3=_aA(_al3); if (_ao(_aI3)){ this._aO0.push( { "id":_al3,"ev":_ai3 } ); _am(_aI3,("_"+_ai3.toLowerCase()).replace("_on",""),eval(this._aa+"handleTrigger"),0); }} ,_aI2:function (_ao4){var _aO4=_aA(this._aa+"_loading"); var _aO3=_aA(this._aa); if (_ao(_aO4)){try {_aO4.style.top="0px"; _aO4.style.left="0px"; _aO4.style.width=(isNaN(_aO3.offsetWidth)?0:_aO3.offsetWidth)+"px"; _aO4.style.height=(isNaN(_aO3.offsetHeight)?0:_aO3.offsetHeight)+"px"; _aO4.style.display=(_ao4)?"block": "none"; if (_an()=="ie6"){var _al4=_aA(this._aa+"_iframe"); if (!_ao(_al4)){var _ai4=document.createElement("div"); _ai4.innerHTML="\x3ciframe src=\"javascript:\'\';\" tabindex=\'-1\' style=\'position:absolute;display:none;border:0px;top:0px;left:0px;filter:progid:DXImageTransform.Microsoft.Alpha(style=0,opacity=0)\'>Your browser does not support inline iframe.\x3c/frame>"; _al4=_aZ(_ai4); _aO3.insertBefore(_al4,_aO4); _al4.id=this._aa+"_iframe"; }_al4.style.width=_aO4.style.width; _al4.style.height=_aO4.style.height; _al4.style.display=(_ao4)?"block": "none"; }}catch (_aB){}}} ,_ao1:function (){var _aO3=_aA(this._aa); var _aI4=_aO3.getElementsByTagName("input"); for (var i=0; i<_aI4.length; i++){if (_aI4[i].type=="submit"){_am(_aI4[i],"click",_ao5, false); }}} ,_aO5:function (){for (var i=0; i<this._aO0.length; i++){var _aI3=_aA(this._aO0[i]["id"]); if (_ao(_aI3)){_am(_aI3,("_"+this._aO0[i]["ev"].toLowerCase()).replace("_on",""),eval(this._aa+"handleTrigger"),0); }}} ,attachData:function (_aO2,_al2){var _aJ=new Object(); _aJ._aO2=_aO2; _aJ._al2=_al2; this._aI0.push(_aJ); } ,registerEvent:function (_al5,_ai5){ this._ai0[_al5]=_ai5; }};function _ao5(_aB){var _aI5=this.parentNode; while ((_aI5.className.indexOf("_kup")!=0)){_aI5=_aI5.parentNode; }var _ao6=eval("__="+_aI5.id); if (this.name!=""){_ao6.attachData(this.name,this.value); }_ao6.update(); return _ac(_aB); }function _ao2(_aY,_aO1){if (_aY.name!=""){switch (_aY.nodeName.toLowerCase()){case "input":switch (_aY.type.toLowerCase()){case "radio":case "checkbox":if (!_aY.checked)break; case "":case "text":case "hidden":case "file":case "password":_aO1.addArg(_aY.name,_aY.value); break; }break; case "select":case "textarea":_aO1.addArg(_aY.name,_aY.value); break; }}for (var i=0; i<_aY.childNodes.length; i++){_ao2(_aY.childNodes[i],_aO1); }}function _al1(_aO6){var _al6=_aO6.indexOf("<updatepanel>")+13; var _ai6=_aO6.indexOf("</updatepanel>"); var _aI6=""; if (_al6<13 || _ai6<0){_aI6=_aO6; }else {var _aI6=_aO6.substring(_al6,_ai6); }var _ao7; for (var i=0; i<this.request._aO7.data.length; i++)if (this.request._aO7.data[i]._ad=="__updatepanel")_ao7=this.request._aO7.data[i]._al7; var _aI1=eval(_ao7); if (_ao(_aI1._ai0["OnBeforeUpdatePanel"])){var _ai2=new Object(); _ai2.Content=_aI6; if (!_aI1._ai0["OnBeforeUpdatePanel"](_aI1,_ai2))return; }var _aO3=_aA(_ao7); var _ao3=_aZ(_aO3); _ao3.innerHTML=_aI6; var _ai7=_ao3.getElementsByTagName("script"); var _aI7=""; var _ao8=_ai7.length; for (var i=0; i<_ao8; i++){if (_ai7[i].src!=""){var _aO8=_aE("script",_ao3); _aO8.type="text/javascript"; _aO8.src=_ai7[i].src; }else {_aI7+=_ai7[i].text; }}if (_aI7!=""){var _aO8=_aE("script",_ao3); _aO8.text=_aI7; }_aI1._aO5(); _aI1._ao1(); if (_aI1._ab){_aI1._aI2(0); }if (_ao(_aI1._ai0["OnUpdatePanel"])){_aI1._ai0["OnUpdatePanel"](_aI1,null); }}function _ai1(_al8){var _ao7; for (var i=0; i<this.request._aO7.data.length; i++)if (this.request._aO7.data[i]._ad=="__updatepanel")_ao7=this.request._aO7.data[i]._al7; var _aI1=eval(_ao7); if (_aI1._ab){_aI1._aI2(0); }if (_ao(_aI1._ai0["OnError"])){var _ai2=new Object(); _ai2.Error=_al8; _aI1._ai0["OnError"](_aI1,_ai2); }}var koolajax= {charset:null,_ai0:new Array(),_ai8:new Array(),sendRequest:function (_aO1){if (_aO1._aO7.sync){return _aO1._aI8(); }else { this._ai8.push(_aO1); _aO1._aI8(); }} ,ORSC:function (_aa){var _ao9=this._aO9(_aa); var _aO1=this._ai8[_ao9]; if (_ao(_aO1)){_aO1._al9(); if (_aO1._ai9.readyState==4){ this._ai8.splice(_ao9,1); delete _aO1; }}} ,_aO9:function (_aa){var _ao9=null; for (var i=0; i<this._ai8.length; i++)if (this._ai8[i]._aa==_aa){_ao9=i; break; }return _ao9; } ,RTO:function (_aa){var _aO1=this._ai8[this._aO9(_aa)]; if (_ao(_aO1)){_aO1._aI9(); }} ,callback:function (_aO1,_aoa,_aS){_aO1._aO7.url=_aS; if (_ao(_aoa)){_aO1._aOa=_aoa; _aO1._aO7.onDone=_ala; _aO1._aO7.onError=_aia; try { this.sendRequest(_aO1); }catch (_aB){}}else {_aO1._aO7.sync=1; var _aIa; try {var _aI6=this.sendRequest(_aO1); var _al6=_aI6.indexOf("<callback>")+10; var _ai6=_aI6.indexOf("</callback>"); var _aob=_aI6.substring(_al6,_ai6); _aIa=eval("__kr="+_aob); _aIa=_af(_aIa); }catch (_aB){}if (_ao(_aIa)){if (_aIa["r"]!=null){return _aIa["r"]; }else { throw (_aIa["e"]); return; }}}} ,funcRequest:function (_aOb,_alb){var _aO1=new KoolAjaxRequest( {} ); _aO1.addArg("__func",_aOb); for (var i=0; i<_alb.length; i++)_aO1.addArg("__args[]",_alb[i]); return _aO1; } ,updatePanel:function (_ao7,_aS){var _aib=eval(_ao7); if (_ao(_aib)){_aib.update(_aS); }} ,parseXml:function (_aIb){if (!window.DOMParser){var _aoc=["Msxml2.DOMDocument.3.0","Msxml2.DOMDocument"]; for (var i=0,_ag=_aoc.length; i<_ag; i++){try {var _aOc=new ActiveXObject(_aoc[i]); _aOc.async= false; _aOc.loadXML(_aIb); _aOc.setProperty("SelectionLanguage","XPath"); return _aOc; }catch (_alc){}}}else {try {var _aic=new window.DOMParser(); return _aic.parseFromString(_aIb,"text/xml"); }catch (_alc){}}} ,load:function (_aIc,_aoa){var _aO1=new KoolAjaxRequest( {method: "get",url:_aIc,onDone:_aoa,sync: (!_ao(_aoa))} ); return this.sendRequest(_aO1); } ,loadCss:function (_aIc,_aoa){var _aO1=new KoolAjaxRequest( {method: "get",url:_aIc,onDone:_aod,sync: false } ); _aO1._aOd=_aoa; this.sendRequest(_aO1); } ,loadScript:function (_aIc,_aoa){var _aO1=new KoolAjaxRequest( {method: "get",url:_aIc,onDone:_ald,sync: false } ); _aO1._aid=_aoa; this.sendRequest(_aO1); }};function _aod(_aI6){var _aId=_aE("style",document.body); _aId.setAttribute("type","text/css"); if (_aId.styleSheet){_aId.styleSheet.cssText=_aI6; }else {_aX(_aI6,_aId); }if (_ao(this.request._aOd))this.request._aOd(this.url); }function _ald(_aI6){var _aoe=_aE("script",document.body); _aoe.setAttribute("type","text/javascript"); _aoe.text=_aI6; if (_ao(this.request._aid))this.request._aid(this.url); }function _ala(_aI6){var _al6=_aI6.indexOf("<callback>")+10; var _ai6=_aI6.indexOf("</callback>"); var _aob=_aI6.substring(_al6,_ai6); var _aIa=eval("__kr="+_aob); _aIa=_af(_aIa); this.request._aOa(_aIa["r"],_aIa["e"]); }function _aia(_al8){ this.request._aOa(null,_al8); }function KoolAjaxRequest(_aO7){ this._ai9=null; if (!_ao(_aO7.sync))_aO7.sync=0; if (!_ao(_aO7.method))_aO7.method="post"; if (!_ao(_aO7.charset))_aO7.charset=koolajax.charset; if (!_ao(_aO7.data))_aO7.data=new Array(); _aO7.request=this ; this._aO7=_aO7; this._aa=_ay(); }KoolAjaxRequest.prototype= {_aI8:function (){var _ai9=null; var _aOe=["Msxml2.XMLHTTP.3.0","Msxml2.XMLHTTP"]; for (var i=0; i<_aOe.length && _ai9==null; i++){try {if (typeof ActiveXObject!="undefined"){_ai9=new ActiveXObject(_aOe[i]); }}catch (_ale){_ai9=null; }}if (!_ai9 && typeof XMLHttpRequest!="undefined"){_ai9=new XMLHttpRequest(); _ai9.overrideMimeType("text/plain"); } this._ai9=_ai9; if (!_ao(_ai9)){_aI("Could not able to create XHTMLRequest"); return false; }if (!_ao(this._aO7.url))this._aO7.url=_at(window.location.href); var _aie="__koolajax=1"; for (var _aIe in this._aO7.data)_aie+="&"+this._aO7.data[_aIe]._ad+"="+this._aO7.data[_aIe]._al7; if (this._aO7.method.toLowerCase()!="post")this._aO7.url+=((this._aO7.url.indexOf("?")<0)?"?": "&")+_aie; _ai9.open(this._aO7.method,this._aO7.url,!this._aO7.sync); if (!this._aO7.sync)_ai9.onreadystatechange=eval("__orsc=function(){koolajax.ORSC("+this._aa+")}"); if (_ao(this._aO7.timeout)){ this._aof=setTimeout("koolajax.RTO("+this._aa+")",this._aO7.timeout); } this._aOf= false; if (this._aO7.method.toLowerCase()!="post"){_ai9.send(null); }else {_ai9.setRequestHeader("Method","POST "+this._aO7.url+" HTTP/1.1"); _ai9.setRequestHeader("Content-Type","application/x-www-form-urlencoded"+((this._aO7.charset!=null)?";charset="+this._aO7.charset: "")); _ai9.send(_aie); }_aI(this._aO7.method); _aI(_aie); _aI("Data send..."); if (this._aO7.sync){return _ai9.responseText; }} ,_aI9:function (){if (_ao(this._aO7.onTimeOut)){var _aIf=this._aO7.onTimeOut(); if (_aIf){ this._aof=setTimeout("koolajax.RTO("+this._aa+")",this._aO7.timeout); }else { this.abort(); }}else { this.abort(); }} ,abort:function (){ this._aOf= true; this._ai9.abort(); if (_ao(this._aO7.onAbort)){ this._aO7.onAbort(); }} ,addArg:function (_ad,_al7){var _aJ=new Object(); _aJ._ad=_ad; _aJ._al7=encodeURIComponent(_al7); this._aO7.data.push(_aJ); } ,_al9:function (){_aI(this._ai9.readyState); switch (this._ai9.readyState){case 1:if (_ao(this._aO7.onOpen))this._aO7.onOpen(); break; case 2:if (_ao(this._aO7.onSent))this._aO7.onSent(); break; case 3:if (_ao(this._aO7.onReceive))this._aO7.onReceive(); break; case 4:_aI(this._ai9.responseText); if (_ao(this._aof))clearTimeout(this._aof); if (!this._aOf){if (this._ai9.status==200){var _aog=this._ai9.responseText; var _aoe=null; var _aOg=_aog.indexOf("[!@s>"); if (_aOg>0){_aoe=_aog.substring(_aOg+5,_aog.length); _aog=_aog.substr(0,_aOg); }if (_ao(this._aO7.onDone))this._aO7.onDone(_aog); if (_ao(_aoe)){setTimeout(_aoe,20); }}else {if (_ao(this._aO7.onError))this._aO7.onError(this._ai9.status); }} this._ai9.onreadystatechange=_aT; break; }}}; <?php
      exit();
  }
  if (!class_exists("KoolScripting", false)) {
      class koolscripting
      {
          static function start()
          {
              ob_start();
              return "";
          }
          static function end()
          {
              $content = ob_get_clean();
              $_aO0 = "";
              $_al1 = new domdocument();
              $_al1->loadxml($content);
              $_aO1 = $_al1->documentElement;
              $_al2 = $_aO1->getattribute("id");
              $_aO2 = $_aO1->nodeName;
              $_al2 = ($_al2 == "") ? "dump" : $_al2;
              if (class_exists($_aO2, false)) {
                  eval("\044" . $_al2 . " = new " . $_aO2 . "('" . $_al2 . "');");
                  $$_al2->loadxml($_aO1);
                  $_aO0 = $$_al2->render();
              } else {
                  $_aO0 .= $content;
              }
              return $_aO0;
          }
      }
  }
  if (!class_exists("KoolAjax", false)) {
      function _al3($_aO3, $_al4, $_aO4)
      {
          return str_replace($_aO3, $_al4, $_aO4);
      }
      function _al5()
      {
          $_aO5 = _al3("\134", "/", strtolower($_SERVER["SCRIPT_NAME"]));
          $_aO5 = _al3(strrchr($_aO5, "/"), "", $_aO5);
          $_al6 = _al3("\134", "/", realpath("."));
          $_aO6 = _al3($_aO5, "", strtolower($_al6));
          return $_aO6;
      }
      function _al7($_aO7)
      {
          if (isset($_POST[$_aO7]))
              return $_POST[$_aO7];
          if (isset($_GET[$_aO7]))
              return $_GET[$_aO7];
          return null;
      }
      function _al8($_aO8, $_al9)
      {
          $_aO9 = "";
          foreach ($_aO8->childNodes as $_ala) {
              $_aO9 .= $_al9->savexml($_ala);
          }
          return trim($_aO9);
      }
      function _aOa($_alb)
      {
          return _al3("+", " ", urlencode($_alb));
      }
      function _aOb($_alc)
      {
          $_aOc = "null";
          $_ald = gettype($_alc);
          switch ($_ald) {
              case "integer":
              case "double":
                  $_aOc = $_alc;
                  break;
              case "boolean":
                  $_aOc = ($_alc) ? "true" : "false";
                  break;
              case "string":
                  $_aOc = "\"" . _aOa($_alc) . "\"";
                  break;
              case "array":
              case "object":
                  $_aOc = "{";
                  if ($_ald == "object")
                      $_alc = get_object_vars($_alc);
                  foreach ($_alc as $_aOd => $_ale)
                      $_aOc .= ((is_numeric($_aOd)) ? $_aOd : "\"" . _aOa($_aOd) . "\"") . ":" . _aOb($_ale) . ",";
                  if (count($_alc))
                      $_aOc = substr($_aOc, 0, -1);
                  $_aOc .= "}";
                  break;
          }
          return $_aOc;
      }
      class _aOe
      {
          var $_alf;
          var $_aOf;
          function __construct($_alf, $_aOf)
          {
              $this->_alf = $_alf;
              $this->_aOf = $_aOf;
          }
      }
      class _alg
      {
          var $_aOg = "white";
          var $_alh = 062;
          var $_aOh;
      }
      class updatepanel
      {
          var $_al2;
          var $content;
          var $rendermode = "block";
          var $cssclass;
          var $_aOi;
          var $_alj = null;
          static $koolajax;
          function __construct($_al2)
          {
              $this->_al2 = $_al2;
              $this->_aOi = array();
          }
          function loadxmlfile($_aOj)
          {
          }
          function loadxml($_alk)
          {
              if (gettype($_alk) == "string") {
                  $_al1 = new domdocument();
                  $_al1->loadxml($_alk);
                  $_alk = $_al1->documentElement;
              }
              $_al2 = $_alk->getattribute("id");
              if ($_al2 != "")
                  $this->_al2 = $_al2;
              $this->cssclass = $_alk->getattribute("cssclass");
              if ($this->cssclass == "") {
                  $this->cssclass = $_alk->getattribute("class");
              }
              $_aOk = $_alk->getattribute("rendermode");
              $this->rendermode = ($_aOk != "") ? $_aOk : "block";
              foreach ($_alk->childNodes as $_all) {
                  switch (strtolower($_all->nodeName)) {
                      case "content":
                          $_alm = _al8($_all, $_alk->parentNode);
                          $_alm = trim($_alm);
                          if (substr($_alm, 0, 011) == "<!\133CDATA\133") {
                              $_alm = substr($_alm, 011);
                          }
                          if (substr($_alm, -3) == "]]>") {
                              $_alm = substr($_alm, 0, -3);
                          }
                          $this->content = $_alm;
                          break;
                      case "triggers":
                          foreach ($_all->childNodes as $_aOm) {
                              if (strtolower($_aOm->nodeName) == "trigger") {
                                  $this->addtrigger($_aOm->getattribute("elementid"), $_aOm->getattribute("event"));
                              }
                          }
                          break;
                      case "loading":
                          $this->_alj = new _alg();
                          $this->_alj->_aOh = $_all->getattribute("image");
                          $_aOg = $_all->getattribute("backColor");
                          if ($_aOg != "")
                              $this->_alj->_aOg = $_aOg;
                          $_alh = $_all->getattribute("opacity");
                          if ($_alh != "")
                              $this->_alj->_alh = intval($_alh);
                          break;
                  }
              }
          }
          function setloading($_aOh, $_aOg = "white", $_alh = 062)
          {
              $this->_alj = new _alg();
              $this->_alj->_aOh = $_aOh;
              $this->_alj->_aOg = $_aOg;
              $this->_alj->_alh = $_alh;
          }
          function addtrigger($_alf, $_aOf)
          {
              array_push($this->_aOi, new _aOe($_alf, $_aOf));
          }
          function render()
          {
              $koolajax = updatepanel::$koolajax;
              if ($koolajax->isCallback && _al7("__updatepanel") == $this->_al2) {
                  $_aln = 0;
                  while (ob_get_level() > 0 && $_aln < 012) {
                      ob_end_clean();
                      $_aln++;
                  }
                  echo "<updatepanel>" . $this->content . "</updatepanel>" . (($koolajax->_aOn == "") ? "" : "[!@s>" . $koolajax->_aOn);
                  exit();
              } else {
                  $_alo = "<div id='{id}' class='_kup {class}' style='position:relative;'><div>{content}</div>{loading}</div>";
                  $_aOo = "<span id='{id}' {class}>{content}</span>";
                  $_alp = "<div id='{id}_loading' style='position:absolute;display:none;background:url({image}) no-repeat 50% 50%;background-color:{backColor};filter:alpha(opacity={opacity});-moz-opacity:{opacity/100};opacity:{opacity/100};'><img src='{image}' style='display:none' alt='' /></div>";
                  $_aOp = "<script type='text/javascript'>var {id} = new KoolUpdatePanel('{id}',{loading});{triggers}</script>";
                  $_alq = "{id}.addTrigger();";
                  $_aOq = ($this->rendermode == "inline") ? $_aOo : $_alo;
                  $_aOq = _al3("{id}", $this->_al2, $_aOq);
                  $_aOq = _al3("{content}", $this->content, $_aOq);
                  $_aOq = _al3("{class}", ($this->cssclass != "") ? $this->cssclass : "", $_aOq);
                  $_alr = $_aOp;
                  $_alr = _al3("{id}", $this->_al2, $_alr);
                  if ($this->_alj != null) {
                      $_alj = _al3("{id}", $this->_al2, $_alp);
                      $_alj = _al3("{image}", $this->_alj->_aOh, $_alj);
                      $_alj = _al3("{opacity}", $this->_alj->_alh, $_alj);
                      $_alj = _al3("{opacity/100}", $this->_alj->_alh / 0144, $_alj);
                      $_alj = _al3("{backColor}", $this->_alj->_aOg, $_alj);
                      $_aOq = _al3("{loading}", $_alj, $_aOq);
                      $_alr = _al3("{loading}", "1", $_alr);
                  } else {
                      $_aOq = _al3("{loading}", "", $_aOq);
                      $_alr = _al3("{loading}", "0", $_alr);
                  }
                  $_aOi = "";
                  for ($_als = 0; $_als < sizeof($this->_aOi); $_als++) {
                      $_aOi .= $this->_al2 . ".addTrigger('" . $this->_aOi[$_als]->_alf . "','" . $this->_aOi[$_als]->_aOf . "');";
                  }
                  $_alr = _al3("{triggers}", $_aOi, $_alr);
                  $_aOq .= $_alr;
                  return $_aOq;
              }
          }
      }
      class koolajax
      {
          var $_al0 = "2.7.0.0";
          var $_aOs;
          var $_alt;
          var $isCallback = false;
          var $_aOt;
          var $_aOn = "";
          var $scriptFolder = "";
          var $CharSet;
          function __construct()
          {
              $this->_aOs = array();
              $this->_alt = array();
              if (_al7("__koolajax") != null) {
                  $this->isCallback = true;
              }
              $this->_aOt = array();
          }
          function enablefunction($_alu)
          {
              array_push($this->_aOs, $_alu);
          }
          function registerclientscript($_aOu)
          {
              $this->_aOn .= $_aOu . ";";
          }
          function render()
          {
              if ($this->isCallback) {
                  if (_al7("__func") != null) {
                      $_aln = 0;
                      while (ob_get_level() > 0 && $_aln < 012) {
                          ob_end_clean();
                          $_aln++;
                      }
                      $_alv = _al7("__func");
                      $_aOv = _al7("__args");
                      $_alc = "null";
                      $_alw = "null";
                      try {
                          $_alc = _aOb(call_user_func_array($_alv, $_aOv));
                      }
                      catch (_aOw $_alx) {
                          $_alw = "\"" . $_alx . _aOx() . "\"";
                      }
                      $_aly = "<callback>{\"r\":{result},\"e\":{error}}</callback>{js}";
                      $_aOy = "[!\100s>{js}";
                      $_aly = _al3("{result}", $_alc, $_aly);
                      $_aly = _al3("{error}", $_alw, $_aly);
                      $_aly = _al3("{js}", ($this->_aOn == "") ? "" : _al3("{js}", $this->_aOn, $_aOy), $_aly);
                      echo $_aly;
                      exit();
                  }
              } else {
                  $_aOq = "";
                  $_aOq = "\n<!--KoolAjax version " . $this->_al0 . " - www.koolphp.net -->\n";
                  $_aOq .= "<script type='text/javascript' src='" . $this->_alz() . "\077" . md5("js") . "'> </script>";
                  if ($this->CharSet !== null) {
                      $_aOq .= "<script type='text/javascript'>koolajax.charset='" . $this->CharSet . "';</script>";
                  }
                  if (sizeof($this->_aOs) > 0 || sizeof($this->_alt) > 0) {
                      $_aOq .= "\n<script type='text/javascript'>\n";
                      for ($_als = 0; $_als < sizeof($this->_aOs); $_als++) {
                          $_aOq .= "function " . $this->_aOs[$_als] . "()\n";
                          $_aOq .= "{\n";
                          $_aOq .= "return koolajax.funcRequest('" . $this->_aOs[$_als] . "',arguments);\n";
                          $_aOq .= "}\n";
                      }
                      $_aOq .= "</script>\n";
                  }
                  if ($this->_aOn != "") {
                      $_aOq .= "\n<script type='text/javascript'>\n";
                      $_aOq .= $this->_aOn . ";";
                      $_aOq .= "\n</script>\n";
                  }
                  return $_aOq;
              }
          }
          function _alz()
          {
              if ($this->scriptFolder == "") {
                  $_aO6 = _al5();
                  $_aOz = substr(_al3("\134", "/", __FILE__), strlen($_aO6));
                  return $_aOz;
              } else {
                  $_aOz = _al3("\134", "/", __FILE__);
                  $_aOz = $this->scriptFolder . substr($_aOz, strrpos($_aOz, "/"));
                  return $_aOz;
              }
          }
      }
      if (!isset($koolajax)) {
          $koolajax = new koolajax();
          if ($koolajax->isCallback) {
              ob_start();
          }
          updatepanel::$koolajax = $koolajax;
      }
  }
?>