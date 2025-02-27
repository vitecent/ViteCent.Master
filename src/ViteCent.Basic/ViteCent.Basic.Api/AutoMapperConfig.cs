#region
using ViteCent.Basic.Data.BaseModule;
using ViteCent.Basic.Data.BaseModuleField;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Basic.Data.BaseResource;
using ViteCent.Basic.Entity;
using ViteCent.Core.Web;

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
        #region BaseModule

        CreateMap<GetBaseModuleArgs, GetBaseModuleEntityArgs>();
        CreateMap<SearchBaseModuleArgs, SearchBaseModuleEntityArgs>();
        CreateMap<AddBaseModuleArgs, BaseModuleEntity>();
        CreateMap<BaseModuleEntity, BaseModuleResult>();
        CreateMap<EditBaseModuleArgs, GetBaseModuleEntityArgs>();

        #endregion

        #region BaseModuleField

        CreateMap<GetBaseModuleFieldArgs, GetBaseModuleFieldEntityArgs>();
        CreateMap<SearchBaseModuleFieldArgs, SearchBaseModuleFieldEntityArgs>();
        CreateMap<AddBaseModuleFieldArgs, BaseModuleFieldEntity>();
        CreateMap<BaseModuleFieldEntity, BaseModuleFieldResult>();
        CreateMap<EditBaseModuleFieldArgs, GetBaseModuleFieldEntityArgs>();

        #endregion

        #region BaseOperation

        CreateMap<GetBaseOperationArgs, GetBaseOperationEntityArgs>();
        CreateMap<SearchBaseOperationArgs, SearchBaseOperationEntityArgs>();
        CreateMap<AddBaseOperationArgs, BaseOperationEntity>();
        CreateMap<BaseOperationEntity, BaseOperationResult>();
        CreateMap<EditBaseOperationArgs, GetBaseOperationEntityArgs>();

        #endregion

        #region BaseResource

        CreateMap<GetBaseResourceArgs, GetBaseResourceEntityArgs>();
        CreateMap<SearchBaseResourceArgs, SearchBaseResourceEntityArgs>();
        CreateMap<AddBaseResourceArgs, BaseResourceEntity>();
        CreateMap<BaseResourceEntity, BaseResourceResult>();
        CreateMap<EditBaseResourceArgs, GetBaseResourceEntityArgs>();

        #endregion
    }
}