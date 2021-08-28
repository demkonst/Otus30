using System;

namespace Otus30.Models
{
    /// <summary>
    ///     Гараж
    /// </summary>
    public class Garage : Placement, IMyCloneable<Garage>, ICloneable
    {
        public Garage(double area, bool heating) : base(area)
        {
            Heating = heating;
        }

        /// <summary>
        ///     Отопление
        /// </summary>
        public bool Heating { get; set; }

        public new object Clone()
        {
            return MyClone();
        }

        public override Garage MyClone()
        {
            return new Garage(Area, Heating);
        }
    }
}