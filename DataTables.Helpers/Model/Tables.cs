using System.Collections.Generic;
using System.Web.Mvc;

namespace DataTables.Helpers.Model
{
    /// <summary>
    /// Table structure
    /// </summary>
    public static class Tables
    {
        /// <summary>
        /// Create table and initial script
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="id">Table Id.</param>
        /// <param name="options">Options for create table.</param>
        /// <returns>Table and inline script.</returns>
        internal static MvcHtmlString Create<TModel>(string id, DataTablesOptions<TModel> options)
        {
            return Build(id, options, null);
        }

        /// <summary>
        /// Create table and initial script
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="id">Table Id.</param>
        /// <param name="options">Options for create table.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        /// <returns>Table and inline script.</returns>
        internal static MvcHtmlString Create<TModel>(string id, DataTablesOptions<TModel> options, object htmlAttributes)
        {
            return Build(id, options, htmlAttributes);
        }

        /// <summary>
        /// Create table and initial script
        /// </summary>
        /// <param name="id">Table Id.</param>
        /// <param name="options">Options for create table.</param>
        /// <returns>Table and inline script.</returns>
        internal static MvcHtmlString Create(string id, DataTablesOptions options)
        {
            return Build(id, options, null);
        }

        /// <summary>
        /// Create table and initial script
        /// </summary>
        /// <param name="id">Table Id.</param>
        /// <param name="options">Options for create table.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        /// <returns>Table and inline script.</returns>
        internal static MvcHtmlString Create(string id, DataTablesOptions options, object htmlAttributes)
        {
            return Build(id, options, htmlAttributes);
        }

        private static MvcHtmlString Build(string id, DataTablesOptions options, object htmlAttributes)
        {
            var script = JsScript.Script(id, options);
            return BuildTable(id, script, htmlAttributes);
        }

        private static MvcHtmlString Build<TModel>(string id, DataTablesOptions<TModel> options, object htmlAttributes)
        {
            var script = JsScript.Script(id, options);
            return BuildTable(id, script, htmlAttributes);
        }

        private static MvcHtmlString BuildTable(string id, TagBuilder script, object htmlAttributes)
        {
            return new MvcHtmlString(Setup(id, script, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes)));
        }

        private static string Setup(string id, TagBuilder script, IDictionary<string, object> htmlAttributes)
        {
            var table = new TagBuilder("table");
            var thead = new TagBuilder("thead");
            var tbody = new TagBuilder("tbody");
            table.GenerateId(id);
            table.MergeAttributes(htmlAttributes);
            table.MergeAttribute("style", "width:100%");
            table.InnerHtml += thead;
            table.InnerHtml += tbody;
            return table.ToString()+script;
        }
    }
}
