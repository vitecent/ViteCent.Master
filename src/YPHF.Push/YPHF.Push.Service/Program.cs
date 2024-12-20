/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using YPHF.Core.Web;

namespace YPHF.Push.Service
{
    /// <summary>
    /// </summary>
    public class Program
    {
        /// <summary>
        /// </summary>
        /// <param name="args"></param>
        public static async Task Main(string[] args)
        {
            var xmls = new List<string>()
            {
                //"YPHF.Push.Service"
            };

            var microService = new BaseMicroService("YPHF.Push.Service", xmls)
            {
                OnBuild = (builder) =>
                {
                    builder.UseAutoMapper(typeof(AutoMapperConfig));
                    builder.UseAutoFac(new AutoFacConfig());
                }
            };

            await microService.RunAsync(args);
        }
    }
}