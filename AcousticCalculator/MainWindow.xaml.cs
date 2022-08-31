using AcousticCalculator.Entities;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AcousticCalculator
{

    public partial class MainWindow : Window
    {
        Calculator Calculator { get; set; }
        public MainWindow()
        {
            Calculator = new Calculator();
            InitializeComponent();
            GetData();

        }
        private void GetData()
        {
            DataBaseContext dbContext = new DataBaseContext();
            var listOfGlasses = dbContext.PakSzyb.Where(x => x.Hide == false && x.DzwRwigu != 0).OrderBy(x => x.Lp).ToList();
            var listOfVentairs = dbContext.Napowiet.ToList();
            cmbGlass.ItemsSource = listOfGlasses;
            cmbGlass.DisplayMemberPath = "NrArt";
            cmbGlass.SelectedValuePath = "NrArt";
            cmbAir.ItemsSource = listOfVentairs;
            cmbAir.DisplayMemberPath = "NrArt";
            cmbAir.SelectedValuePath = "NrArt";
        }
        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = Calculator.Calculate();
                txtScoreCorrection.Text = result.Correction.ToString();
                txtScoreRw.Text = result.Rw.ToString();
                txtScoreRa2.Text = result.Ra2.ToString();
                lblInfo.Content = result.Info;
            }
            catch (Exception ex)
            {
                lblInfo.Content = ex.Message;
            }
            
        }

        private void cmbAir_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedVentAir = (Napowiet)cmbAir.SelectedItem;
            Calculator.VentAir = selectedVentAir;
            txtAirRw.Text = selectedVentAir.DnEW.ToString();
        }

        private void cmbGlass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedGlass = (PakSzyb)cmbGlass.SelectedItem;
            Calculator.Glass = selectedGlass;
            txtGlassRw.Text = selectedGlass.DzwRwigu.ToString();
            txtGlassC.Text = selectedGlass.DzwC.ToString();
            txtGlassCtr.Text = selectedGlass.DzwCtr.ToString();
        }

        private void txtHeight_TextChanged(object sender, TextChangedEventArgs e)
        {

            CalculateArea();

        }
        private void txtWidth_TextChanged(object sender, TextChangedEventArgs e)
        {

            CalculateArea();

        }
        private void CalculateArea()
        {
            if (txtHeight.Text != "" && txtWidth.Text != "")
            {
                try
                {
                    var width = Int32.Parse(txtWidth.Text);
                    var height = Int32.Parse(txtHeight.Text);
                    double area = width * height;
                    txtArea.Text = Math.Round((area / 1000 / 1000),2).ToString();
                    CalculatedWindow calculatedWindow = new CalculatedWindow(width, height);
                    Calculator.Window = calculatedWindow;
                }
                catch (Exception)
                {
                    txtArea.Text = "wpisz liczby";
                }

            }
        }
    }
}
