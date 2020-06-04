using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Repositories.Interfaces {
    public interface IExceptionLogRepository {
        IEnumerable<ExceptionLog> Get();
        void Post(ExceptionLog exceptionLog);
    }
}
