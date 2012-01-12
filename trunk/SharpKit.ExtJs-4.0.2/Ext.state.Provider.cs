//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.state
namespace Ext.state
{
    #region Provider
    /// <summary>
    /// Abstract base class for state provider implementations. The provider is responsible
    /// for setting values  and extracting values to/from the underlying storage source. The
    /// storage source can vary and the details should be implemented in a subclass. For example
    /// a provider could use a server side database or the browser localstorage where supported. This class provides methods for encoding and decoding typed variables including
    /// dates and defines the Provider interface. By default these methods put the value and the
    /// type information into a delimited string that can be stored. These should be overridden in
    /// a subclass if you want to change the format of the encoded value and subsequent decoding.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Provider : Ext.Base, Ext.util.Observable
    {
        /// <summary>
        /// Adds the specified events to the list of events which this Observable may fire. ...
        /// </summary>
        public object addEvents(object o, JsString more){return null;}
        /// <summary>
        /// Appends an event handler to this object. ...
        /// </summary>
        public object addListener(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Adds listeners to any Observable object (or Element) which are automatically removed when this Component is
        /// destroyed. ...
        /// </summary>
        public object addManagedListener(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Clears a value from the state ...
        /// </summary>
        public object clear(JsString name){return null;}
        /// <summary>
        /// Removes all listeners for this object including the managed listeners ...
        /// </summary>
        public object clearListeners(){return null;}
        /// <summary>
        /// Removes all managed listeners for this object. ...
        /// </summary>
        public object clearManagedListeners(){return null;}
        /// <summary>
        /// Decodes a string previously encoded with encodeValue. ...
        /// </summary>
        public object decodeValue(JsString value){return null;}
        /// <summary>
        /// Enables events fired by this Observable to bubble up an owner hierarchy by calling this.getBubbleTarget() if
        /// present. ...
        /// </summary>
        public object enableBubble(object events){return null;}
        /// <summary>
        /// Encodes a value including type information. ...
        /// </summary>
        public JsString encodeValue(object value){return null;}
        /// <summary>
        /// Fires the specified event with the passed parameters (minus the event name, plus the options object passed
        /// to addList...
        /// </summary>
        public bool fireEvent(JsString eventName, object args){return false;}
        /// <summary>
        /// Returns the current value for a key ...
        /// </summary>
        public object get(JsString name, object defaultValue){return null;}
        /// <summary>
        /// Checks to see if this object has any listeners for a specified event ...
        /// </summary>
        public bool hasListener(JsString eventName){return false;}
        /// <summary>
        /// Shorthand for addManagedListener. ...
        /// </summary>
        public object mon(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Shorthand for removeManagedListener. ...
        /// </summary>
        public object mun(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Shorthand for addListener. ...
        /// </summary>
        public object on(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Relays selected events from the specified Observable as if the events were fired by this. ...
        /// </summary>
        public object relayEvents(object origin, JsString events, object prefix){return null;}
        /// <summary>
        /// Removes an event handler. ...
        /// </summary>
        public object removeListener(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Removes listeners that were added by the mon method. ...
        /// </summary>
        public object removeManagedListener(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Resumes firing events (see suspendEvents). ...
        /// </summary>
        public object resumeEvents(){return null;}
        /// <summary>
        /// Sets the value for a key ...
        /// </summary>
        public object set(JsString name, object value){return null;}
        /// <summary>
        /// Suspends the firing of all events. ...
        /// </summary>
        public object suspendEvents(bool queueSuspended){return null;}
        /// <summary>
        /// Shorthand for removeListener. ...
        /// </summary>
        public object un(JsString eventName, JsAction handler, object scope=null){return null;}
        public Provider(Ext.state.ProviderConfig config){}
        public Provider(){}
    }
    #endregion
    #region ProviderConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ProviderConfig : Ext.BaseConfig
    {
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public object listeners{get;set;}
        /// <summary>
        /// A string to prefix to items stored in the underlying state store. ...
        /// </summary>
        public JsString prefix{get;set;}
    }
    #endregion
    #region ProviderEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ProviderEvents : Ext.BaseEvents
    {
        /// <summary>
        /// Fires when a state change occurs. ...
        /// </summary>
        public static JsString statechange="statechange";
    }
    #endregion
}
#endregion