using inercya.EntityLite;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Net;
using System.Net.Http.Headers;
using System.Web.Http.Results;
using WebApi.Entities;
using WebApi.Services;

namespace WebApi.Controllers
{
    public class BaseController : Controller
    {
        public AuthorizationService AuthorizationService { get; set; }

        private MapDataService _dataService;
        public MapDataService DataService
        {
            get
            {
                if (_dataService == null)
                {
                    _dataService = this.HttpContext.RequestServices.GetRequiredService<MapDataService>();
                }
                return _dataService;
            }
        }

        public User? _currentUser;
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
        protected async Task CheckHaveThisPermission(PermissionId permission)
        {
            CheckAuthAsync(() => HasPermission(permission));
        }
        
        protected async Task<bool> HasPermission(PermissionId permission)
        {
            return await AuthorizationService.HasPermission(CurrentUser.UserId, permission);
        }

        protected bool HasRoles
        {
            get
            {
                var user = this.CurrentUser;
                return user != null && user.Roles != null && user.Roles.Count > 0;
            }
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
