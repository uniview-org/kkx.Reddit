using System.Collections.Generic;
using Newtonsoft.Json;

namespace kkx.Reddit.Types.Responses {
	using RichText = List<RichTextItem>;
	// using Comments = Tuple<Listing<Post>, Listing<Comment>>;

	public class Thing {}

	public class PostData {
		[JsonProperty("subreddit")]
		public string Subreddit { get; set; }
		[JsonProperty("title")]
		public string Title { get; set; }
		[JsonProperty("id")]
		public string Id { get; set; }
		[JsonProperty("score")]
		public int Score { get; set; }
		[JsonProperty("thumbnail")]
		public string Thumbnail { get; set; }
		[JsonProperty("link_flair_type")]
		public string LinkFlairType { get; set; }
		[JsonProperty("author_flair_type")]
		public string AuthorFlairType { get; set; }
		[JsonProperty("url_overriden_by_dest")]
		public string UrlOverridenByDest { get; set; }
		[JsonProperty("preview")]
		public Preview Preview { get; set; }
		[JsonProperty("author")]
		public string Author { get; set; }
		[JsonProperty("num_comments")]
		public int NumComments { get; set; }
		[JsonProperty("permalink")]
		public string Permalink { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("created_utc")]
		public long CreatedUtc { get; set; }
		[JsonProperty("link_flair_richtext")]
		public RichText LinkFlairRichText { get; set; }
		[JsonProperty("link_flair_text")]
		public string LinkFlairText { get; set; }
		[JsonProperty("link_flair_background_color")]
		public string LinkFlairBackgroundColor { get; set; }
		[JsonProperty("selftext")]
		public string SelfText { get; set; }
		[JsonProperty("edited_utc")]
		public long EditedUtc { get; set; }
		[JsonProperty("is_self")]
		public bool IsSelf { get; set; }
		[JsonProperty("selftext_html")]
		public string SelfTextHtml { get; set; }
		[JsonProperty("author_flair_background_color")]
		public string AuthorFlairBackgroundColor { get; set; }
		[JsonProperty("author_flair_richtext")]
		public RichText AuthorFlairRichText { get; set; }
		[JsonProperty("author_flair_text")]
		public string AuthorFlairText { get; set; }
		[JsonProperty("author_flair_text_color")]
		public string AuthorFlairTextColor { get; set; }
		[JsonProperty("secure_media")]
		public Media SecureMedia { get; set; }
		[JsonProperty("media")]
		public Media Media { get; set; }
		[JsonProperty("is_video")]
		public bool IsVideo { get; set; }
		[JsonProperty("is_gallery")]
		public bool IsGallery { get; set; }
		[JsonProperty("over_18")]
		public bool Over18 { get; set; }
		[JsonProperty("gallery_data")]
		public GalleryData GalleryData { get; set; }
		[JsonProperty("media_embed")]
		public Embed MediaEmbed { get; set; }
		[JsonProperty("secure_media_embed")]
		public Embed SecureMediaEmbed { get; set; }
		[JsonProperty("media_metadata")]
		public Dictionary<string, MediaMetadataItem> MediaMetadata { get; set; }
	}

	public class Comment : Thing {
		[JsonProperty("kind")]
		public string Kind { get; } = "t1";
		[JsonProperty("data")]
		public CommentData Data { get; set; }
	}

	public class CommentData : PostData {
		[JsonProperty("body")]
		public string Body { get; set; }
		[JsonProperty("body_html")]
		public string BodyHtml { get; set; }
		[JsonProperty("replies")]
		public Listing<Comment> Replies { get; set; }
	}

	public class More : Thing {
		[JsonProperty("kind")]
		public string Kind { get; } = "more";
		[JsonProperty("data")]
		public MoreData Data { get; set; }
	}

	public class MoreData {
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("id")]
		public string Id { get; set; }
		[JsonProperty("parent_id")]
		public string ParentId { get; set; }
		[JsonProperty("depth")]
		public int Depth { get; set; }
		[JsonProperty("children")]
		public List<string> Children { get; set; }
	}

	public class Account : Thing {
		[JsonProperty("kind")]
		public string Kind { get; } = "t2";
	}

	public class Post : Thing {
		[JsonProperty("kind")]
		public string Kind { get; } = "t3";
		[JsonProperty("data")]
		public PostData Data { get; set; }
	}

	public class Listing<T> : Thing {
		[JsonProperty("kind")]
		public string Kind { get; } = "Listing";
		[JsonProperty("data")]
		public ListingData<T> Data { get; set; }
	}
	
	public class ListingData<T> {
		[JsonProperty("modhash")]
		public string ModHash { get; set; }
		[JsonProperty("dist")]
		public int Dist { get; set; }
		[JsonProperty("children")]
		public List<T> Children { get; set; }
		[JsonProperty("after")]
		public string After { get; set; }
		[JsonProperty("before")]
		public string Before { get; set; }
	}

	public class RichTextItem {
		[JsonProperty("e")]
		public string E { get; set; }
		[JsonProperty("t")]
		public string T { get; set; }
	}

	public class Media {
		[JsonProperty("reddit_video")]
		public RedditVideo RedditVideo { get; set; }
	}
	
	public class RedditVideo {
		[JsonProperty("fallback_url")]
		public string FallbackUrl { get; set; }
		[JsonProperty("height")]
		public int Height { get; set; }
		[JsonProperty("width")]
		public int Width { get; set; }
		[JsonProperty("scrubber_media_url")]
		public string ScrubberMediaUrl { get; set; }
		[JsonProperty("dash_url")]
		public string DashUrl { get; set; }
		[JsonProperty("duration")]
		public int Duration { get; set; }
		[JsonProperty("hls_url")]
		public string HlsUrl { get; set; }
		[JsonProperty("is_gif")]
		public bool IsGif { get; set; }
	}

	public class GalleryData {
		[JsonProperty("items")]
		public List<GalleryItem> Items { get; set; }
	}

	public class GalleryItem {
		[JsonProperty("media_url")]
		public string MediaUrl { get; set; }
		[JsonProperty("id")]
		public string Id { get; set; }
	}

	public class Embed {
		[JsonProperty("content")]
		public string Content { get; set; }
		[JsonProperty("width")]
		public int Width { get; set; }
		[JsonProperty("height")]
		public int Height { get; set; }
		[JsonProperty("scrolling")]
		public bool Scrolling { get; set; }
		[JsonProperty("media_domain_url")]
		public string MediaDomainUrl { get; set; }
	}

	public class Preview {
		[JsonProperty("images")]
		public List<PreviewImage> Images { get; set; }
		[JsonProperty("enabled")]
		public bool Enabled { get; set; }
	}

	public class PreviewImage {
		[JsonProperty("source")]
		public PreviewMedia Source { get; set; }
		[JsonProperty("resolutions")]
		public List<PreviewMedia> Resolutions { get; set; }
		[JsonProperty("variants")]
		public Dictionary<string, PreviewImage> Variants { get; set; }
		[JsonProperty("id")]
		public string Id { get; set; }
	}
	
	public class PreviewMedia {
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("width")]
		public int Width { get; set; }
		[JsonProperty("height")]
		public int Height { get; set; }
	}

	public class MediaMetadataItem {
		[JsonProperty("status")]
		public string Status { get; set; }
		[JsonProperty("e")]
		public string E { get; set; }
		[JsonProperty("m")]
		public string M { get; set; }
		[JsonProperty("p")]
		public List<MediaMetadataVariant> P { get; set; }
	}

	public class MediaMetadataVariant {
		[JsonProperty("x")]
		public int X { get; set; }
		[JsonProperty("y")]
		public int Y { get; set; }
		[JsonProperty("u")]
		public string U { get; set; }
	}
}
