using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Peek.Framework.Common.Request
{
    public class PageInformation
    {
        [JsonIgnore]
        public int Offset
        {
            get
            {
                return (Page - 1) * PageSize;
            }
        }

        [Range(1, int.MaxValue, ErrorMessage = "Please enter a number higher than 0")]
        public int Page { get; set; }

        [Range(2, int.MaxValue, ErrorMessage = "Please enter a number higher than 2")]
        public int PageSize { get; set; }

    }
}
