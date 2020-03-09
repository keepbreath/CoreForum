using CoreForum.Dto.Models;
using CoreForum.Dto.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Interfaces.Services
{
    public partial interface IEmailService : IContextService
    {
        void SendMail(Email email, Settings settings);
        void SendMail(Email email);
        void SendMail(List<Email> email);
        void SendMail(List<Email> email, Settings settings);
        void ProcessMail(List<Email> emails);
        string EmailTemplate(string to, string content);
        string EmailTemplate(string to, string content, Settings settings);
        void SendEmailConfirmationEmail(MembershipUser userToSave, bool manuallyAuthoriseMembers, bool memberEmailAuthorisationNeeded);
    }
}
