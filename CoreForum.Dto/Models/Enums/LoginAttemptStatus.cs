using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Enums
{
    public enum LoginAttemptStatus
    {
        LoginSuccessful,
        UserNotFound,
        PasswordIncorrect,
        PasswordAttemptsExceeded,
        UserLockedOut,
        UserNotApproved,
        Banned
    }
}
