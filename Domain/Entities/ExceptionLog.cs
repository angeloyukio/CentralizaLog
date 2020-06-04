using System;

namespace Domain.Entities {
    public class ExceptionLog {
        #region Properties
        public int ID { get; set; }
        public string Message { get; set; }
        public string InnerException { get; set; }
        public string StackTrace { get; set; }
        public DateTime ExceptionDateTime { get; set; }
        public string LogedUser { get; set; }
        public string Note { get; set; }
        #endregion

        #region Contructors
        public ExceptionLog() { }

        public ExceptionLog(string message, string innerException, string stackTrace, DateTime exceptionDateTime, string logedUser, string note) {
            Message = message;
            InnerException = innerException;
            StackTrace = stackTrace;
            ExceptionDateTime = exceptionDateTime;
            LogedUser = logedUser;
            Note = note;
        }
        #endregion
    }
}
