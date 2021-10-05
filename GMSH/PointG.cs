using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcGmsh
{
   public class PointG : IEntityG
   {
      public object Id { get; set; }
      public string GeoString { get => GetGeoString(); }
      public double Step { get; set; }
      public double X { get;}
      public double Y { get;}
      public double Z { get;}
      public EntityGType Type => EntityGType.point;

      public PointG(double x, double y, double z, int id = 0, double st = 1000)
      {
         Step = st;
         Id = id;
         X = x;
         Y = y;
         Z = z;
      }

      public PointG(Autodesk.AutoCAD.Geometry.Point3d src, int id = 0, double st = 1000)
      {
         Step = st;
         Id = id;
         X = src.X;
         Y = src.Y;
         Z = src.Z;
      }
      
      public PointG(Autodesk.AutoCAD.Geometry.Point2d src, int id = 0, double st = 1000)
      {
         Step = st;
         Id = id;
         X = src.X;
         Y = src.Y;
         Z = 0;
      }

      string GetGeoString()
      {
         return $"Point({Id}) = " + "{" + $"{X}, {Y}, {Z}, {Step}" + "};";
      }
   }
}
