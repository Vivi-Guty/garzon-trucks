using inercya.EntityLite;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NLog.Fluent;
using System.Configuration;
using System.DirectoryServices.AccountManagement;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Web.Http;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Services
{
    public class AuthorizationService
    {
        private readonly MapDataService _dataService;

        public AuthorizationService(MapDataService dataService)
        {
            _dataService = dataService;
        }

        public async Task<bool> HasPermission(int userId, PermissionId permissionId)
        {
            var anyPermission = await this._dataService.UserPermissionRepository.Query(Projection.Minimal)
                .Where(UserPermissionFields.UserId, OperatorLite.Equals, userId)
                .And(UserPermissionFields.PermissionId, OperatorLite.Equals, (int)permissionId)
                .AnyAsync();
            return anyPermission;
        }

        public async Task<bool> HasPermission(int userId, PermissionId permissionId, EntityTypeId entityTypeId, int entityId)
        {
            var entitiesSubfilter = (new FilterLite<UserRoleEntity>())
                .Where(UserPermissionFields.EntityId, entityId)
                .And(UserPermissionFields.EntityTypeId, entityTypeId);

            var anyPermission = await this._dataService.UserPermissionRepository.Query(Projection.Minimal)
                .Where(UserPermissionFields.UserId, OperatorLite.Equals, userId)
                .And(UserPermissionFields.PermissionId, OperatorLite.Equals, (int)permissionId)
                .And(entitiesSubfilter)
                .AnyAsync();

            return anyPermission;
        }

        public async Task<bool> IsRoleMember(int userId, RoleId roleId)
        {
            return await this._dataService.UserRoleEntityRepository.Query(Projection.Minimal)
                .Where(UserRoleEntityFields.EntityId, OperatorLite.Equals, 0)
                .And(UserRoleEntityFields.UserId, OperatorLite.Equals, userId)
                .And(UserRoleEntityFields.RoleId, OperatorLite.Equals, (int)roleId)
                .AnyAsync();
        }

        public async Task<bool> IsRoleMember(int userId, RoleId roleId, EntityTypeId entityTypeId, int entityId)
        {
            var entitiesSubfilter = (new FilterLite<UserRoleEntity>())
                .Where(UserRoleEntityFields.EntityId, entityId)
                .Or(UserRoleEntityFields.EntityId, 0);

            return await this._dataService.UserRoleEntityRepository.Query(Projection.BaseTable)
                .Where(UserRoleEntityFields.UserId, OperatorLite.Equals, userId)
                .And(UserRoleEntityFields.RoleId, OperatorLite.Equals, (int)roleId)
                .And(entitiesSubfilter)
                .AnyAsync();
        }
    }
}