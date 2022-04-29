using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_SNAFELP {
    public class OpenError_SQL_Server_SNAFELP_Exception: SqlServer_SNAFELP_Exception {

        public OpenError_SQL_Server_SNAFELP_Exception() {

        }

        public OpenError_SQL_Server_SNAFELP_Exception(string message) : base(message) {

        }

        public OpenError_SQL_Server_SNAFELP_Exception(string message, Exception innerException) : base(message, innerException) {

        }

        protected OpenError_SQL_Server_SNAFELP_Exception(SerializationInfo info, StreamingContext context) : base(info, context) {

        }

    }
}
