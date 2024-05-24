using kolesnichenko_11.AddModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kolesnichenko_11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppConnect.model1db = new Task_11Entities(); //подключение базы данных
            AppFrame.FrameMain = FrmMain; //подключение фрейма с началом работы программы

            Client.ItemsSource = AddModel.Task_11Entities.GetContext().Client.ToList();
        }
    }
}
