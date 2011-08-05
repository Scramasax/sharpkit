//@AutoGenerated
if(typeof($CreateDelegate)=='undefined'){var $fki=0;var $fkp=String.fromCharCode(1);$CreateDelegate=function(a,b){if(a==null) return b;var c=a.$delegateCache;if(c==null){c={};a.$delegateCache=c;}if(b.$fk==null) {$fki++;b.$fk=$fkp+String($fki);}var d=c[b.$fk];if(d==null){ d=function(){return arguments.callee.func.apply(arguments.callee.target, arguments);};d.func=b;d.target=a;d.isDelegate=true;c[b.$fk]=d;}return d;}}
if(typeof(JsTypes)=='undefined')  JsTypes = [];
JsTypes.push(
{
	isEnum : false,
	definition : {
	}
	,
	staticDefinition : {
	}
	,
	baseType : null,
	customAttributes : [],
	interfaceNames : [],
	assemblyName : "SharpKit.JsClr",
	fullname : "System.Runtime.Serialization.IExtensibleDataObject",
	baseTypeName : "System.Object",
	isInterface : true,
	isDelegate : false,
	isValueType : false,
	isPartial : false}
)
if(typeof(JsTypes)=='undefined')  JsTypes = [];
JsTypes.push(
{
	isEnum : false,
	definition : {
		ctor : 
		function()
{
    System.Object.ctor.call(this);
}}
	,
	staticDefinition : {
		IsStatic : 
		function(pi)
{
    return pi._IsStatic;
},IsPublic : 
		function(pi)
{
    throw new Error('Not Implemented');
}}
	,
	baseType : null,
	customAttributes : [],
	interfaceNames : [],
	assemblyName : "SharpKit.JsClr",
	fullname : "SharpKit.PropertyInfoExtensions",
	baseTypeName : "System.Object",
	isInterface : false,
	isDelegate : false,
	isValueType : false,
	isPartial : false}
)
if(typeof(JsTypes)=='undefined')  JsTypes = [];
JsTypes.push(
{
	isEnum : false,
	definition : {
		ctor : 
		function()
{
    System.Object.ctor.call(this);
}}
	,
	staticDefinition : {
		GetValueOrDefaultIfNullOrEmpty : 
		function(s, defaultValue)
{
    if(s==null || s.length==0) return defaultValue; return s;
},IsNullOrEmpty$$String : 
		function(s)
{
    return s == null || s.length == 0;
},IsNotNullOrEmpty$$String : 
		function(s)
{
    return s != null && s.length > 0;
},HtmlEscape : 
		function(s)
{
    return s.Replace$$String$$String("&", "&amp;").Replace$$String$$String("<", "&lt;").Replace$$String$$String(">", "&gt;").Replace$$String$$String("\n", "<br/>");
},ReplaceFirst$$String$$String$$String : 
		function(s, search, replace)
{
    return s.ReplaceFirst(search, replace);
},ReplaceFirst$$String$$String$$String$$StringComparison : 
		function(s, search, replace, comparisonType)
{
    var index = s.IndexOf$$String$$StringComparison(search, comparisonType);
    if (index != -1)
    {
        var finalStr = System.String.Concat$$String$$String$$String(s.Substring$$Int32$$Int32(0, index), replace, s.Substring$$Int32(search.get_Length() + index));
        return finalStr;
    }
    return s;
},FixCamelCasing : 
		function(s)
{
    var sb = new System.Text.StringBuilder.ctor();
    var first = true;
    var $it12 = s.GetEnumerator();
    while ($it12.MoveNext())
    {
        var c = $it12.get_Current();
        if (System.Char.IsUpper$$Char(c) && !first)
        {
            sb.Append$$Char(' ');
        }
        sb.Append$$Char(c);
        first = false;
    }
    return sb.ToString();
},RemoveLast : 
		function(s, count)
{
    return s.substr(s, s.length-count);
},TrimEnd : 
		function(s, trimText)
{
    if (s.EndsWith$$String(trimText))
        return SharpKit.Extensions2.RemoveLast(s, trimText.get_Length());
    return s;
},EqualsIgnoreCase : 
		function(s1, s2)
{
    return System.String.Compare$$String$$String$$Boolean(s1, s2, true) == 0;
}}
	,
	baseType : null,
	customAttributes : [],
	interfaceNames : [],
	assemblyName : "SharpKit.JsClr",
	fullname : "SharpKit.Extensions2",
	baseTypeName : "System.Object",
	isInterface : false,
	isDelegate : false,
	isValueType : false,
	isPartial : false}
)
if(typeof(JsTypes)=='undefined')  JsTypes = [];
JsTypes.push(
{
	isEnum : false,
	definition : {
		ctor : 
		function()
{
    System.Object.ctor.call(this);
}}
	,
	staticDefinition : {
		escape : 
		function(s)
{
    return escape(s);
},ToJsFunction : 
		function(del)
{
    return del._ToJsFunction();
},JsEquals : 
		function(obj, value)
{
    return obj==value;
},JsExactEqualsToUndefined : 
		function(obj)
{
    return obj===undefined;
},JsExactEquals : 
		function(obj, value)
{
    return obj===value;
},Typeof : 
		function(obj)
{
    return typeof(obj);
},ApplyFunction : 
		function(func, thisArg, prms)
{
    throw new System.NotImplementedException.ctor$$String("TODO: Implement");
},CallFunction : 
		function(func, thisArg, prms)
{
    throw new System.NotImplementedException.ctor$$String("TODO: Implement");
},CallFunction2 : 
		function(obj, funcName, prms)
{
    return obj[funcName].apply(obj, Arguments.from(arguments, 2));
},CreateDelegate : 
		function(obj, func)
{
    return new System.MulticastDelegate.ctor(obj, func);
},CreateInstanceDelegate$$Object$$String : 
		function(obj, funcName)
{
    var jsObj = obj;
    if (jsObj == null || funcName == null || jsObj[funcName] == null)
        throw new System.Exception.ctor$$String("CreateInstanceDelegate error");
    return new System.MulticastDelegate.ctor(jsObj, jsObj[funcName]);
},CreateInstanceDelegate$$Object$$String$$Boolean : 
		function(obj, funcName, findOverloadedMethod)
{
    var jsObj = obj;
    if (jsObj == null || funcName == null)
        throw new System.Exception.ctor$$String("CreateInstanceDelegate error");
    if (jsObj[funcName] == null && findOverloadedMethod)
    {
        var overloadedFuncName = SharpKit.JavaScript.Utils.Js.FindOverloadedMethodName(obj, funcName);
        if (overloadedFuncName == null)
            throw new System.Exception.ctor$$String("CreateInstanceDelegate error");
        else
            funcName = overloadedFuncName;
    }
    if (jsObj[funcName] == null)
        throw new System.Exception.ctor$$String("CreateInstanceDelegate error");
    return new System.MulticastDelegate.ctor(jsObj, jsObj[funcName]);
},FindOverloadedMethodName : 
		function(obj, funcName)
{
    funcName+='$$';for(var o in obj)
if (typeof(obj[o])=='function' && o.indexOf(funcName)==0) 
	return o; 
return null;
},Eval : 
		function(code)
{
    eval(code)
},Compile : 
		function()
{
    throw new System.NotImplementedException.ctor();
},GetHashKey : 
		function(key)
{
    return GetHashKey(key);
},DeleteMember : 
		function(obj, name)
{
    delete obj[name];
},parseFloat : 
		function(s)
{
    return parseFloat(s);
},parseInt : 
		function(s)
{
    return parseInt(s);
},ApplyNew : 
		function(jsCtor, prms)
{
    if(prms==null || prms.length==0) return new jsCtor(); return new jsCtor(prms[0], prms[1], prms[2], prms[3], prms[4], prms[5], prms[6], prms[7], prms[8]);
},IsArray : 
		function(obj)
{
    return obj instanceof Array;
},isNaN : 
		function(obj)
{
    return isNaN(obj);
},decodeURIComponent : 
		function(encodedURIString)
{
    return decodeURIComponent(encodedURIString)
},encodeURIComponent : 
		function(encodedURIString)
{
    return encodeURIComponent(encodedURIString)
},encodeURI : 
		function(URIString)
{
    return encodeURI(URIString)
},decodeURI : 
		function(URIString)
{
    return decodeURI(URIString)
},unescape : 
		function(s)
{
    return unescape(s)
},undefined : 
		null}
	,
	baseType : null,
	customAttributes : [],
	interfaceNames : [],
	assemblyName : "SharpKit.JsClr",
	fullname : "SharpKit.JavaScript.Utils.Js",
	baseTypeName : "System.Object",
	isInterface : false,
	isDelegate : false,
	isValueType : false,
	isPartial : false}
)
if(typeof(JsTypes)=='undefined')  JsTypes = [];
JsTypes.push(
{
	isEnum : false,
	definition : {
		ctor : 
		function()
{
    System.Object.ctor.call(this);
}}
	,
	staticDefinition : {
		JsFunctionNameToClrMethodName : 
		function(jsFuncName)
{
    var methodName = jsFuncName;
    var di = jsFuncName.IndexOf$$Char('$');
    if (di > 0)
        methodName = jsFuncName.Substring$$Int32$$Int32(0, di);
    return methodName;
},ClrTypeToJsTypeRef : 
		function(type)
{
    var att = System.Linq.Enumerable.FirstOrDefault$$IEnumerable$1("SharpKit.JavaScript.JsTypeAttribute", System.Linq.Enumerable.OfType("SharpKit.JavaScript.JsTypeAttribute", type.GetCustomAttributes$$Type$$Boolean(Typeof(SharpKit.JavaScript.JsTypeAttribute), false)));
    if (att != null && SharpKit.Extensions2.IsNotNullOrEmpty$$String(att.get_Name()))
    {
        return att.get_Name().Replace$$Char$$Char('`', '$');
    }
    return type.get_Namespace() + "." + type.get_Name().Replace$$Char$$Char('`', '$');
},ClrConstructorToJsFunctionName : 
		function(mi)
{
    var sb = new System.Text.StringBuilder.ctor();
    var typeRef = SharpKit.JavaScript.JsNamingHelper.ClrTypeToJsTypeRef(mi.get_DeclaringType());
    sb.Append$$String(typeRef);
    sb.Append$$String(".ctor");
    SharpKit.JavaScript.JsNamingHelper.ConvertParametersToJsFunctionName(mi.GetParameters(), sb);
    return sb.ToString();
},ConvertParametersToJsFunctionName : 
		function(prms, sb)
{
    var $it13 = prms.GetEnumerator();
    while ($it13.MoveNext())
    {
        var prm = $it13.get_Current();
        sb.Append$$String("$$");
        sb.Append$$String(prm.get_ParameterType().get_Name());
    }
},ClrMethodBaseToJsFunctionName : 
		function(mi)
{
    if (mi.get_MemberType() == 1)
    {
        return SharpKit.JavaScript.JsNamingHelper.ClrMethodToJsFunctionName(Cast(mi, "System.Reflection.MethodInfo"));
    }
    else if (mi.get_MemberType() == 8)
    {
        return SharpKit.JavaScript.JsNamingHelper.ClrConstructorToJsFunctionName(Cast(mi, "System.Reflection.ConstructorInfo"));
    }
    else
        throw new System.NotImplementedException.ctor();
},ClrMethodToJsFunctionName : 
		function(mi)
{
    if (SharpKit.JavaScript.JsNamingHelper.IsPropertySetter(mi))
    {
        return mi.get_Name();
    }
    var name = mi.get_Name();
    var type = mi.get_DeclaringType();
    if (type.get_IsGenericType())
    {
        type = type.GetGenericTypeDefinition();
        mi = type.GetMethod$$String(name);
    }
    var sb = new System.Text.StringBuilder.ctor();
    if (mi.get_IsStatic())
    {
        sb.Append$$String(SharpKit.JavaScript.JsNamingHelper.ClrTypeToJsTypeRef(type));
        var att = System.Linq.Enumerable.FirstOrDefault$$IEnumerable$1("SharpKit.JavaScript.JsTypeAttribute", System.Linq.Enumerable.OfType("SharpKit.JavaScript.JsTypeAttribute", type.GetCustomAttributes$$Type$$Boolean(Typeof(SharpKit.JavaScript.JsTypeAttribute), false)));
        if (att == null || att.get_Mode() == 2)
        {
            sb.Append$$String(".staticDefinition.");
        }
        else
        {
            sb.Append$$String(".");
        }
    }
    sb.Append$$String(name);
    SharpKit.JavaScript.JsNamingHelper.ConvertParametersToJsFunctionName(mi.GetParameters(), sb);
    return sb.ToString();
},IsPropertySetter : 
		function(mi)
{
    var name = mi.get_Name();
    return name.StartsWith$$String("set_") && mi.GetParameters().get_Length() == 1;
}}
	,
	baseType : null,
	customAttributes : [],
	interfaceNames : [],
	assemblyName : "SharpKit.JsClr",
	fullname : "SharpKit.JavaScript.JsNamingHelper",
	baseTypeName : "System.Object",
	isInterface : false,
	isDelegate : false,
	isValueType : false,
	isPartial : false}
)
