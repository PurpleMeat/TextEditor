using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
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

namespace TextEditor
{
    /// <summary>
    /// Логика взаимодействия для AllFiles.xaml
    /// </summary>
    public partial class AllFiles : Page
    {
        public ObservableCollection<AllFilesInformation> fileInfo { get; set; }
        public AllFiles()
        {
            InitializeComponent();
            //forech для списка файлов в папке. если папка то будет устанавливать свою фотку
            fileInfo = new ObservableCollection<AllFilesInformation>
            {
            new AllFilesInformation {Id=1, ImagePath="Resour/papka.png", Name="iPhone 6S", Date="Apple" },
            new AllFilesInformation {Id=2, ImagePath="Resour/listik.png", Name="Lumia 950", Date="Microsoft" },
            new AllFilesInformation {Id=3, ImagePath="Resour/listik.png", Name="Nexus 5X", Date="Google" },
            new AllFilesInformation {Id=4, ImagePath="Resour/listik.png", Name="Galaxy S6", Date="Samsung"}
        };
            filesList.ItemsSource = fileInfo;
        }

        
            
    }
}
