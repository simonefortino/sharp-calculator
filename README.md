# Simple calculator app with Avalonia UI

![C#](https://img.shields.io/badge/C%23-.NET%2010.0-blue)
![Framework](https://img.shields.io/badge/UI-AvaloniaUI-purple)
![License](https://img.shields.io/badge/License-MIT-green)

A simple, clean calculator built in C# with Avalonia UI.

## Features
* Standard arithmetic operations (`+`, `-`, `*`, `/`)
* Cross-platform support (Windows and Linux)
* Clean UI with light and dark themes
* Top bar menu for quick actions
* Useful keyboard shortcuts

## Downloads & Installation

In the releases page you can find 4 packages:

* **Windows standard executable (x64)**  
  To execute this release, extract the `.zip` and run the `.exe` file.  
  *Requires [.NET 10.0 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) installed on your PC.*

* **Windows self-contained executable (x64)**  
  This executable can be run without having the .NET Runtime installed.

* <a id="linux-std"></a>**Linux standard executable (x64)**  
  To run this executable, make sure to have [.NET 10.0 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) installed, then run these commands in your terminal (in the folder containing your `.tar.gz`):

```bash
# 1. Extract all the files from the archive
mkdir -p linux-x64-standard && tar -xzvf SharpCalculator-v1.1.0-linux-x64-standard.tar.gz -C linux-x64-standard

# 2. Enter the extracted folder
cd linux-x64-standard

# 3. Give execute permissions
chmod +x SharpCalculator

# 4. Run the executable
./SharpCalculator
```

* **Linux self-contained executable (x64)**  
  Like the Windows self-contained version, you won't need any Runtime installed. Just follow the same steps as the [Linux standard executable](#linux-std) using the self-contained archive name.

---

### Note for Windows Users 

As this is an open-source project without a paid code signing certificate, Windows Defender SmartScreen may display a warning ("Windows protected your PC") when you run the app for the first time.

To start the application:
1. Click on **More info**.
2. Click the **Run anyway** button.

The source code is fully open and can be inspected directly in this repository.  
If you prefer, you can download the code and build the program directly on your own machine using .NET.

---

## Documentation & Changelog
* **Changelog:** To see all changes for past and upcoming releases, check [CHANGELOG.md](CHANGELOG.md).

---

## Credits
* **Icon:** Created by <a href="https://www.flaticon.com/free-icons/calculator" title="calculator icons">Pixel perfect - Flaticon</a>.