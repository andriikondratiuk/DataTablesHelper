using System.Collections.Generic;
using System.ComponentModel;

namespace DataTables.Helpers.Model
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    public class DataTablesOptions<TModel> : DataTablesOptions
    {
        /// <summary>
        /// Data to use as the display data for the table.
        /// </summary>
        public IEnumerable<TModel> Data { get; set; }
    }
    /// <summary>
    /// Customization of these options are performed by defining options in the $().DataTable() constructor.
    /// See <see href="https://datatables.net/reference/option/">here</see>
    /// </summary>
    public class DataTablesOptions
    {
        /// <summary>
        /// DataTables - Columns.
        /// </summary>
        [DisplayName("columnDefs")]
        public List<DataColumns> Columns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("language")]
        public LanguageOptions Language { get; set; }
        /// <summary>
        /// Enable and configure the AutoFill extension for DataTables.
        /// </summary>
        [DisplayName("autoFill")]
        public AutoFillOptions AutoFill { get; set; }
        /// <summary>
        /// Load data for the table's content from an Ajax source.
        /// </summary>
        [DisplayName("ajax")]
        public AjaxHelperOptions Ajax { get; set; }
        #region Features
        /// <summary>
        /// Feature control DataTables' smart column width handling.<c> Default value: true</c>
        /// </summary>
        /// <example>
        /// <code>
        /// $('#example').dataTable( {
        ///     "autoWidth": false
        /// });
        /// </code>
        /// </example>
        [DisplayName("autoWidth")]
        public bool? AutoWidth { get; set; }
        /// <summary>
        ///  Feature control deferred rendering for additional speed of initialisation.<c> Default value: false</c>
        /// </summary>
        /// <example>
        /// <code>
        /// 
        /// </code>
        /// </example>
        [DisplayName("deferRender")]
        public bool? DeferRender { get; set; }
        /// <summary>
        /// Feature control table information display field.<c> Default value: true</c>
        /// </summary>
        /// <example>
        /// <code>
        /// 
        /// </code>
        /// </example>
        [DisplayName("info")]
        public bool? Info { get; set; }
        /// <summary>
        /// Feature control the end user's ability to change the paging display length of the table.<c> Default value: true</c>
        /// </summary>
        /// <example>
        /// <code>
        /// 
        /// </code>
        /// </example>
        [DisplayName("lengthChange")]
        public bool? LengthChange { get; set; }
        /// <summary>
        /// Feature control ordering (sorting) abilities in DataTables.<c> Default value: true</c>
        /// </summary>
        /// <example>
        /// <code>
        /// 
        /// </code>
        /// </example>
        [DisplayName("ordering")]
        public bool? Ordering { get; set; }
        /// <summary>
        /// Enable or disable table pagination.<c> Default value: true</c>
        /// </summary>
        /// <example>
        /// <code>
        /// 
        /// </code>
        /// </example>
        [DisplayName("paging")]
        public bool? Paging { get; set; }
        /// <summary>
        /// Feature control the processing indicator.<c> Default value: false</c>
        /// </summary>
        /// <example>
        /// <code>
        /// 
        /// </code>
        /// </example>
        [DisplayName("processing")]
        public bool? Processing { get; set; }
        /// <summary>
        /// Horizontal scrolling. Description: false - No horizontal scrolling, true - Enable horizontal scrolling in the table.<c> Default value: false</c>
        /// </summary>
        /// <example>
        /// <code>
        /// 
        /// </code>
        /// </example>
        [DisplayName("scrollX")]
        public bool? ScrollX { get; set; }
        /// <summary>
        /// Vertical scrolling.
        /// </summary>
        /// <example>
        /// <code>
        /// 12345678
        /// 23456
        /// </code>
        /// </example>
        [DisplayName("scrollY")]
        public string ScrollY { get; set; }
        /// <summary>
        /// Feature control search (filtering) abilities.<c> Default value: true</c>
        /// </summary>
        /// <example>
        /// <code>
        /// 
        /// </code>
        /// </example>
        [DisplayName("searching")]
        public bool? Searching { get; set; }
        /// <summary>
        /// Feature control DataTables' server-side processing mode.<c> Default value: false</c>
        /// </summary>
        /// <example>
        /// <code>
        /// 
        /// </code>
        /// </example>
        [DisplayName("serverSide")]
        public bool? ServerSide { get; set; }
        /// <summary>
        /// State saving - restore table state on page reload.<c> Default value: false</c>
        /// </summary>
        [DisplayName("stateSave")]
        public bool? StateSave { get; set; }
        #endregion
        #region Callbacks
        /// <summary>
        /// Callback for whenever a TR element is created for the table's body.<c> Example: function( row, data, dataIndex ) {if (data[4] == "A" ) {$(row).addClass( 'important' );}}</c>
        /// </summary>
        [DisplayName("createdRow")]
        public string CreatedRow { get; set; }
        /// <summary>
        /// Function that is called every time DataTables performs a draw.<c> Example: function( settings ) {alert( 'DataTables has redrawn the table' );</c>
        /// </summary>
        [DisplayName("drawCallback")]
        public string DrawCallback { get; set; }
        /// <summary>
        /// Footer display callback function.<c> Example: function( tfoot, data, start, end, display ) {$(tfoot).find('th').eq(0).html( "Starting index is "+start );}</c>
        /// </summary>
        [DisplayName("footerCallback")]
        public string FooterCallback { get; set; }
        /// <summary>
        /// Number formatting callback function.<c> Example: function ( toFormat ) {return toFormat.toString().replace(/\B(?= (\d{ 3})+(?!\d))/g, "'");};</c>
        /// </summary>
        [DisplayName("formatNumber")]
        public string FormatNumber { get; set; }
        /// <summary>
        /// Header display callback function.<c> Example: function( thead, data, start, end, display ) {$(thead).find('th').eq(0).html( 'Displaying '+(end-start)+' records' );}</c>
        /// </summary>
        [DisplayName("headerCallback")]
        public string HeaderCallback { get; set; }
        /// <summary>
        /// Table summary information display callback.<c> Example: function( settings, start, end, max, total, pre ) {return start +" to "+ end;}</c>
        /// </summary>
        [DisplayName("infoCallback")]
        public string InfoCallback { get; set; }
        /// <summary>
        /// Initialisation complete callback.<c> Example: function(settings, json) {alert( 'DataTables has finished its initialisation.' );}</c>
        /// </summary>
        [DisplayName("initComplete")]
        public string InitComplete { get; set; }
        /// <summary>
        /// Pre-draw callback.<c> Example: function( settings ) {$('#example tbody').off( 'click', 'td' );}</c>
        /// </summary>
        [DisplayName("preDrawCallback")]
        public string PreDrawCallback { get; set; }
        /// <summary>
        /// Row draw callback.<c> Example: function( row, data ) {if (data.grade == "A" ) {$('td:eq(4)', row).html( '<b>A</b>' );}}</c>
        /// </summary>
        [DisplayName("rowCallback")]
        public string RowCallback { get; set; }
        /// <summary>
        /// Callback that defines where and how a saved state should be loaded.<c> Example: function (settings, callback) {$.ajax( {url: '/state_load',dataType: 'json',success: function(json) {callback(json);}} );}</c>
        /// </summary>
        [DisplayName("stateLoadCallback")]
        public string StateLoadCallback { get; set; }
        /// <summary>
        /// State loaded callback.<c> Example: function (settings, data) {alert( 'Saved filter was: '+data.search.search );}</c>
        /// </summary>
        [DisplayName("stateLoaded")]
        public string StateLoaded { get; set; }
        /// <summary>
        /// State loaded - data manipulation callback.<c> Example: function (settings, data) {data.search.search = "";}</c>
        /// </summary>
        [DisplayName("stateLoadParams")]
        public string StateLoadParams { get; set; }
        /// <summary>
        /// Callback that defines how the table state is stored and where.<c> Example: function (settings, data) {$.ajax({"url": "/state_save","data": data,"dataType": "json","type": "POST","success": function() { }});}</c>
        /// </summary>
        [DisplayName("stateSaveCallback")]
        public string StateSaveCallback { get; set; }
        /// <summary>
        /// State save - data manipulation callback.<c> Example: function (settings, data) {data.search.search = "";}</c>
        /// </summary>
        [DisplayName("stateSaveParams")]
        public string StateSaveParams { get; set; }
        #endregion
        #region Options
        /// <summary>
        /// Delay the loading of server-side data until second draw.<c>Default value: null; Examples: 57 or [57, 100]</c>
        /// </summary>
        [DisplayName("deferLoading")]
        public string DeferLoading { get; set; }
        /// <summary>
        /// Destroy any existing table matching the selector and replace with the new options.<c>Default value: false</c>
        /// </summary>
        [DisplayName("destroy")]
        public bool? Destroy { get; set; }
        /// <summary>
        /// Initial paging start point.<c>Default value: 0</c>
        /// </summary>
        [DisplayName("displayStart")]
        public int? DisplayStart { get; set; }
        /// <summary>
        /// Define the table control elements to appear on the page and in what order<c>Default value: lfrtip</c>
        /// </summary>
        [DisplayName("dom")]
        public string Dom { get; set; }
        /// <summary>
        ///  Change the options in the page length select list.<c>Default value: [ 10, 25, 50, 100 ]</c>
        /// </summary>
        [DisplayName("lengthMenu")]
        public string LengthMenu { get; set; }
        /// <summary>
        /// Initial order(sort) to apply to the table.<c>Default value: [[0, 'asc']]</c>
        /// </summary>
        [DisplayName("order")]
        public string Order { get; set; }
        /// <summary>
        /// Control which cell the order event handler will be applied to in a column.<c>Default value: false</c>
        /// </summary>
        [DisplayName("orderCellsTop")]
        public bool? OrderCellsTop { get; set; }
        /// <summary>
        /// Highlight the columns being ordered in the table's body.<c>Default value: true</c>
        /// </summary>
        [DisplayName("orderClasses")]
        public bool? OrderClasses { get; set; }
        /// <summary>
        /// Ordering to always be applied to the table.<c>Examples: {"pre": [ 0, 'asc' ],"post": [ 1, 'asc' ]} or [ 0, 'asc' ]</c>
        /// </summary>
        [DisplayName("OrderFixed")]
        public string OrderFixed { get; set; }
        /// <summary>
        /// Multiple column ordering ability control.<c>Default value: true</c>
        /// </summary>
        [DisplayName("orderMulti")]
        public bool? OrderMulti { get; set; }
        /// <summary>
        /// Change the initial page length(number of rows per page).<c>Default value: 10</c>
        /// </summary>
        [DisplayName("pageLength")]
        public int? PageLength { get; set; }
        /// <summary>
        /// Pagination button display options.<c>Default value: simple_numbers</c>
        /// </summary>
        [DisplayName("pagingType")]
        public string PagingType { get; set; }
        /// <summary>
        /// Display component renderer types.<c>Examples: "bootstrap" or {"header": "jqueryui","pageButton": "bootstrap"}</c>
        /// </summary>
        [DisplayName("renderer")]
        public string Renderer { get; set; }
        /// <summary>
        /// Retrieve an existing DataTables instance.<c>Default value: false</c>
        /// </summary>
        [DisplayName("retrieve")]
        public bool? Retrieve { get; set; }
        /// <summary>
        /// Data property name that DataTables will use to set tr element DOM IDs.<c>Default value: DT_RowId</c>
        /// </summary>
        [DisplayName("rowId")]
        public string RowId { get; set; }
        /// <summary>
        /// Allow the table to reduce in height when a limited number of rows are shown.<c>Default value: false</c>
        /// </summary>
        [DisplayName("scrollCollapse")]
        public bool? ScrollCollapse { get; set; }
        /// <summary>
        ///  Set an initial filter in DataTables and / or filtering options.
        /// </summary>
        [DisplayName("search")]
        public SearchOption Search { get; set; }
        /// <summary>
        /// Define an initial search for individual columns.<c>Example: [null,{ "search": "My filter" },null,{ "search": "^[0-9]", "escapeRegex": false }]</c>
        /// </summary>
        [DisplayName("searchCols")]
        public string SearchCols { get; set; }
        /// <summary>
        /// Set a throttle frequency for searching.<c>Default value: null</c>
        /// </summary>
        [DisplayName("searchDelay")]
        public int? SearchDelay { get; set; }
        /// <summary>
        /// Saved state validity duration<c>Default value: 7200</c>
        /// </summary>
        [DisplayName("stateDuration")]
        public int? StateDuration { get; set; }
        /// <summary>
        /// Set the zebra stripe class names for the rows in the table.<c>Example: [ 'strip1', 'strip2', 'strip3' ]</c>
        /// </summary>
        [DisplayName("stripeClasses")]
        public string StripeClasses { get; set; }
        /// <summary>
        /// Tab index control for keyboard navigation.<c>Default value: 0</c>
        /// </summary>
        [DisplayName("tabIndex")]
        public int? TabIndex { get; set; }
        #endregion
        /// <summary>
        /// Buttons configuration object.
        /// </summary>
        [DisplayName("buttons")]
        public ButtonsOptions Buttons { get; set; }
        /// <summary>
        /// Enable and configure the ColReorder extension for DataTables.
        /// </summary>
        [DisplayName("colReorder")]
        public ColReorderOptions ColReorder { get; set; }
        /// <summary>
        /// Enable and configure the FixedColumns extension for DataTables.
        /// </summary>
        [DisplayName("fixedColumns")]
        public FixedColumnsOptions FixedColumns { get; set; }
        /// <summary>
        /// FixedHeader configuration object.
        /// </summary>
        [DisplayName("fixedHeader")]
        public FixedHeaderOptions FixedHeader { get; set; }
        /// <summary>
        /// Enable and configure the KeyTable extension for DataTables.
        /// </summary>
        [DisplayName("keys")]
        public KeysOptions Keys { get; set; }
        /// <summary>
        /// Enable and configure the Responsive extension for DataTables
        /// </summary>
        [DisplayName("responsive")]
        public ResponsiveOptions Responsive { get; set; }
        /// <summary>
        /// Enable and configure the RowGroup extension for DataTables.
        /// </summary>
        [DisplayName("rowGroup")]
        public RowGroupOptions RowGroup { get; set; }
        /// <summary>
        /// Enable and configure the RowReorder extension for DataTables.
        /// </summary>
        [DisplayName("rowReorder")]
        public RowReorderOptions RowReorder { get; set; }
        /// <summary>
        /// Enable and configure the Scroller extension for DataTables.
        /// </summary>
        [DisplayName("scroller")]
        public ScrollerOptions Scroller { get; set; }
        /// <summary>
        /// Select configuration object.
        /// </summary>
        [DisplayName("select")]
        public SelectOptions Select { get; set; }
    }
    /// <summary>
    /// Select configuration object.
    /// </summary>
    public class SelectOptions
    {
        /// <summary>
        /// Indicate if the selected items will be removed when clicking outside of the table.<c>Default value: false</c>
        /// </summary>
        [DisplayName("blurable")]
        public bool? Blurable { get; set; }
        /// <summary>
        /// Set the class name that will be applied to selected items.<c>Default value: selected</c>
        /// </summary>
        [DisplayName("className")]
        public string ClassName { get; set; }
        /// <summary>
        /// Enable / disable the display for item selection information in the table summary.<c>Default value: true</c>
        /// </summary>
        [DisplayName("info")]
        public bool? Info { get; set; }
        /// <summary>
        /// Set which table items to select (rows, columns or cells).<c>Default value: row</c>
        /// </summary>
        [DisplayName("items")]
        public string Items { get; set; }
        /// <summary>
        /// Set the element selector used for mouse event capture to select items.<c>Default value: td, th</c>
        /// </summary>
        [DisplayName("selector")]
        public string Selector { get; set; }
        /// <summary>
        /// Set the selection style for end user interaction with the table.<c>Default value: os</c>
        /// </summary>
        [DisplayName("style")]
        public string Style { get; set; }
    }
    /// <summary>
    /// Enable and configure the Scroller extension for DataTables.
    /// </summary>
    public class ScrollerOptions
    {
        /// <summary>
        /// Set the point at which new data will be loaded and drawn.<c>Default value: 0.5</c>
        /// </summary>
        [DisplayName("boundaryScale")]
        public double? BoundaryScale { get; set; }
        /// <summary>
        /// The amount of data that Scroller should pre-buffer to ensure smooth scrolling.<c>Default value: 9</c>
        /// </summary>
        [DisplayName("displayBuffer")]
        public int? DisplayBuffer { get; set; }
        /// <summary>
        /// Display a loading message while Scroller is loading additional data.<c>Default value: false</c>
        /// </summary>
        [DisplayName("loadingIndicator")]
        public bool? LoadingIndicator { get; set; }
        /// <summary>
        /// Set the row height, or how the row height is calculated.<c>Default value: auto</c>
        /// </summary>
        [DisplayName("rowHeight")]
        public string RowHeight { get; set; }
        /// <summary>
        /// Time delay before new data is requested when server-side processing is enabled.<c>Default value: 200</c>
        /// </summary>
        [DisplayName("serverWait")]
        public int? ServerWait { get; set; }
    }
    /// <summary>
    /// Enable and configure the RowReorder extension for DataTables.
    /// </summary>
    public class RowReorderOptions
    {
        /// <summary>
        ///  Configure the data point that will be used for the reordering data.<c>Default value: 0</c>
        /// </summary>
        [DisplayName("dataSrc")]
        public string DataSrc { get; set; }
        /// <summary>
        /// Attach an Editor instance for database updating.<c>Default value: null</c>
        /// </summary>
        [DisplayName("editor")]
        public string Editor { get; set; }
        /// <summary>
        /// Enable / disable RowReorder's user interaction.<c>Default value: true</c>
        /// </summary>
        [DisplayName("enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Set the options for the Editor form when submitting data.<c>Default value: {}</c>
        /// </summary>
        [DisplayName("formOptions")]
        public string FormOptions { get; set; }
        /// <summary>
        /// Define the selector used to pick the elements that will start a drag.<c>Default value: td:first-child</c>
        /// </summary>
        [DisplayName("selector")]
        public string Selector { get; set; }
        /// <summary>
        ///  Horizontal position control of the row being dragged.<c>Default value: false</c>
        /// </summary>
        [DisplayName("snapX")]
        public bool? SnapX { get; set; }
        /// <summary>
        /// Control automatic of data when a row is dropped.<c>Default value: true</c>
        /// </summary>
        [DisplayName("update")]
        public bool? Update { get; set; }
    }
    /// <summary>
    /// Enable and configure the RowGroup extension for DataTables.
    /// </summary>
    public class RowGroupOptions
    {
        /// <summary>
        /// Set the class name to be used for the grouping rows.<c>Default value: group</c>
        /// </summary>
        [DisplayName("className")]
        public string ClassName { get; set; }
        /// <summary>
        /// Set the data point to use as the grouping data source.<c>Default value: 0</c>
        /// </summary>
        [DisplayName("dataSrc")]
        public string DataSrc { get; set; }
        /// <summary>
        /// Text to show for rows which have null, undefined or empty string group data.<c>Default value: No group</c>
        /// </summary>
        [DisplayName("emptyDataGroup")]
        public string EmptyDataGroup { get; set; }
        /// <summary>
        /// Provides the ability to disable row grouping at initialization.<c>Default value: true</c>
        /// </summary>
        [DisplayName("enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Set the class name to be used for the grouping end rows.<c>Default value: group-end</c>
        /// </summary>
        [DisplayName("endClassName")]
        public string EndClassName { get; set; }
        /// <summary>
        /// Provide a function that can be used to control the data shown in the end grouping row.<c>Examples: function ( rows, group ) {return group +' ('+rows.count()+' rows)';}</c>
        /// </summary>
        [DisplayName("endRender")]
        public string EndRender { get; set; }
        /// <summary>
        /// Set the class name to be used for the grouping start rows.<c>Default value: group-start</c>
        /// </summary>
        [DisplayName("startClassName")]
        public string StartClassName { get; set; }
        /// <summary>
        ///  Provide a function that can be used to control the data shown in the start grouping row.<c>Default value: function(rows, data) { return data; }</c>
        /// </summary>
        [DisplayName("startRender")]
        public string StartRender { get; set; }
    }
    /// <summary>
    /// Enable and configure the Responsive extension for DataTables
    /// </summary>
    public class ResponsiveOptions
    {
        /// <summary>
        /// Enable and configure the child rows shown by Responsive for collapsed tables.
        /// </summary>
        [DisplayName("details")]
        public DetailOptions Details { get; set; }
        /// <summary>
        /// Set the orthogonal data request type for the hidden information display.<c>Default value: display</c>
        /// </summary>
        [DisplayName("orthogonal")]
        public string Orthogonal { get; set; }
    }
    /// <summary>
    /// Enable and configure the child rows shown by Responsive for collapsed tables.
    /// </summary>
    public class DetailOptions
    {
        /// <summary>
        ///  Set the breakpoints for a Responsive instance.<c>Examples: [{ name: 'desktop', width: Infinity},{ name: 'tablet',  width: 1024 },{ name: 'fablet',  width: 768 },{ name: 'phone',   width: 480 }]</c>
        /// </summary>
        [DisplayName("breakpoints")]
        public string Breakpoints { get; set; }
        /// <summary>
        /// Define how the hidden information should be displayed to the end user.<c>Examples: $.fn.dataTable.Responsive.display.modal()</c>
        /// </summary>
        [DisplayName("display")]
        public string Display { get; set; }
        /// <summary>
        /// Define the renderer used to display the child rows.<c>Examples: $.fn.dataTable.Responsive.renderer.tableAll()</c>
        /// </summary>
        [DisplayName("renderer")]
        public string Renderer { get; set; }
        /// <summary>
        /// Column / selector for child row display control when using column details type.<c>Examples: 'tr'</c>
        /// </summary>
        [DisplayName("target")]
        public string Target { get; set; }
        /// <summary>
        /// Set the child row display control type.<c>Default value: inline</c>
        /// </summary>
        [DisplayName("type")]
        public string Type { get; set; }
    }
    /// <summary>
    /// Enable and configure the KeyTable extension for DataTables.
    /// </summary>
    public class KeysOptions
    {
        /// <summary>
        /// Allow KeyTable's focus to be blurred (removed) from a table.<c>Default value: true</c>
        /// </summary>
        [DisplayName("blurable")]
        public bool? Blurable { get; set; }
        /// <summary>
        /// Set the class name used for the focused cell.<c>Default value: focus</c>
        /// </summary>
        [DisplayName("className")]
        public string ClassName { get; set; }
        /// <summary>
        /// Enable / disable clipboard interaction with KeyTable.<c>Default value: true</c>
        /// </summary>
        [DisplayName("clipboard")]
        public bool? Clipboard { get; set; }
        /// <summary>
        /// Set the orthogonal data to copy to clipboard.<c>Default value: display</c>
        /// </summary>
        [DisplayName("clipboardOrthogonal")]
        public string ClipboardOrthogonal { get; set; }
        /// <summary>
        /// Select the columns that can gain focus.<c>Examples: ':not(:last-child)'</c>
        /// </summary>
        [DisplayName("columns")]
        public string Columns { get; set; }
        /// <summary>
        /// Set if Editor should automatically select the text in the input.<c>Default value: true</c>
        /// </summary>
        [DisplayName("editAutoSelect")]
        public bool? EditAutoSelect { get; set; }
        /// <summary>
        /// Control if editing should be activated immediately upon focus.<c>Default value: false</c>
        /// </summary>
        [DisplayName("editOnFocus")]
        public bool? EditOnFocus { get; set; }
        /// <summary>
        /// Attach an Editor instance for Excel like editing.<c>Default value: null</c>
        /// </summary>
        [DisplayName("editor")]
        public string Editor { get; set; }
        /// <summary>
        /// Enable or disable navigation while inline editing.<c>Default value: navigation-only</c>
        /// </summary>
        [DisplayName("editorKeys")]
        public string EditorKeys { get; set; }
        /// <summary>
        /// Cell to receive initial focus in the table.<c>Example: ':eq(0)'</c>
        /// </summary>
        [DisplayName("focus")]
        public string Focus { get; set; }
        /// <summary>
        /// Limit the keys that KeyTable will listen for and take action on.<c>Example: [ "\t".charCodeAt(0) ]</c>
        /// </summary>
        [DisplayName("keys")]
        public string Keys { get; set; }
        /// <summary>
        /// Set the table's tab index for when it will receive focus.<c>Default value: null</c>
        /// </summary>
        [DisplayName("tabIndex")]
        public int? TabIndex { get; set; }
    }
    /// <summary>
    /// FixedHeader configuration object.
    /// </summary>
    public class FixedHeaderOptions
    {
        /// <summary>
        /// Enable / disable fixed footer.<c>Default value: false</c>
        /// </summary>
        [DisplayName("footer")]
        public bool? Footer { get; set; }
        /// <summary>
        /// Offset the table's fixed footer.<c>Default value: 0</c>
        /// </summary>
        [DisplayName("footerOffset")]
        public int? FooterOffset { get; set; }
        /// <summary>
        /// Enable/disable fixed header.<c>Default value: true</c>
        /// </summary>
        [DisplayName("header")]
        public bool? Header { get; set; }
        /// <summary>
        /// Offset the table's fixed header.<c>Default value: 0</c>
        /// </summary>
        [DisplayName("headerOffset")]
        public int? HeaderOffset { get; set; }
    }
    /// <summary>
    /// Enable and configure the FixedColumns extension for DataTables.
    /// </summary>
    public class FixedColumnsOptions
    {
        /// <summary>
        /// Row height matching algorithm to use.<c>Default value: semiauto. Example:'none'</c>
        /// </summary>
        [DisplayName("heightMatch")]
        public string HeightMatch { get; set; }
        /// <summary>
        /// Number of columns to fix to the left of the table.<c>Default value: 1</c>
        /// </summary>
        [DisplayName("leftColumns")]
        public int? LeftColumns { get; set; }
        /// <summary>
        /// Number of columns to fix to the right of the table.<c>Default value: 0</c>
        /// </summary>
        [DisplayName("rightColumns")]
        public int? RightColumns { get; set; }
    }
    /// <summary>
    /// Enable and configure the ColReorder extension for DataTables.
    /// </summary>
    public class ColReorderOptions
    {
        /// <summary>
        /// Initial enablement state of ColReorder.<c>Default value: true</c>
        /// </summary>
        [DisplayName("enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Disallow x columns from reordering(counting from the left).<c>Default value: 0</c>
        /// </summary>
        [DisplayName("fixedColumnsLeft")]
        public int? FixedColumnsLeft { get; set; }
        /// <summary>
        /// Disallow x columns from reordering(counting from the right).<c>Default value: 0</c>
        /// </summary>
        [DisplayName("fixedColumnsRight")]
        public int? FixedColumnsRight { get; set; }
        /// <summary>
        /// Set a default order for the columns in the table.<c>Example: [ 5, 4, 3, 2, 1, 0 ]</c>
        /// </summary>
        [DisplayName("order")]
        public string Order { get; set; }
        /// <summary>
        /// Enable / disable live reordering of columns during a drag.<c>Default value: true</c>
        /// </summary>
        [DisplayName("realtime")]
        public bool? Realtime { get; set; }
    }
    /// <summary>
    /// Options for Buttons
    /// </summary>
    public class ButtonsOptions
    {
        /// <summary>
        /// List of buttons to be created.<c>Default value: TBC</c>
        /// </summary>
        [DisplayName("buttons")]
        public List<InnerButtons> Buttons { get; set; }
        /// <summary>
        /// Options to control the DOM structure Buttons creates.
        /// </summary>
        [DisplayName("dom")]
        public Dom Dom { get; set; }
        /// <summary>
        /// Set a name for the instance for the group selector.<c>Default value: main</c>
        /// </summary>
        [DisplayName("name")]
        public string Name { get; set; }
    }
    /// <summary>
    /// Options to control the DOM structure Buttons creates.
    /// </summary>
    public class Dom
    {
        /// <summary>
        /// DOM configuration for individual button elements.<c>Examples: {tag: 'button', className: 'btn'}</c>
        /// </summary>
        [DisplayName("button")]
        public string Button { get; set; }
        /// <summary>
        /// DOM configuration of a button container element.<c>Examples: tag: 'li',className: 'button-item'}</c>
        /// </summary>
        [DisplayName("buttonContainer")]
        public string ButtonContainer { get; set; }
        /// <summary>
        /// DOM configuration of a button liner element.<c>Examples: {tag: 'i'}</c>
        /// </summary>
        [DisplayName("buttonLiner")]
        public string ButtonLiner { get; set; }
        /// <summary>
        /// DOM configuration of the collection display.<c>Examples: {tag: 'aside'}</c>
        /// </summary>
        [DisplayName("collection")]
        public string Collection { get; set; }
        /// <summary>
        /// DOM configuration of the Buttons container element.<c>Examples: {tag: 'aside'}</c>
        /// </summary>
        [DisplayName("container")]
        public string Container { get; set; }
    }
    /// <summary>
    /// Inner button
    /// </summary>
    public class InnerButtons
    {
        /// <summary>
        /// Action to take when the button is activated.<c>Default value: Default action depends upon the button type.Please refer to the button type documentation.Examples: function ( e, dt, node, config ) {alert( 'Activated!' );this.disable(); // disable button} </c>
        /// </summary>
        [DisplayName("action")]
        public string BtnAction { get; set; }
        /// <summary>
        /// Collection of attribute key / values to set for a button.<c>Example: {title: 'Copy',id: 'copyButton'}</c>
        /// </summary>
        [DisplayName("attr")]
        public string Attr { get; set; }
        /// <summary>
        /// Ensure that any requirements have been satisfied before initializing a button.<c>Example: function ( dt, config ) {return window.FileReader !== undefined;}</c>
        /// </summary>
        [DisplayName("available")]
        public string Available { get; set; }
        /// <summary>
        /// Set the class name for the button.<c>Examples: 'copyButton'</c>
        /// </summary>
        [DisplayName("className")]
        public string ClassName { get; set; }
        /// <summary>
        /// Function that is called when the button is destroyed.<c>Example: function ( dt, node, config ) {node.off( 'mouseenter'+config.namespace );node.off( 'mouseleave'+config.namespace );}</c>
        /// </summary>
        [DisplayName("destroy")]
        public string Destroy { get; set; }
        /// <summary>
        /// Set a button's initial enabled state.<c>Default value: true</c>
        /// </summary>
        [DisplayName("enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Define which button type the button should be based on.<c>Example: 'excel'</c>
        /// </summary>
        [DisplayName("extend")]
        public string Extend { get; set; }
        /// <summary>
        /// Initialization function that can be used to add events specific to this button.<c>Example: function ( dt, node, config ) {var that = this;dt.on( 'select.dt.DT deselect.dt.DT', function(){that.enable(dt.rows( { selected: true } ).any());});this.disable();}</c>
        /// </summary>
        [DisplayName("init")]
        public string Init { get; set; }
        /// <summary>
        ///  Define an activation key for a button.<c>Example: 'p'</c>
        /// </summary>
        [DisplayName("key")]
        public string Key { get; set; }
        /// <summary>
        /// Set a name for each selection.<c>Example: 'printButton'</c>
        /// </summary>
        [DisplayName("name")]
        public string Name { get; set; }
        /// <summary>
        /// Unique namespace for every button.
        /// </summary>
        [DisplayName("namespace")]
        public string Namespace { get; set; }
        /// <summary>
        /// Set the tag for the button.<c>Example: 'a'</c>
        /// </summary>
        [DisplayName("tag")]
        public string Tag { get; set; }
        /// <summary>
        /// The text to show in the button.<c>Example: 'Copy to clipboard'</c>
        /// </summary>
        [DisplayName("text")]
        public string Text { get; set; }
        /// <summary>
        /// Button title attribute text.<c>Example: 'Copy'</c>
        /// </summary>
        [DisplayName("titleAttr")]
        public string TitleAttr { get; set; }
    }
    /// <summary>
    /// Options for Ajax
    /// </summary>
    public class AjaxHelperOptions
    {
        /// <summary>
        /// URL to set to be the Ajax data source for the table.
        /// </summary>
        [DisplayName("url")]
        public string Url { get; set; }
        /// <summary>
        /// Add or modify data submitted to the server upon an Ajax request.<c>Examples: {"user_id": 451} or function ( d ) {d.extra_search = $('#extra').val();}</c>
        /// </summary>
        [DisplayName("data")]
        public string Data { get; set; }
        /// <summary>
        /// An alias for method.<c>Default values: Get</c>
        /// </summary>
        [DisplayName("type")]
        public string Type { get; set; }
        /// <summary>
        /// The type of data that you're expecting back from the server.<c>Examples: jsonp</c>
        /// </summary>
        [DisplayName("dataType")]
        public string DataType { get; set; }
        /// <summary>
        /// Data property or manipulation method for table data.<c>Examples: "dataSrc": "tableData"</c>
        /// </summary>
        [DisplayName("dataSrc")]
        public string DataSrc { get; set; }
    }
    /// <summary>
    /// Enable and configure the AutoFill extension for DataTables.
    /// </summary>
    public class AutoFillOptions
    {
        /// <summary>
        /// Always ask the end user if an action should be taken or not.<c>Default value: false</c>
        /// </summary>
        [DisplayName("alwaysAsk")]
        public bool? AlwaysAsk { get; set; }
        /// <summary>
        /// Select the columns that can be auto filled.<c>Default value: Empty string (i.e.all columns)</c>
        /// </summary>
        [DisplayName("columns")]
        public string Columns { get; set; }
        /// <summary>
        /// Attach an Editor instance for database updating.<c>Default value: null</c>
        /// </summary>
        [DisplayName("editor")]
        public string Editor { get; set; }
        /// <summary>
        /// Initial enablement state of AutoFill.<c>Default value: true</c>
        /// </summary>
        [DisplayName("enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Action that will cause the auto fill drag handle to appear in a cell.<c>Default value: null</c>
        /// </summary>
        [DisplayName("focus")]
        public string Focus { get; set; }
        /// <summary>
        /// Enable / disable user ability to horizontally drag and fill.<c>Default value: true</c>
        /// </summary>
        [DisplayName("horizontal")]
        public bool? Horizontal { get; set; }
        /// <summary>
        /// Control automatic of data when a fill drag is completed.<c>Default value: true</c>
        /// </summary>
        [DisplayName("update")]
        public bool? Update { get; set; }
        /// <summary>
        /// Enable/disable user ability to vertically drag and fill.<c>Default value: true</c>
        /// </summary>
        [DisplayName("vertical")]
        public bool? Vertical { get; set; }
    }
    /// <summary>
    /// Language AutoFill
    /// </summary>
    public class LanguageAutoFill
    {
        /// <summary>
        /// Multi-fill selector button text.<c>Default value: &gt; </c>
        /// </summary>
        [DisplayName("button")]
        public string Button { get; set; }
        /// <summary>
        /// Multi-fill selector cancel option message.<c>Default value: Cancel</c>
        /// </summary>
        [DisplayName("cancel")]
        public string Cancel { get; set; }
        /// <summary>
        /// Multi-fill selector message for the full fill fill type.<c>Default value: Fill all cells with &gt;i&lt;{data}&gt;/i&lt; </c>
        /// </summary>
        [DisplayName("fill")]
        public string Fill { get; set; }
        /// <summary>
        /// Multi-fill selector message for the horizontal fill fill type.<c>Default value: Fill cells horizontally</c>
        /// </summary>
        [DisplayName("fillHorizontal")]
        public string FillHorizontal { get; set; }
        /// <summary>
        /// Multi-fill selector message for the vertical fill fill type.<c>Default value: Fill cells vertically</c>
        /// </summary>
        [DisplayName("fillVertical")]
        public string FillVertical { get; set; }
        /// <summary>
        /// Multi-fill selector message for the increment fill type.<c>Default value: Increment / decrement each cell by: &gt;input type = 'number' value='1'&lt;</c>
        /// </summary>
        [DisplayName("increment")]
        public string Increment { get; set; }
        /// <summary>
        /// Information message shown at the top of the fill type selector.<c>Default value: </c>
        /// </summary>
        [DisplayName("info")]
        public string Info { get; set; }
    }
    /// <summary>
    /// Language options
    /// </summary>
    public class LanguageOptions
    {
        /// <summary>
        ///  Container object for language strings used by AutoFill.<c></c>
        /// </summary>
        [DisplayName("autoFill")]
        public LanguageAutoFill AutoFill { get; set; }
        /// <summary>
        /// Container object for language strings used by Select.
        /// </summary>
        [DisplayName("select")]
        public LanguageSelect Select { get; set; }
    }
    /// <summary>
    /// Container object for language strings used by Select.
    /// </summary>
    public class LanguageSelect
    {
        /// <summary>
        /// Table information summary string for the number of cells selected.<c>Example: "%d cells selected"</c>
        /// </summary>
        [DisplayName("cells")]
        public string Cells { get; set; }
        /// <summary>
        /// Table information summary string for the number of columns selected.<c>Example: "%d columns selected"</c>
        /// </summary>
        [DisplayName("columns")]
        public string Columns { get; set; }
        /// <summary>
        /// Table information summary string for the number of rows selected.<c>Example: "%d rows selected"</c>
        /// </summary>
        [DisplayName("rows")]
        public string Rows { get; set; }
    }
    /// <summary>
    /// Set an initial filter in DataTables and/or filtering options.
    /// </summary>
    public class SearchOption
    {
        /// <summary>
        /// Control case-sensitive filtering option.<c>Default value:true</c>
        /// </summary>
        [DisplayName("caseInsensitive")]
        public bool? CaseInsensitive { get; set; }
        /// <summary>
        /// Enable / disable escaping of regular expression characters in the search term.<c>Default value: false</c>
        /// </summary>
        [DisplayName("regex")]
        public bool? Regex { get; set; }
        /// <summary>
        /// Set an initial filtering condition on the table.<c></c>
        /// </summary>
        [DisplayName("search")]
        public string Search { get; set; }
        /// <summary>
        /// Enable/disable DataTables' smart filtering.<c>Default value: true</c>
        /// </summary>
        [DisplayName("smart")]
        public bool? Smart { get; set; }
    }
    /// <summary>
    /// DataTables - Columns.
    /// </summary>
    public class DataColumns
    {
        /// <summary>
        /// Cell type to be created for a column.
        /// </summary>
        [DisplayName("cellType")]
        public string CellType { get; set; }
        /// <summary>
        /// Class to assign to each cell in the column.<c>Default value: td</c>
        /// </summary>
        [DisplayName("className")]
        public string ClassName { get; set; }
        /// <summary>
        /// Add padding to the text content used when calculating the optimal with for a table.<c>Example: 'mmm'</c>
        /// </summary>
        [DisplayName("contentPadding")]
        public string ContentPadding { get; set; }
        /// <summary>
        /// Cell created callback to allow DOM manipulation.<c>Example: function (td, cellData, rowData, row, col) {if (cellData &gt; 1) {$(td).css('color', 'red')}}</c>
        /// </summary>
        [DisplayName("createdCell")]
        public string CreatedCell { get; set; }
        /// <summary>
        /// Set the data source for the column from the rows data object/array.<c>Default Takes the index value of the column automatically</c>
        /// </summary>
        [DisplayName("data")]
        public string Data { get; set; }
        /// <summary>
        /// Set default, static, content for a column.<c>Examples: "<i>Not set</i>"</c>
        /// </summary>
        [DisplayName("defaultContent")]
        public string DefaultContent { get; set; }
        /// <summary>
        /// Set a descriptive name for a column.
        /// </summary>
        [DisplayName("name")]
        public string Name { get; set; }
        /// <summary>
        /// Enable or disable ordering on this column.<c>Default value: true</c>
        /// </summary>
        [DisplayName("orderable")]
        public bool? Orderable { get; set; }
        /// <summary>
        /// Define multiple column ordering as the default order for a column.<c>Default Takes the index value of the column automatically</c>
        /// </summary>
        [DisplayName("orderData")]
        public string OrderData { get; set; }
        /// <summary>
        /// Live DOM sorting type assignment.<c>Examples: "dom-select"</c>
        /// </summary>
        [DisplayName("orderDataType")]
        public string OrderDataType { get; set; }
        /// <summary>
        /// Order direction application sequence.<c>Default value: [ 'asc', 'desc' ]</c>
        /// </summary>
        [DisplayName("orderSequence")]
        public string OrderSequence { get; set; }
        /// <summary>
        /// Render (process) the data for use in the table.<c>Examples: function ( data, type, row, meta ) {return '&lt;a href="'+data+'"&gt;Download'&lt;/a&gt;';}</c>
        /// </summary>
        [DisplayName("render")]
        public string Render { get; set; }
        /// <summary>
        /// Enable or disable filtering on the data in this column.<c>Default value: true</c>
        /// </summary>
        [DisplayName("searchable")]
        public bool? Searchable { get; set; }
        /// <summary>
        /// Set the column title.<c>Default Value read from the column's header cell.</c>
        /// </summary>
        [DisplayName("title")]
        public string Title { get; set; }
        /// <summary>
        /// Set the column type - used for filtering and sorting string processing.<c>Default Auto-detected from raw data.</c>
        /// </summary>
        [DisplayName("type")]
        public string Type { get; set; }
        /// <summary>
        /// Enable or disable the display of this column.<c>Default value: true</c>
        /// </summary>
        [DisplayName("visible")]
        public bool? Visible { get; set; }
        /// <summary>
        /// Column width assignment.<c>Default Auto-detected from the table's content.</c>
        /// </summary>
        [DisplayName("width")]
        public string Width { get; set; }
        /// <summary>
        /// Set column's visibility priority.<c>Default value: undefined</c>
        /// </summary>
        [DisplayName("responsivePriority")]
        public int? ResponsivePriority { get; set; }
        /// <summary>
        /// Columns default constructor.
        /// </summary>
        public DataColumns()
        {
        }
        /// <summary>
        /// Columns constructor.
        /// </summary>
        /// <param name="name">Name field from data-source.</param>
        /// <param name="title">Title for column</param>
        public DataColumns(string name, string title) : this(name, title, null)
        {

        }
        /// <summary>
        /// Columns constructor.
        /// </summary>
        /// <param name="name">Name field from data-source.</param>
        public DataColumns(string name) : this(name, name, null)
        {

        }
        /// <summary>
        /// Columns constructor.
        /// </summary>
        /// <param name="name">Name field from data-source.</param>
        /// <param name="title">Title for column</param>
        /// <param name="visible" >Enable or disable the display of this column. default true</param>
        public DataColumns(string name, string title, bool? visible)
        {
            Name = name;
            Data = name;
            Title = title;
            Visible = visible;
        }
    }
}
