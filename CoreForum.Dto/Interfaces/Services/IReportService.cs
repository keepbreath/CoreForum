using CoreForum.Dto.Models.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Interfaces.Services
{
    public partial interface IReportService : IContextService
    {
        void MemberReport(Report report);
        void PostReport(Report report);
    }
}
