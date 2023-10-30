//PAGINATIN WIP~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using System.Collections.Generic;

// namespace AnimalShelterApi
// {
//   public class PagedList<T> : List<T>
//   {
//     public int CurrentPage { get; private set; }
//     public int TotalPages { get; private set; }
//     public int PageSize { get; private set; }
//     public int TotalCount { get; private set; }

//     public bool HasPrevious => CurrentPage > 1;
//     public bool HasNext => CurrentPage < TotalPages;

//     public PagedList(List<T> pets, int count, int pageNumber, int pageSize)
//     {
//       TotalCount = count;
//       PageSize = pageSize;
//       CurrentPage = pageNumber;

//       TotalPages = (int)Math.Ceiling(count / (double)pageSize);
//       AddRange(pets);
//     }
//     public static async Task<PagedList<T>> ToPagedListAsync(IQueryable<T> source, int pageNumber, int pageSize)
//     {
//       var count = await source.CountAsync();
//       var pets = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
//       return new PagedList<T>(pets, count, pageNumber, pageSize);
//     }
//   }
// } 