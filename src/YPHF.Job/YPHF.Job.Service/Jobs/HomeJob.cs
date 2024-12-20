/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using Quartz;

namespace YPHF.Job.Service.Jobs
{
    /// <summary>
    /// </summary>
    public class HomeJob : IJob
    {
        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
            await Task.CompletedTask;
        }
    }
}