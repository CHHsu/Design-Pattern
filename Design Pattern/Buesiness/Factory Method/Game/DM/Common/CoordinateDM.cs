using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Buesiness.Factory_Method.Game
{
    public class CoordinateDM
    {
        int _xCoordinate;
        int _yCoordinate;

        public CoordinateDM(int xCoordinate, int yCoordinate)
        {
            _xCoordinate = xCoordinate;
            _yCoordinate = yCoordinate;
        }

        public string DisplayStr() { return $"({_xCoordinate},{_yCoordinate})"; }
    }
}
