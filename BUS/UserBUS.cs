using project_winform.CTO;
using project_winform.DAL;
using project_winform.src.config;
using project_winform.src.constants;
using project_winform.src.helpers;
using System;
using System.Collections.Generic;
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

        /* HANDLE LOGIN */
        public static bool HandleUserLogin(string username, string password)
        {
            User user = UserDAL.GetUserWithId(username);
            if (user != null)
                if (user.Password == password)
                    return true;
            return false;
        }

        /* RENDER LIST FROM BASE */
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

        /* ADD - UPDATE - DELETE */
        public static void HandleAddUser(ListView lvwMain, User user)
        {
            bool userResult = UserDAL.CreateUser(user);
            if (userResult)
            {
                ListViewItem item = UserModelToListViewItem(user);
                lvwMainState.Items.Insert(0, item.Clone() as ListViewItem);
                lvwMain.Items.Insert(0, item.Clone() as ListViewItem);

                // Select New Item When Create
                lvwMain.Items[0].Selected = true;
                lvwMain.Select();
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
            else MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionNotSelectListView, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void HandleUpdateUsers(ListView lvwMain, User user)
        {
            if (lvwMain.SelectedItems.Count > 0)
            {
                bool userResult = UserDAL.UpdateUserFromAdminWithId(user);
                if (userResult)
                {
                    foreach (ListViewItem item in lvwMainState.Items)
                        if (item.SubItems[0].Text == user.IdUser)
                        {
                            ListViewItem itemUser = UserModelToListViewItem(user);
                            for (int i = 0; i < item.SubItems.Count; i++)
                                item.SubItems[i].Text = i < itemUser.SubItems.Count ?
                                    itemUser.SubItems[i].Text ?? null : string.Empty;
                        }
                    RenderListViewDataUsersWithPermission(lvwMain);
                }
            }
            else MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionNotSelectListView, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /* SEACRH LISTVIEW */
        public static void HandleSearchOnListView(ListView lvwMain, string search, int index)
        {
            if (index < 0) return;

            ListViewItem itemClone;
            if (search == string.Empty)
            {
                RenderListViewDataUsersWithPermission(lvwMain);
                return;
            }

            ListView lvwTemporary = new ListView();
            foreach (ListViewItem item in LvwMainState.Items)
            {
                itemClone = item.Clone() as ListViewItem;
                string itemTextSearch = item.SubItems[index].Text.Trim().ToLower();
                string searchText = search.Trim().ToLower();
                if (itemTextSearch.IndexOf(searchText) != -1 
                    && item.SubItems[0].Text.Substring(0, 2) == TypeSelectUser)
                    lvwTemporary.Items.Add(itemClone);
            }

            lvwMain.Items.Clear();
            foreach (ListViewItem item in lvwTemporary.Items)
            {
                itemClone = item.Clone() as ListViewItem;
                lvwMain.Items.Add(itemClone);
            }
        }

        /* Import Data */
        public static void HandleImportDataExcelToListView(ListView lvwMain)
        {
            ListView lvwExcel = Excel.ImportDataExcelToListView();
            foreach (ListViewItem item in lvwExcel.Items)
            {
                string id_user = RandomCodeNum(TypeSelectUser).ToString();
                id_user = TypeSelectUser + id_user;

                string password = "123456";
                string name = item.SubItems[1].Text;
                DateTime birthday = DateTime.Parse(item.SubItems[2].Text);
                Class classModal = ClassDAL.GetClassWithName(item.SubItems[5].Text);
                User user = new User(id_user, password, name, birthday, classModal);
                HandleAddUser(lvwMain, user);
            }
        }
    }
}
