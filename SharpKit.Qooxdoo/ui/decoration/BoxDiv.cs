// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.decoration
{
    /// <summary>
	/// <para>Abstract base class for the HBox and VBox decorators.</para>
	/// <para>This decorator uses three images, which are positioned in a vertical/horizontal
	/// line. The first and last image always keep their original size. The center
	/// image is stretched.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.decoration.BoxDiv", OmitOptionalParameters = true, Export = false)]
    public partial class BoxDiv : qx.ui.decoration.Abstract
    {
		#region Properties

		/// <summary>
		/// <para>Base image URL. All the different images needed are named by the default
		/// naming scheme:</para>
		/// <para>${baseImageWithoutExtension}-${imageName}.${baseImageExtension}</para>
		/// <para>These image names are used:</para>
		/// <list type="bullet">
		/// <item>t: top side (vertical orientation)</item>
		/// <item>b: bottom side (vertical orientation)</item>
		/// </list
		/// <list type="bullet">
		/// <item>l: left side (horizontal orientation)</item>
		/// <item>r: right side (horizontal orientation)</item>
		/// </list
		/// <list type="bullet">
		/// <item>c: center image</item>
		/// </list
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "baseImage", NativeField = true)]
		public string BaseImage { get; set; }

		#endregion Properties

		#region Methods

		public BoxDiv() { throw new NotImplementedException(); }

		/// <param name="baseImage">Base image to use</param>
		/// <param name="insets">Insets for the grid</param>
		/// <param name="orientation">Vertical or horizontal orientation</param>
		public BoxDiv(string baseImage, object insets, string orientation) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property baseImage.</para>
		/// </summary>
		[JsMethod(Name = "getBaseImage")]
		public string GetBaseImage() { throw new NotImplementedException(); }

		[JsMethod(Name = "getMarkup")]
		public void GetMarkup() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property baseImage
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property baseImage.</param>
		[JsMethod(Name = "initBaseImage")]
		public void InitBaseImage(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property baseImage.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBaseImage")]
		public void ResetBaseImage() { throw new NotImplementedException(); }

		[JsMethod(Name = "resize")]
		public void Resize(object element, object width, object height) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property baseImage.</para>
		/// </summary>
		/// <param name="value">New value for property baseImage.</param>
		[JsMethod(Name = "setBaseImage")]
		public void SetBaseImage(string value) { throw new NotImplementedException(); }

		[JsMethod(Name = "tint")]
		public void Tint(object element, object bgcolor) { throw new NotImplementedException(); }

		#endregion Methods
    }
}