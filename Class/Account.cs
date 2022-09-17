using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creating_Account_Page.Class
{
    public class Account
    {
        
        string _userName;
        public string userName {

            get { return _userName;}

            set 
            { 
            if (value.Length > 3)
                {
                    _userName = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Kullınıcı adınız 4 karakter veya 4'ten fazla olmalıdır.");
                    Application.Restart();
                }
            
            }
        
        }
        public string passWord { get; set; }
    }
}
