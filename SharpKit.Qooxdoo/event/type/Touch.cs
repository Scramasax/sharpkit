// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.eventx.type
{
    /// <summary>
	/// <para>EXPERIMENTAL &#8211; NOT READY FOR PRODUCTION</para>
	/// <para>Touch event object.</para>
	/// <para>For more information see:
	/// http://developer.apple.com/safari/library/documentation/UserExperience/Reference/TouchEventClassReference/TouchEvent/TouchEvent.html</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.event.type.Touch", OmitOptionalParameters = true, Export = false)]
    public partial class Touch : qx.eventx.type.Dom
    {
		#region Methods

		public Touch() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns an array of native Touch objects representing all current
		/// touches on the document.
		/// Returns an empty array for the &#8220;touchend&#8221; event.</para>
		/// </summary>
		/// <returns>Array of touch objects. For more information see: http://developer.apple.com/safari/library/documentation/UserExperience/Reference/TouchClassReference/Touch/Touch.html</returns>
		[JsMethod(Name = "getAllTouches")]
		public object GetAllTouches() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns an array of native Touch objects representing all touches of
		/// the target element that changed in this event.</para>
		/// <para>On the &#8220;touchstart&#8221; event the array contains all touches that were
		/// added to the target element.
		/// On the &#8220;touchmove&#8221; event the array contains all touches that were
		/// moved on the target element.
		/// On the &#8220;touchend&#8221; event the array contains all touches that used
		/// to be on the target element.</para>
		/// </summary>
		/// <returns>Array of touch objects. For more information see: http://developer.apple.com/safari/library/documentation/UserExperience/Reference/TouchClassReference/Touch/Touch.html</returns>
		[JsMethod(Name = "getChangedTargetTouches")]
		public object GetChangedTargetTouches() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the horizontal position at which the event occurred relative to the
		/// left of the document. This property takes into account any scrolling of
		/// the page.</para>
		/// </summary>
		/// <param name="touchIndex">The index of the Touch object</param>
		/// <returns>The horizontal position of the touch in the document.</returns>
		[JsMethod(Name = "getDocumentLeft")]
		public double GetDocumentLeft(double touchIndex = 0) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the vertical position at which the event occurred relative to the
		/// top of the document. This property takes into account any scrolling of
		/// the page.</para>
		/// </summary>
		/// <param name="touchIndex">The index of the Touch object</param>
		/// <returns>The vertical position of the touch in the document.</returns>
		[JsMethod(Name = "getDocumentTop")]
		public double GetDocumentTop(double touchIndex = 0) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the unique identifier for a certain touch object.</para>
		/// </summary>
		/// <param name="touchIndex">The index of the Touch object</param>
		/// <returns>Unique identifier of the touch object</returns>
		[JsMethod(Name = "getIdentifier")]
		public double GetIdentifier(double touchIndex = 0) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>iOS only: Returns the delta of the rotation since the start of the event, in degrees.
		/// Initial value is 0.0
		/// Clockwise > 0
		/// Counter-clockwise 
		/// </summary>
		/// <returns>The rotation delta</returns>
		[JsMethod(Name = "getRotation")]
		public double GetRotation() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>iOS only: Returns the distance between two fingers since the start of the event.
		/// The distance is a multiplier of the initial distance.
		/// Initial value: 1.0.
		/// Gestures:
		/// < 1.0, pinch close / zoom out.
		/// > 1.0, pinch open / to zoom in.</para>
		/// </summary>
		/// <returns>The scale distance between two fingers</returns>
		[JsMethod(Name = "getScale")]
		public double GetScale() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the horizontal coordinate at which the event occurred relative to
		/// the origin of the screen coordinate system.</para>
		/// </summary>
		/// <param name="touchIndex">The index of the Touch object</param>
		/// <returns>The horizontal position of the touch</returns>
		[JsMethod(Name = "getScreenLeft")]
		public double GetScreenLeft(double touchIndex = 0) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the vertical coordinate at which the event occurred relative to
		/// the origin of the screen coordinate system.</para>
		/// </summary>
		/// <param name="touchIndex">The index of the Touch object</param>
		/// <returns>The vertical position of the touch</returns>
		[JsMethod(Name = "getScreenTop")]
		public double GetScreenTop(double touchIndex = 0) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns an array of native Touch objects representing all touches
		/// associated with the event target element.
		/// Returns an empty array for the &#8220;touchend&#8221; event.</para>
		/// </summary>
		/// <returns>Array of touch objects. For more information see: http://developer.apple.com/safari/library/documentation/UserExperience/Reference/TouchClassReference/Touch/Touch.html</returns>
		[JsMethod(Name = "getTargetTouches")]
		public object GetTargetTouches() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the the horizontal coordinate at which the event occurred relative
		/// to the viewport.</para>
		/// </summary>
		/// <param name="touchIndex">The index of the Touch object</param>
		/// <returns>The horizontal position of the touch</returns>
		[JsMethod(Name = "getViewportLeft")]
		public double GetViewportLeft(double touchIndex = 0) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the vertical coordinate at which the event occurred relative
		/// to the viewport.</para>
		/// </summary>
		/// <param name="touchIndex">The index of the Touch object</param>
		/// <returns>The vertical position of the touch</returns>
		[JsMethod(Name = "getViewportTop")]
		public double GetViewportTop(double touchIndex = 0) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Checks whether more than one touch is associated with the event target
		/// element.</para>
		/// </summary>
		/// <returns>Is multi-touch</returns>
		[JsMethod(Name = "isMultiTouch")]
		public bool IsMultiTouch() { throw new NotImplementedException(); }

		[JsMethod(Name = "stop")]
		public void Stop() { throw new NotImplementedException(); }

		#endregion Methods
    }
}