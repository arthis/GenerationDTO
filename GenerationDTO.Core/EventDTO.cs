using System.Collections.Generic;

namespace GenerationDTO.Core
{
    public class EventDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PropertyDTO> Properties { get; set; }


    }
}