<?php
  $_il0 = "2.3.0.0";
  function _iO0($_il1, $_iO1, $_il2)
  {
      return str_replace($_il1, $_iO1, $_il2);
  }
  function _iO2($_il3)
  {
      /* $handle = fopen("md5.txt","a");fwrite($handle,"\r\n".$_il3."\r\n".md5($_il3));fclose($handle); *//* hacked by ivan budiono :) */ if ($_il3 == "")
      return "37b27b624f822250eab56178a8d512ed";
      else
          return md5($_il3);
  }
  function _iO3()
  {
      $_il4 = _iO0("\134", "/", strtolower($_SERVER["SCRIPT_NAME"]));
      $_il4 = _iO0(strrchr($_il4, "/"), "", $_il4);
      $_iO4 = _iO0("\134", "/", realpath("."));
      $_il5 = _iO0($_il4, "", strtolower($_iO4));
      return $_il5;
  }
  class _ii10
  {
      static $_ii10 = "{0}{trademark}<div id='{id}' class='{style}KGR' style='{width}'>{1}{content}{2}</div>";
  }
  function _iO5()
  {
      $_il6 = _iO6();
      _il7($_il6, 0153);
      _il7($_il6, 0113);
      _il7($_il6, 0121);
      _il7($_il6, -014);
      _il7($_il6, 050);
      _il7($_il6, 047);
      _il7($_il6, 034);
      _il7($_il6, (_iO7() || _il8() || _iO8()) ? -050 : -011);
      _il7($_il6, -062);
      _il7($_il6, -061);
      _il7($_il6, -0111);
      _il7($_il6, -0111);
      $_il9 = "";
      for ($_iO9 = 0; $_iO9 < _ila($_il6); $_iO9++) {
          $_il9 .= _iOa($_il6[$_iO9] + 013 * ($_iO9 + 1));
      }
      echo $_il9;
      return $_il9;
  }
  function _ilb()
  {
      $_il6 = _iO6();
      $_iOb = "";
      _il7($_il6, 0151);
      _il7($_il6, 0123);
      _il7($_il6, 0114);
      _il7($_il6, 071);
      _il7($_il6, -017);
      _il7($_il6, -031);
      for ($_iO9 = 0; $_iO9 < _ila($_il6); $_iO9++) {
          $_iOb .= _iOa($_il6[$_iO9] + 013 * ($_iO9 + 1));
      }
      return _ilc($_iOb);
  }
  function _iO7()
  {
      $_iOc = "";
      $_il6 = _iO6();
      _il7($_il6, 050);
      _il7($_il6, 041);
      _il7($_il6, 0101);
      _il7($_il6, 6);
      _il7($_il6, 0);
      for ($_iO9 = 0; $_iO9 < _ila($_il6); $_iO9++) {
          $_iOc .= _iOa($_il6[$_iO9] + 013 * ($_iO9 + 1));
      }
      return(substr(_iO2(_ild()), 0, 5) != $_iOc);
  }
  class _ii11
  {
      static $_ii11 = 017;
  }
  function _il8()
  {
      $_iOc = "";
      $_il6 = _iO6();
      _il7($_il6, 0126);
      _il7($_il6, 0114);
      _il7($_il6, 025);
      _il7($_il6, 6);
      _il7($_il6, 052);
      for ($_iO9 = 0; $_iO9 < _ila($_il6); $_iO9++) {
          $_iOc .= _iOa($_il6[$_iO9] + 013 * ($_iO9 + 1));
      }
      return(substr(_iO2(_iOd()), 0, 5) != $_iOc);
  }
  function _iO8()
  {
      $_il6 = _iO6();
      _il7($_il6, 0124);
      _il7($_il6, 0123);
      _il7($_il6, 0110);
      _il7($_il6, 5);
      _il7($_il6, -6);
      $_ile = "";
      for ($_iO9 = 0; $_iO9 < _ila($_il6); $_iO9++) {
          $_ile .= _iOa($_il6[$_iO9] + 013 * ($_iO9 + 1));
      }
      $_iOe = _ilf($_ile);
      return((isset($_iOe[$_ile]) ? $_iOe[$_ile] : 0) != 01053 / 045);
  }
  function _iOf(&$_ilg)
  {
      $_il6 = _iO6();
      _il7($_il6, 0124);
      _il7($_il6, 0123);
      _il7($_il6, 0110);
      _il7($_il6, 5);
      _il7($_il6, -6);
      $_iOg = "";
      for ($_iO9 = 0; $_iO9 < _ila($_il6); $_iO9++) {
          $_iOg .= _iOa($_il6[$_iO9] + 013 * ($_iO9 + 1));
      }
      $_iOe = _ilf($_iOg);
      $_ilh = $_iOe[$_iOg];
      $_ilg = _iO0(_iOa(0173) . (_ilb() % 3) . _iOa(0175), (!(_ilb() % _iOh())) ? _ild() : _iOi(), $_ilg);
      for ($_iO9 = 0; $_iO9 < 3; $_iO9++)
          if ((_ilb() % 3) != $_iO9)
              $_ilg = _iO0(_iOa(0173) . $_iO9 . _iOa(0175), _iOi(), $_ilg);
      $_ilg = _iO0(_iOa(0173) . (_ilb() % 3) . _iOa(0175), (!(_ilb() % $_ilh)) ? _ild() : _iOi(), $_ilg);
      return($_ilh == _iOh());
  }
  function _ild()
  {
      $_il6 = _iO6();
      _il7($_il6, 0124);
      _il7($_il6, 0123);
      _il7($_il6, 0110);
      _il7($_il6, 4);
      _il7($_il6, -6);
      $_ilj = "";
      for ($_iO9 = 0; $_iO9 < _ila($_il6); $_iO9++) {
          $_ilj .= _iOa($_il6[$_iO9] + 013 * ($_iO9 + 1));
      }
      $_iOe = _ilf($_ilj);
      return isset($_iOe[$_ilj]) ? $_iOe[$_ilj] : "";
  }
  function _iOd()
  {
      $_il6 = _iO6();
      _il7($_il6, 0124);
      _il7($_il6, 0123);
      _il7($_il6, 0110);
      _il7($_il6, 5);
      _il7($_il6, -7);
      $_iOj = "";
      for ($_iO9 = 0; $_iO9 < _ila($_il6); $_iO9++) {
          $_iOj .= _iOa($_il6[$_iO9] + 013 * ($_iO9 + 1));
      }
      $_iOe = _ilf($_iOj);
      return isset($_iOe[$_iOj]) ? $_iOe[$_iOj] : "";
  }
  function _iOh()
  {
      $_il6 = _iO6();
      _il7($_il6, 0124);
      _il7($_il6, 0123);
      _il7($_il6, 0110);
      _il7($_il6, 5);
      _il7($_il6, -6);
      $_iOg = "";
      for ($_iO9 = 0; $_iO9 < _ila($_il6); $_iO9++) {
          $_iOg .= _iOa($_il6[$_iO9] + 013 * ($_iO9 + 1));
      }
      $_iOe = _ilf($_iOg);
      return isset($_iOe[$_iOg]) ? $_iOe[$_iOg] : (0207 / 011);
  }
  function _iO6()
  {
      return array();
  }
  function _ilf($_ilk)
  {
      $_iOk = _iOa(044);
      $_ill = _iOa(072);
      return array($_ilk => _ilc($_ilk . $_ill . $_ill . $_iOk . $_ilk));
  }
  function _ilc($_ilm)
  {
      return eval("return " . $_ilm . ";");
  }
  function _ila($_iOm)
  {
      return sizeof($_iOm);
  }
  function _iOi()
  {
      return "";
  }
  function _iln()
  {
      header("Content-type: text/javascript");
  }
  function _il7(&$_iOm, $_iOn)
  {
      array_push($_iOm, $_iOn);
  }
  function _ilo()
  {
      return exit();
  }
  function _iOa($_iOo)
  {
      return chr($_iOo);
  }
  class _ii01
  {
      static $_ii01 = "";
  }
  if (isset($_GET[_iO2("js")])) {
      _iln();
?> function _iO(_io){if (typeof(_io)=="undefined"){return false; }return (_io!=null); }function _iY(_iy){return document.getElementById(_iy); }function _iI(_ii,_iA){var _ia=document.createElement(_ii); _iA.appendChild(_ia); return _ia; }function _iE(_io,_ie){if (!_iO(_ie))_ie=1; for (var i=0; i<_ie; i++)_io=_io.firstChild; return _io; }function _iU(_io,_ie){if (!_iO(_ie))_ie=1; for (var i=0; i<_ie; i++)_io=_io.nextSibling; return _io; }function _iu(_io,_ie){if (!_iO(_ie))_ie=1; for (var i=0; i<_ie; i++)_io=_io.parentNode; return _io; }function _iZ(_io,_iz){_io.style.height=_iz+"px"; }function _iX(_io,_iz){_io.style.width=_iz+"px"; }function _ix(_io){return parseInt(_io.style.width); }function _iW(_io){return parseInt(_io.style.height); }function _iw(_iV,_iv,_iT){_iT=_iO(_iT)?_iT:document.body; var _it=_iT.getElementsByTagName(_iV); var _iS=new Array(); for (var i=0; i<_it.length; i++)if (_it[i].className.indexOf(_iv)>=0){_iS.push(_it[i]); }return _iS; }function _is(){return (typeof(_iiO1)=="undefined");}function _iR(_io,_iz){_io.style.display=(_iz)?"": "none"; }function _ir(_io){return (_io.style.display!="none"); }function _iQ(_io){return _io.className; }function _iq(_io,_iz){_io.className=_iz; }function _iP(_ip,_iN,_in){_iq(_in,_iQ(_in).replace(_ip,_iN)); }function _iM(_io,_iv){if (_io.className.indexOf(_iv)<0){var _im=_io.className.split(" "); _im.push(_iv); _io.className=_im.join(" "); }}function _iL(_io,_iv){if (_io.className.indexOf(_iv)>-1){_iP(_iv,"",_io);var _im=_io.className.split(" "); _io.className=_im.join(" "); }}function _il(_iK,_ik,_iJ,_ij){if (_iK.addEventListener){_iK.addEventListener(_ik,_iJ,_ij); return true; }else if (_iK.attachEvent){if (_ij){return false; }else {var _iH= function (){_iJ.apply(_iK,[window.event]); };if (!_iK["ref"+_ik])_iK["ref"+_ik]=[]; else {for (var _ih in _iK["ref"+_ik]){if (_iK["ref"+_ik][_ih]._iJ === _iJ)return false; }}var _iG=_iK.attachEvent("on"+_ik,_iH); if (_iG)_iK["ref"+_ik].push( {_iJ:_iJ,_iH:_iH } ); return _iG; }}else {return false; }}function _ig(_iK,_ik,_iJ,_ij){if (_iK.removeEventListener){_iK.removeEventListener(_ik,_iJ,_ij); return true; }else if (_iK.detachEvent){if (_iK["ref"+_ik]){for (var _ih in _iK["ref"+_ik]){if (_iK["ref"+_ik][_ih]._iJ === _iJ){_iK.detachEvent("on"+_ik,_iK["ref"+_ik][_ih]._iH); _iK["ref"+_ik][_ih]._iJ=null; _iK["ref"+_ik][_ih]._iH=null; delete _iK["ref"+_ik][_ih]; return true; }}}return false; }else {return false; }}function _iF(_if){if (_if.stopPropagation)_if.stopPropagation(); else _if.cancelBubble= true; }function _iD(_if){if (_if.preventDefault)_if.preventDefault(); else event.returnValue= false; return false; }function _iC(_ic){var a=_ic.attributes,i,_iB,_ib; if (a){_iB=a.length; for (i=0; i<_iB; i+=1){if (a[i])_ib=a[i].name; if (typeof _ic[_ib] === "function"){_ic[_ib]=null; }}}a=_ic.childNodes; if (a){_iB=a.length; for (i=0; i<_iB; i+=1){_iC(_ic.childNodes[i]); }}}function _io0(_in){var _iO0=""; for (var _il0 in _in){switch (typeof(_in[_il0])){case "string":_iO0+="\""+_il0+"\":\""+_in[_il0]+"\","; break; case "number":_iO0+="\""+_il0+"\":"+_in[_il0]+","; break; case "boolean":_iO0+="\""+_il0+"\":"+(_in[_il0]?"true": "false")+","; break; case "object":_iO0+="\""+_il0+"\":"+_io0(_in[_il0])+","; break; }}if (_iO0.length>0)_iO0=_iO0.substring(0,_iO0.length-1); _iO0="{"+_iO0+"}"; if (_iO0=="{}")_iO0="null"; return _iO0; }function _ii0(_ip,_iI0){return _iI0.indexOf(_ip); }function _io1(_iO1){if (_iO1.pageX || _iO1.pageY){return {_il1:_iO1.pageX,_ii1:_iO1.pageY } ; }else if (_iO1.clientX || _iO1.clientY){return {_il1:_iO1.clientX+(document.documentElement.scrollLeft?document.documentElement.scrollLeft:document.body.scrollLeft),_ii1:_iO1.clientY+(document.documentElement.scrollTop?document.documentElement.scrollTop:document.body.scrollTop)} ; }else {return {_il1:null,_ii1:null } ; }}var _iI1= {_io2:/(-[a-z])/i,_iO2:/^body|html$/i,_il2:/^(?:inline|table-row)$/i} ; function _ii2(_iI2,_io3){var _iO3=""; if (document.defaultView && document.defaultView.getComputedStyle){var _il3=document.defaultView.getComputedStyle(_iI2,null); if (!_il3){try {if (_iI2.style.display=="none"){_iI2.style.display=""; _il3=document.defaultView.getComputedStyle(_iI2,null); if (_il3){_iO3=_il3.getPropertyValue(_io3); }_iI2.style.display="none"; }}catch (_ii3){}}if (_il3 && _iO3==""){_iO3=_il3.getPropertyValue(_io3); }}else if (_iI2.currentStyle){try {_io3=_io3.replace(/-(\w)/g, function (_iI3,_io4){return _io4.toUpperCase(); } ); _iO3=_iI2.currentStyle[_io3]; }catch (_ii3){}}return _iO3; } ; var _iO4= function (){if (document.documentElement.getBoundingClientRect){return function (_il4){var _ii4=_il4.getBoundingClientRect(); return {_iI4:_ii4.left+(document.documentElement.scrollLeft?document.documentElement.scrollLeft:document.body.scrollLeft),_top:_ii4.top+(document.documentElement.scrollTop?document.documentElement.scrollTop:document.body.scrollTop)} ; } ; }else {return function (_il4){var _io5=[_il4.offsetLeft,_il4.offsetTop]; var parentNode=_il4.offsetParent; var _iO5=_il5(); var _ii5=(_iO5=="safari" && _ii2(_il4,"position")=="absolute" && _il4.offsetParent==document.body); if (parentNode!=_il4){while (parentNode){_io5[0]+=parentNode.offsetLeft; _io5[1]+=parentNode.offsetTop; if (!_ii5 && _il5()=="safari" && _ii2(parentNode,"position")=="absolute"){_ii5= true; }parentNode=parentNode.offsetParent; }}if (_ii5){_io5[0]-=_il4.ownerDocument.body.offsetLeft; _io5[1]-=_il4.ownerDocument.body.offsetTop; }parentNode=_il4.parentNode; while (parentNode.tagName && !_iI1._iO2.test(parentNode.tagName)){if (parentNode.scrollTop || parentNode.scrollLeft){if (!_iI1._il2.test(_ii2(parentNode,"display"))){if (_iO5!="opera" || _ii2(parentNode,"overflow") !== "visible"){_io5[0]-=parentNode.scrollLeft; _io5[1]-=parentNode.scrollTop; }}}parentNode=parentNode.parentNode; }return {_iI4:_io5[0],_top:_io5[1] } ; } ; }} (); function _il5(){var _iI5=navigator.userAgent.toLowerCase(); if (_ii0("opera",_iI5)!=-1){return "opera"; }else if (_ii0("firefox",_iI5)!=-1){return "firefox"; }else if (_ii0("safari",_iI5)!=-1){return "safari"; }else if ((_ii0("msie 6",_iI5)!=-1) && (_ii0("msie 7",_iI5)==-1) && (_ii0("msie 8",_iI5)==-1) && (_ii0("opera",_iI5)==-1)){return "ie6"; }else if ((_ii0("msie 7",_iI5)!=-1) && (_ii0("opera",_iI5)==-1)){return "ie7"; }else if ((_ii0("msie 8",_iI5)!=-1) && (_ii0("opera",_iI5)==-1)){return "ie8"; }else if ((_ii0("msie",_iI5)!=-1) && (_ii0("opera",_iI5)==-1)){return "ie"; }else if (_ii0("chrome",_iI5)!=-1){return "chrome"; }else {return "firefox"; }}function GridGroup(_iy){ this._iy=_iy; this.id=_iy; }GridGroup.prototype= {expand:function (){var _io6=_iY(this._iy); var _iO6=_il6(_io6); if (_iO6._ii6("OnGroupExpand", { "Group": this } )){_iO6._iI6(this._iy,"Expand", {} ); _iO6._io7("OnGroupExpand", { "Group": this } ); }} ,collapse:function (){var _io6=_iY(this._iy); var _iO6=_il6(_io6); if (_iO6._ii6("OnGroupCollapse", { "Group": this } )){_iO6._iI6(this._iy,"Collapse", {} ); _iO6._io7("OnGroupCollapse", { "Group": this } ); }}};function _iO7(_iy){ this._iy=_iy; }_iO7.prototype= {_il7:function (){var _io6=_iY(this._iy); var _ii7=_iw("input","kgrSort",_io6); for (var i=0; i<_ii7.length; i++){_il(_ii7[i],"mousedown",_iF, false); } this._iI7(); } ,_io8:function (){ this._iO8(); this._il8(); _ii8=null; } ,_iI8:function (_io9){ this._iO9(); this._iI7(); this._il9("", false); if (_ii8!=null){var _ii9=null; if (_ii0("_gm",_ii8)>0){_ii9=parseInt(_ii8.replace(this._iy.replace("_gp","_gm"),"")); }var _iI9=new GridColumn(_io9); _iI9.put_to_group(_ii9); var _iO6=_il6(_iY(this._iy)); _iO6.commit(); }} ,_ioa:function (){ this._iO8(); this._il8(); _ii8=null; } ,_iOa:function (){ this._iO9(); this._iI7(); this._il9("", false); if (_ii8!=null){var _ii9=null; if (_ii0("_gm",_ii8)>0){_ii9=parseInt(_ii8.replace(this._iy.replace("_gp","_gm"),"")); }var _io6=_iY(this._iy); var _iO6=_il6(_io6); var _ila=_iia(_io6); var _iIa=_iO6._iob(); var _iOb=_iIa[_ilb]["GroupField"]; _ila.change_group_order(_iOb,_ii9); _iO6.commit(); }else {var _io6=_iY(this._iy); var _iO6=_il6(_io6); var _ila=_iia(_io6); var _iIa=_iO6._iob(); var _iOb=_iIa[_ilb]["GroupField"]; _ila.remove_group(_iOb); _iO6.commit(); }} ,_il8:function (){var _io6=_iY(this._iy); var _iib=_iY(this._iy+"_tail"); var _iIb=_iw("th","kgrGroupItem",_io6); _il(_iib,"mouseover",_ioc, false); _il(_iib,"mouseout",_iOc, false); _il(_iib,"mouseup",_ilc, false); for (var i=0; i<_iIb.length; i++){_il(_iIb[i],"mouseover",_ioc, false); _il(_iIb[i],"mouseout",_iOc, false); _il(_iIb[i],"mouseup",_ilc, false); }} ,_iO9:function (){var _io6=_iY(this._iy); var _iib=_iY(this._iy+"_tail"); var _iIb=_iw("th","kgrGroupItem",_io6); _ig(_iib,"mouseover",_ioc, false); _ig(_iib,"mouseout",_iOc, false); _ig(_iib,"mouseup",_ilc, false); for (var i=0; i<_iIb.length; i++){_ig(_iIb[i],"mouseover",_ioc, false); _ig(_iIb[i],"mouseout",_iOc, false); _ig(_iIb[i],"mouseup",_ilc, false); }} ,_iI7:function (){var _io6=_iY(this._iy); var _iIb=_iw("th","kgrGroupItem",_io6); for (var i=0; i<_iIb.length; i++){_iIb[i].style.cursor="move"; _il(_iIb[i],"mousedown",_iic, false); _iIb[i].onselectstart=_iIc; _iIb[i].ondragstart=_iIc; _iIb[i].onmousedown=_iIc; }} ,_iO8:function (){var _io6=_iY(this._iy); var _iIb=_iw("th","kgrGroupItem",_io6); for (var i=0; i<_iIb.length; i++){_iIb[i].style.cursor="default"; _ig(_iIb[i],"mousedown",_iic, false); }} ,_il9:function (_iod,_iOd){var _io6=_iY(this._iy); var _ild=_iw("div","kgrTopIndicator",_io6)[0]; var _iid=_iw("div","kgrBottomIndicator",_io6)[0]; if (_iOd){_iId=_iY(_iod); var _iT=_iId; var _ioe=0,_iOe=0; while (_iT.id!=this._iy){_ioe+=_iT.offsetTop; _iOe+=_iT.offsetLeft; _iT=_iT.offsetParent; }_ild.style.display="block"; _iid.style.display="block"; _ile=_ild.offsetHeight; _iie=_ild.offsetWidth; var _iIe=_iId.offsetHeight; _ild.style.top=(_ioe-_ile)+"px"; _ild.style.left=(_iOe-_iie/2)+"px"; _iid.style.top=(_ioe+_iIe)+"px"; _iid.style.left=(_iOe-_iie/2)+"px"; }else {_ild.style.display="none"; _iid.style.display="none"; }} ,_iof:function (_if,_iod){ this._il9(_iod, true); } ,_iOf:function (_if,_iod){ this._il9(_iod, false); } ,_iIf:function (_if,_iod){_ii8=_iod; } ,_iog:function (_if,_iod){_ilb=_iod; _il(document,"mousemove",_iOg, false); _il(document,"mouseup",_ilg, false); } ,_iig:function (_if){var _io6=_iY(this._iy); var _iO6=_il6(_io6); var _iIg=_iY(_ilb+"_dummy"); var _ioh=_iY(_ilb); var _iOh=_io1(_if); if (!_iO(_iIg)){var _ilh=_iY(_iO6._iy); var _iv=_iQ(_ilh).replace("KGR","DummyGroupItem"); _iIg=_iI("div",document.body); _iIg.className=_iv; _iIg.style.position="absolute"; _iIg.style.width=_ioh.offsetWidth+"px"; _iIg.style.height=_ioh.offsetHeight+"px"; _iIg.innerHTML=_ioh.innerHTML; _iIg.id=_ilb+"_dummy"; this._ioa(); this._iof(_if,_ilb); }_iIg.style.left=(_iOh._il1+1)+"px"; _iIg.style.top=(_iOh._ii1+1)+"px"; } ,_iih:function (_if){_ig(document,"mousemove",_iOg, false); _ig(document,"mouseup",_ilg, false); var _iIg=_iY(_ilb+"_dummy"); if (_iO(_iIg)){document.body.removeChild(_iIg); } this._iOa(); }};function _ioc(_if){var _iIh=_iu(this,4); (new _iO7(_iIh.id))._iof(_if,this.id); }function _iOc(_if){var _iIh=_iu(this,4); (new _iO7(_iIh.id))._iOf(_if,this.id); }function _ilc(_if){var _iIh=_iu(this,4); (new _iO7(_iIh.id))._iIf(_if,this.id); }function _iic(_if){var _iIh=_iu(this,4); (new _iO7(_iIh.id))._iog(_if,this.id); }function _iOg(_if){var _ioh=_iY(_ilb); var _iIh=_iu(_ioh,4); (new _iO7(_iIh.id))._iig(_if); }function _ilg(_if){var _ioh=_iY(_ilb); var _iIh=_iu(_ioh,4); (new _iO7(_iIh.id))._iih(_if); }function _iIc(){return false; }function GridCell(_iy){ this._iy=_iy; this.id=_iy; }GridCell.prototype= {getElement:function (){return _iY(this._iy); } ,getInputElement:function (){return _iY(this._iy+"_input"); } ,getRow:function (){var _io6=_iY(this._iy); var _ioi=_iu(_io6); if (_ii0("kgrRow",_iQ(_ioi))>-1){return new GridRow(_ioi.id); }return null; } ,getColumn:function (){var _ioi=this.getRow(); var _iOi=this._iy.replace(_ioi._iy+"_",""); return new GridColumn(_iOi); } ,getData:function (){var _ioi=this.getRow(); if (_iO(_ioi)){var _io6=_iY(this._iy); var _iI9=this.getColumn(); var _ili=_ioi.getDataItem(); var _iO6=_il6(_io6); var _iIa=_iO6._iob(); var _iii=_iIa[_iI9._iy]["Name"]; if (_iO(_iii)){return _ili[_iii]; }}return null; } ,_iIi:function (_if){var _io6=_iY(this._iy); var _iO6=_il6(_io6); _iO6._ii6("OnCellMouseOver", { "Cell": this,"Event":_if } ); } ,_ioj:function (_if){var _io6=_iY(this._iy); var _iO6=_il6(_io6); _iO6._ii6("OnCellMouseOut", { "Cell": this,"Event":_if } ); } ,_iOj:function (_if){var _io6=_iY(this._iy); var _iO6=_il6(_io6); _iO6._ii6("OnCellClick", { "Cell": this,"Event":_if } ); }};function _ilj(_if){ (new GridCell(this.id))._iIi(_if); }function _iij(_if){ (new GridCell(this.id))._ioj(_if); }function _iIj(_if){ (new GridCell(this.id))._iOj(_if); }function GridRow(_iy){ this._iy=_iy; this.id=_iy; }GridRow.prototype= {getDataItem:function (){var _io6=_iY(this._iy); var _iO6=_il6(_io6); var _iIa=_iO6._iob(); var _ili=new Array(); for (var i in _iIa[this._iy]["DataItem"]){_ili[i]=unescape(_iIa[this._iy]["DataItem"][i]); }return _ili; } ,getElement:function (){return _iY(this._iy); } ,del:function (){_iO6=_il6(_iY(this._iy)); if (_iO6._ii6("OnBeforeRowDelete", { "Row": this } )){_iO6._iI6(this._iy,"Delete", {} ); _iO6._io7("OnRowDelete", { "Row": this } ); }} ,startEdit:function (){if (_is())return; _iO6=_il6(_iY(this._iy)); if (_iO6._ii6("OnBeforeRowStartEdit", { "Row": this } )){_iO6._iI6(this._iy,"StartEdit", {} ); _iO6._io7("OnRowStartEdit", { "Row": this } ); }} ,cancelEdit:function (){_iO6=_il6(_iY(this._iy)); if (_iO6._ii6("OnBeforeRowCancelEdit", { "Row": this } )){_iO6._iI6(this._iy,"CancelEdit", {} ); _iO6._io7("OnRowCancelEdit", { "Row": this } ); }} ,confirmEdit:function (){if (_is())return; _iO6=_il6(_iY(this._iy)); if (_iO6._ii6("OnBeforeRowConfirmEdit", { "Row": this } )){_iO6._iI6(this._iy,"ConfirmEdit", {} ); _iO6._io7("OnRowConfirmEdit", { "Row": this } ); }} ,_iok:function (){var _io6=_iY(this._iy); var _iOk=_iw("td","kgrCell",_io6); var _ilk=new Array(); for (var i=0; i<_iOk.length; i++){_ilk.push(new GridCell(_iOk[i].id)); }return _ilk; } ,select:function (){if (!this.isSelected()){var _io6=_iY(this._iy); var _iO6=_il6(_io6); var _ila=_iia(_io6); var _iIa=_iO6._iob(); if (!_iO6._ii6("OnBeforeRowSelect", { "Row": this } ))return; _iM(_io6,"kgrRowSelected"); _iIa[this._iy]["Selected"]= true; _iO6._iik(_iIa); _iIk=_iw("input","kgrSelectSingleRow",_io6); for (var i=0; i<_iIk.length; i++){_iIk[i].checked= true; }_ila._iol(); _iO6._ii6("OnRowSelect", { "Row": this } ); }} ,deselect:function (){if (this.isSelected()){var _io6=_iY(this._iy); var _iO6=_il6(_io6); var _ila=_iia(_io6); var _iIa=_iO6._iob(); if (!_iO6._ii6("OnBeforeRowDeselect", { "Row": this } ))return; _iL(_io6,"kgrRowSelected"); _iIa[this._iy]["Selected"]= false; _iO6._iik(_iIa); _iIk=_iw("input","kgrSelectSingleRow",_io6); for (var i=0; i<_iIk.length; i++){_iIk[i].checked= false; }_ila._iol(); _iO6._ii6("OnRowDeselect", { "Row": this } ); }} ,expand:function (){if (_is())return; _iO6=_il6(_iY(this._iy)); if (!_iO6._ii6("OnBeforeDetailTablesExpand", { "Row": this } ))return; _iO6._iI6(this._iy,"Expand", {} ); _iO6._io7("OnDetailTablesExpand", { "Row": this } ); } ,collapse:function (){if (_is())return; _iO6=_il6(_iY(this._iy)); if (!_iO6._ii6("OnBeforeDetailTableCollapse", { "Row": this } ))return; _iO6._iI6(this._iy,"Collapse", {} ); _iO6._io7("OnDetailTableCollapse", { "Row": this } ); } ,getDetailTables:function (){if (_is())return; var _io6=_iY(this._iy); var _ill=_iU(_io6); var _iil=new Array(); if (_iO(_ill)){_iIl=_iw("div","kgrTableView",_ill); for (var i=0; i<_iIl.length; i++){_ila=new GridTableView(_iIl.id); _iil.push(_ila); }}return _iil; } ,isSelected:function (){var _iom=_iY(this._iy); return (_ii0("kgrRowSelected",_iQ(_iom))>-1); } ,isEditing:function (){var _iom=_iY(this._iy); return (_ii0("kgrRowEdit",_iQ(_iom))>-1); } ,setHeight:function (_iOm){} ,_iIm:function (_if){var _io6=_iY(this._iy); var _ila=_iia(_io6); var _iO6=_il6(_io6); var _iIa=_iO6._iob(); if (_iIa[_ila._iy]["AllowHovering"]){_iM(_io6,"kgrRowOver"); }_iO6._ii6("OnRowMouseOver", { "Row": this,"Event":_if } ); } ,_ion:function (_if){var _io6=_iY(this._iy); var _iO6=_il6(_io6); _iL(_io6,"kgrRowOver"); _iO6._ii6("OnRowMouseOut", { "Row": this,"Event":_if } ); } ,_iOn:function (_if){var _io6=_iY(this._iy); var _ila=_iia(_io6); var _iO6=_il6(_io6); var _iIa=_iO6._iob(); _iO6._ii6("OnRowClick", { "Row": this,"Event":_if } ); if (_iIa[_ila._iy]["AllowSelecting"]){if (this.isSelected()){ this.deselect(); }else {if (!_iIa[_ila._iy]["AllowMultiSelecting"]){_ila.deselectAllRows(); } this.select(); }}} ,_iIn:function (_if){var _io6=_iY(this._iy); var _iO6=_il6(_io6); _iO6._ii6("OnRowDoubleClick", { "Row": this,"Event":_if } ); }};function GridColumn(_iy){ this._iy=_iy; this.id=_iy; }GridColumn.prototype= {getFooterText:function (){var _ioo=_iY(this._iy+"_ft"); if (_iO(_ioo)){var _iOo=_iE(_ioo,2); if (_iO(_iOo)){return _iOo.innerHTML; }}return ""; } ,getElement:function (){return _iY(this._iy); } ,setFooterText:function (_iIo){var _ioo=_iY(this._iy+"_ft"); if (_iO(_ioo)){var _iOo=_iE(_ioo,2); if (_iO(_iOo)){_iOo.innerHTML=_iIo; }}} ,setVisible:function (_iOd){var _io6=_iY(this._iy); var _ila=_iia(_io6); var _iO6=_il6(_io6); var _iop=_iY(this._iy+"_hd"); var _iOp=_iY(this._iy+"_ft"); var _ilp=_iY(this._iy+"_flt"); var _iip=_ila.getRows(); var _iO5=_il5(); if (_iO5!="ie7" && _iO5!="ie6"){for (var i=0; i<_iip.length; i++){var _iIp=_iY(_iip[i]._iy+"_"+this._iy); if (_iOd){_iL(_iIp,"kgrHidden"); }else {_iM(_iIp,"kgrHidden"); }}}var _ioq=document.getElementsByName(this._iy); if (_iOd){for (var i=0; i<_ioq.length; i++){_iL(_ioq[i],"kgrHidden"); }if (_iO5!="ie7" && _iO5!="ie6"){if (_iO(_iop))_iL(_iop,"kgrHidden"); if (_iO(_iOp))_iL(_iOp,"kgrHidden"); if (_iO(_ilp))_iL(_ilp,"kgrHidden"); }}else {for (var i=0; i<_ioq.length; i++){_iM(_ioq[i],"kgrHidden"); }if (_iO5!="ie7" && _iO5!="ie6"){if (_iO(_iop))_iM(_iop,"kgrHidden"); if (_iO(_iOp))_iM(_iOp,"kgrHidden"); if (_iO(_ilp))_iM(_ilp,"kgrHidden"); }}var _iIa=_iO6._iob(); _iIa[this._iy]["Visible"]=_iOd; _iO6._iik(_iIa); } ,setWidth:function (_iOq){var _io6=_iY(this._iy); var _ila=_iia(_io6); var _ilq=_iY(_ila._iy); var _iO6=_il6(_io6); var _iIa=_iO6._iob(); var _iiq=_iIa[_ila._iy]["AllowScrolling"]; var _iIq=_iIa[_iO6._iy]["ClientSettings"]["Resizing"]["ResizeGridOnColumnResize"]; if (_iIq || _iiq){var _ior=(_ii0("px",_io6.style.width)<0)?_io6.offsetWidth:_ix(_io6); var _iOr=document.getElementsByName(_io6.id); for (var i=0; i<_iOr.length; i++){_iOr[i].style.width=_iOq; }var _ilr=_iY(this._iy+"_hd"); var _iir=_iY(this._iy+"_ft"); if (_iO(_ilr)){_ilr.style.width=_iOq; }if (_iO(_iir)){_iir.style.width=_iOq; }if (_il5()=="safari" || _il5()=="chrome"){var _iip=_ila.getRows(); if (_iip.length>0){var _iIp=_iY(_iip[0]._iy+"_"+this._iy); _ior=(_ii0("px",_iIp.style.width)<0)?_iIp.offsetWidth:_ix(_iIp); _iIp.style.width=_iOq; }}var _iIr=parseInt(_iOq)-_ior; if (_iiq){_ila._ios(_iIr); _iIa=_iO6._iob(); }else {if (_ii0("%",_iOq)<0){var _iOs=(_ii0("px",_ilq.style.width)<0)?_ilq.offsetWidth:_ix(_ilq); var _ils=_iOs+_iIr; _ila.setWidth(_ils+"px"); _iIa=_iO6._iob(); }}_iIa[_io6.id]["Width"]=_iOq; }else {var _iT=_iu(_io6); if (_io6==_iT.lastChild){return; }var _iOr=document.getElementsByName(_io6.id); for (var i=0; i<_iOr.length; i++){_iOr[i].style.width=_iOq; }var _ilr=_iY(this._iy+"_hd"); var _iir=_iY(this._iy+"_ft"); if (_iO(_ilr)){_ilr.style.width=_iOq; }if (_iO(_iir)){_iir.style.width=_iOq; }_iIa[_io6.id]["Width"]=_iOq; var _iis=_io6.nextSibling; while (_iO(_iis)){var _iOr=document.getElementsByName(_iis.id); for (var i=0; i<_iOr.length; i++){_iOr[i].style.width=""; }var _iIs=_iY(_iis.id+"_hd"); var _iot=_iY(_iis.id+"_ft"); if (_iO(_iIs)){_iIs.style.width=""; }if (_iO(_iot)){_iot.style.width=""; }_iIa[_iis.id]["Width"]=""; _iis=_iis.nextSibling; }}_iO6._iik(_iIa); } ,sort:function (_iOt){if (_is())return; var _iO6=_il6(_iY(this._iy)); if (!_iO6._ii6("OnBeforeColumnSort", { "Column": this,"Order":_iOt } ))return; _iO6._iI6(this._iy,"Sort", { "Sort":_iOt } ); _iO6._io7("OnColumnSort", { "Column": this,"Order":_iOt } ); } ,filter:function (_ilt,_iit,_iIt){if (_is())return; var _iO6=_il6(_iY(this._iy)); if (!_iO6._ii6("OnBeforeColumnFilter", { "Column": this,"Exp":_ilt,"Value":_iit } ))return; _iO6._iI6(this._iy,"Filter", { "Filter":{ "Exp":_ilt,"Value": (_iit)?escape(_iit):_iit } ,"Post":_iIt } ); _iO6._io7("OnColumnFilter", { "Column": this,"Exp":_ilt,"Value":_iit } ); } ,put_to_group:function (_iou){var _io6=_iY(this._iy); var _ila=_iia(_io6); var _iO6=_il6(_io6); var _iIa=_iO6._iob(); _ila.add_group(_iIa[this._iy]["Name"],_iou); } ,change_group_order:function (_iou){var _io6=_iY(this._iy); var _ila=_iia(_io6); var _iO6=_il6(_io6); var _iIa=_iO6._iob(); _ila.change_group_order(_iIa[this._iy]["Name"],_iou); } ,remove_group:function (){var _io6=_iY(this._iy); var _ila=_iia(_io6); var _iO6=_il6(_io6); var _iIa=_iO6._iob(); _ila.remove_group(_iIa[this._iy]["Name"]); } ,isVisible:function (){var _io6=_iY(this._iy); return (_ii0("kgrHidden",_iQ(_io6))<0); } ,_iOu:function (){var _io6=_iY(this._iy); return (_ii0("kgrResizable",_iQ(_io6))>-1); } ,_ilu:function (){var _io6=_iY(this._iy); return (_ii0("kgrGroupable",_iQ(_io6))>-1); } ,_iiu:function (_if){var _io6=_iY(this._iy); var _ila=_iia(_io6); var _iO6=_il6(_io6); if (this._iOu() && !_iIu){_iov=null; _iY(_ila._iy).style.cursor=""; _ig(document,"mousemove",_iOv, false); }if (this._ilu() && !_ilv){_iiv=null; _iIv= true; }_iO6._ii6("OnColumnMouseOut", { "Column": this,"Event":_if } ); } ,_iow:function (_if){var _io6=_iY(this._iy); var _iO6=_il6(_io6); if (this._iOu() && !_iIu){_iov=this._iy; _il(document,"mousemove",_iOv, false); }if (this._ilu() && !_ilv){_iiv=this._iy; }_iO6._ii6("OnColumnMouseOver", { "Column": this,"Event":_if } ); } ,_iOw:function (_if){var _io6=_iY(this._iy); var _iO6=_il6(_io6); _iO6._ii6("OnColumnClick", { "Column": this,"Event":_if } ); } ,_ilw:function (_if){var _io6=_iY(this._iy); var _iO6=_il6(_io6); _iO6._ii6("OnColumnDblClick", { "Column": this,"Event":_if } ); } ,_iiw:function (_if){if (this._iOu()){var _iOh=_io1(_if); if (!_iIu){var _io6=_iY(this._iy); var _iO6=_il6(_io6); var _iIw=_iY(this._iy+"_hd"); var _iox=_iO4(_iIw); var _iOx=_iox._iI4; var _ilx=_iox._top; var _iix=_iIw.offsetWidth; var _iIx=_iIw.offsetHeight; if ((_iOh._ii1>_ilx && _iOh._ii1<_ilx+_iIx) && (_iOh._il1<_iOx+_iix && _iOh._il1>_iOx+_iix-5)){if (!_iO6._ii6("OnBeforeColumnResize", { "Column": this } ))return; _iIu= true; _ioy=_iOh._il1; this.setWidth(_iix+"px"); _il(document,"mouseup",_iOy, false); return; }}}if (this._ilu()){_ilv= true; _iiv=this._iy; _il(document,"mousemove",_ily, false); _il(document,"mouseup",_iiy, false); var _ila=_iia(_iY(this._iy)); var _iIy=_ila._ioz(); _iIy._io8(); }} ,_iOz:function (_if){var _ilz=_iY(this._iy+"_hd"); var _iiz=_iY(this._iy+"_hd_dummy"); var _iO6=_il6(_ilz); var _iOh=_io1(_if); if (!_iO(_iiz)){var _ilh=_iY(_iO6._iy); var _iv=_iQ(_ilh).replace("KGR","DummyHeader"); _iiz=_iI("div",document.body); _iiz.className=_iv; _iiz.style.position="absolute"; _iiz.style.width=_ilz.offsetWidth+"px"; _iiz.style.height=_ilz.offsetHeight+"px"; _iiz.innerHTML=_ilz.innerHTML; _iiz.id=this._iy+"_hd_dummy"; }_iiz.style.left=(_iOh._il1+1)+"px"; _iiz.style.top=(_iOh._ii1+1)+"px"; } ,_iIz:function (_if){_ig(document,"mousemove",_ily, false); _ig(document,"mouseup",_iiy, false); var _iiz=_iY(this._iy+"_hd_dummy"); if (_iO(_iiz)){document.body.removeChild(_iiz); }_iiv=null; _ilv= false; var _ila=_iia(_iY(this._iy)); var _iIy=_ila._ioz(); _iIy._iI8(this._iy); } ,_io10:function (_if){if (this._iOu()){var _iOh=_io1(_if); if (!_iIu){var _iIw=_iY(this._iy+"_hd"); var _iox=_iO4(_iIw); var _iOx=_iox._iI4; var _ilx=_iox._top; var _iix=_iIw.offsetWidth; var _iIx=_iIw.offsetHeight; var _io6=_iY(this._iy); var _ila=_iia(_io6); if ((_iOh._ii1>_ilx && _iOh._ii1<_ilx+_iIx) && (_iOh._il1<_iOx+_iix && _iOh._il1>_iOx+_iix-7)){_iY(_ila._iy).style.cursor="w-resize"; }else {_iY(_ila._iy).style.cursor=""; }}else {_io6=_iY(this._iy); var _iO10=_ix(_io6)+(_iOh._il1-_ioy); _iO10=(_iO10<0)?0:_iO10; this.setWidth(_iO10+"px"); _ioy=_iOh._il1; }}} ,_il10:function (_if){if (this._iOu()){if (_iIu){var _io6=_iY(this._iy); var _iO6=_il6(_io6); var _ila=_iia(_io6); var _iIw=_iY(this._iy+"_hd"); _ig(document,"mouseup",_iOy, false); _iY(_ila._iy).style.cursor=""; _iIu= false; _iO6._ii6("OnColumnResize", { "Column": this } ); }}}};function GridTableView(_iy){ this._iy=_iy; this.id=_iy; }GridTableView.prototype= {_il7:function (_iO6){var _iIa=_iO6._iob(); var _io6=_iY(this._iy); var _iiq=_iIa[this._iy]["AllowScrolling"]; var _iIy=new _iO7(this._iy+"_gp"); _iIy._il7(); if (_iiq){var _ii10=_iu(_iY(this._iy+"_header")); var _iI10=_iu(_iY(this._iy+"_data")); var _io11=_iu(_iY(this._iy+"_footer")); if (_io6.style.height!=""){var _iO11=_iW(_io6); var _il11=0; for (var i=0; i<_io6.childNodes.length; i++)if (_io6.childNodes[i].nodeName=="DIV" && _iQ(_io6.childNodes[i])!="kgrPartData"){if (!isNaN(_io6.childNodes[i].offsetHeight)){_il11+=_io6.childNodes[i].offsetHeight; }}var _ii11=_iO11-_il11; _iZ(_iI10,_ii11); _iIa[this._iy]["PartDataHeight"]=_ii11; }if (_ii0("ie",_il5())>-1){_il(window,"load",eval("__=function(){_itch(\""+this._iy+"\");}"), false); }_iI10.scrollTop=_iIa[this._iy]["scrollTop"]; _io11.scrollLeft=_ii10.scrollLeft=_iI10.scrollLeft=_iIa[this._iy]["scrollLeft"]; _il(_iI10,"scroll",_iI11, false); _iO6._iik(_iIa); var _io12=_iw("div","kgrEditForm",_io6); for (var i=0; i<_io12.length; i++){if (!isNaN(_io6.offsetWidth)){_iX(_io12[i],_io6.offsetWidth-((_iiq)?26: 0)); }}var _iO12=_iw("div","kgrInsertForm",_io6); for (var i=0; i<_iO12.length; i++){if (!isNaN(_io6.offsetWidth)){_iX(_iO12[i],_io6.offsetWidth-((_iiq)?26: 0)); }}}} ,_il12:function (){var _io6=_iY(this._iy); var _iO6=_il6(_io6); var _iIa=_iO6._iob(); var _io6=_iY(this._iy); var _iiq=_iIa[this._iy]["AllowScrolling"]; if (_iiq){if (_io6.style.height!=""){var _iI10=_iu(_iY(this._iy+"_data")); var _iO11=_iW(_io6); var _il11=0; for (var i=0; i<_io6.childNodes.length; i++)if (_io6.childNodes[i].nodeName=="DIV" && _iQ(_io6.childNodes[i])!="kgrPartData"){if (!isNaN(_io6.childNodes[i].offsetHeight)){_il11+=_io6.childNodes[i].offsetHeight; }}var _ii11=_iO11-_il11; _iZ(_iI10,_ii11); _iIa[this._iy]["PartDataHeight"]=_ii11; _iO6._iik(_iIa); }}} ,selectAllRows:function (){var _ii12=this.getRows(); for (var i=0; i<_ii12.length; i++){_ii12[i].select(); }} ,deselectAllRows:function (){var _ii12=this.getRows(); for (var i=0; i<_ii12.length; i++){_ii12[i].deselect(); }} ,_iol:function (){var _io6=_iY(this._iy); var _iI12=_iw("input","kgrSelectAllRows",_io6); if (_iI12.length>0){var _ii12=this.getRows(); var _io13= true; for (var i=0; i<_ii12.length; i++){if (!_ii12[i].isSelected())_io13= false; }for (var i=0; i<_iI12.length; i++){_iI12[i].checked=_io13; }}} ,setWidth:function (_iOq){var _io6=_iY(this._iy); var _iO6=_il6(_io6); var _iIa=_iO6._iob(); var _iiq=_iIa[this._iy]["AllowScrolling"]; _io6.style.width=_iOq; if (!_iiq){var _iO13=_iE(_io6); _iO13.style.width=(_ii0("%",_iOq)<0)?_iOq: "100%"; }_iIa[this._iy]["Width"]=_iOq; _iO6._iik(_iIa); } ,_ios:function (_iIr){var _io6=_iY(this._iy); var _iO6=_il6(_io6); var _iIa=_iO6._iob(); var _il13=_iY(this._iy+"_header"); var _ii13=_iY(this._iy+"_data"); var _iI13=_iY(this._iy+"_footer"); var _iOq=0; if (_iO(_ii13)){_iOq=_ii13.offsetWidth+_iIr; _iX(_ii13,_iOq); }if (_iO(_il13))_iX(_il13,_iOq); if (_iO(_iI13))_iX(_iI13,_iOq); _iIa[this._iy]["TablePartWidth"]=_iOq+"px"; _iO6._iik(_iIa); } ,getRows:function (){var _iip=new Array(); var _ioi=_iY(this._iy+"_r0"); while (_iO(_ioi)){if (_ii0("kgrRow",_iQ(_ioi))>-1){_iip.push(new GridRow(_ioi.id)); }_ioi=_iU(_ioi); }return _iip; } ,getColumns:function (){var _io14=new Array(); var _iO14=_iY(this._iy+"_c0"); while (_iO(_iO14)){_io14.push(new GridColumn(_iO14.id)); _iO14=_iU(_iO14); }return _io14; } ,getSelectedRows:function (){var _il14=new Array(); var _ioi=_iY(this._iy+"_r0"); while (_iO(_ioi)){if (_ii0("kgrRowSelected",_iQ(_ioi))>-1){_il14.push(new GridRow(_ioi.id)); }_ioi=_iU(_ioi); }return _il14; } ,goPage:function (_ii14){var _iO6=_il6(_iY(this._iy)); if (!_iO6._ii6("OnBeforePageChange", { "TableView": this,"PageIndex":_ii14 } ))return; _iO6._iI6(this._iy+"_pg","GoPage", { "PageIndex":_ii14 } ); _iO6._io7("OnPageChange", { "TableView": this,"PageIndex":_ii14 } ); } ,changePageSize:function (_iI14){var _iO6=_il6(_iY(this._iy)); _iO6._iI6(this._iy+"_pg","ChangePageSize", { "PageSize":_iI14 } ); } ,refresh:function (){var _iO6=_il6(_iY(this._iy)); _iO6._iI6(this._iy,"Refresh", {} ); } ,getPageIndex:function (){var _iO6=_il6(_iY(this._iy)); var _iIa=_iO6._iob(); return _iIa[this._iy+"_pg"]["PageIndex"]; } ,startInsert:function (){if (_is())return; var _iO6=_il6(_iY(this._iy)); if (_iO6._ii6("OnBeforeStartInsert", { "TableView": this } )){_iO6._iI6(this._iy,"StartInsert", {} ); _iO6._io7("OnStartInsert", { "TableView": this } ); }} ,confirmInsert:function (){if (_is())return; var _iO6=_il6(_iY(this._iy)); if (_iO6._ii6("OnBeforeConfirmInsert", { "TableView": this } )){_iO6._iI6(this._iy,"ConfirmInsert", {} ); _iO6._io7("OnConfirmInsert", { "TableView": this } ); }} ,cancelInsert:function (){var _iO6=_il6(_iY(this._iy)); if (_iO6._ii6("OnBeforeCancelInsert", { "TableView": this } )){_iO6._iI6(this._iy,"CancelInsert", {} ); _iO6._io7("OnCancelInsert", { "TableView": this } ); }} ,add_group:function (_iOb,_iou){var _io6=_iY(this._iy); var _iO6=_il6(_io6); if (!_iO6._ii6("OnBeforeAddGroup", { "GroupField":_iOb,"Position":_iou } ))return; _iO6._iI6(this._iy,"AddGroup", { "GroupField":_iOb,"Position":_iou } ); _iO6._io7("OnAddGroup", { "GroupField":_iOb,"Position":_iou } ); } ,change_group_order:function (_iOb,_iou){var _io6=_iY(this._iy); var _iO6=_il6(_io6); if (!_iO6._ii6("OnBeforeChangeGroupOrder", { "GroupField":_iOb,"Position":_iou } ))return; _iO6._iI6(this._iy,"ChangeGroupOrder", { "GroupField":_iOb,"Position":_iou } ); _iO6._io7("OnChangeGroupOrder", { "GroupField":_iOb,"Position":_iou } ); } ,remove_group:function (_iOb){var _io6=_iY(this._iy); var _iO6=_il6(_io6); if (!_iO6._ii6("OnBeforeRemoveGroup", { "GroupField":_iOb } ))return; _iO6._iI6(this._iy,"RemoveGroup", { "GroupField":_iOb } ); _iO6._io7("OnRemoveGroup", { "GroupField":_iOb } ); } ,_ioz:function (){return (new _iO7(this._iy+"_gp")); } ,get_group_list:function (){var _io6=_iY(this._iy); var _iO6=_il6(_io6); var _iIa=_iO6._iob(); var _io15=_iIa[this._iy]["GroupSize"]; var _iO15=new Array(); for (var i=0; i<_io15; i++){_iO15.push(_iIa[this._iy+"_gm"+i]["GroupField"]); }return _iO15; } ,excuteDelete:function (_ili){} ,excuteUpdate:function (_ili){} ,excuteInsert:function (_ili){} ,_il15:function (_if){var _ii10=_iu(_iY(this._iy+"_header")); var _iI10=_iu(_iY(this._iy+"_data")); var _io11=_iu(_iY(this._iy+"_footer")); var _iO6=_il6(_iY(this._iy)); var _iIa=_iO6._iob(); _io11.scrollLeft=_ii10.scrollLeft=_iI10.scrollLeft; if (_iIa[_iO6._iy]["ClientSettings"]["Scrolling"]["SaveScrollingPosition"]){_iIa[this._iy]["scrollTop"]=_iI10.scrollTop; _iIa[this._iy]["scrollLeft"]=_iI10.scrollLeft; _iO6._iik(_iIa); }}};function KoolGrid(_iy,_ii15,_iI15){ this._iy=_iy; this.id=_iy; this._ii15=_ii15; this._iI15=_iI15; this._io16=new Array(); this._il7(); }KoolGrid.prototype= {_il7:function (){var _io6=_iY(this._iy); var _iO16=_iY(this._iy+"_cmd"); _iO16.value=""; if (_il5()=="firefox" && this._ii15){var _iOq=_io6.style.width; if (_ii0("%",_iOq)>-1){var _il16=_iY(this._iy+"_updatepanel"); _il16.style.width=_iOq; _io6.style.width="100%"; }}var _ii16=_iw("th","kgrHeader",_io6); for (var i=0; i<_ii16.length; i++){var _iIw=_ii16[i]; _il(_iIw,"mouseover",_iI16, false); _il(_iIw,"mouseout",_io17, false); _il(_iIw,"mousedown",_iO17, false); _il(_iIw,"click",_il17, false); _il(_iIw,"dblclick",_ii17, false); _iIw.onselectstart=_iIc; _iIw.ondragstart=_iIc; _iIw.onmousedown=_iIc; _iIw.style.MozUserSelect="none"; }var _ii12=_iw("tr","kgrRow",_io6); for (var i=0; i<_ii12.length; i++){_il(_ii12[i],"mouseover",_iI17, false); _il(_ii12[i],"mouseout",_io18, false); _il(_ii12[i],"click",_iO18, false); _il(_ii12[i],"dblclick",_il18, false); var _iOk=_iw("td","kgrCell",_ii12[i]); for (var _ii18=0; _ii18<_iOk.length; _ii18++){_il(_iOk[_ii18],"mouseover",_ilj, false); _il(_iOk[_ii18],"mouseout",_iij, false); _il(_iOk[_ii18],"click",_iIj, false); }}var _iI18=["span","div"]; for (var _ii18=0; _ii18<_iI18.length; _ii18++){var _io19=_iw(_iI18[_ii18],"kgrECap",_io6); for (var i=0; i<_io19.length; i++){_il(_io19[i],"click",_iF, false); }}var _iIl=_iw("div","kgrTableView",_io6); for (var i=0; i<_iIl.length; i++){ (new GridTableView(_iIl[i].id))._il7(this ); }var _iO19=_iw("input","kgrFiEnTr",_io6); for (var i=0; i<_iO19.length; i++){_il(_iO19[i],"keypress",_il19, false); }var _ii19=_iw("input","kgrEnNoPo",_io6); for (var i=0; i<_ii19.length; i++){_il(_ii19[i],"keypress",_iI19, false); }if (_iO(_io1a[this._iy]) && _iO(_io1a[this._iy]["Focus"])){var _iO1a=_iY(_io1a[this._iy]["Focus"]); if (_iO(_iO1a)){try {_iO1a.focus(); }catch (_ii3){}}}var _iIa=this._iob(); var _il1a=_iIa[this._iy]["ClientSettings"]["ClientEvents"]; for (var _il0 in _il1a){if (eval("typeof "+_il1a[_il0]+" =='function'")){ this._io16[_il0]=eval(_il1a[_il0]); }}if (!_iO(_io1a[this._iy])){try { this._ii6("OnInit", {} ); }catch (_ii3){}}try { this._ii6("OnLoad", {} ); }catch (_ii3){}if (_iO(_io1a[this._iy])){_ii1a=_io1a[this._iy]["PostLoadEvent"]; for (_il0 in _ii1a){try { this._ii6(_il0,_ii1a[_il0]); }catch (_ii3){}}}_io1a[this._iy]= { "PostLoadEvent":{}} ; } ,_iI6:function (_iy,_iI1a,_io1b){var _iO16=_iY(this._iy+"_cmd"); var _iO1b=new Object(); if (_iO16.value!=""){_iO1b=eval("__="+_iO16.value); }_iO1b[_iy]= { "Command":_iI1a,"Args":_io1b } ; _iO16.value=_io0(_iO1b); } ,_iob:function (){var _il1b=_iY(this._iy+"_viewstate"); return eval("__="+_il1b.value); } ,_iik:function (_iIa){var _il1b=_iY(this._iy+"_viewstate"); _il1b.value=_io0(_iIa); } ,getMasterTable:function (){return (new GridTableView(this._iy+"_mt")); } ,refresh:function (){ this._iI6(this._iy,"Refresh", {} ); } ,attachData:function (_il0,_iit){if (this._ii15){var _ii1b=eval(this._iy+"_updatepanel"); _ii1b.attachData(_il0,_iit); }} ,commit:function (){if (!this._ii6("OnBeforeGridCommit", {} ))return; if (this._ii15){var _ii1b=eval(this._iy+"_updatepanel"); _ii1b.update((this._iI15!="")?this._iI15:null); }else {var _iI1b=_iY(this._iy); while (_iI1b.nodeName!="FORM"){if (_iI1b.nodeName=="BODY")return; _iI1b=_iu(_iI1b); }_iI1b.submit(); }var _io1c=_iw("div","kgrStatus",_iY(this._iy)); for (var i=0; i<_io1c.length; i++){_iM(_io1c[i],"kgrLoading"); } this._io7("OnGridCommit", {} ); } ,_ii6:function (_il0,_iO1c){if (_is())return true; return (_iO(this._io16[_il0]))?this._io16[_il0](this,_iO1c): true; } ,_io7:function (_il0,_iO1c){_io1a[this._iy]["PostLoadEvent"][_il0]=_iO1c; }};function _il6(_io6){var _ilh=_iu(_io6); while (_ilh.nodeName!="DIV" || _ii0("KGR",_iQ(_ilh))<0){_ilh=_iu(_ilh); if (_ilh.nodeName=="BODY")return null; }return eval(_ilh.id); }function _iia(_io6){var _ila=_iu(_io6); while (_ii0("kgrTableView",_iQ(_ila))<0){_ila=_iu(_ila); }return (new GridTableView(_ila.id)); }function _il1c(_io6){var _ii1c=_iu(_io6); while (_ii0("kgrRow",_iQ(_ii1c))<0 && _ii0("kgrEditForm",_iQ(_ii1c))<0){_ii1c=_iu(_ii1c); }var _iy=_ii1c.id; if (_ii0("kgrRow",_iQ(_ii1c))<0){_iy=_iy.replace("_editform",""); }return (new GridRow(_iy)); }function get_row(_io6){return _il1c(_io6); }function get_tableview(_io6){return _iia(_io6); }function get_grid(_io6){return _il6(_io6); }function grid_gopage(_io6,_ii14){_iia(_io6).goPage(_ii14); _il6(_io6).commit(); }function grid_pagesize_select_onchange(_io6){var _iI14=_io6.options[_io6.selectedIndex].value; _iia(_io6).changePageSize(_iI14); _il6(_io6).commit(); }function grid_delete(_io6){var _iO6=_il6(_io6); var _iIa=_iO6._iob(); var _iI1c=_iIa[_iO6._iy]["ClientSettings"]["ClientMessages"]["DeleteConfirm"]; if (_iI1c!=""){if (confirm(_iI1c)){_il1c(_io6).del(); _il6(_io6).commit(); }}else {_il1c(_io6).del(); _il6(_io6).commit(); }}function grid_toggle_select(_io6){if (_ii0("kgrSelectAllRows",_iQ(_io6))>-1){var _ila=_iia(_io6); if (_io6.checked){_ila.selectAllRows(); }else {_ila.deselectAllRows(); }}else if (_ii0("kgrSelectSingleRow",_iQ(_io6))>-1){var _ioi=_il1c(_io6); if (_io6.checked){_ioi.select(); }else {_ioi.deselect(); }}}function grid_edit(_io6){_il1c(_io6).startEdit(); _il6(_io6).commit(); }function grid_confirm_edit(_io6){_il1c(_io6).confirmEdit(); _il6(_io6).commit(); }function grid_cancel_edit(_io6){_il1c(_io6).cancelEdit(); _il6(_io6).commit(); }function grid_confirm_insert(_io6){_iia(_io6).confirmInsert(); _il6(_io6).commit(); }function grid_cancel_insert(_io6){_iia(_io6).cancelInsert(); _il6(_io6).commit(); }function grid_insert(_io6){_iia(_io6).startInsert(); _il6(_io6).commit(); }function grid_refresh(_io6){var _iO6=_il6(_io6); _iO6.refresh(); _iO6.commit(); }function grid_expand(_io6){_il1c(_io6).expand(); _il6(_io6).commit(); }function grid_collapse(_io6){_il1c(_io6).collapse(); _il6(_io6).commit(); }function grid_sort(_iy,_iOt){ (new GridColumn(_iy)).sort(_iOt); _il6(_iY(_iy)).commit(); }function grid_group_toogle(_io6){var _iom=_iu(_io6,3); var _io1d=_iw("span","kgrExpand",_iom); if (_io1d.length>0){ (new GridGroup(_iom.id)).collapse(); }else { (new GridGroup(_iom.id)).expand(); }_il6(_io6).commit(); }function grid_groupitem_sort(_iO1d,_il1d){var _ii1d=_iY(_iO1d); var _iO6=_il6(_ii1d); _iO6._iI6(_iO1d,"Sort", { "Sort":_il1d } ); _iO6.commit(); }function grid_filter_trigger(_iOi,_io6){var _iO6=_il6(_io6); var _iI9=new GridColumn(_iOi); if (_ii0("_filter_select",_io6.id)>0){var _ilt=_io6.options[_io6.selectedIndex].value; _iI9.filter(_ilt,null, true); _iO6.commit(); }else {var _iI1d=_iY(_iOi+"_filter_select"); var _ilt=_iI1d.options[_iI1d.selectedIndex].value; if (_ilt!="No_Filter"){if (_io6.nodeName=="INPUT" && _io6.type=="text"){var _iIa=_iO6._iob(); var _io1e=unescape(_iIa[_iOi]["Filter"]["Value"]); if (_io6.value!=_io1e){_iI9.filter(_ilt,null, true); _iO6.commit(); }}else {_iI9.filter(_ilt,null, true); _iO6.commit(); }}}}function _il19(_if){var _iO1e=_if.keyCode; if (_iO1e==13){var _iO6=_il6(this ); var _iOi=this.id.replace("_filter_input",""); _io1a[_iO6._iy]["Focus"]=this.id; grid_filter_trigger(_iOi,this ); return _iD(_if); }}function _iI19(_if){if (_if.keyCode==13){return _iD(_if); }}var _iov=null; var _iIu= false; var _ioy=0; var _ilv= false; var _iiv=null; var _ii8=null; var _ilb=null; function _iI16(_if){var _iy=this.id.replace("_hd",""); (new GridColumn(_iy))._iow(_if); }function _io17(_if){var _iy=this.id.replace("_hd",""); (new GridColumn(_iy))._iiu(_if); }function _il17(_if){var _iy=this.id.replace("_hd",""); (new GridColumn(_iy))._iOw(_if); }function _ii17(_if){var _iy=this.id.replace("_hd",""); (new GridColumn(_iy))._ilw(_if); }function _iO17(_if){var _iy=this.id.replace("_hd",""); (new GridColumn(_iy))._iiw(_if); return false; }function _iOy(_if){ (new GridColumn(_iov))._il10(_if); }function _iOv(_if){ (new GridColumn(_iov))._io10(_if); }function _iiy(_if){ (new GridColumn(_iiv))._iIz(_if); }function _ily(_if){ (new GridColumn(_iiv))._iOz(_if); }function _iI17(_if){ (new GridRow(this.id))._iIm(_if); }function _io18(_if){ (new GridRow(this.id))._ion(_if); }function _iO18(_if){ (new GridRow(this.id))._iOn(_if); }function _il18(_if){ (new GridRow(this.id))._iIn(_if); }function _iI11(_if){_ila=_iia(this ); _ila._il15(_if); }function _itch(_il1e){ (new GridTableView(_il1e))._il12(); }var _io1a=new Array(); if (typeof(__KGRInits)!="undefined" && _iO(__KGRInits)){for (var i=0; i<__KGRInits.length; i++){__KGRInits[i](); }} <?php
      _iO5();
      _ilo();
  }
  if (!function_exists("money_format")) {
      function money_format($_ilp, $_iOp)
      {
          $_ilq = '/%((?:[\\^!\\-]|\\+|\\(|\\=.)*)([0-9]+)?' . '(?:#([0-9]+))?(?:\\.([0-9]+))?([in%])/';
          if (setlocale(LC_MONETARY, 0) == 'C') {
              setlocale(LC_MONETARY, '');
          }
          $_iOq = localeconv();
          preg_match_all($_ilq, $_ilp, $_ilr, _ils);
          foreach ($_ilr as $_iOs) {
              $value = floatval($_iOp);
              $_ilt = array('fillchar' => preg_match('/\\=(.)/', $_iOs[1], $_iOt) ? $_iOt[1] : ' ', 'nogroup' => preg_match('/\\^/', $_iOs[1]) > 0, 'usesignal' => preg_match('/\\+|\\(/', $_iOs[1], $_iOt) ? $_iOt[0] : '+', 'nosimbol' => preg_match('/\\!/', $_iOs[1]) > 0, 'isleft' => preg_match('/\\-/', $_iOs[1]) > 0);
              $_ilu = trim($_iOs[2]) ? (int)$_iOs[2] : 0;
              $_iOu = trim($_iOs[3]) ? (int)$_iOs[3] : 0;
              $_ilv = trim($_iOs[4]) ? (int)$_iOs[4] : $_iOq['int_frac_digits'];
              $_iOv = $_iOs[5];
              $_ilw = true;
              if ($value < 0) {
                  $_ilw = false;
                  $value *= -1;
              }
              $_iOw = $_ilw ? 'p' : 'n';
              $_ilx = $_iOx = $_ily = $_iOy = $_ilz = '';
              $_ilz = $_ilw ? $_iOq['positive_sign'] : $_iOq['negative_sign'];
              switch (true) {
                  case $_iOq["{$_iOw}_sign_posn"] == 1 && $_ilt['usesignal'] == '+':
                      $_ilx = $_ilz;
                      break;
                  case $_iOq["{$_iOw}_sign_posn"] == 2 && $_ilt['usesignal'] == '+':
                      $_iOx = $_ilz;
                      break;
                  case $_iOq["{$_iOw}_sign_posn"] == 3 && $_ilt['usesignal'] == '+':
                      $_ily = $_ilz;
                      break;
                  case $_iOq["{$_iOw}_sign_posn"] == 4 && $_ilt['usesignal'] == '+':
                      $_iOy = $_ilz;
                      break;
                  case $_ilt['usesignal'] == '(':
                  case $_iOq["{$_iOw}_sign_posn"] == 0:
                      $_ilx = '(';
                      $_iOx = ')';
                      break;
              }
              if (!$_ilt['nosimbol']) {
                  $_iOz = $_ily . ($_iOv == 'i' ? $_iOq['int_curr_symbol'] : $_iOq['currency_symbol']) . $_iOy;
              } else {
                  $_iOz = '';
              }
              $_il10 = $_iOq["{$_iOw}_sep_by_space"] ? ' ' : '';
              $value = number_format($value, $_ilv, $_iOq['mon_decimal_point'], $_ilt['nogroup'] ? '' : $_iOq['mon_thousands_sep']);
              $value = @explode($_iOq['mon_decimal_point'], $value);
              $_iO10 = strlen($_ilx) + strlen($_iOz) + strlen($value[0]);
              if ($_iOu > 0 && $_iOu > $_iO10) {
                  $value[0] = str_repeat($_ilt['fillchar'], $_iOu - $_iO10) . $value[0];
              }
              $value = implode($_iOq['mon_decimal_point'], $value);
              if ($_iOq["{$_iOw}_cs_precedes"]) {
                  $value = $_ilx . $_iOz . $_il10 . $value . $_iOx;
              } else {
                  $value = $_ilx . $value . $_il10 . $_iOz . $_iOx;
              }
              if ($_ilu > 0) {
                  $value = str_pad($value, $_ilu, $_ilt['fillchar'], $_ilt['isleft'] ? STR_PAD_RIGHT : STR_PAD_LEFT);
              }
              $_ilp = str_replace($_iOs[0], $value, $_ilp);
          }
          return $_ilp;
      }
  }
  if (!class_exists("KoolGrid", false)) {
      function _il11($_iO11)
      {
          return _iO0("+", " ", urlencode($_iO11));
      }
      function _il12($_iO11)
      {
          return urldecode(_iO0(" ", "+", $_iO11));
      }
      function _iO12($_iO11)
      {
          return stripslashes($_iO11);
      }
      function _il13($_iO11)
      {
          return addslashes($_iO11);
      }
      function _iO13($_il14, $_iO14)
      {
          $_il15 = explode(",", $_iO14);
          $_iO15 = array();
          if ($_il15 != null) {
              for ($_iO9 = 0; $_iO9 < sizeof($_il15); $_iO9++) {
                  $_il15[$_iO9] = trim($_il15[$_iO9]);
                  $_iO15[$_il15[$_iO9]] = $_il14[$_il15[$_iO9]];
              }
          }
          return $_iO15;
      }
      function _il16($_il14)
      {
          $_il3 = "";
          foreach ($_il14 as $_iO16) {
              $_il3 .= $_iO16;
          }
          return md5($_il3);
      }
      class datasourcefilter
      {
          var $Field;
          var $Expression;
          var $Value;
          function __construct($_il17, $_iO17, $_il18)
          {
              $this->Field = $_il17;
              $this->Expression = $_iO17;
              $this->Value = _il13($_il18);
          }
      }
      class datasourcesort
      {
          var $Field;
          var $Order;
          function __construct($_il17, $_iO18 = "ASC")
          {
              $this->Field = $_il17;
              $this->Order = $_iO18;
          }
      }
      class datasourcegroup
      {
          var $Field;
          function __construct($_il17)
          {
              $this->Field = $_il17;
          }
      }
      class datasource
      {
          var $Sorts = array();
          var $Filters = array();
          var $Groups = array();
          function count()
          {
          }
          function getfields()
          {
          }
          function getdata($_il19 = 0, $_iO19 = 046113177)
          {
          }
          function getaggregates($_il6)
          {
          }
          function insert($_il1a)
          {
              return false;
          }
          function update($_il1a)
          {
              return false;
          }
          function delete($_il1a)
          {
              return false;
          }
          function addsort($_iO1a)
          {
              array_push($this->Sorts, $_iO1a);
          }
          function addfilter($_il1b)
          {
              array_push($this->Filters, $_il1b);
          }
          function addgroup($_iO1b)
          {
              array_push($this->Groups, $_iO1b);
          }
          function clear()
          {
              $this->Sorts = array();
              $this->Filters = array();
              $this->Groups = array();
          }
      }
      class mysqldatasource extends datasource
      {
          var $SelectCommand;
          var $UpdateCommand;
          var $InsertCommand;
          var $DeleteCommand;
          var $_il1c;
          function __construct($_iO1c)
          {
              $this->_il1c = $_iO1c;
          }
          function count()
          {
              $_il1d = "SELECT COUNT(*) FROM (" . $this->SelectCommand . ") AS _TMP {where}";
              $_iO1d = "";
              $_il1e = $this->Filters;
              for ($_iO9 = 0; $_iO9 < sizeof($_il1e); $_iO9++) {
                  $_il18 = $_il1e[$_iO9]->Value;
                  $_il18 = "'" . $_il18 . "'";
                  $_iO1d .= " and " . $_il1e[$_iO9]->Field . " " . $_il1e[$_iO9]->Expression . " " . $_il18;
              }
              if ($_iO1d != "") {
                  $_iO1d = "WHERE " . substr($_iO1d, 5);
              }
              $_il1d = _iO0("{where}", $_iO1d, $_il1d);
              $_iO1e = mysql_query($_il1d, $this->_il1c);
              return mysql_result($_iO1e, 0, 0);
          }
          function getfields()
          {
              $_il1f = array();
              $_iO1e = mysql_query($this->SelectCommand, $this->_il1c);
              while ($_iO1f = mysql_fetch_field($_iO1e)) {
                  $_il17 = array("Name" => $_iO1f->name, "Type" => $_iO1f->type, "Not_Null" => $_iO1f->not_null);
                  array_push($_il1f, $_il17);
              }
              return $_il1f;
          }
          function getdata($_il1g = 0, $_iO1g = 046113177)
          {
              $_il1h = "SELECT * FROM ({SelectCommand}) AS _TMP {where} {orderby} {groupby} {limit}";
              $_iO1d = "";
              $_il1e = $this->Filters;
              for ($_iO9 = 0; $_iO9 < sizeof($_il1e); $_iO9++) {
                  $_il18 = "'" . $_il1e[$_iO9]->Value . "'";
                  $_iO1d .= " and " . $_il1e[$_iO9]->Field . " " . $_il1e[$_iO9]->Expression . " " . $_il18;
              }
              if ($_iO1d != "") {
                  $_iO1d = "WHERE " . substr($_iO1d, 5);
              }
              $_iO1h = "";
              $_il1i = $this->Sorts;
              for ($_iO9 = 0; $_iO9 < sizeof($_il1i); $_iO9++) {
                  $_iO1h .= ", " . $_il1i[$_iO9]->Field . " " . $_il1i[$_iO9]->Order;
              }
              if ($_iO1h != "") {
                  $_iO1h = "ORDER BY " . substr($_iO1h, 2);
              }
              $_iO1i = "";
              $_il1j = $this->Groups;
              for ($_iO9 = 0; $_iO9 < sizeof($_il1j); $_iO9++) {
                  $_iO1i .= ", " . $_il1j[$_iO9]->Field;
              }
              if ($_iO1i != "") {
                  $_iO1i = "GROUP BY " . substr($_iO1i, 2);
              }
              $_iO1j = "LIMIT " . $_il1g . " , " . $_iO1g;
              $_il1k = _iO0("{SelectCommand}", $this->SelectCommand, $_il1h);
              $_il1k = _iO0("{where}", $_iO1d, $_il1k);
              $_il1k = _iO0("{orderby}", $_iO1h, $_il1k);
              $_il1k = _iO0("{groupby}", $_iO1i, $_il1k);
              $_il1k = _iO0("{limit}", $_iO1j, $_il1k);
              $_iO1e = mysql_query($_il1k, $this->_il1c);
              $_iO1k = array();
              while ($_il1l = mysql_fetch_assoc($_iO1e)) {
                  array_push($_iO1k, $_il1l);
              }
              return $_iO1k;
          }
          function getaggregates($_il6)
          {
              $_il1h = "SELECT {text} FROM ({SelectCommand}) AS _TMP {where} {orderby} {groupby}";
              $_il3 = "";
              $_iO1l = array();
              foreach ($_il6 as $_il1m) {
                  if (strpos("||min|max|first|last|count|sum|avg|", "|" . strtolower($_il1m["Aggregate"]) . "|") > 0) {
                      $_il3 .= ", " . $_il1m["Aggregate"] . "(" . $_il1m["DataField"] . ") as " . $_il1m["Key"];
                  }
              }
              if ($_il3 != "") {
                  $_il3 = substr($_il3, 2);
                  $_iO1d = "";
                  $_il1e = $this->Filters;
                  for ($_iO9 = 0; $_iO9 < sizeof($_il1e); $_iO9++) {
                      $_il18 = "'" . $_il1e[$_iO9]->Value . "'";
                      $_iO1d .= " and " . $_il1e[$_iO9]->Field . " " . $_il1e[$_iO9]->Expression . " " . $_il18;
                  }
                  if ($_iO1d != "") {
                      $_iO1d = "WHERE " . substr($_iO1d, 5);
                  }
                  $_iO1h = "";
                  $_il1i = $this->Sorts;
                  for ($_iO9 = 0; $_iO9 < sizeof($_il1i); $_iO9++) {
                      $_iO1h .= ", " . $_il1i[$_iO9]->Field . " " . $_il1i[$_iO9]->Order;
                  }
                  if ($_iO1h != "") {
                      $_iO1h = "ORDER BY " . substr($_iO1h, 2);
                  }
                  $_iO1i = "";
                  $_il1j = $this->Groups;
                  for ($_iO9 = 0; $_iO9 < sizeof($_il1j); $_iO9++) {
                      $_iO1i .= ", " . $_il1j[$_iO9]->Field;
                  }
                  if ($_iO1i != "") {
                      $_iO1i = "GROUP BY " . substr($_iO1i, 2);
                  }
                  $_il1k = _iO0("{SelectCommand}", $this->SelectCommand, $_il1h);
                  $_il1k = _iO0("{text}", $_il3, $_il1k);
                  $_il1k = _iO0("{where}", $_iO1d, $_il1k);
                  $_il1k = _iO0("{orderby}", $_iO1h, $_il1k);
                  $_il1k = _iO0("{groupby}", $_iO1i, $_il1k);
                  $_iO1e = mysql_query($_il1k, $this->_il1c);
                  $_iO1l = mysql_fetch_assoc($_iO1e);
              }
              return $_iO1l;
          }
          function insert($_il1a)
          {
              $_iO1m = explode(";", $this->InsertCommand);
              foreach ($_il1a as $_ilk => $_il18) {
                  for ($_iO9 = 0; $_iO9 < sizeof($_iO1m); $_iO9++) {
                      $_iO1m[$_iO9] = _iO0("\100" . $_ilk, _il13($_il18), $_iO1m[$_iO9]);
                  }
              }
              foreach ($_iO1m as $_il1n) {
                  if (mysql_query($_il1n, $this->_il1c) == false) {
                      return false;
                  }
              }
			  			  			  
              return true;
          }
          function update($_il1a)
          {
              $_iO1n = explode(";", $this->UpdateCommand);
              foreach ($_il1a as $_ilk => $_il18) {
                  for ($_iO9 = 0; $_iO9 < sizeof($_iO1n); $_iO9++) {
                      $_iO1n[$_iO9] = _iO0("\100" . $_ilk, _il13($_il18), $_iO1n[$_iO9]);
                  }
              }
              foreach ($_iO1n as $_il1o) {
                  if (mysql_query($_il1o, $this->_il1c) == false) {
                      return false;
                  }
              }
              return true;
          }
          function delete($_il1a)
          {
              $_iO1o = explode(";", $this->DeleteCommand);
              foreach ($_il1a as $_ilk => $_il18) {
                  for ($_iO9 = 0; $_iO9 < sizeof($_iO1o); $_iO9++) {
                      $_iO1o[$_iO9] = _iO0("\100" . $_ilk, _il13($_il18), $_iO1o[$_iO9]);
                  }
              }
              foreach ($_iO1o as $_il1p) {
                  if (mysql_query($_il1p, $this->_il1c) == false) {
                      return false;
                  }
              }
              return true;
          }
      }
      class arraydatasource extends datasource
      {
          var $_iO1p;
          function __construct($_il1q)
          {
              $this->_iO1p = $_il1q;
          }
          function count()
          {
              return sizeof($this->_iO1p);
          }
          function getfields()
          {
              $_il1f = array();
              $_iO1q = $this->_iO1p[0];
              foreach ($_iO1q as $_il1r => $_iO1r) {
                  array_push($_il1f, $_il1r);
              }
              return $_il1f;
          }
          function getdata($_il19 = 0, $_iO19 = 046113177)
          {
              $_il1s = array();
              if ($_il19 > $this->count())
                  return $_il1s;
              if ($_il19 + $_iO19 > $this->count()) {
                  $_iO19 = $this->count() - $_il19;
              }
              for ($_iO9 = 0; $_iO9 < $_iO19; $_iO9++) {
                  array_push($_il1s, $this->_iO1p[$_il19 + $_iO9]);
              }
              return $_il1s;
          }
      }
      interface _iO1s
      {
          function _il1t();
          function _iO1t();
      }
      class _il1u
      {
          private $_iO1u, $_il1v;
          function __construct($_iO1v)
          {
              $this->_iO1u = _il1w('sha256', $_iO1v, true);
              $_iO1w = mcrypt_get_iv_size(_il1x, _iO1x);
              $this->_il1v = mcrypt_create_iv($_iO1w, _il1y);
          }
          function _iO1y($_il1z)
          {
              return base64_encode(mcrypt_encrypt(_il1x, $this->_iO1u, $_il1z, _iO1x, $this->_il1v));
          }
          function _iO1z($_il1z)
          {
              return trim(mcrypt_decrypt(_il1x, $this->_iO1u, base64_decode($_il1z), _iO1x, $this->_il1v));
          }
      }
      class _il20
      {
          var $_iO20;
          var $_iO1p;
          var $_il21 = false;
          var $_iO21 = false;
          function _il22($_iO22)
          {
              $this->_iO20 = $_iO22;
              $this->_iO21 = $_iO22->KeepViewStateInSession;
              $_il23 = (isset($_POST[$this->_iO20->_iO23 . "_viewstate"])) ? $_POST[$this->_iO20->_iO23 . "_viewstate"] : "";
              if ($this->_iO21 && $_il23 == "") {
                  $_il23 = (isset($_SESSION[$this->_iO20->_iO23 . "_viewstate"])) ? $_SESSION[$this->_iO20->_iO23 . "_viewstate"] : "";
                  $this->_iO20->_il24->_iO24 = true;
              }
              if ($_il23 != "" && $this->_il21) {
                  $_il25 = new _il1u($_SERVER["SERVER_NAME"]);
                  $_il23 = _iO0("()", "+", $_il23);
                  $_il23 = $_il25->_iO1z($_il23);
              }
              $_il23 = _iO0("\134", "", $_il23);
              $this->_iO1p = json_decode($_il23, true);
          }
          function _iO25()
          {
              $_il26 = json_encode($this->_iO1p);
              if ($this->_il21) {
                  $_il25 = new _il1u($_SERVER["SERVER_NAME"]);
                  $_il26 = $_il25->_iO1y($_il26);
                  $_il26 = _iO0("+", "()", $_il26);
              }
              if ($this->_iO21) {
                  $_SESSION[$this->_iO20->_iO23 . "_viewstate"] = $_il26;
              }
              $_iO26 = "<input id='{id}' name='{id}' type='hidden' value='{value}' autocomplete='off' />";
              $_il27 = _iO0("{id}", $this->_iO20->_iO23 . "_viewstate", $_iO26);
              $_il27 = _iO0("{value}", $_il26, $_il27);
              return $_il27;
          }
      }
      class _iO27
      {
          var $_il28;
          var $_iO28;
          function __construct()
          {
              $this->_il28 = array("Insert" => "Add New Record", "Delete" => "Delete", "Confirm" => "Confirm", "Edit" => "Edit", "Cancel" => "Cancel", "Refresh" => "Refresh", "Done" => "Done", "Loading" => "Loading...", "Go" => "Go", "Next" => "Next", "Prev" => "Prev", "No_Filter" => "\133No Filter]", "Equal" => "Equal", "Not_Equal" => "Not Equal", "Greater_Than" => "Greater Than", "Less_Than" => "Less Than", "Greater_Than_Or_Equal" => "Greater Than Or Equal", "Less_Than_Or_Equal" => "Less Than Or Equal", "Contain" => "Contain", "Not_Contain" => "Not Contain", "Start_With" => "Start With", "End_With" => "End With");
              $this->_iO28 = array("DeleteConfirm" => "Are you sure to delete this row?", "PageInfoTemplate" => "Displaying page {PageIndex} in {TotalPages}, items {FirstIndexInPage} to {LastIndexInPage} of {TotalRows}.", "ManualPagerTemplate" => "Change page: {TextBox} (of {TotalPage} pages) {GoPageButton}", "PageSizeText" => "Page Size:", "NextPageToolTip" => "Next Page", "PrevPageToolTip" => "Previous Page", "SortHeaderToolTip" => "Click here to sort", "SortAscToolTip" => "Sort Asc", "SortDescToolTip" => "Sort Desc", "SortNoneToolTip" => "No sort", "InsertForm_ConfirmButtonToolTip" => "Confirm Insert", "InsertForm_CancelButtonToolTip" => "Cancel Insert", "EditForm_ConfirmButtonToolTip" => "Confirm Changes", "EditForm_CancelButtonToolTip" => "Cancel Changes", "RequiredFieldValidator_ErrorMessage" => "Field is required!", "RegularExpressionValidator_ErrorMessage" => "Not valid!", "RangeValidator_ErrorMessage" => "Value must be in range [{MinValue},{MaxValue}]", "GroupPanelGuideText" => "Drag a column header and drop it here to group by that column", "GroupItemToolTip" => "Drag out of the bar to ungroup");
          }
          function load($_il29)
          {
              $_iO29 = new domdocument();
              $_iO29->load($_il29);
              $_il2a = $_iO29->getelementsbytagname("commands");
              if ($_il2a->length > 0) {
                  foreach ($_il2a->item(0)->attributes as $_iO2a) {
                      $this->_il28[$_iO2a->name] = $_iO2a->value;
                  }
              }
              $_il2a = $_iO29->getelementsbytagname("messages");
              if ($_il2a->length > 0) {
                  foreach ($_il2a->item(0)->attributes as $_iO2a) {
                      $this->_iO28[$_iO2a->name] = $_iO2a->value;
                  }
              }
          }
      }
      class _il2b
      {
          var $_iO23;
          var $_iO20;
          var $_il28;
          function __construct($_iO22)
          {
              $this->_iO23 = $_iO22->_iO23 . "_cmd";
              $this->_iO2b();
          }
          function _iO2b()
          {
              if (isset($_POST[$this->_iO23])) {
                  $_il23 = $_POST[$this->_iO23];
                  $_il23 = _iO0("\134", "", $_il23);
                  $this->_il28 = json_decode($_il23, true);
              }
          }
          function _iO25()
          {
              $_il2c = "<input id='{id}' name='{id}' type='hidden' value='' />";
              $_ilm = _iO0("{id}", $this->_iO23, $_il2c);
              return $_ilm;
          }
      }
      class gridrow implements _iO1s
      {
          var $_iO23;
          var $_iO2c;
          var $_il2d;
          var $_iO2d = array();
          var $_il2e;
          var $DataItem;
          var $Selected = false;
          var $Expand = false;
          var $EditMode = false;
          var $TableView;
          var $CssClass = "";
          var $_iO2e = false;
          function _il22($_il2f)
          {
              $this->_il2d = $_il2f;
              $this->TableView = $_il2f;
              $this->_iO2c = $_il2f->_iO2c;
          }
          function getunqiueid()
          {
              return $this->_iO23;
          }
          function _il1t()
          {
              if (isset($this->_iO2c->_iO1p[$this->_iO23])) {
                  $_iO2f = $this->_iO2c->_iO1p[$this->_iO23];
                  $this->Selected = $_iO2f["Selected"];
                  $this->Expand = $_iO2f["Expand"];
                  $this->EditMode = $_iO2f["EditMode"];
                  $_il2g = $_iO2f["DataItem"];
                  $this->DataItem = array();
                  foreach ($_il2g as $_iO2g => $_il2h) {
                      $this->DataItem[$_iO2g] = _il12($_il2h);
                  }
              }
          }
          function _iO1t()
          {
              $_il2g = array();
              foreach ($this->DataItem as $_iO2g => $_il2h) {
                  $_il2g[$_iO2g] = _il11($_il2h);
              }
              $this->_iO2c->_iO1p[$this->_iO23] = array("Selected" => $this->Selected, "Expand" => $this->Expand, "EditMode" => $this->EditMode, "DataItem" => $_il2g);
              foreach ($this->_iO2d as $_iO2h) {
                  $_iO2h->_iO1t();
              }
          }
          function _il2i($_il2f)
          {
              $_il2f->_iO23 = $this->_iO23 . "_dt" . sizeof($this->_iO2d);
              array_push($this->_iO2d, $_il2f);
          }
          function getinstancedetailtables()
          {
              return $this->_iO2d;
          }
          function gettableview()
          {
              return $this->_il2d;
          }
          function _iO2i()
          {
              $this->_il1t();
              if ($this->EditMode) {
                  $this->_il2e = $this->_il2d->EditSettings->_il2j();
                  $this->_il2e->_il22($this->_il2d);
                  $this->_il2e->_iO2j = $this;
              }
              if ($this->Expand) {
                  foreach ($this->_il2d->_il2k as $_iO2h) {
                      $_iO2k = $_iO2h->_il2j();
                      $this->_il2i($_iO2k);
                      $_iO2k->_il22($this->_il2d->_iO20, $this);
                      $_iO2k->_iO2i();
                  }
              }
          }
          function _il2l($_ilm)
          {
              if (isset($_ilm->_il28[$this->_iO23])) {
                  $_iO2l = $_ilm->_il28[$this->_iO23];
                  switch ($_iO2l["Command"]) {
                      case "Select":
                          $this->Selected = true;
                          break;
                      case "Unselect":
                          $this->Selected = false;
                          break;
                      case "Expand":
                          if ($this->_il2d->_iO20->EventHandler->onbeforedetailtablesexpand($this, array()) == true) {
                              $this->Expand = true;
                              $this->_il2d->_iO20->EventHandler->ondetailtablesexpand($this, array());
                          }
                          break;
                      case "Collapse":
                          if ($this->_il2d->_iO20->EventHandler->onbeforedetailtablescollapse($this, array()) == true) {
                              $this->Expand = false;
                              $this->_iO2d = array();
                              $this->_il2d->_iO20->EventHandler->ondetailtablescollapse($this, array());
                          }
                          break;
                      case "StartEdit":
                          if ($this->_il2d->AllowEditing) {
                              if ($this->_il2d->_iO20->EventHandler->onbeforerowstartedit($this, array()) == true) {
                                  $this->EditMode = true;
                                  $this->_il2e = $this->_il2d->EditSettings->_il2j();
                                  $this->_il2e->_il22($this->_il2d);
                                  $this->_il2e->_iO2j = $this;
                                  $this->_il2d->_iO20->EventHandler->onrowstartedit($this, array());
                              }
                          }
                          break;
                      case "ConfirmEdit":
                          if ($this->EditMode) {
                              $this->_il2e->_il2m();
                          }
                          break;
                      case "CancelEdit":
                          if ($this->_il2d->_iO20->EventHandler->onbeforerowcanceledit($this, array()) == true) {
                              $this->EditMode = false;
                              $this->_il2d->_iO20->EventHandler->onrowcanceledit($this, array());
                          }
                          break;
                      case "Delete":
                          if ($this->_il2d->AllowDeleting) {
							  $this->_il2d->_iO20->errorMessage = "";
                              if ($this->_il2d->_iO20->EventHandler->onbeforerowdelete($this, array()) == true) {
                                  $_iO2m = $this->_il2d->DataSource->delete($this->DataItem);
                                  $this->_il2d->_iO24 = true;
								  
								  //Added by Ivan Budiono to show error message :)								  
								  if(mysql_error() != "")
									$this->_il2d->_iO20->errorMessage = "<font color='red'>".mysql_error()."</font>";
								  //*** end ***
								  
                                  $this->_il2d->_iO20->EventHandler->onrowdelete($this, array("Successful" => $_iO2m));
                              }
                          }
                          break;
                  }
              }
              $this->_il2d->_iO20->EventHandler->onrowprerender($this, array());
              if ($this->Expand && sizeof($this->_iO2d) == 0) {
                  foreach ($this->_il2d->_il2k as $_iO2h) {
                      $_iO2k = $_iO2h->_il2j();
                      $this->_il2i($_iO2k);
                      $_iO2k->_il22($this->_il2d->_iO20, $this);
                  }
              }
              foreach ($this->_iO2d as $_iO2h) {
                  $_iO2h->_il2l($_ilm);
              }
          }
          function _iO25()
          {
              $_il2n = "<tr id='{rowid}' class='kgrRow {alt} {selected} {cssclass}'>{tds}</tr>";
              $_iO2n = "<tr><td class='kgrCell'>&#160;</td><td colspan='{colspan}' class='kgrDetailTablesPanel'>{tables}</td></tr>";
              $_il2o = "<div class='kgrDesc'>{text}</div>";
              $_iO2o = "";
              if ($this->EditMode) {
                  $_iO2o = $this->_il2e->_iO25();
              } else {
                  $_il2p = "";
                  for ($_iO9 = 0; $_iO9 < sizeof($this->_il2d->_iO2p); $_iO9++) {
                      $_il2q = $this->_il2d->_iO2p[$_iO9];
                      $_iO2q = $_il2q->_iO25($this);
                      $_il2p .= $_iO2q;
                  }
                  $_iO2o = _iO0("{tds}", $_il2p, $_il2n);
              }
              $_iO2o = _iO0("{rowid}", $this->_iO23, $_iO2o);
              $_iO2o = _iO0("{selected}", $this->Selected ? "kgrRowSelected" : "", $_iO2o);
              $_iO2o = _iO0("{alt}", $this->_iO2e ? "kgrAltRow" : "", $_iO2o);
              $_iO2o = _iO0("{cssclass}", $this->CssClass, $_iO2o);
              if (sizeof($this->_iO2d) > 0) {
                  $_il2r = "";
                  foreach ($this->_iO2d as $_iO2h) {
                      $_iO2r = "";
                      if ($_iO2h->_il2s !== null) {
                          $_iO2r = _iO0("{text}", $_iO2h->_il2s, $_il2o);
                          foreach ($this->DataItem as $_il1r => $_iO1r) {
                              $_iO2r = _iO0("{" . $_il1r . "}", $_iO1r, $_iO2r);
                          }
                      }
                      $_iO2s = $_iO2r . $_iO2h->_iO25();
                      $_il2r .= $_iO2s;
                  }
                  $_il2t = _iO0("{colspan}", sizeof($this->_il2d->_iO2p) - 1, $_iO2n);
                  $_il2t = _iO0("{tables}", $_il2r, $_il2t);
                  $_iO2o .= $_il2t;
              }
              return $_iO2o;
          }
      }
      class _iO2t
      {
          var $Wrap;
          var $Align;
          var $Valign;
          function _il22($_il2q)
          {
              if ($this->Wrap === null)
                  $this->Wrap = $_il2q->Wrap;
              if ($this->Align === null)
                  $this->Align = $_il2q->Align;
              if ($this->Valign === null)
                  $this->Valign = $_il2q->Valign;
          }
          function _il2u()
          {
              return "white-space:" . (($this->Wrap) ? "normal" : "nowrap") . ";";
          }
          function _iO2u()
          {
              return($this->Align) ? "text-align:" . $this->Align . ";" : "";
          }
          function _il2v()
          {
              return($this->Valign) ? "valign='" . $this->Valign . "' " : "";
          }
      }
      class _iO2v
      {
          var $ErrorMessage;
          function _il2w($_il2q, $_il18)
          {
              return null;
          }
      }
      class requiredfieldvalidator extends _iO2v
      {
          function _il2w($_il2q, $_il18)
          {
              $_iO2w = $this->ErrorMessage;
              if ($_iO2w === null)
                  $_iO2w = $_il2q->_il2d->_iO20->Localization->_iO28["RequiredFieldValidator_ErrorMessage"];
              if ($_il18 === null || $_il18 == "") {
                  return $_iO2w;
              }
              return null;
          }
      }
      class regularexpressionvalidator extends _iO2v
      {
          var $ValidationExpression = "";
          function _il2w($_il2q, $_il18)
          {
              $_iO2w = $this->ErrorMessage;
              if ($_iO2w === null)
                  $_iO2w = $_il2q->_il2d->_iO20->Localization->_iO28["RegularExpressionValidator_ErrorMessage"];
              if (!preg_match($this->ValidationExpression, $_il18)) {
                  return $_iO2w;
              }
              return null;
          }
      }
      class rangevalidator extends _iO2v
      {
          var $MinValue;
          var $MaxValue;
          function _il2w($_il2q, $_il18)
          {
              $_iO2w = $this->ErrorMessage;
              if ($_iO2w === null)
                  $_iO2w = $_il2q->_il2d->_iO20->Localization->_iO28["RangeValidator_ErrorMessage"];
              if ($_il18 > $this->MaxValue || $_il18 < $this->MinValue) {
                  $_iO2w = _iO0("{MinValue}", $this->MinValue, $_iO2w);
                  $_iO2w = _iO0("{MaxValue}", $this->MaxValue, $_iO2w);
                  return $_iO2w;
              }
              return null;
          }
      }
      class customvalidator extends _iO2v
      {
          var $ValidateFunction;
          function _il2w($_il2q, $_il18)
          {
              $_il2x = $this->ValidateFunction;
              if ($_il2x !== null) {
                  return $_il2x($_il18);
              }
              return null;
          }
      }
      class gridcolumn implements _iO1s
      {
          var $_iO23;
          var $_iO2c;
          var $_il2d;
          var $_iO2x;
          var $ReadOnly = false;
          var $TableView;
          var $AllowSorting;
          var $AllowResizing;
          var $AllowFiltering;
          var $AllowGrouping;
          var $AllowExporting = true;
          var $Width;
          var $Visible = true;
          var $Filter;
          var $FilterOptions;
          var $HeaderText;
          var $FooterText;
          var $DataField;
          var $Sort = 0;
          var $HeaderStyle;
          var $ItemStyle;
          var $FooterStyle;
          var $Wrap;
          var $Align;
          var $Valign;
          var $CssClass = "";
          var $Aggregate;
          var $_il2y;
          function __construct()
          {
              $this->HeaderStyle = new _iO2t();
              $this->FooterStyle = new _iO2t();
              $this->ItemStyle = new _iO2t();
              $this->_iO2x = array();
          }
          function getunqiueid()
          {
              return $this->_iO23;
          }
          function _il22($_il2f)
          {
              $this->_il2d = $_il2f;
              $this->TableView = $_il2f;
              $this->_iO2c = $_il2f->_iO2c;
              if ($this->AllowSorting === null)
                  $this->AllowSorting = $this->_il2d->AllowSorting;
              if ($this->AllowResizing === null)
                  $this->AllowResizing = $this->_il2d->AllowResizing;
              if ($this->AllowFiltering === null)
                  $this->AllowFiltering = $this->_il2d->AllowFiltering;
              if ($this->AllowGrouping === null)
                  $this->AllowGrouping = $this->_il2d->AllowGrouping;
              if ($this->Width === null)
                  $this->Width = $this->_il2d->ColumnWidth;
              if ($this->Wrap === null)
                  $this->Wrap = $this->_il2d->ColumnWrap;
              if ($this->Align === null)
                  $this->Align = $this->_il2d->ColumnAlign;
              if ($this->Valign === null)
                  $this->Valign = $this->_il2d->_iO2y;
              if ($this->FilterOptions === null)
                  $this->FilterOptions = $this->_il2d->FilterOptions;
              $this->HeaderStyle->_il22($this);
              $this->FooterStyle->_il22($this);
              $this->ItemStyle->_il22($this);
              if ($this->Filter === null) {
                  $this->Filter = array("Value" => "", "Exp" => "No_Filter");
              }
          }
          function addvalidator($_il2z)
          {
              array_push($this->_iO2x, $_il2z);
          }
          function _il1t()
          {
              if (isset($this->_iO2c->_iO1p[$this->_iO23])) {
                  $_iO2f = $this->_iO2c->_iO1p[$this->_iO23];
                  $this->Sort = $_iO2f["Sort"];
                  $this->Width = $_iO2f["Width"];
                  $this->Visible = $_iO2f["Visible"];
                  $this->_il2y = _il12($_iO2f["AggRes"]);
                  $_il1b = $_iO2f["Filter"];
                  $_il1b["Value"] = _il12($_il1b["Value"]);
                  $this->Filter = $_il1b;
              }
          }
          function _iO1t()
          {
              $_il1b = $this->Filter;
              $_il1b["Value"] = _il11($_il1b["Value"]);
              $this->_iO2c->_iO1p[$this->_iO23] = array("Name" => $this->DataField, "Sort" => $this->Sort, "Visible" => $this->Visible, "Filter" => $_il1b, "Width" => $this->Width, "AggRes" => _il11($this->_il2y));
          }
          function _il2l($_ilm)
          {
              if (isset($_ilm->_il28[$this->_iO23])) {
                  $_iO2l = $_ilm->_il28[$this->_iO23];
                  switch ($_iO2l["Command"]) {
                      case "Sort":
                          if ($this->_il2d->_iO20->EventHandler->onbeforecolumnsort($this, array("NewSort" => $_iO2l["Args"]["Sort"])) == true) {
                              $this->Sort = $_iO2l["Args"]["Sort"];
                              $this->_il2d->_iO24 = true;
                              $this->_il2d->_iO20->EventHandler->oncolumnsort($this, array());
                          }
                          break;
                      case "Filter":
                          if ($this->_il2d->_iO20->EventHandler->onbeforecolumnfilter($this, array("FilterValue" => $_iO2l["Args"]["Filter"]["Value"], "FilterExp" => $_iO2l["Args"]["Filter"]["Exp"])) == true) {
                              $this->Filter["Exp"] = $_iO2l["Args"]["Filter"]["Exp"];
                              if ($_iO2l["Args"]["Post"]) {
                                  $this->Filter["Value"] = $this->_iO2z();
                              } else {
                                  $this->Filter["Value"] = _il12($_iO2l["Args"]["Filter"]["Value"]);
                              }
                              $this->_il2d->_iO24 = true;
                              $this->_il2d->_iO20->EventHandler->oncolumnfilter($this, array());
                          }
                          break;
                  }
              }
              if ($this->Sort != 0) {
                  $this->_il2d->DataSource->addsort(new datasourcesort($this->DataField, ($this->Sort < 0) ? "DESC" : "ASC"));
              }
              if ($this->Filter["Exp"] != "No_Filter") {
                  $_iO17 = "";
                  $_il18 = $this->Filter["Value"];
                  switch ($this->Filter["Exp"]) {
                      case "Equal":
                          $_iO17 = "=";
                          break;
                      case "Not_Equal":
                          $_iO17 = "<>";
                          break;
                      case "Greater_Than":
                          $_iO17 = ">";
                          break;
                      case "Less_Than":
                          $_iO17 = "<";
                          break;
                      case "Greater_Than_Or_Equal":
                          $_iO17 = ">=";
                          break;
                      case "Less_Than_Or_Equal":
                          $_iO17 = "<=";
                          break;
                      case "Contain":
                          $_iO17 = "LIKE";
                          $_il18 = "%" . $_il18 . "%";
                          break;
                      case "Not_Contain":
                          $_iO17 = "NOT LIKE";
                          $_il18 = "%" . $_il18 . "%";
                          break;
                      case "Start_With":
                          $_iO17 = "LIKE";
                          $_il18 = $_il18 . "%";
                          break;
                      case "End_With":
                          $_iO17 = "LIKE";
                          $_il18 = "%" . $_il18;
                          break;
                  }
                  $this->_il2d->DataSource->addfilter(new datasourcefilter($this->DataField, $_iO17, $_il18));
              }
          }
          function createinstance($_il30)
          {
              if ($_il30 === null) {
                  $_il30 = new gridcolumn();
              }
              $_il30->ReadOnly = $this->ReadOnly;
              $_il30->HeaderText = $this->HeaderText;
              $_il30->FooterText = $this->FooterText;
              $_il30->DataField = $this->DataField;
              $_il30->AllowSorting = $this->AllowSorting;
              $_il30->AllowResizing = $this->AllowResizing;
              $_il30->AllowFiltering = $this->AllowFiltering;
              $_il30->AllowGrouping = $this->AllowGrouping;
              $_il30->AllowExporting = $this->AllowExporting;
              $_il30->Width = $this->Width;
              $_il30->Visible = $this->Visible;
              $_il30->Sort = $this->Sort;
              $_il30->Filter = $this->Filter;
              $_il30->FilterOptions = $this->FilterOptions;
              $_il30->Wrap = $this->Wrap;
              $_il30->Align = $this->Align;
              $_il30->Valign = $this->Valign;
              $_il30->HeaderStyle = $this->HeaderStyle;
              $_il30->FooterStyle = $this->FooterStyle;
              $_il30->ItemStyle = $this->ItemStyle;
              $_il30->CssClass = $this->CssClass;
              $_il30->_iO2x = $this->_iO2x;
              $_il30->Aggregate = $this->Aggregate;
              return $_il30;
          }
          function inlineeditrender($_il1l)
          {
              return $this->render($_il1l);
          }
          function formeditrender($_il1l)
          {
              return $this->inlineeditrender($_il1l);
          }
          function format($_il18)
          {
              return $_il18;
          }
          function render($_il1l)
          {
              return $this->format($_il1l->DataItem[$this->DataField]);
          }
          function _iO25($_il1l)
          {
              $_iO30 = "<td id='{id}' class='kgrCell {visible} {cssclass}' {valign}><div class='kgrIn' style='{wrap}{align}'>{cell}</div></td>";
              $_iO2q = _iO0("{id}", $_il1l->_iO23 . "_" . $this->_iO23, $_iO30);
              $_il31 = strtolower($_SERVER["HTTP_USER_AGENT"]);
              $_iO31 = (strpos($_il31, "msie 6") !== false) && (strpos($_il31, "msie 7") === false) && (strpos($_il31, "msie 8") === false) && (strpos($_il31, "opera") === false);
              $_il32 = (strpos($_il31, "msie 7") !== false) && (strpos($_il31, "opera") === false);
              $_iO2q = _iO0("{visible}", ($this->Visible || $_iO31 || $_il32) ? "" : "kgrHidden", $_iO2q);
              $_iO2q = _iO0("{wrap}", $this->ItemStyle->_il2u(), $_iO2q);
              $_iO2q = _iO0("{align}", $this->ItemStyle->_iO2u(), $_iO2q);
              $_iO2q = _iO0("{valign}", $this->ItemStyle->_il2v(), $_iO2q);
              $_iO2q = _iO0("{cssclass}", $this->CssClass, $_iO2q);
              $_iO2q = _iO0("{cell}", $this->render($_il1l), $_iO2q);
              return $_iO2q;
          }
          function _iO32($_il1l)
          {
              $_iO30 = "<td id='{id}' class='kgrCell {visible}' {valign}><div class='kgrIn' style='{wrap}{align}' >{cell}</div></td>";
              $_iO2q = _iO0("{id}", $_il1l->_iO23 . "_" . $this->_iO23, $_iO30);
              $_iO2q = _iO0("{cell}", $this->inlineeditrender($_il1l), $_iO2q);
              $_il31 = strtolower($_SERVER["HTTP_USER_AGENT"]);
              $_iO31 = (strpos($_il31, "msie 6") !== false) && (strpos($_il31, "msie 7") === false) && (strpos($_il31, "msie 8") === false) && (strpos($_il31, "opera") === false);
              $_il32 = (strpos($_il31, "msie 7") !== false) && (strpos($_il31, "opera") === false);
              $_iO2q = _iO0("{visible}", ($this->Visible || $_iO31 || $_il32) ? "" : "kgrHidden", $_iO2q);
              $_iO2q = _iO0("{wrap}", $this->ItemStyle->_il2u(), $_iO2q);
              $_iO2q = _iO0("{align}", $this->ItemStyle->_iO2u(), $_iO2q);
              $_iO2q = _iO0("{valign}", $this->ItemStyle->_il2v(), $_iO2q);
              return $_iO2q;
          }
          function _il33($_il1l)
          {
              $_il2n = "<tr style='white-space:nowrap'><td valign='top' style='width:2px;'><label class='kgrCaption' for='{id}'>{text}:</label></td><td valign='top'><div class='kgrInput'>{input}</div></td></tr>";
              $_iO2o = _iO0("{text}", $this->HeaderText, $_il2n);
              $_iO2o = _iO0("{id}", $_il1l->_iO23 . "_" . $this->_iO23 . "_input", $_iO2o);
              $_iO2o = _iO0("{input}", $this->formeditrender($_il1l), $_iO2o);
              return $_iO2o;
          }
          function geteditvalue($_il1l)
          {
              return _iO12($_POST[$_il1l->_iO23 . "_" . $this->_iO23 . "_input"]);
          }
          function _iO33()
          {
              $_il34 = "<col id='{id}' name='{id}' style='{width}' class='{resizable} {visible} {groupable}'/>";
              $_il2q = _iO0("{id}", $this->_iO23, $_il34);
              $_il2q = _iO0("{resizable}", ($this->AllowResizing) ? "kgrResizable" : "", $_il2q);
              $_il2q = _iO0("{groupable}", ($this->AllowGrouping) ? "kgrGroupable" : "", $_il2q);
              $_il2q = _iO0("{width}", ($this->Width != null) ? "width:" . $this->Width . ";" : "", $_il2q);
              $_il2q = _iO0("{visible}", ($this->Visible) ? "" : "kgrHidden", $_il2q);
              return $_il2q;
          }
          function renderheader()
          {
              $_iO34 = "<th id='{id}' class='kgrHeader {visible}' {valign}><div class='kgrIn' style='{wrap}{align}'>{text}&#160;{sign}</div></th>";
              $_il35 = "<a href='javascript:void 0' class='kgrSortHeaderText' onclick='grid_sort(\"{id}\",{sort})' title='{title}'>{text}</a>";
              $_iO35 = "<input type='button' class='kgrSort{dir}' onclick='grid_sort(\"{id}\",{sort})' title='{title}' />";
              $_il36 = _iO0("{id}", $this->_iO23 . "_hd", $_iO34);
              if ($this->AllowSorting) {
                  $_iO1a = 0;
                  $_iO36 = "None";
                  switch ($this->Sort) {
                      case 0:
                          $_iO1a = 1;
                          $_iO36 = "None";
                          break;
                      case 1:
                          $_iO1a = -1;
                          $_iO36 = "Asc";
                          break;
                      case - 1:
                          $_iO1a = 0;
                          $_iO36 = "Desc";
                          break;
                  }
                  $_il37 = _iO0("{id}", $this->_iO23, $_il35);
                  $_il37 = _iO0("{sort}", $_iO1a, $_il37);
                  $_il37 = _iO0("{text}", $this->HeaderText, $_il37);
                  $_il37 = _iO0("{title}", $this->_il2d->_iO20->Localization->_iO28["SortHeaderToolTip"], $_il37);
                  $_iO37 = _iO0("{id}", $this->_iO23, $_iO35);
                  $_iO37 = _iO0("{sort}", $_iO1a, $_iO37);
                  $_iO37 = _iO0("{dir}", $_iO36, $_iO37);
                  $_iO37 = _iO0("{title}", $this->_il2d->_iO20->Localization->_iO28["Sort" . $_iO36 . "ToolTip"], $_iO37);
                  $_il36 = _iO0("{text}", $_il37, $_il36);
                  $_il36 = _iO0("{sign}", $_iO37, $_il36);
              } else {
                  $_il36 = _iO0("{text}", $this->HeaderText, $_il36);
                  $_il36 = _iO0("{sign}", "", $_il36);
              }
              $_il31 = strtolower($_SERVER["HTTP_USER_AGENT"]);
              $_iO31 = (strpos($_il31, "msie 6") !== false) && (strpos($_il31, "msie 7") === false) && (strpos($_il31, "msie 8") === false) && (strpos($_il31, "opera") === false);
              $_il32 = (strpos($_il31, "msie 7") !== false) && (strpos($_il31, "opera") === false);
              $_il36 = _iO0("{visible}", ($this->Visible || $_iO31 || $_il32) ? "" : "kgrHidden", $_il36);
              $_il36 = _iO0("{wrap}", $this->HeaderStyle->_il2u(), $_il36);
              $_il36 = _iO0("{align}", $this->HeaderStyle->_iO2u(), $_il36);
              $_il36 = _iO0("{valign}", $this->HeaderStyle->_il2v(), $_il36);
              return $_il36;
          }
          function renderfooter()
          {
              $_il38 = "<td id='{id}' class='kgrFooter {visible}' {valign}><div class='kgrIn' style='{wrap}{align}'><span class='kgrFooterText'>{text}&#160;</span></div></td>";
              $_iO38 = _iO0("{id}", $this->_iO23 . "_ft", $_il38);
              $_il3 = $this->FooterText;
              if ($this->Aggregate !== null) {
                  $_il39 = new gridrow();
                  $_il39->DataItem[$this->DataField] = $this->_il2y;
                  $_il3 .= $this->render($_il39);
              }
              $_iO38 = _iO0("{text}", $_il3, $_iO38);
              $_il31 = strtolower($_SERVER["HTTP_USER_AGENT"]);
              $_iO31 = (strpos($_il31, "msie 6") !== false) && (strpos($_il31, "msie 7") === false) && (strpos($_il31, "msie 8") === false) && (strpos($_il31, "opera") === false);
              $_il32 = (strpos($_il31, "msie 7") !== false) && (strpos($_il31, "opera") === false);
              $_iO38 = _iO0("{visible}", ($this->Visible || $_iO31 || $_il32) ? "" : "kgrHidden", $_iO38);
              $_iO38 = _iO0("{wrap}", $this->FooterStyle->_il2u(), $_iO38);
              $_iO38 = _iO0("{align}", $this->FooterStyle->_iO2u(), $_iO38);
              $_iO38 = _iO0("{valign}", $this->FooterStyle->_il2v(), $_iO38);
              return $_iO38;
          }
          function renderfilter()
          {
              $_iO39 = "<div class='kgrEditIn'><input class='kgrFiEnTr' type='text' id='{id}' name='{id}' value='{text}' onblur='grid_filter_trigger(\"{colid}\",this)' style='width:100%;' /></div>";
              $_il3a = _iO0("{id}", $this->_iO23 . "_filter_input", $_iO39);
              $_il3a = _iO0("{colid}", $this->_iO23, $_il3a);
              $_il3a = _iO0("{text}", htmlentities($this->Filter["Value"], ENT_QUOTES, $this->_il2d->_iO20->CharSet), $_il3a);
              return $_il3a;
          }
          function _iO2z()
          {
              return _iO12($_POST[$this->_iO23 . "_filter_input"]);
          }
          function _iO3a()
          {
              $_il3b = "<td id='{id}' class='kgrFilterCell {visible}'><div class='kgrIn'>{content}</div></td>";
              $_iO3b = "&#160;";
              if ($this->AllowFiltering) {
                  $_il3c = "<div>{input}</div><div>{select}</div>";
                  $_iO3c = "<select id='{id}' onchange='grid_filter_trigger(\"{colid}\",this)' style='width:100%'>{options}</select>";
                  $_il3d = "<option value='{value}' {selected} >{text}</option>";
                  $_iO3d = $this->FilterOptions;
                  $_il3e = "";
                  for ($_iO9 = 0; $_iO9 < sizeof($_iO3d); $_iO9++) {
                      $_iO3e = _iO0("{value}", $_iO3d[$_iO9], $_il3d);
                      $_iO3e = _iO0("{text}", $this->_il2d->_iO20->Localization->_il28[$_iO3d[$_iO9]], $_iO3e);
                      $_iO3e = _iO0("{selected}", ($this->Filter["Exp"] == $_iO3d[$_iO9]) ? "selected" : "", $_iO3e);
                      $_il3e .= $_iO3e;
                  }
                  $_il3f = _iO0("{id}", $this->_iO23 . "_filter_select", $_iO3c);
                  $_il3f = _iO0("{colid}", $this->_iO23, $_il3f);
                  $_il3f = _iO0("{options}", $_il3e, $_il3f);
                  $_iO3b = _iO0("{select}", $_il3f, $_il3c);
                  $_iO3b = _iO0("{input}", $this->renderfilter(), $_iO3b);
              }
              $_il31 = strtolower($_SERVER["HTTP_USER_AGENT"]);
              $_iO31 = (strpos($_il31, "msie 6") !== false) && (strpos($_il31, "msie 7") === false) && (strpos($_il31, "msie 8") === false) && (strpos($_il31, "opera") === false);
              $_il32 = (strpos($_il31, "msie 7") !== false) && (strpos($_il31, "opera") === false);
              $_il1b = _iO0("{id}", $this->_iO23 . "_flt", $_il3b);
              $_il1b = _iO0("{visible}", ($this->Visible || $_iO31 || $_il32) ? "" : "kgrHidden", $_il1b);
              $_il1b = _iO0("{content}", $_iO3b, $_il1b);
              return $_il1b;
          }
      }
      class _iO3f extends gridcolumn
      {
          var $AllowHtmlRender = false;
          function render($_il1l)
          {
              $_il3g = $this->format($_il1l->DataItem[$this->DataField]);
              if (!$this->AllowHtmlRender) {
                  $_il3g = _iO0("<", "&#60;", $_il3g);
                  $_il3g = _iO0(">", "&#62;", $_il3g);
              }
              return $_il3g;
          }
          function createinstance($_il30 = null)
          {
              if ($_il30 === null) {
                  $_il30 = new _iO3f();
              }
              parent::createinstance($_il30);
              $_il30->AllowHtmlRender = $this->AllowHtmlRender;
              return $_il30;
          }
      }
      class gridboundcolumn extends _iO3f
      {
          function inlineeditrender($_il1l)
          {
              if (!$this->ReadOnly) {
                  $_iO3g = "<div class='kgrEditIn kgrECap'><input id='{id}' class='kgrEnNoPo' name='{id}' type='text' value='{value}' style='width:100%' /></div>";
                  $_il3h = _iO0("{id}", $_il1l->_iO23 . "_" . $this->_iO23 . "_input", $_iO3g);
                  $_il3h = _iO0("{value}", htmlentities($this->format($_il1l->DataItem[$this->DataField]), ENT_QUOTES, $this->_il2d->_iO20->CharSet), $_il3h);
                  return $_il3h;
              } else {
                  return $this->render($_il1l);
              }
          }
          function formeditrender($_il1l)
          {
              $_iO3g = "<input id='{id}' class='kgrEnNoPo' name='{id}' type='text' value='{value}' style='width:90%' />";
              $_il3h = _iO0("{id}", $_il1l->_iO23 . "_" . $this->_iO23 . "_input", $_iO3g);
              $_il3h = _iO0("{value}", htmlentities($this->format($_il1l->DataItem[$this->DataField]), ENT_QUOTES, $this->_il2d->_iO20->CharSet), $_il3h);
              return $_il3h;
          }
          function createinstance($_il30 = null)
          {
              if ($_il30 === null) {
                  $_il30 = new gridboundcolumn();
              }
              parent::createinstance($_il30);
              return $_il30;
          }
      }
      class gridcalculatedcolumn extends gridboundcolumn
      {
          var $Expression;
          function _il22($_il2f)
          {
              parent::_il22($_il2f);
              $this->ReadOnly = true;
              $this->Aggregate = null;
          }
          function render($_il1l)
          {
              $_iO17 = $this->Expression;
              foreach ($_il1l->DataItem as $_il1r => $_iO1r) {
                  $_iO17 = _iO0("{" . $_il1r . "}", $_iO1r, $_iO17);
              }
              return eval("return " . $_iO17 . ";");
          }
          function createinstance($_il30 = null)
          {
              if ($_il30 === null) {
                  $_il30 = new gridcalculatedcolumn();
              }
              parent::createinstance($_il30);
              $_il30->Expression = $this->Expression;
              return $_il30;
          }
      }
      class gridnumbercolumn extends gridboundcolumn
      {
          var $DecimalNumber = 0;
          var $DecimalPoint = ".";
          var $ThousandSeperate = ",";
          function format($_il18)
          {
              $_iO3h = (double)$_il18;
              return number_format($_iO3h, $this->DecimalNumber, $this->DecimalPoint, $this->ThousandSeperate);
          }
          function createinstance($_il30 = null)
          {
              if ($_il30 === null) {
                  $_il30 = new gridnumbercolumn();
              }
              parent::createinstance($_il30);
              $_il30->DecimalNumber = $this->DecimalNumber;
              $_il30->DecimalPoint = $this->DecimalPoint;
              $_il30->ThousandSeperate = $this->ThousandSeperate;
              return $_il30;
          }
      }
      class gridcurrencycolumn extends gridboundcolumn
      {
          var $Locale = "en_US";
          var $FormatString = "%i";
          function format($_il18)
          {
              setlocale(LC_MONETARY, $this->Locale);
              return money_format($this->FormatString, $_il18);
          }
          function createinstance($_il30 = null)
          {
              if ($_il30 === null) {
                  $_il30 = new gridcurrencycolumn();
              }
              parent::createinstance($_il30);
              $_il30->Locale = $this->Locale;
              $_il30->FormatString = $this->FormatString;
              return $_il30;
          }
      }
      class gridtextareacolumn extends _iO3f
      {
          var $BoxHeight;
          function inlineeditrender($_il1l)
          {
              if (!$this->ReadOnly) {
                  $_iO3g = "<div class='kgrEditIn kgrECap'><textarea id='{id}' class='kgrEnNoPo' name='{id}' style='width:100%;{height}'>{value}</textarea></div>";
                  $_il3h = _iO0("{id}", $_il1l->_iO23 . "_" . $this->_iO23 . "_input", $_iO3g);
                  $_il3h = _iO0("{value}", htmlentities($_il1l->DataItem[$this->DataField], ENT_QUOTES, $this->_il2d->_iO20->CharSet), $_il3h);
                  $_il3h = _iO0("{height}", ($this->BoxHeight) ? "height:" . $this->BoxHeight . ";" : "", $_il3h);
                  return $_il3h;
              } else {
                  return $this->render($_il1l);
              }
          }
          function formeditrender($_il1l)
          {
              $_iO3g = "<textarea id='{id}' class='kgrEnNoPo' name='{id}' style='width:90%;{height}'>{value}</textarea>";
              $_il3h = _iO0("{id}", $_il1l->_iO23 . "_" . $this->_iO23 . "_input", $_iO3g);
              $_il3h = _iO0("{value}", htmlentities($_il1l->DataItem[$this->DataField], ENT_QUOTES, $this->_il2d->_iO20->CharSet), $_il3h);
              $_il3h = _iO0("{height}", ($this->Height) ? "height:" . $this->Height . ";" : "", $_il3h);
              return $_il3h;
          }
          function createinstance($_il30 = null)
          {
              if ($_il30 === null) {
                  $_il30 = new gridtextareacolumn();
              }
              parent::createinstance($_il30);
              $_il30->BoxHeight = $this->BoxHeight;
              return $_il30;
          }
      }
      class griddropdowncolumn extends gridcolumn
      {
          var $_il3i = array();
          function render($_il1l)
          {
              $_il18 = $_il1l->DataItem[$this->DataField];
              $_il3 = $_il1l->DataItem[$this->DataField];
              for ($_iO9 = 0; $_iO9 < sizeof($this->_il3i); $_iO9++) {
                  if ($_il18 == $this->_il3i[$_iO9][1]) {
                      $_il3 = $this->_il3i[$_iO9][0];
                      break;
                  }
              }
              return $_il3;
          }
          function additem($_il3, $_il18 = null)
          {
              if ($_il18 === null)
                  $_il18 = $_il3;
              array_push($this->_il3i, array($_il3, $_il18));
          }
          function _iO3i($_il1l, $_iO3c)
          {
              $_il3d = "<option value='{value}' {selected}>{text}</option>";
              $_il3e = "";
              foreach ($this->_il3i as $_iO16) {
                  $_iO3e = _iO0("{text}", $_iO16[0], $_il3d);
                  $_iO3e = _iO0("{value}", htmlentities($_iO16[1], ENT_QUOTES, $this->_il2d->_iO20->CharSet), $_iO3e);
                  $_iO3e = _iO0("{selected}", ($_iO16[1] == $_il1l->DataItem[$this->DataField]) ? "selected" : "", $_iO3e);
                  $_il3e .= $_iO3e;
              }
              $_il3f = _iO0("{id}", $_il1l->_iO23 . "_" . $this->_iO23 . "_input", $_iO3c);
              $_il3f = _iO0("{options}", $_il3e, $_il3f);
              return $_il3f;
          }
          function inlineeditrender($_il1l)
          {
              if (!$this->ReadOnly) {
                  $_iO3c = "<span class='kgrECap'><select id='{id}' name='{id}' style='width:100%'>{options}</select></span>";
                  return $this->_iO3i($_il1l, $_iO3c);
              } else {
                  return $this->render($_il1l);
              }
          }
          function formeditrender($_il1l)
          {
              $_iO3c = "<select id='{id}' name='{id}' style='width:90%'>{options}</select>";
              return $this->_iO3i($_il1l, $_iO3c);
          }
          function renderfilter()
          {
              $_iO3c = "<span class='kgrECap'><select id='{id}' name='{id}' style='width:100%' onchange='grid_filter_trigger(\"{colid}\",this)'>{options}</select></span>";
              $_il3d = "<option value='{value}' {selected}>{text}</option>";
              $_il3e = "";
              foreach ($this->_il3i as $_iO16) {
                  $_iO3e = _iO0("{text}", $_iO16[0], $_il3d);
                  $_iO3e = _iO0("{value}", $_iO16[1], $_iO3e);
                  $_iO3e = _iO0("{selected}", ($_iO16[1] == $this->Filter["Value"]) ? "selected" : "", $_iO3e);
                  $_il3e .= $_iO3e;
              }
              $_il3f = _iO0("{id}", $this->_iO23 . "_filter_input", $_iO3c);
              $_il3f = _iO0("{colid}", $this->_iO23, $_il3f);
              $_il3f = _iO0("{options}", $_il3e, $_il3f);
              return $_il3f;
          }
          function createinstance($_il30 = null)
          {
              if ($_il30 === null) {
                  $_il30 = new griddropdowncolumn();
              }
              parent::createinstance($_il30);
              $_il30->_il3i = $this->_il3i;
              return $_il30;
          }
      }
      class gridrowselectcolumn extends gridcolumn
      {
          var $Align = "center";
          function _il22($_il2f)
          {
              parent::_il22($_il2f);
              $this->AllowSorting = false;
              $this->AllowResizing = false;
              $this->AllowFiltering = false;
              $this->AllowGrouping = false;
              $this->ReadOnly = true;
              $this->Aggregate = null;
          }
          function render($_il1l)
          {
              $_il3j = "<span class='kgrECap'><input type='checkbox' class='kgrSelectSingleRow' {checked} onclick='grid_toggle_select(this)' /></span>";
              $_iO3j = _iO0("{checked}", $_il1l->Selected ? "checked" : "", $_il3j);
              return $_iO3j;
          }
          function _iO33()
          {
              $_il34 = "<col id='{id}' name='{id}' style='{width}' class='kgrColumnSelect {resizable} {visible}'/>";
              $_il2q = _iO0("{id}", $this->_iO23, $_il34);
              $_il2q = _iO0("{resizable}", ($this->AllowResizing) ? "kgrResizable" : "", $_il2q);
              $_il2q = _iO0("{width}", ($this->Width != null) ? "width:" . $this->Width . ";" : "", $_il2q);
              $_il2q = _iO0("{visible}", ($this->Visible) ? "" : "kgrHidden", $_il2q);
              return $_il2q;
          }
          function renderheader()
          {
              $_il3j = "<span class='kgrECap'><input type='checkbox' class='kgrSelectAllRows' {checked} onclick='grid_toggle_select(this)' /></span>";
              $_iO1k = $this->_il2d->_il3k;
              $_iO3k = true;
              for ($_iO9 = 0; $_iO9 < sizeof($_iO1k); $_iO9++) {
                  if (!$_iO1k[$_iO9]->Selected) {
                      $_iO3k = false;
                      break;
                  }
              }
              $this->HeaderText = _iO0("{checked}", $_iO3k ? "checked" : "", $_il3j);
              return parent::renderheader();
          }
          function createinstance($_il30 = null)
          {
              if ($_il30 === null) {
                  $_il30 = new gridrowselectcolumn();
              }
              parent::createinstance($_il30);
              return $_il30;
          }
      }
      class gridbooleancolumn extends gridcolumn
      {
          var $TrueText = "True";
          var $FalseText = "False";
          var $UseCheckBox = false;
          function render($_il1l)
          {
              $_il3h = "";
              if ($this->UseCheckBox) {
                  $_iO3g = "<input type='checkbox' {checked} disabled />";
                  $_il3h = _iO0("{checked}", ($_il1l->DataItem[$this->DataField]) ? "checked" : "", $_iO3g);
              } else {
                  $_il3h = ($_il1l->DataItem[$this->DataField]) ? $this->TrueText : $this->FalseText;
              }
              return $_il3h;
          }
          function inlineeditrender($_il1l, $_il3l = false)
          {
              if (!$this->ReadOnly) {
                  $_il3h = "";
                  if ($this->UseCheckBox) {
                      $_iO3g = "<span class='kgrECap'><input  id='{id}' name='{id}' type='checkbox' {checked} /></span>";
                      $_il3h = _iO0("{id}", $_il1l->_iO23 . "_" . $this->_iO23 . "_input", $_iO3g);
                      $_il3h = _iO0("{checked}", ($_il1l->DataItem[$this->DataField]) ? "checked" : "", $_il3h);
                  } else {
                      $_iO3c = "<span class='kgrECap'><select id='{id}' name='{id}' style='width:{width}'>{options}</select></span>";
                      $_il3d = "<option value='{value}' {selected}>{text}</option>";
                      $_iO3l = _iO0("{value}", "1", $_il3d);
                      $_iO3l = _iO0("{selected}", ($_il1l->DataItem[$this->DataField]) ? "selected" : "", $_iO3l);
                      $_iO3l = _iO0("{text}", $this->TrueText, $_iO3l);
                      $_il3m = _iO0("{value}", "0", $_il3d);
                      $_il3m = _iO0("{selected}", (!$_il1l->DataItem[$this->DataField]) ? "selected" : "", $_il3m);
                      $_il3m = _iO0("{text}", $this->FalseText, $_il3m);
                      $_il3h = _iO0("{id}", $_il1l->_iO23 . "_" . $this->_iO23 . "_input", $_iO3c);
                      $_il3h = _iO0("{options}", $_iO3l . $_il3m, $_il3h);
                      $_il3h = _iO0("{width}", ($_il3l) ? "90%" : "100%", $_il3h);
                  }
                  return $_il3h;
              } else {
                  return $this->render($_il1l);
              }
          }
          function formeditrender($_il1l)
          {
              return $this->inlineeditrender($_il1l, true);
          }
          function geteditvalue($_il1l)
          {
              if ($this->UseCheckBox) {
                  return isset($_POST[$_il1l->_iO23 . "_" . $this->_iO23 . "_input"]) ? 1 : 0;
              } else {
                  return parent::geteditvalue($_il1l);
              }
          }
          function renderfilter()
          {
              $_il3h = "";
              if ($this->UseCheckBox) {
                  $_iO3g = "<span class='kgrECap'><input  id='{id}' name='{id}' type='checkbox' {checked} onchange='grid_filter_trigger(\"{colid}\",this)' /></span>";
                  $_il3h = _iO0("{id}", $this->_iO23 . "_filter_input", $_iO3g);
                  $_il3h = _iO0("{colid}", $this->_iO23, $_il3h);
                  $_il3h = _iO0("{checked}", ($this->Filter["Value"]) ? "checked" : "", $_il3h);
              } else {
                  $_iO3c = "<span class='kgrECap'><select id='{id}' name='{id}' style='width:100%' onchange='grid_filter_trigger(\"{colid}\",this)'>{options}</select></span>";
                  $_il3d = "<option value='{value}' {selected}>{text}</option>";
                  $_iO3l = _iO0("{value}", "1", $_il3d);
                  $_iO3l = _iO0("{selected}", ($this->Filter["Value"]) ? "selected" : "", $_iO3l);
                  $_iO3l = _iO0("{text}", $this->TrueText, $_iO3l);
                  $_il3m = _iO0("{value}", "0", $_il3d);
                  $_il3m = _iO0("{selected}", (!$this->Filter["Value"]) ? "selected" : "", $_il3m);
                  $_il3m = _iO0("{text}", $this->FalseText, $_il3m);
                  $_il3h = _iO0("{id}", $this->_iO23 . "_filter_input", $_iO3c);
                  $_il3h = _iO0("{colid}", $this->_iO23, $_il3h);
                  $_il3h = _iO0("{options}", $_iO3l . $_il3m, $_il3h);
              }
              return $_il3h;
          }
          function _iO2z()
          {
              if ($this->UseCheckBox) {
                  return isset($_POST[$this->_iO23 . "_filter_input"]) ? 1 : 0;
              } else {
                  return parent::_iO2z();
              }
          }
          function createinstance($_il30 = null)
          {
              if ($_il30 === null) {
                  $_il30 = new gridbooleancolumn();
              }
              parent::createinstance($_il30);
              $_il30->TrueText = $this->TrueText;
              $_il30->FalseText = $this->FalseText;
              $_il30->UseCheckBox = $this->UseCheckBox;
              return $_il30;
          }
      }
      class gridimagecolumn extends gridcolumn
      {
          var $ImageFolder = "";
          var $CssClass = "";
          function render($_il1l)
          {
              $_iO3g = "<img src='{src}' class='{class}' alt='' />";
              $_il3h = _iO0("{src}", (($this->ImageFolder != "") ? ($this->ImageFolder . "/") : "") . $_il1l->DataItem[$this->DataField], $_iO3g);
              $_il3h = _iO0("{class}", $this->CssClass, $_il3h);
              return $_il3h;
          }
          function inlineeditrender($_il1l)
          {
              return $this->render($_il1l);
          }
          function createinstance($_il30 = null)
          {
              if ($_il30 === null) {
                  $_il30 = new gridimagecolumn();
              }
              parent::createinstance($_il30);
              $_il30->ImageFolder = $this->ImageFolder;
              $_il30->CssClass = $this->CssClass;
              return $_il30;
          }
      }
      class gridcustomcolumn extends gridcolumn
      {
          var $ItemTemplate;
          var $EditItemTemplate;
          function _il22($_il2f)
          {
              parent::_il22($_il2f);
              $this->ReadOnly = true;
          }
          function render($_il1l)
          {
              $_il3h = $this->ItemTemplate;
              foreach ($_il1l->DataItem as $_il1r => $_iO1r) {
                  $_il3h = _iO0("{" . $_il1r . "}", $_iO1r, $_il3h);
              }
              return $_il3h;
          }
          function inlineeditrender($_il1l)
          {
              $_il3h = $this->EditItemTemplate;
              foreach ($_il1l->DataItem as $_il1r => $_iO1r) {
                  $_il3h = _iO0("{" . $_il1r . "}", $_iO1r, $_il3h);
              }
              return $_il3h;
          }
          function createinstance($_il30 = null)
          {
              if ($_il30 === null) {
                  $_il30 = new gridcustomcolumn();
              }
              parent::createinstance($_il30);
              $_il30->ItemTemplate = $this->ItemTemplate;
              $_il30->EditItemTemplate = $this->EditItemTemplate;
              return $_il30;
          }
      }
      class gridcommandcolumn extends gridcolumn
      {
          var $CommandText = "Command";
          var $OnClick = "";
          var $CssClass = "";
          function _il22($_il2f)
          {
              parent::_il22($_il2f);
              $this->AllowSorting = false;
              $this->AllowFiltering = false;
              $this->AllowGrouping = false;
              $this->AllowExporting = false;
              $this->ReadOnly = true;
              $this->Aggregate = null;
          }
          function render($_il1l)
          {
              $_iO3g = "<span class='kgrECap'><input type='button' class='{class}' value='{text}' onclick='{onclick}' /></span>";
              $_il3h = _iO0("{class}", $this->CssClass, $_iO3g);
              $_il3 = $this->CommandText;
              $_iO3m = $this->OnClick;
              foreach ($_il1l->DataItem as $_il1r => $_iO1r) {
                  $_il3 = _iO0("{" . $_il1r . "}", $_iO1r, $_il3);
                  $_iO3m = _iO0("{" . $_il1r . "}", $_iO1r, $_iO3m);
              }
              $_il3h = _iO0("{text}", $_il3, $_il3h);
              $_il3h = _iO0("{onclick}", $_iO3m, $_il3h);
              return $_il3h;
          }
          function inlineeditrender($_il1l)
          {
              return $this->render($_il1l);
          }
          function createinstance($_il30 = null)
          {
              if ($_il30 === null) {
                  $_il30 = new gridcommandcolumn();
              }
              parent::createinstance($_il30);
              $_il30->CommandText = $this->CommandText;
              $_il30->OnClick = $this->OnClick;
              $_il30->CssClass = $this->CssClass;
              return $_il30;
          }
      }
      class grideditdeletecolumn extends gridcolumn
      {
          var $ButtonType = "Link";
          var $EditButtonText;
          var $DeleteButtonText;
          var $ConfirmButtonText;
          var $CancelButtonText;
          var $EditButtonImageUrl = "";
          var $DeleteButtonImageUrl = "";
          var $ConfirmButtonImageUrl = "";
          var $CancelButtonImageUrl = "";
          var $EditButtonCssClass = "";
          var $ConfirmButtonCssClass = "";
          var $CancelButtonCssClass = "";
          var $DeleteButtonCssClass = "";
          var $ShowEditButton = true;
          var $ShowDeleteButton = true;
          function _il22($_il2f)
          {
              parent::_il22($_il2f);
              $this->AllowSorting = false;
              $this->AllowResizing = false;
              $this->AllowFiltering = false;
              $this->AllowGrouping = false;
              $this->AllowExporting = false;
              $this->ReadOnly = true;
              $this->Aggregate = null;
              if ($this->EditButtonText === null)
                  $this->EditButtonText = $_il2f->_iO20->Localization->_il28["Edit"];
              if ($this->DeleteButtonText === null)
                  $this->DeleteButtonText = $_il2f->_iO20->Localization->_il28["Delete"];
              if ($this->ConfirmButtonText === null)
                  $this->ConfirmButtonText = $_il2f->_iO20->Localization->_il28["Confirm"];
              if ($this->CancelButtonText === null)
                  $this->CancelButtonText = $_il2f->_iO20->Localization->_il28["Cancel"];
          }
          function render($_il1l)
          {
              $_il34 = "<span class='kgrECap'>{edit} {delete}</span>";
              $_il3n = "";
              switch (strtolower($this->ButtonType)) {
                  case "link":
                      $_il3n = "<a type='button' class='{class}' onclick='{onclick}' href='javascript:void 0'>{text}</a>";
                      break;
                  case "image":
                      $_il3n = "<input type='image' src='{src}' onclick='{onclick}' class='{class}' />";
                      break;
                  case "button":
                  default:
                      $_il3n = "<input class='{class}' type='button' value='{text}' onclick='{onclick}' />";
                      break;
              }
              $_iO3n = _iO0("{text}", $this->EditButtonText, $_il3n);
              $_iO3n = _iO0("{class}", $this->EditButtonCssClass, $_iO3n);
              $_iO3n = _iO0("{src}", $this->EditButtonImageUrl, $_iO3n);
              $_iO3n = _iO0("{onclick}", "grid_edit(this)", $_iO3n);
              $_il3o = _iO0("{text}", $this->DeleteButtonText, $_il3n);
              $_il3o = _iO0("{class}", $this->DeleteButtonCssClass, $_il3o);
              $_il3o = _iO0("{src}", $this->DeleteButtonImageUrl, $_il3o);
              $_il3o = _iO0("{onclick}", "grid_delete(this)", $_il3o);
              $_il2q = _iO0("{edit}", ($this->ShowEditButton) ? $_iO3n : "", $_il34);
              $_il2q = _iO0("{delete}", ($this->ShowDeleteButton) ? $_il3o : "", $_il2q);
              return $_il2q;
          }
          function inlineeditrender($_il1l)
          {
              if ($this->ShowEditButton) {
                  $_il34 = "<span class='kgrECap'>{confirm} {cancel}</span>";
                  $_il3n = "";
                  switch (strtolower($this->ButtonType)) {
                      case "link":
                          $_il3n = "<a type='button' class='{class}' onclick='{onclick}' href='javascript:void 0'>{text}</a>";
                          break;
                      case "image":
                          $_il3n = "<input type='image' src='{src}' onclick='{onclick}' class='{class}' />";
                          break;
                      case "button":
                      default:
                          $_il3n = "<input class='{class}' type='button' value='{text}' onclick='{onclick}' />";
                          break;
                  }
                  $_iO3o = _iO0("{text}", $this->ConfirmButtonText, $_il3n);
                  $_iO3o = _iO0("{class}", $this->ConfirmButtonCssClass, $_iO3o);
                  $_iO3o = _iO0("{src}", $this->ConfirmButtonImageUrl, $_iO3o);
                  $_iO3o = _iO0("{onclick}", "grid_confirm_edit(this)", $_iO3o);
                  $_il3p = _iO0("{text}", $this->CancelButtonText, $_il3n);
                  $_il3p = _iO0("{class}", $this->CancelButtonCssClass, $_il3p);
                  $_il3p = _iO0("{src}", $this->CancelButtonImageUrl, $_il3p);
                  $_il3p = _iO0("{onclick}", "grid_cancel_edit(this)", $_il3p);
                  $_il2q = _iO0("{confirm}", $_iO3o, $_il34);
                  $_il2q = _iO0("{cancel}", $_il3p, $_il2q);
                  return $_il2q;
              } else {
                  return $this->render($_il1l);
              }
          }
          function createinstance($_il30 = null)
          {
              if ($_il30 === null) {
                  $_il30 = new grideditdeletecolumn();
              }
              parent::createinstance($_il30);
              $_il30->ButtonType = $this->ButtonType;
              $_il30->ReadOnly = $this->ReadOnly;
              $_il30->EditButtonText = $this->EditButtonText;
              $_il30->DeleteButtonText = $this->DeleteButtonText;
              $_il30->ConfirmButtonText = $this->ConfirmButtonText;
              $_il30->CancelButtonText = $this->CancelButtonText;
              $_il30->EditButtonImageUrl = $this->EditButtonImageUrl;
              $_il30->DeleteButtonImageUrl = $this->DeleteButtonImageUrl;
              $_il30->ConfirmButtonImageUrl = $this->ConfirmButtonImageUrl;
              $_il30->CancelButtonImageUrl = $this->CancelButtonImageUrl;
              $_il30->EditButtonCssClass = $this->EditButtonCssClass;
              $_il30->DeleteButtonCssClass = $this->DeleteButtonCssClass;
              $_il30->ConfirmButtonCssClass = $this->ConfirmButtonCssClass;
              $_il30->CancelButtonCssClass = $this->CancelButtonCssClass;
              $_il30->ShowEditButton = $this->ShowEditButton;
              $_il30->ShowDeleteButton = $this->ShowDeleteButton;
              return $_il30;
          }
      }
      class gridexpanddetailcolumn extends gridcolumn
      {
          function _il22($_il2f)
          {
              parent::_il22($_il2f);
              $this->AllowSorting = false;
              $this->AllowResizing = false;
              $this->AllowFiltering = false;
              $this->AllowGrouping = false;
              $this->AllowExporting = false;
              $this->ReadOnly = true;
              $this->Aggregate = null;
          }
          function render($_il1l)
          {
              $_il34 = "<span class='kgr{status} kgrECap' onclick='grid_{command}(this)'> </span>";
              $_il2q = _iO0("{status}", ($_il1l->Expand) ? "Expand" : "Collapse", $_il34);
              $_il2q = _iO0("{command}", ($_il1l->Expand) ? "collapse" : "expand", $_il2q);
              return $_il2q;
          }
          function _iO33()
          {
              $_il34 = "<col id='{id}' name='{id}' style='{width}' class='kgrColumnExpand {resizable} {visible}'/>";
              $_il2q = _iO0("{id}", $this->_iO23, $_il34);
              $_il2q = _iO0("{resizable}", ($this->AllowResizing) ? "kgrResizable" : "", $_il2q);
              $_il2q = _iO0("{width}", ($this->Width != null) ? "width:" . $this->Width . ";" : "", $_il2q);
              $_il2q = _iO0("{visible}", ($this->Visible) ? "" : "kgrHidden", $_il2q);
              return $_il2q;
          }
          function createinstance($_il30 = null)
          {
              if ($_il30 === null) {
                  $_il30 = new gridexpanddetailcolumn();
              }
              parent::createinstance($_il30);
              return $_il30;
          }
      }
      class _iO3p extends gridcolumn
      {
          function _il22($_il2f)
          {
              parent::_il22($_il2f);
              $this->AllowSorting = false;
              $this->AllowResizing = false;
              $this->AllowFiltering = false;
              $this->AllowGrouping = false;
              $this->ReadOnly = true;
              $this->Aggregate = null;
              $this->AllowExporting = false;
          }
          function render($_il1l)
          {
              return "&#160;";
          }
          function _iO33()
          {
              $_il34 = "<col id='{id}' name='{id}' style='{width}' class='kgrColumnGroup'/>";
              $_il2q = _iO0("{id}", $this->_iO23, $_il34);
              $_il2q = _iO0("{width}", ($this->Width != null) ? "width:" . $this->Width . ";" : "", $_il2q);
              return $_il2q;
          }
          function createinstance($_il30 = null)
          {
              if ($_il30 === null) {
                  $_il30 = new _iO3p();
              }
              parent::createinstance($_il30);
              return $_il30;
          }
      }
      class griddatetimecolumn extends gridcolumn
      {
          var $Picker;
          var $FormatString;
          function _il22($_il2f)
          {
              parent::_il22($_il2f);
              if ($this->FormatString === null) {
                  $this->FormatString = "m/d/Y g:i A";
                  if ($this->Picker !== null) {
                      switch (strtolower(get_class($this->Picker))) {
                          case "kooldatetimepicker":
                              $this->FormatString = $this->Picker->DateFormat . " " . $this->Picker->TimeFormat;
                              break;
                          case "kooldatepicker":
                              $this->FormatString = $this->Picker->DateFormat;
                              break;
                          case "kooltimepicker":
                              $this->FormatString = $this->Picker->TimeFormat;
                              break;
                      }
                  }
              }
          }
          function inlineeditrender($_il1l)
          {
              if (!$this->ReadOnly) {
                  $_il3q = $_il1l->DataItem[$this->DataField];
                  $_iO3q = strtotime($_il3q);
                  if ($this->Picker !== null) {
                      $_il3r = "m/d/Y g:i A";
                      switch (strtolower(get_class($this->Picker))) {
                          case "kooldatetimepicker":
                              $_il3r = $this->Picker->DateFormat . " " . $this->Picker->TimeFormat;
                              break;
                          case "kooldatepicker":
                              $_il3r = $this->Picker->DateFormat;
                              break;
                          case "kooltimepicker":
                              $_il3r = $this->Picker->TimeFormat;
                              break;
                      }
                      $this->Picker->id = $_il1l->_iO23 . "_" . $this->_iO23 . "_input";
                      $this->Picker->Width = "100%";
                      $this->Picker->ClientEvents = array();
                      $this->Picker->init();
                      $this->Picker->Value = ($_il3q != "") ? date($_il3r, $_iO3q) : "";
                      $_iO3g = "<div class='kgrECap'>{picker}{js_edit_overflow}</div>";
                      $_iO3r = "<script type='text/javascript'>document.getElementById('{id}').className+=' kgrEnNoPo';var _agent=navigator.userAgent.toLowerCase();if(!((_agent.indexOf('msie 6')!=-1 || _agent.indexOf('msie 7')!=-1)&&_agent.indexOf('msie 8')==-1 &&_agent.indexOf('opera')==-1)){document.getElementById('{id}_bound').parentNode.parentNode.style.overflow='visible';}</script>";
                      $_il3s = _iO0("{id}", $this->Picker->id, $_iO3r);
                      $_il3h = _iO0("{picker}", $this->Picker->render(), $_iO3g);
                      $_il3h = _iO0("{js_edit_overflow}", $_il3s, $_il3h);
                      return $_il3h;
                  } else {
                      $_iO3g = "<div class='kgrEditIn kgrECap'><input id='{id}' class='kgrEnNoPo' name='{id}' type='text' value='{value}' style='width:100%' /></div>";
                      $_il3h = _iO0("{id}", $_il1l->_iO23 . "_" . $this->_iO23 . "_input", $_iO3g);
                      $_il3h = _iO0("{value}", ($_il3q != "") ? htmlentities(date($this->FormatString, $_iO3q), ENT_QUOTES, $this->_il2d->_iO20->CharSet) : "", $_il3h);
                      return $_il3h;
                  }
              } else {
                  return $this->render($_il1l);
              }
          }
          function formeditrender($_il1l)
          {
              $_il3q = $_il1l->DataItem[$this->DataField];
              $_iO3q = strtotime($_il3q);
              if ($this->Picker !== null) {
                  $_il3r = "m/d/Y g:i A";
                  switch (strtolower(get_class($this->Picker))) {
                      case "kooldatetimepicker":
                          $_il3r = $this->Picker->DateFormat . " " . $this->Picker->TimeFormat;
                          break;
                      case "kooldatepicker":
                          $_il3r = $this->Picker->DateFormat;
                          break;
                      case "kooltimepicker":
                          $_il3r = $this->Picker->TimeFormat;
                          break;
                  }
                  $this->Picker->id = $_il1l->_iO23 . "_" . $this->_iO23 . "_input";
                  $this->Picker->Width = "90%";
                  $this->Picker->ClientEvents = array();
                  $this->Picker->init();
                  $this->Picker->Value = ($_il3q != "") ? date($_il3r, $_iO3q) : "";
                  $_iO3g = "<div class='kgrECap'>{picker}{js_edit_overflow}</div>";
                  $_iO3r = "<script type='text/javascript'>document.getElementById('{id}').className+=' kgrEnNoPo';</script>";
                  $_il3s = _iO0("{id}", $this->Picker->id, $_iO3r);
                  $_il3h = _iO0("{picker}", $this->Picker->render(), $_iO3g);
                  $_il3h = _iO0("{js_edit_overflow}", $_il3s, $_il3h);
                  return $_il3h;
              } else {
                  $_iO3g = "<div class='kgrEditIn kgrECap'><input id='{id}' class='kgrEnNoPo' name='{id}' type='text' value='{value}' style='width:90%' /></div>";
                  $_il3h = _iO0("{id}", $_il1l->_iO23 . "_" . $this->_iO23 . "_input", $_iO3g);
                  $_il3h = _iO0("{value}", ($_il3q != "") ? htmlentities(date($this->FormatString, $_iO3q), ENT_QUOTES, $this->_il2d->_iO20->CharSet) : "", $_il3h);
                  return $_il3h;
              }
          }
          function renderfilter()
          {
              $_il3q = $this->Filter["Value"];
              $_iO3q = strtotime($_il3q);
              if ($this->Picker !== null) {
                  $_il3r = "m/d/Y g:i A";
                  switch (strtolower(get_class($this->Picker))) {
                      case "kooldatetimepicker":
                          $_il3r = $this->Picker->DateFormat . " " . $this->Picker->TimeFormat;
                          break;
                      case "kooldatepicker":
                          $_il3r = $this->Picker->DateFormat;
                          break;
                      case "kooltimepicker":
                          $_il3r = $this->Picker->TimeFormat;
                          break;
                  }
                  $this->Picker->id = $this->_iO23 . "_filter_input";
                  $this->Picker->Width = "100%";
                  $this->Picker->ClientEvents["OnSelect"] = $this->Picker->id . "_onselect";
                  $this->Picker->init();
                  $this->Picker->Value = ($_il3q != "") ? date($_il3r, $_iO3q) : "";
                  $_iO3g = "<div class='kgrECap'>{picker}{js_init}</div>";
                  $_iO3s = "<script type='text/javascript'>function {id}_onselect(){grid_filter_trigger(\"{colid}\",document.getElementById('{id}'))};var _input = document.getElementById('{id}');_input.className+='kgrFiEnTr'; var _agent=navigator.userAgent.toLowerCase();if(!((_agent.indexOf('msie 6')!=-1 || _agent.indexOf('msie 7')!=-1)&&_agent.indexOf('msie 8')==-1 &&_agent.indexOf('opera')==-1)){document.getElementById('{id}_bound').parentNode.parentNode.parentNode.style.overflow='visible';}</script>";
                  $_il3t = _iO0("{id}", $this->Picker->id, $_iO3s);
                  $_il3t = _iO0("{colid}", $this->_iO23, $_il3t);
                  $_il3h = _iO0("{picker}", $this->Picker->render(), $_iO3g);
                  $_il3h = _iO0("{js_init}", $_il3t, $_il3h);
                  return $_il3h;
              } else {
                  $_iO39 = "<div class='kgrEditIn'><input class='kgrFiEnTr' type='text' id='{id}' name='{id}' value='{text}' onblur='grid_filter_trigger(\"{colid}\",this)' style='width:100%;' /></div>";
                  $_il3a = _iO0("{id}", $this->_iO23 . "_filter_input", $_iO39);
                  $_il3a = _iO0("{colid}", $this->_iO23, $_il3a);
                  $_il3a = _iO0("{text}", ($_il3q != "") ? htmlentities(date($this->FormatString, $_iO3q), ENT_QUOTES, $this->_il2d->_iO20->CharSet) : "", $_il3a);
                  return $_il3a;
              }
          }
          function render($_il1l)
          {
              $_iO3q = strtotime($_il1l->DataItem[$this->DataField]);
	      return date_format(date_create($_il1l->DataItem[$this->DataField]), $this->FormatString);
          }
          function geteditvalue($_il1l)
          {
              $_iO3t = _iO12($_POST[$_il1l->_iO23 . "_" . $this->_iO23 . "_input"]);
              $_iO3q = strtotime($_iO3t);
              return date("Y-m-d H:i:s", $_iO3q);
          }
          function _iO2z()
          {
              $_iO3t = _iO12($_POST[$this->_iO23 . "_filter_input"]);
              $_iO3q = strtotime($_iO3t);
              return date("Y-m-d H:i:s", $_iO3q);
          }
          function createinstance($_il30 = null)
          {
              if ($_il30 === null) {
                  $_il30 = new griddatetimecolumn();
              }
              parent::createinstance($_il30);
              $_il30->Picker = $this->Picker;
              $_il30->FormatString = $this->FormatString;
              return $_il30;
          }
      }
      class _il3u implements _iO1s
      {
          var $_iO23;
          var $_il2d;
          var $_iO2c;
          var $TableView;
          var $PageIndex = 0;
          var $_iO3u;
          var $_il3v;
          var $PageSize;
          var $ShowPageInfo = true;
          var $PageInfoTemplate;
          var $ShowPageSize = true;
          var $PageSizeText;
          var $PageSizeOptions = "20, 40, 60";
          function _il22($_il2f)
          {
              $this->_il2d = $_il2f;
              $this->TableView = $_il2f;
              $this->_iO2c = $_il2f->_iO2c;
              if ($this->PageSize === null)
                  $this->PageSize = $this->_il2d->PageSize;
              if ($this->PageInfoTemplate === null)
                  $this->PageInfoTemplate = $_il2f->_iO20->Localization->_iO28["PageInfoTemplate"];
              if ($this->PageSizeText === null)
                  $this->PageSizeText = $_il2f->_iO20->Localization->_iO28["PageSizeText"];
          }
          function _il1t()
          {
              if (isset($this->_iO2c->_iO1p[$this->_iO23])) {
                  $_iO2f = $this->_iO2c->_iO1p[$this->_iO23];
                  $this->PageIndex = $_iO2f["PageIndex"];
                  $this->_iO3u = $_iO2f["_TotalPages"];
                  $this->_il3v = $_iO2f["_TotalRows"];
                  $this->PageSize = $_iO2f["PageSize"];
              }
          }
          function _iO1t()
          {
              $this->_iO2c->_iO1p[$this->_iO23] = array("PageIndex" => $this->PageIndex, "_TotalPages" => $this->_iO3u, "PageSize" => $this->PageSize, "_TotalRows" => $this->_il3v);
          }
          function _il2l($_ilm)
          {
              if (isset($_ilm->_il28[$this->_iO23])) {
                  $_iO2l = $_ilm->_il28[$this->_iO23];
                  switch ($_iO2l["Command"]) {
                      case "GoPage":
                          if ($this->_il2d->_iO20->EventHandler->onbeforepageindexchange($this, array("NewPageIndex" => $_iO2l["Args"]["PageIndex"])) == true) {
                              $this->PageIndex = $_iO2l["Args"]["PageIndex"];
                              $this->_il2d->_iO24 = true;
                              $this->_il2d->_iO20->EventHandler->onpageindexchange($this, array());
                          }
                          break;
                      case "ChangePageSize":
                          if ($this->_il2d->_iO20->EventHandler->onbeforepagesizechange($this, array("NewPageSize" => $_iO2l["Args"]["PageSize"])) == true) {
                              $this->PageSize = $_iO2l["Args"]["PageSize"];
                              $this->_il2d->_iO24 = true;
                              $this->_il2d->_iO20->EventHandler->onpagesizechange($this, array());
                          }
                          break;
                  }
              }
              $this->_iO3u = ceil($this->_il3v / $this->PageSize);
              if ($this->PageIndex >= $this->_iO3u)
                  $this->PageIndex = $this->_iO3u - 1;
              if ($this->PageIndex < 0)
                  $this->PageIndex = 0;
          }
          function _iO25()
          {
              return "";
          }
          function _iO3v()
          {
              $_il3w = "<div class='kgrInfo'>{text}</div>";
              $_il3 = _iO0("{PageIndex}", ($this->_iO3u > 0) ? ($this->PageIndex + 1) : 0, $this->PageInfoTemplate);
              $_il3 = _iO0("{TotalPages}", $this->_iO3u, $_il3);
              $_iO3w = ($this->_iO3u > 0) ? ($this->PageIndex * $this->PageSize + 1) : 0;
              $_il3x = ($this->PageIndex + 1) * $this->PageSize;
              if ($_il3x > $this->_il3v)
                  $_il3x = $this->_il3v;
              $_il3 = _iO0("{FirstIndexInPage}", $_iO3w, $_il3);
              $_il3 = _iO0("{LastIndexInPage}", $_il3x, $_il3);
              $_il3 = _iO0("{TotalRows}", $this->_il3v, $_il3);
              $_iO3x = _iO0("{text}", $_il3, $_il3w);
              return $_iO3x;
          }
          function _il3y()
          {
              $_iO3y = "<div class='kgrPageSize'>{text}{select}</div>";
              $_iO3c = "<select onchange='grid_pagesize_select_onchange(this)'>{options}</select>";
              $_il3d = "<option value='{value}' {selected}>{value}</option>";
              $_il3e = "";
              $_il3z = explode(',', $this->PageSizeOptions);
              for ($_iO9 = 0; $_iO9 < sizeof($_il3z); $_iO9++) {
                  $_iO3e = _iO0("{value}", $_il3z[$_iO9], $_il3d);
                  $_iO3e = _iO0("{selected}", ($this->PageSize == (int)$_il3z[$_iO9]) ? "selected" : "", $_iO3e);
                  $_il3e .= $_iO3e;
              }
              $_il3f = _iO0("{options}", $_il3e, $_iO3c);
              $_iO3z = _iO0("{text}", $this->PageSizeText, $_iO3y);
              $_iO3z = _iO0("{select}", $_il3f, $_iO3z);
              return $_iO3z;
          }
          function _il2j(&$_il30)
          {
              $_il30->PageIndex = $this->PageIndex;
              $_il30->ShowPageInfo = $this->ShowPageInfo;
              $_il30->PageInfoTemplate = $this->PageInfoTemplate;
              $_il30->ShowPageSize = $this->ShowPageSize;
              $_il30->PageSizeText = $this->PageSizeText;
              $_il30->PageSizeOptions = $this->PageSizeOptions;
          }
      }
      class gridprevnextpager extends _il3u
      {
          var $PrevPageText;
          var $PrevPageToolTip;
          var $NextPageText;
          var $NextPageToolTip;
          function _il22($_il2f)
          {
              parent::_il22($_il2f);
              if ($this->PrevPageText === null)
                  $this->PrevPageText = $_il2f->_iO20->Localization->_il28["Prev"];
              if ($this->PrevPageToolTip === null)
                  $this->PrevPageToolTip = $_il2f->_iO20->Localization->_iO28["PrevPageToolTip"];
              if ($this->NextPageText === null)
                  $this->NextPageText = $_il2f->_iO20->Localization->_il28["Next"];
              if ($this->NextPageToolTip === null)
                  $this->NextPageToolTip = $_il2f->_iO20->Localization->_iO28["NextPageToolTip"];
          }
          function _iO25()
          {
              $_il40 = "<div class='kgrPager kgrNextPrevNextPager'>{pagesize}{nav}{info}<div style='clear:both'></div></div>";
              $_iO40 = "<div class='kgrNav'>{prev} {next}</div>";
              $_il3n = "<input type='button' onclick='{onclick}' title='{title}'/>";
              $_il41 = "<a href='javascript:void 0' onclick='{onclick}' title='{title}'>{text}</a>";
              $_iO41 = "<span class= '{class}'>{button}</span>";
              $_il42 = _iO0("{onclick}", ($this->PageIndex > 0) ? "grid_gopage(this," . ($this->PageIndex - 1) . ")" : "", $_il3n);
              $_il42 = _iO0("{title}", $this->PrevPageToolTip, $_il42);
              $_iO42 = $this->PrevPageText;
              if ($this->PageIndex > 0 && $this->PrevPageText !== null) {
                  $_iO42 = _iO0("{onclick}", "grid_gopage(this," . ($this->PageIndex - 1) . ")", $_il41);
                  $_iO42 = _iO0("{text}", $this->PrevPageText, $_iO42);
                  $_iO42 = _iO0("{title}", $this->PrevPageToolTip, $_iO42);
              }
              $_il43 = _iO0("{button}", $_il42 . $_iO42, $_iO41);
              $_il43 = _iO0("{class}", "kgrPrev", $_il43);
              $_iO43 = _iO0("{onclick}", ($this->PageIndex < $this->_iO3u - 1) ? "grid_gopage(this," . ($this->PageIndex + 1) . ")" : "", $_il3n);
              $_iO43 = _iO0("{title}", $this->NextPageToolTip, $_iO43);
              $_il44 = $this->NextPageText;
              if (($this->PageIndex < $this->_iO3u - 1) && $this->NextPageText !== null) {
                  $_il44 = _iO0("{onclick}", "grid_gopage(this," . ($this->PageIndex + 1) . ")", $_il41);
                  $_il44 = _iO0("{text}", $this->NextPageText, $_il44);
                  $_il44 = _iO0("{title}", $this->NextPageToolTip, $_il44);
              }
              $_iO44 = _iO0("{button}", $_il44 . $_iO43, $_iO41);
              $_iO44 = _iO0("{class}", "kgrNext", $_iO44);
              $_il45 = _iO0("{prev}", $_il43, $_iO40);
              $_il45 = _iO0("{next}", $_iO44, $_il45);
              $_iO3z = ($this->ShowPageSize) ? $this->_il3y() : "";
              $_iO3x = ($this->ShowPageInfo) ? $this->_iO3v() : "";
              $_iO45 = _iO0("{nav}", $_il45, $_il40);
              $_iO45 = _iO0("{info}", $_iO3x, $_iO45);
              $_iO45 = _iO0("{pagesize}", $_iO3z, $_iO45);
              return $_iO45;
          }
          function _il2j()
          {
              $_il30 = new gridprevnextpager();
              parent::_il2j($_il30);
              $_il30->NextPageText = $this->NextPageText;
              $_il30->NextPageToolTip = $this->NextPageToolTip;
              $_il30->PrevPageText = $this->PrevPageText;
              $_il30->PrevPageToolTip = $this->PrevPageToolTip;
              return $_il30;
          }
      }
      class gridnumericpager extends _il3u
      {
          var $Range = 012;
          function _iO25()
          {
              $_il40 = "<div class='kgrPager kgrNumericPager'>{pagesize}{nav}{info}<div style='clear:both'></div></div>";
              $_iO40 = "<div class='kgrNav'>{numbers}</div>";
              $_il46 = "<a class='kgrNum {selected}' {href} {onclick}><span>{number}</span></a> ";
              $_iO46 = floor($this->PageIndex / $this->Range) * $this->Range;
              $_il47 = "";
              if ($_iO46 > 0) {
                  $_iO3h = _iO0("{href}", "href='javascript:void 0'", $_il46);
                  $_iO3h = _iO0("{onclick}", "onclick='grid_gopage(this," . ($_iO46 - 1) . ")'", $_iO3h);
                  $_iO3h = _iO0("{number}", "...", $_iO3h);
                  $_il47 .= $_iO3h;
              }
              for ($_iO9 = $_iO46; $_iO9 < $_iO46 + $this->Range && $_iO9 < $this->_iO3u; $_iO9++) {
                  $_iO3h = _iO0("{number}", ($_iO9 + 1), $_il46);
                  if ($_iO9 == $this->PageIndex) {
                      $_iO3h = _iO0("{selected}", "kgrNumSelected", $_iO3h);
                      $_iO3h = _iO0("{href}", "", $_iO3h);
                      $_iO3h = _iO0("{onclick}", "", $_iO3h);
                  } else {
                      $_iO3h = _iO0("{selected}", "", $_iO3h);
                      $_iO3h = _iO0("{href}", "href='javascript:void 0'", $_iO3h);
                      $_iO3h = _iO0("{onclick}", "onclick='grid_gopage(this," . $_iO9 . ")'", $_iO3h);
                  }
                  $_il47 .= $_iO3h;
              }
              if ($_iO46 + $this->Range < $this->_iO3u) {
                  $_iO3h = _iO0("{href}", "href='javascript:void 0'", $_il46);
                  $_iO3h = _iO0("{onclick}", "onclick='grid_gopage(this," . ($_iO46 + $this->Range) . ")'", $_iO3h);
                  $_iO3h = _iO0("{number}", "...", $_iO3h);
                  $_il47 .= $_iO3h;
              }
              $_il45 = _iO0("{numbers}", $_il47, $_iO40);
              $_iO3z = ($this->ShowPageSize) ? $this->_il3y() : "";
              $_iO3x = ($this->ShowPageInfo) ? $this->_iO3v() : "";
              $_iO45 = _iO0("{nav}", $_il45, $_il40);
              $_iO45 = _iO0("{info}", $_iO3x, $_iO45);
              $_iO45 = _iO0("{pagesize}", $_iO3z, $_iO45);
              return $_iO45;
          }
          function _il2j()
          {
              $_il30 = new gridnumericpager();
              parent::_il2j($_il30);
              $_il30->Range = $this->Range;
              return $_il30;
          }
      }
      class gridprevnextandnumericpager extends _il3u
      {
          var $Range = 012;
          var $NextPageText;
          var $PrevPageText;
          var $NextPageToolTip;
          var $PrevPageToolTip;
          function _il22($_il2f)
          {
              parent::_il22($_il2f);
              if ($this->PrevPageText === null)
                  $this->PrevPageText = $_il2f->_iO20->Localization->_il28["Prev"];
              if ($this->PrevPageToolTip === null)
                  $this->PrevPageToolTip = $_il2f->_iO20->Localization->_iO28["PrevPageToolTip"];
              if ($this->NextPageText === null)
                  $this->NextPageText = $_il2f->_iO20->Localization->_il28["Next"];
              if ($this->NextPageToolTip === null)
                  $this->NextPageToolTip = $_il2f->_iO20->Localization->_iO28["NextPageToolTip"];
          }
          function _iO25()
          {
              $_il40 = "<div class='kgrPager kgrNextPrevAndNumericPager'>{pagesize}{nav}{info}<div style='clear:both'></div></div>";
              $_iO40 = "<div class='kgrNav'>{prev} {numbers} {next}</div>";
              $_il46 = "<a class='kgrNum {selected}' {href} {onclick}><span>{number}</span></a> ";
              $_il3n = "<input type='button' onclick='{onclick}' title='{title}'/>";
              $_il41 = "<a href='javascript:void 0' onclick='{onclick}' title='{title}'>{text}</a>";
              $_iO41 = "<span class= '{class}'>{button}</span>";
              $_iO46 = floor($this->PageIndex / $this->Range) * $this->Range;
              $_il47 = "";
              if ($_iO46 > 0) {
                  $_iO3h = _iO0("{href}", "href='javascript:void 0'", $_il46);
                  $_iO3h = _iO0("{onclick}", "onclick='grid_gopage(this," . ($_iO46 - 1) . ")'", $_iO3h);
                  $_iO3h = _iO0("{number}", "...", $_iO3h);
                  $_il47 .= $_iO3h;
              }
              for ($_iO9 = $_iO46; $_iO9 < $_iO46 + $this->Range && $_iO9 < $this->_iO3u; $_iO9++) {
                  $_iO3h = _iO0("{number}", ($_iO9 + 1), $_il46);
                  if ($_iO9 == $this->PageIndex) {
                      $_iO3h = _iO0("{selected}", "kgrNumSelected", $_iO3h);
                      $_iO3h = _iO0("{href}", "", $_iO3h);
                      $_iO3h = _iO0("{onclick}", "", $_iO3h);
                  } else {
                      $_iO3h = _iO0("{selected}", "", $_iO3h);
                      $_iO3h = _iO0("{href}", "href='javascript:void 0'", $_iO3h);
                      $_iO3h = _iO0("{onclick}", "onclick='grid_gopage(this," . $_iO9 . ")'", $_iO3h);
                  }
                  $_il47 .= $_iO3h;
              }
              if ($_iO46 + $this->Range < $this->_iO3u) {
                  $_iO3h = _iO0("{href}", "href='javascript:void 0'", $_il46);
                  $_iO3h = _iO0("{onclick}", "onclick='grid_gopage(this," . ($_iO46 + $this->Range) . ")'", $_iO3h);
                  $_iO3h = _iO0("{number}", "...", $_iO3h);
                  $_il47 .= $_iO3h;
              }
              $_il42 = _iO0("{onclick}", ($this->PageIndex > 0) ? "grid_gopage(this," . ($this->PageIndex - 1) . ")" : "", $_il3n);
              $_il42 = _iO0("{title}", $this->PrevPageToolTip, $_il42);
              $_iO42 = $this->PrevPageText;
              if ($this->PageIndex > 0 && $this->PrevPageText !== null) {
                  $_iO42 = _iO0("{onclick}", "grid_gopage(this," . ($this->PageIndex - 1) . ")", $_il41);
                  $_iO42 = _iO0("{text}", $this->PrevPageText, $_iO42);
                  $_iO42 = _iO0("{title}", $this->PrevPageToolTip, $_iO42);
              }
              $_il43 = _iO0("{button}", $_il42 . $_iO42, $_iO41);
              $_il43 = _iO0("{class}", "kgrPrev", $_il43);
              $_iO43 = _iO0("{onclick}", ($this->PageIndex < $this->_iO3u - 1) ? "grid_gopage(this," . ($this->PageIndex + 1) . ")" : "", $_il3n);
              $_iO43 = _iO0("{title}", $this->NextPageToolTip, $_iO43);
              $_il44 = $this->NextPageText;
              if (($this->PageIndex < $this->_iO3u - 1) && $this->NextPageText !== null) {
                  $_il44 = _iO0("{onclick}", "grid_gopage(this," . ($this->PageIndex + 1) . ")", $_il41);
                  $_il44 = _iO0("{text}", $this->NextPageText, $_il44);
                  $_il44 = _iO0("{title}", $this->NextPageToolTip, $_il44);
              }
              $_iO44 = _iO0("{button}", $_il44 . $_iO43, $_iO41);
              $_iO44 = _iO0("{class}", "kgrNext", $_iO44);
              $_il45 = _iO0("{numbers}", $_il47, $_iO40);
              $_il45 = _iO0("{prev}", $_il43, $_il45);
              $_il45 = _iO0("{next}", $_iO44, $_il45);
              $_iO3z = ($this->ShowPageSize) ? $this->_il3y() : "";
              $_iO3x = ($this->ShowPageInfo) ? $this->_iO3v() : "";
              $_iO45 = _iO0("{nav}", $_il45, $_il40);
              $_iO45 = _iO0("{info}", $_iO3x, $_iO45);
              $_iO45 = _iO0("{pagesize}", $_iO3z, $_iO45);
              return $_iO45;
          }
          function _il2j()
          {
              $_il30 = new gridprevnextandnumericpager();
              parent::_il2j($_il30);
              $_il30->Range = $this->Range;
              $_il30->NextPageText = $this->NextPageText;
              $_il30->PrevPageText = $this->PrevPageText;
              $_il30->NextPageToolTip = $this->NextPageToolTip;
              $_il30->PrevPageToolTip = $this->PrevPageToolTip;
              return $_il30;
          }
      }
      class gridmanualpager extends _il3u
      {
          var $ManualPagerTemplate;
          var $ButtonType = "Button";
          var $GoPageButtonText;
          var $TextBoxWidth = "25px";
          function _il22($_il2f)
          {
              parent::_il22($_il2f);
              if ($this->ManualPagerTemplate === null)
                  $this->ManualPagerTemplate = $_il2f->_iO20->Localization->_iO28["ManualPagerTemplate"];
              if ($this->GoPageButtonText === null)
                  $this->GoPageButtonText = $_il2f->_iO20->Localization->_il28["Go"];
          }
          function _il2l($_ilm)
          {
              parent::_il2l($_ilm);
              if (isset($_ilm->_il28[$this->_iO23])) {
                  $_iO2l = $_ilm->_il28[$this->_iO23];
                  $this->PageIndex = ((int)$_POST[$this->_iO23 . "_input"]) - 1;
                  if ($this->PageIndex >= $this->_iO3u)
                      $this->PageIndex = $this->_iO3u - 1;
                  if ($this->PageIndex < 0)
                      $this->PageIndex = 0;
                  $this->_il2d->_iO24 = true;
              }
          }
          function _iO25()
          {
              $_il40 = "<div class='kgrPager kgrManualPager'>{pagesize}{nav}{info}<div style='clear:both'></div></div>";
              $_iO40 = "<div class='kgrNav'>{main}</div>";
              $_iO47 = "<input id='{id}' name='{id}' type='textbox' style='width:{width};' value='{text}'/>";
              $_il48 = $this->ManualPagerTemplate;
              $_iO48 = "";
              switch (strtolower($this->ButtonType)) {
                  case "link":
                      $_iO48 = "<a class='kgrGoButton' href='javascript:void 0' onclick='grid_gopage(this,0)'>{text}</a>";
                      break;
                  case "image":
                      $_iO48 = "<input class='kgrGoButton kgrGoImage' type='button' onclick='grid_gopage(this,0)' />";
                      break;
                  case "button":
                  default:
                      $_iO48 = "<input class='kgrGoButton' type='button' onclick='grid_gopage(this,0)' value='{text}' />";
                      break;
              }
              $_il49 = _iO0("{id}", $this->_iO23 . "_input", $_iO47);
              $_il49 = _iO0("{width}", $this->TextBoxWidth, $_il49);
              $_il49 = _iO0("{text}", $this->PageIndex + 1, $_il49);
              $_iO49 = _iO0("{text}", $this->GoPageButtonText, $_iO48);
              $_ilg = _iO0("{TextBox}", $_il49, $_il48);
              $_ilg = _iO0("{GoPageButton}", $_iO49, $_ilg);
              $_ilg = _iO0("{TotalPage}", $this->_iO3u, $_ilg);
              $_il45 = _iO0("{main}", $_ilg, $_iO40);
              $_iO3z = ($this->ShowPageSize) ? $this->_il3y() : "";
              $_iO3x = ($this->ShowPageInfo) ? $this->_iO3v() : "";
              $_iO45 = _iO0("{nav}", $_il45, $_il40);
              $_iO45 = _iO0("{info}", $_iO3x, $_iO45);
              $_iO45 = _iO0("{pagesize}", $_iO3z, $_iO45);
              return $_iO45;
          }
          function _il2j()
          {
              $_il30 = new gridmanualpager();
              parent::_il2j($_il30);
              $_il30->ManualPagerTemplate = $this->ManualPagerTemplate;
              $_il30->ButtonType = $this->ButtonType;
              $_il30->GoPageButtonText = $this->GoPageButtonText;
              $_il30->TextBoxWidth = $this->TextBoxWidth;
              return $_il30;
          }
      }
      class gridcustompager extends _il3u
      {
          function render($_il4a)
          {
              return "CustomPager";
          }
          function _iO25()
          {
              $_il40 = "<div class='kgrPager kgrCustomPager'>{pagesize}{nav}{info}<div style='clear:both'></div></div>";
              $_iO40 = "<div class='kgrNav'>{main}</div>";
              $_iO45 = $_il40;
              $_il4a = array("PageIndex" => $this->PageIndex, "TotalPages" => $this->_iO3u);
              $_il45 = _iO0("{main}", $this->render($_il4a), $_iO40);
              $_iO45 = _iO0("{nav}", $_il45, $_iO45);
              $_iO3x = ($this->ShowPageInfo) ? $this->_iO3v() : "";
              $_iO45 = _iO0("{info}", $_iO3x, $_iO45);
              $_iO3z = ($this->ShowPageSize) ? $this->_il3y() : "";
              $_iO3x = ($this->ShowPageInfo) ? $this->_iO3v() : "";
              $_iO45 = _iO0("{info}", $_iO3x, $_iO45);
              $_iO45 = _iO0("{pagesize}", $_iO3z, $_iO45);
              return $_iO45;
          }
          function _il2j($_il30)
          {
              if ($_il30 === null) {
                  $_il30 = eval("new " . get_class($this) . "()");
              }
              parent::_il2j($_il30);
              return $_il30;
          }
      }
      interface gridtemplate
      {
          function render($_iO2j);
          function getdata($_iO2j);
      }
      class _iO4a
      {
          var $Mode = "Inline";
          var $HeaderCaption;
          var $ColumnNumber = 1;
          var $CancelButtonText;
          var $ConfirmButtonText;
          var $CancelButtonToolTip;
          var $ConfirmButtonToolTip;
          var $Template;
          function _il2j(&$_il30)
          {
              $_il30->Mode = $this->Mode;
              $_il30->Template = $this->Template;
              $_il30->HeaderCaption = $this->HeaderCaption;
              $_il30->ColumnNumber = $this->ColumnNumber;
              $_il30->CancelButtonText = $this->CancelButtonText;
              $_il30->ConfirmButtonText = $this->ConfirmButtonText;
              $_il30->CancelButtonToolTip = $this->CancelButtonToolTip;
              $_il30->ConfirmButtonToolTip = $this->ConfirmButtonToolTip;
          }
      }
      class _il4b extends _iO4a
      {
          var $_iO23;
      }
      class _iO4b extends _iO4a
      {
          function _il2j()
          {
              $_il30 = new _il4c();
              parent::_il2j($_il30);
              return $_il30;
          }
      }
      class _il4c extends _il4b
      {
          var $_iO2j;
          var $_iO4c;
          function _il22($_il2f)
          {
              if ($this->CancelButtonText === null)
                  $this->CancelButtonText = $_il2f->_iO20->Localization->_il28["Cancel"];
              if ($this->ConfirmButtonText === null)
                  $this->ConfirmButtonText = $_il2f->_iO20->Localization->_il28["Confirm"];
              if ($this->CancelButtonToolTip === null)
                  $this->CancelButtonToolTip = $_il2f->_iO20->Localization->_iO28["EditForm_CancelButtonToolTip"];
              if ($this->ConfirmButtonToolTip === null)
                  $this->ConfirmButtonToolTip = $_il2f->_iO20->Localization->_iO28["EditForm_ConfirmButtonToolTip"];
          }
          function _il2m()
          {
              $_il2g = $this->_iO2j->DataItem;
              $_il4d = false;
              if (strtolower($this->Mode) == "template") {
                  $_iO4d = $this->Template->getdata($this->_iO2j);
                  foreach ($_iO4d as $_il1r => $_iO1r) {
                      $_il2g[$_il1r] = $_iO1r;
                  }
              } else {
                  foreach ($this->_iO2j->_il2d->_iO2p as $_il2q) {
                      if (!$_il2q->ReadOnly) {
                          $_il2g[$_il2q->DataField] = $_il2q->geteditvalue($this->_iO2j);
                          foreach ($_il2q->_iO2x as $_il2z) {
                              if ($_il2z->_il2w($_il2q, $_il2g[$_il2q->DataField]) !== null) {
                                  $_il4d = true;
                              }
                          }
                      }
                  }
              }
              $this->_iO4c = $_il2g;
              if (!$_il4d) {
				  $this->_iO2j->_il2d->_iO20->errorMessage = "";
                  if ($this->_iO2j->_il2d->_iO20->EventHandler->onbeforerowconfirmedit($this->_iO2j, array("NewDataItem" => $_il2g)) == true) {
                      $_il4e = $this->_iO2j->_il2d->DataSource->update($_il2g);
                      $this->_iO2j->_il2d->_iO24 = true;
                      $this->_iO2j->EditMode = false;
					  
					  //Added by Ivan Budiono to show error message :)					  
					  if(mysql_error() != "")
						$this->_iO2j->_il2d->_iO20->errorMessage = "<font color='red'>".mysql_error()."</font>";
					  //*** end ***
					  
                      $this->_iO2j->_il2d->_iO20->EventHandler->onrowconfirmedit($this->_iO2j, array("NewDataItem" => $_il2g, "Successful" => $_il4e));
                  }
              }
          }
          function _iO25()
          {
              $_iO2o = "";
              $_iO4e = new gridrow();
              $_iO4e->_iO23 = $this->_iO2j->_iO23;
              $_iO4e->_il22($this->_iO2j->_il2d);
              $_iO4e->DataItem = ($this->_iO4c !== null) ? $this->_iO4c : $this->_iO2j->DataItem;
              switch (strtolower($this->Mode)) {
                  case "template":
                      $_il2n = "<tr id='{rowid}' class='kgrRow {alt} {selected} kgrRowEdit'>{tds}</tr>";
                      $_il4f = "<tr><td colspan='{colspan}'><div id='{rowid}_editform' class='kgrEditForm'>{content}</div></td></tr>";
                      $_il2p = "";
                      for ($_iO9 = 0; $_iO9 < sizeof($this->_iO2j->_il2d->_iO2p); $_iO9++) {
                          $_il2q = $this->_iO2j->_il2d->_iO2p[$_iO9];
                          $_iO2q = $_il2q->_iO25($this->_iO2j);
                          $_il2p .= $_iO2q;
                      }
                      $_iO2o = _iO0("{tds}", $_il2p, $_il2n);
                      $_iO4f = _iO0("{content}", ($this->Template === null) ? "<b>Notice</b>: No template found!" : $this->Template->render($this->_iO2j), $_il4f);
                      $_iO4f = _iO0("{colspan}", sizeof($this->_iO2j->_il2d->_iO2p), $_iO4f);
                      $_iO2o .= $_iO4f;
                      break;
                  case "form":
                      $_il2n = "<tr id='{rowid}' class='kgrRow {alt} {selected} kgrRowEdit'>{tds}</tr>";
                      $_il4f = "<tr><td colspan='{colspan}'><div id='{rowid}_editform' class='kgrEditForm'>{header}{validators}{bigtable}{footer}</div></td></tr>";
                      $_il4g = "<div class='kgrFormHeader'>{text}</div>";
                      $_iO4g = "<div class='kgrFormFooter'>{buttons}</div>";
                      $_il4h = "<ul class='kgrValidator'>{items}</ul>";
                      $_iO4h = "<li><label for='{id}'>{header}: {error}</label></li>";
                      $_il4i = "<table style='table-layout:fixed;width:100%;'><tr>{bigtable_tds}</tr></table>";
                      $_iO4i = "<td style='vertical-align: top;width:{width}%'>{table{n}}</td>";
                      $_il4j = "<table style='height:{height}px;width:100%;'>{ct_trs}</table>";
                      $_il3n = "<input type='button' onclick='{onclick}' title='{title}'/>";
                      $_il41 = "<a href='javascript:void 0' onclick='{onclick}' title='{title}'>{text}</a>";
                      $_iO41 = "<span class= '{class}'>{button}{a}</span> ";
                      $_iO4j = 043;
                      $_il2p = "";
                      for ($_iO9 = 0; $_iO9 < sizeof($this->_iO2j->_il2d->_iO2p); $_iO9++) {
                          $_il2q = $this->_iO2j->_il2d->_iO2p[$_iO9];
                          $_iO2q = $_il2q->_iO25($this->_iO2j);
                          $_il2p .= $_iO2q;
                      }
                      $_iO2o = _iO0("{tds}", $_il2p, $_il2n);
                      $_il4k = "";
                      $_iO4k = $this->HeaderCaption;
                      if ($_iO4k != null) {
                          foreach ($this->_iO2j->DataItem as $_il1r => $_iO1r) {
                              $_iO4k = _iO0("{" . $_il1r . "}", $_iO1r, $_iO4k);
                          }
                          $_il4k = _iO0("{text}", $_iO4k, $_il4g);
                      }
                      $_il4l = "";
                      if ($this->_iO4c !== null) {
                          foreach ($_iO4e->_il2d->_iO2p as $_il2q) {
                              if (!$_il2q->ReadOnly) {
                                  foreach ($_il2q->_iO2x as $_il2z) {
                                      $_iO4l = $_il2z->_il2w($_il2q, $_iO4e->DataItem[$_il2q->DataField]);
                                      if ($_iO4l !== null) {
                                          $_il4m = _iO0("{header}", $_il2q->HeaderText, $_iO4h);
                                          $_il4m = _iO0("{error}", $_iO4l, $_il4m);
                                          $_il4m = _iO0("{id}", $_iO4e->_iO23 . "_" . $_il2q->_iO23 . "_input", $_il4m);
                                          $_il4l .= $_il4m;
                                      }
                                  }
                              }
                          }
                      }
                      $_iO4m = _iO0("{items}", $_il4l, $_il4h);
                      $_il4n = "";
                      for ($_iO9 = 0; $_iO9 < $this->ColumnNumber; $_iO9++) {
                          $_iO4n = _iO0("{n}", $_iO9, $_iO4i);
                          $_iO4n = _iO0("{width}", (0144 / $this->ColumnNumber), $_iO4n);
                          $_il4n .= $_iO4n;
                      }
                      $_il4o = _iO0("{bigtable_tds}", $_il4n, $_il4i);
                      $_iO4o = array();
                      for ($_iO9 = 0; $_iO9 < sizeof($_iO4e->_il2d->_iO2p); $_iO9++) {
                          $_il2q = $_iO4e->_il2d->_iO2p[$_iO9];
                          if (!$_il2q->ReadOnly) {
                              $_il4p = $_il2q->_il33($_iO4e);
                              array_push($_iO4o, $_il4p);
                          }
                      }
                      $_iO4p = ceil(sizeof($_iO4o) / $this->ColumnNumber);
                      for ($_iO9 = 0; $_iO9 < $this->ColumnNumber; $_iO9++) {
                          $_il4q = "";
                          for ($_iO4q = 0; $_iO4q < $_iO4p; $_iO4q++) {
                              $_il4r = $_iO4p * $_iO9 + $_iO4q;
                              if ($_il4r < sizeof($_iO4o)) {
                                  $_il4q .= $_iO4o[$_il4r];
                              }
                          }
                          $_iO4r = _iO0("{ct_trs}", $_il4q, $_il4j);
                          $_iO4r = _iO0("{height}", $_iO4p * $_iO4j, $_iO4r);
                          if ($_il4q == "")
                              $_iO4r = "";
                          $_il4o = _iO0("{table" . $_iO9 . "}", $_iO4r, $_il4o);
                      }
                      $_iO3o = _iO0("{class}", "kgrConfirm", $_iO41);
                      $_iO3o = _iO0("{button}", $_il3n, $_iO3o);
                      $_iO3o = _iO0("{a}", ($this->ConfirmButtonText != null) ? $_il41 : "", $_iO3o);
                      $_iO3o = _iO0("{onclick}", "grid_confirm_edit(this)", $_iO3o);
                      $_iO3o = _iO0("{title}", $this->ConfirmButtonToolTip, $_iO3o);
                      $_iO3o = _iO0("{text}", $this->ConfirmButtonText, $_iO3o);
                      $_il3p = _iO0("{class}", "kgrCancel", $_iO41);
                      $_il3p = _iO0("{button}", $_il3n, $_il3p);
                      $_il3p = _iO0("{a}", ($this->CancelButtonText != null) ? $_il41 : "", $_il3p);
                      $_il3p = _iO0("{onclick}", "grid_cancel_edit(this)", $_il3p);
                      $_il3p = _iO0("{title}", $this->CancelButtonToolTip, $_il3p);
                      $_il3p = _iO0("{text}", $this->CancelButtonText, $_il3p);
                      $_il4s = _iO0("{buttons}", $_iO3o . $_il3p, $_iO4g);
                      $_iO4f = _iO0("{header}", $_il4k, $_il4f);
                      $_iO4f = _iO0("{validators}", $_iO4m, $_iO4f);
                      $_iO4f = _iO0("{bigtable}", $_il4o, $_iO4f);
                      $_iO4f = _iO0("{footer}", $_il4s, $_iO4f);
                      $_iO4f = _iO0("{colspan}", sizeof($_iO4e->_il2d->_iO2p), $_iO4f);
                      $_iO2o .= $_iO4f;
                      break;
                  case "inline":
                  default:
                      $_il2n = "<tr id='{rowid}' class='kgrRow {alt} {selected} kgrRowEdit'>{tds}</tr>";
                      $_iO4s = "<tr class='kgrValidator'>{valid_tds}</tr>";
                      $_il4t = "<td class='kgrCell'><div class='kgrIn' style='white-space:normal;'>{divs}</div></td>";
                      $_iO4t = "<div><label for='{id}'>{error}</label></div>";
                      $_il2p = "";
                      for ($_iO9 = 0; $_iO9 < sizeof($_iO4e->_il2d->_iO2p); $_iO9++) {
                          $_il2q = $_iO4e->_il2d->_iO2p[$_iO9];
                          $_iO2q = $_il2q->_iO32($_iO4e);
                          $_il2p .= $_iO2q;
                      }
                      $_iO2o = _iO0("{tds}", $_il2p, $_il2n);
                      $_il4u = "";
                      if ($this->_iO4c !== null) {
                          $_iO4u = "";
                          for ($_iO9 = 0; $_iO9 < sizeof($_iO4e->_il2d->_iO2p); $_iO9++) {
                              $_il2q = $_iO4e->_il2d->_iO2p[$_iO9];
                              $_il4v = "";
                              if (!$_il2q->ReadOnly) {
                                  foreach ($_il2q->_iO2x as $_il2z) {
                                      $_iO4l = $_il2z->_il2w($_il2q, $_iO4e->DataItem[$_il2q->DataField]);
                                      if ($_iO4l !== null) {
                                          $_iO4v = _iO0("{error}", $_iO4l, $_iO4t);
                                          $_iO4v = _iO0("{id}", $_iO4e->_iO23 . "_" . $_il2q->_iO23 . "_input", $_iO4v);
                                          $_il4v .= $_iO4v;
                                      }
                                  }
                              }
                              $_il4w = _iO0("{divs}", $_il4v, $_il4t);
                              $_iO4u .= $_il4w;
                          }
                          $_il4u = _iO0("{valid_tds}", $_iO4u, $_iO4s);
                      }
                      $_iO2o .= $_il4u;
                      break;
              }
              return $_iO2o;
          }
      }
      class _iO4w extends _iO4a
      {
          var $HeaderCaption = "";
          function _il2j()
          {
              $_il30 = new _il4x();
              parent::_il2j($_il30);
              return $_il30;
          }
      }
      class _il4x extends _il4b
      {
          var $_il2d;
          var $_iO4c;
          function _il22($_il2f)
          {
              $this->_il2d = $_il2f;
              if ($this->CancelButtonText === null)
                  $this->CancelButtonText = $_il2f->_iO20->Localization->_il28["Cancel"];
              if ($this->ConfirmButtonText === null)
                  $this->ConfirmButtonText = $_il2f->_iO20->Localization->_il28["Confirm"];
              if ($this->CancelButtonToolTip === null)
                  $this->CancelButtonToolTip = $_il2f->_iO20->Localization->_iO28["InsertForm_CancelButtonToolTip"];
              if ($this->ConfirmButtonToolTip === null)
                  $this->ConfirmButtonToolTip = $_il2f->_iO20->Localization->_iO28["InsertForm_ConfirmButtonToolTip"];
          }
          function _iO4x()
          {
              $_il2g = array();
              for ($_iO9 = 0; $_iO9 < sizeof($this->_il2d->_iO2p); $_iO9++) {
                  if ($this->_il2d->_iO2p[$_iO9]->DataField != null) {
                      $_il2g[$this->_il2d->_iO2p[$_iO9]->DataField] = null;
                  }
              }
              $_il4y = new gridrow();
              $_il4y->_iO23 = $this->_il2d->_iO23 . "_nr";
              $_il4y->_il22($this->_il2d);
              $_il4d = false;
              if (strtolower($this->Mode) == "template") {
                  $_iO4d = $this->Template->getdata($_il4y);
                  foreach ($_iO4d as $_il1r => $_iO1r) {
                      $_il2g[$_il1r] = $_iO1r;
                  }
              } else {
                  foreach ($this->_il2d->_iO2p as $_il2q) {
                      if (!$_il2q->ReadOnly) {
                          $_il2g[$_il2q->DataField] = $_il2q->geteditvalue($_il4y);
                          foreach ($_il2q->_iO2x as $_il2z) {
                              if ($_il2z->_il2w($_il2q, $_il2g[$_il2q->DataField]) !== null) {
                                  $_il4d = true;
                              }
                          }
                      }
                  }
              }
              if ($this->_il2d->_iO4y !== null) {
                  foreach ($this->_il2d->_il4z as $_iO4z) {
                      $_il2g[$_iO4z["Detail"]] = $this->_il2d->_iO4y->DataItem[$_iO4z["Master"]];
                  }
              }
              $this->_iO4c = $_il2g;
              if (!$_il4d) {
				  $this->_il2d->_iO20->errorMessage = "";
                  if ($this->_il2d->_iO20->EventHandler->onbeforeconfirminsert($this->_il2d, array("NewDataItem" => $_il2g)) == true) {
                      $_il50 = $this->_il2d->DataSource->insert($_il2g);
                      $this->_il2d->_iO24 = true;
                      $this->_il2d->_iO50 = false;		
					  
					  //Added by Ivan Budiono to show error message :)
					  if(mysql_error() != "")
						$this->_il2d->_iO20->errorMessage = "<font color='red'>".mysql_error()."</font>";
					  //*** end ***
					  
                      $this->_il2d->_iO20->EventHandler->onconfirminsert($this->_il2d, array("NewDataItem" => $_il2g, "Successful" => $_il50));					  
                  }
              }
          }
          function _iO25()
          {
              $_il51 = "";
              $_il2g = array();
              for ($_iO9 = 0; $_iO9 < sizeof($this->_il2d->_iO2p); $_iO9++) {
                  if ($this->_il2d->_iO2p[$_iO9]->DataField != null) {
                      $_il2g[$this->_il2d->_iO2p[$_iO9]->DataField] = null;
                  }
              }
              $_il4y = new gridrow();
              $_il4y->_iO23 = $this->_il2d->_iO23 . "_nr";
              $_il4y->_il22($this->_il2d);
              $_il4y->DataItem = $this->_iO4c;
              switch (strtolower($this->Mode)) {
                  case "template":
                      $_iO51 = "<tr><td colspan='{colspan}'><div id='{id}_insertform' class='kgrInsertForm'>{content}</div></td></tr>";
                      $_il51 = _iO0("{content}", ($this->Template === null) ? "<b>Notice</b>: Template not found!" : $this->Template->render($_il4y), $_iO51);
                      $_il51 = _iO0("{colspan}", sizeof($this->_il2d->_iO2p), $_il51);
                      break;
                  case "form":
                  default:
                      $_iO51 = "<tr><td colspan='{colspan}'><div id='{id}_insertform' class='kgrInsertForm'>{header}{validators}{bigtable}{footer}</div></td></tr>";
                      $_il52 = "<div class='kgrFormHeader'>{text}</div>";
                      $_iO52 = "<div class='kgrFormFooter'>{buttons}</div>";
                      $_il53 = "<ul class='kgrValidator'>{items}</ul>";
                      $_iO53 = "<li><label for='{id}'>{header}: {error}</label></li>";
                      $_il54 = "<table style='table-layout:fixed;width:100%;'><tr>{bigtable_tds}</tr></table>";
                      $_iO54 = "<td style='vertical-align: top;width:{width}%'>{table{n}}</td>";
                      $_il55 = "<table style='height:{height}px;width:100%;'>{ct_trs}</table>";
                      $_il3n = "<input type='button' onclick='{onclick}' title='{title}'/>";
                      $_il41 = "<a href='javascript:void 0' onclick='{onclick}' title='{title}'>{text}</a>";
                      $_iO41 = "<span class= '{class}'>{button}{a}</span> ";
                      $_iO4j = 043;
                      $_il4k = "";
                      if ($this->HeaderCaption != null) {
                          $_il4k = _iO0("{text}", $this->HeaderCaption, $_il52);
                      }
                      $_il4l = "";
                      if ($this->_iO4c !== null) {
                          foreach ($this->_il2d->_iO2p as $_il2q) {
                              if (!$_il2q->ReadOnly) {
                                  foreach ($_il2q->_iO2x as $_il2z) {
                                      $_iO4l = $_il2z->_il2w($_il2q, $_il4y->DataItem[$_il2q->DataField]);
                                      if ($_iO4l !== null) {
                                          $_iO55 = _iO0("{header}", $_il2q->HeaderText, $_iO53);
                                          $_iO55 = _iO0("{error}", $_iO4l, $_iO55);
                                          $_iO55 = _iO0("{id}", $_il4y->_iO23 . "_" . $_il2q->_iO23 . "_input", $_iO55);
                                          $_il4l .= $_iO55;
                                      }
                                  }
                              }
                          }
                      }
                      $_iO4m = _iO0("{items}", $_il4l, $_il53);
                      $_il4n = "";
                      for ($_iO9 = 0; $_iO9 < $this->ColumnNumber; $_iO9++) {
                          $_iO4n = _iO0("{n}", $_iO9, $_iO54);
                          $_iO4n = _iO0("{width}", (0144 / $this->ColumnNumber), $_iO4n);
                          $_il4n .= $_iO4n;
                      }
                      $_il4o = _iO0("{bigtable_tds}", $_il4n, $_il54);
                      $_iO4o = array();
                      for ($_iO9 = 0; $_iO9 < sizeof($this->_il2d->_iO2p); $_iO9++) {
                          $_il2q = $this->_il2d->_iO2p[$_iO9];
                          if (!$_il2q->ReadOnly) {
                              $_il4p = $_il2q->_il33($_il4y);
                              array_push($_iO4o, $_il4p);
                          }
                      }
                      $_iO4p = ceil(sizeof($_iO4o) / $this->ColumnNumber);
                      for ($_iO9 = 0; $_iO9 < $this->ColumnNumber; $_iO9++) {
                          $_il4q = "";
                          for ($_iO4q = 0; $_iO4q < $_iO4p; $_iO4q++) {
                              $_il4r = $_iO4p * $_iO9 + $_iO4q;
                              if ($_il4r < sizeof($_iO4o)) {
                                  $_il4q .= $_iO4o[$_il4r];
                              }
                          }
                          $_il56 = _iO0("{ct_trs}", $_il4q, $_il55);
                          $_il56 = _iO0("{height}", $_iO4j * $_iO4p, $_il56);
                          if ($_il4q == "")
                              $_il56 = "";
                          $_il4o = _iO0("{table" . $_iO9 . "}", $_il56, $_il4o);
                      }
                      $_iO3o = _iO0("{class}", "kgrConfirm", $_iO41);
                      $_iO3o = _iO0("{button}", $_il3n, $_iO3o);
                      $_iO3o = _iO0("{a}", ($this->ConfirmButtonText != null) ? $_il41 : "", $_iO3o);
                      $_iO3o = _iO0("{onclick}", "grid_confirm_insert(this)", $_iO3o);
                      $_iO3o = _iO0("{title}", $this->ConfirmButtonToolTip, $_iO3o);
                      $_iO3o = _iO0("{text}", $this->ConfirmButtonText, $_iO3o);
                      $_il3p = _iO0("{class}", "kgrCancel", $_iO41);
                      $_il3p = _iO0("{button}", $_il3n, $_il3p);
                      $_il3p = _iO0("{a}", ($this->CancelButtonText != null) ? $_il41 : "", $_il3p);
                      $_il3p = _iO0("{onclick}", "grid_cancel_insert(this)", $_il3p);
                      $_il3p = _iO0("{title}", $this->CancelButtonToolTip, $_il3p);
                      $_il3p = _iO0("{text}", $this->CancelButtonText, $_il3p);
                      $_il4s = _iO0("{buttons}", $_iO3o . $_il3p, $_iO52);
                      $_il51 = _iO0("{id}", $_il4y->_iO23, $_iO51);
                      $_il51 = _iO0("{header}", $_il4k, $_il51);
                      $_il51 = _iO0("{validators}", $_iO4m, $_il51);
                      $_il51 = _iO0("{bigtable}", $_il4o, $_il51);
                      $_il51 = _iO0("{footer}", $_il4s, $_il51);
                      $_il51 = _iO0("{colspan}", sizeof($this->_il2d->_iO2p), $_il51);
                      break;
              }
              return $_il51;
          }
      }
      class gridgroup
      {
          var $_iO56;
          var $GroupField;
          var $Sort = 1;
          var $Expand = true;
          var $InfoTemplate;
          var $HeaderText;
          function __construct()
          {
              $this->_iO56 = array();
          }
          function addinfofield($_il57, $_il1m = null)
          {
              array_push($this->_iO56, array("InfoField" => $_il57, "Aggregate" => $_il1m));
          }
          function _il2j()
          {
              $_il30 = new _iO57();
              $_il30->_iO56 = $this->_iO56;
              $_il30->GroupField = $this->GroupField;
              $_il30->Sort = $this->Sort;
              $_il30->Expand = $this->Expand;
              $_il30->InfoTemplate = $this->InfoTemplate;
              $_il30->HeaderText = $this->HeaderText;
              return $_il30;
          }
      }
      class _iO57 extends gridgroup implements _iO1s
      {
          var $_iO23;
          var $_il2d;
          var $_iO2c;
          function _il22($_il2f)
          {
              $this->_il2d = $_il2f;
              $this->_iO2c = $_il2f->_iO2c;
              if ($this->HeaderText === null)
                  $this->HeaderText = $this->GroupField;
              if ($this->InfoTemplate === null)
                  $this->InfoTemplate = $this->HeaderText . ": {" . $this->GroupField . "}";
          }
          function _il1t()
          {
              if (isset($this->_iO2c->_iO1p[$this->_iO23])) {
                  $_iO2f = $this->_iO2c->_iO1p[$this->_iO23];
                  $this->Sort = $_iO2f["Sort"];
                  $this->GroupField = $_iO2f["GroupField"];
                  $this->Expand = $_iO2f["Expand"];
                  $this->InfoTemplate = $_iO2f["InfoTemplate"];
                  $this->_iO56 = $_iO2f["InfoFields"];
                  $this->HeaderText = $_iO2f["HeaderText"];
              }
          }
          function _iO2i()
          {
              $this->_il1t();
          }
          function _iO1t()
          {
              $this->_iO2c->_iO1p[$this->_iO23] = array("Sort" => $this->Sort, "Expand" => $this->Expand, "GroupField" => $this->GroupField, "HeaderText" => $this->HeaderText, "InfoFields" => $this->_iO56, "InfoTemplate" => $this->InfoTemplate);
          }
          function _il2l($_ilm)
          {
              if (isset($_ilm->_il28[$this->_iO23])) {
                  $_iO2l = $_ilm->_il28[$this->_iO23];
                  switch ($_iO2l["Command"]) {
                      case "Sort":
                          $this->Sort = $_iO2l["Args"]["Sort"];
                          $this->_il2d->_iO24 = true;
                          break;
                  }
              }
          }
          function _iO25()
          {
              $_il58 = "<th id='{id}' class='kgrGroupItem' title='{title}'><div class='kgrIn'>{text}&#160;{sort}</div></th>";
              $_iO58 = "<input class='kgrSort{dir}' type='button' title='{title}' onclick='grid_groupitem_sort(\"{id}\",{sort})' />";
              $_il59 = ($this->Sort < 0) ? "Desc" : "Asc";
              $_iO1a = _iO0("{id}", $this->_iO23, $_iO58);
              $_iO1a = _iO0("{dir}", $_il59, $_iO1a);
              $_iO1a = _iO0("{title}", $this->_il2d->_iO20->Localization->_iO28["Sort" . $_il59 . "ToolTip"], $_iO1a);
              $_iO1a = _iO0("{sort}", -$this->Sort, $_iO1a);
              $_iO16 = _iO0("{id}", $this->_iO23, $_il58);
              $_iO16 = _iO0("{text}", $this->HeaderText, $_iO16);
              $_iO16 = _iO0("{sort}", $_iO1a, $_iO16);
              $_iO16 = _iO0("{title}", $this->_il2d->_iO20->Localization->_iO28["GroupItemToolTip"], $_iO16);
              return $_iO16;
          }
          function _iO59()
          {
              $_iO1b = new _il5a();
              $_iO1b->Expand = $this->Expand;
              $_iO1b->_iO5a = $this;
              return $_iO1b;
          }
      }
      class _il5a implements _iO1s
      {
          var $_iO23;
          var $_il2d;
          var $_il3k;
          var $_il5b;
          var $_iO2c;
          var $_iO5b = 0;
          var $_il5c;
          var $_iO5c;
          var $_iO5a;
          var $_il5d;
          var $Expand;
          function _il22($_il2f)
          {
              $this->_il2d = $_il2f;
              $this->_iO2c = $_il2f->_iO2c;
              $this->_il3k = array();
              $this->_il5b = array();
          }
          function _iO2i()
          {
              $this->_il1t();
              foreach ($this->_il5b as $_iO1b) {
                  $_iO1b->_iO2i();
              }
          }
          function _iO5d($_il1l)
          {
              array_push($this->_il3k, $_il1l);
              $this->_il5c = $_il1l->DataItem[$this->_iO5a->GroupField];
          }
          function _il5e($_iO1k)
          {
              $_iO5e = $this->_iO5b + 1;
              if (isset($this->_il2d->_il5f[$_iO5e])) {
                  $_iO5f = $this->_il2d->_il5f[$_iO5e];
                  $_iO1b = null;
                  $_il5g = 0;
                  for ($_iO9 = 0; $_iO9 < sizeof($_iO1k); $_iO9++) {
                      if ($_iO1b == null) {
                          $_iO1b = $_iO5f->_iO59();
                          $_iO1b->_iO23 = $this->_iO23 . "_gr" . $_il5g;
                          $_iO1b->_il22($this->_il2d);
                          $_iO1b->_iO5b = $_iO5e;
                          $_iO1b->_iO5d($_iO1k[$_iO9]);
                          $_iO1b->_iO5c = $this;
                          array_push($this->_il5b, $_iO1b);
                      } else {
                          if ($_iO1b->_il5c == $_iO1k[$_iO9]->DataItem[$_iO1b->_iO5a->GroupField]) {
                              $_iO1b->_iO5d($_iO1k[$_iO9]);
                          } else {
                              $_iO1b->_il5e($_iO1b->_il3k);
                              $_iO1b = $_iO5f->_iO59();
                              $_il5g++;
                              $_iO1b->_iO23 = $this->_iO23 . "_gr" . $_il5g;
                              $_iO1b->_il22($this->_il2d);
                              $_iO1b->_iO5b = $_iO5e;
                              $_iO1b->_iO5d($_iO1k[$_iO9]);
                              $_iO1b->_iO5c = $this;
                              array_push($this->_il5b, $_iO1b);
                          }
                      }
                      if ($_iO9 == sizeof($_iO1k) - 1) {
                          $_iO1b->_il5e($_iO1b->_il3k);
                      }
                  }
              }
          }
          function _il1t()
          {
              if (isset($this->_iO2c->_iO1p[$this->_iO23])) {
                  $_iO2f = $this->_iO2c->_iO1p[$this->_iO23];
                  $this->Expand = $_iO2f["Expand"];
              }
          }
          function _iO1t()
          {
              if ($this->_iO5b > -1) {
                  $this->_iO2c->_iO1p[$this->_iO23] = array("Expand" => $this->Expand);
              }
              foreach ($this->_il5b as $_iO1b) {
                  $_iO1b->_iO1t();
              }
          }
          function _il2l($_ilm)
          {
              if (isset($_ilm->_il28[$this->_iO23])) {
                  $_iO2l = $_ilm->_il28[$this->_iO23];
                  switch ($_iO2l["Command"]) {
                      case "Expand":
                          $this->Expand = true;
                          break;
                      case "Collapse":
                          $this->Expand = false;
                          break;
                  }
              }
              foreach ($this->_il5b as $_iO1b) {
                  $_iO1b->_il2l($_ilm);
              }
              if ($this->_iO5a !== null) {
                  $_iO5g = array();
                  $_il5h = array();
                  for ($_iO9 = 0; $_iO9 < sizeof($this->_iO5a->_iO56); $_iO9++) {
                      $_iO5h = $this->_iO5a->_iO56[$_iO9];
                      if ($_iO5h["Aggregate"] == null) {
                          $_iO5g[$_iO9] = $this->_il3k[0]->DataItem[$_iO5h["InfoField"]];
                      } else {
                          $_iO5g[$_iO9] = "";
                          array_push($_il5h, array("Key" => "_" . $_iO9, "Aggregate" => $_iO5h["Aggregate"], "DataField" => $_iO5h["InfoField"]));
                      }
                  }
                  if (sizeof($_il5h) > 0) {
                      $_il5i = $this->_il2d->DataSource->Filters;
                      $_iO5i = $this;
                      while ($_iO5i !== $this->_il2d->_il5j) {
                          $this->_il2d->DataSource->addfilter(new datasourcefilter($_iO5i->_iO5a->GroupField, "=", $_iO5i->_il5c));
                          $_iO5i = $_iO5i->_iO5c;
                      }
                      $_iO1e = $this->_il2d->DataSource->getaggregates($_il5h);
                      if ($_iO1e !== null) {
                          foreach ($_iO1e as $_il1r => $_iO1r) {
                              $_iO5g[_iO0("_", "", $_il1r)] = $_iO1r;
                          }
                      }
                      $this->_il2d->DataSource->Filters = $_il5i;
                  }
                  $this->_il5d = $_iO5g;
              }
          }
          function _iO25()
          {
              $_iO5j = "";
              if ($this->_iO5b > -1) {
                  $_il2n = "<tr id='{id}' class='kgrGroup'>{group_tds}<td class='kgrCell' colspan='{colspan}'><div class='kgrIn' style='white-space:nowrap;'><span class='kgrHeaderText' onclick='grid_group_toogle(this)'>{content}</span></div></td></tr>";
                  $_il5k = "<td class='kgrCell'><div class='kgrIn' style='white-space:nowrap;'>{sign}</div></td>";
                  $_iO5k = "<span class='{status}' onclick='grid_group_toogle(this)'></span>";
                  $_iO2o = _iO0("{id}", $this->_iO23, $_il2n);
                  $_il5l = "";
                  for ($_iO9 = 0; $_iO9 < $this->_iO5b; $_iO9++) {
                      $_iO5l = _iO0("{sign}", "&#160;", $_il5k);
                      $_il5l .= $_iO5l;
                  }
                  $_il5m = _iO0("{status}", $this->Expand ? "kgrExpand" : "kgrCollapse", $_iO5k);
                  $_iO5l = _iO0("{sign}", $_il5m, $_il5k);
                  $_il5l .= $_iO5l;
                  $_iO5m = sizeof($this->_il2d->_iO2p) - $this->_iO5b - 1;
                  $_iO2o = _iO0("{group_tds}", $_il5l, $_iO2o);
                  $_iO2o = _iO0("{colspan}", $_iO5m, $_iO2o);
                  $_il5n = $this->_iO5a->InfoTemplate;
                  for ($_iO9 = 0; $_iO9 < sizeof($this->_iO5a->_iO56); $_iO9++) {
                      $_il5n = _iO0("{" . $this->_iO5a->_iO56[$_iO9]["InfoField"] . "}", $this->_il5d[$_iO9], $_il5n);
                  }
                  $_iO2o = _iO0("{content}", $_il5n, $_iO2o);
                  $_iO5j .= $_iO2o;
                  if ($this->Expand) {
                      if (sizeof($this->_il5b) > 0) {
                          foreach ($this->_il5b as $_iO1b) {
                              $_iO5j .= $_iO1b->_iO25();
                          }
                      } else {
                          foreach ($this->_il3k as $_il1l) {
                              $_iO5j .= $_il1l->_iO25();
                          }
                      }
                  }
              } else {
                  foreach ($this->_il5b as $_iO1b) {
                      $_iO5j .= $_iO1b->_iO25();
                  }
              }
              return $_iO5j;
          }
      }
      class _iO5n
      {
          var $PanelCssClass = "";
          var $ItemCssClass = "";
          var $ItemConnector = "-";
          function _il2j()
          {
              $_il30 = new _il5o();
              $_il30->PanelCssClass = $this->PanelCssClass;
              $_il30->ItemCssClass = $this->ItemCssClass;
              $_il30->ItemConnector = $this->ItemConnector;
              return $_il30;
          }
      }
      class _il5o extends _iO5n
      {
          var $_iO23;
          var $_il2d;
          function _il22($_il2f)
          {
              $this->_il2d = $_il2f;
          }
          function _iO25()
          {
              $_il48 = "<div id='{id}' class='kgrGroupPanel' style='position:relative;'><span></span>{indicators}<table class='kgrGroupTable' style='width:100%;border-collapse:collapse;'><tr>{ths}<td id='{id}_tail' style='width:100%;'>{guidetext}</td></tr></table></div>";
              $_iO5o = "<td>{ct}</td>";
              $_il5p = "<div class='kgrTopIndicator' style='position:absolute;display:none;'></div><div class='kgrBottomIndicator' style='position:absolute;display:none;'></div>";
              $_iO5p = _iO0("{ct}", $this->ItemConnector, $_iO5o);
              $_il5q = "";
              $_il1j = $this->_il2d->_il5f;
              for ($_iO9 = 0; $_iO9 < sizeof($_il1j); $_iO9++) {
                  $_il5q .= $_il1j[$_iO9]->_iO25();
                  if ($_iO9 < sizeof($_il1j) - 1) {
                      $_il5q .= $_iO5p;
                  }
              }
              $_ilg = _iO0("{id}", $this->_iO23, $_il48);
              $_ilg = _iO0("{ths}", $_il5q, $_ilg);
              $_ilg = _iO0("{indicators}", $_il5p, $_ilg);
              $_ilg = _iO0("{guidetext}", (sizeof($_il1j) > 0) ? "&#160;" : $this->_il2d->_iO20->Localization->_iO28["GroupPanelGuideText"], $_ilg);
              return $_ilg;
          }
      }
      class gridtableview
      {
          var $DataSource;
          var $DataKeyNames;
          var $_il4z = array();
          var $_iO2p = array();
          var $_il2k = array();
          var $_il5f = array();
          var $_il2s;
          var $Pager;
          var $ShowHeader;
          var $ShowFooter;
          var $Width;
          var $Height;
          var $EditSettings;
          var $InsertSettings;
          var $RowAlternative;
          var $AllowHovering;
          var $AllowSelecting;
          var $AllowMultiSelecting;
          var $AllowEditing;
          var $AllowDeleting;
          var $AllowScrolling;
          var $AllowSorting;
          var $AllowResizing;
          var $AllowFiltering;
          var $AllowGrouping;
          var $PageSize;
          var $ShowFunctionPanel = false;
          var $FunctionPanel;
          var $ShowGroupPanel = false;
          var $GroupPanel;
          var $AutoGenerateRowSelectColumn;
          var $AutoGenerateExpandColumn;
          var $AutoGenerateColumns;
          var $AutoGenerateEditColumn;
          var $AutoGenerateDeleteColumn;
          var $DisableAutoGenerateDataFields;
          var $KeepSelectedRecords;
          var $ColumnWidth;
          var $ColumnWrap;
          var $ColumnAlign;
          var $_iO2y;
          var $TableLayout;
          var $FilterOptions;
          var $_iO5q;
          function __construct()
          {
              $this->EditSettings = new _iO4b();
              $this->InsertSettings = new _iO4w();
              $this->FunctionPanel = new _il5r();
              $this->GroupPanel = new _iO5n();
          }
          function addgroup($_iO1b)
          {
              array_push($this->_il5f, $_iO1b);
          }
          function addcolumn($_iO5r)
          {
              array_push($this->_iO2p, $_iO5r);
          }
          function adddetailtable($_il2f, $_iO2r = null)
          {
              $_il2f->_il2s = $_iO2r;
              array_push($this->_il2k, $_il2f);
          }
          function addrelationfield($_il5s, $_iO5s)
          {
              array_push($this->_il4z, array("Detail" => $_il5s, "Master" => $_iO5s));
          }
          function _il2j()
          {
              $_il30 = new _il5t();
              for ($_iO9 = 0; $_iO9 < sizeof($this->_iO2p); $_iO9++) {
                  $_il30->_iO2p[$_iO9] = $this->_iO2p[$_iO9]->createinstance();
              }
              for ($_iO9 = 0; $_iO9 < sizeof($this->_il5f); $_iO9++) {
                  $_il30->_il5f[$_iO9] = $this->_il5f[$_iO9]->_il2j();
              }
              $_il30->_il2k = $this->_il2k;
              $_il30->_il4z = $this->_il4z;
              $_il30->_il2s = $this->_il2s;
              $_il30->Pager = $this->Pager;
              $_il30->DataSource = $this->DataSource;
              $_il30->ShowHeader = $this->ShowHeader;
              $_il30->ShowFooter = $this->ShowFooter;
              $_il30->Width = $this->Width;
              $_il30->Height = $this->Height;
              $_il30->EditSettings = $this->EditSettings;
              $_il30->InsertSettings = $this->InsertSettings;
              $_il30->AllowHovering = $this->AllowHovering;
              $_il30->AllowEditing = $this->AllowEditing;
              $_il30->AllowDeleting = $this->AllowDeleting;
              $_il30->AllowSelecting = $this->AllowSelecting;
              $_il30->AllowMultiSelecting = $this->AllowMultiSelecting;
              $_il30->AllowScrolling = $this->AllowScrolling;
              $_il30->AllowSorting = $this->AllowSorting;
              $_il30->AllowResizing = $this->AllowResizing;
              $_il30->AllowFiltering = $this->AllowFiltering;
              $_il30->AllowGrouping = $this->AllowGrouping;
              $_il30->RowAlternative = $this->RowAlternative;
              $_il30->AutoGenerateRowSelectColumn = $this->AutoGenerateRowSelectColumn;
              $_il30->AutoGenerateExpandColumn = $this->AutoGenerateExpandColumn;
              $_il30->AutoGenerateColumns = $this->AutoGenerateColumns;
              $_il30->AutoGenerateEditColumn = $this->AutoGenerateEditColumn;
              $_il30->AutoGenerateDeleteColumn = $this->AutoGenerateDeleteColumn;
              $_il30->DisableAutoGenerateDataFields = $this->DisableAutoGenerateDataFields;
              $_il30->KeepSelectedRecords = $this->KeepSelectedRecords;
              $_il30->DataKeyNames = $this->DataKeyNames;
              $_il30->PageSize = $this->PageSize;
              $_il30->ShowFunctionPanel = $this->ShowFunctionPanel;
              $_il30->FunctionPanel = $this->FunctionPanel;
              $_il30->ShowGroupPanel = $this->ShowGroupPanel;
              $_il30->GroupPanel = $this->GroupPanel->_il2j();
              $_il30->ColumnWidth = $this->ColumnWidth;
              $_il30->ColumnWrap = $this->ColumnWrap;
              $_il30->ColumnAlign = $this->ColumnAlign;
              $_il30->_iO2y = $this->_iO2y;
              $_il30->TableLayout = $this->TableLayout;
              $_il30->FilterOptions = $this->FilterOptions;
              return $_il30;
          }
      }
      class _il5t extends gridtableview implements _iO1s
      {
          var $_iO20;
          var $_iO4y;
          var $_iO23;
          var $_iO2c;
          var $Grid;
          var $ParentRow;
          var $_il3k = array();
          var $_iO5t = 0;
          var $_iO24 = false;
          var $_il5u = 0;
          var $_iO5u = 0;
          var $_il5v = null;
          var $_iO50 = false;
          var $_iO5v;
          var $_il5w;
          var $_il5j;
          var $_iO5w;
          var $SelectedKeys = array();
          function getunqiueid()
          {
              return $this->_iO23;
          }
          function _il22($_iO22, $_il5x)
          {
              $this->_iO20 = $_iO22;
              $this->_iO4y = $_il5x;
              $this->Grid = $_iO22;
              $this->ParentRow = $_il5x;
              $this->_iO2c = $_iO22->_iO2c;
              if ($this->KeepSelectedRecords === null)
                  $this->KeepSelectedRecords = $this->_iO20->KeepSelectedRecords;
              if ($this->AllowHovering === null)
                  $this->AllowHovering = $this->_iO20->AllowHovering;
              if ($this->AllowEditing === null)
                  $this->AllowEditing = $this->_iO20->AllowEditing;
              if ($this->AllowDeleting === null)
                  $this->AllowDeleting = $this->_iO20->AllowDeleting;
              if ($this->AllowSelecting === null)
                  $this->AllowSelecting = $this->_iO20->AllowSelecting;
              if ($this->AllowMultiSelecting === null)
                  $this->AllowMultiSelecting = $this->_iO20->AllowMultiSelecting;
              if ($this->AllowScrolling === null)
                  $this->AllowScrolling = $this->_iO20->AllowScrolling;
              if ($this->AllowSorting === null)
                  $this->AllowSorting = $this->_iO20->AllowSorting;
              if ($this->AllowResizing === null)
                  $this->AllowResizing = $this->_iO20->AllowResizing;
              if ($this->AllowFiltering === null)
                  $this->AllowFiltering = $this->_iO20->AllowFiltering;
              if ($this->AllowGrouping === null)
                  $this->AllowGrouping = $this->_iO20->AllowGrouping;
              if ($this->ShowHeader === null)
                  $this->ShowHeader = $this->_iO20->ShowHeader;
              if ($this->ShowFooter === null)
                  $this->ShowFooter = $this->_iO20->ShowFooter;
              if ($this->RowAlternative === null)
                  $this->RowAlternative = $this->_iO20->RowAlternative;
              if ($this->PageSize === null)
                  $this->PageSize = $this->_iO20->PageSize;
              if ($this->DataSource === null)
                  $this->DataSource = $this->_iO20->DataSource;
              if ($this->Width === null)
                  $this->Width = "100%";
              if ($_il5x == null) {
                  if ($this->Height === null)
                      $this->Height = $this->_iO20->Height;
              }
              if ($this->AutoGenerateRowSelectColumn === null)
                  $this->AutoGenerateRowSelectColumn = $this->_iO20->AutoGenerateRowSelectColumn;
              if ($this->AutoGenerateExpandColumn === null)
                  $this->AutoGenerateExpandColumn = $this->_iO20->AutoGenerateExpandColumn;
              if ($this->AutoGenerateColumns === null)
                  $this->AutoGenerateColumns = $this->_iO20->AutoGenerateColumns;
              if ($this->AutoGenerateEditColumn === null)
                  $this->AutoGenerateEditColumn = $this->_iO20->AutoGenerateEditColumn;
              if ($this->AutoGenerateDeleteColumn === null)
                  $this->AutoGenerateDeleteColumn = $this->_iO20->AutoGenerateDeleteColumn;
              if ($this->DisableAutoGenerateDataFields === null)
                  $this->DisableAutoGenerateDataFields = $this->_iO20->DisableAutoGenerateDataFields;
              if ($this->ColumnWrap === null)
                  $this->ColumnWrap = $this->_iO20->ColumnWrap;
              if ($this->ColumnAlign === null)
                  $this->ColumnAlign = $this->_iO20->ColumnAlign;
              if ($this->_iO2y === null)
                  $this->_iO2y = $this->_iO20->_iO2y;
              if ($this->TableLayout === null)
                  $this->TableLayout = $this->_iO20->TableLayout;
              if ($this->FilterOptions === null)
                  $this->FilterOptions = $this->_iO20->FilterOptions;
              if ($this->AllowMultiSelecting) {
                  $this->AllowSelecting = true;
              }
              if ($this->AutoGenerateRowSelectColumn) {
                  $_iO5x = new gridrowselectcolumn();
                  $_iO5x->Align = "center";
                  $_il6 = array($_iO5x);
                  $this->_iO2p = array_merge($_il6, $this->_iO2p);
              }
              if ($this->AutoGenerateExpandColumn) {
                  $_il5y = new gridexpanddetailcolumn();
                  $_il5y->Align = "center";
                  $_il6 = array($_il5y);
                  $this->_iO2p = array_merge($_il6, $this->_iO2p);
              }
              if ($this->AutoGenerateColumns) {
                  $_il1f = $this->DataSource->getfields();
                  $_iO5y = $this->DisableAutoGenerateDataFields . ",";
                  foreach ($_il1f as $_il17) {
                      if (strpos($_iO5y, $_il17["Name"] . ",") === false) {
                          $_il2q = new gridboundcolumn();
                          $_il2q->HeaderText = $_il17["Name"];
                          $_il2q->DataField = $_il17["Name"];
                          if ($_il17["Not_Null"] == 1) {
                              $_il2q->addvalidator(new requiredfieldvalidator());
                          }
                          $this->addcolumn($_il2q);
                      }
                  }
              }
              if ($this->AutoGenerateEditColumn) {
                  $_il5z = new grideditdeletecolumn();
                  $_il5z->Align = "center";
                  $_il5z->ShowDeleteButton = false;
                  $this->addcolumn($_il5z);
              }
              if ($this->AutoGenerateDeleteColumn) {
                  $_iO5z = new grideditdeletecolumn();
                  $_iO5z->Align = "center";
                  $_iO5z->ShowEditButton = false;
                  $this->addcolumn($_iO5z);
              }
              for ($_iO9 = 0; $_iO9 < sizeof($this->_iO2p); $_iO9++) {
                  $this->_iO2p[$_iO9]->_iO23 = $this->_iO23 . "_c" . $_iO9;
                  $this->_iO2p[$_iO9]->_il22($this);
              }
              if ($this->Pager != null) {
                  $this->Pager->_iO23 = $this->_iO23 . "_pg";
                  $this->Pager->_il22($this);
              }
              $this->FunctionPanel->_il22($this);
              $this->GroupPanel->_iO23 = $this->_iO23 . "_gp";
              $this->GroupPanel->_il22($this);
              for ($_iO9 = 0; $_iO9 < sizeof($this->_il5f); $_iO9++) {
                  $this->_il5f[$_iO9]->_iO23 = $this->_iO23 . "_gm" . $_iO9;
                  $this->_il5f[$_iO9]->_il22($this);
              }
          }
          function getparentrow()
          {
              return $this->_iO4y;
          }
          function _il1t()
          {
              if (isset($this->_iO2c->_iO1p[$this->_iO23])) {
                  $_iO2f = $this->_iO2c->_iO1p[$this->_iO23];
                  $this->Width = $_iO2f["Width"];
                  $this->_il5w = $_iO2f["TablePartWidth"];
                  $this->_iO5t = $_iO2f["RowsCount"];
                  $this->_iO50 = $_iO2f["Inserting"];
                  $this->_il5u = $_iO2f["scrollTop"];
                  $this->_iO5u = $_iO2f["scrollLeft"];
                  if (isset($_iO2f["SelectedKeys"])) {
                      $this->SelectedKeys = $_iO2f["SelectedKeys"];
                  }
                  if (isset($_iO2f["PartDataHeight"])) {
                      $this->_il5v = $_iO2f["PartDataHeight"];
                  }
                  $this->_iO5w = $_iO2f["GroupSize"];
              }
              if ($this->Pager != null) {
                  $this->Pager->_il1t();
              }
              for ($_iO9 = 0; $_iO9 < sizeof($this->_iO2p); $_iO9++) {
                  $this->_iO2p[$_iO9]->_il1t();
              }
          }
          function _iO1t()
          {
              $this->_iO2c->_iO1p[$this->_iO23] = array("RowsCount" => sizeof($this->_il3k), "SelectedKeys" => $this->SelectedKeys, "Inserting" => $this->_iO50, "AllowHovering" => $this->AllowHovering, "AllowSelecting" => $this->AllowSelecting, "AllowMultiSelecting" => $this->AllowMultiSelecting, "AllowScrolling" => $this->AllowScrolling, "scrollTop" => $this->_il5u, "scrollLeft" => $this->_iO5u, "Width" => $this->Width, "TablePartWidth" => $this->_il5w, "GroupSize" => sizeof($this->_il5f));
              if ($this->Pager != null) {
                  $this->Pager->_iO1t();
              }
              for ($_iO9 = 0; $_iO9 < sizeof($this->_iO2p); $_iO9++) {
                  $this->_iO2p[$_iO9]->_iO1t();
              }
              for ($_iO9 = 0; $_iO9 < sizeof($this->_il3k); $_iO9++) {
                  $this->_il3k[$_iO9]->_iO1t();
              }
              for ($_iO9 = 0; $_iO9 < sizeof($this->_il5f); $_iO9++) {
                  $this->_il5f[$_iO9]->_iO1t();
              }
              if ($this->_il5j !== null) {
                  $this->_il5j->_iO1t();
              }
          }
          function _iO5d($_il1l)
          {
              $_il1l->_iO23 = $this->_iO23 . "_r" . sizeof($this->_il3k);
              $_il1l->_il22($this);
              array_push($this->_il3k, $_il1l);
          }
          function _iO2i()
          {
              $this->_il1t();
              if ($this->_iO50) {
                  $this->_iO5v = $this->InsertSettings->_il2j();
                  $this->_iO5v->_il22($this);
              }
              for ($_iO9 = 0; $_iO9 < $this->_iO5t; $_iO9++) {
                  $_il1l = new gridrow();
                  $this->_iO5d($_il1l);
                  $_il1l->_iO2i();
              }
              if ($this->_iO5w !== null) {
                  $this->_il5f = array();
                  for ($_iO9 = 0; $_iO9 < $this->_iO5w; $_iO9++) {
                      $_iO5f = new _iO57();
                      $_iO5f->_iO23 = $this->_iO23 . "_gm" . $_iO9;
                      $_iO5f->_il22($this);
                      $_iO5f->_iO2i();
                      array_push($this->_il5f, $_iO5f);
                  }
              } else {
                  $this->_iO5w = sizeof($this->_il5f);
              }
          }
          function refresh()
          {			  
              $this->_iO24 = true;
          }
          function _il2l($_ilm)
          {
              if (!isset($this->_iO2c->_iO1p[$this->_iO23])) {
                  $this->_iO24 = true;
              }
              foreach ($this->_il5f as $_iO1b) {
                  $_iO1b->_il2l($_ilm);
              }
              $this->DataSource->clear();
              if (isset($_ilm->_il28[$this->_iO23])) {
                  $_iO2l = $_ilm->_il28[$this->_iO23];
                  switch ($_iO2l["Command"]) {
                      case "StartInsert":
                          if ($this->_iO20->EventHandler->onbeforestartinsert($this, array()) == true) {
                              $this->_iO50 = true;
                              $this->_iO5v = $this->InsertSettings->_il2j();
                              $this->_iO5v->_il22($this);
                              $this->_iO20->EventHandler->onstartinsert($this, array());
                          }
                          break;
                      case "ConfirmInsert":
                          $this->_iO5v->_iO4x();
                          break;
                      case "CancelInsert":
                          if ($this->_iO20->EventHandler->onbeforecancelinsert($this, array()) == true) {
                              $this->_iO50 = false;
                              $this->_iO20->EventHandler->oncancelinsert($this, null);
                          }
                          break;
                      case "Refresh":
                          $this->_iO24 = true;
                          break;
                      case "AddGroup":
                          $_il60 = $_iO2l["Args"]["GroupField"];
                          $_iO60 = $_iO2l["Args"]["Position"];
                          $_il61 = true;
                          foreach ($this->_il5f as $_iO1b) {
                              if ($_iO1b->GroupField == $_il60) {
                                  $_il61 = false;
                              }
                          }
                          if ($_il61) {
                              $_iO61 = new _iO57();
                              $_iO61->GroupField = $_il60;
                              $_iO61->addinfofield($_il60);
                              foreach ($this->_iO2p as $_iO5r) {
                                  if ($_iO5r->DataField == $_il60) {
                                      $_iO61->HeaderText = $_iO5r->HeaderText;
                                  }
                              }
                              $_iO61->_il22($this);
                              if ($_iO60 === null) {
                                  array_push($this->_il5f, $_iO61);
                              } else {
                                  $_il62 = array();
                                  for ($_iO9 = 0; $_iO9 < sizeof($this->_il5f); $_iO9++) {
                                      if ($_iO60 == $_iO9) {
                                          array_push($_il62, $_iO61);
                                      }
                                      array_push($_il62, $this->_il5f[$_iO9]);
                                  }
                                  $this->_il5f = $_il62;
                              }
                              for ($_iO9 = 0; $_iO9 < sizeof($this->_il5f); $_iO9++) {
                                  $this->_il5f[$_iO9]->_iO23 = $this->_iO23 . "_gm" . $_iO9;
                              }
                          }
                          break;
                      case "ChangeGroupOrder":
                          $_il60 = $_iO2l["Args"]["GroupField"];
                          $_iO62 = $_iO2l["Args"]["Position"];
                          $_il63 = 0;
                          for ($_iO9 = 0; $_iO9 < sizeof($this->_il5f); $_iO9++) {
                              if ($this->_il5f[$_iO9]->GroupField == $_il60) {
                                  $_il63 = $_iO9;
                              }
                          }
                          if ($_iO62 === null || $_iO62 >= sizeof($this->_il5f)) {
                              $_iO62 = sizeof($this->_il5f);
                          }
                          $_il62 = array();
                          for ($_iO9 = 0; $_iO9 <= sizeof($this->_il5f); $_iO9++) {
                              if ($_iO9 == $_iO62) {
                                  array_push($_il62, $this->_il5f[$_il63]);
                              }
                              if ($_iO9 != $_il63 && $_iO9 < sizeof($this->_il5f)) {
                                  array_push($_il62, $this->_il5f[$_iO9]);
                              }
                          }
                          $this->_il5f = $_il62;
                          for ($_iO9 = 0; $_iO9 < sizeof($this->_il5f); $_iO9++) {
                              $this->_il5f[$_iO9]->_iO23 = $this->_iO23 . "_gm" . $_iO9;
                          }
                          break;
                      case "RemoveGroup":
                          $_il60 = $_iO2l["Args"]["GroupField"];
                          $_il62 = array();
                          for ($_iO9 = 0; $_iO9 < sizeof($this->_il5f); $_iO9++) {
                              if ($this->_il5f[$_iO9]->GroupField != $_il60) {
                                  array_push($_il62, $this->_il5f[$_iO9]);
                              }
                          }
                          $this->_il5f = $_il62;
                          for ($_iO9 = 0; $_iO9 < sizeof($this->_il5f); $_iO9++) {
                              $this->_il5f[$_iO9]->_iO23 = $this->_iO23 . "_gm" . $_iO9;
                          }
                          break;
                  }
              }
              $this->_iO20->EventHandler->ontableviewprerender($this, array());
              if (sizeof($this->_il5f) > 0) {
                  $_il6 = array();
                  for ($_iO9 = 0; $_iO9 < sizeof($this->_il5f); $_iO9++) {
                      $this->DataSource->addsort(new datasourcesort($this->_il5f[$_iO9]->GroupField, ($this->_il5f[$_iO9]->Sort < 0) ? "DESC" : "ASC"));
                      $_iO63 = new _iO3p();
                      $_iO63->_iO23 = $this->_iO23 . "_gc" . $_iO9;
                      $_iO63->_il22($this);
                      array_push($_il6, $_iO63);
                  }
                  $this->_iO2p = array_merge($_il6, $this->_iO2p);
              }
              foreach ($this->_iO2p as $_iO5r) {
                  $_iO5r->_il2l($_ilm);
              }
              foreach ($this->_il3k as $_il1l) {
                  $_il1l->_il2l($_ilm);
              }
              if ($this->_iO4y != null) {
                  foreach ($this->_il4z as $_il17) {
                      $this->DataSource->addfilter(new datasourcefilter($_il17["Detail"], "=", $this->_iO4y->DataItem[$_il17["Master"]]));
                  }
              }
              if ($this->Pager != null) {
                  $this->Pager->_il3v = $this->DataSource->count();
                  $this->Pager->_il2l($_ilm);
              }
              $_il64 = array();
              if ($this->KeepSelectedRecords && $this->DataKeyNames !== null) {
                  foreach ($this->SelectedKeys as $_iO64) {
                      $_il64[_il16($_iO64)] = $_iO64;
                  }
                  foreach ($this->_il3k as $_il1l) {
                      $_iO64 = _iO13($_il1l->DataItem, $this->DataKeyNames);
                      $_il65 = _il16($_iO64);
                      if ($_il1l->Selected) {
                          $_il64[$_il65] = $_iO64;
                      } else {
                          if (isset($_il64[$_il65])) {
                              unset($_il64[$_il65]);
                          }
                      }
                  }
              }
              if ($this->_iO24) {
                  $_iO1q = array();
                  if ($this->Pager != null) {
                      $_iO1q = $this->DataSource->getdata($this->Pager->PageSize * $this->Pager->PageIndex, $this->Pager->PageSize);
                  } else {
                      $_iO1q = $this->DataSource->getdata();
                  }
                  $this->_il3k = array();
                  for ($_iO9 = 0; $_iO9 < sizeof($_iO1q); $_iO9++) {
                      $_il1l = new gridrow();
                      $_il1l->DataItem = $_iO1q[$_iO9];
                      $this->_iO5d($_il1l);
                  }
                  $_il5h = array();
                  foreach ($this->_iO2p as $_iO5r) {
                      if ($_iO5r->Aggregate !== null) {
                          array_push($_il5h, array("Key" => $_iO5r->_iO23, "Aggregate" => $_iO5r->Aggregate, "DataField" => $_iO5r->DataField));
                      }
                  }
                  $_iO1e = null;
                  if (sizeof($_il5h) > 0) {
                      $_iO1e = $this->DataSource->getaggregates($_il5h);
                  }
                  if ($_iO1e !== null) {
                      foreach ($this->_iO2p as $_iO5r) {
                          if (isset($_iO1e[$_iO5r->_iO23])) {
                              $_iO5r->_il2y = $_iO1e[$_iO5r->_iO23];
                          }
                      }
                  }
              }
              $this->SelectedKeys = array();
              if ($this->KeepSelectedRecords && $this->DataKeyNames !== null) {
                  if ($this->_iO24) {
                      foreach ($this->_il3k as $_il1l) {
                          $_iO64 = _iO13($_il1l->DataItem, $this->DataKeyNames);
                          $_il65 = _il16($_iO64);
                          if (isset($_il64[$_il65])) {
                              $_il1l->Selected = true;
                          }
                      }
                  }
                  foreach ($_il64 as $_iO64) {
                      array_push($this->SelectedKeys, $_iO64);
                  }
              } else {
                  foreach ($this->_il3k as $_il1l) {
                      if ($_il1l->Selected) {
                          $_iO64 = _iO13($_il1l->DataItem, $this->DataKeyNames);
                          array_push($this->SelectedKeys, $_iO64);
                      }
                  }
              }
              if (sizeof($this->_il5f) > 0) {
                  $this->_il5j = new _il5a();
                  $this->_il5j->_iO23 = $this->_iO23 . "_rg";
                  $this->_il5j->_il22($this);
                  $this->_il5j->_iO5b = -1;
                  $this->_il5j->_il5e($this->_il3k);
                  $this->_il5j->_iO2i();
                  $this->_il5j->_il2l($_ilm);
              }
          }
          function getinstancerows()
          {
              return $this->_il3k;
          }
          function getinstancecolumns()
          {
              return $this->_iO2p;
          }
          function exporttocsv()
          {
              $_iO65 = $this->_iO20->ExportSettings;
              header("Pragma: public");
              header("Expires: 0");
              header("Cache-Control: must-revalidate, post-check=0, pre-check=0");
              header("Cache-Control: public");
              header("Content-Description: File Transfer");
              header("Content-Type: application/force-download");
              header("Content-Disposition: attachment; filename=\"" . $_iO65->FileName . ".csv\"");
              header("Content-Transfer-Encoding: binary");
              $_il66 = true;
              foreach ($this->_iO2p as $_iO5r) {
                  if ($_iO5r->AllowExporting) {
                      if (!$_il66)
                          echo ",";
                      echo "\"" . $_iO5r->HeaderText . "\"";
                      $_il66 = false;
                  }
              }
              echo "\r\n";
              if ($_iO65->IgnorePaging) {
                  $_iO66 = $this->DataSource->getdata();
                  foreach ($_iO66 as $_il2g) {
                      $_il1l = new gridrow();
                      $_il1l->DataItem = $_il2g;
                      $_il66 = true;
                      foreach ($this->_iO2p as $_iO5r) {
                          if ($_iO5r->AllowExporting) {
                              if (!$_il66)
                                  echo ",";
                              echo "\"" . $_iO5r->render($_il1l) . "\"";
                              $_il66 = false;
                          }
                      }
                      echo "\r\n";
                  }
              } else {
                  foreach ($this->_il3k as $_il1l) {
                      $_il66 = true;
                      foreach ($this->_iO2p as $_iO5r) {
                          if ($_iO5r->AllowExporting) {
                              if (!$_il66)
                                  echo ",";
                              echo "\"" . $_iO5r->render($_il1l) . "\"";
                              $_il66 = false;
                          }
                      }
                      echo "\r\n";
                  }
              }
              exit();
          }
          function exporttoexcel()
          {
              require "library/Excel/Writer.php";
              $_iO65 = $this->_iO20->ExportSettings;
              $_il67 = new spreadsheet_excel_writer();
              $_il67->send($_iO65->FileName . ".xls");
              $_iO67 = &$_il67->addworksheet($_iO65->FileName);
              $_il68 = &$_il67->addformat();
              $_il68->setbold();
              $_il68->setalign("left");
              $_iO68 = &$_il67->addformat();
              $_iO68->setalign("left");
              $_il69 = 0;
              $_iO69 = 0;
              $_il6a = array();
              foreach ($this->_iO2p as $_iO5r) {
                  if ($_iO5r->AllowExporting) {
                      $_iO67->write($_iO69, $_il69, $_iO5r->HeaderText, $_il68);
                      $_il6a[$_il69] = strlen($_iO5r->HeaderText);
                      $_il69++;
                  }
              }
              $_iO69++;
              $_il69 = 0;
              if ($_iO65->IgnorePaging) {
                  $_iO66 = $this->DataSource->getdata();
                  foreach ($_iO66 as $_il2g) {
                      $_il1l = new gridrow();
                      $_il1l->DataItem = $_il2g;
                      foreach ($this->_iO2p as $_iO5r) {
                          if ($_iO5r->AllowExporting) {
                              $_il3 = $_iO5r->render($_il1l);
                              $_iO67->write($_iO69, $_il69, $_il3, $_iO68);
                              if ($_il6a[$_il69] < strlen("$_il3")) {
                                  $_il6a[$_il69] = strlen("$_il3");
                              }
                              $_il69++;
                          }
                      }
                      $_iO69++;
                      $_il69 = 0;
                  }
              } else {
                  foreach ($this->_il3k as $_il1l) {
                      foreach ($this->_iO2p as $_iO5r) {
                          if ($_iO5r->AllowExporting) {
                              $_il3 = $_iO5r->render($_il1l);
                              $_iO67->write($_iO69, $_il69, $_il3, $_iO68);
                              if ($_il6a[$_il69] < strlen("$_il3")) {
                                  $_il6a[$_il69] = strlen("$_il3");
                              }
                              $_il69++;
                          }
                      }
                      $_iO69++;
                      $_il69 = 0;
                  }
              }
              for ($_iO9 = 0; $_iO9 < sizeof($_il6a); $_iO9++) {
                  $_iO67->setcolumn($_iO9, $_iO9, (($_il6a[$_iO9] < 055) ? $_il6a[$_iO9] : 055) + 5);
              }
              $_il67->close();
              exit();
          }
          function exporttoword()
          {
              $_iO65 = $this->_iO20->ExportSettings;
              header("Pragma: public");
              header("Expires: 0");
              header("Cache-Control: must-revalidate, post-check=0, pre-check=0");
              header("Cache-Control: public");
              header("Content-Description: File Transfer");
              header("Content-Type: application/msword");
              header("Content-Disposition: attachment; filename=\"" . $_iO65->FileName . ".doc\"");
              header("Content-Transfer-Encoding: binary");
              echo "<table border='1'>";
              echo "<tr>";
              foreach ($this->_iO2p as $_iO5r) {
                  if ($_iO5r->AllowExporting) {
                      echo "<th align='left' style='background-color:#EEEEEE;'>" . $_iO5r->HeaderText . "</th>";
                  }
              }
              echo "</tr>";
              if ($_iO65->IgnorePaging) {
                  $_iO66 = $this->DataSource->getdata();
                  foreach ($_iO66 as $_il2g) {
                      $_il1l = new gridrow();
                      $_il1l->DataItem = $_il2g;
                      echo "<tr>";
                      foreach ($this->_iO2p as $_iO5r) {
                          if ($_iO5r->AllowExporting) {
                              echo "<td>" . $_iO5r->render($_il1l) . "</td>";
                          }
                      }
                      echo "</tr>";
                  }
              } else {
                  foreach ($this->_il3k as $_il1l) {
                      echo "<tr>";
                      foreach ($this->_iO2p as $_iO5r) {
                          if ($_iO5r->AllowExporting) {
                              echo "<td>" . $_iO5r->render($_il1l) . "</td>";
                          }
                      }
                      echo "</tr>";
                  }
              }
              echo "</table>";
              exit();
          }
          function exporttopdf()
          {   
              ini_set('memory_limit', '-1');
              require "library/tcpdf/config/lang/eng.php";
              require "library/tcpdf/tcpdf.php";
              $_iO65 = $this->_iO20->ExportSettings;
              $_iO6a = new tcpdf(PDF_PAGE_ORIENTATION, PDF_UNIT, PDF_PAGE_FORMAT, true, 'UTF-8', false);
              $_iO6a->setfont('helvetica', '', 012);
              $_iO6a->addpage();
              $_il6b = "";
              $_il6b .= '<table border="1">';
              $_il6b .= "<tr>";
              foreach ($this->_iO2p as $_iO5r) {
                  if ($_iO5r->AllowExporting) {
                      $_il6b .= '<th align="left" style="background-color: #EEEEEE;"><b>' . $_iO5r->HeaderText . '</b></th>';
                  }
              }
              $_il6b .= "</tr>";
              if ($_iO65->IgnorePaging) {
                  $_iO66 = $this->DataSource->getdata();
                  foreach ($_iO66 as $_il2g) {
                      $_il1l = new gridrow();
                      $_il1l->DataItem = $_il2g;
                      $_il6b .= "<tr>";
                      foreach ($this->_iO2p as $_iO5r) {
                          if ($_iO5r->AllowExporting) {
                              $_il6b .= "<td>" . $_iO5r->render($_il1l) . "</td>";
                          }
                      }
                      $_il6b .= "</tr>";
                  }
              } else {
                  foreach ($this->_il3k as $_il1l) {
                      $_il6b .= "<tr>";
                      foreach ($this->_iO2p as $_iO5r) {
                          if ($_iO5r->AllowExporting) {
                              $_il6b .= "<td>" . $_iO5r->render($_il1l) . "</td>";
                          }
                      }
                      $_il6b .= "</tr>";
                  }
              }
              $_il6b .= "</table>";
              $_iO6a->writehtml($_il6b, true, 0, true, 0);
              $_iO6a->output($_iO65->FileName . ".pdf", "D");
              exit();
          }
          function _iO25()
          {
              $_iO6b = "<div id='{id}' class='kgrTableView' style='{width}{height}'>{grouppanel}{tables}{functionpanel}{pager}{status}</div>";
              $_il6c = "<table class='kgrTable' cellspacing='0' style='{style}'>{colgroup}{thead}{tfoot}{tbody}</table>";
              $_iO6c = "<div class='{class}' style='{divstyle}'><table id='{id}_{part}' style='{style}' class='kgrTable'>{colgroup}{tpart}</table></div>";
              $_il6d = "<colgroup>{cols}</colgroup>";
              $_iO6d = "<thead><tr>{ths}</tr>{insertform}{filter}</thead>";
              $_il6e = "<tr>{tds}</tr>";
              $_iO6e = "<tfoot>{tfoot_trs}</tfoot>";
              $_il6f = "<tr>{col_footer_tds}</tr>";
              $_iO6f = "<tbody>{tbody_trs}</tbody>";
              $_il6g = "";
              $_il5q = "";
              $_iO6g = "";
              $_il6h = sizeof($this->_iO2p);
              for ($_iO9 = 0; $_iO9 < $_il6h; $_iO9++) {
                  $_iO6h = $this->_iO2p[$_iO9];
                  $_il6g .= $_iO6h->_iO33();
                  if ($this->ShowHeader) {
                      $_il5q .= $_iO6h->renderheader();
                  }
                  if ($this->ShowFooter) {
                      $_iO6g .= $_iO6h->renderfooter();
                  }
              }
              $_il6i = _iO0("{cols}", $_il6g, $_il6d);
              $_iO6i = _iO0("{ths}", $_il5q, $_iO6d);
              $_iO6i = _iO0("{insertform}", ($this->_iO50) ? $this->_iO5v->_iO25() : "", $_iO6i);
              $_il6j = false;
              for ($_iO9 = 0; $_iO9 < sizeof($this->_iO2p); $_iO9++) {
                  if ($this->_iO2p[$_iO9]->AllowFiltering) {
                      $_il6j = true;
                  }
              }
              if ($_il6j) {
                  $_iO6j = "";
                  for ($_iO9 = 0; $_iO9 < sizeof($this->_iO2p); $_iO9++) {
                      $_iO6j .= $this->_iO2p[$_iO9]->_iO3a();
                  }
                  $_il6k = _iO0("{tds}", $_iO6j, $_il6e);
                  $_iO6i = _iO0("{filter}", $_il6k, $_iO6i);
              } else {
                  $_iO6i = _iO0("{filter}", "", $_iO6i);
              }
              $_iO6k = "";
              if ($this->ShowFunctionPanel) {
                  $_iO6k = $this->FunctionPanel->_iO25();
              }
              $_il6l = "";
              if ($this->ShowGroupPanel) {
                  $_il6l = $this->GroupPanel->_iO25();
              }
              $_iO45 = "";
              if ($this->Pager != null) {
                  $_iO45 = $this->Pager->_iO25();
              }
              $_iO6l = "";
              if ($this->_iO23 == $this->_iO20->_iO23 . "_mt" && $this->_iO20->ShowStatus) {
                  $_iO6l = $this->_iO20->Status->_iO25();
              }
              $_il6m = "";
              if ($this->ShowFooter) {
                  $_iO6m = _iO0("{col_footer_tds}", $_iO6g, $_il6f);
                  $_il6m .= $_iO6m;
              }
              $_il6n = _iO0("{tfoot_trs}", $_il6m, $_iO6e);
              $_iO6n = "";
              for ($_iO9 = 0; $_iO9 < sizeof($this->_il3k); $_iO9++) {
                  if ($this->RowAlternative) {
                      $this->_il3k[$_iO9]->_iO2e = ($_iO9 % 2 != 0);
                  }
              }
              if (sizeof($this->_il5f) > 0) {
                  $_iO6n = $this->_il5j->_iO25();
              } else {
                  for ($_iO9 = 0; $_iO9 < sizeof($this->_il3k); $_iO9++) {
                      $_iO6n .= $this->_il3k[$_iO9]->_iO25();
                  }
              }
              $_il6o = _iO0("{tbody_trs}", $_iO6n, $_iO6f);
              $_iO6o = _iO0("{id}", $this->_iO23, $_iO6b);
              if ($this->AllowScrolling == true) {
                  $_il6p = "table-layout:fixed; empty-cells: show; overflow:hidden; width:{width};";
                  $_il6p = _iO0("{width}", ($this->_il5w != null) ? $this->_il5w : "100%", $_il6p);
                  $_iO6p = _iO0("{id}", $this->_iO23, $_iO6c);
                  $_iO6p = _iO0("{part}", "header", $_iO6p);
                  $_iO6p = _iO0("{class}", "kgrPartHeader", $_iO6p);
                  $_iO6p = _iO0("{colgroup}", $_il6i, $_iO6p);
                  $_iO6p = _iO0("{tpart}", $_iO6i, $_iO6p);
                  $_iO6p = _iO0("{style}", $_il6p, $_iO6p);
                  $_iO6p = _iO0("{divstyle}", "", $_iO6p);
                  $_il6q = _iO0("{id}", $this->_iO23, $_iO6c);
                  $_il6q = _iO0("{part}", "data", $_il6q);
                  $_il6q = _iO0("{class}", "kgrPartData", $_il6q);
                  $_il6q = _iO0("{colgroup}", $_il6i, $_il6q);
                  $_il6q = _iO0("{tpart}", $_il6o, $_il6q);
                  $_il6q = _iO0("{style}", $_il6p, $_il6q);
                  $_iO6q = "";
                  $_iO6q .= ($this->_il5v) ? "height:" . $this->_il5v . "px;" : "";
                  $_il6q = _iO0("{divstyle}", $_iO6q, $_il6q);
                  $_il6r = _iO0("{id}", $this->_iO23, $_iO6c);
                  $_il6r = _iO0("{part}", "footer", $_il6r);
                  $_il6r = _iO0("{class}", "kgrPartFooter", $_il6r);
                  $_il6r = _iO0("{colgroup}", $_il6i, $_il6r);
                  $_il6r = _iO0("{tpart}", $_il6n, $_il6r);
                  $_il6r = _iO0("{style}", $_il6p, $_il6r);
                  $_il6r = _iO0("{divstyle}", "", $_il6r);
                  $_il6q = _iO0("{colgroup}", $_il6i, $_il6q);
                  $_il6q = _iO0("{tpart}", $_il6o, $_il6q);
                  $_iO6o = _iO0("{tables}", $_iO6p . $_il6q . $_il6r, $_iO6o);
              } else {
                  $_iO2s = $_il6c;
                  $_iO2s = _iO0("{colgroup}", $_il6i, $_iO2s);
                  $_iO2s = _iO0("{style}", "table-layout: {layout};empty-cells: show;{width}", $_iO2s);
                  $_iO2s = _iO0("{layout}", $this->TableLayout, $_iO2s);
                  if ($this->Width !== null && strpos($this->Width, "%") !== false) {
                      $_iO2s = _iO0("{width}", "width:100%", $_iO2s);
                  }
                  $_iO2s = _iO0("{thead}", ($this->ShowHeader) ? $_iO6i : "", $_iO2s);
                  $_iO2s = _iO0("{tfoot}", $_il6n, $_iO2s);
                  $_iO2s = _iO0("{tbody}", $_il6o, $_iO2s);
                  $_iO6o = _iO0("{tables}", $_iO2s, $_iO6o);
              }
              $_iO6o = _iO0("{width}", ($this->Width != "") ? "width:" . $this->Width . ";" : "", $_iO6o);
              $_iO6o = _iO0("{height}", ($this->Height != "") ? "height:" . $this->Height . ";" : "", $_iO6o);
              $_iO6o = _iO0("{grouppanel}", $_il6l, $_iO6o);
              $_iO6o = _iO0("{functionpanel}", $_iO6k, $_iO6o);
              $_iO6o = _iO0("{pager}", $_iO45, $_iO6o);
              $_iO6o = _iO0("{status}", $_iO6l, $_iO6o);
              return $_iO6o;
          }
      }
      class _iO6r
      {
          var $LoadingText;
          var $DoneText;
		  var $grid; //Added by Ivan Budiono to show error message :)
          function _il22($_iO22)
          {
			  $this->grid = $_iO22;
              if ($this->LoadingText === null)
                  $this->LoadingText = $_iO22->Localization->_il28["Loading"];
              if ($this->DoneText === null)
                  $this->DoneText = $_iO22->Localization->_il28["Done"];
          }
          function _iO25()
          {
			  //Added by Ivan Budiono to show error message :)
			  if($this->grid->errorMessage == "")
				$_il6s = "<div class='kgrStatus'><span class='kgrDoneText'>{donetext}</span><span class='kgrLoadingText'>{loadingtext}</span></div>";
			  else
				$_il6s = "<div class='kgrStatus'>".$this->grid->errorMessage."</div>";
			  //*** end ***/
			  
              $_iO6l = _iO0("{donetext}", $this->DoneText, $_il6s);
              $_iO6l = _iO0("{loadingtext}", $this->LoadingText, $_iO6l);
              return $_iO6l;
          }
      }
      class _iO6s
      {
          var $IgnorePaging = false;
          var $FileName = "KoolGridExport";
      }
      class _il6t
      {
          var $Resizing;
          var $Selecting;
          var $Scrolling;
          var $ClientMessages;
          var $ClientEvents;
          var $_iO20;
          function __construct()
          {
              $this->Resizing = array("ResizeGridOnColumnResize" => false);
              $this->Selecting = array();
              $this->Scrolling = array("SaveScrollingPosition" => true);
              $this->ClientMessages = array("DeleteConfirm" => null);
              $this->ClientEvents = array();
          }
          function _il22($_iO22)
          {
              $this->_iO20 = $_iO22;
              if ($this->ClientMessages["DeleteConfirm"] === null)
                  $this->ClientMessages["DeleteConfirm"] = $_iO22->Localization->_iO28["DeleteConfirm"];
          }
          function _iO1t()
          {
              $_il27 = $this->_iO20->_iO2c;
              $_iO6t = $this->_iO20->_iO23;
              $_il27->_iO1p[$_iO6t]["ClientSettings"] = array();
              $_il27->_iO1p[$_iO6t]["ClientSettings"]["Resizing"] = $this->Resizing;
              $_il27->_iO1p[$_iO6t]["ClientSettings"]["Selecting"] = $this->Selecting;
              $_il27->_iO1p[$_iO6t]["ClientSettings"]["Scrolling"] = $this->Scrolling;
              $_il27->_iO1p[$_iO6t]["ClientSettings"]["ClientMessages"] = $this->ClientMessages;
              $_il27->_iO1p[$_iO6t]["ClientSettings"]["ClientEvents"] = $this->ClientEvents;
          }
      }
      class _il5r
      {
          var $ShowRefreshButton = true;
          var $ShowInsertButton = true;
          var $RefreshButtonText;
          var $InsertButtonText;
          var $_il2d;
          var $PanelTemplate = "{Insert} {Refresh}";
          function _il22($_il2f)
          {
              $this->_il2d = $_il2f;
              if ($this->RefreshButtonText === null)
                  $this->RefreshButtonText = $_il2f->_iO20->Localization->_il28["Refresh"];
              if ($this->InsertButtonText === null)
                  $this->InsertButtonText = $_il2f->_iO20->Localization->_il28["Insert"];
          }
          function _iO25()
          {
              $_il6u = "<div class='kgrFunctionPanel'>{content}</div>";
              $_il3n = "<input type='button' onclick='{onclick}' title='{title}'/>";
              $_il41 = "<a href='javascript:void 0' onclick='{onclick}' title='{title}'>{text}</a>";
              $_iO41 = "<span class= '{class}'>{button}{a}</span> ";
              $_iO6u = _iO0("{class}", "kgrRefresh", $_iO41);
              $_iO6u = _iO0("{button}", $_il3n, $_iO6u);
              $_iO6u = _iO0("{a}", ($this->RefreshButtonText != null) ? $_il41 : "", $_iO6u);
              $_iO6u = _iO0("{onclick}", "grid_refresh(this)", $_iO6u);
              $_iO6u = _iO0("{title}", "", $_iO6u);
              $_iO6u = _iO0("{text}", $this->RefreshButtonText, $_iO6u);
              $_il6v = _iO0("{class}", "kgrInsert", $_iO41);
              $_il6v = _iO0("{button}", $_il3n, $_il6v);
              $_il6v = _iO0("{a}", ($this->InsertButtonText != null) ? $_il41 : "", $_il6v);
              $_il6v = _iO0("{onclick}", "grid_insert(this)", $_il6v);
              $_il6v = _iO0("{title}", "", $_il6v);
              $_il6v = _iO0("{text}", $this->InsertButtonText, $_il6v);
              $_iO6v = _iO0("{content}", $this->PanelTemplate, $_il6u);
              $_iO6v = _iO0("{Refresh}", ($this->ShowRefreshButton) ? $_iO6u : "", $_iO6v);
              $_iO6v = _iO0("{Insert}", ($this->ShowInsertButton) ? $_il6v : "", $_iO6v);
              return $_iO6v;
          }
      }
      class _il6w implements _iO1s
      {
          var $_iO23;
          var $_iO2c;
          var $MasterTable;
          var $_il24;
          var $AjaxEnabled = false;
          var $AjaxHandlePage;
          var $_iO6w;
          var $Status;
          var $AllowHovering = false;
          var $AllowSelecting = false;
          var $AllowMultiSelecting = false;
          var $AllowEditing = false;
          var $AllowDeleting = false;
          var $AllowScrolling = false;
          var $AllowSorting = false;
          var $AllowResizing = false;
          var $AllowFiltering = false;
          var $AllowGrouping = false;
          var $ShowHeader = true;
          var $ShowFooter = false;
          var $RowAlternative = false;
          var $AutoGenerateRowSelectColumn = false;
          var $AutoGenerateExpandColumn = false;
          var $AutoGenerateColumns = false;
          var $AutoGenerateEditColumn = false;
          var $AutoGenerateDeleteColumn = false;
          var $DisableAutoGenerateDataFields = "";
          var $KeepSelectedRecords = false;
          var $ShowStatus = true;
          var $ColumnWrap = false;
          var $ColumnAlign;
          var $_iO2y;
          var $TableLayout = "auto";
          var $Width;
          var $Height;
          var $FilterOptions;
          var $PageSize = 040;
          var $DataSource;
          var $ClientSettings;
          var $Localization;
          var $CharSet = "UTF-8";
          var $KeepViewStateInSession = false;
          var $EventHandler;
          var $ExportSettings;
          function __construct($_il6x)
          {
              $this->_iO23 = $_il6x;
              $this->_iO2c = new _il20();
              $this->Localization = new _iO27();
              $this->MasterTable = new gridtableview();
              $this->_iO6w = new _il2b($this);
              $this->Status = new _iO6r();
              $this->ClientSettings = new _il6t();
              $this->FilterOptions = array("No_Filter", "Equal", "Not_Equal", "Greater_Than", "Less_Than", "Greater_Than_Or_Equal", "Less_Than_Or_Equal", "Contain", "Not_Contain", "Start_With", "End_With");
              $this->ExportSettings = new _iO6s();
          }
          function _il22()
          {
              if ($this->EventHandler === null)
                  $this->EventHandler = new grideventhandler();
              $this->_iO2c->_il22($this);
              $this->_il24->_iO23 = $this->_iO23 . "_mt";
              $this->_il24->_il22($this, null);
              $this->ClientSettings->_il22($this);
              $this->Status->_il22($this);
          }
          function _il1t()
          {
              if (isset($this->_iO2c->_iO1p[$this->_iO23])) {
                  $_iO2f = $this->_iO2c->_iO1p[$this->_iO23];
              }
          }
          function _iO1t()
          {
              $this->_iO2c->_iO1p = array();
              $this->_iO2c->_iO1p[$this->_iO23] = array();
              $this->_il24->_iO1t();
              $this->ClientSettings->_iO1t();
          }
          function process()
          {
              $this->_il24 = $this->MasterTable->_il2j();
              $this->_il22();
              $this->_il1t();
              $this->_il24->_iO2i();
              if (isset($this->_iO6w->_il28[$this->_iO23])) {
                  $_iO2l = $this->_iO6w->_il28[$this->_iO23];
                  switch ($_iO2l["Command"]) {
                      case "Refresh":
                          $this->_il24->_iO24 = true;
                          break;
                  }
              }
              $this->EventHandler->ongridprerender($this, array());
              $this->_il24->_il2l($this->_iO6w);
          }
          function refresh()
          {
              if ($this->_il24 !== null) {
                  $this->_il24->_iO24 = true;
              }
          }
          function getinstancemastertable()
          {
              return $this->_il24;
          }
          function _iO6x()
          {
              $this->_iO1t();
              $_il48 = "{mastertable}{viewstate}{command}";
              $_ilg = _iO0("{mastertable}", $this->_il24->_iO25(), $_il48);
              $_ilg = _iO0("{viewstate}", $this->_iO2c->_iO25(), $_ilg);
              $_ilg = _iO0("{command}", $this->_iO6w->_iO25(), $_ilg);
              return $_ilg;
          }
          function registerclientevent($_il6y, $_iO6y)
          {
              $this->ClientSettings->ClientEvents[$_il6y] = $_iO6y;
          }
      }
      class grideventhandler
      {
          function onbeforedetailtablesexpand($_il6z, $_il4a)
          {
              return true;
          }
          function ondetailtablesexpand($_il6z, $_il4a)
          {
          }
          function onbeforedetailtablescollapse($_il6z, $_il4a)
          {
              return true;
          }
          function ondetailtablescollapse($_il6z, $_il4a)
          {
          }
          function onbeforerowstartedit($_il6z, $_il4a)
          {
              return true;
          }
          function onrowstartedit($_il6z, $_il4a)
          {
          }
          function onbeforerowcanceledit($_il6z, $_il4a)
          {
              return true;
          }
          function onrowcanceledit($_il6z, $_il4a)
          {
          }
          function onbeforerowdelete($_il6z, $_il4a)
          {
              return true;
          }
          function onrowdelete($_il6z, $_il4a)
          {
          }
          function onbeforecolumnsort($_il6z, $_il4a)
          {
              return true;
          }
          function oncolumnsort($_il6z, $_il4a)
          {
          }
          function onbeforecolumngroup($_il6z, $_il4a)
          {
              return true;
          }
          function oncolumngroup($_il6z, $_il4a)
          {
          }
          function onbeforecolumnfilter($_il6z, $_il4a)
          {
              return true;
          }
          function oncolumnfilter($_il6z, $_il4a)
          {
          }
          function onbeforepageindexchange($_il6z, $_il4a)
          {
              return true;
          }
          function onpageindexchange($_il6z, $_il4a)
          {
          }
          function onbeforepagesizechange($_il6z, $_il4a)
          {
              return true;
          }
          function onpagesizechange($_il6z, $_il4a)
          {
          }
          function onbeforerowconfirmedit($_il6z, $_il4a)
          {
              return true;
          }
          function onrowconfirmedit($_il6z, $_il4a)
          {
          }
          function onbeforeconfirminsert($_il6z, $_il4a)
          {
              return true;
          }
          function onconfirminsert($_il6z, $_il4a)
          {
          }
          function onbeforestartinsert($_il6z, $_il4a)
          {
              return true;
          }
          function onstartinsert($_il6z, $_il4a)
          {
          }
          function onbeforecancelinsert($_il6z, $_il4a)
          {
              return true;
          }
          function oncancelinsert($_il6z, $_il4a)
          {
          }
          function onrowprerender($_il6z, $_il4a)
          {
          }
          function ontableviewprerender($_il6z, $_il4a)
          {
          }
          function ongridprerender($_il6z, $_il4a)
          {
          }
      }
      class koolgrid extends _il6w
      {
          var $_il0 = "2.3.0.0";
          var $styleFolder;
          var $_il6p;
          var $scriptFolder;
          var $id;
          var $AjaxLoadingImage;
		  var $errorMessage = ""; //Added by Ivan Budiono to show error message :)
          function __construct($_il6x)
          {
              $this->id = $_il6x;
              parent::__construct($_il6x);
          }
          function render()
          {			  
			  $_iO6z = "";
              $_iO6z .= $this->registercss();
              $_iO6z .= $this->rendergrid();
              $_il70 = isset($_POST["__koolajax"]) || isset($_GET["__koolajax"]);
              $_iO6z .= ($_il70) ? "" : $this->registerscript();
              $_iO6z .= "<script type='text/javascript'>";
              $_iO6z .= $this->startupscript();
              $_iO6z .= "</script>";
              if ($this->AjaxEnabled && class_exists("UpdatePanel")) {
                  $_iO70 = new updatepanel($this->id . "_updatepanel");
                  $_iO70->content = $_iO6z;
                  $_iO70->cssclass = $this->_il6p . "KGR_UpdatePanel";
                  if ($this->AjaxLoadingImage) {
                      $_iO70->setloading($this->AjaxLoadingImage);
                  }
                  $_iO6z = $_iO70->render();
              }
              return $_iO6z;
          }
          function rendergrid()
          {
              $this->_il71();
              $_iO71 = "\n<!--KoolGrid version {version} - www.koolphp.net -->\n";
              $_il72 = _iO0("{version}", $this->_il0, $_iO71);
              $_ilg = _iO0("{id}", $this->id, _iOd());
              if (_iOf($_ilg)) {
                  $_ilg = _iO0("{style}", $this->_il6p, $_ilg);
              }
              $_ilg = _iO0("{trademark}", $_il72, $_ilg);
              $_ilg = _iO0("{width}", ($this->Width !== null) ? "width:" . $this->Width : "", $_ilg);
              $_ilg = _iO0("{content}", parent::_iO6x(), $_ilg);
              $_ilg = _iO0("{version}", $this->_il0, $_ilg);
              return $_ilg;
          }
          function _il71()
          {
              $this->styleFolder = _iO0("\134", "/", $this->styleFolder);
              $_iO72 = trim($this->styleFolder, "/");
              $_il73 = strrpos($_iO72, "/");
              $this->_il6p = substr($_iO72, ($_il73 ? $_il73 : -1) + 1);
          }
          function registercss()
          {
              $this->_il71();
              $_iO73 = "<script type='text/javascript'>if (document.getElementById('__{style}KGR')==null){var _head = document.getElementsByTagName('head')[0];var _link = document.createElement('link'); _link.id = '__{style}KGR';_link.rel='stylesheet'; _link.href='{stylepath}/{style}/{style}.css';_head.appendChild(_link);}</script>";
              $_iO6z = _iO0("{style}", $this->_il6p, $_iO73);
              $_iO6z = _iO0("{stylepath}", $this->_il74(), $_iO6z);
              return $_iO6z;
          }
          function registerscript()
          {
              $_iO73 = "<script type='text/javascript'>if(typeof _libKGR=='undefined'){document.write(unescape(\"%3Cscript type='text/javascript' src='{src}'%3E %3C/script%3E\"));_libKGR=1;}</script>";
              $_iO6z = _iO0("{src}", $this->_iO74() . "?" . md5("js"), $_iO73);
              return $_iO6z;
          }
          function startupscript()
          {
              $_iO73 = "var {id}; function {id}_init(){ {id}=new KoolGrid('{id}',{AjaxEnabled},'{AjaxHandlePage}');}";
              $_iO73 .= "if (typeof(KoolGrid)=='function'){{id}_init();}";
              $_iO73 .= "else{if(typeof(__KGRInits)=='undefined'){__KGRInits=new Array();} __KGRInits.push({id}_init);{register_script}}";
              $_il75 = "if(typeof(_libKGR)=='undefined'){var _head = document.getElementsByTagName('head')\1330];var _script = document.createElement('script'); _script.type='text/javascript'; _script.src='{src}'; _head.appendChild(_script);_libKGR=1;}";
              $_iO75 = _iO0("{src}", $this->_iO74() . "\077" . md5("js"), $_il75);
              $_iO6z = _iO0("{id}", $this->id, $_iO73);
              $_iO6z = _iO0("{AjaxEnabled}", $this->AjaxEnabled ? "1" : "0", $_iO6z);
              $_iO6z = _iO0("{AjaxHandlePage}", $this->AjaxHandlePage, $_iO6z);
              $_iO6z = _iO0("{register_script}", $_iO75, $_iO6z);
              return $_iO6z;
          }
          function _iO74()
          {
              if ($this->scriptFolder == "") {
                  $_il5 = _iO3();
                  $_il76 = substr(_iO0("\134", "/", __FILE__), strlen($_il5));
                  return $_il76;
              } else {
                  $_il76 = _iO0("\134", "/", __FILE__);
                  $_il76 = $this->scriptFolder . substr($_il76, strrpos($_il76, "/"));
                  return $_il76;
              }
          }
          function _il74()
          {
              $_iO76 = $this->_iO74();
              $_il77 = _iO0(strrchr($_iO76, "/"), "", $_iO76) . "/styles";
              return $_il77;
          }
      }
  }
?>