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
/// </summary>
public class AutoMapperConfig : BaseMapperConfig
{
    /// <summary>
    /// </summary>
    public override void Map()
    {
        #region BaseModule

        CreateMap<AddBaseModuleArgs, AddBaseModuleEntity>();
        CreateMap<EditBaseModuleArgs, GetBaseModuleEntityArgs>();
        CreateMap<GetBaseModuleArgs, GetBaseModuleEntityArgs>();
        CreateMap<SearchBaseModuleArgs, SearchBaseModuleEntityArgs>();
       CreateMap<BaseModuleEntity, BaseModuleResult>();
        #endregion

        #region BaseModuleField

        CreateMap<AddBaseModuleFieldArgs, AddBaseModuleFieldEntity>();
        CreateMap<EditBaseModuleFieldArgs, GetBaseModuleFieldEntityArgs>();
        CreateMap<GetBaseModuleFieldArgs, GetBaseModuleFieldEntityArgs>();
        CreateMap<SearchBaseModuleFieldArgs, SearchBaseModuleFieldEntityArgs>();
       CreateMap<BaseModuleFieldEntity, BaseModuleFieldResult>();
        #endregion

        #region BaseOperation

        CreateMap<AddBaseOperationArgs, AddBaseOperationEntity>();
        CreateMap<EditBaseOperationArgs, GetBaseOperationEntityArgs>();
        CreateMap<GetBaseOperationArgs, GetBaseOperationEntityArgs>();
        CreateMap<SearchBaseOperationArgs, SearchBaseOperationEntityArgs>();
       CreateMap<BaseOperationEntity, BaseOperationResult>();
        #endregion

        #region BaseResource

        CreateMap<AddBaseResourceArgs, AddBaseResourceEntity>();
        CreateMap<EditBaseResourceArgs, GetBaseResourceEntityArgs>();
        CreateMap<GetBaseResourceArgs, GetBaseResourceEntityArgs>();
        CreateMap<SearchBaseResourceArgs, SearchBaseResourceEntityArgs>();
       CreateMap<BaseResourceEntity, BaseResourceResult>();
        #endregion
    }
}