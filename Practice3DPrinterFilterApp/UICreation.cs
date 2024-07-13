using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Media3D;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace Practice3DPrinterFilterApp
{
    internal static class UICreation
    {
        public static void CreateFilterOptions(
            DatabaseOperations db, 
            ref List<CheckBox> manufacturers, 
            ref List<CheckBox> layerTechnologies, 
            ref List<CheckBox> caseTypes,
            ref List<CheckBox> materials,
            ref List<CheckBox> purposes,
            ref List<CheckBox> heights,
            ref List<RadioButton> depths)
        {
            int avgDepth = 0;

            foreach (string s in db.Printers.Select(m => m.Manufacturer).Distinct().ToList())
            {
                CheckBox tmp = new CheckBox();
                tmp.Content = s;
                manufacturers.Add(tmp);
            }

            foreach (string s in db.Printers.Select(m => m.LayerTechnology).Distinct().ToList())
            {
                CheckBox tmp = new CheckBox();
                tmp.Content = s;
                layerTechnologies.Add(tmp);
            }

            foreach (string s in db.Printers.Select(m => m.CaseType).Distinct().ToList())
            {
                CheckBox tmp = new CheckBox();
                tmp.Content = s;
                caseTypes.Add(tmp);
            }           

            foreach (int s in db.Printers.Select(m => m.Height).Distinct().ToList())
            {
                CheckBox tmp = new CheckBox();
                tmp.Content = s.ToString();
                heights.Add(tmp);
            }
            
            int cnt = 0;
            foreach (int s in db.Printers.Select(m => m.Depth).Distinct().ToList())
            {
                avgDepth += s;
                cnt++;
            }
            avgDepth /= cnt;
            depths.Add(new RadioButton());
            depths[0].Content = "Все";
            for (int i = 0; i < 2; i++)
            {
                RadioButton tmp = new RadioButton();
                tmp.Content = i % 2 == 0 ? $"<{avgDepth}" : $">={avgDepth}";
                depths.Add(tmp);                
            }


            HashSet<string> mats = new HashSet<string>();
            foreach (List<string> s in db.Printers.Select(m => m.Material))
            {
                foreach (string k in s)
                {
                    mats.Add(k);
                }
            }
            foreach (string s in mats)
            {
                CheckBox tmp = new CheckBox();
                tmp.Content = s;
                materials.Add(tmp);
            }

            foreach (string s in db.Printers.Select(m => m.Purpose).Distinct().ToList())
            {
                CheckBox tmp = new CheckBox();
                tmp.Content = s.ToString();
                purposes.Add(tmp);
            }
        }


        public static void CreateFilterResults(List<PrinterClass> filteredPrinters, ref List<Border> results)
        {
            results.Clear();

            foreach(PrinterClass printer in filteredPrinters)
            {
                Border result = new Border();
                result.Height = 110;
                result.Margin = new Thickness(15, 10, 15, 5);
                result.Background = Brushes.White;
                result.CornerRadius = new CornerRadius(10);

                DockPanel dock = new DockPanel();

                Image image = new Image();
                image.Source = printer.Image;
                image.Stretch = System.Windows.Media.Stretch.Fill;
                image.Margin = new Thickness(10);
                image.Width = 90;

                StackPanel stackPanel = new StackPanel();

                Label name = new Label();
                name.Content = $"3D принтер {printer.Manufacturer} {printer.Name}";
                name.FontSize = 22;

                string materials = string.Empty;
                for(int i = 0; i < printer.Material.Count; i++)
                {
                    materials += printer.Material[i];
                    if (i < printer.Material.Count-1) materials += ", ";
                }

                TextBlock description = new TextBlock();
                description.Text = $"{printer.LayerTechnology}, пластик - {materials}, " +
                    $"{printer.CaseType} корпус, высота рабочего пространства: {printer.Height} мм, " +
                    $"глубина рабочего пространства: {printer.Depth} мм, для: {printer.Purpose}";
                description.FontSize = 16;
                description.TextWrapping = TextWrapping.Wrap;

                stackPanel.Children.Add(name);
                stackPanel.Children.Add(description);

                dock.Children.Add(image);
                dock.Children.Add(stackPanel);

                result.Child = dock;

                results.Add(result);
            }
        }
    }
}
