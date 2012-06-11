//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "KeyboardEvent")]
public partial class KeyboardEvent : UIEvent
{

	// KeyboardEvent
	public static int DOM_KEY_LOCATION_STANDARD = 0x00;
	public static int DOM_KEY_LOCATION_LEFT = 0x01;
	public static int DOM_KEY_LOCATION_RIGHT = 0x02;
	public static int DOM_KEY_LOCATION_NUMPAD = 0x03;
	public static int DOM_KEY_LOCATION_MOBILE = 0x04;
	public static int DOM_KEY_LOCATION_JOYSTICK = 0x05;
	public JsString key {get; private set; }
	public int location {get; private set; }
	public bool ctrlKey {get; private set; }
	public bool shiftKey {get; private set; }
	public bool altKey {get; private set; }
	public bool metaKey {get; private set; }
	public bool repeat {get; private set; }
	public bool getModifierState(string keyArg) { return default(bool); }
    public string locale { get; private set; }
    public void initKeyboardEvent(string typeArg, bool canBubbleArg, bool cancelableArg, AbstractView viewArg, string keyArg, int locationArg, string modifiersListArg, bool repeat, string locale) { }
}

}