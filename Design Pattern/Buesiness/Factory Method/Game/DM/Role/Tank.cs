using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Buesiness.Factory_Method.Game
{
    public class Tank : IEnemy
    {
        CoordinateDM coordinateDM;

        public Tank(CoordinateDM coordinateDM)
        {
            this.coordinateDM = coordinateDM;
        }

        public void Attack()
        {
            Console.WriteLine($"{Category()}, Cannonball Attack!");
        }

        public string Category()
        {
            return this.GetType().Name;
        }

        public void Show()
        {
            Console.WriteLine($"{Category()}, Show! {coordinateDM.DisplayStr()}");
        }
    }
}
