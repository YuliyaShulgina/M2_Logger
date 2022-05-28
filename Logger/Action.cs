using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class Actions
    {
        public Result First()
        {
            Logger.Instance.Log(DateTime.Now, LogType.Info, $"Start method{nameof(First)}");
            return new Result
            {
                Status = true
            };
        }
        public Result Second()
        {
            Logger.Instance.Log(DateTime.Now, LogType.Warn, $"Skipped logic in method{nameof(Second)}");
            return new Result
            {
                Status = true
            };
        }
        public Result Third()
        {
            Logger.Instance.Log(DateTime.Now, LogType.Warn, $"I broke a logic{nameof(Third)}");
            return new Result
            {
                Status = false,
                ErrorMessage = "broken"
            };
        }
        public Result Starter()
        {
            return new Result
            {
                Status = false,
                ErrorMessage = "broken"
            };
        }
    }
}
