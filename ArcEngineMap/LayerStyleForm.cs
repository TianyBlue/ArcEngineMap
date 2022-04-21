using System;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;

namespace ArcEngineMap
{
    public partial class LayerStyleForm : Form
    {
        AxMapControl mapControl;
        ILayer layer;
        string color = string.Empty;
        int shapeType = 0;
        public LayerStyleForm()
        {
            InitializeComponent();
        }

        public void ChangeLayerColor(AxMapControl mapControl,ILayer layer)
        {
            this.mapControl = mapControl;
            this.layer = layer;
            IFeatureLayer2 featureLayer = layer as IFeatureLayer2;
            switch (featureLayer.ShapeType.ToString())
            {
                case "esriGeometryPoint":
                    shapeType = 1;
                    break;
                case "esriGeometryPolyline":
                    shapeType = 2;
                    break;
                case "esriGeometryPolygon":
                    shapeType = 3;
                    break;
            }
            Console.WriteLine(featureLayer.ShapeType.ToString());
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {

            IRgbColor rgb = new RgbColorClass();

            switch (color)
            {
                case "":
                    return;
                case "Red":
                    rgb.Blue = 78;
                    rgb.Red = 252;
                    rgb.Green = 78;
                    break;
                case "Blue":
                    rgb.Blue = 242;
                    rgb.Red = 92;
                    rgb.Green = 192;
                    break;
                case "Green":
                    rgb.Blue = 139;
                    rgb.Red = 113;
                    rgb.Green = 217;
                    break;
                case "Yellow":
                    rgb.Blue = 84;
                    rgb.Red = 220;
                    rgb.Green = 247;
                    break;
            }


            ISimpleRenderer renderer = new SimpleRendererClass();
            switch (shapeType)
            {
                case 0:
                    return;
                case 1:
                    ISimpleMarkerSymbol ptSym = new SimpleMarkerSymbol();
                    ptSym.Color = rgb;
                    ptSym.Style = esriSimpleMarkerStyle.esriSMSCircle;
                    renderer.Symbol = ptSym as ISymbol;
                    break;
                case 2:
                    ISimpleLineSymbol lineSym = new SimpleLineSymbolClass();
                    lineSym.Color = rgb;
                    lineSym.Style = esriSimpleLineStyle.esriSLSSolid;
                    renderer.Symbol = lineSym as ISymbol;
                    break;
                case 3:
                    ISimpleLineSymbol lnSym = new SimpleLineSymbolClass();
                    IRgbColor rgb2 = new RgbColorClass();
                    rgb2.Blue = 0;
                    rgb2.Red = 0;
                    rgb2.Green = 0;
                    lnSym.Color = rgb2;
                    lnSym.Style = esriSimpleLineStyle.esriSLSSolid;

                    ISimpleFillSymbol areaSym = new SimpleFillSymbolClass();
                    areaSym.Color = rgb;
                    areaSym.Outline = lnSym;
                    areaSym.Style = esriSimpleFillStyle.esriSFSSolid;
                    renderer.Symbol = areaSym as ISymbol;
                    break;
            }

            IGeoFeatureLayer geofealayer = layer as IGeoFeatureLayer;
            geofealayer.Renderer = renderer as IFeatureRenderer;
            mapControl.Refresh();

            this.Hide();
            this.Dispose();
        }

        private void ColorRedBtn_Click(object sender, EventArgs e)
        {
            color = "Red";
        }

        private void ColorBlueBtn_Click(object sender, EventArgs e)
        {
            color = "Blue";
        }

        private void ColorGreenBtn_Click(object sender, EventArgs e)
        {
            color = "Green";
        }

        private void ColorYellowBtn_Click(object sender, EventArgs e)
        {
            color = "Yellow";
        }
    }
}