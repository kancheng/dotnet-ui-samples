# calculator-winforms-avalonia

這是一個對照項目，展示了使用兩種不同的 UI 框架實現的計算機應用程序：
- **WinForms**：使用 Windows Forms 實現
- **Avalonia**：使用 Avalonia UI 框架實現（跨平台）

兩個計算機都支持基本的加減乘除運算。

## 項目結構

```
calculator-winforms-avalonia/
├── CalculatorWinForms/          # WinForms 計算機項目
│   ├── MainForm.cs              # 主表單和計算邏輯
│   ├── Program.cs               # 應用程序入口點
│   └── CalculatorWinForms.csproj
├── CalculatorAvalonia/           # Avalonia 計算機項目
│   ├── MainWindow.axaml         # 主窗口 XAML
│   ├── MainWindow.axaml.cs      # 主窗口代碼和計算邏輯
│   ├── App.axaml                # 應用程序 XAML
│   ├── App.axaml.cs             # 應用程序代碼
│   ├── Program.cs               # 應用程序入口點
│   └── CalculatorAvalonia.csproj
└── Calculator.sln               # Visual Studio 解決方案文件
```

## 前置要求

- .NET 8.0 SDK 或更高版本
- Windows 操作系統（WinForms 需要）
- 對於 Avalonia：支持 Windows、Linux 或 macOS

## 如何執行

### 方法 1：使用 Visual Studio

1. 打開 `Calculator.sln` 解決方案文件
2. 在解決方案資源管理器中，右鍵點擊要運行的項目：
   - `CalculatorWinForms` - 運行 WinForms 版本
   - `CalculatorAvalonia` - 運行 Avalonia 版本
3. 選擇「設為啟動項目」
4. 按 F5 或點擊「開始」按鈕運行

### 方法 2：使用命令行

#### 運行 WinForms 計算機

```bash
cd CalculatorWinForms
dotnet run
```

#### 運行 Avalonia 計算機

```bash
cd CalculatorAvalonia
dotnet run
```

### 方法 3：構建後執行

#### 構建所有項目

```bash
dotnet build Calculator.sln
```

#### 運行 WinForms 版本

```bash
cd CalculatorWinForms\bin\Debug\net8.0-windows
CalculatorWinForms.exe
```

#### 運行 Avalonia 版本

```bash
cd CalculatorAvalonia\bin\Debug\net8.0
CalculatorAvalonia.exe
```

## 功能說明

兩個計算機都提供以下功能：

- **數字輸入**：0-9 數字按鈕
- **基本運算**：加法 (+)、減法 (−)、乘法 (×)、除法 (÷)
- **小數點**：支持小數運算
- **清除功能**：清除當前計算
- **等於運算**：執行計算並顯示結果
- **錯誤處理**：除以零時顯示錯誤提示

## 技術對比

| 特性 | WinForms | Avalonia |
|------|----------|----------|
| 平台支持 | Windows 專用 | 跨平台（Windows、Linux、macOS） |
| UI 定義 | 代碼定義 | XAML + 代碼 |
| 現代化 | 傳統框架 | 現代 UI 框架 |
| 樣式 | 系統原生樣式 | 可自定義主題 |

## 許可證

本項目使用 GNU General Public License v3.0 許可證。