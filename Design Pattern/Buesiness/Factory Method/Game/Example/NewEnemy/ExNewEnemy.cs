using Design_Pattern.Buesiness.Base;
using Design_Pattern.Buesiness.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Buesiness.Factory_Method.Game
{
    public class ExNewEnemy : BasePractice
    {
        public override string Name()
        {
            return this.GetType().Name;
        }

        public override string Description()
        {
            var msg = new List<string>() { "用 new 產生遊戲敵人" };
            return string.Join(Environment.NewLine, msg);
        }

        public override string Disadvantage()
        {
            var msg = new List<string>() { "每個敵人都得 New 一次", "產生敵人位置需要自行設定", "錯誤訊息寫法重複" };
            return string.Join(Environment.NewLine, msg);
        }

        protected override void Init() {
            List<IEnemy> list = new List<IEnemy>();
            list.Add(new Tank(new CoordinateDM(10, 10)));
            list.Add(new Airplane(new CoordinateDM(10, 10)));
            list.Add(new Tank(new CoordinateDM(10, 10)));
            list.Add(new Airplane(new CoordinateDM(10, 10)));
            list.Add(new Tank(new CoordinateDM(10, 10)));
            list.Add(new Airplane(new CoordinateDM(10, 10)));
            list.Add(new Tank(new CoordinateDM(10, 10)));
            list.Add(new Airplane(new CoordinateDM(10, 10)));

            foreach (IEnemy enemy in list)
            {
                enemy.Show();
                enemy.Attack();
            }
        }
    }
}
