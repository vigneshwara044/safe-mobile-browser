﻿namespace SafeMobileBrowser.Helpers
{
    public static class ErrorConstants
    {
        public const int SessionNotAvailableError = 100;
        public const int ConnectionFailedError = 101;
        public const int NoInternetConnectionError = 102;

        public const string SessionNotAvailable = "SessionNotAvailable";
        public const string InvalidUrl = "InvalidUrl";
        public const string NoInternetConnection = "NoInternetConnection";
        public const string ConnectionFailed = "ConnectionFailed";

        public const string ErrorHeadingText = "ErrorHeading";
        public const string ErrorMessageText = "ErrorMessage";
        public const string ErrorPageMimeType = "text/html";

        // Error Titles
        public const string SessionNotAvailableTitle = "Disconnected";
        public const string InvalidUrlTitle = "Invalid url";
        public const string NoInternetConnectionTitle = "No internet connection";
        public const string ConnectionFailedTitle = "Connection failed";
        public const string BookmarkFetchFailedTitle = "Unable to fetch bookmarks";
        public const string FailedtoRemoveBookmark = "Failed to remove bookmark";
        public const string FailedtoAddBookmark = "Failed to add bookmark";
        public const string PageNotFound = "Page not found";
        public const string ErrorOccured = "Error occured";
        public const string AuthenticationFailedTitle = "Authentication failed";
        public const string FailedToDeleteLogFile = "Failed to delete log file";
        public const string FailedToCopyLogFileContent = "Failed to copy log file content";

        // Error Messages
        public const string SessionNotAvailableMsg = "You are not connected to the SAFE Network.";
        public const string InvalidUrlMsg = "Please try again with a valid url.";
        public const string NoInternetConnectionMsg = "Please connect to the internet.";
        public const string ConnectionFailedMsg = "Could not connect to the SAFE Network. Try updating your IP address on invite server.";
        public const string BookmarkFetchFailedMsg = "Showing previously fetched bookmarks";
        public const string UnableToFetchDataMsg = "Unable to fetch data from the network.";
        public const string RequestDeniedMsg = "Request not granted";
        public const string AuthenticationFailedMsg = "Authentication failed";
    }
}
