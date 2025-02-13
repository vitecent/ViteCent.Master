#region

using ViteCent.Core.Web;
using ViteCent.Basic.Data.Simple;
using ViteCent.Basic.Entity;

#endregion

namespace ViteCent.Basic.Api;

/// <summary>
///     AutoMapper配置类，继承自BaseMapperConfig
/// </summary>
public class AutoMapperConfig : BaseMapperConfig
{
    /// <summary>
    ///     配置映射关系的方法
    /// </summary>
    public override void Map()
    {
        // 配置SimpleEntity到SimpleResult的映射
        CreateMap<SimpleEntity, SimpleResult>();
        // 配置SimpleResult到SimpleEntity的映射
        CreateMap<SimpleResult, SimpleEntity>();
    }
}