using System;

namespace Otus30.Models
{
    /// <summary>
    ///     Помещение
    /// </summary>
    public class Placement : IMyCloneable<Placement>, ICloneable
    {
        public Placement(double area)
        {
            Area = area;
        }

        /// <summary>
        ///     Площадь
        /// </summary>
        public double Area { get; set; }

        public object Clone()
        {
            return MyClone();
        }

        public virtual Placement MyClone()
        {
            return new Placement(Area);
        }
    }
}