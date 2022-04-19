using Lab_4.DataBase;
using Lab_4.DataBase.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class CarBodyTypes : Form
    {
        public CarBodyTypes()
        {
            InitializeComponent(); 
            // указываем свойство для отображения в выпадающем списке
            carBodyTypesComboBox.DisplayMember = "Type";
            UpdateView();
        }

        // метод для обновления пользовательского интерфейса
        private void UpdateView()
        {
            using (var context = new ApplicationDBContext())
            {
                carBodyTypesComboBox.DataSource = context.BodyTypes.ToArray();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bodyTypeTextBox.Text))
            {
                MessageBox.Show("Ошибка! Введите название типа");
                return;
            }

            using (var context = new ApplicationDBContext())
            {
                context.BodyTypes.Add(new BodyType
                {
                    Type = bodyTypeTextBox.Text
                });
                context.SaveChanges();
                UpdateView();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            // валидация данных
            if (!(carBodyTypesComboBox.SelectedItem is BodyType bodyType))
            {
                MessageBox.Show("Ошибка! Выберите тип.");
                return;
            }
            if (string.IsNullOrWhiteSpace(bodyTypeTextBox.Text))
            {
                MessageBox.Show("Ошибка! Введите название типа");
                return;
            }

            using (var context = new ApplicationDBContext())
            {
                var entity = context.BodyTypes.Find(bodyType.BodyTypeID);
                entity.Type = bodyTypeTextBox.Text;

                context.SaveChanges();
                UpdateView();
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            // валидация данных
            if (!(carBodyTypesComboBox.SelectedItem is BodyType bodyType))
            {
                MessageBox.Show("Ошибка! Выберите тип.");
                return;
            }

            // вызов подтверждающего диалога
            var isDelConfirmed = MessageBox.Show("Вы действительно хотите удалить объект?",
                "Подтверждающий диалог", MessageBoxButtons.OKCancel) == DialogResult.OK;
            if (isDelConfirmed)
            {
                using (var context = new ApplicationDBContext())
                {
                    var entity = context.BodyTypes.Find(bodyType.BodyTypeID);
                    context.BodyTypes.Remove(entity);
                    context.SaveChanges();
                    UpdateView();
                }
            }
        }

        private void CarBodyTypesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bodyType = carBodyTypesComboBox.SelectedItem as BodyType;
            bodyTypeTextBox.Text = bodyType?.Type ?? "";
        }
    }
}
