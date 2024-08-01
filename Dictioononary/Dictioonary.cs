using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictiononary
{
    public class Program
    {
        public static void Main()
        {
            //해시테이블 기반의 딕셔너리 자료구조
            Dictionary<string, Monster> monsterDic = new Dictionary<string, Monster>();
            //삽입
            monsterDic.Add("잉어킹1번", new Monster("잉어킹", MonsterType.Water));
            monsterDic.Add("잉어킹2번", new Monster("잉어킹", MonsterType.Water));
            //삭제
            monsterDic.Remove("잉어킹1번");
            //탐색
            if (monsterDic.ContainsKey("잉어킹2번")) // 잉어킹2번이 딕셔너리에 있으면 true
            {
                Monster find = monsterDic["잉어킹2번"];
                Console.WriteLine($"{find.name}{find.type}");
            }
        }
    }
    public enum MonsterType { Fire, Water, Grass}
    public class Monster
    {
        public string name {  get; set; }
        public MonsterType type {  get; set; }
        public Monster(string name, MonsterType type) { this.name = name; this.type = type; }

    }
}
