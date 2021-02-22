using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace kkx.Reddit.Types.Responses {

    public class SubredditRules
    {
        [JsonProperty("rules")]
        public List<Rule> Rules { get; set; }

        [JsonProperty("site_rules")]
        public List<string> SiteRules { get; set; }

        [JsonProperty("site_rules_flow")]
        public List<SiteRulesFlow> SiteRulesFlow { get; set; }
    }

    public class Rule
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("violation_reason")]
        public string ViolationReason { get; set; }

        [JsonProperty("created_utc")]
        public long CreatedUtc { get; set; }

        [JsonProperty("priority")]
        public long Priority { get; set; }

        [JsonProperty("description_html")]
        public string DescriptionHtml { get; set; }
    }

    public class SiteRulesFlow
    {
        [JsonProperty("reasonTextToShow")]
        public string ReasonTextToShow { get; set; }

        [JsonProperty("reasonText")]
        public string ReasonText { get; set; }

        [JsonProperty("nextStepHeader", NullValueHandling = NullValueHandling.Ignore)]
        public string NextStepHeader { get; set; }

        [JsonProperty("nextStepReasons", NullValueHandling = NullValueHandling.Ignore)]
        public List<SiteRulesFlowNextStepReason> NextStepReasons { get; set; }
    }

    public class SiteRulesFlowNextStepReason
    {
        [JsonProperty("nextStepHeader", NullValueHandling = NullValueHandling.Ignore)]
        public string NextStepHeader { get; set; }

        [JsonProperty("reasonTextToShow")]
        public string ReasonTextToShow { get; set; }

        [JsonProperty("nextStepReasons", NullValueHandling = NullValueHandling.Ignore)]
        public List<NextStepReasonNextStepReason> NextStepReasons { get; set; }

        [JsonProperty("reasonText")]
        public string ReasonText { get; set; }

        [JsonProperty("canWriteNotes", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanWriteNotes { get; set; }

        [JsonProperty("isAbuseOfReportButton", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAbuseOfReportButton { get; set; }

        [JsonProperty("notesInputTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string NotesInputTitle { get; set; }

        [JsonProperty("complaintButtonText", NullValueHandling = NullValueHandling.Ignore)]
        public string ComplaintButtonText { get; set; }

        [JsonProperty("complaintUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ComplaintUrl { get; set; }

        [JsonProperty("complaintPageTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string ComplaintPageTitle { get; set; }

        [JsonProperty("fileComplaint", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FileComplaint { get; set; }

        [JsonProperty("complaintPrompt", NullValueHandling = NullValueHandling.Ignore)]
        public string ComplaintPrompt { get; set; }

        [JsonProperty("usernamesInputTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string UsernamesInputTitle { get; set; }

        [JsonProperty("canSpecifyUsernames", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanSpecifyUsernames { get; set; }

        [JsonProperty("requestCrisisSupport", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequestCrisisSupport { get; set; }

        [JsonProperty("oneUsername", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OneUsername { get; set; }
    }

    public class NextStepReasonNextStepReason
    {
        [JsonProperty("reasonTextToShow")]
        public string ReasonTextToShow { get; set; }

        [JsonProperty("reasonText")]
        public string ReasonText { get; set; }
    }
}
