using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationDTO.Core
{
    public class EventGenerator
    {
        private readonly EventWrapper _eventWrapper;
        private StringBuilder result;

        public EventGenerator (EventWrapper eventWrapper )
        {
            _eventWrapper = eventWrapper;
        }

        private void CreateHeader()
        {
            result.Append("using System;");
            result.Append("using System.Diagnostics.Contracts;");

        }

        

        
    }
}
