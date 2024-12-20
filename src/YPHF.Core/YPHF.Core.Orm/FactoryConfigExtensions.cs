/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using Microsoft.Extensions.Configuration;

namespace YPHF.Core.Orm
{
    /// <summary>
    /// Class FactoryConfigExtensions.
    /// </summary>
    public class FactoryConfigExtensions
    {
        /// <summary>
        /// The configs
        /// </summary>
        private static readonly List<FactoryConfig> configs = [];

        /// <summary>
        /// The key
        /// </summary>
        private static readonly object key = new();

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>FactoryConfig.</returns>
        /// <exception cref="System.Exception">key</exception>
        /// <exception cref="System.Exception">configuration is null</exception>
        public static FactoryConfig GetConfig(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new Exception("参数key不能为空");
            }

            var configuration = configs.FirstOrDefault(x => x.Name == key);

            if (configuration == null)
            {
                throw new Exception("数据库不存在");
            }

            return configuration;
        }

        /// <summary>
        /// Sets the configuration.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <exception cref="System.Exception">DataBase</exception>
        /// <exception cref="System.Exception">DataBase.Name</exception>
        /// <exception cref="System.Exception">DataBase.Type</exception>
        /// <exception cref="System.Exception">DataBase.Master</exception>
        /// <exception cref="System.Exception">DataBase.Slaves</exception>
        public static void SetConfig(IConfiguration configuration)
        {
            var dataBase = configuration.GetSection("DataBase");

            if (dataBase == null)
            {
                throw new Exception("Appsettings Must Be DataBase");
            }

            var dataBaseCount = dataBase.GetChildren().Count();

            for (int i = 0; i < dataBaseCount; i++)
            {
                var name = configuration[$"DataBase:{i}:Name"];

                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new Exception("DataBase.Name");
                }

                var type = configuration[$"DataBase:{i}:Type"];

                if (string.IsNullOrWhiteSpace(type))
                {
                    throw new Exception("DataBase.Type");
                }

                var master = configuration[$"DataBase:{i}:Master"];

                if (string.IsNullOrWhiteSpace(master))
                {
                    throw new Exception("DataBase.Master");
                }

                var factoryConfig = new FactoryConfig()
                {
                    Name = name,
                    DbType = type,
                    Master = master,
                    Slaves = []
                };

                var slave = configuration.GetSection($"DataBase:{i}:Slaves");

                if (slave != null)
                {
                    var slaveCount = slave.GetChildren().Count();

                    for (int j = 0; j < slaveCount; j++)
                    {
                        var value = configuration[$"DataBase:{i}:Slaves:{j}"];

                        if (string.IsNullOrWhiteSpace(value))
                        {
                            throw new Exception("DataBase.Slaves");
                        }

                        factoryConfig.Slaves.Add(value);
                    }
                }
                else
                {
                    factoryConfig.Slaves.Add(master);
                }

                lock (key)
                {
                    var _config = configs.FirstOrDefault(x => x.Name == factoryConfig.Name);

                    if (_config != null)
                    {
                        _config.DbType = factoryConfig.DbType;
                        _config.Master = factoryConfig.Master;
                        _config.Slaves = factoryConfig.Slaves;
                    }
                    else
                    {
                        configs.Add(factoryConfig);
                    }
                }
            }
        }
    }
}