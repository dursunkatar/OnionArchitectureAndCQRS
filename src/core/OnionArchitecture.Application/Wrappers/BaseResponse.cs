using System;

namespace OnionArchitecture.Application.Wrappers
{
    public class BaseResponse
    {
        public Guid Id { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
