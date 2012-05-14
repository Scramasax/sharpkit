/*Generated by SharpKit 5 v4.26.6000*/
if(typeof(JsTypes) == "undefined")
    JsTypes = [];
var System$Text$StringBuilder=
{
    fullname:"System.Text.StringBuilder",
    baseTypeName:"System.Object",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            this.array = null;
            this.length = 0;
            System.Object.ctor.call(this);
            this.array = [];
            this.length = 0;
        },
        ctor$$String:function(s)
        {
            this.array = null;
            this.length = 0;
            System.Object.ctor.call(this);
            this.array = [s];
            this.length = s == null?0:s.length;
        },
        Append$$Char:function(s)
        {
            this.array.push(s);
            this.length += 1;
        },
        Append$$String:function(s)
        {
            this.array.push(s);
            this.length += s.length;
        },
        AppendFormat$$String$$Object:function(s,arg0)
        {
            var ss=System.String.Format$$String$$Object(s,arg0);
            this.array.push(ss);
            this.length += ss.length;
        },
        AppendFormat$$String$$Object$$Object:function(s,arg0,arg1)
        {
            var ss=System.String.Format$$String$$Object$$Object(s,arg0,arg1);
            this.array.push(ss);
            this.length += ss.length;
        },
        AppendFormat$$String$$Object$$Object$$Object:function(s,arg0,arg1,arg2)
        {
            var ss=System.String.Format$$String$$Object$$Object$$Object(s,arg0,arg1,arg2);
            this.array.push(ss);
            this.length += ss.length;
        },
        Append$$Object:function(obj)
        {
            if(obj != null)
            {
                var s=obj.toString();
                this.array.push(s);
                this.length += s.length;
            }
        },
        toString:function()
        {
            return this.array.join("");
        },
        Length$$:"System.Int32",
        get_Length:function()
        {
            return this.length;
        },
        set_Length:function(value)
        {
            if(value != 0)
                throw new System.Exception.ctor$$String("Not Implemented");
            this.array.Clear();
            this.length = value;
        },
        Remove:function(start,count)
        {
            var s=this.array.join("");
            s = s.Remove$$Int32$$Int32(start,count);
            this.array = [s];
            this.length = s.length;
            return this;
        }
    }
};
JsTypes.push(System$Text$StringBuilder);
