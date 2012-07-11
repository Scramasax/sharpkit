//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class TextEvent : UIEvent
{

	// TextEvent
	public static int DOM_INPUT_METHOD_UNKNOWN = 0x00;
	public static int DOM_INPUT_METHOD_KEYBOARD = 0x01;
	public static int DOM_INPUT_METHOD_PASTE = 0x02;
	public static int DOM_INPUT_METHOD_DROP = 0x03;
	public static int DOM_INPUT_METHOD_IME = 0x04;
	public static int DOM_INPUT_METHOD_OPTION = 0x05;
	public static int DOM_INPUT_METHOD_HANDWRITING = 0x06;
	public static int DOM_INPUT_METHOD_VOICE = 0x07;
	public static int DOM_INPUT_METHOD_MULTIMODAL = 0x08;
	public static int DOM_INPUT_METHOD_SCRIPT = 0x09;
	public JsString data {get; private set; }
	public int inputMode {get; private set; }
	public void initTextEvent(string typeArg, bool canBubbleArg, bool cancelableArg, AbstractView viewArg, string dataArg, int inputMode) {}
}

}