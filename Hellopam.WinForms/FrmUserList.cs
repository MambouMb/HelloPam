using HelloPam.BLL;
using HelloPam.BO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Hellopam.WinForms
{
    public partial class FrmUserList : Form
    {
        private readonly UserBLO userBLO;
        public FrmUserList()
        {
            InitializeComponent();
            userBLO = new UserBLO();
            dataGridView1.AutoGenerateColumns = false;
        }
        private void LoadData(IEnumerable<User> users)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users;
            lblItemsCount.Text = $"{dataGridView1.Rows.Count} item(s)";
            dataGridView1.ClearSelection();
        }

        private void FrmUserList_Load(object sender, System.EventArgs e)
        {
            txtSearch.Clear();
            LoadData(userBLO.FindUser());
        }

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            User user = new User { Username = txtSearch.Text};
            var users1 = userBLO.FindUser(user);

            user  = new User { Fullname = txtSearch.Text };
            var users2 = userBLO.FindUser(user);

            LoadData(users1.Union(users2).ToList());
        }

        private void refreshToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            txtSearch.Clear();
        }

        private void newUserToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            FrmUserEdit form = new FrmUserEdit();
            form.Show();
        }
    }
}
