#region

using ViteCent.Auth.Data.BaseCompany;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Auth.Data.BaseRolePermission;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Auth.Entity.BaseCompany;
using ViteCent.Auth.Entity.BaseDepartment;
using ViteCent.Auth.Entity.BaseRole;
using ViteCent.Auth.Entity.BaseRolePermission;
using ViteCent.Auth.Entity.BaseUser;
using ViteCent.Auth.Entity.BaseUserDepartment;
using ViteCent.Auth.Entity.BaseUserRole;
using ViteCent.Core.Web;

#endregion

namespace ViteCent.Auth.Api;

/// <summary>
/// </summary>
public class AutoMapperConfig : BaseMapperConfig
{
    /// <summary>
    /// </summary>
    public override void Map()
    {
        #region BaseCompany

        CreateMap<AddBaseCompanyArgs, AddBaseCompanyEntity>();
        CreateMap<EditBaseCompanyArgs, GetBaseCompanyEntityArgs>();
        CreateMap<GetBaseCompanyArgs, GetBaseCompanyEntityArgs>();
        CreateMap<SearchBaseCompanyArgs, SearchBaseCompanyEntityArgs>();
        CreateMap<BaseCompanyEntity, BaseCompanyResult>();
        CreateMap<DeleteBaseCompanyArgs, DeleteBaseCompanyEntityArgs>();
        #endregion

        #region BaseDepartment

        CreateMap<AddBaseDepartmentArgs, AddBaseDepartmentEntity>();
        CreateMap<EditBaseDepartmentArgs, GetBaseDepartmentEntityArgs>();
        CreateMap<GetBaseDepartmentArgs, GetBaseDepartmentEntityArgs>();
        CreateMap<SearchBaseDepartmentArgs, SearchBaseDepartmentEntityArgs>();
        CreateMap<BaseDepartmentEntity, BaseDepartmentResult>();
        CreateMap<DeleteBaseDepartmentArgs, DeleteBaseDepartmentEntityArgs>();
        #endregion

        #region BaseRole

        CreateMap<AddBaseRoleArgs, AddBaseRoleEntity>();
        CreateMap<EditBaseRoleArgs, GetBaseRoleEntityArgs>();
        CreateMap<GetBaseRoleArgs, GetBaseRoleEntityArgs>();
        CreateMap<SearchBaseRoleArgs, SearchBaseRoleEntityArgs>();
        CreateMap<BaseRoleEntity, BaseRoleResult>();
        CreateMap<DeleteBaseRoleArgs, DeleteBaseRoleEntityArgs>();
        #endregion

        #region BaseRolePermission

        CreateMap<AddBaseRolePermissionArgs, AddBaseRolePermissionEntity>();
        CreateMap<EditBaseRolePermissionArgs, GetBaseRolePermissionEntityArgs>();
        CreateMap<GetBaseRolePermissionArgs, GetBaseRolePermissionEntityArgs>();
        CreateMap<SearchBaseRolePermissionArgs, SearchBaseRolePermissionEntityArgs>();
        CreateMap<BaseRolePermissionEntity, BaseRolePermissionResult>();
        CreateMap<DeleteBaseRolePermissionArgs, DeleteBaseRolePermissionEntityArgs>();
        #endregion

        #region BaseUser

        CreateMap<AddBaseUserArgs, AddBaseUserEntity>();
        CreateMap<EditBaseUserArgs, GetBaseUserEntityArgs>();
        CreateMap<GetBaseUserArgs, GetBaseUserEntityArgs>();
        CreateMap<SearchBaseUserArgs, SearchBaseUserEntityArgs>();
        CreateMap<BaseUserEntity, BaseUserResult>();
        CreateMap<DeleteBaseUserArgs, DeleteBaseUserEntityArgs>();
        #endregion

        #region BaseUserDepartment

        CreateMap<AddBaseUserDepartmentArgs, AddBaseUserDepartmentEntity>();
        CreateMap<EditBaseUserDepartmentArgs, GetBaseUserDepartmentEntityArgs>();
        CreateMap<GetBaseUserDepartmentArgs, GetBaseUserDepartmentEntityArgs>();
        CreateMap<SearchBaseUserDepartmentArgs, SearchBaseUserDepartmentEntityArgs>();
        CreateMap<BaseUserDepartmentEntity, BaseUserDepartmentResult>();
        CreateMap<DeleteBaseUserDepartmentArgs, DeleteBaseUserDepartmentEntityArgs>();
        #endregion

        #region BaseUserRole

        CreateMap<AddBaseUserRoleArgs, AddBaseUserRoleEntity>();
        CreateMap<EditBaseUserRoleArgs, GetBaseUserRoleEntityArgs>();
        CreateMap<GetBaseUserRoleArgs, GetBaseUserRoleEntityArgs>();
        CreateMap<SearchBaseUserRoleArgs, SearchBaseUserRoleEntityArgs>();
        CreateMap<BaseUserRoleEntity, BaseUserRoleResult>();
        CreateMap<DeleteBaseUserRoleArgs, DeleteBaseUserRoleEntityArgs>();
        #endregion
    }
}