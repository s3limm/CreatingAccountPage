using Creating_Account_Page.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creating_Account_Page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.userName = txtUserName.Text;
            account.passWord = txtPassword.Text;
            MessageBox.Show($"{account.userName} adlı kullanıcınız başarıyla oluşturulmuştur.");
        }
    }
}
