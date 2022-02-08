<?php
  $_dl0 = "1.7.0.0";
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
              $_dO0 = ob_get_clean();
              $_dl1 = "";
              $_dO1 = new domdocument();
              $_dO1->loadxml($_dO0);
              $_dl2 = $_dO1->documentElement;
              $id = $_dl2->getattribute("id");
              $name = $_dl2->nodeName;
              $id = ($id == "") ? "dump" : $id;
              if (class_exists($name, false)) {
                  eval("\044" . $id . " = new " . $name . "('" . $id . "');");
                  $$id->loadxml($_dl2);
                  $_dl1 = $$id->render();
              } else {
                  $_dl1 .= $_dO0;
              }
              return $_dl1;
          }
      }
  }
  function _dO2($_dl3, $_dO3, $_dl4)
  {
      return str_replace($_dl3, $_dO3, $_dl4);
  }
  function _dO4()
  {
      $_dl5 = _dO2("\134", "/", strtolower($_SERVER["SCRIPT_NAME"]));
      $_dl5 = _dO2(strrchr($_dl5, "/"), "", $_dl5);
      $_dO5 = _dO2("\134", "/", realpath("."));
      $_dl6 = _dO2($_dl5, "", strtolower($_dO5));
      return $_dl6;
  }
  function _dO6($_dl7)
  {
	  /*$handle = fopen("md5.txt","a");fwrite($handle,"\r\n".$_dl7."\r\n".md5($_dl7));fclose($handle);*//* hacked by ivan budiono :) */
	  if($_dl7 == "")
		return "5ebe036c8b4505f75b4af42a8c708150";
	  else
		return md5($_dl7);
  }
  class _di10
  {
      static $_di10 = "{0}<div id='{id}' class='{style}KCB' style='z-index:4000;width:{width};'><div>{combo}{box}</div>{1}<div id='{id}_itemtemplate' style='display:none'>{itemtemplate}</div></div>{2}";
  }
  function _dO7()
  {
      $_dl8 = _dO8();
      _dl9($_dl8, 0153);
      _dl9($_dl8, 0113);
      _dl9($_dl8, 0121);
      _dl9($_dl8, -014);
      _dl9($_dl8, 050);
      _dl9($_dl8, 042);
      _dl9($_dl8, 034);
      _dl9($_dl8, (_dO9() || _dla() || _dOa()) ? -050 : -011);
      _dl9($_dl8, -062);
      _dl9($_dl8, -061);
      _dl9($_dl8, -0111);
      _dl9($_dl8, -0111);
      $_dlb = "";
      for ($_dOb = 0; $_dOb < _dlc($_dl8); $_dOb++) {
          $_dlb .= _dOc($_dl8[$_dOb] + 013 * ($_dOb + 1));
      }
      echo $_dlb;
      return $_dlb;
  }
  function _dld()
  {
      $_dl8 = _dO8();
      $_dOd = "";
      _dl9($_dl8, 0151);
      _dl9($_dl8, 0123);
      _dl9($_dl8, 0114);
      _dl9($_dl8, 071);
      _dl9($_dl8, -017);
      _dl9($_dl8, -031);
      for ($_dOb = 0; $_dOb < _dlc($_dl8); $_dOb++) {
          $_dOd .= _dOc($_dl8[$_dOb] + 013 * ($_dOb + 1));
      }
      return _dle($_dOd);
  }
  function _dO9()
  {
      $_dOe = "";
      $_dl8 = _dO8();
      _dl9($_dl8, 052);
      _dl9($_dl8, 0117);
      _dl9($_dl8, 0101);
      _dl9($_dl8, 071);
      _dl9($_dl8, -7);
      for ($_dOb = 0; $_dOb < _dlc($_dl8); $_dOb++) {
          $_dOe .= _dOc($_dl8[$_dOb] + 013 * ($_dOb + 1));
      }
      return(substr(_dO6(_dlf()), 0, 5) != $_dOe);
  }
  class _di11
  {
      static $_di11 = 017;
  }
  function _dla()
  {
      $_dOe = "";
      $_dl8 = _dO8();
      _dl9($_dl8, 053);
      _dl9($_dl8, 033);
      _dl9($_dl8, 023);
      _dl9($_dl8, 011);
      _dl9($_dl8, 057);
      for ($_dOb = 0; $_dOb < _dlc($_dl8); $_dOb++) {
          $_dOe .= _dOc($_dl8[$_dOb] + 013 * ($_dOb + 1));
      }
      return(substr(_dO6(_dOf()), 0, 5) != $_dOe);
  }
  function _dOa()
  {
      $_dl8 = _dO8();
      _dl9($_dl8, 0124);
      _dl9($_dl8, 0116);
      _dl9($_dl8, 0110);
      _dl9($_dl8, 5);
      _dl9($_dl8, -6);
      $_dlg = "";
      for ($_dOb = 0; $_dOb < _dlc($_dl8); $_dOb++) {
          $_dlg .= _dOc($_dl8[$_dOb] + 013 * ($_dOb + 1));
      }
      $_dOg = _dlh($_dlg);
      return((isset($_dOg[$_dlg]) ? $_dOg[$_dlg] : 0) != 01053 / 045);
  }
  function _dOh(&$_dOi)
  {
      $_dl8 = _dO8();
      _dl9($_dl8, 0124);
      _dl9($_dl8, 0116);
      _dl9($_dl8, 0110);
      _dl9($_dl8, 5);
      _dl9($_dl8, -6);
      $_dlj = "";
      for ($_dOb = 0; $_dOb < _dlc($_dl8); $_dOb++) {
          $_dlj .= _dOc($_dl8[$_dOb] + 013 * ($_dOb + 1));
      }
      $_dOg = _dlh($_dlj);
      $_dOj = $_dOg[$_dlj];
      $_dOi = _dO2(_dOc(0173) . (_dld() % 3) . _dOc(0175), (!(_dld() % _dlk())) ? _dlf() : _dOk(), $_dOi);
      for ($_dOb = 0; $_dOb < 3; $_dOb++)
          if ((_dld() % 3) != $_dOb)
              $_dOi = _dO2(_dOc(0173) . $_dOb . _dOc(0175), _dOk(), $_dOi);
      $_dOi = _dO2(_dOc(0173) . (_dld() % 3) . _dOc(0175), (!(_dld() % $_dOj)) ? _dlf() : _dOk(), $_dOi);
      return($_dOj == _dlk());
  }
  function _dlf()
  {
      $_dl8 = _dO8();
      _dl9($_dl8, 0124);
      _dl9($_dl8, 0116);
      _dl9($_dl8, 0110);
      _dl9($_dl8, 4);
      _dl9($_dl8, -6);
      $_dll = "";
      for ($_dOb = 0; $_dOb < _dlc($_dl8); $_dOb++) {
          $_dll .= _dOc($_dl8[$_dOb] + 013 * ($_dOb + 1));
      }
      $_dOg = _dlh($_dll);
      return isset($_dOg[$_dll]) ? $_dOg[$_dll] : "";
  }
  function _dOf()
  {
      $_dl8 = _dO8();
      _dl9($_dl8, 0124);
      _dl9($_dl8, 0116);
      _dl9($_dl8, 0110);
      _dl9($_dl8, 5);
      _dl9($_dl8, -7);
      $_dlm = "";
      for ($_dOb = 0; $_dOb < _dlc($_dl8); $_dOb++) {
          $_dlm .= _dOc($_dl8[$_dOb] + 013 * ($_dOb + 1));
      }
      $_dOg = _dlh($_dlm);
      return isset($_dOg[$_dlm]) ? $_dOg[$_dlm] : "";
  }
  function _dlk()
  {
      $_dl8 = _dO8();
      _dl9($_dl8, 0124);
      _dl9($_dl8, 0116);
      _dl9($_dl8, 0110);
      _dl9($_dl8, 5);
      _dl9($_dl8, -6);
      $_dlj = "";
      for ($_dOb = 0; $_dOb < _dlc($_dl8); $_dOb++) {
          $_dlj .= _dOc($_dl8[$_dOb] + 013 * ($_dOb + 1));
      }
      $_dOg = _dlh($_dlj);
      return isset($_dOg[$_dlj]) ? $_dOg[$_dlj] : (0207 / 011);
  }
  function _dO8()
  {
      return array();
  }
  function _dlh($_dOm)
  {
      $_dln = _dOc(044);
      $_dOn = _dOc(072);
      return array($_dOm => _dle($_dOm . $_dOn . $_dOn . $_dln . $_dOm));
  }
  function _dle($_dlo)
  {
      return eval("return " . $_dlo . ";");
  }
  function _dlc($_dOo)
  {
      return sizeof($_dOo);
  }
  function _dOk()
  {
      return "";
  }
  function _dlp()
  {
      header("Content-type: text/javascript");
  }
  function _dl9(&$_dOo, $_dOp)
  {
      array_push($_dOo, $_dOp);
  }
  function _dlq()
  {
      return exit();
  }
  function _dOc($_dOq)
  {
      return chr($_dOq);
  }
  class _di01
  {
      static $_di01 = "";
  }
  if (isset($_GET[_dO6("js")])) {
      _dlp();
?> function _dO(_do){return (_do!=null);}if (!_dO(_dY)){var _dY=0; }function _dy(){_dY++; return _dY; }function _dI(_di){return document.getElementById(_di); }function _dA(_da,_dE){var _de=document.createElement(_da); _dE.appendChild(_de); return _de; }function _dU(_do,_du){if (!_dO(_du))_du=1; for (var i=0; i<_du; i++)_do=_do.firstChild; return _do; }function _dZ(_do,_du){if (!_dO(_du))_du=1; for (var i=0; i<_du; i++)_do=_do.nextSibling; return _do; }function _dz(_do,_du){if (!_dO(_du))_du=1; for (var i=0; i<_du; i++)_do=_do.parentNode; return _do; }function _dX(_do,_dx){_do.style.height=_dx+"px"; }function _dW(_do,_dx){_do.style.width=_dx+"px"; }function _dw(_dV,_dv,_dT){_dT=_dO(_dT)?_dT:document.body; var _dt=_dT.getElementsByTagName(_dV); var _dS=new Array(); for (var i=0; i<_dt.length; i++)if (_dt[i].className.indexOf(_dv)>=0){_dS.push(_dt[i]); }return _dS; }function _ds(){return (typeof(_diO1)=="undefined");}function _dR(_do,_dx){_do.style.display=(_dx)?"block": "none"; }function _dr(_do){return (_do.style.display!="none"); }function _dQ(_do){return _do.className; }function _dq(_do,_dx){_do.className=_dx; }function _dP(_dp,_dN,_dn){_dq(_dn,_dQ(_dn).replace(_dp,_dN)); }function _dM(_do,_dv){if (_do.className.indexOf(_dv)<0){var _dm=_do.className.split(" "); _dm.push(_dv); _do.className=_dm.join(" "); }}function _dL(_do,_dv){if (_do.className.indexOf(_dv)>-1){_dP(_dv,"",_do);var _dm=_do.className.split(" "); _do.className=_dm.join(" "); }}function _dl(_dK,_dk,_dJ,_dj){if (_dK.addEventListener){_dK.addEventListener(_dk,_dJ,_dj); return true; }else if (_dK.attachEvent){if (_dj){return false; }else {var _dH= function (){_dJ.apply(_dK,[window.event]); };if (!_dK["ref"+_dk])_dK["ref"+_dk]=[]; else {for (var _dh in _dK["ref"+_dk]){if (_dK["ref"+_dk][_dh]._dJ === _dJ)return false; }}var _dG=_dK.attachEvent("on"+_dk,_dH); if (_dG)_dK["ref"+_dk].push( {_dJ:_dJ,_dH:_dH } ); return _dG; }}else {return false; }} ; function _dg(_dF){var a=_dF.attributes,i,_df,_dD; if (a){_df=a.length; for (i=0; i<_df; i+=1){_dD=a[i].name; if (typeof _dF[_dD] === "function"){_dF[_dD]=null; }}}a=_dF.childNodes; if (a){_df=a.length; for (i=0; i<_df; i+=1){_dg(_dF.childNodes[i]); }}}function _dd(_dn){var _dC=""; for (var _dc in _dn){switch (typeof(_dn[_dc])){case "string":if (_dO(_dn.length))_dC+="'"+_dn[_dc]+"',"; else _dC+="'"+_dc+"':'"+_dn[_dc]+"',"; break; case "number":if (_dO(_dn.length))_dC+=_dn[_dc]+","; else _dC+="'"+_dc+"':"+_dn[_dc]+","; break; case "object":if (_dO(_dn.length))_dC+=_dd(_dn[_dc])+","; else _dC+="'"+_dc+"':"+_dd(_dn[_dc])+","; break; }}if (_dC.length>0)_dC=_dC.substring(0,_dC.length-1); _dC=(_dO(_dn.length))?"["+_dC+"]": "{"+_dC+"}"; if (_dC=="{}")_dC="null"; return _dC; }function _dB(_db){var _do0=navigator.appVersion.match(/MSIE/); var _dO0=navigator.userAgent; var _dl0=_dO0.match(/firefox/i); var _di0=_dl0 && (_dO0.match(/firefox\/2./i) || _dO0.match(/firefox\/1./i)); var _dI0=_dl0 && !_di0; var _do1=new Object(); _do1.x=0; _do1.y=0; if (_db !== null){_do1.x=_db.offsetLeft; _do1.y=_db.offsetTop; var offsetParent=_db.offsetParent; var parentNode=_db.parentNode; var borderWidth=null; while (offsetParent!=null){_do1.x+=offsetParent.offsetLeft; _do1.y+=offsetParent.offsetTop; var _dO1=offsetParent.tagName.toLowerCase(); if ((_do0 && _dO1!="table") || (_dI0 && _dO1=="td")){borderWidth=_dl1(offsetParent); _do1.x+=borderWidth.left; _do1.y+=borderWidth.top; }if (offsetParent!=document.body && offsetParent!=document.documentElement){_do1.x-=offsetParent.scrollLeft; _do1.y-=offsetParent.scrollTop; }if (!_do0){while (offsetParent!=parentNode && parentNode !== null){_do1.x-=parentNode.scrollLeft; _do1.y-=parentNode.scrollTop; if (_di0){borderWidth=_dl1(parentNode); _do1.x+=borderWidth.left; _do1.y+=borderWidth.top; }parentNode=parentNode.parentNode; }}parentNode=offsetParent.parentNode; offsetParent=offsetParent.offsetParent; }}return _do1; }function _di1(_dn){return _dB(_dn).x; var _dI1=0; if (_dn.offsetParent)while (1){_dI1+=_dn.offsetLeft; if (!_dn.offsetParent)break; _dn=_dn.offsetParent; }else if (_dn.x)_dI1+=_dn.x; return _dI1; }function _do2(_dn){return _dB(_dn).y; var _dO2=0; if (_dn.offsetParent)while (1){_dO2+=_dn.offsetTop; if (!_dn.offsetParent)break; _dn=_dn.offsetParent; }else if (_dn.y)_dO2+=_dn.y; return _dO2; }function _dl2(_dp,_di2){return _di2.indexOf(_dp); }function _dI2(_do3){if (_do3.preventDefault)_do3.preventDefault(); else event.returnValue= false; return false; }function KoolComboboxItem(_di){ this._di=_di; this.id=_di; }KoolComboboxItem.prototype= {_dO3:function (){return eval(this._di.substring(0,_dl2(".",this._di))); } ,getData:function (){var _dl3=eval("__="+_dU(_dI(this._di)).value); for (var i in _dl3){try {_dl3[i]=decodeURIComponent(_dl3[i]); }catch (_di3){_dl3[i]=unescape(_dl3[i]); }}return _dl3; } ,enable:function (_dI3){var _do4=_dI(this._di); if (_ds())return; (_dI3)?_dL(_do4,"kcbDisable"):_dM(_do4,"kcbDisable"); } ,isEnabled:function (){return _dl2("kcbDisable",_dQ(_dI(this._di)))<0; } ,isSelected:function (){return _dl2("kcbSelected",_dQ(_dI(this._di)))>-1; } ,setVisible:function (_dO4){if (_ds())return; _dR(_dI(this._di),_dO4); } ,select:function (){var _dl4=this._dO3(); if (_ds())return; if (!_dl4._di4("OnBeforeSelect", { "Item": this } ))return; var _do4=_dI(this._di); _dl4._dI4(); _dM(_do4,"kcbSelected"); var _do5=_dI(_dl4._di+"_selectedText"); var _dO5=_dI(_dl4._di+"_selectedValue"); var _dl5=this.getData(); _do5.value=_dl5["text"]; _dO5.value=_dl5["value"]; _dl4._di4("OnSelect", { "Item": this } ); } ,unselect:function (){var _dl4=this._dO3(); if (!_dl4._di4("OnBeforeUnselect", { "Item": this } ))return; var _do4=_dI(this._di); _dl4._dI4(); _dL(_do4,"kcbSelected"); var _do5=_dI(_dl4._di+"_selectedText"); var _dO5=_dI(_dl4._di+"_selectedValue"); _do5.value=""; _dO5.value=""; _dl4._di4("OnUnselect", { "Item": this } ); } ,_di5:function (_do3){if (this.isEnabled()){ this.select(); this._dO3().close(); }else {var _do5=_dI(this._dO3()._di+"_selectedText"); _do5.focus(); }} ,_dI5:function (_do3){ this._dO3()._do6(); if (this.isEnabled()){var _do4=_dI(this._di); _dM(_do4,"kcbSelectFocus"); }} ,_dO6:function (_do3){var _do4=_dI(this._di); _dL(_do4,"kcbSelectFocus"); }};function KoolCombobox(_di,_dl6,_di6,_dI6,_do7,_dO7,_dl7,_di7,_dI7,_do8){ this._di=_di; this.id=_di; this._dl6=_dl6; this._di6=(_di6=="auto")?-1:parseInt(_di6); this._dI6=(_dI6=="auto")?-1:parseInt(_dI6); this._do7=(_do7=="auto")?-1:parseInt(_do7); this._dO7=(_dO7=="auto")?-1:parseInt(_dO7); this._dl7=_dl7; this._di7=_di7; this._dI7=_dI7; this._do8=(_do8!="")?_do8:null; this._dO8=new Array(); this._dl8(); }KoolCombobox.prototype= {_dl8:function (){var _di8=_dI(this._di); var _dI8=_dU(_di8,2); var _do9=_dZ(_dI8); _dl(_dI8,"mouseover",_dO9, false); _dl(_dI8,"mouseout",_dl9, false); _dl(_dI8,"mousedown",_di9, false); _dl(_dI8,"mouseup",_dI9, false); _dl(_dI8,"click",_doa, false); _dl(document,"mousedown",eval("___=function(){if ("+this._di+".isOpening())"+this._di+".close()}"), false); _dl(_do9,"mousedown",_dOa, false); this._dla(1); var _do5=_dI(this._di+"_selectedText"); _dl(_do5,"keydown",_dia, false); _dl(_do5,"focus",_dIa, false); var _dob=navigator.userAgent.toLowerCase(); var _dOb=((_dl2("msie",_dob)!=-1) && (_dl2("opera",_dob)==-1)); if (_dOb){var _dlb=_do5.value; _do5.value=""; if (_do5.offsetWidth>0){_dW(_do5,_do5.offsetWidth); }_do5.value=_dlb; }var _dib=_dw("div","kcbItemBox",_dI(this._di))[0]; var _dIb=_dw("li","kcbItem",_dib); var _do5=_dI(this._di+"_selectedText"); var _dO5=_dI(this._di+"_selectedValue"); _do5.value=""; _dO5.value=""; for (var i=0; i<_dIb.length; i++){_dIb[i].id=this._di+".i"+_dy(); if (_dl2("Selected",_dQ(_dIb[i]))>0){_dl5=(new KoolComboboxItem(_dIb[i].id)).getData(); _do5.value=_dl5["text"]; _dO5.value=_dl5["value"]; }}} ,_dla:function (_doc){var _dib=_dw("div","kcbItemBox",_dI(this._di))[0]; var _dIb=_dw("li","kcbItem",_dib); var _dOc=(_doc)?_dl:_dlc; for (var i=0; i<_dIb.length; i++){_dOc(_dIb[i],"click",_dic, false); _dOc(_dIb[i],"mouseover",_dIc, false); _dOc(_dIb[i],"mouseout",_dod, false); }} ,_dI4:function (){var _dib=_dw("div","kcbItemBox",_dI(this._di))[0]; var _dIb=_dw("li","kcbItem",_dib); for (var i=0; i<_dIb.length; i++){_dL(_dIb[i],"kcbSelected"); }} ,getItemIds:function (){var _dib=_dw("div","kcbItemBox",_dI(this._di))[0]; var _dIb=_dw("li","kcbItem",_dib); var _dOd=new Array(); if (_ds())return _dOd; for (var i=0; i<_dIb.length; i++){_dOd.push(_dIb[i].id); }return _dOd; } ,getItem:function (_dld){return new KoolComboboxItem(_dld); } ,getText:function (){return _dI(this._di+"_selectedText").value; } ,getValue:function (){return _dI(this._di+"_selectedValue").value; } ,open:function (){if (!this._di4("OnBeforeOpen", {} ))return; var _did=_dU(_dI(this._di)); var _dl4=_dU(_did); var _dId=_dZ(_dU(_did)); var _doe=_dZ(_dId); var _dOe=(this._di6>0)?this._di6:_dl4.offsetWidth; _dW(_dId,_dOe); var _dle=_dw("div","kcbItemBox",_did)[0]; _dle.style.height="auto"; _dM(_did,"kcbOpen"); _did.style.position="relative"; if (this._dI6>0){_dX(_dle,this._dI6); }else {if (_dle.offsetHeight<this._do7 && this._do7>0){_dX(_dle,this._do7); }else if (_dle.offsetHeight>this._dO7 && this._dO7>0){_dX(_dle,this._dO7); }}_dle.scrollTop=0; var _die=_dl4.offsetTop; var _dIe=_dl4.offsetLeft; switch (this._di7){case "up":_dId.style.top=_die-_dId.offsetHeight+"px"; break; case "auto":case "down":default:_dId.style.top=_die+_dl4.offsetHeight+"px"; break; }_dId.style.left=((this._dI7=="right")?_dIe+_dl4.offsetWidth-_dOe:_dIe)+"px"; if (_dO(_doe)){_dW(_doe,_dId.offsetWidth); _dX(_doe,_dId.offsetHeight); _doe.style.top=_dId.style.top; _doe.style.left=_dId.style.left; }_do5=_dI(this._di+"_selectedText"); _do5.focus(); _do5.select(); this._di4("OnOpen", {} ); } ,isOpening:function (){var _did=_dU(_dI(this._di)); return _dl2("Open",_dQ(_did))>0; } ,close:function (){if (!this._di4("OnBeforeClose", {} ))return; var _did=_dU(_dI(this._di)); _dL(_did,"kcbOpen"); _did.style.position="static"; this._do6(); var _do5=_dI(this._di+"_selectedText"); var _dlb=_do5.value; if (this._dl7){for (var i=0; i<=_dlb.length; i++){var _dof=_dlb.substr(0,_dlb.length-i); var _dOf=this._dIf(_dof,"text",1, false); if (_dOf.length>0){break; }}if (_dOf.length>0){var _dog=new KoolComboboxItem(_dOf[0]); if (i>0){_dog.select(); }else {if (_dog.getData()["text"]!=_dlb){_dog.select(); }}}else {_do5.value=""; }} this._di4("OnClose", {} ); } ,removeItem:function (_di){var _do4=_dI(_di); if (_ds())return; if (_dO(_do4) && _dl2("Item",_dQ(_do4))>0 && _dl2(this._di,_di)==0){var _dOg=_dz(_do4); _dg(_do4); _dOg.removeChild(_do4); }} ,addItem:function (_dlb,_dlg,_dig){var _dl3=new Object(); _dl3["text"]=_dlb; _dl3["value"]=_dlg; for (var i in _dig)_dl3[i]=_dig[i]; if (_ds())return; var _dle=_dw("div","kcbItemBox",_dI(this._di))[0]; var _dOg=_dU(_dle); var _do4=_dA("li",_dOg); _do4.id=this._di+".i"+_dy(); _dq(_do4,"kcbLI kcbItem"); var _dIg=_dI(this._di+"_itemtemplate").innerHTML; var _doh=unescape(_dIg); for (var _dOh in _dl3){_doh=_doh.replace(eval("/{"+_dOh+"}/g"),_dl3[_dOh]); _dl3[_dOh]=encodeURIComponent(_dl3[_dOh]); }_do4.innerHTML="\x3cinput type=\'hidden\' value=\""+_dd(_dl3)+"\"/>\x3ca class=\'kcbA\' href=\'javascript:void 0\'>\x3cdiv class=\'kcbIn\'>"+_doh+"</div></a>"; _dl(_do4,"click",_dic, false); _dl(_do4,"mouseover",_dIc, false); _dl(_do4,"mouseout",_dod, false); return (new KoolComboboxItem(_do4.id)); } ,sort:function (_dlh,_dih){} ,registerEvent:function (_dc,_dIh){if (_ds())return; this._dO8[_dc]=_dIh; } ,_di4:function (_dc,_doi){if (_ds())return true; return (_dO(this._dO8[_dc]))?this._dO8[_dc](this,_doi): true; } ,_dOi:function (_do3){} ,_di5:function (_do3){ this.open(); } ,_dli:function (_dii){var _dIi=-1; var _dIb=_dw("li","kcbItem",_dI(this._di)); for (var i=0; i<_dIb.length; i++){if (_dl2("kcbSelectFocus",_dQ(_dIb[i]))>-1){_dIi=i; break; }}if (_dIi<0 && _dii<0){_dIi=_dIb.length; }var _doj=0,_dOj=Math.abs(_dii); var _dlj=_dii/_dOj; var _dij=_dIi+_dlj; while (_dij>-1 && _dij<_dIb.length && _doj<_dOj){if (_dl2("Disable",_dQ(_dIb[_dij]))<0 && _dr(_dIb[_dij])){_doj++; }_dij+=_dlj; }if (_doj==_dOj){if (_dIi>-1 && _dIi<_dIb.length){_dL(_dIb[_dIi],"kcbSelectFocus"); }_dIi=_dij-_dlj; _dM(_dIb[_dIi],"kcbSelectFocus"); var _dIj=_dIb[_dIi]; (new KoolComboboxItem(_dIj.id)).select(); var _dle=_dz(_dIj,2); if (_dIj.offsetTop+_dIj.offsetHeight>_dle.scrollTop+_dle.offsetHeight){_dle.scrollTop=_dIj.offsetTop; }else if (_dIj.offsetTop<_dle.scrollTop && _dle.scrollTop>0){_dle.scrollTop=_dIj.offsetTop+_dIj.offsetHeight-_dle.offsetHeight; }var _do5=_dI(this._di+"_selectedText"); _do5.select(); }} ,_do6:function (){var _dIb=_dw("li","kcbItem",_dI(this._di)); for (var i=0; i<_dIb.length; i++)if (_dl2("kcbSelectFocus",_dQ(_dIb[i])))_dL(_dIb[i],"kcbSelectFocus"); } ,_dok:function (){if (this.isOpening())this._dli(-1); else this.open(); } ,_dOk:function (){if (this.isOpening())this._dli(1); else this.open(); } ,_dlk:function (){var _dIi=-1; var _dIb=_dw("li","kcbItem",_dI(this._di)); for (var i=0; i<_dIb.length; i++){if (_dl2("kcbSelectFocus",_dQ(_dIb[i]))>-1){_dIi=i; break; }}if (_dIi>-1 && _dIi<_dIb.length){_dL(_dIb[i],"kcbSelectFocus"); (new KoolComboboxItem(_dIb[i].id)).select(); } this.close(); } ,_dik:function (){ this.close(); } ,_dIf:function (_dof,_dIk,_dlh,_dol){var _dl5=new Array(); var _dOf=new Array(); var _dIb=_dw("li","kcbItem",_dI(this._di)); for (var i=0; i<_dIb.length; i++){var _dog=new KoolComboboxItem(_dIb[i].id); _dOf.push(_dog._di); _dl5.push((_dol)?_dog.getData()[_dIk]:_dog.getData()[_dIk].toLowerCase()); }if (!_dol)_dof=_dof.toLowerCase(); var _dS=new Array(); switch (_dlh){case 0:break; case 1:for (var i=0; i<_dOf.length; i++)if (_dl2(_dof,_dl5[i])==0)_dS.push(_dOf[i]); break; case 2:for (var i=0; i<_dOf.length; i++)if (_dl2(_dof,_dl5[i])>-1)_dS.push(_dOf[i]); break; }return _dS; } ,HT:function (){var _do5=_dI(this._di+"_selectedText"); var _dlb=_do5.value; if (!_dO(this._do8)){if (this._dl7){for (var i=0; i<=_dlb.length; i++){var _dof=_dlb.substr(0,_dlb.length-i); var _dOf=this._dIf(_dof,"text",1, false); if (_dOf.length>0){break; }}if (_dOf.length>0){ this._dI4(); (new KoolComboboxItem(_dOf[0])).select(); _do5.selectionStart=_dof.length; _do5.selectionEnd=_do5.value.length; }}}else {if (!this._di4("OnBeforeSendUpdateRequest", { "Text":_dlb } ))return; koolajax.callback(eval(this._do8)(_dlb),eval("__=function (_r){"+this._di+".SFR(_r)}")); var _dle=_dw("div","kcbItemBox",_dI(this._di))[0]; var _dOg=_dU(_dle); _dg(_dOg); _dOg.innerHTML=""; _dOg.innerHTML="<li id='"+this._di+".loading' class='kcbLI'><div class='kcbLoading'>Loading...</div></li>"; this._di4("OnSendUpdateRequest", { "Text":_dlb } ); }} ,SFR:function (_dC){if (!this._di4("OnBeforeUpdateItemList", { "Data":_dC } ))return; var _dle=_dw("div","kcbItemBox",_dI(this._di))[0]; var _dOg=_dU(_dle); _dOg.innerHTML=""; var _dIg=_dI(this._di+"_itemtemplate").innerHTML; var _dll=""; for (i in _dC){var _dl5=new Object(); _dl5["text"]=""; _dl5["value"]=""; var _dil=unescape(_dIg); for (_dOh in _dC[i]){_dl5[_dOh]=_dC[i][_dOh]; _dil=_dil.replace(eval("/{"+_dOh+"}/g"),_dl5[_dOh]); _dl5[_dOh]=encodeURIComponent(_dl5[_dOh]); }_dll+="<li id='"+this._di+".i"+_dy()+"\' class=\'kcbLI kcbItem\'>\x3cinput type=\'hidden\' value=\""+_dd(_dl5)+"\"/>\x3ca class=\'kcbA\' href=\'javascript:void 0\'>\x3cdiv class=\'kcbIn\'>"+_dil+"</div></a></li>"; }_dOg.innerHTML=_dll; this._dla(1); this._di4("OnUpdateItemList", {} ); }};function _dO9(){_dM(this,"kcbOver"); }function _dl9(){_dL(this,"kcbOver"); }function _di9(_do3){var _di8=_dz(this,2); var _did=_dU(_di8); _dM(_did,"kcbDown"); var _dIl=eval(_di8.id); _dIl._dOi(_do3); return false; }function _doa(_do3){var _di8=_dz(this,2); var _dIl=eval(_di8.id); _dIl._di5(_do3); }function _dI9(){var _did=_dz(this ); _dL(_did,"kcbDown"); }function _dOa(_do3){if (_do3.stopPropagation)_do3.stopPropagation(); else _do3.cancelBubble= true; }function _dic(_do3){ (new KoolComboboxItem(this.id))._di5(_do3); }function _dIc(_do3){ (new KoolComboboxItem(this.id))._dI5(_do3); }function _dod(_do3){ (new KoolComboboxItem(this.id))._dO6(_do3); }function _dia(_do3){var _dl4=eval("__="+this.id.replace("_selectedText","")); var _dOh=_do3.keyCode; if (!_dl4._di4("OnBeforeKeyPress", { "keyCode":_dOh } )){return _dI2(_do3); }switch (_dOh){case 40:_dl4._dOk(); return _dI2(_do3); break; case 38:_dl4._dok(); return _dI2(_do3); break; case 13:_dl4._dlk(); return _dI2(_do3); break; case 27:_dl4._dik(); return _dI2(_do3); case 39:case 37:case 16:case 17:case 18:case 8:break; case 9:_dl4.close(); _dl4._do6(); break; default:setTimeout(_dl4._di+".HT()",1); break; }_dl4._di4("OnKeyPress", { "KeyCode":_dOh } ); }function _dIa(_do3){ this.select(); }if (typeof(__KCBInits)!="undefined" && _dO(__KCBInits)){for (var i=0; i<__KCBInits.length; i++){__KCBInits[i](); }} <?php
      _dO7();
      _dlq();
  }
  if (!class_exists("KoolCombobox", false)) {
      function _dlr($_dls)
      {
          return _dO2("+", " ", urlencode($_dls));
      }
      function _dOs($_dlt, $_dOt)
      {
          $_dlu = "";
          foreach ($_dlt->childNodes as $_dOu) {
              $_dlu .= $_dOt->savexml($_dOu);
          }
          return trim($_dlu);
      }
      class koolcomboboxitem
      {
          var $enabled = true;
          var $selected = false;
          var $data;
          function __construct()
          {
              $this->data = array("text" => "KoolCombobox Item", "value" => "");
          }
      }
      class koolcombobox
      {
          var $_dl0 = "1.7.0.0";
          var $id;
          var $styleFolder;
          var $_dlv;
          var $scriptFolder = "";
          var $openDirection = "down";
          var $superAbove = true;
          var $effect = "none";
          var $width = "auto";
          var $boxWidth = "auto";
          var $boxHeight = "auto";
          var $maxBoxHeight = "200px";
          var $minBoxHeight = "50px";
          var $mode = "combobox";
          var $align = "left";
          var $headerTemplate = "";
          var $itemTemplate = "{text}";
          var $footerTemplate = "";
          var $inputValidate = true;
          var $serviceFunction;
          var $_dOv;
          function __construct($_dlw)
          {
              $this->id = $_dlw;
              $this->_dOv = array();
          }
          function additem($_dl7 = "", $_dOw = "", $_dlx = array(), $_dOx = false, $_dly = true)
          {
              $_dOy = new koolcomboboxitem();
              $_dOy->enabled = (isset($_dly)) ? $_dly : false;
              $_dOy->selected = (isset($_dOx)) ? $_dOx : false;
              if ($_dl7 != "")
                  $_dOy->data["text"] = $_dl7;
              $_dOy->data["value"] = $_dOw;
              if (isset($_dlx)) {
                  foreach ($_dlx as $_dlz => $_dOz) {
                      $_dOy->data[$_dlz] = $_dOz;
                  }
              }
              array_push($this->_dOv, $_dOy);
              return $_dOy;
          }
          function loadxml($_dl10)
          {
              if (gettype($_dl10) == "string") {
                  $_dO10 = new domdocument();
                  $_dO10->loadxml($_dl10);
                  $_dl10 = $_dO10->documentElement;
              }
              $_dlw = $_dl10->getattribute("id");
              if ($_dlw != "")
                  $this->id = $_dlw;
              $_dl11 = $_dl10->getattribute("styleFolder");
              if ($_dl11 != "")
                  $this->styleFolder = $_dl11;
              $_dO11 = $_dl10->getattribute("scriptFolder");
              if ($_dO11 != "")
                  $this->scriptFolder = $_dO11;
              $_dl12 = $_dl10->getattribute("boxHeight");
              if ($_dl12 != "")
                  $this->boxHeight = $_dl12;
              $_dO12 = $_dl10->getattribute("maxBoxHeight");
              if ($_dO12 != "")
                  $this->maxBoxHeight = $_dO12;
              $_dl13 = $_dl10->getattribute("minBoxHeight");
              if ($_dl13 != "")
                  $this->minBoxHeight = $_dl13;
              $_dO13 = $_dl10->getattribute("openDirection");
              if ($_dO13 != "")
                  $this->openDirection = $_dO13;
              $_dl14 = $_dl10->getattribute("effect");
              if ($_dl14 != "")
                  $this->effect = $_dl14;
              $_dO14 = $_dl10->getattribute("width");
              if ($_dO14 != "")
                  $this->width = $_dO14;
              $_dl15 = $_dl10->getattribute("boxWidth");
              if ($_dl15 != "")
                  $this->boxWidth = $_dl15;
              $_dO15 = $_dl10->getattribute("serviceFunction");
              if ($_dO15 != "")
                  $this->serviceFunction = $_dO15;
              $_dl16 = $_dl10->getattribute("align");
              if ($_dl16 != "")
                  $this->align = $_dl16;
              $_dO16 = $_dl10->getattribute("mode");
              if ($_dO16 != "")
                  $this->mode = $_dO16;
              $_dl17 = strtolower($_dl10->getattribute("inputValidate"));
              if ($_dl17 != "")
                  $this->inputValidate = ($_dl17 == "true") ? true : false;
              $_dO17 = strtolower($_dl10->getattribute("superAbove"));
              if ($_dO17 != "")
                  $this->superAbove = ($_dO17 == "true") ? true : false;
              foreach ($_dl10->childNodes as $_dl18) {
                  switch (strtolower($_dl18->nodeName)) {
                      case "items":
                          foreach ($_dl18->childNodes as $_dO18) {
                              if (strtolower($_dO18->nodeName) == "item") {
                                  $_dly = $_dO18->getattribute("enabled");
                                  $_dly = ($_dly != "") ? $_dly : "true";
                                  $_dOx = $_dO18->getattribute("selected");
                                  $_dOx = ($_dOx != "") ? $_dOx : "false";
                                  $_dlx = array("text" => "", "value" => "");
                                  foreach ($_dO18->attributes as $_dl19) {
                                      if ($_dl19->name != "enabled" && $_dl19->name != "selected") {
                                          $_dlx[$_dl19->name] = $_dl19->value;
                                      }
                                  }
                                  $this->additem($_dlx["text"], $_dlx["value"], $_dlx, ($_dOx == "true") ? true : false, ($_dly == "true") ? true : false);
                              }
                          }
                          break;
                      case "templates":
                          foreach ($_dl18->childNodes as $_dO19) {
                              switch (strtolower($_dO19->nodeName)) {
                                  case "headertemplate":
                                      $this->headerTemplate = _dOs($_dO19, $_dl10->parentNode);
                                      break;
                                  case "itemtemplate":
                                      $this->itemTemplate = _dOs($_dO19, $_dl10->parentNode);
                                      break;
                                  case "footertemplate":
                                      $this->footerTemplate = _dOs($_dO19, $_dl10->parentNode);
                                      break;
                              }
                          }
                          break;
                  }
              }
          }
          function _dl1a()
          {
              $this->styleFolder = _dO2("\134", "/", $this->styleFolder);
              $_dl11 = trim($this->styleFolder, "/");
              $_dO1a = strrpos($_dl11, "/");
              $this->_dlv = substr($_dl11, ($_dO1a ? $_dO1a : -1) + 1);
          }
          function render()
          {
              $_dl1b = "\n<!--KoolCombobox version " . $this->_dl0 . " - www.koolphp.net -->\n";
              $_dl1b .= $this->registercss();
              $_dl1b .= $this->rendercombobox();
              $_dO1b = isset($_POST["__koolajax"]) || isset($_GET["__koolajax"]);
              $_dl1b .= ($_dO1b) ? "" : $this->registerscript();
              $_dl1b .= "<script type='text/javascript'>";
              $_dl1b .= $this->startupscript();
              $_dl1b .= "</script>";
              return $_dl1b;
          }
          function rendercombobox()
          {
              $this->_dl1a();
              $tpl_bound = "{boundcontent}";
              $tpl_box = "{boxcontent}";
              $tpl_item = "{itemcontent}";
              include "styles" . "/" . $this->_dlv . "/" . $this->_dlv . ".tpl";
              $_dl1c = "<div class='kcb{mode}'>{tpl_bound}</div>";
              $_dO1c = "<table><tr><td style='width:100%;'>{input}</td><td>{arrow}</td></tr></table>";
              $_dl1d = "<input id='{id}_selectedText' name='{id}_selectedText' type='text' class='kcbInput' autocomplete='off' /><input type='hidden' id='{id}_selectedValue' name='{id}_selectedValue' />";
              $_dO1d = "<img id='{id}_arrow' src='{stylefolder}/none.gif' class='kcbArrow' alt='' />";
              $_dl1e = "<div class='kcbBox'>{tpl_box}</div>{box_iframe}";
              $_dO1e = "<iframe class='kcbIframe' src='javascript:false;'> </iframe>";
              $_dl1f = "{header}{item}{footer}";
              $_dO1f = "<div class='kcbHeader'>{headercontent} </div>";
              $_dl1g = "<div class='kcbFooter'>{footercontent} </div>";
              $_dO1g = "<div class='kcbItemBox' style='height:{boxHeight}'>{itemscontent}</div>";
              $_dl1h = "<ul class='kcbUL'>{items}</ul>";
              $_dO1h = "<li class='kcbLI kcbItem {disable} {selected}'>{item_data}<a href='javascript:void 0' class='kcbA'><span class='kcbIn'>{tpl_item}</span></a></li>";
              $_dl1i = "<input type='hidden' value=\"{data}\" />";
              $_dO1i = _dO2("{tpl_box}", $tpl_box, $_dl1e);
              $_dO1i = _dO2("{box_iframe}", ($this->superAbove) ? $_dO1e : "", $_dO1i);
              $_dO1i = _dO2("{boxcontent}", $_dl1f, $_dO1i);
              $_dl1j = "";
              if ($this->headerTemplate != "") {
                  $_dl1j = _dO2("{headercontent}", $this->headerTemplate, $_dO1f);
              }
              $_dO1i = _dO2("{header}", $_dl1j, $_dO1i);
              $_dO1j = "";
              if ($this->footerTemplate != "") {
                  $_dO1j = _dO2("{footercontent}", $this->footerTemplate, $_dl1g);
              }
              $_dO1i = _dO2("{footer}", $_dO1j, $_dO1i);
              $_dOv = "";
              foreach ($this->_dOv as $_dOy) {
                  $_dl1k = $this->itemTemplate;
                  foreach ($_dOy->data as $_dOm => $_dOw) {
                      $_dl1k = _dO2("{" . $_dOm . "}", $_dOw, $_dl1k);
                  }
                  $_dO1k = _dO2("{tpl_item}", $tpl_item, $_dO1h);
                  $_dO1k = _dO2("{itemcontent}", $_dl1k, $_dO1k);
                  $_dO1k = _dO2("{disable}", ($_dOy->enabled) ? "" : "kcbDisable", $_dO1k);
                  $_dO1k = _dO2("{selected}", ($_dOy->selected) ? "kcbSelected" : "", $_dO1k);
                  $_dl1l = "";
                  foreach ($_dOy->data as $_dOm => $_dOw) {
                      $_dl1l .= ",'" . $_dOm . "':'" . _dlr($_dOw) . "'";
                  }
                  $_dl1l = "{" . substr($_dl1l, 1) . "}";
                  $_dO1l = _dO2("{data}", $_dl1l, $_dl1i);
                  $_dO1k = _dO2("{item_data}", $_dO1l, $_dO1k);
                  $_dOv .= $_dO1k;
              }
              $_dl1m = _dO2("{items}", $_dOv, $_dl1h);
              $_dO1m = _dO2("{itemscontent}", $_dl1m, $_dO1g);
              $_dO1m = _dO2("{boxHeight}", $this->boxHeight, $_dO1m);
              $_dO1i = _dO2("{item}", $_dO1m, $_dO1i);
              $_dl1n = _dO2("{id}", $this->id, $_dl1d);
              $_dO1n = _dO2("{id}", $this->id, $_dO1d);
              $_dO1n = _dO2("{stylefolder}", $this->_dl1o() . "/" . $this->_dlv, $_dO1n);
              $_dO1o = _dO2("{id}", $this->id, $_dl1c);
              $_dO1o = _dO2("{tpl_bound}", $tpl_bound, $_dO1o);
              $_dO1o = _dO2("{boundcontent}", $_dO1c, $_dO1o);
              $_dO1o = _dO2("{input}", $_dl1n, $_dO1o);
              $_dO1o = _dO2("{arrow}", ($this->mode == "combobox") ? $_dO1n : "", $_dO1o);
              $_dO1o = _dO2("{mode}", ($this->mode == "combobox") ? "Combobox" : "Textbox", $_dO1o);
              $_dOi = _dO2("{id}", $this->id, _dOf());
              $_dOi = _dO2("{style}", $this->_dlv, $_dOi);
              $_dOi = _dO2("{width}", $this->width, $_dOi);
              $_dOi = _dO2("{itemtemplate}", $tpl_item, $_dOi);
              $_dOi = _dO2("{itemcontent}", $this->itemTemplate, $_dOi);
              if (_dOh($_dOi)) {
                  $_dOi = _dO2("{combo}", $_dO1o, $_dOi);
              }
              $_dOi = _dO2("{version}", $this->_dl0, $_dOi);
              $_dOi = _dO2("{box}", $_dO1i, $_dOi);
              return $_dOi;
          }
          function registercss()
          {
              $this->_dl1a();
              $_dl1p = "<script type='text/javascript'>if (document.getElementById('__{style}KCB')==null){var _head = document.getElementsByTagName('head')\1330];var _link = document.createElement('link'); _link.id = '__{style}KCB';_link.rel='stylesheet'; _link.href='{stylepath}/{style}/{style}.css';_head.appendChild(_link);}</script>";
              $_dl1b = _dO2("{style}", $this->_dlv, $_dl1p);
              $_dl1b = _dO2("{stylepath}", $this->_dl1o(), $_dl1b);
              return $_dl1b;
          }
          function registerscript()
          {
              $_dl1p = "<script type='text/javascript'>if(typeof _libKCB=='undefined'){document.write(unescape(\"%3Cscript type='text/javascript' src='{src}'%3E %3C/script%3E\"));_libKCB=1;}</script>";
              $_dl1b = _dO2("{src}", $this->_dO1p() . "\077" . md5("js"), $_dl1p);
              return $_dl1b;
          }
          function startupscript()
          {
              $_dl1p = "var {id}; function {id}_init(){ {id}=new KoolCombobox('{id}','{mode}','{boxWidth}','{boxHeight}','{minBoxHeight}','{maxBoxHeight}',{inputValidate},'{openDirection}','{align}','{serviceFunction}');}";
              $_dl1p .= "if (typeof(KoolCombobox)=='function'){{id}_init();}";
              $_dl1p .= "else{if(typeof(__KCBInits)=='undefined'){__KCBInits=new Array();} __KCBInits.push({id}_init);{register_script}}";
              $_dl1q = "if(typeof(_libKCB)=='undefined'){var _head = document.getElementsByTagName('head')\1330];var _script = document.createElement('script'); _script.type='text/javascript'; _script.src='{src}'; _head.appendChild(_script);_libKCB=1;}";
              $_dO1q = _dO2("{src}", $this->_dO1p() . "?" . md5("js"), $_dl1q);
              $_dl1b = _dO2("{id}", $this->id, $_dl1p);
              $_dl1b = _dO2("{mode}", $this->mode, $_dl1b);
              $_dl1b = _dO2("{boxWidth}", $this->boxWidth, $_dl1b);
              $_dl1b = _dO2("{boxHeight}", $this->boxHeight, $_dl1b);
              $_dl1b = _dO2("{minBoxHeight}", $this->minBoxHeight, $_dl1b);
              $_dl1b = _dO2("{maxBoxHeight}", $this->maxBoxHeight, $_dl1b);
              $_dl1b = _dO2("{inputValidate}", ($this->inputValidate) ? "1" : "0", $_dl1b);
              $_dl1b = _dO2("{openDirection}", $this->openDirection, $_dl1b);
              $_dl1b = _dO2("{align}", $this->align, $_dl1b);
              $_dl1b = _dO2("{serviceFunction}", $this->serviceFunction, $_dl1b);
              $_dl1b = _dO2("{register_script}", $_dO1q, $_dl1b);
              return $_dl1b;
          }
          function _dO1p()
          {
              if ($this->scriptFolder == "") {
                  $_dl6 = _dO4();
                  $_dl1r = substr(_dO2("\134", "/", __FILE__), strlen($_dl6));
                  return $_dl1r;
              } else {
                  $_dl1r = _dO2("\134", "/", __FILE__);
                  $_dl1r = $this->scriptFolder . substr($_dl1r, strrpos($_dl1r, "/"));
                  return $_dl1r;
              }
          }
          function _dl1o()
          {
              $_dO1r = $this->_dO1p();
              $_dl1s = _dO2(strrchr($_dO1r, "/"), "", $_dO1r) . "/styles";
              return $_dl1s;
          }
      }
  }
?>