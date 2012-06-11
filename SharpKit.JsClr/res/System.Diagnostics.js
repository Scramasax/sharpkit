/*Generated by SharpKit 5 v4.27.9000*/
if(typeof(JsTypes) == "undefined")
    JsTypes = [];
var System$Diagnostics$Debugger=
{
    fullname:"System.Diagnostics.Debugger",
    baseTypeName:"System.Object",
    staticDefinition:
    {
        Break:function()
        {
            debugger;
        }
    },
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(System$Diagnostics$Debugger);
var System$Diagnostics$Trace=
{
    fullname:"System.Diagnostics.Trace",
    baseTypeName:"System.Object",
    staticDefinition:
    {
        cctor:function()
        {
            System.Diagnostics.Trace.Warnings = null;
            System.Diagnostics.Trace.Enabled = false;
        },
        TraceWarning$$String:function(msg)
        {
            if(!System.Diagnostics.Trace.Enabled)
                return;
            if(System.Diagnostics.Trace.Warnings == null)
                System.Diagnostics.Trace.Warnings = new System.Collections.Generic.List$1.ctor(System.String);
            System.Diagnostics.Trace.Warnings.Add(msg);
        },
        TraceWarning$$String$$Object$Array:function(format,args)
        {
            if(!System.Diagnostics.Trace.Enabled)
                return;
            System.Diagnostics.Trace.TraceWarning$$String(System.String.Format$$String$$Object$Array(format,args));
        }
    },
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(System$Diagnostics$Trace);
