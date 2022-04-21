using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Controls;

namespace ArcEngineMap
{
    public partial class MainForm : Form
    {
        private string mapUnit = string.Empty;

        private string tool = string.Empty;
        private IFeatureLayer currCheckFeatureLayer = null;
        ILayer moveLayer = null;
        int toIndex = 0;
        IFeature currFeature = null;
        FeatureAttrForm featureAttrForm;
        bool featureAttrFormStatus = false;
        private IWorkspace workspace;
        private SqlQuery sqlQuery = null;
        private bool loginStatus = false;
        public MainForm()
        {
            
            InitializeComponent();
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            featureAttrForm = new FeatureAttrForm();
            sqlQuery = new SqlQuery();
        }

        private void 读取shapefile文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIfHasLogin())
                return;

            //open file browser
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "加载Shapefile";
            fileDialog.Filter = "(*.shp)|*.shp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //string fullpath = fileDialog.FileName;
                //string path = fullpath.Substring(0, fullpath.LastIndexOf("\\"));
                //string filename = fullpath.Substring(fullpath.LastIndexOf("\\") + 1);
                //MainMapControl.AddShapeFile(path, filename);
                //MainMapControl.Refresh();
                //setMapUnit();
                ////ReadLayers();
                //MessageBox.Show("文件加载成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string fullpath = fileDialog.FileName;
                FileLoader loader = new FileLoader();
                loader.LoadShapeFile(MainMapControl, fullpath);
                MessageBox.Show("文件加载成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toolStripStatusLabel3.Text = MainMapControl.Map.SpatialReference.Name;

                for(int i = 0; i < MainMapControl.LayerCount; i++)
                {
                    IGeoDataset set = MainMapControl.get_Layer(0) as IGeoDataset;
                    Console.WriteLine(set.SpatialReference.Name);
                }


            }
        }

        private void setMapUnit()
        {
            switch (MainMapControl.MapUnits)
            {
                case esriUnits.esriDecimalDegrees:
                    mapUnit = "十进制度";
                    break;
                case esriUnits.esriKilometers:
                    mapUnit = "千米";
                    break;
                case esriUnits.esriMeters:
                    mapUnit = "米";
                    break;
                case esriUnits.esriCentimeters:
                    mapUnit = "厘米";
                    break;
                default:
                    mapUnit = "unknown";
                    break;
            }
        }

        public void Login(string username,string password)
        {
            loginStatus = sqlQuery.CheckIfLoginSuccess(username, password);
            if (!loginStatus)
                MessageBox.Show("用户名或密码错误！");
            //MessageBox.Show(username + password);
        }

        public void SkipLogin()
        {
            loginStatus = true;
        }

        private void 读取MXD文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIfHasLogin())
                return;

            //open file browser
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "加载MXD";
            fileDialog.Filter = "(*.mxd)|*.mxd";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fullpath = fileDialog.FileName;
                //Load MXD doc
                MainMapControl.LoadMxFile(fullpath);
                MainMapControl.Refresh();
                MessageBox.Show("文件加载成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setMapUnit();
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MainMapControl_OnMouseMove(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseMoveEvent e)
        {
            string output = string.Format("坐标: ({0:N4},{1:N4}) {2}", e.mapX, e.mapY, mapUnit);
            CoordinatesLabel.Text = output;
            string scale = string.Format("1 : {0:N0}", MainMapControl.MapScale);
            ScaleLabel.Text = scale;
        }

        private void 按属性选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIfHasLogin())
                return;

            SelectByAttrForm form = new SelectByAttrForm(MainMapControl);
            form.Show();
        }

        private void ClickSelect_Click_1(object sender, EventArgs e)
        {
            //LoadTreeView();
            tool = "click_select";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm mLoginForm = new LoginForm(this);
            mLoginForm.Show();
        }

        private void MainTOCControl_OnMouseDown(object sender, ESRI.ArcGIS.Controls.ITOCControlEvents_OnMouseDownEvent e)
        {
            esriTOCControlItem pItem = esriTOCControlItem.esriTOCControlItemNone;
            IBasicMap pMap = null;
            object unk = null;
            object data = null;
            ILayer pLayer = null;
            if (e.button == 2)
            {
                IFeatureLayer pTocFeatureLayer = null;
                MainTOCControl.HitTest(e.x, e.y, ref pItem, ref pMap, ref pLayer, ref unk, ref data);
                pTocFeatureLayer = pLayer as IFeatureLayer;
                if (pItem == esriTOCControlItem.esriTOCControlItemLayer && pTocFeatureLayer != null)
                {
                    currCheckFeatureLayer = pTocFeatureLayer;
                    contextMenuStrip1.Show(Control.MousePosition);
                }
            }
            if(e.button == 1)
            {
                MainTOCControl.HitTest(e.x, e.y, ref pItem, ref pMap, ref pLayer, ref unk, ref data);
                moveLayer = pLayer;
            }
        }

        private void 打开属性表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayerAttrForm currForm = new LayerAttrForm(currCheckFeatureLayer);
            currForm.Show();
        }

        private void 缩放至图层ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMapControl.Extent = currCheckFeatureLayer.AreaOfInterest;
            MainMapControl.Refresh();
        }

        private void MainTOCControl_OnMouseUp(object sender, ITOCControlEvents_OnMouseUpEvent e)
        {
            if (e.button == 1)
            {
                esriTOCControlItem item = esriTOCControlItem.esriTOCControlItemNone;
                IBasicMap map = null; ILayer layer = null;
                object other = null; object index = null;
                MainTOCControl.HitTest(e.x, e.y, ref item, ref map, ref layer, ref other, ref index);
                IMap pMap = MainMapControl.ActiveView.FocusMap;
                if (item == esriTOCControlItem.esriTOCControlItemLayer || layer != null)
                {
                    if (moveLayer != layer)//如果是原图层则不用操作
                    {
                        ILayer pTempLayer;
                        for (int i = 0; i < pMap.LayerCount; i++)
                        {
                            pTempLayer = pMap.get_Layer(i);
                            if (pTempLayer == layer)//获取移动后的图层索引
                            {
                                toIndex = i;
                            }
                        }
                        pMap.MoveLayer(moveLayer, toIndex);
                        MainMapControl.ActiveView.Refresh();
                        MainTOCControl.Update();
                    }
                }
            }
        }

        private void ClickSelectOneFeature()
        {
            // need first open all fields!
            ISelection selection = MainMapControl.Map.FeatureSelection;
            IEnumFeatureSetup iEnumFeatureSetup = (IEnumFeatureSetup)selection;
            iEnumFeatureSetup.AllFields = true;
            IEnumFeature enumFeature = (IEnumFeature)iEnumFeatureSetup;
            enumFeature.Reset();
            currFeature = enumFeature.Next();
        }

        private void MainMapControl_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            switch(tool){
                case "click_select":
                    PointClass point = new PointClass();
                    point.X = e.mapX;
                    point.Y = e.mapY;

                    IGeometry g = point as IGeometry;
                    MainMapControl.Map.SelectByShape(g, null, false);
                    MainMapControl.Refresh();
                    ClickSelectOneFeature();
                    featureAttrForm.UpdateFieldView(currFeature);
                    break;
                case "selectByTrack":
                    IEnvelope envel = MainMapControl.TrackRectangle();
                    IGeometry geom = envel as IGeometry;
                    //Console.WriteLine(envel.Dimension.ToString());

                    //Console.WriteLine(e.mapX.ToString());
                    //select features by shape(envelop as geometry)
                    MainMapControl.Map.SelectByShape(geom, null, false);
                    MainMapControl.Refresh();
                    ClickSelectOneFeature();
                    break;
            }
        }

        private void 按位置选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIfHasLogin())
                return;

            SelectByLocForm form = new SelectByLocForm(MainMapControl,currFeature);
            form.Show();
        }

        private void 创建缓冲区ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIfHasLogin())
                return;

            CreateBufferForm form = new CreateBufferForm(MainMapControl, currFeature);
            form.Show();
        }

        private void 打开要素属性表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIfHasLogin())
                return;

            featureAttrFormStatus = !featureAttrFormStatus;
            if (featureAttrFormStatus)
            {
                featureAttrForm.Show();
                featureAttrForm.UpdateFieldView(currFeature);
            }
            else 
            {
                featureAttrForm.Hide();
            }
        }

        private void 清除选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMapControl.Map.FeatureSelection.Clear();
            MainMapControl.Refresh();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            tool = "";
        }

        private void 连接数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIfHasLogin())
                return;

            DataBaseLoginForm form = new DataBaseLoginForm(MainMapControl, this);
            form.Show();
        }


        public void CreateDBConnect(string dbaddress, string dbname, string username, string password)
        {
            workspace = sqlQuery.GetDBConnect(dbaddress, dbname, username, password);
            if(workspace == null)
            {
                MessageBox.Show("数据库连接失败，请修改配置");
                return;
            }
            List<string> layernames = sqlQuery.GetAllLayerName(workspace);
            for (int i = 0; i < layernames.Count; i++)
            {
                IFeatureLayer layer = sqlQuery.GetFeatureLayer(workspace, layernames[i]);
                MainMapControl.AddLayer(layer);
            }
            toolStripStatusLabel3.Text = MainMapControl.Map.SpatialReference.Name;
            MainMapControl.Refresh();
        }

        private void RectSelectBtn_Click(object sender, EventArgs e)
        {
            tool = "selectByTrack";
        }

        private void 更改要素颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayerStyleForm styleForm = new LayerStyleForm();
            styleForm.ChangeLayerColor(MainMapControl, currCheckFeatureLayer as ILayer);
            styleForm.Show();
        }

        private void ClearSelectionBtn_Click(object sender, EventArgs e)
        {
            MainMapControl.Map.ClearSelection();
            MainMapControl.Refresh();
        }

        private void 读取文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private bool checkIfHasLogin()
        {
            if (loginStatus)
                return true;
            MessageBox.Show("请先登录");
            return false;
        }
    }

}