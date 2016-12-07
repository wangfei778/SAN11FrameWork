using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAN11FrameWork
{
    //这里只有一张表
    class InCityBuildingPO
    {
        public int _ID;
        public int _Name;
        public string _imgFilePath;
        public int _UpGradBuildingID;

        public int _HP;//叠加到城市
        public int _Def;
        public int _isOutSideCity;//城市外，有独立模型
        public string _outsideModelFilePath;
        public bool _isForFanji;//有了这个城市就可以主动反击
        public int _fanjiJuli;//反击距离


    }
}
