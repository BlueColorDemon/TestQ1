using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;

namespace IQGT_Web.Utils
{
    public class CommonLinq
    {
        /// <summary>
        /// 动态排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">数据源</param>
        /// <param name="propertyName">排序字段</param>
        /// <param name="asc">排序方式</param>
        /// <returns></returns>
        public static IEnumerable<T> Sort<T>(IEnumerable<T> source, string propertyName, bool asc)
        {
            Func<T, object> func = s => s.GetType().GetProperty(propertyName).GetValue(s, null);
            if (asc)
                return source.OrderBy(func);
            return source.OrderByDescending(func);
        }

        public static IQueryable<T> DataSorting<T>(IQueryable<T> source, string sortExpression, string sortDirection)
        {
            string sortingDir = string.Empty;
            if (sortDirection.ToUpper().Trim() == "ASC")
                sortingDir = "OrderBy";
            else if (sortDirection.ToUpper().Trim() == "DESC")
                sortingDir = "OrderByDescending";
            ParameterExpression param = Expression.Parameter(typeof(T), sortExpression);
            PropertyInfo pi = typeof(T).GetProperty(sortExpression);
            Type[] types = new Type[2];
            types[0] = typeof(T);
            types[1] = pi.PropertyType;
            Expression expr = Expression.Call(typeof(Queryable), sortingDir, types, source.Expression, Expression.Lambda(Expression.Property(param, sortExpression), param));
            IQueryable<T> query = source.AsQueryable().Provider.CreateQuery<T>(expr);
            return query;
        }

    }
}