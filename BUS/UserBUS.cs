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
        private static ListView lvwMainState = new ListView();

        public static bool HandleUserLogin(string username, string password)
        {
            User user = UserDAL.getUserWithId(username);
            if (user != null)
                if (user.Password == password)
                    return true;
            return false;
        }
    
        public static void RenderListViewAllDataUser()
        {
            List<User> users = UserDAL.getAllUsers();
            foreach (User user in users)
            {
                ListViewItem item = new ListViewItem(user.IdUser);
                item.SubItems.Add(user.Name);
                item.SubItems.Add(user.Birthday.ToString("dd/MM/yyyy"));
                item.SubItems.Add(user.Course);
                item.SubItems.Add(user.ClassModel.Faculty.Name);
                item.SubItems.Add(user.ClassModel.Name);
                lvwMainState.Items.Add(item);
            }
        }

        public static void ListViewRenderWithPermission(ListView lvwMain, string permission)
        {
            lvwMain.Items.Clear();
            ListViewItem itemClone;
            foreach (ListViewItem item in lvwMainState.Items)
            {
                itemClone = item.Clone() as ListViewItem;
                string id_user = itemClone.SubItems[0].Text;
                if (id_user.Substring(0, 2) == permission)
                    lvwMain.Items.Add(itemClone);
            }
        }
    }
}
