using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain
{
    public class Streamer: BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Url { get; set; }

        public List<Video>? Videos { get; set; } // ICollection is an interface, List is a data structure
        // the interface is implemented in the runtime 
    }
}


