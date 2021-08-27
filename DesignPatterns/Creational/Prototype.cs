using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    public class Zed : ICloneable
    {
        public Vector3 Position { get; set; }
        public string Id { get; set; }
        public string PlayerName { get; set; }


        public Zed(Vector3 pos, string id, string playerName)
        {
            Position = pos;
            Id = id;
            PlayerName = playerName;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
