using AspNetCore.IQueryable.Extensions;
using AspNetCore.IQueryable.Extensions.Attributes;
using AspNetCore.IQueryable.Extensions.Filter;
using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;
using System.Text.Json.Serialization;

namespace IQueryable
{
    public class Car : ICustomQueryable, IQueryPaging, IQuerySort
    {
        [QueryOperator(Operator = WhereOperator.Contains)]
        [JsonPropertyName("marca")]
        public string? Marca { get; set; }

        [QueryOperator(Operator = WhereOperator.Contains)]
        [JsonPropertyName("modelo")]
        public string? Modelo { get; set; }

        public string? Sort { get; set; }
        public int? Limit { get; set; }
        public int? Offset { get; set; }
    }
}