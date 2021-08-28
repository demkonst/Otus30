using System;

namespace Otus30.Models
{
    /// <summary>
    ///     Квартира
    /// </summary>
    public class Flat : Accomodation, IMyCloneable<Flat>, ICloneable
    {
        public Flat(double area, int roomCount, int floor) : base(area, roomCount)
        {
            Floor = floor;
        }

        /// <summary>
        ///     Этаж
        /// </summary>
        public int Floor { get; set; }

        public new object Clone()
        {
            return MyClone();
        }

        public override Flat MyClone()
        {
            return new Flat(Area, RoomCount, Floor);
        }
    }
}