# oxyplotを使うために追加する処理

## NuGet
OxyPlot.Xamarin.Formsを追加

## AppDelegate.cs
「global::Xamarin.Forms.Forms.Init();」の後に「OxyPlot.Xamarin.Forms.Platform.iOS.PlotViewRenderer.Init();」を追加
（ANDROIDを同様に追加）
