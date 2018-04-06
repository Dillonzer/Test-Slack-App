namespace Test_App
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_SendSlackMessage = new System.Windows.Forms.Button();
            this.tbox_SlackFieldTitle = new System.Windows.Forms.TextBox();
            this.tbox_SlackFieldValue = new System.Windows.Forms.TextBox();
            this.cbox_SlackFieldShort = new System.Windows.Forms.CheckBox();
            this.gbox_SlackField = new System.Windows.Forms.GroupBox();
            this.btn_SlackFieldAdd = new System.Windows.Forms.Button();
            this.lbl_SlackFieldValue = new System.Windows.Forms.Label();
            this.lbl_SlackFieldTitle = new System.Windows.Forms.Label();
            this.gbox_SlackMessage = new System.Windows.Forms.GroupBox();
            this.lbl_SlackMessageValue = new System.Windows.Forms.Label();
            this.tbox_SlackMessageValue = new System.Windows.Forms.TextBox();
            this.tbox_SlackMessageUsername = new System.Windows.Forms.TextBox();
            this.lbl_SlackMessageUsername = new System.Windows.Forms.Label();
            this.gbox_SlackAttachment = new System.Windows.Forms.GroupBox();
            this.tbox_SlackAttachmentTitle = new System.Windows.Forms.TextBox();
            this.lbl_SlackAttachmentTitle = new System.Windows.Forms.Label();
            this.btn_SlackAttachmentAdd = new System.Windows.Forms.Button();
            this.tbox_SlackAttachmentFallback = new System.Windows.Forms.TextBox();
            this.tbox_SlackAttachmentPretext = new System.Windows.Forms.TextBox();
            this.tbox_SlackAttachmentColor = new System.Windows.Forms.TextBox();
            this.tbox_SlackAttachmentText = new System.Windows.Forms.TextBox();
            this.lbl_SlackAttachmentPreText = new System.Windows.Forms.Label();
            this.lbl_SlackAttachmentColor = new System.Windows.Forms.Label();
            this.lbl_SlackAttachmentText = new System.Windows.Forms.Label();
            this.lbl_SlackAttachmentFallback = new System.Windows.Forms.Label();
            this.lbl_SlackMessageFieldTip = new System.Windows.Forms.Label();
            this.gbox_SlackField.SuspendLayout();
            this.gbox_SlackMessage.SuspendLayout();
            this.gbox_SlackAttachment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SendSlackMessage
            // 
            this.btn_SendSlackMessage.Location = new System.Drawing.Point(478, 369);
            this.btn_SendSlackMessage.Name = "btn_SendSlackMessage";
            this.btn_SendSlackMessage.Size = new System.Drawing.Size(87, 23);
            this.btn_SendSlackMessage.TabIndex = 0;
            this.btn_SendSlackMessage.Text = "Send Message";
            this.btn_SendSlackMessage.UseVisualStyleBackColor = true;
            this.btn_SendSlackMessage.Click += new System.EventHandler(this.btn_SendSlackMessage_Click);
            // 
            // tbox_SlackFieldTitle
            // 
            this.tbox_SlackFieldTitle.Location = new System.Drawing.Point(46, 17);
            this.tbox_SlackFieldTitle.Name = "tbox_SlackFieldTitle";
            this.tbox_SlackFieldTitle.Size = new System.Drawing.Size(147, 20);
            this.tbox_SlackFieldTitle.TabIndex = 2;
            // 
            // tbox_SlackFieldValue
            // 
            this.tbox_SlackFieldValue.Location = new System.Drawing.Point(46, 40);
            this.tbox_SlackFieldValue.Name = "tbox_SlackFieldValue";
            this.tbox_SlackFieldValue.Size = new System.Drawing.Size(147, 20);
            this.tbox_SlackFieldValue.TabIndex = 3;
            // 
            // cbox_SlackFieldShort
            // 
            this.cbox_SlackFieldShort.AutoSize = true;
            this.cbox_SlackFieldShort.Location = new System.Drawing.Point(9, 66);
            this.cbox_SlackFieldShort.Name = "cbox_SlackFieldShort";
            this.cbox_SlackFieldShort.Size = new System.Drawing.Size(51, 17);
            this.cbox_SlackFieldShort.TabIndex = 4;
            this.cbox_SlackFieldShort.Text = "Short";
            this.cbox_SlackFieldShort.UseVisualStyleBackColor = true;
            // 
            // gbox_SlackField
            // 
            this.gbox_SlackField.Controls.Add(this.btn_SlackFieldAdd);
            this.gbox_SlackField.Controls.Add(this.lbl_SlackFieldValue);
            this.gbox_SlackField.Controls.Add(this.lbl_SlackFieldTitle);
            this.gbox_SlackField.Controls.Add(this.cbox_SlackFieldShort);
            this.gbox_SlackField.Controls.Add(this.tbox_SlackFieldTitle);
            this.gbox_SlackField.Controls.Add(this.tbox_SlackFieldValue);
            this.gbox_SlackField.Location = new System.Drawing.Point(348, 10);
            this.gbox_SlackField.Name = "gbox_SlackField";
            this.gbox_SlackField.Size = new System.Drawing.Size(205, 95);
            this.gbox_SlackField.TabIndex = 5;
            this.gbox_SlackField.TabStop = false;
            this.gbox_SlackField.Text = "Slack Field";
            // 
            // btn_SlackFieldAdd
            // 
            this.btn_SlackFieldAdd.Location = new System.Drawing.Point(118, 66);
            this.btn_SlackFieldAdd.Name = "btn_SlackFieldAdd";
            this.btn_SlackFieldAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_SlackFieldAdd.TabIndex = 7;
            this.btn_SlackFieldAdd.Text = "Add Field";
            this.btn_SlackFieldAdd.UseVisualStyleBackColor = true;
            this.btn_SlackFieldAdd.Click += new System.EventHandler(this.btn_SlackFieldAdd_Click);
            // 
            // lbl_SlackFieldValue
            // 
            this.lbl_SlackFieldValue.AutoSize = true;
            this.lbl_SlackFieldValue.Location = new System.Drawing.Point(6, 43);
            this.lbl_SlackFieldValue.Name = "lbl_SlackFieldValue";
            this.lbl_SlackFieldValue.Size = new System.Drawing.Size(34, 13);
            this.lbl_SlackFieldValue.TabIndex = 6;
            this.lbl_SlackFieldValue.Text = "Value";
            // 
            // lbl_SlackFieldTitle
            // 
            this.lbl_SlackFieldTitle.AutoSize = true;
            this.lbl_SlackFieldTitle.Location = new System.Drawing.Point(6, 20);
            this.lbl_SlackFieldTitle.Name = "lbl_SlackFieldTitle";
            this.lbl_SlackFieldTitle.Size = new System.Drawing.Size(27, 13);
            this.lbl_SlackFieldTitle.TabIndex = 5;
            this.lbl_SlackFieldTitle.Text = "Title";
            // 
            // gbox_SlackMessage
            // 
            this.gbox_SlackMessage.Controls.Add(this.lbl_SlackMessageValue);
            this.gbox_SlackMessage.Controls.Add(this.tbox_SlackMessageValue);
            this.gbox_SlackMessage.Controls.Add(this.tbox_SlackMessageUsername);
            this.gbox_SlackMessage.Controls.Add(this.lbl_SlackMessageUsername);
            this.gbox_SlackMessage.Location = new System.Drawing.Point(12, 12);
            this.gbox_SlackMessage.Name = "gbox_SlackMessage";
            this.gbox_SlackMessage.Size = new System.Drawing.Size(562, 73);
            this.gbox_SlackMessage.TabIndex = 6;
            this.gbox_SlackMessage.TabStop = false;
            this.gbox_SlackMessage.Text = "Slack Message";
            // 
            // lbl_SlackMessageValue
            // 
            this.lbl_SlackMessageValue.AutoSize = true;
            this.lbl_SlackMessageValue.Location = new System.Drawing.Point(10, 46);
            this.lbl_SlackMessageValue.Name = "lbl_SlackMessageValue";
            this.lbl_SlackMessageValue.Size = new System.Drawing.Size(50, 13);
            this.lbl_SlackMessageValue.TabIndex = 3;
            this.lbl_SlackMessageValue.Text = "Message";
            // 
            // tbox_SlackMessageValue
            // 
            this.tbox_SlackMessageValue.Location = new System.Drawing.Point(66, 43);
            this.tbox_SlackMessageValue.Name = "tbox_SlackMessageValue";
            this.tbox_SlackMessageValue.Size = new System.Drawing.Size(487, 20);
            this.tbox_SlackMessageValue.TabIndex = 2;
            // 
            // tbox_SlackMessageUsername
            // 
            this.tbox_SlackMessageUsername.Location = new System.Drawing.Point(66, 17);
            this.tbox_SlackMessageUsername.Name = "tbox_SlackMessageUsername";
            this.tbox_SlackMessageUsername.Size = new System.Drawing.Size(124, 20);
            this.tbox_SlackMessageUsername.TabIndex = 1;
            // 
            // lbl_SlackMessageUsername
            // 
            this.lbl_SlackMessageUsername.AutoSize = true;
            this.lbl_SlackMessageUsername.Location = new System.Drawing.Point(9, 20);
            this.lbl_SlackMessageUsername.Name = "lbl_SlackMessageUsername";
            this.lbl_SlackMessageUsername.Size = new System.Drawing.Size(54, 13);
            this.lbl_SlackMessageUsername.TabIndex = 0;
            this.lbl_SlackMessageUsername.Text = "Bot Name";
            // 
            // gbox_SlackAttachment
            // 
            this.gbox_SlackAttachment.Controls.Add(this.lbl_SlackMessageFieldTip);
            this.gbox_SlackAttachment.Controls.Add(this.tbox_SlackAttachmentTitle);
            this.gbox_SlackAttachment.Controls.Add(this.lbl_SlackAttachmentTitle);
            this.gbox_SlackAttachment.Controls.Add(this.gbox_SlackField);
            this.gbox_SlackAttachment.Controls.Add(this.btn_SlackAttachmentAdd);
            this.gbox_SlackAttachment.Controls.Add(this.tbox_SlackAttachmentFallback);
            this.gbox_SlackAttachment.Controls.Add(this.tbox_SlackAttachmentPretext);
            this.gbox_SlackAttachment.Controls.Add(this.tbox_SlackAttachmentColor);
            this.gbox_SlackAttachment.Controls.Add(this.tbox_SlackAttachmentText);
            this.gbox_SlackAttachment.Controls.Add(this.lbl_SlackAttachmentPreText);
            this.gbox_SlackAttachment.Controls.Add(this.lbl_SlackAttachmentColor);
            this.gbox_SlackAttachment.Controls.Add(this.lbl_SlackAttachmentText);
            this.gbox_SlackAttachment.Controls.Add(this.lbl_SlackAttachmentFallback);
            this.gbox_SlackAttachment.Location = new System.Drawing.Point(12, 91);
            this.gbox_SlackAttachment.Name = "gbox_SlackAttachment";
            this.gbox_SlackAttachment.Size = new System.Drawing.Size(562, 272);
            this.gbox_SlackAttachment.TabIndex = 7;
            this.gbox_SlackAttachment.TabStop = false;
            this.gbox_SlackAttachment.Text = "Slack Attachment";
            // 
            // tbox_SlackAttachmentTitle
            // 
            this.tbox_SlackAttachmentTitle.Location = new System.Drawing.Point(66, 19);
            this.tbox_SlackAttachmentTitle.Name = "tbox_SlackAttachmentTitle";
            this.tbox_SlackAttachmentTitle.Size = new System.Drawing.Size(100, 20);
            this.tbox_SlackAttachmentTitle.TabIndex = 10;
            // 
            // lbl_SlackAttachmentTitle
            // 
            this.lbl_SlackAttachmentTitle.AutoSize = true;
            this.lbl_SlackAttachmentTitle.Location = new System.Drawing.Point(15, 22);
            this.lbl_SlackAttachmentTitle.Name = "lbl_SlackAttachmentTitle";
            this.lbl_SlackAttachmentTitle.Size = new System.Drawing.Size(27, 13);
            this.lbl_SlackAttachmentTitle.TabIndex = 9;
            this.lbl_SlackAttachmentTitle.Text = "Title";
            // 
            // btn_SlackAttachmentAdd
            // 
            this.btn_SlackAttachmentAdd.Location = new System.Drawing.Point(445, 243);
            this.btn_SlackAttachmentAdd.Name = "btn_SlackAttachmentAdd";
            this.btn_SlackAttachmentAdd.Size = new System.Drawing.Size(108, 23);
            this.btn_SlackAttachmentAdd.TabIndex = 8;
            this.btn_SlackAttachmentAdd.Text = "Add Attachment";
            this.btn_SlackAttachmentAdd.UseVisualStyleBackColor = true;
            this.btn_SlackAttachmentAdd.Click += new System.EventHandler(this.btn_SlackAttachmentAdd_Click);
            // 
            // tbox_SlackAttachmentFallback
            // 
            this.tbox_SlackAttachmentFallback.Location = new System.Drawing.Point(66, 124);
            this.tbox_SlackAttachmentFallback.Name = "tbox_SlackAttachmentFallback";
            this.tbox_SlackAttachmentFallback.Size = new System.Drawing.Size(100, 20);
            this.tbox_SlackAttachmentFallback.TabIndex = 7;
            // 
            // tbox_SlackAttachmentPretext
            // 
            this.tbox_SlackAttachmentPretext.Location = new System.Drawing.Point(66, 98);
            this.tbox_SlackAttachmentPretext.Name = "tbox_SlackAttachmentPretext";
            this.tbox_SlackAttachmentPretext.Size = new System.Drawing.Size(100, 20);
            this.tbox_SlackAttachmentPretext.TabIndex = 6;
            // 
            // tbox_SlackAttachmentColor
            // 
            this.tbox_SlackAttachmentColor.Location = new System.Drawing.Point(66, 71);
            this.tbox_SlackAttachmentColor.Name = "tbox_SlackAttachmentColor";
            this.tbox_SlackAttachmentColor.Size = new System.Drawing.Size(100, 20);
            this.tbox_SlackAttachmentColor.TabIndex = 5;
            // 
            // tbox_SlackAttachmentText
            // 
            this.tbox_SlackAttachmentText.Location = new System.Drawing.Point(66, 45);
            this.tbox_SlackAttachmentText.Name = "tbox_SlackAttachmentText";
            this.tbox_SlackAttachmentText.Size = new System.Drawing.Size(100, 20);
            this.tbox_SlackAttachmentText.TabIndex = 4;
            // 
            // lbl_SlackAttachmentPreText
            // 
            this.lbl_SlackAttachmentPreText.AutoSize = true;
            this.lbl_SlackAttachmentPreText.Location = new System.Drawing.Point(13, 101);
            this.lbl_SlackAttachmentPreText.Name = "lbl_SlackAttachmentPreText";
            this.lbl_SlackAttachmentPreText.Size = new System.Drawing.Size(40, 13);
            this.lbl_SlackAttachmentPreText.TabIndex = 3;
            this.lbl_SlackAttachmentPreText.Text = "Pretext";
            // 
            // lbl_SlackAttachmentColor
            // 
            this.lbl_SlackAttachmentColor.AutoSize = true;
            this.lbl_SlackAttachmentColor.Location = new System.Drawing.Point(15, 74);
            this.lbl_SlackAttachmentColor.Name = "lbl_SlackAttachmentColor";
            this.lbl_SlackAttachmentColor.Size = new System.Drawing.Size(31, 13);
            this.lbl_SlackAttachmentColor.TabIndex = 2;
            this.lbl_SlackAttachmentColor.Text = "Color";
            // 
            // lbl_SlackAttachmentText
            // 
            this.lbl_SlackAttachmentText.AutoSize = true;
            this.lbl_SlackAttachmentText.Location = new System.Drawing.Point(15, 48);
            this.lbl_SlackAttachmentText.Name = "lbl_SlackAttachmentText";
            this.lbl_SlackAttachmentText.Size = new System.Drawing.Size(28, 13);
            this.lbl_SlackAttachmentText.TabIndex = 1;
            this.lbl_SlackAttachmentText.Text = "Text";
            // 
            // lbl_SlackAttachmentFallback
            // 
            this.lbl_SlackAttachmentFallback.AutoSize = true;
            this.lbl_SlackAttachmentFallback.Location = new System.Drawing.Point(13, 127);
            this.lbl_SlackAttachmentFallback.Name = "lbl_SlackAttachmentFallback";
            this.lbl_SlackAttachmentFallback.Size = new System.Drawing.Size(47, 13);
            this.lbl_SlackAttachmentFallback.TabIndex = 0;
            this.lbl_SlackAttachmentFallback.Text = "Fallback";
            // 
            // lbl_SlackMessageFieldTip
            // 
            this.lbl_SlackMessageFieldTip.ForeColor = System.Drawing.Color.Red;
            this.lbl_SlackMessageFieldTip.Location = new System.Drawing.Point(348, 108);
            this.lbl_SlackMessageFieldTip.Name = "lbl_SlackMessageFieldTip";
            this.lbl_SlackMessageFieldTip.Size = new System.Drawing.Size(205, 45);
            this.lbl_SlackMessageFieldTip.TabIndex = 11;
            this.lbl_SlackMessageFieldTip.Text = "You have to add a field before adding the attachment for fields to add correctly." +
    "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 405);
            this.Controls.Add(this.gbox_SlackAttachment);
            this.Controls.Add(this.gbox_SlackMessage);
            this.Controls.Add(this.btn_SendSlackMessage);
            this.Name = "MainForm";
            this.Text = "Slack Sender";
            this.gbox_SlackField.ResumeLayout(false);
            this.gbox_SlackField.PerformLayout();
            this.gbox_SlackMessage.ResumeLayout(false);
            this.gbox_SlackMessage.PerformLayout();
            this.gbox_SlackAttachment.ResumeLayout(false);
            this.gbox_SlackAttachment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SendSlackMessage;
        private System.Windows.Forms.TextBox tbox_SlackFieldTitle;
        private System.Windows.Forms.TextBox tbox_SlackFieldValue;
        private System.Windows.Forms.CheckBox cbox_SlackFieldShort;
        private System.Windows.Forms.GroupBox gbox_SlackField;
        private System.Windows.Forms.Label lbl_SlackFieldValue;
        private System.Windows.Forms.Label lbl_SlackFieldTitle;
        private System.Windows.Forms.Button btn_SlackFieldAdd;
        private System.Windows.Forms.GroupBox gbox_SlackMessage;
        private System.Windows.Forms.TextBox tbox_SlackMessageUsername;
        private System.Windows.Forms.Label lbl_SlackMessageUsername;
        private System.Windows.Forms.Label lbl_SlackMessageValue;
        private System.Windows.Forms.TextBox tbox_SlackMessageValue;
        private System.Windows.Forms.GroupBox gbox_SlackAttachment;
        private System.Windows.Forms.TextBox tbox_SlackAttachmentFallback;
        private System.Windows.Forms.TextBox tbox_SlackAttachmentPretext;
        private System.Windows.Forms.TextBox tbox_SlackAttachmentColor;
        private System.Windows.Forms.TextBox tbox_SlackAttachmentText;
        private System.Windows.Forms.Label lbl_SlackAttachmentPreText;
        private System.Windows.Forms.Label lbl_SlackAttachmentColor;
        private System.Windows.Forms.Label lbl_SlackAttachmentText;
        private System.Windows.Forms.Label lbl_SlackAttachmentFallback;
        private System.Windows.Forms.Button btn_SlackAttachmentAdd;
        private System.Windows.Forms.TextBox tbox_SlackAttachmentTitle;
        private System.Windows.Forms.Label lbl_SlackAttachmentTitle;
        private System.Windows.Forms.Label lbl_SlackMessageFieldTip;
    }
}

