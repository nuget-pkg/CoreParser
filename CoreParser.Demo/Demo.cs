using System;
using Global;
using static Global.EasyObject;

UseAnsiConsole = true;
SetupConsoleEncoding();

DebugOutput = true;

Log("⁅markup⁆[green]Hello! ハロー© ⁅EMOJI⁆◉▶▸⸝↪️ ↩️ ℴ𝓬➺➢ᰔヾ➠✅🈂️❓❗＼／：＊“≪≫￤；‘｀＃％＄＆＾～￤﴾﴿⁅⁆【】≪≫＋ー＊＝⚽ 𝑪𝒉𝒆𝒄𝒌 🌐🪩[/]");
EchoWebLink(
    "!! THIS TEXT CAN BE CLICKED FOR OPENING URL !! («YOUTUBE PLAYLIST»⭕️⁅🌐⁆@⁅反転mirror⁆パイパイ仮面でどうかしらん？ / 宝鐘マリン FULL 踊ってみた【練習用】 - YouTube)",
    "https://www.youtube.com/watch?v=sLpodTN4xhI&list=PLTvSv0jkjbk9-emLIV2vM-0p7CeMnTYG2");
Debug(new { args });
var answer = CoreParser.Add2(11, 22);
Debug(new { answer });
AssertEqual(
    expected: 33,
    actual: answer,
    hint: new
    {
        answer,
        now = DateTime.Now
    },
    exitCode: 1234
);