using System.Collections;
using System.Linq;
using System.Text;
using DataTables.Helpers.Util;

namespace DataTables.Helpers.Model
{
    internal static class Options
    {
        internal static string SetUp<TModel>(DataTablesOptions<TModel> options)
        {
            var optionsBuilder = new StringBuilder();
            var msg = string.Empty;
            InitialOptions(options, ref msg);
            if (options.Data != null && options.Data.Any())
            {
                optionsBuilder.AppendLine($"'data': {InitialData(options)},");
            }
            optionsBuilder.AppendLine(msg);
            return optionsBuilder.ToString();
        }

        internal static string SetUp(DataTablesOptions options)
        {
            var optionsBuilder = new StringBuilder();
            var msg = string.Empty;
            InitialOptions(options, ref msg);
            optionsBuilder.AppendLine(msg);
            return optionsBuilder.ToString();
        }

        private static string InitialData<TModel>(DataTablesOptions<TModel> options)
        {
            var body = new StringBuilder();
            foreach (var row in options.Data)
            {
                var tr = new StringBuilder("{");
                foreach (var column in options.Columns)
                {
                    if (string.IsNullOrEmpty(column.Name)) continue;
                    var property = row.GetType().GetProperty(column.Name);
                    var value = (object)property != null ? property.GetValue(row, null)?.ToString()
                        .Replace("\\", @"\u005c")  // Because it JS string escape character
                        .Replace("\"", @"\u0022")  // Because it may be string delimiter
                        .Replace("'", @"\u0027")   // Because it may be string delimiter
                        .Replace("&", @"\u0026")   // Because it may interfere with HTML parsing
                        .Replace("<", @"\u003c")   // Because it may interfere with HTML parsing
                        .Replace(">", @"\u003e")   // Because it may interfere with HTML parsing;
                        : string.Empty; 
                    tr.Append($@"""{column.Name}"":""{value}"",");
                }
                tr.Length--;
                tr.Append("},");
                body.Append(tr);
            }
            body.Length--;
            return $"[{body}]";
        }        

        private static void InitialOptions(object obj, ref string msg)
        {
            if (obj == null) return;
            var objType = obj.GetType();
            var properties = objType.GetProperties();
            foreach (var property in properties)
            {
                var propValue = property.GetValue(obj, null);
                if (propValue == null) continue;
                var propName = Utils.GetPropName(property);
                if(propName == "Data") continue;
                msg += $"'{propName}':";
                if (propValue is IList elems)
                {
                    msg += "[";
                    foreach (var item in elems)
                    {
                        msg += "{";
                        msg += propName == "columnDefs" ? $"'targets':{elems.IndexOf(item)}," : "";
                        InitialOptions(item, ref msg);
                        msg += "},";
                    }
                    msg = msg.TrimEnd(',');
                    msg += "],";
                }
                else
                {
                    if (property.PropertyType.Assembly == objType.Assembly)
                    {
                        msg += "{";
                        InitialOptions(propValue, ref msg);
                        msg += "},";
                    }
                    else
                    {
                        msg += $"{Utils.GetValue(property, propValue)},";
                    }
                }
            }
            msg = msg.TrimEnd(',');
        }
    }
}
