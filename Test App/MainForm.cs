using Slack.Webhooks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_App
{
    public partial class MainForm : Form
    {
        const string WEBHOOK = "https://hooks.slack.com/services/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";
        const string ICONURI = "https://upload.wikimedia.org/wikipedia/fr/5/5b/Dallas_Stars_logo_secondaire.png";
        Slack client = new Slack();
        List<SlackAttachment> slackAttachments = new List<SlackAttachment> { null };
        List<SlackField> slackFields = new List<SlackField> { null };

        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_SendSlackMessage_Click(object sender, EventArgs e)
        {
            //needed params
            string username = tbox_SlackMessageUsername.Text;
            string message = tbox_SlackMessageValue.Text;
            Uri icon = new Uri(ICONURI);

            client.SendSlackMessage(WEBHOOK, username, message, icon, slackAttachments);

            //clear these so the next message is fresh
            slackAttachments.Clear();
            slackFields.Clear(); 
        }

        private void btn_SlackAttachmentAdd_Click(object sender, EventArgs e)
        {
            SlackAttachment attachment = new SlackAttachment { };
            
            //needed params
            string fallback = tbox_SlackAttachmentFallback.Text;
            string value = tbox_SlackAttachmentText.Text;
            string color = tbox_SlackAttachmentColor.Text;
            string title = tbox_SlackAttachmentTitle.Text;

            //optional params
            string pretext = tbox_SlackAttachmentPretext.Text;
            string titleLink = tbox_SlackAttachmentTitleLink.Text; //must start with https://
            string authorName = tbox_SlackAttachmentAuthorName.Text;
            string authorIcon = tbox_SlackAttachmentAuthorLink.Text;
            string authorLink = tbox_SlackAttachmentAuthorLink.Text; //must start with https://
            string imageURL = tbox_SlackAttachmentImageURL.Text;
            string thumbURL = tbox_SlackAttachmentThumbURL.Text;

            attachment = client.CreateSlackAttachment(fallback, value, color, title, slackFields, pretext, titleLink, authorName, authorIcon, authorLink, imageURL, thumbURL);

            slackAttachments.Add(attachment);
            slackFields.Clear(); //clear the fields for the next attachment

        }

        private void btn_SlackFieldAdd_Click(object sender, EventArgs e)
        {
            SlackField field = new SlackField { };

            //needed params
            string title = tbox_SlackFieldTitle.Text;
            string value = tbox_SlackFieldValue.Text;
            bool isShort = cbox_SlackFieldShort.Checked;

            field = client.CreateSlackField(title, value, isShort);

            slackFields.Add(field);
        }
    }
}

