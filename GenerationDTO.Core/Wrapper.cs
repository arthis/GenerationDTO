using System.Collections.Generic;

namespace GenerationDTO.Core
{
    public class EventWrapper
    {
        public string Namespace { get; set; }
        public List<EventDTO> Events { get; set; }
    }
}