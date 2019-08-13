using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class ApiResult<T>
    {
        public T Result { get; set; }

        public bool IsSuccess
        {
            get
            {
                return !this.ErrorMessage.Any();
            }
        }

        public List<string> ErrorMessage { get; set; } = new List<string>();  //初始化List
    }
}