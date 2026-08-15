# Simple calculator app with Avalonia UI
This is a simple, clean calculator built in C# with Avalonia UI.


**The icon used for this project is from here:**  
<a href="https://www.flaticon.com/free-icons/calculator" title="calculator icons">Calculator icons created by Pixel perfect - Flaticon</a>

In the release page you can find 4 packages:  
* **Windows standard executable (x64)**  
To execute this release, extract the .zip and click on the .exe file.
You will need [.NET 10.0 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) installed on your PC.
*  **Windows self-contained executable (x64)**  
This executable can be run without having the .NET Runtime installed but it uses a bit more RAM.
* <a id="linux-std"></a>**Linux standard executable (x64)**  
To run this executable, make sure to have [.NET 10.0 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) installed, then paste this commands in the terminal (in the folder containing your .tar.gz):
```bash
# 1. Extract all the files from the archive
tar -xzvf SharpCalculator-v1.0.0-linux-x64-selfcontained.tar.gz

# 2. Enter the extracted folder
cd linux-x64-selfcontained

# 3. Give execute permissions
chmod +x SharpCalculator

# 4. Run the executable
./SharpCalculator
```
* **Linux self-contained executable**  
Like the Windows one, you wont need any Runtime VM installed, just follow the steps for the [Linux standard executable (x64)](#linux-std)


**To see all changes for past and upcoming releases see [CHANGELOG.md](CHANGELOG.md)**