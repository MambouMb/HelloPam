namespace Hellopam.WinForms
{
    partial class FrmUserEdit
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
            this.components = new System.ComponentModel.Container();
            this.TxtFullname = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LIShowHidePassword = new System.Windows.Forms.LinkLabel();
            this.CbProfile = new System.Windows.Forms.ComboBox();
            this.PbPicture = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkStatut = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LiRemovePicture = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtFullname
            // 
            this.TxtFullname.Location = new System.Drawing.Point(12, 47);
            this.TxtFullname.Name = "TxtFullname";
            this.TxtFullname.Size = new System.Drawing.Size(339, 31);
            this.TxtFullname.TabIndex = 0;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(12, 9);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(109, 25);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            // 
            // BtnSave
            // 
            this.BtnSave.ForeColor = System.Drawing.Color.Green;
            this.BtnSave.Location = new System.Drawing.Point(365, 342);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(213, 36);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LIShowHidePassword
            // 
            this.LIShowHidePassword.AutoSize = true;
            this.LIShowHidePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIShowHidePassword.Location = new System.Drawing.Point(310, 194);
            this.LIShowHidePassword.Name = "LIShowHidePassword";
            this.LIShowHidePassword.Size = new System.Drawing.Size(41, 16);
            this.LIShowHidePassword.TabIndex = 4;
            this.LIShowHidePassword.TabStop = true;
            this.LIShowHidePassword.Text = "Show";
            this.LIShowHidePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LIShowHidePassword_LinkClicked);
            // 
            // CbProfile
            // 
            this.CbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProfile.FormattingEnabled = true;
            this.CbProfile.Location = new System.Drawing.Point(12, 299);
            this.CbProfile.Name = "CbProfile";
            this.CbProfile.Size = new System.Drawing.Size(339, 33);
            this.CbProfile.TabIndex = 3;
            // 
            // PbPicture
            // 
            this.PbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbPicture.Location = new System.Drawing.Point(365, 47);
            this.PbPicture.Name = "PbPicture";
            this.PbPicture.Size = new System.Drawing.Size(213, 285);
            this.PbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbPicture.TabIndex = 7;
            this.PbPicture.TabStop = false;
            this.PbPicture.Click += new System.EventHandler(this.PbPicture_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 89);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(110, 25);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Username";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(12, 127);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(339, 31);
            this.TxtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(12, 214);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(339, 31);
            this.TxtPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Profile";
            // 
            // chkStatut
            // 
            this.chkStatut.AutoSize = true;
            this.chkStatut.Checked = true;
            this.chkStatut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatut.Location = new System.Drawing.Point(12, 364);
            this.chkStatut.Name = "chkStatut";
            this.chkStatut.Size = new System.Drawing.Size(98, 29);
            this.chkStatut.TabIndex = 4;
            this.chkStatut.Text = "Enable";
            this.chkStatut.UseVisualStyleBackColor = true;
            this.chkStatut.CheckedChanged += new System.EventHandler(this.chkStatut_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Picture";
            // 
            // LiRemovePicture
            // 
            this.LiRemovePicture.AutoSize = true;
            this.LiRemovePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiRemovePicture.LinkColor = System.Drawing.Color.Red;
            this.LiRemovePicture.Location = new System.Drawing.Point(564, 28);
            this.LiRemovePicture.Name = "LiRemovePicture";
            this.LiRemovePicture.Size = new System.Drawing.Size(14, 16);
            this.LiRemovePicture.TabIndex = 5;
            this.LiRemovePicture.TabStop = true;
            this.LiRemovePicture.Text = "x";
            this.toolTip1.SetToolTip(this.LiRemovePicture, "Remove picture");
            this.LiRemovePicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LiRemovePicture_LinkClicked);
            // 
            // FrmUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 420);
            this.Controls.Add(this.LiRemovePicture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkStatut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.PbPicture);
            this.Controls.Add(this.CbProfile);
            this.Controls.Add(this.LIShowHidePassword);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.TxtFullname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmUserEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserEdit";
            ((System.ComponentModel.ISupportInitialize)(this.PbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtFullname;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.LinkLabel LIShowHidePassword;
        private System.Windows.Forms.ComboBox CbProfile;
        private System.Windows.Forms.PictureBox PbPicture;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkStatut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LiRemovePicture;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}