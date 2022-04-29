using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_SNAFELP {
    public class CloseError_SQL_Server_SNAFELP_Exception: SqlServer_SNAFELP_Exception {
        public CloseError_SQL_Server_SNAFELP_Exception() {
        }

        public CloseError_SQL_Server_SNAFELP_Exception(string message) : base(message) {
        }

        public CloseError_SQL_Server_SNAFELP_Exception(string message, Exception innerException) : base(message, innerException) {
        }

        protected CloseError_SQL_Server_SNAFELP_Exception(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
