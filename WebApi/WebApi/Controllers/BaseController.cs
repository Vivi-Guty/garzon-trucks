using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;

namespace WebApi.Controllers
{
    public class BaseController : Controller
    {
        private InsurancesDataService? _dataService;
        public InsurancesDataService DataService
        {
            get
            {
                if (_dataService == null)
                {
                    _dataService = this.HttpContext.RequestServices.GetRequiredService<InsurancesDataService>();
                }
                return _dataService;
            }
        }

        private User? _currentUser;
        protected User? CurrentUser
        {
            get
            {
                if (this._currentUser == null)
                {
                    this._currentUser = this.HttpContext.Items["CurrentUser"] as User;
                }
                return _currentUser;
            }
        }

        protected bool HasRoles
        {
            get
            {
                var user = this.CurrentUser;
                return user != null && user.Roles != null && user.Roles.Count > 0;
            }
        }


        protected bool IsInRole(RoleId roleId)
        {
            if (CurrentUser != null)
            {
                return HasRoles && this.CurrentUser.Roles.Any(r => r.RoleId == roleId);
            }
            return false;
        }

        protected bool IsInAnyRole(params RoleId[] roleIds)
        {
            if (CurrentUser != null)
            {
                return HasRoles && this.CurrentUser.Roles.Any(r => Array.IndexOf(roleIds, r.RoleId) >= 0);
            }
            return false;
        }

        protected bool IsInRoleGlobally(RoleId roleId)
        {
            return IsInRole(roleId);
        }

        protected bool IsInAnyRoleGlobally(params RoleId[] roleIds)
        {
            return IsInAnyRole(roleIds);
        }

        protected bool IsAppUser
        {
            get { return this.CurrentUser != null; }
        }

        protected void CheckAuth(Func<bool> predicate)
        {
            if (predicate()) return;
            ThrowAuthorizationException();
        }
        protected async Task CheckAuthAsync(Func<Task<bool>> asyncPredicate)
        {
            if (await asyncPredicate()) return;
            ThrowAuthorizationException();
        }

        protected void CheckIsAppUser()
        {
            CheckAuth(() => IsAppUser);
        }

        protected void CheckIsInRole(RoleId role)
        {
            CheckAuth(() => IsInRole(role));
        }

        protected void CheckIsInRoleGlobally(RoleId roleId)
        {
            CheckAuth(() => IsInRoleGlobally(roleId));
        }

        protected void CheckIsInAnyRole(params RoleId[] roleIds)
        {
            CheckAuth(() => IsInAnyRole(roleIds));
        }

        protected void CheckIsInAnyRoleGlobally(RoleId[] roleIds)
        {
            CheckAuth(() => IsInAnyRoleGlobally(roleIds));
        }

        protected void ThrowAuthorizationException()
        {
            if (User.Identity?.IsAuthenticated == false)
            {
                throw new AuthorizationException(UnauthorizedReason.Unautenticated);
            }
            if (CurrentUser == null)
            {
                throw new AuthorizationException(UnauthorizedReason.NoAppUser);
            }
            throw new AuthorizationException(UnauthorizedReason.AccessDenied);
        }
    }
}
