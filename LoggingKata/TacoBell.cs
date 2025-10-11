using System;
namespace LoggingKata
{
    public class TacoBell : ITrackable
    {
        public TacoBell()
        {
            throw new NotImplementedException();
        }
        
        public string Name { get; set; } 
        public Point Location { get; set; }
    
    }
}

