﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Spam
{
    /// <summary>
    ///     This class defines an Akismet's comment format.
    /// </summary>
    public class Comment
    {
        /// <summary>
        ///     The front page or home URL of the instance making the request. For a blog or wiki this would be the front page.
        ///     Must be a full URI, including http://.
        /// </summary>
        /// <remarks>This property is required.</remarks>
        public string blog { get; set; }

        /// <summary>
        ///     IP address of the comment submitter.
        /// </summary>
        /// <remarks>This property is required.</remarks>
        public string user_ip { get; set; }

        /// <summary>
        ///     User agent string of the web browser submitting the comment - typically the HTTP_USER_AGENT cgi variable. Not to be
        ///     confused with the user agent of your Akismet library.
        /// </summary>
        /// <remarks>This property is required.</remarks>
        public string user_agent { get; set; }

        /// <summary>
        ///     The content of the HTTP_REFERER header should be sent here.
        /// </summary>
        public string referrer { get; set; }

        /// <summary>
        ///     The permanent location of the entry the comment was submitted to.
        /// </summary>
        public string permalink { get; set; }

        /// <summary>
        ///     May be blank, comment, trackback, pingback, or a made up value like "registration".
        /// </summary>
        public string comment_type { get; set; }

        /// <summary>
        ///     Name submitted with the comment.
        /// </summary>
        public string comment_author { get; set; }

        /// <summary>
        ///     Email address submitted with the comment.
        /// </summary>
        public string comment_author_email { get; set; }

        /// <summary>
        ///     URL submitted with comment.
        /// </summary>
        public string comment_author_url { get; set; }

        /// <summary>
        ///     The content that was submitted.
        /// </summary>
        public string comment_content { get; set; }

        /// <summary>
        ///     Check is current comment is valid.
        /// </summary>
        public bool IsValid => !(string.IsNullOrWhiteSpace(blog) || string.IsNullOrWhiteSpace(user_ip) ||
                                 string.IsNullOrWhiteSpace(user_agent));
    }
}
