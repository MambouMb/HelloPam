using HelloPam.BLL;
using HelloPam.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Hellopam.WinForms
{
    public partial class FrmUserEdit : Form
    {
        private readonly Action<IEnumerable<User>> callBack;
        private readonly User user;
        private readonly UserBLO userBLO;
        public FrmUserEdit()
        {
            InitializeComponent();
            userBLO = new UserBLO();
            InitForm();
        }

        public FrmUserEdit(Action<IEnumerable<User>> callBack) : this()
        {
            this.callBack = callBack;
        }

        public FrmUserEdit(Action<IEnumerable<User>> callBack, User user) : this(callBack)
        {
            this.user = user;
            TxtFullname.Text = user.Fullname;
            TxtPassword.Text = user.Password;
            TxtUsername.Text = user.Username;
            CbProfile.SelectedIndex = (int)user.Profile;
            chkStatut.Checked = user.Statut ?? false;
            if (user.Picture != null)
                PbPicture.Image = Image.FromStream(new MemoryStream(user.Picture));
        }

        private void InitForm()
        {
            TxtFullname.Clear();
            TxtPassword.Clear();
            TxtPassword.UseSystemPasswordChar = true;
            LIShowHidePassword.Text = "Show";
            TxtUsername.Clear();

            CbProfile.DataSource = Enum.GetNames(typeof(User.ProfileOptions));
            CbProfile.SelectedIndex = -1;
            chkStatut.Checked = true;
            chkStatut.Text = "Enable";
            PbPicture.Image = null;
            PbPicture.ImageLocation = null;
            TxtFullname.Focus();
        }

        private void ValidateForm()
        {
            string error = string.Empty;
            if (string.IsNullOrWhiteSpace(TxtFullname.Text))
                error += "Full name cannot be empty !\n";
            if (string.IsNullOrWhiteSpace(TxtUsername.Text))
                error += "Username cannot be empty !\n";
            if (string.IsNullOrWhiteSpace(TxtPassword.Text))
                error += "Password cannot be empty !\n";
            if (CbProfile.SelectedIndex < 0)
                error += "You must choose a profile !\n";

            if (!string.IsNullOrEmpty(error))
                throw new InvalidExpressionException(error);
        }

        private void LIShowHidePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LIShowHidePassword.Text = LIShowHidePassword.Text == "Show" ? "Hide" : "Show";
            TxtPassword.UseSystemPasswordChar = !TxtPassword.UseSystemPasswordChar;
        }

        private void chkStatut_CheckedChanged(object sender, EventArgs e)
        {
            chkStatut.Text = chkStatut.Checked ? "Enable" : "Disable";
        }

        private void PbPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.jpg;*.jpeg;*.png;*.gif;*.tiff";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PbPicture.ImageLocation = openFileDialog.FileName;
            }
        }

        private void LiRemovePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PbPicture.ImageLocation = null;
            PbPicture.Image = null;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateForm();
                byte[] picture = this.user?.Picture;
                if (!string.IsNullOrEmpty(PbPicture.ImageLocation) &&
                    File.Exists(PbPicture.ImageLocation))
                {
                    picture = File.ReadAllBytes(PbPicture.ImageLocation);
                }

                User newUser = new User
                (
                    this.user?.Id ?? 0,
                    TxtUsername.Text,
                    TxtPassword.Text,
                    TxtFullname.Text,
                    (User.ProfileOptions)CbProfile.SelectedIndex,
                    chkStatut.Checked,
                    picture,
                    DateTime.Now
                 );

                if (this.user == null)
                {
                    userBLO.CreateUser(newUser);
                }
                else
                {
                    userBLO.EditUser(newUser);
                }

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (this.callBack != null)
                    callBack(userBLO.FindUser());

                if (this.user != null)
                    this.Close();

                InitForm();
            }
            catch (InvalidExpressionException ex)
            {
                MessageBox.Show
                (
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    "An error occured. please try again later !",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Console.Error.WriteLine($"---> {ex.Message}");
            }
        }
    }
}
