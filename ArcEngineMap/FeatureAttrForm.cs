using ESRI.ArcGIS.Geodatabase;
using System;
using System.Windows.Forms;

namespace ArcEngineMap
{
    public partial class FeatureAttrForm : Form
    {
        public FeatureAttrForm()
        {
            InitializeComponent();
        }

        public void UpdateFieldView(IFeature feature)
        {
            if (feature == null)
                return;
            FieldNameListBox.Items.Clear();
            FieldValueListBox.Items.Clear();
            IFields fields = feature.Fields;
            for(int i = 0; i < feature.Fields.FieldCount; i++)
            {
                FieldNameListBox.Items.Add(fields.Field[i].AliasName);
                FieldValueListBox.Items.Add(feature.Value[i].ToString());
            }
        }

        private void FieldValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
