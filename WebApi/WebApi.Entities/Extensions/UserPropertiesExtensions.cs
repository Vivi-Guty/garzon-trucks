using inercya.EntityLite;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebApi.Services;

namespace WebApi.Entities
{
    public static class UserPropertiesExtensions
    {
        public static bool IsPasswordValid(this UserProperties user, string password, UserPasswordService ups)
        {
            return ups.IsValidPassword(password, user.UserPasswordSalt, user.UserPasswordHash);
        }

        public static UserPasswordHashModel getPasswordHashAndSalt(this UserProperties user, string password, UserPasswordService ups)
        {
            var salt = ups.GetSalt();

            UserPasswordHashModel uphm = new UserPasswordHashModel()
            {
                PasswordSalt = salt,
                PasswordHash = ups.GetHash(password, salt)
            };

            return uphm;
        }

        public static bool IsValidPasswordStructure(this UserProperties user, string password, string regularExpression)
        {

            if (password.Contains(user.UserEmail))
                return false;
            else if (password.IndexOf(user.LoginName) > 0)
                return false;
            else if (password.LastIndexOf(user.LoginName) > 0)
                return false;
            else if (!Regex.IsMatch(password, regularExpression))
                return false;
            else
                return true;
        }

        public static bool IsPasswordInPasswordsHistory(this UserProperties user, string password, InsurancesDataService ds, UserPasswordService ups)
        {
            bool output = false;

            var userPasswordHistoryList = ds.UserPasswordHistoryRepository.Query(Projection.BaseTable)
                .Where(nameof(UserPasswordHistory.UserId), user.UserId).ToList();

            foreach (UserPasswordHistory ph in userPasswordHistoryList)
            {
                if (ups.IsValidPassword(password, ph.UserPasswordSalt, ph.UserPasswordHash))
                    return true;
            }

            return output;
        }

        public static void SaveNewPassword(this UserProperties user, string newPassword, int passwordDaysToExpire, InsurancesDataService ds, UserPasswordService ups)
        {

            // INSERTAMOS LA NUEVA PASSWORD PARA DICHO USUARIO
            UserPasswordHashModel uphm = user.getPasswordHashAndSalt(newPassword, ups);
            user.UserPasswordSalt = uphm.PasswordSalt;
            user.UserPasswordHash = uphm.PasswordHash;
            user.UserLoginAttemps = 0;
            user.UserPasswordExpirationDate = DateTime.Now.AddDays(passwordDaysToExpire);
            ds.UserPropertiesRepository.Update(user, nameof(User.UserLoginAttemps), nameof(User.UserPasswordHash), nameof(User.UserPasswordSalt), nameof(User.UserPasswordExpirationDate));

            // INSERTAMOS LA NUEVA PASSWORD EN EL HISTORIAL DE CONTRASEÑAS
            UserPasswordHistory uph = new UserPasswordHistory()
            {
                UserId = user.UserId,
                UserPasswordSalt = uphm.PasswordSalt,
                UserPasswordHash = uphm.PasswordHash
            };
            ds.UserPasswordHistoryRepository.Insert(uph);
        }
    }
}
