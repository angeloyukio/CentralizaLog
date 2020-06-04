using System;

namespace Domain.Entities {
    public class OperationLog {
        #region Properties
        public int ID { get; set; }
        public DateTime OperationDateTime { get; set; }
        public string LogedUser { get; set; }
        public string Note { get; set; }
        #endregion

        #region Contructors
        public OperationLog() { }

        public OperationLog(DateTime operationDateTime, string logedUser, string note) {
            OperationDateTime = operationDateTime;
            LogedUser = logedUser;
            Note = note;
        }
        #endregion
    }
}
