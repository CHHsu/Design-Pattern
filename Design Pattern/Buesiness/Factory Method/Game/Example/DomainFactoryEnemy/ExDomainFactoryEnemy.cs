using Design_Pattern.Buesiness.Base;
using Design_Pattern.Buesiness.Factory_Method.Game.DM.Common.Map;
using Design_Pattern.Buesiness.Factory_Method.Game.Enum;
using Design_Pattern.Buesiness.Factory_Method.Game.Example.FactoryEnemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Buesiness.Factory_Method.Game.Example.DomainFactoryEnemy
{
    internal class ExDomainFactoryEnemy : BasePractice
    {
        public override string Description()
        {
            var msg = new List<string>() { "專業分工。每種敵人有自己製造工廠。" };
            return string.Join(Environment.NewLine, msg);
        }

        public override string Disadvantage()
        {
            var msg = new List<string>() { "需要 add 才能顯示新的敵人" };
            return string.Join(Environment.NewLine, msg);
        }

        public override string Name()
        {
            return this.GetType().Name;
        }

        protected override void Init()
        {
            int width = 10, length = 10;
            var tankFactory = new TankFactory(width, length);
            var airplaneFactory = new AirplaneFactory(width, length);

            List<IEnemy> list = new List<IEnemy>();

            list.Add(tankFactory.Create());
            list.Add(airplaneFactory.Create());
            list.Add(tankFactory.Create());
            list.Add(airplaneFactory.Create());
            list.Add(tankFactory.Create());
            list.Add(airplaneFactory.Create());
            list.Add(tankFactory.Create());
            list.Add(airplaneFactory.Create());

            foreach (IEnemy enemy in list)
            {
                enemy.Show();
                enemy.Attack();
            }
        }
    }
}
