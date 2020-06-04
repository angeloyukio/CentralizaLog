using Domain.Services.Interfaces;
using Domain.Entities;
using Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace Domain.Services {
    public class ExceptionLogService : IExceptionLogService{
        private readonly IExceptionLogRepository exceptionLogRepository;

        public ExceptionLogService(IExceptionLogRepository exceptionLogRepository) {
            this.exceptionLogRepository = exceptionLogRepository;
        }
        public IEnumerable<ExceptionLog> Get() {
            return this.exceptionLogRepository.Get();
        }
        public void Post(string Message, string InnerException, string StackTrace, DateTime ExceptionDateTime, string LogedUser, string Note) {
            this.exceptionLogRepository.Post(
                new ExceptionLog(
                    Message
                    , InnerException
                    , StackTrace
                    , ExceptionDateTime
                    , LogedUser
                    , Note));
        }
    }
}
