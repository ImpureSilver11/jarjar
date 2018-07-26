using System;
using System.Collections.Generic;

namespace jarjar
{
    class MainClass
    {
       public static void Main(string[] args){
			var nagayan = new HouseTiger();
            nagayan.Otageti();
			}
    }


	class HouseTiger
    {
		private readonly string Zensyou = "よっしゃいくぞー";
		private readonly string jarjar = "ジャージャー！";
		private readonly string tiger = "タイガー！";
        private readonly string fire = "ファイヤー！";
        private readonly string cyber = "サイバー！";
		private readonly string fiber = "ファイバー！";
		private readonly string diver = "ダイバー！";
		private readonly string byver = "バイバー！";

		List<string> koujou = new List<String>();

		public HouseTiger()
        {
            koujou.Add(tiger);
            koujou.Add(fire);
            koujou.Add(cyber);
            koujou.Add(fiber);
            koujou.Add(diver);
            koujou.Add(byver);
        }

        public void Otageti()
        {
            Console.Write(Zensyou);
            foreach (string s in koujou)
            {
                Console.Write(s);
            }
            Console.WriteLine(jarjar);
        }
    }
}
