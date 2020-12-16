using System.Web.Mvc;

namespace DataTables.Helpers.Model
{
    internal class JsScript
    {
        internal static TagBuilder Script<TModel>(string id, DataTablesOptions<TModel> options)
        {
            var getOptions = Options.SetUp(options);
            return GetScript(id,getOptions);
        }

        internal static TagBuilder Script(string id, DataTablesOptions options)
        {
            var getOptions = Options.SetUp(options);
            return GetScript(id, getOptions);
        }

        private static TagBuilder GetScript(string id, string options)
        {
            var script = new TagBuilder("script")
            {
                Attributes = { ["type"] = "text/javascript" },
                InnerHtml = $@"$(document).ready(function (){{
                                              $('#{id}').DataTable({{
                                                {options}
                                              }});
                                }});"
            };
            return script;
        }
    }

}
