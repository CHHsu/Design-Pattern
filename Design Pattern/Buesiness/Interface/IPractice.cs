using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Buesiness.Interface
{
    public interface IPractice
    {
        string Name();
        string Description();
        string Disadvantage();
        void Run(Action<IPractice> actionBeforeRun, Action<IPractice> actionAfterRun);
    }
}
