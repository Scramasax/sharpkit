// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.core;

namespace qx.dev.unit
{
    /// <summary>
	/// <para>Base class for all unit tests.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.dev.unit.TestCase", OmitOptionalParameters = true, Export = false)]
    public partial class TestCase : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>This event can be fired by assertion functions instead of throwing a
		/// <see cref="qx.core.AssertionError"/>, ensuring that any code defined after the
		/// assertion call will still run.</para>
		/// <para>Event data: The <see cref="qx.core.AssertionError"/></para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnAssertionFailed;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The test currently running</para>
		/// </summary>
		[JsProperty(Name = "testFunc", NativeField = true)]
		public object TestFunc { get; set; }

		/// <summary>
		/// <para>The TestResult instance that runs the test</para>
		/// </summary>
		[JsProperty(Name = "testResult", NativeField = true)]
		public object TestResult { get; set; }

		#endregion Properties

		#region Methods

		public TestCase() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property testFunc.</para>
		/// </summary>
		[JsMethod(Name = "getTestFunc")]
		public object GetTestFunc() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property testResult.</para>
		/// </summary>
		[JsMethod(Name = "getTestResult")]
		public object GetTestResult() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property testFunc
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property testFunc.</param>
		[JsMethod(Name = "initTestFunc")]
		public void InitTestFunc(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property testResult
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property testResult.</param>
		[JsMethod(Name = "initTestResult")]
		public void InitTestResult(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether If debugging code is enabled. (i.e. the setting
		/// qx.debug has the value on.)</para>
		/// </summary>
		/// <returns>Whether debugging is enabled</returns>
		[JsMethod(Name = "isDebugOn")]
		public bool IsDebugOn() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property testFunc.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTestFunc")]
		public void ResetTestFunc() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property testResult.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTestResult")]
		public void ResetTestResult() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Cancel a timeout started with wait() and run the given
		/// function. Used for asynchronous tests, e.g. in a listener&#8217;s callback
		/// function.</para>
		/// <para>Important</para>
		/// <para>The used deferredFunction is the last function which is executed before
		/// the whole test case is disposed. You have to make sure that this resume
		/// function is only used once in the whole test case.</para>
		/// </summary>
		/// <param name="deferredFunction">Function to run</param>
		/// <param name="self">reference to the &#8216;this&#8217; variable inside the callback. By default the test instance is used.</param>
		[JsMethod(Name = "resume")]
		public void Resume(Action<object> deferredFunction, object self) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property testFunc.</para>
		/// </summary>
		/// <param name="value">New value for property testFunc.</param>
		[JsMethod(Name = "setTestFunc")]
		public void SetTestFunc(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property testResult.</para>
		/// </summary>
		/// <param name="value">New value for property testResult.</param>
		[JsMethod(Name = "setTestResult")]
		public void SetTestResult(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Skip this test. Any code after a call to this method will not be executed.</para>
		/// </summary>
		/// <param name="message">Optional message (reason why the test was skipped)</param>
		[JsMethod(Name = "skip")]
		public void Skip(string message) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Instruct the test to wait. Used for asynchronous tests.</para>
		/// </summary>
		/// <param name="delay">Amount of time in milliseconds to wait.</param>
		/// <param name="deferredFunction">Optional function to run after timeout has expired.</param>
		/// <param name="context">Optional execution context for deferredFunction</param>
		[JsMethod(Name = "wait")]
		public void Wait(double delay = 5000, Action<object> deferredFunction = null, object context = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the condition evaluates to true.</para>
		/// </summary>
		/// <param name="condition">Condition to check for. Must evaluate to true.</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assert")]
		public void Assert(object condition, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the number of arguments is within the given range</para>
		/// </summary>
		/// <param name="args">The arguments variable of a function</param>
		/// <param name="minCount">Minimal number of arguments</param>
		/// <param name="maxCount">Maximum number of arguments</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertArgumentsCount")]
		public void AssertArgumentsCount(JsArguments args, double minCount, double maxCount, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is an array.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertArray")]
		public void AssertArray(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that both array have identical array items.</para>
		/// </summary>
		/// <param name="expected">The expected array</param>
		/// <param name="found">The found array</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertArrayEquals")]
		public void AssertArrayEquals(JsArray expected, JsArray found, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is a boolean.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertBoolean")]
		public void AssertBoolean(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value represents the given CSS color value. This method
		/// parses the color strings and compares the RGB values. It is able to
		/// parse values supported by <see cref="qx.util.ColorUtil.StringToRgb"/>.</para>
		/// </summary>
		/// <param name="expected">The expected color</param>
		/// <param name="value">The value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertCssColor")]
		public void AssertCssColor(string expected, string value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is a DOM element.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertElement")]
		public void AssertElement(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that both values are equal. (Uses the equality operator
		/// ==.)</para>
		/// </summary>
		/// <param name="expected">Reference value</param>
		/// <param name="found">found value</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertEquals")]
		public void AssertEquals(object expected, object found, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that an event is fired.</para>
		/// </summary>
		/// <param name="obj">The object on which the event should be fired.</param>
		/// <param name="eventx">The event which should be fired.</param>
		/// <param name="invokeFunc">The function which will be invoked and which fires the event.</param>
		/// <param name="listener">The function which will be invoked in the listener. The function has one parameter called e which is the event.</param>
		/// <param name="msg">Message to be shows if the assertion fails.</param>
		[JsMethod(Name = "assertEventFired")]
		public void AssertEventFired(object obj, string eventx, Action<object> invokeFunc, Action<qx.eventx.type.Data> listener = null, string msg = "") { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that an event is not fired.</para>
		/// </summary>
		/// <param name="obj">The object on which the event should be fired.</param>
		/// <param name="eventx">The event which should be fired.</param>
		/// <param name="invokeFunc">The function which will be invoked and which should not fire the event.</param>
		/// <param name="msg">Message to be shows if the assertion fails.</param>
		[JsMethod(Name = "assertEventNotFired")]
		public void AssertEventNotFired(object obj, string eventx, Action<object> invokeFunc, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Asserts that the callback raises a matching exception.</para>
		/// </summary>
		/// <param name="callback">function to check</param>
		/// <param name="exception">Expected constructor of the exception. The assertion fails if the raised exception is not an instance of the parameter.</param>
		/// <param name="re">The assertion fails if the error message does not match this parameter</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertException")]
		public void AssertException(Action<object> callback, JsError exception = null, object re = null, string msg = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is false (Identity check).</para>
		/// </summary>
		/// <param name="value">Condition to check for. Must be identical to false.</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertFalse")]
		public void AssertFalse(bool value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is a function.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertFunction")]
		public void AssertFunction(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that both values are identical. (Uses the identity operator
		/// ===.)</para>
		/// </summary>
		/// <param name="expected">Reference value</param>
		/// <param name="found">found value</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertIdentical")]
		public void AssertIdentical(object expected, object found, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is an item in the given array.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="array">List of valid values</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertInArray")]
		public void AssertInArray(object value, JsArray array, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is inside the given range.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="min">lower bound</param>
		/// <param name="max">upper bound</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertInRange")]
		public void AssertInRange(object value, double min, double max, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is an instance of the given class.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="clazz">The value must be an instance of this class</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertInstance")]
		public void AssertInstance(object value, Class clazz, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is an integer.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertInteger")]
		public void AssertInteger(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value implements the given interface.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="iface">The value must implement this interface</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertInterface")]
		public void AssertInterface(object value, Class iface, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the first two arguments are equal, when serialized into
		/// JSON.</para>
		/// </summary>
		/// <param name="expected">The expected value</param>
		/// <param name="found">The found value</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertJsonEquals")]
		public void AssertJsonEquals(object expected, object found, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is a key in the given map.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="map">Map, where the keys represent the valid values</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertKeyInMap")]
		public void AssertKeyInMap(object value, object map, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is a map either created using new Object
		/// or by using the object literal notation { ... }.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertMap")]
		public void AssertMap(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the given string matches the regular expression</para>
		/// </summary>
		/// <param name="str">String, which should match the regular expression</param>
		/// <param name="re">Regular expression to match</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertMatch")]
		public void AssertMatch(string str, JsRegExp re, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that both values are not equal. (Uses the not equality operator
		/// !=.)</para>
		/// </summary>
		/// <param name="expected">Reference value</param>
		/// <param name="found">found value</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertNotEquals")]
		public void AssertNotEquals(object expected, object found, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that both values are not identical. (Uses the not identity operator
		/// !==.)</para>
		/// </summary>
		/// <param name="expected">Reference value</param>
		/// <param name="found">found value</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertNotIdentical")]
		public void AssertNotIdentical(object expected, object found, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is not null.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertNotNull")]
		public void AssertNotNull(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is not undefined.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertNotUndefined")]
		public void AssertNotUndefined(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is null.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertNull")]
		public void AssertNull(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is a number.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertNumber")]
		public void AssertNumber(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is an object.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertObject")]
		public void AssertObject(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is an integer >= 0.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertPositiveInteger")]
		public void AssertPositiveInteger(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is a number >= 0.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertPositiveNumber")]
		public void AssertPositiveNumber(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is an instance of <see cref="qx.core.Object"/>.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertQxObject")]
		public void AssertQxObject(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is an instance of <see cref="qx.ui.core.Widget"/>.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertQxWidget")]
		public void AssertQxWidget(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is a regular expression.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertRegExp")]
		public void AssertRegExp(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is a string.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertString")]
		public void AssertString(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is true (Identity check).</para>
		/// </summary>
		/// <param name="value">Condition to check for. Must be identical to true.</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertTrue")]
		public void AssertTrue(bool value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value has the given type using the typeof
		/// operator. Because the type is not always what it is supposed to be it is
		/// better to use more explicit checks like <see cref="AssertString"/> or
		/// <see cref="AssertArray"/>.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="type">expected type of the value</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertType")]
		public void AssertType(object value, string type, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Assert that the value is undefined.</para>
		/// </summary>
		/// <param name="value">Value to check</param>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		[JsMethod(Name = "assertUndefined")]
		public void AssertUndefined(object value, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Raise an <see cref="AssertionError"/></para>
		/// </summary>
		/// <param name="msg">Message to be shown if the assertion fails.</param>
		/// <param name="compact">Show less verbose message. Default: false.</param>
		[JsMethod(Name = "fail")]
		public void Fail(string msg, bool compact) { throw new NotImplementedException(); }

		#endregion Methods
    }
}