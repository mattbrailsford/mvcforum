using System.Linq;
using MVCForum.Domain.DomainModel;
using MVCForum.Domain.DomainModel.Attributes;
using MVCForum.Domain.Interfaces.Badges;

namespace Badge.PostMentionsArduino
{
    [Id("0E75A4FA-B26E-435C-9C44-5DCA2C78D814")]
    [Name("PostMentionsArduino")]
    [DisplayName("Badge.PostMentionsArduino.Name")]
    [Description("Badge.PostMentionsArduino.Desc")]
    [Image("arduino.png")]
    [AwardsPoints(1)]
    public class PostMentionsArduino : IPostBadge
    {
        public bool Rule(MembershipUser user)
        {
            var lastPost = user.Posts.OrderByDescending(x => x.DateCreated).FirstOrDefault();
            if (lastPost != null && lastPost.PostContent.ToLower().Contains("arduino"))
            {
                return true;
            }
            return false;
        }
    }
}
