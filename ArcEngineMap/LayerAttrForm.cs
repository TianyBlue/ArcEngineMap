using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using System;
using System.Data;
using System.Windows.Forms;

namespace ArcEngineMap
{
    public partial class LayerAttrForm : Form
    {
        private IFeatureLayer featureLayer;
        public LayerAttrForm(IFeatureLayer featureLayer)
        {
            InitializeComponent();
            this.featureLayer = featureLayer;
            InitUI();
        }

        public void InitUI()
        {
            IFeature pFeature = null;
            DataTable pFeatDT = new DataTable();
            DataRow pDataRow = null;
            DataColumn pDataCol = null;
            IField pField = null;
            for (int i = 0; i < featureLayer.FeatureClass.Fields.FieldCount; i++)
            {
                pDataCol = new DataColumn();
                pField = featureLayer.FeatureClass.Fields.get_Field(i);
                pDataCol.ColumnName = pField.AliasName; //获取字段名作为列标题
                pDataCol.DataType = Type.GetType("System.Object");//定义列字段类型
                pFeatDT.Columns.Add(pDataCol); //在数据表中添加字段信息
            }
            IFeatureCursor pFeatureCursor = featureLayer.Search(null, true);
            pFeature = pFeatureCursor.NextFeature();
            while (pFeature != null)
            {
                pDataRow = pFeatDT.NewRow();
                //获取字段属性
                for (int k = 0; k < pFeatDT.Columns.Count; k++)
                {
                    pDataRow[k] = pFeature.get_Value(k);
                }

                pFeatDT.Rows.Add(pDataRow); //在数据表中添加字段属性信息
                pFeature = pFeatureCursor.NextFeature();
            }
            //释放指针
            System.Runtime.InteropServices.Marshal.ReleaseComObject(pFeatureCursor);
            //AttrTableView.BeginInit();
            AttrTableView.DataSource = pFeatDT;
        }
    }
}
