namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     For a social data hub activity, this value represents the URL of the photo associated with the user's social
    ///     network profile.
    /// </summary>
    public class UserPhotoURLDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="UserPhotoURLDimension" />.
        /// </summary>
        public UserPhotoURLDimension()
            : base(
                "User Photo URL",
                "For a social data hub activity, this value represents the URL of the photo associated with the user's social network profile.",
                false, "ga:socialActivityUserPhotoUrl")
        {
        }
    }
}