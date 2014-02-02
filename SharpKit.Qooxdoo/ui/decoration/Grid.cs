// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.decoration
{
    /// <summary>
	/// <para>A very complex decoration using two, partly combined and clipped images
	/// to render a graphically impressive borders with gradients.</para>
	/// <para>The decoration supports all forms of vertical gradients. The gradients must
	/// be stretchable to support different heights.</para>
	/// <para>The edges could use different styles of rounded borders. Even different
	/// edge sizes are supported. The sizes are automatically detected by
	/// the build system using the image meta data.</para>
	/// <para>The decoration uses clipped images to reduce the number of external
	/// resources to load.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.decoration.Grid", OmitOptionalParameters = true, Export = false)]
    public partial class Grid : qx.core.Object, qx.ui.decoration.IDecorator
    {
		#region Properties

		/// <summary>
		/// <para>Base image URL. There must be an image with this name and the sliced
		/// and the nine sliced images. The sliced images must be named according to
		/// the following scheme:</para>
		/// <para>${baseImageWithoutExtension}-${imageName}.${baseImageExtension}</para>
		/// <para>These image names are used:</para>
		/// <list type="bullet">
		/// <item>tl (top-left edge)</item>
		/// <item>t (top side)</item>
		/// <item>tr (top-right edge)</item>
		/// </list
		/// <list type="bullet">
		/// <item>bl (bottom-left edge)</item>
		/// <item>b (bottom side)</item>
		/// <item>br (bottom-right edge)</item>
		/// </list
		/// <list type="bullet">
		/// <item>l (left side)</item>
		/// <item>c (center image)</item>
		/// <item>r (right side)</item>
		/// </list
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "baseImage", NativeField = true)]
		public string BaseImage { get; set; }

		/// <summary>
		/// <para>Only used for the CSS3 implementation, see <see cref="qx.ui.decoration.css3.BorderImage.Fill"/> *</para>
		/// </summary>
		[JsProperty(Name = "fill", NativeField = true)]
		public object Fill { get; set; }

		/// <summary>
		/// <para>Width of the bottom inset (keep this margin to the outer box)</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "insetBottom", NativeField = true)]
		public double InsetBottom { get; set; }

		/// <summary>
		/// <para>Width of the left inset (keep this margin to the outer box)</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "insetLeft", NativeField = true)]
		public double InsetLeft { get; set; }

		/// <summary>
		/// <para>Width of the right inset (keep this margin to the outer box)</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "insetRight", NativeField = true)]
		public double InsetRight { get; set; }

		/// <summary>
		/// <para>Property group for insets</para>
		/// </summary>
		[JsProperty(Name = "insets", NativeField = true)]
		public object Insets { get; set; }

		/// <summary>
		/// <para>Width of the top inset (keep this margin to the outer box)</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "insetTop", NativeField = true)]
		public double InsetTop { get; set; }

		/// <summary>
		/// <para>Width of the bottom slice</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "sliceBottom", NativeField = true)]
		public double SliceBottom { get; set; }

		/// <summary>
		/// <para>Width of the left slice</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "sliceLeft", NativeField = true)]
		public double SliceLeft { get; set; }

		/// <summary>
		/// <para>Width of the right slice</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "sliceRight", NativeField = true)]
		public double SliceRight { get; set; }

		/// <summary>
		/// <para>Property group for slices</para>
		/// </summary>
		[JsProperty(Name = "slices", NativeField = true)]
		public object Slices { get; set; }

		/// <summary>
		/// <para>Width of the top slice</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "sliceTop", NativeField = true)]
		public double SliceTop { get; set; }

		#endregion Properties

		#region Methods

		public Grid() { throw new NotImplementedException(); }

		/// <param name="baseImage">Base image to use</param>
		/// <param name="insets">Insets for the grid</param>
		public Grid(string baseImage, object insets) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property baseImage.</para>
		/// </summary>
		[JsMethod(Name = "getBaseImage")]
		public string GetBaseImage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property fill.</para>
		/// </summary>
		[JsMethod(Name = "getFill")]
		public object GetFill() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property insetBottom.</para>
		/// </summary>
		[JsMethod(Name = "getInsetBottom")]
		public double GetInsetBottom() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property insetLeft.</para>
		/// </summary>
		[JsMethod(Name = "getInsetLeft")]
		public double GetInsetLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property insetRight.</para>
		/// </summary>
		[JsMethod(Name = "getInsetRight")]
		public double GetInsetRight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the amount of space, the decoration needs for its border on each
		/// side.</para>
		/// </summary>
		/// <returns>the desired insed a map with the keys top, right, bottom, left.</returns>
		[JsMethod(Name = "getInsets")]
		public object GetInsets() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property insetTop.</para>
		/// </summary>
		[JsMethod(Name = "getInsetTop")]
		public double GetInsetTop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the basic markup structure used for this decoration.
		/// This later updated on DOM to resize or tint the element.</para>
		/// </summary>
		/// <returns>Basic markup</returns>
		[JsMethod(Name = "getMarkup")]
		public string GetMarkup() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property sliceBottom.</para>
		/// </summary>
		[JsMethod(Name = "getSliceBottom")]
		public double GetSliceBottom() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property sliceLeft.</para>
		/// </summary>
		[JsMethod(Name = "getSliceLeft")]
		public double GetSliceLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property sliceRight.</para>
		/// </summary>
		[JsMethod(Name = "getSliceRight")]
		public double GetSliceRight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property sliceTop.</para>
		/// </summary>
		[JsMethod(Name = "getSliceTop")]
		public double GetSliceTop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property baseImage
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property baseImage.</param>
		[JsMethod(Name = "initBaseImage")]
		public void InitBaseImage(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property fill
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property fill.</param>
		[JsMethod(Name = "initFill")]
		public void InitFill(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property insetBottom
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property insetBottom.</param>
		[JsMethod(Name = "initInsetBottom")]
		public void InitInsetBottom(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property insetLeft
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property insetLeft.</param>
		[JsMethod(Name = "initInsetLeft")]
		public void InitInsetLeft(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property insetRight
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property insetRight.</param>
		[JsMethod(Name = "initInsetRight")]
		public void InitInsetRight(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property insetTop
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property insetTop.</param>
		[JsMethod(Name = "initInsetTop")]
		public void InitInsetTop(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property sliceBottom
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property sliceBottom.</param>
		[JsMethod(Name = "initSliceBottom")]
		public void InitSliceBottom(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property sliceLeft
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property sliceLeft.</param>
		[JsMethod(Name = "initSliceLeft")]
		public void InitSliceLeft(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property sliceRight
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property sliceRight.</param>
		[JsMethod(Name = "initSliceRight")]
		public void InitSliceRight(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property sliceTop
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property sliceTop.</param>
		[JsMethod(Name = "initSliceTop")]
		public void InitSliceTop(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property baseImage.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBaseImage")]
		public void ResetBaseImage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property fill.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetFill")]
		public void ResetFill() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property insetBottom.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetInsetBottom")]
		public void ResetInsetBottom() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property insetLeft.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetInsetLeft")]
		public void ResetInsetLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property insetRight.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetInsetRight")]
		public void ResetInsetRight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property insets.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetInsets")]
		public void ResetInsets() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property insetTop.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetInsetTop")]
		public void ResetInsetTop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property sliceBottom.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSliceBottom")]
		public void ResetSliceBottom() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property sliceLeft.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSliceLeft")]
		public void ResetSliceLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property sliceRight.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSliceRight")]
		public void ResetSliceRight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property slices.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSlices")]
		public void ResetSlices() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property sliceTop.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSliceTop")]
		public void ResetSliceTop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resizes the element respecting the configured borders
		/// to the given width and height. Should automatically
		/// respect the box model of the client to correctly
		/// compute the dimensions.</para>
		/// </summary>
		/// <param name="element">The element to update</param>
		/// <param name="width">Width of the element</param>
		/// <param name="height">Height of the element</param>
		[JsMethod(Name = "resize")]
		public void Resize(qx.html.Element element, double width, double height) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property baseImage.</para>
		/// </summary>
		/// <param name="value">New value for property baseImage.</param>
		[JsMethod(Name = "setBaseImage")]
		public void SetBaseImage(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property fill.</para>
		/// </summary>
		/// <param name="value">New value for property fill.</param>
		[JsMethod(Name = "setFill")]
		public void SetFill(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property insetBottom.</para>
		/// </summary>
		/// <param name="value">New value for property insetBottom.</param>
		[JsMethod(Name = "setInsetBottom")]
		public void SetInsetBottom(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property insetLeft.</para>
		/// </summary>
		/// <param name="value">New value for property insetLeft.</param>
		[JsMethod(Name = "setInsetLeft")]
		public void SetInsetLeft(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property insetRight.</para>
		/// </summary>
		/// <param name="value">New value for property insetRight.</param>
		[JsMethod(Name = "setInsetRight")]
		public void SetInsetRight(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the values of the property group insets.</para>
		/// <para>This setter supports a shorthand mode compatible with the way margins and paddins are set in CSS.</para>
		/// </summary>
		/// <param name="insetTop">Sets the value of the property #insetTop.</param>
		/// <param name="insetRight">Sets the value of the property #insetRight.</param>
		/// <param name="insetBottom">Sets the value of the property #insetBottom.</param>
		/// <param name="insetLeft">Sets the value of the property #insetLeft.</param>
		[JsMethod(Name = "setInsets")]
		public void SetInsets(object insetTop, object insetRight, object insetBottom, object insetLeft) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property insetTop.</para>
		/// </summary>
		/// <param name="value">New value for property insetTop.</param>
		[JsMethod(Name = "setInsetTop")]
		public void SetInsetTop(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property sliceBottom.</para>
		/// </summary>
		/// <param name="value">New value for property sliceBottom.</param>
		[JsMethod(Name = "setSliceBottom")]
		public void SetSliceBottom(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property sliceLeft.</para>
		/// </summary>
		/// <param name="value">New value for property sliceLeft.</param>
		[JsMethod(Name = "setSliceLeft")]
		public void SetSliceLeft(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property sliceRight.</para>
		/// </summary>
		/// <param name="value">New value for property sliceRight.</param>
		[JsMethod(Name = "setSliceRight")]
		public void SetSliceRight(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the values of the property group slices.</para>
		/// <para>This setter supports a shorthand mode compatible with the way margins and paddins are set in CSS.</para>
		/// </summary>
		/// <param name="sliceTop">Sets the value of the property #sliceTop.</param>
		/// <param name="sliceRight">Sets the value of the property #sliceRight.</param>
		/// <param name="sliceBottom">Sets the value of the property #sliceBottom.</param>
		/// <param name="sliceLeft">Sets the value of the property #sliceLeft.</param>
		[JsMethod(Name = "setSlices")]
		public void SetSlices(object sliceTop, object sliceRight, object sliceBottom, object sliceLeft) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property sliceTop.</para>
		/// </summary>
		/// <param name="value">New value for property sliceTop.</param>
		[JsMethod(Name = "setSliceTop")]
		public void SetSliceTop(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Applies the given background color to the element
		/// or fallback to the background color defined
		/// by the decoration itself.</para>
		/// </summary>
		/// <param name="element">The element to update</param>
		/// <param name="bgcolor">The color to apply or null</param>
		[JsMethod(Name = "tint")]
		public void Tint(qx.html.Element element, string bgcolor) { throw new NotImplementedException(); }

		#endregion Methods
    }
}