# <span style="color:#0ec2b8">_Find And Replace_</span>

#### _ Find And Replac app, 12/10/2020_

#### By _**Nataliya Zhuravleva, Amanda Otero**_

## <span style="color:#0ec2b8">Description</span>

_This is a console app where a user enters a string, chooses a word in that string and provides a replacement for that word._

## <span style="color:#0ec2b8">Setup/Installation Requirements</span>
### <span style="color:#c4f4ef">Open Locally</span>
1. _Navigate to my [Find And Replace repo](https://github.com/mandystar018/FindAndReplace) to view the project files and commits.
2. _Click on the green button labeled "Code"_ to copy repository URL.
3. _Clone the repository to your local machine_ by opening your machine terminal and using the command "git clone https://github.com/mandystar018/FindAndReplace".
4. _Navigate to the folder "/FindAndReplace.Tests"/ModelTests/ to see test files._
5. _Navigate to the folder "/FindAndReplace/Models/" to see C# files_
6. _To use this application you will need to install .NET. Please, see instructions below._

## <span style="color:#0ec2b8">.NET Installation</span> 


### <span style="color:#c4f4ef">Mac</span> 
<p>C# and .NET programming are fully supported on Mac operating systems. We can install .NET and C# on a Mac in a few steps:</p>

1. _Download this [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer) . Clicking this link will prompt a .pkg file download from Microsoft._

2. _Open the file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests._ 

3. _Confirm the installation is successful by opening your terminal and running the command $ dotnet --version. You should see something like this in response: 2.2.105. This means both .NET and C# are successfully installed._

### <span style="color:#c4f4ef">Windows</span> 
Note on Windows Versions
These Windows instructions assume you're using Windows 10. If you currently run Windows 7 or Windows 8, you may have a free upgrade available.

If you are not running Windows 10 (and cannot or do not plan to upgrade), specific installation steps may differ. However, your instructor will be available to assist with personal laptop configurations during the first week of the course.

### Installation Steps
1. _Download either the the 64-bit .NET Core SDK (Software Development Kit). Clicking these links will prompt a .exe file download from Microsoft._

2. _Open the file and follow the steps provided by the installer for your OS._

3. _Confirm the installation is successful by opening a new Windows PowerShell window and running the command dotnet --version. You should see something a response like this (version numbers do not need to be the same): 2.2.105_<br>
_This means .NET and C# are installed and our computer recognizes the dotnet command._

## <span style="color:#0ec2b8">Running Program</span> 
### <span style="color:#c4f4ef">Run Application</span>
<p>You can launch our program with the following steps:</p>

1. _Navigate to the "/FindAndReplace/" folder in the command line._

2. _Run the following command: $ dotnet build_

3. _Finilly, run the following command to execute this compiled code: $ dotnet run_


### <span style="color:#c4f4ef">Run Tests</span> 

 1. _Open Terminal, navigate into the "/FindAndReplace.Tests/" folder in the command line_ 
 2. _Run the following command $"dotnet restore" to retrieve and install the packages we listed in .csproj in our application._
 3. _Then run the following command: $ dotnet test

## <span style="color:#0ec2b8">Known Bugs</span>

_No known bags_

## <span style="color:#0ec2b8">Support and contact details</span>

_If you have any questions, ideas or concerns, please, contact us:_
* _Nataliya Zhuravleva at [natalindria@gmail.com](mailto:natalindria@gmail.com)_
* _Amanda Otero at [mandywebdev@gmail.com](mailto:mandywebdev@gmail.com)_


## <span style="color:#0ec2b8">Technologies Used</span>

* _C#_
* _.NET_
* _VisualStudio Code_
* _Git_
* _GitHub_
* _MSTest_


## <span style="color:#0ec2b8">Specs</span>

<table>
  <tr>
    <th>ID
    <th>Test</th>
    <th>Input</th>
    <th>Output</th>
    <th>Completed</th>
  </tr>
  <tr>
    <td>1</td>
    <td>Should correctly create instance of ChangeWord</td>
    <td>"Hello World, "word" "universe"</td>
    <td>Change newRequest = new ChangeWord("Hello World", "word", "universe")</td>
    <td>True</td>
  </tr>
  <tr>
    <td>2</td>
    <td>Should correctly get sentence from the list</td>
    <td>ChangeWord newRequest = new ChangeWord("Hello World", "world", "universe"); </td>
    <td>newRequest.Sentence="Hello World";</td>
    <td>True</td>
  </tr>
  <tr>
    <td>4</td>
    <td>Should check that sentence contains first word</td>
    <td>string sentence="Hello World";
      string firstWord="world";
      string secondWord="universe";   
      ChangeWord newRequest = new ChangeWord(sentence, firstWord, secondWord);</td>
    <td>newRequest.ReturnSentence="true";</td>
    <td>True</td>
  </tr>
</table>

### <span style="color:#0ec2b8">License</span> 

*This software is licensed under the [MIT](https://choosealicense.com/licenses/mit/) license*

Copyright (c) 2020 **_Nataliya Zhuravleva, Amanda Otero_**
