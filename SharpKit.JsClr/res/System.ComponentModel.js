/* Generated by SharpKit 5 v5.4.5 */
"use strict";
if (typeof($CreateException)=='undefined') 
{
    var $CreateException = function(ex, error) 
    {
        if(error==null)
            error = new Error();
        if(ex==null)
            ex = new System.Exception.ctor();       
        error.message = ex.message;
        for (var p in ex)
           error[p] = ex[p];
        return error;
    }
}


if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var System$ComponentModel$ListSortDirection = {
    fullname: "System.ComponentModel.ListSortDirection",
    staticDefinition: {
        Ascending: 0,
        Descending: 1
    },
    Kind: "Enum"
};
JsTypes.push(System$ComponentModel$ListSortDirection);
var System$Math = {
    fullname: "System.Math",
    baseTypeName: "System.Object",
    staticDefinition: {
        cctor: function (){
            System.Math.PI = Math.PI;
        },
        Abs$$Number: function (value){
            return Math.abs(value);
        },
        Abs$$Double: function (value){
            return Math.abs(value);
        },
        Abs$$Int32: function (value){
            return Math.abs(value);
        },
        Abs$$Int64: function (value){
            return Math.abs(value);
        },
        Abs$$Single: function (value){
            return Math.abs(value);
        },
        AbsHelper$$Int16: function (value){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        AbsHelper$$Int32: function (value){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        AbsHelper$$Int64: function (value){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        AbsHelper$$SByte: function (value){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        Acos: function (d){
            return Math.acos(d);
        },
        Asin: function (d){
            return Math.asin(d);
        },
        Atan: function (d){
            return Math.atan(d);
        },
        Atan2: function (y, x){
            return Math.atan2(y, x);
        },
        BigMul: function (a, b){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        Ceiling$$Decimal: function (d){
            return Math.ceil(d);
        },
        Ceiling$$Double: function (a){
            return Math.ceil(a);
        },
        Cos: function (d){
            return Math.cos(d);
        },
        Cosh: function (value){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        Exp: function (d){
            return Math.exp(d);
        },
        Floor$$Decimal: function (d){
            return Math.floor(d);
        },
        Floor$$Double: function (d){
            return Math.floor(d);
        },
        IEEERemainder: function (x, y){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        InternalRound: function (value, digits, mode){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        InternalTruncate: function (d){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        Log$$Double: function (d){
            return Math.log(d);
        },
        Log$$Double$$Double: function (a, newBase){
            return Math.log(a) / Math.log(newBase);
        },
        Log10: function (d){
            return Math.log(d) / Math.LN10;
        },
        Max$$Decimal$$Decimal: function (val1, val2){
            return Math.max(val1, val2);
        },
        Max$$Double$$Double: function (val1, val2){
            return Math.max(val1, val2);
        },
        Max$$Int32$$Int32: function (val1, val2){
            return Math.max(val1, val2);
        },
        Max$$Int64$$Int64: function (val1, val2){
            return Math.max(val1, val2);
        },
        Max$$SByte$$SByte: function (val1, val2){
            return Math.max(val1, val2);
        },
        Max$$Single$$Single: function (val1, val2){
            return Math.max(val1, val2);
        },
        Max$$UInt32$$UInt32: function (val1, val2){
            return Math.max(val1, val2);
        },
        Max$$UInt64$$UInt64: function (val1, val2){
            return Math.max(val1, val2);
        },
        Min$$Decimal$$Decimal: function (val1, val2){
            return Math.min(val1, val2);
        },
        Min$$Double$$Double: function (val1, val2){
            return Math.min(val1, val2);
        },
        Min$$Int32$$Int32: function (val1, val2){
            return Math.min(val1, val2);
        },
        Min$$Int64$$Int64: function (val1, val2){
            return Math.min(val1, val2);
        },
        Min$$SByte$$SByte: function (val1, val2){
            return Math.min(val1, val2);
        },
        Min$$Single$$Single: function (val1, val2){
            return Math.min(val1, val2);
        },
        Min$$UInt32$$UInt32: function (val1, val2){
            return Math.min(val1, val2);
        },
        Min$$UInt64$$UInt64: function (val1, val2){
            return Math.min(val1, val2);
        },
        Pow: function (x, y){
            return Math.pow(x, y);
        },
        Round$$Decimal: function (d){
            return Math.round(d);
        },
        Round$$Double: function (a){
            return Math.round(a);
        },
        Round$$Decimal$$Int32: function (d, decimals){
            var pow = Math.pow(10, decimals);
            return Math.round(d * pow) / pow;
        },
        Round$$Decimal$$MidpointRounding: function (d, mode){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        Round$$Double$$Int32: function (value, digits){
            var pow = Math.pow(10, digits);
            return Math.round(value * pow) / pow;
        },
        Round$$Double$$MidpointRounding: function (value, mode){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        Round$$Decimal$$Int32$$MidpointRounding: function (d, decimals, mode){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        Round$$Double$$Int32$$MidpointRounding: function (value, digits, mode){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        Sign$$Decimal: function (value){
            if (value < 0.0)
                return -1;
            if (value > 0.0)
                return 1;
            if (value == 0.0)
                return 0;
            throw $CreateException(new System.ArgumentException.ctor$$String("value"), new Error());
        },
        Sign$$Double: function (value){
            if (value < 0)
                return -1;
            if (value > 0)
                return 1;
            if (value == 0)
                return 0;
            throw $CreateException(new System.ArgumentException.ctor$$String("value"), new Error());
        },
        Sign$$Int16: function (value){
            if (value < 0)
                return -1;
            if (value > 0)
                return 1;
            if (value == 0)
                return 0;
            throw $CreateException(new System.ArgumentException.ctor$$String("value"), new Error());
        },
        Sign$$Int32: function (value){
            if (value < 0)
                return -1;
            if (value > 0)
                return 1;
            if (value == 0)
                return 0;
            throw $CreateException(new System.ArgumentException.ctor$$String("value"), new Error());
        },
        Sign$$Int64: function (value){
            if (value < 0)
                return -1;
            if (value > 0)
                return 1;
            if (value == 0)
                return 0;
            throw $CreateException(new System.ArgumentException.ctor$$String("value"), new Error());
        },
        Sign$$SByte: function (value){
            if (value < 0)
                return -1;
            if (value > 0)
                return 1;
            if (value == 0)
                return 0;
            throw $CreateException(new System.ArgumentException.ctor$$String("value"), new Error());
        },
        Sign$$Single: function (value){
            if (value < 0)
                return -1;
            if (value > 0)
                return 1;
            if (value == 0)
                return 0;
            throw $CreateException(new System.ArgumentException.ctor$$String("value"), new Error());
        },
        Sin: function (a){
            return Math.sin(a);
        },
        Sinh: function (value){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        Sqrt: function (d){
            return Math.sqrt(d);
        },
        Tan: function (a){
            return Math.tan(a);
        },
        Tanh: function (value){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        Truncate$$Decimal: function (d){
            return d | 0;
        },
        Truncate$$Double: function (d){
            return d | 0;
        }
    },
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(System$Math);

