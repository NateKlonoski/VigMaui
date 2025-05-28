using GeoJSON.Text.Geometry;
using Point = GeoJSON.Text.Geometry.Point;

namespace MauiVigilant
{
    /// <summary>
    /// 	Describes an Alert Area(or Location) of concern.
    ///  If Polygon is NOT present, Point indicates a single location on a map (i.e., 'drop a pin').
    /// If Polygon is present, Point shall indicate the centroid of the polygonal area.
    /// </summary>
    public class CompactArea
    {
        public Polygon? Polygon { get; set; }
        public Point? Point { get; set; }
    }
}
