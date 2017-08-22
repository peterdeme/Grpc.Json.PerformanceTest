using System;

namespace Shared
{
    public class SmallRequest
    {
        public string Message { get; set; }

        public static SmallRequest Create()
        {
            return new SmallRequest
            {
                Message = "SmallRequest"
            };
        }
    }
}
