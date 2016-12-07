using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAN11FrameWork
{
    public enum CityType {
        City=1,
        Harbor=2,
        Pass=3,
        Castle=4
    }

    

    class CityPO
    {
        public int _ID;
        public string _Name;
        public string _ModelFilePath;
        public int _hexPosX;
        public int _hexPosY;
        public CityType _cityType;
        public List<int> _heroIDList = new List<int>();
        public List<int> _heroPrisonList = new List<int>();
        public int _prisonEscapeRate;//0到100  和俘虏本省的能力有关
        public int _population;//特大城市 人口300万 兵力上限6万  特小城市 人口10万人  兵力2000
        //人口只影响兵力 ，对其他 毫无影响   建设力只和建设的将领有关  城市本身没有任何收入 没有任何粮食
        //人口还影响城市HP上限  城防也影响城市HP上限 300万人口HP上限就是3000， 城防增加HP比例
        public int _curHp;
        public int _maxHp;
        public int _def; //受太守技能影响，
        public int _attack;//收太守技能影响 受城里士兵数量影响
        //攻击城市  城市掉血  城里士兵掉血（城里士兵获得防御加成） 攻击也是相互的
        public bool _canFanji;//是否可以反击  


        public int _soldierPopulation;//可用兵员人数-----基准比列是1/50之一    
        public int _usedSoldierPopulation;//已用兵员数
        public Dictionary<int, int> soldierDic = new Dictionary<int, int>(); //<SoldierTypePo._ID ,num> 兵数就代表HP      

        public int _moneyPerTurn;// 永远为正数 
        public int _foodPerTurn;//永远为正数 
        public int _money;//   建设招兵需要money  各种命令都需要
        public int _food;// 不影响人口增长
        public int _curZhiAn;//影响人口增长  民心不影响人口增长，只是影响征兵比例。  治安低，可以负增长
        public int _maxZhiAn;
        //治安不可以一劳永逸， 盖治安建筑只是增加治安上限

        public List<int> _mapBuildingIDList = new List<int>();
        public List<int> _inCityBuildingIDList = new List<int>(); //箭塔双层城墙

    }
}
