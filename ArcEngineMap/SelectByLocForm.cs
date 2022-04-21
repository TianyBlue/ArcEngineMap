using System;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;

namespace ArcEngineMap
{
    public partial class SelectByLocForm : Form
    {
        private AxMapControl mapControl;
        private IFeature feature = null;
        private IFeatureLayer targetLayer = null;
        private int method = -1;
        public SelectByLocForm(AxMapControl mapControl,IFeature feature)
        {
            InitializeComponent();
                this.mapControl = mapControl;
                this.feature = feature;
                LoadMapAttr();
        }

        private void LoadMapAttr()
        {
            for (int i = 0; i < mapControl.LayerCount; i++)
            {
                ILayer layer = mapControl.get_Layer(i);
                TargetLayerComboBox.Items.Add(layer.Name);
            }
            TargetLayerComboBox.SelectedIndex = 0;
        }

        private void MethodListBox_Click(object sender, EventArgs e)
        {
            method = MethodListBox.SelectedIndex;
        }

        private void SearchFeatures()
        {
            mapControl.Map.ClearSelection();
            IRelationalOperator relationOperator = feature.Shape as IRelationalOperator;
            IFeatureCursor cursor = targetLayer.Search(null, false);
            IFeature currFeat = cursor.NextFeature();
            switch (method)
            {
                case -1:
                    MessageBox.Show("请先选择方法！");
                    break;
                case 0:      
                    while(currFeat != null)
                    {
                        //overlap only indicates the overlap one (Do Not Include CONTAINS!)
                        if (relationOperator.Overlaps(currFeat.Shape)|| relationOperator.Contains(currFeat.Shape))
                        {
                            mapControl.Map.SelectFeature(targetLayer, currFeat);
                        }
                        currFeat = cursor.NextFeature();
                    }
                    break;
                case 1:
                    while (currFeat != null)
                    {
                        if (relationOperator.Disjoint(currFeat.Shape))
                        {
                            mapControl.Map.SelectFeature(targetLayer, currFeat);
                        }
                        currFeat = cursor.NextFeature();
                    }
                    break;
                case 2:
                    while (currFeat != null)
                    {
                        if (relationOperator.Contains(currFeat.Shape))
                        {
                            mapControl.Map.SelectFeature(targetLayer, currFeat);
                        }
                        currFeat = cursor.NextFeature();
                    }
                    break;
                case 3:
                    while (currFeat != null)
                    {
                        if (relationOperator.Touches(currFeat.Shape))
                        {
                            mapControl.Map.SelectFeature(targetLayer, currFeat);
                        }
                        currFeat = cursor.NextFeature();
                    }
                    break;
                case 4:
                    ITopologicalOperator topologicalOperator = feature.Shape as ITopologicalOperator;
                    // create buffer
                    IGeometry geom = topologicalOperator.Buffer(Convert.ToDouble(ConditionTextBox.Text));
                    relationOperator = geom as IRelationalOperator;
                    while (currFeat != null)
                    {
                        if (relationOperator.Overlaps(currFeat.Shape) || relationOperator.Contains(currFeat.Shape))
                        {
                            mapControl.Map.SelectFeature(targetLayer, currFeat);
                        }
                        currFeat = cursor.NextFeature();
                    }
                    break;
            }
            mapControl.Refresh();
        }

        private void TargetLayerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            targetLayer = mapControl.get_Layer(TargetLayerComboBox.SelectedIndex) as IFeatureLayer;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(feature == null)
            {
                MessageBox.Show("请先选择要素！");
                this.Hide();
                this.Dispose();
                return;
            }
            SearchFeatures();
        }
    }
}
