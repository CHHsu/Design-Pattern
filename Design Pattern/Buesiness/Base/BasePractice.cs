using Design_Pattern.Buesiness.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Buesiness.Base
{
    public abstract class BasePractice : IPractice
    {
        public abstract string Description();
        public abstract string Disadvantage();
        public abstract string Name();
        public void Run(Action<IPractice> actionBeforeRun, Action<IPractice> actionAfterRun)
        {
            if (actionBeforeRun != null)
            {
                actionBeforeRun(this);
            }

            Init();

            if (actionAfterRun != null)
            {
                actionAfterRun(this);
            }
        }

        /// <summary>
        /// 初始範例
        /// </summary>
        protected abstract void Init();
    }
}
