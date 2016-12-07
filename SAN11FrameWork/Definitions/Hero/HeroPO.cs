using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAN11FrameWork.Definitions.Hero
{
    class HeroPO
    {
        public int _ID;
        public string _Name;
        public string _imgFilePath;
        public string _modelFilePath;        
        public int _maxHp;
        public int _curHp;
        public string describe;

        //相互赋值，方便查询

        public int tongyu;  //影响部队攻击力
        public int _attack;//攻击力高的统御必定高 
        public int _zhili;//后面三项是相关的，不要相差太大
        public int _neizhen;
        public int _meili;
        public Dictionary<int, int> _heroRelationDic = new Dictionary<int, int>();// <英雄ID,关系> 可为正数也可以为负数
        //和君主的关系就代表和阵营关系  <君主ID,关系> 可为正数也可以为负数  上面的dic包括这个下面的dic
        public Dictionary<int, int> _factionLeaderRelationDic = new Dictionary<int, int>();
    }
}
