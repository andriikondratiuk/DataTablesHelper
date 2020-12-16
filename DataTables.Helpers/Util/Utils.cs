using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace DataTables.Helpers.Util
{
    internal static class Utils
    {
        internal static string GetPropName(PropertyInfo property)
        {
            var name = property.Name;
            var displayName = (DisplayNameAttribute) property.GetCustomAttribute(typeof(DisplayNameAttribute));
            if (displayName != null)
            {
                name = displayName.DisplayName;
            }
            return name;
        }

        internal static object GetValue(PropertyInfo prop, object value)
        {
            if (prop.PropertyType == typeof(string))
            {
                if(!value.ToString().StartsWith("[") && !value.ToString().StartsWith("{") && !value.ToString().StartsWith("function"))
                    value = $"\"{value}\"";
            }
            else if (prop.PropertyType == typeof(bool) || prop.PropertyType == typeof(bool?))
            {
                value = value.ToString().ToLower();
            }
            else if (prop.PropertyType == typeof(string[]))
            {
                var result = new StringBuilder("[");
                foreach (var s in (string[])value)
                {
                    result.Append($"\"{s}\",");
                }
                result.Length--;
                value = result.Append("]");
            }
            else if (prop.PropertyType == typeof(int[]))
            {
                var result = new StringBuilder("[");
                foreach (var s in (int[])value)
                {
                    result.Append($"{s},");
                }
                result.Length--;
                value = result.Append("]");
            }
            return value;
        }
    }
}
