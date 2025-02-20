using EFCoreEmber;
using EFCoreEmber.Model;
using EFCoreEmber.Repositories;
using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private static IPlayer _playerRepository;
        public Form1()
        {
            InitializeComponent();
            var serviceProvider = GameShopDataFactory.DataFactoryCreate();
            _playerRepository = serviceProvider.GetService<IPlayer>() ?? throw new Exception("Cant take entity from DI");
            
        }
        private void Load_Players()
        {
            var players = _playerRepository.GetAll();
            guna2DataGridView1.DataSource = players.ToList();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var addressId = Guid.NewGuid();
            var player = new Player()
            {
                Id = Guid.NewGuid(),
                Email = TextBoxEmail.Text,
                Username = TextBoxUsername.Text,
                Name = TextBoxName.Text,
                Address = new Address() { Street = "Baker str.", City = "London", Region = "England", AddressId = addressId },
                AddressId = addressId
            };
            _playerRepository.Add(player);
            Load_Players();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Players();
        }
    }
}
