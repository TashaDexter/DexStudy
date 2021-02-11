using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneable
{
    struct Flat : ICloneable
    {
        public int Stage { get; set; }
        public int Number { get; set; }
        public Room Room1 { get; set; }
        public object Clone()
        {
            Room room1 = new Room { A = this.Room1.A, B = this.Room1.B };//для глубокого копирования
            return new Flat
            {
                Stage = this.Stage,
                Number = this.Number,
                Room1 = room1
            };
            //return this.MemberwiseClone(); поверхностное копирование
        }

    }
}
