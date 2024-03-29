//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.util
{
    #region Event
    /// <summary>
    /// <p><strong>NOTE</strong> This is a private utility class for internal use by the framework. Don't rely on its existence.</p><p>Represents single event type that an Observable object listens to.
    /// All actual listeners are tracked inside here.  When the event fires,
    /// it calls all the registered listener functions.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Event
    {
        /// <summary>
        /// true in this class to identify an object as an instantiated Event, or subclass thereof.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool isEvent{get;set;}
        public Event(Ext.util.EventConfig config){}
        public Event(){}
        public Event(params object[] args){}
    }
    #endregion
    #region EventConfig
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class EventConfig
    {
        public EventConfig(params object[] args){}
    }
    #endregion
    #region EventEvents
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class EventEvents
    {
        public EventEvents(params object[] args){}
    }
    #endregion
}
