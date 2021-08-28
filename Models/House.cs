using System;

namespace Otus30.Models
{
    /// <summary>
    ///     Дом
    /// </summary>
    public class House : Accomodation, IMyCloneable<House>, ICloneable
    {
        public House(double area, int roomCount, double backyardArea) : base(area, roomCount)
        {
            BackyardArea = backyardArea;
        }

        /// <summary>
        ///     Площадь участка
        /// </summary>
        public double BackyardArea { get; set; }

        public new object Clone()
        {
            return MyClone();
        }

        public override House MyClone()
        {
            return new House(Area, RoomCount, BackyardArea);
        }
    }
}