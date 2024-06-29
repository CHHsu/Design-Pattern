using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Buesiness.Factory_Method.Game.DM.Common.Map
{
    public class MapDM<T>
    {
        private T _Length;
        private T _Width;

        public MapDM(T length, T width)
        {
            _Length = length;
            _Width = width;
        }

        public T Length { get => _Length; set => _Length = value; }
        public T Width { get => _Width; set => _Width = value; }
    }
}
