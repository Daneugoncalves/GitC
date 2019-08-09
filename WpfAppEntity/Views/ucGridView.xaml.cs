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
using WpfAppEntity.Data;

namespace WpfAppEntity.Views
{
    /// <summary>
    /// Interaction logic for ucGridView.xaml
    /// </summary>
    public partial class ucGridView : UserControl
    {
        public ucGridView()
        {
            InitializeComponent();
        }

        public BibliotecaDBContext context = new BibliotecaDBContext();

        private void DtGridView_Loaded(object sender, RoutedEventArgs e)
        {
            dtGridView.ItemsSource = context.Usuarios.ToList<Usuario>();
        }

        private void DtGridView_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            var objectToedit = ((DataGrid)sender).SelectedValue as Usuario;

            
            
            //var objectToRemove = ((DataGrid)sender).SelectedValue as Usuario;
           //context.Usuarios.Remove(objectToRemove);
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            MessageBox.Show("itens salvos com sucesso");
            


        }

        private void DtGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
