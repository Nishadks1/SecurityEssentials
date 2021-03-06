﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurityEssentials.Model;
using SecurityEssentials.Core;

namespace SecurityEssentials.Core.Identity
{
    public interface IUserManager
    {
		Task<SEIdentityResult> CreateAsync(string userName, string firstName, string lastName, string password, string passwordConfirmation, int securityQuestionLookupItemId, string securityAnswer);
        Task LogOnAsync(string userName, bool isPersistent);
		Task<LogonResult> TryLogOnAsync(string userName, string password);
        Task<User> FindUserByIdAsync(int userId);
		void SignOut();
		Task<SEIdentityResult> ChangePasswordAsync(int userId, string oldPassword, string newPassword);
		SEIdentityResult ValidatePassword(string password, List<string> bannedWords);

	}
}
