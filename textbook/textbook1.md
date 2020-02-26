[Top](./top.md)  

# 開発環境の整理

開発環境は  
  
- Windows 10
- Visual Studio 2019
- .NET Core 3.1

を用意します。  

## Windows

普通にお手持ちの Windows マシンを用意してください。  
Uno Platform の環境は残念ながら Windows です。mac ではプロジェクトの新規作成ができません。  

#### mac の場合

このリポジトリ内にテンプレートから作成しただけのソリューションを置いてあります。  

- [ソリューション  ディレクトリ](../src/template/UnoApp1/)  

新規作成の手順は飛ばして、このディレクトリに手を加えて行ってください。


## Visual Studio 2019

Visual Studio をインストールします。ダウンロードは [こちら](https://visualstudio.microsoft.com/ja/)。  

## ワークロードの選択

インストール時のワークロードの選択では、次のものを選択します (他のものを追加で選択しても構いません)。

#### Web ＆ クラウド

- ASP[]().NET と Web 開発

#### デスクトップとモバイル

- ユニバーサル Windows プラットフォーム開発
- .NET によるモバイル開発

#### 他のツールセット

- .NET Core クロスプラットフォームの開発

#### 個別のコンポーネント

- Windows 10 SDK (10.0.18362.0)

## 拡張機能

Visual Studio の拡張機能で次のものを選択します。

- Uno Platform Solution Templates

## .NET Core

.NET Core をインストール。ダウンロードは [こちら](https://dotnet.microsoft.com/download)。

## エミュレーターや実機などモバイルの実行環境

**※ Android / iOS で動かしたい場合のみ**  

エミュレーター/シミュレーターの作成や実機の接続など実行環境を整えます。  

- Android Emulator のセットアップ  
https://docs.microsoft.com/ja-jp/xamarin/android/get-started/installation/android-emulator/
- Xamarin.iOS のインストール  
https://docs.microsoft.com/ja-jp/xamarin/ios/get-started/installation/



[< | 前へ](./top.md) | [次へ | >](./textbook2.md)
