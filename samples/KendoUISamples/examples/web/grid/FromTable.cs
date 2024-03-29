﻿using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.grid
{
    [JsType(JsMode.Global)]
    public class FromTable
    {
        static FromTable()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            new jQuery("#grid").kendoGrid(new GridConfiguration { height = 250 });
        }
    }
}