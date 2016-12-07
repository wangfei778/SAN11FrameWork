using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAN11FrameWork
{
    //这里有两张表 一张保存building类型数据 一张保存building数据
    class MapBuildingPO
    {
        public int _ID;
        public int _Name;
        public string _modelFilePath;
        public string _imgFilePath;
        public int _UpGradBuildingID;
        public int _hexPosX;
        public int _hexPosY;//这个只对第二章表才有意义

        public int _baseFoodPerTurn;
        public int _baseMoneyPerTurn;
        public int _baseIronPerTurn;//铁矿
        public int _baseHorsePerTurn;
        public int _baseCulturePointPerTurn;
        public int _baseTechPoint;
        public int _baseZhiAnLimit;//治安上限修正


    }
}
