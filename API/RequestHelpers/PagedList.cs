using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.RequestHelpers
{
    public class PagedList<T> : List<T>
    {
        public PagedList(List<T> items, int count, int pageNumber, int PageSize)
        {
            MetaData = new MetaData
            {
                TotalCount = count,
                PageSize = PageSize,
                CurrentPage = pageNumber,
                TotalPages = (int)Math.Ceiling(count / (double)PageSize)
            };
            AddRange(items);
        }

        public MetaData MetaData { get; set; }

        public static async Task<PagedList<T>> ToPagedList(IQueryable<T> query,
         int pageNumber, int PageSize)
         {
            var count = await query.CountAsync();
            var items = await query.Skip((pageNumber-1)*PageSize).Take(PageSize).ToListAsync();
            return new PagedList<T>(items, count, pageNumber, PageSize);
         }
    }
}