namespace RemoteCommandSender
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtcommand = new TextBox();
            btnSendCommand = new Button();
            txtoutput = new TextBox();
            label1 = new Label();
            txtIPAddress = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtcommand
            // 
            txtcommand.Location = new Point(216, 87);
            txtcommand.Margin = new Padding(4, 3, 4, 3);
            txtcommand.Name = "txtcommand";
            txtcommand.PlaceholderText = "Enter the command";
            txtcommand.Size = new Size(505, 28);
            txtcommand.TabIndex = 0;
            txtcommand.TextChanged += textBox1_TextChanged;
            // 
            // btnSendCommand
            // 
            btnSendCommand.BackColor = SystemColors.HotTrack;
            btnSendCommand.BackgroundImageLayout = ImageLayout.Center;
            btnSendCommand.Cursor = Cursors.Hand;
            btnSendCommand.FlatStyle = FlatStyle.Popup;
            btnSendCommand.Location = new Point(236, 143);
            btnSendCommand.Margin = new Padding(4, 3, 4, 3);
            btnSendCommand.Name = "btnSendCommand";
            btnSendCommand.Size = new Size(218, 28);
            btnSendCommand.TabIndex = 1;
            btnSendCommand.Text = "Send Command";
            btnSendCommand.UseVisualStyleBackColor = false;
            btnSendCommand.Click += btnSendCommand_Click;
            // 
            // txtoutput
            // 
            txtoutput.Location = new Point(216, 234);
            txtoutput.Margin = new Padding(4, 3, 4, 3);
            txtoutput.Multiline = true;
            txtoutput.Name = "txtoutput";
            txtoutput.ScrollBars = ScrollBars.Vertical;
            txtoutput.Size = new Size(505, 132);
            txtoutput.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 87);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 21);
            label1.TabIndex = 3;
            label1.Text = "Enter your command";
            // 
            // txtIPAddress
            // 
            txtIPAddress.Location = new Point(216, 31);
            txtIPAddress.Name = "txtIPAddress";
            txtIPAddress.PlaceholderText = "Enter the IP address of recipient device";
            txtIPAddress.Size = new Size(505, 28);
            txtIPAddress.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 5;
            label2.Text = "Enter IP:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 234);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 6;
            label3.Text = "OUTPUT:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(736, 392);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtIPAddress);
            Controls.Add(label1);
            Controls.Add(txtoutput);
            Controls.Add(btnSendCommand);
            Controls.Add(txtcommand);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.OrangeRed;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "SNS-v.0";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcommand;
        private Button btnSendCommand;
        private TextBox txtoutput;
        private Label label1;
        private TextBox txtIPAddress;
        private Label label2;
        private Label label3;
    }
}
