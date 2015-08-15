using System.Linq;
using MVCForum.Domain.DomainModel;
using MVCForum.Domain.DomainModel.Attributes;
using MVCForum.Domain.Interfaces.Badges;

namespace Badge.PostMentionsRaspberryPi
{
    [Id("528E04ED-C2B4-4898-968B-DE57FDA1FEC8")]
    [Name("PostMentionsRaspberryPi")]
    [DisplayName("Badge.PostMentionsRaspberryPi.Name")]
    [Description("Badge.PostMentionsRaspberryPi.Desc")]
    [Image("raspberrypi.png")]
    [AwardsPoints(1)]
    public class PostMentionsRaspberryPi : IPostBadge
    {
        public bool Rule(MembershipUser user)
        {
            var lastPost = user.Posts.OrderByDescending(x => x.DateCreated).FirstOrDefault();
            if (lastPost != null && (lastPost.PostContent.ToLower().Contains("raspberrypi")
                || lastPost.PostContent.ToLower().Contains("raspberry pi")))
            {
                return true;
            }
            return false;
        }
    }
}
