using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;

namespace Practice3DPrinterFilterApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<CheckBox> manufacturers = new List<CheckBox>();
        List<CheckBox> layerTechnologies = new List<CheckBox>();
        List<CheckBox> caseTypes = new List<CheckBox>();
        List<CheckBox> materials = new List<CheckBox>();
        List<CheckBox> purposes = new List<CheckBox>();
        List<CheckBox> heights = new List<CheckBox>();
        List<RadioButton> depths = new List<RadioButton>();   
        
        List<Border> filterResults = new List<Border>();

        List<PrinterClass> printers = new List<PrinterClass>();
        List<PrinterClass> filteredPrinters = new List<PrinterClass>();

        DatabaseOperations db;

        public MainWindow()
        {
            InitializeComponent();
            db = new DatabaseOperations();

            UICreation.CreateFilterOptions(db, ref manufacturers, ref layerTechnologies, ref caseTypes, ref materials, ref purposes, ref heights, ref depths);
            SetFilterOptions();
            SetButtonConnections();

            printers = db.Printers;
            filteredPrinters = new List<PrinterClass>(printers);

            UICreation.CreateFilterResults(printers, ref filterResults);
            ShowResults();
        }

        private void ApplyFilters(object sender, MouseButtonEventArgs e)
        {
            List<string> reqManufacturers = SelectFilters(manufacturers);
            List<string> reqTechs = SelectFilters(layerTechnologies);
            List<string> reqTypes = SelectFilters(caseTypes);
            List<string> reqMats = SelectFilters(materials);
            List<string> reqPurposes = SelectFilters(purposes);
            List<string> reqHeights = SelectFilters(heights);
            int reqDepthIndex = depths.Any(d => d.IsChecked == true) ? depths.IndexOf(depths.Where(d => d.IsChecked == true).First()) : -1;
            int depthAvgValue = Convert.ToInt32(depths[1].Content.ToString()!.Substring(1));

            filteredPrinters.Clear();
            filteredPrinters = new List<PrinterClass>(printers);

            filteredPrinters = reqManufacturers.Count == 0 ? filteredPrinters : filteredPrinters.Where(p => reqManufacturers.All(m => p.Manufacturer == m)).ToList();
            filteredPrinters = reqTechs.Count == 0 ? filteredPrinters : filteredPrinters.Where(p => reqTechs.All(t => p.LayerTechnology == t)).ToList();
            filteredPrinters = reqTypes.Count == 0 ? filteredPrinters : filteredPrinters.Where(p => reqTypes.All(t => p.CaseType == t)).ToList();
            filteredPrinters = reqMats.Count == 0 ? filteredPrinters : filteredPrinters.Where(p => reqMats.All(m => p.Material.Contains(m))).ToList();
            filteredPrinters = reqPurposes.Count == 0 ? filteredPrinters : filteredPrinters.Where(p => reqPurposes.All(pur => p.Purpose == pur)).ToList();
            filteredPrinters = reqHeights.Count == 0 ? filteredPrinters : filteredPrinters.Where(p => reqHeights.All(h => p.Height == Convert.ToInt32(h))).ToList();
            filteredPrinters = reqDepthIndex == -1 || reqDepthIndex == 0 ? filteredPrinters : filteredPrinters.Where(p => reqDepthIndex == 1 ? p.Depth < depthAvgValue : p.Depth >= depthAvgValue).ToList();            

            UICreation.CreateFilterResults(filteredPrinters, ref filterResults);
            ShowResults();

        }

        private void SearchPrinters(object sender, MouseButtonEventArgs e)
        {
            string request = searchBar.Text;
            List<PrinterClass> searchResults = new List<PrinterClass>();
            foreach(PrinterClass printer in filteredPrinters)
            {
                if(isAnyFieldContainsValue(printer, request)) searchResults.Add(printer);
            }

            UICreation.CreateFilterResults(searchResults, ref filterResults);
            ShowResults();
        }

        private bool isAnyFieldContainsValue(PrinterClass printer, string value)
        {
            var properties = printer.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            foreach ( var property in properties)
            {
                int tmp = 0;
                var propVal = property.GetValue(printer);
                if (propVal == null) continue;

                if (propVal.GetType() == typeof(int) && !int.TryParse(value, out tmp))
                    continue;
                else if(propVal.GetType() == typeof(int) && !int.TryParse(value, out tmp))
                    if(propVal.Equals(tmp)) return true;

                if(propVal is List<string> collection)
                {
                    if (collection.Any(p => p != null))
                        foreach (string item in collection)
                        {
                            if (item.ToLower().Contains(value.ToLower())) return true;
                        }
                    else continue;                    

                }

                else if(propVal.ToString()!.ToLower().Contains(value.ToLower())) return true;
                
            }
            return false;
        }


        private List<string> SelectFilters(List<CheckBox> filters)
        {
            List<string> values = new List<string>();
            foreach (CheckBox checkBox in filters)
            {
                if(checkBox.IsChecked == true)
                    values.Add(checkBox.Content.ToString()!);
            }
            return values;
        }

        private void DeselectFilters(ref List<CheckBox> filters)
        {
            foreach (CheckBox checkBox in filters)            
                checkBox.IsChecked = false;            
        }

        private void ResetFilters(object sender, MouseButtonEventArgs e)
        {
            DeselectFilters(ref manufacturers);
            DeselectFilters(ref layerTechnologies);
            DeselectFilters(ref caseTypes);
            DeselectFilters(ref materials);
            DeselectFilters(ref purposes);
            DeselectFilters(ref heights);
            depths.All(d => d.IsChecked == false);

            filteredPrinters = new List<PrinterClass>(printers);

            UICreation.CreateFilterResults(filteredPrinters, ref filterResults);
            ShowResults();
        }

        #region UiRegion

        private void ShowResults()
        {
            ResultsStackPanel.Children.Clear();

            foreach(Border res in filterResults)
            {
                ResultsStackPanel.Children.Add(res);
            }
        }

        private void SetButtonConnections()
        {
            manufacturerBtn.MouseLeftButtonDown += ToggleManuf;
            layerBtn.MouseLeftButtonDown += ToggleLayer;
            caseBtn.MouseLeftButtonDown += ToggleCase;
            heightBtn.MouseLeftButtonDown += ToggleHeight;
            depthsBtn.MouseLeftButtonDown += ToggleDepth;
            materialsBtn.MouseLeftButtonDown += ToggleMat;
            purposesBtn.MouseLeftButtonDown += TogglePurpose;
            apply.MouseLeftButtonDown += ApplyFilters;
            reset.MouseLeftButtonDown += ResetFilters;
            SearchButton.MouseLeftButtonDown += SearchPrinters;
        }        

        private void SetFilterOptions()
        {
            for (int i = 0; i < manufacturers.Count; i++)
                manufacturerPanel.Children.Add(manufacturers[i]);

            for (int i = 0; i < layerTechnologies.Count; i++)
                layerPanel.Children.Add(layerTechnologies[i]);

            for (int i = 0; i < caseTypes.Count; i++)
                casePanel.Children.Add(caseTypes[i]);

            for (int i = 0; i < heights.Count; i++)
                heightPanel.Children.Add(heights[i]);

            for (int i = 0; i < depths.Count; i++)
                depthPanel.Children.Add(depths[i]);

            for (int i = 0; i < materials.Count; i++)
                materialsPanel.Children.Add(materials[i]);

            for (int i = 0; i < purposes.Count; i++)
                purposesPanel.Children.Add(purposes[i]);

        }

        private void TogglePurpose(object sender, MouseButtonEventArgs e)
        {
            if (purposesPanel.Visibility == Visibility.Collapsed)
            {
                purposesPanel.Visibility = Visibility.Visible;
                purposesBtn.Background = (Brush)(new BrushConverter().ConvertFromString("#E5E5E5")!);
            }
            else
            {
                purposesPanel.Visibility = Visibility.Collapsed;
                purposesBtn.Background = Brushes.White;
            }
        }

        private void ToggleMat(object sender, MouseButtonEventArgs e)
        {
            if (materialsPanel.Visibility == Visibility.Collapsed)
            {
                materialsPanel.Visibility = Visibility.Visible;
                materialsBtn.Background = (Brush)(new BrushConverter().ConvertFromString("#E5E5E5")!);
            }
            else
            {
                materialsPanel.Visibility = Visibility.Collapsed;
                materialsBtn.Background = Brushes.White;
            }
        }

        private void ToggleDepth(object sender, MouseButtonEventArgs e)
        {
            if (depthPanel.Visibility == Visibility.Collapsed)
            {
                depthPanel.Visibility = Visibility.Visible;
                depthsBtn.Background = (Brush)(new BrushConverter().ConvertFromString("#E5E5E5")!);
            }
            else
            {
                depthPanel.Visibility = Visibility.Collapsed;
                depthsBtn.Background = Brushes.White;
            }
        }

        private void ToggleHeight(object sender, MouseButtonEventArgs e)
        {
            if (heightPanel.Visibility == Visibility.Collapsed)
            {
                heightPanel.Visibility = Visibility.Visible;
                heightBtn.Background = (Brush)(new BrushConverter().ConvertFromString("#E5E5E5")!);
            }
            else
            {
                heightPanel.Visibility = Visibility.Collapsed;
                heightBtn.Background = Brushes.White;
            }
        }

        private void ToggleCase(object sender, MouseButtonEventArgs e)
        {
            if (casePanel.Visibility == Visibility.Collapsed)
            {
                casePanel.Visibility = Visibility.Visible;
                caseBtn.Background = (Brush)(new BrushConverter().ConvertFromString("#E5E5E5")!);
            }
            else
            {
                casePanel.Visibility = Visibility.Collapsed;
                caseBtn.Background = Brushes.White;
            }
        }

        private void ToggleLayer(object sender, MouseButtonEventArgs e)
        {
            if (layerPanel.Visibility == Visibility.Collapsed)
            {
                layerPanel.Visibility = Visibility.Visible;
                layerBtn.Background = (Brush)(new BrushConverter().ConvertFromString("#E5E5E5")!);
            }
            else
            {
                layerPanel.Visibility = Visibility.Collapsed;
                layerBtn.Background = Brushes.White;
            }
        }

        private void ToggleManuf(object sender, MouseButtonEventArgs e)
        {
            if (manufacturerPanel.Visibility == Visibility.Collapsed)
            {
                manufacturerPanel.Visibility = Visibility.Visible;
                manufacturerBtn.Background = (Brush)(new BrushConverter().ConvertFromString("#E5E5E5")!);
            }
            else
            {
                manufacturerPanel.Visibility = Visibility.Collapsed;
                manufacturerBtn.Background = Brushes.White;
            }
        }
        #endregion



    }
}