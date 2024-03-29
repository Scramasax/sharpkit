// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.layout
{
    /// <summary>
	/// <para>Common set of utility methods used by the standard qooxdoo layouts.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.layout.Util", OmitOptionalParameters = true, Export = false)]
    public partial class Util 
    {
		#region Methods

		public Util() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Arranges two sizes in one box to best respect their individual limitations.</para>
		/// <para>Mainly used by split layouts (Split Panes) where the layout is mainly defined
		/// by the outer dimensions.</para>
		/// </summary>
		/// <param name="beginMin">Minimum size of first widget (from size hint)</param>
		/// <param name="beginIdeal">Ideal size of first widget (maybe after dragging the splitter)</param>
		/// <param name="beginMax">Maximum size of first widget (from size hint)</param>
		/// <param name="endMin">Minimum size of second widget (from size hint)</param>
		/// <param name="endIdeal">Ideal size of second widget (maybe after dragging the splitter)</param>
		/// <param name="endMax">Maximum size of second widget (from size hint)</param>
		/// <returns>Map with the keys beginend with the arranged dimensions.</returns>
		[JsMethod(Name = "arrangeIdeals")]
		public static object ArrangeIdeals(double beginMin, double beginIdeal, double beginMax, double endMin, double endIdeal, double endMax) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Collapses two margins.</para>
		/// <para>Supports positive and negative margins.
		/// Collapsing find the largest positive and the largest
		/// negative value. Afterwards the result is computed through the
		/// subtraction of the negative from the positive value.</para>
		/// </summary>
		/// <param name="varargs">Any number of configured margins</param>
		/// <returns>The collapsed margin</returns>
		[JsMethod(Name = "collapseMargins")]
		public static double CollapseMargins(JsArguments varargs) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the flex offsets needed to reduce the space
		/// difference as much as possible by respecting the
		/// potential of the given elements (being in the range of
		/// their min/max values)</para>
		/// </summary>
		/// <param name="flexibles">Each entry must have these keys: id, potential and flex. The ID is used in the result map as the key for the user to work with later (e.g. upgrade sizes etc. to respect the given offset) The potential is an integer value which is the difference of the currently interesting direction (e.g. shrinking=width-minWidth, growing= maxWidth-width). The flex key holds the flex value of the item.</param>
		/// <param name="avail">Full available space to allocate (ignoring used one)</param>
		/// <param name="used">Size of already allocated space</param>
		/// <returns>A map which contains the calculated offsets under the key which is identical to the ID given in the incoming map.</returns>
		[JsMethod(Name = "computeFlexOffsets")]
		public static object ComputeFlexOffsets(object flexibles, double avail, double used) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the offset which needs to be added to the top position
		/// to result in the stated vertical alignment. Also respects
		/// existing margins (without collapsing).</para>
		/// </summary>
		/// <param name="align">One of top, center or bottom.</param>
		/// <param name="width">The visible width of the widget</param>
		/// <param name="availWidth">The available inner width of the parent</param>
		/// <param name="marginLeft">Optional left margin of the widget</param>
		/// <param name="marginRight">Optional right margin of the widget</param>
		/// <returns>Computed top coordinate</returns>
		[JsMethod(Name = "computeHorizontalAlignOffset")]
		public static double ComputeHorizontalAlignOffset(string align, double width, double availWidth, double marginLeft = 0, double marginRight = 0) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the sum of all horizontal gaps. Normally the
		/// result is used to compute the available width in a widget.</para>
		/// <para>The method optionally respects margin collapsing as well. In
		/// this mode the spacing is collapsed together with the margins.</para>
		/// </summary>
		/// <param name="children">List of children</param>
		/// <param name="spacing">Spacing between every child</param>
		/// <param name="collapse">Optional margin collapsing mode</param>
		/// <returns>Sum of all gaps in the final layout.</returns>
		[JsMethod(Name = "computeHorizontalGaps")]
		public static double ComputeHorizontalGaps(JsArray children, double spacing = 0, bool collapse = false) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the gaps together with the configuration of separators.</para>
		/// </summary>
		/// <param name="children">List of children</param>
		/// <param name="spacing">Configured spacing</param>
		/// <param name="separator">Separator to render</param>
		/// <returns>Sum of gaps</returns>
		[JsMethod(Name = "computeHorizontalSeparatorGaps")]
		public static double ComputeHorizontalSeparatorGaps(qx.ui.core.LayoutItem children, double spacing, qx.html.Decorator separator) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the offset which needs to be added to the top position
		/// to result in the stated vertical alignment. Also respects
		/// existing margins (without collapsing).</para>
		/// </summary>
		/// <param name="align">One of top, middle or bottom.</param>
		/// <param name="height">The visible height of the widget</param>
		/// <param name="availHeight">The available inner height of the parent</param>
		/// <param name="marginTop">Optional top margin of the widget</param>
		/// <param name="marginBottom">Optional bottom margin of the widget</param>
		/// <returns>Computed top coordinate</returns>
		[JsMethod(Name = "computeVerticalAlignOffset")]
		public static double ComputeVerticalAlignOffset(string align, double height, double availHeight, double marginTop = 0, double marginBottom = 0) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the sum of all vertical gaps. Normally the
		/// result is used to compute the available height in a widget.</para>
		/// <para>The method optionally respects margin collapsing as well. In
		/// this mode the spacing is collapsed together with the margins.</para>
		/// </summary>
		/// <param name="children">List of children</param>
		/// <param name="spacing">Spacing between every child</param>
		/// <param name="collapse">Optional margin collapsing mode</param>
		/// <returns>Sum of all gaps in the final layout.</returns>
		[JsMethod(Name = "computeVerticalGaps")]
		public static double ComputeVerticalGaps(JsArray children, double spacing = 0, bool collapse = false) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the gaps together with the configuration of separators.</para>
		/// </summary>
		/// <param name="children">List of children</param>
		/// <param name="spacing">Configured spacing</param>
		/// <param name="separator">Separator to render</param>
		/// <returns>Sum of gaps</returns>
		[JsMethod(Name = "computeVerticalSeparatorGaps")]
		public static double ComputeVerticalSeparatorGaps(qx.ui.core.LayoutItem children, double spacing, qx.html.Decorator separator) { throw new NotImplementedException(); }

		#endregion Methods
    }
}