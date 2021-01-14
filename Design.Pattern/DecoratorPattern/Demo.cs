using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.DecoratorPattern
{
    public static class Demo
    {
        public static void BuildTakn()
        {
            var t50 = new T50("T50 tank");
            var da = new InfraredFunctionTank(t50); // 有红外功能
            var db = new AmphibiousFunctionTakn(da);  // 有红外且有 两栖功能
        }
    }
}
