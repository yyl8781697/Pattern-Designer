using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/********************************************
 * Interpreret Pattern（解释器模式）：定义一个语义，定义它的文法的一种表示，
 * 并定义一个解释器，这个解释器使用该表示来解释语言中的句子
 * 本例以自定义的音乐播放器来例：
 * O表示音阶，'O1'表示低音阶，'O2'表示中音阶，'O3'表示高音阶
 * 'C D E F G A B'分别表示'Do-Re-Mi-Fa-So-La-T1'
 * 音符长度1表示一拍，2表示二拍，0.5表示半拍，0.25表示四分之一拍
 * *****************************************/
namespace InterpreretPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayContext context = new PlayContext();
            //定义一首歌的语义
            context.PlayText = "O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 C 1 ";

            Expression exrepssion = null;
            try
            {
                while (!string.IsNullOrEmpty(context.PlayText))
                {
                    string str = context.PlayText.Substring(0, 1);
                    switch (str)
                    {
                        case "O":
                            exrepssion = new Scale();
                            break;
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                        case "G":
                        case "A":
                        case "B":
                        case "P":
                            exrepssion = new Note();
                            break;
                    }
                    exrepssion.Interpreter(context);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
