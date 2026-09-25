# TH1 - Ghi chu lenh terminal

## Tao project C# Console

Chay cac lenh sau tai thu muc `Lab02/TH1` neu can tao lai project:

```powershell
dotnet new console --name TH1 --framework net8.0
dotnet restore
```

Neu project da ton tai, khong can chay lai `dotnet new`. Mo terminal tai thu muc `Lab02/TH1` bang:

```powershell
cd Lab02/TH1
```

## Cac lenh chay va build

```powershell
# Khoi phuc dependency
dotnet restore

# Build project
dotnet build

# Chay project
dotnet run

# Chay khong build lai
dotnet run --no-build
```

Cac file bai tap hien dang de trong theo yeu cau. Can them mot `Main`/top-level statement vao bai dang chay truoc khi `dotnet build` hoac `dotnet run` thanh cong.

## Tao file IL va PE bang ILDasm / ILAsm

Sau khi project co ma nguon chay duoc, build Release:

```powershell
dotnet build -c Release
```

Tim vi tri cong cu:

```powershell
where.exe ildasm
where.exe ilasm
```

Neu da cai Visual Studio, co the dung duong dan day du den `ildasm.exe` va `ilasm.exe` trong Developer PowerShell/Developer Command Prompt.

Giai ma file PE sang MSIL va luu thanh file `.il`:

```powershell
ildasm .\bin\Release\net8.0\TH1.dll /output=.\TH1.il
```

Lap lai file PE tu MSIL:

```powershell
ilasm .\TH1.il /dll /output=.\TH1_FromIL.dll
```

Neu file dau vao la executable thay vi DLL, bo `/dll` va dung `/exe`:

```powershell
ilasm .\TH1.il /exe /output=.\TH1_FromIL.exe
```

## Luu y

- `ildasm.exe` va `ilasm.exe` thuong di kem .NET SDK/Visual Studio, tuy phien ban cai dat co the nam o thu muc khac nhau.
- Khi chay lenh, thay `net8.0` bang target framework thuc te trong `TH1.csproj` neu can.
- Bai 1 gom phan viet chuong trinh, xuat MSIL bang ILDasm, sau do lap lai PE bang ILAsm.
