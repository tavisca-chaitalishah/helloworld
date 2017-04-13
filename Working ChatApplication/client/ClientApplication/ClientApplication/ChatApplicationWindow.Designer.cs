namespace ClientApplication
{
    partial class ChatApplicationWindow
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
            this._chatApplicationPanel = new System.Windows.Forms.Panel();
            this._panel1 = new System.Windows.Forms.Panel();
            this._groupConversationTextBox = new System.Windows.Forms.TextBox();
            this._sendButton = new System.Windows.Forms.Button();
            this._enterMessageTextBox = new System.Windows.Forms.TextBox();
            this._buttonToConnectToServer = new System.Windows.Forms.Button();
            this._nameOfClientTextBox = new System.Windows.Forms.TextBox();
            this._enterNameLabel = new System.Windows.Forms.Label();
            this._titleOfApplication = new System.Windows.Forms.Label();
            this._chatApplicationPanel.SuspendLayout();
            this._panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _chatApplicationPanel
            // 
            this._chatApplicationPanel.BackColor = System.Drawing.Color.LavenderBlush;
            this._chatApplicationPanel.Controls.Add(this._panel1);
            this._chatApplicationPanel.Controls.Add(this._titleOfApplication);
            this._chatApplicationPanel.Location = new System.Drawing.Point(-2, -1);
            this._chatApplicationPanel.Name = "_chatApplicationPanel";
            this._chatApplicationPanel.Size = new System.Drawing.Size(1569, 741);
            this._chatApplicationPanel.TabIndex = 0;
            // 
            // _panel1
            // 
            this._panel1.Controls.Add(this._groupConversationTextBox);
            this._panel1.Controls.Add(this._sendButton);
            this._panel1.Controls.Add(this._enterMessageTextBox);
            this._panel1.Controls.Add(this._buttonToConnectToServer);
            this._panel1.Controls.Add(this._nameOfClientTextBox);
            this._panel1.Controls.Add(this._enterNameLabel);
            this._panel1.Location = new System.Drawing.Point(289, 105);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(1026, 575);
            this._panel1.TabIndex = 2;
            // 
            // _groupConversationTextBox
            // 
            this._groupConversationTextBox.Location = new System.Drawing.Point(16, 94);
            this._groupConversationTextBox.Multiline = true;
            this._groupConversationTextBox.Name = "_groupConversationTextBox";
            this._groupConversationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._groupConversationTextBox.Size = new System.Drawing.Size(997, 404);
            this._groupConversationTextBox.TabIndex = 7;
            // 
            // _sendButton
            // 
            this._sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sendButton.Location = new System.Drawing.Point(904, 517);
            this._sendButton.Name = "_sendButton";
            this._sendButton.Size = new System.Drawing.Size(121, 55);
            this._sendButton.TabIndex = 5;
            this._sendButton.Text = "Send ";
            this._sendButton.UseVisualStyleBackColor = false;
            this._sendButton.Click += new System.EventHandler(this._SendButton_Click);
            // 
            // _enterMessageTextBox
            // 
            this._enterMessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._enterMessageTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._enterMessageTextBox.HideSelection = false;
            this._enterMessageTextBox.Location = new System.Drawing.Point(16, 517);
            this._enterMessageTextBox.Multiline = true;
            this._enterMessageTextBox.Name = "_enterMessageTextBox";
            this._enterMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._enterMessageTextBox.Size = new System.Drawing.Size(883, 56);
            this._enterMessageTextBox.TabIndex = 4;

            // 
            // _buttonToConnectToServer
            // 
            this._buttonToConnectToServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._buttonToConnectToServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonToConnectToServer.Location = new System.Drawing.Point(813, 35);
            this._buttonToConnectToServer.Name = "_buttonToConnectToServer";
            this._buttonToConnectToServer.Size = new System.Drawing.Size(137, 42);
            this._buttonToConnectToServer.TabIndex = 3;
            this._buttonToConnectToServer.Text = "Connect To Server";
            this._buttonToConnectToServer.UseVisualStyleBackColor = false;
            this._buttonToConnectToServer.Click += new System.EventHandler(this._ButtonToConnectToServer_Click);
            // 
            // _nameOfClientTextBox
            // 
            this._nameOfClientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nameOfClientTextBox.Location = new System.Drawing.Point(363, 35);
            this._nameOfClientTextBox.Multiline = true;
            this._nameOfClientTextBox.Name = "_nameOfClientTextBox";
            this._nameOfClientTextBox.Size = new System.Drawing.Size(420, 38);
            this._nameOfClientTextBox.TabIndex = 2;

            // 
            // _enterNameLabel
            // 
            this._enterNameLabel.AutoSize = true;
            this._enterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._enterNameLabel.Location = new System.Drawing.Point(53, 35);
            this._enterNameLabel.Name = "_enterNameLabel";
            this._enterNameLabel.Size = new System.Drawing.Size(272, 31);
            this._enterNameLabel.TabIndex = 1;
            this._enterNameLabel.Text = "Enter Name of Client ";
            // 
            // _titleOfApplication
            // 
            this._titleOfApplication.AutoSize = true;
            this._titleOfApplication.BackColor = System.Drawing.Color.LightCoral;
            this._titleOfApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titleOfApplication.ForeColor = System.Drawing.SystemColors.ControlText;
            this._titleOfApplication.Location = new System.Drawing.Point(3, 0);
            this._titleOfApplication.Name = "_titleOfApplication";
            this._titleOfApplication.Size = new System.Drawing.Size(1569, 55);
            this._titleOfApplication.TabIndex = 0;
            this._titleOfApplication.Text = "                                 Chat Application For Group                      " +
    "            ";
            // 
            // ChatApplicationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 776);
            this.Controls.Add(this._chatApplicationPanel);
            this.Name = "ChatApplicationWindow";
            this.Text = "ChatApplicationWindow";
            this._chatApplicationPanel.ResumeLayout(false);
            this._chatApplicationPanel.PerformLayout();
            this._panel1.ResumeLayout(false);
            this._panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _chatApplicationPanel;
        private System.Windows.Forms.Label _titleOfApplication;
        private System.Windows.Forms.Label _enterNameLabel;
        private System.Windows.Forms.Panel _panel1;
        private System.Windows.Forms.Button _sendButton;
        private System.Windows.Forms.TextBox _enterMessageTextBox;
        private System.Windows.Forms.Button _buttonToConnectToServer;
        private System.Windows.Forms.TextBox _nameOfClientTextBox;
        private System.Windows.Forms.TextBox _groupConversationTextBox;
    }
}

