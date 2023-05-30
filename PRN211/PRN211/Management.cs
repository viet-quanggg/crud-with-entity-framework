using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using PRN211.Models;
using PRN211.Repository;

namespace PRN211
{
    public partial class Management : Form
    {
        List<BankAccount> accounts = new List<BankAccount>();
        BankAccountRepo bankContext = new BankAccountRepo();
        AccountTypeRepo accountTypeRepo = new AccountTypeRepo();

        public Management()
        {
            InitializeComponent();
            var listBank = bankContext.getAll();
            dgvStudent.DataSource = new BindingSource() { DataSource = listBank };
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var currAccount = bankContext.getAll().ToList()[dgvStudent.CurrentCell.RowIndex];
            bankContext.remove(currAccount);
            dgvStudent.DataSource = new BindingSource() { DataSource = bankContext.getAll() };
        }

        private void btnNew1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Account ID can not be null!", "Warning", MessageBoxButtons.OK);
                    txtID.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Account Name can not be null!", "Warning", MessageBoxButtons.OK);
                    txtName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtBranchName.Text))
                {
                    MessageBox.Show("Branch Name can not be null!", "Warning", MessageBoxButtons.OK);
                    txtBranchName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(cbbTypeID.Text))
                {
                    MessageBox.Show("Type ID can not be null!", "Warning", MessageBoxButtons.OK);
                    cbbTypeID.Focus();

                    return;
                }

                //input data

                //add data to entity
                BankAccount newAccount = new BankAccount();
                newAccount.AccountId = txtID.Text;
                newAccount.AccountName = txtName.Text;
                newAccount.OpenDate = dtpOpenDate.Value;
                newAccount.BranchName = txtBranchName.Text;
                newAccount.TypeId = cbbTypeID.SelectedItem.ToString();
                bankContext.add(newAccount);
                dgvStudent.DataSource = new BindingSource() { DataSource = bankContext.getAll() };
            }
            catch (Exception ex)
            {

                MessageBox.Show("Added fail!", "Notification", MessageBoxButtons.OK);
            }

        }

        private void dgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var currAccount = bankContext.getAll()[dgvStudent.CurrentCell.RowIndex];
            txtID.Text = currAccount.AccountId.ToString();
            txtName.Text = currAccount.AccountName.ToString();
            dtpOpenDate.Value = currAccount.OpenDate.Value;
            txtBranchName.Text = currAccount.BranchName.ToString();
            cbbTypeID.SelectedItem = currAccount.TypeId.ToString();
            btnUpdate.Enabled = true;
            btnCreate.Enabled = true;


        }

        private void reset()
        {
            txtID.Clear();
            txtName.Clear();
            txtBranchName.Clear();
            cbbTypeID.SelectedIndex = 0;
            loadData();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnCreate.Enabled = false;
            var cbblist = accountTypeRepo.getAll().Select(a => a.TypeId);
            cbbTypeID.Items.Clear();
            cbbTypeID.Items.AddRange(cbblist.ToArray());
        }

        private void searchBranchName(string search = "")
        {
            var list = bankContext.getAll().Where(a => a.BranchName.Contains(search));
            dgvStudent.DataSource = new BindingSource() { DataSource = list };
        }
        private void loadData()
        {
            dgvStudent.DataSource = new BindingSource() { DataSource = bankContext.getAll() };
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var currAccount = bankContext.getAll()[dgvStudent.CurrentRow.Index];

            currAccount.AccountId = txtID.Text;
            currAccount.AccountName = txtName.Text;
            currAccount.OpenDate = dtpOpenDate.Value;
            currAccount.BranchName = txtBranchName.Text;
            currAccount.TypeId = cbbTypeID.SelectedItem.ToString();
            bankContext.update(currAccount);
            dgvStudent.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchBranchName(txtSearch.Text);

        }
    }
}
