//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data.proxy
namespace Ext.data.proxy
{
    #region Direct
    /// <summary>
    /// This class is used to send requests to the server using Ext.direct. When a request is made,
    /// the transport mechanism is handed off to the appropriate Provider
    /// to complete the call. Specifying the function This proxy expects a Direct remoting method to be passed in order to be able to complete requests.
    /// This can be done by specifying the directFn configuration. This will use the same direct
    /// method for all requests. Alternatively, you can provide an api configuration. This
    /// allows you to specify a different remoting method for each CRUD action. Parameters This proxy provides options to help configure which parameters will be sent to the server.
    /// By specifying the paramsAsHash option, it will send an object literal containing each
    /// of the passed parameters. The paramOrder option can be used to specify the order in which
    /// the remoting method parameters are passed. Example Usage Ext.define(&#39;User&#39;, {
    /// extend: &#39;Ext.data.Model&#39;,
    /// fields: [&#39;firstName&#39;, &#39;lastName&#39;],
    /// proxy: {
    /// type: &#39;direct&#39;,
    /// directFn: MyApp.getUsers,
    /// paramOrder: &#39;id&#39; // Tells the proxy to pass the id as the first parameter to the remoting method.
    /// }
    /// });
    /// User.load(1);
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Direct : Server, Ext.util.Observable
    {
        public Direct(DirectConfig config){}
        public Direct(){}
    }
    #endregion
    #region DirectConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class DirectConfig : ServerConfig
    {
        public new object api{get;set;}
        /// <summary>
        /// Function to call when executing a request. ...
        /// </summary>
        public JsAction directFn{get;set;}
        /// <summary>
        /// Extra parameters that will be included on every read request. ...
        /// </summary>
        public new object extraParams{get;set;}
        /// <summary>
        /// Defaults to undefined. ...
        /// </summary>
        public object paramOrder{get;set;}
        /// <summary>
        /// Send parameters as a collection of named arguments (defaults to true). ...
        /// </summary>
        public bool paramsAsHash{get;set;}
    }
    #endregion
    #region DirectEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class DirectEvents : ServerEvents
    {
    }
    #endregion
}
#endregion
