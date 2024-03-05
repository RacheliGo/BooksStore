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

namespace BooksStoreGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BooksStoreBL.BookStoreBL booksStoreBL; 
        public MainWindow()
        {
            booksStoreBL = new BooksStoreBL.BookStoreBL();
            
            InitializeComponent();
            var res = booksStoreBL.GetAllBooks();
            BooksDataGrid.ItemsSource = res;

            var reselt = booksStoreBL.HighCostBooks();
            highCost.ItemsSource = reselt;

            var reseltC = booksStoreBL.CostOfComics().Select(l => l.Price);
            CostComics.ItemsSource = reseltC;

            var reseltB = booksStoreBL.NameBookForGirl().Select(l =>l.Name);
            BookForGirl.ItemsSource = reseltB;
        }
    }
}
