// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.util
{
    /// <summary>
	/// <para>Base64 encoder</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.util.Base64", OmitOptionalParameters = true, Export = false)]
    public partial class Base64 
    {
		#region Methods

		public Base64() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Decode a base64 string (http://en.wikipedia.org/wiki/Base64).</para>
		/// </summary>
		/// <param name="input">the input string to decode</param>
		/// <param name="is8bit">Whether the character set is 8-bit, not multi-byte.  If this parameter is not provided, the character set is determined from the &#8216;document&#8217; object.</param>
		/// <returns>The decoded input string.</returns>
		[JsMethod(Name = "decode")]
		public static string Decode(string input, bool is8bit) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Encode a string using base64 encoding (http://en.wikipedia.org/wiki/Base64).</para>
		/// </summary>
		/// <param name="input">the input string to encode</param>
		/// <param name="is8bit">Whether the character set is 8-bit, not multi-byte.  If this parameter is not provided, the character set is determined from the &#8216;document&#8217; object.</param>
		/// <returns>The base64 encoded input string.</returns>
		[JsMethod(Name = "encode")]
		public static string Encode(string input, bool is8bit) { throw new NotImplementedException(); }

		#endregion Methods
    }
}