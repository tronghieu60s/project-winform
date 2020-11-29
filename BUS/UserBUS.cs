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

        public static ListView LvwMainState { get => lvwMainState; set => lvwMainState = value; }

        public UserBUS()
        {
            List<User> users = UserDAL.getUsers();
            foreach (User user in users)
                lvwMainState.Items.Add(AddUserToListViewItem(user));
        }

        public static int RandomCodeNum(string permission)
        {
            Random rd = new Random();
            int random = rd.Next(10000, 99999);
            // Recursive Random
            foreach (ListViewItem item in LvwMainState.Items)
                if (item.SubItems[0].Text == $"{permission}{random}".ToString())
                    return RandomCodeNum(permission);
            return random;
        }

        public static ListViewItem AddUserToListViewItem(User user)
        {
            ListViewItem item = new ListViewItem(user.IdUser);
            item.SubItems.Add(user.Name);
            item.SubItems.Add(user.Birthday.ToString("dd/MM/yyyy"));
            if (user.ClassModel != null)
            {
                item.SubItems.Add(user.ClassModel.Course.Name);
                item.SubItems.Add(user.ClassModel.Faculty.Name);
                item.SubItems.Add(user.ClassModel.Name);
            }
            return item;
        }

        public static bool HandleUserLogin(string username, string password)
        {
            User user = UserDAL.getUserWithId(username);
            if (user != null)
                if (user.Password == password)
                    return true;
            return false;
        }

        public static void RenderListViewDataUsersWithPermission(ListView lvwMain, string permission)
        {
            lvwMain.Items.Clear();
            ListViewItem itemClone;
            foreach (ListViewItem item in lvwMainState.Items)
            {
                itemClone = item.Clone() as ListViewItem;
                string id_user = itemClone.SubItems[0].Text;
                Console.WriteLine(item.SubItems[0].Text);
                if (id_user.Substring(0, 2) == permission)
                    lvwMain.Items.Add(itemClone);
            }
        }

        public static void HandleAddUserToListView(ListView lvwMain, User user)
        {
            bool userResult = UserDAL.addUser(user);
            if (userResult)
            {
                ListViewItem item = AddUserToListViewItem(user);
                lvwMain.Items.Add(item.Clone() as ListViewItem);
                lvwMainState.Items.Add(item.Clone() as ListViewItem);
            }
        }
    }
}
