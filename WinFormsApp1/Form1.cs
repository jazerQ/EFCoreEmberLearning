using EFCoreEmber;
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
        private async Task Load_Players() {
            var players = await _playerRepository.GetAll();
            guna2DataGridView1.DataSource = players.ToList();
        }
            

    }
}
