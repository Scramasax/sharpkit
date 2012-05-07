//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_
{
    /// <summary>
    /// <p>Creates circle shape with editable attributes.</p>
    /// <p>`Circle` instances can be created using the <a href="Graphic.html#method_addShape">`addShape`</a> method of the <a href="Graphic.html">`Graphic`</a> class.
    /// The method's `cfg` argument contains a `type` attribute. Assigning "circle" or `Y.Circle` to this attribute will create a `Circle` instance. Required attributes
    /// for instantiating a `Circle` are `type` and `radius`. Optional attributes include:
    /// <ul>
    /// <li><a href="#attr_fill">fill</a></li>
    /// <li><a href="#attr_id">id</a></li>
    /// <li><a href="#attr_stroke">stroke</a></li>
    /// <li><a href="#attr_transform">transform</a></li>
    /// <li><a href="#attr_transformOrigin">transformOrigin</a></li>
    /// <li><a href="#attr_visible">visible</a></li>
    /// <li><a href="#attr_x">x</a></li>
    /// <li><a href="#attr_y">y</a></li>
    /// </ul>
    /// The below code creates a circle by defining the `type` attribute as "circle":</p>
    /// var myCircle = myGraphic.addShape({
    /// type: "circle",
    /// radius: 10,
    /// fill: {
    /// color: "#9aa"
    /// },
    /// stroke: {
    /// weight: 1,
    /// color: "#000"
    /// }
    /// });
    /// Below, this same circle is created by defining the `type` attribute with a class reference:
    /// var myCircle = myGraphic.addShape({
    /// type: Y.Circle,
    /// radius: 10,
    /// fill: {
    /// color: "#9aa"
    /// },
    /// stroke: {
    /// weight: 1,
    /// color: "#000"
    /// }
    /// });
    /// <p>`Circle` has the following implementations based on browser capability.
    /// <ul>
    /// <li><a href="SVGCircle.html">`SVGCircle`</a></li>
    /// <li><a href="VMLCircle.html">`VMLCircle`</a></li>
    /// <li><a href="CanvasCircle.html">`CanvasCircle`</a></li>
    /// </ul>
    /// It is not necessary to interact with these classes directly. `Circle` will point to the appropriate implemention.</p>
    /// </summary>
    public partial class Circle : Shape
    {
    }
}