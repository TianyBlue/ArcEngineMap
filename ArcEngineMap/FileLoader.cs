using ESRI.ArcGIS.Controls;


namespace ArcEngineMap
{
    class FileLoader : IFileLoader
    {
        public void LoadMXD(AxMapControl mapControl, string fullpath)
        {
            //Load MXD doc
            mapControl.LoadMxFile(fullpath);
            mapControl.Refresh();
            //MessageBox.Show("文件加载成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LoadShapeFile(AxMapControl mapControl, string fullpath)
        {
            string mpath = fullpath.Substring(0, fullpath.LastIndexOf("\\"));
            string filename = fullpath.Substring(fullpath.LastIndexOf("\\") + 1);
            mapControl.AddShapeFile(mpath, filename);
            mapControl.Refresh();
            //MessageBox.Show("文件加载成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}