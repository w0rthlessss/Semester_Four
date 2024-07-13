using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Practice3DPrinterFilterApp
{
    internal class PrinterClass
    {
        public int Id {  get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }        
        public string LayerTechnology {  get; set; }
        public string CaseType {  get; set; }
        public List<string> Material { get; set; }
        public string Purpose { get; set; }
        public int Height {  get; set; }
        public int Depth { get; set; }
        public BitmapImage Image { get; set; }
        

        public PrinterClass(int id, string manufacturer, string name, string layerTechnology, string caseType, List<string> material, string purpose, int height, int depth, byte[] img)
        {
            Id = id;            
            Manufacturer = manufacturer;
            Name = name;
            LayerTechnology = layerTechnology;
            CaseType = caseType;
            Height = height;
            Depth = depth;
            Material = material;
            Purpose = purpose;
            Image = ConvertToBitmap(img);
        }

        private static BitmapImage ConvertToBitmap(byte[] img)
        {            
            using(MemoryStream ms = new MemoryStream(img))
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = ms;
                image.EndInit();
                return image;
            }
            
        }
    }
}
