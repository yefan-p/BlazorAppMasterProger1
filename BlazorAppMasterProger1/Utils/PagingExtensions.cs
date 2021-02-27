using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorAppMasterProger1.Utils
{
    public static class PagingExtensions
    {
        /// <summary>
        /// Вернуть старницу с объектами
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source">Источник данных</param>
        /// <param name="page">Текущий номер страницы</param>
        /// <param name="pageSize">Размер страницы</param>
        /// <returns>Возвращает коллекцию объектов с заданными ограничениями</returns>
        public static IQueryable<TSource> Page<TSource>(this IQueryable<TSource> source, int page, int pageSize)
        {
            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }

        /// <summary>
        /// Число страниц в пагинаторе
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source">Источник</param>
        /// <param name="pageSize">Размер страниц</param>
        /// <returns>Возвращает число страниц для заданной коллекции</returns>
        public static int PageCount<TSource>(this IQueryable<TSource> source, int pageSize)
        {
            int result = (int)Math.Ceiling(source.Count() / (double)pageSize);
            return result;
        }

        public static IEnumerable<TSource> Page<TSource>(this IEnumerable<TSource> source, int page, int pageSize)
        {
            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }

        public static int PageCount<TSource>(this IEnumerable<TSource> source, int pageSize)
        {
            int result = (int)Math.Ceiling(source.Count() / (double)pageSize);
            return result;
        }
    }
}
