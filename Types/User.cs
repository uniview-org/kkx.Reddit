using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace kkx.Reddit.Types.Responses {
	public class UserAbout {
		[JsonProperty("kind")]
		public string Kind { get; set; } = "t2";

		[JsonProperty("data")]
		public UserAboutData Data { get; set; }
	}

	public class UserAboutData {
		[JsonProperty("is_employee")]
		public bool IsEmployee { get; set; }

		[JsonProperty("is_friend")]
		public bool IsFriend { get; set; }

		[JsonProperty("subreddit")]
		public UserAboutSubreddit Subreddit { get; set; }

		[JsonProperty("snoovatar_size")]
		public object SnoovatarSize { get; set; }

		[JsonProperty("awardee_karma")]
		public long AwardeeKarma { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("verified")]
		public bool Verified { get; set; }

		[JsonProperty("is_gold")]
		public bool IsGold { get; set; }

		[JsonProperty("is_mod")]
		public bool IsMod { get; set; }

		[JsonProperty("awarder_karma")]
		public long AwarderKarma { get; set; }

		[JsonProperty("has_verified_email")]
		public bool HasVerifiedEmail { get; set; }

		[JsonProperty("icon_img")]
		public Uri IconImg { get; set; }

		[JsonProperty("hide_from_robots")]
		public bool HideFromRobots { get; set; }

		[JsonProperty("link_karma")]
		public long LinkKarma { get; set; }

		[JsonProperty("total_karma")]
		public long TotalKarma { get; set; }

		[JsonProperty("pref_show_snoovatar")]
		public bool PrefShowSnoovatar { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("created")]
		public long Created { get; set; }

		[JsonProperty("created_utc")]
		public long CreatedUtc { get; set; }

		[JsonProperty("snoovatar_img")]
		public string SnoovatarImg { get; set; }

		[JsonProperty("comment_karma")]
		public long CommentKarma { get; set; }

		[JsonProperty("has_subscribed")]
		public bool HasSubscribed { get; set; }
	}

	public class UserAboutSubreddit {
		[JsonProperty("default_set")]
		public bool DefaultSet { get; set; }

		[JsonProperty("user_is_contributor")]
		public object UserIsContributor { get; set; }

		[JsonProperty("banner_img")]
		public Uri BannerImg { get; set; }

		[JsonProperty("restrict_posting")]
		public bool RestrictPosting { get; set; }

		[JsonProperty("user_is_banned")]
		public object UserIsBanned { get; set; }

		[JsonProperty("free_form_reports")]
		public bool FreeFormReports { get; set; }

		[JsonProperty("community_icon")]
		public object CommunityIcon { get; set; }

		[JsonProperty("show_media")]
		public bool ShowMedia { get; set; }

		[JsonProperty("icon_color")]
		public string IconColor { get; set; }

		[JsonProperty("user_is_muted")]
		public object UserIsMuted { get; set; }

		[JsonProperty("display_name")]
		public string DisplayName { get; set; }

		[JsonProperty("header_img")]
		public object HeaderImg { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("previous_names")]
		public List<object> PreviousNames { get; set; }

		[JsonProperty("over_18")]
		public bool Over18 { get; set; }

		[JsonProperty("icon_size")]
		public List<long> IconSize { get; set; }

		[JsonProperty("primary_color")]
		public string PrimaryColor { get; set; }

		[JsonProperty("icon_img")]
		public Uri IconImg { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("submit_link_label")]
		public string SubmitLinkLabel { get; set; }

		[JsonProperty("header_size")]
		public object HeaderSize { get; set; }

		[JsonProperty("restrict_commenting")]
		public bool RestrictCommenting { get; set; }

		[JsonProperty("subscribers")]
		public long Subscribers { get; set; }

		[JsonProperty("submit_text_label")]
		public string SubmitTextLabel { get; set; }

		[JsonProperty("is_default_icon")]
		public bool IsDefaultIcon { get; set; }

		[JsonProperty("link_flair_position")]
		public string LinkFlairPosition { get; set; }

		[JsonProperty("display_name_prefixed")]
		public string DisplayNamePrefixed { get; set; }

		[JsonProperty("key_color")]
		public string KeyColor { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("is_default_banner")]
		public bool IsDefaultBanner { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("quarantine")]
		public bool Quarantine { get; set; }

		[JsonProperty("banner_size")]
		public List<long> BannerSize { get; set; }

		[JsonProperty("user_is_moderator")]
		public object UserIsModerator { get; set; }

		[JsonProperty("public_description")]
		public string PublicDescription { get; set; }

		[JsonProperty("link_flair_enabled")]
		public bool LinkFlairEnabled { get; set; }

		[JsonProperty("disable_contributor_requests")]
		public bool DisableContributorRequests { get; set; }

		[JsonProperty("subreddit_type")]
		public string SubredditType { get; set; }

		[JsonProperty("user_is_subscriber")]
		public object UserIsSubscriber { get; set; }
	}
}
