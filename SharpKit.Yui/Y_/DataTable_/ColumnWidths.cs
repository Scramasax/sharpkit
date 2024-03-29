//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_.DataTable_
{
    /// <summary>
    /// _API docs for this extension are included in the DataTable class._
    /// Adds basic, programmatic column width support to DataTable. Note, this does not
    /// add support for truncated columns.  Due to the way HTML tables render, column
    /// width is more like a "recommended width".  Column content wider than the
    /// assigned width will cause the column to expand, despite the configured width.
    /// Similarly if the table is too narrow to fit the column with the configured
    /// column width, the column width will be reduced.
    /// To set a column width, either add a `width` value to the column configuration
    /// or call the `setColumnWidth(id, width)` method.
    /// Note, assigning column widths is possible without this module, as each cell is
    /// decorated with a class appropriate for that column which you can statically
    /// target in your site's CSS.
    /// To achieve absolute column widths, with content truncation, you can either:
    /// 1. Use this module, configure *all* columns to have `width`s, then add
    /// `table-layout: fixed;` to your CSS for the appropriate `<table>`, or
    /// 2. Wrap the contents of all cells in the column with a `<div>` (using a
    /// `cellTemplate` or `formatter`), assign the div's style `width`, then assign
    /// the column `width` or add a CSS `width` to the column class created by
    /// DataTable.
    /// <pre><code>.yui3-datatable .yui3-datatable-col-foo {
    /// padding: 0;
    /// width: 125px;
    /// }
    /// .yui3-datatable .yui3-datatable-col-foo .yui3-datatable-liner {
    /// overflow: hidden;
    /// padding: 4px 10px;
    /// width: 125px;
    /// }
    /// </pre></code>
    /// <pre><code>var table = new Y.DataTable({
    /// columns: [
    /// {
    /// key: 'foo',
    /// cellTemplate:
    /// '&lt;td class="{className}">' +
    /// '&lt;div class="yui3-datatable-liner">{content}&lt;/div>' +
    /// '&lt;/td>'
    /// },
    /// ...
    /// ],
    /// ...
    /// });
    /// </code></pre>
    /// To add a liner to all columns, either provide a custom `bodyView` to the
    /// DataTable constructor or update the default `bodyView`'s `CELL_TEMPLATE` like
    /// so:
    /// <pre><code>table.on('renderBody', function (e) {
    /// e.view.CELL_TEMPLATE = e.view.CELL_TEMPLATE.replace(/\{content\}/,
    /// '&lt;div class="yui3-datatable-liner">{content}&lt;/div>');
    /// });
    /// </code></pre>
    /// Keep in mind that DataTable skins apply cell `padding`, so assign your CSS
    /// `width`s accordingly or override the `padding` style for that column's `<td>`s
    /// to 0, and add `padding` to the liner `<div>`'s styles as shown above.
    /// </summary>
    public partial class ColumnWidths
    {
    }
}
