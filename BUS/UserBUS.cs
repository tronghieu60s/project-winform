using project_winform.CTO;
using project_winform.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_winform.BUS
{
    class UserBUS
    {
        public static bool HandleUserLogin(string username, string password)
        {
            User user = UserDAL.getDataUserWithId(username);
            if (user != null)
                if (user.Password == password)
                    return true;
            return false;
        }
    
        public static void RenderListViewAllDataUser(ListView listView)
        {
            List<User> users = UserDAL.getAllDataUsers();
            foreach (User user in users)
            {
                ListViewItem item = new ListViewItem(user.IdUser);
                item.SubItems.Add(user.Name);
                item.SubItems.Add(user.Birthday.ToString());
                item.SubItems.Add(user.Course);
                item.SubItems.Add(user.ClassModel.Faculty.Name);
                item.SubItems.Add(user.ClassModel.Name);
                listView.Items.Add(item);
            }
        }
    }
}
