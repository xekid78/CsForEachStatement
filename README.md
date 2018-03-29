# CsForEachStatement
forEach文（.NET Core）

## 処理
配列の内容をforEach文を使って出力します。

## コード
```
using System;

namespace Foreach
{
    class Foreach
    {
        static void Main(string[] args)
        {
            string[] team = {"佐藤", "鈴木", "田中", "岸田", "有森"};

            foreach (var name in team)
            {
                Console.WriteLine(name + "さん");
            }
        }
    }
}
```

## 出力結果  
```
佐藤さん
鈴木さん
田中さん
岸田さん
有森さん
```
  
## 開発環境
| 開発ツール |  |
|:-|:-|
| OS | Windows10 |
| 統合開発環境(IDE) | Visual Studio Community 2017 |
| 開発言語 | Visual C# |
