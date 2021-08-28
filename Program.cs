using System;

namespace Otus30
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public interface IMyCloneable
        {
            public object Clone();
        }
        /// <summary>
        ///     Помещение
        /// </summary>
        public class Placement:IMyCloneable
        {
            /// <summary>
            ///     Площадь
            /// </summary>
            public double Area { get; set; }

            public virtual object Clone()
            {
                return new Placement
                {
                    Area = Area
                };
            }
        }

        /// <summary>
        ///     Жилое помещение
        /// </summary>
        public class Accomodation : Placement
        {
            /// <summary>
            ///     Количество комнат
            /// </summary>
            public int RoomCount { get; set; }

            public override object Clone()
            {
                return base.Clone();
            }
        }

        /// <summary>
        ///     Квартира
        /// </summary>
        public class Flat : Accomodation
        {
            /// <summary>
            ///     Этаж
            /// </summary>
            public int Floor { get; set; }
        }

        /// <summary>
        ///     Дом
        /// </summary>
        public class House : Accomodation
        {
            /// <summary>
            ///     Площадь участка
            /// </summary>
            public double BackyardArea { get; set; }
        }

        /// <summary>
        ///     Гараж
        /// </summary>
        public class Garage : Placement
        {
            /// <summary>
            ///     Отопление
            /// </summary>
            public bool Heating { get; set; }
        }
    }
}