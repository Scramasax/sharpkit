//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>A <code>Readable Stream</code> has the following methods, members, and events.
    /// </p>
    /// </summary>
    public partial class Readable_Stream
    {
        /// <summary>
        /// <p>Closes the underlying file descriptor. Stream will not emit any more events.
        /// </p>
        /// </summary>
        public object destroy(){return null;}
        /// <summary>
        /// <p>Pauses the incoming <code>&apos;data&apos;</code> events.
        /// </p>
        /// </summary>
        public object pause(){return null;}
        /// <summary>
        /// <p>This is a <code>Stream.prototype</code> method available on all <code>Stream</code>s.
        /// </p>
        /// <p>Connects this read stream to <code>destination</code> WriteStream. Incoming
        /// data on this stream gets written to <code>destination</code>. The destination and source
        /// streams are kept in sync by pausing and resuming as necessary.
        /// </p>
        /// <p>This function returns the <code>destination</code> stream.
        /// </p>
        /// <p>Emulating the Unix <code>cat</code> command:
        /// </p>
        /// <pre><code>process.stdin.resume();
        /// process.stdin.pipe(process.stdout);</code></pre>
        /// <p>By default <code>end()</code> is called on the destination when the source stream emits
        /// <code>end</code>, so that <code>destination</code> is no longer writable. Pass <code>{ end: false }</code> as
        /// <code>options</code> to keep the destination stream open.
        /// </p>
        /// <p>This keeps <code>process.stdout</code> open so that &quot;Goodbye&quot; can be written at the end.
        /// </p>
        /// <pre><code>process.stdin.resume();
        /// process.stdin.pipe(process.stdout, { end: false });
        /// process.stdin.on(&quot;end&quot;, function() {
        /// process.stdout.write(&quot;Goodbye\n&quot;);
        /// });</code></pre>
        /// </summary>
        public object pipe(object destination){return null;}
        /// <summary>
        /// <p>This is a <code>Stream.prototype</code> method available on all <code>Stream</code>s.
        /// </p>
        /// <p>Connects this read stream to <code>destination</code> WriteStream. Incoming
        /// data on this stream gets written to <code>destination</code>. The destination and source
        /// streams are kept in sync by pausing and resuming as necessary.
        /// </p>
        /// <p>This function returns the <code>destination</code> stream.
        /// </p>
        /// <p>Emulating the Unix <code>cat</code> command:
        /// </p>
        /// <pre><code>process.stdin.resume();
        /// process.stdin.pipe(process.stdout);</code></pre>
        /// <p>By default <code>end()</code> is called on the destination when the source stream emits
        /// <code>end</code>, so that <code>destination</code> is no longer writable. Pass <code>{ end: false }</code> as
        /// <code>options</code> to keep the destination stream open.
        /// </p>
        /// <p>This keeps <code>process.stdout</code> open so that &quot;Goodbye&quot; can be written at the end.
        /// </p>
        /// <pre><code>process.stdin.resume();
        /// process.stdin.pipe(process.stdout, { end: false });
        /// process.stdin.on(&quot;end&quot;, function() {
        /// process.stdout.write(&quot;Goodbye\n&quot;);
        /// });</code></pre>
        /// </summary>
        public object pipe(object destination, object options){return null;}
        /// <summary>
        /// <p>Resumes the incoming <code>&apos;data&apos;</code> events after a <code>pause()</code>.
        /// </p>
        /// </summary>
        public object resume(){return null;}
        /// <summary>
        /// <p>Makes the data event emit a string instead of a <code>Buffer</code>. <code>encoding</code> can be
        /// <code>&apos;utf8&apos;</code>, <code>&apos;ascii&apos;</code>, or <code>&apos;base64&apos;</code>.
        /// </p>
        /// </summary>
        public object setEncoding(object encoding){return null;}
    }
}