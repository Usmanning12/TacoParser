namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array's Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log error message and return null
                logger.LogWarning("Less than three items, incomplete data");
                return null; 
            }

            // Done: Grab the latitude from your array at index 0
            var tacoLongitude = double.Parse(cells[0]);
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            
            
            // Done: Grab the longitude from your array at index 1
            var tacoLatitude = double.Parse(cells[1]);
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            
            
            // Done: Grab the name from your array at index 2
            var Name = cells[2];
            

            // Done: Create a TacoBell class
            
            // that conforms to ITrackable
            
            // Done: Create an instance of the Point Struct
            // Done: Set the values of the point correctly (Latitude and Longitude) 

            // Done : Create an instance of the TacoBell class
            var point = new Point();
            point.Latitude = tacoLatitude;
            point.Longitude = tacoLongitude;
            
            var tacoBell = new TacoBell();
            tacoBell.Name = Name;
            tacoBell.Location = point; 
            // Done : Set the values of the class correctly (Name and Location)

            // Done : Then, return the instance of your TacoBell class,
            //  since it conforms to ITrackable

            return tacoBell;
        }
    }
}
