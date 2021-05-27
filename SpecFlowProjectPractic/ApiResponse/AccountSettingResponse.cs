using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectPractic
{
    public class Response
    {
        public string Email { get; set; }
    }

    public class ChangePasswordResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }

    public class ChangePhoneNumberResponse
    {
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }

    public class Large
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Small
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Medium
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Thumbnail
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Original
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Image
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("large")]
        public Large Large { get; set; }

        [JsonProperty("small")]
        public Small Small { get; set; }

        [JsonProperty("medium")]
        public Medium Medium { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        [JsonProperty("original")]
        public Original Original { get; set; }
    }

    public class Root
    {
        [JsonProperty("image")]
        public Image Image { get; set; }
    }
    public class AvatarResponse
    {
        [JsonProperty("avatar")]
        public Avatar Avatar { get; set; }
    }

    public class Avatar
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("large")]
        public Large Large { get; set; }

        [JsonProperty("small")]
        public Small Small { get; set; }

        [JsonProperty("medium")]
        public Medium Medium { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        [JsonProperty("original")]
        public Original Original { get; set; }
    }

    public class ChangeSelfResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("payment_method_connected")]
        public bool PaymentMethodConnected { get; set; }

        [JsonProperty("is_staff")]
        public bool IsStaff { get; set; }

        [JsonProperty("email_verified")]
        public bool EmailVerified { get; set; }

        [JsonProperty("client_profile")]
        public ClientProfile ClientProfile { get; set; }

        [JsonProperty("has_password")]
        public bool HasPassword { get; set; }

        [JsonProperty("avatar")]
        public object Avatar { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    public class ChangeProfileResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("facebook_followers")]
        public string FacebookFollowers { get; set; }

        [JsonProperty("instagram_followers")]
        public string InstagramFollowers { get; set; }

        [JsonProperty("has_invite")]
        public bool HasInvite { get; set; }

        [JsonProperty("company_website")]
        public string CompanyWebsite { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("company_description")]
        public string CompanyDescription { get; set; }

        [JsonProperty("referral")]
        public string Referral { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("is_sms_enabled")]
        public bool IsSmsEnabled { get; set; }

        [JsonProperty("location_latitude")]
        public string LocationLatitude { get; set; }

        [JsonProperty("location_longitude")]
        public string LocationLongitude { get; set; }

        [JsonProperty("location_name")]
        public string LocationName { get; set; }

        [JsonProperty("location_city_name")]
        public string LocationCityName { get; set; }

        [JsonProperty("location_admin1_code")]
        public string LocationAdmin1Code { get; set; }

        [JsonProperty("location_timezone")]
        public string LocationTimezone { get; set; }

        [JsonProperty("company_address")]
        public string CompanyAddress { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("twitter_followers")]
        public string TwitterFollowers { get; set; }

        [JsonProperty("youtube_followers")]
        public string YoutubeFollowers { get; set; }
    }
}
