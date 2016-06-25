namespace ProjectMerger.Security
{
    public class SocialCredentials
    {
        public SocialService SocialService { get; protected set; }
        public string Token { get; set; }
        public string TokenSecret { get; set; }
    }
}