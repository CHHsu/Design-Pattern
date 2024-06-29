using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Buesiness.Factory_Method.Game
{
    public interface IEnemy
    {
        string Category();
        void Show();
        void Attack();
    }
}
