//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_.DD_
{
    /// <summary>
    /// Base scroller class used to create the Plugin.DDNodeScroll and Plugin.DDWinScroll.
    /// This class should not be called on it's own, it's designed to be a plugin.
    /// </summary>
    public partial class Scroll : Y_.Base
    {
        [JsMethod(JsonInitializers=true)]
        public Scroll(){}
        /// <summary>
        /// Called from the drag:align event to determine if we need to scroll.
        /// </summary>
        public void align(){}
        /// <summary>
        /// Called from the drag:end event
        /// </summary>
        public void end(){}
        /// <summary>
        /// Called from the drag:start event
        /// </summary>
        public void start(){}
        /// <summary>
        /// The number of pixels from the edge of the screen to turn on scrolling. Default: 30
        /// </summary>
        public Y_.DataType_.Number buffer{get;set;}
        /// <summary>
        /// The host we are plugged into.
        /// </summary>
        public object host{get;set;}
        /// <summary>
        /// Internal config option to hold the node that we are scrolling. Should not be set by the developer.
        /// </summary>
        public Node parentScroll{get;set;}
        /// <summary>
        /// The number of milliseconds delay to pass to the auto scroller. Default: 235
        /// </summary>
        public Y_.DataType_.Number scrollDelay{get;set;}
    }
}
