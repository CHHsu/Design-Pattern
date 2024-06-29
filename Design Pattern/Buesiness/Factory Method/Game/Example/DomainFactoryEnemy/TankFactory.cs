
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Buesiness.Factory_Method.Game.Example.DomainFactoryEnemy
{
    public class TankFactory : IFactory
    {
        int _width;
        int _height;

        public TankFactory(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public IEnemy Create()
        {
            var x = new Random().Next(_width);
            var y = new Random().Next(_height);
            var dm = new CoordinateDM(x, y);
            return new Tank(dm);
        }
    }
}
