namespace GitScraping.WebApi.Modules.Common.FeatureFlags
{
    /// <summary>
    ///     Features Flags Enum.
    /// </summary>
    public enum CustomFeature
    {
        /// <summary>
        ///     Get Airplane.
        /// </summary>
        ExtractedFile,

        /// <summary>
        ///     Get Comum.
        /// </summary>
        Comum,

        /// <summary>
        ///     Filter errors out.
        /// </summary>
        ErrorFilter,

        /// <summary>
        ///     Use Swagger.
        /// </summary>
        Swagger,

        /// <summary>
        ///     Use SQL Server Persistence.
        /// </summary>
        SqlServer,


        /// <summary>
        ///     Use authentication.
        /// </summary>
        Authentication
    }
}