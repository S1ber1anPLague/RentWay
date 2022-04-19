using Lab_4.DataBase;
using Lab_4.DataBase.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class CarBrands : Form
    {
        public CarBrands()
        {
            InitializeComponent();
            carBrandsComboBox.DisplayMember = "Brand";
            UpdateView();
        }

        private void UpdateView()
        {
            using (var context = new ApplicationDBContext())
            {
                carBrandsComboBox.DataSource = context.CarBrands.ToArray();
            }
        }

        private void CarBrandsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var carBrand = carBrandsComboBox.SelectedItem as CarBrand;
            markTextBox.Text = carBrand?.Brand ?? "";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(markTextBox.Text))
            {
                MessageBox.Show("Ошибка! Введите название марки");
                return;
            }

            using (var context = new ApplicationDBContext())
            {
                if (context.ContainsBrand(markTextBox.Text))
                {
                    MessageBox.Show("Такой бренд уже зарегистрирован в БД");
                    return;
                }

                context.CarBrands.Add(new CarBrand
                {
                    Brand = markTextBox.Text
                });
                context.SaveChanges();
                UpdateView();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (!(carBrandsComboBox.SelectedItem is CarBrand carBrand))
            {
                MessageBox.Show("Ошибка! Выберите марку.");
                return;
            }
            if (string.IsNullOrWhiteSpace(markTextBox.Text))
            {
                MessageBox.Show("Ошибка! Введите название марки");
                return;
            }

            using (var context = new ApplicationDBContext())
            {
                var entity = context.CarBrands.Find(carBrand.CarBrandID);
                entity.Brand = markTextBox.Text;

                context.SaveChanges();
                UpdateView();
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (!(carBrandsComboBox.SelectedItem is CarBrand carBrand))
            {
                MessageBox.Show("Ошибка! Выберите марку.");
                return;
            }

            var isDelConfirmed = MessageBox.Show("Вы действительно хотите удалить объект?",
                "Подтверждающий диалог", MessageBoxButtons.OKCancel) == DialogResult.OK;
            if (isDelConfirmed)
            {
                using (var context = new ApplicationDBContext())
                {
                    var entity = context.CarBrands.Find(carBrand.CarBrandID);
                    context.CarBrands.Remove(entity);
                    context.SaveChanges();
                    UpdateView();
                }
            }
        }

        private void CarBrands_Load(object sender, EventArgs e)
        {

        }
    }
}
