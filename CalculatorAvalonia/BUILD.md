# CalculatorAvalonia 跨平台編譯說明

## 編譯成 EXE（Windows）

### 方式 1：單一檔案（推薦）
```bash
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true
```

### 方式 2：包含所有依賴
```bash
dotnet publish -c Release -r win-x64 --self-contained true
```

### 方式 3：框架相依（檔案較小）
```bash
dotnet publish -c Release -r win-x64 --self-contained false
```

編譯後的 exe 檔案位於：`bin/Release/net8.0/win-x64/publish/CalculatorAvalonia.exe`

## 編譯成可執行檔（Linux）

### 方式 1：單一檔案（推薦）
```bash
dotnet publish -c Release -r linux-x64 --self-contained true -p:PublishSingleFile=true
```

### 方式 2：包含所有依賴
```bash
dotnet publish -c Release -r linux-x64 --self-contained true
```

### 方式 3：框架相依（檔案較小）
```bash
dotnet publish -c Release -r linux-x64 --self-contained false
```

編譯後的可執行檔位於：`bin/Release/net8.0/linux-x64/publish/CalculatorAvalonia`

執行前需要設定執行權限：
```bash
chmod +x bin/Release/net8.0/linux-x64/publish/CalculatorAvalonia
```

## 其他平台

### macOS
```bash
dotnet publish -c Release -r osx-x64 --self-contained true -p:PublishSingleFile=true
```

### ARM64 (Linux)
```bash
dotnet publish -c Release -r linux-arm64 --self-contained true -p:PublishSingleFile=true
```

### ARM64 (Windows)
```bash
dotnet publish -c Release -r win-arm64 --self-contained true -p:PublishSingleFile=true
```

## 注意事項

1. **單一檔案模式**：`PublishSingleFile=true` 會將所有依賴打包成一個檔案，但啟動速度可能稍慢
2. **自包含模式**：`--self-contained true` 會包含 .NET 執行時，檔案較大但不需要安裝 .NET
3. **框架相依模式**：`--self-contained false` 需要目標機器安裝 .NET 8.0 Runtime

## 快速編譯腳本

### Windows (PowerShell)
```powershell
# 編譯 Windows 版本
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true

# 編譯 Linux 版本（在 Windows 上交叉編譯）
dotnet publish -c Release -r linux-x64 --self-contained true -p:PublishSingleFile=true
```

### Linux (Bash)
```bash
# 編譯 Linux 版本
dotnet publish -c Release -r linux-x64 --self-contained true -p:PublishSingleFile=true

# 編譯 Windows 版本（在 Linux 上交叉編譯）
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
```
