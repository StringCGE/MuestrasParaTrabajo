using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_SNAFELP {
    public class SqlServer_SNAFELP_Exception: SNAFELP_Exception {
        public SqlServer_SNAFELP_Exception() {
        }

        public SqlServer_SNAFELP_Exception(string message) : base(message) {
        }

        public SqlServer_SNAFELP_Exception(string message, Exception innerException) : base(message, innerException) {
        }

        protected SqlServer_SNAFELP_Exception(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
