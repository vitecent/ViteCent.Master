/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using System.Text;
using YPHF.Core.Data;

namespace YPHF.Core
{
    /// <summary>
    /// </summary>
    public class BaseNet<T>
        where T : class
    {
        /// <summary>
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<T> GetAsync(string uri, string token = "")
        {
            var client = new HttpClient();

            if (!string.IsNullOrWhiteSpace(token))
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation(Const.Token, token);
            }

            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();

                if (!string.IsNullOrWhiteSpace(data))
                {
                    return BaseJson.DeJson<T>(data);
                }
            }

            return default!;
        }

        /// <summary>
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="args"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<T> PostAsync(string uri, BaseArgs args, string token = "")
        {
            var client = new HttpClient();

            if (!string.IsNullOrWhiteSpace(token))
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation(Const.Token, token);
            }

            var response = await client.PostAsync(uri, new StringContent(args.ToJson(), Encoding.UTF8, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();

                if (!string.IsNullOrWhiteSpace(data))
                {
                    return BaseJson.DeJson<T>(data);
                }
            }

            return default!;
        }
    }
}