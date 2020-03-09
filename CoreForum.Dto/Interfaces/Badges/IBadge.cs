using CoreForum.Dto.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

/**    How To Create A Badge Class:
    ================================

    1. Reference the following DLL in your assembly:

        CoreForum.Core.dll (found in e.g. "CoreForum.Core\bin\Debug")

    2. Create a class. Add these references:

        using CoreForum.Core.DomainModel;
        using CoreForum.Core.DomainModel.Attributes;
        using CoreForum.Domain.Interfaces.API;
        using CoreForum.Domain.Interfaces.Badges;

    3. Inherit from the appropriate badge type interface, e.g. CoreForum.Core.Interfaces.Badges.IVoteUpBadge

    4. Implement the interface i.e.

        bool Rule(MembershipUser user)
        {
            // rule code
            return rule result;
        }

    5.Add the attributes to the class (if these are missing then the rule will be ignored):

        "Id": this is the Guid used to identify the badge

        "Name": the name of the badge, assumed to be unique, therefore if the Id is known but the name has been changed then
        an edit to the badge is assumed (i.e. the name has changed)
	
        "Description": Some text describing your badge

        For example:

        [Id("91e6a90c-c1f1-4fcd-93f0-a40b90f34e2e")]
        [Name("TestBadge 4")]
        [Description("the class 4 badge")]

**/
namespace CoreForum.Dto.Interfaces.Badges
{
    public interface IBadge
    {
        bool Rule(MembershipUser user);
    }
}
