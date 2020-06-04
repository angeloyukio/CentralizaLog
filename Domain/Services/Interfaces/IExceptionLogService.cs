using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Services.Interfaces {
    public interface IExceptionLogService {
        IEnumerable<ExceptionLog> Get();
        void Post(string Message, string InnerException, string StackTrace, DateTime ExceptionDateTime, string LogedUser, string Note);
    }
}
