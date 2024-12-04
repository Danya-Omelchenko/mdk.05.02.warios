using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wariors_Omelchenko.Classes;

namespace Wariors_Omelchenko
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Atack warior = new Atack(100, 0.75);
        public HavyAtack superWarior = new HavyAtack(100, 0.5);
        public MainWindow()
        {
            InitializeComponent();
        }
        public void updateData()
        {
            enemyHealth.Content = "Жизненые показатели: " + Convert.ToString(superWarior.Health);
            playerHealth.Content = "Жизненые показатели: " + Convert.ToString(warior.Health);
        }
        private void Attack(object sender, MouseButtonEventArgs e)
        {
            warior.HaveDamage(10);
            updateData();
        }
        private void AttackHavy(object sender, MouseButtonEventArgs e)
        {
            superWarior.HaveDamage(10);
            updateData();
        }
    }
}
