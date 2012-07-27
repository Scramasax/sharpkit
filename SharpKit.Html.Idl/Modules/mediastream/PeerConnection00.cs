
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:27 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/Modules/mediastream/PeerConnection00.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as 'partial'. Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

*****************************************************************************************************

  This library is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  This library is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.

*****************************************************************************************************/

using System;

namespace SharpKit.Html
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class PeerConnection00
{
	public   PeerConnection00(string serverConfiguration, IceCallback iceCallback) {}
	public  SessionDescription createOffer() { return default(SessionDescription); }
	public  SessionDescription createOffer(object mediaHints) { return default(SessionDescription); }
	public  SessionDescription createAnswer(string offer) { return default(SessionDescription); }
	public  SessionDescription createAnswer(string offer, object mediaHints) { return default(SessionDescription); }
	public  static int SDP_OFFER = 0x100;
	public  static int SDP_PRANSWER = 0x200;
	public  static int SDP_ANSWER = 0x300;
	public  void setLocalDescription(int action, SessionDescription desc) {}
	public  void setRemoteDescription(int action, SessionDescription desc) {}
	public  SessionDescription localDescription {get; set; }
	public  SessionDescription remoteDescription {get; set; }
	public  static int NEW = 0;
	public  static int OPENING = 1;
	public  static int ACTIVE = 2;
	public  static int CLOSED = 3;
	public  int readyState {get; set; }
	public  void startIce() {}
	public  void startIce(object iceOptions) {}
	public  void processIceMessage(IceCandidate candidate) {}
	public  static int ICE_GATHERING = 0x100;
	public  static int ICE_WAITING = 0x200;
	public  static int ICE_CHECKING = 0x300;
	public  static int ICE_CONNECTED = 0x400;
	public  static int ICE_COMPLETED = 0x500;
	public  static int ICE_FAILED = 0x600;
	public  static int ICE_CLOSED = 0x700;
	public  int iceState {get; set; }
	public  void addStream(MediaStream stream) {}
	public  void addStream(MediaStream stream, object mediaStreamHints) {}
	public  void removeStream(MediaStream stream) {}
	public  MediaStreamList localStreams {get; set; }
	public  MediaStreamList remoteStreams {get; set; }
	public  void close() {}
	public  EventListener onconnecting {get; set; }
	public  EventListener onopen {get; set; }
	public  EventListener onstatechange {get; set; }
	public  EventListener onaddstream {get; set; }
	public  EventListener onremovestream {get; set; }
	public  void addEventListener(string type, EventListener listener) {}
	public  void addEventListener(string type, EventListener listener, bool useCapture) {}
	public  void removeEventListener(string type, EventListener listener) {}
	public  void removeEventListener(string type, EventListener listener, bool useCapture) {}
	public  bool dispatchEvent(DOMEvent @event) { return default(bool); }
}

}