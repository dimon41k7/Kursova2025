using Kursova.Models;

namespace Kursova
{
    public partial class MainForm : Form
    {
        private ListGeoObjects listGeoObjects = new ListGeoObjects();
        private Favorites listFavoritesObjects = new Favorites();
        private int lastClickedIndexAll = -1;
        private int lastClickedIndexFavorites = -1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxGeoObjects.Items.Add("̳���");
            listBoxGeoObjects.Items.Add("�����");
            listBoxGeoObjects.Items.Add("�����");
            listBoxGeoObjects.Items.Add("���������");
            comboBoxArea.Items.Add("ʳ�������");
            comboBoxArea.Items.Add("���");
            comboBoxArea.SelectedIndex = 0;
        }

        private void ������_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxGeoObjects.SelectedItem;
            if (selectedItem == "̳���")
            {
                AddCityForm addForm = new AddCityForm(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, this);
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "�����")
            {
                AddRegionForm addForm = new AddRegionForm(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, this);
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "�����")
            {
                AddCountryForm addForm = new AddCountryForm(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, this);
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "���������")
            {
                AddContinentForm addForm = new AddContinentForm(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, this);
                this.Hide();
                addForm.Show();
            }
            else
            {
                MessageBox.Show("���� �� ������ ������ ����, �����, ����� �� ��������� �� ������, �� ��� ������� ������ � ������, �� �� ������ ������!");
            }
        }

        //public void RefreshList()
        //{
        //    listBoxGeoObjectsAll.Items.Clear();
        //    foreach (var item in listGeoObjects.ShowGeoObjects())
        //    {
        //        listBoxGeoObjectsAll.Items.Add(item.ToString());
        //    }

        //    listBoxFavorites.Items.Clear();
        //    foreach (var item in listFavoritesObjects.ShowFavorites())
        //    {
        //        listBoxFavorites.Items.Add(item.ToString());
        //    }
        //}

        //public void RefreshListInMile()
        //{
        //    listBoxGeoObjectsAll.Items.Clear();
        //    foreach (var item in listGeoObjects.ShowGeoObjects())
        //    {
        //        listBoxGeoObjectsAll.Items.Add(item.ToStringInMile());
        //    }

        //    listBoxFavorites.Items.Clear();
        //    foreach (var item in listFavoritesObjects.ShowFavorites())
        //    {
        //        listBoxFavorites.Items.Add(item.ToStringInMile());
        //    }
        //}

        private void buttonFavorites_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxGeoObjectsAll.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("������, ���� ������� �� ������ ������ � ������!");
                return;
            }
            string selected = comboBoxArea.SelectedItem.ToString();
            string line = selectedItem.ToString();

            listFavoritesObjects.AddToFavorites(line, selected);

            if (selected == "���")
            {
                listFavoritesObjects.RefreshListInMile(listBoxFavorites);
            }
            else if (selected == "ʳ�������")
            {
                listFavoritesObjects.RefreshList(listBoxFavorites);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            listGeoObjects.SaveData("objects.txt");
            listFavoritesObjects.SaveData("favoritesobjects.txt");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            listGeoObjects.LoadData();
            listFavoritesObjects.LoadData();
            listGeoObjects.RefreshList(listBoxGeoObjectsAll);
            listFavoritesObjects.RefreshList(listBoxFavorites);
        }

        private void buttonShowObject_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxGeoObjectsAll.SelectedItem;
            if (listBoxGeoObjectsAll.SelectedItem == null && listBoxFavorites.SelectedItem == null)
            {
                MessageBox.Show("������, ���� ������� �� ������ �������� �� ���");
                return;
            }
            else if (listBoxGeoObjectsAll.SelectedItem != null && listBoxFavorites.SelectedItem == null)
            {
                selectedItem = listBoxGeoObjectsAll.SelectedItem;
            }
            else if (listBoxGeoObjectsAll.SelectedItem == null && listBoxFavorites.SelectedItem != null)
            {
                selectedItem = listBoxFavorites.SelectedItem;
            }
            else if (listBoxGeoObjectsAll.SelectedItem != null && listBoxFavorites.SelectedItem != null)
            {
                MessageBox.Show("������ ���� ���� �������, ���� �� ������ �������� �� ���");
                return;
            }
            string[] arrword = selectedItem.ToString().Split('|');
            GeoObject.ShowInMap(arrword);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxGeoObjectsAll.SelectedItem;
            if (listBoxGeoObjectsAll.SelectedItem == null && listBoxFavorites.SelectedItem == null)
            {
                MessageBox.Show("������, ���� ������� �� ������ ��������");
                return;
            }
            else if (listBoxGeoObjectsAll.SelectedItem != null && listBoxFavorites.SelectedItem == null)
            {
                var result = MessageBox.Show("�� ����� ������ ��������?", "", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        listGeoObjects.RemoveGeoObject(listBoxGeoObjectsAll.SelectedIndex);
                        string selected = comboBoxArea.SelectedItem.ToString();

                        if (selected == "���")
                        {
                            listGeoObjects.RefreshListInMile(listBoxGeoObjectsAll);
                        }
                        else if (selected == "ʳ�������")
                        {
                            listGeoObjects.RefreshList(listBoxGeoObjectsAll);
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else if (listBoxGeoObjectsAll.SelectedItem == null && listBoxFavorites.SelectedItem != null)
            {
                var result = MessageBox.Show("�� ����� ������ ��������?", "", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        listFavoritesObjects.RemoveFavorite(listBoxFavorites.SelectedIndex);
                        string selected = comboBoxArea.SelectedItem.ToString();

                        if (selected == "���")
                        {
                            listFavoritesObjects.RefreshListInMile(listBoxFavorites);
                        }
                        else if (selected == "ʳ�������")
                        {
                            listFavoritesObjects.RefreshList(listBoxFavorites);
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else if (listBoxGeoObjectsAll.SelectedItem != null && listBoxFavorites.SelectedItem != null)
            {
                MessageBox.Show("������ ���� ���� �������, ���� �� ������ ��������");
                return;
            }
        }

        private void listBoxGeoObjectsAll_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listBoxGeoObjectsAll.IndexFromPoint(e.Location);

            if (index == -1) return;

            if (index == listBoxGeoObjectsAll.SelectedIndex && index == lastClickedIndexAll)
            {
                listBoxGeoObjectsAll.ClearSelected();
                lastClickedIndexAll = -1;
            }
            else
            {
                listBoxGeoObjectsAll.SelectedIndex = index;
                lastClickedIndexAll = index;
            }
        }

        private void listBoxFavorites_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listBoxFavorites.IndexFromPoint(e.Location);

            if (index == -1) return;

            if (index == listBoxFavorites.SelectedIndex && index == lastClickedIndexFavorites)
            {
                listBoxFavorites.ClearSelected();
                lastClickedIndexFavorites = -1;
            }
            else
            {
                listBoxFavorites.SelectedIndex = index;
                lastClickedIndexFavorites = index;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("�� ������ �������� ���?", "", MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    listGeoObjects.SaveData("objects.txt");
                    listFavoritesObjects.SaveData("favoritesobjects.txt");
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void comboBoxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBoxArea.SelectedItem.ToString();

            if (selected == "���")
            {
                listGeoObjects.RefreshListInMile(listBoxGeoObjectsAll);
                listFavoritesObjects.RefreshListInMile(listBoxFavorites);
            }
            else if (selected == "ʳ�������")
            {
                listGeoObjects.RefreshList(listBoxGeoObjectsAll);
                listFavoritesObjects.RefreshList(listBoxFavorites);
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {

        }

        public string SelectedMorKm
        {
            get => comboBoxArea.SelectedItem?.ToString();
        }
    }
}
