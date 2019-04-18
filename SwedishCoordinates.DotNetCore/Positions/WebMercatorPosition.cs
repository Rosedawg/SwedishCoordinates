using SwedishCoordinates.Classes;

namespace SwedishCoordinates.Positions
{

    public class WebMercatorPosition : Position
    {
        public WebMercatorPosition(double y, double x)
            : base(y, x, Grid.WebMercator)
        {
        }
    }
}
