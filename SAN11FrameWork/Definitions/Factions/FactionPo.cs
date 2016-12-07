using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAN11FrameWork
{

    public class FactionPo
    {
        public int _ID;
        public int _Name;
        public int _leaderID;
        public List<int> _heroIDList;
        public List<int> _cityIDList;
        public int captialID;//首都  只有君主模式，玩家基地没有则gameOver ，AI最后基地没有还可以继续（流亡）

        public int _techPoint;//研究 科研点  科技  全局     盖科研设施
        public int _chaoTingPoint;//朝廷贡献度  全局    
        public int _moral;// 民心影响征兵比例 ，登庸（hero的口才修正是百分比  hero的关系修正也是百分比）  盖民心设施 全局       

        public Dictionary<int, int> _guanzhidic = new Dictionary<int, int>();//官职列表<官职ID,对应heroID> ，负数表示未分封

        public List<int> _avaliableBuildingList = new List<int>();//当前阵营可以建设哪些建筑




    }
 }
