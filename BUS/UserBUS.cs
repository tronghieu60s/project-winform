using project_winform.CTO;
using project_winform.DAL;
using project_winform.src.config;
using project_winform.src.constants;
using project_winform.src.helpers;
using System;
using System.Collections.Generic;
using System.IO;
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

        /* CHANGE PASSWORD */
        public static void HandleChangePassword(string oldPass, string newPass, string reNewPass)
        {
            if (newPass != reNewPass)
            {
                MessageBox.Show(MessageBoxText.PassWordNotMatch, MessageBoxText.CaptionPassWord, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Control.userLogin.Password != Password.HashPassword(oldPass))
            {
                MessageBox.Show(MessageBoxText.PassWordIncorrect, MessageBoxText.CaptionPassWord, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User updateUser = Control.userLogin;
            updateUser.Password = Password.HashPassword(newPass);
            bool result = UserDAL.UpdateUserWithId(updateUser);
            if (result)
            {
                Control.userLogin = updateUser;
                MessageBox.Show(MessageBoxText.ChangePassWordSuccess, MessageBoxText.CaptionPassWord, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* HANDLE LOGIN */
        public static User HandleUserLogin(string username, string password)
        {
            User user = UserDAL.GetUserWithId(username);
            if (user != null)
                if (user.Password == password)
                    return user;
            return null;
        }

        public static void HandleSaveLogin(string username, string password)
        {
            using (StreamWriter sw = new StreamWriter(Config.fileNameConfig))
            {
                sw.WriteLine(Config.configUsername + username);
                sw.WriteLine(Config.configPassword + password);
            }
        }

        public static bool HandleCheckLoginLocalStorage()
        {
            string line = "";
            bool fileValid = File.Exists(Config.fileNameConfig);
            if (!fileValid) return false;

            string username = String.Empty;
            string password = String.Empty;
            using (StreamReader sr = new StreamReader(Config.fileNameConfig))
            {
                if ((line = sr.ReadLine()) == null) return false;
                username = line.StartsWith(Config.configUsername) ?
                    line.Substring(Config.configUsername.Length, line.Length - Config.configUsername.Length) : String.Empty;

                if ((line = sr.ReadLine()) == null) return false;
                password = line.StartsWith(Config.configPassword) ?
                    line.Substring(Config.configPassword.Length, line.Length - Config.configPassword.Length) : String.Empty;
            }

            User user = HandleUserLogin(username, password);
            if (user != null)
            {
                Control.userLogin = user;
                return true;
            }
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

        public static void HandleDeleteUsersWithChecked(ListView lvwMain)
        {
            if (lvwMain.CheckedItems.Count <= 0)
            {
                MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionNotSelectListView, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem itemSelect in lvwMain.CheckedItems)
                DeleteUserWithListViewItem(lvwMain, itemSelect);
        }

        public static void HandleDeleteUserWithId(ListView lvwMain, string id_user)
        {
            foreach (ListViewItem item in lvwMain.Items)
            {
                if (item.SubItems[0].Text == typeSelectUser + id_user)
                {
                    DeleteUserWithListViewItem(lvwMain, item);
                    return;
                }
            }

            MessageBox.Show(MessageBoxText.NotSelectListView, MessageBoxText.CaptionNotSelectListView, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void DeleteUserWithListViewItem(ListView lvwMain, ListViewItem itemSelect)
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
                            item.SubItems[i].Text = i < itemUser.SubItems.Count ?
                                itemUser.SubItems[i].Text ?? null : string.Empty;
                    }
                RenderListViewDataUsersWithPermission(lvwMain);
            }
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
            int count = 0;
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
                count += 1;
            }

            if (count == lvwExcel.Items.Count)
                MessageBox.Show(MessageBoxText.ImportSuccess + count, MessageBoxText.CaptionImportSuccess, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
