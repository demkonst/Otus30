using System;

namespace Otus30.Models
{
    /// <summary>
    ///     Жилое помещение
    /// </summary>
    public class Accomodation : Placement, IMyCloneable<Accomodation>, ICloneable
    {
        public Accomodation(double area, int roomCount) : base(area)
        {
            RoomCount = roomCount;
        }

        /// <summary>
        ///     Количество комнат
        /// </summary>
        public int RoomCount { get; set; }

        public new object Clone()
        {
            return MyClone();
        }

        public override Accomodation MyClone()
        {
            return new Accomodation(Area, RoomCount);
        }
    }
}