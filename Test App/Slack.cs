using Slack.Webhooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_App
{
    /// <summary>
    /// This class is used to interface with Slack by using the Slack.Webhooks NuGet package.
    /// </summary>
    class Slack
    {
        /// <summary>
        /// This function is used to send a message through Slack based on the webhook provided.
        /// </summary>
        /// <param name="uri">Webhook</param>
        /// <param name="username">User you want the bot to show up as</param>
        /// <param name="message">The actual message</param>
        /// <param name="slackAttachments">Slack attachments</param>
        public void SendSlackMessage(string uri, string username, string message, Uri IconURL = null, List<SlackAttachment> slackAttachments = null)
        {
            SlackClient slackClient = new SlackClient(uri);
            SlackMessage slackMessage = new SlackMessage { };

            if (IconURL == null)
            {
                slackMessage = new SlackMessage
                {
                    Username = username,
                    Text = message
                };
            }
            else
            {
                slackMessage = new SlackMessage
                {
                    Username = username,
                    Text = message,
                    IconUrl = IconURL
                };
            }
            
            if (slackAttachments != null)
            {
                slackMessage.Attachments = new List<SlackAttachment> { };
                slackMessage.Attachments.AddRange(slackAttachments);
            }
                        
            slackClient.Post(slackMessage);
        }

        /// <summary>
        /// This function is used to create Slack Attachments
        /// </summary>
        /// <param name="fallback">This shows if the message cannot be shown</param>
        /// <param name="text">Main text of the attachment</param>
        /// <param name="color">Hex color of the bar beside the attachment</param>
        /// <param name="title">Title of the attachment</param>
        /// <param name="fields">Slack fields</param>
        /// <param name="pretext">Optional pretext on the message</param>
        /// <param name="title_link">Optional link on the title of the message</param>
        /// <param name="author_name">Optional Author's name</param>
        /// <param name="author_icon">Optional Author's icon (can be a url)</param>
        /// <param name="author_link">Optional link on the Author's name</param>
        /// <param name="pretext">Optional text to show before the main text</param>
        /// <param name="image_url">Optional image URL</param>
        /// <param name="thumb_url">Optional thumb URL</param>
        /// <param name="footer">Optional footer</param>
        /// <param name="footer_url">Optional footer url</param>
        /// <returns>A finished Slack Attachment to attach to a message</returns>
        public SlackAttachment CreateSlackAttachment(string fallback, string text, string color, string title, List<SlackField> fields = null, string pretext = null, string title_link = null, string author_name = null, string author_icon = null, string author_link = null, string image_url = null, string thumb_url = null, string footer = null, string footer_url = null)
        {
            SlackAttachment slackAttachment = new SlackAttachment { };

            if (fields != null)
            {
                slackAttachment = new SlackAttachment
                {
                    Fallback = fallback,
                    Text = text,
                    Color = color,
                    Pretext = pretext,
                    AuthorName = author_name,
                    AuthorIcon = author_icon,
                    AuthorLink = author_link,
                    Title = title,
                    TitleLink = title_link,
                    Fields = new List<SlackField> { },
                    ImageUrl = image_url,
                    ThumbUrl = thumb_url,
                    Footer = footer,
                    FooterIcon = footer_url
                };

                slackAttachment.Fields.AddRange(fields);
            }
            else
            {

                slackAttachment = new SlackAttachment
                {
                    Fallback = fallback,
                    Text = text,
                    Color = color,
                    Pretext = pretext,
                    AuthorName = author_name,
                    AuthorIcon = author_icon,
                    AuthorLink = author_link,
                    Title = title,
                    TitleLink = title_link,
                    ImageUrl = image_url,
                    ThumbUrl = thumb_url,
                    Footer = footer,
                    FooterIcon = footer_url
                };
            }

            
            return slackAttachment;
        }

        /// <summary>
        /// Create a SlackField
        /// </summary>
        /// <param name="title">Title of Slack Field</param>
        /// <param name="value">Message in the Slack Field</param>
        /// <param name="isShort">Make the field the whole length of the field, or false for not the whole length</param>
        /// <returns>A completed SlackField</returns>
        public SlackField CreateSlackField (string title, string value, bool isShort)
        {
            SlackField slackField = new SlackField
            {
                Title = title,
                Value = value,
                Short = isShort
            };

            return slackField;
        }
    }

   
}
