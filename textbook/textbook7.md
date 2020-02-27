[Top](./top.md)  

# ふたつめの画面

このページからは画面遷移を作り始めます。  
まずはこのページで遷移先の画面を作ります。

# SecondPage 画面の追加
**<プロジェクト名>.Shared** プロジェクトに遷移先画面を追加します。  
```ソリューションエクスプローラ > プロジェクト名 > 右クリック > 追加 > 新しい項目 > 空白のページ``` で [ **名前** ] に 「 **SecondPage.xaml** 」と入力、[ **追加** ] ボタンをクリックします。  

**SecondPage.xaml** に一覧で選択された値の表示と、[ **戻る** ] ボタンを追加します。

```xml
      <StackPanel>
        <TextBlock Text="あなたの選択は"/>
        <TextBlock x:Name="textBlock"/>
        <TextBlock Text="ですね"/>
        <Button Content="GoNext" Click="Button_Click_GoBack"/>
      </StackPanel>
```

**SecondPage.xaml** 全体は次のようになります。

```xml
<Page
    x:Class="UnoApp1.Shared.SecondPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:UnoApp1.Shared"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d"
    Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">

    <Grid>
      <StackPanel>
        <TextBlock Text="あなたの選択は"/>
        <TextBlock x:Name="textBlock"/>
        <TextBlock Text="ですね"/>
        <Button Content="GoNext" Click="Button_Click_GoBack"/>
      </StackPanel>
    </Grid>
</Page>
```

**SecondPage.xaml.cs** に前画面で選択された値の表示と、**戻る** 動作を追加します。

```cs
        private void Button_Click_GoBack(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            textBlock.Text = e.Parameter as string;

            base.OnNavigatedTo(e);
        }
```

**SecondPage.xaml.cs** 全体は次のようになります。

```cs
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UnoApp1.Shared
{
    public sealed partial class SecondPage : Page
    {
        public SecondPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click_GoBack(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            textBlock.Text = e.Parameter as string;

            base.OnNavigatedTo(e);
        }
    }
}
```

ふたつめの画面のコードができましたが、実行結果は一旦おあずけです。まずは、ひとつめの画面に画面遷移のコードを追加しなければこの画面を見ることはできません。  

次ページで、ひとつめの画面に画面遷移のコードを追加します。

[< | 前へ](./textbook6.md) | [次へ | >](./textbook8.md)
