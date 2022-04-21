using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;

namespace ArcEngineMap
{
    public partial class SelectByAttrForm : Form
    {
        private readonly AxMapControl mapControl;
        private IFeatureLayer featureLayer = null;
        private List<string> potentialVal;
        public SelectByAttrForm(AxMapControl mapControl)
        {
            InitializeComponent();
            this.mapControl = mapControl;
            potentialVal = new List<string>();
            LoadMapAttr();
        }

        private void LoadMapAttr()
        {
            for(int i = 0; i < mapControl.LayerCount; i++)
            {
                ILayer layer = mapControl.get_Layer(i);
                LayerNameComboBox.Items.Add(layer.Name);
            }
            LayerNameComboBox.SelectedIndex = 0;
            UpdatePotentialVal();
        }

        private void UpdatePotentialVal()
        {
            int FieldIndex = FieldsListBox.SelectedIndex;
            if (FieldIndex == -1)
                return;

            potentialVal.Clear();
            PotentialValListBox.Items.Clear();

            //查询 ,search的参数第一个为过滤条件，第二个为是否重复执行
            IFeatureCursor pFeatureCursor = featureLayer.Search(null, false);
            //获取查询到的要素 
            IFeature pFeature = pFeatureCursor.NextFeature();
            //判断是否获取到要素 
            while (pFeature != null)
            {
                string val = pFeature.Value[FieldIndex].ToString();
                bool hasIt = false;
                for(int i = 0; i < potentialVal.Count; i++)
                {
                    if (potentialVal[i] == val)
                        hasIt = true;
                }
                if (!hasIt)
                    potentialVal.Add(val);
                pFeature = pFeatureCursor.NextFeature();
            }

            for (int i = 0; i < potentialVal.Count; i++)
                PotentialValListBox.Items.Add(potentialVal[i]);

        }

        private void LayerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LayerNameComboBox.SelectedIndex;
            ILayer layer = mapControl.get_Layer(index);
            featureLayer = layer as IFeatureLayer;
            ReadFields();
            UpdatePotentialVal();
        }

        private void ReadFields()
        {
            FieldsListBox.Items.Clear();
            IFields fields = featureLayer.FeatureClass.Fields;
            for (int i = 0; i < fields.FieldCount; i++)
            {
                FieldsListBox.Items.Add(fields.Field[i].Name);
            }
            FieldsListBox.SelectedIndex = 0;
        }

        private void FieldsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePotentialVal();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try {
                IQueryFilter filter = new QueryFilterClass();
                string clause = SQLTextBox.Text;
                filter.WhereClause = clause;

                //查询 ,search的参数第一个为过滤条件，第二个为是否重复执行
                IFeatureCursor pFeatureCursor = featureLayer.Search(filter, false);
                //获取查询到的要素 
                IFeature pFeature = pFeatureCursor.NextFeature();
                //判断是否获取到要素 
                while (pFeature != null)
                {
                    mapControl.Map.SelectFeature(featureLayer, pFeature); //选择要素 
                    // mMapControl.Extent = pFeature.Shape.Envelope; //放大到要素
                    pFeature = pFeatureCursor.NextFeature();
                }
                mapControl.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FieldsListBox_DoubleClick(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = FieldsListBox.SelectedItem.ToString() + " ";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = "= ";
        }

        private void btnunequal_Click(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = "!= ";
        }

        private void btnmore_Click(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = "> ";
        }

        private void btnmoe_Click(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = ">= ";
        }

        private void btnloe_Click(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = "<= ";
        }

        private void btnless_Click(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = "< ";
        }

        private void btnnot_Click(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = "Not ";
        }

        private void btnand_Click(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = "And ";
        }

        private void btnlike_Click(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = "like ";
        }

        private void btncharacter_Click(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = "'' ";
        }

        private void btnbetween_Click(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = "Between ";
        }

        private void btnpercent_Click(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = "% ";
        }

        private void btnis_Click(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = "is ";
        }

        private void btnnull_Click(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = "Null ";
        }

        private void btnor_Click(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = "Or ";
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = "In ";
        }

        private void PotentialValListBox_DoubleClick(object sender, EventArgs e)
        {
            SQLTextBox.SelectedText = "'" + PotentialValListBox.SelectedItem.ToString() + "'";
        }
    }
}
