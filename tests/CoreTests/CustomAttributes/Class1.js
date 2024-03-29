
if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var SharpKitWebApp5$DependencyAttribute = {
    fullname: "SharpKitWebApp5.DependencyAttribute",
    baseTypeName: "System.Attribute",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition: {
        ctor: function (){
            this._Name = null;
            this._Type = null;
            System.Attribute.ctor.call(this);
        },
        Name$$: "System.String",
        get_Name: function (){
            return this._Name;
        },
        set_Name: function (value){
            this._Name = value;
        },
        ctor$$String: function (name){
            this._Name = null;
            this._Type = null;
            System.Attribute.ctor.call(this);
            this.set_Name(name);
        },
        Type$$: "System.Type",
        get_Type: function (){
            return this._Type;
        },
        set_Type: function (value){
            this._Type = value;
        }
    }
};
JsTypes.push(SharpKitWebApp5$DependencyAttribute);
var SharpKitWebApp5$MyTest = {
    fullname: "SharpKitWebApp5.MyTest",
    baseTypeName: "System.Object",
    assemblyName: "CoreTests",
    customAttributes: [{
        targetType: "property",
        targetMemberName: "DateProvider",
        typeName: "SharpKitWebApp5.DependencyAttribute",
        ctorName: "ctor"
    }, {
        targetType: "property",
        targetMemberName: "DateProvider3",
        typeName: "SharpKitWebApp5.DependencyAttribute",
        ctorName: "ctor",
        namedArguments: {
            Name: "XX",
            Type: function (){
                return Typeof(System.String.ctor);
            }
        }
    }, {
        targetType: "property",
        targetMemberName: "DateProvider2",
        typeName: "SharpKitWebApp5.DependencyAttribute",
        ctorName: "ctor$$String",
        positionalArguments: ["XX"]
    }
    ],
    Kind: "Class",
    definition: {
        ctor: function (){
            this._DateProvider = null;
            this._DateProvider3 = null;
            this._DateProvider2 = null;
            System.Object.ctor.call(this);
        },
        DateProvider$$: "System.Object",
        get_DateProvider: function (){
            return this._DateProvider;
        },
        set_DateProvider: function (value){
            this._DateProvider = value;
        },
        DateProvider3$$: "System.Object",
        get_DateProvider3: function (){
            return this._DateProvider3;
        },
        set_DateProvider3: function (value){
            this._DateProvider3 = value;
        },
        DateProvider2$$: "System.Object",
        get_DateProvider2: function (){
            return this._DateProvider2;
        },
        set_DateProvider2: function (value){
            this._DateProvider2 = value;
        }
    }
};
JsTypes.push(SharpKitWebApp5$MyTest);

