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
    }
}
