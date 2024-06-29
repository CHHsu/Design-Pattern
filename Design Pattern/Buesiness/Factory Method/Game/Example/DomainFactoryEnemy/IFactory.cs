using Design_Pattern.Buesiness.Factory_Method.Game.DM.Common.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Buesiness.Factory_Method.Game.Example.DomainFactoryEnemy
{
    public interface IFactory
    {
        IEnemy Create();
    }
}
