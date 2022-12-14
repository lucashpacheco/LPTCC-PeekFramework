using System.Collections.Generic;

namespace Peek.Framework.Common.Responses
{
    public class PagedResult<T>
    {
        public int TotalItems { get; set; }
        public List<T> Result { get; set; }
    }
}
