using Data.Context;
using Domain.Entities;
using Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace Data.Repositories {
    public class OperationLogRepository : IOperationLogRepository, IDisposable {
        protected readonly CentralizeLogContext centralizedLogContext;
        public OperationLogRepository(CentralizeLogContext centralizeLogContext) {
            this.centralizedLogContext = centralizeLogContext;
        }
        public IEnumerable<OperationLog> Get() {
            IEnumerable<OperationLog> operationLogList = this.centralizedLogContext.OperationLogs;
            Dispose();
            return operationLogList;
        }
        public void Post(OperationLog operationLog) {
            this.centralizedLogContext.Add(operationLog);
            this.centralizedLogContext.SaveChanges();
            Dispose();
        }
        public void Dispose() {
            if (this.centralizedLogContext != null) {
                this.centralizedLogContext.Dispose();
            }
        }
    }
}
