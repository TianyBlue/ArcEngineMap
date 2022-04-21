using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Controls;


namespace ArcEngineMap
{
    interface IFileLoader
    {
        void LoadShapeFile(AxMapControl mapControl,string path);
        void LoadMXD(AxMapControl mapControl,string path);
    }
}
