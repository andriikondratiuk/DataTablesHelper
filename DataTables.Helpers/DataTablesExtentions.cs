using DataTables.Helpers.Model;
using System;
using System.Web.Mvc;

namespace DataTables.Helpers
{  
    /// <summary>
    /// Provides a mechanism to get DataTables.
    /// </summary>
    public static class DataTablesExtentions
    {
        /// <summary>
        /// Gets the DataTables.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <param name="id">Id table.</param>
        /// <param name="options">Options for create table.</param>
        /// <returns></returns>
        public static MvcHtmlString DataTables<TModel>(this HtmlHelper helper, string id, DataTablesOptions<TModel> options)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Empty: Id");
            }
            return Tables.Create(id, options);
        }

        /// <summary>
        /// Gets the DataTables.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <param name="id">Id table.</param>
        /// <param name="options">Options for create table.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        /// <returns></returns>
        public static MvcHtmlString DataTables<TModel>(this HtmlHelper helper, string id, DataTablesOptions<TModel> options, object htmlAttributes)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Empty: Id");
            }
            return Tables.Create(id, options, htmlAttributes);
        }

        /// <summary>
        /// Gets the DataTables.
        /// </summary>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <param name="id">Id table.</param>
        /// <param name="options">Options for create table.</param>
        /// <returns></returns>
        public static MvcHtmlString DataTables(this HtmlHelper helper, string id, DataTablesOptions options)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Empty: Id");
            }
            return Tables.Create(id, options);
        }

        /// <summary>
        /// Gets the DataTables.
        /// </summary>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <param name="id">Id table.</param>
        /// <param name="options">Options for create table.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        /// <returns></returns>
        public static MvcHtmlString DataTables(this HtmlHelper helper, string id, DataTablesOptions options, object htmlAttributes)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Empty: Id");
            }
            return Tables.Create(id, options, htmlAttributes);
        }
    }
}
