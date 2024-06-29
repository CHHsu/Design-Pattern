using Design_Pattern.Buesiness.Base;
using Design_Pattern.Buesiness.Factory_Method.Game.Enum;
using Design_Pattern.Buesiness.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Buesiness.Factory_Method.Game.Example.FactoryEnemy
{
    public class ExFactoryEnemy : BasePractice
    {
        public override string Description()
        {
            var msg = new List<string>() { "用工廠統一產生敵人" };
            return string.Join(Environment.NewLine, msg);
        }

        public override string Disadvantage()
        {
            var msg = new List<string>() { "產生敵人方法集中在一起，新增敵人得再改邏輯", "錯誤訊息寫法重複" };
            return string.Join(Environment.NewLine, msg);
        }

        public override string Name()
        {
            return this.GetType().Name;
        }

        protected override void Init()
        {
            var factory = new SimpleFactory();

            List<IEnemy> list = new List<IEnemy>();
            list.Add(factory.Create(EnemyEnum.Tank));
            list.Add(factory.Create(EnemyEnum.Airplane));
            list.Add(factory.Create(EnemyEnum.Tank));
            list.Add(factory.Create(EnemyEnum.Airplane));
            list.Add(factory.Create(EnemyEnum.Tank));
            list.Add(factory.Create(EnemyEnum.Airplane));
            list.Add(factory.Create(EnemyEnum.Tank));
            list.Add(factory.Create(EnemyEnum.Airplane));

            foreach (IEnemy enemy in list)
            {
                enemy.Show();
                enemy.Attack();
            }
        }
    }
}
