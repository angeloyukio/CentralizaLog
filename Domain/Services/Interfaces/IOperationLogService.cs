using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Services.Interfaces {
    public interface IOperationLogService {
        IEnumerable<OperationLog> Get();
        void Post(DateTime OperationDateTime, string LogedUser, string Note);
    }
}
