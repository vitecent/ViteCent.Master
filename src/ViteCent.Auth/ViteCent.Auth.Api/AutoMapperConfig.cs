#region
using ViteCent.Auth.Data.BaseCompany;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Auth.Data.BaseRolePermission;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Auth.Entity;
using ViteCent.Core.Web;

#endregion

namespace ViteCent.Auth.Api;

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
        #region BaseCompany

        CreateMap<GetBaseCompanyArgs, GetBaseCompanyEntityArgs>();
        CreateMap<SearchBaseCompanyArgs, SearchBaseCompanyEntityArgs>();
        CreateMap<AddBaseCompanyArgs, BaseCompanyEntity>();
        CreateMap<BaseCompanyEntity, BaseCompanyResult>();
        CreateMap<EditBaseCompanyArgs, GetBaseCompanyEntityArgs>();

        #endregion

        #region BaseDepartment

        CreateMap<GetBaseDepartmentArgs, GetBaseDepartmentEntityArgs>();
        CreateMap<SearchBaseDepartmentArgs, SearchBaseDepartmentEntityArgs>();
        CreateMap<AddBaseDepartmentArgs, BaseDepartmentEntity>();
        CreateMap<BaseDepartmentEntity, BaseDepartmentResult>();
        CreateMap<EditBaseDepartmentArgs, GetBaseDepartmentEntityArgs>();

        #endregion

        #region BaseRole

        CreateMap<GetBaseRoleArgs, GetBaseRoleEntityArgs>();
        CreateMap<SearchBaseRoleArgs, SearchBaseRoleEntityArgs>();
        CreateMap<AddBaseRoleArgs, BaseRoleEntity>();
        CreateMap<BaseRoleEntity, BaseRoleResult>();
        CreateMap<EditBaseRoleArgs, GetBaseRoleEntityArgs>();

        #endregion

        #region BaseRolePermission

        CreateMap<GetBaseRolePermissionArgs, GetBaseRolePermissionEntityArgs>();
        CreateMap<SearchBaseRolePermissionArgs, SearchBaseRolePermissionEntityArgs>();
        CreateMap<AddBaseRolePermissionArgs, BaseRolePermissionEntity>();
        CreateMap<BaseRolePermissionEntity, BaseRolePermissionResult>();
        CreateMap<EditBaseRolePermissionArgs, GetBaseRolePermissionEntityArgs>();

        #endregion

        #region BaseUser

        CreateMap<GetBaseUserArgs, GetBaseUserEntityArgs>();
        CreateMap<SearchBaseUserArgs, SearchBaseUserEntityArgs>();
        CreateMap<AddBaseUserArgs, BaseUserEntity>();
        CreateMap<BaseUserEntity, BaseUserResult>();
        CreateMap<EditBaseUserArgs, GetBaseUserEntityArgs>();

        #endregion

        #region BaseUserDepartment

        CreateMap<GetBaseUserDepartmentArgs, GetBaseUserDepartmentEntityArgs>();
        CreateMap<SearchBaseUserDepartmentArgs, SearchBaseUserDepartmentEntityArgs>();
        CreateMap<AddBaseUserDepartmentArgs, BaseUserDepartmentEntity>();
        CreateMap<BaseUserDepartmentEntity, BaseUserDepartmentResult>();
        CreateMap<EditBaseUserDepartmentArgs, GetBaseUserDepartmentEntityArgs>();

        #endregion

        #region BaseUserRole

        CreateMap<GetBaseUserRoleArgs, GetBaseUserRoleEntityArgs>();
        CreateMap<SearchBaseUserRoleArgs, SearchBaseUserRoleEntityArgs>();
        CreateMap<AddBaseUserRoleArgs, BaseUserRoleEntity>();
        CreateMap<BaseUserRoleEntity, BaseUserRoleResult>();
        CreateMap<EditBaseUserRoleArgs, GetBaseUserRoleEntityArgs>();

        #endregion
    }
}