﻿using DotNetCqs;

namespace OneTrueError.Api.Core.Users.Commands
{
    /// <summary>
    ///     Update user notifications
    /// </summary>
    public class UpdateNotifications : Command
    {
        /// <summary>
        ///     Application that the settings is for (0 = generel settings)
        /// </summary>
        public int ApplicationId { get; set; }

        /// <summary>
        ///     How to notify when a new incident is created (received an unique exception)
        /// </summary>
        public NotificationState NotifyOnNewIncidents { get; set; }

        /// <summary>
        ///     How to notify when a new report is created (receive an exception)
        /// </summary>
        public NotificationState NotifyOnNewReport { get; set; }

        /// <summary>
        ///     How to notify user when a peak is detected
        /// </summary>
        public NotificationState NotifyOnPeaks { get; set; }

        /// <summary>
        ///     How to notify when we receive a new report on a closed incident.
        /// </summary>
        public NotificationState NotifyOnReOpenedIncident { get; set; }

        /// <summary>
        ///     How to notify when an user have written an error description
        /// </summary>
        public NotificationState NotifyOnUserFeedback { get; set; }

        /// <summary>
        ///     User that configured its settings.
        /// </summary>
        public int UserId { get; set; }
    }
}