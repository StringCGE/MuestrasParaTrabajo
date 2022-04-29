using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization; 
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_SNAFELP {
    public class SNAFELP_Exception: Exception {
        public SNAFELP_Exception() {
            //hola que hace, una excepcion o que hace
        }

        public SNAFELP_Exception(string message) : base(message) {
            //no pos guau, aqui va tu mensaje personalizado
        }

        public SNAFELP_Exception(string message, Exception innerException) : base(message, innerException) {
            //En google te dice que es innerException 
        }

        protected SNAFELP_Exception(SerializationInfo info, StreamingContext context) : base(info, context) {
            //Cuando no sabes que comentar pero aun comentas lo que puedes
        }
    }
}
