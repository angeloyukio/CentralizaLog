using Data.Context;
using Domain.Entities;
using Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace Data.Repositories {
    public class ExceptionLogRepository : IExceptionLogRepository, IDisposable {
        protected readonly CentralizeLogContext centralizeLogContext;
        public ExceptionLogRepository(CentralizeLogContext centralizeLogContext) {
            this.centralizeLogContext = centralizeLogContext;
        }
        public IEnumerable<ExceptionLog> Get() {
            IEnumerable<ExceptionLog> exceptionLogList = this.centralizeLogContext.ExceptionLogs;
            Dispose();
            return exceptionLogList;
        }
        public void Post(ExceptionLog exceptionLog) {
            this.centralizeLogContext.Add(exceptionLog);
            this.centralizeLogContext.SaveChanges();
            Dispose();
        }
        public void Dispose() {
            this.centralizeLogContext.Dispose();
        }
    }
}
