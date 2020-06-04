using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Repositories.Interfaces {
    public interface IOperationLogRepository {
        IEnumerable<OperationLog> Get();
        void Post(OperationLog operationLog);
    }
}
