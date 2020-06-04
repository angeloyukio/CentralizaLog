using Domain.Entities;
using Domain.Repositories.Interfaces;
using Domain.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Domain.Services {
    public class OperationLogService : IOperationLogService {
        private readonly IOperationLogRepository operationLogRepository;

        public OperationLogService(IOperationLogRepository operationLogRepository) {
            this.operationLogRepository = operationLogRepository;
        }

        public IEnumerable<OperationLog> Get() {
            return this.operationLogRepository.Get();
        }

        public void Post(DateTime OperationDateTime
        , string LogedUser
        , string Note) {
            this.operationLogRepository.Post(
                new OperationLog(OperationDateTime, LogedUser, Note));
        }
    }
}
