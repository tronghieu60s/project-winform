using project_winform.CTO;
using project_winform.DAL;
using project_winform.src.config;
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
        private static string typeSelectUser = Config.typeAdmin;

        public static ListView LvwMainState { get => lvwMainState; set => lvwMainState = value; }
        public static string TypeSelectUser { get => typeSelectUser; set => typeSelectUser = value; }

        public UserBUS()
        {
            List<User> users = UserDAL.GetUsers();
            foreach (User user in users)
                lvwMainState.Items.Add(UserModelToListViewItem(user));
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

        public static ListViewItem UserModelToListViewItem(User user)
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
            User user = UserDAL.GetUserWithId(username);
            if (user != null)
                if (user.Password == password)
                    return true;
            return false;
        }

        public static void RenderListViewDataUsersWithPermission(ListView lvwMain)
        {
            lvwMain.Items.Clear();
            ListViewItem itemClone;
            foreach (ListViewItem item in lvwMainState.Items)
            {
                itemClone = item.Clone() as ListViewItem;
                string id_user = itemClone.SubItems[0].Text;
                if (id_user.Substring(0, 2) == TypeSelectUser)
                    lvwMain.Items.Add(itemClone);
            }
        }

        public static void HandleAddUser(ListView lvwMain, User user)
        {
            bool userResult = UserDAL.AddUser(user);
            if (userResult)
            {
                lvwMainState.Items.Add(UserModelToListViewItem(user));
                RenderListViewDataUsersWithPermission(lvwMain);
            }
        }

        public static void HandleDeleteUsers(ListView lvwMain)
        {
            if (lvwMain.SelectedItems.Count > 0)
            {
                foreach (ListViewItem itemSelect in lvwMain.SelectedItems)
                {
                    string id_user = itemSelect.SubItems[0].Text;
                    foreach (ListViewItem itemMainState in LvwMainState.Items)
                        if (itemMainState.SubItems[0].Text == id_user)
                        {
                            bool result = UserDAL.DeleteUserWithId(id_user);
                            if (result)
                            {
                                LvwMainState.Items.Remove(itemMainState);
                                RenderListViewDataUsersWithPermission(lvwMain);
                            }
                        }
                }
            }
        }

        public static void HandleUpdateUsers(ListView lvwMain, User user)
        {
            bool userResult = UserDAL.UpdateUserWithId(user);
            if (userResult)
            {
                foreach (ListViewItem item in lvwMainState.Items)
                    if (item.SubItems[0].Text == user.IdUser)
                    {
                        ListViewItem itemUser = UserModelToListViewItem(user);
                        for (int i = 0; i < item.SubItems.Count; i++)
                            item.SubItems[i] = i < itemUser.SubItems.Count ? itemUser.SubItems[i] ?? null : null;
                    }
                RenderListViewDataUsersWithPermission(lvwMain);
            }
        }
    }
}
