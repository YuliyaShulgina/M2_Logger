using System;

namespace Logger
{
    partial class Program
    {
        public class Actions
        {
            public Result First()
            {
                Logger.Instance.Log(DateTime.Now, LogType.Info, $"{nameof(First)}");
                return new Result
                {
                    Status = true
                };
            }
            public Result Second()
            {
                Logger.Instance.Log(DateTime.Now, LogType.Warn, $"{nameof(Second)}");
                return new Result
                {
                    Status = true
                };
            }
            public Result Third()
            {
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
}
