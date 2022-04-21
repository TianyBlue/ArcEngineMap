using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System;
using System.Windows.Forms;

namespace ArcEngineMap
{
    public partial class CreateBufferForm : Form
    {
        private readonly AxMapControl mapControl;
        private readonly IFeature feature;
        public CreateBufferForm(AxMapControl mapControl,IFeature feature)
        {
            InitializeComponent();
            this.mapControl = mapControl;
            this.feature = feature;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if(feature == null)
            {
                MessageBox.Show("请先选择要素");
                this.Hide();
                this.Dispose();
                return;
            }
            ITopologicalOperator topologicalOperator = feature.Shape as ITopologicalOperator;
            // create buffer
            IGeometry geom = topologicalOperator.Buffer(Convert.ToDouble(DistanceTextBox.Text));
            ISimpleFillSymbol fillSymbol = new SimpleFillSymbolClass();
            IRgbColor rgb = new RgbColorClass
            {
                Blue = 155,
                Red = 127,
                Green = 203
            };
            fillSymbol.Color = rgb;
            fillSymbol.Style = esriSimpleFillStyle.esriSFSCross;
            IFillShapeElement element = new PolygonElementClass();
            IElement ele = element as IElement;
            ele.Geometry = geom;
            element.Symbol = fillSymbol;
            IGraphicsContainer container = mapControl.ActiveView as IGraphicsContainer;
            container.AddElement(element as IElement, 0);
            mapControl.Refresh();
            this.Hide();
            this.Dispose();
        }
    }
}
