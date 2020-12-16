using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace DataTables.Helpers.Model
{
    /// <summary>
    /// Provides a mechanism to get DataTableAjaxModel.
    /// </summary>
    public static class SearchFunction
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="dataSource"></param>
        /// <param name="result"></param>
        /// <param name="totalCount"></param>
        /// <param name="filtered"></param>
        /// <returns></returns>
        public static void Search<T>(this DataTableAjaxModel model, IQueryable<T> dataSource, out IQueryable<T> result, out int totalCount, out int filtered)
        {
            if (dataSource == null)
                throw new ArgumentNullException(nameof(dataSource));
            totalCount = dataSource.Count();
            var take = model.Length;
            var skip = model.Start;
            //search
            dataSource = SearchData(model, dataSource);
            filtered = dataSource.Count();
            //sort
            dataSource = SortData(model, dataSource);
            //paging
            result = dataSource.Skip(skip).Take(take == -1 ? filtered : take);
        }

        private static IQueryable<T> SearchData<T>(DataTableAjaxModel model, IQueryable<T> dataSource)
        {
            if (!string.IsNullOrEmpty(model.Search?.Value))
            {
                var value = model.Search.Value;
                var type = typeof(T);
                var properties = type.GetProperties();
                BinaryExpression body = null;
                var p = Expression.Parameter(type);
                foreach (var prop in properties)
                {
                    BinaryExpression expression;
                    if (prop.PropertyType == typeof(int))
                    {
                        int.TryParse(value, out var val);
                        expression = GetBinaryExpression(p, prop, val);
                    }
                    else if (prop.PropertyType == typeof(string))
                    {
                        expression = GetBinaryExpression(p, prop, value);
                    }
                    else continue;

                    if (prop == properties.First())
                    {
                        body = expression;
                        continue;
                    }

                    body = Expression.OrElse(body ?? throw new InvalidOperationException(), expression);
                }

                var lambda = Expression.Lambda(body ?? throw new InvalidOperationException(), new[] {p});
                var whereCallExpression = Expression.Call(
                    typeof(Queryable),
                    "Where",
                    new[] {dataSource.ElementType},
                    dataSource.Expression,
                    Expression.Quote(lambda));
                dataSource = dataSource.Provider.CreateQuery<T>(whereCallExpression);
            }

            return dataSource;
        }

        private static BinaryExpression GetBinaryExpression(ParameterExpression p, PropertyInfo prop, object val)
        {
            var accessorExp = Expression.MakeMemberAccess(p, prop);
            return Expression.Equal(accessorExp, Expression.Constant(val));
        }

        private static IQueryable<T> SortData<T>(DataTableAjaxModel model, IQueryable<T> dataSource)
        {
            var sortBy = string.Empty;
            var sortDir = string.Empty;
            if (model.Order != null)
            {
                sortBy = model.Columns[model.Order[0].Column].Data;
                sortDir = model.Order[0].Dir?.ToLower() == "desc" ? "OrderByDescending" : "OrderBy";
                var type = typeof(T);
                var property = type.GetProperty(sortBy);
                var parameter = Expression.Parameter(type, "p");
                var propertyAccess = Expression.MakeMemberAccess(parameter, property ?? throw new InvalidOperationException());
                var orderByExp = Expression.Lambda(propertyAccess, parameter);
                var resultExp = Expression.Call(
                    typeof(Queryable), sortDir,
                    new[] { type, property.PropertyType },
                    dataSource.Expression, Expression.Quote(orderByExp));
                dataSource = dataSource.Provider.CreateQuery<T>(resultExp);
            }
            return dataSource;
        }
    }
}
