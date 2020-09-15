namespace RUA
{
    partial class Form2
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
            this.labanmetag = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblMod = new System.Windows.Forms.Label();
            this.lblPremium = new System.Windows.Forms.Label();
            this.lblKarmaTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNsfw = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblKarmaAward = new System.Windows.Forms.Label();
            this.lblStaticKarmaAward = new System.Windows.Forms.Label();
            this.lblStaticKarmaComment = new System.Windows.Forms.Label();
            this.lblKarmaComment = new System.Windows.Forms.Label();
            this.lblKarmaLink = new System.Windows.Forms.Label();
            this.lblStaticKarmaLink = new System.Windows.Forms.Label();
            this.lblStaticKarmaTotal = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCreatedOn = new System.Windows.Forms.Label();
            this.lblStaticCreatedOn = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labanmetag
            // 
            this.labanmetag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labanmetag.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labanmetag.Location = new System.Drawing.Point(237, 19);
            this.labanmetag.Name = "labanmetag";
            this.labanmetag.Size = new System.Drawing.Size(329, 33);
            this.labanmetag.TabIndex = 0;
            this.labanmetag.Text = "USERNAME";
            this.labanmetag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lblAdmin.ForeColor = System.Drawing.Color.Red;
            this.lblAdmin.Location = new System.Drawing.Point(6, 16);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(54, 20);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Text = "ADMIN";
            this.lblAdmin.Visible = false;
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lblMod.ForeColor = System.Drawing.Color.Green;
            this.lblMod.Location = new System.Drawing.Point(6, 36);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(90, 20);
            this.lblMod.TabIndex = 3;
            this.lblMod.Text = "MODERATOR";
            this.lblMod.Visible = false;
            // 
            // lblPremium
            // 
            this.lblPremium.AutoSize = true;
            this.lblPremium.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lblPremium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPremium.Location = new System.Drawing.Point(6, 56);
            this.lblPremium.Name = "lblPremium";
            this.lblPremium.Size = new System.Drawing.Size(72, 20);
            this.lblPremium.TabIndex = 4;
            this.lblPremium.Text = "PREMIUM";
            this.lblPremium.Visible = false;
            // 
            // lblKarmaTotal
            // 
            this.lblKarmaTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaTotal.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKarmaTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblKarmaTotal.Location = new System.Drawing.Point(74, 16);
            this.lblKarmaTotal.Name = "lblKarmaTotal";
            this.lblKarmaTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKarmaTotal.Size = new System.Drawing.Size(101, 18);
            this.lblKarmaTotal.TabIndex = 5;
            this.lblKarmaTotal.Text = "TOTAL";
            this.lblKarmaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNsfw);
            this.groupBox1.Controls.Add(this.lblPremium);
            this.groupBox1.Controls.Add(this.lblAdmin);
            this.groupBox1.Controls.Add(this.lblMod);
            this.groupBox1.Location = new System.Drawing.Point(123, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 103);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " info";
            // 
            // lblNsfw
            // 
            this.lblNsfw.AutoSize = true;
            this.lblNsfw.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lblNsfw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNsfw.Location = new System.Drawing.Point(6, 76);
            this.lblNsfw.Name = "lblNsfw";
            this.lblNsfw.Size = new System.Drawing.Size(45, 20);
            this.lblNsfw.TabIndex = 5;
            this.lblNsfw.Text = "NSFW";
            this.lblNsfw.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblKarmaAward);
            this.groupBox2.Controls.Add(this.lblStaticKarmaAward);
            this.groupBox2.Controls.Add(this.lblStaticKarmaComment);
            this.groupBox2.Controls.Add(this.lblKarmaComment);
            this.groupBox2.Controls.Add(this.lblKarmaLink);
            this.groupBox2.Controls.Add(this.lblStaticKarmaLink);
            this.groupBox2.Controls.Add(this.lblKarmaTotal);
            this.groupBox2.Controls.Add(this.lblStaticKarmaTotal);
            this.groupBox2.Location = new System.Drawing.Point(568, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 95);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "karma";
            // 
            // lblKarmaAward
            // 
            this.lblKarmaAward.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaAward.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKarmaAward.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblKarmaAward.Location = new System.Drawing.Point(71, 70);
            this.lblKarmaAward.Name = "lblKarmaAward";
            this.lblKarmaAward.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKarmaAward.Size = new System.Drawing.Size(104, 18);
            this.lblKarmaAward.TabIndex = 12;
            this.lblKarmaAward.Text = "AWARD";
            this.lblKarmaAward.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStaticKarmaAward
            // 
            this.lblStaticKarmaAward.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStaticKarmaAward.AutoSize = true;
            this.lblStaticKarmaAward.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStaticKarmaAward.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStaticKarmaAward.Location = new System.Drawing.Point(4, 70);
            this.lblStaticKarmaAward.Name = "lblStaticKarmaAward";
            this.lblStaticKarmaAward.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStaticKarmaAward.Size = new System.Drawing.Size(48, 18);
            this.lblStaticKarmaAward.TabIndex = 11;
            this.lblStaticKarmaAward.Text = "AWARD";
            this.lblStaticKarmaAward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStaticKarmaComment
            // 
            this.lblStaticKarmaComment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStaticKarmaComment.AutoSize = true;
            this.lblStaticKarmaComment.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStaticKarmaComment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStaticKarmaComment.Location = new System.Drawing.Point(4, 52);
            this.lblStaticKarmaComment.Name = "lblStaticKarmaComment";
            this.lblStaticKarmaComment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStaticKarmaComment.Size = new System.Drawing.Size(64, 18);
            this.lblStaticKarmaComment.TabIndex = 10;
            this.lblStaticKarmaComment.Text = "COMMENT";
            this.lblStaticKarmaComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKarmaComment
            // 
            this.lblKarmaComment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaComment.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKarmaComment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblKarmaComment.Location = new System.Drawing.Point(71, 52);
            this.lblKarmaComment.Name = "lblKarmaComment";
            this.lblKarmaComment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKarmaComment.Size = new System.Drawing.Size(104, 18);
            this.lblKarmaComment.TabIndex = 7;
            this.lblKarmaComment.Text = "COMMENT";
            this.lblKarmaComment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKarmaLink
            // 
            this.lblKarmaLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaLink.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKarmaLink.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblKarmaLink.Location = new System.Drawing.Point(68, 34);
            this.lblKarmaLink.Name = "lblKarmaLink";
            this.lblKarmaLink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKarmaLink.Size = new System.Drawing.Size(107, 18);
            this.lblKarmaLink.TabIndex = 6;
            this.lblKarmaLink.Text = "LINK";
            this.lblKarmaLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStaticKarmaLink
            // 
            this.lblStaticKarmaLink.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStaticKarmaLink.AutoSize = true;
            this.lblStaticKarmaLink.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStaticKarmaLink.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStaticKarmaLink.Location = new System.Drawing.Point(4, 34);
            this.lblStaticKarmaLink.Name = "lblStaticKarmaLink";
            this.lblStaticKarmaLink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStaticKarmaLink.Size = new System.Drawing.Size(40, 18);
            this.lblStaticKarmaLink.TabIndex = 9;
            this.lblStaticKarmaLink.Text = "LINK";
            this.lblStaticKarmaLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStaticKarmaTotal
            // 
            this.lblStaticKarmaTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStaticKarmaTotal.AutoSize = true;
            this.lblStaticKarmaTotal.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStaticKarmaTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStaticKarmaTotal.Location = new System.Drawing.Point(4, 16);
            this.lblStaticKarmaTotal.Name = "lblStaticKarmaTotal";
            this.lblStaticKarmaTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStaticKarmaTotal.Size = new System.Drawing.Size(48, 18);
            this.lblStaticKarmaTotal.TabIndex = 8;
            this.lblStaticKarmaTotal.Text = "TOTAL";
            this.lblStaticKarmaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCreatedOn);
            this.groupBox3.Controls.Add(this.lblStaticCreatedOn);
            this.groupBox3.Location = new System.Drawing.Point(123, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 151);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "more info";
            // 
            // lblCreatedOn
            // 
            this.lblCreatedOn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCreatedOn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCreatedOn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCreatedOn.Location = new System.Drawing.Point(98, 21);
            this.lblCreatedOn.Name = "lblCreatedOn";
            this.lblCreatedOn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCreatedOn.Size = new System.Drawing.Size(151, 18);
            this.lblCreatedOn.TabIndex = 14;
            this.lblCreatedOn.Text = "00.00.1970 00:00";
            this.lblCreatedOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStaticCreatedOn
            // 
            this.lblStaticCreatedOn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStaticCreatedOn.AutoSize = true;
            this.lblStaticCreatedOn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStaticCreatedOn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStaticCreatedOn.Location = new System.Drawing.Point(4, 21);
            this.lblStaticCreatedOn.Name = "lblStaticCreatedOn";
            this.lblStaticCreatedOn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStaticCreatedOn.Size = new System.Drawing.Size(88, 18);
            this.lblStaticCreatedOn.TabIndex = 13;
            this.lblStaticCreatedOn.Text = "CREATED ON";
            this.lblStaticCreatedOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lblDescription.Location = new System.Drawing.Point(230, 59);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(332, 47);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "DESCRIPTION";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labanmetag);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labanmetag;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.Label lblPremium;
        private System.Windows.Forms.Label lblKarmaTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblKarmaLink;
        private System.Windows.Forms.Label lblKarmaComment;
        private System.Windows.Forms.Label lblStaticKarmaComment;
        private System.Windows.Forms.Label lblStaticKarmaLink;
        private System.Windows.Forms.Label lblStaticKarmaTotal;
        private System.Windows.Forms.Label lblKarmaAward;
        private System.Windows.Forms.Label lblStaticKarmaAward;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCreatedOn;
        private System.Windows.Forms.Label lblStaticCreatedOn;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblNsfw;
    }
}