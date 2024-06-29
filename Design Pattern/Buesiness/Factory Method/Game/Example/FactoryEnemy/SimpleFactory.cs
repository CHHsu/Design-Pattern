using Design_Pattern.Buesiness.Factory_Method.Game.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Buesiness.Factory_Method.Game.Example.FactoryEnemy
{
    public class SimpleFactory
    {
        int _MaxRandomValue = 10;
        public IEnemy Create(EnemyEnum enemyType) 
        {
            var x = new Random().Next(_MaxRandomValue);
            var y = new Random().Next(_MaxRandomValue);

            if (EnemyEnum.Airplane == enemyType) 
            {
                return new Airplane(new CoordinateDM(x, y));
            }
            else if (EnemyEnum.Tank == enemyType)
            {
                return new Tank(new CoordinateDM(x, y));
            }

            throw new NotImplementedException();
        }
    }
}
